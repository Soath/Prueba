namespace CapaPresentacion
{
    partial class FrmacfACFp_Activo_Fijo_Buscar
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
            this.ribbonTextBox1 = new System.Windows.Forms.RibbonTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ACFid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACFdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonTextBox1
            // 
            this.ribbonTextBox1.TextBoxText = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(711, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(12, 30);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(691, 24);
            this.TextBox1.TabIndex = 4;
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.BackgroundColor = System.Drawing.Color.White;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.ACFid,
            this.ACFdescripcion});
            this.dataListado.Location = new System.Drawing.Point(12, 72);
            this.dataListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowTemplate.Height = 24;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(823, 388);
            this.dataListado.TabIndex = 10;
            this.dataListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellDoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Seleccionar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 50;
            // 
            // ACFid
            // 
            this.ACFid.DataPropertyName = "ACFid";
            this.ACFid.HeaderText = "Id";
            this.ACFid.Name = "ACFid";
            this.ACFid.ReadOnly = true;
            // 
            // ACFdescripcion
            // 
            this.ACFdescripcion.DataPropertyName = "ACFdescripcion";
            this.ACFdescripcion.HeaderText = "Descripcion";
            this.ACFdescripcion.Name = "ACFdescripcion";
            this.ACFdescripcion.ReadOnly = true;
            this.ACFdescripcion.Width = 500;
            // 
            // FrmacfACFp_Activo_Fijo_Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 471);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.button1);
            this.Name = "FrmacfACFp_Activo_Fijo_Buscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmacfACFp_Activo_Fijo_Buscar";
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RibbonTextBox ribbonTextBox1;
        private System.Windows.Forms.Button button1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox1;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACFid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACFdescripcion;
    }
}