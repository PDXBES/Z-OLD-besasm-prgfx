#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using System.Diagnostics;
using SAMaster.Entities;
using SAMaster.Data;

#endregion

namespace SAMaster.Data.Bases
{	
	///<summary>
	/// This class is the base class for any <see cref="MstNodesAcProviderBase"/> implementation.
	/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
	///</summary>
	public abstract partial class MstNodesAcProviderBase : MstNodesAcProviderBaseCore
	{
	} // end class
} // end namespace
