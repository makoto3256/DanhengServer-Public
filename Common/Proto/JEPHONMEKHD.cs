// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: JEPHONMEKHD.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from JEPHONMEKHD.proto</summary>
  public static partial class JEPHONMEKHDReflection {

    #region Descriptor
    /// <summary>File descriptor for JEPHONMEKHD.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static JEPHONMEKHDReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFKRVBIT05NRUtIRC5wcm90bxogQmF0dGxlU3RhdGljdGljRXZlbnRTdGF0",
            "dXMucHJvdG8iYgoLSkVQSE9OTUVLSEQSKQoEdHlwZRgBIAEoDjIbLkJhdHRs",
            "ZVN0YXRpY3RpY0V2ZW50U3RhdHVzEhMKC0dGT09QSktPQkhBGAIgASgNEhMK",
            "C0pORkJFT0lMS0JPGAMgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.BattleStaticticEventStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.JEPHONMEKHD), global::EggLink.DanhengServer.Proto.JEPHONMEKHD.Parser, new[]{ "Type", "GFOOPJKOBHA", "JNFBEOILKBO" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class JEPHONMEKHD : pb::IMessage<JEPHONMEKHD>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<JEPHONMEKHD> _parser = new pb::MessageParser<JEPHONMEKHD>(() => new JEPHONMEKHD());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<JEPHONMEKHD> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.JEPHONMEKHDReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JEPHONMEKHD() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JEPHONMEKHD(JEPHONMEKHD other) : this() {
      type_ = other.type_;
      gFOOPJKOBHA_ = other.gFOOPJKOBHA_;
      jNFBEOILKBO_ = other.jNFBEOILKBO_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JEPHONMEKHD Clone() {
      return new JEPHONMEKHD(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.BattleStaticticEventStatus type_ = global::EggLink.DanhengServer.Proto.BattleStaticticEventStatus.BattleStaticticEventNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BattleStaticticEventStatus Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "GFOOPJKOBHA" field.</summary>
    public const int GFOOPJKOBHAFieldNumber = 2;
    private uint gFOOPJKOBHA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GFOOPJKOBHA {
      get { return gFOOPJKOBHA_; }
      set {
        gFOOPJKOBHA_ = value;
      }
    }

    /// <summary>Field number for the "JNFBEOILKBO" field.</summary>
    public const int JNFBEOILKBOFieldNumber = 3;
    private uint jNFBEOILKBO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JNFBEOILKBO {
      get { return jNFBEOILKBO_; }
      set {
        jNFBEOILKBO_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as JEPHONMEKHD);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(JEPHONMEKHD other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (GFOOPJKOBHA != other.GFOOPJKOBHA) return false;
      if (JNFBEOILKBO != other.JNFBEOILKBO) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::EggLink.DanhengServer.Proto.BattleStaticticEventStatus.BattleStaticticEventNone) hash ^= Type.GetHashCode();
      if (GFOOPJKOBHA != 0) hash ^= GFOOPJKOBHA.GetHashCode();
      if (JNFBEOILKBO != 0) hash ^= JNFBEOILKBO.GetHashCode();
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
      if (Type != global::EggLink.DanhengServer.Proto.BattleStaticticEventStatus.BattleStaticticEventNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (GFOOPJKOBHA != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GFOOPJKOBHA);
      }
      if (JNFBEOILKBO != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(JNFBEOILKBO);
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
      if (Type != global::EggLink.DanhengServer.Proto.BattleStaticticEventStatus.BattleStaticticEventNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (GFOOPJKOBHA != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GFOOPJKOBHA);
      }
      if (JNFBEOILKBO != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(JNFBEOILKBO);
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
      if (Type != global::EggLink.DanhengServer.Proto.BattleStaticticEventStatus.BattleStaticticEventNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (GFOOPJKOBHA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GFOOPJKOBHA);
      }
      if (JNFBEOILKBO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JNFBEOILKBO);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(JEPHONMEKHD other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::EggLink.DanhengServer.Proto.BattleStaticticEventStatus.BattleStaticticEventNone) {
        Type = other.Type;
      }
      if (other.GFOOPJKOBHA != 0) {
        GFOOPJKOBHA = other.GFOOPJKOBHA;
      }
      if (other.JNFBEOILKBO != 0) {
        JNFBEOILKBO = other.JNFBEOILKBO;
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
            Type = (global::EggLink.DanhengServer.Proto.BattleStaticticEventStatus) input.ReadEnum();
            break;
          }
          case 16: {
            GFOOPJKOBHA = input.ReadUInt32();
            break;
          }
          case 24: {
            JNFBEOILKBO = input.ReadUInt32();
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
            Type = (global::EggLink.DanhengServer.Proto.BattleStaticticEventStatus) input.ReadEnum();
            break;
          }
          case 16: {
            GFOOPJKOBHA = input.ReadUInt32();
            break;
          }
          case 24: {
            JNFBEOILKBO = input.ReadUInt32();
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
