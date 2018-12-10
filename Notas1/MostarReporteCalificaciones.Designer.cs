namespace Notas1
{
    partial class MostarReporteCalificaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NotasDataSet1 = new Notas1.NotasDataSet1();
            this.sp_ReporteCalificacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ReporteCalificacionesTableAdapter = new Notas1.NotasDataSet1TableAdapters.sp_ReporteCalificacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NotasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ReporteCalificacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.sp_ReporteCalificacionesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Notas1.ReporteCali.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // NotasDataSet1
            // 
            this.NotasDataSet1.DataSetName = "NotasDataSet1";
            this.NotasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_ReporteCalificacionesBindingSource
            // 
            this.sp_ReporteCalificacionesBindingSource.DataMember = "sp_ReporteCalificaciones";
            this.sp_ReporteCalificacionesBindingSource.DataSource = this.NotasDataSet1;
            // 
            // sp_ReporteCalificacionesTableAdapter
            // 
            this.sp_ReporteCalificacionesTableAdapter.ClearBeforeFill = true;
            // 
            // MostarReporteCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MostarReporteCalificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostarReporteCalificaciones";
            this.Load += new System.EventHandler(this.MostarReporteCalificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NotasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ReporteCalificacionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_ReporteCalificacionesBindingSource;
        private NotasDataSet1 NotasDataSet1;
        private NotasDataSet1TableAdapters.sp_ReporteCalificacionesTableAdapter sp_ReporteCalificacionesTableAdapter;
    }
}