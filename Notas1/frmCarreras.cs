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

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {

            if (txtCarrera.Text == "")
            {
                MessageBox.Show("Debe ingresar la descripción de la carrera", "Error de Ingreso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Carrera registrada satisfactoriamente", "Control de Carreras", MessageBoxButtons.OK);
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
    }
}
