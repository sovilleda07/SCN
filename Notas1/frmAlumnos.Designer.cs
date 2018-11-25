namespace Notas1
{
    partial class frmAlumnos
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripInhabilitar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSalir = new System.Windows.Forms.ToolStripButton();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.lblcalificaciones = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblapellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblnombres = new System.Windows.Forms.Label();
            this.lblcarrera = new System.Windows.Forms.Label();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.mtxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.toolStripSeparator4,
            this.toolStripLimpiar,
            this.toolStripSeparator3,
            this.toolStripSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 391);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(940, 39);
            this.toolStrip1.TabIndex = 15;
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
            this.toolStripGuardar.Click += new System.EventHandler(this.toolStripGuardar_Click_1);
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
            this.toolStripActualizar.Click += new System.EventHandler(this.toolStripActualizar_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripInhabilitar
            // 
            this.toolStripInhabilitar.Font = new System.Drawing.Font("Segoe UI", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.toolStripInhabilitar.Image = global::Notas1.Properties.Resources.icons8_denied_32;
            this.toolStripInhabilitar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripInhabilitar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripInhabilitar.Name = "toolStripInhabilitar";
            this.toolStripInhabilitar.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.toolStripInhabilitar.Size = new System.Drawing.Size(129, 36);
            this.toolStripInhabilitar.Text = "Inhabilitar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLimpiar
            // 
            this.toolStripLimpiar.Font = new System.Drawing.Font("Segoe UI", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.toolStripLimpiar.Image = global::Notas1.Properties.Resources.icons8_delete_24;
            this.toolStripLimpiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLimpiar.Name = "toolStripLimpiar";
            this.toolStripLimpiar.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.toolStripLimpiar.Size = new System.Drawing.Size(104, 36);
            this.toolStripLimpiar.Text = "Limpiar";
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
            this.toolStripSalir.Click += new System.EventHandler(this.toolStripSalir_Click_1);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(81)))), ((int)(((byte)(9)))));
            this.panelBarraTitulo.Controls.Add(this.lblcalificaciones);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(940, 80);
            this.panelBarraTitulo.TabIndex = 26;
            // 
            // lblcalificaciones
            // 
            this.lblcalificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblcalificaciones.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalificaciones.ForeColor = System.Drawing.Color.White;
            this.lblcalificaciones.Location = new System.Drawing.Point(0, 0);
            this.lblcalificaciones.Name = "lblcalificaciones";
            this.lblcalificaciones.Size = new System.Drawing.Size(940, 80);
            this.lblcalificaciones.TabIndex = 23;
            this.lblcalificaciones.Text = "ALUMNOS";
            this.lblcalificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(940, 311);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblapellidos, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtApellidos, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtNombres, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblnombres, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblcarrera, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.cmbCarrera, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.mtxtTelefono, 1, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(464, 285);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblapellidos
            // 
            this.lblapellidos.AutoSize = true;
            this.lblapellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellidos.Location = new System.Drawing.Point(3, 105);
            this.lblapellidos.Name = "lblapellidos";
            this.lblapellidos.Size = new System.Drawing.Size(82, 20);
            this.lblapellidos.TabIndex = 5;
            this.lblapellidos.Text = "Apellidos";
            this.lblapellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(113, 108);
            this.txtApellidos.Multiline = true;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(298, 26);
            this.txtApellidos.TabIndex = 11;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidos_KeyPress);
            // 
            // txtNombres
            // 
            this.txtNombres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(113, 73);
            this.txtNombres.Multiline = true;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(298, 26);
            this.txtNombres.TabIndex = 10;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombres_KeyPress);
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombres.Location = new System.Drawing.Point(3, 70);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(80, 20);
            this.lblnombres.TabIndex = 4;
            this.lblnombres.Text = "Nombres";
            this.lblnombres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblcarrera
            // 
            this.lblcarrera.AutoSize = true;
            this.lblcarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarrera.Location = new System.Drawing.Point(3, 140);
            this.lblcarrera.Name = "lblcarrera";
            this.lblcarrera.Size = new System.Drawing.Size(69, 20);
            this.lblcarrera.TabIndex = 9;
            this.lblcarrera.Text = "Carrera";
            this.lblcarrera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(113, 143);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(298, 21);
            this.cmbCarrera.TabIndex = 12;
            // 
            // mtxtTelefono
            // 
            this.mtxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelefono.Location = new System.Drawing.Point(113, 213);
            this.mtxtTelefono.Mask = "0000-0000";
            this.mtxtTelefono.Name = "mtxtTelefono";
            this.mtxtTelefono.Size = new System.Drawing.Size(298, 24);
            this.mtxtTelefono.TabIndex = 13;
            this.mtxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Controls.Add(this.txtObservaciones, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.lbltelefono, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblemail, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtEmail, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtTelefono, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(473, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.75439F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.807018F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(464, 285);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(153, 143);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(258, 56);
            this.txtObservaciones.TabIndex = 13;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.Location = new System.Drawing.Point(3, 70);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(79, 20);
            this.lbltelefono.TabIndex = 7;
            this.lbltelefono.Text = "Teléfono";
            this.lbltelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Observaciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(3, 105);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(64, 20);
            this.lblemail.TabIndex = 8;
            this.lblemail.Text = "E-mail ";
            this.lblemail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(153, 108);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(258, 26);
            this.txtEmail.TabIndex = 12;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(153, 73);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(258, 26);
            this.txtTelefono.TabIndex = 12;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(940, 430);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmAlumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.frmAlumnos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelBarraTitulo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Label lblapellidos;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblcarrera;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripLimpiar;
        private System.Windows.Forms.MaskedTextBox mtxtTelefono;
    }
}