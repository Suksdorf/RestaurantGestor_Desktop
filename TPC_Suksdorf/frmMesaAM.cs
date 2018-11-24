using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPC_Suksdorf
{
    public partial class frmMesaAM : Form
    {
        Mesa mesa = null;

        public frmMesaAM()
        {
            InitializeComponent();
        }

        public frmMesaAM(Mesa m)
        {
            mesa = m;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMesaAM_Load(object sender, EventArgs e)
        {
            if (mesa != null)
            {
                txtNombre.Text = mesa.Nombre.Trim();
                txtDetalles.Text = mesa.Detalles;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MesaNegocio neg = new MesaNegocio();
            try
            {
                if (mesa == null) mesa = new Mesa();
                mesa.Nombre = txtNombre.Text.Trim();
                mesa.Detalles = txtDetalles.Text.Trim();
                if (mesa.id == 0) neg.Alta(mesa);
                else neg.modificar(mesa);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());                
            }
        }
    }
}
