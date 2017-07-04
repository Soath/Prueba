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
    public partial class Frm_PRMVAR : KryptonForm
    {

        int Activo = 1;
        int Graba = 0;
        public int idEditar = 0;
        public string MensError;
        private static Frm_PRMVAR _Instancia;

        public static Frm_PRMVAR GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new Frm_PRMVAR();
            }
            return _Instancia;
        }
        public Frm_PRMVAR()
        {
            InitializeComponent();


            this.toolStripRefrescar.Click += new System.EventHandler(this.Control_Click_Refrescar);
            this.toolStripAgregar.Click += new System.EventHandler(this.Control_Click_Agregar);
            this.toolStripEditar.Click += new System.EventHandler(this.Control_Click_Editar);
            this.toolStripEliminar.Click += new System.EventHandler(this.Control_Click_Eliminar);
            this.toolStripImprimir.Click += new System.EventHandler(this.Control_Click_Imprimir);
            this.toolStripGuardar.Click += new System.EventHandler(this.Control_Click_Guardar);
            this.toolStripCancelar.Click += new System.EventHandler(this.Control_Click_Cancelar);




            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(Control_Click_dataListado);
            this.Load += new System.EventHandler(this.Frm_PRMVAR_miLoad);
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.ttMensaje.SetToolTip(txtGRP_id, "Ingrese el Valor de Idpostre");
            this.ttMensaje.SetToolTip(txtGRPid_variable, "Ingrese el Valor de Nombre");
            //this.ttMensaje.SetToolTip(txtAMBambiente, "Ingrese el Valor de Precio");
            //this.ttMensaje.SetToolTip(txtStock, "Ingrese el Valor de Stock");
            //this.txtAMBid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_KeyPress_Idpostre);
            //this.txtLOCid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_KeyPress_Nombre);
            //this.txtAMBambiente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_KeyPress_Precio);

        }
        //--------------------------------------------------------------------------------------------------	
        // insertar aqui todos los procedimientos para ABC	
        //--------------------------------------------------------------------------------------------------	
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

        private void Control_Click_dataListado(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            this.tomaTab();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscarNombre();
        }
        //  --------------------------------------------------------------------
        //private void Control_KeyPress_Idpostre(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == 13) this.GetNextControl(ActiveControl, true).Focus();
        //    if (e.KeyChar == 27) this.BotonRefrescar();
        //    if (((e.KeyChar) < 48 && e.KeyChar != 8 && e.KeyChar != 44) || e.KeyChar > 57) e.Handled = true;
        //}
        //private void Control_KeyPress_Nombre(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == 13) this.GetNextControl(ActiveControl, true).Focus();
        //    if (e.KeyChar == 27) this.GetNextControl(ActiveControl, false).Focus();
        //    string cadena = e.KeyChar.ToString().ToUpper();
        //    e.KeyChar = Convert.ToChar(cadena);
        //}
        //private void Control_KeyPress_Precio(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == 13) this.GetNextControl(ActiveControl, true).Focus();
        //    if (e.KeyChar == 27) this.GetNextControl(ActiveControl, false).Focus();
        //    if (((e.KeyChar) < 48 && e.KeyChar != 8 && e.KeyChar != 46) || e.KeyChar > 57) e.Handled = true;
        //    string cadena = this.txtAMBambiente.Text;
        //    if (e.KeyChar == 46 && cadena.Contains(".")) e.Handled = true;
        //    int i = 0;
        //    int p = 0;
        //    while (i < cadena.Length)
        //    {
        //        if (cadena[i] == '.') p = i;
        //        i++;
        //    }
        //    if (cadena.Contains(".") && e.KeyChar != 8 && (cadena.Length - p) > 2) e.Handled = true;
        //}
        // private void Control_KeyPress_Stock(object sender, KeyPressEventArgs e)
        // {
        //     if (e.KeyChar == 13) this.GetNextControl(ActiveControl, true).Focus();
        //     if (e.KeyChar == 27) this.GetNextControl(ActiveControl, false).Focus();
        //     if (((e.KeyChar) < 48 && e.KeyChar != 8 && e.KeyChar != 46) || e.KeyChar > 57) e.Handled = true;
        //     //string cadena = this.txtStock.Text;
        //     if (e.KeyChar == 46 && cadena.Contains(".")) e.Handled = true;
        //     int i = 0;
        //     int p = 0;
        //     while (i < cadena.Length)
        //     {
        //         if (cadena[i] == '.') p = i;
        //         i++;
        //     }
        //     if (cadena.Contains(".") && e.KeyChar != 8 && (cadena.Length - p) > 2) e.Handled = true;
        // }
        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            //            if (e.KeyChar == (char)Keys.Return)
            if (e.KeyChar == 27) this.Close();
        }
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
            this.toolStripEliminar.Visible = false;
            this.toolStripImprimir.Visible = edo;

            this.toolStripGuardar.Visible = !edo;
            this.toolStripCancelar.Visible = !edo;


        }

        private void BotonesSinReg(bool edo)
        {

            this.toolStripRefrescar.Enabled = edo;
            this.toolStripAgregar.Enabled = !edo;
            this.toolStripEditar.Enabled = edo;
            this.toolStripEliminar.Enabled = false;
            this.toolStripImprimir.Enabled = edo;

        }

        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = true;
            this.dataListado.Columns[1].Width = 100;
            this.dataListado.Columns[1].DefaultCellStyle.Format = "#,0";
            this.dataListado.Columns[1].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataListado.Columns[2].Width = 250;
            this.dataListado.Columns[1].HeaderText = "Id";
            this.dataListado.Columns[2].HeaderText = "Configuraciones";

            //this.dataListado.Columns[4].HeaderText = "Stock";
        }

        private void mostrar()
        {
            this.Configura();
            this.Activo = 1;
            this.tomaTab();
            this.Botones(true);
            this.dataListado.DataSource = N_PRMVAR.Mostrar();
            OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
            if (dataListado.Rows.Count == 0)
            {
                BotonesSinReg(false);
            }
            else
            {
                BotonesSinReg(true);
                this.toolStripAgregar.Enabled = true;

            }
            this.dataListado.Select();
            this.dataListado.Focus();
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

        private void BotonRefrescar()
        {
            this.txtBuscar.Text = "";

            this.mostrar();
            button1.Visible = false;
        }
        private void BotonAgregar()
        {
            Activo = 2;
            Graba = 1;
            this.LimpiaCampos();
            this.Botones(false);
            tabControl1.SelectedTab = tabPage2;
            this.txtGRP_id.Focus();
            this.txtGRP_id.Visible = false;

        }

        private void BotonEditar()
        {
            Activo = 2;
            Graba = 2;
            this.Botones(false);
            tabControl1.SelectedTab = tabPage2;
            this.CargaDatos();
            this.txtGRP_id.Focus();
        }
        private void BotonEliminar()
        {

            this.borrauno();
            this.mostrar();
        }
        private void BotonImprimir()
        {
            FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_ACTactividad.rdlc", N_PRMVAR.Mostrar(), "ip");
            rptalu.ShowDialog();
        }

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
            tabControl1.SelectedTab = tabPage1;
           button1.Visible = false;
        }

        private void BotonListado()
        {
            //        if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)	
            //           {	
            //              DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];	
            //             ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);	
            //          }	

        }

        public void LimpiaCampos()
        {
            this.txtGRP_id.Text = "0";
            this.txtGRPid_variable.Text = string.Empty;
            this.txtPRM_descripcion.Text = string.Empty;
            this.txtPRM_valor.Text = string.Empty;
            this.txtPRM_estado.Text = string.Empty;
            this.txtPRM_frmnombre.Text = string.Empty;
            // this.txtStock.Text = string.Empty;
        }
        public DataGridViewRow ObtenerSeleccion()
        {
            DataGridViewRow filaSeleccionada = this.dataListado.Rows[this.dataListado.CurrentRow.Index];
            return filaSeleccionada;
        }
        private void CargaDatos()
        {
            idEditar = 0;
            idEditar = Convert.ToInt32(this.ObtenerSeleccion().Cells[1].Value);
            this.txtGRP_id.Text = Convert.ToString(this.ObtenerSeleccion().Cells[1].Value);
            this.txtGRPid_variable.Text = Convert.ToString(this.ObtenerSeleccion().Cells[2].Value);
            this.txtPRM_descripcion.Text = Convert.ToString(this.ObtenerSeleccion().Cells[3].Value);
            this.txtPRM_valor.Text = Convert.ToString(this.ObtenerSeleccion().Cells[4].Value);
            this.txtPRM_estado.Text = Convert.ToString(this.ObtenerSeleccion().Cells[5].Value);
            this.txtPRM_frmnombre.Text = Convert.ToString(this.ObtenerSeleccion().Cells[6].Value);
            //this.txtStock.Text = Convert.ToString(this.ObtenerSeleccion().Cells[4].Value);
            //CARGA COMBOS
            if (txtPRM_descripcion.Text == "Tabla1")
            {


                button1.Visible = true;

            }
            if (txtPRM_descripcion.Text == "Tabla2")
            {


                button1.Visible = true;

            }
            if (txtPRM_descripcion.Text == "Tabla3")
            {


                button1.Visible = true;

            }
            if (txtPRM_descripcion.Text == "Tabla4")
            {
                button1.Visible = true;


            }
            if (txtPRM_descripcion.Text == "Tabla5")
            {


                button1.Visible = true;


            }
            if (txtPRM_descripcion.Text == "Tabla6")
            {


                button1.Visible = true;

            }
            if (txtPRM_descripcion.Text == "Tabla7")
            {

                button1.Visible = true;

            }
            if (txtPRM_descripcion.Text == "Tabla8")
            {

                button1.Visible = true;

            }
            if (txtPRM_descripcion.Text == "Tabla9")
            {

                button1.Visible = true;

            }
            
        }
     

        private bool validaCampos()
        {
            if (this.txtGRP_id.Text == string.Empty)
            {
                errorIcono.SetError(txtGRP_id, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el id";
                this.txtGRP_id.Focus();
                return false;
            }
            if (this.txtGRPid_variable.Text == string.Empty)
            {
                errorIcono.SetError(txtGRPid_variable, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar la variable";
                this.txtGRPid_variable.Focus();
                return false;
            }
            if(this.txtPRM_descripcion.Text == string.Empty)
            {
                errorIcono.SetError(txtPRM_descripcion, "Ingrese el dato por favor . . . ");
                this.MensError = "Falta ingresar la descripción";
                this.txtGRPid_variable.Focus();
                return false;
            }
            if (this.txtPRM_valor.Text == string.Empty)
            {
                errorIcono.SetError(txtPRM_valor, "Ingrese el dato por favor . . . ");
                this.MensError = "Falta ingresar el valor";
                this.txtPRM_valor.Focus();
                return false;
            }
            if (this.txtPRM_estado.Text == string.Empty) 
            {
                errorIcono.SetError(txtPRM_estado, "Ingrese el dato por favor . . . ");
                this.MensError = "Falta ingresar el estado";
                this.txtPRM_estado.Focus();
                return false;
            }
            if (this.txtPRM_frmnombre.Text == string.Empty) 
            {
                errorIcono.SetError(txtPRM_frmnombre, "Ingrese el dato por favor . . . ");
                this.MensError = "Falta ingresar el nombre del formulario";
                this.txtPRM_frmnombre.Focus();
                return false;
            }

            //if (this.txtStock.Text == string.Empty)
            //{
            //    errorIcono.SetError(txtStock, "Ingrese el dato por Favor..");
            //    this.MensError = "Falta ingresar el valor de Stock";
            //    this.txtStock.Focus();
            //    return false;
            //}
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
                Rta = N_PRMVAR.Insertar(this.txtGRPid_variable.Text, this.txtPRM_descripcion.Text, this.txtPRM_valor.Text, this.txtPRM_estado.Text, this.txtPRM_frmnombre.Text);

                if (Rta.Equals("OK"))
                {
                    this.MensajeOk("Regsitro Acgregado Correctamente");
                }
                else
                {
                    this.MensajeError("Error al Insertar Registro ");
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
                Rta = N_PRMVAR.Editar(this.txtGRP_id.Text, this.txtGRPid_variable.Text, this.txtPRM_descripcion.Text, this.txtPRM_valor.Text, this.txtPRM_estado.Text, this.txtPRM_frmnombre.Text);
                if (Rta.Equals("OK"))
                {
                    this.MensajeOk("Regsitro Actualizado Correctamente");
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
                Codigo = Convert.ToString(this.dataListado.CurrentRow.Cells[1].Value);
                Rta = N_PRMVAR.Eliminar(Codigo);

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

        private void borramuchos()
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema de escolar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Rta = string.Empty;

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rta = N_PRMVAR.Eliminar(Codigo);

                            if (Rta.Equals("OK"))
                            {
                                this.MensajeOk("Se Eliminó Correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError("Error al Eliminar el Registro ...");
                            }

                        }
                    }
                    this.mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void buscarNombre()
        {
            if (this.txtBuscar.Text == "") this.mostrar();
            else
            {
                this.dataListado.DataSource = N_PRMVAR.Buscar(this.txtBuscar.Text);
                this.OcultarColumnas();
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
            }
        }
        private void tomaTab()
        {
            if (Activo == 3) tabControl1.SelectedTab = tabPage3;
            if (Activo == 2) tabControl1.SelectedTab = tabPage2;
            if (Activo == 1) tabControl1.SelectedTab = tabPage1;
        }
        private void Configura()
        {

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.dataListado.Dock = DockStyle.Fill;	
            this.txtGRP_id.TabIndex = 1;
            this.txtGRP_id.TextAlign = HorizontalAlignment.Right;
            this.txtGRPid_variable.TabIndex = 2;
        }
        //-------------------------------------------------------------------
        private void Frm_PRMVAR_miLoad(object sender, EventArgs e)
        {
            this.mostrar();
        }

        private void Frm_PRMVAR_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Activo = 3;
            tabControl1.SelectedTab = tabPage3;
            if (txtPRM_descripcion.Text == "Tabla1")
            {
               

                this.datalistado1.DataSource = Nacf_BajaTension.Mostrar();

            }
            if (txtPRM_descripcion.Text == "Tabla2")
            {
             

                this.datalistado1.DataSource = NACFCODNIIF_SistELECTRICO.Mostrar();

            }
            if (txtPRM_descripcion.Text == "Tabla3")
            {
             

                this.datalistado1.DataSource = NACF_FACTTRANSFORMADORES.Mostrar();

            }
            if (txtPRM_descripcion.Text == "Tabla4")
            {
                 this.datalistado1.DataSource = NACF_MEDIATENSION.Mostrar();


            }
            if (txtPRM_descripcion.Text == "Tabla5")
            {
        

                this.datalistado1.DataSource = NACF_ValorResidual.Mostrar();


            }
            if (txtPRM_descripcion.Text == "Tabla6")
            {
             

                this.datalistado1.DataSource = NACF_ValorResidualNiff.Mostrar();

            }
            if (txtPRM_descripcion.Text == "Tabla7")
            {
                
                this.datalistado1.DataSource = NACF_Valuacion.Mostrar();

            }
            if (txtPRM_descripcion.Text == "Tabla8")
            {
               
                this.datalistado1.DataSource = NACF_VIDAUTILTASADA.Mostrar();

            }
            if (txtPRM_descripcion.Text == "Tabla9")
            {
                
                this.datalistado1.DataSource = NACFVR_IDENT.Mostrar();

            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Activo = 3; 
            tabControl1.SelectedTab = tabPage3;
            if (txtPRM_descripcion.Text == "Tabla1")
            {


                this.datalistado1.DataSource = Nacf_BajaTension.Mostrar();

            }
            if (txtPRM_descripcion.Text == "Tabla2")
            {


                this.datalistado1.DataSource = NACFCODNIIF_SistELECTRICO.Mostrar();

            }
            if (txtPRM_descripcion.Text == "Tabla3")
            {


                this.datalistado1.DataSource = NACF_FACTTRANSFORMADORES.Mostrar();

            }
            if (txtPRM_descripcion.Text == "Tabla4")
            {
                this.datalistado1.DataSource = NACF_MEDIATENSION.Mostrar();


            }
            if (txtPRM_descripcion.Text == "Tabla5")
            {


                this.datalistado1.DataSource = NACF_ValorResidual.Mostrar();


            }
            if (txtPRM_descripcion.Text == "Tabla6")
            {


                this.datalistado1.DataSource = NACF_ValorResidualNiff.Mostrar();

            }
            if (txtPRM_descripcion.Text == "Tabla7")
            {

                this.datalistado1.DataSource = NACF_Valuacion.Mostrar();

            }
            if (txtPRM_descripcion.Text == "Tabla8")
            {

                this.datalistado1.DataSource = NACF_VIDAUTILTASADA.Mostrar();

            }
            if (txtPRM_descripcion.Text == "Tabla9")
            {

                this.datalistado1.DataSource = NACFVR_IDENT.Mostrar();

            }
            
        }
    }
}
