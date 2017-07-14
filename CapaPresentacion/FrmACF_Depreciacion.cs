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

namespace CapaPresentacion
{

    public partial class FrmACF_Depreciacion : Form
    {
        string variabledepre; // variable para obtener el parametro de la fecha de depreciacion
        public FrmACF_Depreciacion()
        {
            InitializeComponent();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Control del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Control  del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

       private void button1_Click(object sender, EventArgs e)
       {
            var cadena = textBox1.Text;
            if (cadena.Length < 4)
            {
                MessageBox.Show("La fecha debe contener 4 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int mes, anio;
                string mes1;
                mes = comboBox1.SelectedIndex + 1;
                if (mes < 10)
                {
                    mes1 = 0 + Convert.ToString(mes);                     
                }
                else
                {
                    mes1 = Convert.ToString(mes);
                }

                anio = Convert.ToInt32(textBox1.Text);
                string variable = Convert.ToString(anio) + mes1;
                MessageBox.Show(Convert.ToString(variable));

                
                try
                {
                    DataTable dat = N_PRMVAR.variabledepre();
                    //if (dat.Rows.Count > 0)
                    //{
                        DataRow row = dat.Rows[0];
                        variabledepre = Convert.ToString(row["PRM_valor"]);
                    //}
                    //else
                        //MessageBox.Show("No Existe", "Registro");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message + ex.StackTrace);
                }

                MessageBox.Show(Convert.ToString(variabledepre));

                if(Convert.ToInt32(variable) > Convert.ToInt32(variabledepre))
                {
                    MessageBox.Show("Procesando Actualización", "Proceso");
                    //ejecutamos el procedimiento almacenado
                    string Rta = string.Empty;
                    try
                    {                   
                        int x = comboBox1.SelectedIndex +1;
                        //MessageBox.Show(Convert.ToString(x));
                        Rta = NacfACFp_Activo_Fijo.depreciacion(
                              Convert.ToString(x)
                            , textBox1.Text
                            , variable
                            );
            
                        if (Rta.Equals("OK"))
                        {
                            this.timer1.Start();
                            this.MensajeOk("Regsitro Actualizado Correctamente");
                            button1.Enabled = false;
                        }
                        else
                        {
                            this.MensajeError("Error: " + Rta);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                else MessageBox.Show("El registro ya fue Actualizado Anteriormente, Imposible Procesar", "Proceso");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            this.progressBar1.Increment(1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 4;
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void FrmACF_Depreciacion_Load(object sender, EventArgs e)
        {

        }
    }
}
