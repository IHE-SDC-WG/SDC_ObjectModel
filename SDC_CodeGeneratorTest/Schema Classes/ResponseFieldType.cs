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
/// This type is a template for a data entry field that accepts entries
/// (responses or answers) of any data type, including text, numbers, dates, and Base 64
/// - encoded blobs (images, sounds, video, other binary formats, etc.). This type
/// cannot contain ListItems, but it may be a child of a Question or a
/// ListItem.
/// </summary>
[XmlInclude(typeof(ListItemResponseFieldType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("ResponseFieldType")]
public partial class ResponseFieldType : ExtensionBaseType
{
    private DataTypes_DEType _response;
    private ExtensionBaseType _item;
    private RichTextType _textAfterResponse;
    private UnitsType _responseUnits;
    private List<EventType> _afterChange;
    private List<OnEventType> _onEvent;
    private bool _responseSpecified;
    private bool _itemSpecified;
    private bool _textAfterResponseSpecified;
    private bool _responseUnitsSpecified;
    private bool _afterChangeSpecified;
    private bool _onEventSpecified;
    /// <summary>
    /// W3C Schema data type details
    /// </summary>
    [XmlElement(Order=0)]
    [RequiredAttribute()]
    [JsonProperty(Order=0, NullValueHandling=NullValueHandling.Ignore)]
    public virtual DataTypes_DEType Response
    {
        get
        {
            return _response;
        }
        set
        {
            if ((_response == value))
            {
                return;
            }
            if (((_response == null) 
                        || (_response.Equals(value) != true)))
            {
                ValidationContext validatorPropContext = new ValidationContext(this, null, null);
                validatorPropContext.MemberName = "Response";
                Validator.ValidateProperty(value, validatorPropContext);
                _response = value;
                OnPropertyChanged("Response", value);
            }
        }
    }
    
    [XmlElement("CallSetValue", typeof(CallFuncActionType), Order=1)]
    [XmlElement("SetValue", typeof(ScriptCodeAnyType), Order=1)]
    public virtual ExtensionBaseType Item
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
    
    /// <summary>
    /// TextAfterResponse is fixed text that appears after (to
    /// the right of) the user's response on the data entry form. This may
    /// be text for units such as "mm", "cm", etc.
    /// </summary>
    [XmlElement(Order=2)]
    [JsonProperty(Order=2, NullValueHandling=NullValueHandling.Ignore)]
    public virtual RichTextType TextAfterResponse
    {
        get
        {
            return _textAfterResponse;
        }
        set
        {
            if ((_textAfterResponse == value))
            {
                return;
            }
            if (((_textAfterResponse == null) 
                        || (_textAfterResponse.Equals(value) != true)))
            {
                _textAfterResponse = value;
                OnPropertyChanged("TextAfterResponse", value);
            }
        }
    }
    
    [XmlElement(Order=3)]
    [JsonProperty(Order=3, NullValueHandling=NullValueHandling.Ignore)]
    public virtual UnitsType ResponseUnits
    {
        get
        {
            return _responseUnits;
        }
        set
        {
            if ((_responseUnits == value))
            {
                return;
            }
            if (((_responseUnits == null) 
                        || (_responseUnits.Equals(value) != true)))
            {
                _responseUnits = value;
                OnPropertyChanged("ResponseUnits", value);
            }
        }
    }
    
    /// <summary>
    /// Event that occurs after the Response value is changed,
    /// usually fired after a user leaves the Response
    /// field.
    /// </summary>
    [XmlElement("AfterChange", Order=4)]
    [JsonProperty(Order=4, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<EventType> AfterChange
    {
        get
        {
            return _afterChange;
        }
        set
        {
            if ((_afterChange == value))
            {
                return;
            }
            if (((_afterChange == null) 
                        || (_afterChange.Equals(value) != true)))
            {
                _afterChange = value;
                OnPropertyChanged("AfterChange", value);
            }
        }
    }
    
    [XmlElement("OnEvent", Order=5)]
    [JsonProperty(Order=5, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<OnEventType> OnEvent
    {
        get
        {
            return _onEvent;
        }
        set
        {
            if ((_onEvent == value))
            {
                return;
            }
            if (((_onEvent == null) 
                        || (_onEvent.Equals(value) != true)))
            {
                _onEvent = value;
                OnPropertyChanged("OnEvent", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool ResponseSpecified
    {
        get
        {
            return _responseSpecified;
        }
        set
        {
            _responseSpecified = value;
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
    public bool TextAfterResponseSpecified
    {
        get
        {
            return _textAfterResponseSpecified;
        }
        set
        {
            _textAfterResponseSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool ResponseUnitsSpecified
    {
        get
        {
            return _responseUnitsSpecified;
        }
        set
        {
            _responseUnitsSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool AfterChangeSpecified
    {
        get
        {
            return _afterChangeSpecified;
        }
        set
        {
            _afterChangeSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool OnEventSpecified
    {
        get
        {
            return _onEventSpecified;
        }
        set
        {
            _onEventSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether AfterChange should be serialized
    /// </summary>
    public virtual bool ShouldSerializeAfterChange()
    {
        return AfterChange != null && AfterChange.Count > 0;
    }
    
    /// <summary>
    /// Test whether OnEvent should be serialized
    /// </summary>
    public virtual bool ShouldSerializeOnEvent()
    {
        return OnEvent != null && OnEvent.Count > 0;
    }
    
    /// <summary>
    /// Test whether Response should be serialized
    /// </summary>
    public virtual bool ShouldSerializeResponse()
    {
        return (Response != null);
    }
    
    /// <summary>
    /// Test whether Item should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItem()
    {
        return (Item != null);
    }
    
    /// <summary>
    /// Test whether TextAfterResponse should be serialized
    /// </summary>
    public virtual bool ShouldSerializeTextAfterResponse()
    {
        return (TextAfterResponse != null);
    }
    
    /// <summary>
    /// Test whether ResponseUnits should be serialized
    /// </summary>
    public virtual bool ShouldSerializeResponseUnits()
    {
        return (ResponseUnits != null);
    }
}
}
#pragma warning restore
