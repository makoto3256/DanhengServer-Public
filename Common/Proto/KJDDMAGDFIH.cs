// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: KJDDMAGDFIH.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from KJDDMAGDFIH.proto</summary>
  public static partial class KJDDMAGDFIHReflection {

    #region Descriptor
    /// <summary>File descriptor for KJDDMAGDFIH.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KJDDMAGDFIHReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFLSkRETUFHREZJSC5wcm90byJyCgtLSkRETUFHREZJSBITCgtMQkxFTUVI",
            "SklFSxgPIAEoDRITCgtQRERBTk1OQURBRhgCIAEoDRITCgtPSENIQ1BFSkxE",
            "SBgGIAEoBRIPCgdpdGVtX2lkGA4gASgNEhMKC1BOQUVCQkFDTUxNGAggASgF",
            "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.KJDDMAGDFIH), global::EggLink.DanhengServer.Proto.KJDDMAGDFIH.Parser, new[]{ "LBLEMEHJIEK", "PDDANMNADAF", "OHCHCPEJLDH", "ItemId", "PNAEBBACMLM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class KJDDMAGDFIH : pb::IMessage<KJDDMAGDFIH>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KJDDMAGDFIH> _parser = new pb::MessageParser<KJDDMAGDFIH>(() => new KJDDMAGDFIH());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KJDDMAGDFIH> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.KJDDMAGDFIHReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KJDDMAGDFIH() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KJDDMAGDFIH(KJDDMAGDFIH other) : this() {
      lBLEMEHJIEK_ = other.lBLEMEHJIEK_;
      pDDANMNADAF_ = other.pDDANMNADAF_;
      oHCHCPEJLDH_ = other.oHCHCPEJLDH_;
      itemId_ = other.itemId_;
      pNAEBBACMLM_ = other.pNAEBBACMLM_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KJDDMAGDFIH Clone() {
      return new KJDDMAGDFIH(this);
    }

    /// <summary>Field number for the "LBLEMEHJIEK" field.</summary>
    public const int LBLEMEHJIEKFieldNumber = 15;
    private uint lBLEMEHJIEK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LBLEMEHJIEK {
      get { return lBLEMEHJIEK_; }
      set {
        lBLEMEHJIEK_ = value;
      }
    }

    /// <summary>Field number for the "PDDANMNADAF" field.</summary>
    public const int PDDANMNADAFFieldNumber = 2;
    private uint pDDANMNADAF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PDDANMNADAF {
      get { return pDDANMNADAF_; }
      set {
        pDDANMNADAF_ = value;
      }
    }

    /// <summary>Field number for the "OHCHCPEJLDH" field.</summary>
    public const int OHCHCPEJLDHFieldNumber = 6;
    private int oHCHCPEJLDH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int OHCHCPEJLDH {
      get { return oHCHCPEJLDH_; }
      set {
        oHCHCPEJLDH_ = value;
      }
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 14;
    private uint itemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "PNAEBBACMLM" field.</summary>
    public const int PNAEBBACMLMFieldNumber = 8;
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
      return Equals(other as KJDDMAGDFIH);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KJDDMAGDFIH other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LBLEMEHJIEK != other.LBLEMEHJIEK) return false;
      if (PDDANMNADAF != other.PDDANMNADAF) return false;
      if (OHCHCPEJLDH != other.OHCHCPEJLDH) return false;
      if (ItemId != other.ItemId) return false;
      if (PNAEBBACMLM != other.PNAEBBACMLM) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LBLEMEHJIEK != 0) hash ^= LBLEMEHJIEK.GetHashCode();
      if (PDDANMNADAF != 0) hash ^= PDDANMNADAF.GetHashCode();
      if (OHCHCPEJLDH != 0) hash ^= OHCHCPEJLDH.GetHashCode();
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
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
      if (PDDANMNADAF != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(PDDANMNADAF);
      }
      if (OHCHCPEJLDH != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(OHCHCPEJLDH);
      }
      if (PNAEBBACMLM != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(PNAEBBACMLM);
      }
      if (ItemId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ItemId);
      }
      if (LBLEMEHJIEK != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(LBLEMEHJIEK);
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
      if (PDDANMNADAF != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(PDDANMNADAF);
      }
      if (OHCHCPEJLDH != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(OHCHCPEJLDH);
      }
      if (PNAEBBACMLM != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(PNAEBBACMLM);
      }
      if (ItemId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ItemId);
      }
      if (LBLEMEHJIEK != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(LBLEMEHJIEK);
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
      if (LBLEMEHJIEK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LBLEMEHJIEK);
      }
      if (PDDANMNADAF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PDDANMNADAF);
      }
      if (OHCHCPEJLDH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(OHCHCPEJLDH);
      }
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemId);
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
    public void MergeFrom(KJDDMAGDFIH other) {
      if (other == null) {
        return;
      }
      if (other.LBLEMEHJIEK != 0) {
        LBLEMEHJIEK = other.LBLEMEHJIEK;
      }
      if (other.PDDANMNADAF != 0) {
        PDDANMNADAF = other.PDDANMNADAF;
      }
      if (other.OHCHCPEJLDH != 0) {
        OHCHCPEJLDH = other.OHCHCPEJLDH;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
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
            PDDANMNADAF = input.ReadUInt32();
            break;
          }
          case 48: {
            OHCHCPEJLDH = input.ReadInt32();
            break;
          }
          case 64: {
            PNAEBBACMLM = input.ReadInt32();
            break;
          }
          case 112: {
            ItemId = input.ReadUInt32();
            break;
          }
          case 120: {
            LBLEMEHJIEK = input.ReadUInt32();
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
            PDDANMNADAF = input.ReadUInt32();
            break;
          }
          case 48: {
            OHCHCPEJLDH = input.ReadInt32();
            break;
          }
          case 64: {
            PNAEBBACMLM = input.ReadInt32();
            break;
          }
          case 112: {
            ItemId = input.ReadUInt32();
            break;
          }
          case 120: {
            LBLEMEHJIEK = input.ReadUInt32();
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
