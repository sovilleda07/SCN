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
    public partial class Clase : Form
    {
        public Clase()
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
            Buscar_Carrera car = new Buscar_Carrera();
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
    }
}
