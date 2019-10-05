<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IngresoDNI.aspx.cs" Inherits="WebForms.IngresoDNI" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-group" style="margin-top: 10px">
        <label for="exampleInputEmail1">DNI</label>
        <asp:TextBox runat="server" type="number" CssClass="form-control" ID="txbDNI" placeholder="Ingresá tu DNI" required="required" />
        <small id="dniHelp" class="form-text text-muted">Si aún no estás registrado te vamos a redireccionár al formulario de registro</small>
        <asp:Button Text="Siguiente" runat="server" type="submit" CssClass="btn btn-dark" ID="btnSiguiente" Style="margin-top: 10px" OnClick="btnSiguiente_Click" />
    </div>

</asp:Content>
