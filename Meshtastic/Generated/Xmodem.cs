// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: meshtastic/xmodem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Meshtastic.Protobufs {

  /// <summary>Holder for reflection information generated from meshtastic/xmodem.proto</summary>
  public static partial class XmodemReflection {

    #region Descriptor
    /// <summary>File descriptor for meshtastic/xmodem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static XmodemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdtZXNodGFzdGljL3htb2RlbS5wcm90bxIKbWVzaHRhc3RpYyK2AQoGWE1v",
            "ZGVtEisKB2NvbnRyb2wYASABKA4yGi5tZXNodGFzdGljLlhNb2RlbS5Db250",
            "cm9sEgsKA3NlcRgCIAEoDRINCgVjcmMxNhgDIAEoDRIOCgZidWZmZXIYBCAB",
            "KAwiUwoHQ29udHJvbBIHCgNOVUwQABIHCgNTT0gQARIHCgNTVFgQAhIHCgNF",
            "T1QQBBIHCgNBQ0sQBhIHCgNOQUsQFRIHCgNDQU4QGBIJCgVDVFJMWhAaQmAK",
            "E2NvbS5nZWVrc3ZpbGxlLm1lc2hCDFhtb2RlbVByb3Rvc0gDWiJnaXRodWIu",
            "Y29tL21lc2h0YXN0aWMvZ28vZ2VuZXJhdGVkqgIUTWVzaHRhc3RpYy5Qcm90",
            "b2J1ZnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Meshtastic.Protobufs.XModem), global::Meshtastic.Protobufs.XModem.Parser, new[]{ "Control", "Seq", "Crc16", "Buffer" }, null, new[]{ typeof(global::Meshtastic.Protobufs.XModem.Types.Control) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class XModem : pb::IMessage<XModem>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<XModem> _parser = new pb::MessageParser<XModem>(() => new XModem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<XModem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Meshtastic.Protobufs.XmodemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public XModem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public XModem(XModem other) : this() {
      control_ = other.control_;
      seq_ = other.seq_;
      crc16_ = other.crc16_;
      buffer_ = other.buffer_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public XModem Clone() {
      return new XModem(this);
    }

    /// <summary>Field number for the "control" field.</summary>
    public const int ControlFieldNumber = 1;
    private global::Meshtastic.Protobufs.XModem.Types.Control control_ = global::Meshtastic.Protobufs.XModem.Types.Control.Nul;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Meshtastic.Protobufs.XModem.Types.Control Control {
      get { return control_; }
      set {
        control_ = value;
      }
    }

    /// <summary>Field number for the "seq" field.</summary>
    public const int SeqFieldNumber = 2;
    private uint seq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Seq {
      get { return seq_; }
      set {
        seq_ = value;
      }
    }

    /// <summary>Field number for the "crc16" field.</summary>
    public const int Crc16FieldNumber = 3;
    private uint crc16_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Crc16 {
      get { return crc16_; }
      set {
        crc16_ = value;
      }
    }

    /// <summary>Field number for the "buffer" field.</summary>
    public const int BufferFieldNumber = 4;
    private pb::ByteString buffer_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Buffer {
      get { return buffer_; }
      set {
        buffer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as XModem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(XModem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Control != other.Control) return false;
      if (Seq != other.Seq) return false;
      if (Crc16 != other.Crc16) return false;
      if (Buffer != other.Buffer) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Control != global::Meshtastic.Protobufs.XModem.Types.Control.Nul) hash ^= Control.GetHashCode();
      if (Seq != 0) hash ^= Seq.GetHashCode();
      if (Crc16 != 0) hash ^= Crc16.GetHashCode();
      if (Buffer.Length != 0) hash ^= Buffer.GetHashCode();
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
      if (Control != global::Meshtastic.Protobufs.XModem.Types.Control.Nul) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Control);
      }
      if (Seq != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Seq);
      }
      if (Crc16 != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Crc16);
      }
      if (Buffer.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Buffer);
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
      if (Control != global::Meshtastic.Protobufs.XModem.Types.Control.Nul) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Control);
      }
      if (Seq != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Seq);
      }
      if (Crc16 != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Crc16);
      }
      if (Buffer.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Buffer);
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
      if (Control != global::Meshtastic.Protobufs.XModem.Types.Control.Nul) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Control);
      }
      if (Seq != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Seq);
      }
      if (Crc16 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Crc16);
      }
      if (Buffer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Buffer);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(XModem other) {
      if (other == null) {
        return;
      }
      if (other.Control != global::Meshtastic.Protobufs.XModem.Types.Control.Nul) {
        Control = other.Control;
      }
      if (other.Seq != 0) {
        Seq = other.Seq;
      }
      if (other.Crc16 != 0) {
        Crc16 = other.Crc16;
      }
      if (other.Buffer.Length != 0) {
        Buffer = other.Buffer;
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
            Control = (global::Meshtastic.Protobufs.XModem.Types.Control) input.ReadEnum();
            break;
          }
          case 16: {
            Seq = input.ReadUInt32();
            break;
          }
          case 24: {
            Crc16 = input.ReadUInt32();
            break;
          }
          case 34: {
            Buffer = input.ReadBytes();
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
            Control = (global::Meshtastic.Protobufs.XModem.Types.Control) input.ReadEnum();
            break;
          }
          case 16: {
            Seq = input.ReadUInt32();
            break;
          }
          case 24: {
            Crc16 = input.ReadUInt32();
            break;
          }
          case 34: {
            Buffer = input.ReadBytes();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the XModem message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum Control {
        [pbr::OriginalName("NUL")] Nul = 0,
        [pbr::OriginalName("SOH")] Soh = 1,
        [pbr::OriginalName("STX")] Stx = 2,
        [pbr::OriginalName("EOT")] Eot = 4,
        [pbr::OriginalName("ACK")] Ack = 6,
        [pbr::OriginalName("NAK")] Nak = 21,
        [pbr::OriginalName("CAN")] Can = 24,
        [pbr::OriginalName("CTRLZ")] Ctrlz = 26,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
