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
/// This type contains a URI link to an SDC XMLPackage
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("PackageItemType")]
public partial class PackageItemType : ExtensionBaseType
{
    #region Private fields
    protected internal bool _shouldSerializeformat;
    protected internal bool _shouldSerializenewData;
    protected internal bool _shouldSerializechangedData;
    private string _formManagerURI;
    private PackageItemTypeFormat _format;
    private string _packageID;
    private string _title;
    private string _baseURI;
    private string _filename;
    private string _basedOnURI;
    private string _lineage;
    private string _version;
    private string _fullURI;
    private string _prevVersionURI;
    private string _formInstanceURI;
    private string _formInstanceVersionURI;
    private string _formPreviousInstanceVersionURI;
    private bool _changedData;
    private bool _newData;
    #endregion
    
    /// <summary>
    /// NEW
    /// </summary>
    [XmlAttribute(DataType="anyURI")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string formManagerURI
    {
        get
        {
            return _formManagerURI;
        }
        set
        {
            if ((_formManagerURI == value))
            {
                return;
            }
            if (((_formManagerURI == null) 
                        || (_formManagerURI.Equals(value) != true)))
            {
                _formManagerURI = value;
                OnPropertyChanged("formManagerURI", value);
            }
        }
    }
    
    /// <summary>
    /// NEW
    /// enumeration
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public virtual PackageItemTypeFormat format
    {
        get
        {
            return _format;
        }
        set
        {
            if ((_format.Equals(value) != true))
            {
                _format = value;
                OnPropertyChanged("format", value);
            }
            _shouldSerializeformat = true;
        }
    }
    
    [XmlAttribute(DataType="anyURI")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string packageID
    {
        get
        {
            return _packageID;
        }
        set
        {
            if ((_packageID == value))
            {
                return;
            }
            if (((_packageID == null) 
                        || (_packageID.Equals(value) != true)))
            {
                _packageID = value;
                OnPropertyChanged("packageID", value);
            }
        }
    }
    
    /// <summary>
    /// NEW
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string title
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
                OnPropertyChanged("title", value);
            }
        }
    }
    
    /// <summary>
    /// If the ID does not use the default base URI (namespace), then the local baseURI goes here. Note that all IDs must be unique within a form, even if they do not have the same baseURI.
    /// 
    /// Ideally, the baseURI + ID should combine to form a *globally* unique identifier, that uniquely identifies an item in a particular form.  The same baseURI and ID may be reused in derived or versioned forms, as long as the context stays the same, and any affected data elements remain unchanged in context and semantics.  Following this approach is likely to simplify analytics based on form content.
    /// </summary>
    [XmlAttribute(DataType="anyURI")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string baseURI
    {
        get
        {
            return _baseURI;
        }
        set
        {
            if ((_baseURI == value))
            {
                return;
            }
            if (((_baseURI == null) 
                        || (_baseURI.Equals(value) != true)))
            {
                _baseURI = value;
                OnPropertyChanged("baseURI", value);
            }
        }
    }
    
    /// <summary>
    /// NEW: filename to use when the current FormDesign instance is saved as a file.
    /// For forms containing responses, the filename may include the formInstanceVersionURI,
    /// but the naming convention may be use-case-specific.
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string filename
    {
        get
        {
            return _filename;
        }
        set
        {
            if ((_filename == value))
            {
                return;
            }
            if (((_filename == null) 
                        || (_filename.Equals(value) != true)))
            {
                _filename = value;
                OnPropertyChanged("filename", value);
            }
        }
    }
    
    /// <summary>
    /// NEW: URI used to identify the form that that this FormDesign is based upon.  In most cases, this should be a standard form that is modified and/or extended by the current FormDesign.
    /// 
    /// The current template reuses the basedOn IDs whenever the question/answer/semantic context is identical to the original.
    /// 
    /// 5/11/17:  Relying on data element mapping may be a better and more flexible approach than @basedOnURI. In this way, forms could compare data elements to determine if they contain semantic matches, and this is supported better with a more robust code map section.
    /// </summary>
    [XmlAttribute(DataType="anyURI")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string basedOnURI
    {
        get
        {
            return _basedOnURI;
        }
        set
        {
            if ((_basedOnURI == value))
            {
                return;
            }
            if (((_basedOnURI == null) 
                        || (_basedOnURI.Equals(value) != true)))
            {
                _basedOnURI = value;
                OnPropertyChanged("basedOnURI", value);
            }
        }
    }
    
    /// <summary>
    /// NEW: A text identifier that is used to group multiple versions of a single form.  The lineage is constant for all versions of a single kind of form.
    /// 
    /// When appended to @baseURI, it can be used to retrieve all versions of one particular form.
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string lineage
    {
        get
        {
            return _lineage;
        }
        set
        {
            if ((_lineage == value))
            {
                return;
            }
            if (((_lineage == null) 
                        || (_lineage.Equals(value) != true)))
            {
                _lineage = value;
                OnPropertyChanged("lineage", value);
            }
        }
    }
    
    /// <summary>
    /// NEW: @version contains the version text for the current form.  It is designed to be used in conjuction with @baseURI and @lineage.
    /// </summary>
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string version
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
                OnPropertyChanged("version", value);
            }
        }
    }
    
    /// <summary>
    /// NEW: The full URI that uniquely identifies the current form.   It is created by concatenating @baseURI + lineage + version.  Each of the componenets is separated by a single forward slash.
    /// </summary>
    [XmlAttribute(DataType="anyURI")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string fullURI
    {
        get
        {
            return _fullURI;
        }
        set
        {
            if ((_fullURI == value))
            {
                return;
            }
            if (((_fullURI == null) 
                        || (_fullURI.Equals(value) != true)))
            {
                _fullURI = value;
                OnPropertyChanged("fullURI", value);
            }
        }
    }
    
    /// <summary>
    /// NEW: The full URI used to identify the form that is the immediate previous version of the current FormDesign
    /// </summary>
    [XmlAttribute(DataType="anyURI")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string prevVersionURI
    {
        get
        {
            return _prevVersionURI;
        }
        set
        {
            if ((_prevVersionURI == value))
            {
                return;
            }
            if (((_prevVersionURI == null) 
                        || (_prevVersionURI.Equals(value) != true)))
            {
                _prevVersionURI = value;
                OnPropertyChanged("prevVersionURI", value);
            }
        }
    }
    
    /// <summary>
    /// NEW: Unique URI used to identify a unique instance of a form.  Used for tracking form responses across time and across multiple episodes of editing by end-users.  This URI does not change for each edit session of a form instance.
    /// </summary>
    [XmlAttribute(DataType="anyURI")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string formInstanceURI
    {
        get
        {
            return _formInstanceURI;
        }
        set
        {
            if ((_formInstanceURI == value))
            {
                return;
            }
            if (((_formInstanceURI == null) 
                        || (_formInstanceURI.Equals(value) != true)))
            {
                _formInstanceURI = value;
                OnPropertyChanged("formInstanceURI", value);
            }
        }
    }
    
    /// <summary>
    /// NEW: Unique URI used to identify a unique instance of a form's saved responses.  It is used for tracking form responses across time and across multiple episodes of editing by end-users.  This URI must change for each edit/save session of a form instance.  It may be e.g., a new GUID, or a repeat of the formInstanceID followed by a version number.
    /// </summary>
    [XmlAttribute(DataType="anyURI")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string formInstanceVersionURI
    {
        get
        {
            return _formInstanceVersionURI;
        }
        set
        {
            if ((_formInstanceVersionURI == value))
            {
                return;
            }
            if (((_formInstanceVersionURI == null) 
                        || (_formInstanceVersionURI.Equals(value) != true)))
            {
                _formInstanceVersionURI = value;
                OnPropertyChanged("formInstanceVersionURI", value);
            }
        }
    }
    
    /// <summary>
    /// NEW: Unique URI used to identify the immediate previous instance of a form containing responses.  This is the @formInstanceVersionURI that represents the instance of the form that the user opened up before beginning a new cycle of edit/save.  This attribute is used for tracking form responses across time and across multiple episodes of editing by end-users.  This URI must change for each edit session of a form instance.
    /// </summary>
    [XmlAttribute(DataType="anyURI")]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string formPreviousInstanceVersionURI
    {
        get
        {
            return _formPreviousInstanceVersionURI;
        }
        set
        {
            if ((_formPreviousInstanceVersionURI == value))
            {
                return;
            }
            if (((_formPreviousInstanceVersionURI == null) 
                        || (_formPreviousInstanceVersionURI.Equals(value) != true)))
            {
                _formPreviousInstanceVersionURI = value;
                OnPropertyChanged("formPreviousInstanceVersionURI", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool changedData
    {
        get
        {
            return _changedData;
        }
        set
        {
            if ((_changedData.Equals(value) != true))
            {
                _changedData = value;
                OnPropertyChanged("changedData", value);
            }
            _shouldSerializechangedData = true;
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual bool newData
    {
        get
        {
            return _newData;
        }
        set
        {
            if ((_newData.Equals(value) != true))
            {
                _newData = value;
                OnPropertyChanged("newData", value);
            }
            _shouldSerializenewData = true;
        }
    }
    
    /// <summary>
    /// Test whether changedData should be serialized
    /// </summary>
    public virtual bool ShouldSerializechangedData()
    {
        if (_shouldSerializechangedData)
        {
            return true;
        }
        return (_changedData != default(bool));
    }
    
    /// <summary>
    /// Test whether newData should be serialized
    /// </summary>
    public virtual bool ShouldSerializenewData()
    {
        if (_shouldSerializenewData)
        {
            return true;
        }
        return (_newData != default(bool));
    }
    
    /// <summary>
    /// Test whether format should be serialized
    /// </summary>
    public virtual bool ShouldSerializeformat()
    {
        if (_shouldSerializeformat)
        {
            return true;
        }
        return (_format != default(PackageItemTypeFormat));
    }
    
    /// <summary>
    /// Test whether formManagerURI should be serialized
    /// </summary>
    public virtual bool ShouldSerializeformManagerURI()
    {
        return !string.IsNullOrEmpty(formManagerURI);
    }
    
    /// <summary>
    /// Test whether packageID should be serialized
    /// </summary>
    public virtual bool ShouldSerializepackageID()
    {
        return !string.IsNullOrEmpty(packageID);
    }
    
    /// <summary>
    /// Test whether title should be serialized
    /// </summary>
    public virtual bool ShouldSerializetitle()
    {
        return !string.IsNullOrEmpty(title);
    }
    
    /// <summary>
    /// Test whether baseURI should be serialized
    /// </summary>
    public virtual bool ShouldSerializebaseURI()
    {
        return !string.IsNullOrEmpty(baseURI);
    }
    
    /// <summary>
    /// Test whether filename should be serialized
    /// </summary>
    public virtual bool ShouldSerializefilename()
    {
        return !string.IsNullOrEmpty(filename);
    }
    
    /// <summary>
    /// Test whether basedOnURI should be serialized
    /// </summary>
    public virtual bool ShouldSerializebasedOnURI()
    {
        return !string.IsNullOrEmpty(basedOnURI);
    }
    
    /// <summary>
    /// Test whether lineage should be serialized
    /// </summary>
    public virtual bool ShouldSerializelineage()
    {
        return !string.IsNullOrEmpty(lineage);
    }
    
    /// <summary>
    /// Test whether version should be serialized
    /// </summary>
    public virtual bool ShouldSerializeversion()
    {
        return !string.IsNullOrEmpty(version);
    }
    
    /// <summary>
    /// Test whether fullURI should be serialized
    /// </summary>
    public virtual bool ShouldSerializefullURI()
    {
        return !string.IsNullOrEmpty(fullURI);
    }
    
    /// <summary>
    /// Test whether prevVersionURI should be serialized
    /// </summary>
    public virtual bool ShouldSerializeprevVersionURI()
    {
        return !string.IsNullOrEmpty(prevVersionURI);
    }
    
    /// <summary>
    /// Test whether formInstanceURI should be serialized
    /// </summary>
    public virtual bool ShouldSerializeformInstanceURI()
    {
        return !string.IsNullOrEmpty(formInstanceURI);
    }
    
    /// <summary>
    /// Test whether formInstanceVersionURI should be serialized
    /// </summary>
    public virtual bool ShouldSerializeformInstanceVersionURI()
    {
        return !string.IsNullOrEmpty(formInstanceVersionURI);
    }
    
    /// <summary>
    /// Test whether formPreviousInstanceVersionURI should be serialized
    /// </summary>
    public virtual bool ShouldSerializeformPreviousInstanceVersionURI()
    {
        return !string.IsNullOrEmpty(formPreviousInstanceVersionURI);
    }
}
}
#pragma warning restore
