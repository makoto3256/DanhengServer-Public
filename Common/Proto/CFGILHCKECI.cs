// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CFGILHCKECI.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from CFGILHCKECI.proto</summary>
  public static partial class CFGILHCKECIReflection {

    #region Descriptor
    /// <summary>File descriptor for CFGILHCKECI.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CFGILHCKECIReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFDRkdJTEhDS0VDSS5wcm90bxoRSE5IRktDSEVQTkYucHJvdG8aEU5MT05H",
            "TkREQUpLLnByb3RvGh1Sb2d1ZU1vZGlmaWVyU291cmNlVHlwZS5wcm90byKy",
            "AQoLQ0ZHSUxIQ0tFQ0kSIQoLSkZCT01OR0tCRkoYAyABKAsyDC5OTE9OR05E",
            "REFKSxI2ChRtb2RpZmllcl9zb3VyY2VfdHlwZRgEIAEoDjIYLlJvZ3VlTW9k",
            "aWZpZXJTb3VyY2VUeXBlEhMKC05QTkJPRUpDTkNEGAEgASgEEiQKC0JGSExF",
            "UEFCQklFGIkIIAEoCzIMLkhOSEZLQ0hFUE5GSABCDQoLRlBEQkZHTkVEQkJC",
            "HqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HNHFKCHEPNFReflection.Descriptor, global::EggLink.DanhengServer.Proto.NLONGNDDAJKReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueModifierSourceTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.CFGILHCKECI), global::EggLink.DanhengServer.Proto.CFGILHCKECI.Parser, new[]{ "JFBOMNGKBFJ", "ModifierSourceType", "NPNBOEJCNCD", "BFHLEPABBIE" }, new[]{ "FPDBFGNEDBB" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CFGILHCKECI : pb::IMessage<CFGILHCKECI>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CFGILHCKECI> _parser = new pb::MessageParser<CFGILHCKECI>(() => new CFGILHCKECI());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CFGILHCKECI> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.CFGILHCKECIReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CFGILHCKECI() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CFGILHCKECI(CFGILHCKECI other) : this() {
      jFBOMNGKBFJ_ = other.jFBOMNGKBFJ_ != null ? other.jFBOMNGKBFJ_.Clone() : null;
      modifierSourceType_ = other.modifierSourceType_;
      nPNBOEJCNCD_ = other.nPNBOEJCNCD_;
      switch (other.FPDBFGNEDBBCase) {
        case FPDBFGNEDBBOneofCase.BFHLEPABBIE:
          BFHLEPABBIE = other.BFHLEPABBIE.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CFGILHCKECI Clone() {
      return new CFGILHCKECI(this);
    }

    /// <summary>Field number for the "JFBOMNGKBFJ" field.</summary>
    public const int JFBOMNGKBFJFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.NLONGNDDAJK jFBOMNGKBFJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.NLONGNDDAJK JFBOMNGKBFJ {
      get { return jFBOMNGKBFJ_; }
      set {
        jFBOMNGKBFJ_ = value;
      }
    }

    /// <summary>Field number for the "modifier_source_type" field.</summary>
    public const int ModifierSourceTypeFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.RogueModifierSourceType modifierSourceType_ = global::EggLink.DanhengServer.Proto.RogueModifierSourceType.RogueModifierSourceNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueModifierSourceType ModifierSourceType {
      get { return modifierSourceType_; }
      set {
        modifierSourceType_ = value;
      }
    }

    /// <summary>Field number for the "NPNBOEJCNCD" field.</summary>
    public const int NPNBOEJCNCDFieldNumber = 1;
    private ulong nPNBOEJCNCD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong NPNBOEJCNCD {
      get { return nPNBOEJCNCD_; }
      set {
        nPNBOEJCNCD_ = value;
      }
    }

    /// <summary>Field number for the "BFHLEPABBIE" field.</summary>
    public const int BFHLEPABBIEFieldNumber = 1033;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HNHFKCHEPNF BFHLEPABBIE {
      get { return fPDBFGNEDBBCase_ == FPDBFGNEDBBOneofCase.BFHLEPABBIE ? (global::EggLink.DanhengServer.Proto.HNHFKCHEPNF) fPDBFGNEDBB_ : null; }
      set {
        fPDBFGNEDBB_ = value;
        fPDBFGNEDBBCase_ = value == null ? FPDBFGNEDBBOneofCase.None : FPDBFGNEDBBOneofCase.BFHLEPABBIE;
      }
    }

    private object fPDBFGNEDBB_;
    /// <summary>Enum of possible cases for the "FPDBFGNEDBB" oneof.</summary>
    public enum FPDBFGNEDBBOneofCase {
      None = 0,
      BFHLEPABBIE = 1033,
    }
    private FPDBFGNEDBBOneofCase fPDBFGNEDBBCase_ = FPDBFGNEDBBOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FPDBFGNEDBBOneofCase FPDBFGNEDBBCase {
      get { return fPDBFGNEDBBCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearFPDBFGNEDBB() {
      fPDBFGNEDBBCase_ = FPDBFGNEDBBOneofCase.None;
      fPDBFGNEDBB_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CFGILHCKECI);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CFGILHCKECI other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(JFBOMNGKBFJ, other.JFBOMNGKBFJ)) return false;
      if (ModifierSourceType != other.ModifierSourceType) return false;
      if (NPNBOEJCNCD != other.NPNBOEJCNCD) return false;
      if (!object.Equals(BFHLEPABBIE, other.BFHLEPABBIE)) return false;
      if (FPDBFGNEDBBCase != other.FPDBFGNEDBBCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (jFBOMNGKBFJ_ != null) hash ^= JFBOMNGKBFJ.GetHashCode();
      if (ModifierSourceType != global::EggLink.DanhengServer.Proto.RogueModifierSourceType.RogueModifierSourceNone) hash ^= ModifierSourceType.GetHashCode();
      if (NPNBOEJCNCD != 0UL) hash ^= NPNBOEJCNCD.GetHashCode();
      if (fPDBFGNEDBBCase_ == FPDBFGNEDBBOneofCase.BFHLEPABBIE) hash ^= BFHLEPABBIE.GetHashCode();
      hash ^= (int) fPDBFGNEDBBCase_;
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
      if (NPNBOEJCNCD != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(NPNBOEJCNCD);
      }
      if (jFBOMNGKBFJ_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(JFBOMNGKBFJ);
      }
      if (ModifierSourceType != global::EggLink.DanhengServer.Proto.RogueModifierSourceType.RogueModifierSourceNone) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ModifierSourceType);
      }
      if (fPDBFGNEDBBCase_ == FPDBFGNEDBBOneofCase.BFHLEPABBIE) {
        output.WriteRawTag(202, 64);
        output.WriteMessage(BFHLEPABBIE);
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
      if (NPNBOEJCNCD != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(NPNBOEJCNCD);
      }
      if (jFBOMNGKBFJ_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(JFBOMNGKBFJ);
      }
      if (ModifierSourceType != global::EggLink.DanhengServer.Proto.RogueModifierSourceType.RogueModifierSourceNone) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ModifierSourceType);
      }
      if (fPDBFGNEDBBCase_ == FPDBFGNEDBBOneofCase.BFHLEPABBIE) {
        output.WriteRawTag(202, 64);
        output.WriteMessage(BFHLEPABBIE);
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
      if (jFBOMNGKBFJ_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(JFBOMNGKBFJ);
      }
      if (ModifierSourceType != global::EggLink.DanhengServer.Proto.RogueModifierSourceType.RogueModifierSourceNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ModifierSourceType);
      }
      if (NPNBOEJCNCD != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(NPNBOEJCNCD);
      }
      if (fPDBFGNEDBBCase_ == FPDBFGNEDBBOneofCase.BFHLEPABBIE) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(BFHLEPABBIE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CFGILHCKECI other) {
      if (other == null) {
        return;
      }
      if (other.jFBOMNGKBFJ_ != null) {
        if (jFBOMNGKBFJ_ == null) {
          JFBOMNGKBFJ = new global::EggLink.DanhengServer.Proto.NLONGNDDAJK();
        }
        JFBOMNGKBFJ.MergeFrom(other.JFBOMNGKBFJ);
      }
      if (other.ModifierSourceType != global::EggLink.DanhengServer.Proto.RogueModifierSourceType.RogueModifierSourceNone) {
        ModifierSourceType = other.ModifierSourceType;
      }
      if (other.NPNBOEJCNCD != 0UL) {
        NPNBOEJCNCD = other.NPNBOEJCNCD;
      }
      switch (other.FPDBFGNEDBBCase) {
        case FPDBFGNEDBBOneofCase.BFHLEPABBIE:
          if (BFHLEPABBIE == null) {
            BFHLEPABBIE = new global::EggLink.DanhengServer.Proto.HNHFKCHEPNF();
          }
          BFHLEPABBIE.MergeFrom(other.BFHLEPABBIE);
          break;
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
            NPNBOEJCNCD = input.ReadUInt64();
            break;
          }
          case 26: {
            if (jFBOMNGKBFJ_ == null) {
              JFBOMNGKBFJ = new global::EggLink.DanhengServer.Proto.NLONGNDDAJK();
            }
            input.ReadMessage(JFBOMNGKBFJ);
            break;
          }
          case 32: {
            ModifierSourceType = (global::EggLink.DanhengServer.Proto.RogueModifierSourceType) input.ReadEnum();
            break;
          }
          case 8266: {
            global::EggLink.DanhengServer.Proto.HNHFKCHEPNF subBuilder = new global::EggLink.DanhengServer.Proto.HNHFKCHEPNF();
            if (fPDBFGNEDBBCase_ == FPDBFGNEDBBOneofCase.BFHLEPABBIE) {
              subBuilder.MergeFrom(BFHLEPABBIE);
            }
            input.ReadMessage(subBuilder);
            BFHLEPABBIE = subBuilder;
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
            NPNBOEJCNCD = input.ReadUInt64();
            break;
          }
          case 26: {
            if (jFBOMNGKBFJ_ == null) {
              JFBOMNGKBFJ = new global::EggLink.DanhengServer.Proto.NLONGNDDAJK();
            }
            input.ReadMessage(JFBOMNGKBFJ);
            break;
          }
          case 32: {
            ModifierSourceType = (global::EggLink.DanhengServer.Proto.RogueModifierSourceType) input.ReadEnum();
            break;
          }
          case 8266: {
            global::EggLink.DanhengServer.Proto.HNHFKCHEPNF subBuilder = new global::EggLink.DanhengServer.Proto.HNHFKCHEPNF();
            if (fPDBFGNEDBBCase_ == FPDBFGNEDBBOneofCase.BFHLEPABBIE) {
              subBuilder.MergeFrom(BFHLEPABBIE);
            }
            input.ReadMessage(subBuilder);
            BFHLEPABBIE = subBuilder;
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
