using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPC_Suksdorf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AbrirPedido frm2 = new frm_AbrirPedido();
            frm2.ShowDialog();
        }

        private void asignarMesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Admin frmAdmin = new frm_Admin();
            frmAdmin.ShowDialog();
        }

        private void verEditarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PedidosActivos frmPedidosActivos = new frm_PedidosActivos();
            frmPedidosActivos.ShowDialog();
        }

        private void meserosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form formu in Application.OpenForms)
            {
                if (formu.GetType() == typeof(frm_Meseros))
                {
                    return;
                }
            }
            frm_Meseros formulario = new frm_Meseros();
            formulario.MdiParent = this;
            formulario.Show();
        }
    }
}
