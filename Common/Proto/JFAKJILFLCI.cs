// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: JFAKJILFLCI.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from JFAKJILFLCI.proto</summary>
  public static partial class JFAKJILFLCIReflection {

    #region Descriptor
    /// <summary>File descriptor for JFAKJILFLCI.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static JFAKJILFLCIReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFKRkFLSklMRkxDSS5wcm90bxoRRE5MRkZQSFBMQkUucHJvdG8i7gEKC0pG",
            "QUtKSUxGTENJEhMKC0RMSE1FSEdMSUFEGAUgASgNEhMKC0lQQU9QTUdKQ0ZM",
            "GA4gASgNEhMKC2F2YXRhcl9saXN0GAwgAygNEhQKDGNoYWxsZW5nZV9pZBgD",
            "IAEoDRITCgtPQ0dPTEpEQVBIRRgEIAEoCBITCgtKS1BMREJHT0JMQhgGIAEo",
            "DRITCgtCSFBNQkREQ0FERhgLIAMoDRITCgtNREJBRkVPRFBHRxgPIAEoDRIh",
            "CgtJQ0NQRFBDQkVFQhgNIAMoCzIMLkROTEZGUEhQTEJFEhMKC0lITVBNRElD",
            "TUtLGAcgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.DNLFFPHPLBEReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.JFAKJILFLCI), global::EggLink.DanhengServer.Proto.JFAKJILFLCI.Parser, new[]{ "DLHMEHGLIAD", "IPAOPMGJCFL", "AvatarList", "ChallengeId", "OCGOLJDAPHE", "JKPLDBGOBLB", "BHPMBDDCADF", "MDBAFEODPGG", "ICCPDPCBEEB", "IHMPMDICMKK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class JFAKJILFLCI : pb::IMessage<JFAKJILFLCI>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<JFAKJILFLCI> _parser = new pb::MessageParser<JFAKJILFLCI>(() => new JFAKJILFLCI());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<JFAKJILFLCI> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.JFAKJILFLCIReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JFAKJILFLCI() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JFAKJILFLCI(JFAKJILFLCI other) : this() {
      dLHMEHGLIAD_ = other.dLHMEHGLIAD_;
      iPAOPMGJCFL_ = other.iPAOPMGJCFL_;
      avatarList_ = other.avatarList_.Clone();
      challengeId_ = other.challengeId_;
      oCGOLJDAPHE_ = other.oCGOLJDAPHE_;
      jKPLDBGOBLB_ = other.jKPLDBGOBLB_;
      bHPMBDDCADF_ = other.bHPMBDDCADF_.Clone();
      mDBAFEODPGG_ = other.mDBAFEODPGG_;
      iCCPDPCBEEB_ = other.iCCPDPCBEEB_.Clone();
      iHMPMDICMKK_ = other.iHMPMDICMKK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JFAKJILFLCI Clone() {
      return new JFAKJILFLCI(this);
    }

    /// <summary>Field number for the "DLHMEHGLIAD" field.</summary>
    public const int DLHMEHGLIADFieldNumber = 5;
    private uint dLHMEHGLIAD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DLHMEHGLIAD {
      get { return dLHMEHGLIAD_; }
      set {
        dLHMEHGLIAD_ = value;
      }
    }

    /// <summary>Field number for the "IPAOPMGJCFL" field.</summary>
    public const int IPAOPMGJCFLFieldNumber = 14;
    private uint iPAOPMGJCFL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IPAOPMGJCFL {
      get { return iPAOPMGJCFL_; }
      set {
        iPAOPMGJCFL_ = value;
      }
    }

    /// <summary>Field number for the "avatar_list" field.</summary>
    public const int AvatarListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_avatarList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> avatarList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AvatarList {
      get { return avatarList_; }
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 3;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    /// <summary>Field number for the "OCGOLJDAPHE" field.</summary>
    public const int OCGOLJDAPHEFieldNumber = 4;
    private bool oCGOLJDAPHE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool OCGOLJDAPHE {
      get { return oCGOLJDAPHE_; }
      set {
        oCGOLJDAPHE_ = value;
      }
    }

    /// <summary>Field number for the "JKPLDBGOBLB" field.</summary>
    public const int JKPLDBGOBLBFieldNumber = 6;
    private uint jKPLDBGOBLB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JKPLDBGOBLB {
      get { return jKPLDBGOBLB_; }
      set {
        jKPLDBGOBLB_ = value;
      }
    }

    /// <summary>Field number for the "BHPMBDDCADF" field.</summary>
    public const int BHPMBDDCADFFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_bHPMBDDCADF_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> bHPMBDDCADF_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BHPMBDDCADF {
      get { return bHPMBDDCADF_; }
    }

    /// <summary>Field number for the "MDBAFEODPGG" field.</summary>
    public const int MDBAFEODPGGFieldNumber = 15;
    private uint mDBAFEODPGG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MDBAFEODPGG {
      get { return mDBAFEODPGG_; }
      set {
        mDBAFEODPGG_ = value;
      }
    }

    /// <summary>Field number for the "ICCPDPCBEEB" field.</summary>
    public const int ICCPDPCBEEBFieldNumber = 13;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.DNLFFPHPLBE> _repeated_iCCPDPCBEEB_codec
        = pb::FieldCodec.ForMessage(106, global::EggLink.DanhengServer.Proto.DNLFFPHPLBE.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DNLFFPHPLBE> iCCPDPCBEEB_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DNLFFPHPLBE>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.DNLFFPHPLBE> ICCPDPCBEEB {
      get { return iCCPDPCBEEB_; }
    }

    /// <summary>Field number for the "IHMPMDICMKK" field.</summary>
    public const int IHMPMDICMKKFieldNumber = 7;
    private uint iHMPMDICMKK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IHMPMDICMKK {
      get { return iHMPMDICMKK_; }
      set {
        iHMPMDICMKK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as JFAKJILFLCI);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(JFAKJILFLCI other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DLHMEHGLIAD != other.DLHMEHGLIAD) return false;
      if (IPAOPMGJCFL != other.IPAOPMGJCFL) return false;
      if(!avatarList_.Equals(other.avatarList_)) return false;
      if (ChallengeId != other.ChallengeId) return false;
      if (OCGOLJDAPHE != other.OCGOLJDAPHE) return false;
      if (JKPLDBGOBLB != other.JKPLDBGOBLB) return false;
      if(!bHPMBDDCADF_.Equals(other.bHPMBDDCADF_)) return false;
      if (MDBAFEODPGG != other.MDBAFEODPGG) return false;
      if(!iCCPDPCBEEB_.Equals(other.iCCPDPCBEEB_)) return false;
      if (IHMPMDICMKK != other.IHMPMDICMKK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DLHMEHGLIAD != 0) hash ^= DLHMEHGLIAD.GetHashCode();
      if (IPAOPMGJCFL != 0) hash ^= IPAOPMGJCFL.GetHashCode();
      hash ^= avatarList_.GetHashCode();
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
      if (OCGOLJDAPHE != false) hash ^= OCGOLJDAPHE.GetHashCode();
      if (JKPLDBGOBLB != 0) hash ^= JKPLDBGOBLB.GetHashCode();
      hash ^= bHPMBDDCADF_.GetHashCode();
      if (MDBAFEODPGG != 0) hash ^= MDBAFEODPGG.GetHashCode();
      hash ^= iCCPDPCBEEB_.GetHashCode();
      if (IHMPMDICMKK != 0) hash ^= IHMPMDICMKK.GetHashCode();
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
      if (ChallengeId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ChallengeId);
      }
      if (OCGOLJDAPHE != false) {
        output.WriteRawTag(32);
        output.WriteBool(OCGOLJDAPHE);
      }
      if (DLHMEHGLIAD != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DLHMEHGLIAD);
      }
      if (JKPLDBGOBLB != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(JKPLDBGOBLB);
      }
      if (IHMPMDICMKK != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(IHMPMDICMKK);
      }
      bHPMBDDCADF_.WriteTo(output, _repeated_bHPMBDDCADF_codec);
      avatarList_.WriteTo(output, _repeated_avatarList_codec);
      iCCPDPCBEEB_.WriteTo(output, _repeated_iCCPDPCBEEB_codec);
      if (IPAOPMGJCFL != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(IPAOPMGJCFL);
      }
      if (MDBAFEODPGG != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MDBAFEODPGG);
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
      if (ChallengeId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ChallengeId);
      }
      if (OCGOLJDAPHE != false) {
        output.WriteRawTag(32);
        output.WriteBool(OCGOLJDAPHE);
      }
      if (DLHMEHGLIAD != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(DLHMEHGLIAD);
      }
      if (JKPLDBGOBLB != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(JKPLDBGOBLB);
      }
      if (IHMPMDICMKK != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(IHMPMDICMKK);
      }
      bHPMBDDCADF_.WriteTo(ref output, _repeated_bHPMBDDCADF_codec);
      avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
      iCCPDPCBEEB_.WriteTo(ref output, _repeated_iCCPDPCBEEB_codec);
      if (IPAOPMGJCFL != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(IPAOPMGJCFL);
      }
      if (MDBAFEODPGG != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(MDBAFEODPGG);
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
      if (DLHMEHGLIAD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DLHMEHGLIAD);
      }
      if (IPAOPMGJCFL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IPAOPMGJCFL);
      }
      size += avatarList_.CalculateSize(_repeated_avatarList_codec);
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      if (OCGOLJDAPHE != false) {
        size += 1 + 1;
      }
      if (JKPLDBGOBLB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JKPLDBGOBLB);
      }
      size += bHPMBDDCADF_.CalculateSize(_repeated_bHPMBDDCADF_codec);
      if (MDBAFEODPGG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MDBAFEODPGG);
      }
      size += iCCPDPCBEEB_.CalculateSize(_repeated_iCCPDPCBEEB_codec);
      if (IHMPMDICMKK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IHMPMDICMKK);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(JFAKJILFLCI other) {
      if (other == null) {
        return;
      }
      if (other.DLHMEHGLIAD != 0) {
        DLHMEHGLIAD = other.DLHMEHGLIAD;
      }
      if (other.IPAOPMGJCFL != 0) {
        IPAOPMGJCFL = other.IPAOPMGJCFL;
      }
      avatarList_.Add(other.avatarList_);
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
      }
      if (other.OCGOLJDAPHE != false) {
        OCGOLJDAPHE = other.OCGOLJDAPHE;
      }
      if (other.JKPLDBGOBLB != 0) {
        JKPLDBGOBLB = other.JKPLDBGOBLB;
      }
      bHPMBDDCADF_.Add(other.bHPMBDDCADF_);
      if (other.MDBAFEODPGG != 0) {
        MDBAFEODPGG = other.MDBAFEODPGG;
      }
      iCCPDPCBEEB_.Add(other.iCCPDPCBEEB_);
      if (other.IHMPMDICMKK != 0) {
        IHMPMDICMKK = other.IHMPMDICMKK;
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
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 32: {
            OCGOLJDAPHE = input.ReadBool();
            break;
          }
          case 40: {
            DLHMEHGLIAD = input.ReadUInt32();
            break;
          }
          case 48: {
            JKPLDBGOBLB = input.ReadUInt32();
            break;
          }
          case 56: {
            IHMPMDICMKK = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            bHPMBDDCADF_.AddEntriesFrom(input, _repeated_bHPMBDDCADF_codec);
            break;
          }
          case 98:
          case 96: {
            avatarList_.AddEntriesFrom(input, _repeated_avatarList_codec);
            break;
          }
          case 106: {
            iCCPDPCBEEB_.AddEntriesFrom(input, _repeated_iCCPDPCBEEB_codec);
            break;
          }
          case 112: {
            IPAOPMGJCFL = input.ReadUInt32();
            break;
          }
          case 120: {
            MDBAFEODPGG = input.ReadUInt32();
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
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 32: {
            OCGOLJDAPHE = input.ReadBool();
            break;
          }
          case 40: {
            DLHMEHGLIAD = input.ReadUInt32();
            break;
          }
          case 48: {
            JKPLDBGOBLB = input.ReadUInt32();
            break;
          }
          case 56: {
            IHMPMDICMKK = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            bHPMBDDCADF_.AddEntriesFrom(ref input, _repeated_bHPMBDDCADF_codec);
            break;
          }
          case 98:
          case 96: {
            avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
            break;
          }
          case 106: {
            iCCPDPCBEEB_.AddEntriesFrom(ref input, _repeated_iCCPDPCBEEB_codec);
            break;
          }
          case 112: {
            IPAOPMGJCFL = input.ReadUInt32();
            break;
          }
          case 120: {
            MDBAFEODPGG = input.ReadUInt32();
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
