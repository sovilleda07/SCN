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
    public partial class frmClase : Form
    {
        public frmClase()
        {
            InitializeComponent();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblclases_Click(object sender, EventArgs e)
        {

        }

        private void gbclases_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBuscar_Carrera car = new frmBuscar_Carrera();
            car.ShowDialog();
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCarrera.Text == "")
            {
                MessageBox.Show("Debe ingresar los datos de la clase", "Error de Ingreso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Clase registrada satisfactoriamente", "Control de Clases", MessageBoxButtons.OK);
            }
        }

        private void toolStripActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCarrera.Text == "")
            {
                MessageBox.Show("Debe ingresar los datos de la clase", "Error de Actualización", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Clase actualizada satisfactoriamente", "Control de Clases", MessageBoxButtons.OK);
            }
        }

        private void toolStripInhabilitar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCarrera.Text == "")
            {
                MessageBox.Show("Debe ingresar los datos de la clase", "Error de Inhabilitación", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Clase Inhabilitada satisfactoriamente", "Control de Clases", MessageBoxButtons.OK);
            }
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
    }
}
