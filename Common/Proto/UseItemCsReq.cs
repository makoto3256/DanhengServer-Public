// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UseItemCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from UseItemCsReq.proto</summary>
  public static partial class UseItemCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for UseItemCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJVc2VJdGVtQ3NSZXEucHJvdG8aEEF2YXRhclR5cGUucHJvdG8ipwEKDFVz",
            "ZUl0ZW1Dc1JlcRIaChJvcHRpb25hbF9yZXdhcmRfaWQYBSABKA0SEwoLSU5O",
            "Q0NQT05ISUwYBCABKA0SEwoLTUdQTENJREdFTEIYDCABKAgSFgoOYmFzZV9h",
            "dmF0YXJfaWQYDSABKA0SEwoLT0lQRUJITEtIUEUYDiABKA0SJAoPdXNlX2F2",
            "YXRhcl90eXBlGAkgASgOMgsuQXZhdGFyVHlwZUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AvatarTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.UseItemCsReq), global::EggLink.DanhengServer.Proto.UseItemCsReq.Parser, new[]{ "OptionalRewardId", "INNCCPONHIL", "MGPLCIDGELB", "BaseAvatarId", "OIPEBHLKHPE", "UseAvatarType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UseItemCsReq : pb::IMessage<UseItemCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UseItemCsReq> _parser = new pb::MessageParser<UseItemCsReq>(() => new UseItemCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UseItemCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.UseItemCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseItemCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseItemCsReq(UseItemCsReq other) : this() {
      optionalRewardId_ = other.optionalRewardId_;
      iNNCCPONHIL_ = other.iNNCCPONHIL_;
      mGPLCIDGELB_ = other.mGPLCIDGELB_;
      baseAvatarId_ = other.baseAvatarId_;
      oIPEBHLKHPE_ = other.oIPEBHLKHPE_;
      useAvatarType_ = other.useAvatarType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UseItemCsReq Clone() {
      return new UseItemCsReq(this);
    }

    /// <summary>Field number for the "optional_reward_id" field.</summary>
    public const int OptionalRewardIdFieldNumber = 5;
    private uint optionalRewardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OptionalRewardId {
      get { return optionalRewardId_; }
      set {
        optionalRewardId_ = value;
      }
    }

    /// <summary>Field number for the "INNCCPONHIL" field.</summary>
    public const int INNCCPONHILFieldNumber = 4;
    private uint iNNCCPONHIL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint INNCCPONHIL {
      get { return iNNCCPONHIL_; }
      set {
        iNNCCPONHIL_ = value;
      }
    }

    /// <summary>Field number for the "MGPLCIDGELB" field.</summary>
    public const int MGPLCIDGELBFieldNumber = 12;
    private bool mGPLCIDGELB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool MGPLCIDGELB {
      get { return mGPLCIDGELB_; }
      set {
        mGPLCIDGELB_ = value;
      }
    }

    /// <summary>Field number for the "base_avatar_id" field.</summary>
    public const int BaseAvatarIdFieldNumber = 13;
    private uint baseAvatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BaseAvatarId {
      get { return baseAvatarId_; }
      set {
        baseAvatarId_ = value;
      }
    }

    /// <summary>Field number for the "OIPEBHLKHPE" field.</summary>
    public const int OIPEBHLKHPEFieldNumber = 14;
    private uint oIPEBHLKHPE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OIPEBHLKHPE {
      get { return oIPEBHLKHPE_; }
      set {
        oIPEBHLKHPE_ = value;
      }
    }

    /// <summary>Field number for the "use_avatar_type" field.</summary>
    public const int UseAvatarTypeFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.AvatarType useAvatarType_ = global::EggLink.DanhengServer.Proto.AvatarType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AvatarType UseAvatarType {
      get { return useAvatarType_; }
      set {
        useAvatarType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UseItemCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UseItemCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OptionalRewardId != other.OptionalRewardId) return false;
      if (INNCCPONHIL != other.INNCCPONHIL) return false;
      if (MGPLCIDGELB != other.MGPLCIDGELB) return false;
      if (BaseAvatarId != other.BaseAvatarId) return false;
      if (OIPEBHLKHPE != other.OIPEBHLKHPE) return false;
      if (UseAvatarType != other.UseAvatarType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OptionalRewardId != 0) hash ^= OptionalRewardId.GetHashCode();
      if (INNCCPONHIL != 0) hash ^= INNCCPONHIL.GetHashCode();
      if (MGPLCIDGELB != false) hash ^= MGPLCIDGELB.GetHashCode();
      if (BaseAvatarId != 0) hash ^= BaseAvatarId.GetHashCode();
      if (OIPEBHLKHPE != 0) hash ^= OIPEBHLKHPE.GetHashCode();
      if (UseAvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) hash ^= UseAvatarType.GetHashCode();
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
      if (INNCCPONHIL != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(INNCCPONHIL);
      }
      if (OptionalRewardId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(OptionalRewardId);
      }
      if (UseAvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        output.WriteRawTag(72);
        output.WriteEnum((int) UseAvatarType);
      }
      if (MGPLCIDGELB != false) {
        output.WriteRawTag(96);
        output.WriteBool(MGPLCIDGELB);
      }
      if (BaseAvatarId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(BaseAvatarId);
      }
      if (OIPEBHLKHPE != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(OIPEBHLKHPE);
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
      if (INNCCPONHIL != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(INNCCPONHIL);
      }
      if (OptionalRewardId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(OptionalRewardId);
      }
      if (UseAvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        output.WriteRawTag(72);
        output.WriteEnum((int) UseAvatarType);
      }
      if (MGPLCIDGELB != false) {
        output.WriteRawTag(96);
        output.WriteBool(MGPLCIDGELB);
      }
      if (BaseAvatarId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(BaseAvatarId);
      }
      if (OIPEBHLKHPE != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(OIPEBHLKHPE);
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
      if (OptionalRewardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OptionalRewardId);
      }
      if (INNCCPONHIL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(INNCCPONHIL);
      }
      if (MGPLCIDGELB != false) {
        size += 1 + 1;
      }
      if (BaseAvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BaseAvatarId);
      }
      if (OIPEBHLKHPE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OIPEBHLKHPE);
      }
      if (UseAvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UseAvatarType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UseItemCsReq other) {
      if (other == null) {
        return;
      }
      if (other.OptionalRewardId != 0) {
        OptionalRewardId = other.OptionalRewardId;
      }
      if (other.INNCCPONHIL != 0) {
        INNCCPONHIL = other.INNCCPONHIL;
      }
      if (other.MGPLCIDGELB != false) {
        MGPLCIDGELB = other.MGPLCIDGELB;
      }
      if (other.BaseAvatarId != 0) {
        BaseAvatarId = other.BaseAvatarId;
      }
      if (other.OIPEBHLKHPE != 0) {
        OIPEBHLKHPE = other.OIPEBHLKHPE;
      }
      if (other.UseAvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        UseAvatarType = other.UseAvatarType;
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
          case 32: {
            INNCCPONHIL = input.ReadUInt32();
            break;
          }
          case 40: {
            OptionalRewardId = input.ReadUInt32();
            break;
          }
          case 72: {
            UseAvatarType = (global::EggLink.DanhengServer.Proto.AvatarType) input.ReadEnum();
            break;
          }
          case 96: {
            MGPLCIDGELB = input.ReadBool();
            break;
          }
          case 104: {
            BaseAvatarId = input.ReadUInt32();
            break;
          }
          case 112: {
            OIPEBHLKHPE = input.ReadUInt32();
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
          case 32: {
            INNCCPONHIL = input.ReadUInt32();
            break;
          }
          case 40: {
            OptionalRewardId = input.ReadUInt32();
            break;
          }
          case 72: {
            UseAvatarType = (global::EggLink.DanhengServer.Proto.AvatarType) input.ReadEnum();
            break;
          }
          case 96: {
            MGPLCIDGELB = input.ReadBool();
            break;
          }
          case 104: {
            BaseAvatarId = input.ReadUInt32();
            break;
          }
          case 112: {
            OIPEBHLKHPE = input.ReadUInt32();
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
