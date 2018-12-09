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

        // Propiedades para Obtener Información
        public int alumnoId { get; set; }
        public string alumnoNombres { get; set; }
        public string alumnoApellidos { get; set; }
        public int claseCodigo { get; set; }
        public string claseNombre { get; set; }
        public int periodoCodigo { get; set; }
        public string periodoDescripcion { get; set; }
        public string periodoAnio { get; set; }

        // Constructor
        public Calificaciones() { }

        /// <summary>
        /// Método para insertar una calificación
        /// </summary>
        /// <param name="laCalificacion"></param>
        /// <returns>true si se realiza el método, false de lo contrario</returns>
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

        /// <summary>
        /// Método para actualizar una calificación
        /// </summary>
        /// <param name="laCalificacion"></param>
        /// <returns></returns>
        public static bool ActualizarCalificacion(Calificaciones laCalificacion)
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_ActualizarCalificacion");

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

            cmd.Parameters.Add(new SqlParameter("@codigoCalificacion", SqlDbType.Int));
            cmd.Parameters["@codigoCalificacion"].Value = laCalificacion.codigo;

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
            // Establecer en la cultura, una modificación en el separador de decimal
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

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
                    AND SCN.Registro.Periodos_codigo = @periodo
                    AND SCN.Registro.estadoCalificacion = 1";

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

        /// <summary>
        /// Método para obtener información de una Calificación
        /// por medio de su código
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static Calificaciones ObtenerInformacion(int codigo)
        {
            // Establecer en la cultura, una modificación en el separador de decimal
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            // Instanciamos la clase Conexión
            Conexion conexion = new Conexion("Notas");

            // Creamos la variable que contendrá el Query
            string sql;

            // Instanciamos la Clase Registro
            Calificaciones resultado = new Calificaciones();

            // Query SQL
            sql = @"SELECT		SCN.Calificaciones.codigo,
                                SCN.Calificaciones.nota1,
			                    SCN.Calificaciones.nota2,
			                    SCN.Calificaciones.nota3,
			                    SCN.Calificaciones.promedio,
                                SCN.Registro.codigo,
                                SCN.Alumnos.id,
                                SCN.Alumnos.nombres,
                                SCN.Alumnos.apellidos,
                                SCN.Clases.codigo,
                                SCN.Clases.nombre,
                                SCN.Periodos.codigo,
                                SCN.Periodos.descripcion,
                                SCN.Periodos.anio
                    FROM SCN.Periodos
                    INNER JOIN SCN.Registro
                    ON SCN.Periodos.codigo = SCN.Registro.Periodos_codigo
                    INNER JOIN SCN.Clases
                    ON SCN.Clases.codigo = SCN.Registro.Clases_codigo
                    INNER JOIN SCN.Alumnos
                    ON SCN.Alumnos.id = SCN.Registro.Alumnos_id
                    INNER JOIN SCN.Calificaciones
                    ON SCN.Calificaciones.Registro_codigo = SCN.Registro.codigo
                    WHERE SCN.Registro.codigo = @codigo
                    AND SCN.Registro.estadoCalificacion = 1";

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando(sql);

            // Crearemos la lectura
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;

                    // Ejecutamos el quey vía un ExecuteReader
                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.codigo = Convert.ToInt16(rdr[0]);
                    resultado.nota1 = rdr.GetDecimal(1);
                    resultado.nota2 = rdr.GetDecimal(2);
                    resultado.nota3 = rdr.GetDecimal(3);
                    resultado.promedio = rdr.GetDecimal(4);
                    resultado.codigoRegistro = Convert.ToInt16(rdr[5]);
                    resultado.alumnoId = Convert.ToInt16(rdr[6]);
                    resultado.alumnoNombres = rdr.GetString(7);
                    resultado.alumnoApellidos = rdr.GetString(8);
                    resultado.claseCodigo = Convert.ToInt16(rdr[9]);
                    resultado.claseNombre = rdr.GetString(10);
                    resultado.periodoCodigo = Convert.ToInt16(rdr[11]);
                    resultado.periodoDescripcion = rdr.GetString(12);
                    resultado.periodoAnio = rdr.GetString(13);
                }

                return resultado;
            }
            catch (Exception)
            {

                return resultado;
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }




    }
}
