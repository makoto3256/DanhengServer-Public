// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RestoreWolfBroGameArchiveScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RestoreWolfBroGameArchiveScRsp.proto</summary>
  public static partial class RestoreWolfBroGameArchiveScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for RestoreWolfBroGameArchiveScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RestoreWolfBroGameArchiveScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRSZXN0b3JlV29sZkJyb0dhbWVBcmNoaXZlU2NSc3AucHJvdG8aFVdvbGZC",
            "cm9HYW1lRGF0YS5wcm90byJfCh5SZXN0b3JlV29sZkJyb0dhbWVBcmNoaXZl",
            "U2NSc3ASDwoHcmV0Y29kZRgGIAEoDRIsChJ3b2xmX2Jyb19nYW1lX2RhdGEY",
            "BSABKAsyEC5Xb2xmQnJvR2FtZURhdGFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.WolfBroGameDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RestoreWolfBroGameArchiveScRsp), global::EggLink.DanhengServer.Proto.RestoreWolfBroGameArchiveScRsp.Parser, new[]{ "Retcode", "WolfBroGameData" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RestoreWolfBroGameArchiveScRsp : pb::IMessage<RestoreWolfBroGameArchiveScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RestoreWolfBroGameArchiveScRsp> _parser = new pb::MessageParser<RestoreWolfBroGameArchiveScRsp>(() => new RestoreWolfBroGameArchiveScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RestoreWolfBroGameArchiveScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RestoreWolfBroGameArchiveScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RestoreWolfBroGameArchiveScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RestoreWolfBroGameArchiveScRsp(RestoreWolfBroGameArchiveScRsp other) : this() {
      retcode_ = other.retcode_;
      wolfBroGameData_ = other.wolfBroGameData_ != null ? other.wolfBroGameData_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RestoreWolfBroGameArchiveScRsp Clone() {
      return new RestoreWolfBroGameArchiveScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 6;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "wolf_bro_game_data" field.</summary>
    public const int WolfBroGameDataFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.WolfBroGameData wolfBroGameData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.WolfBroGameData WolfBroGameData {
      get { return wolfBroGameData_; }
      set {
        wolfBroGameData_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RestoreWolfBroGameArchiveScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RestoreWolfBroGameArchiveScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(WolfBroGameData, other.WolfBroGameData)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (wolfBroGameData_ != null) hash ^= WolfBroGameData.GetHashCode();
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
      if (wolfBroGameData_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(WolfBroGameData);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
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
      if (wolfBroGameData_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(WolfBroGameData);
      }
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Retcode);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (wolfBroGameData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(WolfBroGameData);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RestoreWolfBroGameArchiveScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.wolfBroGameData_ != null) {
        if (wolfBroGameData_ == null) {
          WolfBroGameData = new global::EggLink.DanhengServer.Proto.WolfBroGameData();
        }
        WolfBroGameData.MergeFrom(other.WolfBroGameData);
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
            if (wolfBroGameData_ == null) {
              WolfBroGameData = new global::EggLink.DanhengServer.Proto.WolfBroGameData();
            }
            input.ReadMessage(WolfBroGameData);
            break;
          }
          case 48: {
            Retcode = input.ReadUInt32();
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
            if (wolfBroGameData_ == null) {
              WolfBroGameData = new global::EggLink.DanhengServer.Proto.WolfBroGameData();
            }
            input.ReadMessage(WolfBroGameData);
            break;
          }
          case 48: {
            Retcode = input.ReadUInt32();
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
