﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AyricalikGuncelle.aspx.cs" Inherits="yonetim_Default" %>

<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <!-- Required meta tags-->
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="au theme template">
    <meta name="author" content="Hau Nguyen">
    <meta name="keywords" content="au theme template">

    <!-- Title Page-->
    <title>Dashboard 2</title>

    <!-- Fontfaces CSS-->
    <link href="css/font-face.css" rel="stylesheet" media="all">
    <link href="vendor/font-awesome-4.7/css/font-awesome.min.css" rel="stylesheet" media="all">
    <link href="vendor/font-awesome-5/css/fontawesome-all.min.css" rel="stylesheet" media="all">
    <link href="vendor/mdi-font/css/material-design-iconic-font.min.css" rel="stylesheet" media="all">

    <!-- Bootstrap CSS-->
    <link href="vendor/bootstrap-4.1/bootstrap.min.css" rel="stylesheet" media="all">

    <!-- Vendor CSS-->
    <link href="vendor/animsition/animsition.min.css" rel="stylesheet" media="all">
    <link href="vendor/bootstrap-progressbar/bootstrap-progressbar-3.3.4.min.css" rel="stylesheet" media="all">
    <link href="vendor/wow/animate.css" rel="stylesheet" media="all">
    <link href="vendor/css-hamburgers/hamburgers.min.css" rel="stylesheet" media="all">
    <link href="vendor/slick/slick.css" rel="stylesheet" media="all">
    <link href="vendor/select2/select2.min.css" rel="stylesheet" media="all">
    <link href="vendor/perfect-scrollbar/perfect-scrollbar.css" rel="stylesheet" media="all">
    <link href="vendor/vector-map/jqvmap.min.css" rel="stylesheet" media="all">

    <!-- Main CSS-->
    <link href="css/theme.css" rel="stylesheet" media="all">

    
    <link rel="stylesheet" href="../js/notifyit/notifIt.css" />
    <script src="..//js/jquery-2.0.3.min.js"></script>
    <script src="..//js/notifyit/notifIt.js"></script>
    <script src="ckeditor/ckeditor.js"></script>
      <style type="text/css">
        pre
        {
            border: solid 1px #ccc;
            background-color: #ffa;
            padding: 5px;
            color: #a00;
            line-height: 1.5em;
            
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <!-- MENU SIDEBAR-->
        <aside class="menu-sidebar2">
            <div class="logo">
                <a href="Default.aspx">
                    <asp:Image ID="ImageLogo" ImageUrl="images/icon/logo-white.png" runat="server" />

                </a>
            </div>
            <div class="menu-sidebar2__content js-scrollbar1">
                <div class="account2">
                    <div class="image img-cir img-120">
                        <asp:Image ID="ImageUser" ImageUrl="images/icon/avatar-big-01.jpg" runat="server" />
                    </div>
                    <h4 class="name" id="isim" runat="server">İsim Soyisim</h4>
                    <a href="cik.aspx">Çıkış Yap</a>
                </div>
                <nav class="navbar-sidebar2">
                    <ul class="list-unstyled navbar__list">
                        <li class="active has-sub">
                            <a href="Default.aspx">
                                <i class="fas fa-tachometer-alt"></i>Yönetim Anasayfa
                            </a>

                        </li>
                        <li class="has-sub">
                            <a class="js-arrow" href="#">
                                <i class="fas fa-camera-retro"></i>Slider İşlemleri
                               
                                <span class="arrow">
                                    <i class="fas fa-angle-down"></i>
                                </span>
                            </a>
                            <ul class="list-unstyled navbar__sub-list js-sub-list">
                                <li>
                                    <a href="SliderEkle.aspx">
                                        <i class="fas fa-plus-circle"></i>Slider Ekle</a>
                                </li>
                                <li>
                                    <a href="SliderDuzenle.aspx">
                                        <i class="fas fa-edit"></i>Slider Düzenle</a>
                                </li>


                            </ul>
                        </li>

                        <li class="has-sub">
                            <a class="js-arrow" href="#">
                                <i class="fas fa-desktop"></i>Modül İşlemleri
                               
                                <span class="arrow">
                                    <i class="fas fa-angle-down"></i>
                                </span>
                            </a>
                            <ul class="list-unstyled navbar__sub-list js-sub-list">

                                <li>
                                    <a href="KartDuzenle.aspx">
                                        <i class="fas fa-edit"></i>Kart Düzenle</a>
                                </li>
                                <li>
                                    <a href="HakkimizdaDuzenle.aspx">
                                        <i class="fas fa-edit"></i>Hakkımzda Düzenle</a>
                                </li>
                                <li>
                                    <a href="HizmetEkle.aspx">
                                        <i class="fas fa-plus-circle"></i>Hizmet Ekle</a>
                                </li>
                                <li>
                                    <a href="Hizmetler.aspx">
                                        <i class="fas fa-edit"></i>Hizmetler Düzenle</a>
                                </li>
                                <li>
                                    <a href="Ayricaliklar.aspx">
                                        <i class="fas fa-edit"></i>Ayrıcalıklar Düzenle</a>
                                </li>
                                <li>
                                    <a href="EkipUyeEkle.aspx">
                                        <i class="fas fa-plus-circle"></i>Ekip Üye Ekle</a>
                                </li>
                                <li>
                                    <a href="EkipDuzenle.aspx">
                                        <i class="fas fa-edit"></i>Ekip Düzenle</a>
                                </li>

                            </ul>
                        </li>
                        <li class="has-sub">
                            <a class="js-arrow" href="#">
                                <i class="fas fa-book"></i>Blog İşlemleri
                               
                                <span class="arrow">
                                    <i class="fas fa-angle-down"></i>
                                </span>
                            </a>
                            <ul class="list-unstyled navbar__sub-list js-sub-list">
                                <li>
                                    <a href="BlogYaziEkle.aspx">
                                        <i class="fas fa-plus-circle"></i>Blog Yazı Ekle</a>
                                </li>
                                <li>
                                    <a href="BlogDuzenle.aspx">
                                        <i class="fas fa-edit"></i>Blog Düzenle</a>
                                </li>
                                <li>
                                    <a href="KategoriEkle.aspx">
                                        <i class="fas fa-plus-circle"></i>Kategori Ekle</a>
                                </li>
                                <li>
                                    <a href="KategoriDuzenle.aspx">
                                        <i class="fas fa-edit"></i>Kategori Düzenle</a>
                                </li>

                            </ul>
                        </li>
                        <li class=" has-sub">
                            <a href="FooterDuzenle.aspx">
                                <i class="fas fa-edit"></i>Footer Düzenle 
                            </a>

                        </li>
                    </ul>
                </nav>
            </div>

        </aside>

        <!-- END MENU SIDEBAR-->
        <!-- PAGE CONTAINER-->
        <div class="page-container2">
            <!-- HEADER DESKTOP-->
            <header class="header-desktop2">
                <div class="section__content section__content--p30">
                    <div class="container-fluid">
                        <div class="header-wrap2">
                            <div class="logo d-block d-lg-none">
                                <a href="#">
                                    <img src="images/icon/logo-white.png" alt="CoolAdmin" />
                                </a>
                            </div>
                            <div class="header-button2">

                                <div class="header-button-item mr-0 js-sidebar-btn">
                                    <i class="zmdi zmdi-menu"></i>
                                </div>
                                <div class="setting-menu js-right-sidebar d-none d-lg-block">
                                    <div class="account-dropdown__body">
                                        <div class="account-dropdown__item">
                                            <a href="Hesap.aspx">
                                                <i class="zmdi zmdi-account"></i>Hesabım</a>
                                        </div>
                                        <div class="account-dropdown__item">
                                            <a href="Ayar.aspx">
                                                <i class="zmdi zmdi-settings"></i>Ayarlar</a>
                                        </div>

                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </header>
            <aside class="menu-sidebar2 js-right-sidebar d-block d-lg-none">
                <div class="logo d-block d-lg-none">
                    <a href="#">
                        <img src="images/icon/logo-white.png" alt="CoolAdmin" />
                    </a>
                </div>
                <div class="menu-sidebar2__content js-scrollbar2">
                    <div class="account2">
                        <div class="image img-cir img-120">
                            <asp:Image ID="ImageMobilMenuUserLogo" runat="server" />

                        </div>
                        <h4 class="name" id="adsoyadmobil" runat="server">İsim Soyisim</h4>
                        <a href="cik.aspx">Çıkış Yap</a>
                    </div>
                    <nav class="navbar-sidebar2">
                        <ul class="list-unstyled navbar__list">
                            <li class="active has-sub">
                                <a href="Default.aspx">
                                    <i class="fas fa-tachometer-alt"></i>Yönetim Anasayfa
                                </a>

                            </li>
                            <li class="has-sub">
                                <a class="js-arrow" href="#">
                                    <i class="fas fa-camera-retro"></i>Slider İşlemleri
                               
                                <span class="arrow">
                                    <i class="fas fa-angle-down"></i>
                                </span>
                                </a>
                                <ul class="list-unstyled navbar__sub-list js-sub-list">
                                    <li>
                                        <a href="SliderEkle.aspx">
                                            <i class="fas fa-plus-circle"></i>Slider Ekle</a>
                                    </li>
                                    <li>
                                        <a href="SliderDuzenle.aspx">
                                            <i class="fas fa-edit"></i>Slider Düzenle</a>
                                    </li>


                                </ul>
                            </li>

                            <li class="has-sub">
                                <a class="js-arrow" href="#">
                                    <i class="fas fa-desktop"></i>Modül İşlemleri
                               
                                <span class="arrow">
                                    <i class="fas fa-angle-down"></i>
                                </span>
                                </a>
                                <ul class="list-unstyled navbar__sub-list js-sub-list">

                                    <li>
                                        <a href="KartDuzenle.aspx">
                                            <i class="fas fa-edit"></i>Kart Düzenle</a>
                                    </li>
                                    <li>
                                        <a href="HakkimizdaDuzenle.aspx">
                                            <i class="fas fa-edit"></i>Hakkımzda Düzenle</a>
                                    </li>
                                    <li>
                                        <a href="HizmetEkle.aspx">
                                            <i class="fas fa-plus-circle"></i>Hizmet Ekle</a>
                                    </li>
                                    <li>
                                        <a href="Hizmetler.aspx">
                                            <i class="fas fa-edit"></i>Hizmetler Düzenle</a>
                                    </li>
                                    <li>
                                        <a href="Ayricaliklar.aspx">
                                            <i class="fas fa-edit"></i>Ayrıcalıklar Düzenle</a>
                                    </li>
                                    <li>
                                        <a href="EkipUyeEkle.aspx">
                                            <i class="fas fa-plus-circle"></i>Ekip Üye Ekle</a>
                                    </li>
                                    <li>
                                        <a href="EkipDuzenle.aspx">
                                            <i class="fas fa-edit"></i>Ekip Düzenle</a>
                                    </li>

                                </ul>
                            </li>
                            <li class="has-sub">
                                <a class="js-arrow" href="#">
                                    <i class="fas fa-book"></i>Blog İşlemleri
                               
                                <span class="arrow">
                                    <i class="fas fa-angle-down"></i>
                                </span>
                                </a>
                                <ul class="list-unstyled navbar__sub-list js-sub-list">
                                    <li>
                                        <a href="BlogYaziEkle.aspx">
                                            <i class="fas fa-plus-circle"></i>Blog Yazı Ekle</a>
                                    </li>
                                    <li>
                                        <a href="BlogDuzenle.aspx">
                                            <i class="fas fa-edit"></i>Blog Düzenle</a>
                                    </li>
                                    <li>
                                        <a href="KategoriEkle.aspx">
                                            <i class="fas fa-plus-circle"></i>Kategori Ekle</a>
                                    </li>
                                    <li>
                                        <a href="KategoriDuzenle.aspx">
                                            <i class="fas fa-edit"></i>Kategori Düzenle</a>
                                    </li>

                                </ul>
                            </li>
                            <li class=" has-sub">
                                <a href="FooterDuzenle.aspx">
                                    <i class="fas fa-edit"></i>Footer Düzenle 
                                </a>

                            </li>

                            <li class=" has-sub">
                                <a href="Hesap.aspx">
                                    <i class="fas fa-user"></i>Hesabım 
                                </a>

                            </li>

                            <li class=" has-sub">
                                <a href="Ayar.aspx">
                                    <i class="fas  fa-cog"></i>Ayarlar 
                                </a>

                            </li>
                        </ul>
                    </nav>
                </div>
            </aside>
            <!-- END HEADER DESKTOP-->

            <br />
            <h1 class="pt-5">Ayrıcalık Güncelle</h1>


            
      
            <div class="card">
                <div class="card-header">
                    Ayrıcalık Güncelle
                </div>
                <div class="card-body card-block">





                    <div class="row form-group">
                        <div class="col col-md-3">
                            <label for="text-input" class=" form-control-label">Ayrıcalık  Başlık</label>
                        </div>
                        <div class="col-12 col-md-9">
                            <asp:TextBox ID="TextBoxAyricalikBaslik" CssClass="form-control" runat="server"></asp:TextBox>
                           
                        </div>
                    </div>

                  

                    <div class="row form-group">
                        <div class="col col-md-3">
                            <label for="text-input" class=" form-control-label">Ayrıcalık  Metin</label>
                        </div>
                        <div class="col-12 col-md-9">
                            <asp:TextBox ID="TextBoxAyricalikMetin" TextMode="MultiLine" CssClass="form-control" runat="server"></asp:TextBox>
                         <script type="text/javascript">
                                CKEDITOR.replace('TextBoxAyricalikMetin',{wordcount: {showParagraphs: true,showWordCount: true,showCharCount: true,countSpacesAsChars:true,countHTML:false,maxCharCount: 300}});

                            </script>
                        </div>
                    </div>

              







               
                    <div class="row form-group">
                        <div class="col col-md-3">
                            <label for="file-input" class=" form-control-label">Resim Seçiniz</label>
                        </div>
                        <div class="col-12 col-md-9">
                            <asp:FileUpload ID="fuDosya" ClientIDMode="Static" onchange="$('#resim1')[0].src = window.URL.createObjectURL(this.files[0])" CssClass="form-control" runat="server" Width="100%" Height="35px" />



                        </div>
                    </div>
                    <div class="row form-group mt-2">
                        <div class="col col-md-3 mt-2">
                            <label for="select" class=" form-control-label">Seçilen Resim</label>
                        </div>
                        <div class="col-12 col-md-9 mt-2">
                            <img id="resim1" runat="server" alt="Seçtiğiniz resim burada görünecek " class="img-fluid" height="350" width="350" />
                           
                             <asp:Image ID="ImageYukluResim" CssClass="img-fluid" runat="server" Height="350" Width="350" />
                           
                        </div>
                        
                    </div>

                </div>





                <div class="card-footer">
                    <asp:Button ID="ButtonYayınla" CssClass="btn btn-primary" runat="server" Text="Güncelle" OnClick="ButtonYayınla_Click"  />
                 
                </div>
            </div>














            <section>
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="copyright">
                                <script runat="server">
                                    protected string GetTime()
                                    {
                                        return DateTime.Now.Year.ToString();

                                    }
                                </script>
                                <div runat="server">
                                    <div>
                                        &copy  <%= GetTime() %> <a href="https://www.aktifajans.net" target="_blank">Aktif Ajans Bünyesinde Oluşturulmuştur</a>
                                    </div>
                                </div>
                                
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <!-- END PAGE CONTAINER-->

        </div>

    </form>

</body>
<!-- Jquery JS-->
<script src="vendor/jquery-3.2.1.min.js"></script>
<!-- Bootstrap JS-->
<script src="vendor/bootstrap-4.1/popper.min.js"></script>
<script src="vendor/bootstrap-4.1/bootstrap.min.js"></script>
<!-- Vendor JS       -->
<script src="vendor/slick/slick.min.js">
    </script>
<script src="vendor/wow/wow.min.js"></script>
<script src="vendor/animsition/animsition.min.js"></script>
<script src="vendor/bootstrap-progressbar/bootstrap-progressbar.min.js">
    </script>
<script src="vendor/counter-up/jquery.waypoints.min.js"></script>
<script src="vendor/counter-up/jquery.counterup.min.js">
    </script>
<script src="vendor/circle-progress/circle-progress.min.js"></script>
<script src="vendor/perfect-scrollbar/perfect-scrollbar.js"></script>
<script src="vendor/chartjs/Chart.bundle.min.js"></script>
<script src="vendor/select2/select2.min.js">
    </script>
<script src="vendor/vector-map/jquery.vmap.js"></script>
<script src="vendor/vector-map/jquery.vmap.min.js"></script>
<script src="vendor/vector-map/jquery.vmap.sampledata.js"></script>
<script src="vendor/vector-map/jquery.vmap.world.js"></script>

<!-- Main JS-->
<script src="js/main.js"></script>
</html>
