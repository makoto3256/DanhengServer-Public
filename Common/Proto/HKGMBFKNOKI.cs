// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HKGMBFKNOKI.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HKGMBFKNOKI.proto</summary>
  public static partial class HKGMBFKNOKIReflection {

    #region Descriptor
    /// <summary>File descriptor for HKGMBFKNOKI.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HKGMBFKNOKIReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFIS0dNQkZLTk9LSS5wcm90byI3CgtIS0dNQkZLTk9LSRITCgtDTkdCRkhB",
            "RkhFTBgBIAEoDRITCgtBSkhGSUxGTkdMSxgCIAEoBUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HKGMBFKNOKI), global::EggLink.DanhengServer.Proto.HKGMBFKNOKI.Parser, new[]{ "CNGBFHAFHEL", "AJHFILFNGLK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HKGMBFKNOKI : pb::IMessage<HKGMBFKNOKI>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HKGMBFKNOKI> _parser = new pb::MessageParser<HKGMBFKNOKI>(() => new HKGMBFKNOKI());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HKGMBFKNOKI> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HKGMBFKNOKIReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HKGMBFKNOKI() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HKGMBFKNOKI(HKGMBFKNOKI other) : this() {
      cNGBFHAFHEL_ = other.cNGBFHAFHEL_;
      aJHFILFNGLK_ = other.aJHFILFNGLK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HKGMBFKNOKI Clone() {
      return new HKGMBFKNOKI(this);
    }

    /// <summary>Field number for the "CNGBFHAFHEL" field.</summary>
    public const int CNGBFHAFHELFieldNumber = 1;
    private uint cNGBFHAFHEL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CNGBFHAFHEL {
      get { return cNGBFHAFHEL_; }
      set {
        cNGBFHAFHEL_ = value;
      }
    }

    /// <summary>Field number for the "AJHFILFNGLK" field.</summary>
    public const int AJHFILFNGLKFieldNumber = 2;
    private int aJHFILFNGLK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int AJHFILFNGLK {
      get { return aJHFILFNGLK_; }
      set {
        aJHFILFNGLK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HKGMBFKNOKI);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HKGMBFKNOKI other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CNGBFHAFHEL != other.CNGBFHAFHEL) return false;
      if (AJHFILFNGLK != other.AJHFILFNGLK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CNGBFHAFHEL != 0) hash ^= CNGBFHAFHEL.GetHashCode();
      if (AJHFILFNGLK != 0) hash ^= AJHFILFNGLK.GetHashCode();
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
      if (CNGBFHAFHEL != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CNGBFHAFHEL);
      }
      if (AJHFILFNGLK != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(AJHFILFNGLK);
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
      if (CNGBFHAFHEL != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CNGBFHAFHEL);
      }
      if (AJHFILFNGLK != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(AJHFILFNGLK);
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
      if (CNGBFHAFHEL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CNGBFHAFHEL);
      }
      if (AJHFILFNGLK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AJHFILFNGLK);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HKGMBFKNOKI other) {
      if (other == null) {
        return;
      }
      if (other.CNGBFHAFHEL != 0) {
        CNGBFHAFHEL = other.CNGBFHAFHEL;
      }
      if (other.AJHFILFNGLK != 0) {
        AJHFILFNGLK = other.AJHFILFNGLK;
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
            CNGBFHAFHEL = input.ReadUInt32();
            break;
          }
          case 16: {
            AJHFILFNGLK = input.ReadInt32();
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
            CNGBFHAFHEL = input.ReadUInt32();
            break;
          }
          case 16: {
            AJHFILFNGLK = input.ReadInt32();
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
