<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IngresoDNI.aspx.cs" Inherits="WebForms.IngresoDNI" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-group" style="margin-top: 10px">
        <label for="exampleInputEmail1">DNI</label>
        <asp:TextBox runat="server" type="number" CssClass="form-control" ID="txbDNI" placeholder="Ingresá tu DNI" required="required" />
        <div style="margin-top: 20px">
            <asp:RegularExpressionValidator ID="rev1" runat="server" SetFocusOnError="True"
                ErrorMessage="El DNI debe tener entre 8 y 9 dígitos" Display="Dynamic"
                ControlToValidate="txbDNI" ValidationExpression="^.{8,9}$$" CssClass="alert alert-warning" />
        </div>

        <small id="dniHelp" class="form-text text-muted">Si aún no estás registrado te vamos a redireccionár al formulario de registro</small>
        <asp:Button Text="Siguiente" runat="server" type="submit" CssClass="btn btn-dark" ID="btnSiguiente" Style="margin-top: 10px" OnClick="btnSiguiente_Click" />
    </div>

</asp:Content>
