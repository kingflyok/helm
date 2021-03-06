// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: hapi/release/info.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Hapi.Release {

  /// <summary>Holder for reflection information generated from hapi/release/info.proto</summary>
  public static partial class InfoReflection {

    #region Descriptor
    /// <summary>File descriptor for hapi/release/info.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdoYXBpL3JlbGVhc2UvaW5mby5wcm90bxIMaGFwaS5yZWxlYXNlGh9nb29n",
            "bGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvGhloYXBpL3JlbGVhc2Uvc3Rh",
            "dHVzLnByb3RvItUBCgRJbmZvEiQKBnN0YXR1cxgBIAEoCzIULmhhcGkucmVs",
            "ZWFzZS5TdGF0dXMSMgoOZmlyc3RfZGVwbG95ZWQYAiABKAsyGi5nb29nbGUu",
            "cHJvdG9idWYuVGltZXN0YW1wEjEKDWxhc3RfZGVwbG95ZWQYAyABKAsyGi5n",
            "b29nbGUucHJvdG9idWYuVGltZXN0YW1wEisKB2RlbGV0ZWQYBCABKAsyGi5n",
            "b29nbGUucHJvdG9idWYuVGltZXN0YW1wEhMKC0Rlc2NyaXB0aW9uGAUgASgJ",
            "QglaB3JlbGVhc2ViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Hapi.Release.StatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Hapi.Release.Info), global::Hapi.Release.Info.Parser, new[]{ "Status", "FirstDeployed", "LastDeployed", "Deleted", "Description" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Info describes release information.
  /// </summary>
  public sealed partial class Info : pb::IMessage<Info> {
    private static readonly pb::MessageParser<Info> _parser = new pb::MessageParser<Info>(() => new Info());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Info> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Hapi.Release.InfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Info() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Info(Info other) : this() {
      Status = other.status_ != null ? other.Status.Clone() : null;
      FirstDeployed = other.firstDeployed_ != null ? other.FirstDeployed.Clone() : null;
      LastDeployed = other.lastDeployed_ != null ? other.LastDeployed.Clone() : null;
      Deleted = other.deleted_ != null ? other.Deleted.Clone() : null;
      description_ = other.description_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Info Clone() {
      return new Info(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::Hapi.Release.Status status_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Hapi.Release.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "first_deployed" field.</summary>
    public const int FirstDeployedFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp firstDeployed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp FirstDeployed {
      get { return firstDeployed_; }
      set {
        firstDeployed_ = value;
      }
    }

    /// <summary>Field number for the "last_deployed" field.</summary>
    public const int LastDeployedFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp lastDeployed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp LastDeployed {
      get { return lastDeployed_; }
      set {
        lastDeployed_ = value;
      }
    }

    /// <summary>Field number for the "deleted" field.</summary>
    public const int DeletedFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp deleted_;
    /// <summary>
    /// Deleted tracks when this object was deleted.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Deleted {
      get { return deleted_; }
      set {
        deleted_ = value;
      }
    }

    /// <summary>Field number for the "Description" field.</summary>
    public const int DescriptionFieldNumber = 5;
    private string description_ = "";
    /// <summary>
    /// Description is human-friendly "log entry" about this release.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Info);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Info other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Status, other.Status)) return false;
      if (!object.Equals(FirstDeployed, other.FirstDeployed)) return false;
      if (!object.Equals(LastDeployed, other.LastDeployed)) return false;
      if (!object.Equals(Deleted, other.Deleted)) return false;
      if (Description != other.Description) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (status_ != null) hash ^= Status.GetHashCode();
      if (firstDeployed_ != null) hash ^= FirstDeployed.GetHashCode();
      if (lastDeployed_ != null) hash ^= LastDeployed.GetHashCode();
      if (deleted_ != null) hash ^= Deleted.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (status_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Status);
      }
      if (firstDeployed_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(FirstDeployed);
      }
      if (lastDeployed_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(LastDeployed);
      }
      if (deleted_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Deleted);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Description);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (status_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Status);
      }
      if (firstDeployed_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FirstDeployed);
      }
      if (lastDeployed_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LastDeployed);
      }
      if (deleted_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Deleted);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Info other) {
      if (other == null) {
        return;
      }
      if (other.status_ != null) {
        if (status_ == null) {
          status_ = new global::Hapi.Release.Status();
        }
        Status.MergeFrom(other.Status);
      }
      if (other.firstDeployed_ != null) {
        if (firstDeployed_ == null) {
          firstDeployed_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        FirstDeployed.MergeFrom(other.FirstDeployed);
      }
      if (other.lastDeployed_ != null) {
        if (lastDeployed_ == null) {
          lastDeployed_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        LastDeployed.MergeFrom(other.LastDeployed);
      }
      if (other.deleted_ != null) {
        if (deleted_ == null) {
          deleted_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Deleted.MergeFrom(other.Deleted);
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (status_ == null) {
              status_ = new global::Hapi.Release.Status();
            }
            input.ReadMessage(status_);
            break;
          }
          case 18: {
            if (firstDeployed_ == null) {
              firstDeployed_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(firstDeployed_);
            break;
          }
          case 26: {
            if (lastDeployed_ == null) {
              lastDeployed_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(lastDeployed_);
            break;
          }
          case 34: {
            if (deleted_ == null) {
              deleted_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(deleted_);
            break;
          }
          case 42: {
            Description = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
