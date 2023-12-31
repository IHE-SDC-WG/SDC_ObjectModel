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
/// A generic structure for recording file version metadata.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
[Serializable]
[DesignerCategoryAttribute("code")]
[XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[JsonObject("VersionType")]
public partial class VersionType : ExtensionBaseType
{
    #region Private fields
    private FileType _versioningReference;
    private RichTextType _versionComments;
    private VersionTypeChanges _changes;
    private string _fullVersion;
    private string _versionRegExPattern;
    private string _versionLevel1;
    private string _versionLevel2;
    private string _versionLevel3;
    private string _versionLevel4;
    private string _versionLevel5;
    #endregion
    
    /// <summary>
    /// Information about the document that describes the versioning methodology nomenclature.
    /// </summary>
    [XmlElement(Order=0)]
    [JsonProperty(Order=0, NullValueHandling=NullValueHandling.Ignore)]
    public virtual FileType VersioningReference
    {
        get
        {
            return _versioningReference;
        }
        set
        {
            if ((_versioningReference == value))
            {
                return;
            }
            if (((_versioningReference == null) 
                        || (_versioningReference.Equals(value) != true)))
            {
                _versioningReference = value;
                OnPropertyChanged("VersioningReference", value);
            }
        }
    }
    
    /// <summary>
    /// Comments about the changes in this version
    /// </summary>
    [XmlElement(Order=1)]
    [JsonProperty(Order=1, NullValueHandling=NullValueHandling.Ignore)]
    public virtual RichTextType VersionComments
    {
        get
        {
            return _versionComments;
        }
        set
        {
            if ((_versionComments == value))
            {
                return;
            }
            if (((_versionComments == null) 
                        || (_versionComments.Equals(value) != true)))
            {
                _versionComments = value;
                OnPropertyChanged("VersionComments", value);
            }
        }
    }
    
    /// <summary>
    /// Itemized list of changes in the new version
    /// </summary>
    [XmlElement(Order=2)]
    [JsonProperty(Order=2, NullValueHandling=NullValueHandling.Ignore)]
    public virtual VersionTypeChanges Changes
    {
        get
        {
            return _changes;
        }
        set
        {
            if ((_changes == value))
            {
                return;
            }
            if (((_changes == null) 
                        || (_changes.Equals(value) != true)))
            {
                _changes = value;
                OnPropertyChanged("Changes", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string fullVersion
    {
        get
        {
            return _fullVersion;
        }
        set
        {
            if ((_fullVersion == value))
            {
                return;
            }
            if (((_fullVersion == null) 
                        || (_fullVersion.Equals(value) != true)))
            {
                _fullVersion = value;
                OnPropertyChanged("fullVersion", value);
            }
        }
    }
    
    [XmlAttribute]
    [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
    public virtual string versionRegExPattern
    {
        get
        {
            return _versionRegExPattern;
        }
        set
        {
            if ((_versionRegExPattern == value))
            {
                return;
            }
            if (((_versionRegExPattern == null) 
                        || (_versionRegExPattern.Equals(value) != true)))
            {
                _versionRegExPattern = value;
                OnPropertyChanged("versionRegExPattern", value);
            }
        }
    }
    
    [XmlAttribute("versionLevel.1")]
    [JsonProperty("versionLevel.1", NullValueHandling=NullValueHandling.Ignore)]
    public virtual string versionLevel1
    {
        get
        {
            return _versionLevel1;
        }
        set
        {
            if ((_versionLevel1 == value))
            {
                return;
            }
            if (((_versionLevel1 == null) 
                        || (_versionLevel1.Equals(value) != true)))
            {
                _versionLevel1 = value;
                OnPropertyChanged("versionLevel1", value);
            }
        }
    }
    
    [XmlAttribute("versionLevel.2")]
    [JsonProperty("versionLevel.2", NullValueHandling=NullValueHandling.Ignore)]
    public virtual string versionLevel2
    {
        get
        {
            return _versionLevel2;
        }
        set
        {
            if ((_versionLevel2 == value))
            {
                return;
            }
            if (((_versionLevel2 == null) 
                        || (_versionLevel2.Equals(value) != true)))
            {
                _versionLevel2 = value;
                OnPropertyChanged("versionLevel2", value);
            }
        }
    }
    
    [XmlAttribute("versionLevel.3")]
    [JsonProperty("versionLevel.3", NullValueHandling=NullValueHandling.Ignore)]
    public virtual string versionLevel3
    {
        get
        {
            return _versionLevel3;
        }
        set
        {
            if ((_versionLevel3 == value))
            {
                return;
            }
            if (((_versionLevel3 == null) 
                        || (_versionLevel3.Equals(value) != true)))
            {
                _versionLevel3 = value;
                OnPropertyChanged("versionLevel3", value);
            }
        }
    }
    
    [XmlAttribute("versionLevel.4")]
    [JsonProperty("versionLevel.4", NullValueHandling=NullValueHandling.Ignore)]
    public virtual string versionLevel4
    {
        get
        {
            return _versionLevel4;
        }
        set
        {
            if ((_versionLevel4 == value))
            {
                return;
            }
            if (((_versionLevel4 == null) 
                        || (_versionLevel4.Equals(value) != true)))
            {
                _versionLevel4 = value;
                OnPropertyChanged("versionLevel4", value);
            }
        }
    }
    
    [XmlAttribute("versionLevel.5")]
    [JsonProperty("versionLevel.5", NullValueHandling=NullValueHandling.Ignore)]
    public virtual string versionLevel5
    {
        get
        {
            return _versionLevel5;
        }
        set
        {
            if ((_versionLevel5 == value))
            {
                return;
            }
            if (((_versionLevel5 == null) 
                        || (_versionLevel5.Equals(value) != true)))
            {
                _versionLevel5 = value;
                OnPropertyChanged("versionLevel5", value);
            }
        }
    }
    
    /// <summary>
    /// Test whether VersioningReference should be serialized
    /// </summary>
    public virtual bool ShouldSerializeVersioningReference()
    {
        return (_versioningReference != null);
    }
    
    /// <summary>
    /// Test whether VersionComments should be serialized
    /// </summary>
    public virtual bool ShouldSerializeVersionComments()
    {
        return (_versionComments != null);
    }
    
    /// <summary>
    /// Test whether Changes should be serialized
    /// </summary>
    public virtual bool ShouldSerializeChanges()
    {
        return (_changes != null);
    }
    
    /// <summary>
    /// Test whether fullVersion should be serialized
    /// </summary>
    public virtual bool ShouldSerializefullVersion()
    {
        return !string.IsNullOrEmpty(fullVersion);
    }
    
    /// <summary>
    /// Test whether versionRegExPattern should be serialized
    /// </summary>
    public virtual bool ShouldSerializeversionRegExPattern()
    {
        return !string.IsNullOrEmpty(versionRegExPattern);
    }
    
    /// <summary>
    /// Test whether versionLevel1 should be serialized
    /// </summary>
    public virtual bool ShouldSerializeversionLevel1()
    {
        return !string.IsNullOrEmpty(versionLevel1);
    }
    
    /// <summary>
    /// Test whether versionLevel2 should be serialized
    /// </summary>
    public virtual bool ShouldSerializeversionLevel2()
    {
        return !string.IsNullOrEmpty(versionLevel2);
    }
    
    /// <summary>
    /// Test whether versionLevel3 should be serialized
    /// </summary>
    public virtual bool ShouldSerializeversionLevel3()
    {
        return !string.IsNullOrEmpty(versionLevel3);
    }
    
    /// <summary>
    /// Test whether versionLevel4 should be serialized
    /// </summary>
    public virtual bool ShouldSerializeversionLevel4()
    {
        return !string.IsNullOrEmpty(versionLevel4);
    }
    
    /// <summary>
    /// Test whether versionLevel5 should be serialized
    /// </summary>
    public virtual bool ShouldSerializeversionLevel5()
    {
        return !string.IsNullOrEmpty(versionLevel5);
    }
}
}
#pragma warning restore
