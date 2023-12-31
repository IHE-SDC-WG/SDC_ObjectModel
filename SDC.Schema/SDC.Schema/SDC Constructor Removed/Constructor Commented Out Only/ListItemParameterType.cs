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
/// Parameters are named, uniquely identifiable, instances of form attributes (e.g., @selected).  They are fed into expressions, which are then used as part of a rule within the form.  Parameters can also be fed into URI expressions used inside a Lookup Endpoint, i.e., URIs that call web services to supply list items (e.g., a list of SNOMED-coded items) to a question.
/// 
/// Parameters using this construct are derived from other locations in the XML instance document, including user-entered Response values.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("ListItemParameterType")]
public partial class ListItemParameterType : ExtensionBaseType
{
    #region Private fields
    private string _dataType;
    private string _paramName;
    private string _sourceQuestionName;
    private string _listItemAttribute;
    #endregion
    
    ///// <summary>
    ///// ListItemParameterType class constructor
    ///// </summary>
    //public ListItemParameterType()
    //{
    //    _dataType = "string";
    //    _listItemAttribute = "associatedValue";
    //}
    
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
    
    /// <summary>
    /// A locally useful name that describes the parameter
    /// </summary>
    [XmlAttribute(DataType="NCName")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string paramName
    {
        get
        {
            return _paramName;
        }
        set
        {
            if ((_paramName == value))
            {
                return;
            }
            if (((_paramName == null) 
                        || (_paramName.Equals(value) != true)))
            {
                _paramName = value;
                OnPropertyChanged("paramName", value);
            }
        }
    }
    
    /// <summary>
    /// The @name of a Question in the current form.
    /// </summary>
    [XmlAttribute(DataType="NCName")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string sourceQuestionName
    {
        get
        {
            return _sourceQuestionName;
        }
        set
        {
            if ((_sourceQuestionName == value))
            {
                return;
            }
            if (((_sourceQuestionName == null) 
                        || (_sourceQuestionName.Equals(value) != true)))
            {
                _sourceQuestionName = value;
                OnPropertyChanged("sourceQuestionName", value);
            }
        }
    }
    
    /// <summary>
    /// The name of any XML attribute on a ListItem.  The property value is the parameter's value.  If the Question is multi-select, a list of attribute values is returned.
    /// </summary>
    [XmlAttribute(DataType="NCName")]
    [DefaultValue("associatedValue")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string listItemAttribute
    {
        get
        {
            return _listItemAttribute;
        }
        set
        {
            if ((_listItemAttribute == value))
            {
                return;
            }
            if (((_listItemAttribute == null) 
                        || (_listItemAttribute.Equals(value) != true)))
            {
                _listItemAttribute = value;
                OnPropertyChanged("listItemAttribute", value);
            }
        }
    }
    
    /// <summary>
    /// Test whether dataType should be serialized
    /// </summary>
    public virtual bool ShouldSerializedataType()
    {
        return !string.IsNullOrEmpty(dataType);
    }
    
    /// <summary>
    /// Test whether paramName should be serialized
    /// </summary>
    public virtual bool ShouldSerializeparamName()
    {
        return !string.IsNullOrEmpty(paramName);
    }
    
    /// <summary>
    /// Test whether sourceQuestionName should be serialized
    /// </summary>
    public virtual bool ShouldSerializesourceQuestionName()
    {
        return !string.IsNullOrEmpty(sourceQuestionName);
    }
    
    /// <summary>
    /// Test whether listItemAttribute should be serialized
    /// </summary>
    public virtual bool ShouldSerializelistItemAttribute()
    {
        return !string.IsNullOrEmpty(listItemAttribute);
    }
}
}
#pragma warning restore
