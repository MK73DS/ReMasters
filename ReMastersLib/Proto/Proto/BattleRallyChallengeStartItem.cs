// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattleRallyChallengeStartItem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from BattleRallyChallengeStartItem.proto</summary>
  public static partial class BattleRallyChallengeStartItemReflection {

    #region Descriptor
    /// <summary>File descriptor for BattleRallyChallengeStartItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattleRallyChallengeStartItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNCYXR0bGVSYWxseUNoYWxsZW5nZVN0YXJ0SXRlbS5wcm90bxIMUmVNYXN0",
            "ZXJzTGliInYKHUJhdHRsZVJhbGx5Q2hhbGxlbmdlU3RhcnRJdGVtEiwKJGJh",
            "dHRsZV9yYWxseV9jaGFsbGVuZ2Vfc3RhcnRfaXRlbV9pZBgBIAEoAxIPCgdp",
            "dGVtX2lkGAIgASgEEgoKAnUxGAMgASgDEgoKAnUyGAQgASgDImIKIkJhdHRs",
            "ZVJhbGx5Q2hhbGxlbmdlU3RhcnRJdGVtVGFibGUSPAoHZW50cmllcxgBIAMo",
            "CzIrLlJlTWFzdGVyc0xpYi5CYXR0bGVSYWxseUNoYWxsZW5nZVN0YXJ0SXRl",
            "bWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.BattleRallyChallengeStartItem), global::ReMastersLib.BattleRallyChallengeStartItem.Parser, new[]{ "BattleRallyChallengeStartItemId", "ItemId", "U1", "U2" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.BattleRallyChallengeStartItemTable), global::ReMastersLib.BattleRallyChallengeStartItemTable.Parser, new[]{ "Entries" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BattleRallyChallengeStartItem : pb::IMessage<BattleRallyChallengeStartItem>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BattleRallyChallengeStartItem> _parser = new pb::MessageParser<BattleRallyChallengeStartItem>(() => new BattleRallyChallengeStartItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BattleRallyChallengeStartItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.BattleRallyChallengeStartItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleRallyChallengeStartItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleRallyChallengeStartItem(BattleRallyChallengeStartItem other) : this() {
      battleRallyChallengeStartItemId_ = other.battleRallyChallengeStartItemId_;
      itemId_ = other.itemId_;
      u1_ = other.u1_;
      u2_ = other.u2_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleRallyChallengeStartItem Clone() {
      return new BattleRallyChallengeStartItem(this);
    }

    /// <summary>Field number for the "battle_rally_challenge_start_item_id" field.</summary>
    public const int BattleRallyChallengeStartItemIdFieldNumber = 1;
    private long battleRallyChallengeStartItemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long BattleRallyChallengeStartItemId {
      get { return battleRallyChallengeStartItemId_; }
      set {
        battleRallyChallengeStartItemId_ = value;
      }
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 2;
    private ulong itemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "u1" field.</summary>
    public const int U1FieldNumber = 3;
    private long u1_;
    /// <summary>
    /// BattleRallyId ?
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long U1 {
      get { return u1_; }
      set {
        u1_ = value;
      }
    }

    /// <summary>Field number for the "u2" field.</summary>
    public const int U2FieldNumber = 4;
    private long u2_;
    /// <summary>
    /// BattleRallyId ?
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long U2 {
      get { return u2_; }
      set {
        u2_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BattleRallyChallengeStartItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BattleRallyChallengeStartItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BattleRallyChallengeStartItemId != other.BattleRallyChallengeStartItemId) return false;
      if (ItemId != other.ItemId) return false;
      if (U1 != other.U1) return false;
      if (U2 != other.U2) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BattleRallyChallengeStartItemId != 0L) hash ^= BattleRallyChallengeStartItemId.GetHashCode();
      if (ItemId != 0UL) hash ^= ItemId.GetHashCode();
      if (U1 != 0L) hash ^= U1.GetHashCode();
      if (U2 != 0L) hash ^= U2.GetHashCode();
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
      if (BattleRallyChallengeStartItemId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(BattleRallyChallengeStartItemId);
      }
      if (ItemId != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(ItemId);
      }
      if (U1 != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(U1);
      }
      if (U2 != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(U2);
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
      if (BattleRallyChallengeStartItemId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(BattleRallyChallengeStartItemId);
      }
      if (ItemId != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(ItemId);
      }
      if (U1 != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(U1);
      }
      if (U2 != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(U2);
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
      if (BattleRallyChallengeStartItemId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BattleRallyChallengeStartItemId);
      }
      if (ItemId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ItemId);
      }
      if (U1 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(U1);
      }
      if (U2 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(U2);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BattleRallyChallengeStartItem other) {
      if (other == null) {
        return;
      }
      if (other.BattleRallyChallengeStartItemId != 0L) {
        BattleRallyChallengeStartItemId = other.BattleRallyChallengeStartItemId;
      }
      if (other.ItemId != 0UL) {
        ItemId = other.ItemId;
      }
      if (other.U1 != 0L) {
        U1 = other.U1;
      }
      if (other.U2 != 0L) {
        U2 = other.U2;
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
            BattleRallyChallengeStartItemId = input.ReadInt64();
            break;
          }
          case 16: {
            ItemId = input.ReadUInt64();
            break;
          }
          case 24: {
            U1 = input.ReadInt64();
            break;
          }
          case 32: {
            U2 = input.ReadInt64();
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
            BattleRallyChallengeStartItemId = input.ReadInt64();
            break;
          }
          case 16: {
            ItemId = input.ReadUInt64();
            break;
          }
          case 24: {
            U1 = input.ReadInt64();
            break;
          }
          case 32: {
            U2 = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BattleRallyChallengeStartItemTable : pb::IMessage<BattleRallyChallengeStartItemTable>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BattleRallyChallengeStartItemTable> _parser = new pb::MessageParser<BattleRallyChallengeStartItemTable>(() => new BattleRallyChallengeStartItemTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BattleRallyChallengeStartItemTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.BattleRallyChallengeStartItemReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleRallyChallengeStartItemTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleRallyChallengeStartItemTable(BattleRallyChallengeStartItemTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleRallyChallengeStartItemTable Clone() {
      return new BattleRallyChallengeStartItemTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.BattleRallyChallengeStartItem> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.BattleRallyChallengeStartItem.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.BattleRallyChallengeStartItem> entries_ = new pbc::RepeatedField<global::ReMastersLib.BattleRallyChallengeStartItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::ReMastersLib.BattleRallyChallengeStartItem> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BattleRallyChallengeStartItemTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BattleRallyChallengeStartItemTable other) {
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
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= entries_.GetHashCode();
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
      entries_.WriteTo(output, _repeated_entries_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      entries_.WriteTo(ref output, _repeated_entries_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += entries_.CalculateSize(_repeated_entries_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BattleRallyChallengeStartItemTable other) {
      if (other == null) {
        return;
      }
      entries_.Add(other.entries_);
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
            entries_.AddEntriesFrom(input, _repeated_entries_codec);
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
            entries_.AddEntriesFrom(ref input, _repeated_entries_codec);
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
