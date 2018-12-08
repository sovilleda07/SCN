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
    public partial class RPTCalificaciones : Form
    {
        public RPTCalificaciones()
        {
            InitializeComponent();
        }

        private void RPTCalificaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'NotasDataSetCalificaciones.VCalificaciones' Puede moverla o quitarla según sea necesario.
            this.VCalificacionesTableAdapter.Fill(this.NotasDataSetCalificaciones.VCalificaciones);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
