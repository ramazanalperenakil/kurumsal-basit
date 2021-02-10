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



    }

    protected void ButtonYayınla_Click(object sender, EventArgs e)
    {
        if (fuDosya.HasFile)
        {
            string url = kod.KodOlustur(TextBoxHizmetAdi.Text);
            string HizmetResim = kod.SliderKaydet(fuDosya, 370,224, "/yuklemler/img/hizmetler/kucuk/", url);
            string HizmetDetayResim = kod.SliderKaydet(fuDosya, 870, 490, "/yuklemler/img/hizmetler/buyuk/", url);
            kod.komut("Insert Into hizmetler (Hizmet_Resim_Url,Hizmet_Adi, Hizmet_Kisa_Aciklama, Hizmet_Uzun_Aciklama, Hizmet_Sayfa_Url,Hizmet_Detay_Resim_Url) Values('"+ HizmetResim + "','" + TextBoxHizmetAdi.Text + "', '" + TextBoxHizmetKisaAciklama.Text + "', '" + TextBoxUzunAciklama.Text + "' , '" + url + "' , '"+ HizmetDetayResim + "')");
            MessageBox.Show("İşlem Başarılı.<br/> Hakkımızda Güncellendi ", MessageBox.MesajTipleri.Success);
        }
        else
        {
            MessageBox.Show("HATA<br/> Resim Yüklemdiniz  ", MessageBox.MesajTipleri.Error);
        }
    }
}