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
/// ListField is a grouper for list-like answer choices, which may be
/// derived from either a set of answer choice lists (a List composed of ListItems) or
/// or a list obtained from a LookupEndpoint URI.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("ListFieldType")]
public partial class ListFieldType : ExtensionBaseType
{
    private RichTextType _listHeaderText;
    private CodeSystemType _defaultCodeSystem;
    private ExtensionBaseType _item;
    private List<PredSelectionTestType> _illegalListItemPairings;
    private List<PredSingleSelectionSetsType> _illegalCoSelectedListItems;
    private List<EventType> _afterChange;
    private List<OnEventType> _onEvent;
    private string _colTextDelimiter;
    private byte _numCols;
    private byte _storedCol;
    private ushort _minSelections;
    private ushort _maxSelections;
    private bool _ordered;
    private string _defaultListItemDataType;
    private bool _listHeaderTextSpecified;
    private bool _defaultCodeSystemSpecified;
    private bool _itemSpecified;
    private bool _illegalListItemPairingsSpecified;
    private bool _illegalCoSelectedListItemsSpecified;
    private bool _afterChangeSpecified;
    private bool _onEventSpecified;
    private bool _colTextDelimiterSpecified;
    private bool _numColsSpecified;
    private bool _storedColSpecified;
    private bool _minSelectionsSpecified;
    private bool _maxSelectionsSpecified;
    private bool _orderedSpecified;
    private bool _defaultListItemDataTypeSpecified;
    /// <summary>
    /// ListFieldType class constructor
    /// </summary>
    public ListFieldType()
    {
        _colTextDelimiter = "|";
        _numCols = ((byte)(1));
        _storedCol = ((byte)(1));
        _minSelections = ((ushort)(1));
        _maxSelections = ((ushort)(1));
        _ordered = true;
    }
    
    /// <summary>
    /// The header row for a set of list items. If the list
    /// has more than one column, the column text is separated by the
    /// colTextDelimiter.
    /// </summary>
    [XmlElement(Order=0)]
    [JsonProperty(Order=0, NullValueHandling=NullValueHandling.Ignore)]
    public virtual RichTextType ListHeaderText
    {
        get
        {
            return _listHeaderText;
        }
        set
        {
            if ((_listHeaderText == value))
            {
                return;
            }
            if (((_listHeaderText == null) 
                        || (_listHeaderText.Equals(value) != true)))
            {
                _listHeaderText = value;
                OnPropertyChanged("ListHeaderText", value);
            }
        }
    }
    
    /// <summary>
    /// If coded values are used for items in a List
    /// (including ListItem and LookupEndPoint lists), then the default
    /// coding system should be specified here. For ListItem nodes, any
    /// exceptions to the coding system may be specified on the individual
    /// ListItem nodes. For LookupEndPoints, the endpoint data can
    /// optionally specify any exceptions in a dedicated CodeSystem column
    /// in the returned list data.
    /// </summary>
    [XmlElement(Order=1)]
    [JsonProperty(Order=1, NullValueHandling=NullValueHandling.Ignore)]
    public virtual CodeSystemType DefaultCodeSystem
    {
        get
        {
            return _defaultCodeSystem;
        }
        set
        {
            if ((_defaultCodeSystem == value))
            {
                return;
            }
            if (((_defaultCodeSystem == null) 
                        || (_defaultCodeSystem.Equals(value) != true)))
            {
                _defaultCodeSystem = value;
                OnPropertyChanged("DefaultCodeSystem", value);
            }
        }
    }
    
    [XmlElement("List", typeof(ListType), Order=2)]
    [XmlElement("LookupEndPoint", typeof(LookupEndPointType), Order=2)]
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
    
    [XmlElement("IllegalListItemPairings", Order=3)]
    [JsonProperty(Order=3, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<PredSelectionTestType> IllegalListItemPairings
    {
        get
        {
            return _illegalListItemPairings;
        }
        set
        {
            if ((_illegalListItemPairings == value))
            {
                return;
            }
            if (((_illegalListItemPairings == null) 
                        || (_illegalListItemPairings.Equals(value) != true)))
            {
                _illegalListItemPairings = value;
                OnPropertyChanged("IllegalListItemPairings", value);
            }
        }
    }
    
    [XmlElement("IllegalCoSelectedListItems", Order=4)]
    [JsonProperty(Order=4, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<PredSingleSelectionSetsType> IllegalCoSelectedListItems
    {
        get
        {
            return _illegalCoSelectedListItems;
        }
        set
        {
            if ((_illegalCoSelectedListItems == value))
            {
                return;
            }
            if (((_illegalCoSelectedListItems == null) 
                        || (_illegalCoSelectedListItems.Equals(value) != true)))
            {
                _illegalCoSelectedListItems = value;
                OnPropertyChanged("IllegalCoSelectedListItems", value);
            }
        }
    }
    
    /// <summary>
    /// Event that occurs after List Field selections are
    /// changed.
    /// </summary>
    [XmlElement("AfterChange", Order=5)]
    [JsonProperty(Order=5, NullValueHandling=NullValueHandling.Ignore)]
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
    
    [XmlElement("OnEvent", Order=6)]
    [JsonProperty(Order=6, NullValueHandling=NullValueHandling.Ignore)]
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
    
    /// <summary>
    /// Character in the DisplayText that separates the columns
    /// and rows in a single or multi-column list.
    /// </summary>
    [XmlAttribute]
    [DefaultValue("|")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string colTextDelimiter
    {
        get
        {
            return _colTextDelimiter;
        }
        set
        {
            if ((_colTextDelimiter == value))
            {
                return;
            }
            if (((_colTextDelimiter == null) 
                        || (_colTextDelimiter.Equals(value) != true)))
            {
                _colTextDelimiter = value;
                OnPropertyChanged("colTextDelimiter", value);
            }
        }
    }
    
    /// <summary>
    /// Number of columns in the list
    /// </summary>
    [XmlAttribute]
    [DefaultValue(typeof(byte), "1")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual byte numCols
    {
        get
        {
            return _numCols;
        }
        set
        {
            if ((_numCols.Equals(value) != true))
            {
                _numCols = value;
                OnPropertyChanged("numCols", value);
            }
        }
    }
    
    /// <summary>
    /// Determines which column of the list is stored in a
    /// database. This list is one-based.
    /// </summary>
    [XmlAttribute]
    [DefaultValue(typeof(byte), "1")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual byte storedCol
    {
        get
        {
            return _storedCol;
        }
        set
        {
            if ((_storedCol.Equals(value) != true))
            {
                _storedCol = value;
                OnPropertyChanged("storedCol", value);
            }
        }
    }
    
    /// <summary>
    /// Minimum number of answer choices (list items) that must be
    /// selected by the user. Default value is 1. NEW: changed minimum value to
    /// 1. Removed: If set to 0, then this question need not be answered by the
    /// user.
    /// </summary>
    [XmlAttribute]
    [DefaultValue(typeof(ushort), "1")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual ushort minSelections
    {
        get
        {
            return _minSelections;
        }
        set
        {
            if ((_minSelections.Equals(value) != true))
            {
                _minSelections = value;
                OnPropertyChanged("minSelections", value);
            }
        }
    }
    
    /// <summary>
    /// Maximum number of answer choices (list items) that can be
    /// selected by the user. Must be greater than or equal to minSelections,
    /// and no larger than the total number of list items. A value of 0
    /// indicates no limit to the number of selected list items (answers). This
    /// effectively means that the question is multi-select. (Abbreviated as QM)
    /// A value of 1 (the default) indicates that the question list is
    /// single-select. (Abbreviated as QS)
    /// </summary>
    [XmlAttribute]
    [DefaultValue(typeof(ushort), "1")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual ushort maxSelections
    {
        get
        {
            return _maxSelections;
        }
        set
        {
            if ((_maxSelections.Equals(value) != true))
            {
                _maxSelections = value;
                OnPropertyChanged("maxSelections", value);
            }
        }
    }
    
    /// <summary>
    /// If false, then the form implementation may change the
    /// order of items in the list.
    /// </summary>
    [XmlAttribute]
    [DefaultValue(true)]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool ordered
    {
        get
        {
            return _ordered;
        }
        set
        {
            if ((_ordered.Equals(value) != true))
            {
                _ordered = value;
                OnPropertyChanged("ordered", value);
            }
        }
    }
    
    /// <summary>
    /// This attribute contains an SDC datatype enumeration. The
    /// selected value is the datatype of the content for all
    /// ListItem/@associatedValue content in the current List. It is used
    /// instead of associatedValueType. This element is used only if the
    /// ListItems are all associated with coded values from a single coding
    /// system. If associatedValueType on a ListItem has a datatype assigned,
    /// then the latter datatype overrides the content in
    /// defaultListItemDataType.
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string defaultListItemDataType
    {
        get
        {
            return _defaultListItemDataType;
        }
        set
        {
            if ((_defaultListItemDataType == value))
            {
                return;
            }
            if (((_defaultListItemDataType == null) 
                        || (_defaultListItemDataType.Equals(value) != true)))
            {
                _defaultListItemDataType = value;
                OnPropertyChanged("defaultListItemDataType", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool ListHeaderTextSpecified
    {
        get
        {
            return _listHeaderTextSpecified;
        }
        set
        {
            _listHeaderTextSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool DefaultCodeSystemSpecified
    {
        get
        {
            return _defaultCodeSystemSpecified;
        }
        set
        {
            _defaultCodeSystemSpecified = value;
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
    public bool IllegalListItemPairingsSpecified
    {
        get
        {
            return _illegalListItemPairingsSpecified;
        }
        set
        {
            _illegalListItemPairingsSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool IllegalCoSelectedListItemsSpecified
    {
        get
        {
            return _illegalCoSelectedListItemsSpecified;
        }
        set
        {
            _illegalCoSelectedListItemsSpecified = value;
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
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool colTextDelimiterSpecified
    {
        get
        {
            return _colTextDelimiterSpecified;
        }
        set
        {
            _colTextDelimiterSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool numColsSpecified
    {
        get
        {
            return _numColsSpecified;
        }
        set
        {
            _numColsSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool storedColSpecified
    {
        get
        {
            return _storedColSpecified;
        }
        set
        {
            _storedColSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool minSelectionsSpecified
    {
        get
        {
            return _minSelectionsSpecified;
        }
        set
        {
            _minSelectionsSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool maxSelectionsSpecified
    {
        get
        {
            return _maxSelectionsSpecified;
        }
        set
        {
            _maxSelectionsSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool orderedSpecified
    {
        get
        {
            return _orderedSpecified;
        }
        set
        {
            _orderedSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool defaultListItemDataTypeSpecified
    {
        get
        {
            return _defaultListItemDataTypeSpecified;
        }
        set
        {
            _defaultListItemDataTypeSpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether IllegalListItemPairings should be serialized
    /// </summary>
    public virtual bool ShouldSerializeIllegalListItemPairings()
    {
        return IllegalListItemPairings != null && IllegalListItemPairings.Count > 0;
    }
    
    /// <summary>
    /// Test whether IllegalCoSelectedListItems should be serialized
    /// </summary>
    public virtual bool ShouldSerializeIllegalCoSelectedListItems()
    {
        return IllegalCoSelectedListItems != null && IllegalCoSelectedListItems.Count > 0;
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
    /// Test whether ListHeaderText should be serialized
    /// </summary>
    public virtual bool ShouldSerializeListHeaderText()
    {
        return (ListHeaderText != null);
    }
    
    /// <summary>
    /// Test whether DefaultCodeSystem should be serialized
    /// </summary>
    public virtual bool ShouldSerializeDefaultCodeSystem()
    {
        return (DefaultCodeSystem != null);
    }
    
    /// <summary>
    /// Test whether Item should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItem()
    {
        return (Item != null);
    }
    
    /// <summary>
    /// Test whether colTextDelimiter should be serialized
    /// </summary>
    public virtual bool ShouldSerializecolTextDelimiter()
    {
        return !string.IsNullOrEmpty(colTextDelimiter);
    }
    
    /// <summary>
    /// Test whether defaultListItemDataType should be serialized
    /// </summary>
    public virtual bool ShouldSerializedefaultListItemDataType()
    {
        return !string.IsNullOrEmpty(defaultListItemDataType);
    }
}
}
#pragma warning restore
