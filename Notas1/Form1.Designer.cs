namespace Notas1
{
    partial class MenuFondo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuFondo));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelFormuarios = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnPeriodos = new System.Windows.Forms.Button();
            this.btnMatricula = new System.Windows.Forms.Button();
            this.btnCarreras = new System.Windows.Forms.Button();
            this.btnClase = new System.Windows.Forms.Button();
            this.btnCalificaciones = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor.SuspendLayout();
            this.panelFormuarios.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            this.panelContenedor.Controls.Add(this.panelFormuarios);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelBarraTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1040, 491);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelFormuarios
            // 
            this.panelFormuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(224)))));
            this.panelFormuarios.Controls.Add(this.btnInfo);
            this.panelFormuarios.Controls.Add(this.panel1);
            this.panelFormuarios.Controls.Add(this.label2);
            this.panelFormuarios.Controls.Add(this.pictureBoxLogo);
            this.panelFormuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormuarios.Location = new System.Drawing.Point(199, 40);
            this.panelFormuarios.Name = "panelFormuarios";
            this.panelFormuarios.Size = new System.Drawing.Size(841, 451);
            this.panelFormuarios.TabIndex = 2;
            this.panelFormuarios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormuarios_Paint);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(81)))), ((int)(((byte)(9)))));
            this.btnInfo.BackgroundImage = global::Notas1.Properties.Resources.information;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(1, 2);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(38, 41);
            this.btnInfo.TabIndex = 30;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(81)))), ((int)(((byte)(9)))));
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 53);
            this.panel1.TabIndex = 29;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTitulo, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(841, 53);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(797, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(3, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(835, 35);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "SISTEMA DE CONTROL DE NOTAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(841, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "       Bienvenida Ingeniera";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::Notas1.Properties.Resources.uth_png_1;
            this.pictureBoxLogo.Location = new System.Drawing.Point(236, 72);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(391, 350);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(161)))), ((int)(((byte)(94)))));
            this.panelMenu.Controls.Add(this.tableLayoutPanel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(199, 451);
            this.panelMenu.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.btnAlumnos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPeriodos, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMatricula, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCarreras, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClase, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCalificaciones, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnUsuarios, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 451);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(81)))), ((int)(((byte)(9)))));
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.Image = ((System.Drawing.Image)(resources.GetObject("btnAlumnos.Image")));
            this.btnAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.Location = new System.Drawing.Point(3, 3);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(194, 50);
            this.btnAlumnos.TabIndex = 0;
            this.btnAlumnos.Text = "                   ALUMNOS";
            this.btnAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnPeriodos
            // 
            this.btnPeriodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeriodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPeriodos.FlatAppearance.BorderSize = 0;
            this.btnPeriodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(81)))), ((int)(((byte)(9)))));
            this.btnPeriodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeriodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriodos.Image = global::Notas1.Properties.Resources.icons8_schedule_50;
            this.btnPeriodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeriodos.Location = new System.Drawing.Point(3, 171);
            this.btnPeriodos.Name = "btnPeriodos";
            this.btnPeriodos.Size = new System.Drawing.Size(194, 50);
            this.btnPeriodos.TabIndex = 3;
            this.btnPeriodos.Text = "                  PERIODOS";
            this.btnPeriodos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeriodos.UseVisualStyleBackColor = true;
            this.btnPeriodos.Click += new System.EventHandler(this.btnPeriodos_Click);
            // 
            // btnMatricula
            // 
            this.btnMatricula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatricula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMatricula.FlatAppearance.BorderSize = 0;
            this.btnMatricula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(81)))), ((int)(((byte)(9)))));
            this.btnMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatricula.Image = global::Notas1.Properties.Resources.icons8_registry_editor_50;
            this.btnMatricula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatricula.Location = new System.Drawing.Point(3, 227);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(194, 50);
            this.btnMatricula.TabIndex = 1;
            this.btnMatricula.Text = "                 REGISTRO";
            this.btnMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatricula.UseVisualStyleBackColor = true;
            this.btnMatricula.Click += new System.EventHandler(this.btnMatricula_Click);
            // 
            // btnCarreras
            // 
            this.btnCarreras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarreras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCarreras.FlatAppearance.BorderSize = 0;
            this.btnCarreras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(81)))), ((int)(((byte)(9)))));
            this.btnCarreras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarreras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarreras.Image = global::Notas1.Properties.Resources.icons8_maintenance_50;
            this.btnCarreras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarreras.Location = new System.Drawing.Point(3, 59);
            this.btnCarreras.Name = "btnCarreras";
            this.btnCarreras.Size = new System.Drawing.Size(194, 50);
            this.btnCarreras.TabIndex = 4;
            this.btnCarreras.Text = "                  CARRERAS";
            this.btnCarreras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarreras.UseVisualStyleBackColor = true;
            this.btnCarreras.Click += new System.EventHandler(this.btnCarreras_Click);
            // 
            // btnClase
            // 
            this.btnClase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClase.FlatAppearance.BorderSize = 0;
            this.btnClase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(81)))), ((int)(((byte)(9)))));
            this.btnClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClase.Image = global::Notas1.Properties.Resources.icons8_training_50;
            this.btnClase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClase.Location = new System.Drawing.Point(3, 115);
            this.btnClase.Name = "btnClase";
            this.btnClase.Size = new System.Drawing.Size(194, 50);
            this.btnClase.TabIndex = 5;
            this.btnClase.Text = "                  CLASES";
            this.btnClase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClase.UseVisualStyleBackColor = true;
            this.btnClase.Click += new System.EventHandler(this.btnClase_Click);
            // 
            // btnCalificaciones
            // 
            this.btnCalificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalificaciones.FlatAppearance.BorderSize = 0;
            this.btnCalificaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(81)))), ((int)(((byte)(9)))));
            this.btnCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalificaciones.Image = global::Notas1.Properties.Resources.icons8_test_passed_50;
            this.btnCalificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalificaciones.Location = new System.Drawing.Point(3, 283);
            this.btnCalificaciones.Name = "btnCalificaciones";
            this.btnCalificaciones.Size = new System.Drawing.Size(194, 50);
            this.btnCalificaciones.TabIndex = 6;
            this.btnCalificaciones.Text = "                  CALIFICACIONES";
            this.btnCalificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalificaciones.UseVisualStyleBackColor = true;
            this.btnCalificaciones.Click += new System.EventHandler(this.btnCalificaciones_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(81)))), ((int)(((byte)(9)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = global::Notas1.Properties.Resources.icons8_pie_chart_report_50;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(3, 339);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(194, 50);
            this.button8.TabIndex = 7;
            this.button8.Text = "                  REPORTES";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(81)))), ((int)(((byte)(9)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Image = global::Notas1.Properties.Resources.mantenimiento;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 395);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(194, 53);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "                  MANTENIMIENTO";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(24)))));
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1040, 40);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(989, 12);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestaurar.TabIndex = 4;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(967, 9);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(989, 9);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1011, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MenuFondo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 491);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1040, 491);
            this.Name = "MenuFondo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelContenedor.ResumeLayout(false);
            this.panelFormuarios.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelFormuarios;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnMatricula;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnPeriodos;
        private System.Windows.Forms.Button btnCarreras;
        private System.Windows.Forms.Button btnClase;
        private System.Windows.Forms.Button btnCalificaciones;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnInfo;
    }
}

