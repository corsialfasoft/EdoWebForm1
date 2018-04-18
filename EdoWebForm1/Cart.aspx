<%@ Page Title="Carrellino" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="EdoWebForm1._Cart" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>Ecco il tuo carrello della spesa</h3>
    <br />
    <div class="text-warning">
        <%=Message %>
        <br />
    </div>
    <%if(prodotti!=null){
        foreach(var p in prodotti){ %>
            <div class="container"/>
            <div class="row">
                <div class="col-md-2">
                    <strong>Codice Prodotto:</strong>
                    <%=p.Id%>
                </div>
                <div class="col-md-2">
                    <strong>Descrizione:</strong>
                    <%=p.Nome%>
                </div>
                <div class="col-md-2">
                    <strong>Quantita:</strong>
                    <%=p.QuantitaRichiesta%>
                </div>
            </div>
      <%}
      } %>
    <br />
    <asp:Button class="btn btn-primary" OnClick="Invia" runat="server" text="Invia"></asp:Button>
    <a class="btn btn-primary" runat="server" href="~/SearchProduct">Annulla</a>
</asp:Content>
