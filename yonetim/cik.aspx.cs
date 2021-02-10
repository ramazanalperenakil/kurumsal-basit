using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_cik : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = kod.getDataCell("SELECT  Site_Adi FROM [ayar] ");
        Session.Abandon();
        Response.Redirect("../Default.aspx");
    }
}