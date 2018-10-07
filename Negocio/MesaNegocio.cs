using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class MesaNegocio
    {
        public List<Mesa> Listar()
        {
            List<Mesa> lista = new List<Mesa>();
            AccesoDatos conexion = new AccesoDatos();

            try
            {
                conexion.SetearConsulta("select id, nombre from mesas");
                conexion.AbrirConexion();
                conexion.EjecutarComando();
                
                while (conexion.Lector.Read())
                {
                    Mesa aux = new Mesa();
                    aux.id = conexion.Lector.GetInt32(0);
                    aux.nombre = conexion.Lector.GetString(1);
                    lista.Add(aux);
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
