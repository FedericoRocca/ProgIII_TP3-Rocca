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
            <div style="margin-top: 20px">
                <asp:RegularExpressionValidator ID="rev1" runat="server" SetFocusOnError="True"
                    ErrorMessage="El DNI debe tener entre 8 y 9 dígitos" Display="Dynamic"
                    ControlToValidate="txbDNI" ValidationExpression="^.{8,9}$$" CssClass="alert alert-warning" />
            </div>
        </div>
    </div>

    <div class="row" style="margin-top: 10px">

        <div class="col">
            <label for="exampleInputEmail1">Nombre</label>
            <asp:TextBox runat="server" type="text" CssClass="form-control" ID="txbNombre" placeholder="Nombre" value="<% = reg.Nombre %>" required="required" />
            <div style="margin-top: 20px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" SetFocusOnError="True"
                    ErrorMessage="El nombre debe tener entre 1 y 50 dígitos" Display="Dynamic"
                    ControlToValidate="txbNombre" ValidationExpression="^.{1,50}$$" CssClass="alert alert-warning" />
            </div>
        </div>

        <div class="col">
            <label for="exampleInputEmail1">Apellido</label>
            <asp:TextBox runat="server" type="text" CssClass="form-control" ID="txbApellido" placeholder="Apellido" value="<% = reg.Apellido %>" required="required" />
            <div style="margin-top: 20px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" SetFocusOnError="True"
                    ErrorMessage="El apellido debe tener entre 1 y 50 dígitos" Display="Dynamic"
                    ControlToValidate="txbApellido" ValidationExpression="^.{1,50}$$" CssClass="alert alert-warning" />
            </div>
        </div>

    </div>

    <div class="row" style="margin-top: 10px">
        <div class="col">
            <label for="exampleInputEmail1">E-Mail</label>
            <asp:TextBox runat="server" type="email" CssClass="form-control" ID="txbEmail" placeholder="Email" value="<% = reg.Email %>" required="required" />
            <div style="margin-top: 20px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" SetFocusOnError="True"
                    ErrorMessage="El EMail debe tener entre 1 y 100 dígitos" Display="Dynamic"
                    ControlToValidate="txbEmail" ValidationExpression="^.{1,100}$$" CssClass="alert alert-warning" />
            </div>
        </div>
    </div>

    <div class="row" style="margin-top: 10px">

        <div class="col">
            <label for="exampleInputEmail1">Dirección</label>
            <asp:TextBox runat="server" type="text" CssClass="form-control" ID="txbDireccion" placeholder="Dirección" value="<% = reg.Direccion %>" required="required" />
            <div style="margin-top: 20px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" SetFocusOnError="True"
                    ErrorMessage="La dirección debe tener entre 1 y 50 dígitos" Display="Dynamic"
                    ControlToValidate="txbDireccion" ValidationExpression="^.{1,50}$$" CssClass="alert alert-warning" />
            </div>
        </div>

        <div class="col">
            <label for="exampleInputEmail1">Ciudad</label>
            <asp:TextBox runat="server" type="text" CssClass="form-control" ID="txbCiudad" placeholder="Ciudad" value="<% = reg.Ciudad %>" required="required" />
            <div style="margin-top: 20px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" SetFocusOnError="True"
                    ErrorMessage="La ciudad debe tener entre 1 y 50 dígitos" Display="Dynamic"
                    ControlToValidate="txbCiudad" ValidationExpression="^.{1,50}$$" CssClass="alert alert-warning" />
            </div>
        </div>

        <div class="col">
            <label for="exampleInputEmail1">Código postal</label>
            <asp:TextBox runat="server" type="number" CssClass="form-control" ID="txbCodigoPostal" placeholder="Código postal" value="<% = reg.CodigoPostal %>" required="required" />
            <div style="margin-top: 20px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" SetFocusOnError="True"
                    ErrorMessage="El CP debe tener entre 1 y 8 dígitos" Display="Dynamic"
                    ControlToValidate="txbCodigoPostal" ValidationExpression="^.{1,8}$$" CssClass="alert alert-warning" />
            </div>
        </div>
    </div>

    <small class="form-text text-info">Te enviaremos un mail con el detalle de tu participación.</small>

    <asp:Button Text="Confirmar" runat="server" type="submit" CssClass="btn btn-dark" ID="btnSiguiente" Style="margin-top: 20px" OnClick="btnSiguiente_Click" />

</asp:Content>
