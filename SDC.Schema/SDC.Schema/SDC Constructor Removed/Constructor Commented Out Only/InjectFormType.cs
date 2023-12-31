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
/// CHANGED: This type represents a form or portion of a form that is
/// imported into the current form at a specific location. It allows the composition of
/// forms from other forms or parts of other forms. In practice, using an injected
/// section will requiresome or all of the injected FormDesignXML to be injected under
/// this the InjectForm element. For that reason, the schema supports those elements to
/// appear inline. However, in a "raw" form (not yet filled out), the FormDesign element
/// would generally be empty; only the top-level InjectFormType attributes would be used
/// to point to the parts to be later injected. Form parts to be injected are specified
/// by packageID, not FormID. This allows an injected form to be assocaited with helper
/// files, or to return previosuly completed form parts containing responses.
/// </summary>
[XmlInclude(typeof(ActInjectType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("InjectFormType")]
public partial class InjectFormType : IdentifiedExtensionType
{
    #region Private fields
    protected internal bool _shouldSerializerepeat;
    private IdentifiedExtensionType _item;
    private string _injectionSourceURI;
    private string _rootItemID;
    private string _serverURI;
    private uint _repeat;
    private string _instanceGUID;
    private string _parentGUID;
    #endregion
    
    ///// <summary>
    ///// InjectFormType class constructor
    ///// </summary>
    //public InjectFormType()
    //{
    //    _repeat = ((uint)(0));
    //}
    
    [XmlElement("FormDesign", typeof(FormDesignType), Order=0)]
    [XmlElement("Question", typeof(QuestionItemType), Order=0)]
    [XmlElement("Section", typeof(SectionItemType), Order=0)]
    public virtual IdentifiedExtensionType Item
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
    /// NEW (2/24/2022): The source of the SDC FormDesign, Section or Question to inject
    /// The suggested form of the URI is:
    /// 
    /// serverURI + \fullURI for the FDF (as described in the SDC Technical Reference Guide [TRG])
    /// Retrieves the latest package version with FDF responses (contains the latest FDF-R content)
    /// -OR-
    /// serverURI +\instanceVersionURI for the FDF-R (as described in the TRG)
    /// Retrieves a specific package version with FDF responses  (contains the FDF-R content from a specific point in time)
    /// </summary>
    [XmlAttribute(DataType="anyURI")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string InjectionSourceURI
    {
        get
        {
            return _injectionSourceURI;
        }
        set
        {
            if ((_injectionSourceURI == value))
            {
                return;
            }
            if (((_injectionSourceURI == null) 
                        || (_injectionSourceURI.Equals(value) != true)))
            {
                _injectionSourceURI = value;
                OnPropertyChanged("InjectionSourceURI", value);
            }
        }
    }
    
    /// <summary>
    /// The rootItemID is the ID of the form or form part that
    /// will be injected. It must point to a valid FormDesign, Section or
    /// Question element.
    /// </summary>
    [XmlAttribute(DataType="anyURI")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string rootItemID
    {
        get
        {
            return _rootItemID;
        }
        set
        {
            if ((_rootItemID == value))
            {
                return;
            }
            if (((_rootItemID == null) 
                        || (_rootItemID.Equals(value) != true)))
            {
                _rootItemID = value;
                OnPropertyChanged("rootItemID", value);
            }
        }
    }
    
    /// <summary>
    /// The server from which the injected package will be
    /// retrieved. Former name "pkgManagerURI"
    /// </summary>
    [XmlAttribute(DataType="anyURI")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string serverURI
    {
        get
        {
            return _serverURI;
        }
        set
        {
            if ((_serverURI == value))
            {
                return;
            }
            if (((_serverURI == null) 
                        || (_serverURI.Equals(value) != true)))
            {
                _serverURI = value;
                OnPropertyChanged("serverURI", value);
            }
        }
    }
    
    [XmlAttribute]
    [DefaultValue(typeof(uint), "0")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual uint repeat
    {
        get
        {
            return _repeat;
        }
        set
        {
            if ((_repeat.Equals(value) != true))
            {
                _repeat = value;
                OnPropertyChanged("repeat", value);
            }
            _shouldSerializerepeat = true;
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string instanceGUID
    {
        get
        {
            return _instanceGUID;
        }
        set
        {
            if ((_instanceGUID == value))
            {
                return;
            }
            if (((_instanceGUID == null) 
                        || (_instanceGUID.Equals(value) != true)))
            {
                _instanceGUID = value;
                OnPropertyChanged("instanceGUID", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string parentGUID
    {
        get
        {
            return _parentGUID;
        }
        set
        {
            if ((_parentGUID == value))
            {
                return;
            }
            if (((_parentGUID == null) 
                        || (_parentGUID.Equals(value) != true)))
            {
                _parentGUID = value;
                OnPropertyChanged("parentGUID", value);
            }
        }
    }
    
    /// <summary>
    /// Test whether repeat should be serialized
    /// </summary>
    public virtual bool ShouldSerializerepeat()
    {
        if (_shouldSerializerepeat)
        {
            return true;
        }
        return (_repeat != default(uint));
    }
    
    /// <summary>
    /// Test whether Item should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItem()
    {
        return (_item != null);
    }
    
    /// <summary>
    /// Test whether InjectionSourceURI should be serialized
    /// </summary>
    public virtual bool ShouldSerializeInjectionSourceURI()
    {
        return !string.IsNullOrEmpty(InjectionSourceURI);
    }
    
    /// <summary>
    /// Test whether rootItemID should be serialized
    /// </summary>
    public virtual bool ShouldSerializerootItemID()
    {
        return !string.IsNullOrEmpty(rootItemID);
    }
    
    /// <summary>
    /// Test whether serverURI should be serialized
    /// </summary>
    public virtual bool ShouldSerializeserverURI()
    {
        return !string.IsNullOrEmpty(serverURI);
    }
    
    /// <summary>
    /// Test whether instanceGUID should be serialized
    /// </summary>
    public virtual bool ShouldSerializeinstanceGUID()
    {
        return !string.IsNullOrEmpty(instanceGUID);
    }
    
    /// <summary>
    /// Test whether parentGUID should be serialized
    /// </summary>
    public virtual bool ShouldSerializeparentGUID()
    {
        return !string.IsNullOrEmpty(parentGUID);
    }
}
}
#pragma warning restore
