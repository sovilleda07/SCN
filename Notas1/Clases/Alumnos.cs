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

        /// <summary>
        /// Método para cargar los datos al DataGridView
        /// </summary>
        /// <returns>Un DataView con toda la información</returns>
        public static DataView GetDataView()
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");
            // Creamos la variable que contendrá el Query
            string sql;

            sql = @"SELECT     SCN.Alumnos.id                       as Código,
                               SCN.Alumnos.nombres                  as Nombres,
                               SCN.Alumnos.apellidos                as Apellidos,
                               SCN.Alumnos.telefono                 as Teléfono,
                               SCN.Alumnos.correoElectronico        as Correo,
                               SCN.Alumnos.observaciones            as Observaciones,
                               SCN.Carreras.descripcion             as Carrera
                    FROM SCN.Carreras
                    INNER JOIN SCN.Alumnos
                    ON SCN.Carreras.codigo = SCN.Alumnos.Carreras_codigo
                    WHERE SCN.Alumnos.habilitado = 1";

            try
            {
                SqlDataAdapter data = new SqlDataAdapter();

                //Enviamos el comando a ejecutar
                SqlCommand cmd = conexion.EjecutarComando(sql);
                data.SelectCommand = cmd;

                DataSet ds = new DataSet();
                // Tabla con que vamos a llenar los datos
                data.Fill(ds, "SCN.Alumnos");
                DataTable dt = ds.Tables["SCN.Alumnos"];

                DataView dv = new DataView(dt,
                    "",
                    "Código",
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
        /// Método para obtener información de un alumno
        /// por medio de su código
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>Un objeto de tipo Alumno con los datos</returns>
        public static Alumnos ObtenerInformacionAlumnos(int codigo)
        {
            // Instanciamos la clase Conexion
            Conexion conexion = new Conexion("Notas");

            // Creamos la variable que contendrá el Query
            string sql;

            // Intanciamos la clase Alumnos
            Alumnos resultado = new Alumnos();

            // Query SQL
            sql = @"SELECT      SCN.Alumnos.id,
                                SCN.Alumnos.nombres,
                                SCN.Alumnos.apellidos,
                                SCN.Alumnos.telefono,
                                SCN.Alumnos.correoElectronico,
                                SCN.Alumnos.observaciones,
                                SCN.Carreras.descripcion
                    FROM SCN.Carreras
                    INNER JOIN SCN.Alumnos
                    ON SCN.Carreras.codigo = SCN.Alumnos.Carreras_codigo
                    WHERE SCN.Alumnos.id = @codigo";

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando(sql);

            // Crearemos la lectura
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = codigo;
                    // Ejecutamos el query vía un ExecuteReader
                    rdr = cmd.ExecuteReader(); 
                }

                while (rdr.Read())
                {
                    resultado.id = Convert.ToInt16(rdr[0]);
                    resultado.nombres = rdr.GetString(1);
                    resultado.apellidos = rdr.GetString(2);
                    resultado.telefono = rdr.GetString(3);
                    resultado.correo = rdr.GetString(4);
                    resultado.observaciones = rdr.GetString(5);
                    resultado.descripcionCarrera = rdr.GetString(6);
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

        /// <summary>
        /// Método para cargar al DataGridView
        /// Los datos de un Alumno, según su carrera
        /// </summary>
        /// <param name="carrera"></param>
        /// <returns></returns>
        public static DataView GetDataViewAlumnoCarrera(string carrera)
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");
            // Creamos la variable que contendrá el Query
            string sql;

            sql = @"DECLARE @codigoCarreras INT;
                    SET @codigoCarreras = (SELECT codigo FROM SCN.Carreras WHERE descripcion = @carrera)

                    SELECT     SCN.Alumnos.id                       as Código,
                               SCN.Alumnos.nombres                  as Nombres,
                               SCN.Alumnos.apellidos                as Apellidos,
                               SCN.Alumnos.telefono                 as Teléfono,
                               SCN.Alumnos.observaciones            as Observaciones
                    FROM SCN.Alumnos
                    INNER JOIN SCN.Carreras
                    ON SCN.Carreras.codigo = SCN.Alumnos.Carreras_codigo
                    AND SCN.Carreras.codigo = @codigoCarreras
                    AND SCN.Alumnos.habilitado = 1";

            try
            {
                SqlDataAdapter data = new SqlDataAdapter();

                //Enviamos el comando a ejecutar
                SqlCommand cmd = conexion.EjecutarComando(sql);
                cmd.Parameters.Add("@carrera", SqlDbType.NVarChar,50).Value = carrera;
                data.SelectCommand = cmd;

                DataSet ds = new DataSet();
                // Tabla con que vamos a llenar los datos
                data.Fill(ds, "SCN.Alumnos");
                DataTable dt = ds.Tables["SCN.Alumnos"];

                DataView dv = new DataView(dt,
                    "",
                    "Código",
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

        ///// <summary>
        ///// Método para cargar al DataGridView
        ///// Los datos de un Alumno, según su carrera
        ///// </summary>
        ///// <param name="carrera"></param>
        ///// <returns></returns>
        public static DataView GetDataViewAlumnoCalificación(int clase, int periodo)
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");
            // Creamos la variable que contendrá el Query
            string sql;

            sql = @"SELECT		SCN.Alumnos.id			as Id,
                                SCN.Alumnos.nombres     as Nombres,
                                SCN.Alumnos.apellidos   as Apellidos,
                                SCN.Registro.codigo     as Registro
                    FROM SCN.Registro
                    INNER JOIN SCN.Alumnos
                    ON SCN.Alumnos.id = SCN.Registro.Alumnos_id
                    INNER JOIN SCN.Clases
                    ON SCN.Clases.codigo = SCN.Registro.Clases_codigo
                    INNER JOIN SCN.Periodos
                    ON SCN.Periodos.codigo = SCN.Registro.Periodos_codigo
                    WHERE SCN.Registro.Clases_codigo = @clase
                    AND SCN.Registro.Periodos_codigo = @periodo
                    AND SCN.Registro.estadoCalificacion = 0;";

            try
            {
                SqlDataAdapter data = new SqlDataAdapter();

                //Enviamos el comando a ejecutar
                SqlCommand cmd = conexion.EjecutarComando(sql);

                cmd.Parameters.Add("@clase", SqlDbType.Int).Value = clase;

                cmd.Parameters.Add("@periodo", SqlDbType.Int).Value = periodo;

                data.SelectCommand = cmd;

                DataSet ds = new DataSet();
                // Tabla con que vamos a llenar los datos
                data.Fill(ds, "SCN.Alumnos");
                DataTable dt = ds.Tables["SCN.Alumnos"];

                DataView dv = new DataView(dt,
                    "",
                    "Id",
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
        /// Método para cargar los datos al DataGridView inhabilitados
        /// </summary>
        /// <returns></returns>
        public static DataView GetDataViewInhabilitados()
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");
            // Creamos la variable que contendrá el Query
            string sql;

            sql = @"SELECT     SCN.Alumnos.id                       as Código,
                               SCN.Alumnos.nombres                  as Nombres,
                               SCN.Alumnos.apellidos                as Apellidos,
                               SCN.Alumnos.telefono                 as Teléfono,
                               SCN.Alumnos.correoElectronico        as Correo,
                               SCN.Alumnos.observaciones            as Observaciones,
                               SCN.Carreras.descripcion             as Carrera
                    FROM SCN.Carreras
                    INNER JOIN SCN.Alumnos
                    ON SCN.Carreras.codigo = SCN.Alumnos.Carreras_codigo
                    WHERE SCN.Alumnos.habilitado = 0";

            try
            {
                SqlDataAdapter data = new SqlDataAdapter();

                //Enviamos el comando a ejecutar
                SqlCommand cmd = conexion.EjecutarComando(sql);
                data.SelectCommand = cmd;

                DataSet ds = new DataSet();
                // Tabla con que vamos a llenar los datos
                data.Fill(ds, "SCN.Alumnos");
                DataTable dt = ds.Tables["SCN.Alumnos"];

                DataView dv = new DataView(dt,
                    "",
                    "Código",
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
