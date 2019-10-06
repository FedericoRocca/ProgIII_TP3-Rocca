﻿using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                txbDNI.Text = Session["DNICliente" + Session.SessionID].ToString();
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

                ClienteNegocio clNegocio = new ClienteNegocio();
                Cliente aux = new Cliente();

                aux.Apellido = txbApellido.Text;
                aux.Ciudad = txbCiudad.Text;
                aux.CodigoPostal = txbCodigoPostal.Text;
                aux.Direccion = txbDireccion.Text;
                aux.DNI = int.Parse(txbDNI.Text);
                aux.Email = txbEmail.Text;
                aux.Nombre = txbNombre.Text;

                clNegocio.altaCliente(aux);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}