using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Notas1.Clases
{
    class Alumnos
    {
        // Propiedades
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string observaciones { get; set; }
        public int habilitado { get; set; }
        public string descripcionCarrera { get; set; }

        // Constructor
        public Alumnos() { }

        // Métodos

        /// <summary>
        /// Método para insertar un alumno
        /// </summary>
        /// <param name="elAlumno"></param>
        /// <returns>true si se realiza el método, false de lo contrario</returns>
        public static bool InsertarAlumno(Alumnos elAlumno)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion("Notas");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_InsertarAlumno");

            // Establecemos el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@nombres", SqlDbType.NVarChar, 45));
            cmd.Parameters["@nombres"].Value = elAlumno.nombres;

            cmd.Parameters.Add(new SqlParameter("@apellidos", SqlDbType.NVarChar, 45));
            cmd.Parameters["@apellidos"].Value = elAlumno.apellidos;

            cmd.Parameters.Add(new SqlParameter("@telefono", SqlDbType.NVarChar, 10));
            cmd.Parameters["@telefono"].Value = elAlumno.telefono;

            cmd.Parameters.Add(new SqlParameter("@correoElectronico", SqlDbType.NVarChar, 50));
            cmd.Parameters["@correoElectronico"].Value = elAlumno.correo;

            cmd.Parameters.Add(new SqlParameter("@observaciones", SqlDbType.NVarChar, 60));
            cmd.Parameters["@observaciones"].Value = elAlumno.observaciones;

            cmd.Parameters.Add(new SqlParameter("@descripcionCarrera", SqlDbType.NVarChar, 45));
            cmd.Parameters["@descripcionCarrera"].Value = elAlumno.descripcionCarrera;

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
        /// Método para actualizar un alumno
        /// </summary>
        /// <param name="elAlumno"></param>
        /// <returns>true si se realiza el método, false de lo contrario</returns>
        public static bool ActualizarAlumno(Alumnos elAlumno)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion("Notas");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_ActualizarAlumno");

            // Establecemos el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters["@id"].Value = elAlumno.id;

            cmd.Parameters.Add(new SqlParameter("@nombres", SqlDbType.NVarChar, 45));
            cmd.Parameters["@nombres"].Value = elAlumno.nombres;

            cmd.Parameters.Add(new SqlParameter("@apellidos", SqlDbType.NVarChar, 45));
            cmd.Parameters["@apellidos"].Value = elAlumno.apellidos;

            cmd.Parameters.Add(new SqlParameter("@telefono", SqlDbType.NVarChar, 10));
            cmd.Parameters["@telefono"].Value = elAlumno.telefono;

            cmd.Parameters.Add(new SqlParameter("@correoElectronico", SqlDbType.NVarChar, 50));
            cmd.Parameters["@correoElectronico"].Value = elAlumno.correo;

            cmd.Parameters.Add(new SqlParameter("@observaciones", SqlDbType.NVarChar, 60));
            cmd.Parameters["@observaciones"].Value = elAlumno.observaciones;

            cmd.Parameters.Add(new SqlParameter("@descripcionCarrera", SqlDbType.NVarChar, 45));
            cmd.Parameters["@descripcionCarrera"].Value = elAlumno.descripcionCarrera;

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
        /// Método para Inhabilitar un Alumno
        /// </summary>
        /// <param name="elAlumno"></param>
        /// <returns></returns>
        public static bool InhabilitarAlumno(Alumnos elAlumno)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion("Notas");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_InhabilitarAlumno");

            // Establecemos el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters["@id"].Value = elAlumno.id;

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
        /// Método para habilitar un Alumno
        /// </summary>
        /// <param name="elAlumno"></param>
        /// <returns></returns>
        public static bool HabilitarAlumno(Alumnos elAlumno)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion("Notas");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_HabilitarAlumno");

            // Establecemos el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmd.Parameters["@id"].Value = elAlumno.id;

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

        public static DataView GetDataView()
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");
            // Creamos la variable que contendrá el Query
            string sql;

            sql = @"SELECT     SCN.Alumnos.id               as Código,
                               SCN.Alumnos.nombres                  as Combres,
                               SCM.Alumnos.apellidos                as Apellido,
                               SCN.Alumnos.telefono                 as Teléfono,
                               SCN.Alumnos,correoElectronico        as Carrera
                    FROM SNC.Carreras
                    INNER JOIN SCN.Alumnos
                    ON SCN.Carreras.codigo = SCN.Alumnos.Carreras_codigo
                    WHERE SCN.Alumno.habilitado = 1";
        }





    }
}
