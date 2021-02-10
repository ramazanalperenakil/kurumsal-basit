<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="hakkimizda.aspx.cs" Inherits="hakkimizda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">




    <!-- Page Conttent -->
    <main class="page-content">


        <!-- Start Agency Benefits Area -->
        <div class="section-agency-benefit section-pt section-pb">
            <div class="container">
                <div class="row align-items-center">
                    <div class="col-lg-6">
                        <div class="agency-benefits">
                            <div class="content">
                                <asp:Repeater ID="RepeaterHakkimizda" runat="server">
                                    <ItemTemplate>
                                          <div class="section-title title-2">
                                    <h2><%#Eval("Hakkimizda_Baslik")%></h2>
                                </div>
                                <p><%#Eval("Hakkimizda_Kisa_Metin")%></p>
                                    </ItemTemplate>
                                </asp:Repeater>
                              



                            </div>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="agency-thumb">
                            <div class="thumb">
                                <asp:Repeater ID="RepeaterHakkimizdaResim" runat="server">
                                    <ItemTemplate>
                                         <img src="<%#Eval("Hakkimizda_Resim_Url")%>" alt="Agency Images">
                                    </ItemTemplate>
                                </asp:Repeater>
                               
                            </div>
                        </div>
                    </div>
                    <div class="pt-5">
                        <asp:Repeater ID="RepeaterHakkimizdaUzun" runat="server">
                            <ItemTemplate>
                               <p><%#Eval("Hakkimizda_Uzun_Metin")%></p>
                            </ItemTemplate>
                        </asp:Repeater>
                       
                    </div>

                </div>
            </div>
        </div>
        <!-- End Agency Benefits Area -->




    </main>
    <!--// Page Conttent -->


</asp:Content>

