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
    public partial class frmPeriodos : Form
    {
        // Propiedad para almacenar el código de un periodo
        // al ser seleccionado en el DataGridView
        private int codigoPeriodo;

        // Propiedad para almacenar el nombre de un periodo
        // al ser seleccionado en el DataGridView
        private string nombrePeriodo;

        public frmPeriodos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cargar todos los componentes al iniciar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPeriodos_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Método para limpiar el formulario y resetear los valores en él
        /// </summary>
        private void Limpiar()
        {
            this.nombrePeriodo = null;
            this.codigoPeriodo = 0;
            txtDescripcion.Text = "";
            txtAnio.Text = "";
            CargarDGVPeriodos();
            dgvEstilo(dgvPeriodos);
            nudPeriodo.Value = 1;

            toolStripGuardar.Enabled = true;
            toolStripActualizar.Enabled = true;
            toolStripInhabilitar.Enabled = true;

            txtDescripcion.Focus();
            errorProvider1.Clear();

        }

        // -----------------------Carga de Datos---------------------
       
        private void CargarDGVPeriodos()
        {
            try
            {
                dgvPeriodos.DataSource = Periodos.GetDataView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento para cargar los datos del alumno
        /// Al ser seleccionado en el DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPeriodos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Instanciamos la Clase Periodos
            Periodos elPeriodo = new Periodos();

            elPeriodo = Periodos.ObtenerInformacionPeriodo(Convert.ToInt16(dgvPeriodos.Rows[e.RowIndex].Cells["Código"].Value));

            // El formulario toma los valores del objeto
            this.codigoPeriodo = elPeriodo.codigo;
            this.nombrePeriodo = elPeriodo.descripcion;
            txtDescripcion.Text = elPeriodo.descripcion;
            txtAnio.Text = elPeriodo.anio;
            nudPeriodo.Value = elPeriodo.periodo;

            toolStripGuardar.Enabled = false;
        }

        /// <summary>
        /// Método para establecer el estilo
        /// del color de fondo del DataGridView
        /// </summary>
        /// <param name="dgv"></param>
        private void dgvEstilo(DataGridView dgv)
        {
            dgv.DefaultCellStyle.BackColor = Color.DarkOrange;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }


        // ---------------------------- CRUD -----------------------------
        /// <summary>
        /// Evento para Agregar un periodo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "" || txtAnio.Text == "")
            {
                MessageBox.Show("Debe ingresar todos los datos del periodo", "Información"); ;
            }
            else
            {
                // Instanciamos la clase Periodos
                Periodos elPeriodo = new Periodos();

                // Nuestro objeto adquiere los valores del formulario
                elPeriodo.descripcion = txtDescripcion.Text;
                elPeriodo.anio = txtAnio.Text;
                elPeriodo.periodo = Convert.ToInt16(nudPeriodo.Value);

                // Verificamos si se realizó el método
                if (Periodos.InsertarPeriodo(elPeriodo))
                {
                    MessageBox.Show("Periodo Agregado", "Información");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                }
            }
        }

        /// <summary>
        /// Evento para Actualizar un periodo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripActualizar_Click(object sender, EventArgs e)
        {
            // Verificamos que se ingresó todos los datos
            if (txtDescripcion.Text == "" || txtAnio.Text == "" || dgvPeriodos.CurrentRow == null)
            {
                MessageBox.Show("Ingrese y seleccione un periodo para actualizar", "Información");
            }
            else
            {
                // Instanciamos la clase Periodos
                Periodos elPeriodo = new Periodos();

                // Nuestro objeto adquiere los valores del formulario
                elPeriodo.descripcion = this.nombrePeriodo;
                elPeriodo.descripcionNueva = txtDescripcion.Text;
                elPeriodo.anio = txtAnio.Text;
                elPeriodo.periodo = Convert.ToInt16(nudPeriodo.Value);

                // Verificamos el método
                if (Periodos.ActualizarPeriodo(elPeriodo))
                {
                    MessageBox.Show("Periodo Agregado", "Información");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                }
            }
        }

        /// <summary>
        /// Evento para Inhabilitar un Periodo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripInhabilitar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "" || txtAnio.Text == "" || dgvPeriodos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un periodo para inhabilitar", "Información");
            }
            else
            {
                // Instanciamos la clase Periodos
                Periodos elPeriodo = new Periodos();

                // Nuestro objeto adquiere los valores del formulario
                elPeriodo.descripcion = this.nombrePeriodo;

                // Verficamos el método
                if (Periodos.InhabilitarPeriodo(elPeriodo))
                {
                    MessageBox.Show("Periodo Inhabilitado", "Información");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                }
            }
        }

        /// <summary>
        /// Evento que limpia la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Evento para salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorProvider1.Clear();
                errorProvider1.SetError(txtAnio, "Ingrese solo letras");
            }
        }

        
    }
}
