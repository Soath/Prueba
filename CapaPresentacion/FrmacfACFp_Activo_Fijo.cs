using System;
using System.Collections.Generic;
using ComponentFactory.Krypton.Toolkit;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

using CapaNegocio;

namespace CapaPresentacion
{
    //
    public partial class FrmacfACFp_Activo_Fijo : KryptonForm
    {
        int Activo = 1;
        int Graba = 0;
        int Data1 = 0;
        public int idEditar = 0;
        public string MensError;
        public string mACFid;
        public string Canul;
        public static Control anulado = new Control();
        public static Control baja = new Control();
        public static BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
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
            Anulado();
            Baja();

            MostrarRegistro();
            MostrarRegistro1();               
          
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
            this.BotonCancelar();
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
            MessageBox.Show(mensaje, "Control del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Control del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CodigodeBarra()        {
            
        }
        private void Anulado()
            {

            anulado.Size = new Size(400, 400);
            anulado.BackColor = Color.Red;
            GraphicsPath contorno = new GraphicsPath();
            Matrix rotacion = new Matrix();
            contorno.AddString("Anulado", FontFamily.GenericSansSerif,
            (int)FontStyle.Regular, 70, new Point(40, 0),
            StringFormat.GenericDefault);
            rotacion.Translate(0, 380);
            rotacion.Rotate(-45);
            contorno.Transform(rotacion);
            anulado.Region = new Region(contorno);
            this.Controls.Add(anulado);
            anulado.BringToFront();
            anulado.Visible=false;
            }

        private void Baja()
        {

            baja.Size = new Size(400, 400);
            baja.BackColor = Color.Red;
            GraphicsPath contorno = new GraphicsPath();
            Matrix rotacion = new Matrix();
            contorno.AddString("Baja", FontFamily.GenericSansSerif,
            (int)FontStyle.Regular, 70, new Point(40, 0),
            StringFormat.GenericDefault);
            rotacion.Translate(0, 380);
            rotacion.Rotate(-45);
            contorno.Transform(rotacion);
            baja.Region = new Region(contorno);
            this.Controls.Add(baja);
            baja.BringToFront();
            baja.Visible = false;
        }



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

            this.CtxtACFtipo_activo.Items.Add("AF");
            this.CtxtACFtipo_activo.Items.Add("NC");

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


            // combos de Detalle
            this.cboMARid.DataSource = NacfMARt_Marca.Mostrar();
            this.cboMARid.ValueMember = "MARid";
            this.cboMARid.DisplayMember = "MARid";
            this.cboMARid.SelectedIndex = -1;

            this.cboESTid.DataSource = NacfESTt_Estado.Mostrar();
            this.cboESTid.ValueMember = "ESTid";
            this.cboESTid.DisplayMember = "ESTid";
            this.cboESTid.SelectedIndex = -1;

            this.cboMATid.DataSource = NacfMATt_Material.Mostrar();
            this.cboMATid.ValueMember = "MATid";
            this.cboMATid.DisplayMember = "MATid";
            this.cboMATid.SelectedIndex = -1;

            this.cboUNMid.DataSource = NacfUNMt_Unimed.Mostrar();
            this.cboUNMid.ValueMember = "UNMid";
            this.cboUNMid.DisplayMember = "UNMid";
            this.cboUNMid.SelectedIndex = -1;

            this.cmbACFid_Padre.DataSource = NacfACFp_Activo_Fijo.Mostrar3();
            this.cmbACFid_Padre.ValueMember = "ACFid";
            this.cmbACFid_Padre.DisplayMember = "ACFid";
            this.cmbACFid_Padre.SelectedIndex = -1;

            this.cbocrp.DataSource = NacfCRPt_Centro_Responsabilidad.Mostrar();
            this.cbocrp.ValueMember = "CRPid_crp";
            this.cbocrp.DisplayMember = "CRPid_crp";
            this.cbocrp.SelectedIndex = -1;

        }
        private void Top()
        {
            try
            {
                DataTable dat = NacfACFp_Activo_Fijo.Top();
                MostrarDatos(dat);
                tomaTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            MostrarRegistro1();
        }

        private void Next(String iACFid)
        {
            try
            {
                DataTable dat = NacfACFp_Activo_Fijo.Next(iACFid);
                MostrarDatos(dat);
                tomaTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            MostrarRegistro1();
        }

        private void Prev(String iACFid)
        {
            try
            {
                DataTable dat = NacfACFp_Activo_Fijo.Prev(iACFid);
                MostrarDatos(dat);
                tomaTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            MostrarRegistro1();
        }

        private void Actual(string AFCid)
        {
            try
            {
                DataTable dat = NacfACFp_Activo_Fijo.Actual(AFCid);
                MostrarDatos(dat);
                tomaTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            MostrarRegistro1();
        }


        private void Last()
        {
            try
            {
                DataTable dat = NacfACFp_Activo_Fijo.Last();
                MostrarDatos(dat);
                tomaTab();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            MostrarRegistro1();
        }



        private void Serch()
        {
            this.toolStripComboBox1.Enabled = true;
            this.toolStripTextBox1.Enabled = true;
            Form FrmBuscar = new FrmacfACFp_Activo_Fijo_Buscar();
            FrmBuscar.ShowDialog();

            string IdActi = FrmacfACFp_Activo_Fijo_Buscar.IdAct;
           
            Actual(IdActi);

        }
        private void FormularioImagen()
        {
            FormImagen.idacf = txtACFid.Text;
            FormImagen.tipoacf = CtxtACFtipo_activo.Text;
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
            Data1 = 0;
        }
        private void BotonAgregar()
        {
            Activo = 2;
            Graba = 1;
            EstadoText(this.Controls, true, true);
            Last();
            this.LimpiaCampos();
            this.Botones(false);
            Data1 = 0;
            cboBUKRS.Text = "0300";
            txtACFid.Text = Convert.ToString(Convert.ToInt32(mACFid) + 1);
            cboBUKRS.Enabled = false;
            textEmpresa.Enabled = false;

            //tabControl1.SelectedTab = tabPage2;

            limpiar1();
        }
        private void limpiar1()
        {
            txtACFdepacuniif.Text = "0";
            txtACFdepacutrib.Text = "0";
            txtACFfcapitalizacion.Text = "0";
            txtACFvutilniifanio.Text = "0";
            txtACFfactorniif.Text = "0";
            txtACFvutilniifdia.Text = "0";
            txtACFvalorniif.Text = "0";
            txtACFvutiltribanio.Text = "0";
            txtACFvutiltribdia.Text = "0";
            txtACFvalortrib.Text = "0";
            txtACFfactortrib.Text = "0";
        }

        private void BotonEditar()
        {
            Activo = 2;
            Graba = 2;
            this.Botones(false);
            EstadoText(this.Controls, false, true);
            txtACFid.Enabled=false;
            cboBUKRS.Enabled = false;
            textEmpresa.Enabled = false;
           // tabControl1.SelectedTab = tabPage2;
            this.CargaDatos();
            Data1 = 0;

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
                this.BotonRefrescar();
                Data1 = 0;

            }
            else
                this.MensajeOk(MensError);
        }
        private void BotonCancelar()
        {
            Activo = 0;
            this.Botones(true);
            EstadoText(this.Controls, false, false);
            //tabControl1.SelectedTab = tabPage1;
            Actual(txtACFid.Text);
            Data1 = 0;
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
            //ValidarDatos(this.Controls);


            if (this.cboBLART.Text == string.Empty)
            {
                errorIcono.SetError(cboBLART, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.cboBLART.Focus();
                return false;
            }
            else
                errorIcono.Clear();

            if (this.cboBUKRS.Text == string.Empty)
            {
                errorIcono.SetError(cboBUKRS, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.cboBUKRS.Focus();
                return false;
            }
            else
                errorIcono.Clear();


            if (this.cboSEGMENT.Text == string.Empty)
            {
                errorIcono.SetError(cboSEGMENT, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.cboSEGMENT.Focus();
                return false;
            }
            else
                errorIcono.Clear();


            if (this.cboANLKL.Text == string.Empty)
            {
                errorIcono.SetError(cboANLKL, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.cboANLKL.Focus();
                return false;
            }
            else
                errorIcono.Clear();


            if (this.cboPERNR.Text == string.Empty)
            {
                errorIcono.SetError(cboPERNR, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.cboPERNR.Focus();
                return false;
            }
            else
                errorIcono.Clear();



            if (this.cboCSTid.Text == string.Empty)
            {
                errorIcono.SetError(cboCSTid, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.cboCSTid.Focus();
                return false;
            }
            else
                errorIcono.Clear();

            if (this.cboMVMid.Text == string.Empty)
            {
                errorIcono.SetError(cboMVMid, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.cboMVMid.Focus();
                return false;
            }
            else
                errorIcono.Clear();

            if (this.cboVNRid.Text == string.Empty)
            {
                errorIcono.SetError(cboVNRid, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.cboVNRid.Focus();
                return false;
            }
            else
                errorIcono.Clear();

            if (this.cboCMPid.Text == string.Empty)
            {
                errorIcono.SetError(cboCMPid, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.cboCMPid.Focus();
                return false;
            }
            else
                errorIcono.Clear();

            if (this.cboLIFNR.Text == string.Empty)
            {
                errorIcono.SetError(cboLIFNR, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.cboLIFNR.Focus();
                return false;
            }
            else
                errorIcono.Clear();

            if (this.cboBLART.Text == string.Empty)
            {
                errorIcono.SetError(cboBLART, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.cboBLART.Focus();
                return false;
            }
            else
                errorIcono.Clear();

            if (this.cboKOSTL.Text == string.Empty)
            {
                errorIcono.SetError(cboKOSTL, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.cboKOSTL.Focus();
                return false;
            }
            else
                errorIcono.Clear();


            if (this.cboAMBid.Text == string.Empty)
            {
                errorIcono.SetError(cboAMBid, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.cboAMBid.Focus();
                return false;
            }
            else
                errorIcono.Clear();

            if (this.cboUBEid.Text == string.Empty)
            {
                errorIcono.SetError(cboUBEid, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.cboUBEid.Focus();
                return false;
            }
            else
                errorIcono.Clear();

            if (this.cboV_T087U_ANLUE.Text == string.Empty)
            {
                errorIcono.SetError(cboV_T087U_ANLUE, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.cboV_T087U_ANLUE.Focus();
                return false;
            }
            else
                errorIcono.Clear();

            if (this.cboMARid.Text == string.Empty)
            {
                errorIcono.SetError(cboMARid, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.cboMARid.Focus();
                return false;
            }
            else
                errorIcono.Clear();


            // combos de Detalle
            if (this.cboESTid.Text == string.Empty)
            {
                errorIcono.SetError(cboESTid, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.cboESTid.Focus();
                return false;
            }
            else
                errorIcono.Clear();

            if (this.cboMATid.Text == string.Empty)
            {
                errorIcono.SetError(cboMATid, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.cboMATid.Focus();
                return false;
            }
            else
                errorIcono.Clear();

            if (this.cboUNMid.Text == string.Empty)
            {
                errorIcono.SetError(cboUNMid, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.cboUNMid.Focus();
                return false;
            }
            else
                errorIcono.Clear();

            if (this.cbocrp.Text == string.Empty)
            {
                errorIcono.SetError(cbocrp, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.cbocrp.Focus();
                return false;
            }
            else
                errorIcono.Clear();

            if (this.CtxtACFtipo_activo.Text == string.Empty)
            {
                errorIcono.SetError(CtxtACFtipo_activo, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el valor";
                this.CtxtACFtipo_activo.Focus();
                return false;
            }
            else
                errorIcono.Clear();

            return true;
        }


        public static bool ValidarDatos(Control.ControlCollection Controles)
        {
            bool Valido = true;
            for (int I = 0; I <= Controles.Count - 1; I++)
            {
                Control c = Controles[I];
                if (c.Parent.Enabled == true)
                {
          
                    if (c is TextBox || c is ComboBox)
                    {
                        if (c.Text == string.Empty)
                        {
                            c.Tag = (c.Tag == null ? "" : c.Tag);
                            if (c.Tag.ToString().IndexOf("O") == -1 )
                            {
                                MessageBox.Show("Ingrese Datos Correctamente ![" + c.Name + " " + c.GetType().ToString() + "]", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                c.Focus();
                                Valido = false;
                                return Valido;
                            }
                        }
                    }
                    //else
                    //{
                    //    if (c.Controls.Count > 0)
                    //        Valido = Valido && ValidarDatos(c.Controls);
                    //}

                    if (c.Controls.Count > 0)
                        Valido = Valido && ValidarDatos(c.Controls);
                }
            }
            return Valido;

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
                    , ""
                    , "0"
                    , this.txtACFtipo_orden.Text
                    , this.txtOBJid_objeto.Text
                    , this.cbocrp.Text
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

            InsertaRegistro1();
        }

        // Insertar Datos en la tabla de Características.
        private void InsertaRegistro1()
        {
            string Rta = string.Empty;

            try
            {
                Rta = NacfCRSt_Caracteristicas.Insertar(
                          this.txtACFid.Text
                        , this.cboMARid.Text
                        , this.cboESTid.Text
                        , this.txtCRSserie.Text
                        , this.txtCRSmodelo.Text
                        , this.txtCRScolor.Text
                        , this.cboMATid.Text
                        , this.txtCRStipo.Text
                        , this.cboUNMid.Text
                        , this.txtCRScantidad.Text
                        , this.cboCRSvehplaca.Text
                        , this.txtCRSvehexpediente.Text
                        , this.dtpCRSvehinscripcion.Text
                        , this.txtCRSvehclase.Text
                        , this.txtCRSvehcombustible.Text
                        , this.txtCRSvehejes.Text
                        , this.txtCRSvehpasajeros.Text
                        , this.txtCRSvehasientos.Text
                        , this.txtCRSvehpesoseco.Text
                        , this.txtCRSvehcargautil.Text
                        , this.txtCRSaltura.Text
                        , this.txtCRSancho.Text
                        , this.txtCRSvelocidad.Text
                        , this.txtCRSresolucion.Text
                        , this.txtCRScapacidad.Text
                        , this.txtCRSpotencia.Text
                        , this.txtCRSvnominal.Text
                        , this.txtCRSventrada.Text
                        , this.txtCRSvsalida.Text
                        , this.txtCRSfrecuencia.Text
                        , this.txtCRStemperatura.Text
                        , this.txtCRSprocesador.Text
                        , this.txtCRSpuertos.Text
                        , this.txtCRSutmx.Text
                        , this.txtCRSutmy.Text
                        , this.txtCRSesfuerzopunta.Text
                        , this.txtCRScajaderivadora.Text
                        , this.txtCRSalquilacable.Text
                        , this.txtCRScentropoblado.Text
                        , this.txtCRSurbanizacion.Text
                        , this.txtCRScalle.Text
                        , this.txtCRSlote.Text
                        , this.txtCRSnumeropredio.Text
                        , this.txtCRSdepartamento.Text
                        , this.txtCRSinterior.Text
                        , this.txtCRScarretera.Text
                        , this.txtCRSkilometro.Text
                        , this.txtCRSnombrepredio.Text
                        , this.txtCRSpisospredio.Text
                        , this.txtCRSpartidapredio.Text
                        , this.txtCRStomopredio.Text
                        , this.txtCRSfolioinipredio.Text
                        , this.txtCRSfoliofinpredio.Text
                        , this.txtCRSasientopredio.Text
                        , this.dtpCRSfinscpredio.Text
                        , this.txtCRSficharegistral.Text
                        , this.txtCRSareaconstruida.Text
                        , this.txtCRSperimetro.Text
                        , this.txtCRSusopredio.Text
                        , this.txtCRSvalorautovaluo.Text
                        , this.txtCRScodigoluz.Text
                        , this.txtCRScodigoagua.Text
                        , this.dtpCRSfadqpredio.Text
                        , this.txtCRSobservacion.Text
                        );
                
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
                    , ""
                    , "0"
                    , this.txtACFtipo_orden.Text
                    , this.txtOBJid_objeto.Text
                    , this.cbocrp.Text//cbocrp.SelectedValue.ToString()
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
            //ActualizarRegistros1()
            ActualizarRegistros1();
        }

        // Actualizar Datos en la tabla de Características.
        private void ActualizarRegistros1()
        {
            string Rta = string.Empty;

            try
            {
                Rta = NacfCRSt_Caracteristicas.Editar(
                          this.txtACFid.Text
                        , this.cboMARid.Text
                        , this.cboESTid.Text
                        , this.txtCRSserie.Text
                        , this.txtCRSmodelo.Text
                        , this.txtCRScolor.Text
                        , this.cboMATid.Text
                        , this.txtCRStipo.Text
                        , this.cboUNMid.Text
                        , this.txtCRScantidad.Text
                        , this.cboCRSvehplaca.Text
                        , this.txtCRSvehexpediente.Text
                        , this.dtpCRSvehinscripcion.Text
                        , this.txtCRSvehclase.Text
                        , this.txtCRSvehcombustible.Text
                        , this.txtCRSvehejes.Text
                        , this.txtCRSvehpasajeros.Text
                        , this.txtCRSvehasientos.Text
                        , this.txtCRSvehpesoseco.Text
                        , this.txtCRSvehcargautil.Text
                        , this.txtCRSaltura.Text
                        , this.txtCRSancho.Text
                        , this.txtCRSvelocidad.Text
                        , this.txtCRSresolucion.Text
                        , this.txtCRScapacidad.Text
                        , this.txtCRSpotencia.Text
                        , this.txtCRSvnominal.Text
                        , this.txtCRSventrada.Text
                        , this.txtCRSvsalida.Text
                        , this.txtCRSfrecuencia.Text
                        , this.txtCRStemperatura.Text
                        , this.txtCRSprocesador.Text
                        , this.txtCRSpuertos.Text
                        , this.txtCRSutmx.Text
                        , this.txtCRSutmy.Text
                        , this.txtCRSesfuerzopunta.Text
                        , this.txtCRScajaderivadora.Text
                        , this.txtCRSalquilacable.Text
                        , this.txtCRScentropoblado.Text
                        , this.txtCRSurbanizacion.Text
                        , this.txtCRScalle.Text
                        , this.txtCRSlote.Text
                        , this.txtCRSnumeropredio.Text
                        , this.txtCRSdepartamento.Text
                        , this.txtCRSinterior.Text
                        , this.txtCRScarretera.Text
                        , this.txtCRSkilometro.Text
                        , this.txtCRSnombrepredio.Text
                        , this.txtCRSpisospredio.Text
                        , this.txtCRSpartidapredio.Text
                        , this.txtCRStomopredio.Text
                        , this.txtCRSfolioinipredio.Text
                        , this.txtCRSfoliofinpredio.Text
                        , this.txtCRSasientopredio.Text
                        , this.dtpCRSfinscpredio.Text
                        , this.txtCRSficharegistral.Text
                        , this.txtCRSareaconstruida.Text
                        , this.txtCRSperimetro.Text
                        , this.txtCRSusopredio.Text
                        , this.txtCRSvalorautovaluo.Text
                        , this.txtCRScodigoluz.Text
                        , this.txtCRScodigoagua.Text
                        , this.dtpCRSfadqpredio.Text
                        , this.txtCRSobservacion.Text
                        );

                if (Rta.Equals("OK"))
                {
                    this.MensajeOk("Registro Actualizado Correctamente");
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
        // Elimina Registros	
        //-----------------------------------------------------------------------------------	
        private void borrauno()
        {
            string Rta = string.Empty;
            DialogResult Opcion;
            Opcion = MessageBox.Show("Realmente Desea Anular los Registros", "Sistema de Activos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                if (Canul=="1")
                    Rta = NacfACFp_Activo_Fijo.Eliminar(txtACFid.Text,"0");
                else
                    Rta = NacfACFp_Activo_Fijo.Eliminar(txtACFid.Text, "1");

                Actual(txtACFid.Text); 
                if (Rta.Equals("OK"))
                {
                    this.MensajeOk("Se Anulo Correctamente el registro");
                }
                else
                {
                    this.MensajeError("Error al Anular el Registro ");
                }

            }
        }
        
        private void buscarNombre()
        {
            NacfACFp_Activo_Fijo.Actual("1");
        }

        private void MostrarDatos(DataTable dat)
        {
            if (dat.Rows.Count > 0)
            {
                DataRow row = dat.Rows[0];
                //guardo datos en variables
                cbarra.Text = Convert.ToString(row["ACFid"]);
                mACFid = Convert.ToString(row["ACFid"]);
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
                CtxtACFtipo_activo.Text = Convert.ToString(row["ACFtipo_activo"]).Trim();
                Canul = Convert.ToString(row["ACFAnulado"]);
                cmbACFid_Padre.Text = Convert.ToString(row["ACFid_Padre"]);
                txtACFtipo_orden.Text = Convert.ToString(row["ACFtipo_orden"]);
                cbocrp.Text = Convert.ToString(row["CRPid_crp"]);
                CodigodeBarra();

                

                if (String.IsNullOrEmpty(Canul))
                     {
                       anulado.Visible=false;
                       baja.Visible = false;
                      
                     }
                else
                    
                    if (Canul == "1") anulado.Visible = true;
                    if (Canul == "2") baja.Visible = true;
                    if (Canul == "0") anulado.Visible = false;
                    if (Canul == "0") baja.Visible = false;
                    if (Canul == " ") anulado.Visible = false;
                    if (Canul == " ") baja.Visible = false;

            }

            else
                 MessageBox.Show("No Existe", "Registro");

            btnTerreno_Edificaciones.Enabled = true;
            btnUbicacion_electrica.Enabled = true; 

        }

    


        private void MostrarDatos1(DataTable dat)
        {
            if (dat.Rows.Count > 0)
            {
                DataRow row = dat.Rows[0];
                //guardo datos en variables
                //txtCRSserie.Text = Convert.ToString(row["CRSserie"]);
                //txtCRSvelocidad.Text = Convert.ToString(row["CRSvelocidad"]);

                textACFidC.Text = Convert.ToString(row["ACFid"]);
                cboMARid.Text = Convert.ToString(row["MARid"]);
                cboESTid.Text = Convert.ToString(row["ESTid"]);
                txtCRSserie.Text = Convert.ToString(row["CRSserie"]);
                txtCRSmodelo.Text = Convert.ToString(row["CRSmodelo"]);
                txtCRScolor.Text = Convert.ToString(row["CRScolor"]);
                cboMATid.Text = Convert.ToString(row["MATid"]);
                txtCRStipo.Text = Convert.ToString(row["CRStipo"]);
                cboUNMid.Text = Convert.ToString(row["UNMid"]);
                txtCRScantidad.Text = Convert.ToString(row["CRScantidad"]);
                cboCRSvehplaca.Text = Convert.ToString(row["CRSvehplaca"]);
                txtCRSvehexpediente.Text = Convert.ToString(row["CRSvehexpediente"]);
                dtpCRSvehinscripcion.Text = Convert.ToString(row["CRSvehinscripcion"]);
                txtCRSvehclase.Text = Convert.ToString(row["CRSvehclase"]);
                txtCRSvehcombustible.Text = Convert.ToString(row["CRSvehcombustible"]);
                txtCRSvehejes.Text = Convert.ToString(row["CRSvehejes"]);
                txtCRSvehpasajeros.Text = Convert.ToString(row["CRSvehpasajeros"]);
                txtCRSvehasientos.Text = Convert.ToString(row["CRSvehasientos"]);
                txtCRSvehpesoseco.Text = Convert.ToString(row["CRSvehpesoseco"]);
                txtCRSvehcargautil.Text = Convert.ToString(row["CRSvehcargautil"]);
                txtCRSaltura.Text = Convert.ToString(row["CRSaltura"]);
                txtCRSancho.Text = Convert.ToString(row["CRSancho"]);
                txtCRSvelocidad.Text = Convert.ToString(row["CRSvelocidad"]);
                txtCRSresolucion.Text = Convert.ToString(row["CRSresolucion"]);
                txtCRScapacidad.Text = Convert.ToString(row["CRScapacidad"]);
                txtCRSpotencia.Text = Convert.ToString(row["CRSpotencia"]);
                txtCRSvnominal.Text = Convert.ToString(row["CRSvnominal"]);
                txtCRSventrada.Text = Convert.ToString(row["CRSventrada"]);
                txtCRSvsalida.Text = Convert.ToString(row["CRSvsalida"]);
                txtCRSfrecuencia.Text = Convert.ToString(row["CRSfrecuencia"]);
                txtCRStemperatura.Text = Convert.ToString(row["CRStemperatura"]);
                txtCRSprocesador.Text = Convert.ToString(row["CRSprocesador"]);
                txtCRSpuertos.Text = Convert.ToString(row["CRSpuertos"]);
                txtCRSutmx.Text = Convert.ToString(row["CRSutmx"]);
                txtCRSutmy.Text = Convert.ToString(row["CRSutmy"]);
                txtCRSesfuerzopunta.Text = Convert.ToString(row["CRSesfuerzopunta"]);
                txtCRScajaderivadora.Text = Convert.ToString(row["CRScajaderivadora"]);
                txtCRSalquilacable.Text = Convert.ToString(row["CRSalquilacable"]);
                txtCRScentropoblado.Text = Convert.ToString(row["CRScentropoblado"]);
                txtCRSurbanizacion.Text = Convert.ToString(row["CRSurbanizacion"]);
                txtCRScalle.Text = Convert.ToString(row["CRScalle"]);
                txtCRSlote.Text = Convert.ToString(row["CRSlote"]);
                txtCRSnumeropredio.Text = Convert.ToString(row["CRSnumeropredio"]);
                txtCRSdepartamento.Text = Convert.ToString(row["CRSdepartamento"]);
                txtCRSinterior.Text = Convert.ToString(row["CRSinterior"]);
                txtCRScarretera.Text = Convert.ToString(row["CRScarretera"]);
                txtCRSkilometro.Text = Convert.ToString(row["CRSkilometro"]);
                txtCRSnombrepredio.Text = Convert.ToString(row["CRSnombrepredio"]);
                txtCRSpisospredio.Text = Convert.ToString(row["CRSpisospredio"]);
                txtCRSpartidapredio.Text = Convert.ToString(row["CRSpartidapredio"]);
                txtCRStomopredio.Text = Convert.ToString(row["CRStomopredio"]);
                txtCRSfolioinipredio.Text = Convert.ToString(row["CRSfolioinipredio"]);
                txtCRSfoliofinpredio.Text = Convert.ToString(row["CRSfoliofinpredio"]);
                txtCRSasientopredio.Text = Convert.ToString(row["CRSasientopredio"]);
                dtpCRSfinscpredio.Text = Convert.ToString(row["CRSfinscpredio"]);
                txtCRSficharegistral.Text = Convert.ToString(row["CRSficharegistral"]);
                txtCRSareaconstruida.Text = Convert.ToString(row["CRSareaconstruida"]);
                txtCRSperimetro.Text = Convert.ToString(row["CRSperimetro"]);
                txtCRSusopredio.Text = Convert.ToString(row["CRSusopredio"]);
                txtCRSvalorautovaluo.Text = Convert.ToString(row["CRSvalorautovaluo"]);
                txtCRScodigoluz.Text = Convert.ToString(row["CRScodigoluz"]);
                txtCRScodigoagua.Text = Convert.ToString(row["CRScodigoagua"]);
                dtpCRSfadqpredio.Text = Convert.ToString(row["CRSfadqpredio"]);
                txtCRSobservacion.Text = Convert.ToString(row["CRSobservacion"]);
            }
            else
                {// MessageBox.Show("No Existe", "Registro");

                cboMARid.Text = "";
                cboESTid.Text = "";
                txtCRSserie.Text = "";
                txtCRSmodelo.Text = "";
                txtCRScolor.Text = "";
                cboMATid.Text = "";
                txtCRStipo.Text = "";
                cboUNMid.Text = "";
                txtCRScantidad.Text = "0";
                cboCRSvehplaca.Text = "";
                txtCRSvehexpediente.Text = "";
                dtpCRSvehinscripcion.Text = "";
                txtCRSvehclase.Text = "";
                txtCRSvehcombustible.Text = "";
                txtCRSvehejes.Text = "0";
                txtCRSvehpasajeros.Text = "0";
                txtCRSvehasientos.Text = "0";
                txtCRSvehpesoseco.Text = "0";
                txtCRSvehcargautil.Text = "0";
                txtCRSaltura.Text = "0";
                txtCRSancho.Text = "0";
                txtCRSvelocidad.Text = "";
                txtCRSresolucion.Text = "";
                txtCRScapacidad.Text = "";
                txtCRSpotencia.Text = "";
                txtCRSvnominal.Text = "";
                txtCRSventrada.Text = "";
                txtCRSvsalida.Text = "";
                txtCRSfrecuencia.Text = "";
                txtCRStemperatura.Text = "";
                txtCRSprocesador.Text = "";
                txtCRSpuertos.Text = "";
                txtCRSutmx.Text = "0";
                txtCRSutmy.Text = "0";
                txtCRSesfuerzopunta.Text = "";
                txtCRScajaderivadora.Text = "";
                txtCRSalquilacable.Text = "0";
                txtCRScentropoblado.Text = "";
                txtCRSurbanizacion.Text = "";
                txtCRScalle.Text = "";
                txtCRSlote.Text = "";
                txtCRSnumeropredio.Text = "";
                txtCRSdepartamento.Text = "";
                txtCRSinterior.Text = "";
                txtCRScarretera.Text = "";
                txtCRSkilometro.Text = "0";
                txtCRSnombrepredio.Text = "";
                txtCRSpisospredio.Text = "0";
                txtCRSpartidapredio.Text = "";
                txtCRStomopredio.Text = "";
                txtCRSfolioinipredio.Text = "";
                txtCRSfoliofinpredio.Text = "";
                txtCRSasientopredio.Text = "";
                dtpCRSfinscpredio.Text = "";
                txtCRSficharegistral.Text = "";
                txtCRSareaconstruida.Text = "0";
                txtCRSperimetro.Text = "0";
                txtCRSusopredio.Text = "";
                txtCRSvalorautovaluo.Text = "0";
                txtCRScodigoluz.Text = "";
                txtCRScodigoagua.Text = "";
                dtpCRSfadqpredio.Text = "";
                txtCRSobservacion.Text = "";
                }
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
            Data1 = 0;
        }
        private void Configura()
        {
        }
        //-------------------------------------------------------------------

        
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
                                cmb.Text = "";

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
            
            FrmacfTRNt_terrenodetallecs FrmacfTRNt_terrenodetallecs = new FrmacfTRNt_terrenodetallecs();
            FrmacfTRNt_terrenodetallecs.txtACFid.Text = Convert.ToString(txtACFid.Text);
            FrmacfTRNt_terrenodetallecs.Graba = Graba;
            FrmacfTRNt_terrenodetallecs.ShowDialog();
        }

        private void btnUbicacion_electrica_Click(object sender, EventArgs e)
        {
            FrmacfUBEt_UbicacionElectrica FrmacfUBEt_UbicacionElectrica = new FrmacfUBEt_UbicacionElectrica();
            FrmacfUBEt_UbicacionElectrica.txtACFid.Text = Convert.ToString(this.txtACFid.Text);
            FrmacfUBEt_UbicacionElectrica.Graba = Graba;
            FrmacfUBEt_UbicacionElectrica.ShowDialog();
        }

        private void toolStripImagen_Click(object sender, EventArgs e)
        {
            Form FormImagen = new FormImagen();
            FormularioImagen();
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

            
        }

        private void txtCRScodigoagua_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void FrmacfACFp_Activo_Fijo_Load(object sender, EventArgs e)
        {

        }

        private void txtCRScantidad_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCRScantidad.Text))
                txtACFdepacuniif.Text = "0";
        }

        private void txtCRSvehpesoseco_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCRSvehpesoseco.Text))
                txtACFdepacuniif.Text = "0";
        }

        private void txtCRSvehcargautil_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCRSvehcargautil.Text))
                txtACFdepacuniif.Text = "0";
        }

        private void txtCRSaltura_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCRSaltura.Text))
                txtACFdepacuniif.Text = "0";
        }

        private void txtCRSancho_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCRSancho.Text))
                txtACFdepacuniif.Text = "0";
        }

        private void txtCRSutmx_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCRSutmx.Text))
                txtACFdepacuniif.Text = "0";
        }

        private void txtCRSutmy_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCRSutmy.Text))
                txtACFdepacuniif.Text = "0";
        }

        private void txtCRSkilometro_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCRSkilometro.Text))
                txtACFdepacuniif.Text = "0";
        }

        private void txtCRSareaconstruida_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCRSareaconstruida.Text))
                txtACFdepacuniif.Text = "0";
        }

        private void txtCRSperimetro_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCRSperimetro.Text))
                txtACFdepacuniif.Text = "0";
        }

        private void txtCRSvalorautovaluo_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCRSvalorautovaluo.Text))
                txtACFdepacuniif.Text = "0";
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource=NacfACFp_Activo_Fijo.MostrarPadre(txtACFid.Text);

        }

        private void panelResultado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboBLART_Validated(object sender, EventArgs e)
        {
        }

        private void cboANLKL_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tipoa = cboANLKL.Text;
            if (tipoa.Length >3)        {
            String tipoacf = tipoa.Substring(0, 3);
            //MessageBox.Show(tipoacf);
            //int caseSwitch = 1;             
            switch (tipoacf)
            {
                case "333":
                    tabControl1.TabPages["tabPage2"].Enabled = false;
                    tabControl1.TabPages["tabPage3"].Enabled = true;
                    tabControl1.TabPages["tabPage4"].Enabled = false;
                    tabControl1.TabPages["tabPage5"].Enabled = false;
                    break;
                case "332":
                    tabControl1.TabPages["tabPage2"].Enabled = true;
                    tabControl1.TabPages["tabPage3"].Enabled = false;
                    tabControl1.TabPages["tabPage4"].Enabled = false;
                    tabControl1.TabPages["tabPage5"].Enabled = false;
                    break;
                case "331":
                    tabControl1.TabPages["tabPage2"].Enabled = true;
                    tabControl1.TabPages["tabPage3"].Enabled = false;
                    tabControl1.TabPages["tabPage4"].Enabled = false;
                    tabControl1.TabPages["tabPage5"].Enabled = false;
                    break;
                case "334":
                    tabControl1.TabPages["tabPage2"].Enabled = false;
                    tabControl1.TabPages["tabPage3"].Enabled = false;
                    tabControl1.TabPages["tabPage4"].Enabled = true;
                    tabControl1.TabPages["tabPage5"].Enabled = false;
                    break;
                case "336":
                    tabControl1.TabPages["tabPage2"].Enabled = false;
                    tabControl1.TabPages["tabPage3"].Enabled = false;
                    tabControl1.TabPages["tabPage4"].Enabled = false;
                    tabControl1.TabPages["tabPage5"].Enabled = true;
                    break;

                default:
                    Console.WriteLine("Default case");
                    break;
            }
            //tabControl1.SelectedTab = tabPage2;
            }
        }
    }
}
//-------------------------------------------------------------------
