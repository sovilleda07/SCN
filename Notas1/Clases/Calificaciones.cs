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

        /// <summary>
        /// Método para traer todos las Calificaciones en específico
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="periodo"></param>
        /// <returns>Un DataView con toda la información</returns>
        public static DataView GetDataViewCalificaciones(int clase, int periodo)
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");

            // Creamos la variable que contendrá el Query
            string sql;

            sql = @"SELECT			SCN.Alumnos.id				as Id,
                                    SCN.Alumnos.nombres			as Nombres,
                                    SCN.Alumnos.apellidos		as Apellidos,
                                    SCN.Calificaciones.nota1	as Nota1,
                                    SCN.Calificaciones.nota2	as Nota2,
                                    SCN.Calificaciones.nota3	as Nota3,
                                    SCN.Calificaciones.promedio as Promedio,
                                    SCN.Calificaciones.codigo   as Código
                    FROM SCN.Alumnos
                    INNER JOIN SCN.Registro
                    ON SCN.Registro.Alumnos_id = SCN.Alumnos.id
                    INNER JOIN SCN.Calificaciones
                    ON SCN.Calificaciones.Registro_codigo = SCN.Registro.codigo
                    WHERE SCN.Registro.Clases_codigo = @clase
                    AND SCN.Registro.Periodos_codigo = @periodo";

            try
            {
                SqlDataAdapter data = new SqlDataAdapter();

                // Enviamos el comando a ejecutar
                SqlCommand cmd = conexion.EjecutarComando(sql);

                // Especificamos las variables escalares
                cmd.Parameters.Add("@clase", SqlDbType.Int).Value = clase;
                cmd.Parameters.Add("@periodo", SqlDbType.Int).Value = periodo;

                data.SelectCommand = cmd;

                DataSet ds = new DataSet();
                // Tabla con que vamos a llenar los datos
                data.Fill(ds, "SCN.Calificaciones");
                DataTable dt = ds.Tables["SCN.Calificaciones"];

                DataView dv = new DataView(dt,
                    "", "Código",
                    DataViewRowState.Unchanged);
                return dv;

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
