using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Proveedor : Persona
    {
        public int id;
        public string Producto { get; set; }
        DateTime Horario; //solo orientativo (modificar)
    }
}
