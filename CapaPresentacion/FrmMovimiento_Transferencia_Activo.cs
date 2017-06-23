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
    public partial class FrmMovimiento_Transferencia_Activo : KryptonForm
    {
        int Activo = 1;
        int Graba = 0;
        public int idEditar = 0;
        public string MensError;
        private static FrmMovimiento_Transferencia_Activo _Instancia;

        public static FrmMovimiento_Transferencia_Activo GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FrmMovimiento_Transferencia_Activo();
            }
            return _Instancia;
        }
        public FrmMovimiento_Transferencia_Activo()
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
            // this.toolStripBuscar.Click += new System.EventHandler(this.Control_Click_Serch);

            EstadoText(this.Controls, true, false);
            mostrar();
            MostrarRegistro();
            MostrarCombos();
            CargarCombos();

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
            Prev(txtMVPid_proceso.Text);
            DataGRid(txtMVPid_proceso.Text);
        }
        private void Control_Click_Next(object sender, EventArgs e)
        {
            Next(txtMVPid_proceso.Text);
            DataGRid(txtMVPid_proceso.Text);
        }
        private void Control_Click_Top(object sender, EventArgs e)
        {
            Top();
            DataGRid(txtMVPid_proceso.Text);

        }
        private void Control_Click_Last(object sender, EventArgs e)
        {
            Last();
            DataGRid(txtMVPid_proceso.Text);
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

            // dataListado.Rows.Clear();
            if (dataListado.Rows.Count > 1)
            {
                for (int i = dataListado.Rows.Count - 1; i >= 0; i--)
                {
                    dataListado.Rows.RemoveAt(i);
                }
            }
            this.BotonAgregar();
            //dataListado.DataSource = null;
            //dataListado.ColumnAdded
            //dataListado.Columns.Add("Column1", "ACFid");
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
            //dataListado.DataSource = null;
        }
        private void Control_Click_Cancelar(object sender, EventArgs e)
        {
            this.BotonRefrescar();
            this.MostrarRegistro();
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
        
        private void DataGRid(String iMVAid)
        {
            this.dataListado.DataSource = NacfMVAt_MovimientoActivo.Mostrar(iMVAid);
        }
        private void mostrar()
        {
            this.Configura();
            this.Activo = 1;
            this.tomaTab();
            this.Botones(true);
            this.MostrarRegistro();
        }
        private void Top()
        {
            try
            {
                DataTable dat = NMovimiento_Transferencia_Activo.Top();

                //ACFdescripcion.Text= dat.Rows[0]["ACFdescripcion"].ToString();

                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];
                    //guardo datos en variables
                    txtMVPid_proceso.Text = Convert.ToString(row["MVPid_proceso"]);
                    cboMVPtipo.Text = Convert.ToString(row["MVPtipo"]);
                    txtMVPds_movimiento.Text = Convert.ToString(row["MVPds_movimiento"]);
                    dtpMVPfecha_movimiento.Text = Convert.ToString(row["MVPfecha_movimiento"]);
                    //txtORGid_persona.Text = Convert.ToString(row["ORGid_persona"]);
                    txtORGds_persona.Text = Convert.ToString(row["ORGds_persona"]);
                  //  txtORGid_zona.Text = Convert.ToString(row["ORGid_zona"]);
                    txtORGds_zona.Text = Convert.ToString(row["ORGds_zona"]);
                    txtORGcrp.Text = Convert.ToString(row["ORGcrp"]);
                    txtORGds_crp.Text = Convert.ToString(row["ORGds_crp"]);
                    cboPERNR3.Text = Convert.ToString(row["ORGid_usuario"]);
                    txtORGds_usuario.Text = Convert.ToString(row["ORGds_usuario"]);
                   // txtORGid_ambiente.Text = Convert.ToString(row["ORGid_ambiente"]);
                    txtORGds_ambiente.Text = Convert.ToString(row["ORGds_ambiente"]);
                   // txtDSTid_persona.Text = Convert.ToString(row["DSTid_persona"]);
                    txtDSTds_persona.Text = Convert.ToString(row["DSTds_persona"]);
                  //  txtDSTid_zona.Text = Convert.ToString(row["DSTid_zona"]);
                    txtDSTds_zona.Text = Convert.ToString(row["DSTds_zona"]);
                    txtDSTcrp.Text = Convert.ToString(row["DSTcrp"]);
                    txtDSTds_crp.Text = Convert.ToString(row["DSTds_crp"]);
                    cboPERNR4.Text = Convert.ToString(row["DSTid_usuario"]);
                    txtDSTds_usuario.Text = Convert.ToString(row["DSTds_usuario"]);
                   // txtDSTid_ambiente.Text = Convert.ToString(row["DSTid_ambiente"]);
                    txtDSTds_ambiente.Text = Convert.ToString(row["DSTds_ambiente"]);
                    txtMVPobservaciones.Text = Convert.ToString(row["MVPobservaciones"]);

                }
                else
                    MessageBox.Show("No Existe", "Registro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Next(String iMVPid_proceso)
        {
            try
            {
                DataTable dat = NMovimiento_Transferencia_Activo.Next(iMVPid_proceso);

                //ACFdescripcion.Text= dat.Rows[0]["ACFdescripcion"].ToString();

                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];
                    txtMVPid_proceso.Text = Convert.ToString(row["MVPid_proceso"]);
                    cboMVPtipo.Text = Convert.ToString(row["MVPtipo"]);
                    txtMVPds_movimiento.Text = Convert.ToString(row["MVPds_movimiento"]);
                    dtpMVPfecha_movimiento.Text = Convert.ToString(row["MVPfecha_movimiento"]);
                    cboPERNR1.Text = Convert.ToString(row["ORGid_persona"]);
                    txtORGds_persona.Text = Convert.ToString(row["ORGds_persona"]);
                    cboZONA1.Text = Convert.ToString(row["ORGid_zona"]);
                    txtORGds_zona.Text = Convert.ToString(row["ORGds_zona"]);
                    txtORGcrp.Text = Convert.ToString(row["ORGcrp"]);
                    txtORGds_crp.Text = Convert.ToString(row["ORGds_crp"]);
                    cboPERNR3.Text = Convert.ToString(row["ORGid_usuario"]);
                    txtORGds_usuario.Text = Convert.ToString(row["ORGds_usuario"]);
                    cboAMB1.Text = Convert.ToString(row["ORGid_ambiente"]);
                    txtORGds_ambiente.Text = Convert.ToString(row["ORGds_ambiente"]);
                    cboPERNR2.Text = Convert.ToString(row["DSTid_persona"]);
                    txtDSTds_persona.Text = Convert.ToString(row["DSTds_persona"]);
                    cboZONA2.Text = Convert.ToString(row["DSTid_zona"]);
                    txtDSTds_zona.Text = Convert.ToString(row["DSTds_zona"]);
                    txtDSTcrp.Text = Convert.ToString(row["DSTcrp"]);
                    txtDSTds_crp.Text = Convert.ToString(row["DSTds_crp"]);
                    cboPERNR4.Text = Convert.ToString(row["DSTid_usuario"]);
                    txtDSTds_usuario.Text = Convert.ToString(row["DSTds_usuario"]);
                    cboAMB2.Text = Convert.ToString(row["DSTid_ambiente"]);
                    txtDSTds_ambiente.Text = Convert.ToString(row["DSTds_ambiente"]);
                    txtMVPobservaciones.Text = Convert.ToString(row["MVPobservaciones"]);
                }
                else
                    MessageBox.Show("No Existe", "Registro");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Prev(String iMVPid_proceso)
        {
            try
            {
                DataTable dat = NMovimiento_Transferencia_Activo.Prev(iMVPid_proceso);

                //ACFdescripcion.Text= dat.Rows[0]["ACFdescripcion"].ToString();

                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];
                    txtMVPid_proceso.Text = Convert.ToString(row["MVPid_proceso"]);
                    cboMVPtipo.Text = Convert.ToString(row["MVPtipo"]);
                    txtMVPds_movimiento.Text = Convert.ToString(row["MVPds_movimiento"]);
                    dtpMVPfecha_movimiento.Text = Convert.ToString(row["MVPfecha_movimiento"]);
               //     txtORGid_persona.Text = Convert.ToString(row["ORGid_persona"]);
                    txtORGds_persona.Text = Convert.ToString(row["ORGds_persona"]);
                 //   txtORGid_zona.Text = Convert.ToString(row["ORGid_zona"]);
                    txtORGds_zona.Text = Convert.ToString(row["ORGds_zona"]);
                    txtORGcrp.Text = Convert.ToString(row["ORGcrp"]);
                    txtORGds_crp.Text = Convert.ToString(row["ORGds_crp"]);
                    cboPERNR3.Text = Convert.ToString(row["ORGid_usuario"]);
                    txtORGds_usuario.Text = Convert.ToString(row["ORGds_usuario"]);
                   // txtORGid_ambiente.Text = Convert.ToString(row["ORGid_ambiente"]);
                    txtORGds_ambiente.Text = Convert.ToString(row["ORGds_ambiente"]);
                  //  txtDSTid_persona.Text = Convert.ToString(row["DSTid_persona"]);
                    txtDSTds_persona.Text = Convert.ToString(row["DSTds_persona"]);
                 //   txtDSTid_zona.Text = Convert.ToString(row["DSTid_zona"]);
                    txtDSTds_zona.Text = Convert.ToString(row["DSTds_zona"]);
                    txtDSTcrp.Text = Convert.ToString(row["DSTcrp"]);
                    txtDSTds_crp.Text = Convert.ToString(row["DSTds_crp"]);
                    cboPERNR4.Text = Convert.ToString(row["DSTid_usuario"]);
                    txtDSTds_usuario.Text = Convert.ToString(row["DSTds_usuario"]);
                  //  txtDSTid_ambiente.Text = Convert.ToString(row["DSTid_ambiente"]);
                    txtDSTds_ambiente.Text = Convert.ToString(row["DSTds_ambiente"]);
                    txtMVPobservaciones.Text = Convert.ToString(row["MVPobservaciones"]);
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
                DataTable dat = NMovimiento_Transferencia_Activo.Last();
                //ACFdescripcion.Text= dat.Rows[0]["ACFdescripcion"].ToString();
                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];                  
                    txtMVPid_proceso.Text = Convert.ToString(row["MVPid_proceso"]);
                    cboMVPtipo.Text = Convert.ToString(row["MVPtipo"]);
                    txtMVPds_movimiento.Text = Convert.ToString(row["MVPds_movimiento"]);
                    dtpMVPfecha_movimiento.Text = Convert.ToString(row["MVPfecha_movimiento"]);
                    cboPERNR1.Text = Convert.ToString(row["ORGid_persona"]);
                    txtORGds_persona.Text = Convert.ToString(row["ORGds_persona"]);
                    cboZONA1.Text = Convert.ToString(row["ORGid_zona"]);
                    txtORGds_zona.Text = Convert.ToString(row["ORGds_zona"]);
                    txtORGcrp.Text = Convert.ToString(row["ORGcrp"]);
                    txtORGds_crp.Text = Convert.ToString(row["ORGds_crp"]);
                    cboPERNR3.Text = Convert.ToString(row["ORGid_usuario"]);
                    txtORGds_usuario.Text = Convert.ToString(row["ORGds_usuario"]);
                    cboAMB1.Text = Convert.ToString(row["ORGid_ambiente"]);
                    txtORGds_ambiente.Text = Convert.ToString(row["ORGds_ambiente"]);
                    cboPERNR2.Text = Convert.ToString(row["DSTid_persona"]);
                    txtDSTds_persona.Text = Convert.ToString(row["DSTds_persona"]);
                    cboZONA2.Text = Convert.ToString(row["DSTid_zona"]);
                    txtDSTds_zona.Text = Convert.ToString(row["DSTds_zona"]);
                    txtDSTcrp.Text = Convert.ToString(row["DSTcrp"]);
                    txtDSTds_crp.Text = Convert.ToString(row["DSTds_crp"]);
                    cboPERNR4.Text = Convert.ToString(row["DSTid_usuario"]);
                    txtDSTds_usuario.Text = Convert.ToString(row["DSTds_usuario"]);
                    cboAMB2.Text = Convert.ToString(row["DSTid_ambiente"]);
                    txtDSTds_ambiente.Text = Convert.ToString(row["DSTds_ambiente"]);
                    txtMVPobservaciones.Text = Convert.ToString(row["MVPobservaciones"]);
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
           // Form FrmExcel = new FrmExcel();
           // FrmExcel.Show();
        }
        private void BotonRefrescar()
        {
            EstadoText(this.Controls, false, false);
            this.mostrar();
            this.MostrarRegistro();
        }
        private void BotonAgregar()
        {
            Activo = 2;
            Graba = 1;
            EstadoText(this.Controls, true, true);
            this.LimpiaCampos();
            this.Botones(false);
            Last();
            this.LimpiaCampos();
            if(txtMVPid_proceso.Text == "")
            {
                txtMVPid_proceso.Text = "1";
            }
            else{
            txtMVPid_proceso.Text=Convert.ToString(Convert.ToInt32(txtMVPid_proceso.Text) + 1);
                }
            txtDSTcrp.Text = "";
            txtDSTds_ambiente.Text = "";
            txtDSTds_crp.Text = "";
            txtDSTds_persona.Text = "";
            txtDSTds_usuario.Text = "";
            txtDSTds_zona.Text = "";
            txtMVPds_movimiento.Text = "";
            txtMVPds_movimiento.Text = "";
           // txtMVPid_proceso.Text = "";
            txtORGcrp.Text = "";
            txtORGds_ambiente.Text = "";
            txtORGds_crp.Text = "";
            txtORGds_persona.Text = "";
            txtORGds_usuario.Text = "";
            txtORGds_zona.Text = "";
            cboAMB1.Text = "";
            cboAMB2.Text = "";
            cboMVPtipo.Text = "";
            cboMVPtipo.Text = "";
            cboPERNR1.Text = "";
            cboPERNR2.Text = "";
            cboPERNR3.Text = "";
            cboPERNR4.Text = "";
            cboZONA1.Text = "";
            cboZONA2.Text = "";
            txtDSTds_zona.Text = "";
            txtORGds_zona.Text = "";
            txtMVPobservaciones.Text = "";
        }
        private void ControlEditar(bool activar)
        {
            button8.Enabled = activar;
            button9.Enabled = activar;
        }

        private void BotonEditar()
        {            
            Activo = 2;
            Graba = 2;
            this.Botones(false);
            EstadoText(this.Controls, false, true);                           
            this.CargaDatos();
            ControlEditar(false);
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
                if (Graba == 1) {this.InsertaRegistro(); this.InsertarActivos();}
                if (Graba == 2) { this.ActualizaRegistro(); }
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
                Rta = NMovimiento_Transferencia_Activo.Insertar(
                this.txtMVPid_proceso.Text
                , this.cboMVPtipo.Text
                , this.txtMVPds_movimiento.Text
                , this.dtpMVPfecha_movimiento.Text
                , this.cboZONA1.Text
                , this.txtORGds_zona.Text
                , this.txtORGcrp.Text
                , this.txtORGds_crp.Text
                , this.cboAMB1.Text
                , this.txtORGds_ambiente.Text
                , this.cboPERNR1.Text
                , this.txtORGds_persona.Text                                
                , this.cboPERNR3.Text
                , this.txtORGds_usuario.Text

                , this.cboZONA2.Text
                , this.txtDSTds_zona.Text
                , this.txtDSTcrp.Text
                , this.txtDSTds_crp.Text
                , this.cboAMB2.Text
                , this.txtDSTds_ambiente.Text
                , this.cboPERNR2.Text
                , this.txtDSTds_persona.Text           
                , this.cboPERNR4.Text
                , this.txtDSTds_usuario.Text
                , this.txtMVPobservaciones.Text

                   );
                // Rta = NMovimiento_Transferencia_Activo.Insertar(this.txtMVPid_proceso.Text, "1", "1", "1", "1", "1", "2", DateTime.Today.ToString(), "1", this.txtACFdescripcion.Text, DateTime.Today.ToString(), DateTime.Today.ToString(), "0", "0", "0.00", "0", "0", "0", "", "0", "", "", "", "", "", "", "0.00", "0.00", "", "", "1", "", "1", "", "", "", DateTime.Today.ToString(), "1", "", "1", "1", "1", DateTime.Today.ToString(), "1");

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
                Rta = NMovimiento_Transferencia_Activo.Editar(
                      this.txtMVPid_proceso.Text
                    , this.cboMVPtipo.Text
                    , this.txtMVPds_movimiento.Text
                    , this.dtpMVPfecha_movimiento.Text
                    , this.cboPERNR1.Text
                    , this.txtORGds_persona.Text
                    , this.cboZONA1.Text
                    , this.txtORGds_zona.Text
                    , this.txtORGcrp.Text
                    , this.txtORGds_crp.Text
                    , this.cboPERNR3.Text
                    , this.txtORGds_usuario.Text
                    , this.cboAMB1.Text
                    , this.txtORGds_ambiente.Text
                    , this.cboPERNR2.Text
                    , this.txtDSTds_persona.Text
                    , this.cboZONA2.Text
                    , this.txtDSTds_zona.Text
                    , this.txtDSTcrp.Text
                    , this.txtDSTds_crp.Text
                    , this.cboPERNR4.Text
                    , this.txtDSTds_usuario.Text
                    , this.cboAMB2.Text
                    , this.txtDSTds_ambiente.Text
                    , this.txtMVPobservaciones.Text
                    );

                //Rta = NMovimiento_Transferencia_Activo.Editar("1", "1", "1", "1", "1", "1", "2", DateTime.Today.ToString(), "1", this.txtACFdescripcion.Text, DateTime.Today.ToString(), DateTime.Today.ToString(), "0", "0", "0.00", "0", "0", "0", "", "0", "", "", "", "", "", "", "0.00", "0.00", "", "", "1", "", "1", "", "", "", DateTime.Today.ToString(), "1", "", "1", "1", "1", DateTime.Today.ToString(), "1");

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
            //NMovimiento_Transferencia_Activo.Buscar("1");
        }

        private void MostrarCombos()
        {
            //NMovimiento_Transferencia_Activo.Buscar("1");
        }
        private void MostrarRegistro()
        {
            try
            {
                DataTable dat = NMovimiento_Transferencia_Activo.Mostrar();

                //ACFdescripcion.Text= dat.Rows[0]["ACFdescripcion"].ToString();

                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];
                    txtMVPid_proceso.Text = Convert.ToString(row["MVPid_proceso"]);
                    cboMVPtipo.Text = Convert.ToString(row["MVPtipo"]);
                    txtMVPds_movimiento.Text = Convert.ToString(row["MVPds_movimiento"]);
                    dtpMVPfecha_movimiento.Text = Convert.ToString(row["MVPfecha_movimiento"]);
                    cboPERNR1.Text = Convert.ToString(row["ORGid_persona"]);
                    txtORGds_persona.Text = Convert.ToString(row["ORGds_persona"]);
                    cboZONA1.Text = Convert.ToString(row["ORGid_zona"]);
                    txtORGds_zona.Text = Convert.ToString(row["ORGds_zona"]);
                    txtORGcrp.Text = Convert.ToString(row["ORGcrp"]);
                    txtORGds_crp.Text = Convert.ToString(row["ORGds_crp"]);
                    cboPERNR3.Text = Convert.ToString(row["ORGid_usuario"]);
                    txtORGds_usuario.Text = Convert.ToString(row["ORGds_usuario"]);
                    cboAMB1.Text = Convert.ToString(row["ORGid_ambiente"]);
                    txtORGds_ambiente.Text = Convert.ToString(row["ORGds_ambiente"]);
                    cboPERNR2.Text = Convert.ToString(row["DSTid_persona"]);
                    txtDSTds_persona.Text = Convert.ToString(row["DSTds_persona"]);
                    cboZONA2.Text = Convert.ToString(row["DSTid_zona"]);
                    txtDSTds_zona.Text = Convert.ToString(row["DSTds_zona"]);
                    txtDSTcrp.Text = Convert.ToString(row["DSTcrp"]);
                    txtDSTds_crp.Text = Convert.ToString(row["DSTds_crp"]);
                    cboPERNR4.Text = Convert.ToString(row["DSTid_usuario"]);
                    txtDSTds_usuario.Text = Convert.ToString(row["DSTds_usuario"]);
                    cboAMB2.Text = Convert.ToString(row["DSTid_ambiente"]);
                    txtDSTds_ambiente.Text = Convert.ToString(row["DSTds_ambiente"]);
                    txtMVPobservaciones.Text = Convert.ToString(row["MVPobservaciones"]);



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
        private void FrmMovimiento_Transferencia_Activo_miLoad(object sender, EventArgs e)
        {
            this.mostrar();
        }

        private void FrmMovimiento_Transferencia_Activo_Load(object sender, EventArgs e) { }


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
        private void CargarCombos()
        {
            this.cboPERNR1.DataSource = NbdiXPEpExtraccionSAP_Personal.Mostrar();//
            this.cboPERNR1.ValueMember = "PERNR";
            this.cboPERNR1.DisplayMember = "PERNR";
            this.cboPERNR1.SelectedIndex = -1;

            this.cboPERNR2.DataSource = NbdiXPEpExtraccionSAP_Personal.Mostrar();//
            this.cboPERNR2.ValueMember = "PERNR";
            this.cboPERNR2.DisplayMember = "PERNR";
            this.cboPERNR2.SelectedIndex = -1;

            this.cboPERNR3.DataSource = NbdiXPEpExtraccionSAP_Personal.Mostrar();//
            this.cboPERNR3.ValueMember = "PERNR";
            this.cboPERNR3.DisplayMember = "PERNR";
            this.cboPERNR3.SelectedIndex = -1;

            this.cboPERNR4.DataSource = NbdiXPEpExtraccionSAP_Personal.Mostrar();//
            this.cboPERNR4.ValueMember = "PERNR";
            this.cboPERNR4.DisplayMember = "PERNR";
            this.cboPERNR4.SelectedIndex = -1;

            this.cboAMB1.DataSource = NacfAMBt_Ambiente.Mostrar();//
            this.cboAMB1.ValueMember = "AMBid";
            this.cboAMB1.DisplayMember = "AMBid";
            this.cboAMB1.SelectedIndex = -1;

            this.cboAMB2.DataSource = NacfAMBt_Ambiente.Mostrar();//
            this.cboAMB2.ValueMember = "AMBid";
            this.cboAMB2.DisplayMember = "AMBid";
            this.cboAMB2.SelectedIndex = -1;

            this.cboZONA1.DataSource = NbdiSEGpSegmento.Mostrar();//
            this.cboZONA1.ValueMember = "id_zona";
            this.cboZONA1.DisplayMember = "id_zona";
            this.cboZONA1.SelectedIndex = -1;

            this.cboZONA2.DataSource = NbdiSEGpSegmento.Mostrar();//
            this.cboZONA2.ValueMember = "id_zona";
            this.cboZONA2.DisplayMember = "id_zona";
            this.cboZONA2.SelectedIndex = -1;

            this.cboMVPtipo.DataSource = NacfTMVt_TipoMovimiento.Mostrar();//
            this.cboMVPtipo.ValueMember = "TMVid";
            this.cboMVPtipo.DisplayMember = "TMVid";
            this.cboMVPtipo.SelectedIndex = -1;

            this.txtORGcrp.DataSource = NacfCRPt_Centro_Responsabilidad.Mostrar();
            this.txtORGcrp.ValueMember = "CRPid_crp";
            this.txtORGcrp.DisplayMember = "CRPid_crp";
            this.txtORGcrp.SelectedIndex = -1;

            this.txtDSTcrp.DataSource = NacfCRPt_Centro_Responsabilidad.Mostrar();
            this.txtDSTcrp.ValueMember = "CRPid_crp";
            this.txtDSTcrp.DisplayMember = "CRPid_crp";
            this.txtDSTcrp.SelectedIndex = -1;

            this.txtMVPds_movimiento.DataSource = NacfMVMt_MotivoMovimiento.Mostrar();
            this.txtMVPds_movimiento.ValueMember = "MVMid";
            this.txtMVPds_movimiento.DisplayMember = "MVMid";
            this.txtMVPds_movimiento.SelectedIndex = -1;
            
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
            Form FrmMovimiento_Transferencia_Activo = new FrmMovimiento_Transferencia_Activo();
            FrmMovimiento_Transferencia_Activo.ShowDialog();
        }

        private void multiColumnComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {       
            //
            try
            {
                string iACFid = Microsoft.VisualBasic.Interaction.InputBox(
                                 "Ingrese el Id del Activo Fijo",
                                 "Ajuste del Valor del Bien");
                 if (iACFid != null)
                 {               
                     DataTable tabla = NacfACFp_Activo_Fijo.IngresarACF(iACFid);                    
                     if (tabla.Rows.Count > 0)
                     {
                         foreach (DataRow Drow in tabla.Rows)
                         {
                             int num = dataListado.Rows.Add();
                             dataListado.Rows[num].Cells[0].Value = Drow["ACFid"].ToString();
                             dataListado.Rows[num].Cells[1].Value = Drow["PERNR"].ToString();
                             dataListado.Rows[num].Cells[2].Value = Drow["ACFfincorporacion"].ToString();
                             dataListado.Rows[num].Cells[3].Value = Drow["ACFdescripcion"].ToString();
                         }
                     }
                     else
                         MessageBox.Show("No Existe", "Registro");
                 }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
}

        private void button9_Click(object sender, EventArgs e)
        {
            int fil = dataListado.CurrentRow.Index;
            dataListado.Rows.RemoveAt(fil);
        }

        private void InsertarActivos()
        {
            string rta = string.Empty;
            MessageBox.Show("insertar");
            string activo = txtMVPid_proceso.Text;
            int num = 0;
            try
            {
                foreach (DataGridViewRow row in dataListado.Rows)
                {
                    rta = NacfMVAt_MovimientoActivo.IngresarACF(
                     activo
                     , dataListado.Rows[num].Cells[0].Value.ToString()
                  );

                    if (rta.Equals("OK"))
                    {
                        this.MensajeOk("Registro Agregado Correctamente");                       
                    }
                    else
                    {
                        this.MensajeError("Error al Insertar Registro :" + rta);
                    }
                    if(num < dataListado.Rows.Count) num = num + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void toolStripImprimir_Click(object sender, EventArgs e)
        {
            FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_Movimiento_Activo1.rdlc", NMovimiento_Transferencia_Activo.FichaMovimiento1(txtMVPid_proceso.Text), "ip");
            rptalu.ShowDialog();
        }
    }
}
//-------------------------------------------------------------------
