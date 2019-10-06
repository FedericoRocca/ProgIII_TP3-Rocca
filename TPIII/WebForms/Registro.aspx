<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="WebForms.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div class="row" style="margin-top: 10px">
            <div class="col">
                <small class="form-text text-info">El registro es por una única vez.</small>
                <label for="exampleInputEmail1">DNI</label>
                <asp:TextBox runat="server" type="number" cssClass="form-control" id="txbDNI" placeholder="DNI" readonly="true" required="required"/>
            </div>
        </div>

        <div class="row" style="margin-top: 10px">

            <div class="col">
                <label for="exampleInputEmail1">Nombre</label>
                <asp:TextBox runat="server" type="text" cssClass="form-control" id="txbNombre" placeholder="Nombre" required="required"/>
            </div>

            <div class="col">
                <label for="exampleInputEmail1">Apellido</label>
                <asp:TextBox runat="server" type="text" cssClass="form-control" id="txbApellido" placeholder="Apellido" required="required"/>
            </div>

        </div>

        <div class="row" style="margin-top: 10px">
            <div class="col">
                <label for="exampleInputEmail1">E-Mail</label>
                <asp:TextBox runat="server" type="email" cssClass="form-control" id="txbEmail" placeholder="Email" required="required"/>
            </div>
        </div>

        <div class="row" style="margin-top: 10px">

            <div class="col">
                <label for="exampleInputEmail1">Dirección</label>
                <asp:TextBox runat="server" type="text" cssClass="form-control" id="txbDireccion" placeholder="Dirección" required="required"/>
            </div>

            <div class="col">
                <label for="exampleInputEmail1">Ciudad</label>
                <asp:TextBox runat="server" type="text" cssClass="form-control" id="txbCiudad" placeholder="Ciudad" required="required"/>
            </div>

            <div class="col">
                <label for="exampleInputEmail1">Código postal</label>
                <asp:TextBox runat="server" type="number" cssClass="form-control" id="txbCodigoPostal" placeholder="Código postal" required="required"/>
            </div>
        </div>

    <asp:Button Text="Confirmar" runat="server" type="submit" CssClass="btn btn-dark" ID="btnSiguiente" Style="margin-top: 20px" OnClick="btnSiguiente_Click" />

</asp:Content>
