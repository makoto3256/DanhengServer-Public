// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FightActivityGroup.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FightActivityGroup.proto</summary>
  public static partial class FightActivityGroupReflection {

    #region Descriptor
    /// <summary>File descriptor for FightActivityGroup.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FightActivityGroupReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhGaWdodEFjdGl2aXR5R3JvdXAucHJvdG8ikQEKEkZpZ2h0QWN0aXZpdHlH",
            "cm91cBIQCghncm91cF9pZBgCIAEoDRIjChtwYXNzZWRfbWF4X2RpZmZpY3Vs",
            "dHlfbGV2ZWwYCSABKA0SKgoidGFrZW5fZGlmZmljdWx0eV9sZXZlbF9yZXdh",
            "cmRfbGlzdBgPIAMoDRIYChBlbmRsZXNzX21heF93YXZlGAYgASgNQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FightActivityGroup), global::EggLink.DanhengServer.Proto.FightActivityGroup.Parser, new[]{ "GroupId", "PassedMaxDifficultyLevel", "TakenDifficultyLevelRewardList", "EndlessMaxWave" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FightActivityGroup : pb::IMessage<FightActivityGroup>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FightActivityGroup> _parser = new pb::MessageParser<FightActivityGroup>(() => new FightActivityGroup());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FightActivityGroup> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FightActivityGroupReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightActivityGroup() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightActivityGroup(FightActivityGroup other) : this() {
      groupId_ = other.groupId_;
      passedMaxDifficultyLevel_ = other.passedMaxDifficultyLevel_;
      takenDifficultyLevelRewardList_ = other.takenDifficultyLevelRewardList_.Clone();
      endlessMaxWave_ = other.endlessMaxWave_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FightActivityGroup Clone() {
      return new FightActivityGroup(this);
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

    /// <summary>Field number for the "passed_max_difficulty_level" field.</summary>
    public const int PassedMaxDifficultyLevelFieldNumber = 9;
    private uint passedMaxDifficultyLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PassedMaxDifficultyLevel {
      get { return passedMaxDifficultyLevel_; }
      set {
        passedMaxDifficultyLevel_ = value;
      }
    }

    /// <summary>Field number for the "taken_difficulty_level_reward_list" field.</summary>
    public const int TakenDifficultyLevelRewardListFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_takenDifficultyLevelRewardList_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> takenDifficultyLevelRewardList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TakenDifficultyLevelRewardList {
      get { return takenDifficultyLevelRewardList_; }
    }

    /// <summary>Field number for the "endless_max_wave" field.</summary>
    public const int EndlessMaxWaveFieldNumber = 6;
    private uint endlessMaxWave_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EndlessMaxWave {
      get { return endlessMaxWave_; }
      set {
        endlessMaxWave_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FightActivityGroup);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FightActivityGroup other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GroupId != other.GroupId) return false;
      if (PassedMaxDifficultyLevel != other.PassedMaxDifficultyLevel) return false;
      if(!takenDifficultyLevelRewardList_.Equals(other.takenDifficultyLevelRewardList_)) return false;
      if (EndlessMaxWave != other.EndlessMaxWave) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (PassedMaxDifficultyLevel != 0) hash ^= PassedMaxDifficultyLevel.GetHashCode();
      hash ^= takenDifficultyLevelRewardList_.GetHashCode();
      if (EndlessMaxWave != 0) hash ^= EndlessMaxWave.GetHashCode();
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
      if (GroupId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GroupId);
      }
      if (EndlessMaxWave != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EndlessMaxWave);
      }
      if (PassedMaxDifficultyLevel != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PassedMaxDifficultyLevel);
      }
      takenDifficultyLevelRewardList_.WriteTo(output, _repeated_takenDifficultyLevelRewardList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (GroupId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GroupId);
      }
      if (EndlessMaxWave != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EndlessMaxWave);
      }
      if (PassedMaxDifficultyLevel != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PassedMaxDifficultyLevel);
      }
      takenDifficultyLevelRewardList_.WriteTo(ref output, _repeated_takenDifficultyLevelRewardList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (PassedMaxDifficultyLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PassedMaxDifficultyLevel);
      }
      size += takenDifficultyLevelRewardList_.CalculateSize(_repeated_takenDifficultyLevelRewardList_codec);
      if (EndlessMaxWave != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EndlessMaxWave);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FightActivityGroup other) {
      if (other == null) {
        return;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.PassedMaxDifficultyLevel != 0) {
        PassedMaxDifficultyLevel = other.PassedMaxDifficultyLevel;
      }
      takenDifficultyLevelRewardList_.Add(other.takenDifficultyLevelRewardList_);
      if (other.EndlessMaxWave != 0) {
        EndlessMaxWave = other.EndlessMaxWave;
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
          case 16: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 48: {
            EndlessMaxWave = input.ReadUInt32();
            break;
          }
          case 72: {
            PassedMaxDifficultyLevel = input.ReadUInt32();
            break;
          }
          case 122:
          case 120: {
            takenDifficultyLevelRewardList_.AddEntriesFrom(input, _repeated_takenDifficultyLevelRewardList_codec);
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
          case 16: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 48: {
            EndlessMaxWave = input.ReadUInt32();
            break;
          }
          case 72: {
            PassedMaxDifficultyLevel = input.ReadUInt32();
            break;
          }
          case 122:
          case 120: {
            takenDifficultyLevelRewardList_.AddEntriesFrom(ref input, _repeated_takenDifficultyLevelRewardList_codec);
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
