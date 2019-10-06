using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class VoucherNegocio
    {
        public List<Voucher> getVoucher(string voucherCode)
        {
            try
            {
                DDBBGateway DDBB = new DDBBGateway();

                DDBB.prepareQuery("select Id, CodigoVoucher, Estado, IdCliente, IdProducto, FechaRegistro from Vouchers where Estado = 0 and CodigoVoucher = '" + voucherCode + "'");
                DDBB.sendQuery();
                List<Voucher> vouchersList = new List<Voucher>();
                Voucher aux = new Voucher();

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
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool updateVoucher(Voucher aux)
        {
            try
            {
                DDBBGateway data = new DDBBGateway();
                data.prepareStatement("update Vouchers set IdCliente = '" + aux.IdCliente + "', IdProducto = '" + aux.IdProducto + "', Estado = 1, FechaRegistro = '" + DateTime.Now + "' where Id = '" + aux.ID + "'");
                data.sendStatement();
                if (data.getAffectedRows() >= 1)
                {
                    return true;
                } else return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Voucher> getVoucherByID(string voucherCode)
        {
            try
            {
                DDBBGateway DDBB = new DDBBGateway();

                DDBB.prepareQuery("select Id, CodigoVoucher, Estado, IdCliente, IdProducto, FechaRegistro from Vouchers where Estado = 0 and Id = '" + voucherCode + "'");
                DDBB.sendQuery();
                List<Voucher> vouchersList = new List<Voucher>();
                Voucher aux = new Voucher();

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
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}

