<%@ Page Title="Quiero ganar!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div class="container">
            <div class="form-group" data-toggle="validator">
                <label for="txbVoucher"></label>
                <asp:TextBox runat="server" type="text" CssClass="form-control" id="txbVoucher" placeholder="Código del voucher" required="required" />  
            </div>
            <asp:Button Text="Siguiente" runat="server" type="submit" cssClass="btn btn-dark" aria-describedby="Voucher" id="btnSiguiente" OnClick="btnSiguiente_Click"/>

            <!-- Bootstrap Modal -->
            <div class="modal" id="myModal" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                <div class="modal-dialog modal-dialog-centered">
                    <asp:UpdatePanel ID="upModal" runat="server" ChildrenAsTriggers="false" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h4 class="modal-title"><asp:Label ID="lblModalTitle" runat="server" Text=""></asp:Label></h4>
                                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                                </div>
                                <div class="modal-body">
                                    <asp:Label ID="lblModalBody" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="modal-footer">
                                    <button class="btn btn-info" data-dismiss="modal" aria-hidden="true">Aceptar</button>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>

        </div>
</asp:Content>
