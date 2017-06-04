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
        }
        private void button2_Click(object sender, EventArgs e)
        {
           
            FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_Cbarra.rdlc", NacfACFp_Activo_Fijo.Mostrar3(), "ip");
            rptalu.ShowDialog();
        }
    }
}
