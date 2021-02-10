<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="blog.aspx.cs" Inherits="blog" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">



    <!-- Page Conttent -->
    <main class="page-content">

        <!-- Start Post Carousel Style-->
        <div class="section-post-carousel section-pt section-pb-90">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="section-title text-center">
                            <asp:Repeater ID="RepeaterBlogUst" runat="server">
                                <ItemTemplate>
                                 
                                    <h2><%#Eval("Blog_Ana_Baslik")%></h2>
                                    <p>   <%# (Eval("Blog_Kisa_Aciklama").ToString().Length>250)?Eval("Blog_Kisa_Aciklama").ToString().Substring(0,250)+"...":Eval("Blog_Kisa_Aciklama").ToString() %></p>
                                </ItemTemplate>
                            </asp:Repeater>

                        </div>
                    </div>
                </div>
                <div class="row">
                    <asp:ListView ID="ListViewBlog" runat="server" DataSourceID="SqlDataSource1">
                        <ItemTemplate>
                            <div class="col-lg-4 col-md-6 col-sm-12">
                                <!-- Start Single Post -->
                                <div class="post-carousel mb-30">
                                    <div class="thumb">
                                        <a href='<%# string.Format("Makale/{0}-{1}",Eval("Blog_Url").ToString(),Eval("Blog_Id").ToString()) %> '>
                                            <img src="<%#Eval("Blog_Kucuk_Resim_Url")%>" alt="elementor">
                                        </a>
                                        &nbsp;
                                    </div>
                                    <div class="ptc-content">
                                        <h4><a href='<%# string.Format("Makale/{0}-{1}",Eval("Blog_Url").ToString(),Eval("Blog_Id").ToString()) %> '><%#Eval("Blog_Yazi_Basligi")%></a></h4>
                                        <ul class="meta d-flex">
                                            <li><i class="zmdi zmdi-calendar-check"></i><%#Eval("Blog_Yayinlanma")%></li>
                                            <li><i class="zmdi zmdi-account-calendar"></i>By : <%#Eval("Blog_Yazari")%></li>
                                        </ul>
                                        <p>
                                               <%# (Eval("Blog_Yazi_Onu").ToString().Length>150)?Eval("Blog_Yazi_Onu").ToString().Substring(0,150)+"...":Eval("Blog_Yazi_Onu").ToString() %>
                                           
                                        </p>
                                        <div class="post-btn">
                                            <a class="readmore-btn btn btn-circle" href='<%# string.Format("Makale/{0}-{1}",Eval("Blog_Url").ToString(),Eval("Blog_Id").ToString()) %> '>Devamını Oku...</a>
                                        </div>
                                    </div>
                                </div>
                                <!-- End Single Post -->
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                    <br />

                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:ConnectionString2A %>' SelectCommand="SELECT [Blog_Id], [Blog_Kucuk_Resim_Url], [Blog_Yazari], [Blog_Yayinlanma], [Blog_Duzenlenme], [Blog_Yazi_Basligi], [Blog_Yazi_Onu],[Blog_Url] FROM [blog] WHERE Blog_Ana_Baslik  IS  NULL"></asp:SqlDataSource>


                </div>


            </div>
            <div class="container" style="text-align: center">
                <asp:DataPager ID="DataPager1" PagedControlID="ListViewBlog" PageSize="6" runat="server" ViewStateMode="Inherit">
                    <Fields>

                        <asp:NextPreviousPagerField ButtonType="Link" ShowFirstPageButton="True" ButtonCssClass="btn btn-xs" ShowNextPageButton="False" ShowPreviousPageButton="False"></asp:NextPreviousPagerField>


                        <asp:NumericPagerField NumericButtonCssClass="bold btn btn-medium btn-circle " PreviousPageText="Diğer" CurrentPageLabelCssClass="btn  btn-xs " NextPageText="Diğer" NextPreviousButtonCssClass=" btn btn-circle btn-xs"></asp:NumericPagerField>
                        
                    </Fields>

                    <Fields>

                        <asp:NextPreviousPagerField ButtonCssClass="btn btn-xs" />
                        <asp:NextPreviousPagerField ButtonType="Link" ShowLastPageButton="True" ButtonCssClass="btn btn-xs" ShowNextPageButton="False" ShowPreviousPageButton="False"></asp:NextPreviousPagerField>
                    </Fields>
                </asp:DataPager>

            </div>
        </div>
        <!-- End Post Carousel  Style-->

    </main>
    <!--// Page Conttent -->

</asp:Content>

