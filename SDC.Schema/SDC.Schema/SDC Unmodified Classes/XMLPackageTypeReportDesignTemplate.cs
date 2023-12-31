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
/// XMLPackageType represents the primary grouping of SDC artifacts that support
/// one or more SDC FormDesign templates.
/// It is used as a grouper to exchange multiple SDC XML documents, with or without instance data (i.e., SDC form responses) inside those documents.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true, Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("XMLPackageTypeReportDesignTemplate")]
public partial class XMLPackageTypeReportDesignTemplate : FormDesignType
{
    #region Private fields
    private string _targetTemplateID;
    #endregion
    
    [XmlAttribute(DataType="anyURI")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string targetTemplateID
    {
        get
        {
            return _targetTemplateID;
        }
        set
        {
            if ((_targetTemplateID == value))
            {
                return;
            }
            if (((_targetTemplateID == null) 
                        || (_targetTemplateID.Equals(value) != true)))
            {
                _targetTemplateID = value;
                OnPropertyChanged("targetTemplateID", value);
            }
        }
    }
    
    /// <summary>
    /// Test whether targetTemplateID should be serialized
    /// </summary>
    public virtual bool ShouldSerializetargetTemplateID()
    {
        return !string.IsNullOrEmpty(targetTemplateID);
    }
}
}
#pragma warning restore
