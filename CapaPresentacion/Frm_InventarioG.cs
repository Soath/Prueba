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
    public partial class Frm_InventarioG : Form
    {
        public Frm_InventarioG()
        {
            
            InitializeComponent();
        }
       
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
                }
                else
                    MessageBox.Show("No Existe", "Registro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Rta = string.Empty;
            try
            {
                Rta = NacfINVp_Inventario.Insertar(this.txtINVid.Text, this.txtINVdescripcion.Text, this.dtINVfechainicio.Text, this.txtINVfechacierre.Text, this.txtINVtotal.Text, this.txtINVrespon.Text, this.dtINVperiodo.Text);

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
    }
}