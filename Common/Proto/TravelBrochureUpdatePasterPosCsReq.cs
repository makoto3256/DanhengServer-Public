// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TravelBrochureUpdatePasterPosCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TravelBrochureUpdatePasterPosCsReq.proto</summary>
  public static partial class TravelBrochureUpdatePasterPosCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for TravelBrochureUpdatePasterPosCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TravelBrochureUpdatePasterPosCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihUcmF2ZWxCcm9jaHVyZVVwZGF0ZVBhc3RlclBvc0NzUmVxLnByb3RvIq4B",
            "CiJUcmF2ZWxCcm9jaHVyZVVwZGF0ZVBhc3RlclBvc0NzUmVxEhAKCGRpYXJ5",
            "X2lkGAsgASgNEg8KB2l0ZW1faWQYAyABKA0SEwoLTEJMRU1FSEpJRUsYAiAB",
            "KA0SEwoLT0hDSENQRUpMREgYCCABKAUSEQoJdW5pcXVlX2lkGAQgASgEEhMK",
            "C1BEREFOTU5BREFGGA8gASgNEhMKC1BOQUVCQkFDTUxNGAkgASgFQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TravelBrochureUpdatePasterPosCsReq), global::EggLink.DanhengServer.Proto.TravelBrochureUpdatePasterPosCsReq.Parser, new[]{ "DiaryId", "ItemId", "LBLEMEHJIEK", "OHCHCPEJLDH", "UniqueId", "PDDANMNADAF", "PNAEBBACMLM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TravelBrochureUpdatePasterPosCsReq : pb::IMessage<TravelBrochureUpdatePasterPosCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TravelBrochureUpdatePasterPosCsReq> _parser = new pb::MessageParser<TravelBrochureUpdatePasterPosCsReq>(() => new TravelBrochureUpdatePasterPosCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TravelBrochureUpdatePasterPosCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TravelBrochureUpdatePasterPosCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureUpdatePasterPosCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureUpdatePasterPosCsReq(TravelBrochureUpdatePasterPosCsReq other) : this() {
      diaryId_ = other.diaryId_;
      itemId_ = other.itemId_;
      lBLEMEHJIEK_ = other.lBLEMEHJIEK_;
      oHCHCPEJLDH_ = other.oHCHCPEJLDH_;
      uniqueId_ = other.uniqueId_;
      pDDANMNADAF_ = other.pDDANMNADAF_;
      pNAEBBACMLM_ = other.pNAEBBACMLM_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TravelBrochureUpdatePasterPosCsReq Clone() {
      return new TravelBrochureUpdatePasterPosCsReq(this);
    }

    /// <summary>Field number for the "diary_id" field.</summary>
    public const int DiaryIdFieldNumber = 11;
    private uint diaryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DiaryId {
      get { return diaryId_; }
      set {
        diaryId_ = value;
      }
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 3;
    private uint itemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "LBLEMEHJIEK" field.</summary>
    public const int LBLEMEHJIEKFieldNumber = 2;
    private uint lBLEMEHJIEK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LBLEMEHJIEK {
      get { return lBLEMEHJIEK_; }
      set {
        lBLEMEHJIEK_ = value;
      }
    }

    /// <summary>Field number for the "OHCHCPEJLDH" field.</summary>
    public const int OHCHCPEJLDHFieldNumber = 8;
    private int oHCHCPEJLDH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int OHCHCPEJLDH {
      get { return oHCHCPEJLDH_; }
      set {
        oHCHCPEJLDH_ = value;
      }
    }

    /// <summary>Field number for the "unique_id" field.</summary>
    public const int UniqueIdFieldNumber = 4;
    private ulong uniqueId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong UniqueId {
      get { return uniqueId_; }
      set {
        uniqueId_ = value;
      }
    }

    /// <summary>Field number for the "PDDANMNADAF" field.</summary>
    public const int PDDANMNADAFFieldNumber = 15;
    private uint pDDANMNADAF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PDDANMNADAF {
      get { return pDDANMNADAF_; }
      set {
        pDDANMNADAF_ = value;
      }
    }

    /// <summary>Field number for the "PNAEBBACMLM" field.</summary>
    public const int PNAEBBACMLMFieldNumber = 9;
    private int pNAEBBACMLM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int PNAEBBACMLM {
      get { return pNAEBBACMLM_; }
      set {
        pNAEBBACMLM_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TravelBrochureUpdatePasterPosCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TravelBrochureUpdatePasterPosCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DiaryId != other.DiaryId) return false;
      if (ItemId != other.ItemId) return false;
      if (LBLEMEHJIEK != other.LBLEMEHJIEK) return false;
      if (OHCHCPEJLDH != other.OHCHCPEJLDH) return false;
      if (UniqueId != other.UniqueId) return false;
      if (PDDANMNADAF != other.PDDANMNADAF) return false;
      if (PNAEBBACMLM != other.PNAEBBACMLM) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DiaryId != 0) hash ^= DiaryId.GetHashCode();
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (LBLEMEHJIEK != 0) hash ^= LBLEMEHJIEK.GetHashCode();
      if (OHCHCPEJLDH != 0) hash ^= OHCHCPEJLDH.GetHashCode();
      if (UniqueId != 0UL) hash ^= UniqueId.GetHashCode();
      if (PDDANMNADAF != 0) hash ^= PDDANMNADAF.GetHashCode();
      if (PNAEBBACMLM != 0) hash ^= PNAEBBACMLM.GetHashCode();
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
      if (LBLEMEHJIEK != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LBLEMEHJIEK);
      }
      if (ItemId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ItemId);
      }
      if (UniqueId != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(UniqueId);
      }
      if (OHCHCPEJLDH != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(OHCHCPEJLDH);
      }
      if (PNAEBBACMLM != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(PNAEBBACMLM);
      }
      if (DiaryId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DiaryId);
      }
      if (PDDANMNADAF != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(PDDANMNADAF);
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
      if (LBLEMEHJIEK != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LBLEMEHJIEK);
      }
      if (ItemId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ItemId);
      }
      if (UniqueId != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(UniqueId);
      }
      if (OHCHCPEJLDH != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(OHCHCPEJLDH);
      }
      if (PNAEBBACMLM != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(PNAEBBACMLM);
      }
      if (DiaryId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DiaryId);
      }
      if (PDDANMNADAF != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(PDDANMNADAF);
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
      if (DiaryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DiaryId);
      }
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemId);
      }
      if (LBLEMEHJIEK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LBLEMEHJIEK);
      }
      if (OHCHCPEJLDH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(OHCHCPEJLDH);
      }
      if (UniqueId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(UniqueId);
      }
      if (PDDANMNADAF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PDDANMNADAF);
      }
      if (PNAEBBACMLM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PNAEBBACMLM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TravelBrochureUpdatePasterPosCsReq other) {
      if (other == null) {
        return;
      }
      if (other.DiaryId != 0) {
        DiaryId = other.DiaryId;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.LBLEMEHJIEK != 0) {
        LBLEMEHJIEK = other.LBLEMEHJIEK;
      }
      if (other.OHCHCPEJLDH != 0) {
        OHCHCPEJLDH = other.OHCHCPEJLDH;
      }
      if (other.UniqueId != 0UL) {
        UniqueId = other.UniqueId;
      }
      if (other.PDDANMNADAF != 0) {
        PDDANMNADAF = other.PDDANMNADAF;
      }
      if (other.PNAEBBACMLM != 0) {
        PNAEBBACMLM = other.PNAEBBACMLM;
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
          case 16: {
            LBLEMEHJIEK = input.ReadUInt32();
            break;
          }
          case 24: {
            ItemId = input.ReadUInt32();
            break;
          }
          case 32: {
            UniqueId = input.ReadUInt64();
            break;
          }
          case 64: {
            OHCHCPEJLDH = input.ReadInt32();
            break;
          }
          case 72: {
            PNAEBBACMLM = input.ReadInt32();
            break;
          }
          case 88: {
            DiaryId = input.ReadUInt32();
            break;
          }
          case 120: {
            PDDANMNADAF = input.ReadUInt32();
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
          case 16: {
            LBLEMEHJIEK = input.ReadUInt32();
            break;
          }
          case 24: {
            ItemId = input.ReadUInt32();
            break;
          }
          case 32: {
            UniqueId = input.ReadUInt64();
            break;
          }
          case 64: {
            OHCHCPEJLDH = input.ReadInt32();
            break;
          }
          case 72: {
            PNAEBBACMLM = input.ReadInt32();
            break;
          }
          case 88: {
            DiaryId = input.ReadUInt32();
            break;
          }
          case 120: {
            PDDANMNADAF = input.ReadUInt32();
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
