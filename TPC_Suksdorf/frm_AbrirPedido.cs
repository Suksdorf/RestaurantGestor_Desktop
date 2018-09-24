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
    public partial class frm_AbrirPedido : Form
    {
        public frm_AbrirPedido()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            frm_Pedido frmPedido = new frm_Pedido();
            frmPedido.Show();
            this.Close();
            frmPedido.Focus();
        }
    }
}
