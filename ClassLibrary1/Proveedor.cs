using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Proveedor : Persona
    {
        public int id { get; set; }
        //public string Producto { get; set; } Lo saco porque un proveedor puede traer más de un producto
        public string Descripcion { get; set; }
        public string Horario { get; set; } //solo orientativo (modificar)
    }
}
