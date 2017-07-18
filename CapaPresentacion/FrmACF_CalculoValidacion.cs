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

using CapaNegocio;

namespace CapaPresentacion
{
    //
    public partial class FrmACF_CalculoValidacion : KryptonForm
    {
        int Activo = 1;
        int Graba = 0;
        public int idEditar = 0;
        public string MensError;
        private static FrmACF_CalculoValidacion _Instancia;

        public static FrmACF_CalculoValidacion GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FrmACF_CalculoValidacion();
            }
            return _Instancia;
        }
        public FrmACF_CalculoValidacion()
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

            EstadoText(this.Controls, true, false);
            mostrar();
            MostrarRegistro();
            MostrarCombos();

            CheckAll(this, true);
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
            Prev(txtRVAcodigo.Text);
            //PrevDataGRid(txtRVAcodigo.Text);
        }
        private void Control_Click_Next(object sender, EventArgs e)
        {
            Next(txtRVAcodigo.Text);
            //NextDataGRid(txtRVAcodigo.Text);
        }
        private void Control_Click_Top(object sender, EventArgs e)
        {
            Top();
            //PrevDataGRid(txtRVAcodigo.Text);
        }
        private void Control_Click_Last(object sender, EventArgs e)
        {
            Last();
            //NextDataGRid(txtRVAcodigo.Text);
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
            this.MostrarRegistro();
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

            this.toolStripGuardar.Visible = !edo;
            this.toolStripCancelar.Visible = !edo;
            this.toolStripPrimero.Visible = edo;
            this.toolStripAnterior.Visible = edo;
            this.toolStripSiguiente.Visible = edo;
            this.toolStripUltimo.Visible = edo;
        }

        private void BotonesSinReg(bool edo)
        {
            this.toolStripRefrescar.Enabled = edo;
            this.toolStripAgregar.Enabled = !edo;
            this.toolStripEditar.Enabled = edo;
            this.toolStripEliminar.Enabled = edo;
            this.toolStripImprimir.Enabled = edo;
            this.toolStripPrimero.Enabled = edo;
            this.toolStripAnterior.Enabled = edo;
            this.toolStripSiguiente.Enabled = edo;
            this.toolStripUltimo.Enabled = edo;
        }

        private void OcultarColumnas() { }

        private void mostrar()
        {
            this.Configura();
            this.Activo = 1;
            this.tomaTab();
            this.Botones(true);

            //this.dataListado.DataSource = NacfRVAt_registrovaluacion.Mostrar(); //(txtRVAcodigo.Text);
            //
            //lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
            //if (dataListado.Rows.Count == 0)
            //{
            //    //  BotonesSinReg(false);
            //}
            //else
            //{
            //    //  BotonesSinReg(true);
            //    //  this.toolStripAgregar.Enabled = true;
            //
            //}
            //this.dataListado.Select();
            //this.dataListado.Focus();

        }
        private void Top()
        {
            try
            {
                DataTable dat = NacfRVAt_registrovaluacion.Top();

                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];
                    txtRVAcodigo.Text = Convert.ToString(row["RVAcodigo"]);
                    txtRVAperiodo.Text = Convert.ToString(row["RVAperiodo"]);
                    dtpRVAfecha.Text = Convert.ToString(row["RVAfecha"]);
                    txtRVAresponsable.Text = Convert.ToString(row["RVAresponsable"]);
                    txtRVRestado.Text = Convert.ToString(row["RVRestado"]);

                }
                else
                    MessageBox.Show("No Existe", "Registro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Next(String RVAcodigo)
        {
            try
            {
                DataTable dat = NacfRVAt_registrovaluacion.Next(RVAcodigo);
                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];
                    txtRVAcodigo.Text = Convert.ToString(row["RVAcodigo"]);
                    txtRVAperiodo.Text = Convert.ToString(row["RVAperiodo"]);
                    dtpRVAfecha.Text = Convert.ToString(row["RVAfecha"]);
                    txtRVAresponsable.Text = Convert.ToString(row["RVAresponsable"]);
                    txtRVRestado.Text = Convert.ToString(row["RVRestado"]);

                }
                else
                   MessageBox.Show("No Existe", "Registro");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Prev(String RVAcodigo)
        {
            try
            {
                DataTable dat = NacfRVAt_registrovaluacion.Prev(RVAcodigo);

                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];
                    txtRVAcodigo.Text = Convert.ToString(row["RVAcodigo"]);
                    txtRVAperiodo.Text = Convert.ToString(row["RVAperiodo"]);
                    dtpRVAfecha.Text = Convert.ToString(row["RVAfecha"]);
                    txtRVAresponsable.Text = Convert.ToString(row["RVAresponsable"]);
                    txtRVRestado.Text = Convert.ToString(row["RVRestado"]);
                }
                else
                MessageBox.Show("No Existe", "Registro");

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
                DataTable dat = NacfRVAt_registrovaluacion.Last();

                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];
                    txtRVAcodigo.Text = Convert.ToString(row["RVAcodigo"]);
                    txtRVAperiodo.Text = Convert.ToString(row["RVAperiodo"]);
                    dtpRVAfecha.Text = Convert.ToString(row["RVAfecha"]);
                    txtRVAresponsable.Text = Convert.ToString(row["RVAresponsable"]);
                    txtRVRestado.Text = Convert.ToString(row["RVRestado"]);
                }
                else
                    MessageBox.Show("No Existe", "Registro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Serch()
        {
            //this.toolStripComboBox1.Enabled = true;
            //this.toolStripTextBox1.Enabled = true;
        }
        private void BotonImportar()
        {
            //Form FrmExcel = new FrmExcel();
            //FrmExcel.Show();
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
            Last();

            if (string.IsNullOrWhiteSpace(txtRVAcodigo.Text))
            {
                txtRVAcodigo.Text = "1";
            }
            else txtRVAcodigo.Text = Convert.ToString(Convert.ToInt32(txtRVAcodigo.Text) + 1);
            txtRVAperiodo.Text = "";
            dtpRVAfecha.Text = "";
            txtRVAresponsable.Text = "";
            txtRVRestado.Text = "";
            cboclase.Text = "";
            txtruta.Text = "";
            txtHoja.Text = "";
        }

        private void BotonEditar()
        {
            Activo = 2;
            Graba = 2;
            this.Botones(false);
            EstadoText(this.Controls, false, true);
            this.CargaDatos();
        }
        private void BotonEliminar()
        {
            this.borrauno();
            this.mostrar();
        }
        private void BotonImprimir() { }

        private void BotonGuardar()
        {
            if (this.validaCampos())
            {
                if (Graba == 1) this.InsertaRegistro(); this.GrabarDGV();
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
        }
        private void BotonListado()
        {
            //        if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)	
            //           {	
            //              DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];	
            //             ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);	
            //          }	

        }

        public void LimpiaCampos() { }
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
            MessageBox.Show("insertar");
            try
            {
                Rta = NacfRVAt_registrovaluacion.Insertar(
                      this.txtRVAcodigo.Text
                     , this.txtRVAperiodo.Text
                     , this.dtpRVAfecha.Text
                     , this.txtRVAresponsable.Text
                     , this.txtRVRestado.Text
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
                Rta = NacfRVAt_registrovaluacion.Editar(
                 this.txtRVAcodigo.Text
                , this.txtRVAperiodo.Text
                , this.dtpRVAfecha.Text
                , this.txtRVAresponsable.Text
                , this.txtRVRestado.Text
                );

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
            NacfRVAt_registrovaluacion.Buscar("1");
        }

        private void MostrarCombos()
        {
            NacfRVAt_registrovaluacion.Buscar("1");
        }
        private void MostrarRegistro()
        {

            try
            {
                DataTable dat = NacfRVAt_registrovaluacion.Mostrar();

                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];

                    txtRVAcodigo.Text = Convert.ToString(row["RVAcodigo"]);
                    txtRVAperiodo.Text = Convert.ToString(row["RVAperiodo"]);
                    dtpRVAfecha.Text = Convert.ToString(row["RVAfecha"]);
                    txtRVAresponsable.Text = Convert.ToString(row["RVAresponsable"]);
                    txtRVRestado.Text = Convert.ToString(row["RVRestado"]);
                }
                else
                    MessageBox.Show("No Existe", "Registro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void tomaTab()
        {
            //if (Activo == 2) tabControl1.SelectedTab = tabPage2;
            //if (Activo == 1) tabControl1.SelectedTab = tabPage1;
        }
        private void Configura()
        {
        }
        //-------------------------------------------------------------------
        private void FrmACF_CalculoValidacion_miLoad(object sender, EventArgs e)
        {
            this.mostrar();
        }

        private void FrmACF_CalculoValidacion_Load(object sender, EventArgs e) { }


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
                    if (c is TextBox || c is ComboBox)
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

        private void toolStripAgregar_Click(object sender, EventArgs e) { }

        private void toolStripImportar_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            Form FrmacfTRNt_terrenodetallecs = new FrmacfTRNt_terrenodetallecs();
            FrmacfTRNt_terrenodetallecs.ShowDialog();
        }

        private void btnUbicacion_electrica_Click(object sender, EventArgs e)
        {
            Form FrmACF_CalculoValidacion = new FrmACF_CalculoValidacion();
            FrmACF_CalculoValidacion.ShowDialog();
        }

        private void toolStripSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void FrmACF_CalculoValidacion_Load_1(object sender, EventArgs e)
        {

        }
        private void NextDataGRid(String RVAcodigo)
        {
            //this.dataListado.DataSource = NacfRVAt_registrovaluacion.Mostrar(); // (RVAcodigo);
        }

        private void PrevDataGRid(String RVAcodigo)
        {
            //this.dataListado.DataSource = NacfRVAt_registrovaluacion.Mostrar(); //(RVAcodigo);
        }

        private void tsProcesar_Click(object sender, EventArgs e)
        {
            //NacfRVAt_registrovaluacion.Copiar(txtRVAcodigo.Text);
            mostrar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Form Frm_Excel_Valuacion = new Frm_Excel_Valuacion();
            //Frm_Excel_Valuacion.ShowDialog();

            
        }

        private void btn331_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile1 = new OpenFileDialog();
            openfile1.Filter = "Excel Files |*.*";
            openfile1.Title = "Seleccione el archivo de Excel";
            if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openfile1.FileName.Equals("") == false)
                {
                    txtruta.Text = openfile1.FileName;
                    // MessageBox.Show("Espere Mientras esta Cargando el Documento en Excel", "Atencion");
                    //  MessageBoxTemporal.Show("Espere Mientras esta Cargando el Documento en Excel", "Atencion", 3, true);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtHoja.Text == string.Empty)
            {
                MessageBox.Show("Inserte el nombre de la HOJA");
            }
            else
            {
                int x = cboclase.SelectedIndex;
                MessageBox.Show(Convert.ToString(x));
                switch(x)
                {
                    case 0:
                        try
                        {
                            tabControl1.SelectedIndex = 0;
                            string hoja;
                            hoja = txtHoja.Text;
                            new Importar().importarExcelca(this.txtruta.Text.Trim(), dgv331, hoja, true);
                            lbl331.Text = "Total de Registros: " + Convert.ToString(dgv331.Rows.Count);
                        }
                        catch (Exception ex)
                        {
                        }
                        break;
                    case 1:
                        try
                        {
                            tabControl1.SelectedIndex = 1;
                            string hoja;
                            hoja = txtHoja.Text;
                            new Importar().importarExcelca(this.txtruta.Text.Trim(), dgv332, hoja, true);
                            lbl332.Text = "Total de Registros: " + Convert.ToString(dgv332.Rows.Count);
                        }
                        catch (Exception ex)
                        {
                        }
                        break;
                    case 2:
                        try
                        {
                            tabControl1.SelectedIndex = 2;
                            string hoja;
                            hoja = txtHoja.Text;
                            new Importar().importarExcelca(this.txtruta.Text.Trim(), dgv333, hoja, true);
                            lbl333.Text = "Total de Registros: " + Convert.ToString(dgv333.Rows.Count);
                        }
                        catch (Exception ex)
                        {
                        }
                        break;
                }
            }
        }

        private void GrabarDGV()
        {
            int x331, x332, x333;
            if((x331 = dgv331.Rows.Count) > 0)
            {
                try
                {
                    foreach (DataGridViewRow row in dgv331.Rows)
                    {
                        string Rta = string.Empty;

                        Rta = NacfTRNt_terrenodetalle.Insertar(
                              Convert.ToString(row.Cells[18].Value)     //CRSnombrepredio 
                              , Convert.ToString(row.Cells[3].Value)   //CRScentropoblado  
                              ,""//, Convert.ToString(row.Cells[xxx].Value)   //CRSdepartamento 
                              , ""//, Convert.ToString(row.Cells[xxx].Value)   //CRSinterior 
                              , ""//, Convert.ToString(row.Cells[xxx].Value)   //CRScarretera
                              , ""//, Convert.ToString(row.Cells[xxx].Value)   //CRSkilometro 
                              , Convert.ToString(row.Cells[6].Value)   //ACFArea 
                              , Convert.ToString(row.Cells[7].Value)   //ACFvalor
                              , ""//, Convert.ToString(row.Cells[xxx].Value)   //ACFtc       
                              , Convert.ToString(row.Cells[8].Value)   //ACFvalorSoles
                              , Convert.ToString(row.Cells[9].Value)   //ACFValorDolar
                              , Convert.ToString(row.Cells[10].Value)   //ACFValorAnt0 
                              ,"80"//, Convert.ToString(row.Cells[xxx].Value)   //ACFVutilniff --- valor por defecto 80
                              , Convert.ToString(row.Cells[12].Value)   //ACFNetopcga 
                              , Convert.ToString(row.Cells[13].Value)   //ACFvalorATri    
                              , Convert.ToString(row.Cells[19].Value)   //ACFid 
                              , Convert.ToString(row.Cells[20].Value)   //ACFdiferencia 
                              , Convert.ToString(row.Cells[21].Value)   //ACFDifTemDedu 
                              , Convert.ToString(row.Cells[22].Value)   //ACFDifTemGrav 
                              , ""//, Convert.ToString(row.Cells[xxx].Value)   //ACFTasaIR            
                              , Convert.ToString(row.Cells[24].Value)   //ACFSaldoDeducible 
                              , Convert.ToString(row.Cells[25].Value)   //ACFSaldoGravable  
                              , txtRVAcodigo.Text//, Convert.ToString(row.Cells[xxx].Value)   //RVAcodigo 
                              , Convert.ToString(row.Cells[5].Value)   //ACFUbicacion
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
                    MessageBox.Show("Terranos Ingresados");
                }
            }

            if ((x332 = dgv332.Rows.Count) > 0)
            {
            }

            if ((x333 = dgv333.Rows.Count) > 0)
            {
            }

        }

    }
}
//-------------------------------------------------------------------
