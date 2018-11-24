using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class PlatoNegocio
    {
        public List<Plato> Listar()
        {
            List<Plato> lista = new List<Plato>();
            AccesoDatos conexion = new AccesoDatos();

            try
            {
                conexion.SetearConsulta("select id, nombre, precio from platos where estado=1 order by Nombre");
                conexion.AbrirConexion();
                conexion.EjecutarComando();

                while (conexion.Lector.Read())
                {
                    Plato aux = new Plato();
                    aux.Id = conexion.Lector.GetInt32(0);
                    aux.Nombre = conexion.Lector.GetString(1);
                    aux.Precio = conexion.Lector.GetDecimal(2);
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

        public void Alta(Plato nuevo)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.SetearConsulta("insert into PLATOS (Nombre, Precio, Estado) values (@nombre, @precio, 1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@precio", nuevo.Precio);
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

        public void modificar(Plato modi)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.SetearConsulta("update platos set nombre = @nombre, precio = @precio where Id = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", modi.Nombre);
                conexion.Comando.Parameters.AddWithValue("@precio", modi.Precio);
                conexion.Comando.Parameters.AddWithValue("@id", modi.Id);

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
                
                conexion.SetearConsulta("update platos set estado = 0 where id=@id");
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

        public static List<int> BuscarxPedido(int pedido)
        {
            List<int> platos = new List<int>();
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.SetearConsulta("select plato from platospedido where pedido =" + pedido.ToString());
                accesoDatos.AbrirConexion();
                accesoDatos.EjecutarComando();
                while (accesoDatos.Lector.Read())
                {
                    platos.Add(accesoDatos.Lector.GetInt32(0));
                }
                return platos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.CerrarConexion();
            }
        }

        public static Plato BuscarxId(int id)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.SetearConsulta("select nombre, precio from platos where id=" + id.ToString());
                accesoDatos.AbrirConexion();
                accesoDatos.EjecutarComando();
                accesoDatos.Lector.Read();
                Plato plato = new Plato();
                plato.Id = id;
                plato.Nombre = accesoDatos.Lector.GetString(0);
                plato.Precio = accesoDatos.Lector.GetDecimal(1);
                return plato;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.CerrarConexion();
            }
        }
    }
}
