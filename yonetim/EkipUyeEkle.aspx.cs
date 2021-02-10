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
        string url = kod.KodOlustur(TextBoxAdSoyad.Text);
        if (fuDosya.HasFile)
        {

            string SliderResim = kod.SliderKaydet(fuDosya, 370, 456, "/yuklemler/img/ekip/", url);
            kod.komut("Insert Into ekip (Ekip_Uye_Resim_Url , Ekip_Uye_Adi , Ekip_Uye_Gorevi,Sosyal_Medya_Url_Facebook,Sosyal_Medya_Url_Twitter,Sosyal_Medya_Url_İnstagram,Sosyal_Medya_Url_Diger,Ekip_Uye_Url) VALUES ('" + SliderResim + "' , '" +TextBoxAdSoyad.Text + "' , '" + TextBoxGörevi.Text + "', '"+TextBoxFacebook.Text+"', '"+TextBoxTwitter.Text+"', '"+TextBoxInstagram.Text+"', '"+TextBoxDiger.Text+"' , '"+ url + "' ) ");
            MessageBox.Show("İşlem Başarılı.<br/>  Ekip Üyesi Eklendi Kaldırıldı", MessageBox.MesajTipleri.Success);
            resim1.Visible = false;

            ImageYuklene.ImageUrl = SliderResim;
            ImageYuklene.Visible = true;


        }
        else
        {
            MessageBox.Show("HATA<br/>İşlem Yapılırken Bir Hata Oluştu", MessageBox.MesajTipleri.Error);
        }
    }
}