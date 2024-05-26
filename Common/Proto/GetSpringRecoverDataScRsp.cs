// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetSpringRecoverDataScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetSpringRecoverDataScRsp.proto</summary>
  public static partial class GetSpringRecoverDataScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetSpringRecoverDataScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetSpringRecoverDataScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9HZXRTcHJpbmdSZWNvdmVyRGF0YVNjUnNwLnByb3RvGhJIZWFsUG9vbElu",
            "Zm8ucHJvdG8aGVNwcmluZ1JlY292ZXJDb25maWcucHJvdG8iiAEKGUdldFNw",
            "cmluZ1JlY292ZXJEYXRhU2NSc3ASMwoVc3ByaW5nX3JlY292ZXJfY29uZmln",
            "GAMgASgLMhQuU3ByaW5nUmVjb3ZlckNvbmZpZxIPCgdyZXRjb2RlGA8gASgN",
            "EiUKDmhlYWxfcG9vbF9pbmZvGAYgASgLMg0uSGVhbFBvb2xJbmZvQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HealPoolInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SpringRecoverConfigReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetSpringRecoverDataScRsp), global::EggLink.DanhengServer.Proto.GetSpringRecoverDataScRsp.Parser, new[]{ "SpringRecoverConfig", "Retcode", "HealPoolInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetSpringRecoverDataScRsp : pb::IMessage<GetSpringRecoverDataScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetSpringRecoverDataScRsp> _parser = new pb::MessageParser<GetSpringRecoverDataScRsp>(() => new GetSpringRecoverDataScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetSpringRecoverDataScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetSpringRecoverDataScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSpringRecoverDataScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSpringRecoverDataScRsp(GetSpringRecoverDataScRsp other) : this() {
      springRecoverConfig_ = other.springRecoverConfig_ != null ? other.springRecoverConfig_.Clone() : null;
      retcode_ = other.retcode_;
      healPoolInfo_ = other.healPoolInfo_ != null ? other.healPoolInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSpringRecoverDataScRsp Clone() {
      return new GetSpringRecoverDataScRsp(this);
    }

    /// <summary>Field number for the "spring_recover_config" field.</summary>
    public const int SpringRecoverConfigFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.SpringRecoverConfig springRecoverConfig_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SpringRecoverConfig SpringRecoverConfig {
      get { return springRecoverConfig_; }
      set {
        springRecoverConfig_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 15;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "heal_pool_info" field.</summary>
    public const int HealPoolInfoFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.HealPoolInfo healPoolInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HealPoolInfo HealPoolInfo {
      get { return healPoolInfo_; }
      set {
        healPoolInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetSpringRecoverDataScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetSpringRecoverDataScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(SpringRecoverConfig, other.SpringRecoverConfig)) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(HealPoolInfo, other.HealPoolInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (springRecoverConfig_ != null) hash ^= SpringRecoverConfig.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (healPoolInfo_ != null) hash ^= HealPoolInfo.GetHashCode();
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
      if (springRecoverConfig_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(SpringRecoverConfig);
      }
      if (healPoolInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(HealPoolInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(120);
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
      if (springRecoverConfig_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(SpringRecoverConfig);
      }
      if (healPoolInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(HealPoolInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(120);
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
      if (springRecoverConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpringRecoverConfig);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (healPoolInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HealPoolInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetSpringRecoverDataScRsp other) {
      if (other == null) {
        return;
      }
      if (other.springRecoverConfig_ != null) {
        if (springRecoverConfig_ == null) {
          SpringRecoverConfig = new global::EggLink.DanhengServer.Proto.SpringRecoverConfig();
        }
        SpringRecoverConfig.MergeFrom(other.SpringRecoverConfig);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.healPoolInfo_ != null) {
        if (healPoolInfo_ == null) {
          HealPoolInfo = new global::EggLink.DanhengServer.Proto.HealPoolInfo();
        }
        HealPoolInfo.MergeFrom(other.HealPoolInfo);
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
          case 26: {
            if (springRecoverConfig_ == null) {
              SpringRecoverConfig = new global::EggLink.DanhengServer.Proto.SpringRecoverConfig();
            }
            input.ReadMessage(SpringRecoverConfig);
            break;
          }
          case 50: {
            if (healPoolInfo_ == null) {
              HealPoolInfo = new global::EggLink.DanhengServer.Proto.HealPoolInfo();
            }
            input.ReadMessage(HealPoolInfo);
            break;
          }
          case 120: {
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
          case 26: {
            if (springRecoverConfig_ == null) {
              SpringRecoverConfig = new global::EggLink.DanhengServer.Proto.SpringRecoverConfig();
            }
            input.ReadMessage(SpringRecoverConfig);
            break;
          }
          case 50: {
            if (healPoolInfo_ == null) {
              HealPoolInfo = new global::EggLink.DanhengServer.Proto.HealPoolInfo();
            }
            input.ReadMessage(HealPoolInfo);
            break;
          }
          case 120: {
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