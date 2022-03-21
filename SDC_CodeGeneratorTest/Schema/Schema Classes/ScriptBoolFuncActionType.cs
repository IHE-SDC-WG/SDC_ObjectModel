// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 6.0.0.0. www.xsd2code.com
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace SDC.Schema
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Globalization;
using System.Xml;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MsgPack.Serialization;
using System.IO;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("ScriptBoolFuncActionType")]
public partial class ScriptBoolFuncActionType : ScriptCodeBoolType
{
    #region Private fields
    private ExtensionBaseType[] _items;
    private ItemsChoiceType[] _itemsElementName;
    private bool _itemsSpecified;
    private bool _itemsElementNameSpecified;
    #endregion
    
    [XmlElement("Actions", typeof(ActionsType), Order=0)]
    [XmlElement("ConditionalActions", typeof(PredActionType), Order=0)]
    [XmlElement("Else", typeof(PredActionType), Order=0)]
    [XmlChoiceIdentifierAttribute("ItemsElementName")]
    public virtual ExtensionBaseType[] Items
    {
        get
        {
            return _items;
        }
        set
        {
            if ((_items == value))
            {
                return;
            }
            if (((_items == null) 
                        || (_items.Equals(value) != true)))
            {
                _items = value;
                OnPropertyChanged("Items", value);
            }
        }
    }
    
    [XmlElement("ItemsElementName", Order=1)]
    [XmlIgnore]
    public virtual ItemsChoiceType[] ItemsElementName
    {
        get
        {
            return _itemsElementName;
        }
        set
        {
            if ((_itemsElementName == value))
            {
                return;
            }
            if (((_itemsElementName == null) 
                        || (_itemsElementName.Equals(value) != true)))
            {
                _itemsElementName = value;
                OnPropertyChanged("ItemsElementName", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool ItemsSpecified
    {
        get
        {
            return _itemsSpecified;
        }
        set
        {
            _itemsSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool ItemsElementNameSpecified
    {
        get
        {
            return _itemsElementNameSpecified;
        }
        set
        {
            _itemsElementNameSpecified = value;
        }
    }
}
}
#pragma warning restore