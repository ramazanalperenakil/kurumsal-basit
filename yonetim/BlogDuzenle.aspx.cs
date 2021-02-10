using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yonetim_Default : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = kod.getDataCell("SELECT  Site_Adi FROM [ayar] ");
        if (Request.QueryString["Id"] != null && Request.QueryString["islem"] == "sil")
        {

            try
            {
                kod.komut("delete from blog where Blog_Id=" + Request.QueryString["Id"].ToString());

                MessageBox.Show("İşlem Başarılı.<br/> Makale  Silindi", MessageBox.MesajTipleri.Success);
            }
            catch
            {

                MessageBox.Show("HATA<br/> İşlem Yapılamadı", MessageBox.MesajTipleri.Error);
            }




        }


        if (!Page.IsPostBack)
        {
            DataRow dr = kod.GetDataRow("Select * from blog WHERE [Blog_Id]=1 ");

            TextBlogleSayfaAdi.Text = dr[1].ToString();
            TextBoxBlogSayfasiAciklama.Text = dr[2].ToString();
        }

        if (Session["kullanici"] == null)
        {
            Response.Redirect("Giris.aspx");
        }
        else
        {
            string gelenkadi = Session["kullanici"].ToString();
            //string ad = kod.getDataCell("SELECT  Kullanici_Adi  FROM [kullanicilar] WHERE Kullanici_Sonek =" + gelenkadi);

            //string Soyad = kod.getDataCell("SELECT Kullanici_Soyadi  FROM [kullanicilar] WHERE Kullanici_Sonek =" + Session["kullanici"].ToString());

            isim.InnerText = gelenkadi;
            adsoyadmobil.InnerText = gelenkadi;


        }
        ImageLogo.ImageUrl = kod.getDataCell("SELECT  Logo_Url FROM [ayar]");

        ImageUser.ImageUrl= kod.getDataCell("SELECT  Kullanici_Resim_Url FROM [kullanicilar]");

        ImageMobilMenuUserLogo.ImageUrl= kod.getDataCell("SELECT  Kullanici_Resim_Url FROM [kullanicilar]");

        RepeaterBlog.DataSource = kod.GetDataTable("SELECT *  FROM [blog] WHERE [Blog_Ana_Baslik]  IS  NULL ORDER BY Blog_Id DESC");
        RepeaterBlog.DataBind();

    }
}