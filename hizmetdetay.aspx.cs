using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = RouteData.Values["Hizmet_İd"].ToString();

        RepeaterHizmetResim.DataSource = kod.GetDataTable("SELECT *  FROM [hizmetler] WHERE Hizmet_İd=" + id);
        RepeaterHizmetResim.DataBind();

        RepeaterDigerHizmetler.DataSource = kod.GetDataTable("SELECT TOP 7 *  FROM [hizmetler] WHERE Hizmet_Resim_Url  IS NOT NULL  ORDER BY Hizmet_İd DESC");
        RepeaterDigerHizmetler.DataBind();

        RepeaterIcerik.DataSource = kod.GetDataTable("SELECT *  FROM [hizmetler] WHERE Hizmet_İd=" + id);
        RepeaterIcerik.DataBind();

        Page.Title = kod.getDataCell("SELECT  Hizmet_Adi FROM [hizmetler] WHERE Hizmet_İd=" + id) + " -" + kod.getDataCell("SELECT  Site_Adi FROM [ayar] ");
    }
}