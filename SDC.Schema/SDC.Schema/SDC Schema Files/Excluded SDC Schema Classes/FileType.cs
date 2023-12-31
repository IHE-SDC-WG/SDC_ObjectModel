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
/// Information about a file, usually thought of as a binary byte stream
/// stored on disk. A FileType can also represent a "virtual" file, such as an XML
/// module in a larger XML document. Such a virtual file could theoretically be stored
/// as a byte stream, as an independant file on disk or as a database record or set of
/// records, even if this byte stream is never actually persisted as an independant disk
/// file.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("FileType")]
public partial class FileType : ExtensionBaseType
{
    #region Private fields
    private string_Stype _fileID;
    private anyURI_Stype _fileURI;
    private string_Stype _displayName;
    private string_Stype _title;
    private VersionType _version;
    private string_Stype _fileName;
    private string_Stype _fileExtension;
    private string_Stype _fileClass;
    private positiveInteger_Stype _fileSizeKB;
    private List<string_Stype> _description;
    private string_Stype _copyright;
    private string_Stype _termsofUse;
    private FileUsageType _usage;
    private FileDatesType _dates;
    private ContactsType _contacts;
    private List<ApprovalType> _approval;
    private FileHashType _fileHash;
    private List<LanguageType> _language;
    private AssociatedFilesType _associatedFiles;
    private ProvenanceType _provenance;
    private List<SubmissionRuleType> _defaultSubmissionRule;
    private List<ComplianceRuleType> _defaultComplianceRule;
    #endregion
    
    /// <summary>
    /// Internal/local File ID, not necessarily in the format
    /// of the FileURI used for all SDC FormDesign items.
    /// </summary>
    [XmlElement(Order=0)]
    [JsonProperty(Order=0, NullValueHandling=NullValueHandling.Ignore)]
    public virtual string_Stype FileID
    {
        get
        {
            return _fileID;
        }
        set
        {
            if ((_fileID == value))
            {
                return;
            }
            if (((_fileID == null) 
                        || (_fileID.Equals(value) != true)))
            {
                _fileID = value;
                OnPropertyChanged("FileID", value);
            }
        }
    }
    
    [XmlElement(Order=1)]
    [RequiredAttribute()]
    [JsonProperty(Order=1, NullValueHandling=NullValueHandling.Ignore)]
    public virtual anyURI_Stype FileURI
    {
        get
        {
            return _fileURI;
        }
        set
        {
            if ((_fileURI == value))
            {
                return;
            }
            if (((_fileURI == null) 
                        || (_fileURI.Equals(value) != true)))
            {
                ValidationContext validatorPropContext = new ValidationContext(this, null, null);
                validatorPropContext.MemberName = "FileURI";
                Validator.ValidateProperty(value, validatorPropContext);
                _fileURI = value;
                OnPropertyChanged("FileURI", value);
            }
        }
    }
    
    /// <summary>
    /// Text to be displayed that encapulates the file
    /// contents. This may be the same as the internal Title of the
    /// file.
    /// </summary>
    [XmlElement(Order=2)]
    [JsonProperty(Order=2, NullValueHandling=NullValueHandling.Ignore)]
    public virtual string_Stype DisplayName
    {
        get
        {
            return _displayName;
        }
        set
        {
            if ((_displayName == value))
            {
                return;
            }
            if (((_displayName == null) 
                        || (_displayName.Equals(value) != true)))
            {
                _displayName = value;
                OnPropertyChanged("DisplayName", value);
            }
        }
    }
    
    /// <summary>
    /// Official title of the file.
    /// </summary>
    [XmlElement(Order=3)]
    [JsonProperty(Order=3, NullValueHandling=NullValueHandling.Ignore)]
    public virtual string_Stype Title
    {
        get
        {
            return _title;
        }
        set
        {
            if ((_title == value))
            {
                return;
            }
            if (((_title == null) 
                        || (_title.Equals(value) != true)))
            {
                _title = value;
                OnPropertyChanged("Title", value);
            }
        }
    }
    
    /// <summary>
    /// File version
    /// </summary>
    [XmlElement(Order=4)]
    [JsonProperty(Order=4, NullValueHandling=NullValueHandling.Ignore)]
    public virtual VersionType Version
    {
        get
        {
            return _version;
        }
        set
        {
            if ((_version == value))
            {
                return;
            }
            if (((_version == null) 
                        || (_version.Equals(value) != true)))
            {
                _version = value;
                OnPropertyChanged("Version", value);
            }
        }
    }
    
    /// <summary>
    /// The name of the file as saved on disk or other persistant storage.
    /// </summary>
    [XmlElement(Order=5)]
    [JsonProperty(Order=5, NullValueHandling=NullValueHandling.Ignore)]
    public virtual string_Stype FileName
    {
        get
        {
            return _fileName;
        }
        set
        {
            if ((_fileName == value))
            {
                return;
            }
            if (((_fileName == null) 
                        || (_fileName.Equals(value) != true)))
            {
                _fileName = value;
                OnPropertyChanged("FileName", value);
            }
        }
    }
    
    /// <summary>
    /// The file type extension that describes the file's
    /// internal format. This is usually the 3-4 character text that appears
    /// after the last period in the file name, e.g., txt, docx,
    /// etc.
    /// </summary>
    [XmlElement(Order=6)]
    [JsonProperty(Order=6, NullValueHandling=NullValueHandling.Ignore)]
    public virtual string_Stype FileExtension
    {
        get
        {
            return _fileExtension;
        }
        set
        {
            if ((_fileExtension == value))
            {
                return;
            }
            if (((_fileExtension == null) 
                        || (_fileExtension.Equals(value) != true)))
            {
                _fileExtension = value;
                OnPropertyChanged("FileExtension", value);
            }
        }
    }
    
    /// <summary>
    /// A short description of the class of file, such as "FormDesign XML"
    /// </summary>
    [XmlElement(Order=7)]
    [JsonProperty(Order=7, NullValueHandling=NullValueHandling.Ignore)]
    public virtual string_Stype FileClass
    {
        get
        {
            return _fileClass;
        }
        set
        {
            if ((_fileClass == value))
            {
                return;
            }
            if (((_fileClass == null) 
                        || (_fileClass.Equals(value) != true)))
            {
                _fileClass = value;
                OnPropertyChanged("FileClass", value);
            }
        }
    }
    
    [XmlElement(Order=8)]
    [JsonProperty(Order=8, NullValueHandling=NullValueHandling.Ignore)]
    public virtual positiveInteger_Stype FileSizeKB
    {
        get
        {
            return _fileSizeKB;
        }
        set
        {
            if ((_fileSizeKB == value))
            {
                return;
            }
            if (((_fileSizeKB == null) 
                        || (_fileSizeKB.Equals(value) != true)))
            {
                _fileSizeKB = value;
                OnPropertyChanged("FileSizeKB", value);
            }
        }
    }
    
    /// <summary>
    /// Any additional information about the template or file. The type of information should be specified in the @type
    /// attribute.
    /// </summary>
    [XmlElement("Description", Order=9)]
    [JsonProperty(Order=9, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<string_Stype> Description
    {
        get
        {
            return _description;
        }
        set
        {
            if ((_description == value))
            {
                return;
            }
            if (((_description == null) 
                        || (_description.Equals(value) != true)))
            {
                _description = value;
                OnPropertyChanged("Description", value);
            }
        }
    }
    
    [XmlElement(Order=10)]
    [JsonProperty(Order=10, NullValueHandling=NullValueHandling.Ignore)]
    public virtual string_Stype Copyright
    {
        get
        {
            return _copyright;
        }
        set
        {
            if ((_copyright == value))
            {
                return;
            }
            if (((_copyright == null) 
                        || (_copyright.Equals(value) != true)))
            {
                _copyright = value;
                OnPropertyChanged("Copyright", value);
            }
        }
    }
    
    [XmlElement(Order=11)]
    [JsonProperty(Order=11, NullValueHandling=NullValueHandling.Ignore)]
    public virtual string_Stype TermsofUse
    {
        get
        {
            return _termsofUse;
        }
        set
        {
            if ((_termsofUse == value))
            {
                return;
            }
            if (((_termsofUse == null) 
                        || (_termsofUse.Equals(value) != true)))
            {
                _termsofUse = value;
                OnPropertyChanged("TermsofUse", value);
            }
        }
    }
    
    /// <summary>
    /// Guidance for when this file should be used, and when it should not be used.
    /// </summary>
    [XmlElement(Order=12)]
    [JsonProperty(Order=12, NullValueHandling=NullValueHandling.Ignore)]
    public virtual FileUsageType Usage
    {
        get
        {
            return _usage;
        }
        set
        {
            if ((_usage == value))
            {
                return;
            }
            if (((_usage == null) 
                        || (_usage.Equals(value) != true)))
            {
                _usage = value;
                OnPropertyChanged("Usage", value);
            }
        }
    }
    
    /// <summary>
    /// Various dates associated with the file release, versioning and usage.
    /// </summary>
    [XmlElement(Order=13)]
    [JsonProperty(Order=13, NullValueHandling=NullValueHandling.Ignore)]
    public virtual FileDatesType Dates
    {
        get
        {
            return _dates;
        }
        set
        {
            if ((_dates == value))
            {
                return;
            }
            if (((_dates == null) 
                        || (_dates.Equals(value) != true)))
            {
                _dates = value;
                OnPropertyChanged("Dates", value);
            }
        }
    }
    
    /// <summary>
    /// People and Organizations associated with the file.
    /// Specify the type of Contact in the @type attribute. Examples of
    /// @type include Curator, Author, and Authority.
    /// </summary>
    [XmlElement(Order=14)]
    [JsonProperty(Order=14, NullValueHandling=NullValueHandling.Ignore)]
    public virtual ContactsType Contacts
    {
        get
        {
            return _contacts;
        }
        set
        {
            if ((_contacts == value))
            {
                return;
            }
            if (((_contacts == null) 
                        || (_contacts.Equals(value) != true)))
            {
                _contacts = value;
                OnPropertyChanged("Contacts", value);
            }
        }
    }
    
    /// <summary>
    /// Documentation of review and acceptance of the file for production usage.
    /// </summary>
    [XmlElement("Approval", Order=15)]
    [JsonProperty(Order=15, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<ApprovalType> Approval
    {
        get
        {
            return _approval;
        }
        set
        {
            if ((_approval == value))
            {
                return;
            }
            if (((_approval == null) 
                        || (_approval.Equals(value) != true)))
            {
                _approval = value;
                OnPropertyChanged("Approval", value);
            }
        }
    }
    
    [XmlElement(Order=16)]
    [JsonProperty(Order=16, NullValueHandling=NullValueHandling.Ignore)]
    public virtual FileHashType FileHash
    {
        get
        {
            return _fileHash;
        }
        set
        {
            if ((_fileHash == value))
            {
                return;
            }
            if (((_fileHash == null) 
                        || (_fileHash.Equals(value) != true)))
            {
                _fileHash = value;
                OnPropertyChanged("FileHash", value);
            }
        }
    }
    
    [XmlElement("Language", Order=17)]
    [JsonProperty(Order=17, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<LanguageType> Language
    {
        get
        {
            return _language;
        }
        set
        {
            if ((_language == value))
            {
                return;
            }
            if (((_language == null) 
                        || (_language.Equals(value) != true)))
            {
                _language = value;
                OnPropertyChanged("Language", value);
            }
        }
    }
    
    /// <summary>
    /// Link to any associated files, such as schemas, reference documents, manuals, etc.
    /// </summary>
    [XmlElement(Order=18)]
    [JsonProperty(Order=18, NullValueHandling=NullValueHandling.Ignore)]
    public virtual AssociatedFilesType AssociatedFiles
    {
        get
        {
            return _associatedFiles;
        }
        set
        {
            if ((_associatedFiles == value))
            {
                return;
            }
            if (((_associatedFiles == null) 
                        || (_associatedFiles.Equals(value) != true)))
            {
                _associatedFiles = value;
                OnPropertyChanged("AssociatedFiles", value);
            }
        }
    }
    
    [XmlElement(Order=19)]
    [JsonProperty(Order=19, NullValueHandling=NullValueHandling.Ignore)]
    public virtual ProvenanceType Provenance
    {
        get
        {
            return _provenance;
        }
        set
        {
            if ((_provenance == value))
            {
                return;
            }
            if (((_provenance == null) 
                        || (_provenance.Equals(value) != true)))
            {
                _provenance = value;
                OnPropertyChanged("Provenance", value);
            }
        }
    }
    
    [XmlElement("DefaultSubmissionRule", Order=20)]
    [JsonProperty(Order=20, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<SubmissionRuleType> DefaultSubmissionRule
    {
        get
        {
            return _defaultSubmissionRule;
        }
        set
        {
            if ((_defaultSubmissionRule == value))
            {
                return;
            }
            if (((_defaultSubmissionRule == null) 
                        || (_defaultSubmissionRule.Equals(value) != true)))
            {
                _defaultSubmissionRule = value;
                OnPropertyChanged("DefaultSubmissionRule", value);
            }
        }
    }
    
    [XmlElement("DefaultComplianceRule", Order=21)]
    [JsonProperty(Order=21, NullValueHandling=NullValueHandling.Ignore)]
    public virtual List<ComplianceRuleType> DefaultComplianceRule
    {
        get
        {
            return _defaultComplianceRule;
        }
        set
        {
            if ((_defaultComplianceRule == value))
            {
                return;
            }
            if (((_defaultComplianceRule == null) 
                        || (_defaultComplianceRule.Equals(value) != true)))
            {
                _defaultComplianceRule = value;
                OnPropertyChanged("DefaultComplianceRule", value);
            }
        }
    }
    
    /// <summary>
    /// Test whether Description should be serialized
    /// </summary>
    public virtual bool ShouldSerializeDescription()
    {
        return Description != null && Description.Count > 0;
    }
    
    /// <summary>
    /// Test whether Approval should be serialized
    /// </summary>
    public virtual bool ShouldSerializeApproval()
    {
        return Approval != null && Approval.Count > 0;
    }
    
    /// <summary>
    /// Test whether Language should be serialized
    /// </summary>
    public virtual bool ShouldSerializeLanguage()
    {
        return Language != null && Language.Count > 0;
    }
    
    /// <summary>
    /// Test whether DefaultSubmissionRule should be serialized
    /// </summary>
    public virtual bool ShouldSerializeDefaultSubmissionRule()
    {
        return DefaultSubmissionRule != null && DefaultSubmissionRule.Count > 0;
    }
    
    /// <summary>
    /// Test whether DefaultComplianceRule should be serialized
    /// </summary>
    public virtual bool ShouldSerializeDefaultComplianceRule()
    {
        return DefaultComplianceRule != null && DefaultComplianceRule.Count > 0;
    }
    
    /// <summary>
    /// Test whether FileID should be serialized
    /// </summary>
    public virtual bool ShouldSerializeFileID()
    {
        return (_fileID != null);
    }
    
    /// <summary>
    /// Test whether FileURI should be serialized
    /// </summary>
    public virtual bool ShouldSerializeFileURI()
    {
        return (_fileURI != null);
    }
    
    /// <summary>
    /// Test whether DisplayName should be serialized
    /// </summary>
    public virtual bool ShouldSerializeDisplayName()
    {
        return (_displayName != null);
    }
    
    /// <summary>
    /// Test whether Title should be serialized
    /// </summary>
    public virtual bool ShouldSerializeTitle()
    {
        return (_title != null);
    }
    
    /// <summary>
    /// Test whether Version should be serialized
    /// </summary>
    public virtual bool ShouldSerializeVersion()
    {
        return (_version != null);
    }
    
    /// <summary>
    /// Test whether FileName should be serialized
    /// </summary>
    public virtual bool ShouldSerializeFileName()
    {
        return (_fileName != null);
    }
    
    /// <summary>
    /// Test whether FileExtension should be serialized
    /// </summary>
    public virtual bool ShouldSerializeFileExtension()
    {
        return (_fileExtension != null);
    }
    
    /// <summary>
    /// Test whether FileClass should be serialized
    /// </summary>
    public virtual bool ShouldSerializeFileClass()
    {
        return (_fileClass != null);
    }
    
    /// <summary>
    /// Test whether FileSizeKB should be serialized
    /// </summary>
    public virtual bool ShouldSerializeFileSizeKB()
    {
        return (_fileSizeKB != null);
    }
    
    /// <summary>
    /// Test whether Copyright should be serialized
    /// </summary>
    public virtual bool ShouldSerializeCopyright()
    {
        return (_copyright != null);
    }
    
    /// <summary>
    /// Test whether TermsofUse should be serialized
    /// </summary>
    public virtual bool ShouldSerializeTermsofUse()
    {
        return (_termsofUse != null);
    }
    
    /// <summary>
    /// Test whether Usage should be serialized
    /// </summary>
    public virtual bool ShouldSerializeUsage()
    {
        return (_usage != null);
    }
    
    /// <summary>
    /// Test whether Dates should be serialized
    /// </summary>
    public virtual bool ShouldSerializeDates()
    {
        return (_dates != null);
    }
    
    /// <summary>
    /// Test whether Contacts should be serialized
    /// </summary>
    public virtual bool ShouldSerializeContacts()
    {
        return (_contacts != null);
    }
    
    /// <summary>
    /// Test whether FileHash should be serialized
    /// </summary>
    public virtual bool ShouldSerializeFileHash()
    {
        return (_fileHash != null);
    }
    
    /// <summary>
    /// Test whether AssociatedFiles should be serialized
    /// </summary>
    public virtual bool ShouldSerializeAssociatedFiles()
    {
        return (_associatedFiles != null);
    }
    
    /// <summary>
    /// Test whether Provenance should be serialized
    /// </summary>
    public virtual bool ShouldSerializeProvenance()
    {
        return (_provenance != null);
    }
}
}
#pragma warning restore
