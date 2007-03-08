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
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;

namespace Altinoren.ActiveWriter
{
	/// <summary>
	/// Helper class used to create and initialize toolbox items for this DSL.
	/// </summary>
	/// <remarks>
	/// Double-derived class to allow easier code customization.
	/// </remarks>
	public partial class ActiveWriterToolboxHelper : ActiveWriterToolboxHelperBase 
	{
		/// <summary>
		/// Constructs a new ActiveWriterToolboxHelper.
		/// </summary>
		public ActiveWriterToolboxHelper(global::System.IServiceProvider serviceProvider)
			: base(serviceProvider) { }
	}
	
	/// <summary>
	/// Helper class used to create and initialize toolbox items for this DSL.
	/// </summary>
	public abstract class ActiveWriterToolboxHelperBase
	{
		/// <summary>
		/// Toolbox item filter string used to identify ActiveWriter toolbox items.  
		/// </summary>
		/// <remarks>
		/// See the MSDN documentation for the ToolboxItemFilterAttribute class for more information on toolbox
		/// item filters.
		/// </remarks>
		public const string ToolboxFilterString = "ActiveWriter.1.0";
		/// <summary>
		/// Toolbox item filter string used to identify ManyToOneRelationship connector tool.
		/// </summary>
		public const string ManyToOneRelationshipFilterString = "ManyToOneRelationship.1.0";
		/// <summary>
		/// Toolbox item filter string used to identify ManyToManyRelationship connector tool.
		/// </summary>
		public const string ManyToManyRelationshipFilterString = "ManyToManyRelationship.1.0";
		/// <summary>
		/// Toolbox item filter string used to identify OneToOneRelationship connector tool.
		/// </summary>
		public const string OneToOneRelationshipFilterString = "OneToOneRelationship.1.0";

		private global::System.IServiceProvider sp;
		
		/// <summary>
		/// Constructs a new ActiveWriterToolboxHelperBase.
		/// </summary>
		protected ActiveWriterToolboxHelperBase(global::System.IServiceProvider serviceProvider)
		{
			if(serviceProvider == null) throw new global::System.ArgumentNullException("serviceProvider");
			
			this.sp = serviceProvider;
		}
		
		/// <summary>
		/// Serivce provider used to access services from the hosting environment.
		/// </summary>
		protected global::System.IServiceProvider ServiceProvider
		{
			get
			{
				return this.sp;
			}
		}

		/// <summary>
		/// Returns the display name of the tab that should be opened by default when the editor is opened.
		/// </summary>
		public static string DefaultToolboxTabName
		{
			get
			{
				return global::Altinoren.ActiveWriter.ActiveWriterDomainModel.SingletonResourceManager.GetString("ActiveWriterToolboxTab", global::System.Globalization.CultureInfo.CurrentUICulture);
			}
		}
		
		
		/// <summary>
		/// Returns the toolbox items count in the default tool box tab.
		/// </summary>
		public static int DefaultToolboxTabToolboxItemsCount
		{
			get
			{
				return 4;
			}
		}
		

		/// <summary>
		/// Returns a list of toolbox items for use with this DSL.
		/// </summary>
		public virtual global::System.Collections.Generic.IList<DslDesign::ModelingToolboxItem> CreateToolboxItems()
		{
			global::System.Collections.Generic.List<DslDesign::ModelingToolboxItem> toolboxItems = new global::System.Collections.Generic.List<DslDesign::ModelingToolboxItem>();
			
			// Create store and load domain models.
			using(DslModeling::Store store = new DslModeling::Store(this.ServiceProvider))
			{
				store.LoadDomainModels(typeof(DslDiagrams::CoreDesignSurfaceDomainModel),
					typeof(global::Altinoren.ActiveWriter.ActiveWriterDomainModel));
				global::System.Resources.ResourceManager resourceManager = global::Altinoren.ActiveWriter.ActiveWriterDomainModel.SingletonResourceManager;
				global::System.Globalization.CultureInfo resourceCulture = global::System.Globalization.CultureInfo.CurrentUICulture;
			
				// Open transaction so we can create model elements corresponding to toolbox items.
				using(DslModeling::Transaction t = store.TransactionManager.BeginTransaction("CreateToolboxItems"))
				{

					// Add Class shape tool.
					toolboxItems.Add(new DslDesign::ModelingToolboxItem(
						"ClassToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						1, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("ClassToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("ClassToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"ActiveWriterToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("ActiveWriterToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"CreateClassF1Keyword", // F1 help keyword for the toolbox item.
						resourceManager.GetString("ClassToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::Altinoren.ActiveWriter.ModelClass.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						}));

					// Add ManyToOneRelationship connector tool.
					toolboxItems.Add(new DslDesign::ModelingToolboxItem(
						"ManyToOneRelationshipToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						2, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("ManyToOneRelationshipToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("ManyToOneRelationshipToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.				
						"ActiveWriterToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("ActiveWriterToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"ConnectRelationF1Keyword", // F1 help keyword for the toolbox item.
						resourceManager.GetString("ManyToOneRelationshipToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						null, // Connector toolbox items do not have an underlying data object.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require), 
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ManyToOneRelationshipFilterString)
						}));

					// Add ManyToManyRelationship connector tool.
					toolboxItems.Add(new DslDesign::ModelingToolboxItem(
						"ManyToManyRelationshipToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						3, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("ManyToManyRelationshipToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("ManyToManyRelationshipToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.				
						"ActiveWriterToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("ActiveWriterToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"ManyToManyRelationship", // F1 help keyword for the toolbox item.
						resourceManager.GetString("ManyToManyRelationshipToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						null, // Connector toolbox items do not have an underlying data object.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require), 
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ManyToManyRelationshipFilterString)
						}));

					// Add OneToOneRelationship connector tool.
					toolboxItems.Add(new DslDesign::ModelingToolboxItem(
						"OneToOneRelationshipToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						4, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("OneToOneRelationshipToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("OneToOneRelationshipToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.				
						"ActiveWriterToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("ActiveWriterToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"OneToOneRelationship", // F1 help keyword for the toolbox item.
						resourceManager.GetString("OneToOneRelationshipToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						null, // Connector toolbox items do not have an underlying data object.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require), 
							new global::System.ComponentModel.ToolboxItemFilterAttribute(OneToOneRelationshipFilterString)
						}));

					t.Rollback();
				}
			}

			return toolboxItems;
		}
		
		/// <summary>
		/// Creates an ElementGroupPrototype for the element tool corresponding to the given domain class id.
		/// Default behavior is to create a prototype containing an instance of the domain class.
		/// Derived classes may override this to add additional information to the prototype.
		/// </summary>
		protected virtual DslModeling::ElementGroupPrototype CreateElementToolPrototype(DslModeling::Store store, global::System.Guid domainClassId)
		{
			DslModeling::ModelElement element = store.ElementFactory.CreateElement(domainClassId);
			DslModeling::ElementGroup elementGroup = new DslModeling::ElementGroup(store.DefaultPartition);
			elementGroup.AddGraph(element, true);
			return elementGroup.CreatePrototype();
		}
	}
}
