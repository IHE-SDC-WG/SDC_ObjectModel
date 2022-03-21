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
[JsonObject("string_DEtype")]
public partial class string_DEtype : string_Stype
{
    private long _minLength;
    private bool minLengthFieldSpecified;
    private long _maxLength;
    private bool maxLengthFieldSpecified;
    private string _pattern;
    private string _mask;
    private bool _patternSpecified;
    private bool _maskSpecified;
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual long minLength
    {
        get
        {
            return _minLength;
        }
        set
        {
            if ((_minLength.Equals(value) != true))
            {
                _minLength = value;
                OnPropertyChanged("minLength", value);
            }
        }
    }
    
    [XmlIgnore]
    public virtual bool minLengthSpecified
    {
        get
        {
            return minLengthFieldSpecified;
        }
        set
        {
            if ((minLengthFieldSpecified.Equals(value) != true))
            {
                minLengthFieldSpecified = value;
                OnPropertyChanged("minLengthSpecified", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual long maxLength
    {
        get
        {
            return _maxLength;
        }
        set
        {
            if ((_maxLength.Equals(value) != true))
            {
                _maxLength = value;
                OnPropertyChanged("maxLength", value);
            }
        }
    }
    
    [XmlIgnore]
    public virtual bool maxLengthSpecified
    {
        get
        {
            return maxLengthFieldSpecified;
        }
        set
        {
            if ((maxLengthFieldSpecified.Equals(value) != true))
            {
                maxLengthFieldSpecified = value;
                OnPropertyChanged("maxLengthSpecified", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string pattern
    {
        get
        {
            return _pattern;
        }
        set
        {
            if ((_pattern == value))
            {
                return;
            }
            if (((_pattern == null) 
                        || (_pattern.Equals(value) != true)))
            {
                _pattern = value;
                OnPropertyChanged("pattern", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string mask
    {
        get
        {
            return _mask;
        }
        set
        {
            if ((_mask == value))
            {
                return;
            }
            if (((_mask == null) 
                        || (_mask.Equals(value) != true)))
            {
                _mask = value;
                OnPropertyChanged("mask", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool patternSpecified
    {
        get
        {
            return _patternSpecified;
        }
        set
        {
            _patternSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool maskSpecified
    {
        get
        {
            return _maskSpecified;
        }
        set
        {
            _maskSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether pattern should be serialized
    /// </summary>
    public virtual bool ShouldSerializepattern()
    {
        return !string.IsNullOrEmpty(pattern);
    }
    
    /// <summary>
    /// Test whether mask should be serialized
    /// </summary>
    public virtual bool ShouldSerializemask()
    {
        return !string.IsNullOrEmpty(mask);
    }
}
}
#pragma warning restore
