// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PVEBattleResultCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PVEBattleResultCsReq.proto</summary>
  public static partial class PVEBattleResultCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PVEBattleResultCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PVEBattleResultCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpQVkVCYXR0bGVSZXN1bHRDc1JlcS5wcm90bxoVQmF0dGxlRW5kU3RhdHVz",
            "LnByb3RvGg5CYXR0bGVPcC5wcm90bxoWQmF0dGxlU3RhdGlzdGljcy5wcm90",
            "byLmAwoUUFZFQmF0dGxlUmVzdWx0Q3NSZXESGgoHb3BfbGlzdBgGIAMoCzIJ",
            "LkJhdHRsZU9wEh4KA3N0dBgNIAEoCzIRLkJhdHRsZVN0YXRpc3RpY3MSFgoO",
            "Y2xpZW50X3ZlcnNpb24YCSABKA0SEAoIc3RhZ2VfaWQYAiABKA0SEwoLQkRE",
            "RE1QSE5LT0cYDCABKAgSIgoaaXNfYWlfY29uc2lkZXJfdWx0cmFfc2tpbGwY",
            "CyABKAgSEwoLR0hISE5DSUVHTkIYBCABKA0SEwoLSUpPRERQRkhOR0EYBSAB",
            "KA0SFQoNaXNfYXV0b19maWdodBgPIAEoCBIaChJ0dXJuX3NuYXBzaG90X2hh",
            "c2gYDiABKAwSEQoJYmF0dGxlX2lkGAggASgNEjsKC0pMTFBHSUtQQUJJGAMg",
            "AygLMiYuUFZFQmF0dGxlUmVzdWx0Q3NSZXEuSkxMUEdJS1BBQklFbnRyeRIT",
            "CgtyZXNfdmVyc2lvbhgKIAEoDRIkCgplbmRfc3RhdHVzGAcgASgOMhAuQmF0",
            "dGxlRW5kU3RhdHVzEhMKC0xBQkRQTktCQUlJGAEgASgJGjIKEEpMTFBHSUtQ",
            "QUJJRW50cnkSCwoDa2V5GAEgASgJEg0KBXZhbHVlGAIgASgNOgI4AUIeqgIb",
            "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.BattleEndStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleOpReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleStatisticsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PVEBattleResultCsReq), global::EggLink.DanhengServer.Proto.PVEBattleResultCsReq.Parser, new[]{ "OpList", "Stt", "ClientVersion", "StageId", "BDDDMPHNKOG", "IsAiConsiderUltraSkill", "GHHHNCIEGNB", "IJODDPFHNGA", "IsAutoFight", "TurnSnapshotHash", "BattleId", "JLLPGIKPABI", "ResVersion", "EndStatus", "LABDPNKBAII" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PVEBattleResultCsReq : pb::IMessage<PVEBattleResultCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PVEBattleResultCsReq> _parser = new pb::MessageParser<PVEBattleResultCsReq>(() => new PVEBattleResultCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PVEBattleResultCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PVEBattleResultCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PVEBattleResultCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PVEBattleResultCsReq(PVEBattleResultCsReq other) : this() {
      opList_ = other.opList_.Clone();
      stt_ = other.stt_ != null ? other.stt_.Clone() : null;
      clientVersion_ = other.clientVersion_;
      stageId_ = other.stageId_;
      bDDDMPHNKOG_ = other.bDDDMPHNKOG_;
      isAiConsiderUltraSkill_ = other.isAiConsiderUltraSkill_;
      gHHHNCIEGNB_ = other.gHHHNCIEGNB_;
      iJODDPFHNGA_ = other.iJODDPFHNGA_;
      isAutoFight_ = other.isAutoFight_;
      turnSnapshotHash_ = other.turnSnapshotHash_;
      battleId_ = other.battleId_;
      jLLPGIKPABI_ = other.jLLPGIKPABI_.Clone();
      resVersion_ = other.resVersion_;
      endStatus_ = other.endStatus_;
      lABDPNKBAII_ = other.lABDPNKBAII_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PVEBattleResultCsReq Clone() {
      return new PVEBattleResultCsReq(this);
    }

    /// <summary>Field number for the "op_list" field.</summary>
    public const int OpListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BattleOp> _repeated_opList_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.BattleOp.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleOp> opList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleOp>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleOp> OpList {
      get { return opList_; }
    }

    /// <summary>Field number for the "stt" field.</summary>
    public const int SttFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.BattleStatistics stt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BattleStatistics Stt {
      get { return stt_; }
      set {
        stt_ = value;
      }
    }

    /// <summary>Field number for the "client_version" field.</summary>
    public const int ClientVersionFieldNumber = 9;
    private uint clientVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ClientVersion {
      get { return clientVersion_; }
      set {
        clientVersion_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 2;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "BDDDMPHNKOG" field.</summary>
    public const int BDDDMPHNKOGFieldNumber = 12;
    private bool bDDDMPHNKOG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool BDDDMPHNKOG {
      get { return bDDDMPHNKOG_; }
      set {
        bDDDMPHNKOG_ = value;
      }
    }

    /// <summary>Field number for the "is_ai_consider_ultra_skill" field.</summary>
    public const int IsAiConsiderUltraSkillFieldNumber = 11;
    private bool isAiConsiderUltraSkill_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAiConsiderUltraSkill {
      get { return isAiConsiderUltraSkill_; }
      set {
        isAiConsiderUltraSkill_ = value;
      }
    }

    /// <summary>Field number for the "GHHHNCIEGNB" field.</summary>
    public const int GHHHNCIEGNBFieldNumber = 4;
    private uint gHHHNCIEGNB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GHHHNCIEGNB {
      get { return gHHHNCIEGNB_; }
      set {
        gHHHNCIEGNB_ = value;
      }
    }

    /// <summary>Field number for the "IJODDPFHNGA" field.</summary>
    public const int IJODDPFHNGAFieldNumber = 5;
    private uint iJODDPFHNGA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IJODDPFHNGA {
      get { return iJODDPFHNGA_; }
      set {
        iJODDPFHNGA_ = value;
      }
    }

    /// <summary>Field number for the "is_auto_fight" field.</summary>
    public const int IsAutoFightFieldNumber = 15;
    private bool isAutoFight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAutoFight {
      get { return isAutoFight_; }
      set {
        isAutoFight_ = value;
      }
    }

    /// <summary>Field number for the "turn_snapshot_hash" field.</summary>
    public const int TurnSnapshotHashFieldNumber = 14;
    private pb::ByteString turnSnapshotHash_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString TurnSnapshotHash {
      get { return turnSnapshotHash_; }
      set {
        turnSnapshotHash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "battle_id" field.</summary>
    public const int BattleIdFieldNumber = 8;
    private uint battleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BattleId {
      get { return battleId_; }
      set {
        battleId_ = value;
      }
    }

    /// <summary>Field number for the "JLLPGIKPABI" field.</summary>
    public const int JLLPGIKPABIFieldNumber = 3;
    private static readonly pbc::MapField<string, uint>.Codec _map_jLLPGIKPABI_codec
        = new pbc::MapField<string, uint>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForUInt32(16, 0), 26);
    private readonly pbc::MapField<string, uint> jLLPGIKPABI_ = new pbc::MapField<string, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, uint> JLLPGIKPABI {
      get { return jLLPGIKPABI_; }
    }

    /// <summary>Field number for the "res_version" field.</summary>
    public const int ResVersionFieldNumber = 10;
    private uint resVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ResVersion {
      get { return resVersion_; }
      set {
        resVersion_ = value;
      }
    }

    /// <summary>Field number for the "end_status" field.</summary>
    public const int EndStatusFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.BattleEndStatus endStatus_ = global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BattleEndStatus EndStatus {
      get { return endStatus_; }
      set {
        endStatus_ = value;
      }
    }

    /// <summary>Field number for the "LABDPNKBAII" field.</summary>
    public const int LABDPNKBAIIFieldNumber = 1;
    private string lABDPNKBAII_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LABDPNKBAII {
      get { return lABDPNKBAII_; }
      set {
        lABDPNKBAII_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PVEBattleResultCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PVEBattleResultCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!opList_.Equals(other.opList_)) return false;
      if (!object.Equals(Stt, other.Stt)) return false;
      if (ClientVersion != other.ClientVersion) return false;
      if (StageId != other.StageId) return false;
      if (BDDDMPHNKOG != other.BDDDMPHNKOG) return false;
      if (IsAiConsiderUltraSkill != other.IsAiConsiderUltraSkill) return false;
      if (GHHHNCIEGNB != other.GHHHNCIEGNB) return false;
      if (IJODDPFHNGA != other.IJODDPFHNGA) return false;
      if (IsAutoFight != other.IsAutoFight) return false;
      if (TurnSnapshotHash != other.TurnSnapshotHash) return false;
      if (BattleId != other.BattleId) return false;
      if (!JLLPGIKPABI.Equals(other.JLLPGIKPABI)) return false;
      if (ResVersion != other.ResVersion) return false;
      if (EndStatus != other.EndStatus) return false;
      if (LABDPNKBAII != other.LABDPNKBAII) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= opList_.GetHashCode();
      if (stt_ != null) hash ^= Stt.GetHashCode();
      if (ClientVersion != 0) hash ^= ClientVersion.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (BDDDMPHNKOG != false) hash ^= BDDDMPHNKOG.GetHashCode();
      if (IsAiConsiderUltraSkill != false) hash ^= IsAiConsiderUltraSkill.GetHashCode();
      if (GHHHNCIEGNB != 0) hash ^= GHHHNCIEGNB.GetHashCode();
      if (IJODDPFHNGA != 0) hash ^= IJODDPFHNGA.GetHashCode();
      if (IsAutoFight != false) hash ^= IsAutoFight.GetHashCode();
      if (TurnSnapshotHash.Length != 0) hash ^= TurnSnapshotHash.GetHashCode();
      if (BattleId != 0) hash ^= BattleId.GetHashCode();
      hash ^= JLLPGIKPABI.GetHashCode();
      if (ResVersion != 0) hash ^= ResVersion.GetHashCode();
      if (EndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) hash ^= EndStatus.GetHashCode();
      if (LABDPNKBAII.Length != 0) hash ^= LABDPNKBAII.GetHashCode();
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
      if (LABDPNKBAII.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LABDPNKBAII);
      }
      if (StageId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(StageId);
      }
      jLLPGIKPABI_.WriteTo(output, _map_jLLPGIKPABI_codec);
      if (GHHHNCIEGNB != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GHHHNCIEGNB);
      }
      if (IJODDPFHNGA != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(IJODDPFHNGA);
      }
      opList_.WriteTo(output, _repeated_opList_codec);
      if (EndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) {
        output.WriteRawTag(56);
        output.WriteEnum((int) EndStatus);
      }
      if (BattleId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(BattleId);
      }
      if (ClientVersion != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ClientVersion);
      }
      if (ResVersion != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ResVersion);
      }
      if (IsAiConsiderUltraSkill != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsAiConsiderUltraSkill);
      }
      if (BDDDMPHNKOG != false) {
        output.WriteRawTag(96);
        output.WriteBool(BDDDMPHNKOG);
      }
      if (stt_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Stt);
      }
      if (TurnSnapshotHash.Length != 0) {
        output.WriteRawTag(114);
        output.WriteBytes(TurnSnapshotHash);
      }
      if (IsAutoFight != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsAutoFight);
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
      if (LABDPNKBAII.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LABDPNKBAII);
      }
      if (StageId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(StageId);
      }
      jLLPGIKPABI_.WriteTo(ref output, _map_jLLPGIKPABI_codec);
      if (GHHHNCIEGNB != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GHHHNCIEGNB);
      }
      if (IJODDPFHNGA != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(IJODDPFHNGA);
      }
      opList_.WriteTo(ref output, _repeated_opList_codec);
      if (EndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) {
        output.WriteRawTag(56);
        output.WriteEnum((int) EndStatus);
      }
      if (BattleId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(BattleId);
      }
      if (ClientVersion != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ClientVersion);
      }
      if (ResVersion != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ResVersion);
      }
      if (IsAiConsiderUltraSkill != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsAiConsiderUltraSkill);
      }
      if (BDDDMPHNKOG != false) {
        output.WriteRawTag(96);
        output.WriteBool(BDDDMPHNKOG);
      }
      if (stt_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Stt);
      }
      if (TurnSnapshotHash.Length != 0) {
        output.WriteRawTag(114);
        output.WriteBytes(TurnSnapshotHash);
      }
      if (IsAutoFight != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsAutoFight);
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
      size += opList_.CalculateSize(_repeated_opList_codec);
      if (stt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Stt);
      }
      if (ClientVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClientVersion);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (BDDDMPHNKOG != false) {
        size += 1 + 1;
      }
      if (IsAiConsiderUltraSkill != false) {
        size += 1 + 1;
      }
      if (GHHHNCIEGNB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GHHHNCIEGNB);
      }
      if (IJODDPFHNGA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IJODDPFHNGA);
      }
      if (IsAutoFight != false) {
        size += 1 + 1;
      }
      if (TurnSnapshotHash.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(TurnSnapshotHash);
      }
      if (BattleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BattleId);
      }
      size += jLLPGIKPABI_.CalculateSize(_map_jLLPGIKPABI_codec);
      if (ResVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ResVersion);
      }
      if (EndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EndStatus);
      }
      if (LABDPNKBAII.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LABDPNKBAII);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PVEBattleResultCsReq other) {
      if (other == null) {
        return;
      }
      opList_.Add(other.opList_);
      if (other.stt_ != null) {
        if (stt_ == null) {
          Stt = new global::EggLink.DanhengServer.Proto.BattleStatistics();
        }
        Stt.MergeFrom(other.Stt);
      }
      if (other.ClientVersion != 0) {
        ClientVersion = other.ClientVersion;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.BDDDMPHNKOG != false) {
        BDDDMPHNKOG = other.BDDDMPHNKOG;
      }
      if (other.IsAiConsiderUltraSkill != false) {
        IsAiConsiderUltraSkill = other.IsAiConsiderUltraSkill;
      }
      if (other.GHHHNCIEGNB != 0) {
        GHHHNCIEGNB = other.GHHHNCIEGNB;
      }
      if (other.IJODDPFHNGA != 0) {
        IJODDPFHNGA = other.IJODDPFHNGA;
      }
      if (other.IsAutoFight != false) {
        IsAutoFight = other.IsAutoFight;
      }
      if (other.TurnSnapshotHash.Length != 0) {
        TurnSnapshotHash = other.TurnSnapshotHash;
      }
      if (other.BattleId != 0) {
        BattleId = other.BattleId;
      }
      jLLPGIKPABI_.MergeFrom(other.jLLPGIKPABI_);
      if (other.ResVersion != 0) {
        ResVersion = other.ResVersion;
      }
      if (other.EndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) {
        EndStatus = other.EndStatus;
      }
      if (other.LABDPNKBAII.Length != 0) {
        LABDPNKBAII = other.LABDPNKBAII;
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
          case 10: {
            LABDPNKBAII = input.ReadString();
            break;
          }
          case 16: {
            StageId = input.ReadUInt32();
            break;
          }
          case 26: {
            jLLPGIKPABI_.AddEntriesFrom(input, _map_jLLPGIKPABI_codec);
            break;
          }
          case 32: {
            GHHHNCIEGNB = input.ReadUInt32();
            break;
          }
          case 40: {
            IJODDPFHNGA = input.ReadUInt32();
            break;
          }
          case 50: {
            opList_.AddEntriesFrom(input, _repeated_opList_codec);
            break;
          }
          case 56: {
            EndStatus = (global::EggLink.DanhengServer.Proto.BattleEndStatus) input.ReadEnum();
            break;
          }
          case 64: {
            BattleId = input.ReadUInt32();
            break;
          }
          case 72: {
            ClientVersion = input.ReadUInt32();
            break;
          }
          case 80: {
            ResVersion = input.ReadUInt32();
            break;
          }
          case 88: {
            IsAiConsiderUltraSkill = input.ReadBool();
            break;
          }
          case 96: {
            BDDDMPHNKOG = input.ReadBool();
            break;
          }
          case 106: {
            if (stt_ == null) {
              Stt = new global::EggLink.DanhengServer.Proto.BattleStatistics();
            }
            input.ReadMessage(Stt);
            break;
          }
          case 114: {
            TurnSnapshotHash = input.ReadBytes();
            break;
          }
          case 120: {
            IsAutoFight = input.ReadBool();
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
          case 10: {
            LABDPNKBAII = input.ReadString();
            break;
          }
          case 16: {
            StageId = input.ReadUInt32();
            break;
          }
          case 26: {
            jLLPGIKPABI_.AddEntriesFrom(ref input, _map_jLLPGIKPABI_codec);
            break;
          }
          case 32: {
            GHHHNCIEGNB = input.ReadUInt32();
            break;
          }
          case 40: {
            IJODDPFHNGA = input.ReadUInt32();
            break;
          }
          case 50: {
            opList_.AddEntriesFrom(ref input, _repeated_opList_codec);
            break;
          }
          case 56: {
            EndStatus = (global::EggLink.DanhengServer.Proto.BattleEndStatus) input.ReadEnum();
            break;
          }
          case 64: {
            BattleId = input.ReadUInt32();
            break;
          }
          case 72: {
            ClientVersion = input.ReadUInt32();
            break;
          }
          case 80: {
            ResVersion = input.ReadUInt32();
            break;
          }
          case 88: {
            IsAiConsiderUltraSkill = input.ReadBool();
            break;
          }
          case 96: {
            BDDDMPHNKOG = input.ReadBool();
            break;
          }
          case 106: {
            if (stt_ == null) {
              Stt = new global::EggLink.DanhengServer.Proto.BattleStatistics();
            }
            input.ReadMessage(Stt);
            break;
          }
          case 114: {
            TurnSnapshotHash = input.ReadBytes();
            break;
          }
          case 120: {
            IsAutoFight = input.ReadBool();
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
