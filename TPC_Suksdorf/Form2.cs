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
    public partial class frmPlatoAM : Form
    {
        private Plato plato = null;

        public frmPlatoAM()
        {
            InitializeComponent();
        }

        public frmPlatoAM(Plato plato2)
        {
            InitializeComponent();
            plato = plato2;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PlatoNegocio neg = new PlatoNegocio();
            try
            {
                if(plato==null) plato = new Plato();
                plato.Nombre = txtNombre.Text;
                plato.Precio = decimal.Parse(txtPrecio.Text);
                if (plato.Id == 0) neg.Alta(plato);
                else neg.modificar(plato);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmPlatoAM_Load(object sender, EventArgs e)
        {
            if (plato != null)
            {
                txtNombre.Text = plato.Nombre;
                txtPrecio.Text = plato.Precio.ToString();
            }
        }
    }
}
