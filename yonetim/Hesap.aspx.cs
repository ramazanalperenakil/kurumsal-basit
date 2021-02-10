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
    string id;
    string gelenkadi, sifrem;

    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = kod.getDataCell("SELECT  Site_Adi FROM [ayar] ");
        if (Session["kullanici"] == null)
        {
            Response.Redirect("Giris.aspx");
        }
        else
        {
            gelenkadi = Session["kullanici"].ToString();
            //string ad = kod.getDataCell("SELECT  Kullanici_Adi  FROM [kullanicilar] WHERE Kullanici_Sonek =" + gelenkadi);

            //string Soyad = kod.getDataCell("SELECT Kullanici_Soyadi  FROM [kullanicilar] WHERE Kullanici_Sonek =" + Session["kullanici"].ToString());

            isim.InnerText = gelenkadi;
            adsoyadmobil.InnerText = gelenkadi;

            id = kod.getDataCell("SELECT  Kullanici_Id FROM [kullanicilar] WHERE Kullanici_Sonek = " + Session["kullanici"].ToString());



        }
        ImageLogo.ImageUrl = kod.getDataCell("SELECT  Logo_Url FROM [ayar]");

        ImageUser.ImageUrl = kod.getDataCell("SELECT  Kullanici_Resim_Url FROM [kullanicilar]");

        ImageMobilMenuUserLogo.ImageUrl = kod.getDataCell("SELECT  Kullanici_Resim_Url FROM [kullanicilar]");

        if (!Page.IsPostBack)
        {
            DataRow dr = kod.GetDataRow("Select * from kullanicilar WHERE Kullanici_Sonek = '" + gelenkadi + "' ");

            TextBoxAd.Text = dr[1].ToString();
            TextBoxSoyad.Text = dr[2].ToString();
            TextBoxKadi.Text = dr[3].ToString();
            TextBoxEPosta.Text = dr[4].ToString();
            sifrem = dr[6].ToString();
            TextBoxSifre.Text = dr[6].ToString();
            resim1.ImageUrl = dr[7].ToString();

        }



    }

    protected void ButtonKaydet_Click(object sender, EventArgs e)
    {
        string url = kod.KodOlustur(TextBoxAd.Text + "_" + TextBoxSoyad.Text);


        if (fuDosya.HasFile)
        {

            string Profil = kod.SliderKaydet(fuDosya, 300, 300, "/yuklemler/img/uye/", url);
            kod.komut("UPDATE kullanicilar set Kullanici_Adi='" + TextBoxAd.Text + "', Kullanici_Soyadi='" + TextBoxSoyad.Text + "', Kullanici_E_Posta='" + TextBoxEPosta.Text + "',  Kullanici_Sifre= '" + TextBoxSifre.Text + "', Kullanici_Resim_Url = '" + Profil + "' WHERE Kullanici_Sonek= '"+ gelenkadi + "'" );

            MessageBox.Show("İşlem Başarılı.<br/>  Ekip Üyesi Eklendi Kaldırıldı", MessageBox.MesajTipleri.Success);


            resim1.ImageUrl = Profil;







        }
        else
        {
            kod.komut("UPDATE kullanicilar set Kullanici_Adi='" + TextBoxAd.Text + "', Kullanici_Soyadi='" + TextBoxSoyad.Text + "', Kullanici_E_Posta='" + TextBoxEPosta.Text + "', Kullanici_Sifre = '" + TextBoxSifre.Text + "' WHERE Kullanici_Sonek= '" + gelenkadi + "'");

            MessageBox.Show("İşlem Başarılı.<br/>  Ekip Üyesi Eklendi Kaldırıldı", MessageBox.MesajTipleri.Success);
        }


    }





}