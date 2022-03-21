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

[XmlInclude(typeof(HTML_DEtype))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("HTML_Stype")]
public partial class HTML_Stype : BaseType
{
    #region Private fields
    private List<System.Xml.XmlElement> _any;
    private List<System.Xml.XmlAttribute> _anyAttr;
    private bool _anySpecified;
    private bool _anyAttrSpecified;
    #endregion
    
    [XmlAnyElementAttribute(Order=0)]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<System.Xml.XmlElement> Any
    {
        get
        {
            return _any;
        }
        set
        {
            if ((_any == value))
            {
                return;
            }
            if (((_any == null) 
                        || (_any.Equals(value) != true)))
            {
                _any = value;
                OnPropertyChanged("Any", value);
            }
        }
    }
    
    [XmlAnyAttributeAttribute()]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<System.Xml.XmlAttribute> AnyAttr
    {
        get
        {
            return _anyAttr;
        }
        set
        {
            if ((_anyAttr == value))
            {
                return;
            }
            if (((_anyAttr == null) 
                        || (_anyAttr.Equals(value) != true)))
            {
                _anyAttr = value;
                OnPropertyChanged("AnyAttr", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool AnySpecified
    {
        get
        {
            return _anySpecified;
        }
        set
        {
            _anySpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool AnyAttrSpecified
    {
        get
        {
            return _anyAttrSpecified;
        }
        set
        {
            _anyAttrSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether Any should be serialized
    /// </summary>
    public virtual bool ShouldSerializeAny()
    {
        return Any != null && Any.Count > 0;
    }
    
    /// <summary>
    /// Test whether AnyAttr should be serialized
    /// </summary>
    public virtual bool ShouldSerializeAnyAttr()
    {
        return AnyAttr != null && AnyAttr.Count > 0;
    }
}
}
#pragma warning restore
