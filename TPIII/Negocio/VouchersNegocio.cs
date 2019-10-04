using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class VouchersNegocio
    {
        public List<Vouchers> getVoucher(string voucherCode)
        {
            DDBBGateway DDBB = new DDBBGateway();

            DDBB.prepareQuery("select Id, CodigoVoucher, Estado, IdCliente, IdProducto, FechaRegistro from Vouchers where Estado = 0 and CodigoVoucher = '" + voucherCode + "'");
            DDBB.sendQuery();
            List<Vouchers> vouchersList = new List<Vouchers>();
            Vouchers aux = new Vouchers();

            while (DDBB.getReader().Read())
            {

                aux.ID = (Int64)DDBB.getReader()["Id"];
                aux.CodigoVoucher = DDBB.getReader()["CodigoVoucher"].ToString();
                aux.Estado = (bool)DDBB.getReader()["Estado"];
                if (!Convert.IsDBNull(DDBB.getReader()["IdCliente"]))
                {
                    aux.IdCliente = (int)DDBB.getReader()["IdCliente"];
                }
                else
                {
                    aux.IdCliente = null;
                }

                if (!Convert.IsDBNull(DDBB.getReader()["IdProducto"]))
                {
                    aux.IdProducto = (int)DDBB.getReader()["IdProducto"];
                }
                else
                {
                    aux.IdProducto = null;
                }

                if (!Convert.IsDBNull(DDBB.getReader()["FechaRegistro"]))
                {
                    aux.FechaRegistro = (DateTime)DDBB.getReader()["FechaRegistro"];
                }
                else
                {
                    aux.FechaRegistro = null;
                }

                vouchersList.Add(aux);
            }

            return vouchersList;
        }
    }
}

