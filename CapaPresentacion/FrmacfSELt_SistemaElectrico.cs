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
    public partial class FrmacfSELt_SistemaElectrico : KryptonForm
    {

        int Activo = 1;
        int Graba = 0;
        public int idEditar = 0;
        public string MensError;
        private static FrmacfSELt_SistemaElectrico _Instancia;

        public static FrmacfSELt_SistemaElectrico GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FrmacfSELt_SistemaElectrico();
            }
            return _Instancia;
        }
        public FrmacfSELt_SistemaElectrico()
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
            this.Load += new System.EventHandler(this.FrmacfSELt_SistemaElectrico_miLoad);
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.ttMensaje.SetToolTip(txtSELid, "Ingrese el Valor de Idpostre");
            this.ttMensaje.SetToolTip(txtSELsistemaelectrico, "Ingrese el Valor de Nombre");
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
            this.dataListado.DataSource = NacfSELt_SistemaElectrico.Mostrar();

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
            this.txtSELid.Focus();

        }

        private void BotonEditar()
        {
            Activo = 2;
            Graba = 2;
            this.Botones(false);
            tabControl1.SelectedTab = tabPage2;
            this.CargaDatos();
            this.txtSELid.Focus();
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
            FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_SELSistemaElectrico.rdlc", NacfSELt_SistemaElectrico.Mostrar());
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
            this.txtSELid.Text = "0";
            this.txtSELsistemaelectrico.Text = string.Empty;
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
            this.txtSELid.Text = Convert.ToString(this.ObtenerSeleccion().Cells[1].Value);
            this.txtSELsistemaelectrico.Text = Convert.ToString(this.ObtenerSeleccion().Cells[2].Value);
            this.txtSEGMENT.Text = Convert.ToString(this.ObtenerSeleccion().Cells[3].Value);
        }
        private bool validaCampos()
        {
            if (this.txtSELid.Text == string.Empty)
            {
                errorIcono.SetError(txtSELid, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el código de sistema electrico";
                this.txtSELid.Focus();
                return false;
            }
            if (this.txtSELsistemaelectrico.Text == string.Empty)
            {
                errorIcono.SetError(txtSELsistemaelectrico, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar la Descripción de sistema electrico";
                this.txtSELsistemaelectrico.Focus();
                return false;
            }
            if (this.txtSEGMENT.Text == string.Empty)
            {
                errorIcono.SetError(txtSELsistemaelectrico, "Ingrese el dato por Favor..");
                this.MensError = "Falta ingresar el codigo de segmento.";
                this.txtSEGMENT.Focus();
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
                Rta = NacfSELt_SistemaElectrico.Insertar(this.txtSELid.Text, this.txtSELsistemaelectrico.Text, this.txtSEGMENT.Text);

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
                Rta = NacfSELt_SistemaElectrico.Editar(this.txtSELid.Text, this.txtSELsistemaelectrico.Text, this.txtSEGMENT.Text);
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
                Rta = NacfSELt_SistemaElectrico.Eliminar(Codigo);

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
                            Rta = NacfSELt_SistemaElectrico.Eliminar(Codigo);

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
                this.dataListado.DataSource = NacfSELt_SistemaElectrico.Buscar(this.txtBuscar.Text);
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
            this.txtSELid.TabIndex = 1;
            this.txtSELid.TextAlign = HorizontalAlignment.Right;
            this.txtSELsistemaelectrico.TabIndex = 2;
            this.groupBox2.Text = "Sistema Electrico";
        }
        //-------------------------------------------------------------------
        private void FrmacfSELt_SistemaElectrico_miLoad(object sender, EventArgs e)
        {
            this.mostrar();
        }

        private void FrmacfSELt_SistemaElectrico_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmacfSELt_SistemaElectrico_Load_1(object sender, EventArgs e)
        {

        }
    }
}
