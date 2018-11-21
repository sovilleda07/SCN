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

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                }

                
            }
        }

        private void toolStripActualizar_Click(object sender, EventArgs e)
        {
            if (txtCarrera.Text == "")
            {
                MessageBox.Show("Debe ingresar la descripción de la carrera", "Error de Actualización", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Carrera actualizada satisfactoriamente", "Control de Carreras", MessageBoxButtons.OK);
            }
        }

        private void toolStripInhabilitar_Click(object sender, EventArgs e)
        {
            if (txtCarrera.Text == "")
            {
                MessageBox.Show("Debe ingresar la descripción de la carrera", "Error de Inhabilitación", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Carrera Inhabilitada satisfactoriamente", "Control de Carreras", MessageBoxButtons.OK);
            }
        }

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
    }
}
