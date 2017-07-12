namespace CapaPresentacion
{
    partial class Frm_InventarioCerrar
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
            this.txtINV1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboINV = new MultiColumnComboBoxDemo.MultiColumnComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.datalistado1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtINV1
            // 
            this.txtINV1.Location = new System.Drawing.Point(402, 40);
            this.txtINV1.Name = "txtINV1";
            this.txtINV1.ReadOnly = true;
            this.txtINV1.Size = new System.Drawing.Size(132, 20);
            this.txtINV1.TabIndex = 30;
            this.txtINV1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Inventario Id:";
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
            this.cboINV.Location = new System.Drawing.Point(275, 40);
            this.cboINV.Name = "cboINV";
            this.cboINV.Size = new System.Drawing.Size(121, 21);
            this.cboINV.TabIndex = 28;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(536, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Cerrar Inventario";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(405, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Ver Inventario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // datalistado1
            // 
            this.datalistado1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado1.Location = new System.Drawing.Point(14, 104);
            this.datalistado1.Name = "datalistado1";
            this.datalistado1.Size = new System.Drawing.Size(785, 443);
            this.datalistado1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Conciliar con:";
            // 
            // Frm_InventarioCerrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 559);
            this.Controls.Add(this.txtINV1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboINV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.datalistado1);
            this.Controls.Add(this.label3);
            this.Name = "Frm_InventarioCerrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_InventarioCerrar";
            this.Load += new System.EventHandler(this.Frm_InventarioCerrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datalistado1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtINV1;
        private System.Windows.Forms.Label label4;
        private MultiColumnComboBoxDemo.MultiColumnComboBox cboINV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView datalistado1;
        private System.Windows.Forms.Label label3;
    }
}