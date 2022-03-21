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
/// A hyperlink to an Internet endpoint such as a web page or web service.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("LinkType")]
public partial class LinkType : ExtensionBaseType
{
    private RichTextType _linkText;
    private anyURI_Stype _linkURI;
    private bool _linkTextSpecified;
    private bool _linkURISpecified;
    /// <summary>
    /// A description of the URI link, usually for display purposes.
    /// </summary>
    [XmlElement(Order=0)]
    [JsonProperty(Order=0, NullValueHandling=NullValueHandling.Ignore)]
    public virtual RichTextType LinkText
    {
        get
        {
            return _linkText;
        }
        set
        {
            if ((_linkText == value))
            {
                return;
            }
            if (((_linkText == null) 
                        || (_linkText.Equals(value) != true)))
            {
                _linkText = value;
                OnPropertyChanged("LinkText", value);
            }
        }
    }
    
    /// <summary>
    /// Link to external information.
    /// </summary>
    [XmlElement(Order=1)]
    [RequiredAttribute()]
    [JsonProperty(Order=1, NullValueHandling=NullValueHandling.Ignore)]
    public virtual anyURI_Stype LinkURI
    {
        get
        {
            return _linkURI;
        }
        set
        {
            if ((_linkURI == value))
            {
                return;
            }
            if (((_linkURI == null) 
                        || (_linkURI.Equals(value) != true)))
            {
                ValidationContext validatorPropContext = new ValidationContext(this, null, null);
                validatorPropContext.MemberName = "LinkURI";
                Validator.ValidateProperty(value, validatorPropContext);
                _linkURI = value;
                OnPropertyChanged("LinkURI", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool LinkTextSpecified
    {
        get
        {
            return _linkTextSpecified;
        }
        set
        {
            _linkTextSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool LinkURISpecified
    {
        get
        {
            return _linkURISpecified;
        }
        set
        {
            _linkURISpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether LinkText should be serialized
    /// </summary>
    public virtual bool ShouldSerializeLinkText()
    {
        return (LinkText != null);
    }
    
    /// <summary>
    /// Test whether LinkURI should be serialized
    /// </summary>
    public virtual bool ShouldSerializeLinkURI()
    {
        return (LinkURI != null);
    }
}
}
#pragma warning restore
