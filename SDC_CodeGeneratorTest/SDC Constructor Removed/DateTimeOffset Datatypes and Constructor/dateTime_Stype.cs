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
/// DateTime Data Type The dateTime data type is used to specify a date
/// and a time.
/// The dateTime is specified in the following form
/// "YYYY-MM-DDThh:mm:ss" where:
/// YYYY indicates the year
/// MM indicates the month
/// DD indicates the day
/// T indicates the start of the required time section
/// hh indicates the hour mm indicates the minute
/// ss indicates the second
/// 
/// Time Zones To specify a time zone, you can either enter a time
/// in UTC time by adding a "Z" behind the time -
/// like this: 09:30:10Z
/// or you can specify an offset from the UTC time
/// by adding a positive or negative time behind the
/// time - like this: 09:30:10-06:00 or 09:30:10+06:00.
/// </summary>
[XmlInclude(typeof(dateTime_DEtype))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("dateTime_Stype")]
public partial class dateTime_Stype : BaseType
{
    #region Private fields
    private bool _shouldSerializequantEnum;
    private bool _shouldSerializeval;
    private System.DateTime _val;
    private string _timeZone;
    private dtQuantEnum _quantEnum;
    #endregion
    
    ///// <summary>
    ///// dateTime_Stype class constructor
    ///// </summary>
    //public dateTime_Stype()
    //{
    //    _quantEnum = dtQuantEnum.EQ;
    //}
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual System.DateTime val
    {
        get
        {
            return _val;
        }
        set
        {
            if ((_val.Equals(value) != true))
            {
                _val = value;
                OnPropertyChanged("val", value);
            }
            _shouldSerializeval = true;
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string timeZone
    {
        get
        {
            return _timeZone;
        }
        set
        {
            if ((_timeZone == value))
            {
                return;
            }
            if (((_timeZone == null) 
                        || (_timeZone.Equals(value) != true)))
            {
                _timeZone = value;
                OnPropertyChanged("timeZone", value);
            }
        }
    }
    
    [XmlAttribute]
    [DefaultValue(dtQuantEnum.EQ)]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public virtual dtQuantEnum quantEnum
    {
        get
        {
            return _quantEnum;
        }
        set
        {
            if ((_quantEnum.Equals(value) != true))
            {
                _quantEnum = value;
                OnPropertyChanged("quantEnum", value);
            }
            _shouldSerializequantEnum = true;
        }
    }
    
    /// <summary>
    /// Test whether val should be serialized
    /// </summary>
    public virtual bool ShouldSerializeval()
    {
        if (_shouldSerializeval)
        {
            return true;
        }
        return (_val != default(System.DateTime));
    }
    
    /// <summary>
    /// Test whether quantEnum should be serialized
    /// </summary>
    public virtual bool ShouldSerializequantEnum()
    {
        if (_shouldSerializequantEnum)
        {
            return true;
        }
        return (_quantEnum != default(dtQuantEnum));
    }
    
    /// <summary>
    /// Test whether timeZone should be serialized
    /// </summary>
    public virtual bool ShouldSerializetimeZone()
    {
        return !string.IsNullOrEmpty(timeZone);
    }
}
}
#pragma warning restore
