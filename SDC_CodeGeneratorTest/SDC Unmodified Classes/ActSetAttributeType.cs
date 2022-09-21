// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 6.0.64.0. www.xsd2code.com
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
/// This type is used to act upon the value of common item attributes. If
/// an "act" attribute (a type with the "act" prefix) has no value assigned, it is
/// ignored. If it has a value, then that attribute on the target item(s) assume(s) that
/// stated value when an attached Boolean condition evaluates to true. The attached
/// condition may be an "If" statement or any expression that evaluates to a Boolean
/// value.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("ActSetAttributeType")]
public partial class ActSetAttributeType : ExtensionBaseType
{
    #region Private fields
    protected internal bool _shouldSerializeactReadOnly;
    protected internal bool _shouldSerializeactDeleteResponse;
    protected internal bool _shouldSerializeactSelect;
    protected internal bool _shouldSerializeactActivate;
    protected internal bool _shouldSerializeactMaxCard;
    protected internal bool _shouldSerializeactMinCard;
    protected internal bool _shouldSerializeactEnable;
    protected internal bool _shouldSerializeactVisible;
    private string _targetNames;
    private bool _actVisible;
    private bool _actEnable;
    private uint _actMinCard;
    private uint _actMaxCard;
    private bool _actActivate;
    private bool _actSelect;
    private bool _actDeleteResponse;
    private bool _actReadOnly;
    private string _actType;
    private string _actStyleClass;
    private string _actSetTitleText;
    private byte[] _actSetBase64HTML;
    private string _actSetCode;
    private string _actSetCodeSystem;
    private string _actSetVal;
    private string _actSetAssociatedValue;
    private string _actSetValFromRef;
    private string _actSetAssociatedValueFromRef;
    #endregion
    
    /// <summary>
    /// The names of the items affected by property
    /// actions
    /// </summary>
    [XmlAttribute(DataType="NMTOKENS")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string targetNames
    {
        get
        {
            return _targetNames;
        }
        set
        {
            if ((_targetNames == value))
            {
                return;
            }
            if (((_targetNames == null) 
                        || (_targetNames.Equals(value) != true)))
            {
                _targetNames = value;
                OnPropertyChanged("targetNames", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool actVisible
    {
        get
        {
            return _actVisible;
        }
        set
        {
            if ((_actVisible.Equals(value) != true))
            {
                _actVisible = value;
                OnPropertyChanged("actVisible", value);
            }
            _shouldSerializeactVisible = true;
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool actEnable
    {
        get
        {
            return _actEnable;
        }
        set
        {
            if ((_actEnable.Equals(value) != true))
            {
                _actEnable = value;
                OnPropertyChanged("actEnable", value);
            }
            _shouldSerializeactEnable = true;
        }
    }
    
    /// <summary>
    /// Controls requirement to answer the question and the
    /// minimum number of repeats.
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual uint actMinCard
    {
        get
        {
            return _actMinCard;
        }
        set
        {
            if ((_actMinCard.Equals(value) != true))
            {
                _actMinCard = value;
                OnPropertyChanged("actMinCard", value);
            }
            _shouldSerializeactMinCard = true;
        }
    }
    
    /// <summary>
    /// Controls requirement to answer the
    /// question
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual uint actMaxCard
    {
        get
        {
            return _actMaxCard;
        }
        set
        {
            if ((_actMaxCard.Equals(value) != true))
            {
                _actMaxCard = value;
                OnPropertyChanged("actMaxCard", value);
            }
            _shouldSerializeactMaxCard = true;
        }
    }
    
    /// <summary>
    /// Toggle visible and enabled together. Setting this to false
    /// will de-activate all descendents but will not change their enabled or
    /// visible properties.
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool actActivate
    {
        get
        {
            return _actActivate;
        }
        set
        {
            if ((_actActivate.Equals(value) != true))
            {
                _actActivate = value;
                OnPropertyChanged("actActivate", value);
            }
            _shouldSerializeactActivate = true;
        }
    }
    
    /// <summary>
    /// Toggle selection of a List Item; not applicable to other
    /// items.
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool actSelect
    {
        get
        {
            return _actSelect;
        }
        set
        {
            if ((_actSelect.Equals(value) != true))
            {
                _actSelect = value;
                OnPropertyChanged("actSelect", value);
            }
            _shouldSerializeactSelect = true;
        }
    }
    
    /// <summary>
    /// Delete any response in a Response field on a question or
    /// ListItem. Not applicable to other item types.
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool actDeleteResponse
    {
        get
        {
            return _actDeleteResponse;
        }
        set
        {
            if ((_actDeleteResponse.Equals(value) != true))
            {
                _actDeleteResponse = value;
                OnPropertyChanged("actDeleteResponse", value);
            }
            _shouldSerializeactDeleteResponse = true;
        }
    }
    
    /// <summary>
    /// Delete any response in a Response field on a question or
    /// ListItem. Not applicable to other item types.
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool actReadOnly
    {
        get
        {
            return _actReadOnly;
        }
        set
        {
            if ((_actReadOnly.Equals(value) != true))
            {
                _actReadOnly = value;
                OnPropertyChanged("actReadOnly", value);
            }
            _shouldSerializeactReadOnly = true;
        }
    }
    
    /// <summary>
    /// Set the @type attribute value
    /// </summary>
    [XmlAttribute(DataType="NMTOKENS")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string actType
    {
        get
        {
            return _actType;
        }
        set
        {
            if ((_actType == value))
            {
                return;
            }
            if (((_actType == null) 
                        || (_actType.Equals(value) != true)))
            {
                _actType = value;
                OnPropertyChanged("actType", value);
            }
        }
    }
    
    /// <summary>
    /// Set the @styleClass attribute value
    /// </summary>
    [XmlAttribute(DataType="NMTOKENS")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string actStyleClass
    {
        get
        {
            return _actStyleClass;
        }
        set
        {
            if ((_actStyleClass == value))
            {
                return;
            }
            if (((_actStyleClass == null) 
                        || (_actStyleClass.Equals(value) != true)))
            {
                _actStyleClass = value;
                OnPropertyChanged("actStyleClass", value);
            }
        }
    }
    
    /// <summary>
    /// Set the @title text on an item.
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string actSetTitleText
    {
        get
        {
            return _actSetTitleText;
        }
        set
        {
            if ((_actSetTitleText == value))
            {
                return;
            }
            if (((_actSetTitleText == null) 
                        || (_actSetTitleText.Equals(value) != true)))
            {
                _actSetTitleText = value;
                OnPropertyChanged("actSetTitleText", value);
            }
        }
    }
    
    /// <summary>
    /// Set HTML as base-64-encoded binary
    /// </summary>
    [XmlAttribute(DataType="base64Binary")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual byte[] actSetBase64HTML
    {
        get
        {
            return _actSetBase64HTML;
        }
        set
        {
            if ((_actSetBase64HTML == value))
            {
                return;
            }
            if (((_actSetBase64HTML == null) 
                        || (_actSetBase64HTML.Equals(value) != true)))
            {
                _actSetBase64HTML = value;
                OnPropertyChanged("actSetBase64HTML", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string actSetCode
    {
        get
        {
            return _actSetCode;
        }
        set
        {
            if ((_actSetCode == value))
            {
                return;
            }
            if (((_actSetCode == null) 
                        || (_actSetCode.Equals(value) != true)))
            {
                _actSetCode = value;
                OnPropertyChanged("actSetCode", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string actSetCodeSystem
    {
        get
        {
            return _actSetCodeSystem;
        }
        set
        {
            if ((_actSetCodeSystem == value))
            {
                return;
            }
            if (((_actSetCodeSystem == null) 
                        || (_actSetCodeSystem.Equals(value) != true)))
            {
                _actSetCodeSystem = value;
                OnPropertyChanged("actSetCodeSystem", value);
            }
        }
    }
    
    /// <summary>
    /// Set a @val attribute with a supplied value. The correct
    /// data type must be used if applicable.
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string actSetVal
    {
        get
        {
            return _actSetVal;
        }
        set
        {
            if ((_actSetVal == value))
            {
                return;
            }
            if (((_actSetVal == null) 
                        || (_actSetVal.Equals(value) != true)))
            {
                _actSetVal = value;
                OnPropertyChanged("actSetVal", value);
            }
        }
    }
    
    /// <summary>
    /// Set @associatedValue attribute of a ListItem with a
    /// supplied value. The correct data type must be used if
    /// applicable.
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string actSetAssociatedValue
    {
        get
        {
            return _actSetAssociatedValue;
        }
        set
        {
            if ((_actSetAssociatedValue == value))
            {
                return;
            }
            if (((_actSetAssociatedValue == null) 
                        || (_actSetAssociatedValue.Equals(value) != true)))
            {
                _actSetAssociatedValue = value;
                OnPropertyChanged("actSetAssociatedValue", value);
            }
        }
    }
    
    /// <summary>
    /// Set a @val attribute. The correct data type must be used
    /// if applicable. Supply the @name of an element that has a non-null @val
    /// value of the correct datatype. Null values are
    /// ignored.
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string actSetValFromRef
    {
        get
        {
            return _actSetValFromRef;
        }
        set
        {
            if ((_actSetValFromRef == value))
            {
                return;
            }
            if (((_actSetValFromRef == null) 
                        || (_actSetValFromRef.Equals(value) != true)))
            {
                _actSetValFromRef = value;
                OnPropertyChanged("actSetValFromRef", value);
            }
        }
    }
    
    /// <summary>
    /// Set @associatedValue attribute of a ListItem. The correct
    /// data type must be used if applicable. Supply the @name of an element
    /// that has a non-null @val value of the correct datatype. Null values are
    /// ignored.
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string actSetAssociatedValueFromRef
    {
        get
        {
            return _actSetAssociatedValueFromRef;
        }
        set
        {
            if ((_actSetAssociatedValueFromRef == value))
            {
                return;
            }
            if (((_actSetAssociatedValueFromRef == null) 
                        || (_actSetAssociatedValueFromRef.Equals(value) != true)))
            {
                _actSetAssociatedValueFromRef = value;
                OnPropertyChanged("actSetAssociatedValueFromRef", value);
            }
        }
    }
    
    /// <summary>
    /// Test whether actVisible should be serialized
    /// </summary>
    public virtual bool ShouldSerializeactVisible()
    {
        if (_shouldSerializeactVisible)
        {
            return true;
        }
        return (_actVisible != default(bool));
    }
    
    /// <summary>
    /// Test whether actEnable should be serialized
    /// </summary>
    public virtual bool ShouldSerializeactEnable()
    {
        if (_shouldSerializeactEnable)
        {
            return true;
        }
        return (_actEnable != default(bool));
    }
    
    /// <summary>
    /// Test whether actMinCard should be serialized
    /// </summary>
    public virtual bool ShouldSerializeactMinCard()
    {
        if (_shouldSerializeactMinCard)
        {
            return true;
        }
        return (_actMinCard != default(uint));
    }
    
    /// <summary>
    /// Test whether actMaxCard should be serialized
    /// </summary>
    public virtual bool ShouldSerializeactMaxCard()
    {
        if (_shouldSerializeactMaxCard)
        {
            return true;
        }
        return (_actMaxCard != default(uint));
    }
    
    /// <summary>
    /// Test whether actActivate should be serialized
    /// </summary>
    public virtual bool ShouldSerializeactActivate()
    {
        if (_shouldSerializeactActivate)
        {
            return true;
        }
        return (_actActivate != default(bool));
    }
    
    /// <summary>
    /// Test whether actSelect should be serialized
    /// </summary>
    public virtual bool ShouldSerializeactSelect()
    {
        if (_shouldSerializeactSelect)
        {
            return true;
        }
        return (_actSelect != default(bool));
    }
    
    /// <summary>
    /// Test whether actDeleteResponse should be serialized
    /// </summary>
    public virtual bool ShouldSerializeactDeleteResponse()
    {
        if (_shouldSerializeactDeleteResponse)
        {
            return true;
        }
        return (_actDeleteResponse != default(bool));
    }
    
    /// <summary>
    /// Test whether actReadOnly should be serialized
    /// </summary>
    public virtual bool ShouldSerializeactReadOnly()
    {
        if (_shouldSerializeactReadOnly)
        {
            return true;
        }
        return (_actReadOnly != default(bool));
    }
    
    /// <summary>
    /// Test whether targetNames should be serialized
    /// </summary>
    public virtual bool ShouldSerializetargetNames()
    {
        return !string.IsNullOrEmpty(targetNames);
    }
    
    /// <summary>
    /// Test whether actType should be serialized
    /// </summary>
    public virtual bool ShouldSerializeactType()
    {
        return !string.IsNullOrEmpty(actType);
    }
    
    /// <summary>
    /// Test whether actStyleClass should be serialized
    /// </summary>
    public virtual bool ShouldSerializeactStyleClass()
    {
        return !string.IsNullOrEmpty(actStyleClass);
    }
    
    /// <summary>
    /// Test whether actSetTitleText should be serialized
    /// </summary>
    public virtual bool ShouldSerializeactSetTitleText()
    {
        return !string.IsNullOrEmpty(actSetTitleText);
    }
    
    /// <summary>
    /// Test whether actSetCode should be serialized
    /// </summary>
    public virtual bool ShouldSerializeactSetCode()
    {
        return !string.IsNullOrEmpty(actSetCode);
    }
    
    /// <summary>
    /// Test whether actSetCodeSystem should be serialized
    /// </summary>
    public virtual bool ShouldSerializeactSetCodeSystem()
    {
        return !string.IsNullOrEmpty(actSetCodeSystem);
    }
    
    /// <summary>
    /// Test whether actSetVal should be serialized
    /// </summary>
    public virtual bool ShouldSerializeactSetVal()
    {
        return !string.IsNullOrEmpty(actSetVal);
    }
    
    /// <summary>
    /// Test whether actSetAssociatedValue should be serialized
    /// </summary>
    public virtual bool ShouldSerializeactSetAssociatedValue()
    {
        return !string.IsNullOrEmpty(actSetAssociatedValue);
    }
    
    /// <summary>
    /// Test whether actSetValFromRef should be serialized
    /// </summary>
    public virtual bool ShouldSerializeactSetValFromRef()
    {
        return !string.IsNullOrEmpty(actSetValFromRef);
    }
    
    /// <summary>
    /// Test whether actSetAssociatedValueFromRef should be serialized
    /// </summary>
    public virtual bool ShouldSerializeactSetAssociatedValueFromRef()
    {
        return !string.IsNullOrEmpty(actSetAssociatedValueFromRef);
    }
}
}
#pragma warning restore
