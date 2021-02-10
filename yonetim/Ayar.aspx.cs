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
        if (!Page.IsPostBack)
        {
            DataRow dr = kod.GetDataRow("Select * from ayar");

            TextBoxSiteAdi.Text = dr[1].ToString();
            TextSiteSlogan.Text = dr[2].ToString();
            TextSiteAciklama.Text = dr[3].ToString();
            TextBoxTSiteAnahtarKelime.Text = dr[4].ToString();
            TextBoxSiteUrl.Text = dr[5].ToString();
            

            ImageYuklene.ImageUrl = dr[11].ToString();

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



    }

    protected void ButtonYayınla_Click(object sender, EventArgs e)
    {
        string url = kod.KodOlustur(TextBoxSiteAdi.Text) + "LOGO";
        if (fuDosya.HasFile)
        {
            string Logo = kod.SliderKaydet(fuDosya, 130, 28, "/yuklemler/img/logo/", url);
            kod.komut("UPDATE ayar set Site_Adi='" + TextBoxSiteAdi.Text + "', Site_Slogan='" + TextSiteSlogan.Text + "', Site_Aciklama='" + TextSiteAciklama.Text + "',Site_Anahtar_Kelime ='"+TextBoxTSiteAnahtarKelime.Text+ "', Site_Url='"+TextBoxSiteUrl.Text+ "', Logo_Url='"+ Logo + "' ");
            ImageYuklene.ImageUrl = Logo;
            MessageBox.Show("İşlem Başarılı.<br/> Ayarlar Güncellendi ", MessageBox.MesajTipleri.Success);
        }
        else
        {
            kod.komut("UPDATE ayar set Site_Adi='" + TextBoxSiteAdi.Text + "', Site_Slogan='" + TextSiteSlogan.Text + "', Site_Aciklama='" + TextSiteAciklama.Text + "',Site_Anahtar_Kelime ='" + TextBoxTSiteAnahtarKelime.Text + "', Site_Url='" + TextBoxSiteUrl.Text + "' ");
            MessageBox.Show("İşlem Başarılı.<br/> Slider Güncellendi Kaldırıldı", MessageBox.MesajTipleri.Success);
        }
    }
}