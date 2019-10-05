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
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ProductoNegocio prodNegocio = new ProductoNegocio();
                prods = prodNegocio.getProductos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnProducto_Click(object sender, EventArgs e)
        {

        }
    }
}