<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="hizmetdetay.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Page Conttent -->
    <main class="page-content">

        <!-- Start Service Style-->
        <div class="section-service bg-gray pt-5">
            <div class="container">
                <div class="row">
                     <div class="col-md-12 col-lg-9">
                        <!-- Tab panes -->
                        <div class="tab-content dashboard-content">
                            <div class="" id="">
                                <div class="service-details-content">

                                    <div class="row">
                                        <div class="col-lg-12">
                                            <div class="service-details-lg-image">
                                                <asp:Repeater ID="RepeaterHizmetResim" runat="server">
                                                    <ItemTemplate>
                                                      
                                                        <img src="<%#Eval("Hizmet_Detay_Resim_Url")%>" alt="">
                                                    </ItemTemplate>
                                                </asp:Repeater>

                                            </div>
                                            <div class="service-details-cont mt-30">
                                                <asp:Repeater ID="RepeaterIcerik" runat="server">
                                                    <ItemTemplate>
                                                        <h1 class="service-title"><%#Eval("Hizmet_Adi")%></h1>
                                                        <p><%#Eval("Hizmet_Kisa_Aciklama")%></p>
                                                        <p><%#Eval("Hizmet_Uzun_Aciklama")%></p>
                                                    </ItemTemplate>
                                                </asp:Repeater>


                                            </div>
                                        </div>
                                    </div>



                                </div>
                            </div>
                           
                        </div>
                    </div>
                    <div class="col-md-12 col-lg-3">
                        <!-- Nav tabs -->
                        <ul role="tablist" class="nav flex-column service-details-menu dashboard-list pt-4">
                            <asp:Repeater ID="RepeaterDigerHizmetler" runat="server">
                                <ItemTemplate>
                                    <li><a href='<%# string.Format("../Hizmet-Detay/{0}-{1}",Eval("Hizmet_Sayfa_Url").ToString(),Eval("Hizmet_İd").ToString()) %> ' data-toggle="tab" class="nav-link"><%#Eval("Hizmet_Adi")%></a></li>
                                </ItemTemplate>
                            </asp:Repeater>
                            
                           
                        </ul>
                    </div>
                   
                </div>
            </div>
        </div>
        <!-- End Service Style-->


    </main>
    <!--// Page Conttent -->

</asp:Content>

