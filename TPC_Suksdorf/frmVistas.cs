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
                        dgvVistas.Columns["id"].Visible = false;
                        dgvVistas.Columns["Clave"].Visible = false;
                        break;
                    case 3:
                        Text = "Platos";
                        PlatoNegocio plato = new PlatoNegocio();
                        dgvVistas.DataSource = plato.Listar();
                        dgvVistas.Columns["Id"].Visible = false;
                        break;
                    case 4:
                        Text = "Mesas";
                        MesaNegocio mesa = new MesaNegocio();
                        dgvVistas.DataSource = mesa.Listar();
                        dgvVistas.Columns["Id"].Visible = false;
                        break;
                    case 5:
                        Text = "Pedidos Activos";
                        PedidoNegocio pedidoNegocio = new PedidoNegocio();
                        dgvVistas.DataSource = pedidoNegocio.Listar();
                        dgvVistas.Columns["Id"].Visible = false;
                        btnAgregar.Hide();
                        btnEliminar.Hide();
                        btnModificar.Text = "Ver";
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
                    case 2:
                        frmMeserosAM formulario2 = new frmMeserosAM();
                        formulario2.ShowDialog();
                        break;
                    case 3:
                        frmPlatoAM formulario3 = new frmPlatoAM();
                        formulario3.ShowDialog();
                        break;
                    case 4:
                        frmMesaAM formulario4 = new frmMesaAM();
                        formulario4.ShowDialog();
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
                if (dgvVistas.CurrentRow != null )
                {
                    switch (padre)
                    {
                        case 1:
                            frmProveedoresAM formulario1 = new frmProveedoresAM((Proveedor)dgvVistas.CurrentRow.DataBoundItem);
                            formulario1.Text = "Modificar proveedor";
                            formulario1.ShowDialog();
                            break;
                        case 2:
                            frmMeserosAM formulario2 = new frmMeserosAM((Mesero)dgvVistas.CurrentRow.DataBoundItem);
                            formulario2.Text = "Modificar mesero";
                            formulario2.ShowDialog();
                            break;
                        case 3:
                            frmPlatoAM formulario3 = new frmPlatoAM((Plato)dgvVistas.CurrentRow.DataBoundItem);
                            formulario3.Text = "Modificar plato";
                            formulario3.ShowDialog();
                            break;
                        case 4:
                            frmMesaAM formulario4 = new frmMesaAM((Mesa)dgvVistas.CurrentRow.DataBoundItem);
                            formulario4.Text = "Modificar mesa";
                            formulario4.ShowDialog();
                            break;
                        case 5:
                            frm_Pedido formulario5 = new frm_Pedido((Pedido)dgvVistas.CurrentRow.DataBoundItem, 2);
                            formulario5.ShowDialog();
                            break;
                    }
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
                    case 2:
                        MeseroNegocio neg2 = new MeseroNegocio();
                        neg2.eliminar((int)dgvVistas.CurrentRow.Cells["Id"].Value);
                        break;
                    case 3:
                        PlatoNegocio neg3 = new PlatoNegocio();
                        neg3.eliminar((int)dgvVistas.CurrentRow.Cells["Id"].Value);
                        break;
                    case 4:
                        MesaNegocio neg4 = new MesaNegocio();
                        neg4.eliminar((int)dgvVistas.CurrentRow.Cells["Id"].Value);
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
