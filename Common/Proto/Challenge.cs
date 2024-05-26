// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Challenge.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from Challenge.proto</summary>
  public static partial class ChallengeReflection {

    #region Descriptor
    /// <summary>File descriptor for Challenge.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChallengeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9DaGFsbGVuZ2UucHJvdG8ifwoJQ2hhbGxlbmdlEgwKBHN0YXIYCCABKA0S",
            "FAoMdGFrZW5fcmV3YXJkGA0gASgNEhQKDGNoYWxsZW5nZV9pZBgBIAEoDRIR",
            "CglzY29yZV90d28YDCABKA0SEAoIc2NvcmVfaWQYByABKA0SEwoLR0VIR0VH",
            "T0ZERE0YBSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.Challenge), global::EggLink.DanhengServer.Proto.Challenge.Parser, new[]{ "Star", "TakenReward", "ChallengeId", "ScoreTwo", "ScoreId", "GEHGEGOFDDM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Challenge : pb::IMessage<Challenge>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Challenge> _parser = new pb::MessageParser<Challenge>(() => new Challenge());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Challenge> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChallengeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Challenge() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Challenge(Challenge other) : this() {
      star_ = other.star_;
      takenReward_ = other.takenReward_;
      challengeId_ = other.challengeId_;
      scoreTwo_ = other.scoreTwo_;
      scoreId_ = other.scoreId_;
      gEHGEGOFDDM_ = other.gEHGEGOFDDM_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Challenge Clone() {
      return new Challenge(this);
    }

    /// <summary>Field number for the "star" field.</summary>
    public const int StarFieldNumber = 8;
    private uint star_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Star {
      get { return star_; }
      set {
        star_ = value;
      }
    }

    /// <summary>Field number for the "taken_reward" field.</summary>
    public const int TakenRewardFieldNumber = 13;
    private uint takenReward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TakenReward {
      get { return takenReward_; }
      set {
        takenReward_ = value;
      }
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 1;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    /// <summary>Field number for the "score_two" field.</summary>
    public const int ScoreTwoFieldNumber = 12;
    private uint scoreTwo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScoreTwo {
      get { return scoreTwo_; }
      set {
        scoreTwo_ = value;
      }
    }

    /// <summary>Field number for the "score_id" field.</summary>
    public const int ScoreIdFieldNumber = 7;
    private uint scoreId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScoreId {
      get { return scoreId_; }
      set {
        scoreId_ = value;
      }
    }

    /// <summary>Field number for the "GEHGEGOFDDM" field.</summary>
    public const int GEHGEGOFDDMFieldNumber = 5;
    private uint gEHGEGOFDDM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GEHGEGOFDDM {
      get { return gEHGEGOFDDM_; }
      set {
        gEHGEGOFDDM_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Challenge);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Challenge other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Star != other.Star) return false;
      if (TakenReward != other.TakenReward) return false;
      if (ChallengeId != other.ChallengeId) return false;
      if (ScoreTwo != other.ScoreTwo) return false;
      if (ScoreId != other.ScoreId) return false;
      if (GEHGEGOFDDM != other.GEHGEGOFDDM) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Star != 0) hash ^= Star.GetHashCode();
      if (TakenReward != 0) hash ^= TakenReward.GetHashCode();
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
      if (ScoreTwo != 0) hash ^= ScoreTwo.GetHashCode();
      if (ScoreId != 0) hash ^= ScoreId.GetHashCode();
      if (GEHGEGOFDDM != 0) hash ^= GEHGEGOFDDM.GetHashCode();
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
      if (ChallengeId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChallengeId);
      }
      if (GEHGEGOFDDM != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GEHGEGOFDDM);
      }
      if (ScoreId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ScoreId);
      }
      if (Star != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Star);
      }
      if (ScoreTwo != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ScoreTwo);
      }
      if (TakenReward != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(TakenReward);
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
      if (ChallengeId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChallengeId);
      }
      if (GEHGEGOFDDM != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GEHGEGOFDDM);
      }
      if (ScoreId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ScoreId);
      }
      if (Star != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Star);
      }
      if (ScoreTwo != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ScoreTwo);
      }
      if (TakenReward != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(TakenReward);
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
      if (Star != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Star);
      }
      if (TakenReward != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TakenReward);
      }
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      if (ScoreTwo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScoreTwo);
      }
      if (ScoreId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScoreId);
      }
      if (GEHGEGOFDDM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GEHGEGOFDDM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Challenge other) {
      if (other == null) {
        return;
      }
      if (other.Star != 0) {
        Star = other.Star;
      }
      if (other.TakenReward != 0) {
        TakenReward = other.TakenReward;
      }
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
      }
      if (other.ScoreTwo != 0) {
        ScoreTwo = other.ScoreTwo;
      }
      if (other.ScoreId != 0) {
        ScoreId = other.ScoreId;
      }
      if (other.GEHGEGOFDDM != 0) {
        GEHGEGOFDDM = other.GEHGEGOFDDM;
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
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 40: {
            GEHGEGOFDDM = input.ReadUInt32();
            break;
          }
          case 56: {
            ScoreId = input.ReadUInt32();
            break;
          }
          case 64: {
            Star = input.ReadUInt32();
            break;
          }
          case 96: {
            ScoreTwo = input.ReadUInt32();
            break;
          }
          case 104: {
            TakenReward = input.ReadUInt32();
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
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 40: {
            GEHGEGOFDDM = input.ReadUInt32();
            break;
          }
          case 56: {
            ScoreId = input.ReadUInt32();
            break;
          }
          case 64: {
            Star = input.ReadUInt32();
            break;
          }
          case 96: {
            ScoreTwo = input.ReadUInt32();
            break;
          }
          case 104: {
            TakenReward = input.ReadUInt32();
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
