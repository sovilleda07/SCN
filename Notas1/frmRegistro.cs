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
        private string descripcionCarrera;

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
            this.descripcionCarrera = frmBuscar_Clases.carrera;
            MessageBox.Show(descripcionCarrera.ToString());
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
                frmBuscar_Alumno alumno = new frmBuscar_Alumno(descripcionCarrera);
                alumno.ShowDialog();
            }
            
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtPeriodo.Text == "")
            {
                MessageBox.Show("Debe ingresar los datos", "Error de Ingreso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Registro satisfactorio", "Control de Registro", MessageBoxButtons.OK);
            }
        }

        private void toolStripActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtPeriodo.Text == "")
            {
                MessageBox.Show("Debe ingresar los datos", "Error de Actualización", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Registro Actualizado", "Control de Registro", MessageBoxButtons.OK);
            }
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
