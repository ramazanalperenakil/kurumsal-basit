<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            position: relative;
            width: 100%;
            min-height: 1px;
            -ms-flex: 0 0 75%;
            -webkit-box-flex: 0;
            flex: 0 0 75%;
            max-width: 75%;
            left: 0px;
            top: -6px;
            padding-left: 15px;
            padding-right: 15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="slider" class="carousel slide" data-ride="carousel">
        <ol class="carousel-indicators" runat="server" id="sliderGosterge">
        </ol>
        <div class="carousel-inner">
            <asp:Repeater ID="RepeaterSlider" runat="server">
                <ItemTemplate>
                    <div class="carousel-item <%#(Container.ItemIndex == 0 ? "active":"") %>">
                        <a href='#'>
                            <img src='<%#Eval("Slider_Gorsel_Url")%>' class="d-block w-100" alt="...">
                        </a>
                    </div>

                </ItemTemplate>
            </asp:Repeater>


        </div>
        <a class="carousel-control-prev" href="#slider" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Önceki</span>
        </a>
        <a class="carousel-control-next" href="#slider" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Sonraki</span>
        </a>
    </div>

    <!-- Page Conttent -->
    <main class="page-content">

        <!-- Start Service Style-->
        <div class="section-service">
            <div class="container-fluid plr_-0">
                <div class="row no-gutters row-0">
                    <asp:Repeater ID="RepeaterKartlar" runat="server">
                        <ItemTemplate>
                            <!-- Start Single Service -->
                            <div class="col-lg-3 col-md-6 col-sm-6 col-12">
                                <div class="row-service-wrap">
                                    <div class="service text-left service-6 medical-service">
                                        <div class="icons">

                                            <img src='<%#Eval("Kart_Icon_Url")%>' alt="service icons">
                                        </div>
                                        <div class="content">
                                            <h4><%#Eval("Kart_Baslik")%></h4>
                                            <p><%#Eval("Kart_Aciklama")%></p>
                                        </div>
                                    </div>
                                </div>
                            </div>


                            <!-- End Single Service -->
                        </ItemTemplate>
                    </asp:Repeater>



                </div>
            </div>
        </div>
        <!-- End Service Style-->

        <!-- Start Agency Benefits Area -->
        <asp:Repeater ID="RepeaterHakkimizda" runat="server">
            <ItemTemplate>
                <div class="section-agency-benefit section-pt section-pb">
                    <div class="container">
                        <div class="row align-items-center">
                            <div class="col-lg-6">
                                <div class="agency-benefits">
                                    <div class="content">

                                        <div class="section-title title-2">
                                            <h2><%#Eval("Hakkimizda_Baslik")%></h2>
                                        </div>
                                        <p><%#Eval("Hakkimizda_Kisa_Metin")%></p>


                                        <a href="<%#Eval("Hakkimizda_Url")%>" class="btn contact-btn mt-30 btn-circle">Devamını Oku...</a>
                                    </div>
                                </div>
                            </div>
                            <div class="col-lg-6">
                                <div class="agency-thumb">
                                    <div class="thumb">
                                        <img src="<%#Eval("Hakkimizda_Resim_Url")%>" alt="Agency Images">
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

        <!-- End Agency Benefits Area -->

        <!-- Start Service Style-->
        <div class="section-service bg-gray section-pt section-pb-90">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="section-title text-center">
                            <h2 id="HizmetlerBaslikH" runat="server">Our Services</h2>
                            <p id="HizmetlerMetin" runat="server">Lorem Lorem Lorem ipsum dolor sit amet, consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore</p>
                        </div>
                    </div>
                </div>
                <div class="row cln-service-activation poss_relative">
                    <asp:Repeater ID="RepeaterHizmetler" runat="server">
                        <ItemTemplate>
                            <div class="col-lg-12">
                                <!-- Start Single Service -->
                                <div class="service text-center service-2 padding-none cleaning-service mb-30">
                                    <div class="thumb">
                                        <a href='<%# string.Format("Hizmet-Detay/{0}-{1}",Eval("Hizmet_Sayfa_Url").ToString(),Eval("Hizmet_İd").ToString()) %> '>
                                            <img src="<%#Eval("Hizmet_Resim_Url")%>" alt="service img">
                                        </a>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    </div>
                                    <div class="content">
                                        <h4><a href='<%# string.Format("Hizmet-Detay/{0}-{1}",Eval("Hizmet_Sayfa_Url").ToString(),Eval("Hizmet_İd").ToString()) %> '><%#Eval("Hizmet_Adi")%></a></h4>

                                         <%# (Eval("Hizmet_Kisa_Aciklama").ToString().Length>150)?Eval("Hizmet_Kisa_Aciklama").ToString().Substring(0,150)+"...":Eval("Hizmet_Kisa_Aciklama").ToString() %>


                                        <a class="readmore_btn btn-transparent" href='<%# string.Format("Hizmet-Detay/{0}-{1}",Eval("Hizmet_Sayfa_Url").ToString(),Eval("Hizmet_İd").ToString()) %> '>Devamını Göster...</a>
                                    </div>
                                </div>
                                <!-- End Single Service -->
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>

                </div>
                <div class="text-center">
                    <asp:LinkButton ID="LinkButton1" CssClass="btn text-center container" runat="server" OnClientClick="/Hizmetler" Width="200" PostBackUrl="/Hizmetler">Tüm Hizmetler</asp:LinkButton>
                </div>


            </div>

        </div>
        <!-- End Service Style-->

        <!-- Start Choose Us Area -->
        <div class="reapir-choose-us section-ptb">
            <div class="container">
                <div class="row align-items-center">
                    <div class="col-lg-6 col-md-12 col-sm-12 col-12">
                        <div class="reapir-choose-inner">
                            <div class="section-title title-2 ">
                                <h2 id="ayricalikbaslik"  runat="server">Why  Us</h2>
                            </div>
                            <div class="choose-resone-inner ">

                                <asp:Repeater ID="RepeaterAyricalikAlt" runat="server">
                                    <ItemTemplate>
                                        <p><%#Eval("Ayricalik_Genel_Kisa_Aciklama")%></p>

                                        <!-- Start Single Service -->
                                        <div class="service text-left service-6 reapir-service mt-30">
                                            <div class="icons">
                                                <img src="<%#Eval("Ayricalik_İcon_Url")%>" alt="service icons">
                                            </div>
                                            <div class="content">
                                                <h4><%#Eval("Ayricalik_Adi")%></h4>
                                                <p><%#Eval("Ayricalik_Metin")%> </p>
                                            </div>
                                        </div>
                                        <!-- End Single Service -->
                                    </ItemTemplate>
                                </asp:Repeater>



                            </div>
                        </div>
                    </div>
                    <div class="col-lg-6 col-md-12 col-sm-12 col-12">

                        <div class="section-title title-2 pb-3">
                            <h2>Bizimle İletişime Geçin</h2>
                        </div>



                        <div class="well well-sm">
                            <div class="form-horizontal ">
                                <fieldset>
                                    <legend class="text-center bold">Formu Doldurarak Bizimle İletişime Geçebilirsiniz</legend>

                                    <!-- Name input-->
                                    <div class="form-group">
                                        <label class="col-md-4 control-label bold" for="name">Adınız ve Soyadınız</label>
                                        <div class="col-md-9">
                                            <asp:TextBox CssClass="form-control" ID="TextBoxAdSoyad" runat="server"></asp:TextBox>

                                        </div>
                                    </div>

                                    <!-- Email input-->
                                    <div class="form-group">
                                        <label class="col-md-4 control-label bold" for="email">E-Posta Adresiniz</label>
                                        <div class="col-md-9">
                                            <asp:TextBox CssClass="form-control" ID="TextBoxEMail" runat="server"></asp:TextBox>

                                        </div>
                                    </div>

                                    <!-- Message body -->
                                    <div class="form-group">
                                        <label class="col-md-4  bold control-label" for="message">Mesajınız</label>
          
                                        <div class="auto-style1">
                                            <asp:TextBox TextMode="MultiLine" Height="250" CssClass="form-control" ID="TextBoxMesaj" runat="server"></asp:TextBox>

                                        </div>
                                    </div>

                                    <!-- Form actions -->
                                    <div class="form-group">
                                        <div class="col-md-12 ">
                                            <asp:Button CssClass="btn btn-primary" ID="ButtonGonder" runat="server" Text="Gönder" OnClick="ButtonGonder_Click" />

                                        </div>
                                    </div>
                                </fieldset>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
        <!-- End Choose Us Area -->



        <div class="section-team section-pt section-pb-90 bg-gray">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="section-title text-center">
                            <h2 id="EkipSayfaBaslik" runat="server">Our Guards  </h2>                     <p id="ekipsayfaaciklama" runat="server">Lorem ipsum dolor sit amet, consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore</p>
                        </div>
                    </div>
                </div>
                <!-- Start Team Area -->
                <div class="row">
                    <asp:Repeater ID="RepeaterEkip" runat="server">
                        <ItemTemplate>
                            <!-- Start Single Team -->
                            <div class="col-xl-4 col-lg-4 col-md-6 col-sm-12 col-12">
                                <div class="team team-8 mb-30">
                                    <div class="thumb">
                                       
                                            <img src="<%#Eval("Ekip_Uye_Resim_Url")%>" alt="team img">
                                        
                                    </div>
                                    <div class="team-info">
                                        <div class="content">
                                            <h4><%#Eval("Ekip_Uye_Adi")%></h4>
                                            <span><%#Eval("Ekip_Uye_Gorevi")%></span>
                                        </div>
                                        <ul class="social-network social-net-2">
                                            <li><a class="facebook" href="<%#Eval("Sosyal_Medya_Url_Facebook")%>"><i class="fa fa-facebook"></i></a></li>
                                            <li><a class="twitter" href="<%#Eval("Sosyal_Medya_Url_Twitter")%>"><i class="fa fa-twitter"></i></a></li>
                                            <li><a class="google-plus" href="<%#Eval("Sosyal_Medya_Url_İnstagram")%>"><i class="fa fa-google-plus"></i></a></li>
                                            <li><a class="vimeo" href="<%#Eval("Sosyal_Medya_Url_Diger")%>"><i class="fa fa-vimeo"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <!-- End Single Team -->
                        </ItemTemplate>
                    </asp:Repeater>


                </div>
                <!-- End Team Area -->
            </div>

        </div>
        <!-- End Team Style -->

        <!-- Start Post Carousel Style-->
        <div class="section-post-carousel section-pt section-pb-90">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="section-title text-center">
                            <h2 id="BlogAnaBasligi" runat="server">Latest Blog</h2>
                            <p id="BlogAltBasligi" runat="server">Lorem ipsum dolor sit amet, consectetur adipisicing elit sed do eiusmod tempor incididunt ut labores</p>
                        </div>
                    </div>
                </div>
                <div class="row post-carousel-wrapper post-carousel-active-5 ">


                    <asp:Repeater ID="RepeaterBlog" runat="server">
                        <ItemTemplate>
                            <div class="col-lg-12">
                                <!-- Start Single Post -->
                                <div class="post-carousel ">
                                    <div class="thumb">
                                        <a href='<%# string.Format("Makale/{0}-{1}",Eval("Blog_Url").ToString(),Eval("Blog_Id").ToString()) %> '>
                                            <img src="<%#Eval("Blog_Kucuk_Resim_Url")%>" alt="elementor">
                                        </a>
                                    </div>
                                    <div class="ptc-content">
                                        <h4><a href='<%# string.Format("Makale/{0}-{1}",Eval("Blog_Url").ToString(),Eval("Blog_Id").ToString()) %> '><%#Eval("Blog_Yazi_Basligi")%></a></h4>
                                        <ul class="meta d-flex">
                                            <li><a href="#"><i class="zmdi zmdi-calendar-check"></i><%#Eval("Blog_Yayinlanma")%></a></li>
                                            <li><i class="zmdi zmdi-account-calendar"></i>By : <a href="#"><%#Eval("Blog_Yazari")%></a></li>
                                        </ul>
                                        <p>
                                                 <%# (Eval("Blog_Yazi_Onu").ToString().Length>150)?Eval("Blog_Yazi_Onu").ToString().Substring(0,150)+"...":Eval("Blog_Yazi_Onu").ToString() %>


                                            
                                        </p>
                                        <div class="post-btn">
                                            <a class="readmore-btn btn btn-circle" href='<%# string.Format("Makale/{0}-{1}",Eval("Blog_Url").ToString(),Eval("Blog_Id").ToString()) %> '>Devamını Okl...</a>
                                        </div>
                                    </div>
                                </div>
                                <!-- End Single Post -->
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>




                </div>

            </div>
             <div class="text-center">
                    <asp:LinkButton ID="LinkButton2" CssClass="btn text-center mt-5 container" runat="server" OnClientClick="/Hizmetler" Width="200" PostBackUrl="/Blog">Tüm Yazılar</asp:LinkButton>
                </div>
        </div>
        <!-- End Post Carousel  Style-->

    </main>
    <!--// Page Conttent -->
</asp:Content>

