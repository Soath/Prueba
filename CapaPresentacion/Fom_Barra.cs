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

            this.cboCRP.DataSource = NacfCRPt_Centro_Responsabilidad.Mostrar();
            this.cboCRP.ValueMember = "CRPid_crp";
            this.cboCRP.DisplayMember = "CRPid_crp";
            this.cboCRP.SelectedIndex = -1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CargaData();
            if (chbAMB.Checked == false && chbACF.Checked == false && chbPERNR.Checked== false && chbRACF.Checked == false && chbCRP.Checked == false)
            {
                MessageBox.Show("No ha seleccionado ningún filtro.");
            }
            
            if(rb1.Checked==false && rb2.Checked==false)
            {
                MessageBox.Show("No ha seleccionado el número de columnas");
            }
            if (chbAMB.Checked)
            {
                if (rb2.Checked)
                {
                    FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_Cbarra.rdlc", NacfACFp_Activo_Fijo.Mostrar5(cboAMBid.Text), "ip");
                    rptalu.ShowDialog();
                }
                if(rb1.Checked)
                {
                    FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_Cbarra1.rdlc", NacfACFp_Activo_Fijo.Mostrar5(cboAMBid.Text), "ip");
                    rptalu.ShowDialog();
                }
            }
            if (chbCRP.Checked)
            {
                if (rb2.Checked)
                {
                    FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_Cbarra.rdlc", NacfACFp_Activo_Fijo.Mostrar5(cboCRP.Text), "ip");
                    rptalu.ShowDialog();
                }
                if (rb1.Checked)
                {
                    FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_Cbarra1.rdlc", NacfACFp_Activo_Fijo.Mostrar5(cboCRP.Text), "ip");
                    rptalu.ShowDialog();
                }
            }
            if (chbACF.Checked)
            {
                if (rb2.Checked) { 
                            
                FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_Cbarra.rdlc", NacfACFp_Activo_Fijo.Mostrar5(cboACFid.Text), "ip");
                rptalu.ShowDialog();
                }
                if (rb1.Checked)
                {

                    FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_Cbarra1.rdlc", NacfACFp_Activo_Fijo.Mostrar5(cboACFid.Text), "ip");
                    rptalu.ShowDialog();
                }


            }
            if (chbPERNR.Checked)
            {
                if (rb2.Checked)
                {
                    FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_Cbarra.rdlc", NacfACFp_Activo_Fijo.Mostrar5(cboPERNR.Text), "ip");
                    rptalu.ShowDialog();
                }
                if (rb1.Checked)
                {
                    FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_Cbarra1.rdlc", NacfACFp_Activo_Fijo.Mostrar5(cboPERNR.Text), "ip");
                    rptalu.ShowDialog();
                }

            }
            if(chbRACF.Checked)
            {
                if (rb2.Checked)
                {
                    FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_Cbarra.rdlc", NacfACFp_Activo_Fijo.Mostrar6(txtRACF.Text,txtRACF1.Text), "ip");
                    rptalu.ShowDialog();
                }
                if (rb1.Checked)
                {
                    FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_Cbarra1.rdlc", NacfACFp_Activo_Fijo.Mostrar6(txtRACF.Text, txtRACF1.Text), "ip");
                    rptalu.ShowDialog();
                }


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
            if(chbRACF.Checked)
            this.datalistado1.DataSource = NacfACFp_Activo_Fijo.Mostrar6(txtRACF.Text, txtRACF1.Text);
            if (chbCRP.Checked)
                this.datalistado1.DataSource = NacfACFp_Activo_Fijo.Mostrar5(cboCRP.Text);
        }

        private void Fom_Barra_Load(object sender, EventArgs e)
        {

        }
    }
}
