using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notas1.Clases;

namespace Notas1
{
    public partial class frmBuscar_Alumno_Calificación : Form
    {
        // Constructores
        public frmBuscar_Alumno_Calificación()
        {
            InitializeComponent();
        }

        
        private void frmBuscar_Alumno_Calificación_Load(object sender, EventArgs e)
        {

        }

        // -----------------------Carga de Datos---------------------
        /// <summary>
        /// Método para Cargar los datos al DataGrid
        /// </summary>
        private void CargarDGVAlumnos()
        {
            try
            {
                dgvAlumnos.DataSource = Alumnos
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
