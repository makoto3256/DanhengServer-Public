// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SpaceZooDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SpaceZooDataScRsp.proto</summary>
  public static partial class SpaceZooDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for SpaceZooDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpaceZooDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdTcGFjZVpvb0RhdGFTY1JzcC5wcm90bxoRQ0NHRkNPQkhPQ0oucHJvdG8a",
            "EU1KTkJHRklISkJOLnByb3RvIugBChFTcGFjZVpvb0RhdGFTY1JzcBITCgtI",
            "UENNQ0FMSkhOQRgBIAMoDRIPCgdyZXRjb2RlGA0gASgNEhMKC0dGUE5CRklN",
            "Q0hIGAwgASgNEhMKC0RMSkhGSUpMRkhNGA8gAygNEhMKC01QTURMTk5OREtE",
            "GAggAygNEiEKC0FDRE5JS01ERERJGAogAygLMgwuTUpOQkdGSUhKQk4SEwoL",
            "QkNOSEJJR01LQUoYByADKA0SIQoLSEJNRFBNTUJDREEYCSADKAsyDC5DQ0dG",
            "Q09CSE9DShITCgtIUENEQ0VLTkZHSBgOIAMoDUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CCGFCOBHOCJReflection.Descriptor, global::EggLink.DanhengServer.Proto.MJNBGFIHJBNReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SpaceZooDataScRsp), global::EggLink.DanhengServer.Proto.SpaceZooDataScRsp.Parser, new[]{ "HPCMCALJHNA", "Retcode", "GFPNBFIMCHH", "DLJHFIJLFHM", "MPMDLNNNDKD", "ACDNIKMDDDI", "BCNHBIGMKAJ", "HBMDPMMBCDA", "HPCDCEKNFGH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SpaceZooDataScRsp : pb::IMessage<SpaceZooDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SpaceZooDataScRsp> _parser = new pb::MessageParser<SpaceZooDataScRsp>(() => new SpaceZooDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SpaceZooDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SpaceZooDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooDataScRsp(SpaceZooDataScRsp other) : this() {
      hPCMCALJHNA_ = other.hPCMCALJHNA_.Clone();
      retcode_ = other.retcode_;
      gFPNBFIMCHH_ = other.gFPNBFIMCHH_;
      dLJHFIJLFHM_ = other.dLJHFIJLFHM_.Clone();
      mPMDLNNNDKD_ = other.mPMDLNNNDKD_.Clone();
      aCDNIKMDDDI_ = other.aCDNIKMDDDI_.Clone();
      bCNHBIGMKAJ_ = other.bCNHBIGMKAJ_.Clone();
      hBMDPMMBCDA_ = other.hBMDPMMBCDA_.Clone();
      hPCDCEKNFGH_ = other.hPCDCEKNFGH_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpaceZooDataScRsp Clone() {
      return new SpaceZooDataScRsp(this);
    }

    /// <summary>Field number for the "HPCMCALJHNA" field.</summary>
    public const int HPCMCALJHNAFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_hPCMCALJHNA_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> hPCMCALJHNA_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HPCMCALJHNA {
      get { return hPCMCALJHNA_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 13;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "GFPNBFIMCHH" field.</summary>
    public const int GFPNBFIMCHHFieldNumber = 12;
    private uint gFPNBFIMCHH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GFPNBFIMCHH {
      get { return gFPNBFIMCHH_; }
      set {
        gFPNBFIMCHH_ = value;
      }
    }

    /// <summary>Field number for the "DLJHFIJLFHM" field.</summary>
    public const int DLJHFIJLFHMFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_dLJHFIJLFHM_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> dLJHFIJLFHM_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> DLJHFIJLFHM {
      get { return dLJHFIJLFHM_; }
    }

    /// <summary>Field number for the "MPMDLNNNDKD" field.</summary>
    public const int MPMDLNNNDKDFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_mPMDLNNNDKD_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> mPMDLNNNDKD_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> MPMDLNNNDKD {
      get { return mPMDLNNNDKD_; }
    }

    /// <summary>Field number for the "ACDNIKMDDDI" field.</summary>
    public const int ACDNIKMDDDIFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MJNBGFIHJBN> _repeated_aCDNIKMDDDI_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.MJNBGFIHJBN.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MJNBGFIHJBN> aCDNIKMDDDI_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MJNBGFIHJBN>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MJNBGFIHJBN> ACDNIKMDDDI {
      get { return aCDNIKMDDDI_; }
    }

    /// <summary>Field number for the "BCNHBIGMKAJ" field.</summary>
    public const int BCNHBIGMKAJFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_bCNHBIGMKAJ_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> bCNHBIGMKAJ_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BCNHBIGMKAJ {
      get { return bCNHBIGMKAJ_; }
    }

    /// <summary>Field number for the "HBMDPMMBCDA" field.</summary>
    public const int HBMDPMMBCDAFieldNumber = 9;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.CCGFCOBHOCJ> _repeated_hBMDPMMBCDA_codec
        = pb::FieldCodec.ForMessage(74, global::EggLink.DanhengServer.Proto.CCGFCOBHOCJ.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CCGFCOBHOCJ> hBMDPMMBCDA_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CCGFCOBHOCJ>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CCGFCOBHOCJ> HBMDPMMBCDA {
      get { return hBMDPMMBCDA_; }
    }

    /// <summary>Field number for the "HPCDCEKNFGH" field.</summary>
    public const int HPCDCEKNFGHFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_hPCDCEKNFGH_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> hPCDCEKNFGH_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HPCDCEKNFGH {
      get { return hPCDCEKNFGH_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SpaceZooDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SpaceZooDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!hPCMCALJHNA_.Equals(other.hPCMCALJHNA_)) return false;
      if (Retcode != other.Retcode) return false;
      if (GFPNBFIMCHH != other.GFPNBFIMCHH) return false;
      if(!dLJHFIJLFHM_.Equals(other.dLJHFIJLFHM_)) return false;
      if(!mPMDLNNNDKD_.Equals(other.mPMDLNNNDKD_)) return false;
      if(!aCDNIKMDDDI_.Equals(other.aCDNIKMDDDI_)) return false;
      if(!bCNHBIGMKAJ_.Equals(other.bCNHBIGMKAJ_)) return false;
      if(!hBMDPMMBCDA_.Equals(other.hBMDPMMBCDA_)) return false;
      if(!hPCDCEKNFGH_.Equals(other.hPCDCEKNFGH_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= hPCMCALJHNA_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (GFPNBFIMCHH != 0) hash ^= GFPNBFIMCHH.GetHashCode();
      hash ^= dLJHFIJLFHM_.GetHashCode();
      hash ^= mPMDLNNNDKD_.GetHashCode();
      hash ^= aCDNIKMDDDI_.GetHashCode();
      hash ^= bCNHBIGMKAJ_.GetHashCode();
      hash ^= hBMDPMMBCDA_.GetHashCode();
      hash ^= hPCDCEKNFGH_.GetHashCode();
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
      hPCMCALJHNA_.WriteTo(output, _repeated_hPCMCALJHNA_codec);
      bCNHBIGMKAJ_.WriteTo(output, _repeated_bCNHBIGMKAJ_codec);
      mPMDLNNNDKD_.WriteTo(output, _repeated_mPMDLNNNDKD_codec);
      hBMDPMMBCDA_.WriteTo(output, _repeated_hBMDPMMBCDA_codec);
      aCDNIKMDDDI_.WriteTo(output, _repeated_aCDNIKMDDDI_codec);
      if (GFPNBFIMCHH != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(GFPNBFIMCHH);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      hPCDCEKNFGH_.WriteTo(output, _repeated_hPCDCEKNFGH_codec);
      dLJHFIJLFHM_.WriteTo(output, _repeated_dLJHFIJLFHM_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      hPCMCALJHNA_.WriteTo(ref output, _repeated_hPCMCALJHNA_codec);
      bCNHBIGMKAJ_.WriteTo(ref output, _repeated_bCNHBIGMKAJ_codec);
      mPMDLNNNDKD_.WriteTo(ref output, _repeated_mPMDLNNNDKD_codec);
      hBMDPMMBCDA_.WriteTo(ref output, _repeated_hBMDPMMBCDA_codec);
      aCDNIKMDDDI_.WriteTo(ref output, _repeated_aCDNIKMDDDI_codec);
      if (GFPNBFIMCHH != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(GFPNBFIMCHH);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      hPCDCEKNFGH_.WriteTo(ref output, _repeated_hPCDCEKNFGH_codec);
      dLJHFIJLFHM_.WriteTo(ref output, _repeated_dLJHFIJLFHM_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += hPCMCALJHNA_.CalculateSize(_repeated_hPCMCALJHNA_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (GFPNBFIMCHH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GFPNBFIMCHH);
      }
      size += dLJHFIJLFHM_.CalculateSize(_repeated_dLJHFIJLFHM_codec);
      size += mPMDLNNNDKD_.CalculateSize(_repeated_mPMDLNNNDKD_codec);
      size += aCDNIKMDDDI_.CalculateSize(_repeated_aCDNIKMDDDI_codec);
      size += bCNHBIGMKAJ_.CalculateSize(_repeated_bCNHBIGMKAJ_codec);
      size += hBMDPMMBCDA_.CalculateSize(_repeated_hBMDPMMBCDA_codec);
      size += hPCDCEKNFGH_.CalculateSize(_repeated_hPCDCEKNFGH_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SpaceZooDataScRsp other) {
      if (other == null) {
        return;
      }
      hPCMCALJHNA_.Add(other.hPCMCALJHNA_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.GFPNBFIMCHH != 0) {
        GFPNBFIMCHH = other.GFPNBFIMCHH;
      }
      dLJHFIJLFHM_.Add(other.dLJHFIJLFHM_);
      mPMDLNNNDKD_.Add(other.mPMDLNNNDKD_);
      aCDNIKMDDDI_.Add(other.aCDNIKMDDDI_);
      bCNHBIGMKAJ_.Add(other.bCNHBIGMKAJ_);
      hBMDPMMBCDA_.Add(other.hBMDPMMBCDA_);
      hPCDCEKNFGH_.Add(other.hPCDCEKNFGH_);
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
          case 10:
          case 8: {
            hPCMCALJHNA_.AddEntriesFrom(input, _repeated_hPCMCALJHNA_codec);
            break;
          }
          case 58:
          case 56: {
            bCNHBIGMKAJ_.AddEntriesFrom(input, _repeated_bCNHBIGMKAJ_codec);
            break;
          }
          case 66:
          case 64: {
            mPMDLNNNDKD_.AddEntriesFrom(input, _repeated_mPMDLNNNDKD_codec);
            break;
          }
          case 74: {
            hBMDPMMBCDA_.AddEntriesFrom(input, _repeated_hBMDPMMBCDA_codec);
            break;
          }
          case 82: {
            aCDNIKMDDDI_.AddEntriesFrom(input, _repeated_aCDNIKMDDDI_codec);
            break;
          }
          case 96: {
            GFPNBFIMCHH = input.ReadUInt32();
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            hPCDCEKNFGH_.AddEntriesFrom(input, _repeated_hPCDCEKNFGH_codec);
            break;
          }
          case 122:
          case 120: {
            dLJHFIJLFHM_.AddEntriesFrom(input, _repeated_dLJHFIJLFHM_codec);
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
          case 10:
          case 8: {
            hPCMCALJHNA_.AddEntriesFrom(ref input, _repeated_hPCMCALJHNA_codec);
            break;
          }
          case 58:
          case 56: {
            bCNHBIGMKAJ_.AddEntriesFrom(ref input, _repeated_bCNHBIGMKAJ_codec);
            break;
          }
          case 66:
          case 64: {
            mPMDLNNNDKD_.AddEntriesFrom(ref input, _repeated_mPMDLNNNDKD_codec);
            break;
          }
          case 74: {
            hBMDPMMBCDA_.AddEntriesFrom(ref input, _repeated_hBMDPMMBCDA_codec);
            break;
          }
          case 82: {
            aCDNIKMDDDI_.AddEntriesFrom(ref input, _repeated_aCDNIKMDDDI_codec);
            break;
          }
          case 96: {
            GFPNBFIMCHH = input.ReadUInt32();
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            hPCDCEKNFGH_.AddEntriesFrom(ref input, _repeated_hPCDCEKNFGH_codec);
            break;
          }
          case 122:
          case 120: {
            dLJHFIJLFHM_.AddEntriesFrom(ref input, _repeated_dLJHFIJLFHM_codec);
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
