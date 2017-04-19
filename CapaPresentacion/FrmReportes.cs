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
using System.Net;
using System.Net.NetworkInformation;

namespace CapaPresentacion
{
    public partial class FrmReportes : Form
    {
        private string ip;
        private string rptact;
        private object lst;


    /*  string hallarip ()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }*/
        public FrmReportes(string nombrereporte, object lista, string ip)
        {

            InitializeComponent();
            this.rptact = nombrereporte;
            this.lst = lista;
            this.ip = ip;
            
           
            
        }
      

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportPath = rptact;
            ReportDataSource datos = new ReportDataSource();
            datos.Name = "DataSet1";
            datos.Value = lst;
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
          
            ReportParameter p = new ReportParameter("reportip", localIP);
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datos);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();

            
            


        }
    }
}
