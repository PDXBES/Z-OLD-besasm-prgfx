
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

public partial class MstLinksAcEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "MstLinksAcEdit.aspx?{0}", MstLinksAcDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "MstLinksAcEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "MstLinksAc.aspx");
		FormUtil.SetDefaultMode(FormView1, "MapinfoId");
	}
}


