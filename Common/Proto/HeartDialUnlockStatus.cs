// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HeartDialUnlockStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HeartDialUnlockStatus.proto</summary>
  public static partial class HeartDialUnlockStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for HeartDialUnlockStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HeartDialUnlockStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtIZWFydERpYWxVbmxvY2tTdGF0dXMucHJvdG8qjwEKFUhlYXJ0RGlhbFVu",
            "bG9ja1N0YXR1cxIhCh1IRUFSVF9ESUFMX1VOTE9DS19TVEFUVVNfTE9DSxAA",
            "EioKJkhFQVJUX0RJQUxfVU5MT0NLX1NUQVRVU19VTkxPQ0tfU0lOR0xFEAES",
            "JwojSEVBUlRfRElBTF9VTkxPQ0tfU1RBVFVTX1VOTE9DS19BTEwQAkIeqgIb",
            "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.HeartDialUnlockStatus), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum HeartDialUnlockStatus {
    [pbr::OriginalName("HEART_DIAL_UNLOCK_STATUS_LOCK")] Lock = 0,
    [pbr::OriginalName("HEART_DIAL_UNLOCK_STATUS_UNLOCK_SINGLE")] UnlockSingle = 1,
    [pbr::OriginalName("HEART_DIAL_UNLOCK_STATUS_UNLOCK_ALL")] UnlockAll = 2,
  }

  #endregion

}

#endregion Designer generated code