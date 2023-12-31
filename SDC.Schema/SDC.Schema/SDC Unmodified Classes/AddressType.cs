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
/// A structure for recording street/mailing addresses.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("AddressType")]
public partial class AddressType : ExtensionBaseType
{
    #region Private fields
    private string_Stype _addressType1;
    private List<string_Stype> _internalAddress;
    private List<string_Stype> _addressLine;
    private string_Stype _city;
    private string_Stype _jurisdiction;
    private string_Stype _state;
    private string_Stype _postalCode;
    private string_Stype _country;
    private string_Stype _usage;
    #endregion
    
    [XmlElement("AddressType", Order=0)]
    [JsonProperty("AddressType", Order=0, NullValueHandling=NullValueHandling.Ignore)]
    public virtual string_Stype AddressType1
    {
        get
        {
            return _addressType1;
        }
        set
        {
            if ((_addressType1 == value))
            {
                return;
            }
            if (((_addressType1 == null) 
                        || (_addressType1.Equals(value) != true)))
            {
                _addressType1 = value;
                OnPropertyChanged("AddressType1", value);
            }
        }
    }
    
    /// <summary>
    /// Address instructions for directing mail within an organizations buildings or corporate
    /// infrastructure.
    /// </summary>
    [XmlElement("InternalAddress", Order=1)]
    [JsonProperty(Order=1, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<string_Stype> InternalAddress
    {
        get
        {
            return _internalAddress;
        }
        set
        {
            if ((_internalAddress == value))
            {
                return;
            }
            if (((_internalAddress == null) 
                        || (_internalAddress.Equals(value) != true)))
            {
                _internalAddress = value;
                OnPropertyChanged("InternalAddress", value);
            }
        }
    }
    
    /// <summary>
    /// Address instructions for directing mail to a street address.
    /// </summary>
    [XmlElement("AddressLine", Order=2)]
    [JsonProperty(Order=2, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<string_Stype> AddressLine
    {
        get
        {
            return _addressLine;
        }
        set
        {
            if ((_addressLine == value))
            {
                return;
            }
            if (((_addressLine == null) 
                        || (_addressLine.Equals(value) != true)))
            {
                _addressLine = value;
                OnPropertyChanged("AddressLine", value);
            }
        }
    }
    
    [XmlElement(Order=3)]
    [JsonProperty(Order=3, NullValueHandling=NullValueHandling.Ignore)]
    public virtual string_Stype City
    {
        get
        {
            return _city;
        }
        set
        {
            if ((_city == value))
            {
                return;
            }
            if (((_city == null) 
                        || (_city.Equals(value) != true)))
            {
                _city = value;
                OnPropertyChanged("City", value);
            }
        }
    }
    
    /// <summary>
    /// Other optional locale identifier.
    /// </summary>
    [XmlElement(Order=4)]
    [JsonProperty(Order=4, NullValueHandling=NullValueHandling.Ignore)]
    public virtual string_Stype Jurisdiction
    {
        get
        {
            return _jurisdiction;
        }
        set
        {
            if ((_jurisdiction == value))
            {
                return;
            }
            if (((_jurisdiction == null) 
                        || (_jurisdiction.Equals(value) != true)))
            {
                _jurisdiction = value;
                OnPropertyChanged("Jurisdiction", value);
            }
        }
    }
    
    /// <summary>
    /// State, Province, etc.
    /// </summary>
    [XmlElement(Order=5)]
    [JsonProperty(Order=5, NullValueHandling=NullValueHandling.Ignore)]
    public virtual string_Stype State
    {
        get
        {
            return _state;
        }
        set
        {
            if ((_state == value))
            {
                return;
            }
            if (((_state == null) 
                        || (_state.Equals(value) != true)))
            {
                _state = value;
                OnPropertyChanged("State", value);
            }
        }
    }
    
    /// <summary>
    /// Local postal code, e.g., zip code.
    /// </summary>
    [XmlElement(Order=6)]
    [JsonProperty(Order=6, NullValueHandling=NullValueHandling.Ignore)]
    public virtual string_Stype PostalCode
    {
        get
        {
            return _postalCode;
        }
        set
        {
            if ((_postalCode == value))
            {
                return;
            }
            if (((_postalCode == null) 
                        || (_postalCode.Equals(value) != true)))
            {
                _postalCode = value;
                OnPropertyChanged("PostalCode", value);
            }
        }
    }
    
    /// <summary>
    /// **Need list of official country codes or text?
    /// </summary>
    [XmlElement(Order=7)]
    [JsonProperty(Order=7, NullValueHandling=NullValueHandling.Ignore)]
    public virtual string_Stype Country
    {
        get
        {
            return _country;
        }
        set
        {
            if ((_country == value))
            {
                return;
            }
            if (((_country == null) 
                        || (_country.Equals(value) != true)))
            {
                _country = value;
                OnPropertyChanged("Country", value);
            }
        }
    }
    
    /// <summary>
    /// When this address should be used
    /// </summary>
    [XmlElement(Order=8)]
    [JsonProperty(Order=8, NullValueHandling=NullValueHandling.Ignore)]
    public virtual string_Stype Usage
    {
        get
        {
            return _usage;
        }
        set
        {
            if ((_usage == value))
            {
                return;
            }
            if (((_usage == null) 
                        || (_usage.Equals(value) != true)))
            {
                _usage = value;
                OnPropertyChanged("Usage", value);
            }
        }
    }
    
    /// <summary>
    /// Test whether InternalAddress should be serialized
    /// </summary>
    public virtual bool ShouldSerializeInternalAddress()
    {
        return InternalAddress != null && InternalAddress.Count > 0;
    }
    
    /// <summary>
    /// Test whether AddressLine should be serialized
    /// </summary>
    public virtual bool ShouldSerializeAddressLine()
    {
        return AddressLine != null && AddressLine.Count > 0;
    }
    
    /// <summary>
    /// Test whether AddressType1 should be serialized
    /// </summary>
    public virtual bool ShouldSerializeAddressType1()
    {
        return (_addressType1 != null);
    }
    
    /// <summary>
    /// Test whether City should be serialized
    /// </summary>
    public virtual bool ShouldSerializeCity()
    {
        return (_city != null);
    }
    
    /// <summary>
    /// Test whether Jurisdiction should be serialized
    /// </summary>
    public virtual bool ShouldSerializeJurisdiction()
    {
        return (_jurisdiction != null);
    }
    
    /// <summary>
    /// Test whether State should be serialized
    /// </summary>
    public virtual bool ShouldSerializeState()
    {
        return (_state != null);
    }
    
    /// <summary>
    /// Test whether PostalCode should be serialized
    /// </summary>
    public virtual bool ShouldSerializePostalCode()
    {
        return (_postalCode != null);
    }
    
    /// <summary>
    /// Test whether Country should be serialized
    /// </summary>
    public virtual bool ShouldSerializeCountry()
    {
        return (_country != null);
    }
    
    /// <summary>
    /// Test whether Usage should be serialized
    /// </summary>
    public virtual bool ShouldSerializeUsage()
    {
        return (_usage != null);
    }
}
}
#pragma warning restore
