// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GGKFCCNODGA.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GGKFCCNODGA.proto</summary>
  public static partial class GGKFCCNODGAReflection {

    #region Descriptor
    /// <summary>File descriptor for GGKFCCNODGA.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GGKFCCNODGAReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFHR0tGQ0NOT0RHQS5wcm90byI3CgtHR0tGQ0NOT0RHQRITCgtJSEdMRERP",
            "TVBQRBgBIAEoDRITCgtDT0lMRUVCUEFFSRgCIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GGKFCCNODGA), global::EggLink.DanhengServer.Proto.GGKFCCNODGA.Parser, new[]{ "IHGLDDOMPPD", "COILEEBPAEI" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GGKFCCNODGA : pb::IMessage<GGKFCCNODGA>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GGKFCCNODGA> _parser = new pb::MessageParser<GGKFCCNODGA>(() => new GGKFCCNODGA());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GGKFCCNODGA> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GGKFCCNODGAReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GGKFCCNODGA() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GGKFCCNODGA(GGKFCCNODGA other) : this() {
      iHGLDDOMPPD_ = other.iHGLDDOMPPD_;
      cOILEEBPAEI_ = other.cOILEEBPAEI_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GGKFCCNODGA Clone() {
      return new GGKFCCNODGA(this);
    }

    /// <summary>Field number for the "IHGLDDOMPPD" field.</summary>
    public const int IHGLDDOMPPDFieldNumber = 1;
    private uint iHGLDDOMPPD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IHGLDDOMPPD {
      get { return iHGLDDOMPPD_; }
      set {
        iHGLDDOMPPD_ = value;
      }
    }

    /// <summary>Field number for the "COILEEBPAEI" field.</summary>
    public const int COILEEBPAEIFieldNumber = 2;
    private uint cOILEEBPAEI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint COILEEBPAEI {
      get { return cOILEEBPAEI_; }
      set {
        cOILEEBPAEI_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GGKFCCNODGA);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GGKFCCNODGA other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IHGLDDOMPPD != other.IHGLDDOMPPD) return false;
      if (COILEEBPAEI != other.COILEEBPAEI) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IHGLDDOMPPD != 0) hash ^= IHGLDDOMPPD.GetHashCode();
      if (COILEEBPAEI != 0) hash ^= COILEEBPAEI.GetHashCode();
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
      if (IHGLDDOMPPD != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(IHGLDDOMPPD);
      }
      if (COILEEBPAEI != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(COILEEBPAEI);
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
      if (IHGLDDOMPPD != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(IHGLDDOMPPD);
      }
      if (COILEEBPAEI != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(COILEEBPAEI);
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
      if (IHGLDDOMPPD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IHGLDDOMPPD);
      }
      if (COILEEBPAEI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(COILEEBPAEI);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GGKFCCNODGA other) {
      if (other == null) {
        return;
      }
      if (other.IHGLDDOMPPD != 0) {
        IHGLDDOMPPD = other.IHGLDDOMPPD;
      }
      if (other.COILEEBPAEI != 0) {
        COILEEBPAEI = other.COILEEBPAEI;
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
            IHGLDDOMPPD = input.ReadUInt32();
            break;
          }
          case 16: {
            COILEEBPAEI = input.ReadUInt32();
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
            IHGLDDOMPPD = input.ReadUInt32();
            break;
          }
          case 16: {
            COILEEBPAEI = input.ReadUInt32();
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
