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
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
        }

       

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripActualizar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripInhabilitar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbdatos_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Buscar_Carrera car = new Buscar_Carrera();
            car.ShowDialog();
        }

        private void toolStripGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtnombres.Text == "" || txtapellidos.Text == "" || txtnombrecarrera.Text == "")
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
            if (txtnombres.Text == "" || txtapellidos.Text == "")
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
            if (txtnombres.Text == "" || txtapellidos.Text == "")
            {
                MessageBox.Show("Debe ingresar los datos del alumno", "Error de Inhabilitación", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Alumno Inhabilitado satisfactoriamente", "Control de Alumnos", MessageBoxButtons.OK);
            }
        }
    }
}
