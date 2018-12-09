using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Notas1.Clases
{
    class Calificaciones
    {
        public int codigo { get; set; }
        public decimal nota1 { get; set; }
        public decimal nota2 { get; set; }
        public decimal nota3 { get; set; }
        public decimal promedio { get; set; }
        public int codigoRegistro { get; set; }

        // Constructor
        public Calificaciones() { }

        public static bool InsertarCalificacion(Calificaciones laCalificacion)
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_InsertarCalificacion");

            // Establecemos el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@nota1", SqlDbType.Decimal));
            cmd.Parameters["@nota1"].Value = laCalificacion.nota1;

            cmd.Parameters.Add(new SqlParameter("@nota2", SqlDbType.Decimal));
            cmd.Parameters["@nota2"].Value = laCalificacion.nota2;

            cmd.Parameters.Add(new SqlParameter("@nota3", SqlDbType.Decimal));
            cmd.Parameters["@nota3"].Value = laCalificacion.nota3;

            cmd.Parameters.Add(new SqlParameter("@promedio", SqlDbType.Decimal));
            cmd.Parameters["@promedio"].Value = laCalificacion.promedio;

            cmd.Parameters.Add(new SqlParameter("@codigoRegistro", SqlDbType.Int));
            cmd.Parameters["@codigoRegistro"].Value = laCalificacion.codigoRegistro;

            try
            {
                // Establecemos la conexión
                conexion.EstablecerConexion();
                // Ejecutamos el query vía un ExecuteNonQuery
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Errors[0].ToString());
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }

        public static bool ActualizarCalificacion(Calificaciones laCalificacion)
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_ActualizarCalificacion");

            // Establecemos el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure


            try
            {
                // Establecemos la conexión
                conexion.EstablecerConexion();
                // Ejecutamos el query vía un ExecuteNonQuery
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Errors[0].ToString());

                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }




    }
}
