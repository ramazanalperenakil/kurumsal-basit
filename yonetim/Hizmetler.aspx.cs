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
        if (Request.QueryString["Id"] != null && Request.QueryString["islem"] == "sil")
        {

            try
            {
                kod.komut("delete from hizmetler where Hizmet_İd=" + Request.QueryString["Id"].ToString());

                MessageBox.Show("İşlem Başarılı.<br/> Hizmet  Silindi", MessageBox.MesajTipleri.Success);
            }
            catch
            {

                MessageBox.Show("HATA<br/> İşlem Yapılamadı", MessageBox.MesajTipleri.Error);
            }




        }

        if (!Page.IsPostBack)
        {
            DataRow dr = kod.GetDataRow("Select * from hizmetler WHERE Hizmet_İd=1 ");

            TextBoxHizmetSayfaAdi.Text = dr[1].ToString();
            TextBoxHizmetSayfasiAciklama.Text = dr[2].ToString();
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

        RepeaterHizmetler.DataSource = kod.GetDataTable("SELECT *  FROM [hizmetler] WHERE Hizmet_Resim_Url  IS NOT NULL ORDER BY Hizmet_İd DESC");
        RepeaterHizmetler.DataBind();

    }

    protected void ButtonSayfaBilgisiGüncelle_Click(object sender, EventArgs e)
    {
        try
        {
            kod.komut("UPDATE hizmetler set Hizmetler_Sayfa_Baslik ='" + TextBoxHizmetSayfaAdi.Text + "' ,  Hizmetler_Sayfa_Kisa_Aciklama = '" + TextBoxHizmetSayfasiAciklama.Text + "' WHERE Hizmet_İd =1");
            MessageBox.Show("İşlem Başarılı.<br/> Hakkımızda Güncellendi ", MessageBox.MesajTipleri.Success);
        }
        catch 
        {

            MessageBox.Show("HATA <br/> İşlem Sırasında Hata Oluştu ", MessageBox.MesajTipleri.Error);
        }
       
    }
}