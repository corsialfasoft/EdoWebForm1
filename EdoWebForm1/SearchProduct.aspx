<%@ Page Title="Cerca Prodotto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchProduct.aspx.cs" Inherits="EdoWebForm1._SearchProduct" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>Cerca il tuo prodotto</h3>
    <br />
    <div class="text-warning">
        <%=Message %>
        <br />
    </div>
    <div class="row">
        <div class="col-md-2">
            <label>Codice:</label>
        </div>
        <div class="col-md-3">
           <asp:TextBox class="form-control" placeholder="Codice" runat="server" ID="Codice"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2">
            <label>Descrizione:</label>
        </div>
        <div class="col-md-3">
            <asp:TextBox class="form-control" placeholder="descrizione anche parziale" runat="server" ID="Descrizione"></asp:TextBox>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-md-2">
            <asp:Button class="btn btn-primary" OnClick="CercaProdotto" runat="server" Text="Cerca"/>
        </div>
    </div>
</asp:Content>
