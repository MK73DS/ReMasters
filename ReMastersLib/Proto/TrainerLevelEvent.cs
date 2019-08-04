// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/TrainerLevelEvent.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/TrainerLevelEvent.proto</summary>
  public static partial class TrainerLevelEventReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/TrainerLevelEvent.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrainerLevelEventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1Qcm90by9UcmFpbmVyTGV2ZWxFdmVudC5wcm90bxIMUmVNYXN0ZXJzTGli",
            "IloKEVRyYWluZXJMZXZlbEV2ZW50Eg0KBWxldmVsGAEgASgNEg0KBXF1ZXN0",
            "GAIgASgEEgsKA2V4cBgDIAEoDRIKCgJ1NBgEIAEoDRIOCgZxdWVzdDIYBSAB",
            "KAQiSgoWVHJhaW5lckxldmVsRXZlbnRUYWJsZRIwCgdlbnRyaWVzGAEgAygL",
            "Mh8uUmVNYXN0ZXJzTGliLlRyYWluZXJMZXZlbEV2ZW50YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.TrainerLevelEvent), global::ReMastersLib.TrainerLevelEvent.Parser, new[]{ "Level", "Quest", "Exp", "U4", "Quest2" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.TrainerLevelEventTable), global::ReMastersLib.TrainerLevelEventTable.Parser, new[]{ "Entries" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TrainerLevelEvent : pb::IMessage<TrainerLevelEvent> {
    private static readonly pb::MessageParser<TrainerLevelEvent> _parser = new pb::MessageParser<TrainerLevelEvent>(() => new TrainerLevelEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TrainerLevelEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.TrainerLevelEventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TrainerLevelEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TrainerLevelEvent(TrainerLevelEvent other) : this() {
      level_ = other.level_;
      quest_ = other.quest_;
      exp_ = other.exp_;
      u4_ = other.u4_;
      quest2_ = other.quest2_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TrainerLevelEvent Clone() {
      return new TrainerLevelEvent(this);
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 1;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "quest" field.</summary>
    public const int QuestFieldNumber = 2;
    private ulong quest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Quest {
      get { return quest_; }
      set {
        quest_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 3;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "u4" field.</summary>
    public const int U4FieldNumber = 4;
    private uint u4_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint U4 {
      get { return u4_; }
      set {
        u4_ = value;
      }
    }

    /// <summary>Field number for the "quest2" field.</summary>
    public const int Quest2FieldNumber = 5;
    private ulong quest2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Quest2 {
      get { return quest2_; }
      set {
        quest2_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TrainerLevelEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TrainerLevelEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Level != other.Level) return false;
      if (Quest != other.Quest) return false;
      if (Exp != other.Exp) return false;
      if (U4 != other.U4) return false;
      if (Quest2 != other.Quest2) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Level != 0) hash ^= Level.GetHashCode();
      if (Quest != 0UL) hash ^= Quest.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (U4 != 0) hash ^= U4.GetHashCode();
      if (Quest2 != 0UL) hash ^= Quest2.GetHashCode();
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
      if (Level != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Level);
      }
      if (Quest != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Quest);
      }
      if (Exp != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Exp);
      }
      if (U4 != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(U4);
      }
      if (Quest2 != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(Quest2);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (Quest != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Quest);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (U4 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(U4);
      }
      if (Quest2 != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Quest2);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TrainerLevelEvent other) {
      if (other == null) {
        return;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.Quest != 0UL) {
        Quest = other.Quest;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.U4 != 0) {
        U4 = other.U4;
      }
      if (other.Quest2 != 0UL) {
        Quest2 = other.Quest2;
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
          case 8: {
            Level = input.ReadUInt32();
            break;
          }
          case 16: {
            Quest = input.ReadUInt64();
            break;
          }
          case 24: {
            Exp = input.ReadUInt32();
            break;
          }
          case 32: {
            U4 = input.ReadUInt32();
            break;
          }
          case 40: {
            Quest2 = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class TrainerLevelEventTable : pb::IMessage<TrainerLevelEventTable> {
    private static readonly pb::MessageParser<TrainerLevelEventTable> _parser = new pb::MessageParser<TrainerLevelEventTable>(() => new TrainerLevelEventTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TrainerLevelEventTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.TrainerLevelEventReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TrainerLevelEventTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TrainerLevelEventTable(TrainerLevelEventTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TrainerLevelEventTable Clone() {
      return new TrainerLevelEventTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.TrainerLevelEvent> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.TrainerLevelEvent.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.TrainerLevelEvent> entries_ = new pbc::RepeatedField<global::ReMastersLib.TrainerLevelEvent>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ReMastersLib.TrainerLevelEvent> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TrainerLevelEventTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TrainerLevelEventTable other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!entries_.Equals(other.entries_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= entries_.GetHashCode();
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
      entries_.WriteTo(output, _repeated_entries_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += entries_.CalculateSize(_repeated_entries_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TrainerLevelEventTable other) {
      if (other == null) {
        return;
      }
      entries_.Add(other.entries_);
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
            entries_.AddEntriesFrom(input, _repeated_entries_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
