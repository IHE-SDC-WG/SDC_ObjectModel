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
/// Add all or part of a coding section to the designated target
/// site.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("ActAddCodeType")]
public partial class ActAddCodeType : ItemNameType
{
    #region Private fields
    private CodingType _code;
    #endregion
    
    [XmlElement(Order=0)]
    [JsonProperty(Order=0, NullValueHandling=NullValueHandling.Ignore)]
    public virtual CodingType Code
    {
        get
        {
            return _code;
        }
        set
        {
            if ((_code == value))
            {
                return;
            }
            if (((_code == null) 
                        || (_code.Equals(value) != true)))
            {
                _code = value;
                OnPropertyChanged("Code", value);
            }
        }
    }
    
    /// <summary>
    /// Test whether Code should be serialized
    /// </summary>
    public virtual bool ShouldSerializeCode()
    {
        return (_code != null);
    }
}
}
#pragma warning restore
