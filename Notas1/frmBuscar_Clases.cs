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
    public partial class frmBuscar_Clases : Form
    {
        // Propiedades para obtener valores
        public static int codigoClases;
        public static string descripcionClase;
        public static string carrera;

        public frmBuscar_Clases()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cargar todos los componentes al inicar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBuscas_Clases_Load(object sender, EventArgs e)
        {
            CargarDGVClases();
        }

        // -----------------------Carga de Datos---------------------
        
        /// <summary>
        /// Método para Cargar los datos al DataGrid
        /// </summary>
        private void CargarDGVClases()
        {
            try
            {
                dgvClases.DataSource = Clases.Clases.GetDataView();
                dgvClases.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Evento para cargar los datos de la clase
        /// Al ser seleccionada en el DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvClases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoClases = Convert.ToInt16(dgvClases.Rows[e.RowIndex].Cells["Código"].Value);
            descripcionClase = Convert.ToString(dgvClases.Rows[e.RowIndex].Cells["Nombre"].Value);
            carrera = Convert.ToString(dgvClases.Rows[e.RowIndex].Cells["Carrera"].Value);
        }

        /// <summary>
        /// Evento para enviar los datos al otro formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvClases.SelectedRows.Count == 1)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila");
            }
            
        }

        /// <summary>
        /// Evento para Cerrar el Formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            codigoClases = 0;
            descripcionClase = null;
            carrera = null;
            dgvClases.DataSource = null;
            this.Close();
        }

        
    }
}
