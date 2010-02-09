
#region Imports...
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SAMaster.Web.UI;
#endregion

public partial class MstNodesAcEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "MstNodesAcEdit.aspx?{0}", MstNodesAcDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "MstNodesAcEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "MstNodesAc.aspx");
		FormUtil.SetDefaultMode(FormView1, "MapinfoId");
	}
	protected void GridViewMstLinksAc1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MapinfoId={0}", GridViewMstLinksAc1.SelectedDataKey.Values[0]);
		Response.Redirect("MstLinksAcEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewMstLinksAc2_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MapinfoId={0}", GridViewMstLinksAc2.SelectedDataKey.Values[0]);
		Response.Redirect("MstLinksAcEdit.aspx?" + urlParams, true);		
	}	
}


