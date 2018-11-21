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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmBuscar_Periodo periodo = new frmBuscar_Periodo();
            periodo.ShowDialog();
        }

        private void btnClase_Click(object sender, EventArgs e)
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
            if (txtClase.Text == "" || txtAlumno.Text == "" || txtPeriodo.Text == "")
            {
                MessageBox.Show("Debe ingresar los datos", "Error de Ingreso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Registro satisfactorio", "Control de Registro", MessageBoxButtons.OK);
            }
        }

        private void toolStripActualizar_Click(object sender, EventArgs e)
        {
            if (txtClase.Text == "" || txtAlumno.Text == "" || txtPeriodo.Text == "")
            {
                MessageBox.Show("Debe ingresar los datos", "Error de Actualización", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Registro Actualizado", "Control de Registro", MessageBoxButtons.OK);
            }
        }
    }
}
