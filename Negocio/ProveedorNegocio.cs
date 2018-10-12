using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ProveedorNegocio
    {
        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new List<Proveedor>();
            AccesoDatos conexion = new AccesoDatos();

            try
            {
                conexion.SetearConsulta("select id, nombre from proveedores");
                conexion.AbrirConexion();
                conexion.EjecutarComando();

                while (conexion.Lector.Read())
                {
                    Proveedor aux = new Proveedor();
                    aux.id = conexion.Lector.GetInt32(0);
                    aux.nombre = conexion.Lector.GetString(1);
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
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
