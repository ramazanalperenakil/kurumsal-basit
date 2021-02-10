<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Kategori.aspx.cs" Inherits="Kategori" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1">
        <ItemTemplate>
              <section>
        <div class="container py-3">
            <div class="card">
                <div class="row ">
                    <div class="col-md-4">
                        <img src="<%#Eval("Blog_Kucuk_Resim_Url")%>" class="w-100">
                    </div>
                    <div class="col-md-8 px-3">
                        <div class="card-block px-3">
                            <h4 class="card-title"><%#Eval("Blog_Yazi_Basligi")%></h4>
                            
                            <p class="card-text"><%#Eval("Blog_Yazi_Onu")%></p>
                            <a href='<%# string.Format("../Makale/{0}-{1}",Eval("Blog_Url").ToString(),Eval("Blog_Id").ToString()) %> ' class="btn btn-primary">Devamını Oku...</a>
                        </div>
                    </div>

                </div>
            </div>
        </div>
        </div>
    </section>
        </ItemTemplate>
    </asp:ListView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:ConnectionString2A %>' SelectCommand="SELECT [Blog_Id], [Blog_Kucuk_Resim_Url], [Kategori_Id], [Blog_Url], [Blog_Yazi_Onu], [Blog_Yazi_Basligi] FROM [blog] WHERE ([Kategori_Id] = @Kategori_Id)">
        <SelectParameters>
            <asp:RouteParameter RouteKey="Kategori_Id" Name="Kategori_Id" Type="Int32"></asp:RouteParameter>
        </SelectParameters>
    </asp:SqlDataSource>


  <div class="container" style="text-align: center">
                <asp:DataPager ID="DataPager1" PagedControlID="ListView1" PageSize="2" runat="server" ViewStateMode="Inherit">
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
  
</asp:Content>

