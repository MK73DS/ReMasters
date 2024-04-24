// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattleRallyItemEffect.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from BattleRallyItemEffect.proto</summary>
  public static partial class BattleRallyItemEffectReflection {

    #region Descriptor
    /// <summary>File descriptor for BattleRallyItemEffect.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattleRallyItemEffectReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtCYXR0bGVSYWxseUl0ZW1FZmZlY3QucHJvdG8SDFJlTWFzdGVyc0xpYiKC",
            "AQoVQmF0dGxlUmFsbHlJdGVtRWZmZWN0EiMKG2JhdHRsZV9yYWxseV9pdGVt",
            "X2VmZmVjdF9pZBgBIAEoBBIVCg1pc190ZWFtX3NraWxsGAIgASgIEhUKDXRl",
            "YW1fc2tpbGxfaWQYAyABKAQSCgoCdTEYBCABKAUSCgoCdTIYBSABKAUiUgoa",
            "QmF0dGxlUmFsbHlJdGVtRWZmZWN0VGFibGUSNAoHZW50cmllcxgBIAMoCzIj",
            "LlJlTWFzdGVyc0xpYi5CYXR0bGVSYWxseUl0ZW1FZmZlY3RiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.BattleRallyItemEffect), global::ReMastersLib.BattleRallyItemEffect.Parser, new[]{ "BattleRallyItemEffectId", "IsTeamSkill", "TeamSkillId", "U1", "U2" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.BattleRallyItemEffectTable), global::ReMastersLib.BattleRallyItemEffectTable.Parser, new[]{ "Entries" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BattleRallyItemEffect : pb::IMessage<BattleRallyItemEffect>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BattleRallyItemEffect> _parser = new pb::MessageParser<BattleRallyItemEffect>(() => new BattleRallyItemEffect());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BattleRallyItemEffect> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.BattleRallyItemEffectReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleRallyItemEffect() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleRallyItemEffect(BattleRallyItemEffect other) : this() {
      battleRallyItemEffectId_ = other.battleRallyItemEffectId_;
      isTeamSkill_ = other.isTeamSkill_;
      teamSkillId_ = other.teamSkillId_;
      u1_ = other.u1_;
      u2_ = other.u2_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleRallyItemEffect Clone() {
      return new BattleRallyItemEffect(this);
    }

    /// <summary>Field number for the "battle_rally_item_effect_id" field.</summary>
    public const int BattleRallyItemEffectIdFieldNumber = 1;
    private ulong battleRallyItemEffectId_;
    /// <summary>
    /// Item.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong BattleRallyItemEffectId {
      get { return battleRallyItemEffectId_; }
      set {
        battleRallyItemEffectId_ = value;
      }
    }

    /// <summary>Field number for the "is_team_skill" field.</summary>
    public const int IsTeamSkillFieldNumber = 2;
    private bool isTeamSkill_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsTeamSkill {
      get { return isTeamSkill_; }
      set {
        isTeamSkill_ = value;
      }
    }

    /// <summary>Field number for the "team_skill_id" field.</summary>
    public const int TeamSkillIdFieldNumber = 3;
    private ulong teamSkillId_;
    /// <summary>
    /// TeamSkill.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TeamSkillId {
      get { return teamSkillId_; }
      set {
        teamSkillId_ = value;
      }
    }

    /// <summary>Field number for the "u1" field.</summary>
    public const int U1FieldNumber = 4;
    private int u1_;
    /// <summary>
    /// 0 = ??, 1 = multipleParameterBoost, 2 = ??
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int U1 {
      get { return u1_; }
      set {
        u1_ = value;
      }
    }

    /// <summary>Field number for the "u2" field.</summary>
    public const int U2FieldNumber = 5;
    private int u2_;
    /// <summary>
    /// Value
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int U2 {
      get { return u2_; }
      set {
        u2_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BattleRallyItemEffect);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BattleRallyItemEffect other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BattleRallyItemEffectId != other.BattleRallyItemEffectId) return false;
      if (IsTeamSkill != other.IsTeamSkill) return false;
      if (TeamSkillId != other.TeamSkillId) return false;
      if (U1 != other.U1) return false;
      if (U2 != other.U2) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BattleRallyItemEffectId != 0UL) hash ^= BattleRallyItemEffectId.GetHashCode();
      if (IsTeamSkill != false) hash ^= IsTeamSkill.GetHashCode();
      if (TeamSkillId != 0UL) hash ^= TeamSkillId.GetHashCode();
      if (U1 != 0) hash ^= U1.GetHashCode();
      if (U2 != 0) hash ^= U2.GetHashCode();
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
      if (BattleRallyItemEffectId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(BattleRallyItemEffectId);
      }
      if (IsTeamSkill != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsTeamSkill);
      }
      if (TeamSkillId != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(TeamSkillId);
      }
      if (U1 != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(U1);
      }
      if (U2 != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(U2);
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
      if (BattleRallyItemEffectId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(BattleRallyItemEffectId);
      }
      if (IsTeamSkill != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsTeamSkill);
      }
      if (TeamSkillId != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(TeamSkillId);
      }
      if (U1 != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(U1);
      }
      if (U2 != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(U2);
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
      if (BattleRallyItemEffectId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(BattleRallyItemEffectId);
      }
      if (IsTeamSkill != false) {
        size += 1 + 1;
      }
      if (TeamSkillId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TeamSkillId);
      }
      if (U1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U1);
      }
      if (U2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U2);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BattleRallyItemEffect other) {
      if (other == null) {
        return;
      }
      if (other.BattleRallyItemEffectId != 0UL) {
        BattleRallyItemEffectId = other.BattleRallyItemEffectId;
      }
      if (other.IsTeamSkill != false) {
        IsTeamSkill = other.IsTeamSkill;
      }
      if (other.TeamSkillId != 0UL) {
        TeamSkillId = other.TeamSkillId;
      }
      if (other.U1 != 0) {
        U1 = other.U1;
      }
      if (other.U2 != 0) {
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
            BattleRallyItemEffectId = input.ReadUInt64();
            break;
          }
          case 16: {
            IsTeamSkill = input.ReadBool();
            break;
          }
          case 24: {
            TeamSkillId = input.ReadUInt64();
            break;
          }
          case 32: {
            U1 = input.ReadInt32();
            break;
          }
          case 40: {
            U2 = input.ReadInt32();
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
            BattleRallyItemEffectId = input.ReadUInt64();
            break;
          }
          case 16: {
            IsTeamSkill = input.ReadBool();
            break;
          }
          case 24: {
            TeamSkillId = input.ReadUInt64();
            break;
          }
          case 32: {
            U1 = input.ReadInt32();
            break;
          }
          case 40: {
            U2 = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BattleRallyItemEffectTable : pb::IMessage<BattleRallyItemEffectTable>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BattleRallyItemEffectTable> _parser = new pb::MessageParser<BattleRallyItemEffectTable>(() => new BattleRallyItemEffectTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BattleRallyItemEffectTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.BattleRallyItemEffectReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleRallyItemEffectTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleRallyItemEffectTable(BattleRallyItemEffectTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleRallyItemEffectTable Clone() {
      return new BattleRallyItemEffectTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.BattleRallyItemEffect> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.BattleRallyItemEffect.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.BattleRallyItemEffect> entries_ = new pbc::RepeatedField<global::ReMastersLib.BattleRallyItemEffect>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::ReMastersLib.BattleRallyItemEffect> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BattleRallyItemEffectTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BattleRallyItemEffectTable other) {
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
    public void MergeFrom(BattleRallyItemEffectTable other) {
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