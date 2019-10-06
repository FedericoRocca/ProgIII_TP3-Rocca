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
    public partial class ClienteRegistrado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(!IsPostBack)
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
                Cliente cli = new Cliente();
                cli.Apellido = txbApellido.Text;
                cli.Ciudad = txbCiudad.Text;
                cli.CodigoPostal = txbCodigoPostal.Text;
                cli.Direccion = txbDireccion.Text;
                cli.DNI = int.Parse(txbDNI.Text);
                cli.Email = txbEmail.Text;
                cli.Nombre = txbNombre.Text;

                ClienteNegocio cliNegocio = new ClienteNegocio();
                if( cliNegocio.modificarCliente(cli) == false )
                {
                    Session["Error" + Session.SessionID] = "Error al modificar el cliente";
                    Response.Redirect("Error.aspx", false);
                }
                else
                {
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