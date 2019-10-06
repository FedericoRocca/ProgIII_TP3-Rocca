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