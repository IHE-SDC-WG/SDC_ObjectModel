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
/// SDC datatypes for Data Entry (DE), based mostly on W3C specifications. Uses baseAttributes  and Extension capability to enhance the list of Data Types. Includes additonal metadata to specify data input restrictions for data entry forms, and to aid in validation of IHE RFD SubmitForm responses in XML instance documents.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("DataTypesDateTime_DEType")]
public partial class DataTypesDateTime_DEType : ExtensionBaseType
{
    private BaseType _item;
    private bool _itemSpecified;
    [XmlElement("dateTime", typeof(dateTimeStamp_DEtype), IsNullable=true, Order=0)]
    [XmlElement("duration", typeof(duration_DEtype), IsNullable=true, Order=0)]
    [XmlElement("gMonthDay", typeof(gMonthDay_DEtype), IsNullable=true, Order=0)]
    [XmlElement("gYear", typeof(gYear_DEtype), IsNullable=true, Order=0)]
    [XmlElement("gYearMonth", typeof(gMonth_DEtype), IsNullable=true, Order=0)]
    [XmlElement("time", typeof(time_DEtype), IsNullable=true, Order=0)]
    [XmlElement("yearMonthDuration", typeof(yearMonthDuration_DEtype), IsNullable=true, Order=0)]
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
    
    /// <summary>
    /// Test whether Item should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItem()
    {
        return (Item != null);
    }
}
}
#pragma warning restore
