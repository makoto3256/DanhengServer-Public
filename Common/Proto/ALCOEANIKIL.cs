// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ALCOEANIKIL.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ALCOEANIKIL.proto</summary>
  public static partial class ALCOEANIKILReflection {

    #region Descriptor
    /// <summary>File descriptor for ALCOEANIKIL.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ALCOEANIKILReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFBTENPRUFOSUtJTC5wcm90bxoaRGlzcGxheUNoYWxsZW5nZUluZm8ucHJv",
            "dG8ieQoLQUxDT0VBTklLSUwSEwoLQkVPQ1BHSUFNUEQYCiABKA0SKwoMZGlz",
            "cGxheV90eXBlGAUgASgOMhUuRGlzcGxheUNoYWxsZW5nZUluZm8SEwoLTUJC",
            "UElMR0pHSUwYBCABKA0SEwoLTU9EQVBJR0pOTkoYDSABKA1CHqoCG0VnZ0xp",
            "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.DisplayChallengeInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ALCOEANIKIL), global::EggLink.DanhengServer.Proto.ALCOEANIKIL.Parser, new[]{ "BEOCPGIAMPD", "DisplayType", "MBBPILGJGIL", "MODAPIGJNNJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ALCOEANIKIL : pb::IMessage<ALCOEANIKIL>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ALCOEANIKIL> _parser = new pb::MessageParser<ALCOEANIKIL>(() => new ALCOEANIKIL());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ALCOEANIKIL> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ALCOEANIKILReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ALCOEANIKIL() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ALCOEANIKIL(ALCOEANIKIL other) : this() {
      bEOCPGIAMPD_ = other.bEOCPGIAMPD_;
      displayType_ = other.displayType_;
      mBBPILGJGIL_ = other.mBBPILGJGIL_;
      mODAPIGJNNJ_ = other.mODAPIGJNNJ_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ALCOEANIKIL Clone() {
      return new ALCOEANIKIL(this);
    }

    /// <summary>Field number for the "BEOCPGIAMPD" field.</summary>
    public const int BEOCPGIAMPDFieldNumber = 10;
    private uint bEOCPGIAMPD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BEOCPGIAMPD {
      get { return bEOCPGIAMPD_; }
      set {
        bEOCPGIAMPD_ = value;
      }
    }

    /// <summary>Field number for the "display_type" field.</summary>
    public const int DisplayTypeFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.DisplayChallengeInfo displayType_ = global::EggLink.DanhengServer.Proto.DisplayChallengeInfo.BattleRecordNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.DisplayChallengeInfo DisplayType {
      get { return displayType_; }
      set {
        displayType_ = value;
      }
    }

    /// <summary>Field number for the "MBBPILGJGIL" field.</summary>
    public const int MBBPILGJGILFieldNumber = 4;
    private uint mBBPILGJGIL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MBBPILGJGIL {
      get { return mBBPILGJGIL_; }
      set {
        mBBPILGJGIL_ = value;
      }
    }

    /// <summary>Field number for the "MODAPIGJNNJ" field.</summary>
    public const int MODAPIGJNNJFieldNumber = 13;
    private uint mODAPIGJNNJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MODAPIGJNNJ {
      get { return mODAPIGJNNJ_; }
      set {
        mODAPIGJNNJ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ALCOEANIKIL);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ALCOEANIKIL other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BEOCPGIAMPD != other.BEOCPGIAMPD) return false;
      if (DisplayType != other.DisplayType) return false;
      if (MBBPILGJGIL != other.MBBPILGJGIL) return false;
      if (MODAPIGJNNJ != other.MODAPIGJNNJ) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BEOCPGIAMPD != 0) hash ^= BEOCPGIAMPD.GetHashCode();
      if (DisplayType != global::EggLink.DanhengServer.Proto.DisplayChallengeInfo.BattleRecordNone) hash ^= DisplayType.GetHashCode();
      if (MBBPILGJGIL != 0) hash ^= MBBPILGJGIL.GetHashCode();
      if (MODAPIGJNNJ != 0) hash ^= MODAPIGJNNJ.GetHashCode();
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
      if (MBBPILGJGIL != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MBBPILGJGIL);
      }
      if (DisplayType != global::EggLink.DanhengServer.Proto.DisplayChallengeInfo.BattleRecordNone) {
        output.WriteRawTag(40);
        output.WriteEnum((int) DisplayType);
      }
      if (BEOCPGIAMPD != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(BEOCPGIAMPD);
      }
      if (MODAPIGJNNJ != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MODAPIGJNNJ);
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
      if (MBBPILGJGIL != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MBBPILGJGIL);
      }
      if (DisplayType != global::EggLink.DanhengServer.Proto.DisplayChallengeInfo.BattleRecordNone) {
        output.WriteRawTag(40);
        output.WriteEnum((int) DisplayType);
      }
      if (BEOCPGIAMPD != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(BEOCPGIAMPD);
      }
      if (MODAPIGJNNJ != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MODAPIGJNNJ);
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
      if (BEOCPGIAMPD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BEOCPGIAMPD);
      }
      if (DisplayType != global::EggLink.DanhengServer.Proto.DisplayChallengeInfo.BattleRecordNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DisplayType);
      }
      if (MBBPILGJGIL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MBBPILGJGIL);
      }
      if (MODAPIGJNNJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MODAPIGJNNJ);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ALCOEANIKIL other) {
      if (other == null) {
        return;
      }
      if (other.BEOCPGIAMPD != 0) {
        BEOCPGIAMPD = other.BEOCPGIAMPD;
      }
      if (other.DisplayType != global::EggLink.DanhengServer.Proto.DisplayChallengeInfo.BattleRecordNone) {
        DisplayType = other.DisplayType;
      }
      if (other.MBBPILGJGIL != 0) {
        MBBPILGJGIL = other.MBBPILGJGIL;
      }
      if (other.MODAPIGJNNJ != 0) {
        MODAPIGJNNJ = other.MODAPIGJNNJ;
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
            MBBPILGJGIL = input.ReadUInt32();
            break;
          }
          case 40: {
            DisplayType = (global::EggLink.DanhengServer.Proto.DisplayChallengeInfo) input.ReadEnum();
            break;
          }
          case 80: {
            BEOCPGIAMPD = input.ReadUInt32();
            break;
          }
          case 104: {
            MODAPIGJNNJ = input.ReadUInt32();
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
            MBBPILGJGIL = input.ReadUInt32();
            break;
          }
          case 40: {
            DisplayType = (global::EggLink.DanhengServer.Proto.DisplayChallengeInfo) input.ReadEnum();
            break;
          }
          case 80: {
            BEOCPGIAMPD = input.ReadUInt32();
            break;
          }
          case 104: {
            MODAPIGJNNJ = input.ReadUInt32();
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
