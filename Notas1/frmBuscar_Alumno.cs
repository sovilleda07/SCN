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
    public partial class frmBuscar_Alumno : Form
    {
        // Propiedad para el constructor
        private string descripcionCarrera;

        // Propiedades para obtener valores
        public static int codigoAlumno;
        public static string nombre;
        public static string apellido;

        // Constructores
        public frmBuscar_Alumno()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cargar todos los componentes al iniciar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBuscar_Alumno_Load(object sender, EventArgs e)
        {
            descripcionCarrera = frmRegistro.carreraNombre;
            CargarDGVAlumnos();
        }

        // -----------------------Carga de Datos---------------------

        /// <summary>
        /// Método para Cargar los datos al DataGrid
        /// </summary>
        private void CargarDGVAlumnos()
        {
            try
            {
                dgvAlumnos.DataSource = Alumnos.GetDataViewAlumnoCarrera(descripcionCarrera);
                //dgvAlumnos.Columns[2].AutoSizeMode= DataGridViewAutoSizeColumnMode.Fill ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento para cargar los datos del alumno
        /// al ser seleccionado en el DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoAlumno = Convert.ToInt16(dgvAlumnos.Rows[e.RowIndex].Cells["Código"].Value);
            nombre = Convert.ToString(dgvAlumnos.Rows[e.RowIndex].Cells["Nombres"].Value);
            apellido = Convert.ToString(dgvAlumnos.Rows[e.RowIndex].Cells["Apellidos"].Value);
        }

        

        /// <summary>
        /// Evento para enviar los datos al otro Formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count == 1)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila");
            }
        }

        /// <summary>
        /// Evento para cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            codigoAlumno = 0;
            nombre = null;
            apellido = null;
            dgvAlumnos.DataSource = null;
            this.Close();
        }

        
    }
}
