// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CNCPILHCHJA.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from CNCPILHCHJA.proto</summary>
  public static partial class CNCPILHCHJAReflection {

    #region Descriptor
    /// <summary>File descriptor for CNCPILHCHJA.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CNCPILHCHJAReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFDTkNQSUxIQ0hKQS5wcm90byJ2CgtDTkNQSUxIQ0hKQRITCgtCREtOTklD",
            "TEFOTRgGIAEoDRITCgtFTURJQ0dERUVFQRgOIAMoDRITCgtNRUdETENPRUFK",
            "QRgNIAEoDRITCgtPREFNS0JMTUlNTxgKIAEoDRITCgtFR0ZEUElOTkZCQhgH",
            "IAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.CNCPILHCHJA), global::EggLink.DanhengServer.Proto.CNCPILHCHJA.Parser, new[]{ "BDKNNICLANM", "EMDICGDEEEA", "MEGDLCOEAJA", "ODAMKBLMIMO", "EGFDPINNFBB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CNCPILHCHJA : pb::IMessage<CNCPILHCHJA>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CNCPILHCHJA> _parser = new pb::MessageParser<CNCPILHCHJA>(() => new CNCPILHCHJA());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CNCPILHCHJA> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.CNCPILHCHJAReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CNCPILHCHJA() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CNCPILHCHJA(CNCPILHCHJA other) : this() {
      bDKNNICLANM_ = other.bDKNNICLANM_;
      eMDICGDEEEA_ = other.eMDICGDEEEA_.Clone();
      mEGDLCOEAJA_ = other.mEGDLCOEAJA_;
      oDAMKBLMIMO_ = other.oDAMKBLMIMO_;
      eGFDPINNFBB_ = other.eGFDPINNFBB_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CNCPILHCHJA Clone() {
      return new CNCPILHCHJA(this);
    }

    /// <summary>Field number for the "BDKNNICLANM" field.</summary>
    public const int BDKNNICLANMFieldNumber = 6;
    private uint bDKNNICLANM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BDKNNICLANM {
      get { return bDKNNICLANM_; }
      set {
        bDKNNICLANM_ = value;
      }
    }

    /// <summary>Field number for the "EMDICGDEEEA" field.</summary>
    public const int EMDICGDEEEAFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_eMDICGDEEEA_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> eMDICGDEEEA_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EMDICGDEEEA {
      get { return eMDICGDEEEA_; }
    }

    /// <summary>Field number for the "MEGDLCOEAJA" field.</summary>
    public const int MEGDLCOEAJAFieldNumber = 13;
    private uint mEGDLCOEAJA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MEGDLCOEAJA {
      get { return mEGDLCOEAJA_; }
      set {
        mEGDLCOEAJA_ = value;
      }
    }

    /// <summary>Field number for the "ODAMKBLMIMO" field.</summary>
    public const int ODAMKBLMIMOFieldNumber = 10;
    private uint oDAMKBLMIMO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ODAMKBLMIMO {
      get { return oDAMKBLMIMO_; }
      set {
        oDAMKBLMIMO_ = value;
      }
    }

    /// <summary>Field number for the "EGFDPINNFBB" field.</summary>
    public const int EGFDPINNFBBFieldNumber = 7;
    private uint eGFDPINNFBB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EGFDPINNFBB {
      get { return eGFDPINNFBB_; }
      set {
        eGFDPINNFBB_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CNCPILHCHJA);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CNCPILHCHJA other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BDKNNICLANM != other.BDKNNICLANM) return false;
      if(!eMDICGDEEEA_.Equals(other.eMDICGDEEEA_)) return false;
      if (MEGDLCOEAJA != other.MEGDLCOEAJA) return false;
      if (ODAMKBLMIMO != other.ODAMKBLMIMO) return false;
      if (EGFDPINNFBB != other.EGFDPINNFBB) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BDKNNICLANM != 0) hash ^= BDKNNICLANM.GetHashCode();
      hash ^= eMDICGDEEEA_.GetHashCode();
      if (MEGDLCOEAJA != 0) hash ^= MEGDLCOEAJA.GetHashCode();
      if (ODAMKBLMIMO != 0) hash ^= ODAMKBLMIMO.GetHashCode();
      if (EGFDPINNFBB != 0) hash ^= EGFDPINNFBB.GetHashCode();
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
      if (BDKNNICLANM != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(BDKNNICLANM);
      }
      if (EGFDPINNFBB != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EGFDPINNFBB);
      }
      if (ODAMKBLMIMO != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ODAMKBLMIMO);
      }
      if (MEGDLCOEAJA != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MEGDLCOEAJA);
      }
      eMDICGDEEEA_.WriteTo(output, _repeated_eMDICGDEEEA_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (BDKNNICLANM != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(BDKNNICLANM);
      }
      if (EGFDPINNFBB != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EGFDPINNFBB);
      }
      if (ODAMKBLMIMO != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ODAMKBLMIMO);
      }
      if (MEGDLCOEAJA != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MEGDLCOEAJA);
      }
      eMDICGDEEEA_.WriteTo(ref output, _repeated_eMDICGDEEEA_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (BDKNNICLANM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BDKNNICLANM);
      }
      size += eMDICGDEEEA_.CalculateSize(_repeated_eMDICGDEEEA_codec);
      if (MEGDLCOEAJA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MEGDLCOEAJA);
      }
      if (ODAMKBLMIMO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ODAMKBLMIMO);
      }
      if (EGFDPINNFBB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EGFDPINNFBB);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CNCPILHCHJA other) {
      if (other == null) {
        return;
      }
      if (other.BDKNNICLANM != 0) {
        BDKNNICLANM = other.BDKNNICLANM;
      }
      eMDICGDEEEA_.Add(other.eMDICGDEEEA_);
      if (other.MEGDLCOEAJA != 0) {
        MEGDLCOEAJA = other.MEGDLCOEAJA;
      }
      if (other.ODAMKBLMIMO != 0) {
        ODAMKBLMIMO = other.ODAMKBLMIMO;
      }
      if (other.EGFDPINNFBB != 0) {
        EGFDPINNFBB = other.EGFDPINNFBB;
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
          case 48: {
            BDKNNICLANM = input.ReadUInt32();
            break;
          }
          case 56: {
            EGFDPINNFBB = input.ReadUInt32();
            break;
          }
          case 80: {
            ODAMKBLMIMO = input.ReadUInt32();
            break;
          }
          case 104: {
            MEGDLCOEAJA = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            eMDICGDEEEA_.AddEntriesFrom(input, _repeated_eMDICGDEEEA_codec);
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
          case 48: {
            BDKNNICLANM = input.ReadUInt32();
            break;
          }
          case 56: {
            EGFDPINNFBB = input.ReadUInt32();
            break;
          }
          case 80: {
            ODAMKBLMIMO = input.ReadUInt32();
            break;
          }
          case 104: {
            MEGDLCOEAJA = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            eMDICGDEEEA_.AddEntriesFrom(ref input, _repeated_eMDICGDEEEA_codec);
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
