﻿using System;
using System.Collections.Generic;
using ComponentFactory.Krypton.Toolkit;
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
    //
    public partial class FrmacfACFp_Activo_Fijo : KryptonForm
    {
        int Activo = 1;
        int Graba = 0;
        public int idEditar = 0;
        public string MensError;
        private static FrmacfACFp_Activo_Fijo _Instancia;

        public static FrmacfACFp_Activo_Fijo GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FrmacfACFp_Activo_Fijo();
            }
            return _Instancia;
        }
        public FrmacfACFp_Activo_Fijo()
        {
            InitializeComponent();

            this.toolStripRefrescar.Click += new System.EventHandler(this.Control_Click_Refrescar);
            this.toolStripAgregar.Click += new System.EventHandler(this.Control_Click_Agregar);
            this.toolStripEditar.Click += new System.EventHandler(this.Control_Click_Editar);
            this.toolStripEliminar.Click += new System.EventHandler(this.Control_Click_Eliminar);
            this.toolStripImprimir.Click += new System.EventHandler(this.Control_Click_Imprimir);
            this.toolStripGuardar.Click += new System.EventHandler(this.Control_Click_Guardar);
            this.toolStripCancelar.Click += new System.EventHandler(this.Control_Click_Cancelar);
            this.toolStripAnterior.Click += new System.EventHandler(this.Control_Click_Prev);
            this.toolStripSiguiente.Click += new System.EventHandler(this.Control_Click_Next);
            this.toolStripPrimero.Click += new System.EventHandler(this.Control_Click_Top);
            this.toolStripUltimo.Click += new System.EventHandler(this.Control_Click_Last);
            this.toolStripBuscar.Click += new System.EventHandler(this.Control_Click_Serch);
            this.toolStripImportar.Click += new System.EventHandler(this.Control_Click_Importar);

            EstadoText(this.Controls, true, false);
            mostrar();
            CargarCombos();
            MostrarRegistro();
               
          
            CheckAll(this,true);
        }
        //--------------------------------------------------------------------------------------------------	
        // insertar aqui todos los procedimientos para ABC	
        //--------------------------------------------------------------------------------------------------	
        
        private void CheckAll(Control parent, bool value)
        {           
            foreach (Control currentControl in parent.Controls)
            {
                if (currentControl is TextBox)
                {
                    currentControl.Enter += Control_Enter;
                    currentControl.Leave += Control_Leave;
                    currentControl.KeyPress += MoverFoco;
                }
                // Recurse if control contains other controls
                if (currentControl.Controls.Count > 0)
                {
                    CheckAll(currentControl, value);
                }
            }
        }   

        void ctrl_LostFocus(object sender, EventArgs e)
        {
            var ctrl = sender as Control;
            if (ctrl.Tag is Color)
                ctrl.BackColor = (Color)ctrl.Tag;
        }

        void ctrl_GotFocus(object sender, EventArgs e)
        {
            var ctrl = sender as Control;
            ctrl.Tag = ctrl.BackColor;
            ctrl.BackColor = Color.Red;
        }

        public static void MoverFoco(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }


        private void Control_Click_Prev(object sender, EventArgs e)
            {
                Prev(txtACFid.Text);
            }
        private void Control_Click_Next(object sender, EventArgs e)
            {
                Next(txtACFid.Text);
            }
        private void Control_Click_Top(object sender, EventArgs e)
            {
                Top();
            }
        private void Control_Click_Last(object sender, EventArgs e)
            {
                Last();
            }

        private void Control_Click_Serch(object sender, EventArgs e)
        {
            Serch();
        }
        private void Control_Click_Refrescar(object sender, EventArgs e)
        {
            this.BotonRefrescar();
        }
        private void Control_Click_Agregar(object sender, EventArgs e)
        {
            this.BotonAgregar();
        }
        private void Control_Click_Editar(object sender, EventArgs e)
        {
            this.BotonEditar();
        }
        private void Control_Click_Eliminar(object sender, EventArgs e)
        {
            this.BotonEliminar();
        }
        private void Control_Click_Imprimir(object sender, EventArgs e)
        {
            this.BotonImprimir();
        }
        private void Control_Click_Guardar(object sender, EventArgs e)
        {
            this.BotonGuardar();
        }
        private void Control_Click_Cancelar(object sender, EventArgs e)
        {
            this.BotonRefrescar();
        }
        private void Control_Click_Importar(object sender, EventArgs e)
        {
            this.BotonImportar();
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            this.tomaTab();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscarNombre();
        }
        // --------------------------------------------------------------------
        private void dataListado_Click(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Control Escolar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Control Escolar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Botones(bool edo)
        {
            this.toolStripRefrescar.Visible = edo;
            this.toolStripAgregar.Visible = edo;
            this.toolStripEditar.Visible = edo;
            this.toolStripEliminar.Visible = edo;
            this.toolStripImprimir.Visible = edo;
            this.toolStripImportar.Visible = edo;

            this.toolStripGuardar.Visible = !edo;
            this.toolStripCancelar.Visible = !edo;
            this.toolStripPrimero.Visible = edo;
            this.toolStripAnterior.Visible = edo;
            this.toolStripSiguiente.Visible = edo;
            this.toolStripUltimo.Visible = edo;
            this.toolStripBuscar.Visible = edo;
            this.toolStripComboBox1.Visible = edo;
            this.toolStripTextBox1.Visible = edo;
            this.toolStripImagen.Visible = edo;
            
        }

        private void BotonesSinReg(bool edo)
        {
            this.toolStripRefrescar.Enabled = edo;
            this.toolStripAgregar.Enabled = !edo;
            this.toolStripEditar.Enabled = edo;
            this.toolStripEliminar.Enabled = edo;
            this.toolStripImportar.Visible = edo;
            this.toolStripImprimir.Enabled = edo;
            this.toolStripPrimero.Enabled = edo;
            this.toolStripAnterior.Enabled = edo;
            this.toolStripSiguiente.Enabled = edo;
            this.toolStripUltimo.Enabled = edo;
            this.toolStripBuscar.Enabled = edo;
            this.toolStripComboBox1.Enabled = edo;
            this.toolStripTextBox1.Enabled = edo;
        }

        private void OcultarColumnas()        {}

        private void mostrar()
        {
           
            this.Botones(true);
            this.Configura();
            this.Activo = 1;
            this.tomaTab();
            this.Botones(true);
        }

        private void CargarCombos()
        {
            this.cboBUKRS.DataSource = NbdiSOCpSociedades.Mostrar(); //BURkS
            this.cboBUKRS.ValueMember = "BUKRS";
            this.cboBUKRS.DisplayMember = "BUKRS";
            this.cboBUKRS.SelectedIndex = -1;


            this.cboSEGMENT.DataSource = NbdiSEGpSegmento.Mostrar(); //SEGMENT
            this.cboSEGMENT.ValueMember = "SEGMENT";
            this.cboSEGMENT.DisplayMember = "SEGMENT";
            this.cboSEGMENT.SelectedIndex = -1;

            this.cboANLKL.DataSource = NbdiCAFpClaseDeActivoFijo.Mostrar(); //ANLKL
            this.cboANLKL.ValueMember = "ANLKL";
            this.cboANLKL.DisplayMember = "ANLKL";
            this.cboANLKL.SelectedIndex = -1;

            this.cboPERNR.DataSource = NbdiXPEpExtraccionSAP_Personal.Mostrar(); //PERNR
            this.cboPERNR.ValueMember = "PERNR";
            this.cboPERNR.DisplayMember = "PERNR";
            this.cboPERNR.SelectedIndex = -1;

            this.cboCSTid.DataSource = NacfCSTt_Costo.Mostrar(); //CSTid
            this.cboCSTid.ValueMember = "CSTid";
            this.cboCSTid.DisplayMember = "CSTid";
            this.cboCSTid.SelectedIndex = -1;

            this.cboMVMid.DataSource = NacfMVMt_MotivoMovimiento.Mostrar();  //MVMid
            this.cboMVMid.ValueMember = "MVMid";
            this.cboMVMid.DisplayMember = "MVMid";
            this.cboMVMid.SelectedIndex = -1;

            this.cboVNRid.DataSource = NacfVNRt_VNR.Mostrar();   //VNRid
            this.cboVNRid.ValueMember = "VNRid";
            this.cboVNRid.DisplayMember = "VNRid";
            this.cboVNRid.SelectedIndex = -1;
            this.cboVNRid.Text = "";


            this.cboCMPid.DataSource = NacfCMPt_Componente.Mostrar();    //CMPid
            this.cboCMPid.ValueMember = "CMPid";
            this.cboCMPid.DisplayMember = "CMPid";
            this.cboCMPid.SelectedIndex = -1;

            this.cboLIFNR.DataSource = NbdiPRVpProveedor.Mostrar();  //LIFNR
            this.cboLIFNR.ValueMember = "LIFNR";
            this.cboLIFNR.DisplayMember = "LIFNR";
            this.cboLIFNR.SelectedIndex = -1;
            this.cboLIFNR.Text = "";


            this.cboBLART.DataSource = NbdiCDDpClasesDeDocumento.Mostrar();  //BLART
            this.cboBLART.ValueMember = "BLART";
            this.cboBLART.DisplayMember = "BLART";
            this.cboBLART.SelectedIndex = -1;
            this.cboBLART.Text = "";

            this.cboKOSTL.DataSource = NbdiXCCpExtraccionSAP_CentroCosto.Mostrar();  //KOSTL
            this.cboKOSTL.ValueMember = "KOSTL";
            this.cboKOSTL.DisplayMember = "KOSTL";
            this.cboKOSTL.SelectedIndex = -1;

            this.cboAMBid.DataSource = NacfAMBt_Ambiente.Mostrar();  //AMBid
            this.cboAMBid.ValueMember = "AMBid";
            this.cboAMBid.DisplayMember = "AMBid";
            this.cboAMBid.SelectedIndex = -1;


            this.cboUBEid.DataSource = NacfUBEt_UbicacionElectrica.Mostrar();    //UBEid
            this.cboUBEid.ValueMember = "UBEid";
            this.cboUBEid.DisplayMember = "UBEid";
            this.cboUBEid.SelectedIndex = -1;

            this.cboV_T087U_ANLUE.DataSource = NacfSPNt_Supranumero.Mostrar();   //V_T087U_ANLUE
            this.cboV_T087U_ANLUE.ValueMember = "V_T087U_ANLUE";
            this.cboV_T087U_ANLUE.DisplayMember = "V_T087U_ANLUE";
            this.cboV_T087U_ANLUE.SelectedIndex = -1;
        }
        private void Top()
        {
            try
            {
                DataTable dat = NacfACFp_Activo_Fijo.Top();
                MostrarDatos(dat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Next(String iACFid)
        {
            try
            {
                DataTable dat = NacfACFp_Activo_Fijo.Next(iACFid);
                MostrarDatos(dat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Prev(String iACFid)
        {
            try
            {
                DataTable dat = NacfACFp_Activo_Fijo.Prev(iACFid);
                MostrarDatos(dat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Last()
        {
            try
            {
                DataTable dat = NacfACFp_Activo_Fijo.Last();
                MostrarDatos(dat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Serch()
        {
            this.toolStripComboBox1.Enabled = true;
            this.toolStripTextBox1.Enabled = true;
            Form FrmBuscar = new FrmacfACFp_Activo_Fijo_Buscar();
            FrmBuscar.ShowDialog();

            int IdActi = FrmacfACFp_Activo_Fijo_Buscar.IdAct;
            MessageBox.Show("ID :"+IdActi);
        }
        private void BotonImportar()
        {
            Form FrmExcel = new FrmExcel();
            FrmExcel.Show();
        }
        private void BotonRefrescar()
        {
            EstadoText(this.Controls, false, false);
            this.mostrar();
        }
        private void BotonAgregar()
        {
            Activo = 2;
            Graba = 1;
            EstadoText(this.Controls, true, true);
            this.LimpiaCampos();
            this.Botones(false);
            //tabControl1.SelectedTab = tabPage2;
        }

        private void BotonEditar()
        {
            Activo = 2;
            Graba = 2;
            this.Botones(false);
            EstadoText(this.Controls, false, true);
           // tabControl1.SelectedTab = tabPage2;
            this.CargaDatos();           
        }
        private void BotonEliminar()
        {
            this.borrauno();
            this.mostrar();
        }
        private void BotonImprimir()  {}

        private void BotonGuardar()
        {
            if (this.validaCampos())
            {
                if (Graba == 1) this.InsertaRegistro();
                if (Graba == 2) this.ActualizaRegistro();
                Graba = 0;
                this.BotonCancelar();
                this.BotonRefrescar();
            }
            else
                this.MensajeOk(MensError);
        }
        private void BotonCancelar()
        {
            Activo = 1;
            this.Botones(true);
            EstadoText(this.Controls, false, false);
            //tabControl1.SelectedTab = tabPage1;
        }
        private void BotonListado()
        {
            //        if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)	
            //           {	
            //              DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];	
            //             ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);	
            //          }	

        }

        public void LimpiaCampos() {}
        private void CargaDatos() 
        {         
            idEditar = 0;
        }
        private bool validaCampos()
        {
            return true;
        }


        //-----------------------------------------------------------------------------------	
        // Inserta Registros	
        //-----------------------------------------------------------------------------------	
        private void InsertaRegistro()
        {
            string Rta = string.Empty;
            
            try
            {
                Rta = NacfACFp_Activo_Fijo.Insertar(
                      this.txtACFid.Text
                    , cboBUKRS.SelectedValue.ToString()
                    , cboSEGMENT.SelectedValue.ToString()
                    , cboANLKL.SelectedValue.ToString()
                    , cboPERNR.SelectedValue.ToString()
                    , cboCSTid.SelectedValue.ToString()
                    , cboMVMid.SelectedValue.ToString()
                    , this.dtpACFfmovimiento.Text
                    , cboVNRid.SelectedValue.ToString()
                    , this.txtACFdescripcion.Text
                    , this.dtpACFfincorporacion.Text
                    , this.txtACFfcapitalizacion.Text
                    , this.txtACFvutiltribanio.Text
                    , this.txtACFvutiltribdia.Text
                    , this.txtACFvalortrib.Text
                    , this.txtACFvutilniifanio.Text
                    , this.txtACFvutilniifdia.Text
                    , this.txtACFvalorniif.Text
                    , this.txtACFdepacutrib.Text
                    , this.txtACFdepacuniif.Text
                    , this.txtACFobra.Text
                    //, this.txtACFord41.Text
                    //, this.txtACFord42.Text
                    //, this.txtACFord43.Text
                    //, this.txtACFord44.Text
                    , this.txtACFanlue.Text
                    , this.txtACFfactortrib.Text
                    , this.txtACFfactorniif.Text
                    , this.txtACFcuenta.Text
                    , this.txtACFcuentadep.Text
                    , cboCMPid.SelectedValue.ToString()
                    , this.txtACFobservacion.Text
                    , cboLIFNR.SelectedValue.ToString()
                    , this.txtACFnotaingreso.Text
                    , this.dtpACFfechanotaingreso.Text
                    , this.txtACFordencompra.Text
                    , this.dtpACFfechaordencompra.Text
                    , cboBLART.SelectedValue.ToString()
                    , this.txtACFcomprobante.Text
                    , cboKOSTL.SelectedValue.ToString()
                    , cboAMBid.SelectedValue.ToString()
                    , cboUBEid.SelectedValue.ToString()
                    , this.dtpACFfechacomprobante.Text
                    , cboV_T087U_ANLUE.SelectedValue.ToString()
                    , this.CtxtACFtipo_activo.Text
                    );
                // Rta = NacfACFp_Activo_Fijo.Insertar(this.txtACFid.Text, "1", "1", "1", "1", "1", "2", DateTime.Today.ToString(), "1", this.txtACFdescripcion.Text, DateTime.Today.ToString(), DateTime.Today.ToString(), "0", "0", "0.00", "0", "0", "0", "", "0", "", "", "", "", "", "", "0.00", "0.00", "", "", "1", "", "1", "", "", "", DateTime.Today.ToString(), "1", "", "1", "1", "1", DateTime.Today.ToString(), "1");
                
                if (Rta.Equals("OK"))
                {
                    this.MensajeOk("Regsitro Agregado Correctamente");
                }
                else
                {
                    this.MensajeError("Error al Insertar Registro :" + Rta);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        //-----------------------------------------------------------------------------------	
        // Actualiza Registros	
        //-----------------------------------------------------------------------------------	
        private void ActualizaRegistro()
        {
            string Rta = string.Empty;

            try
            {                
                Rta = NacfACFp_Activo_Fijo.Editar(
                      this.txtACFid.Text
                    , cboBUKRS.SelectedValue.ToString()
                    , cboSEGMENT.SelectedValue.ToString()
                    , cboANLKL.SelectedValue.ToString()
                    , cboPERNR.SelectedValue.ToString()
                    , cboCSTid.SelectedValue.ToString()
                    , cboMVMid.SelectedValue.ToString()
                    , this.dtpACFfmovimiento.Text
                    , cboVNRid.SelectedValue.ToString()
                    , this.txtACFdescripcion.Text
                    , this.dtpACFfincorporacion.Text
                    , this.txtACFfcapitalizacion.Text
                    , this.txtACFvutiltribanio.Text
                    , this.txtACFvutiltribdia.Text
                    , this.txtACFvalortrib.Text
                    , this.txtACFvutilniifanio.Text
                    , this.txtACFvutilniifdia.Text
                    , this.txtACFvalorniif.Text
                    , this.txtACFdepacutrib.Text
                    , this.txtACFdepacuniif.Text
                    , this.txtACFobra.Text
                   //, this.txtACFord41.Text
                   //, this.txtACFord42.Text
                   //, this.txtACFord43.Text
                   //, this.txtACFord44.Text
                    , this.txtACFanlue.Text
                    , this.txtACFfactortrib.Text
                    , this.txtACFfactorniif.Text
                    , this.txtACFcuenta.Text
                    , this.txtACFcuentadep.Text
                    , cboCMPid.SelectedValue.ToString()
                    , this.txtACFobservacion.Text
                    , cboLIFNR.SelectedValue.ToString()
                    , this.txtACFnotaingreso.Text
                    , this.dtpACFfechanotaingreso.Text
                    , this.txtACFordencompra.Text
                    , this.dtpACFfechaordencompra.Text
                    , cboBLART.SelectedValue.ToString()
                    , this.txtACFcomprobante.Text
                    , cboKOSTL.SelectedValue.ToString()
                    , cboAMBid.SelectedValue.ToString()
                    , cboUBEid.SelectedValue.ToString()
                    , this.dtpACFfechacomprobante.Text
                    , cboV_T087U_ANLUE.SelectedValue.ToString()
                    , this.CtxtACFtipo_activo.Text
                    );

                //Rta = NacfACFp_Activo_Fijo.Editar("1", "1", "1", "1", "1", "1", "2", DateTime.Today.ToString(), "1", this.txtACFdescripcion.Text, DateTime.Today.ToString(), DateTime.Today.ToString(), "0", "0", "0.00", "0", "0", "0", "", "0", "", "", "", "", "", "", "0.00", "0.00", "", "", "1", "", "1", "", "", "", DateTime.Today.ToString(), "1", "", "1", "1", "1", DateTime.Today.ToString(), "1");
              
                if (Rta.Equals("OK"))
                {
                    this.MensajeOk("Regsitro Actualizado Correctamente");
                }
                else
                {
                    this.MensajeError("Error al Actualizar Registro " + Rta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //-----------------------------------------------------------------------------------	
        // Elimina Registros	
        //-----------------------------------------------------------------------------------	
        private void borrauno()
        {
            string Rta = string.Empty;
            DialogResult Opcion;
            Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema de escolar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                string Codigo;
                Codigo = "2";
                Rta = NPostres.Eliminar(Codigo);

                if (Rta.Equals("OK"))
                {
                    this.MensajeOk("Se Eliminó Correctamente el registro");
                }
                else
                {
                    this.MensajeError("Error al Eliminar el Registro ");
                }

            }
        }
        
        private void buscarNombre()
        {
            NacfACFp_Activo_Fijo.Buscar("1");
        }

        private void MostrarDatos(DataTable dat)
        {
            if (dat.Rows.Count > 0)
            {
                DataRow row = dat.Rows[0];
                //guardo datos en variables
                txtACFid.Text = Convert.ToString(row["ACFid"]);
                cboBUKRS.Text = Convert.ToString(row["BUKRS"]);
                cboSEGMENT.Text = Convert.ToString(row["SEGMENT"]);
                cboANLKL.Text = Convert.ToString(row["ANLKL"]);
                cboPERNR.Text = Convert.ToString(row["PERNR"]);
                cboCSTid.Text = Convert.ToString(row["CSTid"]);
                cboMVMid.Text = Convert.ToString(row["MVMid"]);
                dtpACFfmovimiento.Text = Convert.ToString(row["ACFfmovimiento"]);
                cboVNRid.Text = Convert.ToString(row["VNRid"]);
                txtACFdescripcion.Text = Convert.ToString(row["ACFdescripcion"]);
                dtpACFfincorporacion.Text = Convert.ToString(row["ACFfincorporacion"]);
                txtACFfcapitalizacion.Text = Convert.ToString(row["ACFfcapitalizacion"]);
                txtACFvutiltribanio.Text = Convert.ToString(row["ACFvutiltribanio"]);
                txtACFvutiltribdia.Text = Convert.ToString(row["ACFvutiltribdia"]);
                txtACFvalortrib.Text = Convert.ToString(row["ACFvalortrib"]);
                txtACFvutilniifanio.Text = Convert.ToString(row["ACFvutilniifanio"]);
                txtACFvutilniifdia.Text = Convert.ToString(row["ACFvutilniifdia"]);
                txtACFvalorniif.Text = Convert.ToString(row["ACFvalorniif"]);
                txtACFdepacutrib.Text = Convert.ToString(row["ACFdepacutrib"]);
                txtACFdepacuniif.Text = Convert.ToString(row["ACFdepacuniif"]);
                txtACFobra.Text = Convert.ToString(row["ACFobra"]);
                //txtACFord41.Text = Convert.ToString(row["ACFord41"]);
                //txtACFord42.Text = Convert.ToString(row["ACFord42"]);
                //txtACFord43.Text = Convert.ToString(row["ACFord43"]);
                //txtACFord44.Text = Convert.ToString(row["ACFord44"]);
                txtACFanlue.Text = Convert.ToString(row["ACFanlue"]);
                txtACFfactortrib.Text = Convert.ToString(row["ACFfactortrib"]);
                txtACFfactorniif.Text = Convert.ToString(row["ACFfactorniif"]);
                txtACFcuenta.Text = Convert.ToString(row["ACFcuenta"]);
                txtACFcuentadep.Text = Convert.ToString(row["ACFcuentadep"]);
                cboCMPid.Text = Convert.ToString(row["CMPid"]);
                txtACFobservacion.Text = Convert.ToString(row["ACFobservacion"]);
                cboLIFNR.Text = Convert.ToString(row["LIFNR"]);
                txtACFnotaingreso.Text = Convert.ToString(row["ACFnotaingreso"]);
                dtpACFfechanotaingreso.Text = Convert.ToString(row["ACFfechanotaingreso"]);
                txtACFordencompra.Text = Convert.ToString(row["ACFordencompra"]);
                dtpACFfechaordencompra.Text = Convert.ToString(row["ACFfechaordencompra"]);
                cboBLART.Text = Convert.ToString(row["BLART"]);
                txtACFcomprobante.Text = Convert.ToString(row["ACFcomprobante"]);
                cboKOSTL.Text = Convert.ToString(row["KOSTL"]);
                cboAMBid.Text = Convert.ToString(row["AMBid"]);
                cboUBEid.Text = Convert.ToString(row["UBEid"]);
                dtpACFfechacomprobante.Text = Convert.ToString(row["ACFfechacomprobante"]);
                cboV_T087U_ANLUE.Text = Convert.ToString(row["V_T087U_ANLUE"]);
                CtxtACFtipo_activo.Text = Convert.ToString(row["ACFtipo_activo"]);
                //guardo datos en variables
                //txtACFid.Text = Convert.ToString(row["ACFid"]);
                //txtACFdescripcion.Text = Convert.ToString(row["ACFdescripcion"]);
            }
            else
                MessageBox.Show("No Existe", "Registro");
        }

    


        private void MostrarDatos1(DataTable dat)
        {
            if (dat.Rows.Count > 0)
            {
                DataRow row = dat.Rows[0];
                //guardo datos en variables
                txtCRSserie.Text = Convert.ToString(row["CRSserie"]);
                txtCRSvelocidad.Text = Convert.ToString(row["CRSvelocidad"]);
            }
            else
                MessageBox.Show("No Existe", "Registro");
        }

        private void MostrarRegistro()
        {

            try
            {
                DataTable dat = NacfACFp_Activo_Fijo.Last();
                MostrarDatos(dat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void MostrarRegistro1()
        {
            try
            {
                DataTable dat = NacfCRSt_Caracteristicas.Buscar(txtACFid.Text);
                MostrarDatos1(dat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void tomaTab()
        {
            //if (Activo == 2) tabControl1.SelectedTab = tabPage1;
            //if (Activo == 1) tabControl1.SelectedTab = tabPage2;

            tabControl1.SelectedTab = tabPage0;

        }
        private void Configura()
        {
        }
        //-------------------------------------------------------------------
        private void FrmPostres_miLoad(object sender, EventArgs e)
        {
            this.mostrar();
        }

        private void FrmPostres_Load(object sender, EventArgs e) {}

        
        public void Control_Enter(object sender, EventArgs e)
        {

            ((Control)sender).BackColor = Color.FromArgb(201, 228, 247);
        }

        public void Control_Leave(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.White;
        }

        public static void EstadoText(Control.ControlCollection Controles, bool Limpiar, bool Enabled)
        {
            foreach (Control c in Controles)
            {
                if (c.Parent.Enabled == true)
                {
                    c.Tag = (c.Tag == null ? "" : c.Tag);
                    if ( c is TextBox || c is ComboBox)
                    {
                        if (c is ComboBox && Limpiar)
                        {
                            //INICIALIZA COMBOS
                            ComboBox cmb = (ComboBox)c;
                            if (cmb.Items.Count >= 0)
                            {
                                cmb.Focus();
                                //cmb.SelectedItem = cmb.Items[0];
                            }
                        }                                           

                        if (Limpiar && c.Tag.ToString().IndexOf("NoLimpiar") == -1)
                            c.Text = string.Empty;

                        if (Limpiar && c.Tag.ToString().IndexOf("Z") != -1)
                            c.Text = "0";

                        if (c.Tag.ToString().IndexOf("A") == -1)
                            c.Enabled = Enabled;

                        if (c.Tag.ToString().IndexOf("D") != -1)
                            c.Enabled = false;                                  
                    }
                    else
                    {
                        EstadoText(c.Controls, Limpiar, Enabled);
                    }

                    if (c is CheckBox)
                    {
                        if (c.Tag.ToString().IndexOf("A") == -1)
                            c.Enabled = Enabled;

                        if (c.Tag.ToString().IndexOf("D") != -1)
                            c.Enabled = false;

                        if (Limpiar && c.Tag.ToString().IndexOf("NoLimpiar") == -1)
                            ((CheckBox)c).Checked = false;
                    }

                    if (c is RadioButton)
                    {
                        if (c.Tag.ToString().IndexOf("A") == -1)
                            c.Enabled = Enabled;

                        if (c.Tag.ToString().IndexOf("D") != -1)
                            c.Enabled = false;
                    }

                    if (c is DateTimePicker)
                    {
                        if (c.Tag.ToString().IndexOf("A") == -1)
                            c.Enabled = Enabled;

                        if (c.Tag.ToString().IndexOf("D") != -1)
                            c.Enabled = false;

                        if (Limpiar && c.Tag.ToString().IndexOf("NoLimpiar") == -1)
                            ((DateTimePicker)c).Value = DateTime.Now.Date;
                    }

                    if (c is Button)
                    {
                        if (c.Tag.ToString().IndexOf("A") == -1)
                            c.Enabled = Enabled;

                        if (c.Tag.ToString().IndexOf("D") != -1)
                            c.Enabled = false;
                    }                   
                }
            }
        }

        private void toolStripAgregar_Click(object sender, EventArgs e) {}

        private void toolStripImportar_Click(object sender, EventArgs e) {}

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(txtACFid.Text));
            FrmacfTRNt_terrenodetallecs FrmacfTRNt_terrenodetallecs = new FrmacfTRNt_terrenodetallecs();
            FrmacfTRNt_terrenodetallecs.AFCidex = "22";
                //Convert.ToString(txtACFid.Text);
            FrmacfTRNt_terrenodetallecs.ShowDialog();
        }

        private void btnUbicacion_electrica_Click(object sender, EventArgs e)
        {
            Form FrmacfUBEt_UbicacionElectrica = new FrmacfUBEt_UbicacionElectrica();
            FrmacfUBEt_UbicacionElectrica.ShowDialog();
        }

        private void toolStripImagen_Click(object sender, EventArgs e)
        {
            Form FormImagen = new FormImagen();
            FormImagen.ShowDialog();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        private void toolStripSiguiente_Click(object sender, EventArgs e)
        {
        }

        private void txtACFvutiltribanio_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtACFvutiltribanio.Text)) 
                ﻿txtACFvutiltribanio.Text = "0";
        }

        private void txtACFfactortrib_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtACFfactortrib.Text)) 
                ﻿txtACFfactortrib.Text = "0";
        }

        private void txtACFvalortrib_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtACFvalortrib.Text)) 
                ﻿txtACFvalortrib.Text = "0";
        }

        private void txtACFvutiltribdia_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtACFvutiltribdia.Text)) 
                ﻿txtACFvutiltribdia.Text = "0";
        }

        private void txtACFdepacutrib_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtACFdepacutrib.Text)) 
                ﻿txtACFdepacutrib.Text = "0";
        }

        private void txtACFdepacuniif_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtACFdepacuniif.Text))
                txtACFdepacuniif.Text = "0";
        }

        private void txtACFvalorniif_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtACFvalorniif.Text))
                txtACFvalorniif.Text = "0";
        }

        private void txtACFvutilniifdia_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtACFvutilniifdia.Text))
                txtACFvutilniifdia.Text = "0";
        }

        private void txtACFfactorniif_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtACFfactorniif.Text))
                txtACFfactorniif.Text = "0";
        }

        private void txtACFvutilniifanio_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtACFvutilniifanio.Text))
                txtACFvutilniifanio.Text = "0";

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void cboBLART_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void txtACFfcapitalizacion_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtACFfcapitalizacion.Text))
                txtACFfcapitalizacion.Text = "0";

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

            this.dataGridView1.DataSource = NacfCRSt_Caracteristicas.Buscar(txtACFid.Text);
            MostrarRegistro1();
        }

        private void txtCRScodigoagua_TextChanged(object sender, EventArgs e)
        {

        }





    }
}
//-------------------------------------------------------------------
