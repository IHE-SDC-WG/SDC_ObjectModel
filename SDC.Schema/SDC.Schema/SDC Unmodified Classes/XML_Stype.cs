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

[XmlInclude(typeof(XML_DEtype))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("XML_Stype")]
public partial class XML_Stype : BaseType
{
    #region Private fields
    private List<System.Xml.XmlElement> _any;
    private string _schema;
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
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string schema
    {
        get
        {
            return _schema;
        }
        set
        {
            if ((_schema == value))
            {
                return;
            }
            if (((_schema == null) 
                        || (_schema.Equals(value) != true)))
            {
                _schema = value;
                OnPropertyChanged("schema", value);
            }
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
    /// Test whether schema should be serialized
    /// </summary>
    public virtual bool ShouldSerializeschema()
    {
        return !string.IsNullOrEmpty(schema);
    }
}
}
#pragma warning restore
