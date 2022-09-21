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
/// BaseType is inherited by all SDC complex types.  It contains attributes for:
/// --@name
/// --@type
/// --@styleClass
/// --@sGuid
/// --@order
/// </summary>
[XmlInclude(typeof(SPARQL_Type))]
[XmlInclude(typeof(ExtensionBaseType))]
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
[XmlInclude(typeof(ActValidateFormType))]
[XmlInclude(typeof(ActPreviewReportType))]
[XmlInclude(typeof(ActShowReportType))]
[XmlInclude(typeof(ActShowMessageType))]
[XmlInclude(typeof(ActShowFormType))]
[XmlInclude(typeof(ActSetAttributeType))]
[XmlInclude(typeof(ActSendReportType))]
[XmlInclude(typeof(ActSaveResponsesType))]
[XmlInclude(typeof(ValidationType))]
[XmlInclude(typeof(RuleAutoSelectType))]
[XmlInclude(typeof(RuleAutoActivateType))]
[XmlInclude(typeof(RulesType))]
[XmlInclude(typeof(ListType))]
[XmlInclude(typeof(ListFieldType))]
[XmlInclude(typeof(DataTypes_DEType))]
[XmlInclude(typeof(ResponseFieldType))]
[XmlInclude(typeof(ListItemResponseFieldType))]
[XmlInclude(typeof(ChildItemsType))]
[XmlInclude(typeof(RuleListItemMatchTargetsType))]
[XmlInclude(typeof(RuleSelectMatchingListItemsType))]
[XmlInclude(typeof(ActActionType))]
[XmlInclude(typeof(ActionsType))]
[XmlInclude(typeof(ItemNameType))]
[XmlInclude(typeof(ActAddCodeType))]
[XmlInclude(typeof(ItemNameAttributeType))]
[XmlInclude(typeof(ScriptCodeBaseType))]
[XmlInclude(typeof(ScriptCodeAnyType))]
[XmlInclude(typeof(ActSetAttrValueScriptType))]
[XmlInclude(typeof(ScriptCodeBoolType))]
[XmlInclude(typeof(ActSetBoolAttributeValueCodeType))]
[XmlInclude(typeof(FuncBoolBaseType))]
[XmlInclude(typeof(PredGuardType))]
[XmlInclude(typeof(PredActionType))]
[XmlInclude(typeof(EventType))]
[XmlInclude(typeof(OnEventType))]
[XmlInclude(typeof(PredAlternativesType))]
[XmlInclude(typeof(PredEvalAttribValuesType))]
[XmlInclude(typeof(PredMultiSelectionSetBoolType))]
[XmlInclude(typeof(PredSingleSelectionSetsType))]
[XmlInclude(typeof(PredSelectionTestType))]
[XmlInclude(typeof(IdentifiedExtensionType))]
[XmlInclude(typeof(FormDesignType))]
[XmlInclude(typeof(DemogFormDesignType))]
[XmlInclude(typeof(InjectFormType))]
[XmlInclude(typeof(ActInjectType))]
[XmlInclude(typeof(DisplayedType))]
[XmlInclude(typeof(ButtonItemType))]
[XmlInclude(typeof(ListItemBaseType))]
[XmlInclude(typeof(ListItemType))]
[XmlInclude(typeof(RepeatingType))]
[XmlInclude(typeof(QuestionItemBaseType))]
[XmlInclude(typeof(QuestionItemType))]
[XmlInclude(typeof(SectionBaseType))]
[XmlInclude(typeof(SectionItemType))]
[XmlInclude(typeof(DataElementType))]
[XmlInclude(typeof(LinkType))]
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
[XmlInclude(typeof(IdentifierType))]
[XmlInclude(typeof(PhoneType))]
[XmlInclude(typeof(EmailType))]
[XmlInclude(typeof(AddressType))]
[XmlInclude(typeof(OrganizationType))]
[XmlInclude(typeof(JobType))]
[XmlInclude(typeof(NameType))]
[XmlInclude(typeof(PersonType))]
[XmlInclude(typeof(ContactType))]
[XmlInclude(typeof(CodeSystemType))]
[XmlInclude(typeof(CodingType))]
[XmlInclude(typeof(ListItemParameterType))]
[XmlInclude(typeof(ParameterItemType))]
[XmlInclude(typeof(CallFuncBaseType))]
[XmlInclude(typeof(CallFuncBoolType))]
[XmlInclude(typeof(CallFuncType))]
[XmlInclude(typeof(LookupEndPointType))]
[XmlInclude(typeof(PhoneNumberType))]
[XmlInclude(typeof(EmailAddressType))]
[XmlInclude(typeof(RichTextType))]
[XmlInclude(typeof(ActSendMessageType))]
[XmlInclude(typeof(BlobType))]
[XmlInclude(typeof(DataTypes_SType))]
[XmlInclude(typeof(ParameterValueType))]
[XmlInclude(typeof(PropertyType))]
[XmlInclude(typeof(ChangeTrackingType))]
[XmlInclude(typeof(ReplacedIDsType))]
[XmlInclude(typeof(CodeMatchType))]
[XmlInclude(typeof(TargetItemNameType))]
[XmlInclude(typeof(CountryCodeType))]
[XmlInclude(typeof(AreaCodeType))]
[XmlInclude(typeof(yearMonthDuration_Stype))]
[XmlInclude(typeof(yearMonthDuration_DEtype))]
[XmlInclude(typeof(XML_Stype))]
[XmlInclude(typeof(XML_DEtype))]
[XmlInclude(typeof(unsignedShort_Stype))]
[XmlInclude(typeof(unsignedShort_DEtype))]
[XmlInclude(typeof(unsignedLong_Stype))]
[XmlInclude(typeof(unsignedLong_DEtype))]
[XmlInclude(typeof(unsignedInt_Stype))]
[XmlInclude(typeof(unsignedInt_DEtype))]
[XmlInclude(typeof(unsignedByte_Stype))]
[XmlInclude(typeof(unsignedByte_DEtype))]
[XmlInclude(typeof(time_Stype))]
[XmlInclude(typeof(time_DEtype))]
[XmlInclude(typeof(string_Stype))]
[XmlInclude(typeof(XPathType))]
[XmlInclude(typeof(XQueryType))]
[XmlInclude(typeof(SQL_Type))]
[XmlInclude(typeof(FileHashType))]
[XmlInclude(typeof(TargetItemXPathType))]
[XmlInclude(typeof(LanguageCodeISO6393_Type))]
[XmlInclude(typeof(UnitsType))]
[XmlInclude(typeof(AcceptabilityType))]
[XmlInclude(typeof(string_DEtype))]
[XmlInclude(typeof(short_Stype))]
[XmlInclude(typeof(short_DEtype))]
[XmlInclude(typeof(positiveInteger_Stype))]
[XmlInclude(typeof(positiveInteger_DEtype))]
[XmlInclude(typeof(nonPositiveInteger_Stype))]
[XmlInclude(typeof(nonPositiveInteger_DEtype))]
[XmlInclude(typeof(nonNegativeInteger_Stype))]
[XmlInclude(typeof(nonNegativeInteger_DEtype))]
[XmlInclude(typeof(negativeInteger_Stype))]
[XmlInclude(typeof(negativeInteger_DEtype))]
[XmlInclude(typeof(long_Stype))]
[XmlInclude(typeof(long_DEtype))]
[XmlInclude(typeof(integer_Stype))]
[XmlInclude(typeof(integer_DEtype))]
[XmlInclude(typeof(int_Stype))]
[XmlInclude(typeof(int_DEtype))]
[XmlInclude(typeof(HTML_Stype))]
[XmlInclude(typeof(HTML_DEtype))]
[XmlInclude(typeof(hexBinary_Stype))]
[XmlInclude(typeof(hexBinary_DEtype))]
[XmlInclude(typeof(gYearMonth_Stype))]
[XmlInclude(typeof(gYearMonth_DEtype))]
[XmlInclude(typeof(gYear_Stype))]
[XmlInclude(typeof(gYear_DEtype))]
[XmlInclude(typeof(gMonthDay_Stype))]
[XmlInclude(typeof(gMonthDay_DEtype))]
[XmlInclude(typeof(gMonth_Stype))]
[XmlInclude(typeof(gMonth_DEtype))]
[XmlInclude(typeof(gDay_Stype))]
[XmlInclude(typeof(gDay_DEtype))]
[XmlInclude(typeof(float_Stype))]
[XmlInclude(typeof(float_DEtype))]
[XmlInclude(typeof(duration_Stype))]
[XmlInclude(typeof(duration_DEtype))]
[XmlInclude(typeof(double_Stype))]
[XmlInclude(typeof(double_DEtype))]
[XmlInclude(typeof(decimal_Stype))]
[XmlInclude(typeof(decimal_DEtype))]
[XmlInclude(typeof(dayTimeDuration_Stype))]
[XmlInclude(typeof(dayTimeDuration_DEtype))]
[XmlInclude(typeof(dateTimeStamp_Stype))]
[XmlInclude(typeof(dateTimeStamp_DEtype))]
[XmlInclude(typeof(dateTime_Stype))]
[XmlInclude(typeof(dateTime_DEtype))]
[XmlInclude(typeof(date_Stype))]
[XmlInclude(typeof(date_DEtype))]
[XmlInclude(typeof(byte_Stype))]
[XmlInclude(typeof(byte_DEtype))]
[XmlInclude(typeof(boolean_Stype))]
[XmlInclude(typeof(boolean_DEtype))]
[XmlInclude(typeof(base64Binary_Stype))]
[XmlInclude(typeof(HashType))]
[XmlInclude(typeof(base64Binary_DEtype))]
[XmlInclude(typeof(anyURI_Stype))]
[XmlInclude(typeof(TargetItemIDType))]
[XmlInclude(typeof(anyURI_DEtype))]
[XmlInclude(typeof(anyType_DEtype))]
[XmlInclude(typeof(CommentType))]
[XmlInclude(typeof(ExtensionType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("BaseType")]
public abstract partial class BaseType : SdcEntityBase
{
    #region Private fields
    protected internal bool _shouldSerializeorder;
    private string _name;
    private string _type;
    private string _styleClass;
    private string _sGuid;
    private decimal _order;
    #endregion
    
    /// <summary>
    /// @name is a developer assigned unique identifier, similar to a unique control/object/variable name, used to provide the ability for programmatic manipulation of an element.  The value of name must be unique within an FDF and FDF-R, even when FDF sections are repeated in the XML.  @name values may begin with a letter or an underscore and may only contain characters that are legal for variable names.  These generally include letters, numbers and underscore.  The use of other characters may result in errors, depending on the programming language employed.  Since XML is case-sensitive, names should not be made unique solely on the basis of alphabetic case, since many programming languages are case insensitive and cannot distinguish names based only on case differences.
    /// </summary>
    [XmlAttribute(DataType="ID")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string name
    {
        get
        {
            return _name;
        }
        set
        {
            if ((_name == value))
            {
                return;
            }
            if (((_name == null) 
                        || (_name.Equals(value) != true)))
            {
                _name = value;
                OnPropertyChanged("name", value);
            }
        }
    }
    
    /// <summary>
    /// The @type attribute can contain custom metadata "tokens" for the element, chosen from a standardized list of terms. Tokens are short alphanumeric text strings, defined by the W3C Schema NMTOKEN specification, that are defined in an Implementation Guide. The type xsd:NMTOKEN represents a single string token. NMTOKEN values may consist of letters, digits, periods ( . ), hyphens ( - ), underscores ( _ ), and colons ( : ). They may start with any of these characters. (www.datypic.com/sc/xsd/t-xsd_NMTOKEN.html) @type tokens may be specific for one or more kinds of SDC elements. Multiple tokens in the type attribute should be separated by whitespace. Type tokens may be used to specify special handling by an application, and are usually used to define form display constraints, but may include other custom metadata as well. Style metadata should generally be handled with @styleClass rather than @type. @type token examples include: tooltip, statusLineText, alignTopLeft, align:bottom, _pageBreak-after, etc. @type metadata should generally not affect the information content of a form.
    /// </summary>
    [XmlAttribute(DataType="NMTOKENS")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string type
    {
        get
        {
            return _type;
        }
        set
        {
            if ((_type == value))
            {
                return;
            }
            if (((_type == null) 
                        || (_type.Equals(value) != true)))
            {
                _type = value;
                OnPropertyChanged("type", value);
            }
        }
    }
    
    /// <summary>
    /// @styleClass is a developer assigned class name for display styling, generally for use with an external style sheet..
    /// </summary>
    [XmlAttribute(DataType="NMTOKENS")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string styleClass
    {
        get
        {
            return _styleClass;
        }
        set
        {
            if ((_styleClass == value))
            {
                return;
            }
            if (((_styleClass == null) 
                        || (_styleClass.Equals(value) != true)))
            {
                _styleClass = value;
                OnPropertyChanged("styleClass", value);
            }
        }
    }
    
    /// <summary>
    /// New 2022_06_02:
    /// Short GUID created from a regular 128-bit GUID, by:
    /// Removing the final "==",
    /// replacing "/" with "_",
    /// replacing "+" with "-",
    /// and then Base 64-encoding the result.
    /// The length is always 22 characters, obeying the following regex pattern:
    /// [A-Za-z0-9\-_]{22}
    /// </summary>
    [XmlAttribute]
    [RegularExpressionAttribute("[A-Za-z0-9\\-_]{22}")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string sGuid
    {
        get
        {
            return _sGuid;
        }
        set
        {
            if ((_sGuid == value))
            {
                return;
            }
            if (((_sGuid == null) 
                        || (_sGuid.Equals(value) != true)))
            {
                ValidationContext validatorPropContext = new ValidationContext(this, null, null);
                validatorPropContext.MemberName = "sGuid";
                Validator.ValidateProperty(value, validatorPropContext);
                _sGuid = value;
                OnPropertyChanged("sGuid", value);
            }
        }
    }
    
    /// <summary>
    /// @order is a decimal attribute that allows the form template developer to define a sequential order for elements in a template. This serves the purpose of providing a definitive/original order to sections, questions, answer choices, etc., when required for display purposes. This is important when the original XML ordering may become disrupted due to the use of an implementation technology that does not natively support ordering (e.g., object collections), and it can also provide a check on the proper importing of the XML tree during implementation.
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual decimal order
    {
        get
        {
            return _order;
        }
        set
        {
            if ((_order.Equals(value) != true))
            {
                _order = value;
                OnPropertyChanged("order", value);
            }
            _shouldSerializeorder = true;
        }
    }
    
    /// <summary>
    /// Test whether order should be serialized
    /// </summary>
    public virtual bool ShouldSerializeorder()
    {
        if (_shouldSerializeorder)
        {
            return true;
        }
        return (_order != default(decimal));
    }
    
    /// <summary>
    /// Test whether name should be serialized
    /// </summary>
    public virtual bool ShouldSerializename()
    {
        return !string.IsNullOrEmpty(name);
    }
    
    /// <summary>
    /// Test whether type should be serialized
    /// </summary>
    public virtual bool ShouldSerializetype()
    {
        return !string.IsNullOrEmpty(type);
    }
    
    /// <summary>
    /// Test whether styleClass should be serialized
    /// </summary>
    public virtual bool ShouldSerializestyleClass()
    {
        return !string.IsNullOrEmpty(styleClass);
    }
    
    /// <summary>
    /// Test whether sGuid should be serialized
    /// </summary>
    public virtual bool ShouldSerializesGuid()
    {
        return !string.IsNullOrEmpty(sGuid);
    }
}
}
#pragma warning restore
