// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerGetTokenCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PlayerGetTokenCsReq.proto</summary>
  public static partial class PlayerGetTokenCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerGetTokenCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerGetTokenCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlQbGF5ZXJHZXRUb2tlbkNzUmVxLnByb3RvIqwBChNQbGF5ZXJHZXRUb2tl",
            "bkNzUmVxEhMKC05ETUJMTE1GTkhLGAQgASgNEhMKC2FjY291bnRfdWlkGAYg",
            "ASgJEg0KBXRva2VuGAkgASgJEhMKC0lBQklMUEFJT0JOGAggASgJEhAKCHBs",
            "YXRmb3JtGA8gASgNEgsKA3VpZBgOIAEoDRITCgtQTExJSVBKSUZPRxgBIAEo",
            "DRITCgtMQU5FS0FBQ1BMSBgKIAEoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
            "dmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PlayerGetTokenCsReq), global::EggLink.DanhengServer.Proto.PlayerGetTokenCsReq.Parser, new[]{ "NDMBLLMFNHK", "AccountUid", "Token", "IABILPAIOBN", "Platform", "Uid", "PLLIIPJIFOG", "LANEKAACPLH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PlayerGetTokenCsReq : pb::IMessage<PlayerGetTokenCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerGetTokenCsReq> _parser = new pb::MessageParser<PlayerGetTokenCsReq>(() => new PlayerGetTokenCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerGetTokenCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PlayerGetTokenCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerGetTokenCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerGetTokenCsReq(PlayerGetTokenCsReq other) : this() {
      nDMBLLMFNHK_ = other.nDMBLLMFNHK_;
      accountUid_ = other.accountUid_;
      token_ = other.token_;
      iABILPAIOBN_ = other.iABILPAIOBN_;
      platform_ = other.platform_;
      uid_ = other.uid_;
      pLLIIPJIFOG_ = other.pLLIIPJIFOG_;
      lANEKAACPLH_ = other.lANEKAACPLH_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerGetTokenCsReq Clone() {
      return new PlayerGetTokenCsReq(this);
    }

    /// <summary>Field number for the "NDMBLLMFNHK" field.</summary>
    public const int NDMBLLMFNHKFieldNumber = 4;
    private uint nDMBLLMFNHK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NDMBLLMFNHK {
      get { return nDMBLLMFNHK_; }
      set {
        nDMBLLMFNHK_ = value;
      }
    }

    /// <summary>Field number for the "account_uid" field.</summary>
    public const int AccountUidFieldNumber = 6;
    private string accountUid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AccountUid {
      get { return accountUid_; }
      set {
        accountUid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "token" field.</summary>
    public const int TokenFieldNumber = 9;
    private string token_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Token {
      get { return token_; }
      set {
        token_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "IABILPAIOBN" field.</summary>
    public const int IABILPAIOBNFieldNumber = 8;
    private string iABILPAIOBN_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string IABILPAIOBN {
      get { return iABILPAIOBN_; }
      set {
        iABILPAIOBN_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "platform" field.</summary>
    public const int PlatformFieldNumber = 15;
    private uint platform_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Platform {
      get { return platform_; }
      set {
        platform_ = value;
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 14;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "PLLIIPJIFOG" field.</summary>
    public const int PLLIIPJIFOGFieldNumber = 1;
    private uint pLLIIPJIFOG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PLLIIPJIFOG {
      get { return pLLIIPJIFOG_; }
      set {
        pLLIIPJIFOG_ = value;
      }
    }

    /// <summary>Field number for the "LANEKAACPLH" field.</summary>
    public const int LANEKAACPLHFieldNumber = 10;
    private uint lANEKAACPLH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LANEKAACPLH {
      get { return lANEKAACPLH_; }
      set {
        lANEKAACPLH_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerGetTokenCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerGetTokenCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NDMBLLMFNHK != other.NDMBLLMFNHK) return false;
      if (AccountUid != other.AccountUid) return false;
      if (Token != other.Token) return false;
      if (IABILPAIOBN != other.IABILPAIOBN) return false;
      if (Platform != other.Platform) return false;
      if (Uid != other.Uid) return false;
      if (PLLIIPJIFOG != other.PLLIIPJIFOG) return false;
      if (LANEKAACPLH != other.LANEKAACPLH) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (NDMBLLMFNHK != 0) hash ^= NDMBLLMFNHK.GetHashCode();
      if (AccountUid.Length != 0) hash ^= AccountUid.GetHashCode();
      if (Token.Length != 0) hash ^= Token.GetHashCode();
      if (IABILPAIOBN.Length != 0) hash ^= IABILPAIOBN.GetHashCode();
      if (Platform != 0) hash ^= Platform.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (PLLIIPJIFOG != 0) hash ^= PLLIIPJIFOG.GetHashCode();
      if (LANEKAACPLH != 0) hash ^= LANEKAACPLH.GetHashCode();
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
      if (PLLIIPJIFOG != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PLLIIPJIFOG);
      }
      if (NDMBLLMFNHK != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(NDMBLLMFNHK);
      }
      if (AccountUid.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(AccountUid);
      }
      if (IABILPAIOBN.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(IABILPAIOBN);
      }
      if (Token.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Token);
      }
      if (LANEKAACPLH != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(LANEKAACPLH);
      }
      if (Uid != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Uid);
      }
      if (Platform != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Platform);
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
      if (PLLIIPJIFOG != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PLLIIPJIFOG);
      }
      if (NDMBLLMFNHK != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(NDMBLLMFNHK);
      }
      if (AccountUid.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(AccountUid);
      }
      if (IABILPAIOBN.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(IABILPAIOBN);
      }
      if (Token.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Token);
      }
      if (LANEKAACPLH != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(LANEKAACPLH);
      }
      if (Uid != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Uid);
      }
      if (Platform != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Platform);
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
      if (NDMBLLMFNHK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NDMBLLMFNHK);
      }
      if (AccountUid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AccountUid);
      }
      if (Token.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Token);
      }
      if (IABILPAIOBN.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(IABILPAIOBN);
      }
      if (Platform != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Platform);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (PLLIIPJIFOG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PLLIIPJIFOG);
      }
      if (LANEKAACPLH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LANEKAACPLH);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerGetTokenCsReq other) {
      if (other == null) {
        return;
      }
      if (other.NDMBLLMFNHK != 0) {
        NDMBLLMFNHK = other.NDMBLLMFNHK;
      }
      if (other.AccountUid.Length != 0) {
        AccountUid = other.AccountUid;
      }
      if (other.Token.Length != 0) {
        Token = other.Token;
      }
      if (other.IABILPAIOBN.Length != 0) {
        IABILPAIOBN = other.IABILPAIOBN;
      }
      if (other.Platform != 0) {
        Platform = other.Platform;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.PLLIIPJIFOG != 0) {
        PLLIIPJIFOG = other.PLLIIPJIFOG;
      }
      if (other.LANEKAACPLH != 0) {
        LANEKAACPLH = other.LANEKAACPLH;
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
            PLLIIPJIFOG = input.ReadUInt32();
            break;
          }
          case 32: {
            NDMBLLMFNHK = input.ReadUInt32();
            break;
          }
          case 50: {
            AccountUid = input.ReadString();
            break;
          }
          case 66: {
            IABILPAIOBN = input.ReadString();
            break;
          }
          case 74: {
            Token = input.ReadString();
            break;
          }
          case 80: {
            LANEKAACPLH = input.ReadUInt32();
            break;
          }
          case 112: {
            Uid = input.ReadUInt32();
            break;
          }
          case 120: {
            Platform = input.ReadUInt32();
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
            PLLIIPJIFOG = input.ReadUInt32();
            break;
          }
          case 32: {
            NDMBLLMFNHK = input.ReadUInt32();
            break;
          }
          case 50: {
            AccountUid = input.ReadString();
            break;
          }
          case 66: {
            IABILPAIOBN = input.ReadString();
            break;
          }
          case 74: {
            Token = input.ReadString();
            break;
          }
          case 80: {
            LANEKAACPLH = input.ReadUInt32();
            break;
          }
          case 112: {
            Uid = input.ReadUInt32();
            break;
          }
          case 120: {
            Platform = input.ReadUInt32();
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
