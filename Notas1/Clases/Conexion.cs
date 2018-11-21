using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Agregar los namespaces necesarios
using System.Data;
using System.Data.SqlClient;

namespace Notas1.Clases
{
    class Conexion
    {
        // Propiedades
        private string servidor;
        private string baseDatos;
        public SqlConnection conn;
        public SqlCommand cmd;

        //Constructores
        public Conexion() { }

        public Conexion(string elServidor, string laBaseDatos)
        {
            servidor = elServidor;
            baseDatos = laBaseDatos;
            EstablecerConexion();
        }

        // Métodos
        /// <summary>
        /// Realiza una conexión al servidor de base de datos.
        /// Requiere el nombre del servidor más la instancia del mismo.
        /// Requiere el nombre de la base de datos a inicializar.
        /// </summary>
        private void EstablecerConexion()
        {
            try
            {
                conn = new SqlConnection(@"server = " + servidor + ";" +
                    "integrated security = true; database = " + baseDatos + ";");

                // Establecer conexión
                conn.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("Servidor o base de datos no encontrados!");
            }
        }

        /// <summary>
        /// Ejecuta un comando SQL.
        /// </summary>
        /// <param name="elComando"></param>
        /// <returns>El query SQL a ejecutar</returns>
        public SqlCommand EjecutarComando(string elComando)
        {
            return cmd = new SqlCommand(elComando, conn);
        }

        /// <summary>
        /// Cierra la conexión al servidor SQL.
        /// </summary>
        public void CerrarConexion()
        {
            conn.Close();
        }

    }
}
