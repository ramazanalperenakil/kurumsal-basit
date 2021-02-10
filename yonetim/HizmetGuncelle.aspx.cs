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
            DataRow dr = kod.GetDataRow("Select * from hizmetler WHERE [Hizmet_İd] = " + Request.QueryString["Id"]);

            ImageYukluResim.ImageUrl = dr[3].ToString();
            TextBoxHizmetAdi.Text = dr[4].ToString();
            TextBoxHizmetKisaAciklama.Text = dr[5].ToString();
            TextBoxUzunAciklama.Text = dr[6].ToString();




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
        string url = kod.KodOlustur(TextBoxHizmetAdi.Text);
        if (fuDosya.HasFile)
        {
            string HizmetResim = kod.SliderKaydet(fuDosya, 370, 224, "/yuklemler/img/hizmetler/kucuk/", url);
            string HizmetDetayResim = kod.SliderKaydet(fuDosya, 370, 224, "/yuklemler/img/hizmetler/buyuk/", url);
            kod.komut("UPDATE hizmetler set Hizmet_Resim_Url='" + HizmetResim + "', Hizmet_Adi='" + TextBoxHizmetAdi.Text + "', Hizmet_Kisa_Aciklama='" + TextBoxHizmetKisaAciklama.Text + "', Hizmet_Uzun_Aciklama = '"+TextBoxUzunAciklama.Text+ "', Hizmet_Sayfa_Url = '"+url+ "' , Hizmet_Detay_Resim_Url ='"+ HizmetDetayResim + "' WHERE Hizmet_İd=" + Request.QueryString["Id"]);

            MessageBox.Show("İşlem Başarılı.<br/> Slider Güncellendi Kaldırıldı", MessageBox.MesajTipleri.Success);

            ImageYukluResim.ImageUrl = HizmetResim;
        }
        else
        {
            kod.komut("UPDATE hizmetler set  Hizmet_Adi='" + TextBoxHizmetAdi.Text + "', Hizmet_Kisa_Aciklama='" + TextBoxHizmetKisaAciklama.Text + "', Hizmet_Uzun_Aciklama = '" + TextBoxUzunAciklama.Text + "', Hizmet_Sayfa_Url = '" + url + "'  WHERE Hizmet_İd=" + Request.QueryString["Id"]);

            MessageBox.Show("İşlem Başarılı.<br/> Slider Güncellendi Kaldırıldı", MessageBox.MesajTipleri.Success);
        }
    }
}