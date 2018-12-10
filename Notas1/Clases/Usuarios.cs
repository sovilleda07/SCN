using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Notas1.Clases
{
    class Usuarios
    {
        // CREACIÓN DE PROPIEDADES PARA LA CLASE
        public string usuario { get; set; }
        public string clave { get; set; }
        public int habilitado { get; set; }

        //CONSTRUCTOR
        //Verificar si necesita más constructores
        public Usuarios() { }

        public Usuarios(string usuario, string clave) { }

        public void ObtenerUsuario(string usuarioLogin, string clave)
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");

            // Creamos la variable que contendrá el Querys
            string sql;

            // Query SQL
            sql = @"SELECT usuario, clave, habilitado 
                    FROM SCN.Usuarios 
                    WHERE usuario = '" + usuarioLogin + "' and clave = '" + clave + "' and habilitado='1'";

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando(sql);

            // Crearemos la lectura
            SqlDataReader rdr;

            try
            {
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    this.usuario = rdr.GetString(0);
                    this.clave = rdr.GetString(1);

                }
            }
            catch (SqlException ex)
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
