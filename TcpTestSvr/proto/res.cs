//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: protos/res.proto
namespace yy.proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"res_list_bag_c2s")]
  public partial class res_list_bag_c2s : global::ProtoBuf.IExtensible
  {
    public res_list_bag_c2s() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"res_list_bag_s2c")]
  public partial class res_list_bag_s2c : global::ProtoBuf.IExtensible
  {
    public res_list_bag_s2c() {}
    
    private readonly global::System.Collections.Generic.List<yy.proto.p_bag_item> _bagItem_list = new global::System.Collections.Generic.List<yy.proto.p_bag_item>();
    [global::ProtoBuf.ProtoMember(1, Name=@"bagItem_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<yy.proto.p_bag_item> bagItem_list
    {
      get { return _bagItem_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"p_bag_item")]
  public partial class p_bag_item : global::ProtoBuf.IExtensible
  {
    public p_bag_item() {}
    
    private long _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _cfgId = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"cfgId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int cfgId
    {
      get { return _cfgId; }
      set { _cfgId = value; }
    }
    private long _count = default(long);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long count
    {
      get { return _count; }
      set { _count = value; }
    }
    private long _max_count = default(long);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"max_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long max_count
    {
      get { return _max_count; }
      set { _max_count = value; }
    }
    private long _expired_time = default(long);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"expired_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long expired_time
    {
      get { return _expired_time; }
      set { _expired_time = value; }
    }
    private bool _is_bind = default(bool);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"is_bind", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_bind
    {
      get { return _is_bind; }
      set { _is_bind = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"res_list_wallet_c2s")]
  public partial class res_list_wallet_c2s : global::ProtoBuf.IExtensible
  {
    public res_list_wallet_c2s() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"res_list_wallet_s2c")]
  public partial class res_list_wallet_s2c : global::ProtoBuf.IExtensible
  {
    public res_list_wallet_s2c() {}
    
    private readonly global::System.Collections.Generic.List<yy.proto.p_wallet_item> _walletItem_list = new global::System.Collections.Generic.List<yy.proto.p_wallet_item>();
    [global::ProtoBuf.ProtoMember(1, Name=@"walletItem_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<yy.proto.p_wallet_item> walletItem_list
    {
      get { return _walletItem_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"p_wallet_item")]
  public partial class p_wallet_item : global::ProtoBuf.IExtensible
  {
    public p_wallet_item() {}
    
    private long _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private long _bind_count;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"bind_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long bind_count
    {
      get { return _bind_count; }
      set { _bind_count = value; }
    }
    private long _unbind_count;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"unbind_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long unbind_count
    {
      get { return _unbind_count; }
      set { _unbind_count = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"res_use_bag_item_c2s")]
  public partial class res_use_bag_item_c2s : global::ProtoBuf.IExtensible
  {
    public res_use_bag_item_c2s() {}
    
    private int _cfg_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"cfg_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int cfg_id
    {
      get { return _cfg_id; }
      set { _cfg_id = value; }
    }
    private long _count;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long count
    {
      get { return _count; }
      set { _count = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"res_use_bag_item_s2c")]
  public partial class res_use_bag_item_s2c : global::ProtoBuf.IExtensible
  {
    public res_use_bag_item_s2c() {}
    
    private bool _success;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"success", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool success
    {
      get { return _success; }
      set { _success = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"res_use_wallet_item_c2s")]
  public partial class res_use_wallet_item_c2s : global::ProtoBuf.IExtensible
  {
    public res_use_wallet_item_c2s() {}
    
    private int _cfg_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"cfg_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int cfg_id
    {
      get { return _cfg_id; }
      set { _cfg_id = value; }
    }
    private long _count;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long count
    {
      get { return _count; }
      set { _count = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"res_use_wallet_item_s2c")]
  public partial class res_use_wallet_item_s2c : global::ProtoBuf.IExtensible
  {
    public res_use_wallet_item_s2c() {}
    
    private bool _success;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"success", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool success
    {
      get { return _success; }
      set { _success = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}