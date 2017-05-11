using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using CapaNegocio;


namespace CapaPresentacion
{       
    public partial class Frm_RegistroInventario : KryptonForm
    {
        private static Frm_InventarioG _Instancia;

        public static Frm_InventarioG GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new Frm_InventarioG();
            }
            return _Instancia;
        }


        public Frm_RegistroInventario()
        {
            InitializeComponent();
            CargarCombos();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarRegistro(this.txtACFid.Text);
            
        }
        private void CargarCombos()
        {
           this.cboPERNR.DataSource = NbdiXPEpExtraccionSAP_Personal.Mostrar(); //BURkS
          this.cboPERNR.ValueMember = "PERNR";
           this.cboPERNR.DisplayMember = "PERNR";
           this.cboPERNR.SelectedIndex = -1;

           this.cboCSTid.DataSource = NacfCSTt_Costo.Mostrar(); //BURkS
           this.cboCSTid.ValueMember = "CSTid";
           this.cboCSTid.DisplayMember = "CSTid";
           this.cboCSTid.SelectedIndex = -1;

           this.cboVNRid.DataSource = NacfVNRt_VNR.Mostrar(); //BURkS
           this.cboVNRid.ValueMember = "VNRid";
           this.cboVNRid.DisplayMember = "VNRid";
           this.cboVNRid.SelectedIndex = -1;

           this.cboACTid.DataSource = NacfACTt_Actividad.Mostrar(); //BURkS
           this.cboACTid.ValueMember = "ACTid";
           this.cboACTid.DisplayMember = "ACTid";
           this.cboACTid.SelectedIndex = -1;

           this.cboSELid.DataSource = NacfSELt_SistemaElectrico.Mostrar(); //BURkS
           this.cboSELid.ValueMember = "SELid";
           this.cboSELid.DisplayMember = "SELid";
           this.cboSELid.SelectedIndex = -1;

           this.cboSETid.DataSource = NacfUBEt_UbicacionElectrica.Mostrar(); //BURkS
           this.cboSETid.ValueMember = "UBEset";
           this.cboSETid.DisplayMember = "UBEset";
           this.cboSETid.SelectedIndex = -1;

           this.cboMARid.DataSource = NacfMARt_Marca.Mostrar(); //BURkS
           this.cboMARid.ValueMember = "MARid";
           this.cboMARid.DisplayMember = "MARid";
           this.cboMARid.SelectedIndex = -1;

           this.cboUNMid.DataSource = NacfUNMt_Unimed.Mostrar(); //BURkS
           this.cboUNMid.ValueMember = "UNMid";
           this.cboUNMid.DisplayMember = "UNMid";
           this.cboUNMid.SelectedIndex = -1;
        }
        private void MostrarRegistro(String ACFid)
        {

            try
            {
                DataTable dat = NacfINBt_Inventariobienes.Buscar(ACFid);
                   
              
                //ACFdescripcion.Text= dat.Rows[0]["ACFdescripcion"].ToString();

                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];
                    cboACTid.Text = Convert.ToString(row["ACTid"]);
                    txtACFdescripcion.Text = Convert.ToString(row["ACFactivo"]);
                    txtACFobservacion.Text = Convert.ToString(row["ACFobservacion"]);
                    cboVNRid.Text = Convert.ToString(row["VNRid"]);
                    txtUBEid1.Text = Convert.ToString(row["UBEid"]);
                    cboCSTid.Text = Convert.ToString(row["CSTid"]);
                    cboPERNR.Text = Convert.ToString(row["PERNR"]);
                    txtACFobra.Text = Convert.ToString(row["ACFobra"]);
                    txtINBbukrs.Text = Convert.ToString(row["BUKRS"]);
                    
               
                }
                else
                    MessageBox.Show("No Existe", "Registro");

                DataTable datt = NacfICRt_Inventariocaracteristicas.Buscar(ACFid);
                    if(datt.Rows.Count > 0)
                    {
                        DataRow row = datt.Rows[0];
                        
                        cboMARid.Text = Convert.ToString(row["MARid"]);
                        txtCRSserie.Text = Convert.ToString(row["CRSserie"]);
                        txtCRSmodelo.Text = Convert.ToString(row["CRSmodelo"]);
                        txtESTid.Text = Convert.ToString(row["ESTid"]);
                        txtCRSobservacion.Text = Convert.ToString(row["CRSobservacion"]);
                        txtCRScantidad.Text = Convert.ToString(row["CRScantidad"]);
                        cboUNMid.Text = Convert.ToString(row["UNMid"]);
                    }
                else
                    MessageBox.Show("No Existe", "Registro");

                    DataTable dattt = NacfUBEt_UbicacionElectrica.Buscar(ACFid);
                if(datt.Rows.Count > 0)
                {
                    DataRow row = dattt.Rows[0];

                    txtUBEgis.Text = Convert.ToString(row["UBEcodigogis"]);
                    cboSELid.Text = Convert.ToString(row["SELid"]);
                    cboSETid.Text = Convert.ToString(row["UBEset"]);
                    txtUBEsetetq.Text = Convert.ToString(row["UBEsetetq"]);
                    txtUBEalimentador.Text = Convert.ToString(row["UBEalimentador"]);
                    txtUBEsed.Text = Convert.ToString(row["UBEsed"]);
                    txtUBEcircuito.Text = Convert.ToString(row["UBEcircuito"]);
                    txtUBEpuntoi.Text = Convert.ToString(row["UBEpuntoi"]);
                    txtUBEpuntoi.Text = Convert.ToString(row["UBEpuntof"]);
                    
                    
                    //Agregar tabla detalle
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Control Escolar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Control Escolar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ActualizaRegistro()
        {
            string Rta = string.Empty;
            try
            {
                Rta = NacfICRt_Inventariocaracteristicas.Editar2(
                    this.txtACFid.Text,
                    this.cboMARid.Text,
                    this.txtCRSserie.Text);

                if (Rta.Equals("OK"))
                {
                    this.MensajeOk("Registro Actualizado Correctamente");
                }
                else
                {
                    this.MensajeError("Error al Actualizar Registro ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPERNR_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVNR_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ActualizaRegistro();
        }
    }

}
