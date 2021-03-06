﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
namespace VisualDesignPatterns
{
	/// <summary>
	/// DomainClass Design
	/// The root in which all other elements are embedded. Appears as a diagram.
	/// </summary>
	[DslDesign::DisplayNameResource("VisualDesignPatterns.Design.DisplayName", typeof(global::VisualDesignPatterns.DesiDomainModel), "VisualDesignPatterns.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("VisualDesignPatterns.Design.Description", typeof(global::VisualDesignPatterns.DesiDomainModel), "VisualDesignPatterns.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::VisualDesignPatterns.DesiDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("ada1f7a1-7c41-4c09-a8c8-56cd23a0ca89")]
	public partial class Design : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// Design domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xada1f7a1, 0x7c41, 0x4c09, 0xa8, 0xc8, 0x56, 0xcd, 0x23, 0xa0, 0xca, 0x89);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Design(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Design(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region DesignPatterns opposite domain role accessor
		
		/// <summary>
		/// Gets a list of DesignPatterns.
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<DesignPattern> DesignPatterns
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<DesignPattern>, DesignPattern>(global::VisualDesignPatterns.DesignHasDesignPatterns.DesignDomainRoleId);
			}
		}
		#endregion
		#region ElementGroupPrototype Merge methods
		/// <summary>
		/// Returns a value indicating whether the source element represented by the
		/// specified root ProtoElement can be added to this element.
		/// </summary>
		/// <param name="rootElement">
		/// The root ProtoElement representing a source element.  This can be null, 
		/// in which case the ElementGroupPrototype does not contain an ProtoElements
		/// and the code should inspect the ElementGroupPrototype context information.
		/// </param>
		/// <param name="elementGroupPrototype">The ElementGroupPrototype that contains the root ProtoElement.</param>
		/// <returns>true if the source element represented by the ProtoElement can be added to this target element.</returns>
		protected override bool CanMerge(DslModeling::ProtoElementBase rootElement, DslModeling::ElementGroupPrototype elementGroupPrototype)
		{
			if ( elementGroupPrototype == null ) throw new global::System.ArgumentNullException("elementGroupPrototype");
			
			if (rootElement != null)
			{
				DslModeling::DomainClassInfo rootElementDomainInfo = this.Partition.DomainDataDirectory.GetDomainClass(rootElement.DomainClassId);
				
				if (rootElementDomainInfo.IsDerivedFrom(global::VisualDesignPatterns.DesignPattern.DomainClassId)) 
				{
					return true;
				}
			}
			return base.CanMerge(rootElement, elementGroupPrototype);
		}
		
		/// <summary>
		/// Called by the Merge process to create a relationship between 
		/// this target element and the specified source element. 
		/// Typically, a parent-child relationship is established
		/// between the target element (the parent) and the source element 
		/// (the child), but any relationship can be established.
		/// </summary>
		/// <param name="sourceElement">The element that is to be related to this model element.</param>
		/// <param name="elementGroup">The group of source ModelElements that have been rehydrated into the target store.</param>
		/// <remarks>
		/// This method is overriden to create the relationship between the target element and the specified source element.
		/// The base method does nothing.
		/// </remarks>
		protected override void MergeRelate(DslModeling::ModelElement sourceElement, DslModeling::ElementGroup elementGroup)
		{
			// In general, sourceElement is allowed to be null, meaning that the elementGroup must be parsed for special cases.
			// However this is not supported in generated code.  Use double-deriving on this class and then override MergeRelate completely if you 
			// need to support this case.
			if ( sourceElement == null ) throw new global::System.ArgumentNullException("sourceElement");
		
				
			global::VisualDesignPatterns.DesignPattern sourceDesignPattern1 = sourceElement as global::VisualDesignPatterns.DesignPattern;
			if (sourceDesignPattern1 != null)
			{
				// Create link for path DesignHasDesignPatterns.DesignPatterns
				this.DesignPatterns.Add(sourceDesignPattern1);

				return;
			}
		
			// Sdk workaround to runtime bug #879350 (DSL: can't copy and paste a MEL that has a MEX). Avoid MergeRelate on ModelElementExtension
			// during a "Paste".
			if (sourceElement is DslModeling::ExtensionElement
				&& sourceElement.Store.TransactionManager.CurrentTransaction.TopLevelTransaction.Context.ContextInfo.ContainsKey("{9DAFD42A-DC0E-4d78-8C3F-8266B2CF8B33}"))
			{
				return;
			}
		
			// Fall through to base class if this class hasn't handled the merge.
			base.MergeRelate(sourceElement, elementGroup);
		}
		
		/// <summary>
		/// Performs operation opposite to MergeRelate - i.e. disconnects a given
		/// element from the current one (removes links created by MergeRelate).
		/// </summary>
		/// <param name="sourceElement">Element to be unmerged/disconnected.</param>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		protected override void MergeDisconnect(DslModeling::ModelElement sourceElement)
		{
			if (sourceElement == null) throw new global::System.ArgumentNullException("sourceElement");
				
			global::VisualDesignPatterns.DesignPattern sourceDesignPattern1 = sourceElement as global::VisualDesignPatterns.DesignPattern;
			if (sourceDesignPattern1 != null)
			{
				// Delete link for path DesignHasDesignPatterns.DesignPatterns
				
				foreach (DslModeling::ElementLink link in global::VisualDesignPatterns.DesignHasDesignPatterns.GetLinks((global::VisualDesignPatterns.Design)this, sourceDesignPattern1))
				{
					// Delete the link, but without possible delete propagation to the element since it's moving to a new location.
					link.Delete(global::VisualDesignPatterns.DesignHasDesignPatterns.DesignDomainRoleId, global::VisualDesignPatterns.DesignHasDesignPatterns.ElementDomainRoleId);
				}

				return;
			}
			// Fall through to base class if this class hasn't handled the unmerge.
			base.MergeDisconnect(sourceElement);
		}
		#endregion
	}
}
namespace VisualDesignPatterns
{
	/// <summary>
	/// DomainClass DesignPattern
	/// Elements embedded in the model. Appear as boxes on the diagram.
	/// </summary>
	[DslDesign::DisplayNameResource("VisualDesignPatterns.DesignPattern.DisplayName", typeof(global::VisualDesignPatterns.DesiDomainModel), "VisualDesignPatterns.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("VisualDesignPatterns.DesignPattern.Description", typeof(global::VisualDesignPatterns.DesiDomainModel), "VisualDesignPatterns.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::VisualDesignPatterns.DesiDomainModel))]
	[global::System.CLSCompliant(true)]
	[global::System.Diagnostics.DebuggerDisplay("{GetType().Name,nq} (Name = {namePropertyStorage})")]
	[DslModeling::DomainObjectId("9a056058-3b3c-49f3-a71a-351a5d858fe4")]
	public partial class DesignPattern : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// DesignPattern domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x9a056058, 0x3b3c, 0x49f3, 0xa7, 0x1a, 0x35, 0x1a, 0x5d, 0x85, 0x8f, 0xe4);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public DesignPattern(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public DesignPattern(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Name domain property code
		
		/// <summary>
		/// Name domain property Id.
		/// </summary>
		public static readonly global::System.Guid NameDomainPropertyId = new global::System.Guid(0x99a9cd97, 0x2883, 0x48a9, 0x80, 0xa0, 0x52, 0x9e, 0xec, 0x84, 0x7a, 0x05);
		
		/// <summary>
		/// Storage for Name
		/// </summary>
		private global::System.String namePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Name domain property.
		/// Description for VisualDesignPatterns.DesignPattern.Name
		/// </summary>
		[DslDesign::DisplayNameResource("VisualDesignPatterns.DesignPattern/Name.DisplayName", typeof(global::VisualDesignPatterns.DesiDomainModel), "VisualDesignPatterns.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("VisualDesignPatterns.DesignPattern/Name.Description", typeof(global::VisualDesignPatterns.DesiDomainModel), "VisualDesignPatterns.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("")]
		[DslModeling::ElementName]
		[DslModeling::DomainObjectId("99a9cd97-2883-48a9-80a0-529eec847a05")]
		public global::System.String Name
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return namePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				NamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the DesignPattern.Name domain property.
		/// </summary>
		internal sealed partial class NamePropertyHandler : DslModeling::DomainPropertyValueHandler<DesignPattern, global::System.String>
		{
			private NamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the DesignPattern.Name domain property value handler.
			/// </summary>
			public static readonly NamePropertyHandler Instance = new NamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the DesignPattern.Name domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return NameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(DesignPattern element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.namePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(DesignPattern element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.namePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Classification domain property code
		
		/// <summary>
		/// Classification domain property Id.
		/// </summary>
		public static readonly global::System.Guid ClassificationDomainPropertyId = new global::System.Guid(0x3c79500c, 0x0fde, 0x488f, 0x8f, 0x5b, 0x21, 0x24, 0xf2, 0x87, 0x19, 0xd8);
		
		/// <summary>
		/// Storage for Classification
		/// </summary>
		private PatternClassification classificationPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of Classification domain property.
		/// Description for VisualDesignPatterns.DesignPattern.Classification
		/// </summary>
		[DslDesign::DisplayNameResource("VisualDesignPatterns.DesignPattern/Classification.DisplayName", typeof(global::VisualDesignPatterns.DesiDomainModel), "VisualDesignPatterns.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("VisualDesignPatterns.DesignPattern/Classification.Description", typeof(global::VisualDesignPatterns.DesiDomainModel), "VisualDesignPatterns.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("3c79500c-0fde-488f-8f5b-2124f28719d8")]
		public PatternClassification Classification
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return classificationPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ClassificationPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the DesignPattern.Classification domain property.
		/// </summary>
		internal sealed partial class ClassificationPropertyHandler : DslModeling::DomainPropertyValueHandler<DesignPattern, PatternClassification>
		{
			private ClassificationPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the DesignPattern.Classification domain property value handler.
			/// </summary>
			public static readonly ClassificationPropertyHandler Instance = new ClassificationPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the DesignPattern.Classification domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ClassificationDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed PatternClassification GetValue(DesignPattern element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.classificationPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(DesignPattern element, PatternClassification newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				PatternClassification oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.classificationPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Design opposite domain role accessor
		/// <summary>
		/// Gets or sets Design.
		/// </summary>
		public virtual Design Design
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return DslModeling::DomainRoleInfo.GetLinkedElement(this, global::VisualDesignPatterns.DesignHasDesignPatterns.ElementDomainRoleId) as Design;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetLinkedElement(this, global::VisualDesignPatterns.DesignHasDesignPatterns.ElementDomainRoleId, value);
			}
		}
		#endregion
		#region AbstractClasses opposite domain role accessor
		
		/// <summary>
		/// Gets a list of AbstractClasses.
		/// Description for
		/// VisualDesignPatterns.DesignPatternHasAbstractClasses.DesignPattern
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<AbstractClass> AbstractClasses
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<AbstractClass>, AbstractClass>(global::VisualDesignPatterns.DesignPatternHasAbstractClasses.DesignPatternDomainRoleId);
			}
		}
		#endregion
		#region ConcreteClasses opposite domain role accessor
		
		/// <summary>
		/// Gets a list of ConcreteClasses.
		/// Description for
		/// VisualDesignPatterns.DesignPatternHasConcreteClasses.DesignPattern
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<ConcreteClass> ConcreteClasses
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<ConcreteClass>, ConcreteClass>(global::VisualDesignPatterns.DesignPatternHasConcreteClasses.DesignPatternDomainRoleId);
			}
		}
		#endregion
		#region ElementGroupPrototype Merge methods
		/// <summary>
		/// Returns a value indicating whether the source element represented by the
		/// specified root ProtoElement can be added to this element.
		/// </summary>
		/// <param name="rootElement">
		/// The root ProtoElement representing a source element.  This can be null, 
		/// in which case the ElementGroupPrototype does not contain an ProtoElements
		/// and the code should inspect the ElementGroupPrototype context information.
		/// </param>
		/// <param name="elementGroupPrototype">The ElementGroupPrototype that contains the root ProtoElement.</param>
		/// <returns>true if the source element represented by the ProtoElement can be added to this target element.</returns>
		protected override bool CanMerge(DslModeling::ProtoElementBase rootElement, DslModeling::ElementGroupPrototype elementGroupPrototype)
		{
			if ( elementGroupPrototype == null ) throw new global::System.ArgumentNullException("elementGroupPrototype");
			
			if (rootElement != null)
			{
				DslModeling::DomainClassInfo rootElementDomainInfo = this.Partition.DomainDataDirectory.GetDomainClass(rootElement.DomainClassId);
				
				if (rootElementDomainInfo.IsDerivedFrom(global::VisualDesignPatterns.ConcreteClass.DomainClassId)) 
				{
					return true;
				}
				
				if (rootElementDomainInfo.IsDerivedFrom(global::VisualDesignPatterns.AbstractClass.DomainClassId)) 
				{
					return true;
				}
			}
			return base.CanMerge(rootElement, elementGroupPrototype);
		}
		
		/// <summary>
		/// Called by the Merge process to create a relationship between 
		/// this target element and the specified source element. 
		/// Typically, a parent-child relationship is established
		/// between the target element (the parent) and the source element 
		/// (the child), but any relationship can be established.
		/// </summary>
		/// <param name="sourceElement">The element that is to be related to this model element.</param>
		/// <param name="elementGroup">The group of source ModelElements that have been rehydrated into the target store.</param>
		/// <remarks>
		/// This method is overriden to create the relationship between the target element and the specified source element.
		/// The base method does nothing.
		/// </remarks>
		protected override void MergeRelate(DslModeling::ModelElement sourceElement, DslModeling::ElementGroup elementGroup)
		{
			// In general, sourceElement is allowed to be null, meaning that the elementGroup must be parsed for special cases.
			// However this is not supported in generated code.  Use double-deriving on this class and then override MergeRelate completely if you 
			// need to support this case.
			if ( sourceElement == null ) throw new global::System.ArgumentNullException("sourceElement");
		
				
			global::VisualDesignPatterns.ConcreteClass sourceConcreteClass1 = sourceElement as global::VisualDesignPatterns.ConcreteClass;
			if (sourceConcreteClass1 != null)
			{
				// Create link for path DesignPatternHasConcreteClasses.ConcreteClasses
				this.ConcreteClasses.Add(sourceConcreteClass1);

				return;
			}
				
			global::VisualDesignPatterns.AbstractClass sourceAbstractClass2 = sourceElement as global::VisualDesignPatterns.AbstractClass;
			if (sourceAbstractClass2 != null)
			{
				// Create link for path DesignPatternHasAbstractClasses.AbstractClasses
				this.AbstractClasses.Add(sourceAbstractClass2);

				return;
			}
		
			// Sdk workaround to runtime bug #879350 (DSL: can't copy and paste a MEL that has a MEX). Avoid MergeRelate on ModelElementExtension
			// during a "Paste".
			if (sourceElement is DslModeling::ExtensionElement
				&& sourceElement.Store.TransactionManager.CurrentTransaction.TopLevelTransaction.Context.ContextInfo.ContainsKey("{9DAFD42A-DC0E-4d78-8C3F-8266B2CF8B33}"))
			{
				return;
			}
		
			// Fall through to base class if this class hasn't handled the merge.
			base.MergeRelate(sourceElement, elementGroup);
		}
		
		/// <summary>
		/// Performs operation opposite to MergeRelate - i.e. disconnects a given
		/// element from the current one (removes links created by MergeRelate).
		/// </summary>
		/// <param name="sourceElement">Element to be unmerged/disconnected.</param>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		protected override void MergeDisconnect(DslModeling::ModelElement sourceElement)
		{
			if (sourceElement == null) throw new global::System.ArgumentNullException("sourceElement");
				
			global::VisualDesignPatterns.ConcreteClass sourceConcreteClass1 = sourceElement as global::VisualDesignPatterns.ConcreteClass;
			if (sourceConcreteClass1 != null)
			{
				// Delete link for path DesignPatternHasConcreteClasses.ConcreteClasses
				
				foreach (DslModeling::ElementLink link in global::VisualDesignPatterns.DesignPatternHasConcreteClasses.GetLinks((global::VisualDesignPatterns.DesignPattern)this, sourceConcreteClass1))
				{
					// Delete the link, but without possible delete propagation to the element since it's moving to a new location.
					link.Delete(global::VisualDesignPatterns.DesignPatternHasConcreteClasses.DesignPatternDomainRoleId, global::VisualDesignPatterns.DesignPatternHasConcreteClasses.ConcreteClassDomainRoleId);
				}

				return;
			}
				
			global::VisualDesignPatterns.AbstractClass sourceAbstractClass2 = sourceElement as global::VisualDesignPatterns.AbstractClass;
			if (sourceAbstractClass2 != null)
			{
				// Delete link for path DesignPatternHasAbstractClasses.AbstractClasses
				
				foreach (DslModeling::ElementLink link in global::VisualDesignPatterns.DesignPatternHasAbstractClasses.GetLinks((global::VisualDesignPatterns.DesignPattern)this, sourceAbstractClass2))
				{
					// Delete the link, but without possible delete propagation to the element since it's moving to a new location.
					link.Delete(global::VisualDesignPatterns.DesignPatternHasAbstractClasses.DesignPatternDomainRoleId, global::VisualDesignPatterns.DesignPatternHasAbstractClasses.AbstractClassDomainRoleId);
				}

				return;
			}
			// Fall through to base class if this class hasn't handled the unmerge.
			base.MergeDisconnect(sourceElement);
		}
		#endregion
	}
}
namespace VisualDesignPatterns
{
	/// <summary>
	/// DomainClass AbstractClass
	/// Description for VisualDesignPatterns.AbstractClass
	/// </summary>
	[DslDesign::DisplayNameResource("VisualDesignPatterns.AbstractClass.DisplayName", typeof(global::VisualDesignPatterns.DesiDomainModel), "VisualDesignPatterns.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("VisualDesignPatterns.AbstractClass.Description", typeof(global::VisualDesignPatterns.DesiDomainModel), "VisualDesignPatterns.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::VisualDesignPatterns.DesiDomainModel))]
	[global::System.CLSCompliant(true)]
	[global::System.Diagnostics.DebuggerDisplay("{GetType().Name,nq} (Name = {namePropertyStorage})")]
	[DslModeling::DomainObjectId("dcbc7bd5-8653-4779-8931-c26a273ac8d6")]
	public partial class AbstractClass : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// AbstractClass domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xdcbc7bd5, 0x8653, 0x4779, 0x89, 0x31, 0xc2, 0x6a, 0x27, 0x3a, 0xc8, 0xd6);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public AbstractClass(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public AbstractClass(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Name domain property code
		
		/// <summary>
		/// Name domain property Id.
		/// </summary>
		public static readonly global::System.Guid NameDomainPropertyId = new global::System.Guid(0x10c3ebfd, 0x3629, 0x4cf9, 0xa5, 0xed, 0x0c, 0x1b, 0xb3, 0x18, 0x0e, 0xc2);
		
		/// <summary>
		/// Storage for Name
		/// </summary>
		private global::System.String namePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Name domain property.
		/// Description for VisualDesignPatterns.AbstractClass.Name
		/// </summary>
		[DslDesign::DisplayNameResource("VisualDesignPatterns.AbstractClass/Name.DisplayName", typeof(global::VisualDesignPatterns.DesiDomainModel), "VisualDesignPatterns.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("VisualDesignPatterns.AbstractClass/Name.Description", typeof(global::VisualDesignPatterns.DesiDomainModel), "VisualDesignPatterns.GeneratedCode.DomainModelResx")]
		[DslModeling::ElementName]
		[DslModeling::DomainObjectId("10c3ebfd-3629-4cf9-a5ed-0c1bb3180ec2")]
		public global::System.String Name
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return namePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				NamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the AbstractClass.Name domain property.
		/// </summary>
		internal sealed partial class NamePropertyHandler : DslModeling::DomainPropertyValueHandler<AbstractClass, global::System.String>
		{
			private NamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the AbstractClass.Name domain property value handler.
			/// </summary>
			public static readonly NamePropertyHandler Instance = new NamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the AbstractClass.Name domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return NameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(AbstractClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.namePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(AbstractClass element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.namePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region DesignPattern opposite domain role accessor
		/// <summary>
		/// Gets or sets DesignPattern.
		/// Description for
		/// VisualDesignPatterns.DesignPatternHasAbstractClasses.AbstractClass
		/// </summary>
		public virtual DesignPattern DesignPattern
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return DslModeling::DomainRoleInfo.GetLinkedElement(this, global::VisualDesignPatterns.DesignPatternHasAbstractClasses.AbstractClassDomainRoleId) as DesignPattern;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetLinkedElement(this, global::VisualDesignPatterns.DesignPatternHasAbstractClasses.AbstractClassDomainRoleId, value);
			}
		}
		#endregion
	}
}
namespace VisualDesignPatterns
{
	/// <summary>
	/// DomainClass ConcreteClass
	/// Description for VisualDesignPatterns.ConcreteClass
	/// </summary>
	[DslDesign::DisplayNameResource("VisualDesignPatterns.ConcreteClass.DisplayName", typeof(global::VisualDesignPatterns.DesiDomainModel), "VisualDesignPatterns.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("VisualDesignPatterns.ConcreteClass.Description", typeof(global::VisualDesignPatterns.DesiDomainModel), "VisualDesignPatterns.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::VisualDesignPatterns.DesiDomainModel))]
	[global::System.CLSCompliant(true)]
	[global::System.Diagnostics.DebuggerDisplay("{GetType().Name,nq} (Name = {namePropertyStorage})")]
	[DslModeling::DomainObjectId("c9e53612-f0e0-48a8-a046-ebcc4292ede2")]
	public partial class ConcreteClass : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// ConcreteClass domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xc9e53612, 0xf0e0, 0x48a8, 0xa0, 0x46, 0xeb, 0xcc, 0x42, 0x92, 0xed, 0xe2);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ConcreteClass(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ConcreteClass(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Name domain property code
		
		/// <summary>
		/// Name domain property Id.
		/// </summary>
		public static readonly global::System.Guid NameDomainPropertyId = new global::System.Guid(0x0f7f22c3, 0xca79, 0x4c26, 0xa9, 0x92, 0xc4, 0xfd, 0x35, 0x7e, 0xad, 0x91);
		
		/// <summary>
		/// Storage for Name
		/// </summary>
		private global::System.String namePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Name domain property.
		/// Description for VisualDesignPatterns.ConcreteClass.Name
		/// </summary>
		[DslDesign::DisplayNameResource("VisualDesignPatterns.ConcreteClass/Name.DisplayName", typeof(global::VisualDesignPatterns.DesiDomainModel), "VisualDesignPatterns.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("VisualDesignPatterns.ConcreteClass/Name.Description", typeof(global::VisualDesignPatterns.DesiDomainModel), "VisualDesignPatterns.GeneratedCode.DomainModelResx")]
		[DslModeling::ElementName]
		[DslModeling::DomainObjectId("0f7f22c3-ca79-4c26-a992-c4fd357ead91")]
		public global::System.String Name
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return namePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				NamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ConcreteClass.Name domain property.
		/// </summary>
		internal sealed partial class NamePropertyHandler : DslModeling::DomainPropertyValueHandler<ConcreteClass, global::System.String>
		{
			private NamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ConcreteClass.Name domain property value handler.
			/// </summary>
			public static readonly NamePropertyHandler Instance = new NamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ConcreteClass.Name domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return NameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ConcreteClass element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.namePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ConcreteClass element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.namePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region DesignPattern opposite domain role accessor
		/// <summary>
		/// Gets or sets DesignPattern.
		/// Description for
		/// VisualDesignPatterns.DesignPatternHasConcreteClasses.ConcreteClass
		/// </summary>
		public virtual DesignPattern DesignPattern
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return DslModeling::DomainRoleInfo.GetLinkedElement(this, global::VisualDesignPatterns.DesignPatternHasConcreteClasses.ConcreteClassDomainRoleId) as DesignPattern;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetLinkedElement(this, global::VisualDesignPatterns.DesignPatternHasConcreteClasses.ConcreteClassDomainRoleId, value);
			}
		}
		#endregion
	}
}
