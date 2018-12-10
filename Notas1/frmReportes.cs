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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento para obtener la informacion de la clase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClase_Click(object sender, EventArgs e)
        {
            frmBuscar_Clases clase = new frmBuscar_Clases();
            clase.ShowDialog();
            txtClase.Text = frmBuscar_Clases.descripcionClase;

        }

        /// <summary>
        /// Evento para obtener la información del periodo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPeriodo_Click(object sender, EventArgs e)
        {
            frmBuscar_Periodo periodo = new frmBuscar_Periodo();
            periodo.ShowDialog();

            txtPeriodo.Text = frmBuscar_Periodo.descripcionPeriodo;
            txtAnio.Text = frmBuscar_Periodo.anioPeriodo;
        }

        /// <summary>
        /// Evento para generar el reporte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripGenerar_Click(object sender, EventArgs e)
        {
            if (txtClase.Text == "" || txtPeriodo.Text == "" || txtAnio.Text == "")
            {
                MessageBox.Show("Selecciones una clase y un periodo", "Información");
            }
            else
            {
                MostarReporteCalificaciones mostrar = new MostarReporteCalificaciones();
                mostrar.clase = txtClase.Text;
                mostrar.periodo = txtPeriodo.Text;

                mostrar.ShowDialog();
                Limpiar();
            }
        }

        /// <summary>
        /// Método para Limpiar las pantallas
        /// </summary>
        private void Limpiar()
        {
            txtClase.Text = "";
            txtAnio.Text = "";
            txtPeriodo.Text = "";
        }
    }
}
