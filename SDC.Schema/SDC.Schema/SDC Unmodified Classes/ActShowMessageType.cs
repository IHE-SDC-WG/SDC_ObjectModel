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
/// Display a message to the form user, triggered by activity within the
/// form.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("ActShowMessageType")]
public partial class ActShowMessageType : ExtensionBaseType
{
    #region Private fields
    private List<RichTextType> _message;
    private string _alertLevel;
    private string _alertType;
    private string _messageType;
    private string _messageCode;
    #endregion
    
    [XmlElement("Message", Order=0)]
    [JsonProperty(Order=0, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<RichTextType> Message
    {
        get
        {
            return _message;
        }
        set
        {
            if ((_message == value))
            {
                return;
            }
            if (((_message == null) 
                        || (_message.Equals(value) != true)))
            {
                _message = value;
                OnPropertyChanged("Message", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string alertLevel
    {
        get
        {
            return _alertLevel;
        }
        set
        {
            if ((_alertLevel == value))
            {
                return;
            }
            if (((_alertLevel == null) 
                        || (_alertLevel.Equals(value) != true)))
            {
                _alertLevel = value;
                OnPropertyChanged("alertLevel", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string alertType
    {
        get
        {
            return _alertType;
        }
        set
        {
            if ((_alertType == value))
            {
                return;
            }
            if (((_alertType == null) 
                        || (_alertType.Equals(value) != true)))
            {
                _alertType = value;
                OnPropertyChanged("alertType", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string messageType
    {
        get
        {
            return _messageType;
        }
        set
        {
            if ((_messageType == value))
            {
                return;
            }
            if (((_messageType == null) 
                        || (_messageType.Equals(value) != true)))
            {
                _messageType = value;
                OnPropertyChanged("messageType", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string messageCode
    {
        get
        {
            return _messageCode;
        }
        set
        {
            if ((_messageCode == value))
            {
                return;
            }
            if (((_messageCode == null) 
                        || (_messageCode.Equals(value) != true)))
            {
                _messageCode = value;
                OnPropertyChanged("messageCode", value);
            }
        }
    }
    
    /// <summary>
    /// Test whether Message should be serialized
    /// </summary>
    public virtual bool ShouldSerializeMessage()
    {
        return Message != null && Message.Count > 0;
    }
    
    /// <summary>
    /// Test whether alertLevel should be serialized
    /// </summary>
    public virtual bool ShouldSerializealertLevel()
    {
        return !string.IsNullOrEmpty(alertLevel);
    }
    
    /// <summary>
    /// Test whether alertType should be serialized
    /// </summary>
    public virtual bool ShouldSerializealertType()
    {
        return !string.IsNullOrEmpty(alertType);
    }
    
    /// <summary>
    /// Test whether messageType should be serialized
    /// </summary>
    public virtual bool ShouldSerializemessageType()
    {
        return !string.IsNullOrEmpty(messageType);
    }
    
    /// <summary>
    /// Test whether messageCode should be serialized
    /// </summary>
    public virtual bool ShouldSerializemessageCode()
    {
        return !string.IsNullOrEmpty(messageCode);
    }
}
}
#pragma warning restore
