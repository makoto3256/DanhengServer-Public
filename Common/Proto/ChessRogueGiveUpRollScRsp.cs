// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueGiveUpRollScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueGiveUpRollScRsp.proto</summary>
  public static partial class ChessRogueGiveUpRollScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueGiveUpRollScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueGiveUpRollScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9DaGVzc1JvZ3VlR2l2ZVVwUm9sbFNjUnNwLnByb3RvGhhDaGVzc1JvZ3Vl",
            "RGljZUluZm8ucHJvdG8aDkl0ZW1MaXN0LnByb3RvInoKGUNoZXNzUm9ndWVH",
            "aXZlVXBSb2xsU2NSc3ASDwoHcmV0Y29kZRgMIAEoDRIsCg9yb2d1ZV9kaWNl",
            "X2luZm8YDiABKAsyEy5DaGVzc1JvZ3VlRGljZUluZm8SHgoLSENCUEtOSkJC",
            "R08YAyABKAsyCS5JdGVtTGlzdEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessRogueDiceInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueGiveUpRollScRsp), global::EggLink.DanhengServer.Proto.ChessRogueGiveUpRollScRsp.Parser, new[]{ "Retcode", "RogueDiceInfo", "HCBPKNJBBGO" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueGiveUpRollScRsp : pb::IMessage<ChessRogueGiveUpRollScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueGiveUpRollScRsp> _parser = new pb::MessageParser<ChessRogueGiveUpRollScRsp>(() => new ChessRogueGiveUpRollScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueGiveUpRollScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueGiveUpRollScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueGiveUpRollScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueGiveUpRollScRsp(ChessRogueGiveUpRollScRsp other) : this() {
      retcode_ = other.retcode_;
      rogueDiceInfo_ = other.rogueDiceInfo_ != null ? other.rogueDiceInfo_.Clone() : null;
      hCBPKNJBBGO_ = other.hCBPKNJBBGO_ != null ? other.hCBPKNJBBGO_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueGiveUpRollScRsp Clone() {
      return new ChessRogueGiveUpRollScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 12;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "rogue_dice_info" field.</summary>
    public const int RogueDiceInfoFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo rogueDiceInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo RogueDiceInfo {
      get { return rogueDiceInfo_; }
      set {
        rogueDiceInfo_ = value;
      }
    }

    /// <summary>Field number for the "HCBPKNJBBGO" field.</summary>
    public const int HCBPKNJBBGOFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.ItemList hCBPKNJBBGO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList HCBPKNJBBGO {
      get { return hCBPKNJBBGO_; }
      set {
        hCBPKNJBBGO_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueGiveUpRollScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueGiveUpRollScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(RogueDiceInfo, other.RogueDiceInfo)) return false;
      if (!object.Equals(HCBPKNJBBGO, other.HCBPKNJBBGO)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (rogueDiceInfo_ != null) hash ^= RogueDiceInfo.GetHashCode();
      if (hCBPKNJBBGO_ != null) hash ^= HCBPKNJBBGO.GetHashCode();
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
      if (hCBPKNJBBGO_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(HCBPKNJBBGO);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
      }
      if (rogueDiceInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(RogueDiceInfo);
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
      if (hCBPKNJBBGO_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(HCBPKNJBBGO);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Retcode);
      }
      if (rogueDiceInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(RogueDiceInfo);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (rogueDiceInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueDiceInfo);
      }
      if (hCBPKNJBBGO_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HCBPKNJBBGO);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueGiveUpRollScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.rogueDiceInfo_ != null) {
        if (rogueDiceInfo_ == null) {
          RogueDiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo();
        }
        RogueDiceInfo.MergeFrom(other.RogueDiceInfo);
      }
      if (other.hCBPKNJBBGO_ != null) {
        if (hCBPKNJBBGO_ == null) {
          HCBPKNJBBGO = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        HCBPKNJBBGO.MergeFrom(other.HCBPKNJBBGO);
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
          case 26: {
            if (hCBPKNJBBGO_ == null) {
              HCBPKNJBBGO = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(HCBPKNJBBGO);
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 114: {
            if (rogueDiceInfo_ == null) {
              RogueDiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo();
            }
            input.ReadMessage(RogueDiceInfo);
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
          case 26: {
            if (hCBPKNJBBGO_ == null) {
              HCBPKNJBBGO = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(HCBPKNJBBGO);
            break;
          }
          case 96: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 114: {
            if (rogueDiceInfo_ == null) {
              RogueDiceInfo = new global::EggLink.DanhengServer.Proto.ChessRogueDiceInfo();
            }
            input.ReadMessage(RogueDiceInfo);
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
