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
/// This type provides information about an Applications Programming Interface (API)
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(AnonymousType=true, Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("InterfaceTypeFields")]
public partial class InterfaceTypeFields : BaseType
{
    private List<InterfaceTypeFieldsField> _field;
    private bool _fieldSpecified;
    [XmlElement("Field", Order=0)]
    [JsonProperty(Order=0, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<InterfaceTypeFieldsField> Field
    {
        get
        {
            return _field;
        }
        set
        {
            if ((_field == value))
            {
                return;
            }
            if (((_field == null) 
                        || (_field.Equals(value) != true)))
            {
                _field = value;
                OnPropertyChanged("Field", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool FieldSpecified
    {
        get
        {
            return _fieldSpecified;
        }
        set
        {
            _fieldSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether Field should be serialized
    /// </summary>
    public virtual bool ShouldSerializeField()
    {
        return Field != null && Field.Count > 0;
    }
}
}
#pragma warning restore
