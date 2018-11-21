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
    public partial class Periodos : Form
    {
        public Periodos()
        {
            InitializeComponent();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblcodigoperiodo_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "" || txtAnio.Text == "" || txtPeriodo.Text == "")
            {
                MessageBox.Show("Debe ingresar los datos del periodo", "Error de Ingreso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Periodo registrado satisfactoriamente", "Control de Periodos", MessageBoxButtons.OK);
            }
        }

        private void toolStripActualizar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "" || txtAnio.Text == "" || txtPeriodo.Text == "")
            {
                MessageBox.Show("Debe ingresar los datos del periodo", "Error de Actualización", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Periodo actualizado satisfactoriamente", "Control de Periodos", MessageBoxButtons.OK);
            }
        }

        private void toolStripInhabilitar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "" || txtAnio.Text == "" || txtPeriodo.Text == "")
            {
                MessageBox.Show("Debe ingresar los datos del periodo", "Error de Inhabilitar", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Periodo inhabilitado satisfactoriamente", "Control de Periodos", MessageBoxButtons.OK);
            }
        }
    }
}
