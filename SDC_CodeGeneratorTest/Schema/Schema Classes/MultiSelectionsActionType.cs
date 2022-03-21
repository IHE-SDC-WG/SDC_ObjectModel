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
[JsonObject("MultiSelectionsActionType")]
public partial class MultiSelectionsActionType : PredMultiSelectionSetBoolType
{
    #region Private fields
    private ActionsType _actions;
    private List<PredActionType> _else;
    private bool _actionsSpecified;
    private bool _elseSpecified;
    #endregion
    
    [XmlElement(Order=0)]
    [JsonProperty(Order=0, NullValueHandling=NullValueHandling.Ignore)]
    public virtual ActionsType Actions
    {
        get
        {
            return _actions;
        }
        set
        {
            if ((_actions == value))
            {
                return;
            }
            if (((_actions == null) 
                        || (_actions.Equals(value) != true)))
            {
                _actions = value;
                OnPropertyChanged("Actions", value);
            }
        }
    }
    
    [XmlElement("Else", Order=1)]
    [JsonProperty(Order=1, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<PredActionType> Else
    {
        get
        {
            return _else;
        }
        set
        {
            if ((_else == value))
            {
                return;
            }
            if (((_else == null) 
                        || (_else.Equals(value) != true)))
            {
                _else = value;
                OnPropertyChanged("Else", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool ActionsSpecified
    {
        get
        {
            return _actionsSpecified;
        }
        set
        {
            _actionsSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool ElseSpecified
    {
        get
        {
            return _elseSpecified;
        }
        set
        {
            _elseSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether Else should be serialized
    /// </summary>
    public virtual bool ShouldSerializeElse()
    {
        return Else != null && Else.Count > 0;
    }
    
    /// <summary>
    /// Test whether Actions should be serialized
    /// </summary>
    public virtual bool ShouldSerializeActions()
    {
        return (_actions != null);
    }
}
}
#pragma warning restore
