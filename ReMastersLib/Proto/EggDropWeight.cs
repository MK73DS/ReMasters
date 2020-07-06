// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/EggDropWeight.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/EggDropWeight.proto</summary>
  public static partial class EggDropWeightReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/EggDropWeight.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EggDropWeightReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlQcm90by9FZ2dEcm9wV2VpZ2h0LnByb3RvEgxSZU1hc3RlcnNMaWIiQwoN",
            "RWdnRHJvcFdlaWdodBITCgtlZ2dfZHJvcF9pZBgBIAEoBRIPCgdpdGVtX2lk",
            "GAIgASgDEgwKBHJhdGUYAyABKAUiQgoSRWdnRHJvcFdlaWdodFRhYmxlEiwK",
            "B2VudHJpZXMYASADKAsyGy5SZU1hc3RlcnNMaWIuRWdnRHJvcFdlaWdodGIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.EggDropWeight), global::ReMastersLib.EggDropWeight.Parser, new[]{ "EggDropId", "ItemId", "Rate" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.EggDropWeightTable), global::ReMastersLib.EggDropWeightTable.Parser, new[]{ "Entries" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EggDropWeight : pb::IMessage<EggDropWeight> {
    private static readonly pb::MessageParser<EggDropWeight> _parser = new pb::MessageParser<EggDropWeight>(() => new EggDropWeight());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EggDropWeight> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.EggDropWeightReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EggDropWeight() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EggDropWeight(EggDropWeight other) : this() {
      eggDropId_ = other.eggDropId_;
      itemId_ = other.itemId_;
      rate_ = other.rate_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EggDropWeight Clone() {
      return new EggDropWeight(this);
    }

    /// <summary>Field number for the "egg_drop_id" field.</summary>
    public const int EggDropIdFieldNumber = 1;
    private int eggDropId_;
    /// <summary>
    /// EggDrop.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int EggDropId {
      get { return eggDropId_; }
      set {
        eggDropId_ = value;
      }
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 2;
    private long itemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "rate" field.</summary>
    public const int RateFieldNumber = 3;
    private int rate_;
    /// <summary>
    /// in %
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Rate {
      get { return rate_; }
      set {
        rate_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EggDropWeight);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EggDropWeight other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EggDropId != other.EggDropId) return false;
      if (ItemId != other.ItemId) return false;
      if (Rate != other.Rate) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EggDropId != 0) hash ^= EggDropId.GetHashCode();
      if (ItemId != 0L) hash ^= ItemId.GetHashCode();
      if (Rate != 0) hash ^= Rate.GetHashCode();
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
      if (EggDropId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(EggDropId);
      }
      if (ItemId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(ItemId);
      }
      if (Rate != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Rate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EggDropId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EggDropId);
      }
      if (ItemId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ItemId);
      }
      if (Rate != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Rate);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EggDropWeight other) {
      if (other == null) {
        return;
      }
      if (other.EggDropId != 0) {
        EggDropId = other.EggDropId;
      }
      if (other.ItemId != 0L) {
        ItemId = other.ItemId;
      }
      if (other.Rate != 0) {
        Rate = other.Rate;
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
            EggDropId = input.ReadInt32();
            break;
          }
          case 16: {
            ItemId = input.ReadInt64();
            break;
          }
          case 24: {
            Rate = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class EggDropWeightTable : pb::IMessage<EggDropWeightTable> {
    private static readonly pb::MessageParser<EggDropWeightTable> _parser = new pb::MessageParser<EggDropWeightTable>(() => new EggDropWeightTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EggDropWeightTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.EggDropWeightReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EggDropWeightTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EggDropWeightTable(EggDropWeightTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EggDropWeightTable Clone() {
      return new EggDropWeightTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.EggDropWeight> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.EggDropWeight.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.EggDropWeight> entries_ = new pbc::RepeatedField<global::ReMastersLib.EggDropWeight>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ReMastersLib.EggDropWeight> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EggDropWeightTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EggDropWeightTable other) {
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
    public void MergeFrom(EggDropWeightTable other) {
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