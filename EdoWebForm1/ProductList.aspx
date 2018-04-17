<%@ Page Title="Prodotti trovati" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="EdoWebForm1._ProductList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>:</h2>
    <div class="container"/>
    <ul class="list-group">
        <%foreach(){%>
            <li class="list-group-item">
                <span class="badge">
                    <asp:Button OnClick="DettaglioProdotto" runat="server" Text="Dettaglio >>"/>
                </span>
                <!--nome e descrizione-->
            </li>
        <%} %>
    </ul>
</asp:Content>
