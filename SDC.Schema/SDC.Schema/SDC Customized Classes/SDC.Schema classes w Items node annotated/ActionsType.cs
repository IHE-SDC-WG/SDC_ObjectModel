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
/// Can hold one or more of the following:
/// --Action (ActActionType)
/// --AddCode (ActAddCodeType)
/// --CallFunction (CallFuncActionType)
/// --ConditionalGroupAction (PredActionType)
/// --Inject (ActInjectType)
/// --PreviewReport (ActPreviewReportType)
/// --RunCode (ScriptCodeAnyType)
/// --Save (ActSaveResponsesType)
/// --SelectMatchingListItems (RuleSelectMatchingListItemsType)
/// --SendMessage111 (ActSendMessageType)
/// --SendReport (ActSendReportType)
/// --SetAttributeValue (ActSetAttributeType)
/// --SetAttributeValueScript (ActSetAttrValueScriptType)
/// --SetBoolAttributeValueCode (ActSetBoolAttributeValueCodeType)
/// --ShowForm (ActShowFormType)
/// --ShowMessage (ActShowMessageType)
/// --ShowReport (ActShowReportType)
/// --ShowURL (CallFuncActionType)
/// --ValidateForm (ActValidateFormType)
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("ActionsType")]
public partial class ActionsType : ExtensionBaseType
{
    #region Private fields
    private ExtensionBaseType[] _items;
    private ItemsChoiceType[] _itemsElementName;
    #endregion
    
    [XmlElement("Action", typeof(ActActionType), Order=0)]
    [XmlElement("AddCode", typeof(ActAddCodeType), Order=0)]
    [XmlElement("CallFunction", typeof(CallFuncType), Order=0)]
    [XmlElement("ConditionalGroupAction", typeof(PredActionType), Order=0)]
    [XmlElement("Inject", typeof(ActInjectType), Order=0)]
    [XmlElement("PreviewReport", typeof(ActPreviewReportType), Order=0)]
    [XmlElement("RunCode", typeof(ScriptCodeAnyType), Order=0)]
    [XmlElement("Save", typeof(ActSaveResponsesType), Order=0)]
    [XmlElement("SelectMatchingListItems", typeof(RuleSelectMatchingListItemsType), Order=0)]
    [XmlElement("SendMessage111", typeof(ActSendMessageType), Order=0)]
    [XmlElement("SendReport", typeof(ActSendReportType), Order=0)]
    [XmlElement("SetAttributeValue", typeof(ActSetAttributeType), Order=0)]
    [XmlElement("SetAttributeValueScript", typeof(ActSetAttrValueScriptType), Order=0)]
    [XmlElement("SetBoolAttributeValueCode", typeof(ActSetBoolAttributeValueCodeType), Order=0)]
    [XmlElement("ShowForm", typeof(ActShowFormType), Order=0)]
    [XmlElement("ShowMessage", typeof(ActShowMessageType), Order=0)]
    [XmlElement("ShowReport", typeof(ActShowReportType), Order=0)]
    [XmlElement("ShowURL", typeof(CallFuncType), Order=0)]
    [XmlElement("ValidateForm", typeof(ActValidateFormType), Order=0)]
    [XmlChoiceIdentifierAttribute("ItemsElementName")]
        /// <summary>
        /// Can hold one or more of the following:
        /// --Action (ActActionType)
        /// --AddCode (ActAddCodeType)
        /// --CallFunction (CallFuncActionType)
        /// --ConditionalGroupAction (PredActionType)
        /// --Inject (ActInjectType)
        /// --PreviewReport (ActPreviewReportType)
        /// --RunCode (ScriptCodeAnyType)
        /// --Save (ActSaveResponsesType)
        /// --SelectMatchingListItems (RuleSelectMatchingListItemsType)
        /// --SendMessage111 (ActSendMessageType)
        /// --SendReport (ActSendReportType)
        /// --SetAttributeValue (ActSetAttributeType)
        /// --SetAttributeValueScript (ActSetAttrValueScriptType)
        /// --SetBoolAttributeValueCode (ActSetBoolAttributeValueCodeType)
        /// --ShowForm (ActShowFormType)
        /// --ShowMessage (ActShowMessageType)
        /// --ShowReport (ActShowReportType)
        /// --ShowURL (CallFuncActionType)
        /// --ValidateForm (ActValidateFormType)
        /// </summary>
        public virtual ExtensionBaseType[] Items
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
    
    [XmlElement("ItemsElementName", Order=1)]
    [XmlIgnore]
    public virtual ItemsChoiceType[] ItemsElementName
    {
        get
        {
            return _itemsElementName;
        }
        set
        {
            if ((_itemsElementName == value))
            {
                return;
            }
            if (((_itemsElementName == null) 
                        || (_itemsElementName.Equals(value) != true)))
            {
                _itemsElementName = value;
                OnPropertyChanged("ItemsElementName", value);
            }
        }
    }
}
}
#pragma warning restore
