// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IIPBNJMNFHL.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from IIPBNJMNFHL.proto</summary>
  public static partial class IIPBNJMNFHLReflection {

    #region Descriptor
    /// <summary>File descriptor for IIPBNJMNFHL.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IIPBNJMNFHLReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFJSVBCTkpNTkZITC5wcm90bxoXSGVhcnREaWFsU3RlcFR5cGUucHJvdG8a",
            "GkhlYXJ0RGlhbEVtb3Rpb25UeXBlLnByb3RvIpoBCgtJSVBCTkpNTkZITBIq",
            "CgtHS09LTkNITEtMSBgNIAEoDjIVLkhlYXJ0RGlhbEVtb3Rpb25UeXBlEhMK",
            "C0lJQUZOS09GSEJMGAEgASgIEiAKBHN0ZXAYBiABKA4yEi5IZWFydERpYWxT",
            "dGVwVHlwZRITCgtKUENMRkNJQkhNShgLIAEoCBITCgtHQkxHRFBQSUZQRRgP",
            "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HeartDialStepTypeReflection.Descriptor, global::EggLink.DanhengServer.Proto.HeartDialEmotionTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.IIPBNJMNFHL), global::EggLink.DanhengServer.Proto.IIPBNJMNFHL.Parser, new[]{ "GKOKNCHLKLH", "IIAFNKOFHBL", "Step", "JPCLFCIBHMJ", "GBLGDPPIFPE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class IIPBNJMNFHL : pb::IMessage<IIPBNJMNFHL>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IIPBNJMNFHL> _parser = new pb::MessageParser<IIPBNJMNFHL>(() => new IIPBNJMNFHL());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<IIPBNJMNFHL> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.IIPBNJMNFHLReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IIPBNJMNFHL() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IIPBNJMNFHL(IIPBNJMNFHL other) : this() {
      gKOKNCHLKLH_ = other.gKOKNCHLKLH_;
      iIAFNKOFHBL_ = other.iIAFNKOFHBL_;
      step_ = other.step_;
      jPCLFCIBHMJ_ = other.jPCLFCIBHMJ_;
      gBLGDPPIFPE_ = other.gBLGDPPIFPE_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IIPBNJMNFHL Clone() {
      return new IIPBNJMNFHL(this);
    }

    /// <summary>Field number for the "GKOKNCHLKLH" field.</summary>
    public const int GKOKNCHLKLHFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.HeartDialEmotionType gKOKNCHLKLH_ = global::EggLink.DanhengServer.Proto.HeartDialEmotionType.Peace;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HeartDialEmotionType GKOKNCHLKLH {
      get { return gKOKNCHLKLH_; }
      set {
        gKOKNCHLKLH_ = value;
      }
    }

    /// <summary>Field number for the "IIAFNKOFHBL" field.</summary>
    public const int IIAFNKOFHBLFieldNumber = 1;
    private bool iIAFNKOFHBL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IIAFNKOFHBL {
      get { return iIAFNKOFHBL_; }
      set {
        iIAFNKOFHBL_ = value;
      }
    }

    /// <summary>Field number for the "step" field.</summary>
    public const int StepFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.HeartDialStepType step_ = global::EggLink.DanhengServer.Proto.HeartDialStepType.Missing;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HeartDialStepType Step {
      get { return step_; }
      set {
        step_ = value;
      }
    }

    /// <summary>Field number for the "JPCLFCIBHMJ" field.</summary>
    public const int JPCLFCIBHMJFieldNumber = 11;
    private bool jPCLFCIBHMJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool JPCLFCIBHMJ {
      get { return jPCLFCIBHMJ_; }
      set {
        jPCLFCIBHMJ_ = value;
      }
    }

    /// <summary>Field number for the "GBLGDPPIFPE" field.</summary>
    public const int GBLGDPPIFPEFieldNumber = 15;
    private uint gBLGDPPIFPE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GBLGDPPIFPE {
      get { return gBLGDPPIFPE_; }
      set {
        gBLGDPPIFPE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as IIPBNJMNFHL);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(IIPBNJMNFHL other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GKOKNCHLKLH != other.GKOKNCHLKLH) return false;
      if (IIAFNKOFHBL != other.IIAFNKOFHBL) return false;
      if (Step != other.Step) return false;
      if (JPCLFCIBHMJ != other.JPCLFCIBHMJ) return false;
      if (GBLGDPPIFPE != other.GBLGDPPIFPE) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GKOKNCHLKLH != global::EggLink.DanhengServer.Proto.HeartDialEmotionType.Peace) hash ^= GKOKNCHLKLH.GetHashCode();
      if (IIAFNKOFHBL != false) hash ^= IIAFNKOFHBL.GetHashCode();
      if (Step != global::EggLink.DanhengServer.Proto.HeartDialStepType.Missing) hash ^= Step.GetHashCode();
      if (JPCLFCIBHMJ != false) hash ^= JPCLFCIBHMJ.GetHashCode();
      if (GBLGDPPIFPE != 0) hash ^= GBLGDPPIFPE.GetHashCode();
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
      if (IIAFNKOFHBL != false) {
        output.WriteRawTag(8);
        output.WriteBool(IIAFNKOFHBL);
      }
      if (Step != global::EggLink.DanhengServer.Proto.HeartDialStepType.Missing) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Step);
      }
      if (JPCLFCIBHMJ != false) {
        output.WriteRawTag(88);
        output.WriteBool(JPCLFCIBHMJ);
      }
      if (GKOKNCHLKLH != global::EggLink.DanhengServer.Proto.HeartDialEmotionType.Peace) {
        output.WriteRawTag(104);
        output.WriteEnum((int) GKOKNCHLKLH);
      }
      if (GBLGDPPIFPE != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(GBLGDPPIFPE);
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
      if (IIAFNKOFHBL != false) {
        output.WriteRawTag(8);
        output.WriteBool(IIAFNKOFHBL);
      }
      if (Step != global::EggLink.DanhengServer.Proto.HeartDialStepType.Missing) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Step);
      }
      if (JPCLFCIBHMJ != false) {
        output.WriteRawTag(88);
        output.WriteBool(JPCLFCIBHMJ);
      }
      if (GKOKNCHLKLH != global::EggLink.DanhengServer.Proto.HeartDialEmotionType.Peace) {
        output.WriteRawTag(104);
        output.WriteEnum((int) GKOKNCHLKLH);
      }
      if (GBLGDPPIFPE != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(GBLGDPPIFPE);
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
      if (GKOKNCHLKLH != global::EggLink.DanhengServer.Proto.HeartDialEmotionType.Peace) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) GKOKNCHLKLH);
      }
      if (IIAFNKOFHBL != false) {
        size += 1 + 1;
      }
      if (Step != global::EggLink.DanhengServer.Proto.HeartDialStepType.Missing) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Step);
      }
      if (JPCLFCIBHMJ != false) {
        size += 1 + 1;
      }
      if (GBLGDPPIFPE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GBLGDPPIFPE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(IIPBNJMNFHL other) {
      if (other == null) {
        return;
      }
      if (other.GKOKNCHLKLH != global::EggLink.DanhengServer.Proto.HeartDialEmotionType.Peace) {
        GKOKNCHLKLH = other.GKOKNCHLKLH;
      }
      if (other.IIAFNKOFHBL != false) {
        IIAFNKOFHBL = other.IIAFNKOFHBL;
      }
      if (other.Step != global::EggLink.DanhengServer.Proto.HeartDialStepType.Missing) {
        Step = other.Step;
      }
      if (other.JPCLFCIBHMJ != false) {
        JPCLFCIBHMJ = other.JPCLFCIBHMJ;
      }
      if (other.GBLGDPPIFPE != 0) {
        GBLGDPPIFPE = other.GBLGDPPIFPE;
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
            IIAFNKOFHBL = input.ReadBool();
            break;
          }
          case 48: {
            Step = (global::EggLink.DanhengServer.Proto.HeartDialStepType) input.ReadEnum();
            break;
          }
          case 88: {
            JPCLFCIBHMJ = input.ReadBool();
            break;
          }
          case 104: {
            GKOKNCHLKLH = (global::EggLink.DanhengServer.Proto.HeartDialEmotionType) input.ReadEnum();
            break;
          }
          case 120: {
            GBLGDPPIFPE = input.ReadUInt32();
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
            IIAFNKOFHBL = input.ReadBool();
            break;
          }
          case 48: {
            Step = (global::EggLink.DanhengServer.Proto.HeartDialStepType) input.ReadEnum();
            break;
          }
          case 88: {
            JPCLFCIBHMJ = input.ReadBool();
            break;
          }
          case 104: {
            GKOKNCHLKLH = (global::EggLink.DanhengServer.Proto.HeartDialEmotionType) input.ReadEnum();
            break;
          }
          case 120: {
            GBLGDPPIFPE = input.ReadUInt32();
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
