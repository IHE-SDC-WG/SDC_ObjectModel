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
/// Property is any type of data that is associated with any form item (e.g., section, question, list item) in any context.  The Property context is specified by the @type attribute.  Examples of @type values may include:
/// -alternate language representations, e.g., 'spanish'
/// -'instruction'
/// -'tooltip'
/// -'help' for a pop-up help box
/// -'outlining' (such as question numbering)
/// 
/// The @type enumerations must be defined and documented for the particular use case, and are currently out of scope in this schema definition.  Multiple type tokens for a single element are supported.
/// 
/// RENAMED:  'OtherText' to 'Property' 9/14/2016
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("PropertyType")]
public partial class PropertyType : ExtensionBaseType
{
    #region Private fields
    private DataTypes_SType _typedValue;
    private string _propName;
    private string _propClass;
    private string _val;
    #endregion
    
    /// <summary>
    /// Contains optional typed data.
    /// </summary>
    [XmlElement(Order=0)]
    [JsonProperty(Order=0, NullValueHandling=NullValueHandling.Ignore)]
    public virtual DataTypes_SType TypedValue
    {
        get
        {
            return _typedValue;
        }
        set
        {
            if ((_typedValue == value))
            {
                return;
            }
            if (((_typedValue == null) 
                        || (_typedValue.Equals(value) != true)))
            {
                _typedValue = value;
                OnPropertyChanged("TypedValue", value);
            }
        }
    }
    
    /// <summary>
    /// NEW
    /// </summary>
    [XmlAttribute(DataType="NMTOKEN")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string propName
    {
        get
        {
            return _propName;
        }
        set
        {
            if ((_propName == value))
            {
                return;
            }
            if (((_propName == null) 
                        || (_propName.Equals(value) != true)))
            {
                _propName = value;
                OnPropertyChanged("propName", value);
            }
        }
    }
    
    /// <summary>
    /// NEW
    /// </summary>
    [XmlAttribute(DataType="NMTOKENS")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string propClass
    {
        get
        {
            return _propClass;
        }
        set
        {
            if ((_propClass == value))
            {
                return;
            }
            if (((_propClass == null) 
                        || (_propClass.Equals(value) != true)))
            {
                _propClass = value;
                OnPropertyChanged("propClass", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string val
    {
        get
        {
            return _val;
        }
        set
        {
            if ((_val == value))
            {
                return;
            }
            if (((_val == null) 
                        || (_val.Equals(value) != true)))
            {
                _val = value;
                OnPropertyChanged("val", value);
            }
        }
    }
    
    /// <summary>
    /// Test whether TypedValue should be serialized
    /// </summary>
    public virtual bool ShouldSerializeTypedValue()
    {
        return (_typedValue != null);
    }
    
    /// <summary>
    /// Test whether propName should be serialized
    /// </summary>
    public virtual bool ShouldSerializepropName()
    {
        return !string.IsNullOrEmpty(propName);
    }
    
    /// <summary>
    /// Test whether propClass should be serialized
    /// </summary>
    public virtual bool ShouldSerializepropClass()
    {
        return !string.IsNullOrEmpty(propClass);
    }
    
    /// <summary>
    /// Test whether val should be serialized
    /// </summary>
    public virtual bool ShouldSerializeval()
    {
        return !string.IsNullOrEmpty(val);
    }
}
}
#pragma warning restore
