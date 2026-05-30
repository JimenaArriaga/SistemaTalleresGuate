namespace TalleresGuate
{
    partial class DetalleFacturasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleFacturasForm));
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.lblDetallesDeFactura = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtTotalDetalle = new System.Windows.Forms.TextBox();
            this.cboxCodigoTipoServicio = new System.Windows.Forms.ComboBox();
            this.cboxCodigoFactura = new System.Windows.Forms.ComboBox();
            this.cboxCodigoInventario = new System.Windows.Forms.ComboBox();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.lblTotalDetalle = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblCodigoTipoServicio = new System.Windows.Forms.Label();
            this.lblCodigoInventario = new System.Windows.Forms.Label();
            this.lblCodigoFactura = new System.Windows.Forms.Label();
            this.txtCodigoDetalleFactura = new System.Windows.Forms.TextBox();
            this.lblCodigoDetalleFactura = new System.Windows.Forms.Label();
            this.dgvDetalleFacturas = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkSeleccionar = new System.Windows.Forms.CheckBox();
            this.btnExportar = new FontAwesome.Sharp.IconButton();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtNombreDetalleFactura = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFacturas)).BeginInit();
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
            this.btnCerrar.Location = new System.Drawing.Point(896, 479);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(87, 29);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblDetallesDeFactura
            // 
            this.lblDetallesDeFactura.AutoSize = true;
            this.lblDetallesDeFactura.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblDetallesDeFactura.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDetallesDeFactura.Location = new System.Drawing.Point(68, 12);
            this.lblDetallesDeFactura.Name = "lblDetallesDeFactura";
            this.lblDetallesDeFactura.Size = new System.Drawing.Size(284, 32);
            this.lblDetallesDeFactura.TabIndex = 10;
            this.lblDetallesDeFactura.Text = "Detalles De Facturas";
            this.lblDetallesDeFactura.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(915, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 20;
            this.btnEliminar.Location = new System.Drawing.Point(790, 295);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 29);
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
            this.btnEditar.Size = new System.Drawing.Size(95, 29);
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
            this.btnGuardar.Size = new System.Drawing.Size(95, 29);
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
            this.btnCancelar.Size = new System.Drawing.Size(95, 29);
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
            this.btnNuevo.Size = new System.Drawing.Size(95, 29);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(426, 293);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(55, 16);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Estado:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.nudCantidad);
            this.tabPage2.Controls.Add(this.txtPrecioUnitario);
            this.tabPage2.Controls.Add(this.txtSubtotal);
            this.tabPage2.Controls.Add(this.txtImpuesto);
            this.tabPage2.Controls.Add(this.txtTotalDetalle);
            this.tabPage2.Controls.Add(this.cboxCodigoTipoServicio);
            this.tabPage2.Controls.Add(this.cboxCodigoFactura);
            this.tabPage2.Controls.Add(this.cboxCodigoInventario);
            this.tabPage2.Controls.Add(this.lblImpuesto);
            this.tabPage2.Controls.Add(this.lblCantidad);
            this.tabPage2.Controls.Add(this.btnEliminar);
            this.tabPage2.Controls.Add(this.btnEditar);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Controls.Add(this.lblEstado);
            this.tabPage2.Controls.Add(this.rdbInactivo);
            this.tabPage2.Controls.Add(this.rdbActivo);
            this.tabPage2.Controls.Add(this.lblTotalDetalle);
            this.tabPage2.Controls.Add(this.lblSubtotal);
            this.tabPage2.Controls.Add(this.lblPrecioUnitario);
            this.tabPage2.Controls.Add(this.lblCodigoTipoServicio);
            this.tabPage2.Controls.Add(this.lblCodigoInventario);
            this.tabPage2.Controls.Add(this.lblCodigoFactura);
            this.tabPage2.Controls.Add(this.txtCodigoDetalleFactura);
            this.tabPage2.Controls.Add(this.lblCodigoDetalleFactura);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(905, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gestiona";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(226, 291);
            this.nudCantidad.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(167, 23);
            this.nudCantidad.TabIndex = 12;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Enabled = false;
            this.txtPrecioUnitario.Location = new System.Drawing.Point(527, 39);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(187, 23);
            this.txtPrecioUnitario.TabIndex = 29;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(527, 103);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(187, 23);
            this.txtSubtotal.TabIndex = 28;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Enabled = false;
            this.txtImpuesto.Location = new System.Drawing.Point(527, 164);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.ReadOnly = true;
            this.txtImpuesto.Size = new System.Drawing.Size(187, 23);
            this.txtImpuesto.TabIndex = 27;
            this.txtImpuesto.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtTotalDetalle
            // 
            this.txtTotalDetalle.Enabled = false;
            this.txtTotalDetalle.Location = new System.Drawing.Point(527, 227);
            this.txtTotalDetalle.Name = "txtTotalDetalle";
            this.txtTotalDetalle.ReadOnly = true;
            this.txtTotalDetalle.Size = new System.Drawing.Size(187, 23);
            this.txtTotalDetalle.TabIndex = 26;
            // 
            // cboxCodigoTipoServicio
            // 
            this.cboxCodigoTipoServicio.FormattingEnabled = true;
            this.cboxCodigoTipoServicio.Location = new System.Drawing.Point(226, 224);
            this.cboxCodigoTipoServicio.Name = "cboxCodigoTipoServicio";
            this.cboxCodigoTipoServicio.Size = new System.Drawing.Size(167, 24);
            this.cboxCodigoTipoServicio.TabIndex = 25;
            this.cboxCodigoTipoServicio.SelectedIndexChanged += new System.EventHandler(this.cboxCodigoTipoServicio_SelectedIndexChanged);
            // 
            // cboxCodigoFactura
            // 
            this.cboxCodigoFactura.FormattingEnabled = true;
            this.cboxCodigoFactura.Location = new System.Drawing.Point(226, 103);
            this.cboxCodigoFactura.Name = "cboxCodigoFactura";
            this.cboxCodigoFactura.Size = new System.Drawing.Size(167, 24);
            this.cboxCodigoFactura.TabIndex = 24;
            this.cboxCodigoFactura.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // cboxCodigoInventario
            // 
            this.cboxCodigoInventario.FormattingEnabled = true;
            this.cboxCodigoInventario.Location = new System.Drawing.Point(226, 163);
            this.cboxCodigoInventario.Name = "cboxCodigoInventario";
            this.cboxCodigoInventario.Size = new System.Drawing.Size(167, 24);
            this.cboxCodigoInventario.TabIndex = 23;
            this.cboxCodigoInventario.SelectedIndexChanged += new System.EventHandler(this.cboxCodigoInventario_SelectedIndexChanged);
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Location = new System.Drawing.Point(426, 171);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(68, 16);
            this.lblImpuesto.TabIndex = 21;
            this.lblImpuesto.Text = "Impuesto:";
            this.lblImpuesto.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(36, 295);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(68, 16);
            this.lblCantidad.TabIndex = 19;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // rdbInactivo
            // 
            this.rdbInactivo.AutoSize = true;
            this.rdbInactivo.Location = new System.Drawing.Point(641, 289);
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
            this.rdbActivo.Location = new System.Drawing.Point(527, 289);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(63, 20);
            this.rdbActivo.TabIndex = 15;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = true;
            this.rdbActivo.CheckedChanged += new System.EventHandler(this.rdbActivo_CheckedChanged);
            // 
            // lblTotalDetalle
            // 
            this.lblTotalDetalle.AutoSize = true;
            this.lblTotalDetalle.Location = new System.Drawing.Point(420, 234);
            this.lblTotalDetalle.Name = "lblTotalDetalle";
            this.lblTotalDetalle.Size = new System.Drawing.Size(89, 16);
            this.lblTotalDetalle.TabIndex = 13;
            this.lblTotalDetalle.Text = "Total Detalle:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(426, 111);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(63, 16);
            this.lblSubtotal.TabIndex = 11;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(420, 45);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(103, 16);
            this.lblPrecioUnitario.TabIndex = 9;
            this.lblPrecioUnitario.Text = "Precio Unitario:";
            // 
            // lblCodigoTipoServicio
            // 
            this.lblCodigoTipoServicio.AutoSize = true;
            this.lblCodigoTipoServicio.Location = new System.Drawing.Point(32, 230);
            this.lblCodigoTipoServicio.Name = "lblCodigoTipoServicio";
            this.lblCodigoTipoServicio.Size = new System.Drawing.Size(188, 16);
            this.lblCodigoTipoServicio.TabIndex = 7;
            this.lblCodigoTipoServicio.Text = "Codigo Del Tipo De Servicio:";
            // 
            // lblCodigoInventario
            // 
            this.lblCodigoInventario.AutoSize = true;
            this.lblCodigoInventario.Location = new System.Drawing.Point(33, 168);
            this.lblCodigoInventario.Name = "lblCodigoInventario";
            this.lblCodigoInventario.Size = new System.Drawing.Size(144, 16);
            this.lblCodigoInventario.TabIndex = 5;
            this.lblCodigoInventario.Text = "Codigo De Inventario:";
            // 
            // lblCodigoFactura
            // 
            this.lblCodigoFactura.AutoSize = true;
            this.lblCodigoFactura.Location = new System.Drawing.Point(32, 111);
            this.lblCodigoFactura.Name = "lblCodigoFactura";
            this.lblCodigoFactura.Size = new System.Drawing.Size(131, 16);
            this.lblCodigoFactura.TabIndex = 3;
            this.lblCodigoFactura.Text = "Codigo De Factura:";
            // 
            // txtCodigoDetalleFactura
            // 
            this.txtCodigoDetalleFactura.Enabled = false;
            this.txtCodigoDetalleFactura.Location = new System.Drawing.Point(226, 45);
            this.txtCodigoDetalleFactura.Name = "txtCodigoDetalleFactura";
            this.txtCodigoDetalleFactura.ReadOnly = true;
            this.txtCodigoDetalleFactura.Size = new System.Drawing.Size(167, 23);
            this.txtCodigoDetalleFactura.TabIndex = 2;
            // 
            // lblCodigoDetalleFactura
            // 
            this.lblCodigoDetalleFactura.AutoSize = true;
            this.lblCodigoDetalleFactura.Location = new System.Drawing.Point(33, 48);
            this.lblCodigoDetalleFactura.Name = "lblCodigoDetalleFactura";
            this.lblCodigoDetalleFactura.Size = new System.Drawing.Size(129, 16);
            this.lblCodigoDetalleFactura.TabIndex = 0;
            this.lblCodigoDetalleFactura.Text = "Codigo Del Detalle:";
            this.lblCodigoDetalleFactura.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvDetalleFacturas
            // 
            this.dgvDetalleFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFacturas.Location = new System.Drawing.Point(44, 79);
            this.dgvDetalleFacturas.Name = "dgvDetalleFacturas";
            this.dgvDetalleFacturas.Size = new System.Drawing.Size(820, 239);
            this.dgvDetalleFacturas.TabIndex = 2;
            this.dgvDetalleFacturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleFacturas_CellClick);
            this.dgvDetalleFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.chkSeleccionar);
            this.tabPage1.Controls.Add(this.btnExportar);
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.dgvDetalleFacturas);
            this.tabPage1.Controls.Add(this.txtNombreDetalleFactura);
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
            this.chkSeleccionar.Font = new System.Drawing.Font("Arial", 10F);
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
            this.btnExportar.Size = new System.Drawing.Size(100, 34);
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
            this.btnImprimir.Location = new System.Drawing.Point(689, 19);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(95, 29);
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
            this.btnLimpiar.Location = new System.Drawing.Point(571, 19);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 29);
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
            this.btnBuscar.Location = new System.Drawing.Point(452, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 29);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtNombreDetalleFactura
            // 
            this.txtNombreDetalleFactura.Location = new System.Drawing.Point(118, 22);
            this.txtNombreDetalleFactura.Name = "txtNombreDetalleFactura";
            this.txtNombreDetalleFactura.Size = new System.Drawing.Size(312, 23);
            this.txtNombreDetalleFactura.TabIndex = 1;
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
            // DetalleFacturasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1052, 533);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblDetallesDeFactura);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "DetalleFacturasForm";
            this.Text = "DetalleFacturasForm";
            this.Load += new System.EventHandler(this.DetalleFacturasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFacturas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label lblDetallesDeFactura;
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
        private System.Windows.Forms.Label lblTotalDetalle;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblCodigoTipoServicio;
        private System.Windows.Forms.Label lblCodigoInventario;
        private System.Windows.Forms.Label lblCodigoFactura;
        private System.Windows.Forms.TextBox txtCodigoDetalleFactura;
        private System.Windows.Forms.Label lblCodigoDetalleFactura;
        private System.Windows.Forms.DataGridView dgvDetalleFacturas;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkSeleccionar;
        private FontAwesome.Sharp.IconButton btnExportar;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtNombreDetalleFactura;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cboxCodigoTipoServicio;
        private System.Windows.Forms.ComboBox cboxCodigoFactura;
        private System.Windows.Forms.ComboBox cboxCodigoInventario;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtTotalDetalle;
    }
}