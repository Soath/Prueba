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


            this.chkEliminar.Click += new System.EventHandler(this.Control_Click_ChkEliminar);

            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(Control_Click_dataListado);
            this.Load += new System.EventHandler(this.FrmacfCMPt_Componente_miLoad);
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.ttMensaje.SetToolTip(txtCMPid, "Ingrese el Valor de CMPid");
            this.ttMensaje.SetToolTip(txtCMPcomponente, "Ingrese la descripción de componente");
            this.ttMensaje.SetToolTip(txtCMPusoestimado, "Ingrese el uso estimado.");
            this.ttMensaje.SetToolTip(txtCMPconservacion, "Ingrese la conservacion.");
            this.ttMensaje.SetToolTip(txtCMPobsolecencia, "Ingrese la obsolecencia.");
            this.ttMensaje.SetToolTip(txtCMPlimitelegal, "Ingrese el limite legal.");
            this.ttMensaje.SetToolTip(txtCMPtotalfactores, "Ingrese el total factores.");
            this.ttMensaje.SetToolTip(txtCMPfactorusoestimado, "Ingrese el factor de uso estimado.");
            this.ttMensaje.SetToolTip(txtCMPvutilanio, "Ingrese la vida util por año.");
            this.ttMensaje.SetToolTip(txtCMPvutildia, "Ingrese la vida util por dia .");
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
        private void Control_Click_ChkEliminar(object sender, EventArgs e)
        {
            this.BotonChkEliminar();
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
            this.toolStripEliminar.Visible = edo;
            this.toolStripImprimir.Visible = edo;

            this.toolStripGuardar.Visible = !edo;
            this.toolStripCancelar.Visible = !edo;


        }

        private void BotonesSinReg(bool edo)
        {

            this.toolStripRefrescar.Enabled = edo;
            this.toolStripAgregar.Enabled = !edo;
            this.toolStripEditar.Enabled = edo;
            this.toolStripEliminar.Enabled = edo;
            this.toolStripImprimir.Enabled = edo;

        }

        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
            this.dataListado.Columns[1].Width = 100;
            this.dataListado.Columns[1].DefaultCellStyle.Format = "#,0";
            this.dataListado.Columns[1].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataListado.Columns[2].Width = 250;
            this.dataListado.Columns[3].Width = 100;
            this.dataListado.Columns[3].DefaultCellStyle.Format = "#,0.00";
            this.dataListado.Columns[3].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataListado.Columns[4].Width = 100;
            this.dataListado.Columns[1].HeaderText = "Idpostre";
            this.dataListado.Columns[2].HeaderText = "Nombre";
            this.dataListado.Columns[3].HeaderText = "Precio";
            //this.dataListado.Columns[4].HeaderText = "Stock";
        }

        private void mostrar()
        {
            this.Configura();
            this.Activo = 1;
            this.tomaTab();
            this.Botones(true);
            this.dataListado.DataSource = NacfCMPt_Componente.Mostrar();

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
        private void BotonRefrescar()
        {
            this.txtBuscar.Text = "";
            this.chkEliminar.Checked = false;
            this.mostrar();
        }
        private void BotonAgregar()
        {
            Activo = 2;
            Graba = 1;
            this.LimpiaCampos();
            this.Botones(false);
            tabControl1.SelectedTab = tabPage2;
            this.txtCMPid.Focus();

        }

        private void BotonEditar()
        {
            Activo = 2;
            Graba = 2;
            this.Botones(false);
            tabControl1.SelectedTab = tabPage2;
            this.CargaDatos();
            this.txtCMPid.Focus();
        }
        private void BotonEliminar()
        {
            if (this.chkEliminar.Checked)
                this.borramuchos();
            else
                this.borrauno();
            this.mostrar();
        }
        private void BotonImprimir()
        {
            FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_CMPComponente.rdlc", NacfCMPt_Componente.Mostrar(),"ip");
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
        }
        private void BotonChkEliminar()
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
            this.txtCMPid.Text = "0";
            this.txtCMPcomponente.Text = string.Empty;
            this.txtCMPusoestimado.Text = string.Empty;
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
            //idEditar = Convert.ToInt32(this.ObtenerSeleccion().Cells[1].Value);
            this.txtCMPid.Text = Convert.ToString(this.ObtenerSeleccion().Cells[1].Value);
            this.txtCMPcomponente.Text = Convert.ToString(this.ObtenerSeleccion().Cells[2].Value);
            this.txtCMPusoestimado.Text = Convert.ToString(this.ObtenerSeleccion().Cells[3].Value);
            this.txtCMPconservacion.Text = Convert.ToString(this.ObtenerSeleccion().Cells[4].Value);
            this.txtCMPobsolecencia.Text = Convert.ToString(this.ObtenerSeleccion().Cells[5].Value);
            this.txtCMPlimitelegal.Text = Convert.ToString(this.ObtenerSeleccion().Cells[6].Value);
            this.txtCMPtotalfactores.Text = Convert.ToString(this.ObtenerSeleccion().Cells[7].Value);
            this.txtCMPfactorusoestimado.Text = Convert.ToString(this.ObtenerSeleccion().Cells[8].Value);
            this.txtCMPvutilanio.Text = Convert.ToString(this.ObtenerSeleccion().Cells[9].Value);
            this.txtCMPvutildia.Text = Convert.ToString(this.ObtenerSeleccion().Cells[10].Value);
        }
        private bool validaCampos()
        {
            if (this.txtCMPid.Text == string.Empty)
            {
                errorIcono.SetError(txtCMPid, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el Código de componentes.";
                this.txtCMPid.Focus();
                return false;
            }
            if (this.txtCMPcomponente.Text == string.Empty)
            {
                errorIcono.SetError(txtCMPcomponente, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar la descripción del componente.";
                this.txtCMPcomponente.Focus();
                return false;
            }
            if (this.txtCMPusoestimado.Text == string.Empty)
            {
                errorIcono.SetError(txtCMPusoestimado, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el uso estimado.";
                this.txtCMPusoestimado.Focus();
                return false;
            }
            if (this.txtCMPconservacion.Text == string.Empty)
            {
                errorIcono.SetError(txtCMPconservacion, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar la conservacion";
                this.txtCMPconservacion.Focus();
                return false;
            }
            if (this.txtCMPobsolecencia.Text == string.Empty)
            {
                errorIcono.SetError(txtCMPobsolecencia, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar la obsolecencia";
                this.txtCMPobsolecencia.Focus();
                return false;
            }
            if (this.txtCMPlimitelegal.Text == string.Empty)
            {
                errorIcono.SetError(txtCMPlimitelegal, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el limite legal";
                this.txtCMPlimitelegal.Focus();
                return false;
            }
            if (this.txtCMPtotalfactores.Text == string.Empty)
            {
                errorIcono.SetError(txtCMPtotalfactores, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el total factores.";
                this.txtCMPtotalfactores.Focus();
                return false;
            }
            if (this.txtCMPfactorusoestimado.Text == string.Empty)
            {
                errorIcono.SetError(txtCMPfactorusoestimado, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el factor de uso estimado.";
                this.txtCMPfactorusoestimado.Focus();
                return false;
            }
            if (this.txtCMPvutilanio.Text == string.Empty)
            {
                errorIcono.SetError(txtCMPvutilanio, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar la vida util por año.";
                this.txtCMPvutilanio.Focus();
                return false;
            }
            if (this.txtCMPvutildia.Text == string.Empty)
            {
                errorIcono.SetError(txtCMPvutildia, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar la vida util por día.";
                this.txtCMPvutildia.Focus();
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
                Rta = NacfCMPt_Componente.Insertar(this.txtCMPid.Text, this.txtCMPcomponente.Text, this.txtCMPusoestimado.Text, this.txtCMPconservacion.Text, this.txtCMPobsolecencia.Text, this.txtCMPlimitelegal.Text, this.txtCMPtotalfactores.Text, this.txtCMPfactorusoestimado.Text, this.txtCMPvutilanio.Text, this.txtCMPvutildia.Text);

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
                Rta = NacfCMPt_Componente.Editar(this.txtCMPid.Text, this.txtCMPcomponente.Text, this.txtCMPusoestimado.Text,this.txtCMPconservacion.Text,this.txtCMPobsolecencia.Text,this.txtCMPlimitelegal.Text,this.txtCMPtotalfactores.Text,this.txtCMPfactorusoestimado.Text,this.txtCMPvutilanio.Text,this.txtCMPvutildia.Text);
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
                Rta = NacfCMPt_Componente.Eliminar(Codigo);

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
                            Rta = NacfCMPt_Componente.Eliminar(Codigo);

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
                this.dataListado.DataSource = NacfCMPt_Componente.Buscar(this.txtBuscar.Text);
                this.OcultarColumnas();
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
            }
        }
        private void tomaTab()
        {
            if (Activo == 2) tabControl1.SelectedTab = tabPage2;
            if (Activo == 1) tabControl1.SelectedTab = tabPage1;
        }
        private void Configura()
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //this.dataListado.Dock = DockStyle.Fill;	
            this.txtCMPid.TabIndex = 1;
            this.txtCMPid.TextAlign = HorizontalAlignment.Right;
            this.txtCMPcomponente.TabIndex = 2;
            this.txtCMPusoestimado.TabIndex = 3;
            this.txtCMPusoestimado.TextAlign = HorizontalAlignment.Right;
            
            this.groupBox2.Text = "Componentes";
        }
        //-------------------------------------------------------------------
        private void FrmacfCMPt_Componente_miLoad(object sender, EventArgs e)
        {
            this.mostrar();
        }

        private void FrmacfCMPt_Componente_Load(object sender, EventArgs e)
        {

        }

        private void FrmacfCMPt_Componente_Load_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
