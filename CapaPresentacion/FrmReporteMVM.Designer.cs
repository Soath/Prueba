﻿namespace CapaPresentacion
{
    partial class FrmReporteMVM
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
            this.ActivosFijosDataSet = new CapaPresentacion.ActivosFijosDataSet();
            this.acfMVMt_MotivoMovimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acfMVMt_MotivoMovimientoTableAdapter = new CapaPresentacion.ActivosFijosDataSetTableAdapters.acfMVMt_MotivoMovimientoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ActivosFijosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acfMVMt_MotivoMovimientoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.acfMVMt_MotivoMovimientoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(751, 548);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ActivosFijosDataSet
            // 
            this.ActivosFijosDataSet.DataSetName = "ActivosFijosDataSet";
            this.ActivosFijosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acfMVMt_MotivoMovimientoBindingSource
            // 
            this.acfMVMt_MotivoMovimientoBindingSource.DataMember = "acfMVMt_MotivoMovimiento";
            this.acfMVMt_MotivoMovimientoBindingSource.DataSource = this.ActivosFijosDataSet;
            // 
            // acfMVMt_MotivoMovimientoTableAdapter
            // 
            this.acfMVMt_MotivoMovimientoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteMVM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 549);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteMVM";
            this.Text = "FrmReporteMVM";
            this.Load += new System.EventHandler(this.FrmReporteMVM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActivosFijosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acfMVMt_MotivoMovimientoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource acfMVMt_MotivoMovimientoBindingSource;
        private ActivosFijosDataSet ActivosFijosDataSet;
        private ActivosFijosDataSetTableAdapters.acfMVMt_MotivoMovimientoTableAdapter acfMVMt_MotivoMovimientoTableAdapter;
    }
}