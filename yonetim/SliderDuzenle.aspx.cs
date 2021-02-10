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
        if (DropDownListYayinDurumunaGore.SelectedItem.Text== "Pasif")
        {
            RepeaterSlider.DataSource = kod.GetDataTable("SELECT *  FROM [slider] WHERE Slider_Durum = 0  ");
            RepeaterSlider.DataBind();
        }
        else if (DropDownListYayinDurumunaGore.SelectedItem.Text == "Aktif")
        {
            RepeaterSlider.DataSource = kod.GetDataTable("SELECT *  FROM [slider]  WHERE Slider_Durum = 1  Order BY [Slider_Id] DESC");
            RepeaterSlider.DataBind();
        }
        else
        {
            RepeaterSlider.DataSource = kod.GetDataTable("SELECT *  FROM [slider]   Order BY [Slider_Id] DESC");
            RepeaterSlider.DataBind();
        }
        if (Request.QueryString["Id"] != null && Request.QueryString["islem"] == "yayindankaldir")
        {
            try
            {
                kod.komut("UPDATE slider set Slider_Durum= 0 where Slider_Id=" + Request.QueryString["Id"].ToString());

                MessageBox.Show("İşlem Başarılı.<br/> Resim Yayından Kaldırıldı", MessageBox.MesajTipleri.Success);
            }
            catch 
            {

                MessageBox.Show("HATA<br/> İşlem Yapılamadı", MessageBox.MesajTipleri.Error);
            }

           
            

            


        }
        if (Request.QueryString["Id"] != null && Request.QueryString["islem"] == "sil")
        {

            try
            {
                kod.komut("delete from slider where Slider_Id=" + Request.QueryString["Id"].ToString());

                MessageBox.Show("İşlem Başarılı.<br/> Slider Silindi", MessageBox.MesajTipleri.Success);
            }
            catch 
            {

                MessageBox.Show("HATA<br/> İşlem Yapılamadı", MessageBox.MesajTipleri.Error);
            }
           



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

        ImageUser.ImageUrl = kod.getDataCell("SELECT  Kullanici_Resim_Url FROM [kullanicilar]");

        ImageMobilMenuUserLogo.ImageUrl = kod.getDataCell("SELECT  Kullanici_Resim_Url FROM [kullanicilar]");

       





    }



    

    
}