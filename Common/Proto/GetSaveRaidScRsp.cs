// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetSaveRaidScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetSaveRaidScRsp.proto</summary>
  public static partial class GetSaveRaidScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetSaveRaidScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetSaveRaidScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZHZXRTYXZlUmFpZFNjUnNwLnByb3RvGgpSYWlkLnByb3RvIngKEEdldFNh",
            "dmVSYWlkU2NSc3ASEwoLd29ybGRfbGV2ZWwYBiABKA0SDwoHcmV0Y29kZRgD",
            "IAEoDRIYCglyYWlkX2xpc3QYCiADKAsyBS5SYWlkEg8KB3JhaWRfaWQYDSAB",
            "KA0SEwoLSUlKUERLRkRBS04YBCABKAhCHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RaidReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetSaveRaidScRsp), global::EggLink.DanhengServer.Proto.GetSaveRaidScRsp.Parser, new[]{ "WorldLevel", "Retcode", "RaidList", "RaidId", "IIJPDKFDAKN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetSaveRaidScRsp : pb::IMessage<GetSaveRaidScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetSaveRaidScRsp> _parser = new pb::MessageParser<GetSaveRaidScRsp>(() => new GetSaveRaidScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetSaveRaidScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetSaveRaidScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSaveRaidScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSaveRaidScRsp(GetSaveRaidScRsp other) : this() {
      worldLevel_ = other.worldLevel_;
      retcode_ = other.retcode_;
      raidList_ = other.raidList_.Clone();
      raidId_ = other.raidId_;
      iIJPDKFDAKN_ = other.iIJPDKFDAKN_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetSaveRaidScRsp Clone() {
      return new GetSaveRaidScRsp(this);
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 6;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 3;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "raid_list" field.</summary>
    public const int RaidListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Raid> _repeated_raidList_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.Raid.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Raid> raidList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Raid>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Raid> RaidList {
      get { return raidList_; }
    }

    /// <summary>Field number for the "raid_id" field.</summary>
    public const int RaidIdFieldNumber = 13;
    private uint raidId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RaidId {
      get { return raidId_; }
      set {
        raidId_ = value;
      }
    }

    /// <summary>Field number for the "IIJPDKFDAKN" field.</summary>
    public const int IIJPDKFDAKNFieldNumber = 4;
    private bool iIJPDKFDAKN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IIJPDKFDAKN {
      get { return iIJPDKFDAKN_; }
      set {
        iIJPDKFDAKN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetSaveRaidScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetSaveRaidScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (WorldLevel != other.WorldLevel) return false;
      if (Retcode != other.Retcode) return false;
      if(!raidList_.Equals(other.raidList_)) return false;
      if (RaidId != other.RaidId) return false;
      if (IIJPDKFDAKN != other.IIJPDKFDAKN) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= raidList_.GetHashCode();
      if (RaidId != 0) hash ^= RaidId.GetHashCode();
      if (IIJPDKFDAKN != false) hash ^= IIJPDKFDAKN.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (IIJPDKFDAKN != false) {
        output.WriteRawTag(32);
        output.WriteBool(IIJPDKFDAKN);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(WorldLevel);
      }
      raidList_.WriteTo(output, _repeated_raidList_codec);
      if (RaidId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(RaidId);
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
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Retcode);
      }
      if (IIJPDKFDAKN != false) {
        output.WriteRawTag(32);
        output.WriteBool(IIJPDKFDAKN);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(WorldLevel);
      }
      raidList_.WriteTo(ref output, _repeated_raidList_codec);
      if (RaidId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(RaidId);
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
      if (WorldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldLevel);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      size += raidList_.CalculateSize(_repeated_raidList_codec);
      if (RaidId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RaidId);
      }
      if (IIJPDKFDAKN != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetSaveRaidScRsp other) {
      if (other == null) {
        return;
      }
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      raidList_.Add(other.raidList_);
      if (other.RaidId != 0) {
        RaidId = other.RaidId;
      }
      if (other.IIJPDKFDAKN != false) {
        IIJPDKFDAKN = other.IIJPDKFDAKN;
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 32: {
            IIJPDKFDAKN = input.ReadBool();
            break;
          }
          case 48: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 82: {
            raidList_.AddEntriesFrom(input, _repeated_raidList_codec);
            break;
          }
          case 104: {
            RaidId = input.ReadUInt32();
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
            Retcode = input.ReadUInt32();
            break;
          }
          case 32: {
            IIJPDKFDAKN = input.ReadBool();
            break;
          }
          case 48: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 82: {
            raidList_.AddEntriesFrom(ref input, _repeated_raidList_codec);
            break;
          }
          case 104: {
            RaidId = input.ReadUInt32();
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
