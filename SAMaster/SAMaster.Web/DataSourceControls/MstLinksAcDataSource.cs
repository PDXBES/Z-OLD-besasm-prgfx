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
	/// Represents the DataRepository.MstLinksAcProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(MstLinksAcDataSourceDesigner))]
	public class MstLinksAcDataSource : ProviderDataSource<MstLinksAc, MstLinksAcKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MstLinksAcDataSource class.
		/// </summary>
		public MstLinksAcDataSource() : base(DataRepository.MstLinksAcProvider)
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the MstLinksAcDataSourceView used by the MstLinksAcDataSource.
		/// </summary>
		protected MstLinksAcDataSourceView MstLinksAcView
		{
			get { return ( View as MstLinksAcDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the MstLinksAcDataSource control invokes to retrieve data.
		/// </summary>
		public MstLinksAcSelectMethod SelectMethod
		{
			get
			{
				MstLinksAcSelectMethod selectMethod = MstLinksAcSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (MstLinksAcSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the MstLinksAcDataSourceView class that is to be
		/// used by the MstLinksAcDataSource.
		/// </summary>
		/// <returns>An instance of the MstLinksAcDataSourceView class.</returns>
		protected override BaseDataSourceView<MstLinksAc, MstLinksAcKey> GetNewDataSourceView()
		{
			return new MstLinksAcDataSourceView(this, DefaultViewName);
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
	/// Supports the MstLinksAcDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class MstLinksAcDataSourceView : ProviderDataSourceView<MstLinksAc, MstLinksAcKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MstLinksAcDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the MstLinksAcDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public MstLinksAcDataSourceView(MstLinksAcDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal MstLinksAcDataSource MstLinksAcOwner
		{
			get { return Owner as MstLinksAcDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal MstLinksAcSelectMethod SelectMethod
		{
			get { return MstLinksAcOwner.SelectMethod; }
			set { MstLinksAcOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal MstLinksAcProviderBase MstLinksAcProvider
		{
			get { return Provider as MstLinksAcProviderBase; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<MstLinksAc> GetSelectData(out int count)
		{
			Hashtable values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<MstLinksAc> results = null;
			MstLinksAc item;
			count = 0;
			
			System.Int32 _mapinfoId;
			System.String _dsNode_nullable;
			System.String _usNode_nullable;

			switch ( SelectMethod )
			{
				case MstLinksAcSelectMethod.Get:
					MstLinksAcKey entityKey  = new MstLinksAcKey();
					entityKey.Load(values);
					item = MstLinksAcProvider.Get(GetTransactionManager(), entityKey);
					results = new TList<MstLinksAc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case MstLinksAcSelectMethod.GetAll:
                    results = MstLinksAcProvider.GetAll(GetTransactionManager(), StartIndex, PageSize, out count);
                    break;
				case MstLinksAcSelectMethod.GetPaged:
					results = MstLinksAcProvider.GetPaged(GetTransactionManager(), WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case MstLinksAcSelectMethod.Find:
					if ( FilterParameters != null )
						results = MstLinksAcProvider.Find(GetTransactionManager(), FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = MstLinksAcProvider.Find(GetTransactionManager(), WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case MstLinksAcSelectMethod.GetByMapinfoId:
					_mapinfoId = ( values["MapinfoId"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MapinfoId"], typeof(System.Int32)) : (int)0;
					item = MstLinksAcProvider.GetByMapinfoId(GetTransactionManager(), _mapinfoId);
					results = new TList<MstLinksAc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case MstLinksAcSelectMethod.GetByDsNode:
					_dsNode_nullable = (System.String) EntityUtil.ChangeType(values["DsNode"], typeof(System.String));
					results = MstLinksAcProvider.GetByDsNode(GetTransactionManager(), _dsNode_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case MstLinksAcSelectMethod.GetByUsNode:
					_usNode_nullable = (System.String) EntityUtil.ChangeType(values["UsNode"], typeof(System.String));
					results = MstLinksAcProvider.GetByUsNode(GetTransactionManager(), _usNode_nullable, this.StartIndex, this.PageSize, out count);
					break;
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
			if ( SelectMethod == MstLinksAcSelectMethod.Get || SelectMethod == MstLinksAcSelectMethod.GetByMapinfoId )
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
				MstLinksAc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// execute deep load method
					MstLinksAcProvider.DeepLoad(GetTransactionManager(), GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<MstLinksAc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// execute deep load method
			MstLinksAcProvider.DeepLoad(GetTransactionManager(), entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region MstLinksAcDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the MstLinksAcDataSource class.
	/// </summary>
	public class MstLinksAcDataSourceDesigner : ProviderDataSourceDesigner<MstLinksAc, MstLinksAcKey>
	{
		/// <summary>
		/// Initializes a new instance of the MstLinksAcDataSourceDesigner class.
		/// </summary>
		public MstLinksAcDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MstLinksAcSelectMethod SelectMethod
		{
			get { return ((MstLinksAcDataSource) DataSource).SelectMethod; }
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
				actions.Add(new MstLinksAcDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region MstLinksAcDataSourceActionList

	/// <summary>
	/// Supports the MstLinksAcDataSourceDesigner class.
	/// </summary>
	internal class MstLinksAcDataSourceActionList : DesignerActionList
	{
		private MstLinksAcDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the MstLinksAcDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public MstLinksAcDataSourceActionList(MstLinksAcDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MstLinksAcSelectMethod SelectMethod
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

	#endregion MstLinksAcDataSourceActionList
	
	#endregion MstLinksAcDataSourceDesigner
	
	#region MstLinksAcSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the MstLinksAcDataSource.SelectMethod property.
	/// </summary>
	public enum MstLinksAcSelectMethod
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
		/// Represents the GetByMapinfoId method.
		/// </summary>
		GetByMapinfoId,
		/// <summary>
		/// Represents the GetByDsNode method.
		/// </summary>
		GetByDsNode,
		/// <summary>
		/// Represents the GetByUsNode method.
		/// </summary>
		GetByUsNode
	}
	
	#endregion MstLinksAcSelectMethod

	#region MstLinksAcFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MstLinksAc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MstLinksAcFilter : SqlFilter<MstLinksAcColumn>
	{
	}
	
	#endregion MstLinksAcFilter

	#region MstLinksAcExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MstLinksAc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MstLinksAcExpressionBuilder : SqlExpressionBuilder<MstLinksAcColumn>
	{
	}
	
	#endregion MstLinksAcExpressionBuilder	

	#region MstLinksAcProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;MstLinksAcChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="MstLinksAc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MstLinksAcProperty : ChildEntityProperty<MstLinksAcChildEntityTypes>
	{
	}
	
	#endregion MstLinksAcProperty
}

