using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace WebForms
{
    public partial class ClienteRegistrado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Cliente reg = (Cliente)Session["Cliente" + Session.SessionID];
                txbApellido.Text = reg.Apellido;
                txbCiudad.Text = reg.Ciudad;
                txbCodigoPostal.Text = reg.CodigoPostal;
                txbDireccion.Text = reg.Direccion;
                txbDNI.Text = reg.DNI.ToString();
                txbEmail.Text = reg.Email;
                txbNombre.Text = reg.Nombre;
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}