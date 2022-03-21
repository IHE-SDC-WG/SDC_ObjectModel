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
/// MOVED from SDCDataTypes:
/// SDC datatypes in Simple (S) format, based mostly on W3C specifications.  Uses baseAttributes and Extension capability to enhance the list of Data Types.        **CHECK for ERRORS and completeness**
/// </summary>
[XmlInclude(typeof(ParameterValueType))]
[XmlInclude(typeof(PropertyType1))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("DataTypes_SType")]
public partial class DataTypes_SType : ExtensionBaseType
{
    #region Private fields
    private bool _shouldSerializeItemElementName;
    private BaseType _item;
    private ItemChoiceType _itemElementName;
    private bool _itemSpecified;
    private bool _itemElementNameSpecified;
    #endregion
    
    [XmlElement("HTML", typeof(HTML_Stype), IsNullable=true, Order=0)]
    [XmlElement("XML", typeof(XML_Stype), IsNullable=true, Order=0)]
    [XmlElement("anyType", typeof(anyType_DEtype), IsNullable=true, Order=0)]
    [XmlElement("anyURI", typeof(anyURI_Stype), IsNullable=true, Order=0)]
    [XmlElement("base64Binary", typeof(base64Binary_Stype), IsNullable=true, Order=0)]
    [XmlElement("boolean", typeof(boolean_Stype), IsNullable=true, Order=0)]
    [XmlElement("byte", typeof(byte_Stype), IsNullable=true, Order=0)]
    [XmlElement("date", typeof(date_Stype), IsNullable=true, Order=0)]
    [XmlElement("dateTime", typeof(dateTimeStamp_Stype), IsNullable=true, Order=0)]
    [XmlElement("dateTimeStamp", typeof(dateTimeStamp_Stype), IsNullable=true, Order=0)]
    [XmlElement("decimal", typeof(decimal_Stype), IsNullable=true, Order=0)]
    [XmlElement("double", typeof(double_Stype), IsNullable=true, Order=0)]
    [XmlElement("duration", typeof(duration_Stype), IsNullable=true, Order=0)]
    [XmlElement("float", typeof(float_Stype), IsNullable=true, Order=0)]
    [XmlElement("gDay", typeof(gDay_Stype), IsNullable=true, Order=0)]
    [XmlElement("gMonth", typeof(gMonth_Stype), IsNullable=true, Order=0)]
    [XmlElement("gMonthDay", typeof(gMonthDay_Stype), IsNullable=true, Order=0)]
    [XmlElement("gYear", typeof(gYear_Stype), IsNullable=true, Order=0)]
    [XmlElement("gYearMonth", typeof(gMonth_Stype), IsNullable=true, Order=0)]
    [XmlElement("hexBinary", typeof(hexBinary_Stype), IsNullable=true, Order=0)]
    [XmlElement("int", typeof(int_Stype), IsNullable=true, Order=0)]
    [XmlElement("integer", typeof(integer_Stype), IsNullable=true, Order=0)]
    [XmlElement("long", typeof(long_Stype), IsNullable=true, Order=0)]
    [XmlElement("negativeInteger", typeof(negativeInteger_Stype), IsNullable=true, Order=0)]
    [XmlElement("nonNegativeInteger", typeof(nonNegativeInteger_Stype), IsNullable=true, Order=0)]
    [XmlElement("nonPositiveInteger", typeof(nonPositiveInteger_Stype), IsNullable=true, Order=0)]
    [XmlElement("positiveInteger", typeof(positiveInteger_Stype), IsNullable=true, Order=0)]
    [XmlElement("short", typeof(short_Stype), IsNullable=true, Order=0)]
    [XmlElement("string", typeof(string_Stype), IsNullable=true, Order=0)]
    [XmlElement("time", typeof(time_Stype), IsNullable=true, Order=0)]
    [XmlElement("unsignedByte", typeof(unsignedByte_Stype), IsNullable=true, Order=0)]
    [XmlElement("unsignedInt", typeof(unsignedInt_Stype), IsNullable=true, Order=0)]
    [XmlElement("unsignedLong", typeof(unsignedLong_Stype), IsNullable=true, Order=0)]
    [XmlElement("unsignedShort", typeof(unsignedShort_Stype), IsNullable=true, Order=0)]
    [XmlElement("yearMonthDuration", typeof(yearMonthDuration_Stype), IsNullable=true, Order=0)]
    [XmlChoiceIdentifierAttribute("ItemElementName")]
    public virtual BaseType Item
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
    public virtual ItemChoiceType ItemElementName
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
        return (_itemElementName != default(ItemChoiceType));
    }
    
    /// <summary>
    /// Test whether Item should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItem()
    {
        return (_item != null);
    }
}
}
#pragma warning restore
