// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SectionStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SectionStatus.proto</summary>
  public static partial class SectionStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for SectionStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SectionStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNTZWN0aW9uU3RhdHVzLnByb3RvGhpNZXNzYWdlU2VjdGlvblN0YXR1cy5w",
            "cm90byJSCg1TZWN0aW9uU3RhdHVzEhIKCnNlY3Rpb25faWQYDSABKA0SLQoO",
            "c2VjdGlvbl9zdGF0dXMYAyABKA4yFS5NZXNzYWdlU2VjdGlvblN0YXR1c0Ie",
            "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MessageSectionStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SectionStatus), global::EggLink.DanhengServer.Proto.SectionStatus.Parser, new[]{ "SectionId", "SectionStatus_" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SectionStatus : pb::IMessage<SectionStatus>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SectionStatus> _parser = new pb::MessageParser<SectionStatus>(() => new SectionStatus());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SectionStatus> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SectionStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SectionStatus() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SectionStatus(SectionStatus other) : this() {
      sectionId_ = other.sectionId_;
      sectionStatus_ = other.sectionStatus_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SectionStatus Clone() {
      return new SectionStatus(this);
    }

    /// <summary>Field number for the "section_id" field.</summary>
    public const int SectionIdFieldNumber = 13;
    private uint sectionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SectionId {
      get { return sectionId_; }
      set {
        sectionId_ = value;
      }
    }

    /// <summary>Field number for the "section_status" field.</summary>
    public const int SectionStatus_FieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.MessageSectionStatus sectionStatus_ = global::EggLink.DanhengServer.Proto.MessageSectionStatus.MessageSectionNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MessageSectionStatus SectionStatus_ {
      get { return sectionStatus_; }
      set {
        sectionStatus_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SectionStatus);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SectionStatus other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SectionId != other.SectionId) return false;
      if (SectionStatus_ != other.SectionStatus_) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SectionId != 0) hash ^= SectionId.GetHashCode();
      if (SectionStatus_ != global::EggLink.DanhengServer.Proto.MessageSectionStatus.MessageSectionNone) hash ^= SectionStatus_.GetHashCode();
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
      if (SectionStatus_ != global::EggLink.DanhengServer.Proto.MessageSectionStatus.MessageSectionNone) {
        output.WriteRawTag(24);
        output.WriteEnum((int) SectionStatus_);
      }
      if (SectionId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(SectionId);
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
      if (SectionStatus_ != global::EggLink.DanhengServer.Proto.MessageSectionStatus.MessageSectionNone) {
        output.WriteRawTag(24);
        output.WriteEnum((int) SectionStatus_);
      }
      if (SectionId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(SectionId);
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
      if (SectionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SectionId);
      }
      if (SectionStatus_ != global::EggLink.DanhengServer.Proto.MessageSectionStatus.MessageSectionNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) SectionStatus_);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SectionStatus other) {
      if (other == null) {
        return;
      }
      if (other.SectionId != 0) {
        SectionId = other.SectionId;
      }
      if (other.SectionStatus_ != global::EggLink.DanhengServer.Proto.MessageSectionStatus.MessageSectionNone) {
        SectionStatus_ = other.SectionStatus_;
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
            SectionStatus_ = (global::EggLink.DanhengServer.Proto.MessageSectionStatus) input.ReadEnum();
            break;
          }
          case 104: {
            SectionId = input.ReadUInt32();
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
            SectionStatus_ = (global::EggLink.DanhengServer.Proto.MessageSectionStatus) input.ReadEnum();
            break;
          }
          case 104: {
            SectionId = input.ReadUInt32();
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
