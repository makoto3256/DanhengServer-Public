// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GNHMDHCFAFL.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GNHMDHCFAFL.proto</summary>
  public static partial class GNHMDHCFAFLReflection {

    #region Descriptor
    /// <summary>File descriptor for GNHMDHCFAFL.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GNHMDHCFAFLReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFHTkhNREhDRkFGTC5wcm90byI3CgtHTkhNREhDRkFGTBITCgtGRE9ERUhN",
            "TlBKUBgGIAEoDRITCgtKQkhOS0dIRE9FQRgDIAEoCEIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GNHMDHCFAFL), global::EggLink.DanhengServer.Proto.GNHMDHCFAFL.Parser, new[]{ "FDODEHMNPJP", "JBHNKGHDOEA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GNHMDHCFAFL : pb::IMessage<GNHMDHCFAFL>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GNHMDHCFAFL> _parser = new pb::MessageParser<GNHMDHCFAFL>(() => new GNHMDHCFAFL());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GNHMDHCFAFL> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GNHMDHCFAFLReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GNHMDHCFAFL() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GNHMDHCFAFL(GNHMDHCFAFL other) : this() {
      fDODEHMNPJP_ = other.fDODEHMNPJP_;
      jBHNKGHDOEA_ = other.jBHNKGHDOEA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GNHMDHCFAFL Clone() {
      return new GNHMDHCFAFL(this);
    }

    /// <summary>Field number for the "FDODEHMNPJP" field.</summary>
    public const int FDODEHMNPJPFieldNumber = 6;
    private uint fDODEHMNPJP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FDODEHMNPJP {
      get { return fDODEHMNPJP_; }
      set {
        fDODEHMNPJP_ = value;
      }
    }

    /// <summary>Field number for the "JBHNKGHDOEA" field.</summary>
    public const int JBHNKGHDOEAFieldNumber = 3;
    private bool jBHNKGHDOEA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool JBHNKGHDOEA {
      get { return jBHNKGHDOEA_; }
      set {
        jBHNKGHDOEA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GNHMDHCFAFL);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GNHMDHCFAFL other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FDODEHMNPJP != other.FDODEHMNPJP) return false;
      if (JBHNKGHDOEA != other.JBHNKGHDOEA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FDODEHMNPJP != 0) hash ^= FDODEHMNPJP.GetHashCode();
      if (JBHNKGHDOEA != false) hash ^= JBHNKGHDOEA.GetHashCode();
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
      if (JBHNKGHDOEA != false) {
        output.WriteRawTag(24);
        output.WriteBool(JBHNKGHDOEA);
      }
      if (FDODEHMNPJP != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(FDODEHMNPJP);
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
      if (JBHNKGHDOEA != false) {
        output.WriteRawTag(24);
        output.WriteBool(JBHNKGHDOEA);
      }
      if (FDODEHMNPJP != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(FDODEHMNPJP);
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
      if (FDODEHMNPJP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FDODEHMNPJP);
      }
      if (JBHNKGHDOEA != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GNHMDHCFAFL other) {
      if (other == null) {
        return;
      }
      if (other.FDODEHMNPJP != 0) {
        FDODEHMNPJP = other.FDODEHMNPJP;
      }
      if (other.JBHNKGHDOEA != false) {
        JBHNKGHDOEA = other.JBHNKGHDOEA;
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
          case 24: {
            JBHNKGHDOEA = input.ReadBool();
            break;
          }
          case 48: {
            FDODEHMNPJP = input.ReadUInt32();
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
          case 24: {
            JBHNKGHDOEA = input.ReadBool();
            break;
          }
          case 48: {
            FDODEHMNPJP = input.ReadUInt32();
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
