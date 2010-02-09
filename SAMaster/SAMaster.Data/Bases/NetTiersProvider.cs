
#region Using directives

using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Configuration.Provider;

using SAMaster.Entities;

#endregion

namespace SAMaster.Data.Bases
{	
	///<summary>
	/// The base class to implements to create a .NetTiers provider.
	///</summary>
	public abstract class NetTiersProvider : NetTiersProviderBase
	{
		
		///<summary>
		/// Current MstNodesAcProviderBase instance.
		///</summary>
		public virtual MstNodesAcProviderBase MstNodesAcProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MstLinksAcProviderBase instance.
		///</summary>
		public virtual MstLinksAcProviderBase MstLinksAcProvider{get {throw new NotImplementedException();}}
		
		
	}
}
