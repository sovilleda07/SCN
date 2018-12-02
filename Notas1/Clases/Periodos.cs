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
    class Periodos
    {
        // Propiedades

        public int codigo { get; set; }
        public string descripcion { get; set; }
        public string descripcionNueva { get; set; }
        public string anio { get; set; }
        public int periodo { get; set; }
        public int habilitado { get; set; }

        /// <summary>
        /// Método para insertar un Periodo
        /// </summary>
        /// <param name="elPeriodo"></param>
        /// <returns>true si se realiza el método, false de lo contrario</returns>
        public static bool InsertarPeriodo(Periodos elPeriodo)
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");

            // enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_InsertarPeriodo");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 20));
            cmd.Parameters["@descripcion"].Value = elPeriodo.descripcion;

            cmd.Parameters.Add(new SqlParameter("@anio", SqlDbType.NVarChar, 5));
            cmd.Parameters["@anio"].Value = elPeriodo.anio;

            cmd.Parameters.Add(new SqlParameter("@periodo", SqlDbType.Int));
            cmd.Parameters["@periodo"].Value = elPeriodo.periodo;

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
        /// Método para actualizar un periodo
        /// </summary>
        /// <param name="elPeriodo"></param>
        /// <returns>true si se realiza el método, false de lo contrario</returns>
        public static bool ActualizarPeriodo(Periodos elPeriodo)
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");

            // enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_ActualizarPeriodo");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure

            cmd.Parameters.Add(new SqlParameter("@codigoPeriodo ", SqlDbType.Int));
            cmd.Parameters["@codigoPeriodo "].Value = elPeriodo.codigo;

            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 20));
            cmd.Parameters["@descripcion"].Value = elPeriodo.descripcion;

            cmd.Parameters.Add(new SqlParameter("@descripcionNueva", SqlDbType.NVarChar, 20));
            cmd.Parameters["@descripcionNueva"].Value = elPeriodo.descripcionNueva;

            cmd.Parameters.Add(new SqlParameter("@anio", SqlDbType.NVarChar, 5));
            cmd.Parameters["@anio"].Value = elPeriodo.anio;

            cmd.Parameters.Add(new SqlParameter("@periodo", SqlDbType.Int));
            cmd.Parameters["@periodo"].Value = elPeriodo.periodo;

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
        /// Método para Inhabilitar una carrera
        /// </summary>
        /// <param name="elPeriodo"></param>
        /// <returns>true si se realiza el método, false de lo contrario</returns>
        public static bool InhabilitarPeriodo(Periodos elPeriodo)
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");

            // enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_InhabilitarPeriodo");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@codigoPeriodo ", SqlDbType.Int));
            cmd.Parameters["@codigoPeriodo "].Value = elPeriodo.codigo;

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
        /// Método para Habilitar un periodo
        /// </summary>
        /// <param name="elPeriodo"></param>
        /// <returns>true si se realiza el método, false de lo contrario</returns>
        public static bool HabilitarCarrera(Periodos elPeriodo)
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");

            // enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_HabilitarPeriodo");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@codigoPeriodo ", SqlDbType.Int));
            cmd.Parameters["@codigoPeriodo "].Value = elPeriodo.codigo;

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
        /// Método para cargar los datos del DataGridView
        /// </summary>
        /// <returns>Un DataView con toda la información</returns>
        public static DataView GetDataView()
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");

            // Creamos la variable que contendrá el Query
            string sql;

            sql = @"SELECT      SCN.Periodos.codigo         as  Código,
                                SCN.Periodos.descripcion    as  Descripción,
                                SCN.Periodos.anio           as  Año,
                                SCN.Periodos.periodo        as  Periodo
                    FROM SCN.Periodos
                    WHERE SCN.Periodos.habilitado = 1";

            try
            {
                SqlDataAdapter data = new SqlDataAdapter();

                // Enviamos el comando a ejecutar
                SqlCommand cmd = conexion.EjecutarComando(sql);
                data.SelectCommand = cmd;

                DataSet ds = new DataSet();
                // Tabla con que vamos a llenar los datos
                data.Fill(ds, "SCN.Periodos");
                DataTable dt = ds.Tables["SCN.Periodos"];

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
        /// Método para obtener la información de un periodo en específico
        /// </summary>
        /// <param name="periodo"></param>
        /// <returns>Un objeto de tipo Periodo con la información</returns>
        public static Periodos ObtenerInformacionPeriodo(int codigo)
        {
            // Instanciamos la clase conexión
            Conexion conexion = new Conexion("Notas");

            // Creamos la variable que contendrá el Querys
            string sql;

            // Instanciamos la clase Periodo
            Periodos resultado = new Periodos();

            // Query SQL
            sql = @"SELECT *
                    FROM SCN.Periodos
                    WHERE codigo = @codigo";

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
                    resultado.codigo = Convert.ToInt16(rdr[0]);
                    resultado.descripcion = rdr.GetString(1);
                    resultado.anio = rdr.GetString(2);
                    resultado.periodo = Convert.ToInt16(rdr[3]);
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
