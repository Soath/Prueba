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
    
    public partial class FrmExcel : Form
    {
        public FrmExcel()
        {
            InitializeComponent();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtHoja.Text == string.Empty)
            {
                MessageBox.Show("Inserte el nombre de la HOJA");
            }
            else { 
 


            try
            {
                string hoja;
                hoja = txtHoja.Text;

                new Importar().importarExcelca(dataListado, hoja, true);
            }
            catch (Exception ex)
            {
                
            }
            
                

        }
        }
  
        private void FrmExcel_Load(object sender, EventArgs e)
        {
            dataListado.AllowUserToAddRows = false;
        }
        



        private void grabarsele()
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
                        Rta = NacfACFp_Activo_Fijo.Insertar(
                              Convert.ToString(row.Cells[3].Value), //ACFid
                              Convert.ToString(row.Cells[6].Value),  // BUKRS
                              Convert.ToString(row.Cells[7].Value),  //Se trajo del excel de SAP SEGMENT
                              "", //ANLKL  //Convert.ToString(row.Cells[106].Value), //Se trajo del excel de SAP ANLKL ( Id clase activos) 
                              Convert.ToString(row.Cells[9].Value),  //PERNR
                              Convert.ToString(row.Cells[13].Value), //CSTid
                              Convert.ToString(row.Cells[14].Value), //MVMid
                              "", // ACFfmovimiento en la tabla en blanco
                              Convert.ToString(row.Cells[16].Value),//VNRid
                              Convert.ToString(row.Cells[4].Value), //ACFdescripcion
                              Convert.ToString(row.Cells[15].Value),//ACFfincorporacion
                              "", //ACFfcapitalizacion
                              Convert.ToString(row.Cells[43].Value), //ACFvutiltribanio
                              "0", //FORMULA ACFvutiltribdia
                              "0", // ACFvalortrib
                              Convert.ToString(row.Cells[42].Value), //ACFvutilniifanio
                              "0", // FORMULA vutilniifdia
                              Convert.ToString(row.Cells[44].Value), // No se encontro ACFvalorniif
                              "0", //ACFdepacutrib
                              "0", // ACFdepacuniif
                              "", // ACFobra
                            //Convert.ToString(row.Cells[130].Value)  , //Se trajo del excel de SAP ACFord41
                            //Convert.ToString(row.Cells[131].Value)  ,//Se trajo del excel de SAP ACFord42
                            //Convert.ToString(row.Cells[132].Value)  ,//Se trajo del excel de SAP ACFord43
                            //Convert.ToString(row.Cells[133].Value)  ,//Se trajo del excel de SAP ACFord44
                              "",//encontro ACFanlue
                              "", //No se encontro ACFfactortrib
                              "", //No se encontro ACFfactorniif
                              Convert.ToString(row.Cells[11].Value), //ACFcuenta
                              "",//No se encontro ACFcuentadep
                              "",//No se encontro CMPid
                              "",//No se encontro ACFobservacion
                              Convert.ToString(row.Cells[30].Value), //LIFNR
                              Convert.ToString(row.Cells[35].Value),//ACFnotaingreso
                              Convert.ToString(row.Cells[36].Value),//ACFfechanotaingreso
                              Convert.ToString(row.Cells[38].Value),//ACFordencompra
                              Convert.ToString(row.Cells[39].Value),//ACFfechaordencompra
                              Convert.ToString(row.Cells[31].Value),//No se encontro BLART
                              Convert.ToString(row.Cells[33].Value),//ACFcomprobante
                              Convert.ToString(row.Cells[29].Value),//KOSTL
                              "",//AMBid
                              "0",//UBEID
                              Convert.ToString(row.Cells[34].Value),//ACFfechacomprobante
                              "0",  //V_T087U_ANLUE
                              "", //ACFtipo_activo
                              "",  //ACFAnulado 
                              "", // ACFid_Padre
                               Convert.ToString(row.Cells[36].Value), // ACFtipo_orden
                               Convert.ToString(row.Cells[47].Value), // OBJid_objeto
                               Convert.ToString(row.Cells[7].Value) // CRPid_crp
                              );

                        //Rta = NacfCRSt_Caracteristicas.Insertar(
                        //      Convert.ToString(row.Cells[3].Value), // ACFid
                        //       "", // MARid
                        //       "", // ESTid
                        //       "", // CRSserie
                        //      Convert.ToString(row.Cells[55].Value), // CRSmodelo
                        //      Convert.ToString(row.Cells[56].Value), // CRScolor
                        //      "", // MATid
                        //      "", // CRStipo
                        //      Convert.ToString(row.Cells[101].Value), // UNMid
                        //      Convert.ToString(row.Cells[54].Value), // CRScantidad
                        //      Convert.ToString(row.Cells[58].Value), // CRSvehplaca
                        //      Convert.ToString(row.Cells[60].Value), // CRSvehexpediente
                        //      Convert.ToString(row.Cells[61].Value), // CRSvehinscripcion
                        //      Convert.ToString(row.Cells[62].Value), // CRSvehclase
                        //      Convert.ToString(row.Cells[63].Value), // CRSvehcombustible
                        //      Convert.ToString(row.Cells[64].Value), // CRSvehejes
                        //      Convert.ToString(row.Cells[65].Value), // CRSvehpasajeros
                        //      Convert.ToString(row.Cells[66].Value), // CRSvehasientos
                        //      Convert.ToString(row.Cells[67].Value), // CRSvehpesoseco
                        //      Convert.ToString(row.Cells[68].Value), // CRSvehcargautil
                        //      Convert.ToString(row.Cells[69].Value), // CRSaltura
                        //      Convert.ToString(row.Cells[70].Value), // CRSancho
                        //      Convert.ToString(row.Cells[76].Value), // CRSvelocidad
                        //      "", // CRSresolucion
                        //      "", // CRScapacidad
                        //      Convert.ToString(row.Cells[77].Value), // CRSpotencia
                        //      Convert.ToString(row.Cells[79].Value), // CRSvnominal
                        //      Convert.ToString(row.Cells[78].Value), // CRSventrada
                        //      Convert.ToString(row.Cells[80].Value), // CRSvsalida
                        //      Convert.ToString(row.Cells[81].Value), // CRSfrecuencia
                        //      Convert.ToString(row.Cells[82].Value), // CRStemperatura
                        //      Convert.ToString(row.Cells[83].Value), // CRSprocesador
                        //      Convert.ToString(row.Cells[84].Value), // CRSpuertos
                        //      Convert.ToString(row.Cells[71].Value), // CRSutmx
                        //      Convert.ToString(row.Cells[72].Value), // CRSutmy
                        //      Convert.ToString(row.Cells[73].Value), // CRSesfuerzopunta
                        //      Convert.ToString(row.Cells[74].Value), // CRScajaderivadora
                        //      Convert.ToString(row.Cells[75].Value), // CRSalquilacable
                        //      Convert.ToString(row.Cells[86].Value), // CRScentropoblado
                        //      Convert.ToString(row.Cells[87].Value), // CRSurbanizacion
                        //      Convert.ToString(row.Cells[88].Value), // CRScalle
                        //      Convert.ToString(row.Cells[89].Value), // CRSlote
                        //      Convert.ToString(row.Cells[90].Value), // CRSnumeropredio
                        //      Convert.ToString(row.Cells[91].Value), // CRSdepartamento
                        //      Convert.ToString(row.Cells[92].Value), // CRSinterior
                        //      Convert.ToString(row.Cells[94].Value), // CRScarretera
                        //      Convert.ToString(row.Cells[93].Value), // CRSkilometro
                        //      Convert.ToString(row.Cells[95].Value), // CRSnombrepredio
                        //      Convert.ToString(row.Cells[96].Value), // CRSpisospredio
                        //      "", // CRSpartidapredio
                        //      "", // CRStomopredio
                        //      "", // CRSfolioinipredio
                        //      "", // CRSfoliofinpredio
                        //      "", // CRSasientopredio
                        //      "", // CRSfinscpredio
                        //      Convert.ToString(row.Cells[98].Value), // CRSficharegistral
                        //      Convert.ToString(row.Cells[103].Value), // CRSareaconstruida
                        //      Convert.ToString(row.Cells[104].Value), // CRSperimetro
                        //      "", // CRSusopredio
                        //      "", // CRSvalorautovaluo
                        //      "", // CRScodigoluz
                        //      "", // CRScodigoagua
                        //      "", // CRSfadqpredio
                        //      Convert.ToString(row.Cells[85].Value) // CRSobservacion
                        //    );
                        //
                                                                             
                        if (Rta.Equals("OK"))
                        {
                            MessageBox.Show("Datos agregados");
                        }
                        else
                        {
                            MessageBox.Show("Datos No Agregados");
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
                   Rta = NacfACFp_Activo_Fijo.Insertar(
                         Convert.ToString(row.Cells[3].Value), //ACFid
                         Convert.ToString(row.Cells[6].Value),  // BUKRS
                         Convert.ToString(row.Cells[7].Value),  //Se trajo del excel de SAP SEGMENT
                         "", //ANLKL  //Convert.ToString(row.Cells[106].Value), //Se trajo del excel de SAP ANLKL ( Id clase activos) 
                         Convert.ToString(row.Cells[9].Value) ,  //PERNR
                         Convert.ToString(row.Cells[13].Value)  , //CSTid
                         Convert.ToString(row.Cells[14].Value)  , //MVMid
                         ""  , // ACFfmovimiento en la tabla en blanco
                         Convert.ToString(row.Cells[15].Value)  ,//VNRid
                         Convert.ToString(row.Cells[4].Value)  , //ACFdescripcion
                         Convert.ToString(row.Cells[15].Value)  ,//ACFfincorporacion
                         "", //ACFfcapitalizacion
                         Convert.ToString(row.Cells[43].Value)  , //ACFvutiltribanio
                         "0", //FORMULA ACFvutiltribdia
                         "0", // ACFvalortrib
                         Convert.ToString(row.Cells[42].Value)  , //ACFvutilniifanio
                         "0", // FORMULA vutilniifdia
                         Convert.ToString(row.Cells[44].Value)  , // No se encontro ACFvalorniif
                         "0", //ACFdepacutrib
                         "0" , // ACFdepacuniif
                         "" , // ACFobra
                       //Convert.ToString(row.Cells[130].Value)  , //Se trajo del excel de SAP ACFord41
                       //Convert.ToString(row.Cells[131].Value)  ,//Se trajo del excel de SAP ACFord42
                       //Convert.ToString(row.Cells[132].Value)  ,//Se trajo del excel de SAP ACFord43
                       //Convert.ToString(row.Cells[133].Value)  ,//Se trajo del excel de SAP ACFord44
                         "" ,//encontro ACFanlue
                         "" , //No se encontro ACFfactortrib
                         "" , //No se encontro ACFfactorniif
                         Convert.ToString(row.Cells[11].Value)  , //ACFcuenta
                         "" ,//No se encontro ACFcuentadep
                         "" ,//No se encontro CMPid
                         "" ,//No se encontro ACFobservacion
                         Convert.ToString(row.Cells[30].Value)  , //LIFNR
                         Convert.ToString(row.Cells[35].Value)  ,//ACFnotaingreso
                         Convert.ToString(row.Cells[36].Value)  ,//ACFfechanotaingreso
                         Convert.ToString(row.Cells[38].Value)  ,//ACFordencompra
                         Convert.ToString(row.Cells[39].Value)  ,//ACFfechaordencompra
                         Convert.ToString(row.Cells[40].Value)  ,//No se encontro BLART
                         Convert.ToString(row.Cells[33].Value)  ,//ACFcomprobante
                         Convert.ToString(row.Cells[29].Value)  ,//KOSTL
                         ""  ,//AMBid
                         "0" ,//UBEID
                         Convert.ToString(row.Cells[34].Value)  ,//ACFfechacomprobante
                         "0" ,  //V_T087U_ANLUE
                         "", //ACFtipo_activo
                         "",  //ACFAnulado 
                         "" ,// ACFid_Padre
                         Convert.ToString(row.Cells[36].Value), // ACFtipo_orden
                         Convert.ToString(row.Cells[47].Value), // OBJid_objeto
                         Convert.ToString(row.Cells[7].Value) // CRPid_crp
                         );
                                                             
                   Rta = NacfCRSt_Caracteristicas.Insertar(
                         Convert.ToString(row.Cells[3].Value), // ACFid
                          "", // MARid
                          "", // ESTid
                          "", // CRSserie
                         Convert.ToString(row.Cells[55].Value), // CRSmodelo
                         Convert.ToString(row.Cells[56].Value), // CRScolor
                         "", // MATid
                         "", // CRStipo
                         Convert.ToString(row.Cells[101].Value), // UNMid
                         Convert.ToString(row.Cells[54].Value), // CRScantidad
                         Convert.ToString(row.Cells[58].Value), // CRSvehplaca
                         Convert.ToString(row.Cells[60].Value), // CRSvehexpediente
                         Convert.ToString(row.Cells[61].Value), // CRSvehinscripcion
                         Convert.ToString(row.Cells[62].Value), // CRSvehclase
                         Convert.ToString(row.Cells[63].Value), // CRSvehcombustible
                         Convert.ToString(row.Cells[64].Value), // CRSvehejes
                         Convert.ToString(row.Cells[65].Value), // CRSvehpasajeros
                         Convert.ToString(row.Cells[66].Value), // CRSvehasientos
                         Convert.ToString(row.Cells[67].Value), // CRSvehpesoseco
                         Convert.ToString(row.Cells[68].Value), // CRSvehcargautil
                         Convert.ToString(row.Cells[69].Value), // CRSaltura
                         Convert.ToString(row.Cells[70].Value), // CRSancho
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
                         Convert.ToString(row.Cells[71].Value), // CRSutmx
                         Convert.ToString(row.Cells[72].Value), // CRSutmy
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
                         Convert.ToString(row.Cells[93].Value), // CRSkilometro
                         Convert.ToString(row.Cells[95].Value), // CRSnombrepredio
                         Convert.ToString(row.Cells[96].Value), // CRSpisospredio
                         "", // CRSpartidapredio
                         "", // CRStomopredio
                         "", // CRSfolioinipredio
                         "", // CRSfoliofinpredio
                         "", // CRSasientopredio
                         "", // CRSfinscpredio
                         Convert.ToString(row.Cells[98].Value), // CRSficharegistral
                         Convert.ToString(row.Cells[103].Value), // CRSareaconstruida
                         Convert.ToString(row.Cells[104].Value), // CRSperimetro
                         "", // CRSusopredio
                         "", // CRSvalorautovaluo
                         "", // CRScodigoluz
                         "", // CRScodigoagua
                         "", // CRSfadqpredio
                         Convert.ToString(row.Cells[85].Value) // CRSobservacion
                       );

                   if (Rta.Equals("OK"))
                   {
                   }
                   else
                   {
                       break;

                   }
                }

                MessageBox.Show("Datos agregados");
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

           private void button2_Click_1(object sender, EventArgs e)
           {
               if (this.chkEliminar.Checked)
                   this.grabarsele();
               else
                   this.grabarlote();
           }
        }



}

