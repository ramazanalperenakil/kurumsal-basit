<%@ Application Language="C#" %>

<script RunAt="server">

    void Application_Start(object sender, EventArgs e)
    {
        // Uygulama başlangıcında çalışan kod
        RegisterRoutes(System.Web.Routing.RouteTable.Routes);

    }
    public static void RegisterRoutes(System.Web.Routing.RouteCollection route)
    {

        route.MapPageRoute("Hizmetler", "Hizmet-Detay/{Hizmet_Sayfa_Url}-{Hizmet_İd}", "~/hizmetdetay.aspx");
        route.MapPageRoute("Makale", "Makale/{Blog_Url}-{Blog_Id}", "~/BlogDetay.aspx");
        route.MapPageRoute("Blog", "Blog", "~/blog.aspx");
        route.MapPageRoute("Anasayfa", "Anasayfa", "~/Default.aspx");
        route.MapPageRoute("Hakkımızda", "Hakkimizda", "~/hakkimizda.aspx");
        route.MapPageRoute("Hizmetlerimiz", "Hizmetler", "~/hizmetler.aspx");
        route.MapPageRoute("İletişim", "İletisim", "~/iletisim.aspx");
        route.MapPageRoute("Tüm Kategoriler", "Kategori", "~/Kategori.aspx");
         route.MapPageRoute("Kategori", "Kategori/{Kategori_Adi}-{Kategori_Id}", "~/Kategori.aspx");





        //route.MapPageRoute("yazi", "{URL}-{YaziId}", "~/YazıDetay.aspx");
        //route.MapPageRoute("Tüm Haberler", "haberler", "~/Kategori.aspx");

    }

    void Application_End(object sender, EventArgs e)
    {
        // Uygulama kapanışında çalışan kod

    }

    void Application_Error(object sender, EventArgs e)
    {
        // İşlenmemiş bir hata oluştuğunda çalışan kod

    }

    void Session_Start(object sender, EventArgs e)
    {
        // Yeni bir oturum başlatıldığında çalışan kod

    }

    void Session_End(object sender, EventArgs e)
    {
        // Oturum bittiğinde çalışan kod
        // Not: Session_End olayı yalnızca sessionstate modu
        // Web.config dosyasında InProc olarak ayarlandığında başlatılır. Oturum modu StateServer 
        // veya SQLServer olarak ayarlanırsa, olay başlatılmaz.

    }

</script>
