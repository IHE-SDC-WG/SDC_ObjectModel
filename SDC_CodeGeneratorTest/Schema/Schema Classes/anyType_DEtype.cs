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
[JsonObject("anyType_DEtype")]
public partial class anyType_DEtype : BaseType
{
    #region Private fields
    private List<System.Xml.XmlElement> _any;
    private long _minLength;
    private bool minLengthFieldSpecified;
    private long _maxLength;
    private bool maxLengthFieldSpecified;
    private string _schema;
    private string _namespace;
    private List<System.Xml.XmlAttribute> _anyAttr;
    private bool _anySpecified;
    private bool _schemaSpecified;
    private bool _namespaceSpecified;
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
    /// Namespace used in an XML Schema file, if any, used to constrain and validate the the content of this field.  This is similar to the use of namespaces with the xs:any element in XML Schemas.
    /// 
    /// See: http://www.w3.org/TR/xmlschema-0/#any
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string @namespace
    {
        get
        {
            return _namespace;
        }
        set
        {
            if ((_namespace == value))
            {
                return;
            }
            if (((_namespace == null) 
                        || (_namespace.Equals(value) != true)))
            {
                _namespace = value;
                OnPropertyChanged("namespace", value);
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
    public bool schemaSpecified
    {
        get
        {
            return _schemaSpecified;
        }
        set
        {
            _schemaSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool namespaceSpecified
    {
        get
        {
            return _namespaceSpecified;
        }
        set
        {
            _namespaceSpecified = value;
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
    
    /// <summary>
    /// Test whether schema should be serialized
    /// </summary>
    public virtual bool ShouldSerializeschema()
    {
        return !string.IsNullOrEmpty(schema);
    }
    
    /// <summary>
    /// Test whether namespace should be serialized
    /// </summary>
    public virtual bool ShouldSerializenamespace()
    {
        return !string.IsNullOrEmpty(@namespace);
    }
}
}
#pragma warning restore