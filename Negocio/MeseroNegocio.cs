using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class MeseroNegocio
    {
        public List<Mesero> Listar()
        {
            List<Mesero> lista = new List<Mesero>();
            //SqlConnection conexion = new SqlConnection("data source=.; initial catalog=SUKSDORF_DB; integrated security=sspi");
            //SqlCommand comando = new SqlCommand("select id, nombre, clave from meseros", conexion);
            //SqlDataReader lector;
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                
                conexion.SetearConsulta("select id, nombre, clave from meseros");
                conexion.AbrirConexion();
                conexion.EjecutarComando();

                while (conexion.Lector.Read())
                {
                    Mesero mesero = new Mesero();
                    mesero.id = conexion.Lector.GetInt32(0);
                    mesero.nombre = conexion.Lector.GetString(1);
                    mesero.clave = conexion.Lector.GetString(2);

                    lista.Add(mesero);
                }

                return lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.CerrarConexion();
                conexion = null;
            }
        }
    }
}
