using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CapaPresentacion
{
    public partial class FrmReportes : Form
    {

        private string rptact;
        private object lst;


        public FrmReportes(string nombrereporte, object lista)
        {
            InitializeComponent();
            this.rptact = nombrereporte;
            this.lst = lista;
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = rptact;
            ReportDataSource datos = new ReportDataSource();
            datos.Name = "DataSet1";
            datos.Value = lst;
            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datos);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
