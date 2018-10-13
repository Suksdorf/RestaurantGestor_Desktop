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
    public partial class frmVistas : Form
    {
        private int padre;

        public frmVistas(int p)
        {
            padre = p;
            InitializeComponent();
        }
        
        private void frmVistas_Load(object sender, EventArgs e)
        {
            try
            {
                switch (padre)
                {
                    case 1:
                        this.Text = "Proveedores";
                        dgvVistas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                        ProveedorNegocio proveedor = new ProveedorNegocio();
                        dgvVistas.DataSource = proveedor.Listar();
                        dgvVistas.Columns["Nombre"].DisplayIndex = 0;
                        dgvVistas.Columns["Descripcion"].Visible = false;
                        dgvVistas.Columns["Id"].Visible = false;
                        break;
                    case 2:
                        this.Text = "Meseros";
                        MeseroNegocio mesero = new MeseroNegocio();
                        dgvVistas.DataSource = mesero.Listar();
                        break;
                    case 3:
                        Text = "Platos";
                        PlatoNegocio plato = new PlatoNegocio();
                        dgvVistas.DataSource = plato.Listar();
                        dgvVistas.Columns["Id"].Visible = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (padre)
                {
                    case 1:
                        frmProveedoresAM formulario1 = new frmProveedoresAM();                      
                        formulario1.ShowDialog();
                        break;
                    case 3:
                        frmPlatoAM formulario2 = new frmPlatoAM();
                        formulario2.ShowDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                frmVistas_Load(sender, e);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (padre)
                {
                    case 1:
                        frmProveedoresAM formulario1 = new frmProveedoresAM((Proveedor)dgvVistas.CurrentRow.DataBoundItem);
                        formulario1.Text = "Modificar proveedor";
                        formulario1.ShowDialog();
                        break;
                    case 3:
                        frmPlatoAM formulario = new frmPlatoAM((Plato)dgvVistas.CurrentRow.DataBoundItem);
                        formulario.Text = "Modificar plato";
                        formulario.ShowDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                frmVistas_Load(sender, e);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Está seguro que desea eliminar el registro seleccionado?","Eliminar",MessageBoxButtons.YesNo) == DialogResult.No){
                return;
            }
            try
            {
                switch (padre)
                {
                    case 1:
                        ProveedorNegocio neg1 = new ProveedorNegocio();
                        neg1.eliminar((int)dgvVistas.CurrentRow.Cells["Id"].Value);
                        break;
                    case 3:
                        PlatoNegocio neg3 = new PlatoNegocio();
                        neg3.eliminar((int)dgvVistas.CurrentRow.Cells["Id"].Value);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                frmVistas_Load(sender, e);
            }
        }
    }
}
