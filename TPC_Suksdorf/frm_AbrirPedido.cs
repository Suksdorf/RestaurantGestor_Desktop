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
    public partial class frm_AbrirPedido : Form
    {
        public frm_AbrirPedido()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido() { fecha = DateTime.Now };
            pedido.mesero = (Mesero)cmb_Meseros.SelectedItem;
            pedido.mesa = (Mesa)cmb_Mesa.SelectedItem;
            PedidoNegocio.Alta(pedido);

            frm_Pedido frmPedido = new frm_Pedido(PedidoNegocio.BuscarUltimo(), 1);
            frmPedido.ShowDialog();
            this.Close();
            frmPedido.Focus();
        }

        private void cmb_Meseros_SelectedIndexChanged(object sender, EventArgs e)
        {
            MesaNegocio mesaNegocio = new MesaNegocio();
            Mesero aux = (Mesero)cmb_Meseros.SelectedItem;
            cmb_Mesa.DataSource = mesaNegocio.ListarxMesero(aux.id);
        }

        private void frm_AbrirPedido_Load(object sender, EventArgs e)
        {
            MeseroNegocio neg = new MeseroNegocio();
            List<Mesero> lista = neg.Listar();
            cmb_Meseros.DataSource = lista;

            MesaNegocio mesaNegocio = new MesaNegocio();
            Mesero aux = (Mesero)cmb_Meseros.SelectedItem;
            cmb_Mesa.DataSource = mesaNegocio.ListarxMesero(aux.id);
        }
    }
}
