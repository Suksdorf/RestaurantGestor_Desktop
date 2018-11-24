using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pedido
    {
        public int id { get; set; }
        public Mesero mesero { get; set; }
        public Mesa mesa { get; set; }
        public List<Plato> platos { get; set; }
        public DateTime fecha { get; set; }
    }
}
