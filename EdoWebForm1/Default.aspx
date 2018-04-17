<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EdoWebForm1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div class="jumbotron">
    <h1>Logistica Merci</h1>
        <p class="lead">Servizi per la gestione logistica della richiesta merci</p>
</div>

<div class="row">
    <div class="col-md-6">
        <h4>Clicca su Ricerca Prodotto per iniziare a ordinare le merci!</h4>        
        <a class="btn btn-primary btn-lg" runat="server" href="~/SearchProduct">Ricerca Prodotto</a>
    </div>
</div>
</asp:Content>
