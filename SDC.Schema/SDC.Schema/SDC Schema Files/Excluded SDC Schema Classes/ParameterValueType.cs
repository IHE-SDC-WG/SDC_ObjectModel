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
/// This type describes strongly-typed parameters used in functions and web services.  Values are hard-coded as constants in the XML instance document.  They are not user-entered values.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("ParameterValueType")]
public partial class ParameterValueType : DataTypes_SType
{
    #region Private fields
    private string _paramName;
    #endregion
    
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
    /// Test whether paramName should be serialized
    /// </summary>
    public virtual bool ShouldSerializeparamName()
    {
        return !string.IsNullOrEmpty(paramName);
    }
}
}
#pragma warning restore
