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
    public partial class Frm_InventarioCerrar : KryptonForm
    {
        public Frm_InventarioCerrar()
        {
            InitializeComponent();
            CargarCombos();
        }

        private void CargarCombos()
        {


            this.cboINV.DataSource = NacfINVp_Inventario.Mostrar(); //INVid
            this.cboINV.ValueMember = "INVid";
            this.cboINV.DisplayMember = "INVid";
            this.cboINV.SelectedIndex = -1;

        }

        private void mostrar(string iINVid)
        {
            this.datalistado1.DataSource = NacfINBt_Inventariobienes.conciliarinvent(iINVid);
            /* if (datalistado.Rows.Count == 0)
             {
                 BotonesSinReg(false);
             }
             else
             {
                 BotonesSinReg(true);
                 this.toolStripAgregar.Enabled = true;

             }
             this.datalistado.Select();
             this.datalistado.Focus();*/


        }

        private void Frm_InventarioCerrar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public DataGridViewRow ObtenerSeleccion()
        {
            DataGridViewRow filaSeleccionada = this.datalistado1.Rows[this.datalistado1.CurrentRow.Index];
            return filaSeleccionada;
        }
        private void datalistado1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string variableid;
            variableid = Convert.ToString(this.ObtenerSeleccion().Cells[1].Value);
            //MessageBox.Show(variableid);
            mostraracf(variableid);
            mostrarinv(variableid);
        }

        private void mostraracf(string variableid)
        {
            try
            {
                DataTable dat = NacfCRSt_Caracteristicas.mostrarconciliar(variableid);
                //DataTable dat = NacfINVp_Inventario.Next(iINVid);
                //MessageBox.Show(variableid);
                if (dat.Rows.Count > 0)
                {
                    //MessageBox.Show(variableid);
                    DataRow row = dat.Rows[0];
                    //características
                    txtacfserie.Text = Convert.ToString(row["CRSserie"]);
                    txtacfmarca.Text = Convert.ToString(row["MARid"]);
                    txtacfmodelo.Text = Convert.ToString(row["CRSmodelo"]);
                    txtacfcantidad.Text = Convert.ToString(row["CRScantidad"]);
                    txtacfunidad.Text = Convert.ToString(row["UNMid"]);
                    //electrico
                    txtacfgis.Text = Convert.ToString(row["UBEcodigogis"]);
                    txtacfelectrico.Text = Convert.ToString(row["SELid"]);
                    txtacfset.Text = Convert.ToString(row["UBEsetetq"]);
                    txtacfalimentador.Text = Convert.ToString(row["UBEalimentadoretq"]);
                    txtacfsed.Text = Convert.ToString(row["UBEsedetq"]);
                    txtacfcircuito.Text = Convert.ToString(row["UBEcircuitoetq"]);
                    txtacfinicio.Text = Convert.ToString(row["UBEpuntoietq"]);
                    txtacffin.Text = Convert.ToString(row["UBEpuntofetq"]);
                    //terrenos y edificaciones
                    txtacffichapredio.Text = Convert.ToString(row["CRSfinscpredio"]);
                    txtacfficharegistral.Text = Convert.ToString(row["CRSficharegistral"]);
                    txtacfareaconstruida.Text = Convert.ToString(row["CRSareaconstruida"]);
                    txtacfperimetro.Text = Convert.ToString(row["CRSperimetro"]);
                    txtacfusopredio.Text = Convert.ToString(row["CRSusopredio"]);
                    //vehículos
                    txtacfplaca.Text = Convert.ToString(row["CRSvehplaca"]);
                    txtacfexpediente.Text = Convert.ToString(row["CRSvehexpediente"]);
                    txtacfinscripcion.Text = Convert.ToString(row["CRSvehinscripcion"]);
                    txtacfclase.Text = Convert.ToString(row["CRSvehclase"]);
                    txtacfcombustible.Text = Convert.ToString(row["CRSvehcombustible"]);
                    txtacfejes.Text = Convert.ToString(row["CRSvehejes"]);
                    txtacfpasajeros.Text = Convert.ToString(row["CRSvehpasajeros"]);
                    txtacfasientos.Text = Convert.ToString(row["CRSvehasientos"]);
                    txtacfpeso.Text = Convert.ToString(row["CRSvehpesoseco"]);
                    txtacfcarga.Text = Convert.ToString(row["CRSvehcargautil"]);
                    txtacfaltura.Text = Convert.ToString(row["CRSaltura"]);
                    txtacfancho.Text = Convert.ToString(row["CRSancho"]);
                    //equipos
                    txtacfvelocidad.Text = Convert.ToString(row["CRSvelocidad"]);
                    txtacfresolucion.Text = Convert.ToString(row["CRSresolucion"]);
                    txtacfcapacidad.Text = Convert.ToString(row["CRScapacidad"]);
                    txtacfpotencia.Text = Convert.ToString(row["CRSpotencia"]);
                    txtacfnominal.Text = Convert.ToString(row["CRSvnominal"]);
                    txtacfentrada.Text = Convert.ToString(row["CRSventrada"]);
                    txtacfsalida.Text = Convert.ToString(row["CRSvsalida"]);
                    txtacffrecuencia.Text = Convert.ToString(row["CRSfrecuencia"]);
                    txtacftemperatura.Text = Convert.ToString(row["CRStemperatura"]);
                    txtacfprocesador.Text = Convert.ToString(row["CRSprocesador"]);
                    txtacfpuertos.Text = Convert.ToString(row["CRSpuertos"]);
                }
                else
                    MessageBox.Show("No Existe", "Registro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void mostrarinv(string variableid)
        {
            try
            {
                //DataTable dat = NacfCRSt_Caracteristicas.mostrarconciliar(variableid);
                DataTable dat = NacfICRt_Inventariocaracteristicas.mostrarconciliar(variableid);
                //MessageBox.Show(variableid);
                if (dat.Rows.Count > 0)
                {
                    //MessageBox.Show(variableid);
                    DataRow row = dat.Rows[0];
                    //características
                    txtinvserie.Text = Convert.ToString(row["CRSserie"]);
                    txtinvmarca.Text = Convert.ToString(row["MARid"]);
                    txtinvmodelo.Text = Convert.ToString(row["CRSmodelo"]);
                    txtinvcantidad.Text = Convert.ToString(row["CRScantidad"]);
                    txtinvunidad.Text = Convert.ToString(row["UNMid"]);
                    //electrico
                    txtinvgis.Text = Convert.ToString(row["UBEcodigogis"]);
                    txtinvelectrico.Text = Convert.ToString(row["SELid"]);
                    txtinvset.Text = Convert.ToString(row["UBEsetetq"]);
                    txtinvalimentador.Text = Convert.ToString(row["UBEalimentadoretq"]);
                    txtinvsed.Text = Convert.ToString(row["UBEsedetq"]);
                    txtinvcircuito.Text = Convert.ToString(row["UBEcircuitoetq"]);
                    txtinvinicio.Text = Convert.ToString(row["UBEpuntoietq"]);
                    txtinvfin.Text = Convert.ToString(row["UBEpuntofetq"]);
                    //terrenos y edificaciones
                    txtinvfichapredio.Text = Convert.ToString(row["CRSfinscpredio"]);
                    txtinvficharegistral.Text = Convert.ToString(row["CRSficharegistral"]);
                    txtinvareaconstruida.Text = Convert.ToString(row["CRSareaconstruida"]);
                    txtinvperimetro.Text = Convert.ToString(row["CRSperimetro"]);
                    txtinvusopredio.Text = Convert.ToString(row["CRSusopredio"]);
                    //vehículos
                    txtinvplaca.Text = Convert.ToString(row["CRSvehplaca"]);
                    txtinvexpediente.Text = Convert.ToString(row["CRSvehexpediente"]);
                    txtinvinscripcion.Text = Convert.ToString(row["CRSvehinscripcion"]);
                    txtinvclase.Text = Convert.ToString(row["CRSvehclase"]);
                    txtinvcombustible.Text = Convert.ToString(row["CRSvehcombustible"]);
                    txtinvejes.Text = Convert.ToString(row["CRSvehejes"]);
                    txtinvpasajeros.Text = Convert.ToString(row["CRSvehpasajeros"]);
                    txtinvasientos.Text = Convert.ToString(row["CRSvehasientos"]);
                    txtinvpeso.Text = Convert.ToString(row["CRSvehpesoseco"]);
                    txtinvcarga.Text = Convert.ToString(row["CRSvehcargautil"]);
                    txtinvaltura.Text = Convert.ToString(row["CRSaltura"]);
                    txtinvancho.Text = Convert.ToString(row["CRSancho"]);
                    //equipos
                    txtinvvelocidad.Text = Convert.ToString(row["CRSvelocidad"]);
                    txtinvresolucion.Text = Convert.ToString(row["CRSresolucion"]);
                    txtinvcapacidad.Text = Convert.ToString(row["CRScapacidad"]);
                    txtinvpotencia.Text = Convert.ToString(row["CRSpotencia"]);
                    txtinvnominal.Text = Convert.ToString(row["CRSvnominal"]);
                    txtinventrada.Text = Convert.ToString(row["CRSventrada"]);
                    txtinvsalida.Text = Convert.ToString(row["CRSvsalida"]);
                    txtinvfrecuencia.Text = Convert.ToString(row["CRSfrecuencia"]);
                    txtinvtemperatura.Text = Convert.ToString(row["CRStemperatura"]);
                    txtinvprocesador.Text = Convert.ToString(row["CRSprocesador"]);
                    txtinvpuertos.Text = Convert.ToString(row["CRSpuertos"]);
                }
                else
                    MessageBox.Show("No Existe", "Registro");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Control del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Control del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("No Existe", "Registro");
            string Rta = string.Empty;
            MessageBox.Show("Cerrando Inventario");
            try
            {
                foreach (DataGridViewRow row in datalistado1.Rows)
                {
                    Rta = NacfICRt_Inventariocaracteristicas.CerrarInventario(
                     //this.datalistado1.CurrentRow.Cells[0].Value.ToString()
                     this.datalistado1.CurrentRow.Cells[1].Value.ToString()// ACFid
                    , this.txtinvserie.Text //CRSserie
                    , this.txtinvmarca.Text // MARid
                    //, this.txtinvelectrico.Text //ESTid
                    , this.txtinvmodelo.Text //CRSmodelo
                    , this.txtinvunidad.Text //UNMid 
                    , this.txtinvcantidad.Text //CRScantidad
                    , this.txtinvplaca.Text //CRSvehplaca
                    , this.txtinvexpediente.Text //CRSvehexpediente
                    , this.txtinvinscripcion.Text //CRSvehinscripcion
                    , this.txtinvclase.Text //CRSvehclase
                    , this.txtinvcombustible.Text //CRSvehcombustible
                    , this.txtinvclase.Text //CRSvehejes
                    , this.txtinvpasajeros.Text //CRSvehpasajeros
                    , this.txtinvasientos.Text //CRSvehasientos
                    , this.txtinvpeso.Text //CRSvehpesoseco
                    , this.txtinvcarga.Text //CRSvehcargautil
                    , this.txtinvaltura.Text //CRSaltura 
                    , this.txtinvancho.Text //CRSancho
                    , this.txtinvvelocidad.Text //CRSvelocidad
                    , this.txtinvresolucion.Text //CRSresolucion
                    , this.txtinvcapacidad.Text //CRScapacidad
                    , this.txtinvpotencia.Text //CRSpotencia
                    , this.txtinvnominal.Text //CRSvnominal 
                    , this.txtinventrada.Text //RSventrada
                    , this.txtinvsalida.Text //CRSvsalida
                    , this.txtinvfrecuencia.Text //CRSfrecuencia
                    , this.txtinvtemperatura.Text //CRStemperatura
                    , this.txtinvprocesador.Text //CRSprocesador
                    , this.txtinvpuertos.Text //CRSpuertos
                    , this.txtinvfichapredio.Text //CRSfinscpredio
                    , this.txtinvficharegistral.Text //CRSficharegistral
                    , this.txtinvareaconstruida.Text //CRSareaconstruida
                    , this.txtinvperimetro.Text //CRSperimetro
                    , this.txtinvusopredio.Text //CRSusopredio

                  );

                    if (Rta.Equals("OK"))
                    {
                        this.MensajeOk("Proceso Terminado Correctamente");
                        mostrar(cboINV.Text);
                    }
                    else
                    {
                        this.MensajeError("Error al Cerrar Inventario:" + Rta);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("prueba", "prueba");
            mostrar(cboINV.Text);
        }
    }
}
