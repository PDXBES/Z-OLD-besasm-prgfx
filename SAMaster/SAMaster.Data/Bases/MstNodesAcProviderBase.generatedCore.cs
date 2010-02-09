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
	/// This class is the base class for any <see cref="MstNodesAcProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MstNodesAcProviderBaseCore : EntityProviderBase<SAMaster.Entities.MstNodesAc, SAMaster.Entities.MstNodesAcKey>
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
		public override bool Delete(TransactionManager transactionManager, SAMaster.Entities.MstNodesAcKey key)
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
		public override SAMaster.Entities.MstNodesAc Get(TransactionManager transactionManager, SAMaster.Entities.MstNodesAcKey key, int start, int pageLength)
		{
			return GetByMapinfoId(transactionManager, key.MapinfoId, start, pageLength);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key IX_mst_nodes_ac index.
		/// </summary>
		/// <param name="_node"></param>
		/// <returns>Returns an instance of the <see cref="SAMaster.Entities.MstNodesAc"/> class.</returns>
		public SAMaster.Entities.MstNodesAc GetByNode(System.String _node)
		{
			int count = -1;
			return GetByNode(null,_node, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_mst_nodes_ac index.
		/// </summary>
		/// <param name="_node"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="SAMaster.Entities.MstNodesAc"/> class.</returns>
		public SAMaster.Entities.MstNodesAc GetByNode(System.String _node, int start, int pageLength)
		{
			int count = -1;
			return GetByNode(null, _node, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_mst_nodes_ac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_node"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="SAMaster.Entities.MstNodesAc"/> class.</returns>
		public SAMaster.Entities.MstNodesAc GetByNode(TransactionManager transactionManager, System.String _node)
		{
			int count = -1;
			return GetByNode(transactionManager, _node, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_mst_nodes_ac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_node"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="SAMaster.Entities.MstNodesAc"/> class.</returns>
		public SAMaster.Entities.MstNodesAc GetByNode(TransactionManager transactionManager, System.String _node, int start, int pageLength)
		{
			int count = -1;
			return GetByNode(transactionManager, _node, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_mst_nodes_ac index.
		/// </summary>
		/// <param name="_node"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="SAMaster.Entities.MstNodesAc"/> class.</returns>
		public SAMaster.Entities.MstNodesAc GetByNode(System.String _node, int start, int pageLength, out int count)
		{
			return GetByNode(null, _node, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the IX_mst_nodes_ac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_node"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="SAMaster.Entities.MstNodesAc"/> class.</returns>
		public abstract SAMaster.Entities.MstNodesAc GetByNode(TransactionManager transactionManager, System.String _node, int start, int pageLength, out int count);
						
		/// <summary>
		/// 	Gets rows from the datasource based on the primary key PK_mst_nodes_ac index.
		/// </summary>
		/// <param name="_mapinfoId"></param>
		/// <returns>Returns an instance of the <see cref="SAMaster.Entities.MstNodesAc"/> class.</returns>
		public SAMaster.Entities.MstNodesAc GetByMapinfoId(System.Int32 _mapinfoId)
		{
			int count = -1;
			return GetByMapinfoId(null,_mapinfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_mst_nodes_ac index.
		/// </summary>
		/// <param name="_mapinfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="SAMaster.Entities.MstNodesAc"/> class.</returns>
		public SAMaster.Entities.MstNodesAc GetByMapinfoId(System.Int32 _mapinfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByMapinfoId(null, _mapinfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_mst_nodes_ac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mapinfoId"></param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="SAMaster.Entities.MstNodesAc"/> class.</returns>
		public SAMaster.Entities.MstNodesAc GetByMapinfoId(TransactionManager transactionManager, System.Int32 _mapinfoId)
		{
			int count = -1;
			return GetByMapinfoId(transactionManager, _mapinfoId, 0, int.MaxValue, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_mst_nodes_ac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mapinfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="SAMaster.Entities.MstNodesAc"/> class.</returns>
		public SAMaster.Entities.MstNodesAc GetByMapinfoId(TransactionManager transactionManager, System.Int32 _mapinfoId, int start, int pageLength)
		{
			int count = -1;
			return GetByMapinfoId(transactionManager, _mapinfoId, start, pageLength, out count);
		}
		
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_mst_nodes_ac index.
		/// </summary>
		/// <param name="_mapinfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">out parameter to get total records for query</param>
		/// <remarks></remarks>
		/// <returns>Returns an instance of the <see cref="SAMaster.Entities.MstNodesAc"/> class.</returns>
		public SAMaster.Entities.MstNodesAc GetByMapinfoId(System.Int32 _mapinfoId, int start, int pageLength, out int count)
		{
			return GetByMapinfoId(null, _mapinfoId, start, pageLength, out count);
		}
		
				
		/// <summary>
		/// 	Gets rows from the datasource based on the PK_mst_nodes_ac index.
		/// </summary>
		/// <param name="transactionManager"><see cref="TransactionManager"/> object</param>
		/// <param name="_mapinfoId"></param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">Number of rows to return.</param>
		/// <param name="count">The total number of records.</param>
		/// <returns>Returns an instance of the <see cref="SAMaster.Entities.MstNodesAc"/> class.</returns>
		public abstract SAMaster.Entities.MstNodesAc GetByMapinfoId(TransactionManager transactionManager, System.Int32 _mapinfoId, int start, int pageLength, out int count);
						
		#endregion "Get By Index Functions"
	
		#region Custom Methods
		
		
		#endregion

		#region Helper Functions	
		
		/// <summary>
		/// Fill a TList&lt;MstNodesAc&gt; From a DataReader.
		/// </summary>
		/// <param name="reader">Datareader</param>
		/// <param name="rows">The collection to fill</param>
		/// <param name="start">Row number at which to start reading, the first row is 0.</param>
		/// <param name="pageLength">number of rows.</param>
		/// <returns>a <see cref="TList&lt;MstNodesAc&gt;"/></returns>
		public static TList<MstNodesAc> Fill(IDataReader reader, TList<MstNodesAc> rows, int start, int pageLength)
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
				
				SAMaster.Entities.MstNodesAc c = null;
				if (useEntityFactory)
				{
					key = new System.Text.StringBuilder("MstNodesAc")
					.Append("|").Append((System.Int32)reader[((int)MstNodesAcColumn.MapinfoId - 1)]).ToString();
					c = EntityManager.LocateOrCreate<MstNodesAc>(
					key.ToString(), // EntityTrackingKey
					"MstNodesAc",  //Creational Type
					entityCreationFactoryType,  //Factory used to create entity
					enableEntityTracking); // Track this entity?
				}
				else
				{
					c = new SAMaster.Entities.MstNodesAc();
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
					c.MapinfoId = (System.Int32)reader[((int)MstNodesAcColumn.MapinfoId - 1)];
					c.OriginalMapinfoId = c.MapinfoId;
					c.Node = (System.String)reader[((int)MstNodesAcColumn.Node - 1)];
					c.Xcoord = (reader.IsDBNull(((int)MstNodesAcColumn.Xcoord - 1)))?null:(System.Double?)reader[((int)MstNodesAcColumn.Xcoord - 1)];
					c.Ycoord = (reader.IsDBNull(((int)MstNodesAcColumn.Ycoord - 1)))?null:(System.Double?)reader[((int)MstNodesAcColumn.Ycoord - 1)];
					c.NodeType = (reader.IsDBNull(((int)MstNodesAcColumn.NodeType - 1)))?null:(System.String)reader[((int)MstNodesAcColumn.NodeType - 1)];
					c.GrndElev = (reader.IsDBNull(((int)MstNodesAcColumn.GrndElev - 1)))?null:(System.Double?)reader[((int)MstNodesAcColumn.GrndElev - 1)];
					c.HasSpecNode = (reader.IsDBNull(((int)MstNodesAcColumn.HasSpecNode - 1)))?null:(System.String)reader[((int)MstNodesAcColumn.HasSpecNode - 1)];
					c.HasSpecLink = (reader.IsDBNull(((int)MstNodesAcColumn.HasSpecLink - 1)))?null:(System.String)reader[((int)MstNodesAcColumn.HasSpecLink - 1)];
					c.GageId = (reader.IsDBNull(((int)MstNodesAcColumn.GageId - 1)))?null:(System.String)reader[((int)MstNodesAcColumn.GageId - 1)];
					c.DmeGlobalId = (reader.IsDBNull(((int)MstNodesAcColumn.DmeGlobalId - 1)))?null:(System.Int32?)reader[((int)MstNodesAcColumn.DmeGlobalId - 1)];
					c.EntityTrackingKey = key;
					c.AcceptChanges();
					c.SuppressEntityEvents = false;
				}
				rows.Add(c);
			}
		return rows;
		}		
		/// <summary>
		/// Refreshes the <see cref="SAMaster.Entities.MstNodesAc"/> object from the <see cref="IDataReader"/>.
		/// </summary>
		/// <param name="reader">The <see cref="IDataReader"/> to read from.</param>
		/// <param name="entity">The <see cref="SAMaster.Entities.MstNodesAc"/> object to refresh.</param>
		public static void RefreshEntity(IDataReader reader, SAMaster.Entities.MstNodesAc entity)
		{
			if (!reader.Read()) return;
			
			entity.MapinfoId = (System.Int32)reader[((int)MstNodesAcColumn.MapinfoId - 1)];
			entity.OriginalMapinfoId = (System.Int32)reader["MAPINFO_ID"];
			entity.Node = (System.String)reader[((int)MstNodesAcColumn.Node - 1)];
			entity.Xcoord = (reader.IsDBNull(((int)MstNodesAcColumn.Xcoord - 1)))?null:(System.Double?)reader[((int)MstNodesAcColumn.Xcoord - 1)];
			entity.Ycoord = (reader.IsDBNull(((int)MstNodesAcColumn.Ycoord - 1)))?null:(System.Double?)reader[((int)MstNodesAcColumn.Ycoord - 1)];
			entity.NodeType = (reader.IsDBNull(((int)MstNodesAcColumn.NodeType - 1)))?null:(System.String)reader[((int)MstNodesAcColumn.NodeType - 1)];
			entity.GrndElev = (reader.IsDBNull(((int)MstNodesAcColumn.GrndElev - 1)))?null:(System.Double?)reader[((int)MstNodesAcColumn.GrndElev - 1)];
			entity.HasSpecNode = (reader.IsDBNull(((int)MstNodesAcColumn.HasSpecNode - 1)))?null:(System.String)reader[((int)MstNodesAcColumn.HasSpecNode - 1)];
			entity.HasSpecLink = (reader.IsDBNull(((int)MstNodesAcColumn.HasSpecLink - 1)))?null:(System.String)reader[((int)MstNodesAcColumn.HasSpecLink - 1)];
			entity.GageId = (reader.IsDBNull(((int)MstNodesAcColumn.GageId - 1)))?null:(System.String)reader[((int)MstNodesAcColumn.GageId - 1)];
			entity.DmeGlobalId = (reader.IsDBNull(((int)MstNodesAcColumn.DmeGlobalId - 1)))?null:(System.Int32?)reader[((int)MstNodesAcColumn.DmeGlobalId - 1)];
			entity.AcceptChanges();
		}
		
		/// <summary>
		/// Refreshes the <see cref="SAMaster.Entities.MstNodesAc"/> object from the <see cref="DataSet"/>.
		/// </summary>
		/// <param name="dataSet">The <see cref="DataSet"/> to read from.</param>
		/// <param name="entity">The <see cref="SAMaster.Entities.MstNodesAc"/> object.</param>
		public static void RefreshEntity(DataSet dataSet, SAMaster.Entities.MstNodesAc entity)
		{
			DataRow dataRow = dataSet.Tables[0].Rows[0];
			
			entity.MapinfoId = (System.Int32)dataRow["MAPINFO_ID"];
			entity.OriginalMapinfoId = (System.Int32)dataRow["MAPINFO_ID"];
			entity.Node = (System.String)dataRow["Node"];
			entity.Xcoord = Convert.IsDBNull(dataRow["XCoord"]) ? null : (System.Double?)dataRow["XCoord"];
			entity.Ycoord = Convert.IsDBNull(dataRow["YCoord"]) ? null : (System.Double?)dataRow["YCoord"];
			entity.NodeType = Convert.IsDBNull(dataRow["NodeType"]) ? null : (System.String)dataRow["NodeType"];
			entity.GrndElev = Convert.IsDBNull(dataRow["GrndElev"]) ? null : (System.Double?)dataRow["GrndElev"];
			entity.HasSpecNode = Convert.IsDBNull(dataRow["HasSpecNode"]) ? null : (System.String)dataRow["HasSpecNode"];
			entity.HasSpecLink = Convert.IsDBNull(dataRow["HasSpecLink"]) ? null : (System.String)dataRow["HasSpecLink"];
			entity.GageId = Convert.IsDBNull(dataRow["GageID"]) ? null : (System.String)dataRow["GageID"];
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
		/// <param name="entity">The <see cref="SAMaster.Entities.MstNodesAc"/> object to load.</param>
		/// <param name="deep">Boolean. A flag that indicates whether to recursively save all Property Collection that are descendants of this instance. If True, saves the complete object graph below this object. If False, saves this object only. </param>
		/// <param name="deepLoadType">DeepLoadType Enumeration to Include/Exclude object property collections from Load.</param>
		/// <param name="childTypes">SAMaster.Entities.MstNodesAc Property Collection Type Array To Include or Exclude from Load</param>
		/// <param name="innerList">A collection of child types for easy access.</param>
	    /// <exception cref="ArgumentNullException">entity or childTypes is null.</exception>
	    /// <exception cref="ArgumentException">deepLoadType has invalid value.</exception>
		public override void DeepLoad(TransactionManager transactionManager, SAMaster.Entities.MstNodesAc entity, bool deep, DeepLoadType deepLoadType, System.Type[] childTypes, DeepSession innerList)
		{
			if(entity == null)
				return;
			
			//used to hold DeepLoad method delegates and fire after all the local children have been loaded.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
			// Deep load child collections  - Call GetByMapinfoId methods when available
			
			#region MstLinksAcCollectionGetByDsNode
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MstLinksAc>|MstLinksAcCollectionGetByDsNode", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MstLinksAcCollectionGetByDsNode' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MstLinksAcCollectionGetByDsNode = DataRepository.MstLinksAcProvider.GetByDsNode(transactionManager, entity.Node);

				if (deep && entity.MstLinksAcCollectionGetByDsNode.Count > 0)
				{
					deepHandles.Add("MstLinksAcCollectionGetByDsNode",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MstLinksAc>) DataRepository.MstLinksAcProvider.DeepLoad,
						new object[] { transactionManager, entity.MstLinksAcCollectionGetByDsNode, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
			#region MstLinksAcCollectionGetByUsNode
			//Relationship Type One : Many
			if (CanDeepLoad(entity, "List<MstLinksAc>|MstLinksAcCollectionGetByUsNode", deepLoadType, innerList)) 
			{
				#if NETTIERS_DEBUG
				System.Diagnostics.Debug.WriteLine("- property 'MstLinksAcCollectionGetByUsNode' loaded. key " + entity.EntityTrackingKey);
				#endif 

				entity.MstLinksAcCollectionGetByUsNode = DataRepository.MstLinksAcProvider.GetByUsNode(transactionManager, entity.Node);

				if (deep && entity.MstLinksAcCollectionGetByUsNode.Count > 0)
				{
					deepHandles.Add("MstLinksAcCollectionGetByUsNode",
						new KeyValuePair<Delegate, object>((DeepLoadHandle<MstLinksAc>) DataRepository.MstLinksAcProvider.DeepLoad,
						new object[] { transactionManager, entity.MstLinksAcCollectionGetByUsNode, deep, deepLoadType, childTypes, innerList }
					));
				}
			}		
			#endregion 
			
			
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
		/// Deep Save the entire object graph of the SAMaster.Entities.MstNodesAc object with criteria based of the child 
		/// Type property array and DeepSaveType.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="entity">SAMaster.Entities.MstNodesAc instance</param>
		/// <param name="deepSaveType">DeepSaveType Enumeration to Include/Exclude object property collections from Save.</param>
		/// <param name="childTypes">SAMaster.Entities.MstNodesAc Property Collection Type Array To Include or Exclude from Save</param>
		/// <param name="innerList">A Hashtable of child types for easy access.</param>
		public override bool DeepSave(TransactionManager transactionManager, SAMaster.Entities.MstNodesAc entity, DeepSaveType deepSaveType, System.Type[] childTypes, DeepSession innerList)
		{	
			if (entity == null)
				return false;
							
			#region Composite Parent Properties
			//Save Source Composite Properties, however, don't call deep save on them.  
			//So they only get saved a single level deep.
			#endregion Composite Parent Properties

			// Save Root Entity through Provider
			if (!entity.IsDeleted)
				this.Save(transactionManager, entity);
			
			//used to hold DeepSave method delegates and fire after all the local children have been saved.
			Dictionary<string, KeyValuePair<Delegate, object>> deepHandles = new Dictionary<string, KeyValuePair<Delegate, object>>();
	
			#region List<MstLinksAc>
				if (CanDeepSave(entity.MstLinksAcCollectionGetByDsNode, "List<MstLinksAc>|MstLinksAcCollectionGetByDsNode", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MstLinksAc child in entity.MstLinksAcCollectionGetByDsNode)
					{
						if(child.DsNodeSource != null)
						{
							child.DsNode = child.DsNodeSource.Node;
						}
						else
						{
							child.DsNode = entity.Node;
						}

					}

					if (entity.MstLinksAcCollectionGetByDsNode.Count > 0 || entity.MstLinksAcCollectionGetByDsNode.DeletedItems.Count > 0)
					{
						//DataRepository.MstLinksAcProvider.Save(transactionManager, entity.MstLinksAcCollectionGetByDsNode);
						
						deepHandles.Add("MstLinksAcCollectionGetByDsNode",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MstLinksAc >) DataRepository.MstLinksAcProvider.DeepSave,
							new object[] { transactionManager, entity.MstLinksAcCollectionGetByDsNode, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
	
			#region List<MstLinksAc>
				if (CanDeepSave(entity.MstLinksAcCollectionGetByUsNode, "List<MstLinksAc>|MstLinksAcCollectionGetByUsNode", deepSaveType, innerList)) 
				{	
					// update each child parent id with the real parent id (mostly used on insert)
					foreach(MstLinksAc child in entity.MstLinksAcCollectionGetByUsNode)
					{
						if(child.UsNodeSource != null)
						{
							child.UsNode = child.UsNodeSource.Node;
						}
						else
						{
							child.UsNode = entity.Node;
						}

					}

					if (entity.MstLinksAcCollectionGetByUsNode.Count > 0 || entity.MstLinksAcCollectionGetByUsNode.DeletedItems.Count > 0)
					{
						//DataRepository.MstLinksAcProvider.Save(transactionManager, entity.MstLinksAcCollectionGetByUsNode);
						
						deepHandles.Add("MstLinksAcCollectionGetByUsNode",
						new KeyValuePair<Delegate, object>((DeepSaveHandle< MstLinksAc >) DataRepository.MstLinksAcProvider.DeepSave,
							new object[] { transactionManager, entity.MstLinksAcCollectionGetByUsNode, deepSaveType, childTypes, innerList }
						));
					}
				} 
			#endregion 
				
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
	
	#region MstNodesAcChildEntityTypes
	
	///<summary>
	/// Enumeration used to expose the different child entity types 
	/// for child properties in <c>SAMaster.Entities.MstNodesAc</c>
	///</summary>
	public enum MstNodesAcChildEntityTypes
	{

		///<summary>
		/// Collection of <c>MstNodesAc</c> as OneToMany for MstLinksAcCollection
		///</summary>
		[ChildEntityType(typeof(TList<MstLinksAc>))]
		MstLinksAcCollectionGetByDsNode,

		///<summary>
		/// Collection of <c>MstNodesAc</c> as OneToMany for MstLinksAcCollection
		///</summary>
		[ChildEntityType(typeof(TList<MstLinksAc>))]
		MstLinksAcCollectionGetByUsNode,
	}
	
	#endregion MstNodesAcChildEntityTypes
	
	#region MstNodesAcFilterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilterBuilder&lt;MstNodesAcColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MstNodesAc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MstNodesAcFilterBuilder : SqlFilterBuilder<MstNodesAcColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MstNodesAcFilterBuilder class.
		/// </summary>
		public MstNodesAcFilterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MstNodesAcFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MstNodesAcFilterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MstNodesAcFilterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MstNodesAcFilterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MstNodesAcFilterBuilder
	
	#region MstNodesAcParameterBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ParameterizedSqlFilterBuilder&lt;MstNodesAcColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MstNodesAc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MstNodesAcParameterBuilder : ParameterizedSqlFilterBuilder<MstNodesAcColumn>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MstNodesAcParameterBuilder class.
		/// </summary>
		public MstNodesAcParameterBuilder() : base() { }

		/// <summary>
		/// Initializes a new instance of the MstNodesAcParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		public MstNodesAcParameterBuilder(bool ignoreCase) : base(ignoreCase) { }

		/// <summary>
		/// Initializes a new instance of the MstNodesAcParameterBuilder class.
		/// </summary>
		/// <param name="ignoreCase">Specifies whether to create case-insensitive statements.</param>
		/// <param name="useAnd">Specifies whether to combine statements using AND or OR.</param>
		public MstNodesAcParameterBuilder(bool ignoreCase, bool useAnd) : base(ignoreCase, useAnd) { }

		#endregion Constructors
	}

	#endregion MstNodesAcParameterBuilder
	
	#region MstNodesAcSortBuilder
    
    /// <summary>
    /// A strongly-typed instance of the <see cref="SqlSortBuilder&lt;MstNodesAcColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MstNodesAc"/> object.
    /// </summary>
    [CLSCompliant(true)]
    public class MstNodesAcSortBuilder : SqlSortBuilder<MstNodesAcColumn>
    {
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MstNodesAcSqlSortBuilder class.
		/// </summary>
		public MstNodesAcSortBuilder() : base() { }

		#endregion Constructors

    }    
    #endregion MstNodesAcSortBuilder
	
} // end namespace
