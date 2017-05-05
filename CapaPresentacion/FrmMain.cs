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
        {         }

        private void ribbon2_Click(object sender, EventArgs e)
        {        }
        private void ribbon3_Click(object sender, EventArgs e)
        {                    }
        
        private void ribbonButton1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Prueba 1", "Prueba 1xxx",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }        
        private void ribbonButton11_Click(object sender, EventArgs e)
        {
            Form FrmMovimiento_Transferencia_Activo = new FrmMovimiento_Transferencia_Activo();
            FrmMovimiento_Transferencia_Activo.ShowDialog();
        }        
        private void ribbonButton12_Click(object sender, EventArgs e)
        {
            Form FrmacfACFp_Activo_Fijo = new FrmacfACFp_Activo_Fijo();
            FrmacfACFp_Activo_Fijo.ShowDialog();
        }
                
        private void ribbonButton65_Click(object sender, EventArgs e)
        {
            Form FrmacfINVp_Inventario = new FrmacfINVp_Inventario();
            FrmacfINVp_Inventario.ShowDialog();
        }
        private void ribbonButton66_Click(object sender, EventArgs e)
        {
            Form FrmbdiCAFpClaseDeActivoFijo = new FrmbdiCAFpClaseDeActivoFijo();
            FrmbdiCAFpClaseDeActivoFijo.ShowDialog();
        }
        private void ribbonButton67_Click(object sender, EventArgs e)
        {
            Form FrmbdiCDDpClasesDeDocumento = new FrmbdiCDDpClasesDeDocumento();
            FrmbdiCDDpClasesDeDocumento.ShowDialog();
        }
        private void ribbonButton68_Click(object sender, EventArgs e)
        {
            Form FrmbdiPRVpProveedor = new FrmbdiPRVpProveedor();
            FrmbdiPRVpProveedor.ShowDialog();
        }
        private void ribbonButton69_Click(object sender, EventArgs e)
        {
            Form FrmbdiSEGpSegmento = new FrmbdiSEGpSegmento();
            FrmbdiSEGpSegmento.ShowDialog();
        }
        private void ribbonButton70_Click(object sender, EventArgs e)
        {
            Form FrmbdiSOCpSociedades = new FrmbdiSOCpSociedades();
            FrmbdiSOCpSociedades.ShowDialog();
        }
        private void ribbonButton71_Click(object sender, EventArgs e)
        {
            Form FrmbdiXCCpExtraccionSAP_CentroCosto = new FrmbdiXCCpExtraccionSAP_CentroCosto();
            FrmbdiXCCpExtraccionSAP_CentroCosto.ShowDialog();
        }
        private void ribbonButton72_Click(object sender, EventArgs e)
        {
            Form FrmbdiXPEpExtraccionSAP_Personal = new FrmbdiXPEpExtraccionSAP_Personal();
            FrmbdiXPEpExtraccionSAP_Personal.ShowDialog();
        }

        private void rbtn1_Click(object sender, EventArgs e)
        {
            //Form FrmacfACTt_Actividad = new FrmacfACTt_Actividad();
            //FrmacfACTt_Actividad.ShowDialog();
        }
        private void rbtn2_Click(object sender, EventArgs e)
        {
            Form FrmacfAMBt_Ambiente = new FrmacfAMBt_Ambiente();
            FrmacfAMBt_Ambiente.ShowDialog();
        }
        private void rbtn3_Click(object sender, EventArgs e)
        {
            Form FrmacfCMPt_Componente = new FrmacfCMPt_Componente();
            FrmacfCMPt_Componente.ShowDialog();
        }
        private void rbtn4_Click(object sender, EventArgs e)
        {
            Form FrmacfCRSt_Caracteristicas = new FrmacfCRSt_Caracteristicas();
            FrmacfCRSt_Caracteristicas.ShowDialog();
        }
        private void rbtn5_Click(object sender, EventArgs e)
        {
            Form FrmacfCSTt_Costo = new FrmacfCSTt_Costo();
            FrmacfCSTt_Costo.ShowDialog();
        }
        private void rbtn6_Click(object sender, EventArgs e)
        {
            Form FrmacfDDFt_detalledediferido = new FrmacfDDFt_detalledediferido();
            FrmacfDDFt_detalledediferido.ShowDialog();
        }
        private void rbtn7_Click(object sender, EventArgs e)
        {
            Form FrmacfDRTt_detallereparotributario = new FrmacfDRTt_detallereparotributario();
            FrmacfDRTt_detallereparotributario.ShowDialog();
        }
        private void rbtn8_Click(object sender, EventArgs e)
        {
            Form FrmacfEDIt_edificaciondetalle = new FrmacfEDIt_edificaciondetalle();
            FrmacfEDIt_edificaciondetalle.ShowDialog();
        }
        private void rbtn9_Click(object sender, EventArgs e)
        {
            Form FrmacfESTt_Estado = new FrmacfESTt_Estado();
            FrmacfESTt_Estado.ShowDialog();
        }
        private void rbtn10_Click(object sender, EventArgs e)
        {
            Form FrmacfICRt_Inventariocaracteristicas = new FrmacfICRt_Inventariocaracteristicas();
            FrmacfICRt_Inventariocaracteristicas.ShowDialog();
        }
        private void rbtn11_Click(object sender, EventArgs e)
        {
            Form FrmacfINBt_Inventariobienes = new FrmacfINBt_Inventariobienes();
            FrmacfINBt_Inventariobienes.ShowDialog();
        }
        private void rbtn12_Click(object sender, EventArgs e)
        {
            Form FrmacfINVp_Inventario = new FrmacfINVp_Inventario();
            FrmacfINVp_Inventario.ShowDialog();
        }
        private void rbtn13_Click(object sender, EventArgs e)
        {
            Form FrmacfLOCt_Local = new FrmacfLOCt_Local();
            FrmacfLOCt_Local.ShowDialog();
        }
        private void rbtn14_Click(object sender, EventArgs e)
        {
            Form FrmacfMARt_Marca = new FrmacfMARt_Marca();
            FrmacfMARt_Marca.ShowDialog();
        }
        private void rbtn15_Click(object sender, EventArgs e)
        {
            Form FrmacfMATt_Material = new FrmacfMATt_Material();
            FrmacfMATt_Material.ShowDialog();
        }
        private void rbtn16_Click(object sender, EventArgs e)
        {
            Form FrmacfMEQt_maquinariaequipo = new FrmacfMEQt_maquinariaequipo();
            FrmacfMEQt_maquinariaequipo.ShowDialog();
        }
        private void rbtn17_Click(object sender, EventArgs e)
        {
            Form FrmacfMVAt_MovimientoActivo = new FrmacfMVAt_MovimientoActivo();
            FrmacfMVAt_MovimientoActivo.ShowDialog();
        }
        private void rbtn18_Click(object sender, EventArgs e)
        {
            Form FrmacfMVMt_MotivoMovimiento = new FrmacfMVMt_MotivoMovimiento();
            FrmacfMVMt_MotivoMovimiento.ShowDialog();
        }
        private void rbtn19_Click(object sender, EventArgs e)
        {
            Form FrmacfPDFt_procesodiferido = new FrmacfPDFt_procesodiferido();
            FrmacfPDFt_procesodiferido.ShowDialog();
        }
        private void rbtn20_Click(object sender, EventArgs e)
        {
            Form FrmacfRTRt_Reparotributario = new FrmacfRTRt_Reparotributario();
            FrmacfRTRt_Reparotributario.ShowDialog();
        }
        private void rbtn21_Click(object sender, EventArgs e)
        {
            Form FrmacfRVAt_registrovaluacion = new FrmacfRVAt_registrovaluacion();
            FrmacfRVAt_registrovaluacion.ShowDialog();
        }
        private void rbtn22_Click(object sender, EventArgs e)
        {
            Form FrmacfSELt_SistemaElectrico = new FrmacfSELt_SistemaElectrico();
            FrmacfSELt_SistemaElectrico.ShowDialog();
        }
        private void rbtn23_Click(object sender, EventArgs e)
        {
            Form FrmacfSPNt_Supranumero = new FrmacfSPNt_Supranumero();
            FrmacfSPNt_Supranumero.ShowDialog();
        }
        private void rbtn24_Click(object sender, EventArgs e)
        {
            Form FrmacfTMVt_TipoMovimiento = new FrmacfTMVt_TipoMovimiento();
            FrmacfTMVt_TipoMovimiento.ShowDialog();
        }
        private void rbtn25_Click(object sender, EventArgs e)
        {
            Form FrmacfTRNt_terrenodetallecs = new FrmacfTRNt_terrenodetallecs();
            FrmacfTRNt_terrenodetallecs.ShowDialog();
        }
        private void rbtn26_Click(object sender, EventArgs e)
        {
            Form FrmacfUBEt_UbicacionElectrica = new FrmacfUBEt_UbicacionElectrica();
            FrmacfUBEt_UbicacionElectrica.ShowDialog();
        }
        private void rbtn27_Click(object sender, EventArgs e)
        {
            Form FrmacfUNMt_Unimed = new FrmacfUNMt_Unimed();
            FrmacfUNMt_Unimed.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void ribbonOrbMenuItem2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ribbonButton41_Click(object sender, EventArgs e)
        {
            Form Frm_InventarioG = new Frm_InventarioG();
            Frm_InventarioG.Show();
        }

        private void ribbonButton58_Click(object sender, EventArgs e)
        {
            Form Frm_RegistroInventario = new Frm_RegistroInventario();
            Frm_RegistroInventario.ShowDialog();
        }

        private void ribbonButton59_Click(object sender, EventArgs e)
        {
            Form Frm_ConciliarInventario = new Frm_ConciliarInventario();
            Frm_ConciliarInventario.ShowDialog();
        }
    }
}
