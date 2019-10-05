using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public Int64 ID { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string URLImagen { get; set; }

        public Producto(){}
        public Producto(Int64 _ID, string _Titulo, string _Descripcion, string _URLImagen){
            ID = _ID;
            Titulo = _Titulo;
            Descripcion = _Descripcion;
            URLImagen = _URLImagen;
        }
    }
}
