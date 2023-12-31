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
/// This type provides data about the current and original registries that host the template or package, and also provides information about the status of the template/package within the current registry.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("RegistryType")]
public partial class RegistryType : ExtensionBaseType
{
    #region Private fields
    private RegistrySummaryType _originalRegistry;
    private RegistrySummaryType _currentRegistry;
    private RegisteredItemType _registrationStatus;
    #endregion
    
    [XmlElement(Order=0)]
    [JsonProperty(Order=0, NullValueHandling=NullValueHandling.Ignore)]
    public virtual RegistrySummaryType OriginalRegistry
    {
        get
        {
            return _originalRegistry;
        }
        set
        {
            if ((_originalRegistry == value))
            {
                return;
            }
            if (((_originalRegistry == null) 
                        || (_originalRegistry.Equals(value) != true)))
            {
                _originalRegistry = value;
                OnPropertyChanged("OriginalRegistry", value);
            }
        }
    }
    
    [XmlElement(Order=1)]
    [RequiredAttribute()]
    [JsonProperty(Order=1, NullValueHandling=NullValueHandling.Ignore)]
    public virtual RegistrySummaryType CurrentRegistry
    {
        get
        {
            return _currentRegistry;
        }
        set
        {
            if ((_currentRegistry == value))
            {
                return;
            }
            if (((_currentRegistry == null) 
                        || (_currentRegistry.Equals(value) != true)))
            {
                ValidationContext validatorPropContext = new ValidationContext(this, null, null);
                validatorPropContext.MemberName = "CurrentRegistry";
                Validator.ValidateProperty(value, validatorPropContext);
                _currentRegistry = value;
                OnPropertyChanged("CurrentRegistry", value);
            }
        }
    }
    
    [XmlElement(Order=2)]
    [JsonProperty(Order=2, NullValueHandling=NullValueHandling.Ignore)]
    public virtual RegisteredItemType RegistrationStatus
    {
        get
        {
            return _registrationStatus;
        }
        set
        {
            if ((_registrationStatus == value))
            {
                return;
            }
            if (((_registrationStatus == null) 
                        || (_registrationStatus.Equals(value) != true)))
            {
                _registrationStatus = value;
                OnPropertyChanged("RegistrationStatus", value);
            }
        }
    }
    
    /// <summary>
    /// Test whether OriginalRegistry should be serialized
    /// </summary>
    public virtual bool ShouldSerializeOriginalRegistry()
    {
        return (_originalRegistry != null);
    }
    
    /// <summary>
    /// Test whether CurrentRegistry should be serialized
    /// </summary>
    public virtual bool ShouldSerializeCurrentRegistry()
    {
        return (_currentRegistry != null);
    }
    
    /// <summary>
    /// Test whether RegistrationStatus should be serialized
    /// </summary>
    public virtual bool ShouldSerializeRegistrationStatus()
    {
        return (_registrationStatus != null);
    }
}
}
#pragma warning restore
