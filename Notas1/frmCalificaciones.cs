using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas1
{
    public partial class frmCalificaciones : Form
    {

        // Propiedad para almacenar información de otros formularios
        private int codigoPeriodo;
        private int codigoClase;
        private int codigoAlumno;

        public frmCalificaciones()
        {
            InitializeComponent();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        // -----------------Carga de Datos-------------------------

        /// <summary>
        /// Evento para traer los datos de la clase
        /// desde otro formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            frmBuscar_Clases clase = new frmBuscar_Clases();
            clase.ShowDialog();
            txtClase.Text = frmBuscar_Clases.descripcionClase;
            this.codigoClase = frmBuscar_Clases.codigoClases;


        }

        /// <summary>
        /// Evento para traer los datos del periodo
        /// desde otro formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPeriodo_Click(object sender, EventArgs e)
        {
            frmBuscar_Periodo periodo = new frmBuscar_Periodo();
            periodo.ShowDialog();

            txtPeriodo.Text = frmBuscar_Periodo.descripcionPeriodo;
            txtAnio.Text = frmBuscar_Periodo.anioPeriodo;
            this.codigoPeriodo = frmBuscar_Periodo.codigoPeriodo;
            
        }

        /// <summary>
        /// Evento para traer los datos del alumno
        /// desde otro formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlumno_Click(object sender, EventArgs e)
        {
            ///LLAMAR a OTRO FORMULARIO PARA BUSCAR LOS ALUMNOS A CALIFICAR
            frmBuscar_Alumno alumno = new frmBuscar_Alumno();
            alumno.ShowDialog();
        }


        // -------------------------CRUD---------------------------

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            if (txtClase.Text == "" || txtAlumno.Text == "" || txtApellido.Text == "" || txtPeriodo.Text == "" || txtNota1.Text == "" || txtNota2.Text == "" || txtNota3.Text == "" || txtPromedio.Text == "")
            {
                MessageBox.Show("Debe ingresar los datos", "Error de Ingreso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Calificación registrada satisfactoriamente", "Control de Calificaciones", MessageBoxButtons.OK);
            }
        }

        private void toolStripctualizar_Click(object sender, EventArgs e)
        {
            if (txtClase.Text == "" || txtAlumno.Text == "" || txtApellido.Text == "" || txtPeriodo.Text == "" || txtNota1.Text == "" || txtNota2.Text == "" || txtNota3.Text == "" || txtPromedio.Text == "")
            {
                MessageBox.Show("Debe ingresar los datos", "Error de Actualización", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Calificación Actualizada satisfactoriamente", "Control de Calificaciones", MessageBoxButtons.OK);
            }
        }

        
    }
}
