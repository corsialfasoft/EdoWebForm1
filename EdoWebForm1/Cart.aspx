<%@ Page Title="Carrellino" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="EdoWebForm1._Cart" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>Ecco il tuo carrello della spesa</h3>
    <div class="container"/>
    <div class="row">
        <div class="col-md-2">
            <strong>Codice Prodotto:</strong>
        </div>
        <div class="col-md-2">
            <strong>Descrizione:</strong>
        </div>
        <div class="col-md-2">
            <strong>Quantita:</strong>
        </div>
    </div>
    <!--qua ci va il foreach-->
    <br />
    <asp:Button class="btn btn-primary" OnClick="Invia" runat="server" text="Invia"></asp:Button>
    <asp:Button class="btn btn-primary" OnClick="Pulisci" runat="server" text="Pulisci"></asp:Button>
    <a class="btn btn-primary" runat="server" href="~/SearchProduct">Annulla</a>
</asp:Content>
