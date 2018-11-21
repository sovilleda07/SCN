using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Notas1.Clases
{
    class cl_Usuarios
    {
        // CREACIÓN DE PROPIEDADES PARA LA CLASE
        public string usuario { get; set; }
        public string clave { get; set; }
        public int habilitado { get; set; }

        //CONSTRUCTOR
        //Verificar si necesita más constructores
        public cl_Usuarios() { }

        public cl_Usuarios(string usuario, string clave) { }

        public void ObtenerUsuario(string usuarioLogin, string clave)
        {
            cl_Conexion conexion = new cl_Conexion();
            string sql = @"SELECT usuario, clave, habilitado FROM SCN.Usuarios WHERE usuario = '" + usuarioLogin + "' and clave = '" + clave + "' and habilitado='1'";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);

            try
            {
                conexion.Abrir();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.usuario = dr.GetString(0);
                    this.clave = dr.GetString(1);
                }
            }
            catch (SqlException excepcion)
            {
                Exception ex = new Exception(
                   String.Format("{0} \n\n{1}",
                   "no podemos obtener la informacion del usuario", excepcion.Message));
                ex.HelpLink = "unicah.edu";
                ex.Source = "Clase_Usuario";
                throw ex;
            }
            finally
            {
                conexion.Cerrar();
            }
        }


    }
}
