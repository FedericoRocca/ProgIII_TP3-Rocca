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

        public bool altaCliente(Cliente aux)
        {
            try
            {
                DDBBGateway data = new DDBBGateway();
                data.prepareStatement("" +
                    "INSERT INTO Clientes VALUES ('" + aux.DNI + "', '" + aux.Nombre + "', '" + aux.Apellido + "', '" + aux.Email + "', '" + aux.Direccion + "', '" + aux.Ciudad + "', '" + aux.CodigoPostal + "', '" + DateTime.Now + "')");
                data.sendStatement();
                data.closeConnection();

                if (data.getAffectedRows() <= 0)
                {
                    return false;
                }
                else return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool modificarCliente(Cliente aux)
        {
            try
            {
                DDBBGateway data = new DDBBGateway();
                data.prepareStatement("update Clientes set Nombre = '" + aux.Nombre + "', Apellido = '" + aux.Apellido + "', Email = '" + aux.Email + "', Direccion = '" + aux.Direccion + "', Ciudad = '" + aux.Ciudad + "', CodigoPostal = '" + aux.CodigoPostal + "' where DNI = '" + aux.DNI + "'");
                data.sendStatement();
                data.closeConnection();

                if (data.getAffectedRows() >= 0)
                {
                    return true;
                }
                else return false;

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
