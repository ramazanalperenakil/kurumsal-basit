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
            DataRow dr = kod.GetDataRow("Select * from ayricaliklar WHERE [Ayricaliklar_İd] = " + Request.QueryString["Id"]);

            TextBoxAyricalikBaslik.Text = dr[4].ToString();
            TextBoxAyricalikMetin.Text = dr[5].ToString();
            ImageYukluResim.ImageUrl = dr[3].ToString();
            
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
        string url = kod.KodOlustur( TextBoxAyricalikBaslik.Text);
        if (fuDosya.HasFile)
        {
            string AyricalikResim = kod.SliderKaydet(fuDosya, 70, 62, "/yuklemler/img/ayricaliklar/", url);
            kod.komut("UPDATE ayricaliklar set Ayricalik_İcon_Url='" + AyricalikResim + "', Ayricalik_Adi='" + TextBoxAyricalikBaslik.Text + "', Ayricalik_Metin='" + TextBoxAyricalikMetin.Text + "' WHERE Ayricaliklar_İd=" + Request.QueryString["Id"]);
            ImageYukluResim.ImageUrl = AyricalikResim;
            MessageBox.Show("İşlem Başarılı.<br/> Slider Güncellendi Kaldırıldı", MessageBox.MesajTipleri.Success);
        }
        else
        {
            kod.komut("UPDATE ayricaliklar set Ayricalik_Adi='" + TextBoxAyricalikBaslik.Text + "', Ayricalik_Metin='" + TextBoxAyricalikMetin.Text + "' WHERE Ayricaliklar_İd=" + Request.QueryString["Id"]);

            MessageBox.Show("İşlem Başarılı.<br/> Slider Güncellendi Kaldırıldı", MessageBox.MesajTipleri.Success);
        }
    }
}