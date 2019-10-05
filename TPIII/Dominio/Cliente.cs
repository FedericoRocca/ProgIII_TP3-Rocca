using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public Int64 ID { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string CodigoPostal { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Cliente(){}
        public Cliente(
            Int64 _ID, 
            int _DNI, 
            string _Nombre,
            string _Apellido,
            string _Email,
            string _Direccion, 
            string _Ciudad, 
            string _CodigoPostal,
            DateTime _FechaRegistro)
        {
            ID = _ID;
            DNI = _DNI;
            Nombre = _Nombre;
            Apellido = _Apellido;
            Email = _Email;
            Direccion = _Direccion;
            Ciudad = _Ciudad;
            CodigoPostal = _CodigoPostal;
            FechaRegistro = _FechaRegistro;
        }

    }
}
