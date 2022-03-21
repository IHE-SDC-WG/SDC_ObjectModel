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
[JsonObject("XMLPackageTypeHelperFile")]
public partial class XMLPackageTypeHelperFile : ExtensionBaseType
{
    #region Private fields
    private string _templateID;
    private string _targetTemplateID;
    private bool _templateIDSpecified;
    private bool _targetTemplateIDSpecified;
    #endregion
    
    [XmlAttribute(DataType="anyURI")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string templateID
    {
        get
        {
            return _templateID;
        }
        set
        {
            if ((_templateID == value))
            {
                return;
            }
            if (((_templateID == null) 
                        || (_templateID.Equals(value) != true)))
            {
                _templateID = value;
                OnPropertyChanged("templateID", value);
            }
        }
    }
    
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
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool templateIDSpecified
    {
        get
        {
            return _templateIDSpecified;
        }
        set
        {
            _templateIDSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool targetTemplateIDSpecified
    {
        get
        {
            return _targetTemplateIDSpecified;
        }
        set
        {
            _targetTemplateIDSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether templateID should be serialized
    /// </summary>
    public virtual bool ShouldSerializetemplateID()
    {
        return !string.IsNullOrEmpty(templateID);
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
