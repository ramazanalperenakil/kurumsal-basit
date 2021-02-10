using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_Giris : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = kod.getDataCell("SELECT  Site_Adi FROM [ayar] ");
        if (Session["kullanici"] != null)
        {
            Response.Redirect("Default.aspx");

        }
        RepeaterLogo.DataSource = kod.GetDataTable("SELECT *  FROM [ayar]");
        RepeaterLogo.DataBind();
    }

    protected void ButtonGiris_Click(object sender, EventArgs e)
    {
        string kullanici = TextBoxKadi.Text, sifre = TextBoxSifre.Text;
        DataTable dt = kod.GetDataTable("Select * from kullanicilar where (Kullanici_Sonek='" + kullanici + "' AND Kullanici_Sifre='" + sifre + "' )"); /*AND uyeTuru='admin'*/

        if (dt.Rows.Count == 0)
        {
            hata.Visible = true;
        }
        else
        {
            Session["kullanici"] = kullanici;
            
            Response.Redirect("Default.aspx");
        }
    }
}