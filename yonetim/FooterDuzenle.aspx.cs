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
            DataRow dr = kod.GetDataRow("Select * from footer ");

            TextBoxAlanBirBaslik.Text = dr[1].ToString();
            TextBoxBirinciAlanMetin.Text = dr[2].ToString();
            TextBoxIletisimBaslik.Text = dr[3].ToString();
            TextBoxIletisimMetin.Text = dr[4].ToString();
            TextBoxEPosta.Text = dr[5].ToString();
            TextBoxTel.Text = dr[6].ToString();
            TextBoxFax.Text = dr[7].ToString();
            TextBoxAlanUcBaslik.Text = dr[8].ToString();
            TextBoxAlanUcMetin.Text = dr[9].ToString();
            TextBoxAlanDortBaslik.Text = dr[10].ToString();
            TextBoxAlanDortMetin.Text = dr[11].ToString();
            TextBoxLD.Text = dr[12].ToString();
            TextBoxFace.Text = dr[13].ToString();
            TextBoxTwitter.Text = dr[14].ToString();
            TextBoxInsatgarm.Text = dr[15].ToString();
            TextBoxCPR.Text = dr[16].ToString();
            




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
        try
        {
            kod.komut("UPDATE footer set Foter_Alan_Bir_Baslik='" + TextBoxAlanBirBaslik.Text + "', Foter_Alan_Bir_Metin='" + TextBoxBirinciAlanMetin.Text + "', Footer_İletisim_Baslik = '" + TextBoxIletisimBaslik.Text + "',Footer_İletisim_Metin = '" + TextBoxIletisimMetin.Text + "', Footer_İletisim_Telefon =  '" + TextBoxTel.Text + "', Footer_İletisim_Fax = '" + TextBoxFax.Text + "', Footer_İletisim_E_posta = '" + TextBoxEPosta.Text + "', Footer_Alan_Uc_Baslik = '" + TextBoxAlanUcBaslik.Text + "',Footer_Alan_Uc_Metin = '" + TextBoxAlanUcMetin.Text + "',Footer_Alan_Dort_Baslik  = '" + TextBoxAlanDortBaslik.Text + "', Footer_Alan_Dort_Metin = '" + TextBoxAlanDortMetin.Text + "' , Footer_Facebook_Url = '" + TextBoxFace.Text + "' , Footer_Twitter_Url = '" + TextBoxTwitter.Text + "' , Footer_İnstagram_Url = '" + TextBoxInsatgarm.Text + "' ,Footer_E_Posta_Url='" + TextBoxLD.Text + "'  ,Footer_CPR= '" + TextBoxCPR.Text + "'");

            MessageBox.Show("İşlem Başarılı.<br/> Kategori Güncellendi ", MessageBox.MesajTipleri.Success);
        }
        catch 
        {

            MessageBox.Show("HATA<br/> İşlem Sırasında Bir Hata Oldu ", MessageBox.MesajTipleri.Error);
        }
    }
}