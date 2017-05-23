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
    public partial class Frm_LiquidacionObra : Form
    {
        public Frm_LiquidacionObra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Frm_3_Load(object sender, EventArgs e)
        {
            dataListado.AllowUserToAddRows = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripActivos_Click(object sender, EventArgs e)
        {
            if (txtHoja.Text == string.Empty)
            {
                MessageBox.Show("Inserte el nombre de la HOJA");
            }
            else
            {
                try
                {
                    string hoja;
                    hoja = txtHoja.Text;

                    BotonesIE(true);
                    new Importar().importarExcelLiqui(dataListado, hoja, true);
                    //Columnas();
                    
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                //falta mostrar el ACFid
                Int32 total = 0;
                foreach (DataGridViewRow row in dataListado.Rows)
                {
                    string Rta = string.Empty;

                    total = total + Convert.ToInt32(row.Cells[2].Value); 

                    Rta = NacfACFp_Activo_Fijo.Insertar2(
                    Convert.ToString(row.Cells[0].Value) //ACFdescripcion
          );
                    if (Rta.Equals("OK"))
                    {
                    }
                    else
                    {
                        break;

                    }

                }
                MessageBox.Show("Datos agregados");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        
        }

        private void BotonesIE(bool edo)
        {
            
            this.toolStripActivos.Visible   =  !edo;
            this.toolStripRefrescar.Visible =   edo;
            this.toolStripGuardar.Visible   =  edo;
            this.toolStripCancelar.Visible  =  edo;
            this.toolStripSiguiente.Visible =  edo;
        }

        private void toolStripSiguiente_Click(object sender, EventArgs e)
        {
            new Importar().ExportarDataGridViewExcel(dataListado);
        }

        private void toolStripRefrescar_Click(object sender, EventArgs e)
        {

                    decimal total = 0;
                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        total = total + Convert.ToDecimal(row.Cells[2].Value);
                    }

                    this.textBox1.Text = Convert.ToString(total);
                    this.textBox2.Text = Convert.ToString(total);
                    MessageBox.Show("Datos Procesados");

        }


    }
}
