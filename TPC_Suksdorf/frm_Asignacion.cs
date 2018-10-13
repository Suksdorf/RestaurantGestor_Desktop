using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace TPC_Suksdorf
{
    public partial class frm_Asignacion : Form
    {
        public frm_Asignacion()
        {
            InitializeComponent();
        }

        private void frm_Asignacion_Load(object sender, EventArgs e)
        {
            MeseroNegocio meseronegocio = new MeseroNegocio();
            List<Mesero> listaMeseros = meseronegocio.Listar();
            foreach (Mesero elemento in listaMeseros)
            {
                ltb_Meseros.Items.Add(elemento.Nombre);
            }

            MesaNegocio mesanegocio = new MesaNegocio();
            List<Mesa> listaMesa = mesanegocio.Listar();
            foreach(Mesa elemento in listaMesa)
            {
                ltb_Mesas.Items.Add(elemento.nombre);
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
