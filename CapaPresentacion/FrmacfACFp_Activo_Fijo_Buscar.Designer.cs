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
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ACFid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACFdescripcion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACFid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACFdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonTextBox1
            // 
            this.ribbonTextBox1.TextBoxText = null;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACFid2,
            this.ACFdescripcion2});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(12, 63);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowTemplate.Height = 24;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(668, 160);
            this.kryptonDataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(841, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(487, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(12, 30);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(823, 24);
            this.TextBox1.TabIndex = 4;
            this.TextBox1.Text = "kryptonTextBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACFid,
            this.ACFdescripcion});
            this.dataGridView1.Location = new System.Drawing.Point(12, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(953, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // ACFid2
            // 
            this.ACFid2.DataPropertyName = "ACFid";
            this.ACFid2.HeaderText = "Id";
            this.ACFid2.Name = "ACFid2";
            this.ACFid2.ReadOnly = true;
            // 
            // ACFdescripcion2
            // 
            this.ACFdescripcion2.DataPropertyName = "ACFdescripcion";
            this.ACFdescripcion2.HeaderText = "Descripcion";
            this.ACFdescripcion2.Name = "ACFdescripcion2";
            this.ACFdescripcion2.ReadOnly = true;
            this.ACFdescripcion2.Width = 500;
            // 
            // ACFid
            // 
            this.ACFid.DataPropertyName = "ACFid";
            this.ACFid.HeaderText = "id";
            this.ACFid.Name = "ACFid";
            // 
            // ACFdescripcion
            // 
            this.ACFdescripcion.DataPropertyName = "ACFdescripcion";
            this.ACFdescripcion.HeaderText = "Descripcion";
            this.ACFdescripcion.Name = "ACFdescripcion";
            this.ACFdescripcion.Width = 800;
            // 
            // FrmacfACFp_Activo_Fijo_Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 471);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Name = "FrmacfACFp_Activo_Fijo_Buscar";
            this.Text = "FrmacfACFp_Activo_Fijo_Buscar";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RibbonTextBox ribbonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACFid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACFdescripcion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACFid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACFdescripcion;
    }
}