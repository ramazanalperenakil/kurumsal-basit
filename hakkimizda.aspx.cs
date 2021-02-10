using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class hakkimizda : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        RepeaterHakkimizda.DataSource = kod.GetDataTable("SELECT *  FROM [ayar]");
        RepeaterHakkimizda.DataBind();

        RepeaterHakkimizdaResim.DataSource = kod.GetDataTable("SELECT *  FROM [ayar]");
        RepeaterHakkimizdaResim.DataBind();

        RepeaterHakkimizdaUzun.DataSource = kod.GetDataTable("SELECT *  FROM [ayar]");
        RepeaterHakkimizdaUzun.DataBind();

    }
}