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
/// Contains information about a registered package, including a description of the package contents and purpose (PackageDescription), information about the registry that contains the package XML (RegistryData), and information about the package file characteristics (TemplateFile).
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true, Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("TemplateAdminTypeDigitalSignature")]
public partial class TemplateAdminTypeDigitalSignature : ExtensionBaseType
{
    #region Private fields
    private TemplateAdminTypeDigitalSignaturePackageSignature _packageSignature;
    private TemplateAdminTypeDigitalSignatureSignatureProperties _signatureProperties;
    private bool _packageSignatureSpecified;
    private bool _signaturePropertiesSpecified;
    #endregion
    
    [XmlElement(Order=0)]
    [JsonProperty(Order=0, NullValueHandling=NullValueHandling.Ignore)]
    public virtual TemplateAdminTypeDigitalSignaturePackageSignature PackageSignature
    {
        get
        {
            return _packageSignature;
        }
        set
        {
            if ((_packageSignature == value))
            {
                return;
            }
            if (((_packageSignature == null) 
                        || (_packageSignature.Equals(value) != true)))
            {
                _packageSignature = value;
                OnPropertyChanged("PackageSignature", value);
            }
        }
    }
    
    [XmlElement(Order=1)]
    [JsonProperty(Order=1, NullValueHandling=NullValueHandling.Ignore)]
    public virtual TemplateAdminTypeDigitalSignatureSignatureProperties SignatureProperties
    {
        get
        {
            return _signatureProperties;
        }
        set
        {
            if ((_signatureProperties == value))
            {
                return;
            }
            if (((_signatureProperties == null) 
                        || (_signatureProperties.Equals(value) != true)))
            {
                _signatureProperties = value;
                OnPropertyChanged("SignatureProperties", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool PackageSignatureSpecified
    {
        get
        {
            return _packageSignatureSpecified;
        }
        set
        {
            _packageSignatureSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool SignaturePropertiesSpecified
    {
        get
        {
            return _signaturePropertiesSpecified;
        }
        set
        {
            _signaturePropertiesSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether PackageSignature should be serialized
    /// </summary>
    public virtual bool ShouldSerializePackageSignature()
    {
        return (_packageSignature != null);
    }
    
    /// <summary>
    /// Test whether SignatureProperties should be serialized
    /// </summary>
    public virtual bool ShouldSerializeSignatureProperties()
    {
        return (_signatureProperties != null);
    }
}
}
#pragma warning restore
