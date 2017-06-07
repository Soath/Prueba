using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Fom_Barra : Form
    {
        public Fom_Barra()
        {
            InitializeComponent();
            CargarCombos();
            
        }
        private void CargarCombos()
        {
            this.cboAMBid.DataSource = NacfAMBt_Ambiente.Mostrar();
            this.cboAMBid.ValueMember = "AMBid";
            this.cboAMBid.DisplayMember = "AMBid";
            this.cboAMBid.SelectedIndex = -1;

            this.cboACFid.DataSource = NacfACFp_Activo_Fijo.MostrarRegistro("");
            this.cboACFid.ValueMember = "ACFid";
            this.cboACFid.DisplayMember = "ACFid";
            this.cboACFid.SelectedIndex = -1;

            this.cboPERNR.DataSource = NbdiXPEpExtraccionSAP_Personal.Mostrar();
            this.cboPERNR.ValueMember = "PERNR";
            this.cboPERNR.DisplayMember = "PERNR";
            this.cboPERNR.SelectedIndex = -1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CargaData();
            if (chbAMB.Checked)
            {
                FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_Cbarra.rdlc", NacfACFp_Activo_Fijo.Mostrar5(cboAMBid.Text), "ip");
                rptalu.ShowDialog();
            }
            if (chbACF.Checked)
            {
                FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_Cbarra.rdlc", NacfACFp_Activo_Fijo.Mostrar5(cboACFid.Text), "ip");
                rptalu.ShowDialog();
            }
            if (chbPERNR.Checked)
            {
                FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_Cbarra.rdlc", NacfACFp_Activo_Fijo.Mostrar5(cboPERNR.Text), "ip");
                rptalu.ShowDialog();
            }

        }
        private void CargaData ()
        {
            if( chbACF.Checked)
            this.datalistado1.DataSource = NacfACFp_Activo_Fijo.Mostrar5(cboACFid.Text);
            if(chbAMB.Checked)
            this.datalistado1.DataSource = NacfACFp_Activo_Fijo.Mostrar5(cboAMBid.Text);
            if (chbPERNR.Checked)
            this.datalistado1.DataSource = NacfACFp_Activo_Fijo.Mostrar5(cboPERNR.Text);

        }
    }
}
