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

[XmlInclude(typeof(PackageListType))]
[XmlInclude(typeof(PackageItemType))]
[XmlInclude(typeof(XMLPackageType))]
[XmlInclude(typeof(HTMLPackageType))]
[XmlInclude(typeof(BasePackageType))]
[XmlInclude(typeof(RetrieveFormPackageType))]
[XmlInclude(typeof(DataStoreType))]
[XmlInclude(typeof(DataSourceType))]
[XmlInclude(typeof(TemplateTargetType))]
[XmlInclude(typeof(ItemMapType))]
[XmlInclude(typeof(MappingType))]
[XmlInclude(typeof(RegisteredItemStateType))]
[XmlInclude(typeof(RegisteredItemType))]
[XmlInclude(typeof(InterfaceType))]
[XmlInclude(typeof(RegistrySummaryType))]
[XmlInclude(typeof(RegistryType))]
[XmlInclude(typeof(TemplateAdminType))]
[XmlInclude(typeof(DataTypesDateTime_SType))]
[XmlInclude(typeof(DataTypesDateTime_DEType))]
[XmlInclude(typeof(DataTypesNumeric_SType))]
[XmlInclude(typeof(DataTypesNumeric_DEType))]
[XmlInclude(typeof(ChangeType))]
[XmlInclude(typeof(ComplianceRuleType))]
[XmlInclude(typeof(DestinationType))]
[XmlInclude(typeof(SubmissionRuleType))]
[XmlInclude(typeof(ProvenanceType))]
[XmlInclude(typeof(AssociatedFilesType))]
[XmlInclude(typeof(LanguageType))]
[XmlInclude(typeof(ApprovalType))]
[XmlInclude(typeof(FileDatesType))]
[XmlInclude(typeof(FileUsageType))]
[XmlInclude(typeof(ContactsType))]
[XmlInclude(typeof(ChangedFieldType))]
[XmlInclude(typeof(ChangeLogType))]
[XmlInclude(typeof(VersionType))]
[XmlInclude(typeof(FileType))]
[XmlInclude(typeof(ActValidateFormType))]
[XmlInclude(typeof(ActPreviewReportType))]
[XmlInclude(typeof(ActShowReportType))]
[XmlInclude(typeof(ActShowMessageType))]
[XmlInclude(typeof(ActShowFormType))]
[XmlInclude(typeof(ActSetAttributeType))]
[XmlInclude(typeof(ActSendReportType))]
[XmlInclude(typeof(ActSaveResponsesType))]
[XmlInclude(typeof(RuleAutoSelectType))]
[XmlInclude(typeof(RuleAutoActivateType))]
[XmlInclude(typeof(ValidationType))]
[XmlInclude(typeof(RulesType))]
[XmlInclude(typeof(ListType))]
[XmlInclude(typeof(ListFieldType))]
[XmlInclude(typeof(ChildItemsType))]
[XmlInclude(typeof(DataTypes_DEType))]
[XmlInclude(typeof(ResponseFieldType))]
[XmlInclude(typeof(ListItemResponseFieldType))]
[XmlInclude(typeof(ScriptCodeBaseType))]
[XmlInclude(typeof(ScriptCodeAnyType))]
[XmlInclude(typeof(ActSetAttrValueScriptType))]
[XmlInclude(typeof(ScriptCodeBoolType))]
[XmlInclude(typeof(ScriptBoolFuncActionType))]
[XmlInclude(typeof(ActSetBoolAttributeValueCodeType))]
[XmlInclude(typeof(IdentifierType))]
[XmlInclude(typeof(PhoneType))]
[XmlInclude(typeof(EmailType))]
[XmlInclude(typeof(AddressType))]
[XmlInclude(typeof(OrganizationType))]
[XmlInclude(typeof(JobType))]
[XmlInclude(typeof(NameType))]
[XmlInclude(typeof(PersonType))]
[XmlInclude(typeof(ContactType))]
[XmlInclude(typeof(LinkType))]
[XmlInclude(typeof(IdentifiedExtensionType))]
[XmlInclude(typeof(FormDesignType))]
[XmlInclude(typeof(InjectFormType))]
[XmlInclude(typeof(ActInjectType))]
[XmlInclude(typeof(DisplayedType))]
[XmlInclude(typeof(ButtonItemType))]
[XmlInclude(typeof(RepeatingType))]
[XmlInclude(typeof(QuestionItemBaseType))]
[XmlInclude(typeof(QuestionItemType))]
[XmlInclude(typeof(SectionBaseType))]
[XmlInclude(typeof(SectionItemType))]
[XmlInclude(typeof(ListItemBaseType))]
[XmlInclude(typeof(ListItemType))]
[XmlInclude(typeof(DataElementType))]
[XmlInclude(typeof(RuleListItemMatchTargetsType))]
[XmlInclude(typeof(CodeSystemType))]
[XmlInclude(typeof(CodingType))]
[XmlInclude(typeof(ItemNameType))]
[XmlInclude(typeof(ActAddCodeType))]
[XmlInclude(typeof(ItemNameAttributeType))]
[XmlInclude(typeof(RuleSelectMatchingListItemsType))]
[XmlInclude(typeof(ActActionType))]
[XmlInclude(typeof(ActionsType))]
[XmlInclude(typeof(FuncBoolBaseType))]
[XmlInclude(typeof(PredAlternativesType))]
[XmlInclude(typeof(PredGuardType))]
[XmlInclude(typeof(PredMultiSelectionSetBoolType))]
[XmlInclude(typeof(MultiSelectionsActionType))]
[XmlInclude(typeof(PredEvalAttribValuesType))]
[XmlInclude(typeof(AttributeEvalActionType))]
[XmlInclude(typeof(PredActionType))]
[XmlInclude(typeof(EventType))]
[XmlInclude(typeof(OnEventType))]
[XmlInclude(typeof(PredSingleSelectionSetsType))]
[XmlInclude(typeof(SelectionSetsActionType))]
[XmlInclude(typeof(PredSelectionTestType))]
[XmlInclude(typeof(SelectionTestActionType))]
[XmlInclude(typeof(ListItemParameterType))]
[XmlInclude(typeof(ParameterItemType))]
[XmlInclude(typeof(CallFuncBaseType))]
[XmlInclude(typeof(CallFuncBoolType))]
[XmlInclude(typeof(CallFuncBoolActionType))]
[XmlInclude(typeof(CallFuncType))]
[XmlInclude(typeof(CallFuncActionType))]
[XmlInclude(typeof(LookupEndPointType))]
[XmlInclude(typeof(PhoneNumberType))]
[XmlInclude(typeof(EmailAddressType))]
[XmlInclude(typeof(RichTextType))]
[XmlInclude(typeof(ActSendMessageType))]
[XmlInclude(typeof(BlobType))]
[XmlInclude(typeof(DataTypes_SType))]
[XmlInclude(typeof(ParameterValueType))]
[XmlInclude(typeof(PropertyType1))]
[XmlInclude(typeof(PropertyType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("ExtensionBaseType")]
public abstract partial class ExtensionBaseType : BaseType
{
    #region Private fields
    private List<CommentType> _comment;
    private List<ExtensionType> _extension;
    private List<PropertyType> _property;
    private bool _commentSpecified;
    private bool _extensionSpecified;
    private bool _propertySpecified;
    #endregion
    
    [XmlElement("Comment", Order=0)]
    [JsonProperty(Order=0, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<CommentType> Comment
    {
        get
        {
            return _comment;
        }
        set
        {
            if ((_comment == value))
            {
                return;
            }
            if (((_comment == null) 
                        || (_comment.Equals(value) != true)))
            {
                _comment = value;
                OnPropertyChanged("Comment", value);
            }
        }
    }
    
    [XmlElement("Extension", Order=1)]
    [JsonProperty(Order=1, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<ExtensionType> Extension
    {
        get
        {
            return _extension;
        }
        set
        {
            if ((_extension == value))
            {
                return;
            }
            if (((_extension == null) 
                        || (_extension.Equals(value) != true)))
            {
                _extension = value;
                OnPropertyChanged("Extension", value);
            }
        }
    }
    
    [XmlElement("Property", Order=2)]
    [JsonProperty(Order=2, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<PropertyType> Property
    {
        get
        {
            return _property;
        }
        set
        {
            if ((_property == value))
            {
                return;
            }
            if (((_property == null) 
                        || (_property.Equals(value) != true)))
            {
                _property = value;
                OnPropertyChanged("Property", value);
            }
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool CommentSpecified
    {
        get
        {
            return _commentSpecified;
        }
        set
        {
            _commentSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool ExtensionSpecified
    {
        get
        {
            return _extensionSpecified;
        }
        set
        {
            _extensionSpecified = value;
        }
    }
    
    [JsonIgnore]
    [XmlIgnore()]
    public bool PropertySpecified
    {
        get
        {
            return _propertySpecified;
        }
        set
        {
            _propertySpecified = value;
        }
    }
    
    /// <summary>
    /// Test whether Comment should be serialized
    /// </summary>
    public virtual bool ShouldSerializeComment()
    {
        return Comment != null && Comment.Count > 0;
    }
    
    /// <summary>
    /// Test whether Extension should be serialized
    /// </summary>
    public virtual bool ShouldSerializeExtension()
    {
        return Extension != null && Extension.Count > 0;
    }
    
    /// <summary>
    /// Test whether Property should be serialized
    /// </summary>
    public virtual bool ShouldSerializeProperty()
    {
        return Property != null && Property.Count > 0;
    }
}
}
#pragma warning restore