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
using ComponentFactory.Krypton.Toolkit;

namespace CapaPresentacion
{
    public partial class FrmACF_ReparoTributario : KryptonForm
    {
        int Activo = 1;
        int Graba = 0;
        public int idEditar = 0;
        public string MensError;

        public FrmACF_ReparoTributario()
        {
            InitializeComponent();
            EstadoText(this.Controls, true, false);
         
            MostrarRegistro();
         
        }
     
        private void MostrarRegistro()
        {

            try
            {
                DataTable dat = NacfRTRt_Reparotributario.Mostrar();

                //ACFdescripcion.Text= dat.Rows[0]["ACFdescripcion"].ToString();

                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];
                    txtRTRcodigo.Text = Convert.ToString(row["RTRcodigo"]);
                    txtRTRperiodo.Text = Convert.ToString(row["RTRperiodo"]);
                    dtRTRfecha.Text = Convert.ToString(row["RTRfecha"]);
                    txtRTRresponsable.Text = Convert.ToString(row["RTRresponsable"]);
                    txtRTRestado.Checked = Convert.ToBoolean(row["RTRestado"]);
                }
                else
                    MessageBox.Show("No Existe", "Registro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Prev(String RTRcodigo)
        {
            try
            {
                DataTable dat = NacfRTRt_Reparotributario.Prev(RTRcodigo);

                //ACFdescripcion.Text= dat.Rows[0]["ACFdescripcion"].ToString();

                if (dat.Rows.Count > 0)
                {
                    //guardo datos en variables
                    DataRow row = dat.Rows[0];
                    txtRTRcodigo.Text = Convert.ToString(row["RTRcodigo"]);
                    txtRTRperiodo.Text = Convert.ToString(row["RTRperiodo"]);
                    dtRTRfecha.Text = Convert.ToString(row["RTRfecha"]);
                    txtRTRresponsable.Text = Convert.ToString(row["RTRresponsable"]);
                    txtRTRestado.Checked = Convert.ToBoolean(row["RTRestado"]);

                }
                else
                    MessageBox.Show("No Existe", "Registro");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void NextDataGRid(String RTRcodigo)
        {
            this.datalistado1.DataSource = NacfDRTt_detallereparotributario.Buscar(RTRcodigo);
        }

        private void PrevDataGRid(String RTRcodigo)
        {
            this.datalistado1.DataSource = NacfDRTt_detallereparotributario.Buscar(RTRcodigo);
        }
        private void Next(String RTRcodigo)
        {
            try
            {
                DataTable dat = NacfRTRt_Reparotributario.Next(RTRcodigo);

                //ACFdescripcion.Text= dat.Rows[0]["ACFdescripcion"].ToString();

                if (dat.Rows.Count > 0)
                {
                    
                    //guardo datos en variables
                    DataRow row = dat.Rows[0];
                    txtRTRcodigo.Text = Convert.ToString(row["RTRcodigo"]);
                    txtRTRperiodo.Text = Convert.ToString(row["RTRperiodo"]);
                    dtRTRfecha.Text = Convert.ToString(row["RTRfecha"]);
                    txtRTRresponsable.Text = Convert.ToString(row["RTRresponsable"]);
                    txtRTRestado.Text = Convert.ToString(row["RTRestado"]);

                }
                else
                    MessageBox.Show("No Existe", "Registro");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void mostrar()
        {
            this.datalistado1.DataSource = NacfDRTt_detallereparotributario.Buscar(txtRTRcodigo.Text);
            /* if (datalistado.Rows.Count == 0)
             {
                 BotonesSinReg(false);
             }
             else
             {
                 BotonesSinReg(true);
                 this.toolStripAgregar.Enabled = true;

             }
             this.datalistado.Select();
             this.datalistado.Focus();*/


        }
        private void MostrarDatos(DataTable dat)
        {
            if (dat.Rows.Count > 0)
            {
                DataRow row = dat.Rows[0];
                //guardo datos en variables
                txtRTRcodigo.Text = Convert.ToString(row["RTRcodigo"]);
                txtRTRperiodo.Text = Convert.ToString(row["RTRperiodo"]);
                dtRTRfecha.Text = Convert.ToString(row["RTRfecha"]);
                txtRTRresponsable.Text = Convert.ToString(row["RTRresponsable"]);
                txtRTRestado.Checked = Convert.ToBoolean(row["RTRestado"]);
                //guardo datos en variables
                //txtACFid.Text = Convert.ToString(row["ACFid"]);
                //txtACFdescripcion.Text = Convert.ToString(row["ACFdescripcion"]);
            }
            else
                MessageBox.Show("No Existe", "Registro");
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
        private void Botones(bool edo)
        {
            this.toolStripRefrescar.Visible = edo;
            this.toolStripAgregar.Visible = edo;
            this.toolStripEditar.Visible = edo;


            this.toolStripGuardar.Visible = !edo;
            this.toolStripCancelar.Visible = !edo;
            this.toolStripPrimero.Visible = edo;
            this.toolStripAnterior.Visible = edo;
            this.toolStripSiguiente.Visible = edo;
            this.toolStripUltimo.Visible = edo;

        }
        private void BotonAgregar()
        {
            Activo = 2;
            Graba = 1;
           
            EstadoText(this.Controls, true, true);
            this.Botones(false);
            Last();
            txtRTRcodigo.Text = Convert.ToString(Convert.ToInt32(txtRTRcodigo.Text) + 1);
            txtRTRperiodo.Text = "";
            txtRTRresponsable.Text = "";
            //tabControl1.SelectedTab = tabPage2;
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Control Escolar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Control Escolar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool validaCampos()
        {
            return true;
        }
        //-----------------------------------------------------------------------------------	
        // Actualiza Registros	
        //-----------------------------------------------------------------------------------	
        private void ActualizaRegistro()
        {
            string Rta = string.Empty;
            try
            {
                Rta = NacfRTRt_Reparotributario.Editar(this.txtRTRperiodo.Text, this.dtRTRfecha.Text, this.txtRTRresponsable.Text, this.txtRTRestado.Checked, this.txtRTRcodigo.Text);

                //Rta = NacfACFp_Activo_Fijo.Editar("1", "1", "1", "1", "1", "1", "2", DateTime.Today.ToString(), "1", this.txtACFdescripcion.Text, DateTime.Today.ToString(), DateTime.Today.ToString(), "0", "0", "0.00", "0", "0", "0", "", "0", "", "", "", "", "", "", "0.00", "0.00", "", "", "1", "", "1", "", "", "", DateTime.Today.ToString(), "1", "", "1", "1", "1", DateTime.Today.ToString(), "1");

                if (Rta.Equals("OK"))
                {
                    this.MensajeOk("Regsitro Editado Correctamente");
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
        private void BotonCancelar()
        {
            Activo = 1;
            this.Botones(true);
            EstadoText(this.Controls, false, false);
            //tabControl1.SelectedTab = tabPage1;
        }
        private void BotonRefrescar()
        {
            EstadoText(this.Controls, false, false);

            this.Botones(true);
            this.MostrarRegistro();
        }
        private void BotonGuardar()
        {
            if (this.validaCampos())
            {
                if (Graba == 1) { this.InsertaRegistro(); }
                if (Graba == 2) this.ActualizaRegistro();
                Graba = 0;
                this.BotonCancelar();
                this.BotonRefrescar();
            }
            else
                this.MensajeOk(MensError);
        }
        private void InsertaRegistro()
        {
            string Rta = string.Empty;
            try
            {
                Rta = NacfRTRt_Reparotributario.Insertar(this.txtRTRperiodo.Text, this.dtRTRfecha.Text, this.txtRTRresponsable.Text, this.txtRTRestado.Checked, this.txtRTRcodigo.Text);

                if (Rta.Equals("OK"))
                {
                    this.MensajeOk("Registro Agregado Correctamente");

                }
                else
                {
                    this.MensajeError(Rta);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void CargaDatos()
        {
            idEditar = 0;
            Graba = 2;  
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
        private void Last()
        {
            try
            {
                DataTable dat = NacfRTRt_Reparotributario.Last();
                MostrarDatos(dat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Top()
        {
            try
            {
                DataTable dat = NacfRTRt_Reparotributario.Top();
                MostrarDatos(dat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void toolStripSiguiente_Click(object sender, EventArgs e)
        {
            Next(txtRTRcodigo.Text);
            NextDataGRid(txtRTRcodigo.Text);
        }

        private void toolStripAnterior_Click(object sender, EventArgs e)
        {
            Prev(txtRTRcodigo.Text);
            PrevDataGRid(txtRTRcodigo.Text);
        }

        private void toolStripUltimo_Click(object sender, EventArgs e)
        {
            Last();
            NextDataGRid(txtRTRcodigo.Text);

        }

        private void toolStripPrimero_Click(object sender, EventArgs e)
        {
            Top();
            PrevDataGRid(txtRTRcodigo.Text);
        }


        private void toolStripAgregar_Click(object sender, EventArgs e)
        {
            BotonAgregar();
        }

        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            BotonEditar();
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            BotonGuardar();
        }

        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            BotonRefrescar();
        }

        private void cboPERNR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonProcesar_Click(object sender, EventArgs e)
        {
          
        }

        private void tsProcesar_Click(object sender, EventArgs e)
        {
            NacfDRTt_detallereparotributario.Copiar(txtRTRcodigo.Text);
            mostrar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form Frm_Excel_Reparo = new Frm_Excel_Reparo();
            Frm_Excel_Reparo.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_Reparo_Tributario.rdlc",NacfDRTt_detallereparotributario.Reporte(txtRTRcodigo.Text), "ip");
            rptalu.ShowDialog();
        }
    }
}
