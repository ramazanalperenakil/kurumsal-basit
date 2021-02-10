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
            DataRow dr = kod.GetDataRow("Select * from ayar ");

            TextBoxHakkimizdaBaslik.Text = dr[6].ToString();
            TextBoxHakkimizdaKisaMetin.Text = dr[8].ToString();
            ImageYukluResim.ImageUrl = dr[7].ToString();
            TextBoxHakkimizdaUzunMetin.Text = dr[9].ToString();
            TextBoxHakkimizdaSayfaUrl.Text = dr[10].ToString();
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
        string url = kod.KodOlustur(TextBoxHakkimizdaBaslik.Text);
        if (fuDosya.HasFile)
        {
            string HakkimizdaResim = kod.SliderKaydet(fuDosya, 450, 305, "/yuklemler/img/sayfalar/", url);

            kod.komut("UPDATE ayar set Hakkimizda_Baslik ='" + TextBoxHakkimizdaBaslik.Text + "' ,  Hakkimizda_Resim_Url = '" + HakkimizdaResim + "' , Hakkimizda_Kisa_Metin = '" + TextBoxHakkimizdaKisaMetin.Text + "' , Hakkimizda_Uzun_Metin = '" + TextBoxHakkimizdaUzunMetin.Text + "' , Hakkimizda_Url = '" + TextBoxHakkimizdaSayfaUrl.Text + "'" );
            MessageBox.Show("İşlem Başarılı.<br/> Hakkımızda Güncellendi ", MessageBox.MesajTipleri.Success);


        }
        else
        {
            kod.komut("UPDATE ayar set Hakkimizda_Baslik ='" + TextBoxHakkimizdaBaslik.Text + "' , Hakkimizda_Kisa_Metin = '" + TextBoxHakkimizdaKisaMetin.Text + "' , Hakkimizda_Uzun_Metin = '" + TextBoxHakkimizdaUzunMetin.Text + "' , Hakkimizda_Url = '" + TextBoxHakkimizdaSayfaUrl.Text + "'");
            MessageBox.Show("İşlem Başarılı.<br/> Hakkımızda Güncellendi ", MessageBox.MesajTipleri.Success);

        }
    }
}