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
                VoucherNegocio vouch = new VoucherNegocio();
                List<Voucher> voucher = new List<Voucher>();

                voucher = vouch.getVoucher(txbVoucher.Text);
                if(voucher.Count == 0)
                {
                    lblModalTitle.Text = "Voucher no encontrado";
                    lblModalBody.Text = "El código \"" + txbVoucher.Text + "\" ingresado no corresponde a un voucher válido, existente o disponible.";
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                    upModal.Update();
                }
                else
                {
                    Response.Redirect("Premios.aspx");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}