using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CapaNegocio;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMain : Form
    {
        ACFLOCT_LOCAL aCFLOCT_LOCAL;
        UserControl1 User1;
        
        public FrmMain()
        {
            String mensaje = NConexion.ChequearConexion();
            if (mensaje == "Y")
            {
                InitializeComponent();
                Iniciar();
            }
            else
            {
                MessageBox.Show("El Sistema de Gestión no se puede iniciar ya que existió un error al conectarse con la Base de Datos. " + mensaje,
                  "Error al iniciar el Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
        }

        public void Iniciar()
        {
            User1 = new UserControl1();
            this.panelContenedor.Controls.Clear();
            this.panelContenedor.Controls.Add(User1);
        }

        private void ribbon1_Click(object sender, EventArgs e)
        {
            
        }

        private void ribbon2_Click(object sender, EventArgs e)
        {
        }
        private void ribbon3_Click(object sender, EventArgs e)
        {            
        }


        private void ribbonButton1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Prueba 1", "Prueba 1xxx",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {

            Form FrmacfMARt_Marca = new FrmacfMARt_Marca();
            FrmacfMARt_Marca.ShowDialog();
        }
        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            Form FrmacfUNMt_Unimed = new FrmacfUNMt_Unimed();
            FrmacfUNMt_Unimed.ShowDialog();
        }
        private void ribbonButton3_Click(object sender, EventArgs e)
        {
            Form FrmacfINVp_Inventario = new FrmacfINVp_Inventario();
            FrmacfINVp_Inventario.ShowDialog();
        }
        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            Form FrmacfACFp_Activo_Fijo = new FrmacfACFp_Activo_Fijo();
            FrmacfACFp_Activo_Fijo.ShowDialog();
        }
        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            Form FrmbdiXPEpExtraccionSAP_Personal = new FrmbdiXPEpExtraccionSAP_Personal();
            FrmbdiXPEpExtraccionSAP_Personal.ShowDialog();
        }
        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            Form FrmbdiPRVpProveedor = new FrmbdiPRVpProveedor();
            FrmbdiPRVpProveedor.ShowDialog();
        }
        private void ribbonButton8_Click(object sender, EventArgs e)
        {
            Form FrmacfCSTt_Costo = new FrmacfCSTt_Costo();
            FrmacfCSTt_Costo.ShowDialog();
        }
        private void ribbonButton9_Click(object sender, EventArgs e)
        {
            Form FrmacfVNRt_VNR = new FrmacfVNRt_VNR();
            FrmacfVNRt_VNR.ShowDialog();
        }
        private void ribbonButton35_Click(object sender, EventArgs e)
        {
            Form FrmacfESTt_Estado = new FrmacfESTt_Estado();
            FrmacfESTt_Estado.ShowDialog();
        }
        private void ribbonButton36_Click(object sender, EventArgs e)
        {
            Form FrmbdiCDDpClasesDeDocumento = new FrmbdiCDDpClasesDeDocumento();
            FrmbdiCDDpClasesDeDocumento.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        private void ribbonOrbMenuItem2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
