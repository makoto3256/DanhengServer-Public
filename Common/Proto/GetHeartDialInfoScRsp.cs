// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetHeartDialInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetHeartDialInfoScRsp.proto</summary>
  public static partial class GetHeartDialInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetHeartDialInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetHeartDialInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtHZXRIZWFydERpYWxJbmZvU2NSc3AucHJvdG8aEUdOSE1ESENGQUZMLnBy",
            "b3RvGhFJSVBCTkpNTkZITC5wcm90bxoRQlBHTUJBSkhOSEEucHJvdG8aG0hl",
            "YXJ0RGlhbFVubG9ja1N0YXR1cy5wcm90byK+AQoVR2V0SGVhcnREaWFsSW5m",
            "b1NjUnNwEg8KB3JldGNvZGUYCCABKA0SKwoLUEpKR1BISUNBTEgYDyABKA4y",
            "Fi5IZWFydERpYWxVbmxvY2tTdGF0dXMSIQoLT0ZLTFBIRkhHSUoYByADKAsy",
            "DC5JSVBCTkpNTkZITBIhCgtFSUZOTU1OQUxGSxgCIAMoCzIMLkdOSE1ESENG",
            "QUZMEiEKC0RQTk5HTEtDSENGGA4gAygLMgwuQlBHTUJBSkhOSEFCHqoCG0Vn",
            "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.GNHMDHCFAFLReflection.Descriptor, global::EggLink.DanhengServer.Proto.IIPBNJMNFHLReflection.Descriptor, global::EggLink.DanhengServer.Proto.BPGMBAJHNHAReflection.Descriptor, global::EggLink.DanhengServer.Proto.HeartDialUnlockStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetHeartDialInfoScRsp), global::EggLink.DanhengServer.Proto.GetHeartDialInfoScRsp.Parser, new[]{ "Retcode", "PJJGPHICALH", "OFKLPHFHGIJ", "EIFNMMNALFK", "DPNNGLKCHCF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetHeartDialInfoScRsp : pb::IMessage<GetHeartDialInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetHeartDialInfoScRsp> _parser = new pb::MessageParser<GetHeartDialInfoScRsp>(() => new GetHeartDialInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetHeartDialInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetHeartDialInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetHeartDialInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetHeartDialInfoScRsp(GetHeartDialInfoScRsp other) : this() {
      retcode_ = other.retcode_;
      pJJGPHICALH_ = other.pJJGPHICALH_;
      oFKLPHFHGIJ_ = other.oFKLPHFHGIJ_.Clone();
      eIFNMMNALFK_ = other.eIFNMMNALFK_.Clone();
      dPNNGLKCHCF_ = other.dPNNGLKCHCF_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetHeartDialInfoScRsp Clone() {
      return new GetHeartDialInfoScRsp(this);
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

    /// <summary>Field number for the "PJJGPHICALH" field.</summary>
    public const int PJJGPHICALHFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus pJJGPHICALH_ = global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus.Lock;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus PJJGPHICALH {
      get { return pJJGPHICALH_; }
      set {
        pJJGPHICALH_ = value;
      }
    }

    /// <summary>Field number for the "OFKLPHFHGIJ" field.</summary>
    public const int OFKLPHFHGIJFieldNumber = 7;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.IIPBNJMNFHL> _repeated_oFKLPHFHGIJ_codec
        = pb::FieldCodec.ForMessage(58, global::EggLink.DanhengServer.Proto.IIPBNJMNFHL.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.IIPBNJMNFHL> oFKLPHFHGIJ_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.IIPBNJMNFHL>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.IIPBNJMNFHL> OFKLPHFHGIJ {
      get { return oFKLPHFHGIJ_; }
    }

    /// <summary>Field number for the "EIFNMMNALFK" field.</summary>
    public const int EIFNMMNALFKFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.GNHMDHCFAFL> _repeated_eIFNMMNALFK_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.GNHMDHCFAFL.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GNHMDHCFAFL> eIFNMMNALFK_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GNHMDHCFAFL>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GNHMDHCFAFL> EIFNMMNALFK {
      get { return eIFNMMNALFK_; }
    }

    /// <summary>Field number for the "DPNNGLKCHCF" field.</summary>
    public const int DPNNGLKCHCFFieldNumber = 14;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BPGMBAJHNHA> _repeated_dPNNGLKCHCF_codec
        = pb::FieldCodec.ForMessage(114, global::EggLink.DanhengServer.Proto.BPGMBAJHNHA.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BPGMBAJHNHA> dPNNGLKCHCF_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BPGMBAJHNHA>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BPGMBAJHNHA> DPNNGLKCHCF {
      get { return dPNNGLKCHCF_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetHeartDialInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetHeartDialInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (PJJGPHICALH != other.PJJGPHICALH) return false;
      if(!oFKLPHFHGIJ_.Equals(other.oFKLPHFHGIJ_)) return false;
      if(!eIFNMMNALFK_.Equals(other.eIFNMMNALFK_)) return false;
      if(!dPNNGLKCHCF_.Equals(other.dPNNGLKCHCF_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (PJJGPHICALH != global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus.Lock) hash ^= PJJGPHICALH.GetHashCode();
      hash ^= oFKLPHFHGIJ_.GetHashCode();
      hash ^= eIFNMMNALFK_.GetHashCode();
      hash ^= dPNNGLKCHCF_.GetHashCode();
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
      eIFNMMNALFK_.WriteTo(output, _repeated_eIFNMMNALFK_codec);
      oFKLPHFHGIJ_.WriteTo(output, _repeated_oFKLPHFHGIJ_codec);
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Retcode);
      }
      dPNNGLKCHCF_.WriteTo(output, _repeated_dPNNGLKCHCF_codec);
      if (PJJGPHICALH != global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus.Lock) {
        output.WriteRawTag(120);
        output.WriteEnum((int) PJJGPHICALH);
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
      eIFNMMNALFK_.WriteTo(ref output, _repeated_eIFNMMNALFK_codec);
      oFKLPHFHGIJ_.WriteTo(ref output, _repeated_oFKLPHFHGIJ_codec);
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Retcode);
      }
      dPNNGLKCHCF_.WriteTo(ref output, _repeated_dPNNGLKCHCF_codec);
      if (PJJGPHICALH != global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus.Lock) {
        output.WriteRawTag(120);
        output.WriteEnum((int) PJJGPHICALH);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (PJJGPHICALH != global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus.Lock) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PJJGPHICALH);
      }
      size += oFKLPHFHGIJ_.CalculateSize(_repeated_oFKLPHFHGIJ_codec);
      size += eIFNMMNALFK_.CalculateSize(_repeated_eIFNMMNALFK_codec);
      size += dPNNGLKCHCF_.CalculateSize(_repeated_dPNNGLKCHCF_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetHeartDialInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.PJJGPHICALH != global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus.Lock) {
        PJJGPHICALH = other.PJJGPHICALH;
      }
      oFKLPHFHGIJ_.Add(other.oFKLPHFHGIJ_);
      eIFNMMNALFK_.Add(other.eIFNMMNALFK_);
      dPNNGLKCHCF_.Add(other.dPNNGLKCHCF_);
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
          case 18: {
            eIFNMMNALFK_.AddEntriesFrom(input, _repeated_eIFNMMNALFK_codec);
            break;
          }
          case 58: {
            oFKLPHFHGIJ_.AddEntriesFrom(input, _repeated_oFKLPHFHGIJ_codec);
            break;
          }
          case 64: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 114: {
            dPNNGLKCHCF_.AddEntriesFrom(input, _repeated_dPNNGLKCHCF_codec);
            break;
          }
          case 120: {
            PJJGPHICALH = (global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus) input.ReadEnum();
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
          case 18: {
            eIFNMMNALFK_.AddEntriesFrom(ref input, _repeated_eIFNMMNALFK_codec);
            break;
          }
          case 58: {
            oFKLPHFHGIJ_.AddEntriesFrom(ref input, _repeated_oFKLPHFHGIJ_codec);
            break;
          }
          case 64: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 114: {
            dPNNGLKCHCF_.AddEntriesFrom(ref input, _repeated_dPNNGLKCHCF_codec);
            break;
          }
          case 120: {
            PJJGPHICALH = (global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus) input.ReadEnum();
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
