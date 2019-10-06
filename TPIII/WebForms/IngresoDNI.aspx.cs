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
    public partial class IngresoDNI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteNegocio cliente = new ClienteNegocio();
                List<Cliente> aux = cliente.getCliente(txbDNI.Text);

                if (aux.Count <= 0)
                {
                    // Redirijo a form de registro completando únicamente el DNI
                    Session["DNICliente" + Session.SessionID] = txbDNI.Text;
                    Response.Redirect("Registro.aspx", false);
                }
                else
                {
                    // Redirijo a form de confirmación completando todos los datos
                    Session["Cliente" + Session.SessionID] = aux[0];
                    Response.Redirect("ClienteRegistrado.aspx");
                }

                

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}