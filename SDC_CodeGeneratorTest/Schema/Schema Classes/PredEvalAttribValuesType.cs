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
/// This Rule evaluates an arbitrary set of attribute values from any item
/// and returns a Boolean summary value. In the PropertyValues condition, the contained
/// Boolean attributed values are ANDed together (by default) to return a derived
/// Boolean value. Default values are used if the attribute is not explicitly set to a
/// value. For attributes without default values, omitted (null) values are ignored and
/// are not used for null propagation.
/// </summary>
[XmlInclude(typeof(AttributeEvalActionType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("PredEvalAttribValuesType")]
public partial class PredEvalAttribValuesType : FuncBoolBaseType
{
    #region Private fields
    private bool _shouldSerializeboolOp;
    private bool _not;
    private PredEvalAttribValuesTypeBoolOp _boolOp;
    private string _itemNames;
    private bool _isSelected;
    private bool isSelectedFieldSpecified;
    private bool _isActive;
    private bool isActiveFieldSpecified;
    private string _hasSelectionsGTE;
    private string _hasSelectionsLTE;
    private string _hasSelectionsExact;
    private bool _hasResponse;
    private bool hasResponseFieldSpecified;
    private bool _isVisible;
    private bool isVisibleFieldSpecified;
    private bool _isEnabled;
    private bool isEnabledFieldSpecified;
    private bool _isRequired;
    private bool isRequiredFieldSpecified;
    private bool _isReadOnly;
    private bool isReadOnlyFieldSpecified;
    private string _hasType;
    private string _hasStyleClass;
    private bool _hasValue;
    private bool hasValueFieldSpecified;
    private string _supportDatesAndIntervals;
    private string _hasPattern;
    private string _hasValueEQ;
    private string _hasValueLT;
    private string _hasValueLTE;
    private string _hasValueGT;
    private string _hasValueGTE;
    private string _hasAssociatedValueEQ;
    private string _hasAssociatedValueLT;
    private string _hasAssociatedValueLTE;
    private string _hasAssociatedValueGT;
    private string _hasAssociatedValueGTE;
    private bool _notSpecified;
    private bool _boolOpSpecified;
    private bool _itemNamesSpecified;
    private bool _hasSelectionsGTESpecified;
    private bool _hasSelectionsLTESpecified;
    private bool _hasSelectionsExactSpecified;
    private bool _hasTypeSpecified;
    private bool _hasStyleClassSpecified;
    private bool _supportDatesAndIntervalsSpecified;
    private bool _hasPatternSpecified;
    private bool _hasValueEQSpecified;
    private bool _hasValueLTSpecified;
    private bool _hasValueLTESpecified;
    private bool _hasValueGTSpecified;
    private bool _hasValueGTESpecified;
    private bool _hasAssociatedValueEQSpecified;
    private bool _hasAssociatedValueLTSpecified;
    private bool _hasAssociatedValueLTESpecified;
    private bool _hasAssociatedValueGTSpecified;
    private bool _hasAssociatedValueGTESpecified;
    #endregion
    
    /// <summary>
    /// PredEvalAttribValuesType class constructor
    /// </summary>
    public PredEvalAttribValuesType()
    {
        _not = false;
        _boolOp = PredEvalAttribValuesTypeBoolOp.AND;
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
    /// Required. This attribute holds the @name attributes of the
    /// item(s) (Section, Question, List Item) to interrogate. These named items
    /// will be searched for attribute values specified in this Type. If a named
    /// item does not have a particualr attribute, then the attribute condition
    /// is ignored for that named item. It does not generate an error or a null
    /// propagation response.
    /// </summary>
    [XmlAttribute(DataType="NMTOKENS")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string itemNames
    {
        get
        {
            return _itemNames;
        }
        set
        {
            if ((_itemNames == value))
            {
                return;
            }
            if (((_itemNames == null) 
                        || (_itemNames.Equals(value) != true)))
            {
                _itemNames = value;
                OnPropertyChanged("itemNames", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool isSelected
    {
        get
        {
            return _isSelected;
        }
        set
        {
            if ((_isSelected.Equals(value) != true))
            {
                _isSelected = value;
                OnPropertyChanged("isSelected", value);
            }
        }
    }
    
    [XmlIgnore]
    public virtual bool isSelectedSpecified
    {
        get
        {
            return isSelectedFieldSpecified;
        }
        set
        {
            if ((isSelectedFieldSpecified.Equals(value) != true))
            {
                isSelectedFieldSpecified = value;
                OnPropertyChanged("isSelectedSpecified", value);
            }
        }
    }
    
    /// <summary>
    /// If visible and enabled are both true, then isActive is
    /// true. Otherwise, it is false.
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool isActive
    {
        get
        {
            return _isActive;
        }
        set
        {
            if ((_isActive.Equals(value) != true))
            {
                _isActive = value;
                OnPropertyChanged("isActive", value);
            }
        }
    }
    
    [XmlIgnore]
    public virtual bool isActiveSpecified
    {
        get
        {
            return isActiveFieldSpecified;
        }
        set
        {
            if ((isActiveFieldSpecified.Equals(value) != true))
            {
                isActiveFieldSpecified = value;
                OnPropertyChanged("isActiveSpecified", value);
            }
        }
    }
    
    /// <summary>
    /// Applies only to Questions that have selection lists
    /// (ListItems or LookupField). Evaluates to true if the number of selected
    /// items equals or exceeds the entered value.
    /// </summary>
    [XmlAttribute(DataType="nonNegativeInteger")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string hasSelectionsGTE
    {
        get
        {
            return _hasSelectionsGTE;
        }
        set
        {
            if ((_hasSelectionsGTE == value))
            {
                return;
            }
            if (((_hasSelectionsGTE == null) 
                        || (_hasSelectionsGTE.Equals(value) != true)))
            {
                _hasSelectionsGTE = value;
                OnPropertyChanged("hasSelectionsGTE", value);
            }
        }
    }
    
    /// <summary>
    /// Applies only to Questions that have selection lists
    /// (ListItems or LookupField). Evaluates to true if the number of selected
    /// items is less than or equal to the entered value.
    /// </summary>
    [XmlAttribute(DataType="nonNegativeInteger")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string hasSelectionsLTE
    {
        get
        {
            return _hasSelectionsLTE;
        }
        set
        {
            if ((_hasSelectionsLTE == value))
            {
                return;
            }
            if (((_hasSelectionsLTE == null) 
                        || (_hasSelectionsLTE.Equals(value) != true)))
            {
                _hasSelectionsLTE = value;
                OnPropertyChanged("hasSelectionsLTE", value);
            }
        }
    }
    
    /// <summary>
    /// Applies only to Questions that have selection lists
    /// (ListItems or LookupField). Evaluates to true if the number of selected
    /// items equals the entered value.
    /// </summary>
    [XmlAttribute(DataType="nonNegativeInteger")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string hasSelectionsExact
    {
        get
        {
            return _hasSelectionsExact;
        }
        set
        {
            if ((_hasSelectionsExact == value))
            {
                return;
            }
            if (((_hasSelectionsExact == null) 
                        || (_hasSelectionsExact.Equals(value) != true)))
            {
                _hasSelectionsExact = value;
                OnPropertyChanged("hasSelectionsExact", value);
            }
        }
    }
    
    /// <summary>
    /// Applies only to items that have Response Fields (Questions
    /// and ListItems). If the ListItem or Question has a Response Field, and
    /// that field has a value in it, this property returns true. If it does not
    /// have a value, it returns false. If no Response Field is present, it
    /// retuns null and is not used for Boolean comparisons.
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool hasResponse
    {
        get
        {
            return _hasResponse;
        }
        set
        {
            if ((_hasResponse.Equals(value) != true))
            {
                _hasResponse = value;
                OnPropertyChanged("hasResponse", value);
            }
        }
    }
    
    [XmlIgnore]
    public virtual bool hasResponseSpecified
    {
        get
        {
            return hasResponseFieldSpecified;
        }
        set
        {
            if ((hasResponseFieldSpecified.Equals(value) != true))
            {
                hasResponseFieldSpecified = value;
                OnPropertyChanged("hasResponseSpecified", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool isVisible
    {
        get
        {
            return _isVisible;
        }
        set
        {
            if ((_isVisible.Equals(value) != true))
            {
                _isVisible = value;
                OnPropertyChanged("isVisible", value);
            }
        }
    }
    
    [XmlIgnore]
    public virtual bool isVisibleSpecified
    {
        get
        {
            return isVisibleFieldSpecified;
        }
        set
        {
            if ((isVisibleFieldSpecified.Equals(value) != true))
            {
                isVisibleFieldSpecified = value;
                OnPropertyChanged("isVisibleSpecified", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool isEnabled
    {
        get
        {
            return _isEnabled;
        }
        set
        {
            if ((_isEnabled.Equals(value) != true))
            {
                _isEnabled = value;
                OnPropertyChanged("isEnabled", value);
            }
        }
    }
    
    [XmlIgnore]
    public virtual bool isEnabledSpecified
    {
        get
        {
            return isEnabledFieldSpecified;
        }
        set
        {
            if ((isEnabledFieldSpecified.Equals(value) != true))
            {
                isEnabledFieldSpecified = value;
                OnPropertyChanged("isEnabledSpecified", value);
            }
        }
    }
    
    /// <summary>
    /// If the minCard value is greater than 0, then isRequired =
    /// "true" If the minCard = "0" then isRequired = "false"
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool isRequired
    {
        get
        {
            return _isRequired;
        }
        set
        {
            if ((_isRequired.Equals(value) != true))
            {
                _isRequired = value;
                OnPropertyChanged("isRequired", value);
            }
        }
    }
    
    [XmlIgnore]
    public virtual bool isRequiredSpecified
    {
        get
        {
            return isRequiredFieldSpecified;
        }
        set
        {
            if ((isRequiredFieldSpecified.Equals(value) != true))
            {
                isRequiredFieldSpecified = value;
                OnPropertyChanged("isRequiredSpecified", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool isReadOnly
    {
        get
        {
            return _isReadOnly;
        }
        set
        {
            if ((_isReadOnly.Equals(value) != true))
            {
                _isReadOnly = value;
                OnPropertyChanged("isReadOnly", value);
            }
        }
    }
    
    [XmlIgnore]
    public virtual bool isReadOnlySpecified
    {
        get
        {
            return isReadOnlyFieldSpecified;
        }
        set
        {
            if ((isReadOnlyFieldSpecified.Equals(value) != true))
            {
                isReadOnlyFieldSpecified = value;
                OnPropertyChanged("isReadOnlySpecified", value);
            }
        }
    }
    
    [XmlAttribute(DataType="NMTOKENS")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string hasType
    {
        get
        {
            return _hasType;
        }
        set
        {
            if ((_hasType == value))
            {
                return;
            }
            if (((_hasType == null) 
                        || (_hasType.Equals(value) != true)))
            {
                _hasType = value;
                OnPropertyChanged("hasType", value);
            }
        }
    }
    
    [XmlAttribute(DataType="NMTOKENS")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string hasStyleClass
    {
        get
        {
            return _hasStyleClass;
        }
        set
        {
            if ((_hasStyleClass == value))
            {
                return;
            }
            if (((_hasStyleClass == null) 
                        || (_hasStyleClass.Equals(value) != true)))
            {
                _hasStyleClass = value;
                OnPropertyChanged("hasStyleClass", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool hasValue
    {
        get
        {
            return _hasValue;
        }
        set
        {
            if ((_hasValue.Equals(value) != true))
            {
                _hasValue = value;
                OnPropertyChanged("hasValue", value);
            }
        }
    }
    
    [XmlIgnore]
    public virtual bool hasValueSpecified
    {
        get
        {
            return hasValueFieldSpecified;
        }
        set
        {
            if ((hasValueFieldSpecified.Equals(value) != true))
            {
                hasValueFieldSpecified = value;
                OnPropertyChanged("hasValueSpecified", value);
            }
        }
    }
    
    [XmlAttribute("supportDatesAndIntervals...")]
    [JsonProperty("supportDatesAndIntervals...", NullValueHandling=NullValueHandling.Ignore)]
    public virtual string supportDatesAndIntervals
    {
        get
        {
            return _supportDatesAndIntervals;
        }
        set
        {
            if ((_supportDatesAndIntervals == value))
            {
                return;
            }
            if (((_supportDatesAndIntervals == null) 
                        || (_supportDatesAndIntervals.Equals(value) != true)))
            {
                _supportDatesAndIntervals = value;
                OnPropertyChanged("supportDatesAndIntervals", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string hasPattern
    {
        get
        {
            return _hasPattern;
        }
        set
        {
            if ((_hasPattern == value))
            {
                return;
            }
            if (((_hasPattern == null) 
                        || (_hasPattern.Equals(value) != true)))
            {
                _hasPattern = value;
                OnPropertyChanged("hasPattern", value);
            }
        }
    }
    
    /// <summary>
    /// If the value is peceded by a colon (:) sign, then it is a
    /// reference to the @val attribute of another element. References can refer
    /// to any element with an @val attribute or @propVal on a Property. The
    /// datatype must be cast to the appropriate target
    /// datatype.
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string hasValueEQ
    {
        get
        {
            return _hasValueEQ;
        }
        set
        {
            if ((_hasValueEQ == value))
            {
                return;
            }
            if (((_hasValueEQ == null) 
                        || (_hasValueEQ.Equals(value) != true)))
            {
                _hasValueEQ = value;
                OnPropertyChanged("hasValueEQ", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string hasValueLT
    {
        get
        {
            return _hasValueLT;
        }
        set
        {
            if ((_hasValueLT == value))
            {
                return;
            }
            if (((_hasValueLT == null) 
                        || (_hasValueLT.Equals(value) != true)))
            {
                _hasValueLT = value;
                OnPropertyChanged("hasValueLT", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string hasValueLTE
    {
        get
        {
            return _hasValueLTE;
        }
        set
        {
            if ((_hasValueLTE == value))
            {
                return;
            }
            if (((_hasValueLTE == null) 
                        || (_hasValueLTE.Equals(value) != true)))
            {
                _hasValueLTE = value;
                OnPropertyChanged("hasValueLTE", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string hasValueGT
    {
        get
        {
            return _hasValueGT;
        }
        set
        {
            if ((_hasValueGT == value))
            {
                return;
            }
            if (((_hasValueGT == null) 
                        || (_hasValueGT.Equals(value) != true)))
            {
                _hasValueGT = value;
                OnPropertyChanged("hasValueGT", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string hasValueGTE
    {
        get
        {
            return _hasValueGTE;
        }
        set
        {
            if ((_hasValueGTE == value))
            {
                return;
            }
            if (((_hasValueGTE == null) 
                        || (_hasValueGTE.Equals(value) != true)))
            {
                _hasValueGTE = value;
                OnPropertyChanged("hasValueGTE", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string hasAssociatedValueEQ
    {
        get
        {
            return _hasAssociatedValueEQ;
        }
        set
        {
            if ((_hasAssociatedValueEQ == value))
            {
                return;
            }
            if (((_hasAssociatedValueEQ == null) 
                        || (_hasAssociatedValueEQ.Equals(value) != true)))
            {
                _hasAssociatedValueEQ = value;
                OnPropertyChanged("hasAssociatedValueEQ", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string hasAssociatedValueLT
    {
        get
        {
            return _hasAssociatedValueLT;
        }
        set
        {
            if ((_hasAssociatedValueLT == value))
            {
                return;
            }
            if (((_hasAssociatedValueLT == null) 
                        || (_hasAssociatedValueLT.Equals(value) != true)))
            {
                _hasAssociatedValueLT = value;
                OnPropertyChanged("hasAssociatedValueLT", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string hasAssociatedValueLTE
    {
        get
        {
            return _hasAssociatedValueLTE;
        }
        set
        {
            if ((_hasAssociatedValueLTE == value))
            {
                return;
            }
            if (((_hasAssociatedValueLTE == null) 
                        || (_hasAssociatedValueLTE.Equals(value) != true)))
            {
                _hasAssociatedValueLTE = value;
                OnPropertyChanged("hasAssociatedValueLTE", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string hasAssociatedValueGT
    {
        get
        {
            return _hasAssociatedValueGT;
        }
        set
        {
            if ((_hasAssociatedValueGT == value))
            {
                return;
            }
            if (((_hasAssociatedValueGT == null) 
                        || (_hasAssociatedValueGT.Equals(value) != true)))
            {
                _hasAssociatedValueGT = value;
                OnPropertyChanged("hasAssociatedValueGT", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string hasAssociatedValueGTE
    {
        get
        {
            return _hasAssociatedValueGTE;
        }
        set
        {
            if ((_hasAssociatedValueGTE == value))
            {
                return;
            }
            if (((_hasAssociatedValueGTE == null) 
                        || (_hasAssociatedValueGTE.Equals(value) != true)))
            {
                _hasAssociatedValueGTE = value;
                OnPropertyChanged("hasAssociatedValueGTE", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool notSpecified
    {
        get
        {
            return _notSpecified;
        }
        set
        {
            _notSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool boolOpSpecified
    {
        get
        {
            return _boolOpSpecified;
        }
        set
        {
            _boolOpSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool itemNamesSpecified
    {
        get
        {
            return _itemNamesSpecified;
        }
        set
        {
            _itemNamesSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool hasSelectionsGTESpecified
    {
        get
        {
            return _hasSelectionsGTESpecified;
        }
        set
        {
            _hasSelectionsGTESpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool hasSelectionsLTESpecified
    {
        get
        {
            return _hasSelectionsLTESpecified;
        }
        set
        {
            _hasSelectionsLTESpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool hasSelectionsExactSpecified
    {
        get
        {
            return _hasSelectionsExactSpecified;
        }
        set
        {
            _hasSelectionsExactSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool hasTypeSpecified
    {
        get
        {
            return _hasTypeSpecified;
        }
        set
        {
            _hasTypeSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool hasStyleClassSpecified
    {
        get
        {
            return _hasStyleClassSpecified;
        }
        set
        {
            _hasStyleClassSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool supportDatesAndIntervalsSpecified
    {
        get
        {
            return _supportDatesAndIntervalsSpecified;
        }
        set
        {
            _supportDatesAndIntervalsSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool hasPatternSpecified
    {
        get
        {
            return _hasPatternSpecified;
        }
        set
        {
            _hasPatternSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool hasValueEQSpecified
    {
        get
        {
            return _hasValueEQSpecified;
        }
        set
        {
            _hasValueEQSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool hasValueLTSpecified
    {
        get
        {
            return _hasValueLTSpecified;
        }
        set
        {
            _hasValueLTSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool hasValueLTESpecified
    {
        get
        {
            return _hasValueLTESpecified;
        }
        set
        {
            _hasValueLTESpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool hasValueGTSpecified
    {
        get
        {
            return _hasValueGTSpecified;
        }
        set
        {
            _hasValueGTSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool hasValueGTESpecified
    {
        get
        {
            return _hasValueGTESpecified;
        }
        set
        {
            _hasValueGTESpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool hasAssociatedValueEQSpecified
    {
        get
        {
            return _hasAssociatedValueEQSpecified;
        }
        set
        {
            _hasAssociatedValueEQSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool hasAssociatedValueLTSpecified
    {
        get
        {
            return _hasAssociatedValueLTSpecified;
        }
        set
        {
            _hasAssociatedValueLTSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool hasAssociatedValueLTESpecified
    {
        get
        {
            return _hasAssociatedValueLTESpecified;
        }
        set
        {
            _hasAssociatedValueLTESpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool hasAssociatedValueGTSpecified
    {
        get
        {
            return _hasAssociatedValueGTSpecified;
        }
        set
        {
            _hasAssociatedValueGTSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool hasAssociatedValueGTESpecified
    {
        get
        {
            return _hasAssociatedValueGTESpecified;
        }
        set
        {
            _hasAssociatedValueGTESpecified = value;
        }
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
    
    /// <summary>
    /// Test whether itemNames should be serialized
    /// </summary>
    public virtual bool ShouldSerializeitemNames()
    {
        return !string.IsNullOrEmpty(itemNames);
    }
    
    /// <summary>
    /// Test whether hasSelectionsGTE should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasSelectionsGTE()
    {
        return !string.IsNullOrEmpty(hasSelectionsGTE);
    }
    
    /// <summary>
    /// Test whether hasSelectionsLTE should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasSelectionsLTE()
    {
        return !string.IsNullOrEmpty(hasSelectionsLTE);
    }
    
    /// <summary>
    /// Test whether hasSelectionsExact should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasSelectionsExact()
    {
        return !string.IsNullOrEmpty(hasSelectionsExact);
    }
    
    /// <summary>
    /// Test whether hasType should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasType()
    {
        return !string.IsNullOrEmpty(hasType);
    }
    
    /// <summary>
    /// Test whether hasStyleClass should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasStyleClass()
    {
        return !string.IsNullOrEmpty(hasStyleClass);
    }
    
    /// <summary>
    /// Test whether supportDatesAndIntervals should be serialized
    /// </summary>
    public virtual bool ShouldSerializesupportDatesAndIntervals()
    {
        return !string.IsNullOrEmpty(supportDatesAndIntervals);
    }
    
    /// <summary>
    /// Test whether hasPattern should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasPattern()
    {
        return !string.IsNullOrEmpty(hasPattern);
    }
    
    /// <summary>
    /// Test whether hasValueEQ should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasValueEQ()
    {
        return !string.IsNullOrEmpty(hasValueEQ);
    }
    
    /// <summary>
    /// Test whether hasValueLT should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasValueLT()
    {
        return !string.IsNullOrEmpty(hasValueLT);
    }
    
    /// <summary>
    /// Test whether hasValueLTE should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasValueLTE()
    {
        return !string.IsNullOrEmpty(hasValueLTE);
    }
    
    /// <summary>
    /// Test whether hasValueGT should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasValueGT()
    {
        return !string.IsNullOrEmpty(hasValueGT);
    }
    
    /// <summary>
    /// Test whether hasValueGTE should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasValueGTE()
    {
        return !string.IsNullOrEmpty(hasValueGTE);
    }
    
    /// <summary>
    /// Test whether hasAssociatedValueEQ should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasAssociatedValueEQ()
    {
        return !string.IsNullOrEmpty(hasAssociatedValueEQ);
    }
    
    /// <summary>
    /// Test whether hasAssociatedValueLT should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasAssociatedValueLT()
    {
        return !string.IsNullOrEmpty(hasAssociatedValueLT);
    }
    
    /// <summary>
    /// Test whether hasAssociatedValueLTE should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasAssociatedValueLTE()
    {
        return !string.IsNullOrEmpty(hasAssociatedValueLTE);
    }
    
    /// <summary>
    /// Test whether hasAssociatedValueGT should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasAssociatedValueGT()
    {
        return !string.IsNullOrEmpty(hasAssociatedValueGT);
    }
    
    /// <summary>
    /// Test whether hasAssociatedValueGTE should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasAssociatedValueGTE()
    {
        return !string.IsNullOrEmpty(hasAssociatedValueGTE);
    }
}
}
#pragma warning restore
