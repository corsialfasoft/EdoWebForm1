<%@ Page Title="Dettagli del prodotto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="EdoWebForm1._ProductDetail" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <div class="container">
        <!--qua ci va la form-->
            <div>
                <strong>Codice Prodotto: </strong>
                <!--codice-->
            </div>
            <div>
                <strong>Descrizione: </strong>
                <!--descrizione-->
            </div>
            <div>
                <strong>Inserisci:</strong>
                <!--campi da compilare con la quantita-->
                <asp:Button OnClick="AggiungiProdottoACarrello" class="btn btn-primary" runat="server" Text="Aggiungi al carrello"/>
                <a class="btn btn-primary" runat="server" href="~/Home">Annulla</a>
            </div>
    </div>
</asp:Content>
