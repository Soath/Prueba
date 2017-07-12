namespace CapaPresentacion
{
    partial class Frm_ConciliarInventario
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
            this.label3 = new System.Windows.Forms.Label();
            this.datalistado1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtINV1 = new System.Windows.Forms.TextBox();
            this.cboINV = new MultiColumnComboBoxDemo.MultiColumnComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Conciliar con:";
            // 
            // datalistado1
            // 
            this.datalistado1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado1.Location = new System.Drawing.Point(12, 108);
            this.datalistado1.Name = "datalistado1";
            this.datalistado1.Size = new System.Drawing.Size(785, 385);
            this.datalistado1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Procesar Conciliación";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(534, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Inventario Id:";
            // 
            // txtINV1
            // 
            this.txtINV1.Location = new System.Drawing.Point(400, 44);
            this.txtINV1.Name = "txtINV1";
            this.txtINV1.ReadOnly = true;
            this.txtINV1.Size = new System.Drawing.Size(132, 20);
            this.txtINV1.TabIndex = 23;
            this.txtINV1.TabStop = false;
            // 
            // cboINV
            // 
            this.cboINV.AutoComplete = true;
            this.cboINV.AutoDropdown = true;
            this.cboINV.BackColorEven = System.Drawing.Color.White;
            this.cboINV.BackColorOdd = System.Drawing.Color.White;
            this.cboINV.ColumnNames = "";
            this.cboINV.ColumnWidthDefault = 75;
            this.cboINV.ColumnWidths = "";
            this.cboINV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboINV.FormattingEnabled = true;
            this.cboINV.LinkedColumnIndex = 1;
            this.cboINV.LinkedTextBox = this.txtINV1;
            this.cboINV.Location = new System.Drawing.Point(273, 44);
            this.cboINV.Name = "cboINV";
            this.cboINV.Size = new System.Drawing.Size(121, 21);
            this.cboINV.TabIndex = 21;
            // 
            // Frm_ConciliarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 515);
            this.Controls.Add(this.txtINV1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboINV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.datalistado1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_ConciliarInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ConciliarInventario";
            this.Load += new System.EventHandler(this.Frm_ConciliarInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datalistado1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView datalistado1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private MultiColumnComboBoxDemo.MultiColumnComboBox cboINV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtINV1;
    }
}