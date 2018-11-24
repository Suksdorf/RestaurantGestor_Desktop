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
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                
                conexion.SetearConsulta("select Id, nombre, direccion, telefono, mail, clave from meseros where estado = 1 order by Nombre");
                conexion.AbrirConexion();
                conexion.EjecutarComando();

                while (conexion.Lector.Read())
                {
                    Mesero mesero = new Mesero();
                    mesero.id = conexion.Lector.GetInt32(0);
                    mesero.Nombre = conexion.Lector.GetString(1);
                    if (!conexion.Lector.IsDBNull(2)) mesero.Direccion = conexion.Lector.GetString(2);
                    if (!conexion.Lector.IsDBNull(3)) mesero.Telefono = conexion.Lector.GetString(3);
                    if (!conexion.Lector.IsDBNull(4)) mesero.Mail = conexion.Lector.GetString(4);
                    mesero.clave = conexion.Lector.GetString(5);

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

        public void Alta(Mesero nuevo)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.SetearConsulta("insert into MESEROS (Nombre, Direccion, Telefono, Mail, Clave, Estado) values (@nombre, @direccion, @telefono, @mail, @clave, 1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@direccion", nuevo.Direccion);
                conexion.Comando.Parameters.AddWithValue("@telefono", nuevo.Telefono);
                conexion.Comando.Parameters.AddWithValue("@mail", nuevo.Mail);
                conexion.Comando.Parameters.AddWithValue("@clave", nuevo.clave);
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

        public void modificar(Mesero modi)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.SetearConsulta("update MESEROS set nombre = @nombre, direccion = @direccion, telefono = @telefono, mail = @mail, clave = @clave where Id = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", modi.Nombre);
                conexion.Comando.Parameters.AddWithValue("@direccion", modi.Direccion);
                conexion.Comando.Parameters.AddWithValue("@telefono", modi.Telefono);
                conexion.Comando.Parameters.AddWithValue("@mail", modi.Mail);
                conexion.Comando.Parameters.AddWithValue("@clave", modi.clave);
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
                conexion.SetearConsulta("update MESEROS set estado = 0 where id=@id");
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

        public static Mesero BuscarxId(int id)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.SetearConsulta("select Id, nombre, direccion, telefono, mail, clave from meseros where id=@id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", id);
                conexion.AbrirConexion();
                conexion.EjecutarComando();
                conexion.Lector.Read();

                Mesero mesero = new Mesero();
                mesero.id = conexion.Lector.GetInt32(0);
                mesero.Nombre = conexion.Lector.GetString(1);
                if (!conexion.Lector.IsDBNull(2)) mesero.Direccion = conexion.Lector.GetString(2);
                if (!conexion.Lector.IsDBNull(3)) mesero.Telefono = conexion.Lector.GetString(3);
                if (!conexion.Lector.IsDBNull(4)) mesero.Mail = conexion.Lector.GetString(4);
                mesero.clave = conexion.Lector.GetString(5);

                return mesero;
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
    }
}
