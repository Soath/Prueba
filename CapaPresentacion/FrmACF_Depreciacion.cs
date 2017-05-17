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
            string fecha1, fecha2;
            int proceso = 0;
            if (checkBox1.Checked == true)   { proceso = 1; };
            if (checkBox2.Checked == true)   { proceso = 2; };
            if ((checkBox1.Checked == true) && (checkBox2.Checked == true) )
                                             { proceso = 3; };
            switch (proceso)
            {                
                case 1:
                    MessageBox.Show("Proceso de Depreciaciación - Contable NIIF");
                    fecha1 = dateTimePicker1.Text;
                    fecha2 = "00/00/0000";
                    break;
                case 2:
                    MessageBox.Show("Proceso de Depreciaciación - Tributaria LIR");
                    fecha1 = "00/00/0000";
                    fecha2 = dateTimePicker1.Text;
                    break;
                case 3:
                    MessageBox.Show("Proceso de Depreciaciación - Contable y Tributaria");
                    fecha1 = dateTimePicker1.Text;
                    fecha2 = dateTimePicker1.Text;
                    break;
                default:
                    MessageBox.Show("Debe Elegir el Tipo Proceso de Depreciaciación");
                    fecha1 = "00/00/0000";
                    fecha2 = "00/00/0000";
                    break;
            };
            //ejecutamos el procedimiento almacenado
            string Rta = string.Empty;
            try
            {
                Rta = NacfACFp_Activo_Fijo.depreciacion(
                      fecha1
                    , fecha2
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
