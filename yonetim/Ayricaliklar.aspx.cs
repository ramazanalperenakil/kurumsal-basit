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
            DataRow dr = kod.GetDataRow("Select * from ayricaliklar WHERE Ayricaliklar_İd=1 ");

            TextBoxAyricalikGenelBaslik.Text = dr[1].ToString();
            TextBoxAyricaklikGenelMetin.Text = dr[2].ToString();
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


        RepeaterAyrıcalıklar.DataSource = kod.GetDataTable("SELECT *  FROM [ayricaliklar] ");
        RepeaterAyrıcalıklar.DataBind();


    }

    protected void ButtonAricalikGenelBilgisiGüncelle_Click(object sender, EventArgs e)
    {
        try
        {
            kod.komut("UPDATE ayricaliklar set Ayricalik_Genel_Adi ='" + TextBoxAyricalikGenelBaslik.Text + "' ,  Ayricalik_Genel_Kisa_Aciklama = '" + TextBoxAyricaklikGenelMetin.Text + "' WHERE Ayricaliklar_İd =1");
            MessageBox.Show("İşlem Başarılı.<br/> Ayrıcalık Genel Bilgileri Güncellendi ", MessageBox.MesajTipleri.Success);
        }
        catch 
        {

            MessageBox.Show(" HATA <br/> İşlem Yapılırken Bir Hata Oluştu ", MessageBox.MesajTipleri.Error);
        }
      
    }
}