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
    public partial class frmCalificaciones : Form
    {
        public frmCalificaciones()
        {
            InitializeComponent();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            frmBuscas_Clases clase = new frmBuscas_Clases();
            clase.ShowDialog();
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            frmBuscar_Alumno alumno = new frmBuscar_Alumno();
            alumno.ShowDialog();
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            if (txtClase.Text == "" || txtAlumno.Text == "" || txtApellido.Text == "" || txtCarrera.Text == "" || txtNota1.Text == "" || txtNota2.Text == "" || txtNota3.Text == "" || txtPromedio.Text == "")
            {
                MessageBox.Show("Debe ingresar los datos", "Error de Ingreso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Calificación registrada satisfactoriamente", "Control de Calificaciones", MessageBoxButtons.OK);
            }
        }

        private void toolStripctualizar_Click(object sender, EventArgs e)
        {
            if (txtClase.Text == "" || txtAlumno.Text == "" || txtApellido.Text == "" || txtCarrera.Text == "" || txtNota1.Text == "" || txtNota2.Text == "" || txtNota3.Text == "" || txtPromedio.Text == "")
            {
                MessageBox.Show("Debe ingresar los datos", "Error de Actualización", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Calificación Actualizada satisfactoriamente", "Control de Calificaciones", MessageBoxButtons.OK);
            }
        }
    }
}
