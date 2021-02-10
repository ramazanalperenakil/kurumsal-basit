<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="hizmetler.aspx.cs" Inherits="hizmetler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <!-- Page Conttent -->
    <main class="page-content">

        <!-- Start Service Style-->
        <div class="section-service bg-gray section-pt section-pb-90">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="section-title text-center">
                            <asp:Repeater ID="RepeaterHizmetlerUst" runat="server">
                                <ItemTemplate>
                                    <h2><%#Eval("Hizmetler_Sayfa_Baslik")%></h2>
                                    <p><%#Eval("Hizmetler_Sayfa_Kisa_Aciklama")%></p>
                                </ItemTemplate>
                            </asp:Repeater>

                        </div>
                    </div>
                </div>
                <div class="row">
                    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
                        <ItemTemplate>
                            <div class="col-lg-4 col-md-6 col-12">
                                <!-- Start Single Service -->
                                <div class="service text-center service-2 padding-none cleaning-service mb-30 ">
                                    <div class="thumb">
                                        <a href='<%# string.Format("Hizmet-Detay/{0}-{1}",Eval("Hizmet_Sayfa_Url").ToString(),Eval("Hizmet_İd").ToString()) %> '>
                                            <img src="<%#Eval("Hizmet_Resim_Url")%>" alt="service img">
                                        </a>
                                    </div>
                                    <div class="content">
                                        <h4><a href='<%# string.Format("Hizmet-Detay/{0}-{1}",Eval("Hizmet_Sayfa_Url").ToString(),Eval("Hizmet_İd").ToString()) %> '><%#Eval("Hizmet_Adi")%></a></h4>
                                        <p><%#Eval("Hizmet_Kisa_Aciklama")%></p>
                                        <a class="readmore_btn btn-transparent" href='<%# string.Format("Hizmet-Detay/{0}-{1}",Eval("Hizmet_Sayfa_Url").ToString(),Eval("Hizmet_İd").ToString()) %> '>Devamını Göster...</a>
                                    </div>
                                </div>
                                <!-- End Single Service -->
                            </div>
                        </ItemTemplate>
                    </asp:ListView>







                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:ConnectionString2A %>' SelectCommand="SELECT [Hizmet_İd], [Hizmet_Resim_Url], [Hizmet_Adi], [Hizmet_Kisa_Aciklama], [Hizmet_Uzun_Aciklama], [Hizmet_Sayfa_Url] FROM [hizmetler] WHERE Hizmet_Resim_Url  IS NOT NULL"></asp:SqlDataSource>
                </div>
            </div>
               <div class="container" style="text-align: center">
                <asp:DataPager ID="DataPager1" PagedControlID="ListView1" PageSize="6" runat="server" ViewStateMode="Inherit">
                    <Fields>

                        <asp:NextPreviousPagerField ButtonType="Link" ShowFirstPageButton="True"  ButtonCssClass=" btn text-white btn-success" ShowNextPageButton="False" ShowPreviousPageButton="False"></asp:NextPreviousPagerField>


                        <asp:NumericPagerField NumericButtonCssClass="bold text-white btn btn-medium btn-circle " PreviousPageText="Diğer" CurrentPageLabelCssClass="btn text-white btn-xs " NextPageText="Diğer" NextPreviousButtonCssClass=" btn text-white btn-circle btn-xs"></asp:NumericPagerField>
                        
                    </Fields>

                    <Fields>

                        <asp:NextPreviousPagerField ButtonCssClass="btn text-white btn-xs" />
                        <asp:NextPreviousPagerField ButtonType="Link" ShowLastPageButton="True" ButtonCssClass="btn text-white btn-xs" ShowNextPageButton="False" ShowPreviousPageButton="False"></asp:NextPreviousPagerField>
                    </Fields>
                </asp:DataPager>

            </div>
        </div>
        <!-- End Service Style-->


    </main>
    <!--// Page Conttent -->


</asp:Content>

