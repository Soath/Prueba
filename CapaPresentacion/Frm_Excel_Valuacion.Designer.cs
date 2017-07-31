namespace CapaPresentacion
{
    partial class Frm_Excel_Valuacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Excel_Valuacion));
            this.textRuta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLoadingStatus = new System.Windows.Forms.Label();
            this.prgLoadingProgress = new System.Windows.Forms.ProgressBar();
            this.pbLoadingGraphic = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripAnterior = new System.Windows.Forms.ToolStripButton();
            this.toolStripAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSiguiente = new System.Windows.Forms.ToolStripButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoja = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bwInstance = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingGraphic)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // textRuta
            // 
            this.textRuta.Location = new System.Drawing.Point(69, 85);
            this.textRuta.Multiline = true;
            this.textRuta.Name = "textRuta";
            this.textRuta.Size = new System.Drawing.Size(348, 20);
            this.textRuta.TabIndex = 204;
            this.textRuta.Text = "C:\\Users\\avatec\\Documents\\GitHub\\Prueba\\docs\\Liquidaciones G1V1_1ER GRUPO.xlsx";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 19);
            this.button1.TabIndex = 203;
            this.button1.Text = "Examinar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLoadingStatus
            // 
            this.lblLoadingStatus.AutoSize = true;
            this.lblLoadingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingStatus.Location = new System.Drawing.Point(584, 123);
            this.lblLoadingStatus.Name = "lblLoadingStatus";
            this.lblLoadingStatus.Size = new System.Drawing.Size(134, 31);
            this.lblLoadingStatus.TabIndex = 202;
            this.lblLoadingStatus.Text = "Loading...";
            this.lblLoadingStatus.Visible = false;
            // 
            // prgLoadingProgress
            // 
            this.prgLoadingProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgLoadingProgress.Location = new System.Drawing.Point(429, 86);
            this.prgLoadingProgress.Name = "prgLoadingProgress";
            this.prgLoadingProgress.Size = new System.Drawing.Size(471, 23);
            this.prgLoadingProgress.TabIndex = 201;
            // 
            // pbLoadingGraphic
            // 
            this.pbLoadingGraphic.Image = ((System.Drawing.Image)(resources.GetObject("pbLoadingGraphic.Image")));
            this.pbLoadingGraphic.Location = new System.Drawing.Point(906, 86);
            this.pbLoadingGraphic.Name = "pbLoadingGraphic";
            this.pbLoadingGraphic.Size = new System.Drawing.Size(70, 70);
            this.pbLoadingGraphic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoadingGraphic.TabIndex = 200;
            this.pbLoadingGraphic.TabStop = false;
            this.pbLoadingGraphic.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAnterior,
            this.toolStripAgregar,
            this.toolStripEditar,
            this.toolStripCancelar,
            this.toolStripSiguiente});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(994, 67);
            this.toolStrip1.TabIndex = 199;
            this.toolStrip1.Text = "toolStrip1";
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
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(194, 150);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 13);
            this.lblTotal.TabIndex = 198;
            this.lblTotal.Text = "Registro:";
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
            this.dataListado.Location = new System.Drawing.Point(9, 178);
            this.dataListado.Margin = new System.Windows.Forms.Padding(2);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.RowTemplate.Height = 24;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataListado.Size = new System.Drawing.Size(971, 261);
            this.dataListado.TabIndex = 197;
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
            this.chkEliminar.Location = new System.Drawing.Point(11, 150);
            this.chkEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(82, 17);
            this.chkEliminar.TabIndex = 196;
            this.chkEliminar.Text = "Seleccionar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 195;
            this.label1.Text = "Nombre de la hoja";
            // 
            // txtHoja
            // 
            this.txtHoja.Location = new System.Drawing.Point(116, 109);
            this.txtHoja.Multiline = true;
            this.txtHoja.Name = "txtHoja";
            this.txtHoja.Size = new System.Drawing.Size(302, 20);
            this.txtHoja.TabIndex = 194;
            this.txtHoja.Text = "sap";
            // 
            // bwInstance
            // 
            this.bwInstance.WorkerReportsProgress = true;
            this.bwInstance.WorkerSupportsCancellation = true;
            // 
            // Frm_Excel_Valuacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 440);
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
            this.Name = "Frm_Excel_Valuacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Excel_Valuacion";
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingGraphic)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textRuta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLoadingStatus;
        private System.Windows.Forms.ProgressBar prgLoadingProgress;
        private System.Windows.Forms.PictureBox pbLoadingGraphic;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripAnterior;
        private System.Windows.Forms.ToolStripButton toolStripAgregar;
        private System.Windows.Forms.ToolStripButton toolStripEditar;
        private System.Windows.Forms.ToolStripButton toolStripCancelar;
        private System.Windows.Forms.ToolStripButton toolStripSiguiente;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoja;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker bwInstance;
    }
}