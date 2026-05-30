namespace TalleresGuate
{
    partial class TipoServiciosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoServiciosForm));
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtDescripcionServicio = new System.Windows.Forms.TextBox();
            this.lblDescripcionServicio = new System.Windows.Forms.Label();
            this.txtTotalServicio = new System.Windows.Forms.TextBox();
            this.txtRecargoServicio = new System.Windows.Forms.TextBox();
            this.txtCostoBase = new System.Windows.Forms.TextBox();
            this.lblRecargoServicio = new System.Windows.Forms.Label();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.cboxNombreServicio = new System.Windows.Forms.ComboBox();
            this.lblTotalServicio = new System.Windows.Forms.Label();
            this.lblCostoBase = new System.Windows.Forms.Label();
            this.lblNombreTipoServicio = new System.Windows.Forms.Label();
            this.txtCodigoTipoServicio = new System.Windows.Forms.TextBox();
            this.lblCodigoTipoServicio = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkSeleccionar = new System.Windows.Forms.CheckBox();
            this.btnExportar = new FontAwesome.Sharp.IconButton();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.dgvTipoServicios = new System.Windows.Forms.DataGridView();
            this.txtNombreTipoServicio = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 10F);
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 20;
            this.btnCerrar.Location = new System.Drawing.Point(875, 479);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(104, 29);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(68, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tipos de servicios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(912, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 69);
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
            this.btnEliminar.Location = new System.Drawing.Point(790, 300);
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
            this.btnEditar.Location = new System.Drawing.Point(790, 224);
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
            this.btnGuardar.Location = new System.Drawing.Point(790, 155);
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
            this.btnCancelar.Location = new System.Drawing.Point(790, 87);
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
            this.btnNuevo.Location = new System.Drawing.Point(790, 29);
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
            this.lblEstado.Location = new System.Drawing.Point(405, 220);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 16);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.Click += new System.EventHandler(this.label10_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.txtDescripcionServicio);
            this.tabPage2.Controls.Add(this.lblDescripcionServicio);
            this.tabPage2.Controls.Add(this.txtTotalServicio);
            this.tabPage2.Controls.Add(this.txtRecargoServicio);
            this.tabPage2.Controls.Add(this.txtCostoBase);
            this.tabPage2.Controls.Add(this.lblRecargoServicio);
            this.tabPage2.Controls.Add(this.btnEliminar);
            this.tabPage2.Controls.Add(this.btnEditar);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Controls.Add(this.lblEstado);
            this.tabPage2.Controls.Add(this.rdbInactivo);
            this.tabPage2.Controls.Add(this.rdbActivo);
            this.tabPage2.Controls.Add(this.cboxNombreServicio);
            this.tabPage2.Controls.Add(this.lblTotalServicio);
            this.tabPage2.Controls.Add(this.lblCostoBase);
            this.tabPage2.Controls.Add(this.lblNombreTipoServicio);
            this.tabPage2.Controls.Add(this.txtCodigoTipoServicio);
            this.tabPage2.Controls.Add(this.lblCodigoTipoServicio);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(905, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gestiona";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txtDescripcionServicio
            // 
            this.txtDescripcionServicio.Location = new System.Drawing.Point(567, 130);
            this.txtDescripcionServicio.Name = "txtDescripcionServicio";
            this.txtDescripcionServicio.Size = new System.Drawing.Size(203, 23);
            this.txtDescripcionServicio.TabIndex = 26;
            // 
            // lblDescripcionServicio
            // 
            this.lblDescripcionServicio.AutoSize = true;
            this.lblDescripcionServicio.Location = new System.Drawing.Point(405, 137);
            this.lblDescripcionServicio.Name = "lblDescripcionServicio";
            this.lblDescripcionServicio.Size = new System.Drawing.Size(156, 16);
            this.lblDescripcionServicio.TabIndex = 25;
            this.lblDescripcionServicio.Text = "Descricion Del Servicio:";
            this.lblDescripcionServicio.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTotalServicio
            // 
            this.txtTotalServicio.Enabled = false;
            this.txtTotalServicio.Location = new System.Drawing.Point(567, 35);
            this.txtTotalServicio.Name = "txtTotalServicio";
            this.txtTotalServicio.ReadOnly = true;
            this.txtTotalServicio.Size = new System.Drawing.Size(203, 23);
            this.txtTotalServicio.TabIndex = 24;
            // 
            // txtRecargoServicio
            // 
            this.txtRecargoServicio.Enabled = false;
            this.txtRecargoServicio.Location = new System.Drawing.Point(184, 297);
            this.txtRecargoServicio.Name = "txtRecargoServicio";
            this.txtRecargoServicio.ReadOnly = true;
            this.txtRecargoServicio.Size = new System.Drawing.Size(181, 23);
            this.txtRecargoServicio.TabIndex = 23;
            // 
            // txtCostoBase
            // 
            this.txtCostoBase.Enabled = false;
            this.txtCostoBase.Location = new System.Drawing.Point(184, 217);
            this.txtCostoBase.Name = "txtCostoBase";
            this.txtCostoBase.ReadOnly = true;
            this.txtCostoBase.Size = new System.Drawing.Size(181, 23);
            this.txtCostoBase.TabIndex = 22;
            this.txtCostoBase.TextChanged += new System.EventHandler(this.txtCostoBase_TextChanged);
            // 
            // lblRecargoServicio
            // 
            this.lblRecargoServicio.AutoSize = true;
            this.lblRecargoServicio.Location = new System.Drawing.Point(24, 304);
            this.lblRecargoServicio.Name = "lblRecargoServicio";
            this.lblRecargoServicio.Size = new System.Drawing.Size(145, 16);
            this.lblRecargoServicio.TabIndex = 19;
            this.lblRecargoServicio.Text = "Recargo Por Servicio:";
            // 
            // rdbInactivo
            // 
            this.rdbInactivo.AutoSize = true;
            this.rdbInactivo.Location = new System.Drawing.Point(697, 228);
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
            this.rdbActivo.Location = new System.Drawing.Point(567, 222);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(63, 20);
            this.rdbActivo.TabIndex = 15;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = true;
            // 
            // cboxNombreServicio
            // 
            this.cboxNombreServicio.FormattingEnabled = true;
            this.cboxNombreServicio.Items.AddRange(new object[] {
            "Mecánica ",
            "Electricidad ",
            "Enderezado ",
            "Balanceo",
            "Diagnostico"});
            this.cboxNombreServicio.Location = new System.Drawing.Point(184, 130);
            this.cboxNombreServicio.Name = "cboxNombreServicio";
            this.cboxNombreServicio.Size = new System.Drawing.Size(181, 24);
            this.cboxNombreServicio.TabIndex = 12;
            this.cboxNombreServicio.SelectedIndexChanged += new System.EventHandler(this.cboxNombreServicio_SelectedIndexChanged);
            // 
            // lblTotalServicio
            // 
            this.lblTotalServicio.AutoSize = true;
            this.lblTotalServicio.Location = new System.Drawing.Point(405, 46);
            this.lblTotalServicio.Name = "lblTotalServicio";
            this.lblTotalServicio.Size = new System.Drawing.Size(95, 16);
            this.lblTotalServicio.TabIndex = 9;
            this.lblTotalServicio.Text = "Total Servicio:";
            // 
            // lblCostoBase
            // 
            this.lblCostoBase.AutoSize = true;
            this.lblCostoBase.Location = new System.Drawing.Point(15, 224);
            this.lblCostoBase.Name = "lblCostoBase";
            this.lblCostoBase.Size = new System.Drawing.Size(84, 16);
            this.lblCostoBase.TabIndex = 5;
            this.lblCostoBase.Text = "Costo Base:";
            // 
            // lblNombreTipoServicio
            // 
            this.lblNombreTipoServicio.AutoSize = true;
            this.lblNombreTipoServicio.Location = new System.Drawing.Point(15, 137);
            this.lblNombreTipoServicio.Name = "lblNombreTipoServicio";
            this.lblNombreTipoServicio.Size = new System.Drawing.Size(139, 16);
            this.lblNombreTipoServicio.TabIndex = 3;
            this.lblNombreTipoServicio.Text = "Nombre Del Servicio:";
            // 
            // txtCodigoTipoServicio
            // 
            this.txtCodigoTipoServicio.Enabled = false;
            this.txtCodigoTipoServicio.Location = new System.Drawing.Point(184, 39);
            this.txtCodigoTipoServicio.Name = "txtCodigoTipoServicio";
            this.txtCodigoTipoServicio.ReadOnly = true;
            this.txtCodigoTipoServicio.Size = new System.Drawing.Size(181, 23);
            this.txtCodigoTipoServicio.TabIndex = 2;
            this.txtCodigoTipoServicio.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblCodigoTipoServicio
            // 
            this.lblCodigoTipoServicio.AutoSize = true;
            this.lblCodigoTipoServicio.Location = new System.Drawing.Point(15, 42);
            this.lblCodigoTipoServicio.Name = "lblCodigoTipoServicio";
            this.lblCodigoTipoServicio.Size = new System.Drawing.Size(163, 16);
            this.lblCodigoTipoServicio.TabIndex = 0;
            this.lblCodigoTipoServicio.Text = "Codigo Tipo De Servicio:";
            this.lblCodigoTipoServicio.Click += new System.EventHandler(this.label3_Click);
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
            this.tabPage1.Controls.Add(this.dgvTipoServicios);
            this.tabPage1.Controls.Add(this.txtNombreTipoServicio);
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
            this.btnExportar.Size = new System.Drawing.Size(100, 29);
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
            this.btnImprimir.Location = new System.Drawing.Point(656, 22);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(86, 29);
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
            this.btnLimpiar.Location = new System.Drawing.Point(550, 19);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(84, 29);
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
            this.btnBuscar.Location = new System.Drawing.Point(436, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 29);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvTipoServicios
            // 
            this.dgvTipoServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoServicios.Location = new System.Drawing.Point(44, 79);
            this.dgvTipoServicios.Name = "dgvTipoServicios";
            this.dgvTipoServicios.Size = new System.Drawing.Size(820, 239);
            this.dgvTipoServicios.TabIndex = 2;
            this.dgvTipoServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoServicios_CellClick);
            // 
            // txtNombreTipoServicio
            // 
            this.txtNombreTipoServicio.Location = new System.Drawing.Point(101, 22);
            this.txtNombreTipoServicio.Name = "txtNombreTipoServicio";
            this.txtNombreTipoServicio.Size = new System.Drawing.Size(314, 23);
            this.txtNombreTipoServicio.TabIndex = 1;
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
            // 
            // TipoServiciosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 533);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "TipoServiciosForm";
            this.Text = "TipoServiciosForm";
            this.Load += new System.EventHandler(this.TipoServiciosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.ComboBox cboxNombreServicio;
        private System.Windows.Forms.Label lblTotalServicio;
        private System.Windows.Forms.Label lblCostoBase;
        private System.Windows.Forms.Label lblNombreTipoServicio;
        private System.Windows.Forms.TextBox txtCodigoTipoServicio;
        private System.Windows.Forms.Label lblCodigoTipoServicio;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkSeleccionar;
        private FontAwesome.Sharp.IconButton btnExportar;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.DataGridView dgvTipoServicios;
        private System.Windows.Forms.TextBox txtNombreTipoServicio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtRecargoServicio;
        private System.Windows.Forms.TextBox txtCostoBase;
        private System.Windows.Forms.Label lblRecargoServicio;
        private System.Windows.Forms.TextBox txtTotalServicio;
        private System.Windows.Forms.TextBox txtDescripcionServicio;
        private System.Windows.Forms.Label lblDescripcionServicio;
    }
}