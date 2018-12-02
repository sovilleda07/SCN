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
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga todos los componentes al iniciar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCarreras_Load(object sender, EventArgs e)
        {
            ListarListBoxCarreras();
            Limpiar();
        }

        /// <summary>
        /// Método para limpiar la pantlla después de cada operación
        /// </summary>
        private void Limpiar()
        {
            txtCarrera.Text = "";
            lstCarreras.SelectedIndex = -1;
            txtCarrera.Focus();
            toolStripGuardar.Enabled = true;
            toolStripActualizar.Enabled = false;
            toolStripInhabilitar.Enabled = false;
            ListarListBoxCarreras();
        }

        /// <summary>
        /// Evento click para que cuando se seleccione
        /// Un elemento del ListBox, traiga los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstCarreras_Click(object sender, EventArgs e)
        {
            // Creamos un objeto de tipo Carreras
            Carreras laCarrera = new Carreras();

            // Obtenemos la informacion de las carreras, enviando su nombre
            laCarrera = Carreras.ObtenerInformacionCarrera(lstCarreras.SelectedItem.ToString());

            txtCarrera.Text = laCarrera.descripcion;
            toolStripGuardar.Enabled = false;
            toolStripActualizar.Enabled = true;
            toolStripInhabilitar.Enabled = true;
        }

        /// <summary>
        /// Método para cargar los datos de las carreras al ListBox
        /// </summary>
        private void ListarListBoxCarreras()
        {
            // Limpiamos los items existentes
            lstCarreras.Items.Clear();

            // Instanciamos la Clase Carreras
            Carreras laCarrera = new Carreras();

            // Almacenamos todos las carreras existentes
            // y habilitadas en una lista
            List<Carreras> listaCarreras = Carreras.LeerTodosHabilitados();

            // Si hay algun elemento en la lista
            // Lo agregamos al ListBox
            if (listaCarreras.Any())
            {
                listaCarreras.ForEach(carrera => lstCarreras.Items.Add(carrera.descripcion.ToString()));
            }
            else
            {
                lstCarreras.Items.Add("No hay Carreras Disponibles");
            }
        }

        /// <summary>
        /// Evento para Agregar una Carrera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripGuardar_Click(object sender, EventArgs e)
        {

            if (txtCarrera.Text == "")
            {
                MessageBox.Show("Debe ingresar la descripción de la carrera", "Error de Ingreso", MessageBoxButtons.OK);
            }
            else
            {
                // Instanciamos la clase Carreras
                Carreras laCarrera = new Carreras();
                // Nuestro objeto adquiere los valores del formulario
                laCarrera.descripcion = txtCarrera.Text;

                // Verificamos si se realizó el método
                if (Carreras.InsertarCarrera(laCarrera))
                {
                    MessageBox.Show("Carrera Agregada", "Información");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                }

                
            }
        }

        /// <summary>
        /// Evento para Actualizar una carrera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripActualizar_Click(object sender, EventArgs e)
        {
            // Verificamos que se ingresó todos los datos
            if (txtCarrera.Text == "" || lstCarreras.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese y seleccione una carrera para actualizar", "Información");
            }
            else
            {
                // Instanciamos la clase Carreras
                Carreras laCarrera = new Carreras();

                //nuestro objeto adquiere los valores del formulario
                laCarrera.descripcion = lstCarreras.SelectedItem.ToString();
                laCarrera.descripcionNueva = txtCarrera.Text;


                // Verificamos el método
                if (Carreras.ActualizarCarrera(laCarrera))
                {
                    MessageBox.Show("Carrera actualizada");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        /// <summary>
        /// Evento para inhabilitar una carrera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripInhabilitar_Click(object sender, EventArgs e)
        {
            if (lstCarreras.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una carrera para inhabilitar", "Información");
            }
            else
            {
                // Instanciamos la clase Carreras
                Carreras laCarrera = new Carreras();

                //nuestro objeto adquiere los valores del formulario
                laCarrera.descripcion = lstCarreras.SelectedItem.ToString();

                // Verificamos el método
                if (Carreras.InhabilitarCarrera(laCarrera))
                {
                    MessageBox.Show("Carrera Inhabilitada Satisfactoriamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
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

        /// <summary>
        /// Evento para validar el ingreso de solo letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCarrera_KeyPress(object sender, KeyPressEventArgs e)
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
                errorProvider1.SetError(txtCarrera, "Ingrese solo letras");
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Evento que limpia la pantallas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
