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
            SqlConnection conexion = new SqlConnection("data source=.; initial catalog=SUKSDORF_DB; integrated security=sspi");
            SqlCommand comando = new SqlCommand("select id, nombre, clave from meseros", conexion);
            SqlDataReader lector;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Mesero mesero = new Mesero();
                    mesero.id = lector.GetInt32(0);
                    mesero.nombre = lector.GetString(1);
                    mesero.clave = lector.GetString(2);

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
                conexion.Close();
                conexion = null;
            }
        }
    }
}
