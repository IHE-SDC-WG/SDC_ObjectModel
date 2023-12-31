﻿using CSharpVitamins;
using SDC.Schema;
using static SDC.Schema.SdcUtil;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace SDC.Schema.Extensions
{
    public static class IdentifiedExtensionTypeExtensions
    {
        /// <summary>
        /// Set the ID property on any IdentifiedExtensionType node only if it does not already exist <br/>
        /// in the current tree's _UniqueIDs hashable. <br/>
        /// Returns false if the new ID already already exists for a different node in _UniqueIDs.<br/>
        /// Returns true if the new ID is the same as the old ID.<br/>
        /// Returns false if the new ID is null or empty.
        /// </summary>
        /// <returns></returns>
        public static bool TrySetID(this IdentifiedExtensionType iet, string newID)
        {
            if (iet.TopNode is null || newID == "") return false;
            if(newID == iet.ID) return true;

            var u = (_IUniqueIDs)iet.TopNode;            

            if(u._UniqueIDs.TryGetValue(newID, out _) == false) return false;  //ID already in use elsewhere
            
            iet.ID = newID;
            return true;
        }
    }
}