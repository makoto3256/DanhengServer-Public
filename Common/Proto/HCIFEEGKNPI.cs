// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HCIFEEGKNPI.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HCIFEEGKNPI.proto</summary>
  public static partial class HCIFEEGKNPIReflection {

    #region Descriptor
    /// <summary>File descriptor for HCIFEEGKNPI.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HCIFEEGKNPIReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFIQ0lGRUVHS05QSS5wcm90byJyCgtIQ0lGRUVHS05QSRIPCgdidWZmX2lk",
            "GAEgASgNEhMKC0ZDTktBTU9KR0RLGAIgASgNEhMKC0NNS0VERUdGSE9CGAgg",
            "ASgNEhMKC1BMR0tMQklCQ0ZKGAogASgNEhMKC0hDTk9DRkpGRVBIGA0gASgN",
            "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HCIFEEGKNPI), global::EggLink.DanhengServer.Proto.HCIFEEGKNPI.Parser, new[]{ "BuffId", "FCNKAMOJGDK", "CMKEDEGFHOB", "PLGKLBIBCFJ", "HCNOCFJFEPH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HCIFEEGKNPI : pb::IMessage<HCIFEEGKNPI>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HCIFEEGKNPI> _parser = new pb::MessageParser<HCIFEEGKNPI>(() => new HCIFEEGKNPI());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HCIFEEGKNPI> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HCIFEEGKNPIReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HCIFEEGKNPI() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HCIFEEGKNPI(HCIFEEGKNPI other) : this() {
      buffId_ = other.buffId_;
      fCNKAMOJGDK_ = other.fCNKAMOJGDK_;
      cMKEDEGFHOB_ = other.cMKEDEGFHOB_;
      pLGKLBIBCFJ_ = other.pLGKLBIBCFJ_;
      hCNOCFJFEPH_ = other.hCNOCFJFEPH_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HCIFEEGKNPI Clone() {
      return new HCIFEEGKNPI(this);
    }

    /// <summary>Field number for the "buff_id" field.</summary>
    public const int BuffIdFieldNumber = 1;
    private uint buffId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BuffId {
      get { return buffId_; }
      set {
        buffId_ = value;
      }
    }

    /// <summary>Field number for the "FCNKAMOJGDK" field.</summary>
    public const int FCNKAMOJGDKFieldNumber = 2;
    private uint fCNKAMOJGDK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FCNKAMOJGDK {
      get { return fCNKAMOJGDK_; }
      set {
        fCNKAMOJGDK_ = value;
      }
    }

    /// <summary>Field number for the "CMKEDEGFHOB" field.</summary>
    public const int CMKEDEGFHOBFieldNumber = 8;
    private uint cMKEDEGFHOB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CMKEDEGFHOB {
      get { return cMKEDEGFHOB_; }
      set {
        cMKEDEGFHOB_ = value;
      }
    }

    /// <summary>Field number for the "PLGKLBIBCFJ" field.</summary>
    public const int PLGKLBIBCFJFieldNumber = 10;
    private uint pLGKLBIBCFJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PLGKLBIBCFJ {
      get { return pLGKLBIBCFJ_; }
      set {
        pLGKLBIBCFJ_ = value;
      }
    }

    /// <summary>Field number for the "HCNOCFJFEPH" field.</summary>
    public const int HCNOCFJFEPHFieldNumber = 13;
    private uint hCNOCFJFEPH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HCNOCFJFEPH {
      get { return hCNOCFJFEPH_; }
      set {
        hCNOCFJFEPH_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HCIFEEGKNPI);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HCIFEEGKNPI other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BuffId != other.BuffId) return false;
      if (FCNKAMOJGDK != other.FCNKAMOJGDK) return false;
      if (CMKEDEGFHOB != other.CMKEDEGFHOB) return false;
      if (PLGKLBIBCFJ != other.PLGKLBIBCFJ) return false;
      if (HCNOCFJFEPH != other.HCNOCFJFEPH) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BuffId != 0) hash ^= BuffId.GetHashCode();
      if (FCNKAMOJGDK != 0) hash ^= FCNKAMOJGDK.GetHashCode();
      if (CMKEDEGFHOB != 0) hash ^= CMKEDEGFHOB.GetHashCode();
      if (PLGKLBIBCFJ != 0) hash ^= PLGKLBIBCFJ.GetHashCode();
      if (HCNOCFJFEPH != 0) hash ^= HCNOCFJFEPH.GetHashCode();
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
      if (BuffId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(BuffId);
      }
      if (FCNKAMOJGDK != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FCNKAMOJGDK);
      }
      if (CMKEDEGFHOB != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CMKEDEGFHOB);
      }
      if (PLGKLBIBCFJ != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(PLGKLBIBCFJ);
      }
      if (HCNOCFJFEPH != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(HCNOCFJFEPH);
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
      if (BuffId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(BuffId);
      }
      if (FCNKAMOJGDK != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FCNKAMOJGDK);
      }
      if (CMKEDEGFHOB != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CMKEDEGFHOB);
      }
      if (PLGKLBIBCFJ != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(PLGKLBIBCFJ);
      }
      if (HCNOCFJFEPH != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(HCNOCFJFEPH);
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
      if (BuffId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuffId);
      }
      if (FCNKAMOJGDK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FCNKAMOJGDK);
      }
      if (CMKEDEGFHOB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CMKEDEGFHOB);
      }
      if (PLGKLBIBCFJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PLGKLBIBCFJ);
      }
      if (HCNOCFJFEPH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HCNOCFJFEPH);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HCIFEEGKNPI other) {
      if (other == null) {
        return;
      }
      if (other.BuffId != 0) {
        BuffId = other.BuffId;
      }
      if (other.FCNKAMOJGDK != 0) {
        FCNKAMOJGDK = other.FCNKAMOJGDK;
      }
      if (other.CMKEDEGFHOB != 0) {
        CMKEDEGFHOB = other.CMKEDEGFHOB;
      }
      if (other.PLGKLBIBCFJ != 0) {
        PLGKLBIBCFJ = other.PLGKLBIBCFJ;
      }
      if (other.HCNOCFJFEPH != 0) {
        HCNOCFJFEPH = other.HCNOCFJFEPH;
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
            BuffId = input.ReadUInt32();
            break;
          }
          case 16: {
            FCNKAMOJGDK = input.ReadUInt32();
            break;
          }
          case 64: {
            CMKEDEGFHOB = input.ReadUInt32();
            break;
          }
          case 80: {
            PLGKLBIBCFJ = input.ReadUInt32();
            break;
          }
          case 104: {
            HCNOCFJFEPH = input.ReadUInt32();
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
            BuffId = input.ReadUInt32();
            break;
          }
          case 16: {
            FCNKAMOJGDK = input.ReadUInt32();
            break;
          }
          case 64: {
            CMKEDEGFHOB = input.ReadUInt32();
            break;
          }
          case 80: {
            PLGKLBIBCFJ = input.ReadUInt32();
            break;
          }
          case 104: {
            HCNOCFJFEPH = input.ReadUInt32();
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
