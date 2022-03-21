// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 5.1.1.0. www.xsd2code.com
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
using System.Threading;

namespace SDC.Schema
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;
using System.Reflection;
using System.IO;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.CodeDom;
    using Newtonsoft.Json;

    #region Base entity class
    public partial class SdcEntityBase : System.ComponentModel.INotifyPropertyChanged

    {

        private ObjectChangeTracker changeTrackerField;

        [XmlIgnore()]
        [JsonIgnore]
        public ObjectChangeTracker ChangeTracker
    {
        get
        {
            if ((this.changeTrackerField == null))
            {
                this.changeTrackerField = new ObjectChangeTracker(this);
            }
            return changeTrackerField;
        }
    }
    
   
    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    
    public virtual void OnPropertyChanged(string propertyName, object value)
    {
        this.ChangeTracker.RecordCurrentValue(propertyName, value);
        System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
        if ((handler != null))
        {
            handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
    
    
    
//    #region Clone method
//    /// <summary>
//    /// Create a clone of this T object
//    /// </summary>
//    public virtual T Clone()
//    {
//        return ((T)(this.MemberwiseClone()));
//    }
//    #endregion
}
#endregion
}
#pragma warning restore
