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
/// Inject a form or part of a form at the specified location. The
/// injected section may come from the current form.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("ActInjectType")]
public partial class ActInjectType : InjectFormType
{
    private string _targetNames;
    private bool _targetNamesSpecified;
    /// <summary>
    /// The names of the parent items that will have the form (or
    /// form section) injected as child node(s).
    /// </summary>
    [XmlAttribute(DataType="NMTOKENS")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string targetNames
    {
        get
        {
            return _targetNames;
        }
        set
        {
            if ((_targetNames == value))
            {
                return;
            }
            if (((_targetNames == null) 
                        || (_targetNames.Equals(value) != true)))
            {
                _targetNames = value;
                OnPropertyChanged("targetNames", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool targetNamesSpecified
    {
        get
        {
            return _targetNamesSpecified;
        }
        set
        {
            _targetNamesSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether targetNames should be serialized
    /// </summary>
    public virtual bool ShouldSerializetargetNames()
    {
        return !string.IsNullOrEmpty(targetNames);
    }
}
}
#pragma warning restore
