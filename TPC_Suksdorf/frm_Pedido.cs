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
    public partial class frm_Pedido : Form
    {
        int padre;
        Pedido pedido = new Pedido();
        public frm_Pedido(Pedido pedido, int padre)
        {
            this.padre = padre;
            this.pedido = pedido;
            InitializeComponent();
        }

        private void lbl_NroPedido_Click(object sender, EventArgs e)
        {

        }

        private void frm_Pedido_Load(object sender, EventArgs e)
        {
            lblFecha.Text = pedido.fecha.ToString();
            lblMesa.Text = pedido.mesa.ToString();
            lblMesero.Text = pedido.mesero.ToString();

            PlatoNegocio platoNegocio = new PlatoNegocio();
            cmb_Insumos.DataSource = platoNegocio.Listar();

            CargarInsumos();
        }

        private void CargarInsumos()
        {
            List<Plato> platos = new List<Plato>();
            foreach (int x in PlatoNegocio.BuscarxPedido(pedido.id))
            {
                platos.Add(PlatoNegocio.BuscarxId(x));
            }
            dgvInsumos.DataSource = platos;
            dgvInsumos.Columns["id"].Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCerrarPedido_Click(object sender, EventArgs e)
        {
            PedidoNegocio.CerrarPedido(pedido.id);
            Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.SetearConsulta("insert into platospedido (plato, pedido) values (@plato, @pedido)");
                accesoDatos.Comando.Parameters.Clear();
                Plato aux = new Plato();
                aux = (Plato)cmb_Insumos.SelectedItem;
                accesoDatos.Comando.Parameters.AddWithValue("@plato", aux.Id);
                accesoDatos.Comando.Parameters.AddWithValue("@pedido", pedido.id);
                accesoDatos.AbrirConexion();
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());                
            }
            finally
            {
                accesoDatos.CerrarConexion();
                CargarInsumos();
            }
        }

        private void dgvInsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
