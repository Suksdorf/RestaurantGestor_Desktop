using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Pedido
    {
        public int id;
        public Mesero mesero;
        public Mesa mesa;
        public List<Plato> platos;
    }
}
