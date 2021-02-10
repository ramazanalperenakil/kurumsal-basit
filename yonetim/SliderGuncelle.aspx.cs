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
            DataRow dr = kod.GetDataRow("Select * from slider WHERE [Slider_Id] = "+Request.QueryString["Id"]);

            TextBoxSliderHedefUrl.Text = dr[3].ToString();
            DropDownListYayinDurumu.SelectedValue = dr[2].ToString();
            ImageYukluResim.ImageUrl = dr[1].ToString();


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
        string url = kod.KodOlustur(TextBoxSliderHedefUrl.Text);
        if (fuDosya.HasFile)
        {
            string SliderResim = kod.SliderKaydet(fuDosya, 1920, 800, "/yuklemler/img/slider/", url);
            kod.komut("UPDATE slider set Slider_Gorsel_Url='" + SliderResim + "', Slider_Durum='" + DropDownListYayinDurumu.SelectedValue + "', Slider_Hedef_Url='" + TextBoxSliderHedefUrl.Text + "' WHERE Slider_Id=" + Request.QueryString["Id"]);

            MessageBox.Show("İşlem Başarılı.<br/> Slider Güncellendi Kaldırıldı", MessageBox.MesajTipleri.Success);
        }
        else
        {
            kod.komut("UPDATE slider set  Slider_Durum='" + DropDownListYayinDurumu.SelectedValue + "', Slider_Hedef_Url='" + TextBoxSliderHedefUrl.Text + "' WHERE Slider_Id=" + Request.QueryString["Id"]);

            MessageBox.Show("İşlem Başarılı.<br/> Slider Güncellendi Kaldırıldı", MessageBox.MesajTipleri.Success);
        }

    }
}