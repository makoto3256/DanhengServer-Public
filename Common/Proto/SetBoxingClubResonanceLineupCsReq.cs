// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SetBoxingClubResonanceLineupCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SetBoxingClubResonanceLineupCsReq.proto</summary>
  public static partial class SetBoxingClubResonanceLineupCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SetBoxingClubResonanceLineupCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetBoxingClubResonanceLineupCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidTZXRCb3hpbmdDbHViUmVzb25hbmNlTGluZXVwQ3NSZXEucHJvdG8aEUVF",
            "SU1KSEZES0dOLnByb3RvIlwKIVNldEJveGluZ0NsdWJSZXNvbmFuY2VMaW5l",
            "dXBDc1JlcRIUCgxjaGFsbGVuZ2VfaWQYDSABKA0SIQoLSUNDUERQQ0JFRUIY",
            "BiADKAsyDC5FRUlNSkhGREtHTkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVy",
            "LlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.EEIMJHFDKGNReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SetBoxingClubResonanceLineupCsReq), global::EggLink.DanhengServer.Proto.SetBoxingClubResonanceLineupCsReq.Parser, new[]{ "ChallengeId", "ICCPDPCBEEB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SetBoxingClubResonanceLineupCsReq : pb::IMessage<SetBoxingClubResonanceLineupCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SetBoxingClubResonanceLineupCsReq> _parser = new pb::MessageParser<SetBoxingClubResonanceLineupCsReq>(() => new SetBoxingClubResonanceLineupCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SetBoxingClubResonanceLineupCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SetBoxingClubResonanceLineupCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetBoxingClubResonanceLineupCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetBoxingClubResonanceLineupCsReq(SetBoxingClubResonanceLineupCsReq other) : this() {
      challengeId_ = other.challengeId_;
      iCCPDPCBEEB_ = other.iCCPDPCBEEB_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetBoxingClubResonanceLineupCsReq Clone() {
      return new SetBoxingClubResonanceLineupCsReq(this);
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 13;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    /// <summary>Field number for the "ICCPDPCBEEB" field.</summary>
    public const int ICCPDPCBEEBFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.EEIMJHFDKGN> _repeated_iCCPDPCBEEB_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.EEIMJHFDKGN.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EEIMJHFDKGN> iCCPDPCBEEB_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EEIMJHFDKGN>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EEIMJHFDKGN> ICCPDPCBEEB {
      get { return iCCPDPCBEEB_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SetBoxingClubResonanceLineupCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SetBoxingClubResonanceLineupCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChallengeId != other.ChallengeId) return false;
      if(!iCCPDPCBEEB_.Equals(other.iCCPDPCBEEB_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
      hash ^= iCCPDPCBEEB_.GetHashCode();
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
      iCCPDPCBEEB_.WriteTo(output, _repeated_iCCPDPCBEEB_codec);
      if (ChallengeId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ChallengeId);
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
      iCCPDPCBEEB_.WriteTo(ref output, _repeated_iCCPDPCBEEB_codec);
      if (ChallengeId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ChallengeId);
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
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      size += iCCPDPCBEEB_.CalculateSize(_repeated_iCCPDPCBEEB_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SetBoxingClubResonanceLineupCsReq other) {
      if (other == null) {
        return;
      }
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
      }
      iCCPDPCBEEB_.Add(other.iCCPDPCBEEB_);
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
          case 50: {
            iCCPDPCBEEB_.AddEntriesFrom(input, _repeated_iCCPDPCBEEB_codec);
            break;
          }
          case 104: {
            ChallengeId = input.ReadUInt32();
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
          case 50: {
            iCCPDPCBEEB_.AddEntriesFrom(ref input, _repeated_iCCPDPCBEEB_codec);
            break;
          }
          case 104: {
            ChallengeId = input.ReadUInt32();
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
