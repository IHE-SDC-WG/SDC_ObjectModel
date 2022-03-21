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

/// <summary>
/// Show a report preview, based on data in the current form. The
/// following parameter may be used: reportID: points to a report definition in SDC
/// format.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("ActPreviewReportType")]
public partial class ActPreviewReportType : ExtensionBaseType
{
    private string _reportID;
    private string _displayState;
    private bool _reportIDSpecified;
    private bool _displayStateSpecified;
    /// <summary>
    /// This ID represents the report to be
    /// displayed.
    /// </summary>
    [XmlAttribute(DataType="anyURI")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string reportID
    {
        get
        {
            return _reportID;
        }
        set
        {
            if ((_reportID == value))
            {
                return;
            }
            if (((_reportID == null) 
                        || (_reportID.Equals(value) != true)))
            {
                _reportID = value;
                OnPropertyChanged("reportID", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string displayState
    {
        get
        {
            return _displayState;
        }
        set
        {
            if ((_displayState == value))
            {
                return;
            }
            if (((_displayState == null) 
                        || (_displayState.Equals(value) != true)))
            {
                _displayState = value;
                OnPropertyChanged("displayState", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool reportIDSpecified
    {
        get
        {
            return _reportIDSpecified;
        }
        set
        {
            _reportIDSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool displayStateSpecified
    {
        get
        {
            return _displayStateSpecified;
        }
        set
        {
            _displayStateSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether reportID should be serialized
    /// </summary>
    public virtual bool ShouldSerializereportID()
    {
        return !string.IsNullOrEmpty(reportID);
    }
    
    /// <summary>
    /// Test whether displayState should be serialized
    /// </summary>
    public virtual bool ShouldSerializedisplayState()
    {
        return !string.IsNullOrEmpty(displayState);
    }
}
}
#pragma warning restore
