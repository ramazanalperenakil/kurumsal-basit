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

        string Slider = kod.getDataCell("SELECT  COUNT(Slider_Id) FROM slider ");
        SliderSayisi.InnerText = Slider.ToString();


        string HizmetSay = kod.getDataCell("SELECT  COUNT(Hizmet_İd) FROM [hizmetler] WHERE Hizmet_Resim_Url  IS NOT NULL ");
        HizmetSayisi.InnerText = HizmetSay.ToString();


        string Makalesay = kod.getDataCell("SELECT  COUNT(Blog_Id) FROM blog WHERE [Blog_Ana_Baslik]  IS  NULL ");
        MakaleSayisi.InnerText = Makalesay.ToString();


        string CAlsay = kod.getDataCell("SELECT  COUNT(Ekip_İd) FROM [ekip] ");
        Calisan.InnerText = CAlsay.ToString();

    }
}