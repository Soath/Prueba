namespace CapaPresentacion
{
    partial class FrmExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExcel));
            this.txtHoja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripRefrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripAnterior = new System.Windows.Forms.ToolStripButton();
            this.toolStripSiguiente = new System.Windows.Forms.ToolStripButton();
            this.prgLoadingProgress = new System.Windows.Forms.ProgressBar();
            this.pbLoadingGraphic = new System.Windows.Forms.PictureBox();
            this.bwInstance = new System.ComponentModel.BackgroundWorker();
            this.lblLoadingStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textRuta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingGraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHoja
            // 
            this.txtHoja.Location = new System.Drawing.Point(116, 100);
            this.txtHoja.Multiline = true;
            this.txtHoja.Name = "txtHoja";
            this.txtHoja.Size = new System.Drawing.Size(302, 20);
            this.txtHoja.TabIndex = 1;
            this.txtHoja.Text = "sap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la hoja";
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.BackgroundColor = System.Drawing.Color.White;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dataListado.Location = new System.Drawing.Point(9, 169);
            this.dataListado.Margin = new System.Windows.Forms.Padding(2);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.RowTemplate.Height = 24;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataListado.Size = new System.Drawing.Size(971, 261);
            this.dataListado.TabIndex = 163;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Visible = false;
            this.Seleccionar.Width = 50;
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(11, 141);
            this.chkEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(82, 17);
            this.chkEliminar.TabIndex = 162;
            this.chkEliminar.Text = "Seleccionar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged_1);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(194, 141);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 13);
            this.lblTotal.TabIndex = 164;
            this.lblTotal.Text = "Registro:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.toolStripCancelar,
            this.toolStripAnterior,
            this.toolStripSiguiente});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(963, 67);
            this.toolStrip1.TabIndex = 165;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripRefrescar
            // 
            this.toolStripRefrescar.Image = global::CapaPresentacion.Properties.Resources.download;
            this.toolStripRefrescar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRefrescar.Name = "toolStripRefrescar";
            this.toolStripRefrescar.Size = new System.Drawing.Size(127, 64);
            this.toolStripRefrescar.Text = "Obtener. Registro SAP";
            this.toolStripRefrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripAgregar
            // 
            this.toolStripAgregar.Image = global::CapaPresentacion.Properties.Resources.add_folder;
            this.toolStripAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAgregar.Name = "toolStripAgregar";
            this.toolStripAgregar.Size = new System.Drawing.Size(104, 64);
            this.toolStripAgregar.Text = "Procesar Grabado";
            this.toolStripAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripAgregar.Visible = false;
            this.toolStripAgregar.Click += new System.EventHandler(this.toolStripAgregar_Click);
            // 
            // toolStripEditar
            // 
            this.toolStripEditar.Image = global::CapaPresentacion.Properties.Resources.edit;
            this.toolStripEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEditar.Name = "toolStripEditar";
            this.toolStripEditar.Size = new System.Drawing.Size(41, 64);
            this.toolStripEditar.Text = "Editar";
            this.toolStripEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripEditar.Visible = false;
            // 
            // toolStripCancelar
            // 
            this.toolStripCancelar.Image = global::CapaPresentacion.Properties.Resources.stop;
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
            // toolStripAnterior
            // 
            this.toolStripAnterior.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripAnterior.Image = global::CapaPresentacion.Properties.Resources.down_;
            this.toolStripAnterior.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAnterior.Name = "toolStripAnterior";
            this.toolStripAnterior.Size = new System.Drawing.Size(86, 64);
            this.toolStripAnterior.Text = "Importar Excel";
            this.toolStripAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripAnterior.Click += new System.EventHandler(this.toolStripAnterior_Click);
            // 
            // toolStripSiguiente
            // 
            this.toolStripSiguiente.Image = global::CapaPresentacion.Properties.Resources.up_;
            this.toolStripSiguiente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripSiguiente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSiguiente.Name = "toolStripSiguiente";
            this.toolStripSiguiente.Size = new System.Drawing.Size(83, 64);
            this.toolStripSiguiente.Text = "Exportar Excel";
            this.toolStripSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripSiguiente.Visible = false;
            // 
            // prgLoadingProgress
            // 
            this.prgLoadingProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgLoadingProgress.Location = new System.Drawing.Point(429, 77);
            this.prgLoadingProgress.Name = "prgLoadingProgress";
            this.prgLoadingProgress.Size = new System.Drawing.Size(471, 23);
            this.prgLoadingProgress.TabIndex = 167;
            // 
            // pbLoadingGraphic
            // 
            this.pbLoadingGraphic.Image = ((System.Drawing.Image)(resources.GetObject("pbLoadingGraphic.Image")));
            this.pbLoadingGraphic.Location = new System.Drawing.Point(906, 77);
            this.pbLoadingGraphic.Name = "pbLoadingGraphic";
            this.pbLoadingGraphic.Size = new System.Drawing.Size(70, 70);
            this.pbLoadingGraphic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoadingGraphic.TabIndex = 166;
            this.pbLoadingGraphic.TabStop = false;
            this.pbLoadingGraphic.Visible = false;
            // 
            // bwInstance
            // 
            this.bwInstance.WorkerReportsProgress = true;
            this.bwInstance.WorkerSupportsCancellation = true;
            this.bwInstance.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwInstance_DoWork);
            this.bwInstance.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwInstance_ProgressChanged);
            this.bwInstance.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwInstance_RunWorkerCompleted);
            // 
            // lblLoadingStatus
            // 
            this.lblLoadingStatus.AutoSize = true;
            this.lblLoadingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingStatus.Location = new System.Drawing.Point(584, 114);
            this.lblLoadingStatus.Name = "lblLoadingStatus";
            this.lblLoadingStatus.Size = new System.Drawing.Size(134, 31);
            this.lblLoadingStatus.TabIndex = 168;
            this.lblLoadingStatus.Text = "Loading...";
            this.lblLoadingStatus.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 19);
            this.button1.TabIndex = 170;
            this.button1.Text = "Examinar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textRuta
            // 
            this.textRuta.Location = new System.Drawing.Point(69, 76);
            this.textRuta.Multiline = true;
            this.textRuta.Name = "textRuta";
            this.textRuta.Size = new System.Drawing.Size(348, 20);
            this.textRuta.TabIndex = 171;
            this.textRuta.Text = "C:\\Users\\avatec\\Documents\\GitHub\\Prueba\\docs\\Liquidaciones G1V1_1ER GRUPO.xlsx";
            // 
            // FrmExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 483);
            this.Controls.Add(this.textRuta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLoadingStatus);
            this.Controls.Add(this.prgLoadingProgress);
            this.Controls.Add(this.pbLoadingGraphic);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.chkEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHoja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExcel";
            this.Load += new System.EventHandler(this.FrmExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingGraphic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripRefrescar;
        private System.Windows.Forms.ToolStripButton toolStripAgregar;
        private System.Windows.Forms.ToolStripButton toolStripEditar;
        private System.Windows.Forms.ToolStripButton toolStripCancelar;
        private System.Windows.Forms.ToolStripButton toolStripAnterior;
        private System.Windows.Forms.ToolStripButton toolStripSiguiente;
        private System.Windows.Forms.ProgressBar prgLoadingProgress;
        private System.Windows.Forms.PictureBox pbLoadingGraphic;
        private System.ComponentModel.BackgroundWorker bwInstance;
        private System.Windows.Forms.Label lblLoadingStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textRuta;
    }
}