// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueGameAeonInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueGameAeonInfo.proto</summary>
  public static partial class ChessRogueGameAeonInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueGameAeonInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueGameAeonInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxDaGVzc1JvZ3VlR2FtZUFlb25JbmZvLnByb3RvGhFEQU5FRUhNS0RLTi5w",
            "cm90byJhChZDaGVzc1JvZ3VlR2FtZUFlb25JbmZvEhMKC0hOQ0dQTUNCTkxI",
            "GAQgASgFEg8KB2Flb25faWQYByABKA0SIQoLSURNTk1BUEFIT00YBiABKAsy",
            "DC5EQU5FRUhNS0RLTkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.DANEEHMKDKNReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueGameAeonInfo), global::EggLink.DanhengServer.Proto.ChessRogueGameAeonInfo.Parser, new[]{ "HNCGPMCBNLH", "AeonId", "IDMNMAPAHOM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueGameAeonInfo : pb::IMessage<ChessRogueGameAeonInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueGameAeonInfo> _parser = new pb::MessageParser<ChessRogueGameAeonInfo>(() => new ChessRogueGameAeonInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueGameAeonInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueGameAeonInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueGameAeonInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueGameAeonInfo(ChessRogueGameAeonInfo other) : this() {
      hNCGPMCBNLH_ = other.hNCGPMCBNLH_;
      aeonId_ = other.aeonId_;
      iDMNMAPAHOM_ = other.iDMNMAPAHOM_ != null ? other.iDMNMAPAHOM_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueGameAeonInfo Clone() {
      return new ChessRogueGameAeonInfo(this);
    }

    /// <summary>Field number for the "HNCGPMCBNLH" field.</summary>
    public const int HNCGPMCBNLHFieldNumber = 4;
    private int hNCGPMCBNLH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int HNCGPMCBNLH {
      get { return hNCGPMCBNLH_; }
      set {
        hNCGPMCBNLH_ = value;
      }
    }

    /// <summary>Field number for the "aeon_id" field.</summary>
    public const int AeonIdFieldNumber = 7;
    private uint aeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AeonId {
      get { return aeonId_; }
      set {
        aeonId_ = value;
      }
    }

    /// <summary>Field number for the "IDMNMAPAHOM" field.</summary>
    public const int IDMNMAPAHOMFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.DANEEHMKDKN iDMNMAPAHOM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.DANEEHMKDKN IDMNMAPAHOM {
      get { return iDMNMAPAHOM_; }
      set {
        iDMNMAPAHOM_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueGameAeonInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueGameAeonInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HNCGPMCBNLH != other.HNCGPMCBNLH) return false;
      if (AeonId != other.AeonId) return false;
      if (!object.Equals(IDMNMAPAHOM, other.IDMNMAPAHOM)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HNCGPMCBNLH != 0) hash ^= HNCGPMCBNLH.GetHashCode();
      if (AeonId != 0) hash ^= AeonId.GetHashCode();
      if (iDMNMAPAHOM_ != null) hash ^= IDMNMAPAHOM.GetHashCode();
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
      if (HNCGPMCBNLH != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(HNCGPMCBNLH);
      }
      if (iDMNMAPAHOM_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(IDMNMAPAHOM);
      }
      if (AeonId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(AeonId);
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
      if (HNCGPMCBNLH != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(HNCGPMCBNLH);
      }
      if (iDMNMAPAHOM_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(IDMNMAPAHOM);
      }
      if (AeonId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(AeonId);
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
      if (HNCGPMCBNLH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(HNCGPMCBNLH);
      }
      if (AeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AeonId);
      }
      if (iDMNMAPAHOM_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IDMNMAPAHOM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueGameAeonInfo other) {
      if (other == null) {
        return;
      }
      if (other.HNCGPMCBNLH != 0) {
        HNCGPMCBNLH = other.HNCGPMCBNLH;
      }
      if (other.AeonId != 0) {
        AeonId = other.AeonId;
      }
      if (other.iDMNMAPAHOM_ != null) {
        if (iDMNMAPAHOM_ == null) {
          IDMNMAPAHOM = new global::EggLink.DanhengServer.Proto.DANEEHMKDKN();
        }
        IDMNMAPAHOM.MergeFrom(other.IDMNMAPAHOM);
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
          case 32: {
            HNCGPMCBNLH = input.ReadInt32();
            break;
          }
          case 50: {
            if (iDMNMAPAHOM_ == null) {
              IDMNMAPAHOM = new global::EggLink.DanhengServer.Proto.DANEEHMKDKN();
            }
            input.ReadMessage(IDMNMAPAHOM);
            break;
          }
          case 56: {
            AeonId = input.ReadUInt32();
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
          case 32: {
            HNCGPMCBNLH = input.ReadInt32();
            break;
          }
          case 50: {
            if (iDMNMAPAHOM_ == null) {
              IDMNMAPAHOM = new global::EggLink.DanhengServer.Proto.DANEEHMKDKN();
            }
            input.ReadMessage(IDMNMAPAHOM);
            break;
          }
          case 56: {
            AeonId = input.ReadUInt32();
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
