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
[JsonObject("ReplacedIDsType")]
public partial class ReplacedIDsType : BaseType
{
    #region Private fields
    private List<anyURI_Stype> _replacedID;
    private bool _replacedIDSpecified;
    #endregion
    
    [XmlElement("ReplacedID", Order=0)]
    [JsonProperty(Order=0, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<anyURI_Stype> ReplacedID
    {
        get
        {
            return _replacedID;
        }
        set
        {
            if ((_replacedID == value))
            {
                return;
            }
            if (((_replacedID == null) 
                        || (_replacedID.Equals(value) != true)))
            {
                _replacedID = value;
                OnPropertyChanged("ReplacedID", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool ReplacedIDSpecified
    {
        get
        {
            return _replacedIDSpecified;
        }
        set
        {
            _replacedIDSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether ReplacedID should be serialized
    /// </summary>
    public virtual bool ShouldSerializeReplacedID()
    {
        return ReplacedID != null && ReplacedID.Count > 0;
    }
}
}
#pragma warning restore
