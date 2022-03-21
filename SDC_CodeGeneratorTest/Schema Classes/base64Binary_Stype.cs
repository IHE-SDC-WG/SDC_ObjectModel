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

[XmlInclude(typeof(HashType))]
[XmlInclude(typeof(base64Binary_DEtype))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("base64Binary_Stype")]
public partial class base64Binary_Stype : BaseType
{
    private string _mediaType;
    private byte[] _val;
    private bool _mediaTypeSpecified;
    private bool _valSpecified;
    /// <summary>
    /// TBD: Must be a valid Media (MIME) type
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string mediaType
    {
        get
        {
            return _mediaType;
        }
        set
        {
            if ((_mediaType == value))
            {
                return;
            }
            if (((_mediaType == null) 
                        || (_mediaType.Equals(value) != true)))
            {
                _mediaType = value;
                OnPropertyChanged("mediaType", value);
            }
        }
    }
    
    [XmlAttribute(DataType="base64Binary")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual byte[] val
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
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool mediaTypeSpecified
    {
        get
        {
            return _mediaTypeSpecified;
        }
        set
        {
            _mediaTypeSpecified = value;
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
    
    /// <summary>
    /// Test whether mediaType should be serialized
    /// </summary>
    public virtual bool ShouldSerializemediaType()
    {
        return !string.IsNullOrEmpty(mediaType);
    }
}
}
#pragma warning restore
