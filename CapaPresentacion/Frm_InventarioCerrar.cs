using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Frm_InventarioCerrar : KryptonForm
    {
        public Frm_InventarioCerrar()
        {
            InitializeComponent();
            CargarCombos();
        }

        private void CargarCombos()
        {


            this.cboINV.DataSource = NacfINVp_Inventario.Mostrar(); //INVid
            this.cboINV.ValueMember = "INVid";
            this.cboINV.DisplayMember = "INVid";
            this.cboINV.SelectedIndex = -1;

        }

        private void mostrar(string iINVid)
        {
            this.datalistado1.DataSource = NacfINBt_Inventariobienes.conciliarinvent(iINVid);
        }

        private void Frm_InventarioCerrar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            mostrar(cboINV.Text);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Control:", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Control_", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string Rta = string.Empty;
            MessageBox.Show("Cerrando Inventario");
            try
            {
                foreach (DataGridViewRow row in datalistado1.Rows)
                {
                    Rta = NacfICRt_Inventariocaracteristicas.CerrarInventario(
                      //this.datalistado1.CurrentRow.Cells[0].Value.ToString()
                     this.datalistado1.CurrentRow.Cells[5].Value.ToString()
                    , this.datalistado1.CurrentRow.Cells[6].Value.ToString()
                    , this.datalistado1.CurrentRow.Cells[8].Value.ToString()

                  );

                    if (Rta.Equals("OK"))
                    {
                        this.MensajeOk("Proceso Terminado Correctamente");
                        mostrar(cboINV.Text);
                    }
                    else
                    {
                        this.MensajeError("Error al Cerrar Inventario:" + Rta);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
    }

