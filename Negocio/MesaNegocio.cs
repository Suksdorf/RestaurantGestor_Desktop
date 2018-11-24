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
                conexion.SetearConsulta("select id, nombre, detalles from mesas where estado = 1");
                conexion.AbrirConexion();
                conexion.EjecutarComando();
                
                while (conexion.Lector.Read())
                {
                    Mesa aux = new Mesa();
                    aux.id = conexion.Lector.GetInt32(0);
                    aux.Nombre = conexion.Lector.GetString(1);
                    if (!conexion.Lector.IsDBNull(2)) aux.Detalles = conexion.Lector.GetString(2);
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

        internal static Mesa BuscarxId(int id)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.SetearConsulta("select id, nombre, detalles from mesas where estado = 1 and id=@id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                conexion.AbrirConexion();
                conexion.EjecutarComando();
                conexion.Lector.Read();

                Mesa mesa = new Mesa();
                mesa.id = conexion.Lector.GetInt32(0);
                mesa.Nombre = conexion.Lector.GetString(1);
                if (!conexion.Lector.IsDBNull(2)) mesa.Detalles = conexion.Lector.GetString(2);

                return mesa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void Alta(Mesa nuevo)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.SetearConsulta("insert into MESAS (Nombre, Detalles, Estado) values (@nombre, @detalles, 1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@detalles", nuevo.Detalles);
                conexion.AbrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void modificar(Mesa modi)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.SetearConsulta("update MESAS set nombre = @nombre, detalles = @detalles where Id = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", modi.Nombre);
                conexion.Comando.Parameters.AddWithValue("@detalles", modi.Detalles);
                conexion.Comando.Parameters.AddWithValue("@id", modi.id);

                conexion.AbrirConexion();
                conexion.ejecutarAccion();
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

        public void eliminar(int id)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.SetearConsulta("update MESAS set estado = 0 where id=@id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                conexion.AbrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public List<Mesa> ListarxMesero(int mesero)
        {
            List<Mesa> lista = new List<Mesa>();
            AccesoDatos conexion = new AccesoDatos();

            try
            {
                conexion.SetearConsulta("select id, nombre, detalles from mesas m inner join MesaMesero mm on m.Id = mm.Mesa where mm.Mesero = @mesero and mm.Jornada = @jornada");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@mesero", mesero);
                conexion.Comando.Parameters.AddWithValue("@jornada", Jornada.jornada);
                conexion.AbrirConexion();
                conexion.EjecutarComando();

                while (conexion.Lector.Read())
                {
                    Mesa aux = new Mesa();
                    aux.id = conexion.Lector.GetInt32(0);
                    aux.Nombre = conexion.Lector.GetString(1);
                    if (!conexion.Lector.IsDBNull(2)) aux.Detalles = conexion.Lector.GetString(2);
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
