<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="WebForms.Error" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="alert alert-danger" role="alert" style="margin-top: 10px">
        <p>
            Ups! algo salió mal...
            Por favor, informá lo siguiente al administrador del sitio:
        </p>
        <p>
            <% = Session["Error" + Session.SessionID] %>
        </p>
    </div>

    <div class="embed-responsive embed-responsive-16by9" style="margin-top: 10px">
        <iframe class="embed-responsive-item" src="https://www.youtube.com/embed/dQw4w9WgXcQ?autoplay=1&mute=1"></iframe>
    </div>

</asp:Content>
