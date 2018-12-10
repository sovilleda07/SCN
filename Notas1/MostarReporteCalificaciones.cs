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
    public partial class MostarReporteCalificaciones : Form
    {
        public MostarReporteCalificaciones()
        {
            InitializeComponent();
        }

        // Propiedades para obtener reporte
        public string clase { get; set; }
        public string periodo { get; set; }

        private void MostarReporteCalificaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'NotasDataSet1.sp_ReporteCalificaciones' Puede moverla o quitarla según sea necesario.
            this.sp_ReporteCalificacionesTableAdapter.Fill(this.NotasDataSet1.sp_ReporteCalificaciones,clase,periodo);

            this.reportViewer1.RefreshReport();
        }
    }
}
