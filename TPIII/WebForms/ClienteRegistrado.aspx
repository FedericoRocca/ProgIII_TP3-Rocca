<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClienteRegistrado.aspx.cs" Inherits="WebForms.ClienteRegistrado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%
        Dominio.Cliente reg = new Dominio.Cliente();
        reg = (Dominio.Cliente)Session["Cliente" + Session.SessionID];

    %>
    <div class="row" style="margin-top: 10px">
        <div class="col">
            <label for="exampleInputEmail1">DNI</label>
            <asp:TextBox runat="server" type="number" CssClass="form-control" ID="txbDNI" placeholder="DNI" ReadOnly="true" value="<% = reg.DNI %>" required="required" />
        </div>
    </div>

    <div class="row" style="margin-top: 10px">

        <div class="col">
            <label for="exampleInputEmail1">Nombre</label>
            <asp:TextBox runat="server" type="text" CssClass="form-control" ID="txbNombre" placeholder="Nombre" value="<% = reg.Nombre %>" required="required" />
        </div>

        <div class="col">
            <label for="exampleInputEmail1">Apellido</label>
            <asp:TextBox runat="server" type="text" CssClass="form-control" ID="txbApellido" placeholder="Apellido" value="<% = reg.Apellido %>" required="required" />
        </div>

    </div>

    <div class="row" style="margin-top: 10px">
        <div class="col">
            <label for="exampleInputEmail1">E-Mail</label>
            <asp:TextBox runat="server" type="email" CssClass="form-control" ID="txbEmail" placeholder="Email" value="<% = reg.Email %>" required="required" />
        </div>
    </div>

    <div class="row" style="margin-top: 10px">

        <div class="col">
            <label for="exampleInputEmail1">Dirección</label>
            <asp:TextBox runat="server" type="text" CssClass="form-control" ID="txbDireccion" placeholder="Dirección" value="<% = reg.Direccion %>" required="required" />
        </div>

        <div class="col">
            <label for="exampleInputEmail1">Ciudad</label>
            <asp:TextBox runat="server" type="text" CssClass="form-control" ID="txbCiudad" placeholder="Ciudad" value="<% = reg.Ciudad %>" required="required" />
        </div>

        <div class="col">
            <label for="exampleInputEmail1">Código postal</label>
            <asp:TextBox runat="server" type="number" CssClass="form-control" ID="txbCodigoPostal" placeholder="Código postal" value="<% = reg.CodigoPostal %>" required="required" />
        </div>
    </div>

    <asp:Button Text="Confirmar" runat="server" type="submit" CssClass="btn btn-dark" ID="btnSiguiente" Style="margin-top: 20px" OnClick="btnSiguiente_Click" />

</asp:Content>
