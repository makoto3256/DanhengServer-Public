// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CLDJMHDELHN.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from CLDJMHDELHN.proto</summary>
  public static partial class CLDJMHDELHNReflection {

    #region Descriptor
    /// <summary>File descriptor for CLDJMHDELHN.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CLDJMHDELHNReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFDTERKTUhERUxITi5wcm90bxoXUHVua0xvcmRTaGFyZVR5cGUucHJvdG8i",
            "zQEKC0NMREpNSERFTEhOEgsKA3VpZBgBIAEoDRISCgptb25zdGVyX2lkGAIg",
            "ASgNEhEKCWNvbmZpZ19pZBgDIAEoDRITCgt3b3JsZF9sZXZlbBgEIAEoDRIR",
            "Cgl0aW1lc3RhbXAYBSABKAMSDwoHbGVmdF9ocBgGIAEoDRITCgtJTElHSkxD",
            "TkhBRRgHIAEoDRInCgtQSU1JTEpQS09JSBgIIAEoDjISLlB1bmtMb3JkU2hh",
            "cmVUeXBlEhMKC0xIR0JQTk5QQUVNGAkgASgIQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PunkLordShareTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.CLDJMHDELHN), global::EggLink.DanhengServer.Proto.CLDJMHDELHN.Parser, new[]{ "Uid", "MonsterId", "ConfigId", "WorldLevel", "Timestamp", "LeftHp", "ILIGJLCNHAE", "PIMILJPKOIH", "LHGBPNNPAEM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CLDJMHDELHN : pb::IMessage<CLDJMHDELHN>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CLDJMHDELHN> _parser = new pb::MessageParser<CLDJMHDELHN>(() => new CLDJMHDELHN());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CLDJMHDELHN> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.CLDJMHDELHNReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CLDJMHDELHN() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CLDJMHDELHN(CLDJMHDELHN other) : this() {
      uid_ = other.uid_;
      monsterId_ = other.monsterId_;
      configId_ = other.configId_;
      worldLevel_ = other.worldLevel_;
      timestamp_ = other.timestamp_;
      leftHp_ = other.leftHp_;
      iLIGJLCNHAE_ = other.iLIGJLCNHAE_;
      pIMILJPKOIH_ = other.pIMILJPKOIH_;
      lHGBPNNPAEM_ = other.lHGBPNNPAEM_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CLDJMHDELHN Clone() {
      return new CLDJMHDELHN(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 1;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "monster_id" field.</summary>
    public const int MonsterIdFieldNumber = 2;
    private uint monsterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MonsterId {
      get { return monsterId_; }
      set {
        monsterId_ = value;
      }
    }

    /// <summary>Field number for the "config_id" field.</summary>
    public const int ConfigIdFieldNumber = 3;
    private uint configId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ConfigId {
      get { return configId_; }
      set {
        configId_ = value;
      }
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 4;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 5;
    private long timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    /// <summary>Field number for the "left_hp" field.</summary>
    public const int LeftHpFieldNumber = 6;
    private uint leftHp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LeftHp {
      get { return leftHp_; }
      set {
        leftHp_ = value;
      }
    }

    /// <summary>Field number for the "ILIGJLCNHAE" field.</summary>
    public const int ILIGJLCNHAEFieldNumber = 7;
    private uint iLIGJLCNHAE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ILIGJLCNHAE {
      get { return iLIGJLCNHAE_; }
      set {
        iLIGJLCNHAE_ = value;
      }
    }

    /// <summary>Field number for the "PIMILJPKOIH" field.</summary>
    public const int PIMILJPKOIHFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.PunkLordShareType pIMILJPKOIH_ = global::EggLink.DanhengServer.Proto.PunkLordShareType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PunkLordShareType PIMILJPKOIH {
      get { return pIMILJPKOIH_; }
      set {
        pIMILJPKOIH_ = value;
      }
    }

    /// <summary>Field number for the "LHGBPNNPAEM" field.</summary>
    public const int LHGBPNNPAEMFieldNumber = 9;
    private bool lHGBPNNPAEM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool LHGBPNNPAEM {
      get { return lHGBPNNPAEM_; }
      set {
        lHGBPNNPAEM_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CLDJMHDELHN);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CLDJMHDELHN other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (MonsterId != other.MonsterId) return false;
      if (ConfigId != other.ConfigId) return false;
      if (WorldLevel != other.WorldLevel) return false;
      if (Timestamp != other.Timestamp) return false;
      if (LeftHp != other.LeftHp) return false;
      if (ILIGJLCNHAE != other.ILIGJLCNHAE) return false;
      if (PIMILJPKOIH != other.PIMILJPKOIH) return false;
      if (LHGBPNNPAEM != other.LHGBPNNPAEM) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (MonsterId != 0) hash ^= MonsterId.GetHashCode();
      if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
      if (Timestamp != 0L) hash ^= Timestamp.GetHashCode();
      if (LeftHp != 0) hash ^= LeftHp.GetHashCode();
      if (ILIGJLCNHAE != 0) hash ^= ILIGJLCNHAE.GetHashCode();
      if (PIMILJPKOIH != global::EggLink.DanhengServer.Proto.PunkLordShareType.None) hash ^= PIMILJPKOIH.GetHashCode();
      if (LHGBPNNPAEM != false) hash ^= LHGBPNNPAEM.GetHashCode();
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
      if (Uid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Uid);
      }
      if (MonsterId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MonsterId);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ConfigId);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(WorldLevel);
      }
      if (Timestamp != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(Timestamp);
      }
      if (LeftHp != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(LeftHp);
      }
      if (ILIGJLCNHAE != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ILIGJLCNHAE);
      }
      if (PIMILJPKOIH != global::EggLink.DanhengServer.Proto.PunkLordShareType.None) {
        output.WriteRawTag(64);
        output.WriteEnum((int) PIMILJPKOIH);
      }
      if (LHGBPNNPAEM != false) {
        output.WriteRawTag(72);
        output.WriteBool(LHGBPNNPAEM);
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
      if (Uid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Uid);
      }
      if (MonsterId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MonsterId);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ConfigId);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(WorldLevel);
      }
      if (Timestamp != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(Timestamp);
      }
      if (LeftHp != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(LeftHp);
      }
      if (ILIGJLCNHAE != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ILIGJLCNHAE);
      }
      if (PIMILJPKOIH != global::EggLink.DanhengServer.Proto.PunkLordShareType.None) {
        output.WriteRawTag(64);
        output.WriteEnum((int) PIMILJPKOIH);
      }
      if (LHGBPNNPAEM != false) {
        output.WriteRawTag(72);
        output.WriteBool(LHGBPNNPAEM);
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
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (MonsterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MonsterId);
      }
      if (ConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
      }
      if (WorldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldLevel);
      }
      if (Timestamp != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Timestamp);
      }
      if (LeftHp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LeftHp);
      }
      if (ILIGJLCNHAE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ILIGJLCNHAE);
      }
      if (PIMILJPKOIH != global::EggLink.DanhengServer.Proto.PunkLordShareType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PIMILJPKOIH);
      }
      if (LHGBPNNPAEM != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CLDJMHDELHN other) {
      if (other == null) {
        return;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.MonsterId != 0) {
        MonsterId = other.MonsterId;
      }
      if (other.ConfigId != 0) {
        ConfigId = other.ConfigId;
      }
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
      }
      if (other.Timestamp != 0L) {
        Timestamp = other.Timestamp;
      }
      if (other.LeftHp != 0) {
        LeftHp = other.LeftHp;
      }
      if (other.ILIGJLCNHAE != 0) {
        ILIGJLCNHAE = other.ILIGJLCNHAE;
      }
      if (other.PIMILJPKOIH != global::EggLink.DanhengServer.Proto.PunkLordShareType.None) {
        PIMILJPKOIH = other.PIMILJPKOIH;
      }
      if (other.LHGBPNNPAEM != false) {
        LHGBPNNPAEM = other.LHGBPNNPAEM;
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
            Uid = input.ReadUInt32();
            break;
          }
          case 16: {
            MonsterId = input.ReadUInt32();
            break;
          }
          case 24: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 32: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 40: {
            Timestamp = input.ReadInt64();
            break;
          }
          case 48: {
            LeftHp = input.ReadUInt32();
            break;
          }
          case 56: {
            ILIGJLCNHAE = input.ReadUInt32();
            break;
          }
          case 64: {
            PIMILJPKOIH = (global::EggLink.DanhengServer.Proto.PunkLordShareType) input.ReadEnum();
            break;
          }
          case 72: {
            LHGBPNNPAEM = input.ReadBool();
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
            Uid = input.ReadUInt32();
            break;
          }
          case 16: {
            MonsterId = input.ReadUInt32();
            break;
          }
          case 24: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 32: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 40: {
            Timestamp = input.ReadInt64();
            break;
          }
          case 48: {
            LeftHp = input.ReadUInt32();
            break;
          }
          case 56: {
            ILIGJLCNHAE = input.ReadUInt32();
            break;
          }
          case 64: {
            PIMILJPKOIH = (global::EggLink.DanhengServer.Proto.PunkLordShareType) input.ReadEnum();
            break;
          }
          case 72: {
            LHGBPNNPAEM = input.ReadBool();
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