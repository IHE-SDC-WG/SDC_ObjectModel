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
/// information about where to submit a completed form
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("SubmissionRuleType")]
public partial class SubmissionRuleType : ExtensionBaseType
{
    #region Private fields
    private List<DestinationType> _destination;
    private string_Stype _ruleDescription;
    private string _formID;
    private string _ruleID;
    private bool _destinationSpecified;
    private bool _ruleDescriptionSpecified;
    private bool _formIDSpecified;
    private bool _ruleIDSpecified;
    #endregion
    
    [XmlElement("Destination", Order=0)]
    [RequiredAttribute()]
    [JsonProperty(Order=0, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<DestinationType> Destination
    {
        get
        {
            return _destination;
        }
        set
        {
            if ((_destination == value))
            {
                return;
            }
            if (((_destination == null) 
                        || (_destination.Equals(value) != true)))
            {
                ValidationContext validatorPropContext = new ValidationContext(this, null, null);
                validatorPropContext.MemberName = "Destination";
                Validator.ValidateProperty(value, validatorPropContext);
                _destination = value;
                OnPropertyChanged("Destination", value);
            }
        }
    }
    
    [XmlElement(Order=1)]
    [JsonProperty(Order=1, NullValueHandling=NullValueHandling.Ignore)]
    public virtual string_Stype RuleDescription
    {
        get
        {
            return _ruleDescription;
        }
        set
        {
            if ((_ruleDescription == value))
            {
                return;
            }
            if (((_ruleDescription == null) 
                        || (_ruleDescription.Equals(value) != true)))
            {
                _ruleDescription = value;
                OnPropertyChanged("RuleDescription", value);
            }
        }
    }
    
    [XmlAttribute(DataType="anyURI")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string formID
    {
        get
        {
            return _formID;
        }
        set
        {
            if ((_formID == value))
            {
                return;
            }
            if (((_formID == null) 
                        || (_formID.Equals(value) != true)))
            {
                _formID = value;
                OnPropertyChanged("formID", value);
            }
        }
    }
    
    [XmlAttribute(DataType="anyURI")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string ruleID
    {
        get
        {
            return _ruleID;
        }
        set
        {
            if ((_ruleID == value))
            {
                return;
            }
            if (((_ruleID == null) 
                        || (_ruleID.Equals(value) != true)))
            {
                _ruleID = value;
                OnPropertyChanged("ruleID", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool DestinationSpecified
    {
        get
        {
            return _destinationSpecified;
        }
        set
        {
            _destinationSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool RuleDescriptionSpecified
    {
        get
        {
            return _ruleDescriptionSpecified;
        }
        set
        {
            _ruleDescriptionSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool formIDSpecified
    {
        get
        {
            return _formIDSpecified;
        }
        set
        {
            _formIDSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool ruleIDSpecified
    {
        get
        {
            return _ruleIDSpecified;
        }
        set
        {
            _ruleIDSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether Destination should be serialized
    /// </summary>
    public virtual bool ShouldSerializeDestination()
    {
        return Destination != null && Destination.Count > 0;
    }
    
    /// <summary>
    /// Test whether RuleDescription should be serialized
    /// </summary>
    public virtual bool ShouldSerializeRuleDescription()
    {
        return (_ruleDescription != null);
    }
    
    /// <summary>
    /// Test whether formID should be serialized
    /// </summary>
    public virtual bool ShouldSerializeformID()
    {
        return !string.IsNullOrEmpty(formID);
    }
    
    /// <summary>
    /// Test whether ruleID should be serialized
    /// </summary>
    public virtual bool ShouldSerializeruleID()
    {
        return !string.IsNullOrEmpty(ruleID);
    }
}
}
#pragma warning restore