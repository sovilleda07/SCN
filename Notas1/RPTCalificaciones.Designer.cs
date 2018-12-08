namespace Notas1
{
    partial class RPTCalificaciones
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NotasDataSetCalificaciones = new Notas1.NotasDataSetCalificaciones();
            this.VCalificacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VCalificacionesTableAdapter = new Notas1.NotasDataSetCalificacionesTableAdapters.VCalificacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NotasDataSetCalificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VCalificacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VCalificacionesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Notas1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(792, 466);
            this.reportViewer1.TabIndex = 0;
            // 
            // NotasDataSetCalificaciones
            // 
            this.NotasDataSetCalificaciones.DataSetName = "NotasDataSetCalificaciones";
            this.NotasDataSetCalificaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VCalificacionesBindingSource
            // 
            this.VCalificacionesBindingSource.DataMember = "VCalificaciones";
            this.VCalificacionesBindingSource.DataSource = this.NotasDataSetCalificaciones;
            // 
            // VCalificacionesTableAdapter
            // 
            this.VCalificacionesTableAdapter.ClearBeforeFill = true;
            // 
            // RPTCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 490);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RPTCalificaciones";
            this.Text = "RPTCalificaciones";
            this.Load += new System.EventHandler(this.RPTCalificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NotasDataSetCalificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VCalificacionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VCalificacionesBindingSource;
        private NotasDataSetCalificaciones NotasDataSetCalificaciones;
        private NotasDataSetCalificacionesTableAdapters.VCalificacionesTableAdapter VCalificacionesTableAdapter;
    }
}