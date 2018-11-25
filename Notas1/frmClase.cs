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
    public partial class frmClase : Form
    {
        // Propiedad para almacenar el nombre de una clase 
        // Al ser seleccionada en el DataGridView
        private string nombreClase;

        public frmClase()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Carga todos los componentes al iniciar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmClase_Load(object sender, EventArgs e)
        {
            ListarComboCarreras();
            Limpiar();
        }

        /// <summary>
        /// Método para Limpiar el formulario y resetear los valores en él
        /// </summary>
        private void Limpiar()
        {
            this.nombreClase = null;
            ListarComboCarreras();
            txtNombre.Text = "";
            cmbCarrera.SelectedIndex = -1;
            nudCreditos.Value = 1;
            dgvClases.DataSource = "";
            CargarDGVClase();
            dgvEstilo(dgvClases);

            toolStripGuardar.Enabled = true;
            toolStripActualizar.Enabled = true;
            toolStripInhabilitar.Enabled = true;

            txtNombre.Focus();

        }

        /// <summary>
        /// Método para cargar el ComboBox con las carreras
        /// </summary>
        private void ListarComboCarreras()
        {
            // Limpiamos los items existentes
            cmbCarrera.Items.Clear();

            // Instanciamos la clase Carreras
            Carreras laCarrera = new Carreras();

            // Almacenamos todas las carreras existentes
            // y habilitadas en una lista
            List<Carreras> listaCarreras = Carreras.LeerTodosHabilitados();

            // Si hay algún elemento en la lista
            // Lo agregamos al ComboBox
            if (listaCarreras.Any())
            {
                listaCarreras.ForEach(carrera => cmbCarrera.Items.Add(carrera.descripcion.ToString()));
            }
            else
            {
                cmbCarrera.Items.Add("No hay Carreras Disponibles");
            }

        }

        /// <summary>
        /// Método para Cargar los datos al DataGridView
        /// </summary>
        private void CargarDGVClase()
        {
            try
            {
                // El origen de los datos del DataGridView
                // Está en un método en la clase Clases, hacemos referencia a él
                dgvClases.DataSource = Clases.Clases.GetDataView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento para Guardar una Clase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || cmbCarrera.SelectedIndex == -1 || nudCreditos.Value == 0)
            {
                MessageBox.Show("Debe ingresar todos los datos de la Clase", "Información");
            }
            else
            {
                // Instanciamos la clase Clase
                Clases.Clases laClase = new Clases.Clases();

                // Nuestro objeto adquiere los valores del formulario
                laClase.nombre = txtNombre.Text;
                laClase.creditos = Convert.ToInt16(nudCreditos.Value);
                laClase.descripcionCarrera = cmbCarrera.SelectedItem.ToString();

                // Verificamos si se realizó el método
                if (Clases.Clases.InsertarClase(laClase))
                {
                    MessageBox.Show("Clase Agregada", "Información");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                }
            }
        }

        /// <summary>
        /// Evento para Actualizar una clase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ev"></param>
        private void toolStripActualizar_Click(object sender, EventArgs ev)
        {
            if (txtNombre.Text == "" || cmbCarrera.SelectedIndex == -1 || nudCreditos.Value == 0 || dgvClases.CurrentRow == null)
            {
                MessageBox.Show("Debe ingresar todos los datos de la Clase", "Información");
            }
            else
            {
                // Instanciamos la clase Clase
                Clases.Clases laClase = new Clases.Clases();

                // Nuestro objeto adquiere los valores del formulario
                laClase.nombreNuevo = txtNombre.Text;
                laClase.nombre = this.nombreClase;
                laClase.creditos = Convert.ToInt16(nudCreditos.Value);
                laClase.descripcionCarrera = cmbCarrera.SelectedItem.ToString();

                // Verificamos si se realizó el método
                if (Clases.Clases.ActualizarClase(laClase))
                {
                    MessageBox.Show("Clase Actualizada", "Información");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                }
            }
        }

        /// <summary>
        /// Evento para Inhabilitar una Clase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripInhabilitar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || cmbCarrera.SelectedIndex == -1 || nudCreditos.Value == 0 || dgvClases.CurrentRow == null)
            {
                MessageBox.Show("Debe Seleccionar una Clase para Inhabilitarla", "Información");
            }
            else
            {
                // Instanciamos la clase Clase
                Clases.Clases laClase = new Clases.Clases();

                // Nuestro objeto adquiere los valores del formulario
                laClase.nombre = this.nombreClase;

                // Verificamos el método
                if (Clases.Clases.InhabilitarClase(laClase))
                {
                    MessageBox.Show("Clase Inhabilitada Satisfactoriamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error");
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

        /// <summary>
        /// Evento Para validar el ingreso de solo letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.Clear();
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorProvider1.Clear();
                errorProvider1.SetError(txtNombre, "Ingrese solo letras");
            }
        }

        /// <summary>
        /// Evento para cargar los datos de la clase
        /// Al ser seleccionada en el DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Instanciamos la clase Clase
            Clases.Clases laClase = new Clases.Clases();

            laClase = Clases.Clases.ObtenerInformacionClase(dgvClases.Rows[e.RowIndex].Cells["Nombre"].Value.ToString());

            txtNombre.Text = laClase.nombre;
            cmbCarrera.SelectedItem = laClase.descripcionCarrera;
            nudCreditos.Value = laClase.creditos;
            this.nombreClase = laClase.nombre;

            toolStripGuardar.Enabled = false;
        }

        /// <summary>
        /// Método para establecer estilo del
        /// Color de fondo del DataGridView
        /// </summary>
        /// <param name="dgv"></param>
        private void dgvEstilo(DataGridView dgv)
        {
            dgv.DefaultCellStyle.BackColor = Color.DarkOrange;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }



        private void lblclases_Click(object sender, EventArgs e)
        {

        }

        private void gbclases_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
