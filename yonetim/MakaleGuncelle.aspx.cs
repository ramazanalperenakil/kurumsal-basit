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
            DataRow dr = kod.GetDataRow("Select * from blog WHERE [Blog_Id] = " + Request.QueryString["Id"]);

            TextBoxBlogYaziBaslik.Text = dr[9].ToString();
            TextBoxMakaleKisaMetin.Text = dr[10].ToString();
            TextBoxMakaleUzunMetin.Text = dr[11].ToString();
           // DropDownListKategori.DataSource= dr[14].ToString();
            ImageYukluResim.ImageUrl = dr[3].ToString();

            DataTable dt = kod.GetDataTable("Select * from kategoriler");
            DropDownListKategori.DataSource = dt;
            DropDownListKategori.DataValueField = "Kategori_Id";
            DropDownListKategori.DataTextField = "Kategori_Adi";
            DropDownListKategori.DataBind();

            DropDownListKategori.SelectedValue=  dr[13].ToString();



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
            string url = kod.KodOlustur(TextBoxBlogYaziBaslik.Text);
            string MakaleReismKucuk = kod.SliderKaydet(fuDosya, 370, 270, "/yuklemler/img/makale/kucuk/", url);
            string MaklaleResimBuyuk = kod.SliderKaydet(fuDosya, 870, 490, "/yuklemler/img/makale/buyuk/", url);

            kod.komut("UPDATE blog set Blog_Kucuk_Resim_Url='" + MakaleReismKucuk + "', Blog_Buyuk_Resim_Url='" + MaklaleResimBuyuk + "', Blog_Duzenlenme='" + DateTime.Now.ToLongDateString().ToString() + "', Blog_Yazi_Basligi='"+ TextBoxBlogYaziBaslik .Text+ "', Blog_Yazi_Onu = '"+TextBoxMakaleKisaMetin.Text+ "' , Blog_Yazi = '"+TextBoxMakaleUzunMetin.Text+ "', Kategori_Id = '"+DropDownListKategori.SelectedValue+ "' WHERE Blog_Id=" + Request.QueryString["Id"]);

            MessageBox.Show("İşlem Başarılı.<br/> Makale Güncellendi ", MessageBox.MesajTipleri.Success);
        }
        else
        {

            kod.komut("UPDATE blog set  Blog_Duzenlenme='" + DateTime.Now.ToLongDateString().ToString() + "', Blog_Yazi_Basligi='" + TextBoxBlogYaziBaslik.Text + "', Blog_Yazi_Onu = '" + TextBoxMakaleKisaMetin.Text + "' , Blog_Yazi = '" + TextBoxMakaleUzunMetin.Text + "', Kategori_Id = '" + DropDownListKategori.SelectedValue + "' WHERE Blog_Id=" + Request.QueryString["Id"]);

            MessageBox.Show("İşlem Başarılı.<br/> Kart Güncellendi ", MessageBox.MesajTipleri.Success);
        }
    }
}