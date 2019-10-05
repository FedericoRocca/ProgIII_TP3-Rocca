<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="WebForms.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <% 
        if ( Session["Cliente" + Session.SessionID] == null)
        {
                string _DNI = Session["DNICliente" + Session.SessionID].ToString();
        %>


        <div class="row" style="margin-top: 10px">
            <div class="col">
                <small class="form-text text-info">El registro es por una única vez.</small>
                <label for="exampleInputEmail1">DNI</label>
                <input type="number" class="form-control" id="txbDNI" placeholder="DNI" readonly value="<% = _DNI %>" required="required">
            </div>
        </div>

        <div class="row" style="margin-top: 10px">

            <div class="col">
                <label for="exampleInputEmail1">Nombre</label>
                <input type="text" class="form-control" id="txbNombre" placeholder="Nombre" required="required">
            </div>

            <div class="col">
                <label for="exampleInputEmail1">Apellido</label>
                <input type="text" class="form-control" id="txbApellido" placeholder="Apellido" required="required">
            </div>

        </div>

        <div class="row" style="margin-top: 10px">
            <div class="col">
                <label for="exampleInputEmail1">E-Mail</label>
                <input type="email" class="form-control" id="txbEmail" placeholder="Email" required="required">
            </div>
        </div>

        <div class="row" style="margin-top: 10px">

            <div class="col">
                <label for="exampleInputEmail1">Dirección</label>
                <input type="text" class="form-control" id="txbDireccion" placeholder="Dirección" required="required">
            </div>

            <div class="col">
                <label for="exampleInputEmail1">Ciudad</label>
                <input type="text" class="form-control" id="txbCiudad" placeholder="Ciudad" required="required">
            </div>

            <div class="col">
                <label for="exampleInputEmail1">Código postal</label>
                <input type="number" class="form-control" id="txbCodigoPostal" placeholder="Código postal" required="required">
            </div>
        </div>

        <%
        }
        else
        {

                Dominio.Cliente reg = new Dominio.Cliente();
                reg = (Dominio.Cliente)Session["Cliente" + Session.SessionID];

        %>
        <div class="row" style="margin-top: 10px">
            <div class="col">
                <label for="exampleInputEmail1">DNI</label>
                <input type="number" class="form-control" id="txbDNI" placeholder="DNI" readonly value="<% = reg.DNI %>" required="required">
            </div>
        </div>

        <div class="row" style="margin-top: 10px">

            <div class="col">
                <label for="exampleInputEmail1">Nombre</label>
                <input type="text" class="form-control" id="txbNombre" placeholder="Nombre"  value="<% = reg.Nombre %>" required="required">
            </div>

            <div class="col">
                <label for="exampleInputEmail1">Apellido</label>
                <input type="text" class="form-control" id="txbApellido" placeholder="Apellido"  value="<% = reg.Apellido %>" required="required">
            </div>

        </div>

        <div class="row" style="margin-top: 10px">
            <div class="col">
                <label for="exampleInputEmail1">E-Mail</label>
                <input type="email" class="form-control" id="txbEmail" placeholder="Email"  value="<% = reg.Email %>" required="required">
            </div>
        </div>

        <div class="row" style="margin-top: 10px">

            <div class="col">
                <label for="exampleInputEmail1">Dirección</label>
                <input type="text" class="form-control" id="txbDireccion" placeholder="Dirección"  value="<% = reg.Direccion %>" required="required">
            </div>

            <div class="col">
                <label for="exampleInputEmail1">Ciudad</label>
                <input type="text" class="form-control" id="txbCiudad" placeholder="Ciudad"  value="<% = reg.Ciudad %>" required="required">
            </div>

            <div class="col">
                <label for="exampleInputEmail1">Código postal</label>
                <input type="number" class="form-control" id="txbCodigoPostal" placeholder="Código postal"  value="<% = reg.CodigoPostal %>" required="required">
            </div>
        </div>
        <%
        }
        %>



    <asp:Button Text="Confirmar" runat="server" type="submit" CssClass="btn btn-dark" ID="btnSiguiente" Style="margin-top: 20px" />

</asp:Content>
