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

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVistas formulario = new frmVistas(1);
            formulario.ShowDialog();
        }

        private void meserosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVistas formulario = new frmVistas(2);
            formulario.ShowDialog();
        }

        private void platosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVistas formulario = new frmVistas(3);
            formulario.ShowDialog();
        }
    }
}
