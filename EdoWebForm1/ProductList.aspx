<%@ Page Title="Prodotti trovati" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="EdoWebForm1._ProductList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>:</h2>
    <br />
    <div class="container"/>
    <div class="table" style="margin-top:25px">
        <asp:Table ID="Table1" runat="server" width="100%"
            CellPadding="10"
            GridLines="None"
            HorizontalAlign="Center">
        </asp:Table>
    </div>
</asp:Content>
