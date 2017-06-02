namespace CapaPresentacion
{
    partial class Frm_InventarioG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InventarioG));
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtINVid = new System.Windows.Forms.TextBox();
            this.txtINVdescripcion = new System.Windows.Forms.TextBox();
            this.txtINVrespon = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtINVfechainicio = new System.Windows.Forms.DateTimePicker();
            this.rbtotal = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cbActivo = new System.Windows.Forms.CheckBox();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripRefrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripPrimero = new System.Windows.Forms.ToolStripButton();
            this.toolStripUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripAnterior = new System.Windows.Forms.ToolStripButton();
            this.toolStripSiguiente = new System.Windows.Forms.ToolStripButton();
            this.toolStripBuscar = new System.Windows.Forms.ToolStripButton();
            this.txtINVfechacierre = new System.Windows.Forms.DateTimePicker();
            this.txtINVperiodo = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cboAMBid = new MultiColumnComboBoxDemo.MultiColumnComboBox();
            this.txtAMBid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(324, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 29);
            this.label3.TabIndex = 125;
            this.label3.Text = "Generar Inventario";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 127;
            this.label1.Text = "Id del Inventario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 128;
            this.label2.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 129;
            this.label4.Text = "Fecha Inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 130;
            this.label5.Text = "Fecha cierre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 131;
            this.label6.Text = "Tipo ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 132;
            this.label7.Text = "Responsable";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 133;
            this.label8.Text = "Periodo";
            // 
            // txtINVid
            // 
            this.txtINVid.Location = new System.Drawing.Point(126, 103);
            this.txtINVid.Name = "txtINVid";
            this.txtINVid.Size = new System.Drawing.Size(34, 20);
            this.txtINVid.TabIndex = 134;
            // 
            // txtINVdescripcion
            // 
            this.txtINVdescripcion.Location = new System.Drawing.Point(235, 103);
            this.txtINVdescripcion.Name = "txtINVdescripcion";
            this.txtINVdescripcion.Size = new System.Drawing.Size(285, 20);
            this.txtINVdescripcion.TabIndex = 135;
            // 
            // txtINVrespon
            // 
            this.txtINVrespon.Location = new System.Drawing.Point(87, 157);
            this.txtINVrespon.Name = "txtINVrespon";
            this.txtINVrespon.Size = new System.Drawing.Size(432, 20);
            this.txtINVrespon.TabIndex = 139;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 141;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 142;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dtINVfechainicio
            // 
            this.dtINVfechainicio.Checked = false;
            this.dtINVfechainicio.Enabled = false;
            this.dtINVfechainicio.Location = new System.Drawing.Point(597, 103);
            this.dtINVfechainicio.Name = "dtINVfechainicio";
            this.dtINVfechainicio.Size = new System.Drawing.Size(241, 20);
            this.dtINVfechainicio.TabIndex = 146;
            this.dtINVfechainicio.Value = new System.DateTime(2017, 4, 28, 8, 50, 2, 0);
            // 
            // rbtotal
            // 
            this.rbtotal.AutoSize = true;
            this.rbtotal.Location = new System.Drawing.Point(166, 132);
            this.rbtotal.Name = "rbtotal";
            this.rbtotal.Size = new System.Drawing.Size(49, 17);
            this.rbtotal.TabIndex = 149;
            this.rbtotal.Text = "Total";
            this.rbtotal.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(221, 132);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 17);
            this.radioButton2.TabIndex = 150;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Por Área";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // cbActivo
            // 
            this.cbActivo.AutoSize = true;
            this.cbActivo.Enabled = false;
            this.cbActivo.Location = new System.Drawing.Point(39, 133);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(56, 17);
            this.cbActivo.TabIndex = 153;
            this.cbActivo.Text = "Activo";
            this.cbActivo.UseVisualStyleBackColor = true;
            // 
            // datalistado
            // 
            this.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado.Location = new System.Drawing.Point(15, 223);
            this.datalistado.Name = "datalistado";
            this.datalistado.Size = new System.Drawing.Size(823, 199);
            this.datalistado.TabIndex = 154;
            this.datalistado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datalistado_CellDoubleClick);
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
            this.toolStripGuardar,
            this.toolStripCancelar,
            this.toolStripPrimero,
            this.toolStripUltimo,
            this.toolStripAnterior,
            this.toolStripSiguiente,
            this.toolStripBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 67);
            this.toolStrip1.TabIndex = 155;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripRefrescar
            // 
            this.toolStripRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRefrescar.Image")));
            this.toolStripRefrescar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRefrescar.Name = "toolStripRefrescar";
            this.toolStripRefrescar.Size = new System.Drawing.Size(63, 64);
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
            this.toolStripAgregar.Size = new System.Drawing.Size(99, 64);
            this.toolStripAgregar.Text = "Agregar/Generar";
            this.toolStripAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripAgregar.Click += new System.EventHandler(this.toolStripAgregar_Click);
            // 
            // toolStripEditar
            // 
            this.toolStripEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEditar.Image")));
            this.toolStripEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEditar.Name = "toolStripEditar";
            this.toolStripEditar.Size = new System.Drawing.Size(41, 64);
            this.toolStripEditar.Text = "Editar";
            this.toolStripEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripEditar.Click += new System.EventHandler(this.toolStripEditar_Click);
            // 
            // toolStripEliminar
            // 
            this.toolStripEliminar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEliminar.Image")));
            this.toolStripEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEliminar.Name = "toolStripEliminar";
            this.toolStripEliminar.Size = new System.Drawing.Size(54, 64);
            this.toolStripEliminar.Text = "Eliminar";
            this.toolStripEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripGuardar
            // 
            this.toolStripGuardar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGuardar.Image")));
            this.toolStripGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGuardar.Name = "toolStripGuardar";
            this.toolStripGuardar.Size = new System.Drawing.Size(53, 64);
            this.toolStripGuardar.Text = "Guardar";
            this.toolStripGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripGuardar.Visible = false;
            this.toolStripGuardar.Click += new System.EventHandler(this.toolStripGuardar_Click);
            // 
            // toolStripCancelar
            // 
            this.toolStripCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCancelar.Image")));
            this.toolStripCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCancelar.Name = "toolStripCancelar";
            this.toolStripCancelar.Size = new System.Drawing.Size(57, 64);
            this.toolStripCancelar.Text = "Cancelar";
            this.toolStripCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripCancelar.Visible = false;
            this.toolStripCancelar.Click += new System.EventHandler(this.toolStripCancelar_Click);
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
            this.toolStripPrimero.Click += new System.EventHandler(this.toolStripPrimero_Click);
            // 
            // toolStripUltimo
            // 
            this.toolStripUltimo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUltimo.Image")));
            this.toolStripUltimo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripUltimo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUltimo.Name = "toolStripUltimo";
            this.toolStripUltimo.Size = new System.Drawing.Size(47, 64);
            this.toolStripUltimo.Text = "Ultimo";
            this.toolStripUltimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripUltimo.Click += new System.EventHandler(this.toolStripUltimo_Click);
            // 
            // toolStripAnterior
            // 
            this.toolStripAnterior.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripAnterior.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAnterior.Image")));
            this.toolStripAnterior.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAnterior.Name = "toolStripAnterior";
            this.toolStripAnterior.Size = new System.Drawing.Size(54, 64);
            this.toolStripAnterior.Text = "Anterior";
            this.toolStripAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripAnterior.Click += new System.EventHandler(this.toolStripAnterior_Click_1);
            // 
            // toolStripSiguiente
            // 
            this.toolStripSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSiguiente.Image")));
            this.toolStripSiguiente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripSiguiente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSiguiente.Name = "toolStripSiguiente";
            this.toolStripSiguiente.Size = new System.Drawing.Size(60, 64);
            this.toolStripSiguiente.Text = "Siguiente";
            this.toolStripSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripSiguiente.Click += new System.EventHandler(this.toolStripSiguiente_Click_1);
            // 
            // toolStripBuscar
            // 
            this.toolStripBuscar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBuscar.Image")));
            this.toolStripBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBuscar.Name = "toolStripBuscar";
            this.toolStripBuscar.Size = new System.Drawing.Size(46, 64);
            this.toolStripBuscar.Text = "Buscar";
            this.toolStripBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // txtINVfechacierre
            // 
            this.txtINVfechacierre.Checked = false;
            this.txtINVfechacierre.Enabled = false;
            this.txtINVfechacierre.Location = new System.Drawing.Point(597, 129);
            this.txtINVfechacierre.Name = "txtINVfechacierre";
            this.txtINVfechacierre.Size = new System.Drawing.Size(241, 20);
            this.txtINVfechacierre.TabIndex = 156;
            this.txtINVfechacierre.Value = new System.DateTime(2017, 4, 28, 8, 50, 2, 0);
            // 
            // txtINVperiodo
            // 
            this.txtINVperiodo.Location = new System.Drawing.Point(597, 160);
            this.txtINVperiodo.Name = "txtINVperiodo";
            this.txtINVperiodo.Size = new System.Drawing.Size(241, 20);
            this.txtINVperiodo.TabIndex = 157;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(36, 204);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 13);
            this.lblTotal.TabIndex = 158;
            this.lblTotal.Text = "lblTotal";
            // 
            // cboAMBid
            // 
            this.cboAMBid.AutoComplete = false;
            this.cboAMBid.AutoDropdown = false;
            this.cboAMBid.BackColorEven = System.Drawing.Color.White;
            this.cboAMBid.BackColorOdd = System.Drawing.Color.White;
            this.cboAMBid.ColumnNames = "";
            this.cboAMBid.ColumnWidthDefault = 75;
            this.cboAMBid.ColumnWidths = "";
            this.cboAMBid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboAMBid.FormattingEnabled = true;
            this.cboAMBid.LinkedColumnIndex = 2;
            this.cboAMBid.LinkedTextBox = this.txtAMBid;
            this.cboAMBid.Location = new System.Drawing.Point(293, 130);
            this.cboAMBid.Name = "cboAMBid";
            this.cboAMBid.Size = new System.Drawing.Size(101, 21);
            this.cboAMBid.TabIndex = 159;
            // 
            // txtAMBid
            // 
            this.txtAMBid.Location = new System.Drawing.Point(400, 131);
            this.txtAMBid.Name = "txtAMBid";
            this.txtAMBid.ReadOnly = true;
            this.txtAMBid.Size = new System.Drawing.Size(119, 20);
            this.txtAMBid.TabIndex = 160;
            this.txtAMBid.TabStop = false;
            // 
            // Frm_InventarioG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(850, 434);
            this.Controls.Add(this.txtAMBid);
            this.Controls.Add(this.cboAMBid);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtINVperiodo);
            this.Controls.Add(this.txtINVfechacierre);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.datalistado);
            this.Controls.Add(this.cbActivo);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rbtotal);
            this.Controls.Add(this.dtINVfechainicio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtINVrespon);
            this.Controls.Add(this.txtINVdescripcion);
            this.Controls.Add(this.txtINVid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_InventarioG";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_InventarioG";
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtINVrespon;
        private System.Windows.Forms.TextBox txtINVdescripcion;
        private System.Windows.Forms.TextBox txtINVid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbtotal;
        private System.Windows.Forms.DataGridView datalistado;
        private System.Windows.Forms.CheckBox cbActivo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripRefrescar;
        private System.Windows.Forms.ToolStripButton toolStripAgregar;
        private System.Windows.Forms.ToolStripButton toolStripEditar;
        private System.Windows.Forms.ToolStripButton toolStripEliminar;
        private System.Windows.Forms.ToolStripButton toolStripGuardar;
        private System.Windows.Forms.ToolStripButton toolStripCancelar;
        private System.Windows.Forms.ToolStripButton toolStripPrimero;
        private System.Windows.Forms.ToolStripButton toolStripAnterior;
        private System.Windows.Forms.ToolStripButton toolStripSiguiente;
        private System.Windows.Forms.ToolStripButton toolStripUltimo;
        private System.Windows.Forms.ToolStripButton toolStripBuscar;
        private System.Windows.Forms.DateTimePicker dtINVfechainicio;
        private System.Windows.Forms.DateTimePicker txtINVfechacierre;
        private System.Windows.Forms.TextBox txtINVperiodo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtAMBid;
        private MultiColumnComboBoxDemo.MultiColumnComboBox cboAMBid;
    }
}