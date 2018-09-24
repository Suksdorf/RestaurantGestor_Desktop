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
 
            SqlConnection conexion = new SqlConnection("data source=.; initial catalog=SUKSDORF_DB; integrated security=sspi");
            SqlCommand comando = new SqlCommand("select id, nombre from mesas", conexion);
            SqlDataReader lector;

            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Mesa aux = new Mesa();
                    aux.id = lector.GetInt32(0);
                    aux.nombre = lector.GetString(1);
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
                conexion.Close();
                conexion = null;
            }
        }
    }
}
