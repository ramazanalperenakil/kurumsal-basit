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
            DataTable dt = kod.GetDataTable("Select * from kategoriler");
            DropDownListKategori.DataSource = dt;
            DropDownListKategori.DataValueField = "Kategori_Id";
            DropDownListKategori.DataTextField = "Kategori_Adi";
            DropDownListKategori.DataBind();
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
        if (fuDosya.HasFile)
        {
            try
            {

                string url = kod.KodOlustur(TextBoxBlogYaziBaslik.Text);
                string MakaleReismKucuk = kod.SliderKaydet(fuDosya, 370, 270, "/yuklemler/img/makale/kucuk/", url);
                string MaklaleResimBuyuk = kod.SliderKaydet(fuDosya, 870, 490, "/yuklemler/img/makale/buyuk/", url);
                kod.komut("Insert Into blog (Blog_Kucuk_Resim_Url,Blog_Buyuk_Resim_Url, Blog_Yazari, Blog_Yayinlanma, Blog_Duzenlenme,Blog_Okuma_Sayisi,Blog_Yazi_Basligi,Blog_Yazi_Onu,Blog_Yazi,Blog_Url,Kategori_Id) Values('" + MakaleReismKucuk + "','" + MaklaleResimBuyuk + "', '" + Session["kullanici"].ToString() + "', '" + DateTime.Now.ToLongDateString().ToString() + "', '" + DateTime.Now.ToLongDateString().ToString() + "' , '" + "50" + "' , '" + TextBoxBlogYaziBaslik.Text + "', '" + TextBoxMakaleKisaMetin.Text + "','" + TextBoxMakaleUzunMetin.Text + "','" + url + "','" + DropDownListKategori.SelectedValue + "')");
                MessageBox.Show("İşlem Başarılı.<br/> Makale Eklendi ", MessageBox.MesajTipleri.Success);
            }
            catch (Exception)
            {
                MessageBox.Show("HATA<br/> İşlem Yapılırken Bir Hata Oluştu Max:250 Karakter Olmalı  " , MessageBox.MesajTipleri.Error);
            }
        }
        else
        {
            MessageBox.Show("HATA<br/> Resim Yüklemdiniz  ", MessageBox.MesajTipleri.Error);
        }
    }
}