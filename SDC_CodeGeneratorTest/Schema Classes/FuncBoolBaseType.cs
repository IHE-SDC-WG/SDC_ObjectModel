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
/// Function or web service that returns a Boolean value.  Items that inherit from this class must test the result for being a Boolean true/false value or null.
/// </summary>
[XmlInclude(typeof(PredAlternativesType))]
[XmlInclude(typeof(PredGuardType))]
[XmlInclude(typeof(PredMultiSelectionSetBoolType))]
[XmlInclude(typeof(MultiSelectionsActionType))]
[XmlInclude(typeof(PredEvalAttribValuesType))]
[XmlInclude(typeof(AttributeEvalActionType))]
[XmlInclude(typeof(PredActionType))]
[XmlInclude(typeof(EventType))]
[XmlInclude(typeof(OnEventType))]
[XmlInclude(typeof(PredSingleSelectionSetsType))]
[XmlInclude(typeof(SelectionSetsActionType))]
[XmlInclude(typeof(PredSelectionTestType))]
[XmlInclude(typeof(SelectionTestActionType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("FuncBoolBaseType")]
public abstract partial class FuncBoolBaseType : ExtensionBaseType
{
    private bool _allowNull;
    private string _validationMessage;
    private bool _returnVal;
    private bool returnValFieldSpecified;
    private bool _allowNullSpecified;
    private bool _validationMessageSpecified;
    /// <summary>
    /// FuncBoolBaseType class constructor
    /// </summary>
    public FuncBoolBaseType()
    {
        _allowNull = true;
    }
    
    /// <summary>
    /// True means that null values are allowed in @returnVal.  This corresponds to an empty string in @val or a missing @returnVal attribute.
    /// </summary>
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
    
    /// <summary>
    /// Optional message that appears when the rule evaluates to true
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string validationMessage
    {
        get
        {
            return _validationMessage;
        }
        set
        {
            if ((_validationMessage == value))
            {
                return;
            }
            if (((_validationMessage == null) 
                        || (_validationMessage.Equals(value) != true)))
            {
                _validationMessage = value;
                OnPropertyChanged("validationMessage", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool returnVal
    {
        get
        {
            return _returnVal;
        }
        set
        {
            if ((_returnVal.Equals(value) != true))
            {
                _returnVal = value;
                OnPropertyChanged("returnVal", value);
            }
        }
    }
    
    [XmlIgnore]
    public virtual bool returnValSpecified
    {
        get
        {
            return returnValFieldSpecified;
        }
        set
        {
            if ((returnValFieldSpecified.Equals(value) != true))
            {
                returnValFieldSpecified = value;
                OnPropertyChanged("returnValSpecified", value);
            }
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
    public bool validationMessageSpecified
    {
        get
        {
            return _validationMessageSpecified;
        }
        set
        {
            _validationMessageSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether validationMessage should be serialized
    /// </summary>
    public virtual bool ShouldSerializevalidationMessage()
    {
        return !string.IsNullOrEmpty(validationMessage);
    }
}
}
#pragma warning restore
