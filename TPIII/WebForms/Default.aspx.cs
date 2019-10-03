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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {

            try
            {
                DDBBGateway DDBB = new DDBBGateway();

                DDBB.prepareQuery("select * from Vouchers where Estado = 0 and CodigoVoucher = '" + txbVoucher.Text + "'");
                DDBB.sendQuery(true);

                if(DDBB.getselectedRows() <= 0)
                {
                    lblModalTitle.Text = "Voucher no encontrado";
                    lblModalBody.Text = "El código ingresado no corresponde a un voucher válido, existente o disponible.";
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                    upModal.Update();
                }
                else
                {
                    Response.Redirect("Premios.aspx");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}