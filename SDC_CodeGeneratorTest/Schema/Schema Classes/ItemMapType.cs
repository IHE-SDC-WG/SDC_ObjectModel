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
[JsonObject("ItemMapType")]
public partial class ItemMapType : ExtensionBaseType
{
    #region Private fields
    private TemplateTargetType _templateTarget;
    private DataSourceType _dataSource;
    private List<RichTextType> _mapComment;
    private bool _templateTargetSpecified;
    private bool _dataSourceSpecified;
    private bool _mapCommentSpecified;
    #endregion
    
    /// <summary>
    /// Target item in a FormDesignTemplate.
    /// </summary>
    [XmlElement(Order=0)]
    [JsonProperty(Order=0, NullValueHandling=NullValueHandling.Ignore)]
    public virtual TemplateTargetType TemplateTarget
    {
        get
        {
            return _templateTarget;
        }
        set
        {
            if ((_templateTarget == value))
            {
                return;
            }
            if (((_templateTarget == null) 
                        || (_templateTarget.Equals(value) != true)))
            {
                _templateTarget = value;
                OnPropertyChanged("TemplateTarget", value);
            }
        }
    }
    
    /// <summary>
    /// The DataSource is an object that maps to a target item in a FormDesignTemplate.  DataSources objects can include terminology codes, local values, XML-based document entries, database records, RDF store triples, etc.
    /// </summary>
    [XmlElement(Order=1)]
    [JsonProperty(Order=1, NullValueHandling=NullValueHandling.Ignore)]
    public virtual DataSourceType DataSource
    {
        get
        {
            return _dataSource;
        }
        set
        {
            if ((_dataSource == value))
            {
                return;
            }
            if (((_dataSource == null) 
                        || (_dataSource.Equals(value) != true)))
            {
                _dataSource = value;
                OnPropertyChanged("DataSource", value);
            }
        }
    }
    
    [XmlElement("MapComment", Order=2)]
    [JsonProperty(Order=2, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<RichTextType> MapComment
    {
        get
        {
            return _mapComment;
        }
        set
        {
            if ((_mapComment == value))
            {
                return;
            }
            if (((_mapComment == null) 
                        || (_mapComment.Equals(value) != true)))
            {
                _mapComment = value;
                OnPropertyChanged("MapComment", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool TemplateTargetSpecified
    {
        get
        {
            return _templateTargetSpecified;
        }
        set
        {
            _templateTargetSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool DataSourceSpecified
    {
        get
        {
            return _dataSourceSpecified;
        }
        set
        {
            _dataSourceSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool MapCommentSpecified
    {
        get
        {
            return _mapCommentSpecified;
        }
        set
        {
            _mapCommentSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether MapComment should be serialized
    /// </summary>
    public virtual bool ShouldSerializeMapComment()
    {
        return MapComment != null && MapComment.Count > 0;
    }
    
    /// <summary>
    /// Test whether TemplateTarget should be serialized
    /// </summary>
    public virtual bool ShouldSerializeTemplateTarget()
    {
        return (_templateTarget != null);
    }
    
    /// <summary>
    /// Test whether DataSource should be serialized
    /// </summary>
    public virtual bool ShouldSerializeDataSource()
    {
        return (_dataSource != null);
    }
}
}
#pragma warning restore
