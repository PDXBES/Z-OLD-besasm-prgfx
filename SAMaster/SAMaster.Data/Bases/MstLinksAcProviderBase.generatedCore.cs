#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using SAMaster.Entities;
using SAMaster.Data;

#endregion

namespace SAMaster.Data.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="MstLinksAcProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MstLinksAcProviderBaseCore : EntityProviderBase<SAMaster.Entities.MstLinksAc, SAMaster.Entities.MstLinksAcKey>
	{		
		#region Get from Many To Many Relationship Functions
		#endregion	
		
		#region Delete Methods

		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to delete.</param>
		/// <returns>Returns true if operation suceeded.</returns>
		public override bool Delete(TransactionManager transactionManager, SAMaster.Entities.MstLinksAcKey key)
		{
			return Delete(transactionManager, key.MapinfoId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="_mapinfoId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public bool Delete(System.Int32 _mapinfoId)
		{
			return Delete(null, _mapinfoId);
		}
		
		/// <summary>
		/// 	Deletes a row from the DataSource.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mapinfoId">. Primary Key.</param>
		/// <remarks>Deletes based on primary key(s).</remarks>
		/// <returns>Returns true if operation suceeded.</returns>
		public abstract bool Delete(TransactionManager transactionManager, System.Int32 _mapinfoId);		
		
		#endregion Delete Methods
		
		#region Get By Foreign Key Functions
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_mst_links_ac_DSmst_nodes_ac key.
		///		FK_mst_links_ac_DSmst_nodes_ac Description: 
		/// </summary>
		/// <param name="_dsNode"></param>
		/// <returns>Returns a typed collection of SAMaster.Entities.MstLinksAc objects.</returns>
		public TList<MstLinksAc> GetByDsNode(System.String _dsNode)
		{
			int count = -1;
			return GetByDsNode(_dsNode, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_mst_links_ac_DSmst_nodes_ac key.
		///		FK_mst_links_ac_DSmst_nodes_ac Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_dsNode"></param>
		/// <returns>Returns a typed collection of SAMaster.Entities.MstLinksAc objects.</returns>
		/// <remarks></remarks>
		public TList<MstLinksAc> GetByDsNode(TransactionManager transactionManager, System.String _dsNode)
		{
			int count = -1;
			return GetByDsNode(transactionManager, _dsNode, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_mst_links_ac_DSmst_nodes_ac key.
		///		FK_mst_links_ac_DSmst_nodes_ac Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_dsNode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of SAMaster.Entities.MstLinksAc objects.</returns>
		public TList<MstLinksAc> GetByDsNode(TransactionManager transactionManager, System.String _dsNode, int start, int pageLength)
		{
			int count = -1;
			return GetByDsNode(transactionManager, _dsNode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_mst_links_ac_DSmst_nodes_ac key.
		///		fkMstLinksAcDsmstNodesAc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_dsNode"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of SAMaster.Entities.MstLinksAc objects.</returns>
		public TList<MstLinksAc> GetByDsNode(System.String _dsNode, int start, int pageLength)
		{
			int count =  -1;
			return GetByDsNode(null, _dsNode, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_mst_links_ac_DSmst_nodes_ac key.
		///		fkMstLinksAcDsmstNodesAc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_dsNode"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of SAMaster.Entities.MstLinksAc objects.</returns>
		public TList<MstLinksAc> GetByDsNode(System.String _dsNode, int start, int pageLength,out int count)
		{
			return GetByDsNode(null, _dsNode, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_mst_links_ac_DSmst_nodes_ac key.
		///		FK_mst_links_ac_DSmst_nodes_ac Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_dsNode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of SAMaster.Entities.MstLinksAc objects.</returns>
		public abstract TList<MstLinksAc> GetByDsNode(TransactionManager transactionManager, System.String _dsNode, int start, int pageLength, out int count);
		
	
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_mst_links_ac_USmst_nodes_ac key.
		///		FK_mst_links_ac_USmst_nodes_ac Description: 
		/// </summary>
		/// <param name="_usNode"></param>
		/// <returns>Returns a typed collection of SAMaster.Entities.MstLinksAc objects.</returns>
		public TList<MstLinksAc> GetByUsNode(System.String _usNode)
		{
			int count = -1;
			return GetByUsNode(_usNode, 0,int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_mst_links_ac_USmst_nodes_ac key.
		///		FK_mst_links_ac_USmst_nodes_ac Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_usNode"></param>
		/// <returns>Returns a typed collection of SAMaster.Entities.MstLinksAc objects.</returns>
		/// <remarks></remarks>
		public TList<MstLinksAc> GetByUsNode(TransactionManager transactionManager, System.String _usNode)
		{
			int count = -1;
			return GetByUsNode(transactionManager, _usNode, 0, int.MaxValue, out count);
		}
		
			/// <summary>
		/// 	Gets rows from the datasource based on the FK_mst_links_ac_USmst_nodes_ac key.
		///		FK_mst_links_ac_USmst_nodes_ac Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_usNode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		///  <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of SAMaster.Entities.MstLinksAc objects.</returns>
		public TList<MstLinksAc> GetByUsNode(TransactionManager transactionManager, System.String _usNode, int start, int pageLength)
		{
			int count = -1;
			return GetByUsNode(transactionManager, _usNode, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_mst_links_ac_USmst_nodes_ac key.
		///		fkMstLinksAcUsmstNodesAc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_usNode"></param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of SAMaster.Entities.MstLinksAc objects.</returns>
		public TList<MstLinksAc> GetByUsNode(System.String _usNode, int start, int pageLength)
		{
			int count =  -1;
			return GetByUsNode(null, _usNode, start, pageLength,out count);	
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_mst_links_ac_USmst_nodes_ac key.
		///		fkMstLinksAcUsmstNodesAc Description: 
		/// </summary>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="_usNode"></param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns a typed collection of SAMaster.Entities.MstLinksAc objects.</returns>
		public TList<MstLinksAc> GetByUsNode(System.String _usNode, int start, int pageLength,out int count)
		{
			return GetByUsNode(null, _usNode, start, pageLength, out count);	
		}
						
		/// <summary>
		/// 	Gets rows from the datasource based on the FK_mst_links_ac_USmst_nodes_ac key.
		///		FK_mst_links_ac_USmst_nodes_ac Description: 
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_usNode"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns a typed collection of SAMaster.Entities.MstLinksAc objects.</returns>
		public abstract TList<MstLinksAc> GetByUsNode(TransactionManager transactionManager, System.String _usNode, int start, int pageLength, out int count);
		
		#endregion

		#region Get By Index Functions
		
		/// <summary>
		/// 	Gets a row from the DataSource based on its primary key.
		/// </summary>
		/// <param name="transactionManager">A <see cref="TransactionManager"/> object.</param>
		/// <param name="key">The unique identifier of the row to retrieve.</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <returns>Returns an instance of the Entity class.</returns>
		public override SAMaster.Entities.MstLinksAc Get(TransactionManager transactionManager, SAMaster.Entities.MstLinksAcKey key, int start, int pageLength)
		{
			return GetByMapinfoId(transactionManager, key.MapinfoId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_mst_links_ac index.
		/// </summary>
		/// <param name="_mapinfoId"></param>
		/// <returns>Returns an instance of the <see cref="SAMaster.Entities.MstLinksAc"/> class.</returns>
		public SAMaster.Entities.MstLinksAc GetByMapinfoId(System.Int32 _mapinfoId)
		{
			int count = -1;
			return GetByMapinfoId(null,_mapinfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_mst_links_ac index.
		/// </summary>
		/// <param name="_mapinfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="SAMaster.Entities.MstLinksAc"/> class.</returns>
		public SAMaster.Entities.MstLinksAc GetByMapinfoId(System.Int32 _mapinfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByMapinfoId(null, _mapinfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_mst_links_ac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mapinfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="SAMaster.Entities.MstLinksAc"/> class.</returns>
		public SAMaster.Entities.MstLinksAc GetByMapinfoId(TransactionManager transactionManager, System.Int32 _mapinfoId)
		{
			int count = -1;
			return GetByMapinfoId(transactionManager, _mapinfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_mst_links_ac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mapinfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="SAMaster.Entities.MstLinksAc"/> class.</returns>
		public SAMaster.Entities.MstLinksAc GetByMapinfoId(TransactionManager transactionManager, System.Int32 _mapinfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByMapinfoId(transactionManager, _mapinfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_mst_links_ac index.
		/// </summary>
		/// <param name="_mapinfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="SAMaster.Entities.MstLinksAc"/> class.</returns>
		public SAMaster.Entities.MstLinksAc GetByMapinfoId(System.Int32 _mapinfoId, int start, int pageLength, out int count)
		{
			return GetByMapinfoId(null, _mapinfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_mst_links_ac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mapinfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="SAMaster.Entities.MstLinksAc"/> class.</returns>
		public abstract SAMaster.Entities.MstLinksAc GetByMapinfoId(TransactionManager transactionManager, System.Int32 _mapinfoId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MstLinksAc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MstLinksAc&gt;"/></returns>
		public static TList<MstLinksAc> Fill(IDataReader reader, TList<MstLinksAc> rows, int start, int pageLength)
		{
			NetTiersProvider currentProvider = DataRepository.Provider;
            bool useEntityFactory = currentProvider.UseEntityFactory;
            bool enableEntityTracking = currentProvider.EnableEntityTracking;
            LoadPolicy currentLoadPolicy = currentProvider.CurrentLoadPolicy;
			Type entityCreationFactoryType = currentProvider.EntityCreationalFactoryType;
			
			// advance to the starting row
			for (int i = 0; i < start; i++)
			{
				if (!reader.Read())
				return rows; // not enough rows, just return
			}
			for (int i = 0; i < pageLength; i++)
			{
				if (!reader.Read())
					break; // we are done
					
				string key = null;
				
				SAMaster.Entities.MstLinksAc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MstLinksAc")
					.Append("|").Append((System.Int32)reader[((int)MstLinksAcColumn.MapinfoId - 1)]).ToString();
					c = EntityManager.LocateOrCreate<MstLinksAc>(
					key.ToString(), // EntityTrackingKey
					"MstLinksAc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new SAMaster.Entities.MstLinksAc();
				}
				
				if (!enableEntityTracking ||
					c.EntityState == EntityState.Added ||
					(enableEntityTracking &&
					
						(
							(currentLoadPolicy == LoadPolicy.PreserveChanges && c.EntityState == EntityState.Unchanged) ||
							(currentLoadPolicy == LoadPolicy.DiscardChanges && c.EntityState != EntityState.Unchanged)
						)
					))
				{
					c.SuppressEntityEvents = true;
					c.MapinfoId = (System.Int32)reader[((int)MstLinksAcColumn.MapinfoId - 1)];
					c.OriginalMapinfoId = c.MapinfoId;
					c.MlinkId = (reader.IsDBNull(((int)MstLinksAcColumn.MlinkId - 1)))?null:(System.Int32?)reader[((int)MstLinksAcColumn.MlinkId - 1)];
					c.CompKey = (reader.IsDBNull(((int)MstLinksAcColumn.CompKey - 1)))?null:(System.Int32?)reader[((int)MstLinksAcColumn.CompKey - 1)];
					c.UsNode = (reader.IsDBNull(((int)MstLinksAcColumn.UsNode - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.UsNode - 1)];
					c.DsNode = (reader.IsDBNull(((int)MstLinksAcColumn.DsNode - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.DsNode - 1)];
					c.PipeShape = (reader.IsDBNull(((int)MstLinksAcColumn.PipeShape - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.PipeShape - 1)];
					c.LinkType = (reader.IsDBNull(((int)MstLinksAcColumn.LinkType - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.LinkType - 1)];
					c.PipeFlowType = (reader.IsDBNull(((int)MstLinksAcColumn.PipeFlowType - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.PipeFlowType - 1)];
					c.Length = (reader.IsDBNull(((int)MstLinksAcColumn.Length - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Length - 1)];
					c.DiamWidth = (reader.IsDBNull(((int)MstLinksAcColumn.DiamWidth - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.DiamWidth - 1)];
					c.Height = (reader.IsDBNull(((int)MstLinksAcColumn.Height - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Height - 1)];
					c.Material = (reader.IsDBNull(((int)MstLinksAcColumn.Material - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.Material - 1)];
					c.Upsdpth = (reader.IsDBNull(((int)MstLinksAcColumn.Upsdpth - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Upsdpth - 1)];
					c.Dwndpth = (reader.IsDBNull(((int)MstLinksAcColumn.Dwndpth - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Dwndpth - 1)];
					c.Usie = (reader.IsDBNull(((int)MstLinksAcColumn.Usie - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Usie - 1)];
					c.Dsie = (reader.IsDBNull(((int)MstLinksAcColumn.Dsie - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Dsie - 1)];
					c.AsBuilt = (reader.IsDBNull(((int)MstLinksAcColumn.AsBuilt - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.AsBuilt - 1)];
					c.Instdate = (reader.IsDBNull(((int)MstLinksAcColumn.Instdate - 1)))?null:(System.DateTime?)reader[((int)MstLinksAcColumn.Instdate - 1)];
					c.Fromx = (reader.IsDBNull(((int)MstLinksAcColumn.Fromx - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Fromx - 1)];
					c.Fromy = (reader.IsDBNull(((int)MstLinksAcColumn.Fromy - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Fromy - 1)];
					c.Tox = (reader.IsDBNull(((int)MstLinksAcColumn.Tox - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Tox - 1)];
					c.Toy = (reader.IsDBNull(((int)MstLinksAcColumn.Toy - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Toy - 1)];
					c.Roughness = (reader.IsDBNull(((int)MstLinksAcColumn.Roughness - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Roughness - 1)];
					c.TimeFrame = (reader.IsDBNull(((int)MstLinksAcColumn.TimeFrame - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.TimeFrame - 1)];
					c.DataFlagSynth = (reader.IsDBNull(((int)MstLinksAcColumn.DataFlagSynth - 1)))?null:(System.Int32?)reader[((int)MstLinksAcColumn.DataFlagSynth - 1)];
					c.DataQual = (reader.IsDBNull(((int)MstLinksAcColumn.DataQual - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.DataQual - 1)];
					c.Hservstat = (reader.IsDBNull(((int)MstLinksAcColumn.Hservstat - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.Hservstat - 1)];
					c.ValidFromDate = (reader.IsDBNull(((int)MstLinksAcColumn.ValidFromDate - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.ValidFromDate - 1)];
					c.ValidToDate = (reader.IsDBNull(((int)MstLinksAcColumn.ValidToDate - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.ValidToDate - 1)];
					c.CadKey = (reader.IsDBNull(((int)MstLinksAcColumn.CadKey - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.CadKey - 1)];
					c.AuditNodeId = (reader.IsDBNull(((int)MstLinksAcColumn.AuditNodeId - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.AuditNodeId - 1)];
					c.AuditDups = (reader.IsDBNull(((int)MstLinksAcColumn.AuditDups - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.AuditDups - 1)];
					c.AuditSpatial = (reader.IsDBNull(((int)MstLinksAcColumn.AuditSpatial - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.AuditSpatial - 1)];
					c.AuditOk2Go = (System.Boolean)reader[((int)MstLinksAcColumn.AuditOk2Go - 1)];
					c.AuditProcTimestamp = (reader.IsDBNull(((int)MstLinksAcColumn.AuditProcTimestamp - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.AuditProcTimestamp - 1)];
					c.Qdes = (reader.IsDBNull(((int)MstLinksAcColumn.Qdes - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Qdes - 1)];
					c.DmeGlobalId = (reader.IsDBNull(((int)MstLinksAcColumn.DmeGlobalId - 1)))?null:(System.Int32?)reader[((int)MstLinksAcColumn.DmeGlobalId - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="SAMaster.Entities.MstLinksAc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="SAMaster.Entities.MstLinksAc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, SAMaster.Entities.MstLinksAc entity)
		{
			if (!reader.Read()) return;
			
			entity.MapinfoId = (System.Int32)reader[((int)MstLinksAcColumn.MapinfoId - 1)];
			entity.OriginalMapinfoId = (System.Int32)reader["MAPINFO_ID"];
			entity.MlinkId = (reader.IsDBNull(((int)MstLinksAcColumn.MlinkId - 1)))?null:(System.Int32?)reader[((int)MstLinksAcColumn.MlinkId - 1)];
			entity.CompKey = (reader.IsDBNull(((int)MstLinksAcColumn.CompKey - 1)))?null:(System.Int32?)reader[((int)MstLinksAcColumn.CompKey - 1)];
			entity.UsNode = (reader.IsDBNull(((int)MstLinksAcColumn.UsNode - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.UsNode - 1)];
			entity.DsNode = (reader.IsDBNull(((int)MstLinksAcColumn.DsNode - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.DsNode - 1)];
			entity.PipeShape = (reader.IsDBNull(((int)MstLinksAcColumn.PipeShape - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.PipeShape - 1)];
			entity.LinkType = (reader.IsDBNull(((int)MstLinksAcColumn.LinkType - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.LinkType - 1)];
			entity.PipeFlowType = (reader.IsDBNull(((int)MstLinksAcColumn.PipeFlowType - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.PipeFlowType - 1)];
			entity.Length = (reader.IsDBNull(((int)MstLinksAcColumn.Length - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Length - 1)];
			entity.DiamWidth = (reader.IsDBNull(((int)MstLinksAcColumn.DiamWidth - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.DiamWidth - 1)];
			entity.Height = (reader.IsDBNull(((int)MstLinksAcColumn.Height - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Height - 1)];
			entity.Material = (reader.IsDBNull(((int)MstLinksAcColumn.Material - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.Material - 1)];
			entity.Upsdpth = (reader.IsDBNull(((int)MstLinksAcColumn.Upsdpth - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Upsdpth - 1)];
			entity.Dwndpth = (reader.IsDBNull(((int)MstLinksAcColumn.Dwndpth - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Dwndpth - 1)];
			entity.Usie = (reader.IsDBNull(((int)MstLinksAcColumn.Usie - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Usie - 1)];
			entity.Dsie = (reader.IsDBNull(((int)MstLinksAcColumn.Dsie - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Dsie - 1)];
			entity.AsBuilt = (reader.IsDBNull(((int)MstLinksAcColumn.AsBuilt - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.AsBuilt - 1)];
			entity.Instdate = (reader.IsDBNull(((int)MstLinksAcColumn.Instdate - 1)))?null:(System.DateTime?)reader[((int)MstLinksAcColumn.Instdate - 1)];
			entity.Fromx = (reader.IsDBNull(((int)MstLinksAcColumn.Fromx - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Fromx - 1)];
			entity.Fromy = (reader.IsDBNull(((int)MstLinksAcColumn.Fromy - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Fromy - 1)];
			entity.Tox = (reader.IsDBNull(((int)MstLinksAcColumn.Tox - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Tox - 1)];
			entity.Toy = (reader.IsDBNull(((int)MstLinksAcColumn.Toy - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Toy - 1)];
			entity.Roughness = (reader.IsDBNull(((int)MstLinksAcColumn.Roughness - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Roughness - 1)];
			entity.TimeFrame = (reader.IsDBNull(((int)MstLinksAcColumn.TimeFrame - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.TimeFrame - 1)];
			entity.DataFlagSynth = (reader.IsDBNull(((int)MstLinksAcColumn.DataFlagSynth - 1)))?null:(System.Int32?)reader[((int)MstLinksAcColumn.DataFlagSynth - 1)];
			entity.DataQual = (reader.IsDBNull(((int)MstLinksAcColumn.DataQual - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.DataQual - 1)];
			entity.Hservstat = (reader.IsDBNull(((int)MstLinksAcColumn.Hservstat - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.Hservstat - 1)];
			entity.ValidFromDate = (reader.IsDBNull(((int)MstLinksAcColumn.ValidFromDate - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.ValidFromDate - 1)];
			entity.ValidToDate = (reader.IsDBNull(((int)MstLinksAcColumn.ValidToDate - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.ValidToDate - 1)];
			entity.CadKey = (reader.IsDBNull(((int)MstLinksAcColumn.CadKey - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.CadKey - 1)];
			entity.AuditNodeId = (reader.IsDBNull(((int)MstLinksAcColumn.AuditNodeId - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.AuditNodeId - 1)];
			entity.AuditDups = (reader.IsDBNull(((int)MstLinksAcColumn.AuditDups - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.AuditDups - 1)];
			entity.AuditSpatial = (reader.IsDBNull(((int)MstLinksAcColumn.AuditSpatial - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.AuditSpatial - 1)];
			entity.AuditOk2Go = (System.Boolean)reader[((int)MstLinksAcColumn.AuditOk2Go - 1)];
			entity.AuditProcTimestamp = (reader.IsDBNull(((int)MstLinksAcColumn.AuditProcTimestamp - 1)))?null:(System.String)reader[((int)MstLinksAcColumn.AuditProcTimestamp - 1)];
			entity.Qdes = (reader.IsDBNull(((int)MstLinksAcColumn.Qdes - 1)))?null:(System.Double?)reader[((int)MstLinksAcColumn.Qdes - 1)];
			entity.DmeGlobalId = (reader.IsDBNull(((int)MstLinksAcColumn.DmeGlobalId - 1)))?null:(System.Int32?)reader[((int)MstLinksAcColumn.DmeGlobalId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="SAMaster.Entities.MstLinksAc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="SAMaster.Entities.MstLinksAc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, SAMaster.Entities.MstLinksAc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MapinfoId = (System.Int32)dataRow["MAPINFO_ID"];
			entity.OriginalMapinfoId = (System.Int32)dataRow["MAPINFO_ID"];
			entity.MlinkId = Convert.IsDBNull(dataRow["MLinkID"]) ? null : (System.Int32?)dataRow["MLinkID"];
			entity.CompKey = Convert.IsDBNull(dataRow["CompKey"]) ? null : (System.Int32?)dataRow["CompKey"];
			entity.UsNode = Convert.IsDBNull(dataRow["USNode"]) ? null : (System.String)dataRow["USNode"];
			entity.DsNode = Convert.IsDBNull(dataRow["DSNode"]) ? null : (System.String)dataRow["DSNode"];
			entity.PipeShape = Convert.IsDBNull(dataRow["PipeShape"]) ? null : (System.String)dataRow["PipeShape"];
			entity.LinkType = Convert.IsDBNull(dataRow["LinkType"]) ? null : (System.String)dataRow["LinkType"];
			entity.PipeFlowType = Convert.IsDBNull(dataRow["PipeFlowType"]) ? null : (System.String)dataRow["PipeFlowType"];
			entity.Length = Convert.IsDBNull(dataRow["Length"]) ? null : (System.Double?)dataRow["Length"];
			entity.DiamWidth = Convert.IsDBNull(dataRow["DiamWidth"]) ? null : (System.Double?)dataRow["DiamWidth"];
			entity.Height = Convert.IsDBNull(dataRow["Height"]) ? null : (System.Double?)dataRow["Height"];
			entity.Material = Convert.IsDBNull(dataRow["Material"]) ? null : (System.String)dataRow["Material"];
			entity.Upsdpth = Convert.IsDBNull(dataRow["upsdpth"]) ? null : (System.Double?)dataRow["upsdpth"];
			entity.Dwndpth = Convert.IsDBNull(dataRow["dwndpth"]) ? null : (System.Double?)dataRow["dwndpth"];
			entity.Usie = Convert.IsDBNull(dataRow["USIE"]) ? null : (System.Double?)dataRow["USIE"];
			entity.Dsie = Convert.IsDBNull(dataRow["DSIE"]) ? null : (System.Double?)dataRow["DSIE"];
			entity.AsBuilt = Convert.IsDBNull(dataRow["AsBuilt"]) ? null : (System.String)dataRow["AsBuilt"];
			entity.Instdate = Convert.IsDBNull(dataRow["Instdate"]) ? null : (System.DateTime?)dataRow["Instdate"];
			entity.Fromx = Convert.IsDBNull(dataRow["FromX"]) ? null : (System.Double?)dataRow["FromX"];
			entity.Fromy = Convert.IsDBNull(dataRow["FromY"]) ? null : (System.Double?)dataRow["FromY"];
			entity.Tox = Convert.IsDBNull(dataRow["ToX"]) ? null : (System.Double?)dataRow["ToX"];
			entity.Toy = Convert.IsDBNull(dataRow["ToY"]) ? null : (System.Double?)dataRow["ToY"];
			entity.Roughness = Convert.IsDBNull(dataRow["Roughness"]) ? null : (System.Double?)dataRow["Roughness"];
			entity.TimeFrame = Convert.IsDBNull(dataRow["TimeFrame"]) ? null : (System.String)dataRow["TimeFrame"];
			entity.DataFlagSynth = Convert.IsDBNull(dataRow["DataFlagSynth"]) ? null : (System.Int32?)dataRow["DataFlagSynth"];
			entity.DataQual = Convert.IsDBNull(dataRow["DataQual"]) ? null : (System.String)dataRow["DataQual"];
			entity.Hservstat = Convert.IsDBNull(dataRow["Hservstat"]) ? null : (System.String)dataRow["Hservstat"];
			entity.ValidFromDate = Convert.IsDBNull(dataRow["ValidFromDate"]) ? null : (System.String)dataRow["ValidFromDate"];
			entity.ValidToDate = Convert.IsDBNull(dataRow["ValidToDate"]) ? null : (System.String)dataRow["ValidToDate"];
			entity.CadKey = Convert.IsDBNull(dataRow["CADKey"]) ? null : (System.String)dataRow["CADKey"];
			entity.AuditNodeId = Convert.IsDBNull(dataRow["AuditNodeID"]) ? null : (System.String)dataRow["AuditNodeID"];
			entity.AuditDups = Convert.IsDBNull(dataRow["AuditDups"]) ? null : (System.String)dataRow["AuditDups"];
			entity.AuditSpatial = Convert.IsDBNull(dataRow["AuditSpatial"]) ? null : (System.String)dataRow["AuditSpatial"];
			entity.AuditOk2Go = (System.Boolean)dataRow["AuditOK2Go"];
			entity.AuditProcTimestamp = Convert.IsDBNull(dataRow["AuditProcTimestamp"]) ? null : (System.String)dataRow["AuditProcTimestamp"];
			entity.Qdes = Convert.IsDBNull(dataRow["Qdes"]) ? null : (System.Double?)dataRow["Qdes"];
			entity.DmeGlobalId = Convert.IsDBNull(dataRow["DME_GlobalID"]) ? null : (System.Int32?)dataRow["DME_GlobalID"];
			entity.AcceptChanges();
		}
		#endregion 
		
		#region DeepLoad Methods
		/// <summary>
		/// Deep Loads the <see cref="IEntity"/> object with criteria based of the child 
		/// property collections only N Levels Deep based on the <see cref="DeepLoadType"/>.
		/// </summary>
		/// <remarks>
		/// Use this method with caution as it is possible to DeepLoad with Recursion and traverse an entire object graph.
		/// </remarks>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="entity">The <see cref="SAMaster.Entities.MstLinksAc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">SAMaster.Entities.MstLinksAc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, SAMaster.Entities.MstLinksAc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;

			#region DsNodeSource	
			if (CanDeepLoad(entity, "MstNodesAc|DsNodeSource", deepLoadType, innerList) 
				&& entity.DsNodeSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.DsNode ?? string.Empty);
				MstNodesAc tmpEntity = EntityManager.LocateEntity<MstNodesAc>(EntityLocator.ConstructKeyFromPkItems(typeof(MstNodesAc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.DsNodeSource = tmpEntity;
				else
					entity.DsNodeSource = DataRepository.MstNodesAcProvider.GetByNode(transactionManager, (entity.DsNode ?? string.Empty));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'DsNodeSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.DsNodeSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MstNodesAcProvider.DeepLoad(transactionManager, entity.DsNodeSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion DsNodeSource

			#region UsNodeSource	
			if (CanDeepLoad(entity, "MstNodesAc|UsNodeSource", deepLoadType, innerList) 
				&& entity.UsNodeSource == null)
			{
				object[] pkItems = new object[1];
				pkItems[0] = (entity.UsNode ?? string.Empty);
				MstNodesAc tmpEntity = EntityManager.LocateEntity<MstNodesAc>(EntityLocator.ConstructKeyFromPkItems(typeof(MstNodesAc), pkItems), DataRepository.Provider.EnableEntityTracking);
				if (tmpEntity != null)
					entity.UsNodeSource = tmpEntity;
				else
					entity.UsNodeSource = DataRepository.MstNodesAcProvider.GetByNode(transactionManager, (entity.UsNode ?? string.Empty));		
				
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'UsNodeSource' loaded. key " + entity.EntityTrackingKey);
				#endif 
				
				if (deep && entity.UsNodeSource != null)
				{
					innerList.SkipChildren = true;
					DataRepository.MstNodesAcProvider.DeepLoad(transactionManager, entity.UsNodeSource, deep, deepLoadType, childTypes, innerList);
					innerList.SkipChildren = false;
				}
					
			}
			#endregion UsNodeSource
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			
			//Fire all DeepLoad Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			deepHandles = null;
		}
		
		#endregion 
		
		#region DeepSave Methods

		/// <summary>
		/// Deep Save the entire object graph of the SAMaster.Entities.MstLinksAc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">SAMaster.Entities.MstLinksAc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">SAMaster.Entities.MstLinksAc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, SAMaster.Entities.MstLinksAc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			
			#region DsNodeSource
			if (CanDeepSave(entity, "MstNodesAc|DsNodeSource", deepSaveType, innerList) 
				&& entity.DsNodeSource != null)
			{
				DataRepository.MstNodesAcProvider.Save(transactionManager, entity.DsNodeSource);
				entity.DsNode = entity.DsNodeSource.Node;
			}
			#endregion 
			
			#region UsNodeSource
			if (CanDeepSave(entity, "MstNodesAc|UsNodeSource", deepSaveType, innerList) 
				&& entity.UsNodeSource != null)
			{
				DataRepository.MstNodesAcProvider.Save(transactionManager, entity.UsNodeSource);
				entity.UsNode = entity.UsNodeSource.Node;
			}
			#endregion 
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			//Fire all DeepSave Items
			foreach(KeyValuePair<Delegate, object> pair in deepHandles.Values)
		    {
                pair.Key.DynamicInvoke((object[])pair.Value);
		    }
			
			// Save Root Entity through Provider, if not already saved in delete mode
			if (entity.IsDeleted)
				this.Save(transactionManager, entity);
				

			deepHandles = null;
						
			return true;
		}
		#endregion
	} // end class
	
	#region MstLinksAcChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>SAMaster.Entities.MstLinksAc</c>
	///</summary>
	public enum MstLinksAcChildEntityTypes
	{
		
		///<summary>
		/// Composite Property for <c>MstNodesAc</c> at DsNodeSource
		///</summary>
		[ChildEntityType(typeof(MstNodesAc))]
		MstNodesAc,
		}
	
	#endregion MstLinksAcChildEntityTypes
	
	#region MstLinksAcFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MstLinksAcColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MstLinksAc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MstLinksAcFilterBuilder : SqlFilterBuilder<MstLinksAcColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MstLinksAcFilterBuilder class.
		/// </summary>
		public MstLinksAcFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MstLinksAcFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MstLinksAcFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MstLinksAcFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MstLinksAcFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MstLinksAcFilterBuilder
	
	#region MstLinksAcParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MstLinksAcColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MstLinksAc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MstLinksAcParameterBuilder : ParameterizedSqlFilterBuilder<MstLinksAcColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MstLinksAcParameterBuilder class.
		/// </summary>
		public MstLinksAcParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MstLinksAcParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MstLinksAcParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MstLinksAcParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MstLinksAcParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MstLinksAcParameterBuilder
	
	#region MstLinksAcSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MstLinksAcColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MstLinksAc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MstLinksAcSortBuilder : SqlSortBuilder<MstLinksAcColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MstLinksAcSqlSortBuilder class.
		/// </summary>
		public MstLinksAcSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MstLinksAcSortBuilder
	
} // end namespace
