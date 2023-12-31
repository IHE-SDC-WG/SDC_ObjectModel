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

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("RuleListItemMatchTargetsType")]
public partial class RuleListItemMatchTargetsType : ExtensionBaseType
{
    #region Private fields
    protected internal bool _shouldSerializeattributeToMatch;
    private string _matchListItems;
    private string _matchQuestions;
    private RuleListItemMatchTargetsTypeAttributeToMatch _attributeToMatch;
    #endregion
    
    ///// <summary>
    ///// RuleListItemMatchTargetsType class constructor
    ///// </summary>
    //public RuleListItemMatchTargetsType()
    //{
    //    _attributeToMatch = RuleListItemMatchTargetsTypeAttributeToMatch.associatedValue;
    //}
    
    /// <summary>
    /// Takes the @name of one or more target ListItem elements.
    /// If the source value matches the match supplied attribute criteria, then
    /// the ListItem(s) should be selcted. The named Question and target
    /// ListItem must be activated (visible and enabled) in order for it to be
    /// selected. Read-only ListItems can be selected in the same manner.
    /// Multiple ListItem names may be specified, separated by
    /// spaces.
    /// </summary>
    [XmlAttribute(DataType="NMTOKENS")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string MatchListItems
    {
        get
        {
            return _matchListItems;
        }
        set
        {
            if ((_matchListItems == value))
            {
                return;
            }
            if (((_matchListItems == null) 
                        || (_matchListItems.Equals(value) != true)))
            {
                _matchListItems = value;
                OnPropertyChanged("MatchListItems", value);
            }
        }
    }
    
    /// <summary>
    /// Takes the @name of a Question element with ListItems. If
    /// the source value matches the @associatedValue (or other
    /// @attributeToMatch) of one or more ListItems, then the ListItem(s) should
    /// be selected. The named Question and target ListItem must be activated
    /// (visible and enabled) in order for it to be selected. Read-only
    /// Questions/ListItems can be selected in the same manner. Multiple Question
    /// names may be specified, separated by spaces.
    /// </summary>
    [XmlAttribute(DataType="NMTOKENS")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string MatchQuestions
    {
        get
        {
            return _matchQuestions;
        }
        set
        {
            if ((_matchQuestions == value))
            {
                return;
            }
            if (((_matchQuestions == null) 
                        || (_matchQuestions.Equals(value) != true)))
            {
                _matchQuestions = value;
                OnPropertyChanged("MatchQuestions", value);
            }
        }
    }
    
    [XmlAttribute]
    [DefaultValue(RuleListItemMatchTargetsTypeAttributeToMatch.associatedValue)]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public virtual RuleListItemMatchTargetsTypeAttributeToMatch attributeToMatch
    {
        get
        {
            return _attributeToMatch;
        }
        set
        {
            if ((_attributeToMatch.Equals(value) != true))
            {
                _attributeToMatch = value;
                OnPropertyChanged("attributeToMatch", value);
            }
            _shouldSerializeattributeToMatch = true;
        }
    }
    
    /// <summary>
    /// Test whether attributeToMatch should be serialized
    /// </summary>
    public virtual bool ShouldSerializeattributeToMatch()
    {
        if (_shouldSerializeattributeToMatch)
        {
            return true;
        }
        return (_attributeToMatch != default(RuleListItemMatchTargetsTypeAttributeToMatch));
    }
    
    /// <summary>
    /// Test whether MatchListItems should be serialized
    /// </summary>
    public virtual bool ShouldSerializeMatchListItems()
    {
        return !string.IsNullOrEmpty(MatchListItems);
    }
    
    /// <summary>
    /// Test whether MatchQuestions should be serialized
    /// </summary>
    public virtual bool ShouldSerializeMatchQuestions()
    {
        return !string.IsNullOrEmpty(MatchQuestions);
    }
}
}
#pragma warning restore
