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
/// This is the base type for all subtypes that require a unique URI identifier.
/// </summary>
[XmlInclude(typeof(FormDesignType))]
[XmlInclude(typeof(DemogFormDesignType))]
[XmlInclude(typeof(InjectFormType))]
[XmlInclude(typeof(ActInjectType))]
[XmlInclude(typeof(DisplayedType))]
[XmlInclude(typeof(ButtonItemType))]
[XmlInclude(typeof(ListItemBaseType))]
[XmlInclude(typeof(ListItemType))]
[XmlInclude(typeof(RepeatingType))]
[XmlInclude(typeof(QuestionItemBaseType))]
[XmlInclude(typeof(QuestionItemType))]
[XmlInclude(typeof(SectionBaseType))]
[XmlInclude(typeof(SectionItemType))]
[XmlInclude(typeof(DataElementType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("IdentifiedExtensionType")]
public abstract partial class IdentifiedExtensionType : ExtensionBaseType
{
    #region Private fields
    private string _id;
    private string _baseURI;
    #endregion
    
    [XmlAttribute(DataType="anyURI")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string ID
    {
        get
        {
            return _id;
        }
        set
        {
            if ((_id == value))
            {
                return;
            }
            if (((_id == null) 
                        || (_id.Equals(value) != true)))
            {
                _id = value;
                OnPropertyChanged("ID", value);
            }
        }
    }
    
    [XmlAttribute(DataType="anyURI")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string baseURI
    {
        get
        {
            return _baseURI;
        }
        set
        {
            if ((_baseURI == value))
            {
                return;
            }
            if (((_baseURI == null) 
                        || (_baseURI.Equals(value) != true)))
            {
                _baseURI = value;
                OnPropertyChanged("baseURI", value);
            }
        }
    }
    
    /// <summary>
    /// Test whether ID should be serialized
    /// </summary>
    public virtual bool ShouldSerializeID()
    {
        return !string.IsNullOrEmpty(ID);
    }
    
    /// <summary>
    /// Test whether baseURI should be serialized
    /// </summary>
    public virtual bool ShouldSerializebaseURI()
    {
        return !string.IsNullOrEmpty(baseURI);
    }
}
}
#pragma warning restore