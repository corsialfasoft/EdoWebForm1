<%@ Page Title="Dettagli del prodotto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="EdoWebForm1._ProductDetail" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <br />
    <div class="text-warning">
        <%=Message %>
        <br />
    </div>
    <div class="container">
            <div>
                <strong>Codice Prodotto: </strong>
            </div>
            <div class="col-sm-8">
                <asp:Label runat="server"><%=prodotto.Id %></asp:Label>
            </div>
            <div>
                <strong>Descrizione: </strong>
            </div>
           <div class="col-sm-8">
                <asp:Label runat="server"><%=prodotto.Nome %></asp:Label>
            </div>
            <div>
                <strong>Giacenza: </strong>
            </div>
            <div class="col-sm-8">
                <asp:Label runat="server"><%=prodotto.Quantita %></asp:Label>
            </div>
            <div>
                <strong>Inserisci quantita' da richiedere:</strong>
            </div>
            <div class="col-sm-8">
                <asp:Label runat="server">
                    <asp:TextBox ID="qta" runat="server"></asp:TextBox>
                </asp:Label>
            </div>
                <asp:Button OnClick="AggiungiProdottoACarrello" class="btn btn-primary" runat="server" Text="Aggiungi al carrello"/>
                <asp:Button OnClick="Annulla" class="btn btn-primary" runat="server" Text="Annulla" />
    </div>
</asp:Content>
