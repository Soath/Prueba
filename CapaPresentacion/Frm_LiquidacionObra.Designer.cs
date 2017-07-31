namespace CapaPresentacion
{
    partial class Frm_LiquidacionObra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LiquidacionObra));
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripActivos = new System.Windows.Forms.ToolStripButton();
            this.toolStripRefrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSiguiente = new System.Windows.Forms.ToolStripButton();
            this.toolStripCancelar = new System.Windows.Forms.ToolStripButton();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataListado
            // 
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Location = new System.Drawing.Point(4, 111);
            this.dataListado.Name = "dataListado";
            this.dataListado.Size = new System.Drawing.Size(834, 240);
            this.dataListado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre de la hoja";
            // 
            // txtHoja
            // 
            this.txtHoja.Location = new System.Drawing.Point(109, 77);
            this.txtHoja.Multiline = true;
            this.txtHoja.Name = "txtHoja";
            this.txtHoja.Size = new System.Drawing.Size(331, 20);
            this.txtHoja.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Costo Directo :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(714, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(714, 383);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Costo Indirecto :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripActivos,
            this.toolStripRefrescar,
            this.toolStripGuardar,
            this.toolStripSiguiente,
            this.toolStripCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(844, 67);
            this.toolStrip1.TabIndex = 158;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripActivos
            // 
            this.toolStripActivos.Image = ((System.Drawing.Image)(resources.GetObject("toolStripActivos.Image")));
            this.toolStripActivos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripActivos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripActivos.Name = "toolStripActivos";
            this.toolStripActivos.Size = new System.Drawing.Size(188, 64);
            this.toolStripActivos.Text = "Importar Archivo Liquidación XLS";
            this.toolStripActivos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripActivos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripActivos.Click += new System.EventHandler(this.toolStripActivos_Click);
            // 
            // toolStripRefrescar
            // 
            this.toolStripRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRefrescar.Image")));
            this.toolStripRefrescar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRefrescar.Name = "toolStripRefrescar";
            this.toolStripRefrescar.Size = new System.Drawing.Size(131, 64);
            this.toolStripRefrescar.Text = "Procesar Valor Unitario";
            this.toolStripRefrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripRefrescar.Visible = false;
            this.toolStripRefrescar.Click += new System.EventHandler(this.toolStripRefrescar_Click);
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
            // toolStripSiguiente
            // 
            this.toolStripSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSiguiente.Image")));
            this.toolStripSiguiente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripSiguiente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSiguiente.Name = "toolStripSiguiente";
            this.toolStripSiguiente.Size = new System.Drawing.Size(120, 64);
            this.toolStripSiguiente.Text = "Generar Archivo SAP";
            this.toolStripSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripSiguiente.Visible = false;
            this.toolStripSiguiente.Click += new System.EventHandler(this.toolStripSiguiente_Click);
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
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(528, 83);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 13);
            this.lblTotal.TabIndex = 159;
            this.lblTotal.Text = "Registro:";
            // 
            // Frm_LiquidacionObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 431);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHoja);
            this.Controls.Add(this.dataListado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_LiquidacionObra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_LiquidacionObra";
            this.Load += new System.EventHandler(this.Frm_3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripActivos;
        private System.Windows.Forms.ToolStripButton toolStripRefrescar;
        private System.Windows.Forms.ToolStripButton toolStripGuardar;
        private System.Windows.Forms.ToolStripButton toolStripCancelar;
        private System.Windows.Forms.ToolStripButton toolStripSiguiente;
        private System.Windows.Forms.Label lblTotal;
    }
}