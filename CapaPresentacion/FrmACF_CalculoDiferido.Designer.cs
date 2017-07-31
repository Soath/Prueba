namespace CapaPresentacion
{
    partial class FrmACF_CalculoDiferido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmACF_CalculoDiferido));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPDFcodigo = new System.Windows.Forms.TextBox();
            this.txtPDFreponsable = new System.Windows.Forms.TextBox();
            this.dtpPDFfecha = new System.Windows.Forms.DateTimePicker();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripRefrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripPrimero = new System.Windows.Forms.ToolStripButton();
            this.toolStripAnterior = new System.Windows.Forms.ToolStripButton();
            this.toolStripSiguiente = new System.Windows.Forms.ToolStripButton();
            this.toolStripUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsProcesar = new System.Windows.Forms.ToolStripButton();
            this.txtPDFestado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPDFperiodo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(211, 111);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(162, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Importar desde Excel";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(211, 154);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(223, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Generar desde Base de Datos";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Calculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Periodo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 295);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Calculo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 340);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Responsable";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 385);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Estado";
            // 
            // txtPDFcodigo
            // 
            this.txtPDFcodigo.Location = new System.Drawing.Point(376, 212);
            this.txtPDFcodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPDFcodigo.Name = "txtPDFcodigo";
            this.txtPDFcodigo.Size = new System.Drawing.Size(144, 22);
            this.txtPDFcodigo.TabIndex = 8;
            // 
            // txtPDFreponsable
            // 
            this.txtPDFreponsable.Location = new System.Drawing.Point(376, 336);
            this.txtPDFreponsable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPDFreponsable.Name = "txtPDFreponsable";
            this.txtPDFreponsable.Size = new System.Drawing.Size(364, 22);
            this.txtPDFreponsable.TabIndex = 11;
            // 
            // dtpPDFfecha
            // 
            this.dtpPDFfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPDFfecha.Location = new System.Drawing.Point(376, 288);
            this.dtpPDFfecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpPDFfecha.Name = "dtpPDFfecha";
            this.dtpPDFfecha.Size = new System.Drawing.Size(128, 22);
            this.dtpPDFfecha.TabIndex = 15;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(15, 406);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(924, 370);
            this.tabControl1.TabIndex = 209;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabPage1.Controls.Add(this.dataListado);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.chkEliminar);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(916, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.BackgroundColor = System.Drawing.Color.White;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListado.Location = new System.Drawing.Point(13, 105);
            this.dataListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowTemplate.Height = 24;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(813, 204);
            this.dataListado.TabIndex = 9;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 50;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(20, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(500, 79);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 17);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "lblTotal";
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(13, 79);
            this.chkEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(80, 21);
            this.chkEliminar.TabIndex = 5;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(107, 34);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(327, 22);
            this.txtBuscar.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRefrescar,
            this.toolStripAgregar,
            this.toolStripEditar,
            this.toolStripEliminar,
            this.toolStripImprimir,
            this.toolStripGuardar,
            this.toolStripCancelar,
            this.toolStripPrimero,
            this.toolStripAnterior,
            this.toolStripSiguiente,
            this.toolStripUltimo,
            this.toolStripButton1,
            this.tsProcesar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(952, 76);
            this.toolStrip1.TabIndex = 210;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripRefrescar
            // 
            this.toolStripRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRefrescar.Image")));
            this.toolStripRefrescar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRefrescar.Name = "toolStripRefrescar";
            this.toolStripRefrescar.Size = new System.Drawing.Size(79, 73);
            this.toolStripRefrescar.Text = "Actualizar";
            this.toolStripRefrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripAgregar
            // 
            this.toolStripAgregar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAgregar.Image")));
            this.toolStripAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAgregar.Name = "toolStripAgregar";
            this.toolStripAgregar.Size = new System.Drawing.Size(67, 73);
            this.toolStripAgregar.Text = "Agregar";
            this.toolStripAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripEditar
            // 
            this.toolStripEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEditar.Image")));
            this.toolStripEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEditar.Name = "toolStripEditar";
            this.toolStripEditar.Size = new System.Drawing.Size(52, 73);
            this.toolStripEditar.Text = "Editar";
            this.toolStripEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripEliminar
            // 
            this.toolStripEliminar.Enabled = false;
            this.toolStripEliminar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEliminar.Image")));
            this.toolStripEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEliminar.Name = "toolStripEliminar";
            this.toolStripEliminar.Size = new System.Drawing.Size(56, 73);
            this.toolStripEliminar.Text = "Anular";
            this.toolStripEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripImprimir
            // 
            this.toolStripImprimir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripImprimir.Image")));
            this.toolStripImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripImprimir.Name = "toolStripImprimir";
            this.toolStripImprimir.Size = new System.Drawing.Size(70, 73);
            this.toolStripImprimir.Text = "Imprimir";
            this.toolStripImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripGuardar
            // 
            this.toolStripGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGuardar.Image")));
            this.toolStripGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGuardar.Name = "toolStripGuardar";
            this.toolStripGuardar.Size = new System.Drawing.Size(137, 73);
            this.toolStripGuardar.Text = "Guardar y Procesar";
            this.toolStripGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripGuardar.Visible = false;
            // 
            // toolStripCancelar
            // 
            this.toolStripCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCancelar.Image")));
            this.toolStripCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCancelar.Name = "toolStripCancelar";
            this.toolStripCancelar.Size = new System.Drawing.Size(70, 73);
            this.toolStripCancelar.Text = "Cancelar";
            this.toolStripCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripCancelar.Visible = false;
            // 
            // toolStripPrimero
            // 
            this.toolStripPrimero.AutoSize = false;
            this.toolStripPrimero.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPrimero.Image")));
            this.toolStripPrimero.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripPrimero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPrimero.Name = "toolStripPrimero";
            this.toolStripPrimero.Size = new System.Drawing.Size(60, 79);
            this.toolStripPrimero.Text = "Primero";
            this.toolStripPrimero.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripPrimero.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripPrimero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripAnterior
            // 
            this.toolStripAnterior.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripAnterior.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAnterior.Image")));
            this.toolStripAnterior.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAnterior.Name = "toolStripAnterior";
            this.toolStripAnterior.Size = new System.Drawing.Size(67, 73);
            this.toolStripAnterior.Text = "Anterior";
            this.toolStripAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSiguiente
            // 
            this.toolStripSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSiguiente.Image")));
            this.toolStripSiguiente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripSiguiente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSiguiente.Name = "toolStripSiguiente";
            this.toolStripSiguiente.Size = new System.Drawing.Size(75, 73);
            this.toolStripSiguiente.Text = "Siguiente";
            this.toolStripSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripUltimo
            // 
            this.toolStripUltimo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUltimo.Image")));
            this.toolStripUltimo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripUltimo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUltimo.Name = "toolStripUltimo";
            this.toolStripUltimo.Size = new System.Drawing.Size(58, 73);
            this.toolStripUltimo.Text = "Ultimo";
            this.toolStripUltimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButton1.Size = new System.Drawing.Size(71, 73);
            this.toolStripButton1.Text = "Importar";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsProcesar
            // 
            this.tsProcesar.Image = ((System.Drawing.Image)(resources.GetObject("tsProcesar.Image")));
            this.tsProcesar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsProcesar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsProcesar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsProcesar.Name = "tsProcesar";
            this.tsProcesar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsProcesar.Size = new System.Drawing.Size(69, 40);
            this.tsProcesar.Text = "Procesar";
            this.tsProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsProcesar.Visible = false;
            this.tsProcesar.Click += new System.EventHandler(this.tsProcesar_Click);
            // 
            // txtPDFestado
            // 
            this.txtPDFestado.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2"});
            this.txtPDFestado.FormattingEnabled = true;
            this.txtPDFestado.Items.AddRange(new object[] {
            "1",
            "2"});
            this.txtPDFestado.Location = new System.Drawing.Point(376, 382);
            this.txtPDFestado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPDFestado.Name = "txtPDFestado";
            this.txtPDFestado.Size = new System.Drawing.Size(51, 24);
            this.txtPDFestado.TabIndex = 211;
            this.txtPDFestado.Text = "1";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(452, 378);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 35);
            this.label6.TabIndex = 212;
            this.label6.Text = "1 = Baja         2 = Anulado";
            // 
            // txtPDFperiodo
            // 
            this.txtPDFperiodo.CustomFormat = "MM/yyyy";
            this.txtPDFperiodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtPDFperiodo.Location = new System.Drawing.Point(376, 247);
            this.txtPDFperiodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPDFperiodo.Name = "txtPDFperiodo";
            this.txtPDFperiodo.ShowUpDown = true;
            this.txtPDFperiodo.Size = new System.Drawing.Size(128, 22);
            this.txtPDFperiodo.TabIndex = 213;
            // 
            // FrmACF_CalculoDiferido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 789);
            this.Controls.Add(this.txtPDFperiodo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPDFestado);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dtpPDFfecha);
            this.Controls.Add(this.txtPDFreponsable);
            this.Controls.Add(this.txtPDFcodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmACF_CalculoDiferido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmACF_CalculoDiferido";
            this.Load += new System.EventHandler(this.FrmACF_CalculoDiferido_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPDFcodigo;
        private System.Windows.Forms.TextBox txtPDFreponsable;
        private System.Windows.Forms.DateTimePicker dtpPDFfecha;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripRefrescar;
        private System.Windows.Forms.ToolStripButton toolStripAgregar;
        private System.Windows.Forms.ToolStripButton toolStripEditar;
        private System.Windows.Forms.ToolStripButton toolStripEliminar;
        private System.Windows.Forms.ToolStripButton toolStripImprimir;
        private System.Windows.Forms.ToolStripButton toolStripGuardar;
        private System.Windows.Forms.ToolStripButton toolStripCancelar;
        private System.Windows.Forms.ToolStripButton toolStripPrimero;
        private System.Windows.Forms.ToolStripButton toolStripAnterior;
        private System.Windows.Forms.ToolStripButton toolStripSiguiente;
        private System.Windows.Forms.ToolStripButton toolStripUltimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtPDFestado;
        private System.Windows.Forms.ToolStripButton tsProcesar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DateTimePicker txtPDFperiodo;
    }
}