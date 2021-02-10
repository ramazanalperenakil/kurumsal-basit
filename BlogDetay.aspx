<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BlogDetay.aspx.cs" Inherits="BlogDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <!-- Page Conttent -->
    <main class="page-content">

        <!-- content-wraper start -->
        <div class="content-wraper section-pb ">
            <div class="container">
                <div class="row">
                    <div class="col-lg-3 order-2 order-lg-2">
                        <!-- blog-widget-wrap start -->
                        <div class="blog-widget-wrap">

                           

                            <!-- blog-widget start -->
                            <div class="blog-widget mt-30">
                                <h5 class="title">Kategoriler</h5>
                                <ul>
                                    <asp:Repeater ID="RepeaterKategoriler" runat="server">
                                        <ItemTemplate>
                                            <li><a href='<%# string.Format("../Kategori/{0}-{1}",Eval("Kategori_Url").ToString(),Eval("Kategori_Id").ToString()) %> '><%#Eval("Kategori_Adi")%></a></li>
                                        </ItemTemplate>
                                    </asp:Repeater>


                                </ul>
                            </div>
                            <!-- blog-widget end -->

                            <!-- blog-widget start -->
                            <div class="widget-blog blog-widget mt-30">
                                <h5 class="title">Son Makaleler</h5>
                                <!-- widget-blog-inner start -->
                                <asp:Repeater ID="RepeaterSonYazilar" runat="server">
                                    <ItemTemplate>
                                        <div class="widget-blog-inner">
                                            <div class="widget-blog-image">
                                                <a href='<%# string.Format("../Makale/{0}-{1}",Eval("Blog_Url").ToString(),Eval("Blog_Id").ToString()) %> '>
                                                    <img src="<%#Eval("Blog_Kucuk_Resim_Url")%>" alt=""></a>
                                            </div>
                                            <div class="widget-blog-content text-left">
                                                <h6><a href='<%# string.Format("../Makale/{0}-{1}",Eval("Blog_Url").ToString(),Eval("Blog_Id").ToString() )%>  '><%#Eval("Blog_Yazi_Basligi")%> </a></h6>

                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>


                                <!-- widget-blog-inner end -->
                            </div>
                            <!-- blog-widget end -->


                        </div>
                        <!-- blog-widget-wrap end -->
                    </div>

                    <div class="col-lg-9 order-1 order-lg-1">
                        <!-- blog-details-wrapper start -->
                        <div class="blog-details-wrapper ">
                            <div class="blog-details-image">
                                <asp:Repeater ID="RepeaterBlogResim" runat="server">
                                    <ItemTemplate>
                                        <h1><%#Eval("Blog_Yazi_Basligi")%></h1>
                                        <img src="<%#Eval("Blog_Buyuk_Resim_Url")%>" alt="">
                                    </ItemTemplate>
                                </asp:Repeater>

                            </div>
                            <div class="postinfo-wrapper">
                                <div class="post-info">
                                    <div class="meta-body">
                                        <ul class="d-flex">
                                            <asp:Repeater ID="RepeaterBilgi" runat="server">
                                                <ItemTemplate>
                                                    <li>By: <a href="#"><%#Eval("Blog_Yazari")%></a></li>
                                                    Y:
                                                    <li><%#Eval("Blog_Yayinlanma")%></li>
                                                    - 
                                                   D:
                                                    <li><%#Eval("Blog_Duzenlenme")%></li>
                                                </ItemTemplate>
                                            </asp:Repeater>

                                        </ul>
                                        <hr />
                                    </div>
                                    <asp:Repeater ID="RepeaterIcerik" runat="server">
                                        <ItemTemplate>
                                            
                                            <h5><%#Eval("Blog_Yazi_Onu")%></h5>
                                           
                                            <hr />
                                            <p><%#Eval("Blog_Yazi")%></p>
                                        </ItemTemplate>
                                    </asp:Repeater>




                                </div>


                            </div>
                        </div>
                        <!-- blog-details-wrapper end -->
                    </div>
                </div>
            </div>
        </div>
        <!-- content-wraper end -->

    </main>
    <!--// Page Conttent -->

</asp:Content>

