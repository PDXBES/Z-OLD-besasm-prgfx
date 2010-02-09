#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using SAMaster.Entities;
using SAMaster.Data;
using SAMaster.Data.Bases;
#endregion

namespace SAMaster.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.MstNodesAcProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(MstNodesAcDataSourceDesigner))]
	public class MstNodesAcDataSource : ProviderDataSource<MstNodesAc, MstNodesAcKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MstNodesAcDataSource class.
		/// </summary>
		public MstNodesAcDataSource() : base(DataRepository.MstNodesAcProvider)
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the MstNodesAcDataSourceView used by the MstNodesAcDataSource.
		/// </summary>
		protected MstNodesAcDataSourceView MstNodesAcView
		{
			get { return ( View as MstNodesAcDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the MstNodesAcDataSource control invokes to retrieve data.
		/// </summary>
		public MstNodesAcSelectMethod SelectMethod
		{
			get
			{
				MstNodesAcSelectMethod selectMethod = MstNodesAcSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (MstNodesAcSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the MstNodesAcDataSourceView class that is to be
		/// used by the MstNodesAcDataSource.
		/// </summary>
		/// <returns>An instance of the MstNodesAcDataSourceView class.</returns>
		protected override BaseDataSourceView<MstNodesAc, MstNodesAcKey> GetNewDataSourceView()
		{
			return new MstNodesAcDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the MstNodesAcDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class MstNodesAcDataSourceView : ProviderDataSourceView<MstNodesAc, MstNodesAcKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MstNodesAcDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the MstNodesAcDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public MstNodesAcDataSourceView(MstNodesAcDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal MstNodesAcDataSource MstNodesAcOwner
		{
			get { return Owner as MstNodesAcDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal MstNodesAcSelectMethod SelectMethod
		{
			get { return MstNodesAcOwner.SelectMethod; }
			set { MstNodesAcOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal MstNodesAcProviderBase MstNodesAcProvider
		{
			get { return Provider as MstNodesAcProviderBase; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<MstNodesAc> GetSelectData(out int count)
		{
			Hashtable values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<MstNodesAc> results = null;
			MstNodesAc item;
			count = 0;
			
			System.String _node;
			System.Int32 _mapinfoId;

			switch ( SelectMethod )
			{
				case MstNodesAcSelectMethod.Get:
					MstNodesAcKey entityKey  = new MstNodesAcKey();
					entityKey.Load(values);
					item = MstNodesAcProvider.Get(GetTransactionManager(), entityKey);
					results = new TList<MstNodesAc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case MstNodesAcSelectMethod.GetAll:
                    results = MstNodesAcProvider.GetAll(GetTransactionManager(), StartIndex, PageSize, out count);
                    break;
				case MstNodesAcSelectMethod.GetPaged:
					results = MstNodesAcProvider.GetPaged(GetTransactionManager(), WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case MstNodesAcSelectMethod.Find:
					if ( FilterParameters != null )
						results = MstNodesAcProvider.Find(GetTransactionManager(), FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = MstNodesAcProvider.Find(GetTransactionManager(), WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case MstNodesAcSelectMethod.GetByMapinfoId:
					_mapinfoId = ( values["MapinfoId"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MapinfoId"], typeof(System.Int32)) : (int)0;
					item = MstNodesAcProvider.GetByMapinfoId(GetTransactionManager(), _mapinfoId);
					results = new TList<MstNodesAc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				case MstNodesAcSelectMethod.GetByNode:
					_node = ( values["Node"] != null ) ? (System.String) EntityUtil.ChangeType(values["Node"], typeof(System.String)) : string.Empty;
					item = MstNodesAcProvider.GetByNode(GetTransactionManager(), _node);
					results = new TList<MstNodesAc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// FK
				// M:M
				// Custom
				default:
					break;
			}

			if ( results != null && count < 1 )
			{
				count = results.Count;

				if ( !String.IsNullOrEmpty(CustomMethodRecordCountParamName) )
				{
					object objCustomCount = EntityUtil.ChangeType(customOutput[CustomMethodRecordCountParamName], typeof(Int32));
					
					if ( objCustomCount != null )
					{
						count = (int) objCustomCount;
					}
				}
			}
			
			return results;
		}
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == MstNodesAcSelectMethod.Get || SelectMethod == MstNodesAcSelectMethod.GetByMapinfoId )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				MstNodesAc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// execute deep load method
					MstNodesAcProvider.DeepLoad(GetTransactionManager(), GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<MstNodesAc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// execute deep load method
			MstNodesAcProvider.DeepLoad(GetTransactionManager(), entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region MstNodesAcDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the MstNodesAcDataSource class.
	/// </summary>
	public class MstNodesAcDataSourceDesigner : ProviderDataSourceDesigner<MstNodesAc, MstNodesAcKey>
	{
		/// <summary>
		/// Initializes a new instance of the MstNodesAcDataSourceDesigner class.
		/// </summary>
		public MstNodesAcDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MstNodesAcSelectMethod SelectMethod
		{
			get { return ((MstNodesAcDataSource) DataSource).SelectMethod; }
			set { SetPropertyValue("SelectMethod", value); }
		}

		/// <summary>Gets the designer action list collection for this designer.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.DesignerActionListCollection"/>
		/// associated with this designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				DesignerActionListCollection actions = new DesignerActionListCollection();
				actions.Add(new MstNodesAcDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region MstNodesAcDataSourceActionList

	/// <summary>
	/// Supports the MstNodesAcDataSourceDesigner class.
	/// </summary>
	internal class MstNodesAcDataSourceActionList : DesignerActionList
	{
		private MstNodesAcDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the MstNodesAcDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public MstNodesAcDataSourceActionList(MstNodesAcDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MstNodesAcSelectMethod SelectMethod
		{
			get { return _designer.SelectMethod; }
			set { _designer.SelectMethod = value; }
		}

		/// <summary>
		/// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// objects contained in the list.
		/// </summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// array that contains the items in this list.</returns>
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			DesignerActionItemCollection items = new DesignerActionItemCollection();
			items.Add(new DesignerActionPropertyItem("SelectMethod", "Select Method", "Methods"));
			return items;
		}
	}

	#endregion MstNodesAcDataSourceActionList
	
	#endregion MstNodesAcDataSourceDesigner
	
	#region MstNodesAcSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the MstNodesAcDataSource.SelectMethod property.
	/// </summary>
	public enum MstNodesAcSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetByNode method.
		/// </summary>
		GetByNode,
		/// <summary>
		/// Represents the GetByMapinfoId method.
		/// </summary>
		GetByMapinfoId
	}
	
	#endregion MstNodesAcSelectMethod

	#region MstNodesAcFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MstNodesAc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MstNodesAcFilter : SqlFilter<MstNodesAcColumn>
	{
	}
	
	#endregion MstNodesAcFilter

	#region MstNodesAcExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MstNodesAc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MstNodesAcExpressionBuilder : SqlExpressionBuilder<MstNodesAcColumn>
	{
	}
	
	#endregion MstNodesAcExpressionBuilder	

	#region MstNodesAcProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;MstNodesAcChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="MstNodesAc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MstNodesAcProperty : ChildEntityProperty<MstNodesAcChildEntityTypes>
	{
	}
	
	#endregion MstNodesAcProperty
}

