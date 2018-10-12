using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlDataReader lector;
        private SqlCommand comando;
        private SqlConnection conexion;

        public SqlDataReader Lector {
            get { return lector; }
        }

        public SqlCommand Comando
        {
            get { return comando; }
        }

        public AccesoDatos()
        {
            conexion = new SqlConnection("initial catalog=SUKSDORF_DB; data source=.; integrated security=sspi");
        }

        public void SetearConsulta(string consulta)
        {
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void AbrirConexion()
        {
            try
            {
                conexion.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        public void CerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch ( Exception ex)
            {
                throw ex;
            }
        }

        public void EjecutarComando()
        {
            try
            {
                comando.Connection = conexion;
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            try
            {
                comando.Connection = conexion;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
