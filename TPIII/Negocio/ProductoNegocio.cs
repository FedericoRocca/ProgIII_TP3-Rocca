using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ProductoNegocio
    {
        public List<Producto> getProductos()
        {
            try
            {
                DDBBGateway data = new DDBBGateway();
                List<Producto> aux = new List<Producto>();
                data.prepareQuery("select Id, Titulo, Descripcion, URLImagen from Productos");
                data.sendQuery();
                while( data.getReader().Read() )
                {
                    aux.Add( new Producto(
                        (Int64)data.getReader()["Id"],
                        data.getReader()["Titulo"].ToString(),
                        data.getReader()["Descripcion"].ToString(),
                        data.getReader()["URLImagen"].ToString()));
                }

                return aux;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Producto> getProductoByID(string _ID)
        {
            try
            {
                DDBBGateway data = new DDBBGateway();
                List<Producto> aux = new List<Producto>();
                data.prepareQuery("select Id, Titulo, Descripcion, URLImagen from Productos where Id = '" + _ID + "'");
                data.sendQuery();
                while (data.getReader().Read())
                {
                    aux.Add(new Producto(
                        (Int64)data.getReader()["Id"],
                        data.getReader()["Titulo"].ToString(),
                        data.getReader()["Descripcion"].ToString(),
                        data.getReader()["URLImagen"].ToString()));
                }

                return aux;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
