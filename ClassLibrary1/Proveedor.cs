using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Proveedor : Persona
    {
        public string Producto { get; set; }
        DateTime Horario; //solo orientativo (modificar)
    }
}
