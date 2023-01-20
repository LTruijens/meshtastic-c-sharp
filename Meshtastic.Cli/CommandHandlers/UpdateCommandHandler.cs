﻿using Meshtastic.Cli.Mappings;
using Meshtastic.Cli.Utilities;
using Meshtastic.Data;
using Meshtastic.Data.MessageFactories;
using Meshtastic.Protobufs;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using static SimpleExec.Command;

namespace Meshtastic.Cli.CommandHandlers;

[ExcludeFromCodeCoverage(Justification = "Requires interaction")]
public class UpdateCommandHandler : DeviceCommandHandler
{
    public UpdateCommandHandler(FirmwarePackageService firmwarePackageService, ReleaseZipService releaseZipService, DeviceConnectionContext context, CommandContext commandContext)
        : base(context, commandContext)
    {
        this.firmwarePackageService = firmwarePackageService;
        this.releaseZipService = releaseZipService;
    }

    private DeviceStateContainer? deviceStateContainer;
    private readonly FirmwarePackageService firmwarePackageService;
    private readonly ReleaseZipService releaseZipService;

    public async Task Handle()
    {
        var wantConfig = new ToRadioMessageFactory().CreateWantConfigMessage();
        await Connection.WriteToRadio(wantConfig, CompleteOnConfigReceived);
        Connection.Disconnect();
        var hardwareModel = deviceStateContainer!.Nodes.First(n => n.Num == deviceStateContainer.MyNodeInfo.MyNodeNum).User.HwModel;
        await StartInteractiveFlashUpdate(hardwareModel);
    }

    private async Task StartInteractiveFlashUpdate(HardwareModel hardwareModel)
    {
        var releaseOptions = await firmwarePackageService.GetFirmwareReleases();
        var selection = GetFirmwareSelection(releaseOptions, "Which release or pull-request?");
        var release = AnsiConsole.Prompt(selection);
        var memoryStream = await firmwarePackageService.DownloadRelease(release);
        var filePath = await releaseZipService.ExtractUpdateBinary(memoryStream, hardwareModel);

        if (HardwareModelMappings.NrfHardwareModels.Contains(hardwareModel))
        {
            var drive = GetSelectedDrive();
            await Uf2Update(drive, filePath);
        }
        else
        {
            EsptoolUpdate(filePath, ConnectionContext.Port!);
        }
    }

    private static async Task Uf2Update(string drive, string uf2Path)
    {
        AnsiConsole.WriteLine($"Copying uf2 file to {drive}");
        await RunAsync("cp", uf2Path);
        AnsiConsole.WriteLine($"Copying complete");
    }

    private static void EsptoolUpdate(string binPath, string port)
    {
        AnsiConsole.Status()
            .Spinner(Spinner.Known.Dots)
            .Start("Flashing", (ctx) =>
        {
            var info = new ProcessStartInfo()
            {
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
            };
            SetEsptoolProcessInfo(info, binPath, port);
            using var process = Process.Start(info);
            process!.OutputDataReceived += (sender, args) => AnsiConsole.WriteLine(args.Data ?? String.Empty);
            process!.ErrorDataReceived += (sender, args) => AnsiConsole.WriteLine(args.Data ?? String.Empty);
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();
            process.Close();
            File.Delete(binPath);
            AnsiConsole.Write("Completed device update!");
        });
    }

    private static void SetEsptoolProcessInfo(ProcessStartInfo processStartInfo, string filePath, string port)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            processStartInfo.FileName = "cmd.exe";
            processStartInfo.Arguments = $"cmd /C \"python -m esptool --baud 921600 write_flash 0x10000 {filePath} -p {port}\"";
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            processStartInfo.FileName = "bash";
            processStartInfo.Arguments = $"python -m esptool --baud 921600 write_flash 0x10000 {filePath} -p {port}";
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            processStartInfo.FileName = "sh";
            processStartInfo.Arguments = $"python -m esptool --baud 921600 write_flash 0x10000 {filePath} -p {port}";
        }
    }

    private static string GetSelectedDrive()
    {
        return AnsiConsole.Prompt(new SelectionPrompt<string>()
            .Title("Which drive?")
            .AddChoices(Directory.GetLogicalDrives()));
    }

    private static SelectionPrompt<FirmwarePackage> GetFirmwareSelection(FirmwarePackageOptions releases, string promptText)
    {
        var selection = new SelectionPrompt<FirmwarePackage>()
            .Title(promptText)
            .PageSize(20)
            .AddChoiceGroup(new FirmwarePackage("Stable", String.Empty), releases.releases.stable)
            .AddChoiceGroup(new FirmwarePackage("Alpha", String.Empty), releases.releases.alpha)
            .AddChoiceGroup(new FirmwarePackage("Pull-requests", String.Empty), releases
                .pullRequests
                .Select(pr => new FirmwarePackage(pr.title.EscapeMarkup(), pr.zip_url)));
        selection.Converter = r => r.title;
        return selection;
    }

    public override Task OnCompleted(FromRadio packet, DeviceStateContainer container)
    {
        deviceStateContainer = container;
        return Task.CompletedTask;
    }
}
