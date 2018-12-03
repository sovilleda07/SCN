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
    public partial class frmBuscar_Periodo : Form
    {
        // Propiedades para obtener valores
        public static int codigoPeriodo;
        public static string descripcionPeriodo;
        public static string anioPeriodo;

        public frmBuscar_Periodo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cargar todos los componentes al iniciar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmBuscar_Periodo_Load(object sender, EventArgs e)
        {
            CargarDGVPeriodos();
        }

        // -----------------------Carga de Datos---------------------

        /// <summary>
        /// Método para Cargar los datos al DataGrid
        /// </summary>
        private void CargarDGVPeriodos()
        {
            try
            {
                dgvPeriodos.DataSource = Periodos.GetDataView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento para cargar los datos del periodo
        /// Al ser seleccionado en el DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPeriodos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoPeriodo = Convert.ToInt16(dgvPeriodos.Rows[e.RowIndex].Cells["Código"].Value);
            descripcionPeriodo = Convert.ToString(dgvPeriodos.Rows[e.RowIndex].Cells["Descripción"].Value);
            anioPeriodo = Convert.ToString(dgvPeriodos.Rows[e.RowIndex].Cells["Año"].Value);
        }

        /// <summary>
        /// Evento para enviar los datos al otro formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvPeriodos.SelectedRows.Count == 1)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar una fila");
            }
            
        }

        /// <summary>
        /// Evento para cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            codigoPeriodo = 0;
            descripcionPeriodo = null;
            anioPeriodo = null;
            dgvPeriodos.DataSource = null;
            this.Close();
        }

        private void lblcalificaciones_Click(object sender, EventArgs e)
        {

        }

        
    }
}
