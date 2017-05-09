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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarRegistro(this.txtACFid.Text);
            
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
                    txtACTid.Text = Convert.ToString(row["ACTid"]);
                    txtACFobservacion.Text = Convert.ToString(row["ACFactivo"]);
                    txtACFdescripcion.Text = Convert.ToString(row["ACFobservacion"]);
                    txtVNRid.Text = Convert.ToString(row["VNRid"]);
                    txtUBEid2.Text = Convert.ToString(row["UBEid"]);
                    txtCSTid.Text = Convert.ToString(row["CSTid"]);
                    txtPERNR.Text = Convert.ToString(row["PERNR"]);
                    txtACFobservacion.Text = Convert.ToString(row["ACFobservacion"]);
                    txtACFobra.Text = Convert.ToString(row["ACFobra"]);
                    txtINBbukrs.Text = Convert.ToString(row["BUKRS"]);

               
                }
                else
                    MessageBox.Show("No Existe", "Registro");

                DataTable datt = NacfICRt_Inventariocaracteristicas.Buscar(ACFid);
                    if(datt.Rows.Count > 0)
                    {
                        DataRow row = datt.Rows[0];
                        
                        txtMARid.Text = Convert.ToString(row["MARid"]);
                        txtCRSserie.Text = Convert.ToString(row["CRSserie"]);
                        txtCRSmodelo.Text = Convert.ToString(row["CRSmodelo"]);
                        txtESTid.Text = Convert.ToString(row["ESTid"]);
                        txtCRSobservacion.Text = Convert.ToString(row["CRSobservacion"]);
                    }
                else
                    MessageBox.Show("No Existe", "Registro");

                    DataTable dattt = NacfUBEt_UbicacionElectrica.Buscar(ACFid);
                if(datt.Rows.Count > 0)
                {
                    DataRow row = dattt.Rows[0];

                    txtUBEgis.Text = Convert.ToString(row["UBEcodigogis"]);
                    txtSELid.Text = Convert.ToString(row["SELid"]);
                    txtUBEset.Text = Convert.ToString(row["UBEset"]);
                    txtUBEsetetq.Text = Convert.ToString(row["UBEsetetq"]);
                    txtUBEalimentador.Text = Convert.ToString(row["UBEalimentador"]);
                    txtUBEsed.Text = Convert.ToString(row["UBEsed"]);
                    txtUBEcircuito.Text = Convert.ToString(row["UBEcircuito"]);
                    txtUBEpuntoi.Text = Convert.ToString(row["UBEpuntoi"]);
                    txtUBEpuntoi.Text = Convert.ToString(row["UBEpuntof"]);
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
    }

}
