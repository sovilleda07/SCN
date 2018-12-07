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
    class Registro
    {
        // Propiedades
        public int codigo { get; set; }
        public DateTime fecha { get; set; }
        public int Alumnos_id { get; set; }
        public int Clases_codigo { get; set; }
        public int Periodos_codigo { get; set; }


        public int codigoNuevo { get; set; }
        public DateTime fechaNueva { get; set; }
        public int Alumnos_idNuevo { get; set; }
        public int Clases_codigoNuevo { get; set; }
        public int Periodos_codigoNuevo { get; set; }

        public string alumnoNombre { get; set; }
        public string alumnoApellido { get; set; }
        public string claseNombre { get; set; }
        public string periodoDescripcion { get; set; }
        public string periodoAnio { get; set; }
        public int periodoNumero { get; set; }


        // Constructor
        public Registro() { }

        // Métodos

        /// <summary>
        /// Método para insertar un registro de clase
        /// </summary>
        /// <param name="elRegistro"></param>
        /// <returns>true si se realiza el método, false de lo contrario</returns>
        public static bool InsertarRegistro(Registro elRegistro)
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_InsertarRegistro");

            // Establecemos el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime));
            cmd.Parameters["@fecha"].Value = System.DateTime.Now;

            cmd.Parameters.Add(new SqlParameter("@alumnosId", SqlDbType.Int));
            cmd.Parameters["@alumnosId"].Value = elRegistro.Alumnos_id;

            cmd.Parameters.Add(new SqlParameter("@clasescodigo", SqlDbType.Int));
            cmd.Parameters["@clasescodigo"].Value = elRegistro.Clases_codigo;

            cmd.Parameters.Add(new SqlParameter("@periodosCodigo", SqlDbType.Int));
            cmd.Parameters["@periodosCodigo"].Value = elRegistro.Periodos_codigo;

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
        /// /Método para actualizar el registro de una clase
        /// </summary>
        /// <param name="elRegistro"></param>
        /// <returns>true si se realiza el método, false de lo contrario</returns>
        public static bool ActualizarRegistro(Registro elRegistro)
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_ActualizarRegistro");

            // Establecemos el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure

            cmd.Parameters.Add(new SqlParameter("@codigoRegistro", SqlDbType.Int));
            cmd.Parameters["@codigoRegistro"].Value = elRegistro.codigo;

            cmd.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime));
            cmd.Parameters["@fecha"].Value = System.DateTime.Now;

            cmd.Parameters.Add(new SqlParameter("@alumnosId", SqlDbType.Int));
            cmd.Parameters["@alumnosId"].Value = elRegistro.Alumnos_id;

            cmd.Parameters.Add(new SqlParameter("@clasescodigo", SqlDbType.Int));
            cmd.Parameters["@clasescodigo"].Value = elRegistro.Clases_codigo;

            cmd.Parameters.Add(new SqlParameter("@periodosCodigo", SqlDbType.Int));
            cmd.Parameters["@periodosCodigo"].Value = elRegistro.Periodos_codigo;

            cmd.Parameters.Add(new SqlParameter("@alumnosIdNuevo", SqlDbType.Int));
            cmd.Parameters["@alumnosId"].Value = elRegistro.Alumnos_idNuevo;

            cmd.Parameters.Add(new SqlParameter("@clasescodigoNuevo", SqlDbType.Int));
            cmd.Parameters["@clasescodigo"].Value = elRegistro.Clases_codigoNuevo;

            cmd.Parameters.Add(new SqlParameter("@periodosCodigoNuevo", SqlDbType.Int));
            cmd.Parameters["@periodosCodigo"].Value = elRegistro.Periodos_codigoNuevo;

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
        /// Método para Cargar los datos al DataGridView
        /// </summary>
        /// <returns>Un DataView con toda la información</returns>
        public static DataView GetDataView()
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");

            // Creamos la variable que contendrá el Query
            string sql;

            sql = @"SELECT      SCN.Alumnos.id                  as Código,
                                SCN.Alumnos.nombres				as Nombres,
		                        SCN.Alumnos.apellidos			as Apellidos,
		                        SCN.Clases.nombre				as Clase,
		                        SCN.Periodos.descripcion		as Periodo
                    FROM SCN.Registro 
                    INNER JOIN SCN.Alumnos
                    ON SCN.Registro.Alumnos_id = SCN.Alumnos.id
                    INNER JOIN SCN.Clases
                    ON SCN.Registro.Clases_codigo = SCN.Clases.codigo 
                    INNER JOIN SCN.Periodos
                    ON SCN.Registro.Periodos_codigo = SCN.Periodos.codigo";
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();

                // Enviamos el comando a ejecutar
                SqlCommand cmd = conexion.EjecutarComando(sql);
                data.SelectCommand = cmd;

                DataSet ds = new DataSet();
                // Tabla con que vamos a llenar los datos
                data.Fill(ds, "SCN.Registro");
                DataTable dt = ds.Tables["SCN.Registro"];

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
        /// Método para traer todos los alumnos de una clase en específico
        /// </summary>
        /// <returns>Un DataView con toda la información</returns>
        public static DataView GetDataViewRegistro(int clase, int periodo)
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");

            // Creamos la variable que contendrá el Query
            string sql;

            sql = @"SELECT		SCN.Alumnos.id					as Id,
                                SCN.Alumnos.nombres				as Nombres,
                                SCN.Alumnos.apellidos			as Apellidos,
		                        SCN.Clases.nombre				as Clase,
		                        SCN.Periodos.descripcion		as Periodo,
                                SCN.Periodos.anio               as Año,
		                        SCN.Registro.codigo				as Código
                    FROM SCN.Registro
                    INNER JOIN SCN.Alumnos
                    ON SCN.Alumnos.id = SCN.Registro.Alumnos_id
                    INNER JOIN SCN.Clases
                    ON SCN.Clases.codigo = SCN.Registro.Clases_codigo
                    INNER JOIN SCN.Periodos
                    ON SCN.Periodos.codigo = SCN.Registro.Periodos_codigo
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
                data.Fill(ds, "SCN.Registro");
                DataTable dt = ds.Tables["SCN.Registro"];

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
        /// Método para obtener información de un Registro
        /// por medio de su código
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns>Un objeto de tipo Registro con los datos</returns>
        public static Registro ObtenerInformacion(int codigo)
        {
            // Instanciamos la clase Conexión
            Conexion conexion = new Conexion("Notas");

            // Creamos la variable que contendrá el Query
            string sql;

            // Instanciamos la Clase Registro
            Registro resultado = new Registro();

            // Query SQL
            sql = @"SELECT      SCN.Registro.codigo,
                                SCN.Alumnos.id,
                                SCN.Alumnos.nombres,
                                SCN.Alumnos.apellidos,
                                SCN.Clases.codigo,
                                SCN.Clases.nombre,
                                SCN.Periodos.codigo,
                                SCN.Periodos.descripcion,
                                SCN.Periodos.anio,
                                SCN.Periodos.periodo
                    FROM SCN.Periodos
                    INNER JOIN SCN.Registro
                    ON SCN.Periodos.codigo = SCN.Registro.Periodos_codigo
                    INNER JOIN SCN.Clases
                    ON SCN.Clases.codigo = SCN.Registro.Clases_codigo
                    INNER JOIN SCN.Alumnos
                    ON SCN.Alumnos.id = SCN.Registro.Alumnos_id
                    WHERE SCN.Registro.codigo = @codigo";

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
                    resultado.Alumnos_id = Convert.ToInt16(rdr[1]);
                    resultado.alumnoNombre = rdr.GetString(2);
                    resultado.alumnoApellido = rdr.GetString(3);
                    resultado.Clases_codigo = Convert.ToInt16(rdr[4]);
                    resultado.claseNombre = rdr.GetString(5);
                    resultado.Periodos_codigo = Convert.ToInt16(rdr[6]);
                    resultado.periodoDescripcion = rdr.GetString(7);
                    resultado.periodoAnio = rdr.GetString(8);
                    resultado.periodoNumero = Convert.ToInt16(rdr[9]);

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
