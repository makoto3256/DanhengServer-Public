// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SceneInfo.proto</summary>
  public static partial class SceneInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9TY2VuZUluZm8ucHJvdG8aEURIRUVIQklNT0FDLnByb3RvGh5NaXNzaW9u",
            "U3RhdHVzQnlTY2VuZUluZm8ucHJvdG8aFEN1c3RvbVNhdmVEYXRhLnByb3Rv",
            "GhRFbnRpdHlCdWZmSW5mby5wcm90bxoaU2NlbmVFbnRpdHlHcm91cEluZm8u",
            "cHJvdG8aFVNjZW5lRW50aXR5SW5mby5wcm90bxoVU2NlbmVHcm91cFN0YXRl",
            "LnByb3RvGg5CdWZmSW5mby5wcm90byKIBgoJU2NlbmVJbmZvEhAKCHBsYW5l",
            "X2lkGAUgASgNEhYKDmdhbWVfbW9kZV90eXBlGAEgASgNEhAKCGVudHJ5X2lk",
            "GA8gASgNEisKEGdyb3VwX3N0YXRlX2xpc3QY6A0gAygLMhAuU2NlbmVHcm91",
            "cFN0YXRlEjEKEWVudGl0eV9ncm91cF9saXN0GPEDIAMoCzIVLlNjZW5lRW50",
            "aXR5R3JvdXBJbmZvEhwKFGxpZ2h0ZW5fc2VjdGlvbl9saXN0GAkgAygNEiEK",
            "DnN5bmNfYnVmZl9pbmZvGAcgAygLMgkuQnVmZkluZm8SEAoIZmxvb3JfaWQY",
            "CCABKA0SNgoSc2NlbmVfbWlzc2lvbl9pbmZvGL4BIAEoCzIZLk1pc3Npb25T",
            "dGF0dXNCeVNjZW5lSW5mbxInCg5zYXZlX2RhdGFfbGlzdBgEIAMoCzIPLkN1",
            "c3RvbVNhdmVEYXRhEhgKEGxlYWRlcl9lbnRpdHlfaWQYAiABKA0SMAoLTUpM",
            "SUNGREZKSEgYDiADKAsyGy5TY2VuZUluZm8uTUpMSUNGREZKSEhFbnRyeRIQ",
            "Cgh3b3JsZF9pZBgMIAEoDRIaChJjbGllbnRfcG9zX3ZlcnNpb24YBiABKA0S",
            "KQoQZW50aXR5X2J1ZmZfbGlzdBgNIAMoCzIPLkVudGl0eUJ1ZmZJbmZvEhUK",
            "DWdyb3VwX2lkX2xpc3QYAyADKA0SJQoLZW50aXR5X2xpc3QYCiADKAsyEC5T",
            "Y2VuZUVudGl0eUluZm8SFAoLQ05HQUtLQ01PTkgY6g4gASgNEjkKEGZsb29y",
            "X3NhdmVkX2RhdGEYswogAygLMh4uU2NlbmVJbmZvLkZsb29yU2F2ZWREYXRh",
            "RW50cnkaQAoQTUpMSUNGREZKSEhFbnRyeRILCgNrZXkYASABKA0SGwoFdmFs",
            "dWUYAiABKAsyDC5ESEVFSEJJTU9BQzoCOAEaNQoTRmxvb3JTYXZlZERhdGFF",
            "bnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAU6AjgBQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.DHEEHBIMOACReflection.Descriptor, global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.CustomSaveDataReflection.Descriptor, global::EggLink.DanhengServer.Proto.EntityBuffInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneEntityGroupInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneEntityInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneGroupStateReflection.Descriptor, global::EggLink.DanhengServer.Proto.BuffInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SceneInfo), global::EggLink.DanhengServer.Proto.SceneInfo.Parser, new[]{ "PlaneId", "GameModeType", "EntryId", "GroupStateList", "EntityGroupList", "LightenSectionList", "SyncBuffInfo", "FloorId", "SceneMissionInfo", "SaveDataList", "LeaderEntityId", "MJLICFDFJHH", "WorldId", "ClientPosVersion", "EntityBuffList", "GroupIdList", "EntityList", "CNGAKKCMONH", "FloorSavedData" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SceneInfo : pb::IMessage<SceneInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneInfo> _parser = new pb::MessageParser<SceneInfo>(() => new SceneInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SceneInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneInfo(SceneInfo other) : this() {
      planeId_ = other.planeId_;
      gameModeType_ = other.gameModeType_;
      entryId_ = other.entryId_;
      groupStateList_ = other.groupStateList_.Clone();
      entityGroupList_ = other.entityGroupList_.Clone();
      lightenSectionList_ = other.lightenSectionList_.Clone();
      syncBuffInfo_ = other.syncBuffInfo_.Clone();
      floorId_ = other.floorId_;
      sceneMissionInfo_ = other.sceneMissionInfo_ != null ? other.sceneMissionInfo_.Clone() : null;
      saveDataList_ = other.saveDataList_.Clone();
      leaderEntityId_ = other.leaderEntityId_;
      mJLICFDFJHH_ = other.mJLICFDFJHH_.Clone();
      worldId_ = other.worldId_;
      clientPosVersion_ = other.clientPosVersion_;
      entityBuffList_ = other.entityBuffList_.Clone();
      groupIdList_ = other.groupIdList_.Clone();
      entityList_ = other.entityList_.Clone();
      cNGAKKCMONH_ = other.cNGAKKCMONH_;
      floorSavedData_ = other.floorSavedData_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneInfo Clone() {
      return new SceneInfo(this);
    }

    /// <summary>Field number for the "plane_id" field.</summary>
    public const int PlaneIdFieldNumber = 5;
    private uint planeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlaneId {
      get { return planeId_; }
      set {
        planeId_ = value;
      }
    }

    /// <summary>Field number for the "game_mode_type" field.</summary>
    public const int GameModeTypeFieldNumber = 1;
    private uint gameModeType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GameModeType {
      get { return gameModeType_; }
      set {
        gameModeType_ = value;
      }
    }

    /// <summary>Field number for the "entry_id" field.</summary>
    public const int EntryIdFieldNumber = 15;
    private uint entryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntryId {
      get { return entryId_; }
      set {
        entryId_ = value;
      }
    }

    /// <summary>Field number for the "group_state_list" field.</summary>
    public const int GroupStateListFieldNumber = 1768;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SceneGroupState> _repeated_groupStateList_codec
        = pb::FieldCodec.ForMessage(14146, global::EggLink.DanhengServer.Proto.SceneGroupState.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneGroupState> groupStateList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneGroupState>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneGroupState> GroupStateList {
      get { return groupStateList_; }
    }

    /// <summary>Field number for the "entity_group_list" field.</summary>
    public const int EntityGroupListFieldNumber = 497;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SceneEntityGroupInfo> _repeated_entityGroupList_codec
        = pb::FieldCodec.ForMessage(3978, global::EggLink.DanhengServer.Proto.SceneEntityGroupInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityGroupInfo> entityGroupList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityGroupInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityGroupInfo> EntityGroupList {
      get { return entityGroupList_; }
    }

    /// <summary>Field number for the "lighten_section_list" field.</summary>
    public const int LightenSectionListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_lightenSectionList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> lightenSectionList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LightenSectionList {
      get { return lightenSectionList_; }
    }

    /// <summary>Field number for the "sync_buff_info" field.</summary>
    public const int SyncBuffInfoFieldNumber = 7;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BuffInfo> _repeated_syncBuffInfo_codec
        = pb::FieldCodec.ForMessage(58, global::EggLink.DanhengServer.Proto.BuffInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BuffInfo> syncBuffInfo_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BuffInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BuffInfo> SyncBuffInfo {
      get { return syncBuffInfo_; }
    }

    /// <summary>Field number for the "floor_id" field.</summary>
    public const int FloorIdFieldNumber = 8;
    private uint floorId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FloorId {
      get { return floorId_; }
      set {
        floorId_ = value;
      }
    }

    /// <summary>Field number for the "scene_mission_info" field.</summary>
    public const int SceneMissionInfoFieldNumber = 190;
    private global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo sceneMissionInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo SceneMissionInfo {
      get { return sceneMissionInfo_; }
      set {
        sceneMissionInfo_ = value;
      }
    }

    /// <summary>Field number for the "save_data_list" field.</summary>
    public const int SaveDataListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.CustomSaveData> _repeated_saveDataList_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.CustomSaveData.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CustomSaveData> saveDataList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CustomSaveData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CustomSaveData> SaveDataList {
      get { return saveDataList_; }
    }

    /// <summary>Field number for the "leader_entity_id" field.</summary>
    public const int LeaderEntityIdFieldNumber = 2;
    private uint leaderEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LeaderEntityId {
      get { return leaderEntityId_; }
      set {
        leaderEntityId_ = value;
      }
    }

    /// <summary>Field number for the "MJLICFDFJHH" field.</summary>
    public const int MJLICFDFJHHFieldNumber = 14;
    private static readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.DHEEHBIMOAC>.Codec _map_mJLICFDFJHH_codec
        = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.DHEEHBIMOAC>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.DHEEHBIMOAC.Parser), 114);
    private readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.DHEEHBIMOAC> mJLICFDFJHH_ = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.DHEEHBIMOAC>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::EggLink.DanhengServer.Proto.DHEEHBIMOAC> MJLICFDFJHH {
      get { return mJLICFDFJHH_; }
    }

    /// <summary>Field number for the "world_id" field.</summary>
    public const int WorldIdFieldNumber = 12;
    private uint worldId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldId {
      get { return worldId_; }
      set {
        worldId_ = value;
      }
    }

    /// <summary>Field number for the "client_pos_version" field.</summary>
    public const int ClientPosVersionFieldNumber = 6;
    private uint clientPosVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ClientPosVersion {
      get { return clientPosVersion_; }
      set {
        clientPosVersion_ = value;
      }
    }

    /// <summary>Field number for the "entity_buff_list" field.</summary>
    public const int EntityBuffListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.EntityBuffInfo> _repeated_entityBuffList_codec
        = pb::FieldCodec.ForMessage(106, global::EggLink.DanhengServer.Proto.EntityBuffInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EntityBuffInfo> entityBuffList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EntityBuffInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EntityBuffInfo> EntityBuffList {
      get { return entityBuffList_; }
    }

    /// <summary>Field number for the "group_id_list" field.</summary>
    public const int GroupIdListFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_groupIdList_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> groupIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> GroupIdList {
      get { return groupIdList_; }
    }

    /// <summary>Field number for the "entity_list" field.</summary>
    public const int EntityListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SceneEntityInfo> _repeated_entityList_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.SceneEntityInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityInfo> entityList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneEntityInfo> EntityList {
      get { return entityList_; }
    }

    /// <summary>Field number for the "CNGAKKCMONH" field.</summary>
    public const int CNGAKKCMONHFieldNumber = 1898;
    private uint cNGAKKCMONH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CNGAKKCMONH {
      get { return cNGAKKCMONH_; }
      set {
        cNGAKKCMONH_ = value;
      }
    }

    /// <summary>Field number for the "floor_saved_data" field.</summary>
    public const int FloorSavedDataFieldNumber = 1331;
    private static readonly pbc::MapField<string, int>.Codec _map_floorSavedData_codec
        = new pbc::MapField<string, int>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForInt32(16, 0), 10650);
    private readonly pbc::MapField<string, int> floorSavedData_ = new pbc::MapField<string, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, int> FloorSavedData {
      get { return floorSavedData_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlaneId != other.PlaneId) return false;
      if (GameModeType != other.GameModeType) return false;
      if (EntryId != other.EntryId) return false;
      if(!groupStateList_.Equals(other.groupStateList_)) return false;
      if(!entityGroupList_.Equals(other.entityGroupList_)) return false;
      if(!lightenSectionList_.Equals(other.lightenSectionList_)) return false;
      if(!syncBuffInfo_.Equals(other.syncBuffInfo_)) return false;
      if (FloorId != other.FloorId) return false;
      if (!object.Equals(SceneMissionInfo, other.SceneMissionInfo)) return false;
      if(!saveDataList_.Equals(other.saveDataList_)) return false;
      if (LeaderEntityId != other.LeaderEntityId) return false;
      if (!MJLICFDFJHH.Equals(other.MJLICFDFJHH)) return false;
      if (WorldId != other.WorldId) return false;
      if (ClientPosVersion != other.ClientPosVersion) return false;
      if(!entityBuffList_.Equals(other.entityBuffList_)) return false;
      if(!groupIdList_.Equals(other.groupIdList_)) return false;
      if(!entityList_.Equals(other.entityList_)) return false;
      if (CNGAKKCMONH != other.CNGAKKCMONH) return false;
      if (!FloorSavedData.Equals(other.FloorSavedData)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PlaneId != 0) hash ^= PlaneId.GetHashCode();
      if (GameModeType != 0) hash ^= GameModeType.GetHashCode();
      if (EntryId != 0) hash ^= EntryId.GetHashCode();
      hash ^= groupStateList_.GetHashCode();
      hash ^= entityGroupList_.GetHashCode();
      hash ^= lightenSectionList_.GetHashCode();
      hash ^= syncBuffInfo_.GetHashCode();
      if (FloorId != 0) hash ^= FloorId.GetHashCode();
      if (sceneMissionInfo_ != null) hash ^= SceneMissionInfo.GetHashCode();
      hash ^= saveDataList_.GetHashCode();
      if (LeaderEntityId != 0) hash ^= LeaderEntityId.GetHashCode();
      hash ^= MJLICFDFJHH.GetHashCode();
      if (WorldId != 0) hash ^= WorldId.GetHashCode();
      if (ClientPosVersion != 0) hash ^= ClientPosVersion.GetHashCode();
      hash ^= entityBuffList_.GetHashCode();
      hash ^= groupIdList_.GetHashCode();
      hash ^= entityList_.GetHashCode();
      if (CNGAKKCMONH != 0) hash ^= CNGAKKCMONH.GetHashCode();
      hash ^= FloorSavedData.GetHashCode();
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
      if (GameModeType != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GameModeType);
      }
      if (LeaderEntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LeaderEntityId);
      }
      groupIdList_.WriteTo(output, _repeated_groupIdList_codec);
      saveDataList_.WriteTo(output, _repeated_saveDataList_codec);
      if (PlaneId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(PlaneId);
      }
      if (ClientPosVersion != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ClientPosVersion);
      }
      syncBuffInfo_.WriteTo(output, _repeated_syncBuffInfo_codec);
      if (FloorId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(FloorId);
      }
      lightenSectionList_.WriteTo(output, _repeated_lightenSectionList_codec);
      entityList_.WriteTo(output, _repeated_entityList_codec);
      if (WorldId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(WorldId);
      }
      entityBuffList_.WriteTo(output, _repeated_entityBuffList_codec);
      mJLICFDFJHH_.WriteTo(output, _map_mJLICFDFJHH_codec);
      if (EntryId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(EntryId);
      }
      if (sceneMissionInfo_ != null) {
        output.WriteRawTag(242, 11);
        output.WriteMessage(SceneMissionInfo);
      }
      entityGroupList_.WriteTo(output, _repeated_entityGroupList_codec);
      floorSavedData_.WriteTo(output, _map_floorSavedData_codec);
      groupStateList_.WriteTo(output, _repeated_groupStateList_codec);
      if (CNGAKKCMONH != 0) {
        output.WriteRawTag(208, 118);
        output.WriteUInt32(CNGAKKCMONH);
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
      if (GameModeType != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GameModeType);
      }
      if (LeaderEntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LeaderEntityId);
      }
      groupIdList_.WriteTo(ref output, _repeated_groupIdList_codec);
      saveDataList_.WriteTo(ref output, _repeated_saveDataList_codec);
      if (PlaneId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(PlaneId);
      }
      if (ClientPosVersion != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ClientPosVersion);
      }
      syncBuffInfo_.WriteTo(ref output, _repeated_syncBuffInfo_codec);
      if (FloorId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(FloorId);
      }
      lightenSectionList_.WriteTo(ref output, _repeated_lightenSectionList_codec);
      entityList_.WriteTo(ref output, _repeated_entityList_codec);
      if (WorldId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(WorldId);
      }
      entityBuffList_.WriteTo(ref output, _repeated_entityBuffList_codec);
      mJLICFDFJHH_.WriteTo(ref output, _map_mJLICFDFJHH_codec);
      if (EntryId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(EntryId);
      }
      if (sceneMissionInfo_ != null) {
        output.WriteRawTag(242, 11);
        output.WriteMessage(SceneMissionInfo);
      }
      entityGroupList_.WriteTo(ref output, _repeated_entityGroupList_codec);
      floorSavedData_.WriteTo(ref output, _map_floorSavedData_codec);
      groupStateList_.WriteTo(ref output, _repeated_groupStateList_codec);
      if (CNGAKKCMONH != 0) {
        output.WriteRawTag(208, 118);
        output.WriteUInt32(CNGAKKCMONH);
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
      if (PlaneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlaneId);
      }
      if (GameModeType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GameModeType);
      }
      if (EntryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntryId);
      }
      size += groupStateList_.CalculateSize(_repeated_groupStateList_codec);
      size += entityGroupList_.CalculateSize(_repeated_entityGroupList_codec);
      size += lightenSectionList_.CalculateSize(_repeated_lightenSectionList_codec);
      size += syncBuffInfo_.CalculateSize(_repeated_syncBuffInfo_codec);
      if (FloorId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FloorId);
      }
      if (sceneMissionInfo_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(SceneMissionInfo);
      }
      size += saveDataList_.CalculateSize(_repeated_saveDataList_codec);
      if (LeaderEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LeaderEntityId);
      }
      size += mJLICFDFJHH_.CalculateSize(_map_mJLICFDFJHH_codec);
      if (WorldId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldId);
      }
      if (ClientPosVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClientPosVersion);
      }
      size += entityBuffList_.CalculateSize(_repeated_entityBuffList_codec);
      size += groupIdList_.CalculateSize(_repeated_groupIdList_codec);
      size += entityList_.CalculateSize(_repeated_entityList_codec);
      if (CNGAKKCMONH != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(CNGAKKCMONH);
      }
      size += floorSavedData_.CalculateSize(_map_floorSavedData_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneInfo other) {
      if (other == null) {
        return;
      }
      if (other.PlaneId != 0) {
        PlaneId = other.PlaneId;
      }
      if (other.GameModeType != 0) {
        GameModeType = other.GameModeType;
      }
      if (other.EntryId != 0) {
        EntryId = other.EntryId;
      }
      groupStateList_.Add(other.groupStateList_);
      entityGroupList_.Add(other.entityGroupList_);
      lightenSectionList_.Add(other.lightenSectionList_);
      syncBuffInfo_.Add(other.syncBuffInfo_);
      if (other.FloorId != 0) {
        FloorId = other.FloorId;
      }
      if (other.sceneMissionInfo_ != null) {
        if (sceneMissionInfo_ == null) {
          SceneMissionInfo = new global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo();
        }
        SceneMissionInfo.MergeFrom(other.SceneMissionInfo);
      }
      saveDataList_.Add(other.saveDataList_);
      if (other.LeaderEntityId != 0) {
        LeaderEntityId = other.LeaderEntityId;
      }
      mJLICFDFJHH_.MergeFrom(other.mJLICFDFJHH_);
      if (other.WorldId != 0) {
        WorldId = other.WorldId;
      }
      if (other.ClientPosVersion != 0) {
        ClientPosVersion = other.ClientPosVersion;
      }
      entityBuffList_.Add(other.entityBuffList_);
      groupIdList_.Add(other.groupIdList_);
      entityList_.Add(other.entityList_);
      if (other.CNGAKKCMONH != 0) {
        CNGAKKCMONH = other.CNGAKKCMONH;
      }
      floorSavedData_.MergeFrom(other.floorSavedData_);
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
            GameModeType = input.ReadUInt32();
            break;
          }
          case 16: {
            LeaderEntityId = input.ReadUInt32();
            break;
          }
          case 26:
          case 24: {
            groupIdList_.AddEntriesFrom(input, _repeated_groupIdList_codec);
            break;
          }
          case 34: {
            saveDataList_.AddEntriesFrom(input, _repeated_saveDataList_codec);
            break;
          }
          case 40: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 48: {
            ClientPosVersion = input.ReadUInt32();
            break;
          }
          case 58: {
            syncBuffInfo_.AddEntriesFrom(input, _repeated_syncBuffInfo_codec);
            break;
          }
          case 64: {
            FloorId = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            lightenSectionList_.AddEntriesFrom(input, _repeated_lightenSectionList_codec);
            break;
          }
          case 82: {
            entityList_.AddEntriesFrom(input, _repeated_entityList_codec);
            break;
          }
          case 96: {
            WorldId = input.ReadUInt32();
            break;
          }
          case 106: {
            entityBuffList_.AddEntriesFrom(input, _repeated_entityBuffList_codec);
            break;
          }
          case 114: {
            mJLICFDFJHH_.AddEntriesFrom(input, _map_mJLICFDFJHH_codec);
            break;
          }
          case 120: {
            EntryId = input.ReadUInt32();
            break;
          }
          case 1522: {
            if (sceneMissionInfo_ == null) {
              SceneMissionInfo = new global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo();
            }
            input.ReadMessage(SceneMissionInfo);
            break;
          }
          case 3978: {
            entityGroupList_.AddEntriesFrom(input, _repeated_entityGroupList_codec);
            break;
          }
          case 10650: {
            floorSavedData_.AddEntriesFrom(input, _map_floorSavedData_codec);
            break;
          }
          case 14146: {
            groupStateList_.AddEntriesFrom(input, _repeated_groupStateList_codec);
            break;
          }
          case 15184: {
            CNGAKKCMONH = input.ReadUInt32();
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
            GameModeType = input.ReadUInt32();
            break;
          }
          case 16: {
            LeaderEntityId = input.ReadUInt32();
            break;
          }
          case 26:
          case 24: {
            groupIdList_.AddEntriesFrom(ref input, _repeated_groupIdList_codec);
            break;
          }
          case 34: {
            saveDataList_.AddEntriesFrom(ref input, _repeated_saveDataList_codec);
            break;
          }
          case 40: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 48: {
            ClientPosVersion = input.ReadUInt32();
            break;
          }
          case 58: {
            syncBuffInfo_.AddEntriesFrom(ref input, _repeated_syncBuffInfo_codec);
            break;
          }
          case 64: {
            FloorId = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            lightenSectionList_.AddEntriesFrom(ref input, _repeated_lightenSectionList_codec);
            break;
          }
          case 82: {
            entityList_.AddEntriesFrom(ref input, _repeated_entityList_codec);
            break;
          }
          case 96: {
            WorldId = input.ReadUInt32();
            break;
          }
          case 106: {
            entityBuffList_.AddEntriesFrom(ref input, _repeated_entityBuffList_codec);
            break;
          }
          case 114: {
            mJLICFDFJHH_.AddEntriesFrom(ref input, _map_mJLICFDFJHH_codec);
            break;
          }
          case 120: {
            EntryId = input.ReadUInt32();
            break;
          }
          case 1522: {
            if (sceneMissionInfo_ == null) {
              SceneMissionInfo = new global::EggLink.DanhengServer.Proto.MissionStatusBySceneInfo();
            }
            input.ReadMessage(SceneMissionInfo);
            break;
          }
          case 3978: {
            entityGroupList_.AddEntriesFrom(ref input, _repeated_entityGroupList_codec);
            break;
          }
          case 10650: {
            floorSavedData_.AddEntriesFrom(ref input, _map_floorSavedData_codec);
            break;
          }
          case 14146: {
            groupStateList_.AddEntriesFrom(ref input, _repeated_groupStateList_codec);
            break;
          }
          case 15184: {
            CNGAKKCMONH = input.ReadUInt32();
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
