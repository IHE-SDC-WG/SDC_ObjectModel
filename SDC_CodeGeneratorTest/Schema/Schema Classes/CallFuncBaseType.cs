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

/// <summary>
/// Function or web service that returns a string value.
/// </summary>
[XmlInclude(typeof(CallFuncBoolType))]
[XmlInclude(typeof(CallFuncBoolActionType))]
[XmlInclude(typeof(CallFuncType))]
[XmlInclude(typeof(CallFuncActionType))]
[XmlInclude(typeof(LookupEndPointType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("CallFuncBaseType")]
public abstract partial class CallFuncBaseType : ExtensionBaseType
{
    #region Private fields
    private bool _shouldSerializeItemElementName;
    private anyURI_Stype _item;
    private ItemChoiceType1 _itemElementName;
    private RichTextType _security;
    private List<ExtensionBaseType> _items;
    private bool _returnList;
    private string _listDelimiter;
    private string _objectTypeName;
    private string _objectFormat;
    private bool _allowNull;
    private string _returnVal;
    private bool _itemSpecified;
    private bool _itemElementNameSpecified;
    private bool _securitySpecified;
    private bool _itemsSpecified;
    private bool _returnListSpecified;
    private bool _listDelimiterSpecified;
    private bool _objectTypeNameSpecified;
    private bool _objectFormatSpecified;
    private bool _allowNullSpecified;
    private bool _returnValSpecified;
    #endregion
    
    /// <summary>
    /// CallFuncBaseType class constructor
    /// </summary>
    public CallFuncBaseType()
    {
        _returnList = false;
        _listDelimiter = "|";
        _allowNull = true;
    }
    
    [XmlElement("FunctionURI", typeof(anyURI_Stype), Order=0)]
    [XmlElement("LocalFunctionName", typeof(anyURI_Stype), Order=0)]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public virtual anyURI_Stype Item
    {
        get
        {
            return _item;
        }
        set
        {
            if ((_item == value))
            {
                return;
            }
            if (((_item == null) 
                        || (_item.Equals(value) != true)))
            {
                _item = value;
                OnPropertyChanged("Item", value);
            }
        }
    }
    
    [XmlElement(Order=1)]
    [XmlIgnore]
    public virtual ItemChoiceType1 ItemElementName
    {
        get
        {
            return _itemElementName;
        }
        set
        {
            if ((_itemElementName.Equals(value) != true))
            {
                _itemElementName = value;
                OnPropertyChanged("ItemElementName", value);
            }
            _shouldSerializeItemElementName = true;
        }
    }
    
    /// <summary>
    /// Information about securly accessing the web service.  More detailed service patterns may be required.
    /// </summary>
    [XmlElement(Order=2)]
    [JsonProperty(Order=2, NullValueHandling=NullValueHandling.Ignore)]
    public virtual RichTextType Security
    {
        get
        {
            return _security;
        }
        set
        {
            if ((_security == value))
            {
                return;
            }
            if (((_security == null) 
                        || (_security.Equals(value) != true)))
            {
                _security = value;
                OnPropertyChanged("Security", value);
            }
        }
    }
    
    [XmlElement("ListItemParameterRef", typeof(ListItemParameterType), Order=3)]
    [XmlElement("ParameterRef", typeof(ParameterItemType), Order=3)]
    [XmlElement("ParameterValue", typeof(ParameterValueType), Order=3)]
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
    public virtual bool returnList
    {
        get
        {
            return _returnList;
        }
        set
        {
            if ((_returnList.Equals(value) != true))
            {
                _returnList = value;
                OnPropertyChanged("returnList", value);
            }
        }
    }
    
    [XmlAttribute]
    [DefaultValue("|")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string listDelimiter
    {
        get
        {
            return _listDelimiter;
        }
        set
        {
            if ((_listDelimiter == value))
            {
                return;
            }
            if (((_listDelimiter == null) 
                        || (_listDelimiter.Equals(value) != true)))
            {
                _listDelimiter = value;
                OnPropertyChanged("listDelimiter", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string objectTypeName
    {
        get
        {
            return _objectTypeName;
        }
        set
        {
            if ((_objectTypeName == value))
            {
                return;
            }
            if (((_objectTypeName == null) 
                        || (_objectTypeName.Equals(value) != true)))
            {
                _objectTypeName = value;
                OnPropertyChanged("objectTypeName", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string objectFormat
    {
        get
        {
            return _objectFormat;
        }
        set
        {
            if ((_objectFormat == value))
            {
                return;
            }
            if (((_objectFormat == null) 
                        || (_objectFormat.Equals(value) != true)))
            {
                _objectFormat = value;
                OnPropertyChanged("objectFormat", value);
            }
        }
    }
    
    [XmlAttribute]
    [DefaultValue(true)]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool allowNull
    {
        get
        {
            return _allowNull;
        }
        set
        {
            if ((_allowNull.Equals(value) != true))
            {
                _allowNull = value;
                OnPropertyChanged("allowNull", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string returnVal
    {
        get
        {
            return _returnVal;
        }
        set
        {
            if ((_returnVal == value))
            {
                return;
            }
            if (((_returnVal == null) 
                        || (_returnVal.Equals(value) != true)))
            {
                _returnVal = value;
                OnPropertyChanged("returnVal", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool ItemSpecified
    {
        get
        {
            return _itemSpecified;
        }
        set
        {
            _itemSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool ItemElementNameSpecified
    {
        get
        {
            return _itemElementNameSpecified;
        }
        set
        {
            _itemElementNameSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool SecuritySpecified
    {
        get
        {
            return _securitySpecified;
        }
        set
        {
            _securitySpecified = value;
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
    public bool returnListSpecified
    {
        get
        {
            return _returnListSpecified;
        }
        set
        {
            _returnListSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool listDelimiterSpecified
    {
        get
        {
            return _listDelimiterSpecified;
        }
        set
        {
            _listDelimiterSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool objectTypeNameSpecified
    {
        get
        {
            return _objectTypeNameSpecified;
        }
        set
        {
            _objectTypeNameSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool objectFormatSpecified
    {
        get
        {
            return _objectFormatSpecified;
        }
        set
        {
            _objectFormatSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool allowNullSpecified
    {
        get
        {
            return _allowNullSpecified;
        }
        set
        {
            _allowNullSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool returnValSpecified
    {
        get
        {
            return _returnValSpecified;
        }
        set
        {
            _returnValSpecified = value;
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
    /// Test whether ItemElementName should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItemElementName()
    {
        if (_shouldSerializeItemElementName)
        {
            return true;
        }
        return (_itemElementName != default(ItemChoiceType1));
    }
    
    /// <summary>
    /// Test whether Item should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItem()
    {
        return (_item != null);
    }
    
    /// <summary>
    /// Test whether Security should be serialized
    /// </summary>
    public virtual bool ShouldSerializeSecurity()
    {
        return (_security != null);
    }
    
    /// <summary>
    /// Test whether listDelimiter should be serialized
    /// </summary>
    public virtual bool ShouldSerializelistDelimiter()
    {
        return !string.IsNullOrEmpty(listDelimiter);
    }
    
    /// <summary>
    /// Test whether objectTypeName should be serialized
    /// </summary>
    public virtual bool ShouldSerializeobjectTypeName()
    {
        return !string.IsNullOrEmpty(objectTypeName);
    }
    
    /// <summary>
    /// Test whether objectFormat should be serialized
    /// </summary>
    public virtual bool ShouldSerializeobjectFormat()
    {
        return !string.IsNullOrEmpty(objectFormat);
    }
    
    /// <summary>
    /// Test whether returnVal should be serialized
    /// </summary>
    public virtual bool ShouldSerializereturnVal()
    {
        return !string.IsNullOrEmpty(returnVal);
    }
}
}
#pragma warning restore
