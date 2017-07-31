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

    public partial class Frm_Excel_Reparo : Form
    {

        public Frm_Excel_Reparo()
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

        private void Frm_Excel_Reparo_Load(object sender, EventArgs e)
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
                        Rta = NacfDRTt_detallereparotributario.Insertar2(
                             Convert.ToString(row.Cells[1].Value), //ACFCuenta
                              Convert.ToString(row.Cells[3].Value), //ACFid
                              Convert.ToString(row.Cells[4].Value), //ACFdescripcion 
                              Convert.ToString(row.Cells[5].Value), //ACFfactorniif
                              Convert.ToString(row.Cells[6].Value),  //ACFvutilniif
                              Convert.ToString(row.Cells[7].Value), //ACFfactortriub
                              Convert.ToString(row.Cells[8].Value), //ACFvutiltrib
                              Convert.ToString(row.Cells[9].Value), //ACFvutiltrib
                              Convert.ToString(row.Cells[10].Value),//VNRid
                             
                              Convert.ToString(row.Cells[12].Value),//ACFfincorporacion
                            Convert.ToString(row.Cells[13].Value), //ACFvutiltrib
                              Convert.ToString(row.Cells[14].Value), //ACFvutiltribanio
                        
                              Convert.ToString(row.Cells[16].Value)//ACFvutiltrib
                      
                             
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
      
        private void grabarlote()
        {
            try
            {
                foreach (DataGridViewRow row in dataListado.Rows)
                {
                    string Rta = string.Empty;
                    Rta = NacfDRTt_detallereparotributario.Insertar2(
                              Convert.ToString(row.Cells[1].Value), //ACFCuenta
                              Convert.ToString(row.Cells[3].Value), //ACFid
                              Convert.ToString(row.Cells[4].Value), //ACFdescripcion 
                              Convert.ToString(row.Cells[5].Value), //ACFfactorniif
                              Convert.ToString(row.Cells[6].Value),  //ACFvutilniif
                              Convert.ToString(row.Cells[7].Value), //ACFfactortriub
                              Convert.ToString(row.Cells[8].Value), //ACFvutiltrib
                              Convert.ToString(row.Cells[9].Value), //ACFvutiltrib
                              Convert.ToString(row.Cells[10].Value),//VNRid
                             
                              Convert.ToString(row.Cells[12].Value),//ACFfincorporacion
                            Convert.ToString(row.Cells[13].Value), //ACFvutiltrib
                              Convert.ToString(row.Cells[14].Value), //ACFvutiltribanio
                        
                              Convert.ToString(row.Cells[16].Value) //ACFvutiltrib
                             
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
                //this.grabarseleCARAC();
               // this.grabarseleBUIELEC();
                MessageBox.Show("Proceso Importar Datos seleccionados Terminado");
                //this.Dispose();
            }
            else
            {
                MessageBox.Show("Procesando grabado por lotes, Por favor espere al Mensaje de Confirmación");
                //this.grabarloteVNR();
                //this.grabarloteCentroCosto();
                this.grabarlote();
              
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

