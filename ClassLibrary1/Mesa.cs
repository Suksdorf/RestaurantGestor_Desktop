using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Mesa
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Detalles { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

        public static Mesa BuscarxId(int v)
        {
            throw new NotImplementedException();
        }
    }
}
