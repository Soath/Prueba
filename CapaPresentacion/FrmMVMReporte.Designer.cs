namespace CapaPresentacion
{
    partial class FrmMVMReporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ActivosFijosDataSet2 = new CapaPresentacion.ActivosFijosDataSet2();
            this.acfMVMt_MotivoMovimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acfMVMt_MotivoMovimientoTableAdapter = new CapaPresentacion.ActivosFijosDataSet2TableAdapters.acfMVMt_MotivoMovimientoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ActivosFijosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acfMVMt_MotivoMovimientoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet3";
            reportDataSource1.Value = this.acfMVMt_MotivoMovimientoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(998, 684);
            this.reportViewer1.TabIndex = 0;
            // 
            // ActivosFijosDataSet2
            // 
            this.ActivosFijosDataSet2.DataSetName = "ActivosFijosDataSet2";
            this.ActivosFijosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acfMVMt_MotivoMovimientoBindingSource
            // 
            this.acfMVMt_MotivoMovimientoBindingSource.DataMember = "acfMVMt_MotivoMovimiento";
            this.acfMVMt_MotivoMovimientoBindingSource.DataSource = this.ActivosFijosDataSet2;
            // 
            // acfMVMt_MotivoMovimientoTableAdapter
            // 
            this.acfMVMt_MotivoMovimientoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMVMReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 680);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmMVMReporte";
            this.Text = "FrmMVMReporte";
            this.Load += new System.EventHandler(this.FrmMVMReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActivosFijosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acfMVMt_MotivoMovimientoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource acfMVMt_MotivoMovimientoBindingSource;
        private ActivosFijosDataSet2 ActivosFijosDataSet2;
        private ActivosFijosDataSet2TableAdapters.acfMVMt_MotivoMovimientoTableAdapter acfMVMt_MotivoMovimientoTableAdapter;
    }
}