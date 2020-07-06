// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/VillaBonusZone.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/VillaBonusZone.proto</summary>
  public static partial class VillaBonusZoneReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/VillaBonusZone.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VillaBonusZoneReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpQcm90by9WaWxsYUJvbnVzWm9uZS5wcm90bxIMUmVNYXN0ZXJzTGliIqAE",
            "Cg5WaWxsYUJvbnVzWm9uZRIbChN2aWxsYV9ib251c196b25lX2lkGAEgASgF",
            "EhwKFHZpdGFsaXR5X2l0ZW1fc2V0X2lkGAIgASgDEhkKEXZpZ29yX2l0ZW1f",
            "c2V0X2lkGAMgASgDEhsKE2V4dHJhX2l0ZW1fc2V0XzFfaWQYBCABKAMSDQoF",
            "cmF0ZTEYBSABKAUSGwoTZXh0cmFfaXRlbV9zZXRfMl9pZBgGIAEoAxINCgVy",
            "YXRlMhgHIAEoBRIbChNleHRyYV9pdGVtX3NldF8zX2lkGAggASgDEg0KBXJh",
            "dGUzGAkgASgFEhsKE2V4dHJhX2l0ZW1fc2V0XzRfaWQYCiABKAMSDQoFcmF0",
            "ZTQYCyABKAUSGwoTZXh0cmFfaXRlbV9zZXRfNV9pZBgMIAEoAxINCgVyYXRl",
            "NRgNIAEoBRIbChNleHRyYV9pdGVtX3NldF82X2lkGA4gASgDEg0KBXJhdGU2",
            "GA8gASgFEhsKE2V4dHJhX2l0ZW1fc2V0XzdfaWQYECABKAMSDQoFcmF0ZTcY",
            "ESABKAUSGwoTZXh0cmFfaXRlbV9zZXRfOF9pZBgSIAEoAxINCgVyYXRlOBgT",
            "IAEoBRIbChNleHRyYV9pdGVtX3NldF85X2lkGBQgASgDEg0KBXJhdGU5GBUg",
            "ASgFEhwKFGV4dHJhX2l0ZW1fc2V0XzEwX2lkGBYgASgDEg4KBnJhdGUxMBgX",
            "IAEoBSJEChNWaWxsYUJvbnVzWm9uZVRhYmxlEi0KB2VudHJpZXMYASADKAsy",
            "HC5SZU1hc3RlcnNMaWIuVmlsbGFCb251c1pvbmViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.VillaBonusZone), global::ReMastersLib.VillaBonusZone.Parser, new[]{ "VillaBonusZoneId", "VitalityItemSetId", "VigorItemSetId", "ExtraItemSet1Id", "Rate1", "ExtraItemSet2Id", "Rate2", "ExtraItemSet3Id", "Rate3", "ExtraItemSet4Id", "Rate4", "ExtraItemSet5Id", "Rate5", "ExtraItemSet6Id", "Rate6", "ExtraItemSet7Id", "Rate7", "ExtraItemSet8Id", "Rate8", "ExtraItemSet9Id", "Rate9", "ExtraItemSet10Id", "Rate10" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.VillaBonusZoneTable), global::ReMastersLib.VillaBonusZoneTable.Parser, new[]{ "Entries" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VillaBonusZone : pb::IMessage<VillaBonusZone> {
    private static readonly pb::MessageParser<VillaBonusZone> _parser = new pb::MessageParser<VillaBonusZone>(() => new VillaBonusZone());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VillaBonusZone> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.VillaBonusZoneReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VillaBonusZone() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VillaBonusZone(VillaBonusZone other) : this() {
      villaBonusZoneId_ = other.villaBonusZoneId_;
      vitalityItemSetId_ = other.vitalityItemSetId_;
      vigorItemSetId_ = other.vigorItemSetId_;
      extraItemSet1Id_ = other.extraItemSet1Id_;
      rate1_ = other.rate1_;
      extraItemSet2Id_ = other.extraItemSet2Id_;
      rate2_ = other.rate2_;
      extraItemSet3Id_ = other.extraItemSet3Id_;
      rate3_ = other.rate3_;
      extraItemSet4Id_ = other.extraItemSet4Id_;
      rate4_ = other.rate4_;
      extraItemSet5Id_ = other.extraItemSet5Id_;
      rate5_ = other.rate5_;
      extraItemSet6Id_ = other.extraItemSet6Id_;
      rate6_ = other.rate6_;
      extraItemSet7Id_ = other.extraItemSet7Id_;
      rate7_ = other.rate7_;
      extraItemSet8Id_ = other.extraItemSet8Id_;
      rate8_ = other.rate8_;
      extraItemSet9Id_ = other.extraItemSet9Id_;
      rate9_ = other.rate9_;
      extraItemSet10Id_ = other.extraItemSet10Id_;
      rate10_ = other.rate10_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VillaBonusZone Clone() {
      return new VillaBonusZone(this);
    }

    /// <summary>Field number for the "villa_bonus_zone_id" field.</summary>
    public const int VillaBonusZoneIdFieldNumber = 1;
    private int villaBonusZoneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int VillaBonusZoneId {
      get { return villaBonusZoneId_; }
      set {
        villaBonusZoneId_ = value;
      }
    }

    /// <summary>Field number for the "vitality_item_set_id" field.</summary>
    public const int VitalityItemSetIdFieldNumber = 2;
    private long vitalityItemSetId_;
    /// <summary>
    /// ItemSet.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long VitalityItemSetId {
      get { return vitalityItemSetId_; }
      set {
        vitalityItemSetId_ = value;
      }
    }

    /// <summary>Field number for the "vigor_item_set_id" field.</summary>
    public const int VigorItemSetIdFieldNumber = 3;
    private long vigorItemSetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long VigorItemSetId {
      get { return vigorItemSetId_; }
      set {
        vigorItemSetId_ = value;
      }
    }

    /// <summary>Field number for the "extra_item_set_1_id" field.</summary>
    public const int ExtraItemSet1IdFieldNumber = 4;
    private long extraItemSet1Id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ExtraItemSet1Id {
      get { return extraItemSet1Id_; }
      set {
        extraItemSet1Id_ = value;
      }
    }

    /// <summary>Field number for the "rate1" field.</summary>
    public const int Rate1FieldNumber = 5;
    private int rate1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Rate1 {
      get { return rate1_; }
      set {
        rate1_ = value;
      }
    }

    /// <summary>Field number for the "extra_item_set_2_id" field.</summary>
    public const int ExtraItemSet2IdFieldNumber = 6;
    private long extraItemSet2Id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ExtraItemSet2Id {
      get { return extraItemSet2Id_; }
      set {
        extraItemSet2Id_ = value;
      }
    }

    /// <summary>Field number for the "rate2" field.</summary>
    public const int Rate2FieldNumber = 7;
    private int rate2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Rate2 {
      get { return rate2_; }
      set {
        rate2_ = value;
      }
    }

    /// <summary>Field number for the "extra_item_set_3_id" field.</summary>
    public const int ExtraItemSet3IdFieldNumber = 8;
    private long extraItemSet3Id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ExtraItemSet3Id {
      get { return extraItemSet3Id_; }
      set {
        extraItemSet3Id_ = value;
      }
    }

    /// <summary>Field number for the "rate3" field.</summary>
    public const int Rate3FieldNumber = 9;
    private int rate3_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Rate3 {
      get { return rate3_; }
      set {
        rate3_ = value;
      }
    }

    /// <summary>Field number for the "extra_item_set_4_id" field.</summary>
    public const int ExtraItemSet4IdFieldNumber = 10;
    private long extraItemSet4Id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ExtraItemSet4Id {
      get { return extraItemSet4Id_; }
      set {
        extraItemSet4Id_ = value;
      }
    }

    /// <summary>Field number for the "rate4" field.</summary>
    public const int Rate4FieldNumber = 11;
    private int rate4_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Rate4 {
      get { return rate4_; }
      set {
        rate4_ = value;
      }
    }

    /// <summary>Field number for the "extra_item_set_5_id" field.</summary>
    public const int ExtraItemSet5IdFieldNumber = 12;
    private long extraItemSet5Id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ExtraItemSet5Id {
      get { return extraItemSet5Id_; }
      set {
        extraItemSet5Id_ = value;
      }
    }

    /// <summary>Field number for the "rate5" field.</summary>
    public const int Rate5FieldNumber = 13;
    private int rate5_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Rate5 {
      get { return rate5_; }
      set {
        rate5_ = value;
      }
    }

    /// <summary>Field number for the "extra_item_set_6_id" field.</summary>
    public const int ExtraItemSet6IdFieldNumber = 14;
    private long extraItemSet6Id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ExtraItemSet6Id {
      get { return extraItemSet6Id_; }
      set {
        extraItemSet6Id_ = value;
      }
    }

    /// <summary>Field number for the "rate6" field.</summary>
    public const int Rate6FieldNumber = 15;
    private int rate6_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Rate6 {
      get { return rate6_; }
      set {
        rate6_ = value;
      }
    }

    /// <summary>Field number for the "extra_item_set_7_id" field.</summary>
    public const int ExtraItemSet7IdFieldNumber = 16;
    private long extraItemSet7Id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ExtraItemSet7Id {
      get { return extraItemSet7Id_; }
      set {
        extraItemSet7Id_ = value;
      }
    }

    /// <summary>Field number for the "rate7" field.</summary>
    public const int Rate7FieldNumber = 17;
    private int rate7_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Rate7 {
      get { return rate7_; }
      set {
        rate7_ = value;
      }
    }

    /// <summary>Field number for the "extra_item_set_8_id" field.</summary>
    public const int ExtraItemSet8IdFieldNumber = 18;
    private long extraItemSet8Id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ExtraItemSet8Id {
      get { return extraItemSet8Id_; }
      set {
        extraItemSet8Id_ = value;
      }
    }

    /// <summary>Field number for the "rate8" field.</summary>
    public const int Rate8FieldNumber = 19;
    private int rate8_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Rate8 {
      get { return rate8_; }
      set {
        rate8_ = value;
      }
    }

    /// <summary>Field number for the "extra_item_set_9_id" field.</summary>
    public const int ExtraItemSet9IdFieldNumber = 20;
    private long extraItemSet9Id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ExtraItemSet9Id {
      get { return extraItemSet9Id_; }
      set {
        extraItemSet9Id_ = value;
      }
    }

    /// <summary>Field number for the "rate9" field.</summary>
    public const int Rate9FieldNumber = 21;
    private int rate9_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Rate9 {
      get { return rate9_; }
      set {
        rate9_ = value;
      }
    }

    /// <summary>Field number for the "extra_item_set_10_id" field.</summary>
    public const int ExtraItemSet10IdFieldNumber = 22;
    private long extraItemSet10Id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ExtraItemSet10Id {
      get { return extraItemSet10Id_; }
      set {
        extraItemSet10Id_ = value;
      }
    }

    /// <summary>Field number for the "rate10" field.</summary>
    public const int Rate10FieldNumber = 23;
    private int rate10_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Rate10 {
      get { return rate10_; }
      set {
        rate10_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VillaBonusZone);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VillaBonusZone other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (VillaBonusZoneId != other.VillaBonusZoneId) return false;
      if (VitalityItemSetId != other.VitalityItemSetId) return false;
      if (VigorItemSetId != other.VigorItemSetId) return false;
      if (ExtraItemSet1Id != other.ExtraItemSet1Id) return false;
      if (Rate1 != other.Rate1) return false;
      if (ExtraItemSet2Id != other.ExtraItemSet2Id) return false;
      if (Rate2 != other.Rate2) return false;
      if (ExtraItemSet3Id != other.ExtraItemSet3Id) return false;
      if (Rate3 != other.Rate3) return false;
      if (ExtraItemSet4Id != other.ExtraItemSet4Id) return false;
      if (Rate4 != other.Rate4) return false;
      if (ExtraItemSet5Id != other.ExtraItemSet5Id) return false;
      if (Rate5 != other.Rate5) return false;
      if (ExtraItemSet6Id != other.ExtraItemSet6Id) return false;
      if (Rate6 != other.Rate6) return false;
      if (ExtraItemSet7Id != other.ExtraItemSet7Id) return false;
      if (Rate7 != other.Rate7) return false;
      if (ExtraItemSet8Id != other.ExtraItemSet8Id) return false;
      if (Rate8 != other.Rate8) return false;
      if (ExtraItemSet9Id != other.ExtraItemSet9Id) return false;
      if (Rate9 != other.Rate9) return false;
      if (ExtraItemSet10Id != other.ExtraItemSet10Id) return false;
      if (Rate10 != other.Rate10) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (VillaBonusZoneId != 0) hash ^= VillaBonusZoneId.GetHashCode();
      if (VitalityItemSetId != 0L) hash ^= VitalityItemSetId.GetHashCode();
      if (VigorItemSetId != 0L) hash ^= VigorItemSetId.GetHashCode();
      if (ExtraItemSet1Id != 0L) hash ^= ExtraItemSet1Id.GetHashCode();
      if (Rate1 != 0) hash ^= Rate1.GetHashCode();
      if (ExtraItemSet2Id != 0L) hash ^= ExtraItemSet2Id.GetHashCode();
      if (Rate2 != 0) hash ^= Rate2.GetHashCode();
      if (ExtraItemSet3Id != 0L) hash ^= ExtraItemSet3Id.GetHashCode();
      if (Rate3 != 0) hash ^= Rate3.GetHashCode();
      if (ExtraItemSet4Id != 0L) hash ^= ExtraItemSet4Id.GetHashCode();
      if (Rate4 != 0) hash ^= Rate4.GetHashCode();
      if (ExtraItemSet5Id != 0L) hash ^= ExtraItemSet5Id.GetHashCode();
      if (Rate5 != 0) hash ^= Rate5.GetHashCode();
      if (ExtraItemSet6Id != 0L) hash ^= ExtraItemSet6Id.GetHashCode();
      if (Rate6 != 0) hash ^= Rate6.GetHashCode();
      if (ExtraItemSet7Id != 0L) hash ^= ExtraItemSet7Id.GetHashCode();
      if (Rate7 != 0) hash ^= Rate7.GetHashCode();
      if (ExtraItemSet8Id != 0L) hash ^= ExtraItemSet8Id.GetHashCode();
      if (Rate8 != 0) hash ^= Rate8.GetHashCode();
      if (ExtraItemSet9Id != 0L) hash ^= ExtraItemSet9Id.GetHashCode();
      if (Rate9 != 0) hash ^= Rate9.GetHashCode();
      if (ExtraItemSet10Id != 0L) hash ^= ExtraItemSet10Id.GetHashCode();
      if (Rate10 != 0) hash ^= Rate10.GetHashCode();
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
      if (VillaBonusZoneId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(VillaBonusZoneId);
      }
      if (VitalityItemSetId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(VitalityItemSetId);
      }
      if (VigorItemSetId != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(VigorItemSetId);
      }
      if (ExtraItemSet1Id != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(ExtraItemSet1Id);
      }
      if (Rate1 != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Rate1);
      }
      if (ExtraItemSet2Id != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(ExtraItemSet2Id);
      }
      if (Rate2 != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Rate2);
      }
      if (ExtraItemSet3Id != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(ExtraItemSet3Id);
      }
      if (Rate3 != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Rate3);
      }
      if (ExtraItemSet4Id != 0L) {
        output.WriteRawTag(80);
        output.WriteInt64(ExtraItemSet4Id);
      }
      if (Rate4 != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Rate4);
      }
      if (ExtraItemSet5Id != 0L) {
        output.WriteRawTag(96);
        output.WriteInt64(ExtraItemSet5Id);
      }
      if (Rate5 != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(Rate5);
      }
      if (ExtraItemSet6Id != 0L) {
        output.WriteRawTag(112);
        output.WriteInt64(ExtraItemSet6Id);
      }
      if (Rate6 != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(Rate6);
      }
      if (ExtraItemSet7Id != 0L) {
        output.WriteRawTag(128, 1);
        output.WriteInt64(ExtraItemSet7Id);
      }
      if (Rate7 != 0) {
        output.WriteRawTag(136, 1);
        output.WriteInt32(Rate7);
      }
      if (ExtraItemSet8Id != 0L) {
        output.WriteRawTag(144, 1);
        output.WriteInt64(ExtraItemSet8Id);
      }
      if (Rate8 != 0) {
        output.WriteRawTag(152, 1);
        output.WriteInt32(Rate8);
      }
      if (ExtraItemSet9Id != 0L) {
        output.WriteRawTag(160, 1);
        output.WriteInt64(ExtraItemSet9Id);
      }
      if (Rate9 != 0) {
        output.WriteRawTag(168, 1);
        output.WriteInt32(Rate9);
      }
      if (ExtraItemSet10Id != 0L) {
        output.WriteRawTag(176, 1);
        output.WriteInt64(ExtraItemSet10Id);
      }
      if (Rate10 != 0) {
        output.WriteRawTag(184, 1);
        output.WriteInt32(Rate10);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (VillaBonusZoneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(VillaBonusZoneId);
      }
      if (VitalityItemSetId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(VitalityItemSetId);
      }
      if (VigorItemSetId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(VigorItemSetId);
      }
      if (ExtraItemSet1Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExtraItemSet1Id);
      }
      if (Rate1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Rate1);
      }
      if (ExtraItemSet2Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExtraItemSet2Id);
      }
      if (Rate2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Rate2);
      }
      if (ExtraItemSet3Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExtraItemSet3Id);
      }
      if (Rate3 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Rate3);
      }
      if (ExtraItemSet4Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExtraItemSet4Id);
      }
      if (Rate4 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Rate4);
      }
      if (ExtraItemSet5Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExtraItemSet5Id);
      }
      if (Rate5 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Rate5);
      }
      if (ExtraItemSet6Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExtraItemSet6Id);
      }
      if (Rate6 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Rate6);
      }
      if (ExtraItemSet7Id != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(ExtraItemSet7Id);
      }
      if (Rate7 != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Rate7);
      }
      if (ExtraItemSet8Id != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(ExtraItemSet8Id);
      }
      if (Rate8 != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Rate8);
      }
      if (ExtraItemSet9Id != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(ExtraItemSet9Id);
      }
      if (Rate9 != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Rate9);
      }
      if (ExtraItemSet10Id != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(ExtraItemSet10Id);
      }
      if (Rate10 != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Rate10);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VillaBonusZone other) {
      if (other == null) {
        return;
      }
      if (other.VillaBonusZoneId != 0) {
        VillaBonusZoneId = other.VillaBonusZoneId;
      }
      if (other.VitalityItemSetId != 0L) {
        VitalityItemSetId = other.VitalityItemSetId;
      }
      if (other.VigorItemSetId != 0L) {
        VigorItemSetId = other.VigorItemSetId;
      }
      if (other.ExtraItemSet1Id != 0L) {
        ExtraItemSet1Id = other.ExtraItemSet1Id;
      }
      if (other.Rate1 != 0) {
        Rate1 = other.Rate1;
      }
      if (other.ExtraItemSet2Id != 0L) {
        ExtraItemSet2Id = other.ExtraItemSet2Id;
      }
      if (other.Rate2 != 0) {
        Rate2 = other.Rate2;
      }
      if (other.ExtraItemSet3Id != 0L) {
        ExtraItemSet3Id = other.ExtraItemSet3Id;
      }
      if (other.Rate3 != 0) {
        Rate3 = other.Rate3;
      }
      if (other.ExtraItemSet4Id != 0L) {
        ExtraItemSet4Id = other.ExtraItemSet4Id;
      }
      if (other.Rate4 != 0) {
        Rate4 = other.Rate4;
      }
      if (other.ExtraItemSet5Id != 0L) {
        ExtraItemSet5Id = other.ExtraItemSet5Id;
      }
      if (other.Rate5 != 0) {
        Rate5 = other.Rate5;
      }
      if (other.ExtraItemSet6Id != 0L) {
        ExtraItemSet6Id = other.ExtraItemSet6Id;
      }
      if (other.Rate6 != 0) {
        Rate6 = other.Rate6;
      }
      if (other.ExtraItemSet7Id != 0L) {
        ExtraItemSet7Id = other.ExtraItemSet7Id;
      }
      if (other.Rate7 != 0) {
        Rate7 = other.Rate7;
      }
      if (other.ExtraItemSet8Id != 0L) {
        ExtraItemSet8Id = other.ExtraItemSet8Id;
      }
      if (other.Rate8 != 0) {
        Rate8 = other.Rate8;
      }
      if (other.ExtraItemSet9Id != 0L) {
        ExtraItemSet9Id = other.ExtraItemSet9Id;
      }
      if (other.Rate9 != 0) {
        Rate9 = other.Rate9;
      }
      if (other.ExtraItemSet10Id != 0L) {
        ExtraItemSet10Id = other.ExtraItemSet10Id;
      }
      if (other.Rate10 != 0) {
        Rate10 = other.Rate10;
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
            VillaBonusZoneId = input.ReadInt32();
            break;
          }
          case 16: {
            VitalityItemSetId = input.ReadInt64();
            break;
          }
          case 24: {
            VigorItemSetId = input.ReadInt64();
            break;
          }
          case 32: {
            ExtraItemSet1Id = input.ReadInt64();
            break;
          }
          case 40: {
            Rate1 = input.ReadInt32();
            break;
          }
          case 48: {
            ExtraItemSet2Id = input.ReadInt64();
            break;
          }
          case 56: {
            Rate2 = input.ReadInt32();
            break;
          }
          case 64: {
            ExtraItemSet3Id = input.ReadInt64();
            break;
          }
          case 72: {
            Rate3 = input.ReadInt32();
            break;
          }
          case 80: {
            ExtraItemSet4Id = input.ReadInt64();
            break;
          }
          case 88: {
            Rate4 = input.ReadInt32();
            break;
          }
          case 96: {
            ExtraItemSet5Id = input.ReadInt64();
            break;
          }
          case 104: {
            Rate5 = input.ReadInt32();
            break;
          }
          case 112: {
            ExtraItemSet6Id = input.ReadInt64();
            break;
          }
          case 120: {
            Rate6 = input.ReadInt32();
            break;
          }
          case 128: {
            ExtraItemSet7Id = input.ReadInt64();
            break;
          }
          case 136: {
            Rate7 = input.ReadInt32();
            break;
          }
          case 144: {
            ExtraItemSet8Id = input.ReadInt64();
            break;
          }
          case 152: {
            Rate8 = input.ReadInt32();
            break;
          }
          case 160: {
            ExtraItemSet9Id = input.ReadInt64();
            break;
          }
          case 168: {
            Rate9 = input.ReadInt32();
            break;
          }
          case 176: {
            ExtraItemSet10Id = input.ReadInt64();
            break;
          }
          case 184: {
            Rate10 = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class VillaBonusZoneTable : pb::IMessage<VillaBonusZoneTable> {
    private static readonly pb::MessageParser<VillaBonusZoneTable> _parser = new pb::MessageParser<VillaBonusZoneTable>(() => new VillaBonusZoneTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VillaBonusZoneTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.VillaBonusZoneReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VillaBonusZoneTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VillaBonusZoneTable(VillaBonusZoneTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VillaBonusZoneTable Clone() {
      return new VillaBonusZoneTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.VillaBonusZone> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.VillaBonusZone.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.VillaBonusZone> entries_ = new pbc::RepeatedField<global::ReMastersLib.VillaBonusZone>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ReMastersLib.VillaBonusZone> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VillaBonusZoneTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VillaBonusZoneTable other) {
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
    public void MergeFrom(VillaBonusZoneTable other) {
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