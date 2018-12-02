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
    public partial class frmAlumnos : Form
    {
        // Propiedad para almacenar el código de un Alumno
        // al ser seleccionado en el DataGridView
        private int codigoAlumno;

        public frmAlumnos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cargar todos los componentes al iniciar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            ListarComboCarreras();
            Limpiar();
        }

        /// <summary>
        /// Método para limpiar el formulario y resetear los valores en él
        /// </summary>
        private void Limpiar()
        {
            this.codigoAlumno = 0;
            ListarComboCarreras();
            txtNombres.Text = "";
            txtApellidos.Text = "";
            cmbCarrera.SelectedIndex = -1;
            mtxtTelefono.Text = "";
            txtEmail.Text = "";
            txtObservaciones.Text = "";
            CargarDGVAlumnos();
            dgvEstilo(dgvAlumnos);

            toolStripGuardar.Enabled = true;
            toolStripActualizar.Enabled = false;
            toolStripInhabilitar.Enabled = false;

            txtNombres.Focus();
            errorProvider1.Clear();

        }

        // -----------------Carga de Datos-------------------------

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
        /// Método para Cargar los datos al dataGridView
        /// </summary>
        private void CargarDGVAlumnos()
        {
            try
            {
                // El origen de los datos del DataGridView
                // Está en un método en la clase Alumnos, hacemos referencia a él
                dgvAlumnos.DataSource = Alumnos.GetDataView();
            }
            catch (Exception ex)
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
        private void dgvAlumnos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Instanciamos la Clase Alumnos
            Alumnos elAlumno = new Alumnos();

            elAlumno = Alumnos.ObtenerInformacionAlumnos(Convert.ToInt16(dgvAlumnos.Rows[e.RowIndex].Cells["Código"].Value));

            // El formulario toma los valores del objeto
            this.codigoAlumno = elAlumno.id;
            txtNombres.Text = elAlumno.nombres;
            txtApellidos.Text = elAlumno.apellidos;
            cmbCarrera.SelectedItem = elAlumno.descripcionCarrera;
            mtxtTelefono.Text = elAlumno.telefono;
            txtEmail.Text = elAlumno.correo;
            txtObservaciones.Text = elAlumno.observaciones;

            toolStripGuardar.Enabled = false;
            toolStripActualizar.Enabled = true;
            toolStripInhabilitar.Enabled = true;
        }


        /// <summary>
        /// Método para establecer estilo
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
        /// Evento para Actualizar un Alumno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtNombres.Text == "" || mtxtTelefono.Text == "" || cmbCarrera.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar todos los datos del Alumno", "Información");
            }
            else
            {
                // Instanciamos la Clase Alumnos
                Alumnos elAlumno = new Alumnos();

                // Nuestro objeto adquiere los valores del formulario
                elAlumno.nombres = txtNombres.Text;
                elAlumno.apellidos = txtApellidos.Text;
                elAlumno.descripcionCarrera = cmbCarrera.SelectedItem.ToString();
                elAlumno.telefono = mtxtTelefono.Text;
                elAlumno.correo = txtEmail.Text;
                elAlumno.observaciones = txtObservaciones.Text;

                // Verificamos si se realizó el método
                if (Alumnos.InsertarAlumno(elAlumno))
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

        /// <summary>
        /// Evento para Actualizar un Alumno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripActualizar_Click_1(object sender, EventArgs e)
        {
            if (txtNombres.Text == "" || mtxtTelefono.Text == "" || cmbCarrera.SelectedIndex == -1 || dgvAlumnos.CurrentRow == null)
            {
                MessageBox.Show("Debe ingresar todos los datos del Alumno", "Información");
            }
            else
            {
                // Instanciamos la clase Alumnos
                Alumnos elAlumno = new Alumnos();

                // Nuestro objeto adquiere los valores del formulario
                elAlumno.id = this.codigoAlumno;
                elAlumno.nombres = txtNombres.Text;
                elAlumno.apellidos = txtApellidos.Text;
                elAlumno.descripcionCarrera = cmbCarrera.SelectedItem.ToString();
                elAlumno.telefono = mtxtTelefono.Text;
                elAlumno.correo = txtEmail.Text;
                elAlumno.observaciones = txtObservaciones.Text;

                // Verificamos si se realizó el método
                if (Alumnos.ActualizarAlumno(elAlumno))
                {
                    MessageBox.Show("Alumno Actualizado", "Información");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                }
            }
            
        }

        /// <summary>
        /// Evento para Inhabilitar un Alumno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripInhabilitar_Click_1(object sender, EventArgs e)
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
        /// Evento para cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // ------------------------- VALIDACIÓN -------------------------

        /// <summary>
        /// Evento para validar la entrada de sólo letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtnombres_KeyPress(object sender, KeyPressEventArgs e)
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
                errorProvider1.SetError(txtNombres, "Ingrese solo letras");
            }
        }

        /// <summary>
        /// Evento para validar la entrada de sólo letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtapellidos_KeyPress(object sender, KeyPressEventArgs e)
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
                errorProvider1.SetError(txtApellidos, "Ingrese solo letras");
            }
        }

         /// <summary>
        /// Evento para validar la entrada de sólo números
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
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
                errorProvider1.SetError(mtxtTelefono, "Ingrese solo números");
            }
        }   
        
        private void gbdatos_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Evento para Inhabilitar un Alumno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripInhabilitar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text == "" || mtxtTelefono.Text == "" || cmbCarrera.SelectedIndex == -1 || dgvAlumnos.CurrentRow == null)
            {
                MessageBox.Show("Debe ingresar todos los datos del Alumno", "Información");
            }
            else
            {
                // Instanciamos la clase Alumnos
                Alumnos elAlumno = new Alumnos();

                // Nuestro objeto adquiere los valores del formulario
                elAlumno.id = this.codigoAlumno;

                // Verificamos el método
                if (Alumnos.InhabilitarAlumno(elAlumno))
                {
                    MessageBox.Show("Alumno Inhabilitado", "Información");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                }

            }
        }

        
    }
}
