using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hizmetler : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {

        RepeaterHizmetlerUst.DataSource = kod.GetDataTable("SELECT *  FROM [hizmetler] WHERE [Hizmet_İd] = 1");
        RepeaterHizmetlerUst.DataBind();

        //RepeaterHizmetler.DataSource = kod.GetDataTable("SELECT *  FROM [hizmetler] WHERE Hizmet_Resim_Url  IS NOT NULL ");
        //RepeaterHizmetler.DataBind();


    }
}