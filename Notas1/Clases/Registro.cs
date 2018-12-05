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

        public static bool ActualizarRegistro(Registro elRegistro)
        {
            return true;
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

            sql = @"SELECT      SCN.Registro.codigo             as Registro,
                                SCN.Alumnos.id                  as Código,
                                SCN.Alumnos.nombres				as Nombres,
		                        SCN.Alumnos.apellidos			as Apellidos,
		                        SCN.Clases.nombre				as Clase,
		                        SCN.Periodos.descripcion		as Periodo
                    FROM SCN.Registro 
                    INNER JOIN SCN.Alumnos
                    ON SCN.Registro.Alumnos_id = SCN.Alumnos.id
                    INNER JOIN SCN.Clases
                    ON SCN.Clases.codigo = @clase
                    INNER JOIN SCN.Periodos
                    ON SCN.Periodos.codigo = @periodo";
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


    }
}
