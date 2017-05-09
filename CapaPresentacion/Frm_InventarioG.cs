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
    public partial class Frm_InventarioG : KryptonForm
    {
        int Activo = 1;
        int Graba = 0;
        public int idEditar = 0;
        public string MensError;
        
        BindingSource bss = new BindingSource();

        private static Frm_InventarioG _Instancia;

        public static Frm_InventarioG GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new Frm_InventarioG();
            }
            return _Instancia;
        }

        public Frm_InventarioG()
        {
            
            InitializeComponent();
          
            EstadoText(this.Controls, true, false);
            mostrar();
            MostrarRegistro();
        }
        public static int IdAct;
        private void dtperiodo_ValueChanged(object sender, EventArgs e)
        {

        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Control Escolar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Control Escolar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void MostrarDatos(DataTable dat)
        {
            if (dat.Rows.Count > 0)
            {
                DataRow row = dat.Rows[0];
                //guardo datos en variables
                txtINVid.Text = Convert.ToString(row["INVid"]);
                txtINVdescripcion.Text = Convert.ToString(row["INVdetalle"]);
                dtINVfechainicio.Text = Convert.ToString(row["INVinicio"]);
                txtINVfechacierre.Text = Convert.ToString(row["INVcierre"]);
                cbActivo.Checked = Convert.ToBoolean(row["INVactivo"]);
                txtINVrespon.Text = Convert.ToString(row["INVrespon"]);
                txtINVperiodo.Text = Convert.ToString(row["INVperiodo"]);
                //guardo datos en variables
                //txtACFid.Text = Convert.ToString(row["ACFid"]);
                //txtACFdescripcion.Text = Convert.ToString(row["ACFdescripcion"]);
            }
            else
                MessageBox.Show("No Existe", "Registro");
        }
       private void MostrarRegistro()
        {

          try
            {
                DataTable dat = NacfINVp_Inventario.Mostrar();

                //ACFdescripcion.Text= dat.Rows[0]["ACFdescripcion"].ToString();
               
                if (dat.Rows.Count > 0)
              {
                    DataRow row = dat.Rows[0];
                    txtINVid.Text = Convert.ToString(row["INVid"]);
                    txtINVdescripcion.Text = Convert.ToString(row["INVdetalle"]);
                    dtINVfechainicio.Text = Convert.ToString(row["INVinicio"]);
                    txtINVfechacierre.Text = Convert.ToString(row["INVcierre"]);
                    cbActivo.Checked = Convert.ToBoolean(row["INVactivo"]);
                    txtINVrespon.Text = Convert.ToString(row["INVrespon"]);
                    txtINVperiodo.Text = Convert.ToString(row["INVperiodo"]);
              }
                else
                   MessageBox.Show("No Existe", "Registro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
       private void BotonRefrescar()
       {
           EstadoText(this.Controls, false, false);
           
           this.Botones(true);
           this.MostrarRegistro();
       }
       //-----------------------------------------------------------------------------------	
       // Actualiza Registros	
       //-----------------------------------------------------------------------------------	
       private void ActualizaRegistro()
       {
           string Rta = string.Empty;
           try
           {
               Rta= NacfINVp_Inventario.Editar(
                     this.txtINVid.Text
                   , this.txtINVdescripcion.Text
                   , this.dtINVfechainicio.Text
                   , this.txtINVfechacierre.Text
                   , this.cbActivo.Checked
                   , this.txtINVrespon.Text
                   , this.txtINVperiodo.Text
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
       private void Top()
       {
           try
           {
               DataTable dat = NacfINVp_Inventario.Top();
               MostrarDatos(dat);
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message + ex.StackTrace);
           }
       }
       private bool validaCampos()
       {
           return true;
       }
       private void BotonGuardar()
       {
           if (this.validaCampos())
           {
               if (Graba == 1) { this.InsertaRegistro(); this.CopiarRegistro(); this.CopiarRegistro2(); }
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
               Rta = NacfINVp_Inventario.Insertar(this.txtINVid.Text, this.txtINVdescripcion.Text, this.dtINVfechainicio.Text, this.txtINVfechacierre.Text, false, this.txtINVrespon.Text, this.txtINVperiodo.Text);

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
        private void button1_Click(object sender, EventArgs e)
        {
            

        }
        private void CopiarRegistro()
        {
            string Rta = string.Empty;
            try
            {
                Rta = NacfINBt_Inventariobienes.Copiar();

                if (Rta.Equals("OK"))
                {
                    this.MensajeOk("Inventario generado correctamente.");
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
        private void CopiarRegistro2()
        {
            string Rta = string.Empty;
            try
            {
                Rta = NacfICRt_Inventariocaracteristicas.Copiar();

                if (Rta.Equals("OK"))
                {
                    this.MensajeOk("Inventario características generado correctamente.");
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
        private void Next(String iINVid)
        {
            try
            {
                DataTable dat = NacfINVp_Inventario.Next(iINVid);

                //ACFdescripcion.Text= dat.Rows[0]["ACFdescripcion"].ToString();

                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];
                    //guardo datos en variables
                    txtINVid.Text = Convert.ToString(row["INVid"]);
                    txtINVdescripcion.Text = Convert.ToString(row["INVdetalle"]);
                    dtINVfechainicio.Text = Convert.ToString(row["INVinicio"]);
                    txtINVfechacierre.Text = Convert.ToString(row["INVcierre"]);
                    cbActivo.Checked = Convert.ToBoolean(row["INVactivo"]);
                    txtINVrespon.Text = Convert.ToString(row["INVrespon"]);
                    txtINVperiodo.Text = Convert.ToString(row["INVperiodo"]);
                  

                }
                else
                    MessageBox.Show("No Existe", "Registro");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void BotonAgregar()
        {
            Activo = 2;
            Graba = 1;
            EstadoText(this.Controls, true, true);
            this.Botones(false);
            //tabControl1.SelectedTab = tabPage2;
        }
        private void Prev(String iINVid)
        {
            try
            {
                DataTable dat = NacfINVp_Inventario.Prev(iINVid);

                //ACFdescripcion.Text= dat.Rows[0]["ACFdescripcion"].ToString();

                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];
                    //guardo datos en variables
                    txtINVid.Text = Convert.ToString(row["INVid"]);
                    txtINVdescripcion.Text = Convert.ToString(row["INVdetalle"]);
                    dtINVfechainicio.Text = Convert.ToString(row["INVinicio"]);
                    txtINVfechacierre.Text = Convert.ToString(row["INVcierre"]);
                    cbActivo.Checked = Convert.ToBoolean(row["INVactivo"]); 
                    txtINVrespon.Text = Convert.ToString(row["INVrespon"]);
                    txtINVperiodo.Text = Convert.ToString(row["INVperiodo"]);
                  
                }
                else
                    MessageBox.Show("No Existe", "Registro");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void NextDataGRid(String iINVid)
        {
            this.datalistado.DataSource = NacfINBt_Inventariobienes.Mostrar(iINVid);
        }

        private void PrevDataGRid(String iINVid)
        {
            this.datalistado.DataSource = NacfINBt_Inventariobienes.Mostrar(iINVid);
        }
        private void CargaDatos()
        {
            idEditar = 0;
        }
        private void mostrar()
        {
            this.datalistado.DataSource = NacfINBt_Inventariobienes.Mostrar("1");
            lblTotal.Text = "Total de Registros: " + Convert.ToString(datalistado.Rows.Count);
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
        private void BotonesSinReg(bool edo)
        {
            this.toolStripRefrescar.Enabled = edo;
            this.toolStripAgregar.Enabled = !edo;
            this.toolStripEditar.Enabled = edo;
            this.toolStripEliminar.Enabled = edo;
            this.toolStripPrimero.Enabled = edo;
            this.toolStripAnterior.Enabled = edo;
            this.toolStripSiguiente.Enabled = edo;
            this.toolStripUltimo.Enabled = edo;
            //this.toolStripBuscar.Enabled = edo;
            //this.toolStripComboBox1.Enabled = edo;
            //this.toolStripTextBox1.Enabled = edo;
        }
        private void Botones(bool edo)
        {
            this.toolStripRefrescar.Visible = edo;
            this.toolStripAgregar.Visible = edo;
            this.toolStripEditar.Visible = edo;
            this.toolStripEliminar.Visible = edo;
          

            this.toolStripGuardar.Visible = !edo;
            this.toolStripCancelar.Visible = !edo;
            this.toolStripPrimero.Visible = edo;
            this.toolStripAnterior.Visible = edo;
            this.toolStripSiguiente.Visible = edo;
            this.toolStripUltimo.Visible = edo;
            this.toolStripBuscar.Visible = edo;
          
        }
        private void Last()
        {
            try
            {
                DataTable dat = NacfINVp_Inventario.Last();
                MostrarDatos(dat);
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
        private void BotonEditar()
        {
            Activo = 2;
            Graba = 2;
            this.Botones(false);
            EstadoText(this.Controls, false, true);
            // tabControl1.SelectedTab = tabPage2;
            this.CargaDatos();
        }
        private void toolStripSiguiente_Click_1(object sender, EventArgs e)
        {
            Next(txtINVid.Text);
            NextDataGRid(txtINVid.Text);
        }

        private void toolStripAnterior_Click_1(object sender, EventArgs e)
        {
            Prev(txtINVid.Text);
            PrevDataGRid(txtINVid.Text);
        }

        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            BotonEditar();
        }

        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            BotonRefrescar();
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            BotonGuardar();
        }

        private void toolStripAgregar_Click(object sender, EventArgs e)
        {
            BotonAgregar();
        }

        private void toolStripPrimero_Click(object sender, EventArgs e)
        {
            Top();
            PrevDataGRid(txtINVid.Text);
        }

        private void toolStripUltimo_Click(object sender, EventArgs e)
        {
            Last();
            NextDataGRid(txtINVid.Text);

        }

     

        private void datalistado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datalistado.Rows[e.RowIndex].Cells[1].Value.ToString() != "")
            {
                IdAct = int.Parse(datalistado.Rows[e.RowIndex].Cells[0].Value.ToString());
                Form Frm_RegistroInventario = new Frm_RegistroInventario();
                Frm_RegistroInventario.ShowDialog();

            }
            
        }

        private void btINBbuscar_Click(object sender, EventArgs e)
        {
            //bss.DataSource = NacfINBt_Inventariobienes.Buscar(this.txtINBacf.Text);
            //this.datalistado.DataSource = bss;
        }

    }

}