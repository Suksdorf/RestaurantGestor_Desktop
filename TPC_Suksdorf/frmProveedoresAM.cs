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
    public partial class frmProveedoresAM : Form
    {
        private Proveedor proveedorGlobal = null;

        public frmProveedoresAM()
        {
            InitializeComponent();
        }

        public frmProveedoresAM(Proveedor prov)
        {
            InitializeComponent();
            proveedorGlobal = prov;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProveedorNegocio neg = new ProveedorNegocio();
            try
            {
                if (proveedorGlobal == null) proveedorGlobal = new Proveedor();
                proveedorGlobal.Nombre = txtNombre.Text;
                proveedorGlobal.Telefono = txtTelefono.Text;
                proveedorGlobal.Mail = txtMail.Text;
                proveedorGlobal.Horario = txtHorario.Text;
                proveedorGlobal.Descripcion = txtDescripcion.Text;
                proveedorGlobal.Direccion = txtDireccion.Text;
                if (proveedorGlobal.id == 0) neg.Alta(proveedorGlobal);
                else neg.modificar(proveedorGlobal);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmProveedoresAM_Load(object sender, EventArgs e)
        {
            if (proveedorGlobal != null)
            {
                txtNombre.Text = proveedorGlobal.Nombre;
                txtTelefono.Text = proveedorGlobal.Telefono;
                txtMail.Text = proveedorGlobal.Mail;
                txtDireccion.Text = proveedorGlobal.Direccion;
                txtHorario.Text = proveedorGlobal.Horario;
                txtDescripcion.Text = proveedorGlobal.Descripcion;
            }
        }
    }
}
