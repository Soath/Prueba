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
    public partial class FrmACF_SustituacionMejora : Form
    {
        public FrmACF_SustituacionMejora()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string iACFid = Microsoft.VisualBasic.Interaction.InputBox(
                            "Ingrese el Id del Activo Fijo",
                            "Ajuste del Valor del Bien");
            if (iACFid != null)
            {

                //dataListado.DataSource = NacfACFp_Activo_Fijo.Mostrar2(iACFid);

                DataTable tabla = NacfCRSt_Caracteristicas.MostrarSustitucionMejora(iACFid);

                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow Drow in tabla.Rows)
                    {
                    int num = dataListado.Rows.Add();
                    dataListado.Rows[num].Cells[0].Value = Drow["ACFid"].ToString();
                    dataListado.Rows[num].Cells[1].Value = Drow["MARid"].ToString();
                    dataListado.Rows[num].Cells[2].Value = Drow["CRSserie"].ToString();
                    dataListado.Rows[num].Cells[3].Value = Drow["CRSmodelo"].ToString();
                    dataListado.Rows[num].Cells[4].Value = Drow["CRScolor"].ToString();
                    dataListado.Rows[num].Cells[5].Value = Drow["CRSresolucion"].ToString();
                    dataListado.Rows[num].Cells[6].Value = Drow["CRScapacidad"].ToString();
                    dataListado.Rows[num].Cells[7].Value = Drow["CRSpotencia"].ToString();
                    dataListado.Rows[num].Cells[8].Value = Drow["CRSvnominal"].ToString();
                    dataListado.Rows[num].Cells[9].Value = Drow["CRSventrada"].ToString();
                    dataListado.Rows[num].Cells[10].Value = Drow["CRSvsalida"].ToString();
                    dataListado.Rows[num].Cells[11].Value = Drow["CRSfrecuencia"].ToString();
                    dataListado.Rows[num].Cells[12].Value = Drow["CRStemperatura"].ToString();
                    dataListado.Rows[num].Cells[13].Value = Drow["CRSprocesador"].ToString();
                    dataListado.Rows[num].Cells[14].Value = Drow["CRSpuertos"].ToString();
                    dataListado.Rows[num].Cells[15].Value = Drow["CRSobservacion"].ToString();                                        
                    }
                }
                else
                    MessageBox.Show("No Existe", "Registro");
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            int fil = dataListado.CurrentRow.Index;
            dataListado.Rows.RemoveAt(fil);
        }
        private void FrmACF_SustituacionMejora_Load(object sender, EventArgs e)
        {
            this.button6.Enabled = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Rta = string.Empty;
            MessageBox.Show("insertar");
            try
            {
                foreach (DataGridViewRow row in dataListado.Rows)
                {
                    Rta = NacfCRSt_Caracteristicas.EditarSustitucionMejora(
                      this.dataListado.CurrentRow.Cells[0].Value.ToString()
                    , this.dataListado.CurrentRow.Cells[1].Value.ToString()
                    , this.dataListado.CurrentRow.Cells[2].Value.ToString()
                    , this.dataListado.CurrentRow.Cells[3].Value.ToString()
                    , this.dataListado.CurrentRow.Cells[4].Value.ToString()
                    , this.dataListado.CurrentRow.Cells[5].Value.ToString()
                    , this.dataListado.CurrentRow.Cells[6].Value.ToString()
                    , this.dataListado.CurrentRow.Cells[7].Value.ToString()
                    , this.dataListado.CurrentRow.Cells[8].Value.ToString()
                    , this.dataListado.CurrentRow.Cells[9].Value.ToString()
                    , this.dataListado.CurrentRow.Cells[10].Value.ToString()
                    , this.dataListado.CurrentRow.Cells[11].Value.ToString()
                    , this.dataListado.CurrentRow.Cells[12].Value.ToString()
                    , this.dataListado.CurrentRow.Cells[13].Value.ToString()
                    , this.dataListado.CurrentRow.Cells[14].Value.ToString()
                    , this.dataListado.CurrentRow.Cells[15].Value.ToString()
                  );

                    if (Rta.Equals("OK"))
                    {
                        this.MensajeOk("Regsitro Agregado Correctamente");
                    }
                    else
                    {
                        this.MensajeError("Error al Insertar Registro :" + Rta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
