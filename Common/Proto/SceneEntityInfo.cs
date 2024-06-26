// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneEntityInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SceneEntityInfo.proto</summary>
  public static partial class SceneEntityInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneEntityInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneEntityInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVTY2VuZUVudGl0eUluZm8ucHJvdG8aEE1vdGlvbkluZm8ucHJvdG8aFFNj",
            "ZW5lQWN0b3JJbmZvLnByb3RvGhlTY2VuZU5wY01vbnN0ZXJJbmZvLnByb3Rv",
            "GhJTY2VuZU5wY0luZm8ucHJvdG8aGVNjZW5lU3VtbW9uVW5pdEluZm8ucHJv",
            "dG8aE1NjZW5lUHJvcEluZm8ucHJvdG8isQIKD1NjZW5lRW50aXR5SW5mbxIR",
            "CgllbnRpdHlfaWQYDCABKA0SEAoIZ3JvdXBfaWQYAiABKA0SDwoHaW5zdF9p",
            "ZBgBIAEoDRIbCgZtb3Rpb24YBSABKAsyCy5Nb3Rpb25JbmZvEiAKBWFjdG9y",
            "GAggASgLMg8uU2NlbmVBY3RvckluZm9IABIrCgtucGNfbW9uc3RlchgKIAEo",
            "CzIULlNjZW5lTnBjTW9uc3RlckluZm9IABIcCgNucGMYAyABKAsyDS5TY2Vu",
            "ZU5wY0luZm9IABIeCgRwcm9wGA0gASgLMg4uU2NlbmVQcm9wSW5mb0gAEisK",
            "C3N1bW1vbl91bml0GA4gASgLMhQuU2NlbmVTdW1tb25Vbml0SW5mb0gAQhEK",
            "D0VudGl0eU9uZW9mQ2FzZUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy",
            "b3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MotionInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneActorInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneNpcMonsterInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneNpcInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneSummonUnitInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ScenePropInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SceneEntityInfo), global::EggLink.DanhengServer.Proto.SceneEntityInfo.Parser, new[]{ "EntityId", "GroupId", "InstId", "Motion", "Actor", "NpcMonster", "Npc", "Prop", "SummonUnit" }, new[]{ "EntityOneofCase" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SceneEntityInfo : pb::IMessage<SceneEntityInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneEntityInfo> _parser = new pb::MessageParser<SceneEntityInfo>(() => new SceneEntityInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneEntityInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SceneEntityInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityInfo(SceneEntityInfo other) : this() {
      entityId_ = other.entityId_;
      groupId_ = other.groupId_;
      instId_ = other.instId_;
      motion_ = other.motion_ != null ? other.motion_.Clone() : null;
      switch (other.EntityOneofCaseCase) {
        case EntityOneofCaseOneofCase.Actor:
          Actor = other.Actor.Clone();
          break;
        case EntityOneofCaseOneofCase.NpcMonster:
          NpcMonster = other.NpcMonster.Clone();
          break;
        case EntityOneofCaseOneofCase.Npc:
          Npc = other.Npc.Clone();
          break;
        case EntityOneofCaseOneofCase.Prop:
          Prop = other.Prop.Clone();
          break;
        case EntityOneofCaseOneofCase.SummonUnit:
          SummonUnit = other.SummonUnit.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityInfo Clone() {
      return new SceneEntityInfo(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 12;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 2;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "inst_id" field.</summary>
    public const int InstIdFieldNumber = 1;
    private uint instId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint InstId {
      get { return instId_; }
      set {
        instId_ = value;
      }
    }

    /// <summary>Field number for the "motion" field.</summary>
    public const int MotionFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.MotionInfo motion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MotionInfo Motion {
      get { return motion_; }
      set {
        motion_ = value;
      }
    }

    /// <summary>Field number for the "actor" field.</summary>
    public const int ActorFieldNumber = 8;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneActorInfo Actor {
      get { return entityOneofCaseCase_ == EntityOneofCaseOneofCase.Actor ? (global::EggLink.DanhengServer.Proto.SceneActorInfo) entityOneofCase_ : null; }
      set {
        entityOneofCase_ = value;
        entityOneofCaseCase_ = value == null ? EntityOneofCaseOneofCase.None : EntityOneofCaseOneofCase.Actor;
      }
    }

    /// <summary>Field number for the "npc_monster" field.</summary>
    public const int NpcMonsterFieldNumber = 10;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneNpcMonsterInfo NpcMonster {
      get { return entityOneofCaseCase_ == EntityOneofCaseOneofCase.NpcMonster ? (global::EggLink.DanhengServer.Proto.SceneNpcMonsterInfo) entityOneofCase_ : null; }
      set {
        entityOneofCase_ = value;
        entityOneofCaseCase_ = value == null ? EntityOneofCaseOneofCase.None : EntityOneofCaseOneofCase.NpcMonster;
      }
    }

    /// <summary>Field number for the "npc" field.</summary>
    public const int NpcFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneNpcInfo Npc {
      get { return entityOneofCaseCase_ == EntityOneofCaseOneofCase.Npc ? (global::EggLink.DanhengServer.Proto.SceneNpcInfo) entityOneofCase_ : null; }
      set {
        entityOneofCase_ = value;
        entityOneofCaseCase_ = value == null ? EntityOneofCaseOneofCase.None : EntityOneofCaseOneofCase.Npc;
      }
    }

    /// <summary>Field number for the "prop" field.</summary>
    public const int PropFieldNumber = 13;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ScenePropInfo Prop {
      get { return entityOneofCaseCase_ == EntityOneofCaseOneofCase.Prop ? (global::EggLink.DanhengServer.Proto.ScenePropInfo) entityOneofCase_ : null; }
      set {
        entityOneofCase_ = value;
        entityOneofCaseCase_ = value == null ? EntityOneofCaseOneofCase.None : EntityOneofCaseOneofCase.Prop;
      }
    }

    /// <summary>Field number for the "summon_unit" field.</summary>
    public const int SummonUnitFieldNumber = 14;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneSummonUnitInfo SummonUnit {
      get { return entityOneofCaseCase_ == EntityOneofCaseOneofCase.SummonUnit ? (global::EggLink.DanhengServer.Proto.SceneSummonUnitInfo) entityOneofCase_ : null; }
      set {
        entityOneofCase_ = value;
        entityOneofCaseCase_ = value == null ? EntityOneofCaseOneofCase.None : EntityOneofCaseOneofCase.SummonUnit;
      }
    }

    private object entityOneofCase_;
    /// <summary>Enum of possible cases for the "EntityOneofCase" oneof.</summary>
    public enum EntityOneofCaseOneofCase {
      None = 0,
      Actor = 8,
      NpcMonster = 10,
      Npc = 3,
      Prop = 13,
      SummonUnit = 14,
    }
    private EntityOneofCaseOneofCase entityOneofCaseCase_ = EntityOneofCaseOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityOneofCaseOneofCase EntityOneofCaseCase {
      get { return entityOneofCaseCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearEntityOneofCase() {
      entityOneofCaseCase_ = EntityOneofCaseOneofCase.None;
      entityOneofCase_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneEntityInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneEntityInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (GroupId != other.GroupId) return false;
      if (InstId != other.InstId) return false;
      if (!object.Equals(Motion, other.Motion)) return false;
      if (!object.Equals(Actor, other.Actor)) return false;
      if (!object.Equals(NpcMonster, other.NpcMonster)) return false;
      if (!object.Equals(Npc, other.Npc)) return false;
      if (!object.Equals(Prop, other.Prop)) return false;
      if (!object.Equals(SummonUnit, other.SummonUnit)) return false;
      if (EntityOneofCaseCase != other.EntityOneofCaseCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (InstId != 0) hash ^= InstId.GetHashCode();
      if (motion_ != null) hash ^= Motion.GetHashCode();
      if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.Actor) hash ^= Actor.GetHashCode();
      if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.NpcMonster) hash ^= NpcMonster.GetHashCode();
      if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.Npc) hash ^= Npc.GetHashCode();
      if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.Prop) hash ^= Prop.GetHashCode();
      if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.SummonUnit) hash ^= SummonUnit.GetHashCode();
      hash ^= (int) entityOneofCaseCase_;
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
      if (InstId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(InstId);
      }
      if (GroupId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GroupId);
      }
      if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.Npc) {
        output.WriteRawTag(26);
        output.WriteMessage(Npc);
      }
      if (motion_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Motion);
      }
      if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.Actor) {
        output.WriteRawTag(66);
        output.WriteMessage(Actor);
      }
      if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.NpcMonster) {
        output.WriteRawTag(82);
        output.WriteMessage(NpcMonster);
      }
      if (EntityId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(EntityId);
      }
      if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.Prop) {
        output.WriteRawTag(106);
        output.WriteMessage(Prop);
      }
      if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.SummonUnit) {
        output.WriteRawTag(114);
        output.WriteMessage(SummonUnit);
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
      if (InstId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(InstId);
      }
      if (GroupId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GroupId);
      }
      if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.Npc) {
        output.WriteRawTag(26);
        output.WriteMessage(Npc);
      }
      if (motion_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Motion);
      }
      if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.Actor) {
        output.WriteRawTag(66);
        output.WriteMessage(Actor);
      }
      if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.NpcMonster) {
        output.WriteRawTag(82);
        output.WriteMessage(NpcMonster);
      }
      if (EntityId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(EntityId);
      }
      if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.Prop) {
        output.WriteRawTag(106);
        output.WriteMessage(Prop);
      }
      if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.SummonUnit) {
        output.WriteRawTag(114);
        output.WriteMessage(SummonUnit);
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
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (InstId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(InstId);
      }
      if (motion_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Motion);
      }
      if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.Actor) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Actor);
      }
      if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.NpcMonster) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NpcMonster);
      }
      if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.Npc) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Npc);
      }
      if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.Prop) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Prop);
      }
      if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.SummonUnit) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SummonUnit);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneEntityInfo other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.InstId != 0) {
        InstId = other.InstId;
      }
      if (other.motion_ != null) {
        if (motion_ == null) {
          Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
        }
        Motion.MergeFrom(other.Motion);
      }
      switch (other.EntityOneofCaseCase) {
        case EntityOneofCaseOneofCase.Actor:
          if (Actor == null) {
            Actor = new global::EggLink.DanhengServer.Proto.SceneActorInfo();
          }
          Actor.MergeFrom(other.Actor);
          break;
        case EntityOneofCaseOneofCase.NpcMonster:
          if (NpcMonster == null) {
            NpcMonster = new global::EggLink.DanhengServer.Proto.SceneNpcMonsterInfo();
          }
          NpcMonster.MergeFrom(other.NpcMonster);
          break;
        case EntityOneofCaseOneofCase.Npc:
          if (Npc == null) {
            Npc = new global::EggLink.DanhengServer.Proto.SceneNpcInfo();
          }
          Npc.MergeFrom(other.Npc);
          break;
        case EntityOneofCaseOneofCase.Prop:
          if (Prop == null) {
            Prop = new global::EggLink.DanhengServer.Proto.ScenePropInfo();
          }
          Prop.MergeFrom(other.Prop);
          break;
        case EntityOneofCaseOneofCase.SummonUnit:
          if (SummonUnit == null) {
            SummonUnit = new global::EggLink.DanhengServer.Proto.SceneSummonUnitInfo();
          }
          SummonUnit.MergeFrom(other.SummonUnit);
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
            InstId = input.ReadUInt32();
            break;
          }
          case 16: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 26: {
            global::EggLink.DanhengServer.Proto.SceneNpcInfo subBuilder = new global::EggLink.DanhengServer.Proto.SceneNpcInfo();
            if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.Npc) {
              subBuilder.MergeFrom(Npc);
            }
            input.ReadMessage(subBuilder);
            Npc = subBuilder;
            break;
          }
          case 42: {
            if (motion_ == null) {
              Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(Motion);
            break;
          }
          case 66: {
            global::EggLink.DanhengServer.Proto.SceneActorInfo subBuilder = new global::EggLink.DanhengServer.Proto.SceneActorInfo();
            if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.Actor) {
              subBuilder.MergeFrom(Actor);
            }
            input.ReadMessage(subBuilder);
            Actor = subBuilder;
            break;
          }
          case 82: {
            global::EggLink.DanhengServer.Proto.SceneNpcMonsterInfo subBuilder = new global::EggLink.DanhengServer.Proto.SceneNpcMonsterInfo();
            if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.NpcMonster) {
              subBuilder.MergeFrom(NpcMonster);
            }
            input.ReadMessage(subBuilder);
            NpcMonster = subBuilder;
            break;
          }
          case 96: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 106: {
            global::EggLink.DanhengServer.Proto.ScenePropInfo subBuilder = new global::EggLink.DanhengServer.Proto.ScenePropInfo();
            if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.Prop) {
              subBuilder.MergeFrom(Prop);
            }
            input.ReadMessage(subBuilder);
            Prop = subBuilder;
            break;
          }
          case 114: {
            global::EggLink.DanhengServer.Proto.SceneSummonUnitInfo subBuilder = new global::EggLink.DanhengServer.Proto.SceneSummonUnitInfo();
            if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.SummonUnit) {
              subBuilder.MergeFrom(SummonUnit);
            }
            input.ReadMessage(subBuilder);
            SummonUnit = subBuilder;
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
            InstId = input.ReadUInt32();
            break;
          }
          case 16: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 26: {
            global::EggLink.DanhengServer.Proto.SceneNpcInfo subBuilder = new global::EggLink.DanhengServer.Proto.SceneNpcInfo();
            if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.Npc) {
              subBuilder.MergeFrom(Npc);
            }
            input.ReadMessage(subBuilder);
            Npc = subBuilder;
            break;
          }
          case 42: {
            if (motion_ == null) {
              Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(Motion);
            break;
          }
          case 66: {
            global::EggLink.DanhengServer.Proto.SceneActorInfo subBuilder = new global::EggLink.DanhengServer.Proto.SceneActorInfo();
            if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.Actor) {
              subBuilder.MergeFrom(Actor);
            }
            input.ReadMessage(subBuilder);
            Actor = subBuilder;
            break;
          }
          case 82: {
            global::EggLink.DanhengServer.Proto.SceneNpcMonsterInfo subBuilder = new global::EggLink.DanhengServer.Proto.SceneNpcMonsterInfo();
            if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.NpcMonster) {
              subBuilder.MergeFrom(NpcMonster);
            }
            input.ReadMessage(subBuilder);
            NpcMonster = subBuilder;
            break;
          }
          case 96: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 106: {
            global::EggLink.DanhengServer.Proto.ScenePropInfo subBuilder = new global::EggLink.DanhengServer.Proto.ScenePropInfo();
            if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.Prop) {
              subBuilder.MergeFrom(Prop);
            }
            input.ReadMessage(subBuilder);
            Prop = subBuilder;
            break;
          }
          case 114: {
            global::EggLink.DanhengServer.Proto.SceneSummonUnitInfo subBuilder = new global::EggLink.DanhengServer.Proto.SceneSummonUnitInfo();
            if (entityOneofCaseCase_ == EntityOneofCaseOneofCase.SummonUnit) {
              subBuilder.MergeFrom(SummonUnit);
            }
            input.ReadMessage(subBuilder);
            SummonUnit = subBuilder;
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
