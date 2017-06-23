namespace CapaPresentacion
{
    partial class FrmMovimiento_Transferencia_Activo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovimiento_Transferencia_Activo));
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
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.txtORGds_crp = new System.Windows.Forms.TextBox();
            this.txtORGds_zona = new System.Windows.Forms.TextBox();
            this.txtORGds_persona = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtORGcrp = new MultiColumnComboBoxDemo.MultiColumnComboBox();
            this.cboPERNR3 = new MultiColumnComboBoxDemo.MultiColumnComboBox();
            this.txtORGds_usuario = new System.Windows.Forms.TextBox();
            this.cboAMB1 = new MultiColumnComboBoxDemo.MultiColumnComboBox();
            this.txtORGds_ambiente = new System.Windows.Forms.TextBox();
            this.cboZONA1 = new MultiColumnComboBoxDemo.MultiColumnComboBox();
            this.cboPERNR1 = new MultiColumnComboBoxDemo.MultiColumnComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMVPds_movimiento1 = new System.Windows.Forms.TextBox();
            this.txtMVPobservaciones = new System.Windows.Forms.TextBox();
            this.dtpMVPfecha_movimiento = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMVPid_proceso = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDSTcrp = new MultiColumnComboBoxDemo.MultiColumnComboBox();
            this.txtDSTds_crp = new System.Windows.Forms.TextBox();
            this.cboPERNR4 = new MultiColumnComboBoxDemo.MultiColumnComboBox();
            this.txtDSTds_usuario = new System.Windows.Forms.TextBox();
            this.cboAMB2 = new MultiColumnComboBoxDemo.MultiColumnComboBox();
            this.txtDSTds_ambiente = new System.Windows.Forms.TextBox();
            this.cboZONA2 = new MultiColumnComboBoxDemo.MultiColumnComboBox();
            this.txtDSTds_zona = new System.Windows.Forms.TextBox();
            this.cboPERNR2 = new MultiColumnComboBoxDemo.MultiColumnComboBox();
            this.txtDSTds_persona = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboMVPtipo1 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.datalistado1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMVPds_movimiento = new MultiColumnComboBoxDemo.MultiColumnComboBox();
            this.cboMVPtipo = new MultiColumnComboBoxDemo.MultiColumnComboBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado1)).BeginInit();
            this.SuspendLayout();
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
            this.toolStripUltimo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 62);
            this.toolStrip1.TabIndex = 206;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripRefrescar
            // 
            this.toolStripRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRefrescar.Image")));
            this.toolStripRefrescar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRefrescar.Name = "toolStripRefrescar";
            this.toolStripRefrescar.Size = new System.Drawing.Size(63, 59);
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
            this.toolStripAgregar.Size = new System.Drawing.Size(53, 59);
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
            this.toolStripEditar.Size = new System.Drawing.Size(41, 59);
            this.toolStripEditar.Text = "Editar";
            this.toolStripEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripEliminar
            // 
            this.toolStripEliminar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEliminar.Image")));
            this.toolStripEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEliminar.Name = "toolStripEliminar";
            this.toolStripEliminar.Size = new System.Drawing.Size(46, 59);
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
            this.toolStripImprimir.Size = new System.Drawing.Size(57, 59);
            this.toolStripImprimir.Text = "Imprimir";
            this.toolStripImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripImprimir.Click += new System.EventHandler(this.toolStripImprimir_Click);
            // 
            // toolStripGuardar
            // 
            this.toolStripGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGuardar.Image")));
            this.toolStripGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGuardar.Name = "toolStripGuardar";
            this.toolStripGuardar.Size = new System.Drawing.Size(53, 59);
            this.toolStripGuardar.Text = "Guardar";
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
            this.toolStripCancelar.Size = new System.Drawing.Size(57, 59);
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
            this.toolStripAnterior.Size = new System.Drawing.Size(54, 59);
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
            this.toolStripSiguiente.Size = new System.Drawing.Size(60, 59);
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
            this.toolStripUltimo.Size = new System.Drawing.Size(47, 59);
            this.toolStripUltimo.Text = "Ultimo";
            this.toolStripUltimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // txtORGds_crp
            // 
            this.txtORGds_crp.Location = new System.Drawing.Point(120, 58);
            this.txtORGds_crp.Margin = new System.Windows.Forms.Padding(2);
            this.txtORGds_crp.Name = "txtORGds_crp";
            this.txtORGds_crp.ReadOnly = true;
            this.txtORGds_crp.Size = new System.Drawing.Size(254, 20);
            this.txtORGds_crp.TabIndex = 229;
            this.txtORGds_crp.TabStop = false;
            // 
            // txtORGds_zona
            // 
            this.txtORGds_zona.Location = new System.Drawing.Point(120, 37);
            this.txtORGds_zona.Margin = new System.Windows.Forms.Padding(2);
            this.txtORGds_zona.Name = "txtORGds_zona";
            this.txtORGds_zona.ReadOnly = true;
            this.txtORGds_zona.Size = new System.Drawing.Size(254, 20);
            this.txtORGds_zona.TabIndex = 228;
            this.txtORGds_zona.TabStop = false;
            // 
            // txtORGds_persona
            // 
            this.txtORGds_persona.Location = new System.Drawing.Point(190, 16);
            this.txtORGds_persona.Margin = new System.Windows.Forms.Padding(2);
            this.txtORGds_persona.Name = "txtORGds_persona";
            this.txtORGds_persona.ReadOnly = true;
            this.txtORGds_persona.Size = new System.Drawing.Size(184, 20);
            this.txtORGds_persona.TabIndex = 227;
            this.txtORGds_persona.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 226;
            this.label2.Text = "Usuario en Uso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 225;
            this.label3.Text = "CRP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 224;
            this.label4.Text = "Zona";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 223;
            this.label5.Text = "Usuario o Cargo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 222;
            this.label6.Text = "Fecha Movimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 221;
            this.label7.Text = "Tipo Movimiento";
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.BackgroundColor = System.Drawing.Color.White;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataListado.Location = new System.Drawing.Point(9, 335);
            this.dataListado.Margin = new System.Windows.Forms.Padding(2);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowTemplate.Height = 24;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(682, 196);
            this.dataListado.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ACFid";
            this.Column1.HeaderText = "Código de Activo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PERNR";
            this.Column2.HeaderText = "Código de Personal";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ACFfincorporacion";
            this.Column3.HeaderText = "Fecha de Incorporación";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ACFdescripcion";
            this.Column4.HeaderText = "Descripcion";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.txtORGcrp);
            this.groupBox1.Controls.Add(this.cboPERNR3);
            this.groupBox1.Controls.Add(this.cboAMB1);
            this.groupBox1.Controls.Add(this.cboZONA1);
            this.groupBox1.Controls.Add(this.cboPERNR1);
            this.groupBox1.Controls.Add(this.txtORGds_usuario);
            this.groupBox1.Controls.Add(this.txtORGds_persona);
            this.groupBox1.Controls.Add(this.txtORGds_ambiente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtORGds_crp);
            this.groupBox1.Controls.Add(this.txtORGds_zona);
            this.groupBox1.Location = new System.Drawing.Point(9, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(386, 136);
            this.groupBox1.TabIndex = 231;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE ORIGEN";
            // 
            // txtORGcrp
            // 
            this.txtORGcrp.AutoComplete = false;
            this.txtORGcrp.AutoDropdown = false;
            this.txtORGcrp.BackColorEven = System.Drawing.Color.White;
            this.txtORGcrp.BackColorOdd = System.Drawing.Color.White;
            this.txtORGcrp.ColumnNames = "";
            this.txtORGcrp.ColumnWidthDefault = 75;
            this.txtORGcrp.ColumnWidths = "";
            this.txtORGcrp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtORGcrp.FormattingEnabled = true;
            this.txtORGcrp.LinkedColumnIndex = 2;
            this.txtORGcrp.LinkedTextBox = this.txtORGds_crp;
            this.txtORGcrp.Location = new System.Drawing.Point(52, 59);
            this.txtORGcrp.Name = "txtORGcrp";
            this.txtORGcrp.Size = new System.Drawing.Size(63, 21);
            this.txtORGcrp.TabIndex = 262;
            // 
            // cboPERNR3
            // 
            this.cboPERNR3.AutoComplete = false;
            this.cboPERNR3.AutoDropdown = false;
            this.cboPERNR3.BackColorEven = System.Drawing.Color.White;
            this.cboPERNR3.BackColorOdd = System.Drawing.Color.White;
            this.cboPERNR3.ColumnNames = "";
            this.cboPERNR3.ColumnWidthDefault = 75;
            this.cboPERNR3.ColumnWidths = "";
            this.cboPERNR3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboPERNR3.FormattingEnabled = true;
            this.cboPERNR3.LinkedColumnIndex = 1;
            this.cboPERNR3.LinkedTextBox = this.txtORGds_usuario;
            this.cboPERNR3.Location = new System.Drawing.Point(100, 80);
            this.cboPERNR3.Name = "cboPERNR3";
            this.cboPERNR3.Size = new System.Drawing.Size(85, 21);
            this.cboPERNR3.TabIndex = 261;
            // 
            // txtORGds_usuario
            // 
            this.txtORGds_usuario.Location = new System.Drawing.Point(190, 80);
            this.txtORGds_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtORGds_usuario.Name = "txtORGds_usuario";
            this.txtORGds_usuario.ReadOnly = true;
            this.txtORGds_usuario.Size = new System.Drawing.Size(184, 20);
            this.txtORGds_usuario.TabIndex = 234;
            this.txtORGds_usuario.TabStop = false;
            // 
            // cboAMB1
            // 
            this.cboAMB1.AutoComplete = false;
            this.cboAMB1.AutoDropdown = false;
            this.cboAMB1.BackColorEven = System.Drawing.Color.White;
            this.cboAMB1.BackColorOdd = System.Drawing.Color.White;
            this.cboAMB1.ColumnNames = "";
            this.cboAMB1.ColumnWidthDefault = 75;
            this.cboAMB1.ColumnWidths = "";
            this.cboAMB1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboAMB1.FormattingEnabled = true;
            this.cboAMB1.LinkedColumnIndex = 2;
            this.cboAMB1.LinkedTextBox = this.txtORGds_ambiente;
            this.cboAMB1.Location = new System.Drawing.Point(75, 102);
            this.cboAMB1.Name = "cboAMB1";
            this.cboAMB1.Size = new System.Drawing.Size(54, 21);
            this.cboAMB1.TabIndex = 260;
            // 
            // txtORGds_ambiente
            // 
            this.txtORGds_ambiente.Location = new System.Drawing.Point(134, 102);
            this.txtORGds_ambiente.Margin = new System.Windows.Forms.Padding(2);
            this.txtORGds_ambiente.Name = "txtORGds_ambiente";
            this.txtORGds_ambiente.ReadOnly = true;
            this.txtORGds_ambiente.Size = new System.Drawing.Size(240, 20);
            this.txtORGds_ambiente.TabIndex = 233;
            this.txtORGds_ambiente.TabStop = false;
            // 
            // cboZONA1
            // 
            this.cboZONA1.AutoComplete = false;
            this.cboZONA1.AutoDropdown = false;
            this.cboZONA1.BackColorEven = System.Drawing.Color.White;
            this.cboZONA1.BackColorOdd = System.Drawing.Color.White;
            this.cboZONA1.ColumnNames = "";
            this.cboZONA1.ColumnWidthDefault = 75;
            this.cboZONA1.ColumnWidths = "";
            this.cboZONA1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboZONA1.FormattingEnabled = true;
            this.cboZONA1.LinkedColumnIndex = 1;
            this.cboZONA1.LinkedTextBox = this.txtORGds_zona;
            this.cboZONA1.Location = new System.Drawing.Point(52, 36);
            this.cboZONA1.Name = "cboZONA1";
            this.cboZONA1.Size = new System.Drawing.Size(63, 21);
            this.cboZONA1.TabIndex = 259;
            // 
            // cboPERNR1
            // 
            this.cboPERNR1.AutoComplete = false;
            this.cboPERNR1.AutoDropdown = false;
            this.cboPERNR1.BackColorEven = System.Drawing.Color.White;
            this.cboPERNR1.BackColorOdd = System.Drawing.Color.White;
            this.cboPERNR1.ColumnNames = "";
            this.cboPERNR1.ColumnWidthDefault = 75;
            this.cboPERNR1.ColumnWidths = "";
            this.cboPERNR1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboPERNR1.FormattingEnabled = true;
            this.cboPERNR1.LinkedColumnIndex = 1;
            this.cboPERNR1.LinkedTextBox = this.txtORGds_persona;
            this.cboPERNR1.Location = new System.Drawing.Point(102, 14);
            this.cboPERNR1.Name = "cboPERNR1";
            this.cboPERNR1.Size = new System.Drawing.Size(83, 21);
            this.cboPERNR1.TabIndex = 253;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 232;
            this.label1.Text = "Ubicación";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(397, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 237;
            this.label13.Text = "Motivo Movimiento";
            // 
            // txtMVPds_movimiento1
            // 
            this.txtMVPds_movimiento1.Location = new System.Drawing.Point(559, 99);
            this.txtMVPds_movimiento1.Margin = new System.Windows.Forms.Padding(2);
            this.txtMVPds_movimiento1.Name = "txtMVPds_movimiento1";
            this.txtMVPds_movimiento1.ReadOnly = true;
            this.txtMVPds_movimiento1.Size = new System.Drawing.Size(176, 20);
            this.txtMVPds_movimiento1.TabIndex = 236;
            this.txtMVPds_movimiento1.TabStop = false;
            // 
            // txtMVPobservaciones
            // 
            this.txtMVPobservaciones.Location = new System.Drawing.Point(5, 19);
            this.txtMVPobservaciones.Margin = new System.Windows.Forms.Padding(2);
            this.txtMVPobservaciones.Multiline = true;
            this.txtMVPobservaciones.Name = "txtMVPobservaciones";
            this.txtMVPobservaciones.Size = new System.Drawing.Size(675, 29);
            this.txtMVPobservaciones.TabIndex = 242;
            // 
            // dtpMVPfecha_movimiento
            // 
            this.dtpMVPfecha_movimiento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpMVPfecha_movimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMVPfecha_movimiento.Location = new System.Drawing.Point(250, 103);
            this.dtpMVPfecha_movimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpMVPfecha_movimiento.Name = "dtpMVPfecha_movimiento";
            this.dtpMVPfecha_movimiento.Size = new System.Drawing.Size(102, 20);
            this.dtpMVPfecha_movimiento.TabIndex = 248;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(187, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 251;
            this.label15.Text = "Proceso ID";
            // 
            // txtMVPid_proceso
            // 
            this.txtMVPid_proceso.Location = new System.Drawing.Point(250, 77);
            this.txtMVPid_proceso.Margin = new System.Windows.Forms.Padding(2);
            this.txtMVPid_proceso.Name = "txtMVPid_proceso";
            this.txtMVPid_proceso.Size = new System.Drawing.Size(102, 20);
            this.txtMVPid_proceso.TabIndex = 250;
            this.txtMVPid_proceso.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.txtDSTcrp);
            this.groupBox3.Controls.Add(this.cboPERNR4);
            this.groupBox3.Controls.Add(this.cboAMB2);
            this.groupBox3.Controls.Add(this.cboZONA2);
            this.groupBox3.Controls.Add(this.cboPERNR2);
            this.groupBox3.Controls.Add(this.txtDSTds_usuario);
            this.groupBox3.Controls.Add(this.txtDSTds_persona);
            this.groupBox3.Controls.Add(this.txtDSTds_ambiente);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtDSTds_crp);
            this.groupBox3.Controls.Add(this.txtDSTds_zona);
            this.groupBox3.Location = new System.Drawing.Point(399, 126);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(392, 136);
            this.groupBox3.TabIndex = 252;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DATOS DE DESTINO (MOVIMIENTO)";
            // 
            // txtDSTcrp
            // 
            this.txtDSTcrp.AutoComplete = false;
            this.txtDSTcrp.AutoDropdown = false;
            this.txtDSTcrp.BackColorEven = System.Drawing.Color.White;
            this.txtDSTcrp.BackColorOdd = System.Drawing.Color.White;
            this.txtDSTcrp.ColumnNames = "";
            this.txtDSTcrp.ColumnWidthDefault = 75;
            this.txtDSTcrp.ColumnWidths = "";
            this.txtDSTcrp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtDSTcrp.FormattingEnabled = true;
            this.txtDSTcrp.LinkedColumnIndex = 2;
            this.txtDSTcrp.LinkedTextBox = this.txtDSTds_crp;
            this.txtDSTcrp.Location = new System.Drawing.Point(52, 59);
            this.txtDSTcrp.Name = "txtDSTcrp";
            this.txtDSTcrp.Size = new System.Drawing.Size(63, 21);
            this.txtDSTcrp.TabIndex = 263;
            // 
            // txtDSTds_crp
            // 
            this.txtDSTds_crp.Location = new System.Drawing.Point(120, 58);
            this.txtDSTds_crp.Margin = new System.Windows.Forms.Padding(2);
            this.txtDSTds_crp.Name = "txtDSTds_crp";
            this.txtDSTds_crp.ReadOnly = true;
            this.txtDSTds_crp.Size = new System.Drawing.Size(268, 20);
            this.txtDSTds_crp.TabIndex = 229;
            this.txtDSTds_crp.TabStop = false;
            // 
            // cboPERNR4
            // 
            this.cboPERNR4.AutoComplete = false;
            this.cboPERNR4.AutoDropdown = false;
            this.cboPERNR4.BackColorEven = System.Drawing.Color.White;
            this.cboPERNR4.BackColorOdd = System.Drawing.Color.White;
            this.cboPERNR4.ColumnNames = "";
            this.cboPERNR4.ColumnWidthDefault = 75;
            this.cboPERNR4.ColumnWidths = "";
            this.cboPERNR4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboPERNR4.FormattingEnabled = true;
            this.cboPERNR4.LinkedColumnIndex = 1;
            this.cboPERNR4.LinkedTextBox = this.txtDSTds_usuario;
            this.cboPERNR4.Location = new System.Drawing.Point(100, 79);
            this.cboPERNR4.Name = "cboPERNR4";
            this.cboPERNR4.Size = new System.Drawing.Size(74, 21);
            this.cboPERNR4.TabIndex = 262;
            // 
            // txtDSTds_usuario
            // 
            this.txtDSTds_usuario.Location = new System.Drawing.Point(190, 80);
            this.txtDSTds_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtDSTds_usuario.Name = "txtDSTds_usuario";
            this.txtDSTds_usuario.ReadOnly = true;
            this.txtDSTds_usuario.Size = new System.Drawing.Size(198, 20);
            this.txtDSTds_usuario.TabIndex = 234;
            this.txtDSTds_usuario.TabStop = false;
            // 
            // cboAMB2
            // 
            this.cboAMB2.AutoComplete = false;
            this.cboAMB2.AutoDropdown = false;
            this.cboAMB2.BackColorEven = System.Drawing.Color.White;
            this.cboAMB2.BackColorOdd = System.Drawing.Color.White;
            this.cboAMB2.ColumnNames = "";
            this.cboAMB2.ColumnWidthDefault = 75;
            this.cboAMB2.ColumnWidths = "";
            this.cboAMB2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboAMB2.FormattingEnabled = true;
            this.cboAMB2.LinkedColumnIndex = 2;
            this.cboAMB2.LinkedTextBox = this.txtDSTds_ambiente;
            this.cboAMB2.Location = new System.Drawing.Point(75, 101);
            this.cboAMB2.Name = "cboAMB2";
            this.cboAMB2.Size = new System.Drawing.Size(54, 21);
            this.cboAMB2.TabIndex = 261;
            this.cboAMB2.SelectedIndexChanged += new System.EventHandler(this.multiColumnComboBox5_SelectedIndexChanged);
            // 
            // txtDSTds_ambiente
            // 
            this.txtDSTds_ambiente.Location = new System.Drawing.Point(134, 102);
            this.txtDSTds_ambiente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDSTds_ambiente.Name = "txtDSTds_ambiente";
            this.txtDSTds_ambiente.ReadOnly = true;
            this.txtDSTds_ambiente.Size = new System.Drawing.Size(254, 20);
            this.txtDSTds_ambiente.TabIndex = 233;
            this.txtDSTds_ambiente.TabStop = false;
            // 
            // cboZONA2
            // 
            this.cboZONA2.AutoComplete = false;
            this.cboZONA2.AutoDropdown = false;
            this.cboZONA2.BackColorEven = System.Drawing.Color.White;
            this.cboZONA2.BackColorOdd = System.Drawing.Color.White;
            this.cboZONA2.ColumnNames = "";
            this.cboZONA2.ColumnWidthDefault = 75;
            this.cboZONA2.ColumnWidths = "";
            this.cboZONA2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboZONA2.FormattingEnabled = true;
            this.cboZONA2.LinkedColumnIndex = 1;
            this.cboZONA2.LinkedTextBox = this.txtDSTds_zona;
            this.cboZONA2.Location = new System.Drawing.Point(52, 37);
            this.cboZONA2.Name = "cboZONA2";
            this.cboZONA2.Size = new System.Drawing.Size(63, 21);
            this.cboZONA2.TabIndex = 260;
            // 
            // txtDSTds_zona
            // 
            this.txtDSTds_zona.Location = new System.Drawing.Point(120, 37);
            this.txtDSTds_zona.Margin = new System.Windows.Forms.Padding(2);
            this.txtDSTds_zona.Name = "txtDSTds_zona";
            this.txtDSTds_zona.ReadOnly = true;
            this.txtDSTds_zona.Size = new System.Drawing.Size(268, 20);
            this.txtDSTds_zona.TabIndex = 228;
            this.txtDSTds_zona.TabStop = false;
            // 
            // cboPERNR2
            // 
            this.cboPERNR2.AutoComplete = false;
            this.cboPERNR2.AutoDropdown = false;
            this.cboPERNR2.BackColorEven = System.Drawing.Color.White;
            this.cboPERNR2.BackColorOdd = System.Drawing.Color.White;
            this.cboPERNR2.ColumnNames = "";
            this.cboPERNR2.ColumnWidthDefault = 75;
            this.cboPERNR2.ColumnWidths = "";
            this.cboPERNR2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboPERNR2.FormattingEnabled = true;
            this.cboPERNR2.LinkedColumnIndex = 1;
            this.cboPERNR2.LinkedTextBox = this.txtDSTds_persona;
            this.cboPERNR2.Location = new System.Drawing.Point(101, 14);
            this.cboPERNR2.Name = "cboPERNR2";
            this.cboPERNR2.Size = new System.Drawing.Size(84, 21);
            this.cboPERNR2.TabIndex = 259;
            // 
            // txtDSTds_persona
            // 
            this.txtDSTds_persona.Location = new System.Drawing.Point(190, 16);
            this.txtDSTds_persona.Margin = new System.Windows.Forms.Padding(2);
            this.txtDSTds_persona.Name = "txtDSTds_persona";
            this.txtDSTds_persona.ReadOnly = true;
            this.txtDSTds_persona.Size = new System.Drawing.Size(198, 20);
            this.txtDSTds_persona.TabIndex = 227;
            this.txtDSTds_persona.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 223;
            this.label8.Text = "Usuario o Cargo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 232;
            this.label9.Text = "Ubicación";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 224;
            this.label10.Text = "Zona";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 225;
            this.label11.Text = "CRP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 226;
            this.label12.Text = "Usuario en Uso";
            // 
            // cboMVPtipo1
            // 
            this.cboMVPtipo1.Location = new System.Drawing.Point(560, 72);
            this.cboMVPtipo1.Name = "cboMVPtipo1";
            this.cboMVPtipo1.ReadOnly = true;
            this.cboMVPtipo1.Size = new System.Drawing.Size(175, 20);
            this.cboMVPtipo1.TabIndex = 263;
            this.cboMVPtipo1.TabStop = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(5, 15);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(65, 19);
            this.button8.TabIndex = 264;
            this.button8.Text = "Agregar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Location = new System.Drawing.Point(698, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 62);
            this.groupBox2.TabIndex = 265;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Activos";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(5, 37);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(65, 19);
            this.button9.TabIndex = 265;
            this.button9.Text = "Eliminar";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMVPobservaciones);
            this.groupBox4.Location = new System.Drawing.Point(7, 267);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(685, 56);
            this.groupBox4.TabIndex = 267;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Observaciones";
            // 
            // datalistado1
            // 
            this.datalistado1.AllowUserToAddRows = false;
            this.datalistado1.AllowUserToDeleteRows = false;
            this.datalistado1.AllowUserToOrderColumns = true;
            this.datalistado1.BackgroundColor = System.Drawing.Color.White;
            this.datalistado1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.datalistado1.Location = new System.Drawing.Point(9, 335);
            this.datalistado1.Margin = new System.Windows.Forms.Padding(2);
            this.datalistado1.MultiSelect = false;
            this.datalistado1.Name = "datalistado1";
            this.datalistado1.ReadOnly = true;
            this.datalistado1.RowTemplate.Height = 24;
            this.datalistado1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado1.Size = new System.Drawing.Size(682, 196);
            this.datalistado1.TabIndex = 268;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ACFid";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código de Activo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PERNR";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código de Personal";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ACFfincorporacion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha de Incorporación";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ACFdescripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 300;
            // 
            // txtMVPds_movimiento
            // 
            this.txtMVPds_movimiento.AutoComplete = false;
            this.txtMVPds_movimiento.AutoDropdown = false;
            this.txtMVPds_movimiento.BackColorEven = System.Drawing.Color.White;
            this.txtMVPds_movimiento.BackColorOdd = System.Drawing.Color.White;
            this.txtMVPds_movimiento.ColumnNames = "";
            this.txtMVPds_movimiento.ColumnWidthDefault = 75;
            this.txtMVPds_movimiento.ColumnWidths = "";
            this.txtMVPds_movimiento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtMVPds_movimiento.FormattingEnabled = true;
            this.txtMVPds_movimiento.LinkedColumnIndex = 2;
            this.txtMVPds_movimiento.LinkedTextBox = this.txtMVPds_movimiento1;
            this.txtMVPds_movimiento.Location = new System.Drawing.Point(508, 99);
            this.txtMVPds_movimiento.Name = "txtMVPds_movimiento";
            this.txtMVPds_movimiento.Size = new System.Drawing.Size(47, 21);
            this.txtMVPds_movimiento.TabIndex = 266;
            // 
            // cboMVPtipo
            // 
            this.cboMVPtipo.AutoComplete = false;
            this.cboMVPtipo.AutoDropdown = false;
            this.cboMVPtipo.BackColorEven = System.Drawing.Color.White;
            this.cboMVPtipo.BackColorOdd = System.Drawing.Color.White;
            this.cboMVPtipo.ColumnNames = "";
            this.cboMVPtipo.ColumnWidthDefault = 75;
            this.cboMVPtipo.ColumnWidths = "";
            this.cboMVPtipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboMVPtipo.FormattingEnabled = true;
            this.cboMVPtipo.LinkedColumnIndex = 1;
            this.cboMVPtipo.LinkedTextBox = this.cboMVPtipo1;
            this.cboMVPtipo.Location = new System.Drawing.Point(508, 72);
            this.cboMVPtipo.Name = "cboMVPtipo";
            this.cboMVPtipo.Size = new System.Drawing.Size(47, 21);
            this.cboMVPtipo.TabIndex = 262;
            // 
            // FrmMovimiento_Transferencia_Activo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.datalistado1);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtMVPds_movimiento);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cboMVPtipo1);
            this.Controls.Add(this.cboMVPtipo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtMVPid_proceso);
            this.Controls.Add(this.dtpMVPfecha_movimiento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMVPds_movimiento1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMovimiento_Transferencia_Activo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMovimiento_Transferencia_Activo";
            this.Load += new System.EventHandler(this.FrmMovimiento_Transferencia_Activo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.TextBox txtORGds_crp;
        private System.Windows.Forms.TextBox txtORGds_zona;
        private System.Windows.Forms.TextBox txtORGds_persona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DateTimePicker dtpMVPfecha_movimiento;
        private System.Windows.Forms.TextBox txtMVPobservaciones;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMVPds_movimiento1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtORGds_usuario;
        private System.Windows.Forms.TextBox txtORGds_ambiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMVPid_proceso;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDSTds_usuario;
        private System.Windows.Forms.TextBox txtDSTds_persona;
        private System.Windows.Forms.TextBox txtDSTds_ambiente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDSTds_crp;
        private System.Windows.Forms.TextBox txtDSTds_zona;
        private MultiColumnComboBoxDemo.MultiColumnComboBox cboAMB2;
        private MultiColumnComboBoxDemo.MultiColumnComboBox cboZONA2;
        private MultiColumnComboBoxDemo.MultiColumnComboBox cboPERNR2;
        private MultiColumnComboBoxDemo.MultiColumnComboBox cboAMB1;
        private MultiColumnComboBoxDemo.MultiColumnComboBox cboZONA1;
        private MultiColumnComboBoxDemo.MultiColumnComboBox cboPERNR1;
        private MultiColumnComboBoxDemo.MultiColumnComboBox cboPERNR4;
        private MultiColumnComboBoxDemo.MultiColumnComboBox cboPERNR3;
        private System.Windows.Forms.TextBox cboMVPtipo1;
        private MultiColumnComboBoxDemo.MultiColumnComboBox cboMVPtipo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private MultiColumnComboBoxDemo.MultiColumnComboBox txtDSTcrp;
        private MultiColumnComboBoxDemo.MultiColumnComboBox txtORGcrp;
        private MultiColumnComboBoxDemo.MultiColumnComboBox txtMVPds_movimiento;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView datalistado1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}