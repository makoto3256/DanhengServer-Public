// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetMonopolyInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetMonopolyInfoScRsp.proto</summary>
  public static partial class GetMonopolyInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetMonopolyInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetMonopolyInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpHZXRNb25vcG9seUluZm9TY1JzcC5wcm90bxoRQUNBSlBIUE5LQUUucHJv",
            "dG8aEU5FSktERU5HTEtPLnByb3RvGhZNb25vcG9seUJ1ZmZJbmZvLnByb3Rv",
            "GhFFTUtQUE1JSUVOSy5wcm90bxoRTUFDQ0hIRUZKQUkucHJvdG8aEU9MRERE",
            "REVEQklLLnByb3RvGhFES0FDRkVFSEZNQy5wcm90bxoXTW9ub3BvbHlFdmVu",
            "dEluZm8ucHJvdG8aFE1vbm9wb2x5UmVwb3J0LnByb3RvGhFDQ05MSElJRE5L",
            "TS5wcm90bxoVTW9ub3BvbHlNYXBJbmZvLnByb3RvIsMDChRHZXRNb25vcG9s",
            "eUluZm9TY1JzcBIhCgtGSUtLTUVBR1BPUBgHIAEoCzIMLkRLQUNGRUVIRk1D",
            "EiEKC0xET05BTEZLR0NQGAggASgLMgwuTUFDQ0hIRUZKQUkSIQoLSEhORUFB",
            "TUZQQkwYASABKAsyDC5DQ05MSElJRE5LTRITCgtDUEJIS0RLQk5LSBgEIAMo",
            "DRIqCg9yb2d1ZV9idWZmX2luZm8YCiABKAsyES5Nb25vcG9seUJ1ZmZJbmZv",
            "EiIKCG1hcF9pbmZvGAwgASgLMhAuTW9ub3BvbHlNYXBJbmZvEg8KB3JldGNv",
            "ZGUYCSABKA0SIQoLTU1FQ0ZFT1BBTUEYDyABKAsyDC5BQ0FKUEhQTktBRRIh",
            "CgtQQ0pPS0JHT0VLShgCIAEoCzIMLkVNS1BQTUlJRU5LEh8KA3N0dBgFIAEo",
            "CzISLk1vbm9wb2x5RXZlbnRJbmZvEiEKC0hHSEZPRU9ISU1EGAMgASgLMgwu",
            "T0xERERERURCSUsSHwoGcmVwb3J0GAYgASgLMg8uTW9ub3BvbHlSZXBvcnQS",
            "IQoLR0tMUEhQREhDRUsYDSABKAsyDC5ORUpLREVOR0xLT0IeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ACAJPHPNKAEReflection.Descriptor, global::EggLink.DanhengServer.Proto.NEJKDENGLKOReflection.Descriptor, global::EggLink.DanhengServer.Proto.MonopolyBuffInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.EMKPPMIIENKReflection.Descriptor, global::EggLink.DanhengServer.Proto.MACCHHEFJAIReflection.Descriptor, global::EggLink.DanhengServer.Proto.OLDDDDEDBIKReflection.Descriptor, global::EggLink.DanhengServer.Proto.DKACFEEHFMCReflection.Descriptor, global::EggLink.DanhengServer.Proto.MonopolyEventInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.MonopolyReportReflection.Descriptor, global::EggLink.DanhengServer.Proto.CCNLHIIDNKMReflection.Descriptor, global::EggLink.DanhengServer.Proto.MonopolyMapInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetMonopolyInfoScRsp), global::EggLink.DanhengServer.Proto.GetMonopolyInfoScRsp.Parser, new[]{ "FIKKMEAGPOP", "LDONALFKGCP", "HHNEAAMFPBL", "CPBHKDKBNKH", "RogueBuffInfo", "MapInfo", "Retcode", "MMECFEOPAMA", "PCJOKBGOEKJ", "Stt", "HGHFOEOHIMD", "Report", "GKLPHPDHCEK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetMonopolyInfoScRsp : pb::IMessage<GetMonopolyInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetMonopolyInfoScRsp> _parser = new pb::MessageParser<GetMonopolyInfoScRsp>(() => new GetMonopolyInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetMonopolyInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetMonopolyInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMonopolyInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMonopolyInfoScRsp(GetMonopolyInfoScRsp other) : this() {
      fIKKMEAGPOP_ = other.fIKKMEAGPOP_ != null ? other.fIKKMEAGPOP_.Clone() : null;
      lDONALFKGCP_ = other.lDONALFKGCP_ != null ? other.lDONALFKGCP_.Clone() : null;
      hHNEAAMFPBL_ = other.hHNEAAMFPBL_ != null ? other.hHNEAAMFPBL_.Clone() : null;
      cPBHKDKBNKH_ = other.cPBHKDKBNKH_.Clone();
      rogueBuffInfo_ = other.rogueBuffInfo_ != null ? other.rogueBuffInfo_.Clone() : null;
      mapInfo_ = other.mapInfo_ != null ? other.mapInfo_.Clone() : null;
      retcode_ = other.retcode_;
      mMECFEOPAMA_ = other.mMECFEOPAMA_ != null ? other.mMECFEOPAMA_.Clone() : null;
      pCJOKBGOEKJ_ = other.pCJOKBGOEKJ_ != null ? other.pCJOKBGOEKJ_.Clone() : null;
      stt_ = other.stt_ != null ? other.stt_.Clone() : null;
      hGHFOEOHIMD_ = other.hGHFOEOHIMD_ != null ? other.hGHFOEOHIMD_.Clone() : null;
      report_ = other.report_ != null ? other.report_.Clone() : null;
      gKLPHPDHCEK_ = other.gKLPHPDHCEK_ != null ? other.gKLPHPDHCEK_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMonopolyInfoScRsp Clone() {
      return new GetMonopolyInfoScRsp(this);
    }

    /// <summary>Field number for the "FIKKMEAGPOP" field.</summary>
    public const int FIKKMEAGPOPFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.DKACFEEHFMC fIKKMEAGPOP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.DKACFEEHFMC FIKKMEAGPOP {
      get { return fIKKMEAGPOP_; }
      set {
        fIKKMEAGPOP_ = value;
      }
    }

    /// <summary>Field number for the "LDONALFKGCP" field.</summary>
    public const int LDONALFKGCPFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.MACCHHEFJAI lDONALFKGCP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MACCHHEFJAI LDONALFKGCP {
      get { return lDONALFKGCP_; }
      set {
        lDONALFKGCP_ = value;
      }
    }

    /// <summary>Field number for the "HHNEAAMFPBL" field.</summary>
    public const int HHNEAAMFPBLFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.CCNLHIIDNKM hHNEAAMFPBL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CCNLHIIDNKM HHNEAAMFPBL {
      get { return hHNEAAMFPBL_; }
      set {
        hHNEAAMFPBL_ = value;
      }
    }

    /// <summary>Field number for the "CPBHKDKBNKH" field.</summary>
    public const int CPBHKDKBNKHFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_cPBHKDKBNKH_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> cPBHKDKBNKH_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CPBHKDKBNKH {
      get { return cPBHKDKBNKH_; }
    }

    /// <summary>Field number for the "rogue_buff_info" field.</summary>
    public const int RogueBuffInfoFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.MonopolyBuffInfo rogueBuffInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MonopolyBuffInfo RogueBuffInfo {
      get { return rogueBuffInfo_; }
      set {
        rogueBuffInfo_ = value;
      }
    }

    /// <summary>Field number for the "map_info" field.</summary>
    public const int MapInfoFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.MonopolyMapInfo mapInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MonopolyMapInfo MapInfo {
      get { return mapInfo_; }
      set {
        mapInfo_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 9;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "MMECFEOPAMA" field.</summary>
    public const int MMECFEOPAMAFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.ACAJPHPNKAE mMECFEOPAMA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ACAJPHPNKAE MMECFEOPAMA {
      get { return mMECFEOPAMA_; }
      set {
        mMECFEOPAMA_ = value;
      }
    }

    /// <summary>Field number for the "PCJOKBGOEKJ" field.</summary>
    public const int PCJOKBGOEKJFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.EMKPPMIIENK pCJOKBGOEKJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EMKPPMIIENK PCJOKBGOEKJ {
      get { return pCJOKBGOEKJ_; }
      set {
        pCJOKBGOEKJ_ = value;
      }
    }

    /// <summary>Field number for the "stt" field.</summary>
    public const int SttFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.MonopolyEventInfo stt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MonopolyEventInfo Stt {
      get { return stt_; }
      set {
        stt_ = value;
      }
    }

    /// <summary>Field number for the "HGHFOEOHIMD" field.</summary>
    public const int HGHFOEOHIMDFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.OLDDDDEDBIK hGHFOEOHIMD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.OLDDDDEDBIK HGHFOEOHIMD {
      get { return hGHFOEOHIMD_; }
      set {
        hGHFOEOHIMD_ = value;
      }
    }

    /// <summary>Field number for the "report" field.</summary>
    public const int ReportFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.MonopolyReport report_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MonopolyReport Report {
      get { return report_; }
      set {
        report_ = value;
      }
    }

    /// <summary>Field number for the "GKLPHPDHCEK" field.</summary>
    public const int GKLPHPDHCEKFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.NEJKDENGLKO gKLPHPDHCEK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.NEJKDENGLKO GKLPHPDHCEK {
      get { return gKLPHPDHCEK_; }
      set {
        gKLPHPDHCEK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetMonopolyInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetMonopolyInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(FIKKMEAGPOP, other.FIKKMEAGPOP)) return false;
      if (!object.Equals(LDONALFKGCP, other.LDONALFKGCP)) return false;
      if (!object.Equals(HHNEAAMFPBL, other.HHNEAAMFPBL)) return false;
      if(!cPBHKDKBNKH_.Equals(other.cPBHKDKBNKH_)) return false;
      if (!object.Equals(RogueBuffInfo, other.RogueBuffInfo)) return false;
      if (!object.Equals(MapInfo, other.MapInfo)) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(MMECFEOPAMA, other.MMECFEOPAMA)) return false;
      if (!object.Equals(PCJOKBGOEKJ, other.PCJOKBGOEKJ)) return false;
      if (!object.Equals(Stt, other.Stt)) return false;
      if (!object.Equals(HGHFOEOHIMD, other.HGHFOEOHIMD)) return false;
      if (!object.Equals(Report, other.Report)) return false;
      if (!object.Equals(GKLPHPDHCEK, other.GKLPHPDHCEK)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (fIKKMEAGPOP_ != null) hash ^= FIKKMEAGPOP.GetHashCode();
      if (lDONALFKGCP_ != null) hash ^= LDONALFKGCP.GetHashCode();
      if (hHNEAAMFPBL_ != null) hash ^= HHNEAAMFPBL.GetHashCode();
      hash ^= cPBHKDKBNKH_.GetHashCode();
      if (rogueBuffInfo_ != null) hash ^= RogueBuffInfo.GetHashCode();
      if (mapInfo_ != null) hash ^= MapInfo.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (mMECFEOPAMA_ != null) hash ^= MMECFEOPAMA.GetHashCode();
      if (pCJOKBGOEKJ_ != null) hash ^= PCJOKBGOEKJ.GetHashCode();
      if (stt_ != null) hash ^= Stt.GetHashCode();
      if (hGHFOEOHIMD_ != null) hash ^= HGHFOEOHIMD.GetHashCode();
      if (report_ != null) hash ^= Report.GetHashCode();
      if (gKLPHPDHCEK_ != null) hash ^= GKLPHPDHCEK.GetHashCode();
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
      if (hHNEAAMFPBL_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(HHNEAAMFPBL);
      }
      if (pCJOKBGOEKJ_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PCJOKBGOEKJ);
      }
      if (hGHFOEOHIMD_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(HGHFOEOHIMD);
      }
      cPBHKDKBNKH_.WriteTo(output, _repeated_cPBHKDKBNKH_codec);
      if (stt_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Stt);
      }
      if (report_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Report);
      }
      if (fIKKMEAGPOP_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(FIKKMEAGPOP);
      }
      if (lDONALFKGCP_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(LDONALFKGCP);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Retcode);
      }
      if (rogueBuffInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(RogueBuffInfo);
      }
      if (mapInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(MapInfo);
      }
      if (gKLPHPDHCEK_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(GKLPHPDHCEK);
      }
      if (mMECFEOPAMA_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(MMECFEOPAMA);
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
      if (hHNEAAMFPBL_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(HHNEAAMFPBL);
      }
      if (pCJOKBGOEKJ_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(PCJOKBGOEKJ);
      }
      if (hGHFOEOHIMD_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(HGHFOEOHIMD);
      }
      cPBHKDKBNKH_.WriteTo(ref output, _repeated_cPBHKDKBNKH_codec);
      if (stt_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Stt);
      }
      if (report_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Report);
      }
      if (fIKKMEAGPOP_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(FIKKMEAGPOP);
      }
      if (lDONALFKGCP_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(LDONALFKGCP);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Retcode);
      }
      if (rogueBuffInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(RogueBuffInfo);
      }
      if (mapInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(MapInfo);
      }
      if (gKLPHPDHCEK_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(GKLPHPDHCEK);
      }
      if (mMECFEOPAMA_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(MMECFEOPAMA);
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
      if (fIKKMEAGPOP_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FIKKMEAGPOP);
      }
      if (lDONALFKGCP_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LDONALFKGCP);
      }
      if (hHNEAAMFPBL_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HHNEAAMFPBL);
      }
      size += cPBHKDKBNKH_.CalculateSize(_repeated_cPBHKDKBNKH_codec);
      if (rogueBuffInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueBuffInfo);
      }
      if (mapInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MapInfo);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (mMECFEOPAMA_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MMECFEOPAMA);
      }
      if (pCJOKBGOEKJ_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PCJOKBGOEKJ);
      }
      if (stt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Stt);
      }
      if (hGHFOEOHIMD_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HGHFOEOHIMD);
      }
      if (report_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Report);
      }
      if (gKLPHPDHCEK_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GKLPHPDHCEK);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetMonopolyInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.fIKKMEAGPOP_ != null) {
        if (fIKKMEAGPOP_ == null) {
          FIKKMEAGPOP = new global::EggLink.DanhengServer.Proto.DKACFEEHFMC();
        }
        FIKKMEAGPOP.MergeFrom(other.FIKKMEAGPOP);
      }
      if (other.lDONALFKGCP_ != null) {
        if (lDONALFKGCP_ == null) {
          LDONALFKGCP = new global::EggLink.DanhengServer.Proto.MACCHHEFJAI();
        }
        LDONALFKGCP.MergeFrom(other.LDONALFKGCP);
      }
      if (other.hHNEAAMFPBL_ != null) {
        if (hHNEAAMFPBL_ == null) {
          HHNEAAMFPBL = new global::EggLink.DanhengServer.Proto.CCNLHIIDNKM();
        }
        HHNEAAMFPBL.MergeFrom(other.HHNEAAMFPBL);
      }
      cPBHKDKBNKH_.Add(other.cPBHKDKBNKH_);
      if (other.rogueBuffInfo_ != null) {
        if (rogueBuffInfo_ == null) {
          RogueBuffInfo = new global::EggLink.DanhengServer.Proto.MonopolyBuffInfo();
        }
        RogueBuffInfo.MergeFrom(other.RogueBuffInfo);
      }
      if (other.mapInfo_ != null) {
        if (mapInfo_ == null) {
          MapInfo = new global::EggLink.DanhengServer.Proto.MonopolyMapInfo();
        }
        MapInfo.MergeFrom(other.MapInfo);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.mMECFEOPAMA_ != null) {
        if (mMECFEOPAMA_ == null) {
          MMECFEOPAMA = new global::EggLink.DanhengServer.Proto.ACAJPHPNKAE();
        }
        MMECFEOPAMA.MergeFrom(other.MMECFEOPAMA);
      }
      if (other.pCJOKBGOEKJ_ != null) {
        if (pCJOKBGOEKJ_ == null) {
          PCJOKBGOEKJ = new global::EggLink.DanhengServer.Proto.EMKPPMIIENK();
        }
        PCJOKBGOEKJ.MergeFrom(other.PCJOKBGOEKJ);
      }
      if (other.stt_ != null) {
        if (stt_ == null) {
          Stt = new global::EggLink.DanhengServer.Proto.MonopolyEventInfo();
        }
        Stt.MergeFrom(other.Stt);
      }
      if (other.hGHFOEOHIMD_ != null) {
        if (hGHFOEOHIMD_ == null) {
          HGHFOEOHIMD = new global::EggLink.DanhengServer.Proto.OLDDDDEDBIK();
        }
        HGHFOEOHIMD.MergeFrom(other.HGHFOEOHIMD);
      }
      if (other.report_ != null) {
        if (report_ == null) {
          Report = new global::EggLink.DanhengServer.Proto.MonopolyReport();
        }
        Report.MergeFrom(other.Report);
      }
      if (other.gKLPHPDHCEK_ != null) {
        if (gKLPHPDHCEK_ == null) {
          GKLPHPDHCEK = new global::EggLink.DanhengServer.Proto.NEJKDENGLKO();
        }
        GKLPHPDHCEK.MergeFrom(other.GKLPHPDHCEK);
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
          case 10: {
            if (hHNEAAMFPBL_ == null) {
              HHNEAAMFPBL = new global::EggLink.DanhengServer.Proto.CCNLHIIDNKM();
            }
            input.ReadMessage(HHNEAAMFPBL);
            break;
          }
          case 18: {
            if (pCJOKBGOEKJ_ == null) {
              PCJOKBGOEKJ = new global::EggLink.DanhengServer.Proto.EMKPPMIIENK();
            }
            input.ReadMessage(PCJOKBGOEKJ);
            break;
          }
          case 26: {
            if (hGHFOEOHIMD_ == null) {
              HGHFOEOHIMD = new global::EggLink.DanhengServer.Proto.OLDDDDEDBIK();
            }
            input.ReadMessage(HGHFOEOHIMD);
            break;
          }
          case 34:
          case 32: {
            cPBHKDKBNKH_.AddEntriesFrom(input, _repeated_cPBHKDKBNKH_codec);
            break;
          }
          case 42: {
            if (stt_ == null) {
              Stt = new global::EggLink.DanhengServer.Proto.MonopolyEventInfo();
            }
            input.ReadMessage(Stt);
            break;
          }
          case 50: {
            if (report_ == null) {
              Report = new global::EggLink.DanhengServer.Proto.MonopolyReport();
            }
            input.ReadMessage(Report);
            break;
          }
          case 58: {
            if (fIKKMEAGPOP_ == null) {
              FIKKMEAGPOP = new global::EggLink.DanhengServer.Proto.DKACFEEHFMC();
            }
            input.ReadMessage(FIKKMEAGPOP);
            break;
          }
          case 66: {
            if (lDONALFKGCP_ == null) {
              LDONALFKGCP = new global::EggLink.DanhengServer.Proto.MACCHHEFJAI();
            }
            input.ReadMessage(LDONALFKGCP);
            break;
          }
          case 72: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 82: {
            if (rogueBuffInfo_ == null) {
              RogueBuffInfo = new global::EggLink.DanhengServer.Proto.MonopolyBuffInfo();
            }
            input.ReadMessage(RogueBuffInfo);
            break;
          }
          case 98: {
            if (mapInfo_ == null) {
              MapInfo = new global::EggLink.DanhengServer.Proto.MonopolyMapInfo();
            }
            input.ReadMessage(MapInfo);
            break;
          }
          case 106: {
            if (gKLPHPDHCEK_ == null) {
              GKLPHPDHCEK = new global::EggLink.DanhengServer.Proto.NEJKDENGLKO();
            }
            input.ReadMessage(GKLPHPDHCEK);
            break;
          }
          case 122: {
            if (mMECFEOPAMA_ == null) {
              MMECFEOPAMA = new global::EggLink.DanhengServer.Proto.ACAJPHPNKAE();
            }
            input.ReadMessage(MMECFEOPAMA);
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
          case 10: {
            if (hHNEAAMFPBL_ == null) {
              HHNEAAMFPBL = new global::EggLink.DanhengServer.Proto.CCNLHIIDNKM();
            }
            input.ReadMessage(HHNEAAMFPBL);
            break;
          }
          case 18: {
            if (pCJOKBGOEKJ_ == null) {
              PCJOKBGOEKJ = new global::EggLink.DanhengServer.Proto.EMKPPMIIENK();
            }
            input.ReadMessage(PCJOKBGOEKJ);
            break;
          }
          case 26: {
            if (hGHFOEOHIMD_ == null) {
              HGHFOEOHIMD = new global::EggLink.DanhengServer.Proto.OLDDDDEDBIK();
            }
            input.ReadMessage(HGHFOEOHIMD);
            break;
          }
          case 34:
          case 32: {
            cPBHKDKBNKH_.AddEntriesFrom(ref input, _repeated_cPBHKDKBNKH_codec);
            break;
          }
          case 42: {
            if (stt_ == null) {
              Stt = new global::EggLink.DanhengServer.Proto.MonopolyEventInfo();
            }
            input.ReadMessage(Stt);
            break;
          }
          case 50: {
            if (report_ == null) {
              Report = new global::EggLink.DanhengServer.Proto.MonopolyReport();
            }
            input.ReadMessage(Report);
            break;
          }
          case 58: {
            if (fIKKMEAGPOP_ == null) {
              FIKKMEAGPOP = new global::EggLink.DanhengServer.Proto.DKACFEEHFMC();
            }
            input.ReadMessage(FIKKMEAGPOP);
            break;
          }
          case 66: {
            if (lDONALFKGCP_ == null) {
              LDONALFKGCP = new global::EggLink.DanhengServer.Proto.MACCHHEFJAI();
            }
            input.ReadMessage(LDONALFKGCP);
            break;
          }
          case 72: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 82: {
            if (rogueBuffInfo_ == null) {
              RogueBuffInfo = new global::EggLink.DanhengServer.Proto.MonopolyBuffInfo();
            }
            input.ReadMessage(RogueBuffInfo);
            break;
          }
          case 98: {
            if (mapInfo_ == null) {
              MapInfo = new global::EggLink.DanhengServer.Proto.MonopolyMapInfo();
            }
            input.ReadMessage(MapInfo);
            break;
          }
          case 106: {
            if (gKLPHPDHCEK_ == null) {
              GKLPHPDHCEK = new global::EggLink.DanhengServer.Proto.NEJKDENGLKO();
            }
            input.ReadMessage(GKLPHPDHCEK);
            break;
          }
          case 122: {
            if (mMECFEOPAMA_ == null) {
              MMECFEOPAMA = new global::EggLink.DanhengServer.Proto.ACAJPHPNKAE();
            }
            input.ReadMessage(MMECFEOPAMA);
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
