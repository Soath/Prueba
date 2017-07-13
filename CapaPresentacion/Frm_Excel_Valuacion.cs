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

    public partial class Frm_Excel_Valuacion : Form
    {

        public Frm_Excel_Valuacion()
        {
            InitializeComponent();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        public enum CurrentStatus
        {
            None,
            Reset,
            Loading,
            Cancelled,
            Success,
            Busy
        }

        //used throughout the form to track application status
        CurrentStatus processingStatus = CurrentStatus.None;

        /// <summary>
        /// changes the interface based on current status (processingStatus)
        /// </summary>
        void setFormControlsBasedOnStatus()
        {
            switch (processingStatus)
            {
                case CurrentStatus.None:
                    break;
                case CurrentStatus.Reset:
                    toolStripAnterior.Enabled = true;
                    lblLoadingStatus.Visible = false;
                    lblLoadingStatus.Text = "Procesando...";
                    pbLoadingGraphic.Visible = false;
                    prgLoadingProgress.Value = 0;
                    break;

                case CurrentStatus.Loading:
                    toolStripAnterior.Enabled = false;
                    lblLoadingStatus.Visible = true;
                    lblLoadingStatus.Text = "Procesnado...";
                    pbLoadingGraphic.Visible = true;
                    prgLoadingProgress.Value = 0;
                    break;

                case CurrentStatus.Cancelled:
                    toolStripAnterior.Enabled = true;
                    lblLoadingStatus.Visible = true;
                    lblLoadingStatus.Text = "Cancelled";
                    pbLoadingGraphic.Visible = false;
                    prgLoadingProgress.Value = 0;
                    break;

                case CurrentStatus.Success:
                    toolStripAnterior.Enabled = true;
                    lblLoadingStatus.Visible = true;
                    lblLoadingStatus.Text = "Finalizado!";
                    pbLoadingGraphic.Visible = false;
                    prgLoadingProgress.Value = 0;
                    break;

                case CurrentStatus.Busy:
                    toolStripAnterior.Enabled = true;
                    lblLoadingStatus.Visible = true;
                    lblLoadingStatus.Text = "En proceso";
                    pbLoadingGraphic.Visible = false;
                    prgLoadingProgress.Value = 0;
                    break;

                default:
                    break;
            }

        }

        /// <summary>
        /// see if the user wants to cancel the background worker
        /// </summary>
        /// <param name="worker">the worker</param>
        /// <param name="e">worker status</param>
        /// <returns>used to tell the caller to exit or not</returns>
        bool isWorkerBeingCancelled(BackgroundWorker worker, DoWorkEventArgs e)
        {
            bool returnValue = false;

            if (worker.CancellationPending == true)
            {
                e.Cancel = true;
                returnValue = true;
                processingStatus = CurrentStatus.Cancelled;
            }

            return returnValue;
        }

        /// <summary>
        /// background worker processing step
        /// </summary>
        /// <param name="sender">worker instance</param>
        /// <param name="e">current status</param>
        private void Importar()
        {
            if (txtHoja.Text == string.Empty)
            {
                MessageBox.Show("Inserte el nombre de la HOJA");
            }
            else
            {
                try
                {

                    string hoja;
                    hoja = txtHoja.Text;
                    new Importar().importarExcelca(this.textRuta.Text.Trim(), dataListado, hoja, true);
                    lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void Frm_Excel_Valuacion_Load(object sender, EventArgs e)
        {
            dataListado.AllowUserToAddRows = false;
        }


        private void BotonesIE(bool edo)
        {
            // this.toolStripRefrescar.Visible = !edo;
            this.toolStripAnterior.Visible = !edo;
            this.toolStripAgregar.Visible = edo;
            this.toolStripEditar.Visible = edo;
            this.toolStripCancelar.Visible = edo;
            this.toolStripSiguiente.Visible = edo;
        }
        private void grabarseleCentroCosto()
        {
            try
            {
                //falta mostrar el ACFid
                Int32 total = 0;
                foreach (DataGridViewRow row in dataListado.Rows)
                {
                    string Rta = string.Empty;

                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        Rta = NbdiXCCpExtraccionSAP_CentroCosto.SAPIMPORT(
                              Convert.ToString(row.Cells[122].Value)//KOSTL
                              );

                        if (Rta.Equals("OK"))
                        {
                            //MessageBox.Show("Datos agregados");
                        }
                        else
                        {
                            //MessageBox.Show("Datos No Agregados");
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void grabarseleVNR()
        {
            try
            {
                //falta mostrar el ACFid
                Int32 total = 0;
                foreach (DataGridViewRow row in dataListado.Rows)
                {
                    string Rta = string.Empty;

                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        Rta = NacfVNRt_VNR.SAPIMPORT(
                              Convert.ToString(row.Cells[16].Value)//VNRid
                              );

                        if (Rta.Equals("OK"))
                        {
                            //MessageBox.Show("Datos agregados");
                        }
                        else
                        {
                            //MessageBox.Show("Datos No Agregados");
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void grabarseleACF()
        {
            try
            {
                //falta mostrar el ACFid
                Int32 total = 0;
                foreach (DataGridViewRow row in dataListado.Rows)
                {
                    string Rta = string.Empty;

                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        Rta = NacfACFp_Activo_Fijo.SAPIMPORT(
                              Convert.ToString(row.Cells[3].Value), //ACFid
                              "0300",// Convert.ToString(row.Cells[6].Value),  // BUKRS
                              "0000000310", //Convert.ToString(row.Cells[7].Value),  //Se trajo del excel de SAP SEGMENT     
                              Convert.ToString(row.Cells[107].Value), //Se trajo del excel de SAP ANLKL ( Id clase activos) 
                              Convert.ToString(row.Cells[9].Value),  //PERNR
                              Convert.ToString(row.Cells[13].Value), //CSTid
                              Convert.ToString(row.Cells[14].Value), //MVMid
                            //"", // ACFfmovimiento en la tabla en blanco
                              Convert.ToString(row.Cells[16].Value),//VNRid
                              Convert.ToString(row.Cells[4].Value), //ACFdescripcion
                              Convert.ToString(row.Cells[15].Value),//ACFfincorporacion
                            //"0", //ACFfcapitalizacion
                              Convert.ToString(row.Cells[43].Value), //ACFvutiltribanio
                              "0", //FORMULA ACFvutiltribdia
                              "0", // ACFvalortrib
                              Convert.ToString(row.Cells[42].Value), //ACFvutilniifanio
                              "0", // FORMULA vutilniifdia
                              Convert.ToString(row.Cells[44].Value), // No se encontro ACFvalorniif
                              "0", //ACFdepacutrib
                              "0", // ACFdepacuniif
                              Convert.ToString(row.Cells[29].Value),//"", // ACFobra
                            //Convert.ToString(row.Cells[130].Value)  , //Se trajo del excel de SAP ACFord41
                            //Convert.ToString(row.Cells[131].Value)  ,//Se trajo del excel de SAP ACFord42
                            //Convert.ToString(row.Cells[132].Value)  ,//Se trajo del excel de SAP ACFord43
                            //Convert.ToString(row.Cells[133].Value)  ,//Se trajo del excel de SAP ACFord44
                              "",//encontro ACFanlue
                            //"", //No se encontro ACFfactortrib
                            //No se encontro ACFfactorniif
                              Convert.ToString(row.Cells[11].Value), //ACFcuenta
                              "",//No se encontro ACFcuentadep
                              "00000",//No se encontro CMPid
                              "",//No se encontro ACFobservacion
                              Convert.ToString(row.Cells[30].Value), //LIFNR
                              Convert.ToString(row.Cells[35].Value),//ACFnotaingreso
                            //Convert.ToString(row.Cells[36].Value),//ACFfechanotaingreso
                              Convert.ToString(row.Cells[38].Value),//ACFordencompra
                              Convert.ToString(row.Cells[39].Value),//ACFfechaordencompra
                              Convert.ToString(row.Cells[31].Value),//BLART
                              Convert.ToString(row.Cells[33].Value),//ACFcomprobante
                              Convert.ToString(row.Cells[122].Value),// "0", Convert.ToString(row.Cells[29].Value),//KOSTL
                              "0",//AMBid
                              "0",//UBEID
                            //Convert.ToString(row.Cells[34].Value),//ACFfechacomprobante
                              "0",  //V_T087U_ANLUE
                              Convert.ToString(row.Cells[2].Value), //ACFtipo_activo
                              "",  //ACFAnulado 
                              "0", // ACFid_Padre
                               Convert.ToString(row.Cells[37].Value), // ACFtipo_orden
                               Convert.ToString(row.Cells[47].Value), // OBJid_objeto
                               Convert.ToString(row.Cells[8].Value), // CRPid_crp
                               Convert.ToString(row.Cells[12].Value) // ACTid
                              );

                        if (Rta.Equals("OK"))
                        {
                            // MessageBox.Show("Datos agregados");
                        }
                        else
                        {
                            //MessageBox.Show("Datos No Agregados");
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void grabarseleCARAC()
        {
            try
            {
                //falta mostrar el ACFid
                Int32 total = 0;
                foreach (DataGridViewRow row in dataListado.Rows)
                {
                    string Rta = string.Empty;

                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        Rta = NacfCRSt_Caracteristicas.SAPIMPORT(
                              Convert.ToString(row.Cells[3].Value), // ACFid
                               "0", // MARid
                               Convert.ToString(row.Cells[52].Value), // ESTid
                               "", // CRSserie
                              Convert.ToString(row.Cells[55].Value), // CRSmodelo
                              Convert.ToString(row.Cells[56].Value), // CRScolor
                              "0", // MATid
                              "", // CRStipo
                              "0", // UNMid
                              Convert.ToString(row.Cells[54].Value), // CRScantidad
                              Convert.ToString(row.Cells[58].Value), // CRSvehplaca
                              Convert.ToString(row.Cells[60].Value), // CRSvehexpediente
                              Convert.ToString(System.DateTime.Today),//Convert.ToString(row.Cells[61].Value), // CRSvehinscripcion
                              Convert.ToString(row.Cells[62].Value), // CRSvehclase
                              Convert.ToString(row.Cells[63].Value), // CRSvehcombustible
                              "0",// Convert.ToString(row.Cells[64].Value), // CRSvehejes
                              "0",// Convert.ToString(row.Cells[65].Value), // CRSvehpasajeros
                              "0",// Convert.ToString(row.Cells[66].Value), // CRSvehasientos
                              "0",// Convert.ToString(row.Cells[67].Value), // CRSvehpesoseco
                              "0",// Convert.ToString(row.Cells[68].Value), // CRSvehcargautil
                              "0",// Convert.ToString(row.Cells[69].Value), // CRSaltura
                              "0",// Convert.ToString(row.Cells[70].Value), // CRSancho
                              Convert.ToString(row.Cells[76].Value), // CRSvelocidad
                              "", // CRSresolucion
                              "", // CRScapacidad
                              Convert.ToString(row.Cells[77].Value), // CRSpotencia
                              Convert.ToString(row.Cells[79].Value), // CRSvnominal
                              Convert.ToString(row.Cells[78].Value), // CRSventrada
                              Convert.ToString(row.Cells[80].Value), // CRSvsalida
                              Convert.ToString(row.Cells[81].Value), // CRSfrecuencia
                              Convert.ToString(row.Cells[82].Value), // CRStemperatura
                              Convert.ToString(row.Cells[83].Value), // CRSprocesador
                              Convert.ToString(row.Cells[84].Value), // CRSpuertos
                              "0",// Convert.ToString(row.Cells[71].Value), // CRSutmx
                              "0",// Convert.ToString(row.Cells[72].Value), // CRSutmy
                              Convert.ToString(row.Cells[73].Value), // CRSesfuerzopunta
                              Convert.ToString(row.Cells[74].Value), // CRScajaderivadora
                              Convert.ToString(row.Cells[75].Value), // CRSalquilacable
                              Convert.ToString(row.Cells[86].Value), // CRScentropoblado
                              Convert.ToString(row.Cells[87].Value), // CRSurbanizacion
                              Convert.ToString(row.Cells[88].Value), // CRScalle
                              Convert.ToString(row.Cells[89].Value), // CRSlote
                              Convert.ToString(row.Cells[90].Value), // CRSnumeropredio
                              Convert.ToString(row.Cells[91].Value), // CRSdepartamento
                              Convert.ToString(row.Cells[92].Value), // CRSinterior
                              Convert.ToString(row.Cells[94].Value), // CRScarretera
                              "0",// Convert.ToString(row.Cells[93].Value), // CRSkilometro
                              Convert.ToString(row.Cells[95].Value), // CRSnombrepredio
                              "0",// Convert.ToString(row.Cells[96].Value), // CRSpisospredio
                              "", // CRSpartidapredio
                              "", // CRStomopredio
                              "", // CRSfolioinipredio
                              "", // CRSfoliofinpredio
                              "", // CRSasientopredio
                              Convert.ToString(System.DateTime.Today),//"", // CRSfinscpredio
                              Convert.ToString(row.Cells[98].Value), // CRSficharegistral
                              "0", // Convert.ToString(row.Cells[103].Value), // CRSareaconstruida
                              "0", // Convert.ToString(row.Cells[104].Value), // CRSperimetro
                              "", // CRSusopredio
                              "0", // CRSvalorautovaluo
                              "", // CRScodigoluz
                              "", // CRScodigoagua
                              Convert.ToString(System.DateTime.Today),//"", // CRSfadqpredio
                              Convert.ToString(row.Cells[85].Value) // CRSobservacion
                            );


                        if (Rta.Equals("OK"))
                        {
                            //MessageBox.Show("Datos agregados");
                        }
                        else
                        {
                            //MessageBox.Show("Datos No Agregados");
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void grabarseleBUIELEC()
        {
            try
            {
                //falta mostrar el ACFid
                Int32 total = 0;
                foreach (DataGridViewRow row in dataListado.Rows)
                {
                    string Rta = string.Empty;

                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        Rta = NacfUBEt_UbicacionElectrica.SAPIMPORT(
                              Convert.ToString(row.Cells[17].Value), // BEcodigogis
                              Convert.ToString(row.Cells[29].Value), // UBEobra     -- proyecto
                              Convert.ToString(row.Cells[122].Value), //"0", // KOSTL
                              Convert.ToString(row.Cells[16].Value), // VNRid 
                              Convert.ToString(row.Cells[19].Value), // SELid 
                              "0", // UBEset
                              Convert.ToString(row.Cells[20].Value), // UBEsetetq
                              "0", // UBEalimentador
                              Convert.ToString(row.Cells[21].Value), // UBEalimentadoretq 
                              "0", // UBEsed 
                              Convert.ToString(row.Cells[22].Value), // UBEsedetq 
                              "0", // UBEcircuito
                              Convert.ToString(row.Cells[23].Value), // UBEcircuitoetq
                              "0", // UBEpuntoi
                              Convert.ToString(row.Cells[27].Value), // UBEpuntoietq
                              "0", // UBEpuntof 
                              Convert.ToString(row.Cells[28].Value), // UBEpuntofetq
                            //"0", // UBEid
                              Convert.ToString(row.Cells[3].Value),  // ACFid  
                              Convert.ToString(row.Cells[18].Value),  // UBIGEO   
                              Convert.ToString(row.Cells[24].Value),  // UBEpostei  
                              Convert.ToString(row.Cells[25].Value)  // UBEpostef  
                            );


                        if (Rta.Equals("OK"))
                        {
                            //MessageBox.Show("Datos agregados");
                        }
                        else
                        {
                            //MessageBox.Show("Datos No Agregados");
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void grabarlote()
        {
            try
            {
                foreach (DataGridViewRow row in dataListado.Rows)
                {
                    string Rta = string.Empty;
                    Rta = NacfACFp_Activo_Fijo.SAPIMPORT(
                                Convert.ToString(row.Cells[3].Value), //ACFid
                                "0300",// Convert.ToString(row.Cells[6].Value),  // BUKRS
                                "0000000310", //Convert.ToString(row.Cells[7].Value),  //Se trajo del excel de SAP SEGMENT     
                                Convert.ToString(row.Cells[107].Value), //Se trajo del excel de SAP ANLKL ( Id clase activos) 
                                Convert.ToString(row.Cells[9].Value),  //PERNR
                                Convert.ToString(row.Cells[13].Value), //CSTid
                                Convert.ToString(row.Cells[14].Value), //MVMid
                        //"", // ACFfmovimiento en la tabla en blanco
                                Convert.ToString(row.Cells[16].Value),//VNRid
                                Convert.ToString(row.Cells[4].Value), //ACFdescripcion
                                Convert.ToString(row.Cells[15].Value),//ACFfincorporacion
                        // "", //ACFfcapitalizacion
                                Convert.ToString(row.Cells[43].Value), //ACFvutiltribanio
                                "0", //FORMULA ACFvutiltribdia
                                "0", // ACFvalortrib
                                Convert.ToString(row.Cells[42].Value), //ACFvutilniifanio
                                "0", // FORMULA vutilniifdia
                                Convert.ToString(row.Cells[44].Value), // No se encontro ACFvalorniif
                                "0", //ACFdepacutrib
                                "0", // ACFdepacuniif
                                Convert.ToString(row.Cells[29].Value),//"", // ACFobra
                        //Convert.ToString(row.Cells[130].Value)  , //Se trajo del excel de SAP ACFord41
                        //Convert.ToString(row.Cells[131].Value)  ,//Se trajo del excel de SAP ACFord42
                        //Convert.ToString(row.Cells[132].Value)  ,//Se trajo del excel de SAP ACFord43
                        //Convert.ToString(row.Cells[133].Value)  ,//Se trajo del excel de SAP ACFord44
                                "",//encontro ACFanlue
                        //"", //No se encontro ACFfactortrib
                        //"", //No se encontro ACFfactorniif
                                Convert.ToString(row.Cells[11].Value), //ACFcuenta
                                "",//No se encontro ACFcuentadep
                                "00000",//No se encontro CMPid
                                Convert.ToString(row.Cells[49].Value), //"",//No se encontro ACFobservacion
                                Convert.ToString(row.Cells[30].Value), //LIFNR
                                Convert.ToString(row.Cells[35].Value),//ACFnotaingreso
                        //Convert.ToString(row.Cells[36].Value),//ACFfechanotaingreso
                                Convert.ToString(row.Cells[38].Value),//ACFordencompra
                                Convert.ToString(row.Cells[39].Value),//ACFfechaordencompra
                                Convert.ToString(row.Cells[31].Value),// BLART
                                Convert.ToString(row.Cells[33].Value),//ACFcomprobante
                                Convert.ToString(row.Cells[122].Value),//  "0",Convert.ToString(row.Cells[29].Value),//KOSTL
                                "0",//AMBid
                                "0",//UBEID
                        //Convert.ToString(row.Cells[34].Value),//ACFfechacomprobante
                                "0",  //V_T087U_ANLUE
                                 Convert.ToString(row.Cells[2].Value), //ACFtipo_activo
                                "",  //ACFAnulado 
                                "0", // ACFid_Padre
                                 Convert.ToString(row.Cells[37].Value), // ACFtipo_orden
                                 Convert.ToString(row.Cells[47].Value), // OBJid_objeto
                                 Convert.ToString(row.Cells[8].Value), // CRPid_crp
                                 Convert.ToString(row.Cells[12].Value) // ACTid
                                );

                    if (Rta.Equals("OK"))
                    {
                        //MessageBox.Show("Datos agregados");
                    }
                    else
                    {
                        //MessageBox.Show("Datos No Agregados");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void grabarloteCARAC()
        {
            try
            {
                //falta mostrar el ACFid
                Int32 total = 0;
                foreach (DataGridViewRow row in dataListado.Rows)
                {
                    string Rta = string.Empty;
                    Rta = NacfCRSt_Caracteristicas.SAPIMPORT(
                          Convert.ToString(row.Cells[3].Value), // ACFid
                           "0", // MARid
                           Convert.ToString(row.Cells[52].Value), // ESTid
                           "", // CRSserie
                          Convert.ToString(row.Cells[55].Value), // CRSmodelo
                          Convert.ToString(row.Cells[56].Value), // CRScolor
                          "0", // MATid
                          "", // CRStipo
                          "0", // UNMid
                          Convert.ToString(row.Cells[54].Value), // CRScantidad
                          Convert.ToString(row.Cells[58].Value), // CRSvehplaca
                          Convert.ToString(row.Cells[60].Value), // CRSvehexpediente
                          Convert.ToString(System.DateTime.Today),//Convert.ToString(row.Cells[61].Value), // CRSvehinscripcion
                          Convert.ToString(row.Cells[62].Value), // CRSvehclase
                          Convert.ToString(row.Cells[63].Value), // CRSvehcombustible
                          "0",// Convert.ToString(row.Cells[64].Value), // CRSvehejes
                          "0",// Convert.ToString(row.Cells[65].Value), // CRSvehpasajeros
                          "0",// Convert.ToString(row.Cells[66].Value), // CRSvehasientos
                          "0",// Convert.ToString(row.Cells[67].Value), // CRSvehpesoseco
                          "0",// Convert.ToString(row.Cells[68].Value), // CRSvehcargautil
                          "0",// Convert.ToString(row.Cells[69].Value), // CRSaltura
                          "0",// Convert.ToString(row.Cells[70].Value), // CRSancho
                          Convert.ToString(row.Cells[76].Value), // CRSvelocidad
                          "", // CRSresolucion
                          "", // CRScapacidad
                          Convert.ToString(row.Cells[77].Value), // CRSpotencia
                          Convert.ToString(row.Cells[79].Value), // CRSvnominal
                          Convert.ToString(row.Cells[78].Value), // CRSventrada
                          Convert.ToString(row.Cells[80].Value), // CRSvsalida
                          Convert.ToString(row.Cells[81].Value), // CRSfrecuencia
                          Convert.ToString(row.Cells[82].Value), // CRStemperatura
                          Convert.ToString(row.Cells[83].Value), // CRSprocesador
                          Convert.ToString(row.Cells[84].Value), // CRSpuertos
                          "0",// Convert.ToString(row.Cells[71].Value), // CRSutmx
                          "0",// Convert.ToString(row.Cells[72].Value), // CRSutmy
                          Convert.ToString(row.Cells[73].Value), // CRSesfuerzopunta
                          Convert.ToString(row.Cells[74].Value), // CRScajaderivadora
                          Convert.ToString(row.Cells[75].Value), // CRSalquilacable
                          Convert.ToString(row.Cells[86].Value), // CRScentropoblado
                          Convert.ToString(row.Cells[87].Value), // CRSurbanizacion
                          Convert.ToString(row.Cells[88].Value), // CRScalle
                          Convert.ToString(row.Cells[89].Value), // CRSlote
                          Convert.ToString(row.Cells[90].Value), // CRSnumeropredio
                          Convert.ToString(row.Cells[91].Value), // CRSdepartamento
                          Convert.ToString(row.Cells[92].Value), // CRSinterior
                          Convert.ToString(row.Cells[94].Value), // CRScarretera
                          "0",// Convert.ToString(row.Cells[93].Value), // CRSkilometro
                          Convert.ToString(row.Cells[95].Value), // CRSnombrepredio
                          "0",// Convert.ToString(row.Cells[96].Value), // CRSpisospredio
                          "", // CRSpartidapredio
                          "", // CRStomopredio
                          "", // CRSfolioinipredio
                          "", // CRSfoliofinpredio
                          "", // CRSasientopredio
                          Convert.ToString(System.DateTime.Today),//"", // CRSfinscpredio
                          Convert.ToString(row.Cells[98].Value), // CRSficharegistral
                          "0", // Convert.ToString(row.Cells[103].Value), // CRSareaconstruida
                          "0", // Convert.ToString(row.Cells[104].Value), // CRSperimetro
                          "", // CRSusopredio
                          "0", // CRSvalorautovaluo
                          "", // CRScodigoluz
                          "", // CRScodigoagua
                          Convert.ToString(System.DateTime.Today),//"", // CRSfadqpredio
                          Convert.ToString(row.Cells[85].Value) // CRSobservacion
                        );

                    if (Rta.Equals("OK"))
                    {
                        //MessageBox.Show("Datos agregados");
                    }
                    else
                    {
                        //MessageBox.Show("Datos No Agregados");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void grabarloteBUIELEC()
        {
            try
            {
                //falta mostrar el ACFid
                Int32 total = 0;
                foreach (DataGridViewRow row in dataListado.Rows)
                {
                    string Rta = string.Empty;
                    Rta = NacfUBEt_UbicacionElectrica.SAPIMPORT(
                          Convert.ToString(row.Cells[17].Value), // BEcodigogis
                          Convert.ToString(row.Cells[29].Value), // UBEobra     -- proyecto
                          Convert.ToString(row.Cells[122].Value), // "0", // KOSTL
                          Convert.ToString(row.Cells[16].Value), // VNRid 
                          Convert.ToString(row.Cells[19].Value), // SELid 
                          "0", // UBEset
                          Convert.ToString(row.Cells[20].Value), // UBEsetetq
                          "0", // UBEalimentador
                          Convert.ToString(row.Cells[21].Value), // UBEalimentadoretq 
                          "0", // UBEsed 
                          Convert.ToString(row.Cells[22].Value), // UBEsedetq 
                          "0", // UBEcircuito
                          Convert.ToString(row.Cells[23].Value), // UBEcircuitoetq
                          "0", // UBEpuntoi
                          Convert.ToString(row.Cells[27].Value), // UBEpuntoietq
                          "0", // UBEpuntof 
                          Convert.ToString(row.Cells[28].Value), // UBEpuntofetq
                        //"0", // UBEid
                          Convert.ToString(row.Cells[3].Value),  // ACFid  
                          Convert.ToString(row.Cells[18].Value),  // UBIGEO   
                          Convert.ToString(row.Cells[24].Value),  // UBEpostei  
                          Convert.ToString(row.Cells[25].Value)  // UBEpostef  
                        );

                    if (Rta.Equals("OK"))
                    {
                        //MessageBox.Show("Datos agregados");
                    }
                    else
                    {
                        //MessageBox.Show("Datos No Agregados");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void grabarloteVNR()
        {
            try
            {
                //falta mostrar el ACFid
                Int32 total = 0;
                foreach (DataGridViewRow row in dataListado.Rows)
                {
                    string Rta = string.Empty;

                    Rta = NacfVNRt_VNR.SAPIMPORT(
                          Convert.ToString(row.Cells[16].Value)//VNRid
                          );

                    if (Rta.Equals("OK"))
                    {
                        //MessageBox.Show("Datos agregados");
                    }
                    else
                    {
                        //MessageBox.Show("Datos No Agregados");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void grabarloteCentroCosto()
        {
            try
            {
                //falta mostrar el ACFid
                Int32 total = 0;
                foreach (DataGridViewRow row in dataListado.Rows)
                {
                    string Rta = string.Empty;
                    Rta = NbdiXCCpExtraccionSAP_CentroCosto.SAPIMPORT(
                          Convert.ToString(row.Cells[122].Value)//KOSTL
                          );

                    if (Rta.Equals("OK"))
                    {
                        //MessageBox.Show("Datos agregados");
                    }
                    else
                    {
                        //MessageBox.Show("Datos No Agregados");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void chkEliminar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
            }
        }

        private void Grabar()
        {
            if (this.chkEliminar.Checked)
            {
                MessageBox.Show("Procesando grabado por detalle, Por favor espere al Mensaje de Confirmación");
                //this.grabarseleVNR();
                //this.grabarseleCentroCosto();
                this.grabarseleACF();
                this.grabarseleCARAC();
                this.grabarseleBUIELEC();
                MessageBox.Show("Proceso Importar Datos seleccionados Terminado");
                //this.Dispose();
            }
            else
            {
                MessageBox.Show("Procesando grabado por lotes, Por favor espere al Mensaje de Confirmación");
                //this.grabarloteVNR();
                //this.grabarloteCentroCosto();
                this.grabarlote();
                this.grabarloteCARAC();
                this.grabarloteBUIELEC();
                MessageBox.Show("Proceso Importar Datos Terminado");
                this.Dispose();
            }

            if (bwInstance.IsBusy == false)
            {
                processingStatus = CurrentStatus.Loading;
                setFormControlsBasedOnStatus();
                Importar();
                bwInstance.RunWorkerAsync();

            }
            else
            {
                processingStatus = CurrentStatus.Busy;
                setFormControlsBasedOnStatus();
            }
        }

        private void toolStripAnterior_Click(object sender, EventArgs e)
        {
            BotonesIE(true);

            if (bwInstance.IsBusy == false)
            {
                processingStatus = CurrentStatus.Loading;
                setFormControlsBasedOnStatus();
                Importar();
                bwInstance.RunWorkerAsync();

            }
            else
            {
                processingStatus = CurrentStatus.Busy;
                setFormControlsBasedOnStatus();
            }


        }

        private void toolStripAgregar_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            BotonesIE(false);
            this.dataListado.DataSource = null;
        }

        private void bwInstance_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bwInstance_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prgLoadingProgress.Value = e.ProgressPercentage;
        }

        private void bwInstance_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            setFormControlsBasedOnStatus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile1 = new OpenFileDialog();
            openfile1.Filter = "Excel Files |*.*";
            openfile1.Title = "Seleccione el archivo de Excel";
            if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openfile1.FileName.Equals("") == false)
                {
                    textRuta.Text = openfile1.FileName;
                    // MessageBox.Show("Espere Mientras esta Cargando el Documento en Excel", "Atencion");
                    //  MessageBoxTemporal.Show("Espere Mientras esta Cargando el Documento en Excel", "Atencion", 3, true);
                }
            }
        }

    }



}

