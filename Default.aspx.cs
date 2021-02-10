using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {

        Page.Title = kod.getDataCell("SELECT  Site_Adi FROM [ayar] ");
        DataTable dtSlider = kod.GetDataTable("SELECT *  FROM slider Order BY [Slider_Id] DESC");
        int ogeSayisi = dtSlider.Rows.Count;
        string ekle = "";
        for (int i = 0; i < ogeSayisi; i++)
        {
            if (i == 0)
            {
                ekle += "<li data-target='#slider' data-slide-to='" + i + "' class='active'></li>";
            }
            else
            {
                ekle += "<li data-target='#slider' data-slide-to='" + i + "'></li>";
            }
        }
        RepeaterSlider.DataSource = dtSlider;
        sliderGosterge.InnerHtml = ekle;
        RepeaterSlider.DataBind();

        RepeaterKartlar.DataSource = kod.GetDataTable("SELECT *  FROM [slider_alt_kart]");
        RepeaterKartlar.DataBind();

        RepeaterHakkimizda.DataSource = kod.GetDataTable("SELECT *  FROM [ayar]");
        RepeaterHakkimizda.DataBind();

        RepeaterHizmetler.DataSource = kod.GetDataTable("SELECT *  FROM [hizmetler] WHERE Hizmet_Resim_Url  IS NOT NULL ");
        RepeaterHizmetler.DataBind();

        RepeaterAyricalikAlt.DataSource = kod.GetDataTable("SELECT *  FROM [ayricaliklar]");
        RepeaterAyricalikAlt.DataBind();

        string HizmetlerBaslik = kod.getDataCell("SELECT  Hizmetler_Sayfa_Baslik FROM [hizmetler] WHERE [Hizmet_İd]=1 ");
        HizmetlerBaslikH.InnerHtml = HizmetlerBaslik.ToString();

        string Hizmet_Metin = kod.getDataCell("SELECT  Hizmetler_Sayfa_Kisa_Aciklama FROM [hizmetler] WHERE [Hizmet_İd]=1 ");
        HizmetlerMetin.InnerHtml = Hizmet_Metin.ToString();
        

        string AyricalikBaslik = kod.getDataCell("SELECT  Ayricalik_Genel_Adi FROM ayricaliklar WHERE [Ayricaliklar_İd]=1 ");
        ayricalikbaslik.InnerText = AyricalikBaslik.ToString();

        string EkipBaslik = kod.getDataCell("SELECT  Ekip_Genel_Baslik FROM [ekip] WHERE [Ekip_İd]=1 ");
        EkipSayfaBaslik.InnerText = EkipBaslik;

        string ekipsayfaaciklamasi = kod.getDataCell("SELECT  Ekip_Genel_Aciklama FROM [ekip] WHERE [Ekip_İd]=1 ");
        ekipsayfaaciklama.InnerText = ekipsayfaaciklamasi;

        RepeaterEkip.DataSource = kod.GetDataTable("SELECT *  FROM [ekip] ");
        RepeaterEkip.DataBind();


        string BlogBasliAna = kod.getDataCell("SELECT  Blog_Ana_Baslik FROM [blog] WHERE [Blog_Id]=1 ");
        BlogAnaBasligi.InnerText = BlogBasliAna;


        string BlogALtBaslik = kod.getDataCell("SELECT  Blog_Kisa_Aciklama FROM [blog] WHERE [Blog_Id]=1 ");
        BlogAltBasligi.InnerText = BlogBasliAna;

        RepeaterBlog.DataSource = kod.GetDataTable("SELECT *  FROM [blog] WHERE Blog_Ana_Baslik  IS  NULL ");
        RepeaterBlog.DataBind();



    }

    protected void ButtonGonder_Click(object sender, EventArgs e)
    {
        string adSoyad = TextBoxAdSoyad.Text , epostaAdresi = TextBoxEMail.Text, mesaji = TextBoxMesaj.Text;
        try
        {
            
            string konu = "Web Sitenizden Mesaj Var";
            
            
            string ipAdresi = "";
            if (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
                ipAdresi = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
            else if (HttpContext.Current.Request.UserHostAddress.Length != 0)
                ipAdresi = HttpContext.Current.Request.UserHostAddress;

            string mesajIcerik = "";
            mesajIcerik += "<b>İletişim Formundan Gelen Mesaj</b> / " + DateTime.Now.ToString() + " / " + ipAdresi + "<br/>";
            mesajIcerik += "<b>Adı Soyadı: </b>" + adSoyad + "<br/>";
            mesajIcerik += "<b>E-posta: </b>" + epostaAdresi + "<br/>";
            mesajIcerik += "<b>Konu: </b>" + konu + "<br/>";
            mesajIcerik += "<b>İleti: </b>" + mesaji;

            MailMessage yeniMesaj = new MailMessage();
            yeniMesaj.IsBodyHtml = true;
            yeniMesaj.To.Add("ramazanalperenakil@gmail.com");
            yeniMesaj.From = new MailAddress("raailetisim@gmail.com", "Site İletişim", System.Text.Encoding.UTF8);
            yeniMesaj.Subject = konu + " - " + adSoyad;
            yeniMesaj.Body = mesajIcerik + "<br/>" + "<br/>" + "Gönderen İp: " + ipAdresi;

            SmtpClient gonder = new SmtpClient();
            gonder.Credentials = new NetworkCredential("raailetisim@gmail.com", ".");
            gonder.Port = 587;
            gonder.Host = "smtp.gmail.com";
            gonder.EnableSsl = true;
            gonder.Send(yeniMesaj);

            MessageBox.Show("İşlem Başarılı.<br/>  Mesajınız Gönderildi ", MessageBox.MesajTipleri.Success);
            TextBoxAdSoyad.Text = "OK";
            //lblBilgi.Visible = true;
            //lblBilgi.Text = "Mesajınız Başarıyla Gönderildi!";
            //lblBilgi.ForeColor = System.Drawing.ColorTranslator.FromHtml("#00a186");
        }
        catch
        {
            MessageBox.Show("HATA <br/>  Mesaj Gönderilirken Bir Hata Oluştu Lütfen Daha Sonra Tekrar Deneyin ", MessageBox.MesajTipleri.Error);

        }
        finally
        {
            TextBoxAdSoyad.Text = "";
            TextBoxEMail.Text = "";
            TextBoxMesaj.Text = "";
        }
    }
}
