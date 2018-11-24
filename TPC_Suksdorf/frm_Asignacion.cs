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
    public partial class frm_Asignacion : Form
    {
        public frm_Asignacion()
        {
            InitializeComponent();
        }

        private void CargarMesas()
        {
            if(ltb_Meseros.SelectedItem != null)
            {
                try
                {
                    ltb_Asignadas.Items.Clear();
                    MesaNegocio mesanegocio = new MesaNegocio();
                    Mesero aux = (Mesero)ltb_Meseros.SelectedItem;
                    List<Mesa> listaMesa = mesanegocio.ListarxMesero(aux.id);
                    foreach (Mesa elemento in listaMesa)
                    {
                        ltb_Asignadas.Items.Add(elemento);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void frm_Asignacion_Load(object sender, EventArgs e)
        {
            MeseroNegocio meseronegocio = new MeseroNegocio();
            List<Mesero> listaMeseros = meseronegocio.Listar();
            foreach (Mesero elemento in listaMeseros)
            {
                ltb_Meseros.Items.Add(elemento);
            }

            MesaNegocio mesanegocio = new MesaNegocio();
            List<Mesa> listaMesa = mesanegocio.Listar();
            foreach(Mesa elemento in listaMesa)
            {
                ltb_Mesas.Items.Add(elemento);
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Asignar_Click(object sender, EventArgs e)
        {
            try
            {
                if (BuscarAsignado((Mesa)ltb_Mesas.SelectedItem))
                {
                    if (MessageBox.Show("Esta mesa ya ha sido asignada a otro mesero, ¿Desea asignarla también al actual?", "Reasignar", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
                AccesoDatos accesoDatos = new AccesoDatos();
                accesoDatos.SetearConsulta("insert into MesaMesero values (@mesa,@mesero,@jornada)");
                accesoDatos.Comando.Parameters.Clear();
                Mesa aux = (Mesa)ltb_Mesas.SelectedItem;
                accesoDatos.Comando.Parameters.AddWithValue("@mesa", aux.id);
                Mesero aux2 = (Mesero)ltb_Meseros.SelectedItem;
                accesoDatos.Comando.Parameters.AddWithValue("@mesero", aux2.id);
                accesoDatos.Comando.Parameters.AddWithValue("@jornada", Jornada.jornada);
                accesoDatos.AbrirConexion();
                accesoDatos.ejecutarAccion();
                accesoDatos.CerrarConexion();

                CargarMesas();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Esta mesa ya fue asignada al mesero");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void ltb_Meseros_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ltb_Meseros_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Asignadas.Text = "Mesas asignadas a " + ltb_Meseros.SelectedItem.ToString();
            CargarMesas();
        }

        private bool BuscarAsignado(Mesa mesa)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            accesoDatos.SetearConsulta("select * from mesamesero where mesa=@mesa and jornada=@jornada");
            accesoDatos.Comando.Parameters.Clear();
            accesoDatos.Comando.Parameters.AddWithValue("@mesa", mesa.id);
            accesoDatos.Comando.Parameters.AddWithValue("@jornada", Jornada.jornada);
            accesoDatos.AbrirConexion();
            accesoDatos.EjecutarComando();
            accesoDatos.Lector.Read();
            if (accesoDatos.Lector.HasRows)
            {
                
                return true;
            }
            return false;
        }
    }
}
