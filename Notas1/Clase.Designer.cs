namespace Notas1
{
    partial class Clase
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripInhabilitar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSalir = new System.Windows.Forms.ToolStripButton();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.lblcalificaciones = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcarrera = new System.Windows.Forms.Label();
            this.lblcreditos = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(225)))), ((int)(((byte)(229)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGuardar,
            this.toolStripSeparator2,
            this.toolStripActualizar,
            this.toolStripSeparator1,
            this.toolStripInhabilitar,
            this.toolStripSeparator3,
            this.toolStripSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 411);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripGuardar
            // 
            this.toolStripGuardar.Font = new System.Drawing.Font("Segoe UI", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.toolStripGuardar.Image = global::Notas1.Properties.Resources.icons8_save_as_30;
            this.toolStripGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGuardar.Name = "toolStripGuardar";
            this.toolStripGuardar.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.toolStripGuardar.Size = new System.Drawing.Size(114, 36);
            this.toolStripGuardar.Text = "Guardar";
            this.toolStripGuardar.Click += new System.EventHandler(this.toolStripGuardar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripActualizar
            // 
            this.toolStripActualizar.Font = new System.Drawing.Font("Segoe UI", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.toolStripActualizar.Image = global::Notas1.Properties.Resources.icons8_synchronize_24;
            this.toolStripActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripActualizar.Name = "toolStripActualizar";
            this.toolStripActualizar.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.toolStripActualizar.Size = new System.Drawing.Size(119, 36);
            this.toolStripActualizar.Text = "Actualizar";
            this.toolStripActualizar.Click += new System.EventHandler(this.toolStripActualizar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripInhabilitar
            // 
            this.toolStripInhabilitar.Font = new System.Drawing.Font("Segoe UI", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.toolStripInhabilitar.Image = global::Notas1.Properties.Resources.icons8_denied_321;
            this.toolStripInhabilitar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripInhabilitar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripInhabilitar.Name = "toolStripInhabilitar";
            this.toolStripInhabilitar.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.toolStripInhabilitar.Size = new System.Drawing.Size(129, 36);
            this.toolStripInhabilitar.Text = "Inhabilitar";
            this.toolStripInhabilitar.Click += new System.EventHandler(this.toolStripInhabilitar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSalir
            // 
            this.toolStripSalir.Font = new System.Drawing.Font("Segoe UI", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.toolStripSalir.Image = global::Notas1.Properties.Resources.icons8_delete_24;
            this.toolStripSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSalir.Name = "toolStripSalir";
            this.toolStripSalir.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.toolStripSalir.Size = new System.Drawing.Size(82, 36);
            this.toolStripSalir.Text = "Salir";
            this.toolStripSalir.Click += new System.EventHandler(this.toolStripSalir_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(81)))), ((int)(((byte)(9)))));
            this.panelBarraTitulo.Controls.Add(this.lblcalificaciones);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(800, 80);
            this.panelBarraTitulo.TabIndex = 28;
            // 
            // lblcalificaciones
            // 
            this.lblcalificaciones.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalificaciones.ForeColor = System.Drawing.Color.White;
            this.lblcalificaciones.Location = new System.Drawing.Point(13, -3);
            this.lblcalificaciones.Name = "lblcalificaciones";
            this.lblcalificaciones.Size = new System.Drawing.Size(800, 80);
            this.lblcalificaciones.TabIndex = 23;
            this.lblcalificaciones.Text = "CLASE";
            this.lblcalificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 331);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblnombre, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblcarrera, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblcreditos, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 325);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(20, 64);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(20, 0, 2, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(71, 20);
            this.lblnombre.TabIndex = 8;
            this.lblnombre.Text = "Nombre";
            // 
            // lblcarrera
            // 
            this.lblcarrera.AutoSize = true;
            this.lblcarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarrera.Location = new System.Drawing.Point(20, 128);
            this.lblcarrera.Margin = new System.Windows.Forms.Padding(20, 0, 2, 0);
            this.lblcarrera.Name = "lblcarrera";
            this.lblcarrera.Size = new System.Drawing.Size(69, 20);
            this.lblcarrera.TabIndex = 18;
            this.lblcarrera.Text = "Carrera";
            // 
            // lblcreditos
            // 
            this.lblcreditos.AutoSize = true;
            this.lblcreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcreditos.Location = new System.Drawing.Point(20, 192);
            this.lblcreditos.Margin = new System.Windows.Forms.Padding(20, 0, 2, 0);
            this.lblcreditos.Name = "lblcreditos";
            this.lblcreditos.Size = new System.Drawing.Size(98, 20);
            this.lblcreditos.TabIndex = 19;
            this.lblcreditos.Text = "N. Créditos";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.txtNombre, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtCarrera, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtCreditos, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnBuscar, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(203, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(594, 325);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(3, 67);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(385, 26);
            this.txtNombre.TabIndex = 21;
            this.txtNombre.Tag = "";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarrera.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCarrera.Enabled = false;
            this.txtCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrera.Location = new System.Drawing.Point(3, 131);
            this.txtCarrera.Multiline = true;
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(385, 26);
            this.txtCarrera.TabIndex = 22;
            this.txtCarrera.Tag = "";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Notas1.Properties.Resources.search_icon24;
            this.btnBuscar.Location = new System.Drawing.Point(394, 131);
            this.btnBuscar.MaximumSize = new System.Drawing.Size(38, 32);
            this.btnBuscar.MinimumSize = new System.Drawing.Size(38, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 32);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBuscar.UseMnemonic = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCreditos
            // 
            this.txtCreditos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreditos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditos.Location = new System.Drawing.Point(3, 195);
            this.txtCreditos.Multiline = true;
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(385, 26);
            this.txtCreditos.TabIndex = 23;
            this.txtCreditos.Tag = "";
            // 
            // Clase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Clase";
            this.Text = "Clase";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelBarraTitulo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripInhabilitar;
        private System.Windows.Forms.ToolStripButton toolStripSalir;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label lblcalificaciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcarrera;
        private System.Windows.Forms.Label lblcreditos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TextBox txtCreditos;
    }
}