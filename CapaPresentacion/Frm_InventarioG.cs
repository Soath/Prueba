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
            mostrar();
            
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
                Rta = NacfINVp_Inventario.Insertar(this.txtINVid.Text, null, null,null,0, null, null);

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
        private void mostrar()
        {
            bss.DataSource = NacfINBt_Inventariobienes.Mostrar();
            this.datalistado.DataSource = bss;
        }
    }

}