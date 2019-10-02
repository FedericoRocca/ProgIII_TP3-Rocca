<%@ Page Title="Quiero ganar!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="WebForms.Premios" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div class="container">
            <div class="card-group">

                <div class="card" style="width: 18rem;">
                    <img src="https://img.culturacolectiva.com/content/2015/11/cama-para-solteros-high.png" class="card-img-top img-fluid" alt="Cama para solteros"/>
                    <div class="card-body d-flex flex-column">
                        <h5 class="card-title mt-auto">Cama para solteros</h5>
                        <p class="card-text mt-auto">Una cómoda cama para que puedas llorar ante la inexorable soledad en la que te encontrás sumido</p>
                        <asp:LinkButton Text="Lo quiero!" CssClass="btn btn-primary mt-auto" id="btnPremioUno" runat="server" />
                    </div>
                </div>

                <div class="card" style="width: 18rem;">
                    <img src="https://statics.memondo.com/p/99/gifs/2016/02/GIF_252014_c9bddbd0c6514522966a39e5237ce77e_creo_deberian_mejorar_el_robot_maquillador_a_no_ser_que_quieras_parecer_el_joker_thumb_fb.jpg?cb=9902057" class="card-img-top img-fluid" alt="Robot maquillador">
                    <div class="card-body d-flex flex-column">
                        <h5 class="card-title mt-auto">Robot maquillador</h5>
                        <p class="card-text mt-auto">Para que puedas presumir ante tus amigas en esas noches de fiesta que sabes que no vas a recordar al día siguiente</p>
                        <asp:LinkButton Text="Lo quiero!" CssClass="btn btn-primary mt-auto" id="btnPremioDos" runat="server" />
                    </div>
                </div>

                <div class="card" style="width: 18rem;">
                    <img src="http://i.imgur.com/L2gASwt.jpg" class="card-img-top img-fluid" alt="Set de cubiertos">
                    <div class="card-body d-flex flex-column">
                        <h5 class="card-title mt-auto">Set de cubiertos</h5>
                        <p class="card-text mt-auto">¿Para que necesitás dietas, gimnasio y hábitos saludables cuando directamente no vas a poder comer?</p>
                        <asp:LinkButton Text="Lo quiero!" CssClass="btn btn-primary mt-auto" id="btnPremioTres" runat="server" />
                    </div>
                </div>

            </div>
        </div>
</asp:Content>