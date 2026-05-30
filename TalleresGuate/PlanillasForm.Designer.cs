namespace TalleresGuate
{
    partial class PlanillasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanillasForm));
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.lblPlanillas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.txtIGSS = new System.Windows.Forms.TextBox();
            this.txtISR = new System.Windows.Forms.TextBox();
            this.txtPagoHorasExtra = new System.Windows.Forms.TextBox();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.cboxCodigoEmpleado = new System.Windows.Forms.ComboBox();
            this.lblPagoHorasExtra = new System.Windows.Forms.Label();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.txtTotalPago = new System.Windows.Forms.TextBox();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.lblISR = new System.Windows.Forms.Label();
            this.lblIGSS = new System.Windows.Forms.Label();
            this.nudHorasTrabajadas = new System.Windows.Forms.NumericUpDown();
            this.lblHorasTrabajadas = new System.Windows.Forms.Label();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.lblCodigoEmpleado = new System.Windows.Forms.Label();
            this.txtCodigoPlanilla = new System.Windows.Forms.TextBox();
            this.lblCodigoPlanilla = new System.Windows.Forms.Label();
            this.dgvPlanillas = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkSeleccionar = new System.Windows.Forms.CheckBox();
            this.btnExportar = new FontAwesome.Sharp.IconButton();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasTrabajadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 20;
            this.btnCerrar.Location = new System.Drawing.Point(886, 479);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(93, 29);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblPlanillas
            // 
            this.lblPlanillas.AutoSize = true;
            this.lblPlanillas.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblPlanillas.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPlanillas.Location = new System.Drawing.Point(68, 12);
            this.lblPlanillas.Name = "lblPlanillas";
            this.lblPlanillas.Size = new System.Drawing.Size(126, 32);
            this.lblPlanillas.TabIndex = 10;
            this.lblPlanillas.Text = "Planillas";
            this.lblPlanillas.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(913, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 20;
            this.btnEliminar.Location = new System.Drawing.Point(790, 310);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 29);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 20;
            this.btnEditar.Location = new System.Drawing.Point(790, 232);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 29);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 20;
            this.btnGuardar.Location = new System.Drawing.Point(790, 161);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 29);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 20;
            this.btnCancelar.Location = new System.Drawing.Point(790, 101);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNuevo.IconColor = System.Drawing.Color.Black;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 20;
            this.btnNuevo.Location = new System.Drawing.Point(790, 26);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 29);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(446, 311);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 16);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Estado:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.lblFechaPago);
            this.tabPage2.Controls.Add(this.dtpFechaPago);
            this.tabPage2.Controls.Add(this.txtIGSS);
            this.tabPage2.Controls.Add(this.txtISR);
            this.tabPage2.Controls.Add(this.txtPagoHorasExtra);
            this.tabPage2.Controls.Add(this.txtSalarioBase);
            this.tabPage2.Controls.Add(this.cboxCodigoEmpleado);
            this.tabPage2.Controls.Add(this.lblPagoHorasExtra);
            this.tabPage2.Controls.Add(this.btnEliminar);
            this.tabPage2.Controls.Add(this.btnEditar);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Controls.Add(this.lblEstado);
            this.tabPage2.Controls.Add(this.rdbInactivo);
            this.tabPage2.Controls.Add(this.rdbActivo);
            this.tabPage2.Controls.Add(this.txtTotalPago);
            this.tabPage2.Controls.Add(this.lblTotalPago);
            this.tabPage2.Controls.Add(this.lblISR);
            this.tabPage2.Controls.Add(this.lblIGSS);
            this.tabPage2.Controls.Add(this.nudHorasTrabajadas);
            this.tabPage2.Controls.Add(this.lblHorasTrabajadas);
            this.tabPage2.Controls.Add(this.lblSalarioBase);
            this.tabPage2.Controls.Add(this.lblCodigoEmpleado);
            this.tabPage2.Controls.Add(this.txtCodigoPlanilla);
            this.tabPage2.Controls.Add(this.lblCodigoPlanilla);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(905, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gestiona";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(446, 255);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(113, 16);
            this.lblFechaPago.TabIndex = 26;
            this.lblFechaPago.Text = "Fecha Del Pago:";
            this.lblFechaPago.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(565, 248);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaPago.TabIndex = 25;
            // 
            // txtIGSS
            // 
            this.txtIGSS.Enabled = false;
            this.txtIGSS.Location = new System.Drawing.Point(565, 39);
            this.txtIGSS.Name = "txtIGSS";
            this.txtIGSS.ReadOnly = true;
            this.txtIGSS.Size = new System.Drawing.Size(200, 23);
            this.txtIGSS.TabIndex = 24;
            // 
            // txtISR
            // 
            this.txtISR.Enabled = false;
            this.txtISR.Location = new System.Drawing.Point(565, 114);
            this.txtISR.Name = "txtISR";
            this.txtISR.ReadOnly = true;
            this.txtISR.Size = new System.Drawing.Size(200, 23);
            this.txtISR.TabIndex = 23;
            // 
            // txtPagoHorasExtra
            // 
            this.txtPagoHorasExtra.Enabled = false;
            this.txtPagoHorasExtra.Location = new System.Drawing.Point(184, 309);
            this.txtPagoHorasExtra.Name = "txtPagoHorasExtra";
            this.txtPagoHorasExtra.ReadOnly = true;
            this.txtPagoHorasExtra.Size = new System.Drawing.Size(229, 23);
            this.txtPagoHorasExtra.TabIndex = 22;
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Enabled = false;
            this.txtSalarioBase.Location = new System.Drawing.Point(184, 180);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.ReadOnly = true;
            this.txtSalarioBase.Size = new System.Drawing.Size(229, 23);
            this.txtSalarioBase.TabIndex = 21;
            // 
            // cboxCodigoEmpleado
            // 
            this.cboxCodigoEmpleado.FormattingEnabled = true;
            this.cboxCodigoEmpleado.Items.AddRange(new object[] {
            "Hipermercado",
            "Supermercado",
            "Minimercado",
            "Superexpres"});
            this.cboxCodigoEmpleado.Location = new System.Drawing.Point(184, 109);
            this.cboxCodigoEmpleado.Name = "cboxCodigoEmpleado";
            this.cboxCodigoEmpleado.Size = new System.Drawing.Size(229, 24);
            this.cboxCodigoEmpleado.TabIndex = 20;
            this.cboxCodigoEmpleado.SelectedIndexChanged += new System.EventHandler(this.cboxCodigoEmpleado_SelectedIndexChanged);
            // 
            // lblPagoHorasExtra
            // 
            this.lblPagoHorasExtra.AutoSize = true;
            this.lblPagoHorasExtra.Location = new System.Drawing.Point(35, 316);
            this.lblPagoHorasExtra.Name = "lblPagoHorasExtra";
            this.lblPagoHorasExtra.Size = new System.Drawing.Size(150, 16);
            this.lblPagoHorasExtra.TabIndex = 19;
            this.lblPagoHorasExtra.Text = "Pago De Horas Extras:";
            // 
            // rdbInactivo
            // 
            this.rdbInactivo.AutoSize = true;
            this.rdbInactivo.Location = new System.Drawing.Point(686, 309);
            this.rdbInactivo.Name = "rdbInactivo";
            this.rdbInactivo.Size = new System.Drawing.Size(73, 20);
            this.rdbInactivo.TabIndex = 16;
            this.rdbInactivo.TabStop = true;
            this.rdbInactivo.Text = "Inactivo";
            this.rdbInactivo.UseVisualStyleBackColor = true;
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Location = new System.Drawing.Point(549, 308);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(63, 20);
            this.rdbActivo.TabIndex = 15;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = true;
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.Enabled = false;
            this.txtTotalPago.Location = new System.Drawing.Point(565, 180);
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.ReadOnly = true;
            this.txtTotalPago.Size = new System.Drawing.Size(200, 23);
            this.txtTotalPago.TabIndex = 14;
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.Location = new System.Drawing.Point(446, 187);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(100, 16);
            this.lblTotalPago.TabIndex = 13;
            this.lblTotalPago.Text = "Total De Pago:";
            // 
            // lblISR
            // 
            this.lblISR.AutoSize = true;
            this.lblISR.Location = new System.Drawing.Point(446, 121);
            this.lblISR.Name = "lblISR";
            this.lblISR.Size = new System.Drawing.Size(33, 16);
            this.lblISR.TabIndex = 11;
            this.lblISR.Text = "ISR:";
            // 
            // lblIGSS
            // 
            this.lblIGSS.AutoSize = true;
            this.lblIGSS.Location = new System.Drawing.Point(446, 46);
            this.lblIGSS.Name = "lblIGSS";
            this.lblIGSS.Size = new System.Drawing.Size(43, 16);
            this.lblIGSS.TabIndex = 9;
            this.lblIGSS.Text = "IGSS:";
            // 
            // nudHorasTrabajadas
            // 
            this.nudHorasTrabajadas.Location = new System.Drawing.Point(184, 254);
            this.nudHorasTrabajadas.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudHorasTrabajadas.Name = "nudHorasTrabajadas";
            this.nudHorasTrabajadas.Size = new System.Drawing.Size(229, 23);
            this.nudHorasTrabajadas.TabIndex = 8;
            this.nudHorasTrabajadas.ValueChanged += new System.EventHandler(this.nudHorasTrabajadas_ValueChanged);
            // 
            // lblHorasTrabajadas
            // 
            this.lblHorasTrabajadas.AutoSize = true;
            this.lblHorasTrabajadas.Location = new System.Drawing.Point(35, 256);
            this.lblHorasTrabajadas.Name = "lblHorasTrabajadas";
            this.lblHorasTrabajadas.Size = new System.Drawing.Size(123, 16);
            this.lblHorasTrabajadas.TabIndex = 7;
            this.lblHorasTrabajadas.Text = "Horas Trabajadas:";
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Location = new System.Drawing.Point(35, 187);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(91, 16);
            this.lblSalarioBase.TabIndex = 5;
            this.lblSalarioBase.Text = "Salario Base:";
            // 
            // lblCodigoEmpleado
            // 
            this.lblCodigoEmpleado.AutoSize = true;
            this.lblCodigoEmpleado.Location = new System.Drawing.Point(33, 117);
            this.lblCodigoEmpleado.Name = "lblCodigoEmpleado";
            this.lblCodigoEmpleado.Size = new System.Drawing.Size(145, 16);
            this.lblCodigoEmpleado.TabIndex = 3;
            this.lblCodigoEmpleado.Text = "Codigo De Empleado:";
            // 
            // txtCodigoPlanilla
            // 
            this.txtCodigoPlanilla.Enabled = false;
            this.txtCodigoPlanilla.Location = new System.Drawing.Point(184, 39);
            this.txtCodigoPlanilla.Name = "txtCodigoPlanilla";
            this.txtCodigoPlanilla.ReadOnly = true;
            this.txtCodigoPlanilla.Size = new System.Drawing.Size(229, 23);
            this.txtCodigoPlanilla.TabIndex = 2;
            // 
            // lblCodigoPlanilla
            // 
            this.lblCodigoPlanilla.AutoSize = true;
            this.lblCodigoPlanilla.Location = new System.Drawing.Point(33, 42);
            this.lblCodigoPlanilla.Name = "lblCodigoPlanilla";
            this.lblCodigoPlanilla.Size = new System.Drawing.Size(127, 16);
            this.lblCodigoPlanilla.TabIndex = 0;
            this.lblCodigoPlanilla.Text = "Codigo De Planilla:";
            // 
            // dgvPlanillas
            // 
            this.dgvPlanillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanillas.Location = new System.Drawing.Point(44, 79);
            this.dgvPlanillas.Name = "dgvPlanillas";
            this.dgvPlanillas.Size = new System.Drawing.Size(820, 239);
            this.dgvPlanillas.TabIndex = 2;
            this.dgvPlanillas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanillas_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.tabControl1.Location = new System.Drawing.Point(70, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(913, 408);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.chkSeleccionar);
            this.tabPage1.Controls.Add(this.btnExportar);
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.dgvPlanillas);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(905, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.AutoSize = true;
            this.chkSeleccionar.Location = new System.Drawing.Point(44, 56);
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.Size = new System.Drawing.Size(100, 20);
            this.chkSeleccionar.TabIndex = 7;
            this.chkSeleccionar.Text = "Seleccionar";
            this.chkSeleccionar.UseVisualStyleBackColor = true;
            this.chkSeleccionar.CheckedChanged += new System.EventHandler(this.chkSeleccionar_CheckedChanged);
            // 
            // btnExportar
            // 
            this.btnExportar.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnExportar.IconColor = System.Drawing.Color.Black;
            this.btnExportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportar.IconSize = 20;
            this.btnExportar.Location = new System.Drawing.Point(44, 324);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(100, 33);
            this.btnExportar.TabIndex = 6;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimir.IconColor = System.Drawing.Color.Black;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.IconSize = 20;
            this.btnImprimir.Location = new System.Drawing.Point(688, 19);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(92, 29);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Limpiar";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 20;
            this.btnLimpiar.Location = new System.Drawing.Point(567, 19);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 29);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 20;
            this.btnBuscar.Location = new System.Drawing.Point(439, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 29);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(314, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 10F);
            this.lblNombre.Location = new System.Drawing.Point(41, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // PlanillasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 533);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblPlanillas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "PlanillasForm";
            this.Text = "PlanillasForm";
            this.Load += new System.EventHandler(this.PlanillasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorasTrabajadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label lblPlanillas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rdbInactivo;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.TextBox txtTotalPago;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.Label lblISR;
        private System.Windows.Forms.Label lblIGSS;
        private System.Windows.Forms.NumericUpDown nudHorasTrabajadas;
        private System.Windows.Forms.Label lblHorasTrabajadas;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.Label lblCodigoEmpleado;
        private System.Windows.Forms.TextBox txtCodigoPlanilla;
        private System.Windows.Forms.Label lblCodigoPlanilla;
        private System.Windows.Forms.DataGridView dgvPlanillas;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkSeleccionar;
        private FontAwesome.Sharp.IconButton btnExportar;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPagoHorasExtra;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.ComboBox cboxCodigoEmpleado;
        private System.Windows.Forms.TextBox txtIGSS;
        private System.Windows.Forms.TextBox txtISR;
        private System.Windows.Forms.TextBox txtPagoHorasExtra;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
    }
}