using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WebForms
{
    public partial class Registro : System.Web.UI.Page
    {
        string prodID;
        string vouchId;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                txbDNI.Text = Session["DNICliente" + Session.SessionID].ToString();
                prodID = Session["prodID" + Session.SessionID].ToString();
                vouchId = Session["vouchId" + Session.SessionID].ToString();
            }
            catch (Exception ex)
            {
                Session["Error" + Session.SessionID] = ex.Message;
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {

                ClienteNegocio clNegocio = new ClienteNegocio();
                Cliente aux = new Cliente();

                aux.Apellido = txbApellido.Text;
                aux.Ciudad = txbCiudad.Text;
                aux.CodigoPostal = txbCodigoPostal.Text;
                aux.Direccion = txbDireccion.Text;
                aux.DNI = int.Parse(txbDNI.Text);
                aux.Email = txbEmail.Text;
                aux.Nombre = txbNombre.Text;

                if(clNegocio.altaCliente(aux) == false)
                {
                    Session["Error" + Session.SessionID] = "Error al crear el cliente";
                    Response.Redirect("Error.aspx", false);
                }
                else
                {
                    VoucherNegocio vouchNegocio = new VoucherNegocio();
                    ProductoNegocio prodNegocio = new ProductoNegocio();

                    List<Voucher> reg = vouchNegocio.getVoucherByID( Session["IdVoucher" + Session.SessionID].ToString() );
                    reg[0].IdCliente = clNegocio.getCliente(aux.DNI.ToString())[0].ID;
                    reg[0].IdProducto = prodNegocio.getProductoByID(prodID.ToString())[0].ID;
                    vouchNegocio.updateVoucher(reg[0]);

                    MailSender mail = new MailSender("promoquieroganar@gmail.com", "Pr0M0Qu13r0G4naR");
                    mail.sendMail("promoquieroganar@gmail.com", aux.Email.ToString(), "Promoción Quiero Ganar!", "<!DOCTYPE html><html xmlns=\"http://www.w3.org/1999/xhtml\" xmlns:v=\"urn:schemas-microsoft-com:vml\" xmlns:o=\"urn:schemas-microsoft-com:office:office\"><head>  <title></title>  <!--[if !mso]><!-- -->  <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">  <!--<![endif]--><meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\"><meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\"><style type=\"text/css\">  #outlook a { padding: 0; }  .ReadMsgBody { width: 100%; }  .ExternalClass { width: 100%; }  .ExternalClass * { line-height:100%; }  body { margin: 0; padding: 0; -webkit-text-size-adjust: 100%; -ms-text-size-adjust: 100%; }  table, td { border-collapse:collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; }  img { border: 0; height: auto; line-height: 100%; outline: none; text-decoration: none; -ms-interpolation-mode: bicubic; }  p { display: block; margin: 13px 0; }</style><!--[if !mso]><!--><style type=\"text/css\">  @media only screen and (max-width:480px) {    @-ms-viewport { width:320px; }    @viewport { width:320px; }  }</style><!--<![endif]--><!--[if mso]><xml>  <o:OfficeDocumentSettings>    <o:AllowPNG/>    <o:PixelsPerInch>96</o:PixelsPerInch>  </o:OfficeDocumentSettings></xml><![endif]--><!--[if lte mso 11]><style type=\"text/css\">  .outlook-group-fix {    width:100% !important;  }</style><![endif]--><style type=\"text/css\">        .hide_on_mobile { display: none !important;}         @media only screen and (min-width: 480px) { .hide_on_mobile { display: table-row !important;} }        [owa] .mj-column-per-100 {            width: 100%!important;          }          [owa] .mj-column-per-50 {            width: 50%!important;          }          [owa] .mj-column-per-33 {            width: 33.333333333333336%!important;          }        </style><style type=\"text/css\">  @media only screen and (min-width:480px) {    .mj-column-per-100 { width:100%!important; }  }</style></head><body style=\"background: #FFFFFF;\">    <div class=\"mj-container\" style=\"background-color:#FFFFFF;\"><!--[if mso | IE]>      <table role=\"presentation\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"600\" align=\"center\" style=\"width:600px;\">        <tr>          <td style=\"line-height:0px;font-size:0px;mso-line-height-rule:exactly;\">      <![endif]--><div style=\"margin:0px auto;max-width:600px;\"><table role=\"presentation\" cellpadding=\"0\" cellspacing=\"0\" style=\"font-size:0px;width:100%;\" align=\"center\" border=\"0\"><tbody><tr><td style=\"text-align:center;vertical-align:top;direction:ltr;font-size:0px;padding:9px 0px 9px 0px;\"><!--[if mso | IE]>      <table role=\"presentation\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\">        <tr>          <td style=\"vertical-align:top;width:600px;\">      <![endif]--><div class=\"mj-column-per-100 outlook-group-fix\" style=\"vertical-align:top;display:inline-block;direction:ltr;font-size:13px;text-align:left;width:100%;\"><table role=\"presentation\" cellpadding=\"0\" cellspacing=\"0\" style=\"vertical-align:top;\" width=\"100%\" border=\"0\"><tbody><tr><td style=\"word-wrap:break-word;font-size:0px;padding:10px 10px 10px 10px;\" align=\"left\"><div style=\"cursor:auto;color:#000000;font-family:Bitter, Georgia, serif;font-size:11px;line-height:1.5;text-align:left;\"><p>Hola!<br>Te escribimos por tu registro en la promoci&#xF3;n Quiero Ganar!<br>Queremos confirmarte que recibimos tu registro del voucher.</p><p>A continuaci&#xF3;n copiamos los datos que registramos</p><p>" +
                        "Participante: " + aux.Nombre + " " + aux.Apellido + "</p><p>" +
                        "DNI: " + aux.DNI.ToString() + "</p><p>" +
                        "Ciudad: " + aux.Ciudad + "</p><p>" +
                        "Direcci&#xF3;n: " + aux.Direccion + "</p><p>" +
                        "Codigo postal: " + aux.CodigoPostal.ToString() + "</p><p>" +
                        "EMail: " + aux.Email + "</p><p>" +
                        "Voucher: " + reg[0].CodigoVoucher.ToString() + "</p><p>" +
                        "Producto: " + prodNegocio.getProductoTituloByID(reg[0].IdProducto.ToString()) + "</p><p>" +
                        "</p><p>Muchas gracias por participar, y te deseamos mucha suerte!<br>El equipo de Quiero Ganar!</p></div></td></tr></tbody></table></div><!--[if mso | IE]>      </td></tr></table>      <![endif]--></td></tr></tbody></table></div><!--[if mso | IE]>      </td></tr></table>      <![endif]--></div></body></html>");

                    Response.Redirect("ParticipandoOK.aspx", false);
                }

            }
            catch (Exception ex)
            {
                Session["Error" + Session.SessionID] = ex.Message;
                Response.Redirect("Error.aspx", false);
            }
        }
    }
}