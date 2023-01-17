// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: meshtastic/channel.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Meshtastic.Protobufs {

  /// <summary>Holder for reflection information generated from meshtastic/channel.proto</summary>
  public static partial class ChannelReflection {

    #region Descriptor
    /// <summary>File descriptor for meshtastic/channel.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChannelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhtZXNodGFzdGljL2NoYW5uZWwucHJvdG8SCm1lc2h0YXN0aWMigwEKD0No",
            "YW5uZWxTZXR0aW5ncxIXCgtjaGFubmVsX251bRgBIAEoDUICGAESCwoDcHNr",
            "GAIgASgMEgwKBG5hbWUYAyABKAkSCgoCaWQYBCABKAcSFgoOdXBsaW5rX2Vu",
            "YWJsZWQYBSABKAgSGAoQZG93bmxpbmtfZW5hYmxlZBgGIAEoCCKhAQoHQ2hh",
            "bm5lbBINCgVpbmRleBgBIAEoBRItCghzZXR0aW5ncxgCIAEoCzIbLm1lc2h0",
            "YXN0aWMuQ2hhbm5lbFNldHRpbmdzEiYKBHJvbGUYAyABKA4yGC5tZXNodGFz",
            "dGljLkNoYW5uZWwuUm9sZSIwCgRSb2xlEgwKCERJU0FCTEVEEAASCwoHUFJJ",
            "TUFSWRABEg0KCVNFQ09OREFSWRACQmEKE2NvbS5nZWVrc3ZpbGxlLm1lc2hC",
            "DUNoYW5uZWxQcm90b3NIA1oiZ2l0aHViLmNvbS9tZXNodGFzdGljL2dvL2dl",
            "bmVyYXRlZKoCFE1lc2h0YXN0aWMuUHJvdG9idWZzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Meshtastic.Protobufs.ChannelSettings), global::Meshtastic.Protobufs.ChannelSettings.Parser, new[]{ "ChannelNum", "Psk", "Name", "Id", "UplinkEnabled", "DownlinkEnabled" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Meshtastic.Protobufs.Channel), global::Meshtastic.Protobufs.Channel.Parser, new[]{ "Index", "Settings", "Role" }, null, new[]{ typeof(global::Meshtastic.Protobufs.Channel.Types.Role) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///
  /// Full settings (center freq, spread factor, pre-shared secret key etc...)
  /// needed to configure a radio for speaking on a particular channel This
  /// information can be encoded as a QRcode/url so that other users can configure
  /// their radio to join the same channel.
  /// A note about how channel names are shown to users: channelname-Xy
  /// poundsymbol is a prefix used to indicate this is a channel name (idea from @professr).
  /// Where X is a letter from A-Z (base 26) representing a hash of the PSK for this
  /// channel - so that if the user changes anything about the channel (which does
  /// force a new PSK) this letter will also change. Thus preventing user confusion if
  /// two friends try to type in a channel name of "BobsChan" and then can't talk
  /// because their PSKs will be different.
  /// The PSK is hashed into this letter by "0x41 + [xor all bytes of the psk ] modulo 26"
  /// This also allows the option of someday if people have the PSK off (zero), the
  /// users COULD type in a channel name and be able to talk.
  /// Y is a lower case letter from a-z that represents the channel 'speed' settings
  /// (for some future definition of speed)
  /// FIXME: Add description of multi-channel support and how primary vs secondary channels are used.
  /// FIXME: explain how apps use channels for security.
  /// explain how remote settings and remote gpio are managed as an example
  /// </summary>
  public sealed partial class ChannelSettings : pb::IMessage<ChannelSettings>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChannelSettings> _parser = new pb::MessageParser<ChannelSettings>(() => new ChannelSettings());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChannelSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Meshtastic.Protobufs.ChannelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelSettings(ChannelSettings other) : this() {
      channelNum_ = other.channelNum_;
      psk_ = other.psk_;
      name_ = other.name_;
      id_ = other.id_;
      uplinkEnabled_ = other.uplinkEnabled_;
      downlinkEnabled_ = other.downlinkEnabled_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChannelSettings Clone() {
      return new ChannelSettings(this);
    }

    /// <summary>Field number for the "channel_num" field.</summary>
    public const int ChannelNumFieldNumber = 1;
    private uint channelNum_;
    /// <summary>
    ///
    /// Deprecated in favor of LoraConfig.channel_num
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChannelNum {
      get { return channelNum_; }
      set {
        channelNum_ = value;
      }
    }

    /// <summary>Field number for the "psk" field.</summary>
    public const int PskFieldNumber = 2;
    private pb::ByteString psk_ = pb::ByteString.Empty;
    /// <summary>
    ///
    /// A simple pre-shared key for now for crypto.
    /// Must be either 0 bytes (no crypto), 16 bytes (AES128), or 32 bytes (AES256).
    /// A special shorthand is used for 1 byte long psks.
    /// These psks should be treated as only minimally secure,
    /// because they are listed in this source code.
    /// Those bytes are mapped using the following scheme:
    /// `0` = No crypto
    /// `1` = The special "default" channel key: {0xd4, 0xf1, 0xbb, 0x3a, 0x20, 0x29, 0x07, 0x59, 0xf0, 0xbc, 0xff, 0xab, 0xcf, 0x4e, 0x69, 0xbf}
    /// `2` through 10 = The default channel key, except with 1 through 9 added to the last byte.
    /// Shown to user as simple1 through 10
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Psk {
      get { return psk_; }
      set {
        psk_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    /// <summary>
    ///
    /// A SHORT name that will be packed into the URL.
    /// Less than 12 bytes.
    /// Something for end users to call the channel
    /// If this is the empty string it is assumed that this channel
    /// is the special (minimally secure) "Default"channel.
    /// In user interfaces it should be rendered as a local language translation of "X".
    /// For channel_num hashing empty string will be treated as "X".
    /// Where "X" is selected based on the English words listed above for ModemPreset
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 4;
    private uint id_;
    /// <summary>
    ///
    /// Used to construct a globally unique channel ID.
    /// The full globally unique ID will be: "name.id" where ID is shown as base36.
    /// Assuming that the number of meshtastic users is below 20K (true for a long time)
    /// the chance of this 64 bit random number colliding with anyone else is super low.
    /// And the penalty for collision is low as well, it just means that anyone trying to decrypt channel messages might need to
    /// try multiple candidate channels.
    /// Any time a non wire compatible change is made to a channel, this field should be regenerated.
    /// There are a small number of 'special' globally known (and fairly) insecure standard channels.
    /// Those channels do not have a numeric id included in the settings, but instead it is pulled from
    /// a table of well known IDs.
    /// (see Well Known Channels FIXME)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "uplink_enabled" field.</summary>
    public const int UplinkEnabledFieldNumber = 5;
    private bool uplinkEnabled_;
    /// <summary>
    ///
    /// If true, messages on the mesh will be sent to the *public* internet by any gateway ndoe
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool UplinkEnabled {
      get { return uplinkEnabled_; }
      set {
        uplinkEnabled_ = value;
      }
    }

    /// <summary>Field number for the "downlink_enabled" field.</summary>
    public const int DownlinkEnabledFieldNumber = 6;
    private bool downlinkEnabled_;
    /// <summary>
    ///
    /// If true, messages seen on the internet will be forwarded to the local mesh.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool DownlinkEnabled {
      get { return downlinkEnabled_; }
      set {
        downlinkEnabled_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChannelSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChannelSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChannelNum != other.ChannelNum) return false;
      if (Psk != other.Psk) return false;
      if (Name != other.Name) return false;
      if (Id != other.Id) return false;
      if (UplinkEnabled != other.UplinkEnabled) return false;
      if (DownlinkEnabled != other.DownlinkEnabled) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChannelNum != 0) hash ^= ChannelNum.GetHashCode();
      if (Psk.Length != 0) hash ^= Psk.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (UplinkEnabled != false) hash ^= UplinkEnabled.GetHashCode();
      if (DownlinkEnabled != false) hash ^= DownlinkEnabled.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ChannelNum != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChannelNum);
      }
      if (Psk.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Psk);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (Id != 0) {
        output.WriteRawTag(37);
        output.WriteFixed32(Id);
      }
      if (UplinkEnabled != false) {
        output.WriteRawTag(40);
        output.WriteBool(UplinkEnabled);
      }
      if (DownlinkEnabled != false) {
        output.WriteRawTag(48);
        output.WriteBool(DownlinkEnabled);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ChannelNum != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChannelNum);
      }
      if (Psk.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Psk);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (Id != 0) {
        output.WriteRawTag(37);
        output.WriteFixed32(Id);
      }
      if (UplinkEnabled != false) {
        output.WriteRawTag(40);
        output.WriteBool(UplinkEnabled);
      }
      if (DownlinkEnabled != false) {
        output.WriteRawTag(48);
        output.WriteBool(DownlinkEnabled);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ChannelNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChannelNum);
      }
      if (Psk.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Psk);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Id != 0) {
        size += 1 + 4;
      }
      if (UplinkEnabled != false) {
        size += 1 + 1;
      }
      if (DownlinkEnabled != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChannelSettings other) {
      if (other == null) {
        return;
      }
      if (other.ChannelNum != 0) {
        ChannelNum = other.ChannelNum;
      }
      if (other.Psk.Length != 0) {
        Psk = other.Psk;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.UplinkEnabled != false) {
        UplinkEnabled = other.UplinkEnabled;
      }
      if (other.DownlinkEnabled != false) {
        DownlinkEnabled = other.DownlinkEnabled;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ChannelNum = input.ReadUInt32();
            break;
          }
          case 18: {
            Psk = input.ReadBytes();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 37: {
            Id = input.ReadFixed32();
            break;
          }
          case 40: {
            UplinkEnabled = input.ReadBool();
            break;
          }
          case 48: {
            DownlinkEnabled = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ChannelNum = input.ReadUInt32();
            break;
          }
          case 18: {
            Psk = input.ReadBytes();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 37: {
            Id = input.ReadFixed32();
            break;
          }
          case 40: {
            UplinkEnabled = input.ReadBool();
            break;
          }
          case 48: {
            DownlinkEnabled = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  ///
  /// A pair of a channel number, mode and the (sharable) settings for that channel
  /// </summary>
  public sealed partial class Channel : pb::IMessage<Channel>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Channel> _parser = new pb::MessageParser<Channel>(() => new Channel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Channel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Meshtastic.Protobufs.ChannelReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Channel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Channel(Channel other) : this() {
      index_ = other.index_;
      settings_ = other.settings_ != null ? other.settings_.Clone() : null;
      role_ = other.role_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Channel Clone() {
      return new Channel(this);
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 1;
    private int index_;
    /// <summary>
    ///
    /// The index of this channel in the channel table (from 0 to MAX_NUM_CHANNELS-1)
    /// (Someday - not currently implemented) An index of -1 could be used to mean "set by name",
    /// in which case the target node will find and set the channel by settings.name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    /// <summary>Field number for the "settings" field.</summary>
    public const int SettingsFieldNumber = 2;
    private global::Meshtastic.Protobufs.ChannelSettings settings_;
    /// <summary>
    ///
    /// The new settings, or NULL to disable that channel
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Meshtastic.Protobufs.ChannelSettings Settings {
      get { return settings_; }
      set {
        settings_ = value;
      }
    }

    /// <summary>Field number for the "role" field.</summary>
    public const int RoleFieldNumber = 3;
    private global::Meshtastic.Protobufs.Channel.Types.Role role_ = global::Meshtastic.Protobufs.Channel.Types.Role.Disabled;
    /// <summary>
    ///
    /// TODO: REPLACE
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Meshtastic.Protobufs.Channel.Types.Role Role {
      get { return role_; }
      set {
        role_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Channel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Channel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Index != other.Index) return false;
      if (!object.Equals(Settings, other.Settings)) return false;
      if (Role != other.Role) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Index != 0) hash ^= Index.GetHashCode();
      if (settings_ != null) hash ^= Settings.GetHashCode();
      if (Role != global::Meshtastic.Protobufs.Channel.Types.Role.Disabled) hash ^= Role.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Index != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Index);
      }
      if (settings_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Settings);
      }
      if (Role != global::Meshtastic.Protobufs.Channel.Types.Role.Disabled) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Role);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Index != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Index);
      }
      if (settings_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Settings);
      }
      if (Role != global::Meshtastic.Protobufs.Channel.Types.Role.Disabled) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Role);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Index);
      }
      if (settings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Settings);
      }
      if (Role != global::Meshtastic.Protobufs.Channel.Types.Role.Disabled) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Role);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Channel other) {
      if (other == null) {
        return;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
      if (other.settings_ != null) {
        if (settings_ == null) {
          Settings = new global::Meshtastic.Protobufs.ChannelSettings();
        }
        Settings.MergeFrom(other.Settings);
      }
      if (other.Role != global::Meshtastic.Protobufs.Channel.Types.Role.Disabled) {
        Role = other.Role;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Index = input.ReadInt32();
            break;
          }
          case 18: {
            if (settings_ == null) {
              Settings = new global::Meshtastic.Protobufs.ChannelSettings();
            }
            input.ReadMessage(Settings);
            break;
          }
          case 24: {
            Role = (global::Meshtastic.Protobufs.Channel.Types.Role) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Index = input.ReadInt32();
            break;
          }
          case 18: {
            if (settings_ == null) {
              Settings = new global::Meshtastic.Protobufs.ChannelSettings();
            }
            input.ReadMessage(Settings);
            break;
          }
          case 24: {
            Role = (global::Meshtastic.Protobufs.Channel.Types.Role) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Channel message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      ///
      /// How this channel is being used (or not).
      /// Note: this field is an enum to give us options for the future.
      /// In particular, someday we might make a 'SCANNING' option.
      /// SCANNING channels could have different frequencies and the radio would
      /// occasionally check that freq to see if anything is being transmitted.
      /// For devices that have multiple physical radios attached, we could keep multiple PRIMARY/SCANNING channels active at once to allow
      /// cross band routing as needed.
      /// If a device has only a single radio (the common case) only one channel can be PRIMARY at a time
      /// (but any number of SECONDARY channels can't be sent received on that common frequency)
      /// </summary>
      public enum Role {
        /// <summary>
        ///
        /// This channel is not in use right now
        /// </summary>
        [pbr::OriginalName("DISABLED")] Disabled = 0,
        /// <summary>
        ///
        /// This channel is used to set the frequency for the radio - all other enabled channels must be SECONDARY
        /// </summary>
        [pbr::OriginalName("PRIMARY")] Primary = 1,
        /// <summary>
        ///
        /// Secondary channels are only used for encryption/decryption/authentication purposes.
        /// Their radio settings (freq etc) are ignored, only psk is used.
        /// </summary>
        [pbr::OriginalName("SECONDARY")] Secondary = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
