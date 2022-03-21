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
[XmlTypeAttribute(AnonymousType=true, Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("DataSourceTypeRDF_Store")]
public partial class DataSourceTypeRDF_Store : DataStoreType
{
    private DataSourceTypeRDF_StoreSPARQL _sPARQL;
    private bool _sPARQLSpecified;
    [XmlElement(Order=0)]
    [JsonProperty(Order=0, NullValueHandling=NullValueHandling.Ignore)]
    public virtual DataSourceTypeRDF_StoreSPARQL SPARQL
    {
        get
        {
            return _sPARQL;
        }
        set
        {
            if ((_sPARQL == value))
            {
                return;
            }
            if (((_sPARQL == null) 
                        || (_sPARQL.Equals(value) != true)))
            {
                _sPARQL = value;
                OnPropertyChanged("SPARQL", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool SPARQLSpecified
    {
        get
        {
            return _sPARQLSpecified;
        }
        set
        {
            _sPARQLSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether SPARQL should be serialized
    /// </summary>
    public virtual bool ShouldSerializeSPARQL()
    {
        return (SPARQL != null);
    }
}
}
#pragma warning restore
