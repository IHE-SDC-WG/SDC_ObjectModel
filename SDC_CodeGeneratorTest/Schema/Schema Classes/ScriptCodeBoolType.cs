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
/// Programming code or pseudocode that describes a calculation.  The code returns a value of the data type required by the parent Response field.  To assist with enabling the code in the form, the referenced form items and properties should be referenced by @name under the parameters elemeent.  It is possible to add mulitple calculation expressions to produce equivalent results using different programming languages and URIs.  The @ type attribute may be used to distinguish between them.  An Extension may be used instead of or along with an Expression and Parameters list.  Expressions may populate Responses that are set to @readOnly = "true" to ensure that all responses are calculated and not latered by the user.  Alternatively, the user may change a value created by (or instead of) the Expression.
/// </summary>
[XmlInclude(typeof(ScriptBoolFuncActionType))]
[XmlInclude(typeof(ActSetBoolAttributeValueCodeType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("ScriptCodeBoolType")]
public partial class ScriptCodeBoolType : ScriptCodeBaseType
{
    #region Private fields
    private bool _not;
    private string _validationMessage;
    private bool _notSpecified;
    private bool _validationMessageSpecified;
    #endregion
    
    /// <summary>
    /// ScriptCodeBoolType class constructor
    /// </summary>
    public ScriptCodeBoolType()
    {
        _not = false;
    }
    
    /// <summary>
    /// If @not="true" then the logical value of the conditions of the parent element is negated; true becomes false and false becomes true.
    /// </summary>
    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool not
    {
        get
        {
            return _not;
        }
        set
        {
            if ((_not.Equals(value) != true))
            {
                _not = value;
                OnPropertyChanged("not", value);
            }
        }
    }
    
    /// <summary>
    /// Optional message that appears when the rule evaluates to true
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string validationMessage
    {
        get
        {
            return _validationMessage;
        }
        set
        {
            if ((_validationMessage == value))
            {
                return;
            }
            if (((_validationMessage == null) 
                        || (_validationMessage.Equals(value) != true)))
            {
                _validationMessage = value;
                OnPropertyChanged("validationMessage", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool notSpecified
    {
        get
        {
            return _notSpecified;
        }
        set
        {
            _notSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool validationMessageSpecified
    {
        get
        {
            return _validationMessageSpecified;
        }
        set
        {
            _validationMessageSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether validationMessage should be serialized
    /// </summary>
    public virtual bool ShouldSerializevalidationMessage()
    {
        return !string.IsNullOrEmpty(validationMessage);
    }
}
}
#pragma warning restore
