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
            Form FrmbdiXPEpExtraccionSAP_Personal = new FrmbdiXPEpExtraccionSAP_Personal();
            FrmbdiXPEpExtraccionSAP_Personal.Show();

            //MessageBox.Show("Prueba 2", "Prueba 2xxx",
            //MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }
        private void ribbon3_Click(object sender, EventArgs e)
        {
            Form FrmacfMVMt_MotivoMovimiento = new FrmacfMVMt_MotivoMovimiento();
            FrmacfMVMt_MotivoMovimiento.Show();

            //MessageBox.Show("Prueba 2", "Prueba 2xxx",
            //MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }


        private void ribbonButton1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Prueba 1", "Prueba 1xxx",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            Form FrmPostres = new FrmPostres();
            FrmPostres.ShowDialog();

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
