// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UpdateMapRotationDataScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from UpdateMapRotationDataScNotify.proto</summary>
  public static partial class UpdateMapRotationDataScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for UpdateMapRotationDataScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UpdateMapRotationDataScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNVcGRhdGVNYXBSb3RhdGlvbkRhdGFTY05vdGlmeS5wcm90bxoRQ2hhcmdl",
            "ckluZm8ucHJvdG8aEVJvdGF0ZXJEYXRhLnByb3RvGhdSb3RhdG9yRW5lcmd5",
            "SW5mby5wcm90bxoTUm90YXRlTWFwSW5mby5wcm90byLqAQodVXBkYXRlTWFw",
            "Um90YXRpb25EYXRhU2NOb3RpZnkSIQoLTEREQkxCRk9CSUwYCiADKAsyDC5S",
            "b3RhdGVyRGF0YRIgCghtYXBfaW5mbxgCIAEoCzIOLlJvdGF0ZU1hcEluZm8S",
            "JwoLZW5lcmd5X2luZm8YBiABKAsyEi5Sb3RhdG9yRW5lcmd5SW5mbxIRCglp",
            "c19yb3RhdGUYBCABKAgSEwoLTU5OSFBKR0xPS00YDiABKA0SIQoLR0hHRUND",
            "S01GR0sYCCADKAsyDC5DaGFyZ2VySW5mbxIQCghyb3RhdGlvbhgHIAEoBUIe",
            "qgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChargerInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RotaterDataReflection.Descriptor, global::EggLink.DanhengServer.Proto.RotatorEnergyInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RotateMapInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.UpdateMapRotationDataScNotify), global::EggLink.DanhengServer.Proto.UpdateMapRotationDataScNotify.Parser, new[]{ "LDDBLBFOBIL", "MapInfo", "EnergyInfo", "IsRotate", "MNNHPJGLOKM", "GHGECCKMFGK", "Rotation" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UpdateMapRotationDataScNotify : pb::IMessage<UpdateMapRotationDataScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UpdateMapRotationDataScNotify> _parser = new pb::MessageParser<UpdateMapRotationDataScNotify>(() => new UpdateMapRotationDataScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UpdateMapRotationDataScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.UpdateMapRotationDataScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateMapRotationDataScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateMapRotationDataScNotify(UpdateMapRotationDataScNotify other) : this() {
      lDDBLBFOBIL_ = other.lDDBLBFOBIL_.Clone();
      mapInfo_ = other.mapInfo_ != null ? other.mapInfo_.Clone() : null;
      energyInfo_ = other.energyInfo_ != null ? other.energyInfo_.Clone() : null;
      isRotate_ = other.isRotate_;
      mNNHPJGLOKM_ = other.mNNHPJGLOKM_;
      gHGECCKMFGK_ = other.gHGECCKMFGK_.Clone();
      rotation_ = other.rotation_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpdateMapRotationDataScNotify Clone() {
      return new UpdateMapRotationDataScNotify(this);
    }

    /// <summary>Field number for the "LDDBLBFOBIL" field.</summary>
    public const int LDDBLBFOBILFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.RotaterData> _repeated_lDDBLBFOBIL_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.RotaterData.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RotaterData> lDDBLBFOBIL_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RotaterData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.RotaterData> LDDBLBFOBIL {
      get { return lDDBLBFOBIL_; }
    }

    /// <summary>Field number for the "map_info" field.</summary>
    public const int MapInfoFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.RotateMapInfo mapInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RotateMapInfo MapInfo {
      get { return mapInfo_; }
      set {
        mapInfo_ = value;
      }
    }

    /// <summary>Field number for the "energy_info" field.</summary>
    public const int EnergyInfoFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.RotatorEnergyInfo energyInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RotatorEnergyInfo EnergyInfo {
      get { return energyInfo_; }
      set {
        energyInfo_ = value;
      }
    }

    /// <summary>Field number for the "is_rotate" field.</summary>
    public const int IsRotateFieldNumber = 4;
    private bool isRotate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsRotate {
      get { return isRotate_; }
      set {
        isRotate_ = value;
      }
    }

    /// <summary>Field number for the "MNNHPJGLOKM" field.</summary>
    public const int MNNHPJGLOKMFieldNumber = 14;
    private uint mNNHPJGLOKM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MNNHPJGLOKM {
      get { return mNNHPJGLOKM_; }
      set {
        mNNHPJGLOKM_ = value;
      }
    }

    /// <summary>Field number for the "GHGECCKMFGK" field.</summary>
    public const int GHGECCKMFGKFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ChargerInfo> _repeated_gHGECCKMFGK_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.ChargerInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChargerInfo> gHGECCKMFGK_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChargerInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ChargerInfo> GHGECCKMFGK {
      get { return gHGECCKMFGK_; }
    }

    /// <summary>Field number for the "rotation" field.</summary>
    public const int RotationFieldNumber = 7;
    private int rotation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Rotation {
      get { return rotation_; }
      set {
        rotation_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UpdateMapRotationDataScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UpdateMapRotationDataScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!lDDBLBFOBIL_.Equals(other.lDDBLBFOBIL_)) return false;
      if (!object.Equals(MapInfo, other.MapInfo)) return false;
      if (!object.Equals(EnergyInfo, other.EnergyInfo)) return false;
      if (IsRotate != other.IsRotate) return false;
      if (MNNHPJGLOKM != other.MNNHPJGLOKM) return false;
      if(!gHGECCKMFGK_.Equals(other.gHGECCKMFGK_)) return false;
      if (Rotation != other.Rotation) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= lDDBLBFOBIL_.GetHashCode();
      if (mapInfo_ != null) hash ^= MapInfo.GetHashCode();
      if (energyInfo_ != null) hash ^= EnergyInfo.GetHashCode();
      if (IsRotate != false) hash ^= IsRotate.GetHashCode();
      if (MNNHPJGLOKM != 0) hash ^= MNNHPJGLOKM.GetHashCode();
      hash ^= gHGECCKMFGK_.GetHashCode();
      if (Rotation != 0) hash ^= Rotation.GetHashCode();
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
      if (mapInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MapInfo);
      }
      if (IsRotate != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsRotate);
      }
      if (energyInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(EnergyInfo);
      }
      if (Rotation != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Rotation);
      }
      gHGECCKMFGK_.WriteTo(output, _repeated_gHGECCKMFGK_codec);
      lDDBLBFOBIL_.WriteTo(output, _repeated_lDDBLBFOBIL_codec);
      if (MNNHPJGLOKM != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MNNHPJGLOKM);
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
      if (mapInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MapInfo);
      }
      if (IsRotate != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsRotate);
      }
      if (energyInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(EnergyInfo);
      }
      if (Rotation != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Rotation);
      }
      gHGECCKMFGK_.WriteTo(ref output, _repeated_gHGECCKMFGK_codec);
      lDDBLBFOBIL_.WriteTo(ref output, _repeated_lDDBLBFOBIL_codec);
      if (MNNHPJGLOKM != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MNNHPJGLOKM);
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
      size += lDDBLBFOBIL_.CalculateSize(_repeated_lDDBLBFOBIL_codec);
      if (mapInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MapInfo);
      }
      if (energyInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EnergyInfo);
      }
      if (IsRotate != false) {
        size += 1 + 1;
      }
      if (MNNHPJGLOKM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MNNHPJGLOKM);
      }
      size += gHGECCKMFGK_.CalculateSize(_repeated_gHGECCKMFGK_codec);
      if (Rotation != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Rotation);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UpdateMapRotationDataScNotify other) {
      if (other == null) {
        return;
      }
      lDDBLBFOBIL_.Add(other.lDDBLBFOBIL_);
      if (other.mapInfo_ != null) {
        if (mapInfo_ == null) {
          MapInfo = new global::EggLink.DanhengServer.Proto.RotateMapInfo();
        }
        MapInfo.MergeFrom(other.MapInfo);
      }
      if (other.energyInfo_ != null) {
        if (energyInfo_ == null) {
          EnergyInfo = new global::EggLink.DanhengServer.Proto.RotatorEnergyInfo();
        }
        EnergyInfo.MergeFrom(other.EnergyInfo);
      }
      if (other.IsRotate != false) {
        IsRotate = other.IsRotate;
      }
      if (other.MNNHPJGLOKM != 0) {
        MNNHPJGLOKM = other.MNNHPJGLOKM;
      }
      gHGECCKMFGK_.Add(other.gHGECCKMFGK_);
      if (other.Rotation != 0) {
        Rotation = other.Rotation;
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
          case 18: {
            if (mapInfo_ == null) {
              MapInfo = new global::EggLink.DanhengServer.Proto.RotateMapInfo();
            }
            input.ReadMessage(MapInfo);
            break;
          }
          case 32: {
            IsRotate = input.ReadBool();
            break;
          }
          case 50: {
            if (energyInfo_ == null) {
              EnergyInfo = new global::EggLink.DanhengServer.Proto.RotatorEnergyInfo();
            }
            input.ReadMessage(EnergyInfo);
            break;
          }
          case 56: {
            Rotation = input.ReadInt32();
            break;
          }
          case 66: {
            gHGECCKMFGK_.AddEntriesFrom(input, _repeated_gHGECCKMFGK_codec);
            break;
          }
          case 82: {
            lDDBLBFOBIL_.AddEntriesFrom(input, _repeated_lDDBLBFOBIL_codec);
            break;
          }
          case 112: {
            MNNHPJGLOKM = input.ReadUInt32();
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
          case 18: {
            if (mapInfo_ == null) {
              MapInfo = new global::EggLink.DanhengServer.Proto.RotateMapInfo();
            }
            input.ReadMessage(MapInfo);
            break;
          }
          case 32: {
            IsRotate = input.ReadBool();
            break;
          }
          case 50: {
            if (energyInfo_ == null) {
              EnergyInfo = new global::EggLink.DanhengServer.Proto.RotatorEnergyInfo();
            }
            input.ReadMessage(EnergyInfo);
            break;
          }
          case 56: {
            Rotation = input.ReadInt32();
            break;
          }
          case 66: {
            gHGECCKMFGK_.AddEntriesFrom(ref input, _repeated_gHGECCKMFGK_codec);
            break;
          }
          case 82: {
            lDDBLBFOBIL_.AddEntriesFrom(ref input, _repeated_lDDBLBFOBIL_codec);
            break;
          }
          case 112: {
            MNNHPJGLOKM = input.ReadUInt32();
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
