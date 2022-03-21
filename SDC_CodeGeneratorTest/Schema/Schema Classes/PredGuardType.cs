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
[JsonObject("PredGuardType")]
public partial class PredGuardType : FuncBoolBaseType
{
    #region Private fields
    private bool _shouldSerializeboolOp;
    private List<ExtensionBaseType> _items;
    private bool _not;
    private PredEvalAttribValuesTypeBoolOp _boolOp;
    private bool _itemsSpecified;
    private bool _notSpecified;
    private bool _boolOpSpecified;
    #endregion
    
    /// <summary>
    /// PredGuardType class constructor
    /// </summary>
    public PredGuardType()
    {
        _not = false;
        _boolOp = PredEvalAttribValuesTypeBoolOp.AND;
    }
    
    [XmlElement("AttributeEval", typeof(PredEvalAttribValuesType), Order=0)]
    [XmlElement("CallBoolFunc", typeof(CallFuncBoolType), Order=0)]
    [XmlElement("Group", typeof(PredGuardType), Order=0)]
    [XmlElement("ItemAlternatives", typeof(PredAlternativesType), Order=0)]
    [XmlElement("MultiSelections", typeof(PredMultiSelectionSetBoolType), Order=0)]
    [XmlElement("ScriptBoolFunc", typeof(ScriptCodeBoolType), Order=0)]
    [XmlElement("SelectionSets", typeof(PredGuardTypeSelectionSets), Order=0)]
    [XmlElement("SelectionTest", typeof(PredSelectionTestType), Order=0)]
    public virtual List<ExtensionBaseType> Items
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
    
    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool not
    {
        get
        {
            return _not;
        }
        set
        {
            if ((_not.Equals(value) != true))
            {
                _not = value;
                OnPropertyChanged("not", value);
            }
        }
    }
    
    [XmlAttribute]
    [DefaultValue(PredEvalAttribValuesTypeBoolOp.AND)]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public virtual PredEvalAttribValuesTypeBoolOp boolOp
    {
        get
        {
            return _boolOp;
        }
        set
        {
            if ((_boolOp.Equals(value) != true))
            {
                _boolOp = value;
                OnPropertyChanged("boolOp", value);
            }
            _shouldSerializeboolOp = true;
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
    public bool notSpecified
    {
        get
        {
            return _notSpecified;
        }
        set
        {
            _notSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool boolOpSpecified
    {
        get
        {
            return _boolOpSpecified;
        }
        set
        {
            _boolOpSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether Items should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItems()
    {
        return Items != null && Items.Count > 0;
    }
    
    /// <summary>
    /// Test whether boolOp should be serialized
    /// </summary>
    public virtual bool ShouldSerializeboolOp()
    {
        if (_shouldSerializeboolOp)
        {
            return true;
        }
        return (_boolOp != default(PredEvalAttribValuesTypeBoolOp));
    }
}
}
#pragma warning restore