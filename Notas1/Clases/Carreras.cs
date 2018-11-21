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
    class Carreras
    {
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public string descripcionNueva { get; set; }
        public int habilitado { get; set; }

        /// <summary>
        /// Método para insertar una carrera
        /// </summary>
        /// <param name="laCarrera"></param>
        /// <returns>true si se realiza la inserción, false de lo contrario</returns>
        public static bool InsertarCarrera(Carreras laCarrera)
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");

            // enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_InsertarCarrera");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 25));
            cmd.Parameters["@descripcion"].Value = laCarrera.descripcion;

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
        /// Método para actualizar una carrera
        /// </summary>
        /// <param name="laCarrera"></param>
        /// <returns>true si se realiza la inserción, false de lo contrario</returns>
        public static bool ActualizarCarrera(Carreras laCarrera)
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");

            // enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_ActualizarCarrera");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 25));
            cmd.Parameters["@descripcion"].Value = laCarrera.descripcion;
            cmd.Parameters.Add(new SqlParameter("@descripcionNueva", SqlDbType.NVarChar, 25));
            cmd.Parameters["@descripcionNueva"].Value = laCarrera.descripcionNueva;

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
        /// Método para inhabilitar una carrera
        /// </summary>
        /// <param name="laCarrera"></param>
        /// <returns>true si se realiza la inserción, false de lo contrario</returns>
        public static bool InhabilitarCarrera(Carreras laCarrera)
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");

            // enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_InhabilitarCarrera");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 25));
            cmd.Parameters["@descripcion"].Value = laCarrera.descripcion;

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

        public static bool HabilitarCarrera(Carreras laCarrera)
        {
            // Instanciamos la conexión
            Conexion conexion = new Conexion("Notas");

            // enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_HablitarCarrera");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 25));
            cmd.Parameters["@descripcion"].Value = laCarrera.descripcion;

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
        /// Método para listar todos las Carreras
        /// </summary>
        /// <returns></returns>
        public static List<Carreras> LeerTodosHabilitados()
        {
            // Instanciamos la clase Conexion
            Conexion conexion = new Conexion("Notas");

            // Creamos una lista de tipo de cliente
            List<Carreras> resultados = new List<Carreras>();

            // Creamos el query
            string sql = @"SELECT codigo, descripcion
                            FROM SCN.Carreras
                            WHERE habilitado = 1";

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando(sql);

            try
            {
                // Establecemos la conexion
                conexion.EstablecerConexion();

                // Ejecutamos el query vía un ExecuteReader
                SqlDataReader rdr = cmd.ExecuteReader();

                // Recorremos los elementos del Reader y los almacenamos
                // en la lista de tipo Carreras

                while (rdr.Read())
                {
                    Carreras laCarrera = new Carreras();

                    // Asignamos los valores del Reader al objeto
                    laCarrera.codigo = Convert.ToInt16(rdr[0]);
                    laCarrera.descripcion = rdr.GetString(1);

                    // Agregamos la Carrera a la lista
                    resultados.Add(laCarrera);
                }

                // retornamos la lista de las Carreras
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


    }



}
