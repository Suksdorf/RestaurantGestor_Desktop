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

namespace TPC_Suksdorf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Jornada.Cargarjornada();
            InitializeComponent();
            Text = Jornada.jornada.ToString();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AbrirPedido frm2 = new frm_AbrirPedido();
            frm2.ShowDialog();
        }

        private void asignarMesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Admin frmAdmin = new frm_Admin();
            if (frmAdmin.ShowDialog() == DialogResult.OK)
            {
                frm_Asignacion frmAsignacion = new frm_Asignacion();
                frmAsignacion.ShowDialog();
            }
        }

        private void verEditarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVistas frmPedidosActivos = new frmVistas(5);
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

        private void mesasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVistas formulario = new frmVistas(4);
            formulario.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea iniciar una nueva jornada?", "Jornada", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frm_Admin formulario = new frm_Admin();
                if(formulario.ShowDialog() == DialogResult.OK)
                {
                    Jornada.NuevaJornada();
                    Jornada.Cargarjornada();
                    Text = Jornada.jornada.ToString();
                }
            }
        }
    }
}
