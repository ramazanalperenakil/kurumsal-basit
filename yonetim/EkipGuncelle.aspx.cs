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
            DataRow dr = kod.GetDataRow("Select * from ekip WHERE [Ekip_İd] = " + Request.QueryString["Id"]);

            ImageYukluResim.ImageUrl = dr[3].ToString();
            TextBoxAdSoyad.Text = dr[4].ToString();
            TextBoxGörevi.Text = dr[5].ToString();
            TextBoxFacebook.Text = dr[6].ToString();
            TextBoxTwitter.Text = dr[7].ToString();
            TextBoxInstagram.Text = dr[8].ToString();
            TextBoxDiger.Text = dr[9].ToString();




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
        string url = kod.KodOlustur(TextBoxAdSoyad.Text);
        if (fuDosya.HasFile)
        {
            string SliderResim = kod.SliderKaydet(fuDosya, 370, 456, "/yuklemler/img/ekip/", url);
           
            kod.komut("UPDATE ekip set Ekip_Uye_Resim_Url='" + SliderResim + "', Ekip_Uye_Adi='" + TextBoxAdSoyad.Text + "', Ekip_Uye_Gorevi='" + TextBoxGörevi.Text + "', Sosyal_Medya_Url_Facebook = '" + TextBoxFacebook.Text + "', Sosyal_Medya_Url_Twitter = '" + TextBoxTwitter.Text + "' , Sosyal_Medya_Url_İnstagram ='" + TextBoxInstagram.Text + "', Sosyal_Medya_Url_Diger= '"+TextBoxDiger.Text+ "' WHERE Ekip_İd=" + Request.QueryString["Id"]);

            MessageBox.Show("İşlem Başarılı.<br/>  Ekip Üyesi Güncellendi ", MessageBox.MesajTipleri.Success);

            ImageYukluResim.ImageUrl = SliderResim;
        }
        else
        {
            kod.komut("UPDATE ekip set  Ekip_Uye_Adi='" + TextBoxAdSoyad.Text + "', Ekip_Uye_Gorevi='" + TextBoxGörevi.Text + "', Sosyal_Medya_Url_Facebook = '" + TextBoxFacebook.Text + "', Sosyal_Medya_Url_Twitter = '" + TextBoxTwitter.Text + "' , Sosyal_Medya_Url_İnstagram ='" + TextBoxInstagram.Text + "', Sosyal_Medya_Url_Diger= '" + TextBoxDiger.Text + "' WHERE Ekip_İd=" + Request.QueryString["Id"]);

            MessageBox.Show("İşlem Başarılı.<br/> Ekip Üyesi Güncellendi ", MessageBox.MesajTipleri.Success);
        }
    }
}