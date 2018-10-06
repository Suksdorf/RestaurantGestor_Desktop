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
    public partial class frm_Meseros : Form
    {
        public frm_Meseros()
        {
            InitializeComponent();
        }

        private void frm_Meseros_Load(object sender, EventArgs e)
        {
            MeseroNegocio negocio = new MeseroNegocio();
            try
            {
                dgvMeseros.DataSource = negocio.Listar();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
