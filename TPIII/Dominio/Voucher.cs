using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Voucher
    {
        public Int64 ID { get; set; }
        public string CodigoVoucher { get; set; }
        public bool Estado { get; set; }
        public Int32 ? IdCliente { get; set; }
        public Int32 ? IdProducto { get; set; }
        public DateTime ? FechaRegistro { get; set; }

        public Voucher(Int64 _ID, string _CodigoVoucher, bool _Estado, Int32 _IdCliente, Int32 _IdProducto, DateTime _FechaRegistro)
        {
            ID = _ID;
            CodigoVoucher = _CodigoVoucher;
            Estado = _Estado;
            IdCliente = _IdCliente;
            IdProducto = _IdProducto;
            FechaRegistro = _FechaRegistro;
        }

        public Voucher(){}
    }
}
