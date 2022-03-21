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
[JsonObject("ContactsType")]
public partial class ContactsType : ExtensionBaseType
{
    private List<ContactType> _contact;
    private bool _contactSpecified;
    [XmlElement("Contact", Order=0)]
    [JsonProperty(Order=0, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<ContactType> Contact
    {
        get
        {
            return _contact;
        }
        set
        {
            if ((_contact == value))
            {
                return;
            }
            if (((_contact == null) 
                        || (_contact.Equals(value) != true)))
            {
                _contact = value;
                OnPropertyChanged("Contact", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool ContactSpecified
    {
        get
        {
            return _contactSpecified;
        }
        set
        {
            _contactSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether Contact should be serialized
    /// </summary>
    public virtual bool ShouldSerializeContact()
    {
        return Contact != null && Contact.Count > 0;
    }
}
}
#pragma warning restore
