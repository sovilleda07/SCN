using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Notas1.Clases
{
    class cl_Conexion
    {
        private const string error = "Hay problemas para conectarse a la base de datos";
        // Creamos el string de conexion.
        private SqlConnection con;

        public SqlConnection conexion
        {
            get
            {
                return con;
            }
        }

        public cl_Conexion()
        {
            this.con = new SqlConnection(@"server = (local);
                        integrated security = true; database = Notas; ");
        }

        // Creamos el metodo para abrir la conexion con la base de datos
        public void Abrir()
        {
            try
            {
                con.Open();
            }
            catch (SqlException excepcion)
            {
                Exception ex = new Exception(
                    String.Format("{0} \n\n{1}",
                    error, excepcion.Message));
                ex.HelpLink = "unicah.edu";
                ex.Source = "Clase_Conexion";
                throw ex;
            }
        }

        //Creamos el metodo para cerrar la conexion con la base de datos.
        public void Cerrar()
        {
            try
            {
                con.Close();
            }
            catch (SqlException excepcion)
            {
                Exception ex = new Exception(
                    String.Format("{0} \n\n{1}",
                    error, excepcion.Message));
                ex.HelpLink = "unicah.edu";
                ex.Source = "Clase_Conexion";

            }

        }
    }
}
