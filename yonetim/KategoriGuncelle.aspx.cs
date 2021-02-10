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
            DataRow dr = kod.GetDataRow("Select Kategori_Adi from kategoriler WHERE [Kategori_Id] = " + Request.QueryString["Id"]);

            TextBoxKategoriAdi.Text = dr[0].ToString();
           

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

    protected void ButtonKaydet_Click(object sender, EventArgs e)
    {
        try
        {
            string url = kod.KodOlustur(TextBoxKategoriAdi.Text);
            kod.komut("UPDATE kategoriler set Kategori_Adi='" + TextBoxKategoriAdi.Text + "', Kategori_Url='" + url + "' WHERE Kategori_Id=" + Request.QueryString["Id"]);

            MessageBox.Show("İşlem Başarılı.<br/> Kategori Güncellendi ", MessageBox.MesajTipleri.Success);
        }
        catch 
        {

            MessageBox.Show("HATA <br/> İşlem Yapılırken Bir Hata Oluştu ", MessageBox.MesajTipleri.Error);
        }
        
    }
}