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
    class Clases
    {
        // Propiedades
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string nombreNuevo { get; set; }
        public int creditos { get; set; }
        public int habilitado { get; set; }
        public string descripcionCarrera { get; set; }


        /// <summary>
        /// Método para insertar una clase
        /// </summary>
        /// <param name="laClase"></param>
        /// <returns>true si se realiza el método, false de lo contrario</returns>
        public static bool InsertarClase(Clases laClase)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion("Notas");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_InsertarClase");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetro del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar, 45));
            cmd.Parameters["@nombre"].Value = laClase.nombre;

            cmd.Parameters.Add(new SqlParameter("@creditos", SqlDbType.Int));
            cmd.Parameters["@creditos"].Value = laClase.creditos;

            cmd.Parameters.Add(new SqlParameter("@descripcionCarrera", SqlDbType.NVarChar, 45));
            cmd.Parameters["@descripcionCarrera"].Value = laClase.descripcionCarrera;

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
        /// Método para actualizar una clase
        /// </summary>
        /// <param name="laClase"></param>
        /// <returns>true si se realiza el método, false de lo contrario</returns>
        public static bool ActualizarClase(Clases laClase)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion("Notas");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_ActualizarClase");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetro del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar, 45));
            cmd.Parameters["@nombre"].Value = laClase.nombre;

            cmd.Parameters.Add(new SqlParameter("@nombreNuevo", SqlDbType.NVarChar, 45));
            cmd.Parameters["@nombreNuevo"].Value = laClase.nombreNuevo;

            cmd.Parameters.Add(new SqlParameter("@creditos", SqlDbType.Int));
            cmd.Parameters["@creditos"].Value = laClase.creditos;

            cmd.Parameters.Add(new SqlParameter("@descripcionCarrera", SqlDbType.NVarChar, 45));
            cmd.Parameters["@descripcionCarrera"].Value = laClase.descripcionCarrera;

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
        /// Método para inhabilitar una clase
        /// </summary>
        /// <param name="laClase"></param>
        /// <returns></returns>
        public static bool InhabilitarClase(Clases laClase)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion("Notas");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_InhabilitarClase");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetro del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar, 45));
            cmd.Parameters["@nombre"].Value = laClase.nombre;

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
        /// Método para Habilitar una carrera
        /// </summary>
        /// <param name="laClase"></param>
        /// <returns></returns>
        public static bool HabilitarCarrera(Clases laClase)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion("Notas");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_HabilitarClase");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int));
            cmd.Parameters["@codigo"].Value = laClase.codigo;

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
            // Instanciamos la conexion
            Conexion conexion = new Conexion("Notas");
            // Creamos la variable que contendrá el Query
            string sql;

            sql = @"SELECT  SCN.Clases.codigo           as  Código,
                            SCN.Clases.nombre           as  Nombre,
                            SCN.Clases.creditos         as  Créditos,
                            SCN.Carreras.descripcion    as  Carrera
                     FROM SCN.Carreras
                     INNER JOIN SCN.Clases
                     ON SCN.Carreras.codigo = SCN.Clases.Carreras_codigo
                     WHERE SCN.Clases.habilitado = 1";

            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                // Enviamos el comando a ejecutar
                SqlCommand cmd = conexion.EjecutarComando(sql);
                data.SelectCommand = cmd;
                DataSet ds = new DataSet();
                // Tabla con que vamos a llenar los datos
                data.Fill(ds, "SCN.Clases");
                DataTable dt = ds.Tables["SCN.Clases"];
                DataView dv = new DataView(dt,
                    "",
                    "Nombre",
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

        public static Clases ObtenerInformacionClase(string clase)
        {
            // Instanciamos la clase Conexion
            Conexion conexion = new Conexion("Notas");
            // Creamos la variable que contendrá el Query
            string sql;
            // Instanciamos la clase Carreras
            Clases resultado = new Clases();

            // Query SQL
            sql = @"SELECT  SCN.Clases.codigo,
                            SCN.Clases.nombre,
                            SCN.Clases.creditos,
                            SCN.Carreras.descripcion
                     FROM SCN.Carreras
                     INNER JOIN SCN.Clases
                     ON SCN.Carreras.codigo = SCN.Clases.Carreras_codigo
                     WHERE SCN.Clases.nombre = @clase";

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando(sql);

            // Crearemos la lectura
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@clase", SqlDbType.NVarChar, 45).Value = clase;
                    // Ejecutamos el query vía un ExecuteReader
                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.codigo = Convert.ToInt16(rdr[0]);
                    resultado.nombre = rdr.GetString(1);
                    resultado.creditos = Convert.ToInt16(rdr[2]);
                    resultado.descripcionCarrera = rdr.GetString(3);
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
        /// Método para listar todas las Clases
        /// </summary>
        /// <returns>Una lista con todas las Clases</returns>
        public static List<Clases> LeerClasesHabilitadas()
        {
            // Instanciamos la clase conexión
            Conexion conexion = new Conexion("Notas");

            // Creamos una lista de tipo de cliente
            List<Clases> resultados = new List<Clases>();

            // Creamos el query
            string sql = @"SELECT codigo, nombre
                            FROM SCN.Clases
                            WHERE habilitado = 1";

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando(sql);

            try
            {
                // Establecemos la conexión
                conexion.EstablecerConexion();

                // Ejecutamos el query vía un ExecuteReader
                SqlDataReader rdr = cmd.ExecuteReader();

                // Recorremos los elementos del Reader y los almacenamos 
                // en la lista de tipos Clases

                while (rdr.Read())
                {
                    Clases laClase = new Clases();

                    // Asignamos los valores del Reader al objeto
                    laClase.codigo = Convert.ToInt16(rdr[0]);
                    laClase.nombre = rdr.GetString(1);

                    // Agregamos la Clase a la lista
                    resultados.Add(laClase);
                }

                // Retornamos la lista de las Clases
                return resultados;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Errors[0].ToString());

                return resultados;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        /// <summary>
        /// Método para listar todas las Clases
        /// </summary>
        /// <returns></returns>
        public static DataView GetDataViewInhabilitadas()
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion("Notas");
            // Creamos la variable que contendrá el Query
            string sql;

            sql = @"SELECT  SCN.Clases.codigo           as  Código,
                            SCN.Clases.nombre           as  Nombre,
                            SCN.Clases.creditos         as  Créditos,
                            SCN.Carreras.descripcion    as  Carrera
                     FROM SCN.Carreras
                     INNER JOIN SCN.Clases
                     ON SCN.Carreras.codigo = SCN.Clases.Carreras_codigo
                     WHERE SCN.Clases.habilitado = 0";

            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                // Enviamos el comando a ejecutar
                SqlCommand cmd = conexion.EjecutarComando(sql);
                data.SelectCommand = cmd;
                DataSet ds = new DataSet();
                // Tabla con que vamos a llenar los datos
                data.Fill(ds, "SCN.Clases");
                DataTable dt = ds.Tables["SCN.Clases"];
                DataView dv = new DataView(dt,
                    "",
                    "Nombre",
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
