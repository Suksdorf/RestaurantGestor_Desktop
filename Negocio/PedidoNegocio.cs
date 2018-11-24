using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class PedidoNegocio
    {
        public List<Pedido> Listar()
        {
            List<Pedido> lista = new List<Pedido>();
            AccesoDatos conexion = new AccesoDatos();

            try
            {
                conexion.SetearConsulta("select id, mesero, mesa, fecha from pedidos where activo = 1");
                conexion.AbrirConexion();
                conexion.EjecutarComando();

                while (conexion.Lector.Read())
                {
                    Pedido aux = new Pedido();
                    aux.id = conexion.Lector.GetInt32(0);
                    aux.mesero = MeseroNegocio.BuscarxId(conexion.Lector.GetInt32(1));
                    aux.mesa = MesaNegocio.BuscarxId(conexion.Lector.GetInt32(2));
                    aux.fecha = conexion.Lector.GetDateTime(3);
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

        public static void Alta(Pedido nuevo)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.SetearConsulta("insert into PEDIDOS (Mesero, Mesa, Fecha, Activo) values (@mesero, @mesa, @fecha, 1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@mesero", nuevo.mesero.id);
                conexion.Comando.Parameters.AddWithValue("@mesa", nuevo.mesa.id);
                conexion.Comando.Parameters.AddWithValue("@fecha", nuevo.fecha);
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

        public static Pedido BuscarUltimo()
        {
            Pedido pedido = new Pedido();
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.SetearConsulta("select id, mesero, mesa, fecha from pedidos where id=(select MAX(id) from PEDIDOS) and activo=1");
                accesoDatos.AbrirConexion();
                accesoDatos.EjecutarComando();
                accesoDatos.Lector.Read();
                pedido.id = accesoDatos.Lector.GetInt32(0);
                pedido.mesero = MeseroNegocio.BuscarxId(accesoDatos.Lector.GetInt32(1));
                pedido.mesa = MesaNegocio.BuscarxId(accesoDatos.Lector.GetInt32(2));
                pedido.fecha = accesoDatos.Lector.GetDateTime(3);
                return pedido;
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

        public static void CerrarPedido(int id)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.SetearConsulta("update PEDIDOS set activo = 0 where id =" + id.ToString());
                accesoDatos.AbrirConexion();
                accesoDatos.ejecutarAccion();
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
