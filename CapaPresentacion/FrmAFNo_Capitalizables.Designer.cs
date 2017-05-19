namespace CapaPresentacion
{
    partial class FrmAFNo_Capitalizables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAFNo_Capitalizables));
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripRefrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripAnterior = new System.Windows.Forms.ToolStripButton();
            this.toolStripSiguiente = new System.Windows.Forms.ToolStripButton();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.BackgroundColor = System.Drawing.Color.White;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Location = new System.Drawing.Point(16, 172);
            this.dataListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.RowTemplate.Height = 24;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(931, 275);
            this.dataListado.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Fecha Desde : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Fecha Hasta : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(246, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(661, 99);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 30;
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
            this.toolStrip1.Size = new System.Drawing.Size(959, 82);
            this.toolStrip1.TabIndex = 156;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripRefrescar
            // 
            this.toolStripRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRefrescar.Image")));
            this.toolStripRefrescar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRefrescar.Name = "toolStripRefrescar";
            this.toolStripRefrescar.Size = new System.Drawing.Size(159, 79);
            this.toolStripRefrescar.Text = "Obtener. Registro SAP";
            this.toolStripRefrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripRefrescar.Click += new System.EventHandler(this.toolStripRefrescar_Click);
            // 
            // toolStripAgregar
            // 
            this.toolStripAgregar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAgregar.Image")));
            this.toolStripAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAgregar.Name = "toolStripAgregar";
            this.toolStripAgregar.Size = new System.Drawing.Size(125, 79);
            this.toolStripAgregar.Text = "Agregar/Generar";
            this.toolStripAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripAgregar.Visible = false;
            // 
            // toolStripEditar
            // 
            this.toolStripEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEditar.Image")));
            this.toolStripEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEditar.Name = "toolStripEditar";
            this.toolStripEditar.Size = new System.Drawing.Size(52, 79);
            this.toolStripEditar.Text = "Editar";
            this.toolStripEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripEditar.Visible = false;
            // 
            // toolStripCancelar
            // 
            this.toolStripCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCancelar.Image")));
            this.toolStripCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCancelar.Name = "toolStripCancelar";
            this.toolStripCancelar.Size = new System.Drawing.Size(70, 79);
            this.toolStripCancelar.Text = "Cancelar";
            this.toolStripCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripCancelar.Visible = false;
            this.toolStripCancelar.Click += new System.EventHandler(this.toolStripCancelar_Click);
            // 
            // toolStripAnterior
            // 
            this.toolStripAnterior.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripAnterior.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAnterior.Image")));
            this.toolStripAnterior.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAnterior.Name = "toolStripAnterior";
            this.toolStripAnterior.Size = new System.Drawing.Size(109, 79);
            this.toolStripAnterior.Text = "Importar Excel";
            this.toolStripAnterior.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripAnterior.Click += new System.EventHandler(this.toolStripAnterior_Click);
            // 
            // toolStripSiguiente
            // 
            this.toolStripSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSiguiente.Image")));
            this.toolStripSiguiente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripSiguiente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSiguiente.Name = "toolStripSiguiente";
            this.toolStripSiguiente.Size = new System.Drawing.Size(107, 79);
            this.toolStripSiguiente.Text = "Exportar Excel";
            this.toolStripSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripSiguiente.Visible = false;
            this.toolStripSiguiente.Click += new System.EventHandler(this.toolStripSiguiente_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(551, 138);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 17);
            this.lblTotal.TabIndex = 157;
            this.lblTotal.Text = "Registro:";
            // 
            // FrmAFNo_Capitalizables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 458);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAFNo_Capitalizables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAFNo_Capitalizables";
            this.Load += new System.EventHandler(this.FrmAFNo_Capitalizables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripRefrescar;
        private System.Windows.Forms.ToolStripButton toolStripAgregar;
        private System.Windows.Forms.ToolStripButton toolStripEditar;
        private System.Windows.Forms.ToolStripButton toolStripCancelar;
        private System.Windows.Forms.ToolStripButton toolStripAnterior;
        private System.Windows.Forms.ToolStripButton toolStripSiguiente;
        private System.Windows.Forms.Label lblTotal;
    }
}