using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notas1.Clases;

namespace Notas1
{
    public partial class frmRegistro : Form
    {
        // Propiedad para almacenar información de otros formularios
        private int codigoPeriodo;
        private int codigoClase;
        private int codigoAlumno;
        //private string descripcionCarrera;
        public static string carreraNombre;
        // Propiedades para actualizar
        private int codigoPeriodoViejo;
        private int codigoClaseViejo;
        private int codigoAlumnoViejo;

        private int codigoRegistro;

        public frmRegistro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cargar todos los componentes al iniciar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRegistro_Load(object sender, EventArgs e)
        {
            Limpiar();
            
        }

        // Método para limpiar el formulario y resetear los valores en él
        private void Limpiar()
        {
            this.codigoPeriodo = 0;
            this.codigoClase = 0;
            this.codigoAlumno = 0;
            txtClase.Text = "";
            txtPeriodo.Text = "";
            txtAnio.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";

            toolStripGuardar.Enabled = true;
            toolStripActualizar.Enabled = false;
            btnClase.Focus();
        }

        // -----------------Carga de Datos-------------------------

        /// <summary>
        /// Evento para traer los datos de la Clase
        /// desde otro formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClase_Click(object sender, EventArgs e)
        {
            frmBuscar_Clases clase = new frmBuscar_Clases();
            clase.ShowDialog();
            txtClase.Text = frmBuscar_Clases.descripcionClase;
            this.codigoClase = frmBuscar_Clases.codigoClases;
            //this.descripcionCarrera = frmBuscar_Clases.carrera;
            carreraNombre= frmBuscar_Clases.carrera;
           
        }

        /// <summary>
        /// Evento para traer los datos del periodo
        /// desde otro formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            frmBuscar_Periodo periodo = new frmBuscar_Periodo();
            periodo.ShowDialog();

            txtPeriodo.Text = frmBuscar_Periodo.descripcionPeriodo;
            txtAnio.Text = frmBuscar_Periodo.anioPeriodo;
            this.codigoPeriodo = frmBuscar_Periodo.codigoPeriodo;
        }

        /// <summary>
        /// Evento para traer los datos del Alumnno
        /// desde otro formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlumno_Click(object sender, EventArgs e)
        {
            if (txtClase.Text == "")
            {
                MessageBox.Show("Debe seleccionar una clase");
            }
            else
            {
                frmBuscar_Alumno alumno = new frmBuscar_Alumno();
                alumno.ShowDialog();
                this.codigoAlumno = frmBuscar_Alumno.codigoAlumno;
                txtNombre.Text = frmBuscar_Alumno.nombre;
                txtApellido.Text = frmBuscar_Alumno.apellido;

            }
            
        }
        
        /// <summary>
        /// Evento para cargar los datos del alumno
        /// Al ser selecionado en el DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRegistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Instanciamos la clase Registro
            Registro elRegistro = new Registro();

            elRegistro = Registro.ObtenerInformacion(Convert.ToInt16(dgvRegistro.Rows[e.RowIndex].Cells["Código"].Value));

            txtNombre.Text = elRegistro.alumnoNombre;
            txtApellido.Text = elRegistro.alumnoApellido;
            this.codigoAlumnoViejo = elRegistro.Alumnos_id;
            this.codigoClaseViejo = elRegistro.Clases_codigo;
            this.codigoPeriodoViejo = elRegistro.Periodos_codigo;
            this.codigoRegistro = elRegistro.codigo;

            MessageBox.Show(this.codigoRegistro.ToString());


        }

        // ---------------------------- CRUD -----------------------------
        /// <summary>
        /// Evento para Guardar un registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            if (txtClase.Text == "" || txtPeriodo.Text == "" || txtNombre.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los datos", "Información");
            }
            else
            {
                // Instanciamos la Clase Registro
                Registro elRegistro = new Registro();

                // Nuestro objeto adquiere los valores del formulario
                elRegistro.Alumnos_id = this.codigoAlumno;
                elRegistro.Clases_codigo = this.codigoClase;
                elRegistro.Periodos_codigo = this.codigoPeriodo;

                // Verificamos si se realizó el método
                if (Registro.InsertarRegistro(elRegistro))
                {
                    MessageBox.Show("Alumno Agregado", "Información");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                }
            }
        }

        private void toolStripActualizar_Click(object sender, EventArgs e)
        {
            if (txtClase.Text == "" || txtPeriodo.Text == "" || txtNombre.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los datos", "Información");
            }
            else
            {
                if (dgvRegistro.SelectedRows.Count == 1)
                {
                    // Instanciamos la clase Registro
                    Registro elRegistro = new Registro();

                    // Nuestro objeto adquiere los valores del formulario
                    elRegistro.codigo = this.codigoRegistro;
                    elRegistro.Alumnos_id = this.codigoAlumnoViejo;
                    elRegistro.Clases_codigo = this.codigoClaseViejo;
                    elRegistro.Periodos_codigo = this.codigoPeriodoViejo;

                    elRegistro.Alumnos_idNuevo = this.codigoAlumno;
                    elRegistro.Clases_codigoNuevo = this.codigoClase;
                    elRegistro.Periodos_codigoNuevo = this.codigoPeriodo;

                    // Verificamos si se realizó el método
                    if (Registro.ActualizarRegistro(elRegistro))
                    {
                        MessageBox.Show("Registro Actualizado", "Información");
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                    }
                }
                else
                {
                    MessageBox.Show("Debe Seleccionar una fila");
                }
            }

        }

        /// <summary>
        /// Evento para buscar un registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBuscar_Click(object sender, EventArgs e)
        {
            if (txtClase.Text == "" || txtPeriodo.Text == "")
            {
                MessageBox.Show("Seleccione una clase y periodo", "Información");
            }
            else
            {
                try
                {
                    // El origen de los datos del DataGridView
                    // Está en un método en la la Clase Registro,
                    // hacemos referencia a él.
                    dgvRegistro.DataSource = Registro.GetDataViewRegistro(this.codigoClase, this.codigoPeriodo);
                    toolStripGuardar.Enabled = false;
                    toolStripActualizar.Enabled = true; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        /// <summary>
        /// Evento para limpiar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Evento para cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
