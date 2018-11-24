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
    public partial class frmMeserosAM : Form
    {
        private Mesero mesero;

        public frmMeserosAM()
        {
            InitializeComponent();
        }

        public frmMeserosAM(Mesero m)
        {
            mesero = m;
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMeserosAM_Load(object sender, EventArgs e)
        {
            if (mesero != null)
            {
                txtNombre.Text = mesero.Nombre;
                txtDireccion.Text = mesero.Direccion;
                txtTelefono.Text = mesero.Telefono;
                txtMail.Text = mesero.Mail;
                txtClave.Text = mesero.clave;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MeseroNegocio neg = new MeseroNegocio();
            
            try
            {
                if (mesero == null) mesero = new Mesero();
                mesero.Nombre = txtNombre.Text.Trim();
                mesero.Direccion = txtDireccion.Text.Trim();
                mesero.Telefono = txtTelefono.Text.Trim();
                mesero.Mail = txtMail.Text.Trim();
                mesero.clave = txtClave.Text.Trim();
                if (mesero.id == 0) neg.Alta(mesero);
                else neg.modificar(mesero);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Close();
            }
        }
    }
}
