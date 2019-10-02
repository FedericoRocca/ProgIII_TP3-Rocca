<%@ Page Title="Quiero ganar!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <nav class="navbar navbar-dark bg-dark">
            <span class="navbar-brand mb-0 h1">Quiero ganar!</span>
        </nav>

        <div class="container">
            <div class="form-group" data-toggle="validator">
                <label for="txbVoucher"></label>
                <input type="text" class="form-control" id="txbVoucher" placeholder="Código del voucher" required="required">
            </div>
            <asp:Button Text="Siguiente" runat="server" type="submit" cssClass="btn btn-dark" aria-describedby="Voucher" id="btnSiguiente" OnClick="btnSiguiente_Click"/>

        </div>
</asp:Content>
