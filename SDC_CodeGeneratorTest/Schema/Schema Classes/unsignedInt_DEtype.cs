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

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("unsignedInt_DEtype")]
public partial class unsignedInt_DEtype : unsignedInt_Stype
{
    #region Private fields
    private uint _minInclusive;
    private bool minInclusiveFieldSpecified;
    private uint _maxInclusive;
    private bool maxInclusiveFieldSpecified;
    private uint _minExclusive;
    private bool minExclusiveFieldSpecified;
    private uint _maxExclusive;
    private bool maxExclusiveFieldSpecified;
    private byte _totalDigits;
    private bool totalDigitsFieldSpecified;
    private string _mask;
    private bool _allowGT;
    private bool _allowGTE;
    private bool _allowLT;
    private bool _allowLTE;
    private bool _allowAPPROX;
    private bool _maskSpecified;
    private bool _allowGTSpecified;
    private bool _allowGTESpecified;
    private bool _allowLTSpecified;
    private bool _allowLTESpecified;
    private bool _allowAPPROXSpecified;
    #endregion
    
    /// <summary>
    /// unsignedInt_DEtype class constructor
    /// </summary>
    public unsignedInt_DEtype()
    {
        _allowGT = false;
        _allowGTE = false;
        _allowLT = false;
        _allowLTE = false;
        _allowAPPROX = false;
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual uint minInclusive
    {
        get
        {
            return _minInclusive;
        }
        set
        {
            if ((_minInclusive.Equals(value) != true))
            {
                _minInclusive = value;
                OnPropertyChanged("minInclusive", value);
            }
        }
    }
    
    [XmlIgnore]
    public virtual bool minInclusiveSpecified
    {
        get
        {
            return minInclusiveFieldSpecified;
        }
        set
        {
            if ((minInclusiveFieldSpecified.Equals(value) != true))
            {
                minInclusiveFieldSpecified = value;
                OnPropertyChanged("minInclusiveSpecified", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual uint maxInclusive
    {
        get
        {
            return _maxInclusive;
        }
        set
        {
            if ((_maxInclusive.Equals(value) != true))
            {
                _maxInclusive = value;
                OnPropertyChanged("maxInclusive", value);
            }
        }
    }
    
    [XmlIgnore]
    public virtual bool maxInclusiveSpecified
    {
        get
        {
            return maxInclusiveFieldSpecified;
        }
        set
        {
            if ((maxInclusiveFieldSpecified.Equals(value) != true))
            {
                maxInclusiveFieldSpecified = value;
                OnPropertyChanged("maxInclusiveSpecified", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual uint minExclusive
    {
        get
        {
            return _minExclusive;
        }
        set
        {
            if ((_minExclusive.Equals(value) != true))
            {
                _minExclusive = value;
                OnPropertyChanged("minExclusive", value);
            }
        }
    }
    
    [XmlIgnore]
    public virtual bool minExclusiveSpecified
    {
        get
        {
            return minExclusiveFieldSpecified;
        }
        set
        {
            if ((minExclusiveFieldSpecified.Equals(value) != true))
            {
                minExclusiveFieldSpecified = value;
                OnPropertyChanged("minExclusiveSpecified", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual uint maxExclusive
    {
        get
        {
            return _maxExclusive;
        }
        set
        {
            if ((_maxExclusive.Equals(value) != true))
            {
                _maxExclusive = value;
                OnPropertyChanged("maxExclusive", value);
            }
        }
    }
    
    [XmlIgnore]
    public virtual bool maxExclusiveSpecified
    {
        get
        {
            return maxExclusiveFieldSpecified;
        }
        set
        {
            if ((maxExclusiveFieldSpecified.Equals(value) != true))
            {
                maxExclusiveFieldSpecified = value;
                OnPropertyChanged("maxExclusiveSpecified", value);
            }
        }
    }
    
    [XmlAttribute]
    [MaxDigitsAttribute(2)]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual byte totalDigits
    {
        get
        {
            return _totalDigits;
        }
        set
        {
            if ((_totalDigits.Equals(value) != true))
            {
                _totalDigits = value;
                OnPropertyChanged("totalDigits", value);
            }
        }
    }
    
    [XmlIgnore]
    public virtual bool totalDigitsSpecified
    {
        get
        {
            return totalDigitsFieldSpecified;
        }
        set
        {
            if ((totalDigitsFieldSpecified.Equals(value) != true))
            {
                totalDigitsFieldSpecified = value;
                OnPropertyChanged("totalDigitsSpecified", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string mask
    {
        get
        {
            return _mask;
        }
        set
        {
            if ((_mask == value))
            {
                return;
            }
            if (((_mask == null) 
                        || (_mask.Equals(value) != true)))
            {
                _mask = value;
                OnPropertyChanged("mask", value);
            }
        }
    }
    
    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool allowGT
    {
        get
        {
            return _allowGT;
        }
        set
        {
            if ((_allowGT.Equals(value) != true))
            {
                _allowGT = value;
                OnPropertyChanged("allowGT", value);
            }
        }
    }
    
    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool allowGTE
    {
        get
        {
            return _allowGTE;
        }
        set
        {
            if ((_allowGTE.Equals(value) != true))
            {
                _allowGTE = value;
                OnPropertyChanged("allowGTE", value);
            }
        }
    }
    
    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool allowLT
    {
        get
        {
            return _allowLT;
        }
        set
        {
            if ((_allowLT.Equals(value) != true))
            {
                _allowLT = value;
                OnPropertyChanged("allowLT", value);
            }
        }
    }
    
    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool allowLTE
    {
        get
        {
            return _allowLTE;
        }
        set
        {
            if ((_allowLTE.Equals(value) != true))
            {
                _allowLTE = value;
                OnPropertyChanged("allowLTE", value);
            }
        }
    }
    
    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool allowAPPROX
    {
        get
        {
            return _allowAPPROX;
        }
        set
        {
            if ((_allowAPPROX.Equals(value) != true))
            {
                _allowAPPROX = value;
                OnPropertyChanged("allowAPPROX", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool maskSpecified
    {
        get
        {
            return _maskSpecified;
        }
        set
        {
            _maskSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool allowGTSpecified
    {
        get
        {
            return _allowGTSpecified;
        }
        set
        {
            _allowGTSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool allowGTESpecified
    {
        get
        {
            return _allowGTESpecified;
        }
        set
        {
            _allowGTESpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool allowLTSpecified
    {
        get
        {
            return _allowLTSpecified;
        }
        set
        {
            _allowLTSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool allowLTESpecified
    {
        get
        {
            return _allowLTESpecified;
        }
        set
        {
            _allowLTESpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool allowAPPROXSpecified
    {
        get
        {
            return _allowAPPROXSpecified;
        }
        set
        {
            _allowAPPROXSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether mask should be serialized
    /// </summary>
    public virtual bool ShouldSerializemask()
    {
        return !string.IsNullOrEmpty(mask);
    }
}
}
#pragma warning restore
