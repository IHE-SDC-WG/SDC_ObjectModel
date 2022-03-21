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

#region FractionDigitsAttribute
public class FractionDigitsAttribute : ValidationAttribute
{
        private readonly uint _decimalPrecision;
     
        public FractionDigitsAttribute(uint decimalPrecision)
        {
            _decimalPrecision = decimalPrecision;
        }

        public override bool IsValid(object value)
        {
            if (value == null)
                return true;

            if (value is decimal)
                return HasPrecision(value, _decimalPrecision);

            if (value is float)
                return HasPrecision(value, _decimalPrecision);

            if (value is double)
                return HasPrecision(value, _decimalPrecision);

            return false;
        }

        private static bool HasPrecision(object value, uint precision)
        {
            string valueStr = String.Empty;
            if (value is decimal)
                valueStr = ((decimal)value).ToString(CultureInfo.InvariantCulture);

            if (value is float)
                valueStr = ((float)value).ToString(CultureInfo.InvariantCulture);

            if (value is double)
                valueStr = ((double)value).ToString(CultureInfo.InvariantCulture);

            int indexOfDot = valueStr.IndexOf('.');
            if (indexOfDot == -1)
            {
                return true;
            }
            return valueStr.Length - indexOfDot - 1 <= precision;
        }
}
#endregion
}
#pragma warning restore
