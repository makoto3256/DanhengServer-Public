// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DDGABPLFMJP.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DDGABPLFMJP.proto</summary>
  public static partial class DDGABPLFMJPReflection {

    #region Descriptor
    /// <summary>File descriptor for DDGABPLFMJP.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DDGABPLFMJPReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFEREdBQlBMRk1KUC5wcm90byJhCgtEREdBQlBMRk1KUBITCgtOSEdJTkdF",
            "UElNRRgIIAEoDRITCgtQR0ZJTUVCT0dNTxgHIAEoDRITCgtLSE5QRkhIR0hJ",
            "RBgFIAEoDRITCgtGQkFJSk5MRUJFQhgKIAEoDUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DDGABPLFMJP), global::EggLink.DanhengServer.Proto.DDGABPLFMJP.Parser, new[]{ "NHGINGEPIME", "PGFIMEBOGMO", "KHNPFHHGHID", "FBAIJNLEBEB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DDGABPLFMJP : pb::IMessage<DDGABPLFMJP>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DDGABPLFMJP> _parser = new pb::MessageParser<DDGABPLFMJP>(() => new DDGABPLFMJP());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DDGABPLFMJP> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DDGABPLFMJPReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DDGABPLFMJP() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DDGABPLFMJP(DDGABPLFMJP other) : this() {
      nHGINGEPIME_ = other.nHGINGEPIME_;
      pGFIMEBOGMO_ = other.pGFIMEBOGMO_;
      kHNPFHHGHID_ = other.kHNPFHHGHID_;
      fBAIJNLEBEB_ = other.fBAIJNLEBEB_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DDGABPLFMJP Clone() {
      return new DDGABPLFMJP(this);
    }

    /// <summary>Field number for the "NHGINGEPIME" field.</summary>
    public const int NHGINGEPIMEFieldNumber = 8;
    private uint nHGINGEPIME_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NHGINGEPIME {
      get { return nHGINGEPIME_; }
      set {
        nHGINGEPIME_ = value;
      }
    }

    /// <summary>Field number for the "PGFIMEBOGMO" field.</summary>
    public const int PGFIMEBOGMOFieldNumber = 7;
    private uint pGFIMEBOGMO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PGFIMEBOGMO {
      get { return pGFIMEBOGMO_; }
      set {
        pGFIMEBOGMO_ = value;
      }
    }

    /// <summary>Field number for the "KHNPFHHGHID" field.</summary>
    public const int KHNPFHHGHIDFieldNumber = 5;
    private uint kHNPFHHGHID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KHNPFHHGHID {
      get { return kHNPFHHGHID_; }
      set {
        kHNPFHHGHID_ = value;
      }
    }

    /// <summary>Field number for the "FBAIJNLEBEB" field.</summary>
    public const int FBAIJNLEBEBFieldNumber = 10;
    private uint fBAIJNLEBEB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FBAIJNLEBEB {
      get { return fBAIJNLEBEB_; }
      set {
        fBAIJNLEBEB_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DDGABPLFMJP);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DDGABPLFMJP other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NHGINGEPIME != other.NHGINGEPIME) return false;
      if (PGFIMEBOGMO != other.PGFIMEBOGMO) return false;
      if (KHNPFHHGHID != other.KHNPFHHGHID) return false;
      if (FBAIJNLEBEB != other.FBAIJNLEBEB) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NHGINGEPIME != 0) hash ^= NHGINGEPIME.GetHashCode();
      if (PGFIMEBOGMO != 0) hash ^= PGFIMEBOGMO.GetHashCode();
      if (KHNPFHHGHID != 0) hash ^= KHNPFHHGHID.GetHashCode();
      if (FBAIJNLEBEB != 0) hash ^= FBAIJNLEBEB.GetHashCode();
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
      if (KHNPFHHGHID != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(KHNPFHHGHID);
      }
      if (PGFIMEBOGMO != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PGFIMEBOGMO);
      }
      if (NHGINGEPIME != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(NHGINGEPIME);
      }
      if (FBAIJNLEBEB != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(FBAIJNLEBEB);
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
      if (KHNPFHHGHID != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(KHNPFHHGHID);
      }
      if (PGFIMEBOGMO != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PGFIMEBOGMO);
      }
      if (NHGINGEPIME != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(NHGINGEPIME);
      }
      if (FBAIJNLEBEB != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(FBAIJNLEBEB);
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
      if (NHGINGEPIME != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NHGINGEPIME);
      }
      if (PGFIMEBOGMO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PGFIMEBOGMO);
      }
      if (KHNPFHHGHID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KHNPFHHGHID);
      }
      if (FBAIJNLEBEB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FBAIJNLEBEB);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DDGABPLFMJP other) {
      if (other == null) {
        return;
      }
      if (other.NHGINGEPIME != 0) {
        NHGINGEPIME = other.NHGINGEPIME;
      }
      if (other.PGFIMEBOGMO != 0) {
        PGFIMEBOGMO = other.PGFIMEBOGMO;
      }
      if (other.KHNPFHHGHID != 0) {
        KHNPFHHGHID = other.KHNPFHHGHID;
      }
      if (other.FBAIJNLEBEB != 0) {
        FBAIJNLEBEB = other.FBAIJNLEBEB;
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
          case 40: {
            KHNPFHHGHID = input.ReadUInt32();
            break;
          }
          case 56: {
            PGFIMEBOGMO = input.ReadUInt32();
            break;
          }
          case 64: {
            NHGINGEPIME = input.ReadUInt32();
            break;
          }
          case 80: {
            FBAIJNLEBEB = input.ReadUInt32();
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
          case 40: {
            KHNPFHHGHID = input.ReadUInt32();
            break;
          }
          case 56: {
            PGFIMEBOGMO = input.ReadUInt32();
            break;
          }
          case 64: {
            NHGINGEPIME = input.ReadUInt32();
            break;
          }
          case 80: {
            FBAIJNLEBEB = input.ReadUInt32();
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
