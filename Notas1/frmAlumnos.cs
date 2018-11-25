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
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {

        }


        private void gbdatos_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        // CRUD
        private void toolStripGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtNombres.Text == "" || txtApellidos.Text == "")
            {
                MessageBox.Show("Debe ingresar los datos del alumno", "Error de Ingreso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Alumno registrado satisfactoriamente", "Control de Alumnos", MessageBoxButtons.OK);
            }
        }

        private void toolStripActualizar_Click_1(object sender, EventArgs e)
        {
            if (txtNombres.Text == "" || txtApellidos.Text == "")
            {
                MessageBox.Show("Debe ingresar los datos del alumno", "Error de Actualización", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Alumno Actualizado satisfactoriamente", "Control de Alumnos", MessageBoxButtons.OK);
            }
        }

        private void toolStripInhabilitar_Click_1(object sender, EventArgs e)
        {
            if (txtNombres.Text == "" || txtApellidos.Text == "")
            {
                MessageBox.Show("Debe ingresar los datos del alumno", "Error de Inhabilitación", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Alumno Inhabilitado satisfactoriamente", "Control de Alumnos", MessageBoxButtons.OK);
            }
        }
        
        private void toolStripSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // VALIDACIÓN

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
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
                errorProvider1.SetError(txtTelefono, "Ingrese solo números");
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

        
    }
}
