using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ClienteNegocio
    {
        public List<Cliente> getCliente(string toSearch)
        {
            try
            {

                DDBBGateway data = new DDBBGateway();
                List<Cliente> aux = new List<Cliente>();

                data.prepareQuery("select Id, DNI, Nombre, Apellido, Email, Direccion, Ciudad, CodigoPostal, FechaRegistro from Clientes  where DNI = " + toSearch );
                data.sendQuery();

                while (data.getReader().Read() )
                {
                    aux.Add(new Cliente(
                        (Int64)data.getReader()["Id"],
                        (int)data.getReader()["DNI"],
                        data.getReader()["Nombre"].ToString(),
                        data.getReader()["Apellido"].ToString(),
                        data.getReader()["Email"].ToString(),
                        data.getReader()["Direccion"].ToString(),
                        data.getReader()["Ciudad"].ToString(),
                        data.getReader()["CodigoPostal"].ToString(),
                        (DateTime)data.getReader()["FechaRegistro"]

                        ));
                }

                data.closeConnection();

                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void altaCliente(Cliente aux)
        {
            try
            {
                DDBBGateway data = new DDBBGateway();
                data.prepareStatement("" +
                    "INSERT INTO Clientes VALUES ('" + aux.DNI + "', '" + aux.Nombre + "', '" + aux.Apellido + "', '" + aux.Email + "', '" + aux.Direccion + "', '" + aux.Ciudad + "', '" + aux.CodigoPostal + "', '" + DateTime.Now + "')");
                data.sendStatement();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
