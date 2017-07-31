namespace CapaPresentacion
{
    partial class FrmacfCMPt_Componente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmacfCMPt_Componente));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelX10 = new System.Windows.Forms.Label();
            this.labelX9 = new System.Windows.Forms.Label();
            this.txtCMPvutildia = new System.Windows.Forms.TextBox();
            this.txtCMPvutilanio = new System.Windows.Forms.TextBox();
            this.labelX8 = new System.Windows.Forms.Label();
            this.labelX7 = new System.Windows.Forms.Label();
            this.labelX6 = new System.Windows.Forms.Label();
            this.labelX5 = new System.Windows.Forms.Label();
            this.labelX4 = new System.Windows.Forms.Label();
            this.txtCMPfactorusoestimado = new System.Windows.Forms.TextBox();
            this.txtCMPtotalfactores = new System.Windows.Forms.TextBox();
            this.txtCMPlimitelegal = new System.Windows.Forms.TextBox();
            this.txtCMPobsolecencia = new System.Windows.Forms.TextBox();
            this.txtCMPconservacion = new System.Windows.Forms.TextBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelX3 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.txtCMPusoestimado = new System.Windows.Forms.TextBox();
            this.txtCMPcomponente = new System.Windows.Forms.TextBox();
            this.txtCMPid = new System.Windows.Forms.TextBox();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCMPnivel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 293);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(693, 285);
            this.tabControl1.TabIndex = 129;
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabPage1.Controls.Add(this.dataListado);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.chkEliminar);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(685, 259);
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
            this.dataListado.Location = new System.Drawing.Point(10, 85);
            this.dataListado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowTemplate.Height = 24;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(610, 166);
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
            this.pictureBox2.Location = new System.Drawing.Point(15, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(375, 64);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "lblTotal";
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(10, 64);
            this.chkEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(62, 17);
            this.chkEliminar.TabIndex = 5;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(69, 16);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(246, 20);
            this.txtBuscar.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(685, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(10, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(654, 231);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuarios";
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            this.labelX10.Location = new System.Drawing.Point(295, 130);
            this.labelX10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(79, 13);
            this.labelX10.TabIndex = 129;
            this.labelX10.Text = "Vida util por dia";
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            this.labelX9.Location = new System.Drawing.Point(295, 95);
            this.labelX9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(83, 13);
            this.labelX9.TabIndex = 128;
            this.labelX9.Text = "Vida util por año";
            // 
            // txtCMPvutildia
            // 
            this.txtCMPvutildia.BackColor = System.Drawing.Color.White;
            this.txtCMPvutildia.Location = new System.Drawing.Point(411, 135);
            this.txtCMPvutildia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCMPvutildia.MaxLength = 30;
            this.txtCMPvutildia.Name = "txtCMPvutildia";
            this.txtCMPvutildia.Size = new System.Drawing.Size(178, 20);
            this.txtCMPvutildia.TabIndex = 127;
            // 
            // txtCMPvutilanio
            // 
            this.txtCMPvutilanio.BackColor = System.Drawing.Color.White;
            this.txtCMPvutilanio.Location = new System.Drawing.Point(411, 100);
            this.txtCMPvutilanio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCMPvutilanio.MaxLength = 30;
            this.txtCMPvutilanio.Name = "txtCMPvutilanio";
            this.txtCMPvutilanio.Size = new System.Drawing.Size(178, 20);
            this.txtCMPvutilanio.TabIndex = 126;
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.Location = new System.Drawing.Point(295, 64);
            this.labelX8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(117, 13);
            this.labelX8.TabIndex = 125;
            this.labelX8.Text = "Factor de uso estimado";
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            this.labelX7.Location = new System.Drawing.Point(295, 33);
            this.labelX7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 13);
            this.labelX7.TabIndex = 124;
            this.labelX7.Text = "Total Factores";
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.Location = new System.Drawing.Point(17, 125);
            this.labelX6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(63, 13);
            this.labelX6.TabIndex = 123;
            this.labelX6.Text = "Limite Legal";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.Location = new System.Drawing.Point(17, 95);
            this.labelX5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(72, 13);
            this.labelX5.TabIndex = 122;
            this.labelX5.Text = "Obsolecencia";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.Location = new System.Drawing.Point(17, 65);
            this.labelX4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(72, 13);
            this.labelX4.TabIndex = 121;
            this.labelX4.Text = "Conservacion";
            // 
            // txtCMPfactorusoestimado
            // 
            this.txtCMPfactorusoestimado.BackColor = System.Drawing.Color.White;
            this.txtCMPfactorusoestimado.Location = new System.Drawing.Point(411, 66);
            this.txtCMPfactorusoestimado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCMPfactorusoestimado.MaxLength = 30;
            this.txtCMPfactorusoestimado.Name = "txtCMPfactorusoestimado";
            this.txtCMPfactorusoestimado.Size = new System.Drawing.Size(178, 20);
            this.txtCMPfactorusoestimado.TabIndex = 120;
            // 
            // txtCMPtotalfactores
            // 
            this.txtCMPtotalfactores.BackColor = System.Drawing.Color.White;
            this.txtCMPtotalfactores.Location = new System.Drawing.Point(411, 35);
            this.txtCMPtotalfactores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCMPtotalfactores.MaxLength = 30;
            this.txtCMPtotalfactores.Name = "txtCMPtotalfactores";
            this.txtCMPtotalfactores.Size = new System.Drawing.Size(178, 20);
            this.txtCMPtotalfactores.TabIndex = 119;
            // 
            // txtCMPlimitelegal
            // 
            this.txtCMPlimitelegal.BackColor = System.Drawing.Color.White;
            this.txtCMPlimitelegal.Location = new System.Drawing.Point(92, 125);
            this.txtCMPlimitelegal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCMPlimitelegal.MaxLength = 30;
            this.txtCMPlimitelegal.Name = "txtCMPlimitelegal";
            this.txtCMPlimitelegal.Size = new System.Drawing.Size(178, 20);
            this.txtCMPlimitelegal.TabIndex = 118;
            // 
            // txtCMPobsolecencia
            // 
            this.txtCMPobsolecencia.BackColor = System.Drawing.Color.White;
            this.txtCMPobsolecencia.Location = new System.Drawing.Point(92, 95);
            this.txtCMPobsolecencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCMPobsolecencia.MaxLength = 30;
            this.txtCMPobsolecencia.Name = "txtCMPobsolecencia";
            this.txtCMPobsolecencia.Size = new System.Drawing.Size(178, 20);
            this.txtCMPobsolecencia.TabIndex = 117;
            // 
            // txtCMPconservacion
            // 
            this.txtCMPconservacion.BackColor = System.Drawing.Color.White;
            this.txtCMPconservacion.Location = new System.Drawing.Point(92, 65);
            this.txtCMPconservacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCMPconservacion.MaxLength = 30;
            this.txtCMPconservacion.Name = "txtCMPconservacion";
            this.txtCMPconservacion.Size = new System.Drawing.Size(178, 20);
            this.txtCMPconservacion.TabIndex = 116;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(24, 76);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(122, 13);
            this.labelX1.TabIndex = 115;
            this.labelX1.Text = "Código de componentes";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(17, 35);
            this.labelX3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(71, 13);
            this.labelX3.TabIndex = 113;
            this.labelX3.Text = "Uso estimado";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(24, 109);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(140, 13);
            this.labelX2.TabIndex = 112;
            this.labelX2.Text = "Descripción de componente";
            // 
            // txtCMPusoestimado
            // 
            this.txtCMPusoestimado.BackColor = System.Drawing.Color.White;
            this.txtCMPusoestimado.Location = new System.Drawing.Point(92, 35);
            this.txtCMPusoestimado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCMPusoestimado.MaxLength = 30;
            this.txtCMPusoestimado.Name = "txtCMPusoestimado";
            this.txtCMPusoestimado.Size = new System.Drawing.Size(178, 20);
            this.txtCMPusoestimado.TabIndex = 110;
            // 
            // txtCMPcomponente
            // 
            this.txtCMPcomponente.BackColor = System.Drawing.Color.White;
            this.txtCMPcomponente.Location = new System.Drawing.Point(166, 106);
            this.txtCMPcomponente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCMPcomponente.MaxLength = 30;
            this.txtCMPcomponente.Name = "txtCMPcomponente";
            this.txtCMPcomponente.Size = new System.Drawing.Size(178, 20);
            this.txtCMPcomponente.TabIndex = 108;
            // 
            // txtCMPid
            // 
            this.txtCMPid.BackColor = System.Drawing.Color.White;
            this.txtCMPid.Location = new System.Drawing.Point(166, 73);
            this.txtCMPid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCMPid.MaxLength = 50;
            this.txtCMPid.Name = "txtCMPid";
            this.txtCMPid.Size = new System.Drawing.Size(178, 20);
            this.txtCMPid.TabIndex = 101;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
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
            this.toolStrip1.Size = new System.Drawing.Size(755, 62);
            this.toolStrip1.TabIndex = 207;
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
            this.toolStripSiguiente.Click += new System.EventHandler(this.toolStripSiguiente_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX10);
            this.groupBox1.Controls.Add(this.txtCMPlimitelegal);
            this.groupBox1.Controls.Add(this.txtCMPobsolecencia);
            this.groupBox1.Controls.Add(this.labelX9);
            this.groupBox1.Controls.Add(this.txtCMPtotalfactores);
            this.groupBox1.Controls.Add(this.txtCMPconservacion);
            this.groupBox1.Controls.Add(this.txtCMPvutildia);
            this.groupBox1.Controls.Add(this.txtCMPfactorusoestimado);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.txtCMPvutilanio);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.Controls.Add(this.txtCMPusoestimado);
            this.groupBox1.Controls.Add(this.labelX7);
            this.groupBox1.Location = new System.Drawing.Point(26, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 159);
            this.groupBox1.TabIndex = 208;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Características";
            // 
            // txtCMPnivel
            // 
            this.txtCMPnivel.BackColor = System.Drawing.Color.White;
            this.txtCMPnivel.Location = new System.Drawing.Point(397, 76);
            this.txtCMPnivel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCMPnivel.MaxLength = 30;
            this.txtCMPnivel.Name = "txtCMPnivel";
            this.txtCMPnivel.Size = new System.Drawing.Size(71, 20);
            this.txtCMPnivel.TabIndex = 209;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 210;
            this.label2.Text = "Nivel";
            // 
            // FrmacfCMPt_Componente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 593);
            this.Controls.Add(this.txtCMPnivel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtCMPid);
            this.Controls.Add(this.txtCMPcomponente);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmacfCMPt_Componente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmacfCMPt_Componente";
            this.Load += new System.EventHandler(this.FrmacfCMPt_Componente_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelX3;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.TextBox txtCMPusoestimado;
        private System.Windows.Forms.TextBox txtCMPcomponente;
        private System.Windows.Forms.TextBox txtCMPid;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label labelX10;
        private System.Windows.Forms.Label labelX9;
        private System.Windows.Forms.TextBox txtCMPvutildia;
        private System.Windows.Forms.TextBox txtCMPvutilanio;
        private System.Windows.Forms.Label labelX8;
        private System.Windows.Forms.Label labelX7;
        private System.Windows.Forms.Label labelX6;
        private System.Windows.Forms.Label labelX5;
        private System.Windows.Forms.Label labelX4;
        private System.Windows.Forms.TextBox txtCMPfactorusoestimado;
        private System.Windows.Forms.TextBox txtCMPtotalfactores;
        private System.Windows.Forms.TextBox txtCMPlimitelegal;
        private System.Windows.Forms.TextBox txtCMPobsolecencia;
        private System.Windows.Forms.TextBox txtCMPconservacion;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCMPnivel;
        private System.Windows.Forms.Label label2;
    }
}