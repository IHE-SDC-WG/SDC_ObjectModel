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
/// NEW:
/// SDC datatypes in Simple (S) format, based mostly on W3C specifications.  Uses baseAttributes and Extension capability to enhance the list of Data Types.        **CHECK for ERRORS and completeness**
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("DataTypesDateTime_SType")]
public partial class DataTypesDateTime_SType : ExtensionBaseType
{
    #region Private fields
    private bool _shouldSerializeItemElementName;
    private object _item;
    private ItemChoiceType3 _itemElementName;
    private bool _itemSpecified;
    private bool _itemElementNameSpecified;
    #endregion
    
    [XmlElement("List000", typeof(object), Order=0)]
    [XmlElement("date", typeof(date_Stype), IsNullable=true, Order=0)]
    [XmlElement("dateTime", typeof(dateTimeStamp_Stype), IsNullable=true, Order=0)]
    [XmlElement("dateTimeStamp", typeof(dateTimeStamp_Stype), IsNullable=true, Order=0)]
    [XmlElement("duration", typeof(duration_Stype), IsNullable=true, Order=0)]
    [XmlElement("gDay", typeof(gDay_Stype), IsNullable=true, Order=0)]
    [XmlElement("gMonth", typeof(gMonth_Stype), IsNullable=true, Order=0)]
    [XmlElement("gMonthDay", typeof(gMonthDay_Stype), IsNullable=true, Order=0)]
    [XmlElement("gYear", typeof(gYear_Stype), IsNullable=true, Order=0)]
    [XmlElement("gYearMonth", typeof(gMonth_Stype), IsNullable=true, Order=0)]
    [XmlElement("time", typeof(time_Stype), IsNullable=true, Order=0)]
    [XmlElement("yearMonthDuration", typeof(yearMonthDuration_Stype), IsNullable=true, Order=0)]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public virtual object Item
    {
        get
        {
            return _item;
        }
        set
        {
            if ((_item == value))
            {
                return;
            }
            if (((_item == null) 
                        || (_item.Equals(value) != true)))
            {
                _item = value;
                OnPropertyChanged("Item", value);
            }
        }
    }
    
    [XmlElement(Order=1)]
    [XmlIgnore]
    public virtual ItemChoiceType3 ItemElementName
    {
        get
        {
            return _itemElementName;
        }
        set
        {
            if ((_itemElementName.Equals(value) != true))
            {
                _itemElementName = value;
                OnPropertyChanged("ItemElementName", value);
            }
            _shouldSerializeItemElementName = true;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool ItemSpecified
    {
        get
        {
            return _itemSpecified;
        }
        set
        {
            _itemSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool ItemElementNameSpecified
    {
        get
        {
            return _itemElementNameSpecified;
        }
        set
        {
            _itemElementNameSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether ItemElementName should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItemElementName()
    {
        if (_shouldSerializeItemElementName)
        {
            return true;
        }
        return (_itemElementName != default(ItemChoiceType3));
    }
}
}
#pragma warning restore