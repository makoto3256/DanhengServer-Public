// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChallengeStoryInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChallengeStoryInfo.proto</summary>
  public static partial class ChallengeStoryInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChallengeStoryInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChallengeStoryInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhDaGFsbGVuZ2VTdG9yeUluZm8ucHJvdG8aHENoYWxsZW5nZVN0b3J5QnVm",
            "ZkluZm8ucHJvdG8iVgoSQ2hhbGxlbmdlU3RvcnlJbmZvEjEKDmN1cl9zdG9y",
            "eV9idWZmGAUgASgLMhcuQ2hhbGxlbmdlU3RvcnlCdWZmSW5mb0gAQg0KC05P",
            "Sk5IR0hLSkpFQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChallengeStoryBuffInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChallengeStoryInfo), global::EggLink.DanhengServer.Proto.ChallengeStoryInfo.Parser, new[]{ "CurStoryBuff" }, new[]{ "NOJNHGHKJJE" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChallengeStoryInfo : pb::IMessage<ChallengeStoryInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChallengeStoryInfo> _parser = new pb::MessageParser<ChallengeStoryInfo>(() => new ChallengeStoryInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChallengeStoryInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChallengeStoryInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChallengeStoryInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChallengeStoryInfo(ChallengeStoryInfo other) : this() {
      switch (other.NOJNHGHKJJECase) {
        case NOJNHGHKJJEOneofCase.CurStoryBuff:
          CurStoryBuff = other.CurStoryBuff.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChallengeStoryInfo Clone() {
      return new ChallengeStoryInfo(this);
    }

    /// <summary>Field number for the "cur_story_buff" field.</summary>
    public const int CurStoryBuffFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChallengeStoryBuffInfo CurStoryBuff {
      get { return nOJNHGHKJJECase_ == NOJNHGHKJJEOneofCase.CurStoryBuff ? (global::EggLink.DanhengServer.Proto.ChallengeStoryBuffInfo) nOJNHGHKJJE_ : null; }
      set {
        nOJNHGHKJJE_ = value;
        nOJNHGHKJJECase_ = value == null ? NOJNHGHKJJEOneofCase.None : NOJNHGHKJJEOneofCase.CurStoryBuff;
      }
    }

    private object nOJNHGHKJJE_;
    /// <summary>Enum of possible cases for the "NOJNHGHKJJE" oneof.</summary>
    public enum NOJNHGHKJJEOneofCase {
      None = 0,
      CurStoryBuff = 5,
    }
    private NOJNHGHKJJEOneofCase nOJNHGHKJJECase_ = NOJNHGHKJJEOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NOJNHGHKJJEOneofCase NOJNHGHKJJECase {
      get { return nOJNHGHKJJECase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearNOJNHGHKJJE() {
      nOJNHGHKJJECase_ = NOJNHGHKJJEOneofCase.None;
      nOJNHGHKJJE_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChallengeStoryInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChallengeStoryInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CurStoryBuff, other.CurStoryBuff)) return false;
      if (NOJNHGHKJJECase != other.NOJNHGHKJJECase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (nOJNHGHKJJECase_ == NOJNHGHKJJEOneofCase.CurStoryBuff) hash ^= CurStoryBuff.GetHashCode();
      hash ^= (int) nOJNHGHKJJECase_;
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
      if (nOJNHGHKJJECase_ == NOJNHGHKJJEOneofCase.CurStoryBuff) {
        output.WriteRawTag(42);
        output.WriteMessage(CurStoryBuff);
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
      if (nOJNHGHKJJECase_ == NOJNHGHKJJEOneofCase.CurStoryBuff) {
        output.WriteRawTag(42);
        output.WriteMessage(CurStoryBuff);
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
      if (nOJNHGHKJJECase_ == NOJNHGHKJJEOneofCase.CurStoryBuff) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurStoryBuff);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChallengeStoryInfo other) {
      if (other == null) {
        return;
      }
      switch (other.NOJNHGHKJJECase) {
        case NOJNHGHKJJEOneofCase.CurStoryBuff:
          if (CurStoryBuff == null) {
            CurStoryBuff = new global::EggLink.DanhengServer.Proto.ChallengeStoryBuffInfo();
          }
          CurStoryBuff.MergeFrom(other.CurStoryBuff);
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
          case 42: {
            global::EggLink.DanhengServer.Proto.ChallengeStoryBuffInfo subBuilder = new global::EggLink.DanhengServer.Proto.ChallengeStoryBuffInfo();
            if (nOJNHGHKJJECase_ == NOJNHGHKJJEOneofCase.CurStoryBuff) {
              subBuilder.MergeFrom(CurStoryBuff);
            }
            input.ReadMessage(subBuilder);
            CurStoryBuff = subBuilder;
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
          case 42: {
            global::EggLink.DanhengServer.Proto.ChallengeStoryBuffInfo subBuilder = new global::EggLink.DanhengServer.Proto.ChallengeStoryBuffInfo();
            if (nOJNHGHKJJECase_ == NOJNHGHKJJEOneofCase.CurStoryBuff) {
              subBuilder.MergeFrom(CurStoryBuff);
            }
            input.ReadMessage(subBuilder);
            CurStoryBuff = subBuilder;
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
