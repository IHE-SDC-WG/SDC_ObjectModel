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
/// Programming code or pseudocode that describes a calculation.  THe code returns a value of the data type required by the parent Response field.  To assist with enabling the code in the form, the referenced form items and properties should be referenced by @name under the parameters elemeent.  It is possible to add mulitple calculation expressions to produce equivalent results using different programming languages and URIs.  The @ type attribute may be used to distinguish between them.  An Extension may be used instead of or along with an Expression and Parameters list.  Expressions may populate Responses that are set to @readOnly = "true" to ensure that all responses are calculated and not latered by the user.  Alternatively, the user may change a value created by (or instead of) the Expression.
/// </summary>
[XmlInclude(typeof(ActSetAttrValueScriptType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("ScriptCodeAnyType")]
public partial class ScriptCodeAnyType : ScriptCodeBaseType
{
    private string _dataType;
    private bool _dataTypeSpecified;
    /// <summary>
    /// ScriptCodeAnyType class constructor
    /// </summary>
    public ScriptCodeAnyType()
    {
        _dataType = "string";
    }
    
    [XmlAttribute]
    [DefaultValue("string")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string dataType
    {
        get
        {
            return _dataType;
        }
        set
        {
            if ((_dataType == value))
            {
                return;
            }
            if (((_dataType == null) 
                        || (_dataType.Equals(value) != true)))
            {
                _dataType = value;
                OnPropertyChanged("dataType", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool dataTypeSpecified
    {
        get
        {
            return _dataTypeSpecified;
        }
        set
        {
            _dataTypeSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether dataType should be serialized
    /// </summary>
    public virtual bool ShouldSerializedataType()
    {
        return !string.IsNullOrEmpty(dataType);
    }
}
}
#pragma warning restore
