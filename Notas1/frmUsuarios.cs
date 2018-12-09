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
                
            }

            if (cmbHabilitar.SelectedIndex == 1)
            {
                

            }

            if (cmbHabilitar.SelectedIndex == 2)
            {
                
            }

            if (cmbHabilitar.SelectedIndex == 3)
            {
                

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Evento para salir del formulario
        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
