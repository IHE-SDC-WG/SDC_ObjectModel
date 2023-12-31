﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Net.Mail;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Sources;
using Newtonsoft.Json;

//using SDC;
namespace SDC.Schema
{
    /// <summary>
    /// <see cref="_IUniqueIDs"/> is an internal interface used to enforce uniqueness of SDC node identifier (ID) values.<br/>
    /// It is implemented by TopNode nodes that require unique identifier properties within their subsumed subtree. <br/>
    /// (e.g., ID or InstanceVersionURI [for instance documents]) properties contained in teh TopNode's subtree.<br/>
    /// The interface is implemented by <see cref="FormDesignType"/>, <see cref="DataElementType"/>, 
    /// <see cref="RetrieveFormPackageType"/>, <see cref="PackageListType"/>, and <see cref="XMLPackageType"/>.<br/><br/>
    /// <see cref="_IUniqueIDs"/> contains a HashSet&lt;string> (<see cref="_UniqueIDs"/>) to help determine uniqueness.<br/><br/>
    /// At this time, <see cref="_IUniqueIDs"/> is only supported for enforcing ID uniqueness within a <see cref="FormDesignType"/> (FD) tree,<br/>
    /// where it contains ID values from all <see cref="IdentifiedExtensionType"/> (IET) nodes within that FD tree.
    /// </summary>
    internal interface _IUniqueIDs
    {
        /// <summary>
        /// <see cref="_UniqueIDs"/> contains a HashSet&lt;string> to help determine SDC node identifier (ID) uniqueness.<br/>
        /// If an ID value has already been used, it will appear in this HashSet.<br/>
        /// ID properties occur most prominently in in <see cref="IdentifiedExtensionType"/> (IET) and <see cref="FormDesignType"/> (FD) nodes.<br/>
        /// </summary>
        internal HashSet<string> _UniqueIDs { get; }
    }
    /// <summary>
    /// Implemented by nodes that contain a ChildItems node.
    /// </summary>
    public interface IChildItemsParent 
        //where T : BaseType, IChildItemsParent<T>
    {
        public ChildItemsType ChildItemsNode { get; set; }

        //Remove all child nodes 


        //QR AddChildQR(string id = "", int insertPosition = -1);
        //QS AddChildQS(string id = "", int insertPosition = -1);
        //QM AddChildQM(string id = "", int insertPosition = -1);
        //QL AddChildQL(string id = "", int insertPosition = -1);
    }
    /// <summary>
    /// Implemented by ListFieldType
    /// </summary>
    public interface IListField
    {
        ListType? List { get; set; }
        LookupEndPointType? LookupEndpoint { get; set; }
    }
    /// <summary>
    /// Implemented by QuestionBaseType
    /// </summary>
    public interface IQuestionBase
    {
        ResponseFieldType? ResponseField_Item { get; set; }
    }
    #region Values    
    /// <summary>
    /// Implemented by SDC data "_Stype" types, which have a strongly-typed val attribute.  Not implemented by anyType, XML, or HTML  
    /// </summary>
    public interface IVal
    {
        ///// <summary>
        ///// Set the @val property using an XML-formatted string, formatted according to XML Schema datatype rules.
        ///// For example, these formatted strings can be generated from .NET datatypes using XmlConvert.ToString(), or copied from existing XML documents
        ///// </summary>
        ///// <param name="sVal">The string value used to set @val</param>
        ///// <param name="message">returns an error message</param>
        ///// <param name="ex">retruns an Exception if the set failed</param>
        ///// <returns>Returns true if success.  Returns false if an Exception was returned, or a string formatting error was detected</returns>
        //bool ValXmlStringSet(string sVal, out Exception ex, out string message);

        /// <summary>
        /// Retrieve @val using an XML-formatted string
        /// </summary>
        string ValXmlString { get; set; }

    }
   /// <summary>
   /// Numbers, including byte, ubyte, decimal, etc., which share attributes like minInclusive, etc.
   /// </summary>
   public interface IValNumeric : IVal 
    {
        //decimal ValDec { get; set; }
       // bool IsValid(out string message);


    } //Implemented by numeric data types, which have a strongly-type val attribute.
    public interface IValDateTime : IVal 
    {
        bool IsValid(out string message);
        
    } //Implemented by DateTime data types, which have a strongly-type val attribute.

    public interface IValDuration : IVal
    {
        bool IsValid(out string message);
    } //Implemented by DateTime data types, which have a strongly-type val attribute.

    /// <summary>
    /// Used to flag data types that are able to represent integers (does not include float, double, decimal)
    /// </summary>
    public interface IInteger : IVal
    { 
        //long ValLong { get; set; } 
    } //Implemented by Integer data, which have a strongly-typed val attribute.  Includes byte, short, long, positive, no-positive, negative and non-negative types

	/// <summary>
	/// /// Used to flag data types that are able to represent real numbers, i.e., that include fractional values (includes float, double, decimal)
	/// </summary>
	public interface IFraction { }


    #endregion
    #region Empty Interfaces

    public interface INewTopLevel //TODO:
    {   //FormDesignType CreateForm(bool addHeader, bool addFooter, string formID, string lineage, string version, string fullURI);
        //FormDesignType CreateFormFromTemplatePath(string path, string formID, string lineage, string version, string fullURI);
        //FormDesignType CreateFormFromTemplateXML(string xml, string formID, string lineage, string version, string fullURI);
        //bool RemoveFormFromPackage(RetrieveFormPackageType pkg, FormDesignType form);
    }
    public interface IPackage : ITopNode //TODO:
    {   //FormDesignType CreateForm(bool addHeader, bool addFooter, string formID, string lineage, string version, string fullURI);
        //FormDesignType CreateFormFromTemplatePath(string path, string formID, string lineage, string version, string fullURI);
        //FormDesignType CreateFormFromTemplateXML(string xml, string formID, string lineage, string version, string fullURI);
        //bool RemoveFormFromPackage(RetrieveFormPackageType pkg, FormDesignType form); 
    }
    public interface IDataElement : ITopNode { }
    public interface IDemogForm : ITopNode { }
    public interface IMap : ITopNode { }
    public interface IFormDesign : ITopNode { }
    public interface IRetrieveFormPackage { }
    /// <summary>
    /// This interface is applied to the partial classes that can have a ChildItems element.
    /// These are Section, Question and ListItem.  
    /// This interface is require to support generic classes that must handle the creation ofthe 
    /// ChildItems element, which holds List of type IdentifiedItemType
    /// </summary>
    /// 
    public interface IChildItemsMember<Tchild> where Tchild : IdentifiedExtensionType, IChildItemsMember<Tchild> { }  //Marks SectionItemType, QuestionItemType, DisplayedType, ButtonItemType, InjectFormType    
    /// <summary>
    /// Items with this interface attach to to a List&lt;> object in the SDC tree.
    /// </summary>
    public interface IListMember { } //
    public interface IQuestionItem : IQuestionList { }

    //bool ConvertToButton(); //abort if LIs or children present

    //convert type to QR
    //Convert to S, DI    (must first delete List or ResponseField present)
    //Convert QR to QS    (delete ResponseField, add List, set maxSelections)
    //Convert QR to QM    (delete ResponseField, add List, set maxSelections)
    //LookupEndPointType AddLookupEndpoint(ListFieldType lfParent);  //should be part of AddChildQL code;
    //CanConvert (to Type)
    public interface IQuestionList { } //may be implemented by Q, List, LI and perhaps DI (if inside a list) 

    //!public interface IQuestionListMember : IQuestionBuilder //decorates LI/LIR and DI
    //{
    //    //for DI, make sure parent is a ListType object
    //    //bool Remove(bool removeDecendants = false);
    //    //bool Move(QuestionItemType target = null, bool moveAbove = false, bool testOnly = false);
    //    //bool Move(ListItemType target = null, bool moveAbove = false, bool testOnly = false);
    //    //ListItemType ConvertToLI(bool testOnly = false);
    //    //DisplayedType ConvertToDI(bool testOnly = false); //abort if children of LI are present
    //    //ListItemType ConvertToLIR(bool testOnly = false);


    //    //for DI, make sure parent is a ListType object
    //!   bool Remove(bool removeDecendants); 
    //!    bool RemoveI(bool removeDecendants) 
    //    { throw new NotImplementedException(); }
    //    //bool Move(QuestionItemType target, bool moveAbove, bool testOnly) { throw new NotImplementedException(); }
    //    //bool Move(ListItemType target, bool moveAbove, bool testOnly) { throw new NotImplementedException(); }
    //    /// <summary>
    //    /// Move a ListItem or DisplayedItem within the same List
    //    /// </summary>
    //    /// <returns>returns true if operation succeeded    
    //    /// </returns>
    //!    bool MoveInList(out string err, int newListIndex = -1);
    //!    bool MoveInListI(out string err, int newListIndex = -1)
    //    {
    //        var qlm = this as BaseType;  //"this" is either a DI or LI
    //        var list = (ListType)(qlm)?.ParentNode;
    //        return qlm.Move(list, out err, 6);
    //    }
    //!    //bool Move(List<BaseType> targetProperty, out List<string> errList, int newListIndex = -1) //DI and LI must have a parent property of ListType (DI or LI) of ChildItems (DI)
    //    //{
    //    //    var qlm = this as BaseType;  //"this" is either a DI or LI
    //    //    var list = (ListType)(qlm)?.ParentNode;
    //    //    return qlm.Move(targetProperty, qlm, out errList, newListIndex);
    //    //}

    //    /// <summary>
    //    /// Move a ListItem or DisplayedItem to another List
    //    /// </summary>
    //    /// <param name="targetList"></param>
    //    /// <param name="errList"></param>
    //    /// <param name="newListIndex"></param>
    //    /// <returns>returns true if operation succeeded    </returns>
    //!    bool MoveToList(ListType targetList, out string err, int newListIndex = -1);
    //!    bool MoveToListI(ListType targetList, out string err, int newListIndex = -1)
    //    {
    //        var qlm = this as BaseType;  //"this" is either a DI or LI
    //        return qlm.Move(targetList, out err, newListIndex);
    //    }

    //    ListItemType ConvertToLI(bool testOnly);
    //    ListItemType ConvertToLI_I(bool testOnly) 
    //    { throw new NotImplementedException(); }
    //    DisplayedType ConvertToDI(bool testOnly);
    //    DisplayedType ConvertToDI_I(bool testOnly)
    //    { throw new NotImplementedException(); } //abort if children of LI are present
    //    ListItemType ConvertToLIR(bool testOnly);
    //    ListItemType ConvertToLIR_I(bool testOnly)
    //    { throw new NotImplementedException(); }
    //!    bool IsMoveAllowedToList(QuestionItemType target, out string error);
    //!    bool IsMoveAllowedToListI(QuestionItemType target, out string error)
    //    {
    //        error = "";

    //        if (
    //            !((target as QuestionItemType).GetQuestionSubtype() == QuestionEnum.QuestionSingle) &&
    //            !((target as QuestionItemType).GetQuestionSubtype() == QuestionEnum.QuestionMultiple) 
    //            )
    //        { error = "A Question target must be a QuestionSingle or QuestionMultiple"; return false; }

    //        return true;
    //    }
    //!    bool MoveInList(DisplayedType source, QuestionItemType target, bool moveAbove);
    //!    bool MoveInListI(DisplayedType source, QuestionItemType target, bool moveAbove)
    //    {
    //        if (source is null) return false;
    //        if (source is RepeatingType) return false; //S, Q are illegal in the list
    //        if (source is ButtonItemType) return false; //B is illegal in the list

    //        if (target is null) target = source.ParentNode?.ParentNode?.ParentNode as QuestionItemType; //LI-->List-->ListField-->Q  - see if we can capture a Question from the source node
    //        if (target is null) return false;

    //        List<BaseType> sourceList = (source.ParentNode as ListType)?.Items?.ToList<BaseType>();//guess that the sourrce node is inside a List
    //        if (sourceList is null) sourceList = (source.ParentNode as ChildItemsType)?.ChildItemsList?.ToList<BaseType>();//try again - guess that source node is inside a ChildItems node
    //        if (sourceList is null) return false;//both guesses failed - this is probably a disconnected node, and we can't work with that.

    //        if (target.ListField_Item is null) AddListToListField(AddListFieldToQuestion(target));  //make sure there is a ist instantiated on this target Question; if not, then create it.          
    //        var targetList = target.ListField_Item.List.Items;
    //        if (targetList is null) return false;  //unkown problem getting Question-->ListField-->List

    //        var indexSource = sourceList.IndexOf(source);
    //        int index = targetList.Count;
    //        sourceList.Remove(source);
    //        targetList.Insert(index, source);
    //        if (targetList[index] == source)
    //        {
    //            source.TopNode.ParentNodes[source.ObjectGUID] = target;
    //            return true;
    //        }

    //        //Error - the source item is now disconnected from the list.  Lets add it back to the end of the list.
    //        sourceList.Insert(indexSource, source); //put source back where it came from; the move failed
    //        return false;

    //    }
    //!    bool MoveInList(DisplayedType source, DisplayedType target, bool moveAbove);
    //!    bool MoveInListI(DisplayedType source, DisplayedType target, bool moveAbove) //target must be a LI or DI (not a RepeatingType); need to address Nodes dictionary updates
    //    {
    //        //this function allows dropping items inside a QS o QM list to rearrange the list
    //        //prevent illegal operationss
    //        if (source is null) return false;
    //        if (source is RepeatingType) return false; //S, Q (RepeatingTypes) are illegal in the Q's list
    //        if (target is RepeatingType) return false; //S, Q (RepeatingTypes) are illegal in the Q's list
    //        if (source is ButtonItemType) return false; //B is illegal in the Q's list
    //        if (target is ButtonItemType) return false; //B is illegal in the Q's list

    //        List<BaseType> sourceList = (source.ParentNode?.ParentNode as ListType)?.Items?.ToList<BaseType>();
    //        if (sourceList is null) sourceList = (source.ParentNode as ChildItemsType)?.ChildItemsList?.ToList<BaseType>();
    //        if (sourceList is null) return false;

    //        var qTarget = target.ParentNode?.ParentNode?.ParentNode as QuestionItemType;
    //        if (qTarget is null) return false;  //we did not get a Q object, so we are not moving  a node into a Q List

    //        var targetList = qTarget.ListField_Item?.List?.Items;


    //        if (targetList is null) return false;

    //        var indexSource = sourceList.IndexOf(source);
    //        sourceList.Remove(source);

    //        //Determine where to insert the node in the list, based on the location of the existing Lis
    //        var index = targetList.IndexOf(target);
    //        if (index < 0) index = targetList.Count; //target node not found in list, so insert source at the end of the list; this should never execute
    //        if (moveAbove) index--;

    //        targetList.Insert(index, source);
    //        if (targetList[index] == source)
    //        {
    //            source.TopNode.ParentNodes[source.ObjectGUID] = target;
    //            return true;
    //        }

    //        //Error - the source item is now disconnected from the list.  Lets add it back to the end of the list.
    //        sourceList.Insert(indexSource, source); //put source back where it came from; the move failed
    //        return false;
    //    }



    //} //Implemented on ListItem and DisplayedItem
    //!public interface IListItem { }    
    //!public interface ISection { }
    //!public interface IButtonItem { }
    //!public interface IInjectForm { }
    //!public interface IDisplayedType { }
    public interface IDisplayedTypeMember { }//LinkType, BlobType, ContactType, CodingType, EventType, OnEventType, PredGuardType
    //public interface IBlob { }
    public interface IExtensionBase { }
    public interface IExtensionBaseTypeMember { }//Used on Extension, Property, Comment 
    public interface IIdentifiedExtensionType { }
    public interface IMoveRemove { }//Used on BaseType only; IExtensionBaseTypeMember has some custom methods but they do not handle Node dictionaries or is-move-allowed testing 
    public interface INavigate { }//apply only to BaseType 
    public interface IResponse : IVal { } //marks LIR and QR
    public interface IResponseField : IVal { }
    public interface IIdentifiers { }
    public interface IAddCoding { }
    public interface IAddContact { }//(File)
    public interface IAddOrganization { }
    public interface IAddPerson { }
    public interface IEvent : IHasActionElseGroup { }//Used for events (PredActionType) 
    public interface IPredGuard { }//used by Guards on ListItem, Button 
    public interface IRule { }
    public interface IHasConditionalActionsNode { }
    public interface IHasParameterGroup { }
    public interface IHasDataType_SType { }
    public interface IHasDataType_DEType { }
    public interface IHasActionsNode { }
    public interface IHasActionElseGroup : IActions, IHasElseNode { }
    public interface IHasElseNode { }
    public interface IActions { }
    public interface IActionsMember { }//used from within an individual action object; "this" refers to the action object itself.  Its parent is the _actions element (ActionsType)
    public interface IValidationTests { }
    public interface IClone { }
    public interface IHtmlPackage { }//On SDCPackage.HTMLPackage
    public interface INumeric { }
	///<summary>
    ///Flags all SDC data type Data Entry (DE) objects that may attach to the Item node of a <see cref="DataTypes_DEType"/> (Response) object.
    ///</summary>
	public interface IDataType_DEType { }
	/// <summary>
	/// Flags all SDC data type Static (S) objects that may attach to the Item node of a <see cref="DataTypes_SType"/> (Response) object.
	/// </summary>
	public interface IDataType_SType { }


    #endregion

}
