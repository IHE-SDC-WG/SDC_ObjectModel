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

[XmlInclude(typeof(dayTimeDuration_DEtype))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("dayTimeDuration_Stype")]
public partial class dayTimeDuration_Stype : BaseType
{
    #region Private fields
    private bool _shouldSerializequantEnum;
    private string _val;
    private dtQuantEnum _quantEnum;
    private bool _valSpecified;
    private bool _quantEnumSpecified;
    #endregion
    
    /// <summary>
    /// dayTimeDuration_Stype class constructor
    /// </summary>
    public dayTimeDuration_Stype()
    {
        _quantEnum = dtQuantEnum.EQ;
    }
    
    [XmlAttribute(DataType="duration")]
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
    
    [XmlAttribute]
    [DefaultValue(dtQuantEnum.EQ)]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public virtual dtQuantEnum quantEnum
    {
        get
        {
            return _quantEnum;
        }
        set
        {
            if ((_quantEnum.Equals(value) != true))
            {
                _quantEnum = value;
                OnPropertyChanged("quantEnum", value);
            }
            _shouldSerializequantEnum = true;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool valSpecified
    {
        get
        {
            return _valSpecified;
        }
        set
        {
            _valSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool quantEnumSpecified
    {
        get
        {
            return _quantEnumSpecified;
        }
        set
        {
            _quantEnumSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether quantEnum should be serialized
    /// </summary>
    public virtual bool ShouldSerializequantEnum()
    {
        if (_shouldSerializequantEnum)
        {
            return true;
        }
        return (_quantEnum != default(dtQuantEnum));
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
