// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetFriendLoginInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetFriendLoginInfoScRsp.proto</summary>
  public static partial class GetFriendLoginInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetFriendLoginInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetFriendLoginInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1HZXRGcmllbmRMb2dpbkluZm9TY1JzcC5wcm90byJ+ChdHZXRGcmllbmRM",
            "b2dpbkluZm9TY1JzcBITCgtISkRGRUNLRUNGSxgPIAEoCBITCgtGTUVNTkdK",
            "SE1IQRgHIAMoDRITCgtJTUhCQ09FUEZFSBgDIAEoCBITCgtJSUFDQ0xBRkhO",
            "QxgLIAMoDRIPCgdyZXRjb2RlGAggASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetFriendLoginInfoScRsp), global::EggLink.DanhengServer.Proto.GetFriendLoginInfoScRsp.Parser, new[]{ "HJDFECKECFK", "FMEMNGJHMHA", "IMHBCOEPFEH", "IIACCLAFHNC", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetFriendLoginInfoScRsp : pb::IMessage<GetFriendLoginInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetFriendLoginInfoScRsp> _parser = new pb::MessageParser<GetFriendLoginInfoScRsp>(() => new GetFriendLoginInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetFriendLoginInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetFriendLoginInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFriendLoginInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFriendLoginInfoScRsp(GetFriendLoginInfoScRsp other) : this() {
      hJDFECKECFK_ = other.hJDFECKECFK_;
      fMEMNGJHMHA_ = other.fMEMNGJHMHA_.Clone();
      iMHBCOEPFEH_ = other.iMHBCOEPFEH_;
      iIACCLAFHNC_ = other.iIACCLAFHNC_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetFriendLoginInfoScRsp Clone() {
      return new GetFriendLoginInfoScRsp(this);
    }

    /// <summary>Field number for the "HJDFECKECFK" field.</summary>
    public const int HJDFECKECFKFieldNumber = 15;
    private bool hJDFECKECFK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HJDFECKECFK {
      get { return hJDFECKECFK_; }
      set {
        hJDFECKECFK_ = value;
      }
    }

    /// <summary>Field number for the "FMEMNGJHMHA" field.</summary>
    public const int FMEMNGJHMHAFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_fMEMNGJHMHA_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> fMEMNGJHMHA_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FMEMNGJHMHA {
      get { return fMEMNGJHMHA_; }
    }

    /// <summary>Field number for the "IMHBCOEPFEH" field.</summary>
    public const int IMHBCOEPFEHFieldNumber = 3;
    private bool iMHBCOEPFEH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IMHBCOEPFEH {
      get { return iMHBCOEPFEH_; }
      set {
        iMHBCOEPFEH_ = value;
      }
    }

    /// <summary>Field number for the "IIACCLAFHNC" field.</summary>
    public const int IIACCLAFHNCFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_iIACCLAFHNC_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> iIACCLAFHNC_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> IIACCLAFHNC {
      get { return iIACCLAFHNC_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 8;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetFriendLoginInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetFriendLoginInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HJDFECKECFK != other.HJDFECKECFK) return false;
      if(!fMEMNGJHMHA_.Equals(other.fMEMNGJHMHA_)) return false;
      if (IMHBCOEPFEH != other.IMHBCOEPFEH) return false;
      if(!iIACCLAFHNC_.Equals(other.iIACCLAFHNC_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HJDFECKECFK != false) hash ^= HJDFECKECFK.GetHashCode();
      hash ^= fMEMNGJHMHA_.GetHashCode();
      if (IMHBCOEPFEH != false) hash ^= IMHBCOEPFEH.GetHashCode();
      hash ^= iIACCLAFHNC_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (IMHBCOEPFEH != false) {
        output.WriteRawTag(24);
        output.WriteBool(IMHBCOEPFEH);
      }
      fMEMNGJHMHA_.WriteTo(output, _repeated_fMEMNGJHMHA_codec);
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Retcode);
      }
      iIACCLAFHNC_.WriteTo(output, _repeated_iIACCLAFHNC_codec);
      if (HJDFECKECFK != false) {
        output.WriteRawTag(120);
        output.WriteBool(HJDFECKECFK);
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
      if (IMHBCOEPFEH != false) {
        output.WriteRawTag(24);
        output.WriteBool(IMHBCOEPFEH);
      }
      fMEMNGJHMHA_.WriteTo(ref output, _repeated_fMEMNGJHMHA_codec);
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Retcode);
      }
      iIACCLAFHNC_.WriteTo(ref output, _repeated_iIACCLAFHNC_codec);
      if (HJDFECKECFK != false) {
        output.WriteRawTag(120);
        output.WriteBool(HJDFECKECFK);
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
      if (HJDFECKECFK != false) {
        size += 1 + 1;
      }
      size += fMEMNGJHMHA_.CalculateSize(_repeated_fMEMNGJHMHA_codec);
      if (IMHBCOEPFEH != false) {
        size += 1 + 1;
      }
      size += iIACCLAFHNC_.CalculateSize(_repeated_iIACCLAFHNC_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetFriendLoginInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.HJDFECKECFK != false) {
        HJDFECKECFK = other.HJDFECKECFK;
      }
      fMEMNGJHMHA_.Add(other.fMEMNGJHMHA_);
      if (other.IMHBCOEPFEH != false) {
        IMHBCOEPFEH = other.IMHBCOEPFEH;
      }
      iIACCLAFHNC_.Add(other.iIACCLAFHNC_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 24: {
            IMHBCOEPFEH = input.ReadBool();
            break;
          }
          case 58:
          case 56: {
            fMEMNGJHMHA_.AddEntriesFrom(input, _repeated_fMEMNGJHMHA_codec);
            break;
          }
          case 64: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            iIACCLAFHNC_.AddEntriesFrom(input, _repeated_iIACCLAFHNC_codec);
            break;
          }
          case 120: {
            HJDFECKECFK = input.ReadBool();
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
          case 24: {
            IMHBCOEPFEH = input.ReadBool();
            break;
          }
          case 58:
          case 56: {
            fMEMNGJHMHA_.AddEntriesFrom(ref input, _repeated_fMEMNGJHMHA_codec);
            break;
          }
          case 64: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            iIACCLAFHNC_.AddEntriesFrom(ref input, _repeated_iIACCLAFHNC_codec);
            break;
          }
          case 120: {
            HJDFECKECFK = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
