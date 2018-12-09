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
    public partial class frmBuscar_Alumno_Calificación : Form
    {
        // Propiedad para el método de DataGridView
        private int codigoClase;
        private int codigoPeriodo;

        // Propiedades para obtener valores
        public static int codigoAlumno;
        public static string nombre;
        public static string apellido;
        public static int codigoRegistro;

        // Constructores
        public frmBuscar_Alumno_Calificación()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Carga todos los componentes al iniciar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBuscar_Alumno_Calificación_Load(object sender, EventArgs e)
        {
            codigoClase = frmCalificaciones.ClaseCodigo;
            codigoPeriodo = frmCalificaciones.PeriodoCodigo;
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
                dgvAlumnos.DataSource = Alumnos.GetDataViewAlumnoCalificación(codigoClase, codigoPeriodo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Eveto para Cargar los datos del alumno
        /// al ser seleccionado en el Data Grid View
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoAlumno = Convert.ToInt16(dgvAlumnos.Rows[e.RowIndex].Cells["Id"].Value);
            nombre = Convert.ToString(dgvAlumnos.Rows[e.RowIndex].Cells["Nombres"].Value);
            apellido = Convert.ToString(dgvAlumnos.Rows[e.RowIndex].Cells["Apellidos"].Value);
            codigoRegistro = Convert.ToInt16(dgvAlumnos.Rows[e.RowIndex].Cells["Registro"].Value);
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
        /// Evento para Cerrar el Formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            codigoAlumno = 0;
            codigoRegistro = 0;
            nombre = null;
            apellido = null;
            dgvAlumnos.DataSource = null;
            this.Close();
        }
    }
}
