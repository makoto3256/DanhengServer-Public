// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CIJNPDEHICK.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from CIJNPDEHICK.proto</summary>
  public static partial class CIJNPDEHICKReflection {

    #region Descriptor
    /// <summary>File descriptor for CIJNPDEHICK.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CIJNPDEHICKReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFDSUpOUERFSElDSy5wcm90byKfAQoLQ0lKTlBERUhJQ0sSMgoLS01MSUNG",
            "TklJRkUYCyADKAsyHS5DSUpOUERFSElDSy5LTUxJQ0ZOSUlGRUVudHJ5EhMK",
            "C0dDTU1HSUlCSkhGGAYgASgNEhMKC0xQSUpDRUJDTVBMGAUgASgNGjIKEEtN",
            "TElDRk5JSUZFRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4",
            "AUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.CIJNPDEHICK), global::EggLink.DanhengServer.Proto.CIJNPDEHICK.Parser, new[]{ "KMLICFNIIFE", "GCMMGIIBJHF", "LPIJCEBCMPL" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CIJNPDEHICK : pb::IMessage<CIJNPDEHICK>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CIJNPDEHICK> _parser = new pb::MessageParser<CIJNPDEHICK>(() => new CIJNPDEHICK());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CIJNPDEHICK> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.CIJNPDEHICKReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CIJNPDEHICK() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CIJNPDEHICK(CIJNPDEHICK other) : this() {
      kMLICFNIIFE_ = other.kMLICFNIIFE_.Clone();
      gCMMGIIBJHF_ = other.gCMMGIIBJHF_;
      lPIJCEBCMPL_ = other.lPIJCEBCMPL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CIJNPDEHICK Clone() {
      return new CIJNPDEHICK(this);
    }

    /// <summary>Field number for the "KMLICFNIIFE" field.</summary>
    public const int KMLICFNIIFEFieldNumber = 11;
    private static readonly pbc::MapField<uint, uint>.Codec _map_kMLICFNIIFE_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 90);
    private readonly pbc::MapField<uint, uint> kMLICFNIIFE_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> KMLICFNIIFE {
      get { return kMLICFNIIFE_; }
    }

    /// <summary>Field number for the "GCMMGIIBJHF" field.</summary>
    public const int GCMMGIIBJHFFieldNumber = 6;
    private uint gCMMGIIBJHF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GCMMGIIBJHF {
      get { return gCMMGIIBJHF_; }
      set {
        gCMMGIIBJHF_ = value;
      }
    }

    /// <summary>Field number for the "LPIJCEBCMPL" field.</summary>
    public const int LPIJCEBCMPLFieldNumber = 5;
    private uint lPIJCEBCMPL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LPIJCEBCMPL {
      get { return lPIJCEBCMPL_; }
      set {
        lPIJCEBCMPL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CIJNPDEHICK);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CIJNPDEHICK other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!KMLICFNIIFE.Equals(other.KMLICFNIIFE)) return false;
      if (GCMMGIIBJHF != other.GCMMGIIBJHF) return false;
      if (LPIJCEBCMPL != other.LPIJCEBCMPL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= KMLICFNIIFE.GetHashCode();
      if (GCMMGIIBJHF != 0) hash ^= GCMMGIIBJHF.GetHashCode();
      if (LPIJCEBCMPL != 0) hash ^= LPIJCEBCMPL.GetHashCode();
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
      if (LPIJCEBCMPL != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LPIJCEBCMPL);
      }
      if (GCMMGIIBJHF != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GCMMGIIBJHF);
      }
      kMLICFNIIFE_.WriteTo(output, _map_kMLICFNIIFE_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (LPIJCEBCMPL != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LPIJCEBCMPL);
      }
      if (GCMMGIIBJHF != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GCMMGIIBJHF);
      }
      kMLICFNIIFE_.WriteTo(ref output, _map_kMLICFNIIFE_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += kMLICFNIIFE_.CalculateSize(_map_kMLICFNIIFE_codec);
      if (GCMMGIIBJHF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GCMMGIIBJHF);
      }
      if (LPIJCEBCMPL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LPIJCEBCMPL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CIJNPDEHICK other) {
      if (other == null) {
        return;
      }
      kMLICFNIIFE_.MergeFrom(other.kMLICFNIIFE_);
      if (other.GCMMGIIBJHF != 0) {
        GCMMGIIBJHF = other.GCMMGIIBJHF;
      }
      if (other.LPIJCEBCMPL != 0) {
        LPIJCEBCMPL = other.LPIJCEBCMPL;
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
            LPIJCEBCMPL = input.ReadUInt32();
            break;
          }
          case 48: {
            GCMMGIIBJHF = input.ReadUInt32();
            break;
          }
          case 90: {
            kMLICFNIIFE_.AddEntriesFrom(input, _map_kMLICFNIIFE_codec);
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
            LPIJCEBCMPL = input.ReadUInt32();
            break;
          }
          case 48: {
            GCMMGIIBJHF = input.ReadUInt32();
            break;
          }
          case 90: {
            kMLICFNIIFE_.AddEntriesFrom(ref input, _map_kMLICFNIIFE_codec);
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
