// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FantasticActivityData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FantasticActivityData.proto</summary>
  public static partial class FantasticActivityDataReflection {

    #region Descriptor
    /// <summary>File descriptor for FantasticActivityData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FantasticActivityDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtGYW50YXN0aWNBY3Rpdml0eURhdGEucHJvdG8aEUxHQkZGREFOQUtQLnBy",
            "b3RvIvICChVGYW50YXN0aWNBY3Rpdml0eURhdGESEwoLSktERkRISU9GTkMY",
            "CCADKA0SPAoLSUpFQ0ZOUEJETkoYBSADKAsyJy5GYW50YXN0aWNBY3Rpdml0",
            "eURhdGEuSUpFQ0ZOUEJETkpFbnRyeRITCgtMSUdIQ0dQR0RPShgOIAMoDRI8",
            "CgtHUEFNR0xBRktHShgBIAMoCzInLkZhbnRhc3RpY0FjdGl2aXR5RGF0YS5H",
            "UEFNR0xBRktHSkVudHJ5EhMKC0RMTEJLQlBDT1BNGA0gAygNEhMKC0lQS0tH",
            "TE1NQU5IGAsgASgNEhMKC0hDQkVKSk5OQlBKGAkgAygNGkAKEElKRUNGTlBC",
            "RE5KRW50cnkSCwoDa2V5GAEgASgNEhsKBXZhbHVlGAIgASgLMgwuTEdCRkZE",
            "QU5BS1A6AjgBGjIKEEdQQU1HTEFGS0dKRW50cnkSCwoDa2V5GAEgASgNEg0K",
            "BXZhbHVlGAIgASgNOgI4AUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlBy",
            "b3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.LGBFFDANAKPReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FantasticActivityData), global::EggLink.DanhengServer.Proto.FantasticActivityData.Parser, new[]{ "JKDFDHIOFNC", "IJECFNPBDNJ", "LIGHCGPGDOJ", "GPAMGLAFKGJ", "DLLBKBPCOPM", "IPKKGLMMANH", "HCBEJJNNBPJ" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FantasticActivityData : pb::IMessage<FantasticActivityData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FantasticActivityData> _parser = new pb::MessageParser<FantasticActivityData>(() => new FantasticActivityData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FantasticActivityData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FantasticActivityDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FantasticActivityData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FantasticActivityData(FantasticActivityData other) : this() {
      jKDFDHIOFNC_ = other.jKDFDHIOFNC_.Clone();
      iJECFNPBDNJ_ = other.iJECFNPBDNJ_.Clone();
      lIGHCGPGDOJ_ = other.lIGHCGPGDOJ_.Clone();
      gPAMGLAFKGJ_ = other.gPAMGLAFKGJ_.Clone();
      dLLBKBPCOPM_ = other.dLLBKBPCOPM_.Clone();
      iPKKGLMMANH_ = other.iPKKGLMMANH_;
      hCBEJJNNBPJ_ = other.hCBEJJNNBPJ_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FantasticActivityData Clone() {
      return new FantasticActivityData(this);
    }

    /// <summary>Field number for the "JKDFDHIOFNC" field.</summary>
    public const int JKDFDHIOFNCFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_jKDFDHIOFNC_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> jKDFDHIOFNC_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> JKDFDHIOFNC {
      get { return jKDFDHIOFNC_; }
    }

    /// <summary>Field number for the "IJECFNPBDNJ" field.</summary>
    public const int IJECFNPBDNJFieldNumber = 5;
    private static readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.LGBFFDANAKP>.Codec _map_iJECFNPBDNJ_codec
        = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.LGBFFDANAKP>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.LGBFFDANAKP.Parser), 42);
    private readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.LGBFFDANAKP> iJECFNPBDNJ_ = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.LGBFFDANAKP>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::EggLink.DanhengServer.Proto.LGBFFDANAKP> IJECFNPBDNJ {
      get { return iJECFNPBDNJ_; }
    }

    /// <summary>Field number for the "LIGHCGPGDOJ" field.</summary>
    public const int LIGHCGPGDOJFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_lIGHCGPGDOJ_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> lIGHCGPGDOJ_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LIGHCGPGDOJ {
      get { return lIGHCGPGDOJ_; }
    }

    /// <summary>Field number for the "GPAMGLAFKGJ" field.</summary>
    public const int GPAMGLAFKGJFieldNumber = 1;
    private static readonly pbc::MapField<uint, uint>.Codec _map_gPAMGLAFKGJ_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 10);
    private readonly pbc::MapField<uint, uint> gPAMGLAFKGJ_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> GPAMGLAFKGJ {
      get { return gPAMGLAFKGJ_; }
    }

    /// <summary>Field number for the "DLLBKBPCOPM" field.</summary>
    public const int DLLBKBPCOPMFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_dLLBKBPCOPM_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> dLLBKBPCOPM_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> DLLBKBPCOPM {
      get { return dLLBKBPCOPM_; }
    }

    /// <summary>Field number for the "IPKKGLMMANH" field.</summary>
    public const int IPKKGLMMANHFieldNumber = 11;
    private uint iPKKGLMMANH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IPKKGLMMANH {
      get { return iPKKGLMMANH_; }
      set {
        iPKKGLMMANH_ = value;
      }
    }

    /// <summary>Field number for the "HCBEJJNNBPJ" field.</summary>
    public const int HCBEJJNNBPJFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_hCBEJJNNBPJ_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> hCBEJJNNBPJ_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HCBEJJNNBPJ {
      get { return hCBEJJNNBPJ_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FantasticActivityData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FantasticActivityData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!jKDFDHIOFNC_.Equals(other.jKDFDHIOFNC_)) return false;
      if (!IJECFNPBDNJ.Equals(other.IJECFNPBDNJ)) return false;
      if(!lIGHCGPGDOJ_.Equals(other.lIGHCGPGDOJ_)) return false;
      if (!GPAMGLAFKGJ.Equals(other.GPAMGLAFKGJ)) return false;
      if(!dLLBKBPCOPM_.Equals(other.dLLBKBPCOPM_)) return false;
      if (IPKKGLMMANH != other.IPKKGLMMANH) return false;
      if(!hCBEJJNNBPJ_.Equals(other.hCBEJJNNBPJ_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= jKDFDHIOFNC_.GetHashCode();
      hash ^= IJECFNPBDNJ.GetHashCode();
      hash ^= lIGHCGPGDOJ_.GetHashCode();
      hash ^= GPAMGLAFKGJ.GetHashCode();
      hash ^= dLLBKBPCOPM_.GetHashCode();
      if (IPKKGLMMANH != 0) hash ^= IPKKGLMMANH.GetHashCode();
      hash ^= hCBEJJNNBPJ_.GetHashCode();
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
      gPAMGLAFKGJ_.WriteTo(output, _map_gPAMGLAFKGJ_codec);
      iJECFNPBDNJ_.WriteTo(output, _map_iJECFNPBDNJ_codec);
      jKDFDHIOFNC_.WriteTo(output, _repeated_jKDFDHIOFNC_codec);
      hCBEJJNNBPJ_.WriteTo(output, _repeated_hCBEJJNNBPJ_codec);
      if (IPKKGLMMANH != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(IPKKGLMMANH);
      }
      dLLBKBPCOPM_.WriteTo(output, _repeated_dLLBKBPCOPM_codec);
      lIGHCGPGDOJ_.WriteTo(output, _repeated_lIGHCGPGDOJ_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      gPAMGLAFKGJ_.WriteTo(ref output, _map_gPAMGLAFKGJ_codec);
      iJECFNPBDNJ_.WriteTo(ref output, _map_iJECFNPBDNJ_codec);
      jKDFDHIOFNC_.WriteTo(ref output, _repeated_jKDFDHIOFNC_codec);
      hCBEJJNNBPJ_.WriteTo(ref output, _repeated_hCBEJJNNBPJ_codec);
      if (IPKKGLMMANH != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(IPKKGLMMANH);
      }
      dLLBKBPCOPM_.WriteTo(ref output, _repeated_dLLBKBPCOPM_codec);
      lIGHCGPGDOJ_.WriteTo(ref output, _repeated_lIGHCGPGDOJ_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += jKDFDHIOFNC_.CalculateSize(_repeated_jKDFDHIOFNC_codec);
      size += iJECFNPBDNJ_.CalculateSize(_map_iJECFNPBDNJ_codec);
      size += lIGHCGPGDOJ_.CalculateSize(_repeated_lIGHCGPGDOJ_codec);
      size += gPAMGLAFKGJ_.CalculateSize(_map_gPAMGLAFKGJ_codec);
      size += dLLBKBPCOPM_.CalculateSize(_repeated_dLLBKBPCOPM_codec);
      if (IPKKGLMMANH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IPKKGLMMANH);
      }
      size += hCBEJJNNBPJ_.CalculateSize(_repeated_hCBEJJNNBPJ_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FantasticActivityData other) {
      if (other == null) {
        return;
      }
      jKDFDHIOFNC_.Add(other.jKDFDHIOFNC_);
      iJECFNPBDNJ_.MergeFrom(other.iJECFNPBDNJ_);
      lIGHCGPGDOJ_.Add(other.lIGHCGPGDOJ_);
      gPAMGLAFKGJ_.MergeFrom(other.gPAMGLAFKGJ_);
      dLLBKBPCOPM_.Add(other.dLLBKBPCOPM_);
      if (other.IPKKGLMMANH != 0) {
        IPKKGLMMANH = other.IPKKGLMMANH;
      }
      hCBEJJNNBPJ_.Add(other.hCBEJJNNBPJ_);
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
          case 10: {
            gPAMGLAFKGJ_.AddEntriesFrom(input, _map_gPAMGLAFKGJ_codec);
            break;
          }
          case 42: {
            iJECFNPBDNJ_.AddEntriesFrom(input, _map_iJECFNPBDNJ_codec);
            break;
          }
          case 66:
          case 64: {
            jKDFDHIOFNC_.AddEntriesFrom(input, _repeated_jKDFDHIOFNC_codec);
            break;
          }
          case 74:
          case 72: {
            hCBEJJNNBPJ_.AddEntriesFrom(input, _repeated_hCBEJJNNBPJ_codec);
            break;
          }
          case 88: {
            IPKKGLMMANH = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            dLLBKBPCOPM_.AddEntriesFrom(input, _repeated_dLLBKBPCOPM_codec);
            break;
          }
          case 114:
          case 112: {
            lIGHCGPGDOJ_.AddEntriesFrom(input, _repeated_lIGHCGPGDOJ_codec);
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
          case 10: {
            gPAMGLAFKGJ_.AddEntriesFrom(ref input, _map_gPAMGLAFKGJ_codec);
            break;
          }
          case 42: {
            iJECFNPBDNJ_.AddEntriesFrom(ref input, _map_iJECFNPBDNJ_codec);
            break;
          }
          case 66:
          case 64: {
            jKDFDHIOFNC_.AddEntriesFrom(ref input, _repeated_jKDFDHIOFNC_codec);
            break;
          }
          case 74:
          case 72: {
            hCBEJJNNBPJ_.AddEntriesFrom(ref input, _repeated_hCBEJJNNBPJ_codec);
            break;
          }
          case 88: {
            IPKKGLMMANH = input.ReadUInt32();
            break;
          }
          case 106:
          case 104: {
            dLLBKBPCOPM_.AddEntriesFrom(ref input, _repeated_dLLBKBPCOPM_codec);
            break;
          }
          case 114:
          case 112: {
            lIGHCGPGDOJ_.AddEntriesFrom(ref input, _repeated_lIGHCGPGDOJ_codec);
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
