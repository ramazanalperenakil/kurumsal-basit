using System;
using System.Collections.Generic;
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
                kod.komut("delete from ekip where Ekip_İd=" + Request.QueryString["Id"].ToString());

                MessageBox.Show("İşlem Başarılı.<br/> Ekip Üyesi  Silindi", MessageBox.MesajTipleri.Success);
            }
            catch
            {

                MessageBox.Show("HATA<br/> İşlem Yapılamadı", MessageBox.MesajTipleri.Error);
            }




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

        RepeaterEkip.DataSource = kod.GetDataTable("SELECT *  FROM [ekip] ");
        RepeaterEkip.DataBind();


    }
}