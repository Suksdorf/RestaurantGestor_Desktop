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
                conexion.SetearConsulta("select id, nombre, descripcion, direccion, telefono, mail, horario from proveedores where estado = 1");
                conexion.AbrirConexion();
                conexion.EjecutarComando();

                while (conexion.Lector.Read())
                {
                    Proveedor aux = new Proveedor();
                    aux.id = conexion.Lector.GetInt32(0);
                    aux.Nombre = conexion.Lector.GetString(1).Trim();
                    aux.Descripcion = conexion.Lector.GetString(2).Trim();
                    aux.Direccion = conexion.Lector.GetString(3).Trim();
                    aux.Telefono = conexion.Lector.GetString(4).Trim();
                    aux.Mail = conexion.Lector.GetString(5).Trim();
                    aux.Horario = conexion.Lector.GetString(6).Trim();
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

        public void modificar(Proveedor modi)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.SetearConsulta("update proveedores set nombre = @nombre, descripcion = @descripcion, direccion=@direccion, telefono=@telefono, mail=@mail, horario=@horario where Id = @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", modi.Nombre);
                conexion.Comando.Parameters.AddWithValue("@descripcion", modi.Descripcion);
                conexion.Comando.Parameters.AddWithValue("@direccion", modi.Direccion);
                conexion.Comando.Parameters.AddWithValue("@telefono", modi.Telefono);
                conexion.Comando.Parameters.AddWithValue("@mail", modi.Mail);
                conexion.Comando.Parameters.AddWithValue("@horario", modi.Horario);
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

        public void Alta(Proveedor nuevo)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.SetearConsulta("insert into proveedores (Nombre, Descripcion, Direccion, Telefono, Mail, Horario, Estado) values (@nombre, @descripcion, @direccion, @telefono, @mail, @horario, 1)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                conexion.Comando.Parameters.AddWithValue("@descripcion", nuevo.Descripcion);
                conexion.Comando.Parameters.AddWithValue("@direccion", nuevo.Direccion);
                conexion.Comando.Parameters.AddWithValue("@telefono", nuevo.Telefono);
                conexion.Comando.Parameters.AddWithValue("@mail", nuevo.Mail);
                conexion.Comando.Parameters.AddWithValue("@horario", nuevo.Horario);
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

        public void eliminar(int value)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.SetearConsulta("update proveedores set estado = 0 where id=@id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id", value);
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
    }
}
