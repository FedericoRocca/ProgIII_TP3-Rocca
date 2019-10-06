<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="WebForms.Premios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container" style="margin-top: 10px; margin-bottom: 10px">
        <div class="card-columns">
            <% foreach (var item in prods)
                { %>

                    <div class="card">
                        <img src="<% = item.URLImagen %>" class="card-img-top" alt=" <% = item.Titulo %>">
                        <div class="card-body">
                            <h5 class="card-title"><% = item.Titulo %></h5>
                            <p class="card-text"><% = item.Descripcion %></p>
                            <a href="IngresoDNI.aspx?prodID=<% = item.ID %>" class="btn btn-primary btn-block">Lo quiero!</a>
                        </div>
                    </div>

                <% } %>
            

        </div>
    </div>
</asp:Content>
