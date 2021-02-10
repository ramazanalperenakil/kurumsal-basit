using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BlogDetay : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = RouteData.Values["Blog_Id"].ToString();
        RepeaterKategoriler.DataSource = kod.GetDataTable("SELECT *  FROM [kategoriler]");
        RepeaterKategoriler.DataBind();

        RepeaterSonYazilar.DataSource = kod.GetDataTable("SELECT *  FROM [blog] WHERE [Blog_Ana_Baslik]  IS  NULL ORDER BY Blog_Id DESC");
        RepeaterSonYazilar.DataBind();

        RepeaterBlogResim.DataSource = kod.GetDataTable("SELECT *  FROM [blog] WHERE Blog_Id=" + id);
        RepeaterBlogResim.DataBind();
        RepeaterBilgi.DataSource = kod.GetDataTable("SELECT *  FROM [blog] WHERE Blog_Id=" + id);
        RepeaterBilgi.DataBind();
        RepeaterIcerik.DataSource = kod.GetDataTable("SELECT *  FROM [blog] WHERE Blog_Id=" + id);
        RepeaterIcerik.DataBind();

        Page.Title = kod.getDataCell("SELECT  Blog_Yazi_Basligi FROM [blog] WHERE Blog_Id=" + id)+ " -" + kod.getDataCell("SELECT  Site_Adi FROM [ayar] "); 
    }
}