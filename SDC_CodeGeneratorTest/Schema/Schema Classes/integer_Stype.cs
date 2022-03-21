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

[XmlInclude(typeof(integer_DEtype))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("integer_Stype")]
public partial class integer_Stype : BaseType
{
    #region Private fields
    private bool _shouldSerializequantEnum;
    private decimal _val;
    private bool valFieldSpecified;
    private dtQuantEnum _quantEnum;
    private bool _quantEnumSpecified;
    #endregion
    
    /// <summary>
    /// integer_Stype class constructor
    /// </summary>
    public integer_Stype()
    {
        _quantEnum = dtQuantEnum.EQ;
    }
    
    [XmlAttribute]
    [FractionDigitsAttribute(0)]
    [MaxDigitsAttribute(29)]
    [RangeAttribute(-7.9228162514264338E+28D, 7.9228162514264338E+28D)]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual decimal val
    {
        get
        {
            return _val;
        }
        set
        {
            if ((_val.Equals(value) != true))
            {
                ValidationContext validatorPropContext = new ValidationContext(this, null, null);
                validatorPropContext.MemberName = "val";
                Validator.ValidateProperty(value, validatorPropContext);
                _val = value;
                OnPropertyChanged("val", value);
            }
        }
    }
    
    [XmlIgnore]
    public virtual bool valSpecified
    {
        get
        {
            return valFieldSpecified;
        }
        set
        {
            if ((valFieldSpecified.Equals(value) != true))
            {
                valFieldSpecified = value;
                OnPropertyChanged("valSpecified", value);
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
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool quantEnumSpecified
    {
        get
        {
            return _quantEnumSpecified;
        }
        set
        {
            _quantEnumSpecified = value;
        }
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
}
}
#pragma warning restore
