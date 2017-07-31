namespace CapaPresentacion
{
    partial class FrmacfGIS_UbicacionElectrica
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnimportar = new System.Windows.Forms.Button();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.lbltultimoid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Último Código de Activo Fijo";
            // 
            // btnimportar
            // 
            this.btnimportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimportar.Location = new System.Drawing.Point(501, 30);
            this.btnimportar.Name = "btnimportar";
            this.btnimportar.Size = new System.Drawing.Size(135, 43);
            this.btnimportar.TabIndex = 1;
            this.btnimportar.Text = "Importar";
            this.btnimportar.UseVisualStyleBackColor = true;
            this.btnimportar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.BackgroundColor = System.Drawing.Color.White;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Location = new System.Drawing.Point(11, 106);
            this.dataListado.Margin = new System.Windows.Forms.Padding(2);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowTemplate.Height = 24;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(692, 428);
            this.dataListado.TabIndex = 10;
            // 
            // lbltultimoid
            // 
            this.lbltultimoid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltultimoid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltultimoid.Location = new System.Drawing.Point(231, 46);
            this.lbltultimoid.Name = "lbltultimoid";
            this.lbltultimoid.Size = new System.Drawing.Size(64, 19);
            this.lbltultimoid.TabIndex = 12;
            this.lbltultimoid.Text = "label2";
            this.lbltultimoid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmacfGIS_UbicacionElectrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 552);
            this.Controls.Add(this.lbltultimoid);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.btnimportar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmacfGIS_UbicacionElectrica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmacfGIS_UbicacionElectrica";
            this.Load += new System.EventHandler(this.FrmacfGIS_UbicacionElectrica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnimportar;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.Label lbltultimoid;
    }
}