// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BIJEHOLIHOO.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BIJEHOLIHOO.proto</summary>
  public static partial class BIJEHOLIHOOReflection {

    #region Descriptor
    /// <summary>File descriptor for BIJEHOLIHOO.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BIJEHOLIHOOReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFCSUpFSE9MSUhPTy5wcm90byJICgtCSUpFSE9MSUhPTxITCgtDRElGR0NL",
            "RVBNShgIIAEoDRIPCgdpdGVtX2lkGA4gASgNEhMKC0FITkRDTkdPS0FGGA8g",
            "ASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.BIJEHOLIHOO), global::EggLink.DanhengServer.Proto.BIJEHOLIHOO.Parser, new[]{ "CDIFGCKEPMJ", "ItemId", "AHNDCNGOKAF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BIJEHOLIHOO : pb::IMessage<BIJEHOLIHOO>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BIJEHOLIHOO> _parser = new pb::MessageParser<BIJEHOLIHOO>(() => new BIJEHOLIHOO());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BIJEHOLIHOO> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.BIJEHOLIHOOReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BIJEHOLIHOO() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BIJEHOLIHOO(BIJEHOLIHOO other) : this() {
      cDIFGCKEPMJ_ = other.cDIFGCKEPMJ_;
      itemId_ = other.itemId_;
      aHNDCNGOKAF_ = other.aHNDCNGOKAF_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BIJEHOLIHOO Clone() {
      return new BIJEHOLIHOO(this);
    }

    /// <summary>Field number for the "CDIFGCKEPMJ" field.</summary>
    public const int CDIFGCKEPMJFieldNumber = 8;
    private uint cDIFGCKEPMJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CDIFGCKEPMJ {
      get { return cDIFGCKEPMJ_; }
      set {
        cDIFGCKEPMJ_ = value;
      }
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 14;
    private uint itemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "AHNDCNGOKAF" field.</summary>
    public const int AHNDCNGOKAFFieldNumber = 15;
    private uint aHNDCNGOKAF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AHNDCNGOKAF {
      get { return aHNDCNGOKAF_; }
      set {
        aHNDCNGOKAF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BIJEHOLIHOO);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BIJEHOLIHOO other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CDIFGCKEPMJ != other.CDIFGCKEPMJ) return false;
      if (ItemId != other.ItemId) return false;
      if (AHNDCNGOKAF != other.AHNDCNGOKAF) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CDIFGCKEPMJ != 0) hash ^= CDIFGCKEPMJ.GetHashCode();
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (AHNDCNGOKAF != 0) hash ^= AHNDCNGOKAF.GetHashCode();
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
      if (CDIFGCKEPMJ != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CDIFGCKEPMJ);
      }
      if (ItemId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ItemId);
      }
      if (AHNDCNGOKAF != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(AHNDCNGOKAF);
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
      if (CDIFGCKEPMJ != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CDIFGCKEPMJ);
      }
      if (ItemId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ItemId);
      }
      if (AHNDCNGOKAF != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(AHNDCNGOKAF);
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
      if (CDIFGCKEPMJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CDIFGCKEPMJ);
      }
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemId);
      }
      if (AHNDCNGOKAF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AHNDCNGOKAF);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BIJEHOLIHOO other) {
      if (other == null) {
        return;
      }
      if (other.CDIFGCKEPMJ != 0) {
        CDIFGCKEPMJ = other.CDIFGCKEPMJ;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.AHNDCNGOKAF != 0) {
        AHNDCNGOKAF = other.AHNDCNGOKAF;
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
          case 64: {
            CDIFGCKEPMJ = input.ReadUInt32();
            break;
          }
          case 112: {
            ItemId = input.ReadUInt32();
            break;
          }
          case 120: {
            AHNDCNGOKAF = input.ReadUInt32();
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
          case 64: {
            CDIFGCKEPMJ = input.ReadUInt32();
            break;
          }
          case 112: {
            ItemId = input.ReadUInt32();
            break;
          }
          case 120: {
            AHNDCNGOKAF = input.ReadUInt32();
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
