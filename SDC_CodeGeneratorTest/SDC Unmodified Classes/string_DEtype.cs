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

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("string_DEtype")]
public partial class string_DEtype : string_Stype
{
    #region Private fields
    protected internal bool _shouldSerializemaxLength;
    protected internal bool _shouldSerializeminLength;
    private ulong _minLength;
    private ulong _maxLength;
    private string _pattern;
    private string _mask;
    #endregion
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual ulong minLength
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
            _shouldSerializeminLength = true;
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual ulong maxLength
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
            _shouldSerializemaxLength = true;
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
    
    /// <summary>
    /// Test whether minLength should be serialized
    /// </summary>
    public virtual bool ShouldSerializeminLength()
    {
        if (_shouldSerializeminLength)
        {
            return true;
        }
        return (_minLength != default(long));
    }
    
    /// <summary>
    /// Test whether maxLength should be serialized
    /// </summary>
    public virtual bool ShouldSerializemaxLength()
    {
        if (_shouldSerializemaxLength)
        {
            return true;
        }
        return (_maxLength != default(long));
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
