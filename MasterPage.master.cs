using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    rehber kod = new rehber();
    protected void Page_Load(object sender, EventArgs e)
    {

        RepeaterLogo.DataSource = kod.GetDataTable("SELECT [Logo_Url]  FROM [ayar]");
        RepeaterLogo.DataBind();
        Repeater1FooterHakkimizda.DataSource = kod.GetDataTable("SELECT *  FROM [footer]");
        Repeater1FooterHakkimizda.DataBind();

        RepeaterFooterİletisim.DataSource = kod.GetDataTable("SELECT *  FROM [footer]");
        RepeaterFooterİletisim.DataBind();

        RepeaterFooterAlanUc.DataSource = kod.GetDataTable("SELECT *  FROM [footer]");
        RepeaterFooterAlanUc.DataBind();

        RepeaterFooterAlanDort.DataSource = kod.GetDataTable("SELECT *  FROM [footer]");
        RepeaterFooterAlanDort.DataBind();

        string facebook = kod.getDataCell("SELECT  Footer_Facebook_Url FROM [footer]");
        string twitter = kod.getDataCell("SELECT  Footer_Twitter_Url FROM [footer]");
        string instagram = kod.getDataCell("SELECT  Footer_İnstagram_Url FROM [footer]");
        string eposta = kod.getDataCell("SELECT  Footer_E_Posta_Url FROM [footer]");
        string CPR = kod.getDataCell("SELECT  Footer_CPR FROM [footer]");

        sosyal.InnerHtml = " <a title='facebook' href='#'><i class='fa fa-facebook'></i></a>";
        sosyal1.InnerHtml = " <a title='facebook' href='" + facebook + "'><i class='fa fa-facebook'></i></a>";
        sosyal2.InnerHtml = " <a title='twitter' href='" + twitter + "'><i class='fa fa-twitter'></i></a>";
        sosyal3.InnerHtml = " <a title='instagram' href='" + instagram + "'><i class='fa fa-google-plus'></i></a>";
        sosyal4.InnerHtml = " <a title='eposta' href='" + eposta + "'><i class='fa fa-pinterest'></i></a>";
        CPRR.InnerHtml = " " + CPR;

        string keyw = kod.getDataCell("SELECT Site_Anahtar_Kelime FROM [ayar]").ToString();
        HtmlMeta addKeywords = new HtmlMeta();
        addKeywords.Name = "keywords";
        addKeywords.Content = keyw;
        //Oluşturmuş olduğumuz Keyword listesini sayfamıza ekliyoruz.
        Page.Header.Controls.Add(addKeywords);

        HtmlMeta addDescription = new HtmlMeta();
        addDescription.Name = "description";
        addDescription.Content = kod.getDataCell("SELECT Site_Aciklama  FROM [ayar]").ToString();
        Page.Header.Controls.Add(addDescription);





    }

}
