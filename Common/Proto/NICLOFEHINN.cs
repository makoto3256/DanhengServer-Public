// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NICLOFEHINN.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from NICLOFEHINN.proto</summary>
  public static partial class NICLOFEHINNReflection {

    #region Descriptor
    /// <summary>File descriptor for NICLOFEHINN.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NICLOFEHINNReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFOSUNMT0ZFSElOTi5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIn8KC05J",
            "Q0xPRkVISU5OEhMKC0hISUROTU5QQ0xNGAggASgIEhMKC0hDTk9DRkpGRVBI",
            "GA4gASgNEiAKCWNvc3RfZGF0YRgKIAEoCzINLkl0ZW1Db3N0RGF0YRITCgtK",
            "R0hIRktQQk5HShgHIAEoCBIPCgdidWZmX2lkGAMgASgNQh6qAhtFZ2dMaW5r",
            "LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemCostDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.NICLOFEHINN), global::EggLink.DanhengServer.Proto.NICLOFEHINN.Parser, new[]{ "HHIDNMNPCLM", "HCNOCFJFEPH", "CostData", "JGHHFKPBNGJ", "BuffId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class NICLOFEHINN : pb::IMessage<NICLOFEHINN>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NICLOFEHINN> _parser = new pb::MessageParser<NICLOFEHINN>(() => new NICLOFEHINN());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NICLOFEHINN> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.NICLOFEHINNReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NICLOFEHINN() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NICLOFEHINN(NICLOFEHINN other) : this() {
      hHIDNMNPCLM_ = other.hHIDNMNPCLM_;
      hCNOCFJFEPH_ = other.hCNOCFJFEPH_;
      costData_ = other.costData_ != null ? other.costData_.Clone() : null;
      jGHHFKPBNGJ_ = other.jGHHFKPBNGJ_;
      buffId_ = other.buffId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NICLOFEHINN Clone() {
      return new NICLOFEHINN(this);
    }

    /// <summary>Field number for the "HHIDNMNPCLM" field.</summary>
    public const int HHIDNMNPCLMFieldNumber = 8;
    private bool hHIDNMNPCLM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HHIDNMNPCLM {
      get { return hHIDNMNPCLM_; }
      set {
        hHIDNMNPCLM_ = value;
      }
    }

    /// <summary>Field number for the "HCNOCFJFEPH" field.</summary>
    public const int HCNOCFJFEPHFieldNumber = 14;
    private uint hCNOCFJFEPH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HCNOCFJFEPH {
      get { return hCNOCFJFEPH_; }
      set {
        hCNOCFJFEPH_ = value;
      }
    }

    /// <summary>Field number for the "cost_data" field.</summary>
    public const int CostDataFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.ItemCostData costData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemCostData CostData {
      get { return costData_; }
      set {
        costData_ = value;
      }
    }

    /// <summary>Field number for the "JGHHFKPBNGJ" field.</summary>
    public const int JGHHFKPBNGJFieldNumber = 7;
    private bool jGHHFKPBNGJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool JGHHFKPBNGJ {
      get { return jGHHFKPBNGJ_; }
      set {
        jGHHFKPBNGJ_ = value;
      }
    }

    /// <summary>Field number for the "buff_id" field.</summary>
    public const int BuffIdFieldNumber = 3;
    private uint buffId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BuffId {
      get { return buffId_; }
      set {
        buffId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NICLOFEHINN);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NICLOFEHINN other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HHIDNMNPCLM != other.HHIDNMNPCLM) return false;
      if (HCNOCFJFEPH != other.HCNOCFJFEPH) return false;
      if (!object.Equals(CostData, other.CostData)) return false;
      if (JGHHFKPBNGJ != other.JGHHFKPBNGJ) return false;
      if (BuffId != other.BuffId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HHIDNMNPCLM != false) hash ^= HHIDNMNPCLM.GetHashCode();
      if (HCNOCFJFEPH != 0) hash ^= HCNOCFJFEPH.GetHashCode();
      if (costData_ != null) hash ^= CostData.GetHashCode();
      if (JGHHFKPBNGJ != false) hash ^= JGHHFKPBNGJ.GetHashCode();
      if (BuffId != 0) hash ^= BuffId.GetHashCode();
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
      if (BuffId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BuffId);
      }
      if (JGHHFKPBNGJ != false) {
        output.WriteRawTag(56);
        output.WriteBool(JGHHFKPBNGJ);
      }
      if (HHIDNMNPCLM != false) {
        output.WriteRawTag(64);
        output.WriteBool(HHIDNMNPCLM);
      }
      if (costData_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(CostData);
      }
      if (HCNOCFJFEPH != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(HCNOCFJFEPH);
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
      if (BuffId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BuffId);
      }
      if (JGHHFKPBNGJ != false) {
        output.WriteRawTag(56);
        output.WriteBool(JGHHFKPBNGJ);
      }
      if (HHIDNMNPCLM != false) {
        output.WriteRawTag(64);
        output.WriteBool(HHIDNMNPCLM);
      }
      if (costData_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(CostData);
      }
      if (HCNOCFJFEPH != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(HCNOCFJFEPH);
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
      if (HHIDNMNPCLM != false) {
        size += 1 + 1;
      }
      if (HCNOCFJFEPH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HCNOCFJFEPH);
      }
      if (costData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CostData);
      }
      if (JGHHFKPBNGJ != false) {
        size += 1 + 1;
      }
      if (BuffId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuffId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NICLOFEHINN other) {
      if (other == null) {
        return;
      }
      if (other.HHIDNMNPCLM != false) {
        HHIDNMNPCLM = other.HHIDNMNPCLM;
      }
      if (other.HCNOCFJFEPH != 0) {
        HCNOCFJFEPH = other.HCNOCFJFEPH;
      }
      if (other.costData_ != null) {
        if (costData_ == null) {
          CostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
        }
        CostData.MergeFrom(other.CostData);
      }
      if (other.JGHHFKPBNGJ != false) {
        JGHHFKPBNGJ = other.JGHHFKPBNGJ;
      }
      if (other.BuffId != 0) {
        BuffId = other.BuffId;
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
            BuffId = input.ReadUInt32();
            break;
          }
          case 56: {
            JGHHFKPBNGJ = input.ReadBool();
            break;
          }
          case 64: {
            HHIDNMNPCLM = input.ReadBool();
            break;
          }
          case 82: {
            if (costData_ == null) {
              CostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(CostData);
            break;
          }
          case 112: {
            HCNOCFJFEPH = input.ReadUInt32();
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
            BuffId = input.ReadUInt32();
            break;
          }
          case 56: {
            JGHHFKPBNGJ = input.ReadBool();
            break;
          }
          case 64: {
            HHIDNMNPCLM = input.ReadBool();
            break;
          }
          case 82: {
            if (costData_ == null) {
              CostData = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(CostData);
            break;
          }
          case 112: {
            HCNOCFJFEPH = input.ReadUInt32();
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
