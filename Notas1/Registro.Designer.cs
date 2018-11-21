namespace Notas1
{
    partial class Registro
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
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.lblcalificaciones = new System.Windows.Forms.Label();
            this.toolStripmatricula = new System.Windows.Forms.ToolStrip();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSalir = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlumno = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcreditos = new System.Windows.Forms.Label();
            this.btnPeriodo = new System.Windows.Forms.Button();
            this.txtClase = new System.Windows.Forms.TextBox();
            this.btnClase = new System.Windows.Forms.Button();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btneliminarclase = new System.Windows.Forms.Button();
            this.btnagregarclase = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelBarraTitulo.SuspendLayout();
            this.toolStripmatricula.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(81)))), ((int)(((byte)(9)))));
            this.panelBarraTitulo.Controls.Add(this.lblcalificaciones);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(800, 80);
            this.panelBarraTitulo.TabIndex = 27;
            // 
            // lblcalificaciones
            // 
            this.lblcalificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblcalificaciones.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalificaciones.ForeColor = System.Drawing.Color.White;
            this.lblcalificaciones.Location = new System.Drawing.Point(0, 0);
            this.lblcalificaciones.Name = "lblcalificaciones";
            this.lblcalificaciones.Size = new System.Drawing.Size(800, 80);
            this.lblcalificaciones.TabIndex = 23;
            this.lblcalificaciones.Text = "REGISTRO";
            this.lblcalificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStripmatricula
            // 
            this.toolStripmatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(225)))), ((int)(((byte)(229)))));
            this.toolStripmatricula.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripmatricula.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripmatricula.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGuardar,
            this.toolStripSeparator2,
            this.toolStripActualizar,
            this.toolStripSeparator1,
            this.toolStripSalir});
            this.toolStripmatricula.Location = new System.Drawing.Point(0, 413);
            this.toolStripmatricula.Name = "toolStripmatricula";
            this.toolStripmatricula.Size = new System.Drawing.Size(800, 37);
            this.toolStripmatricula.TabIndex = 28;
            this.toolStripmatricula.Text = "toolStrip1";
            // 
            // toolStripGuardar
            // 
            this.toolStripGuardar.Font = new System.Drawing.Font("Segoe UI", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.toolStripGuardar.Image = global::Notas1.Properties.Resources.icons8_save_as_30;
            this.toolStripGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGuardar.Name = "toolStripGuardar";
            this.toolStripGuardar.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.toolStripGuardar.Size = new System.Drawing.Size(114, 34);
            this.toolStripGuardar.Text = "Guardar";
            this.toolStripGuardar.Click += new System.EventHandler(this.toolStripGuardar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripActualizar
            // 
            this.toolStripActualizar.Font = new System.Drawing.Font("Segoe UI", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.toolStripActualizar.Image = global::Notas1.Properties.Resources.icons8_synchronize_24;
            this.toolStripActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripActualizar.Name = "toolStripActualizar";
            this.toolStripActualizar.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.toolStripActualizar.Size = new System.Drawing.Size(119, 34);
            this.toolStripActualizar.Text = "Actualizar";
            this.toolStripActualizar.Click += new System.EventHandler(this.toolStripActualizar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripSalir
            // 
            this.toolStripSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.toolStripSalir.Font = new System.Drawing.Font("Segoe UI", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.toolStripSalir.Image = global::Notas1.Properties.Resources.icons8_delete_24;
            this.toolStripSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSalir.Name = "toolStripSalir";
            this.toolStripSalir.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.toolStripSalir.Size = new System.Drawing.Size(82, 34);
            this.toolStripSalir.Text = "Salir";
            this.toolStripSalir.Click += new System.EventHandler(this.toolStripSalir_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 333);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 160);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAlumno, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblnombre, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtAlumno, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(400, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.51948F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.16883F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.493506F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.03896F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(391, 154);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "ALUMNO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAlumno
            // 
            this.btnAlumno.Image = global::Notas1.Properties.Resources.search_icon24;
            this.btnAlumno.Location = new System.Drawing.Point(344, 81);
            this.btnAlumno.MaximumSize = new System.Drawing.Size(38, 32);
            this.btnAlumno.MinimumSize = new System.Drawing.Size(38, 32);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(38, 32);
            this.btnAlumno.TabIndex = 28;
            this.btnAlumno.TabStop = false;
            this.btnAlumno.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAlumno.UseMnemonic = false;
            this.btnAlumno.UseVisualStyleBackColor = true;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(3, 78);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(104, 48);
            this.lblnombre.TabIndex = 16;
            this.lblnombre.Text = "   Alumno:";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlumno.Enabled = false;
            this.txtAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlumno.Location = new System.Drawing.Point(113, 81);
            this.txtAlumno.Multiline = true;
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(225, 24);
            this.txtAlumno.TabIndex = 11;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblcreditos, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnPeriodo, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.txtClase, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnClase, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtPeriodo, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.37662F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.92208F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.07792F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(391, 154);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "CLASES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblcreditos
            // 
            this.lblcreditos.AutoSize = true;
            this.lblcreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcreditos.Location = new System.Drawing.Point(3, 55);
            this.lblcreditos.Name = "lblcreditos";
            this.lblcreditos.Size = new System.Drawing.Size(54, 20);
            this.lblcreditos.TabIndex = 31;
            this.lblcreditos.Text = "Clase";
            // 
            // btnPeriodo
            // 
            this.btnPeriodo.Image = global::Notas1.Properties.Resources.search_icon24;
            this.btnPeriodo.Location = new System.Drawing.Point(344, 101);
            this.btnPeriodo.MaximumSize = new System.Drawing.Size(38, 32);
            this.btnPeriodo.MinimumSize = new System.Drawing.Size(38, 32);
            this.btnPeriodo.Name = "btnPeriodo";
            this.btnPeriodo.Size = new System.Drawing.Size(38, 32);
            this.btnPeriodo.TabIndex = 29;
            this.btnPeriodo.TabStop = false;
            this.btnPeriodo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnPeriodo.UseMnemonic = false;
            this.btnPeriodo.UseVisualStyleBackColor = true;
            this.btnPeriodo.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtClase
            // 
            this.txtClase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClase.Enabled = false;
            this.txtClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClase.Location = new System.Drawing.Point(103, 58);
            this.txtClase.Multiline = true;
            this.txtClase.Name = "txtClase";
            this.txtClase.Size = new System.Drawing.Size(235, 24);
            this.txtClase.TabIndex = 11;
            // 
            // btnClase
            // 
            this.btnClase.Image = global::Notas1.Properties.Resources.search_icon24;
            this.btnClase.Location = new System.Drawing.Point(344, 58);
            this.btnClase.MaximumSize = new System.Drawing.Size(38, 32);
            this.btnClase.MinimumSize = new System.Drawing.Size(38, 32);
            this.btnClase.Name = "btnClase";
            this.btnClase.Size = new System.Drawing.Size(38, 32);
            this.btnClase.TabIndex = 29;
            this.btnClase.TabStop = false;
            this.btnClase.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClase.UseMnemonic = false;
            this.btnClase.UseVisualStyleBackColor = true;
            this.btnClase.Click += new System.EventHandler(this.btnClase_Click);
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPeriodo.Enabled = false;
            this.txtPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodo.Location = new System.Drawing.Point(103, 101);
            this.txtPeriodo.Multiline = true;
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(235, 24);
            this.txtPeriodo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Periodo";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 169);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(794, 161);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btneliminarclase, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnagregarclase, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(788, 44);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // btneliminarclase
            // 
            this.btneliminarclase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btneliminarclase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(225)))), ((int)(((byte)(229)))));
            this.btneliminarclase.Location = new System.Drawing.Point(396, 2);
            this.btneliminarclase.Margin = new System.Windows.Forms.Padding(2);
            this.btneliminarclase.Name = "btneliminarclase";
            this.btneliminarclase.Size = new System.Drawing.Size(390, 34);
            this.btneliminarclase.TabIndex = 42;
            this.btneliminarclase.Text = "Eliminar";
            this.btneliminarclase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminarclase.UseVisualStyleBackColor = false;
            // 
            // btnagregarclase
            // 
            this.btnagregarclase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnagregarclase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(225)))), ((int)(((byte)(229)))));
            this.btnagregarclase.Location = new System.Drawing.Point(50, 2);
            this.btnagregarclase.Margin = new System.Windows.Forms.Padding(50, 2, 2, 2);
            this.btnagregarclase.Name = "btnagregarclase";
            this.btnagregarclase.Size = new System.Drawing.Size(342, 34);
            this.btnagregarclase.TabIndex = 41;
            this.btnagregarclase.Text = "Agregar";
            this.btnagregarclase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnagregarclase.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 105);
            this.dataGridView1.TabIndex = 1;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStripmatricula);
            this.Controls.Add(this.panelBarraTitulo);
            this.Name = "Registro";
            this.Text = "Matricula";
            this.panelBarraTitulo.ResumeLayout(false);
            this.toolStripmatricula.ResumeLayout(false);
            this.toolStripmatricula.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.ToolStrip toolStripmatricula;
        private System.Windows.Forms.ToolStripButton toolStripGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripSalir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtClase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClase;
        private System.Windows.Forms.Label lblcreditos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btneliminarclase;
        private System.Windows.Forms.Button btnagregarclase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblcalificaciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlumno;
        private System.Windows.Forms.Button btnPeriodo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label label3;
    }
}