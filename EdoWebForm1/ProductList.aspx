<%@ Page Title="Prodotti trovati" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="EdoWebForm1._ProductList" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>:</h2>
    <div class="container"/>
    <ul class="list-group">
        <!--qua ci va il foreach-->
            <li class="list-group-item">
                <span class="badge">
                    <!--badge-->
                </span>
                <!--nome e descrizione-->
            </li>
    </ul>
</asp:Content>
