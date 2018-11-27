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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void toolStripSaliru_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbHabilitar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHabilitar.SelectedIndex == 0)    //Alumno
            {
                txtAlumno.Enabled = true;
                txtApellido.Enabled = true;

                txtCarrera.Enabled = false;
                txtClase.Enabled = false;
                txtPeriodo.Enabled = false;
            }

            if (cmbHabilitar.SelectedIndex == 1)
            {
                txtAlumno.Enabled = false;
                txtApellido.Enabled = false;
                txtClase.Enabled = false;
                txtPeriodo.Enabled = false;

                txtCarrera.Enabled = true;

            }

            if (cmbHabilitar.SelectedIndex == 2)
            {
                txtClase.Enabled = true;

                txtAlumno.Enabled = false;
                txtApellido.Enabled = false;
                txtCarrera.Enabled = false;
                txtPeriodo.Enabled = false;
            }

            if (cmbHabilitar.SelectedIndex == 3)
            {
                txtPeriodo.Enabled = true;

                txtAlumno.Enabled = false;
                txtApellido.Enabled = false;
                txtCarrera.Enabled = false;
                txtClase.Enabled = false;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
