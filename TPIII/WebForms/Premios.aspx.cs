using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace WebForms
{
    public partial class Premios : System.Web.UI.Page
    {

        public List<Producto> prods { get; set; }
        public Int64 vouchCode;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ProductoNegocio prodNegocio = new ProductoNegocio();
                prods = prodNegocio.getProductos();
                vouchCode = Int64.Parse(Session["IdVoucher" + Session.SessionID].ToString());
            }
            catch (Exception ex)
            {
                Session["Error" + Session.SessionID] = ex.Message;
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnProducto_Click(object sender, EventArgs e)
        {

        }
    }
}