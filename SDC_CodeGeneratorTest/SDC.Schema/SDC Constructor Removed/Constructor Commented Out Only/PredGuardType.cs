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
/// PredGuardType is a "predicate" expression, which combines various Boolean sub-expressions and returns a Boolean (true/false) result. It is primarily used to subscribe SDC IdentifiedExtensionType (IET) objects (i.e., SectionType, QuestionType, ListItemType, DisplayedType, ButtonItemType, InjectFormType) to changes in SDC form state (i.e., the values of SDC form attributes).  PredGuardType joins together one or more SDC Boolean-retuning functions, and applies a Boolean operator to the joined results to produce a Boolean result.  (Most of the joined functions monitor form state.)   The true/false result from the joined Boolean functions is then used to control the activation (enabled) status of IET objects or the selection status of ListItem nodes.
/// For example, A PredGuardType node attached to the SelectIf guard of ListItem(1) could evaluate if ListItem(2) elesewhere in the form is selected.  If ListItem(2) is selected, then the PredGuardType node would return true, and ListItem(1) would be automatically selected.  ListItem(1) would not be deselected if the PredGuardType node returned false.  A separate DeselectIf guard on ListItem(1) would be required for that purpose.
/// </summary>
[XmlInclude(typeof(PredActionType))]
[XmlInclude(typeof(EventType))]
[XmlInclude(typeof(OnEventType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("PredGuardType")]
public partial class PredGuardType : FuncBoolBaseType
{
    #region Private fields
    protected internal bool _shouldSerializeboolOp;
    protected internal bool _shouldSerializenot;
    protected internal bool _not;
    protected internal PredEvalAttribValuesTypeBoolOp _boolOp;
    private List<ExtensionBaseType> _items;

		
    #endregion
    
    ///// <summary>
    ///// PredGuardType class constructor
    ///// </summary>
    //public PredGuardType()
    //{
    //    _not = false;
    //    _boolOp = PredEvalAttribValuesTypeBoolOp.AND;
    //}
    
    [XmlElement("AttributeEval", typeof(PredEvalAttribValuesType), Order=0)]
    [XmlElement("CallBoolFunc", typeof(CallFuncBoolType), Order=0)]
    [XmlElement("Group", typeof(PredGuardType), Order=0)]
    [XmlElement("ItemAlternatives", typeof(PredAlternativesType), Order=0)]
    [XmlElement("MultiSelections", typeof(PredMultiSelectionSetBoolType), Order=0)]
    [XmlElement("ScriptBoolFunc", typeof(ScriptCodeBoolType), Order=0)]
    [XmlElement("SelectionSets", typeof(PredGuardTypeSelectionSets), Order=0)]
    [XmlElement("SelectionTest", typeof(PredSelectionTestType), Order=0)]
    public virtual List<ExtensionBaseType> Items
    {
        get
        {
            return _items;
        }
        set
        {
            if ((_items == value))
            {
                return;
            }
            if (((_items == null) 
                        || (_items.Equals(value) != true)))
            {
                _items = value;
                OnPropertyChanged("Items", value);
            }
        }
    }
    
    [XmlAttribute]
    [DefaultValue(false)]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool not
    {
        get
        {
            return _not;
        }
        set
        {
            if ((_not.Equals(value) != true))
            {
                _not = value;
                OnPropertyChanged("not", value);
            }
            _shouldSerializenot = true;
        }
    }
    
    [XmlAttribute]
    [DefaultValue(PredEvalAttribValuesTypeBoolOp.AND)]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public virtual PredEvalAttribValuesTypeBoolOp boolOp
    {
        get
        {
            return _boolOp;
        }
        set
        {
            if ((_boolOp.Equals(value) != true))
            {
                _boolOp = value;
                OnPropertyChanged("boolOp", value);
            }
            _shouldSerializeboolOp = true;
        }
    }
    
    /// <summary>
    /// Test whether Items should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItems()
    {
        return Items != null && Items.Count > 0;
    }
    
    /// <summary>
    /// Test whether not should be serialized
    /// </summary>
    public virtual bool ShouldSerializenot()
    {
        if (_shouldSerializenot)
        {
            return true;
        }
        return (_not != default(bool));
    }
    
    /// <summary>
    /// Test whether boolOp should be serialized
    /// </summary>
    public virtual bool ShouldSerializeboolOp()
    {
        if (_shouldSerializeboolOp)
        {
            return true;
        }
        return (_boolOp != default(PredEvalAttribValuesTypeBoolOp));
    }
}
}
#pragma warning restore
