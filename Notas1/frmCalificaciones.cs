using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;
using System.Threading;


using Notas1.Clases;

namespace Notas1
{
    public partial class frmCalificaciones : Form
    {

        // Propiedad para almacenar información de otros formularios
        private int codigoPeriodo;
        private int codigoClase;
        private int codigoAlumno;
        private int codigoRegistro;

        // Propiedades que tomaran los valores del txt
        private decimal textnota1;
        private decimal textnota2;
        private decimal textnota3;
        private decimal promedio;

        // Variables estáticas para almacenar los códigos
        // Y enviarlos como parámetro para hacer los filtros de búsqueda
        public static int ClaseCodigo;
        public static int PeriodoCodigo;

        public frmCalificaciones()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cargar todos los componentes al inicar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCalificaciones_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        // Método para limpiar el formulario y resetear los valores en él.
        private void Limpiar()
        {
            this.codigoPeriodo = 0;
            this.codigoClase = 0;
            this.codigoAlumno = 0;

            txtClase.Text = "";
            txtPeriodo.Text = "";
            txtAnio.Text = "";
            txtNombres.Text = "";
            txtApellido.Text = "";
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtPromedio.Text = "";

            dgvCalificaciones.DataSource = null;
            toolStripGuardar.Enabled = true;
            toolStripActualizar.Enabled = false;
            btnClase.Focus();        
                       
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
            ClaseCodigo = this.codigoClase;


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
            PeriodoCodigo = this.codigoPeriodo;
            
        }

        /// <summary>
        /// Evento para traer los datos del alumno
        /// desde otro formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlumno_Click(object sender, EventArgs e)
        {
            
            if (txtClase.Text == "")
            {
                MessageBox.Show("Debe Seleccionar una Clase y Periodo");
            }
            else
            {
                frmBuscar_Alumno_Calificación alumno = new frmBuscar_Alumno_Calificación();
                alumno.ShowDialog();
                this.codigoAlumno = frmBuscar_Alumno_Calificación.codigoAlumno;
                txtNombres.Text = frmBuscar_Alumno_Calificación.nombre;
                txtApellido.Text = frmBuscar_Alumno_Calificación.apellido;
                codigoRegistro = frmBuscar_Alumno_Calificación.codigoRegistro;
            }
            
        }

        // ****************************************************************************************************************
        private void dgvCalificaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Instanciamos la Clase Calificaciones
            Calificaciones laCalificacion = new Calificaciones();
        }
        // ****************************************************************************************************************


        // -------------------------CRUD---------------------------
        /// <summary>
        /// Evento para Guardar un registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            if (txtClase.Text == "" || txtNombres.Text == "" || txtApellido.Text == "" || txtPeriodo.Text == "" || txtNota1.Text == "" || txtNota2.Text == "" || txtNota3.Text == "" || txtPromedio.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los datos", "Información");
            }
            else
            {
                // Instanciamos la Clase Calificaciones
                Calificaciones laCalificacion = new Calificaciones();

                // Nuestro objeto adquiere los valores del formulario
                laCalificacion.nota1 = this.textnota1;
                laCalificacion.nota2 = this.textnota2;
                laCalificacion.nota3 = this.textnota3;
                laCalificacion.promedio = this.promedio;
                laCalificacion.codigoRegistro = this.codigoRegistro;

                // Verificamos si se realizó el método
                if (Calificaciones.InsertarCalificacion(laCalificacion))
                {
                    MessageBox.Show("Calificacion Agregada", "Información");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                }

            }
        }

        private void toolStripctualizar_Click(object sender, EventArgs e)
        {
            if (txtClase.Text == "" || txtNombres.Text == "" || txtApellido.Text == "" || txtPeriodo.Text == "" || txtNota1.Text == "" || txtNota2.Text == "" || txtNota3.Text == "" || txtPromedio.Text == "")
            {
                MessageBox.Show("Debe ingresar los datos", "Error de Actualización", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Calificación Actualizada satisfactoriamente", "Control de Calificaciones", MessageBoxButtons.OK);
            }
        }

        private void toolStripBuscar_Click(object sender, EventArgs e)
        {

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
        /// Evento para cerrar el Formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ------------------------- VALIDACIÓN -------------------------

        /// <summary>
        /// Validar el ingreso de solo números
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorProvider1.Clear();
                errorProvider1.SetError(txtNota1, "Ingrese solo numeros");
            }
        }

        /// <summary>
        /// Validar el ingreso de solo números
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorProvider1.Clear();
                errorProvider1.SetError(txtNota2, "Ingrese solo numeros");
            }
        }

        /// <summary>
        /// Validar el ingreso de solo números
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNota3_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorProvider1.Clear();
                errorProvider1.SetError(txtNota3, "Ingrese solo numeros");
            }
        }

        /// <summary>
        /// Evento para Validar el ingreso de las notas
        /// Y calcular el promedio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btncalcular_Click(object sender, EventArgs e)
        {
            // Establecer en la cultura, una modificación en el separador de decimal
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            if (txtNota1.Text == "" || txtNota2.Text == "" || txtNota3.Text == "")
            {
                MessageBox.Show("Ingrese todas las notas");
            }
            else
            {
                this.textnota1 = Convert.ToDecimal(this.txtNota1.Text);
                this.textnota2 = Convert.ToDecimal(this.txtNota2.Text);
                this.textnota3 = Convert.ToDecimal(this.txtNota3.Text);

                //MessageBox.Show(nota1.ToString());

                if ((this.textnota1 < 0 || this.textnota1 > 100) || ((this.textnota2 < 0 || this.textnota2 > 100)) || ((this.textnota3 < 0 || this.textnota3 > 100)))
                {
                    MessageBox.Show("Hay notas mayores a 100 o menores a 0");
                }
                else
                {
                    promedio = ((this.textnota1 + this.textnota2 + this.textnota3) / 3);

                    txtPromedio.Text = promedio.ToString();
                }
            }
        }


        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
