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
    public partial class Frm_Rptdepreciacion : Form
    {

        public Frm_Rptdepreciacion()
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void Frm_Rptdepreciacion_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Rptdepreciacion_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {

                FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_Depreciacion1.rdlc", NacfACFp_Activo_Fijo.Depreciacion(textBox1.Text), "ip");
                rptalu.ShowDialog();
            }
            if (radioButton1.Checked)
            {
                int x;
                x = Convert.ToInt32(comboBox1.SelectedIndex)+1;
               // MessageBox.Show(Convert.ToString(x));
                FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_Depreciacion_Mensual.rdlc", NacfACFp_Activo_Fijo.DepreciacionMensual(textBox1.Text, Convert.ToString(x)), "ip");
                rptalu.ShowDialog();
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            comboBox1.Enabled = false;
            this.comboBox1.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
