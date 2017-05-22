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
    public partial class FrmacfCMPt_Componente : KryptonForm
    {
        int Activo = 1;
        int Graba = 0;
        public int idEditar = 0;
        public string MensError;
        private static FrmacfCMPt_Componente _Instancia;

        public static FrmacfCMPt_Componente GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FrmacfCMPt_Componente();
            }
            return _Instancia;
        }
        public FrmacfCMPt_Componente()
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
            //this.toolStripBuscar.Click += new System.EventHandler(this.Control_Click_Serch);

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
            Prev(txtCMPid.Text);
            PrevDataGRid(txtCMPid.Text);
        }
        private void Control_Click_Next(object sender, EventArgs e)
        {
            Next(txtCMPid.Text);
            NextDataGRid(txtCMPid.Text);
        }
        private void Control_Click_Top(object sender, EventArgs e)
        {
            Top();
            PrevDataGRid(txtCMPid.Text);
        }
        private void Control_Click_Last(object sender, EventArgs e)
        {
            Last();
            NextDataGRid(txtCMPid.Text);
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

            this.toolStripGuardar.Visible = !edo;
            this.toolStripCancelar.Visible = !edo;
            this.toolStripPrimero.Visible = edo;
            this.toolStripAnterior.Visible = edo;
            this.toolStripSiguiente.Visible = edo;
            this.toolStripUltimo.Visible = edo;
            //this.toolStripBuscar.Visible = edo;
            //this.toolStripComboBox1.Visible = edo;
            //this.toolStripTextBox1.Visible = edo;
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
            //this.toolStripBuscar.Enabled = edo;
            //this.toolStripComboBox1.Enabled = edo;
            //this.toolStripTextBox1.Enabled = edo;
        }

        private void OcultarColumnas() { }

        private void mostrar()
        {
            this.Configura();
            this.Activo = 1;
            this.tomaTab();
            this.Botones(true);

            this.dataListado.DataSource = NacfACFp_Activo_Fijo.Mostrar4("12010101");

            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
            if (dataListado.Rows.Count == 0)
            {
              //  BotonesSinReg(false);
            }
            else
            {
              //  BotonesSinReg(true);
              //  this.toolStripAgregar.Enabled = true;

            }
            this.dataListado.Select();
            this.dataListado.Focus();

        }
        private void Top()
        {
            try
            {
                DataTable dat = NacfCMPt_Componente.Top();

                //ACFdescripcion.Text= dat.Rows[0]["ACFdescripcion"].ToString();

                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];
                    //guardo datos en variables

                    txtCMPid.Text = Convert.ToString(row["CMPid"]);
                    txtCMPcomponente.Text = Convert.ToString(row["CMPcomponente"]);
                    txtCMPusoestimado.Text = Convert.ToString(row["CMPusoestimado"]);
                    txtCMPconservacion.Text = Convert.ToString(row["CMPconservacion"]);
                    txtCMPobsolecencia.Text = Convert.ToString(row["CMPobsolecencia"]);
                    txtCMPlimitelegal.Text = Convert.ToString(row["CMPlimitelegal"]);
                    txtCMPtotalfactores.Text = Convert.ToString(row["CMPtotalfactores"]);
                    txtCMPfactorusoestimado.Text = Convert.ToString(row["CMPfactorusoestimado"]);
                    txtCMPvutilanio.Text = Convert.ToString(row["CMPvutilanio"]);
                    txtCMPvutildia.Text = Convert.ToString(row["CMPvutildia"]);
                    txtCMPnivel.Text = Convert.ToString(row["CMPnivel"]);

                }
                else
                    MessageBox.Show("No Existe", "Registro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Next(String CMPid)
        {
            try
            {
                DataTable dat = NacfCMPt_Componente.Next(CMPid);

                //ACFdescripcion.Text= dat.Rows[0]["ACFdescripcion"].ToString();

                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];
                    //guardo datos en variables
                    txtCMPid.Text = Convert.ToString(row["CMPid"]);
                    txtCMPcomponente.Text = Convert.ToString(row["CMPcomponente"]);
                    txtCMPusoestimado.Text = Convert.ToString(row["CMPusoestimado"]);
                    txtCMPconservacion.Text = Convert.ToString(row["CMPconservacion"]);
                    txtCMPobsolecencia.Text = Convert.ToString(row["CMPobsolecencia"]);
                    txtCMPlimitelegal.Text = Convert.ToString(row["CMPlimitelegal"]);
                    txtCMPtotalfactores.Text = Convert.ToString(row["CMPtotalfactores"]);
                    txtCMPfactorusoestimado.Text = Convert.ToString(row["CMPfactorusoestimado"]);
                    txtCMPvutilanio.Text = Convert.ToString(row["CMPvutilanio"]);
                    txtCMPvutildia.Text = Convert.ToString(row["CMPvutildia"]);
                    txtCMPnivel.Text = Convert.ToString(row["CMPnivel"]);

                }
               // else
                //    MessageBox.Show("No Existe", "Registro");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Prev(String CMPid)
        {
            try
            {
                DataTable dat = NacfCMPt_Componente.Prev(CMPid);

                //ACFdescripcion.Text= dat.Rows[0]["ACFdescripcion"].ToString();

                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];
                    txtCMPid.Text = Convert.ToString(row["CMPid"]);
                    txtCMPcomponente.Text = Convert.ToString(row["CMPcomponente"]);
                    txtCMPusoestimado.Text = Convert.ToString(row["CMPusoestimado"]);
                    txtCMPconservacion.Text = Convert.ToString(row["CMPconservacion"]);
                    txtCMPobsolecencia.Text = Convert.ToString(row["CMPobsolecencia"]);
                    txtCMPlimitelegal.Text = Convert.ToString(row["CMPlimitelegal"]);
                    txtCMPtotalfactores.Text = Convert.ToString(row["CMPtotalfactores"]);
                    txtCMPfactorusoestimado.Text = Convert.ToString(row["CMPfactorusoestimado"]);
                    txtCMPvutilanio.Text = Convert.ToString(row["CMPvutilanio"]);
                    txtCMPvutildia.Text = Convert.ToString(row["CMPvutildia"]);
                    txtCMPnivel.Text = Convert.ToString(row["CMPnivel"]);
                }
              //  else
                   // MessageBox.Show("No Existe", "Registro");

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
                DataTable dat = NacfCMPt_Componente.Last();

                //ACFdescripcion.Text= dat.Rows[0]["ACFdescripcion"].ToString();

                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];

                    txtCMPid.Text = Convert.ToString(row["CMPid"]);
                    txtCMPcomponente.Text = Convert.ToString(row["CMPcomponente"]);
                    txtCMPusoestimado.Text = Convert.ToString(row["CMPusoestimado"]);
                    txtCMPconservacion.Text = Convert.ToString(row["CMPconservacion"]);
                    txtCMPobsolecencia.Text = Convert.ToString(row["CMPobsolecencia"]);
                    txtCMPlimitelegal.Text = Convert.ToString(row["CMPlimitelegal"]);
                    txtCMPtotalfactores.Text = Convert.ToString(row["CMPtotalfactores"]);
                    txtCMPfactorusoestimado.Text = Convert.ToString(row["CMPfactorusoestimado"]);
                    txtCMPvutilanio.Text = Convert.ToString(row["CMPvutilanio"]);
                    txtCMPvutildia.Text = Convert.ToString(row["CMPvutildia"]);
                    txtCMPnivel.Text = Convert.ToString(row["CMPnivel"]);
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
        private void BotonImprimir() { }

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
               Rta = NacfCMPt_Componente.Insertar(
                     this.txtCMPid.Text
                    , this.txtCMPcomponente.Text
                    , this.txtCMPusoestimado.Text
                    , this.txtCMPconservacion.Text
                    , this.txtCMPobsolecencia.Text
                    , this.txtCMPlimitelegal.Text
                    , this.txtCMPtotalfactores.Text
                    , this.txtCMPfactorusoestimado.Text
                    , this.txtCMPvutilanio.Text
                    , this.txtCMPvutildia.Text
                    //, this.txtCMPnivel.Text

                  );
                //Rta = NacfCMPt_Componente.Insertar(this.txtCMPid.Text, "1", "1", "1", "1", "1", "2", DateTime.Today.ToString(), "1", this.txtACFdescripcion.Text, DateTime.Today.ToString(), DateTime.Today.ToString(), "0", "0", "0.00", "0", "0", "0", "", "0", "", "", "", "", "", "", "0.00", "0.00", "", "", "1", "", "1", "", "", "", DateTime.Today.ToString(), "1", "", "1", "1", "1", DateTime.Today.ToString(), "1");

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
                Rta = NacfACFp_Activo_Fijo.Editar4(txtCMPvutilanio.Text, txtCMPvutildia.Text, txtCMPvutilanio.Text, txtCMPvutildia.Text, txtCMPid.Text);

                //Rta = NacfCMPt_Componente.Editar("1", "1", "1", "1", "1", "1", "2", DateTime.Today.ToString(), "1", this.txtACFdescripcion.Text, DateTime.Today.ToString(), DateTime.Today.ToString(), "0", "0", "0.00", "0", "0", "0", "", "0", "", "", "", "", "", "", "0.00", "0.00", "", "", "1", "", "1", "", "", "", DateTime.Today.ToString(), "1", "", "1", "1", "1", DateTime.Today.ToString(), "1");

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
            NacfCMPt_Componente.Buscar("1");
        }

        private void MostrarCombos()
        {
            NacfCMPt_Componente.Buscar("1");
        }
        private void MostrarRegistro()
        {

            try
            {
                DataTable dat = NacfCMPt_Componente.Mostrar();

                //ACFdescripcion.Text= dat.Rows[0]["ACFdescripcion"].ToString();

                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];

                    txtCMPid.Text = Convert.ToString(row["CMPid"]);
                    txtCMPcomponente.Text = Convert.ToString(row["CMPcomponente"]);
                    txtCMPusoestimado.Text = Convert.ToString(row["CMPusoestimado"]);
                    txtCMPconservacion.Text = Convert.ToString(row["CMPconservacion"]);
                    txtCMPobsolecencia.Text = Convert.ToString(row["CMPobsolecencia"]);
                    txtCMPlimitelegal.Text = Convert.ToString(row["CMPlimitelegal"]);
                    txtCMPtotalfactores.Text = Convert.ToString(row["CMPtotalfactores"]);
                    txtCMPfactorusoestimado.Text = Convert.ToString(row["CMPfactorusoestimado"]);
                    txtCMPvutilanio.Text = Convert.ToString(row["CMPvutilanio"]);
                    txtCMPvutildia.Text = Convert.ToString(row["CMPvutildia"]);
                    txtCMPnivel.Text = Convert.ToString(row["CMPnivel"]);
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
        private void FrmacfCMPt_Componente_miLoad(object sender, EventArgs e)
        {
            this.mostrar();
        }

        private void FrmacfCMPt_Componente_Load(object sender, EventArgs e) { }


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
            Form FrmacfCMPt_Componente = new FrmacfCMPt_Componente();
            FrmacfCMPt_Componente.ShowDialog();
        }

        private void toolStripSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void FrmacfCMPt_Componente_Load_1(object sender, EventArgs e)
        {

        }
        private void NextDataGRid(String CMPid)
        {
            this.dataListado.DataSource = NacfACFp_Activo_Fijo.Mostrar4(CMPid);
        }

        private void PrevDataGRid(String CMPid)
        {
            this.dataListado.DataSource = NacfACFp_Activo_Fijo.Mostrar4(CMPid);
        }




    }
}
//-------------------------------------------------------------------
