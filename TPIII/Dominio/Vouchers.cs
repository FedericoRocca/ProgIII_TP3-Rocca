using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Vouchers
    {
        public Int32 ID { get; set; }
        public string CodigoVoucher { get; set; }
        public bool Estado { get; set; }
        public Int32 IdCliente { get; set; }
        public Int32 IdProducto { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
