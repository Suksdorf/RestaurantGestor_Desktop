using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class Jornada
    {
        public static int jornada;

        public static void Cargarjornada()
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            accesoDatos.SetearConsulta("use SUKSDORF_DB select MAX(id) as jor from jornada");
            accesoDatos.AbrirConexion();
            accesoDatos.EjecutarComando();
            accesoDatos.Lector.Read();
            //jornada = accesoDatos.Lector.GetInt32(0);
            jornada = (int)accesoDatos.Lector["jor"];
            accesoDatos.CerrarConexion();
        }

        public static void NuevaJornada()
        {
            AccesoDatos acceso = new AccesoDatos();
            acceso.SetearConsulta("insert into Jornada default values");
            acceso.AbrirConexion();
            acceso.ejecutarAccion();
            acceso.CerrarConexion();
        }
    }
}
