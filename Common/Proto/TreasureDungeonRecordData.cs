// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TreasureDungeonRecordData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TreasureDungeonRecordData.proto</summary>
  public static partial class TreasureDungeonRecordDataReflection {

    #region Descriptor
    /// <summary>File descriptor for TreasureDungeonRecordData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TreasureDungeonRecordDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9UcmVhc3VyZUR1bmdlb25SZWNvcmREYXRhLnByb3RvGh9UcmVhc3VyZUR1",
            "bmdlb25SZWNvcmRUeXBlLnByb3RvIpUBChlUcmVhc3VyZUR1bmdlb25SZWNv",
            "cmREYXRhEhYKDnNvdXJjZV9ncmlkX2lkGAQgASgNEg4KBnBhcmFtMRgKIAEo",
            "DRIoCgR0eXBlGAwgASgOMhouVHJlYXN1cmVEdW5nZW9uUmVjb3JkVHlwZRIW",
            "Cg50YXJnZXRfZ3JpZF9pZBgDIAEoDRIOCgZwYXJhbTIYBSABKA1CHqoCG0Vn",
            "Z0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.TreasureDungeonRecordTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TreasureDungeonRecordData), global::EggLink.DanhengServer.Proto.TreasureDungeonRecordData.Parser, new[]{ "SourceGridId", "Param1", "Type", "TargetGridId", "Param2" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TreasureDungeonRecordData : pb::IMessage<TreasureDungeonRecordData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TreasureDungeonRecordData> _parser = new pb::MessageParser<TreasureDungeonRecordData>(() => new TreasureDungeonRecordData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TreasureDungeonRecordData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TreasureDungeonRecordDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureDungeonRecordData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureDungeonRecordData(TreasureDungeonRecordData other) : this() {
      sourceGridId_ = other.sourceGridId_;
      param1_ = other.param1_;
      type_ = other.type_;
      targetGridId_ = other.targetGridId_;
      param2_ = other.param2_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureDungeonRecordData Clone() {
      return new TreasureDungeonRecordData(this);
    }

    /// <summary>Field number for the "source_grid_id" field.</summary>
    public const int SourceGridIdFieldNumber = 4;
    private uint sourceGridId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SourceGridId {
      get { return sourceGridId_; }
      set {
        sourceGridId_ = value;
      }
    }

    /// <summary>Field number for the "param1" field.</summary>
    public const int Param1FieldNumber = 10;
    private uint param1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Param1 {
      get { return param1_; }
      set {
        param1_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.TreasureDungeonRecordType type_ = global::EggLink.DanhengServer.Proto.TreasureDungeonRecordType.TreasureDungeonRecordNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.TreasureDungeonRecordType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "target_grid_id" field.</summary>
    public const int TargetGridIdFieldNumber = 3;
    private uint targetGridId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetGridId {
      get { return targetGridId_; }
      set {
        targetGridId_ = value;
      }
    }

    /// <summary>Field number for the "param2" field.</summary>
    public const int Param2FieldNumber = 5;
    private uint param2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Param2 {
      get { return param2_; }
      set {
        param2_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TreasureDungeonRecordData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TreasureDungeonRecordData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SourceGridId != other.SourceGridId) return false;
      if (Param1 != other.Param1) return false;
      if (Type != other.Type) return false;
      if (TargetGridId != other.TargetGridId) return false;
      if (Param2 != other.Param2) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SourceGridId != 0) hash ^= SourceGridId.GetHashCode();
      if (Param1 != 0) hash ^= Param1.GetHashCode();
      if (Type != global::EggLink.DanhengServer.Proto.TreasureDungeonRecordType.TreasureDungeonRecordNone) hash ^= Type.GetHashCode();
      if (TargetGridId != 0) hash ^= TargetGridId.GetHashCode();
      if (Param2 != 0) hash ^= Param2.GetHashCode();
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
      if (TargetGridId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TargetGridId);
      }
      if (SourceGridId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SourceGridId);
      }
      if (Param2 != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Param2);
      }
      if (Param1 != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Param1);
      }
      if (Type != global::EggLink.DanhengServer.Proto.TreasureDungeonRecordType.TreasureDungeonRecordNone) {
        output.WriteRawTag(96);
        output.WriteEnum((int) Type);
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
      if (TargetGridId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TargetGridId);
      }
      if (SourceGridId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SourceGridId);
      }
      if (Param2 != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Param2);
      }
      if (Param1 != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Param1);
      }
      if (Type != global::EggLink.DanhengServer.Proto.TreasureDungeonRecordType.TreasureDungeonRecordNone) {
        output.WriteRawTag(96);
        output.WriteEnum((int) Type);
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
      if (SourceGridId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceGridId);
      }
      if (Param1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Param1);
      }
      if (Type != global::EggLink.DanhengServer.Proto.TreasureDungeonRecordType.TreasureDungeonRecordNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (TargetGridId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetGridId);
      }
      if (Param2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Param2);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TreasureDungeonRecordData other) {
      if (other == null) {
        return;
      }
      if (other.SourceGridId != 0) {
        SourceGridId = other.SourceGridId;
      }
      if (other.Param1 != 0) {
        Param1 = other.Param1;
      }
      if (other.Type != global::EggLink.DanhengServer.Proto.TreasureDungeonRecordType.TreasureDungeonRecordNone) {
        Type = other.Type;
      }
      if (other.TargetGridId != 0) {
        TargetGridId = other.TargetGridId;
      }
      if (other.Param2 != 0) {
        Param2 = other.Param2;
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
            TargetGridId = input.ReadUInt32();
            break;
          }
          case 32: {
            SourceGridId = input.ReadUInt32();
            break;
          }
          case 40: {
            Param2 = input.ReadUInt32();
            break;
          }
          case 80: {
            Param1 = input.ReadUInt32();
            break;
          }
          case 96: {
            Type = (global::EggLink.DanhengServer.Proto.TreasureDungeonRecordType) input.ReadEnum();
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
            TargetGridId = input.ReadUInt32();
            break;
          }
          case 32: {
            SourceGridId = input.ReadUInt32();
            break;
          }
          case 40: {
            Param2 = input.ReadUInt32();
            break;
          }
          case 80: {
            Param1 = input.ReadUInt32();
            break;
          }
          case 96: {
            Type = (global::EggLink.DanhengServer.Proto.TreasureDungeonRecordType) input.ReadEnum();
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
