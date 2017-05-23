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
    public partial class FrmACF_SustituacionMejora : KryptonForm
    {
        public FrmACF_SustituacionMejora()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
           
        }
        private void FrmACF_SustituacionMejora_Load(object sender, EventArgs e)
        {
            Columnas();
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
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void toolStripActivos_Click(object sender, EventArgs e)
        {
            BotonesIE(true);
            //mostrar();
        }

        private void BotonesIE(bool edo)
        {

            this.toolStripRefrescar.Visible = !edo;
            this.toolStripActivos.Visible = !edo;
            this.toolStripAgregar.Visible = edo;
            this.toolStripGuardar.Visible = edo;
            this.toolStripCancelar.Visible = edo;
            this.toolStripEliminar.Visible = edo;


        }

        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            BotonesIE(false);
            this.dataListado.DataSource = null;
            this.dataListado.Rows.Clear();
            this.dataListado.Refresh();
        }

        private void toolStripAgregar_Click(object sender, EventArgs e)
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

        private void Columnas()
        {
            
            this.dataListado.Columns[0].Width = 70;
            this.dataListado.Columns[1].Width = 70;
            this.dataListado.Columns[2].Width = 50;
            this.dataListado.Columns[3].Width = 50;
            this.dataListado.Columns[4].Width = 70;
            this.dataListado.Columns[5].Width = 70;
            this.dataListado.Columns[6].Width = 80;
            this.dataListado.Columns[7].Width = 70;
            this.dataListado.Columns[8].Width = 70;
            this.dataListado.Columns[9].Width = 70;
            this.dataListado.Columns[10].Width = 50;
            this.dataListado.Columns[11].Width = 50;
            this.dataListado.Columns[12].Width = 70;
            this.dataListado.Columns[13].Width = 70;
            this.dataListado.Columns[14].Width = 70;
            this.dataListado.Columns[15].Width = 70;

            this.dataListado.Columns[0].HeaderText = "Id";
            this.dataListado.Columns[1].HeaderText = "Marca";
            this.dataListado.Columns[2].HeaderText = "Serie";
            this.dataListado.Columns[3].HeaderText = "Modelo";
            this.dataListado.Columns[4].HeaderText = "Color";
            this.dataListado.Columns[5].HeaderText = "Resolucion";
            this.dataListado.Columns[6].HeaderText = "Capacidad";
            this.dataListado.Columns[7].HeaderText = "Potencia";
            this.dataListado.Columns[8].HeaderText = "Velocidad Nom.";
            this.dataListado.Columns[9].HeaderText = "Velocidad Ent.";
            this.dataListado.Columns[10].HeaderText = "Velocidad Sal.";
            this.dataListado.Columns[11].HeaderText = "Frecuencia";
            this.dataListado.Columns[12].HeaderText = "Temperatura";
            this.dataListado.Columns[13].HeaderText = "Procesador";
            this.dataListado.Columns[14].HeaderText = "Puertos";
            this.dataListado.Columns[15].HeaderText = "Observacion";
        }
        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            int fil = dataListado.CurrentRow.Index;
            dataListado.Rows.RemoveAt(fil);
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            string Rta = string.Empty;
            Int32 i;
            MessageBox.Show("insertar");
            try
            {

                for (i = 0; i < dataListado.Rows.Count; i++)
                {
                    Rta = NacfCRSt_Caracteristicas.EditarSustitucionMejora(
                      this.dataListado.Rows[i].Cells[0].Value.ToString()
                    , this.dataListado.Rows[i].Cells[1].Value.ToString()
                    , this.dataListado.Rows[i].Cells[2].Value.ToString()
                    , this.dataListado.Rows[i].Cells[3].Value.ToString()
                    , this.dataListado.Rows[i].Cells[4].Value.ToString()
                    , this.dataListado.Rows[i].Cells[5].Value.ToString()
                    , this.dataListado.Rows[i].Cells[6].Value.ToString()
                    , this.dataListado.Rows[i].Cells[7].Value.ToString()
                    , this.dataListado.Rows[i].Cells[8].Value.ToString()
                    , this.dataListado.Rows[i].Cells[9].Value.ToString()
                    , this.dataListado.Rows[i].Cells[10].Value.ToString()
                    , this.dataListado.Rows[i].Cells[11].Value.ToString()
                    , this.dataListado.Rows[i].Cells[12].Value.ToString()
                    , this.dataListado.Rows[i].Cells[13].Value.ToString()
                    , this.dataListado.Rows[i].Cells[14].Value.ToString()
                    , this.dataListado.Rows[i].Cells[15].Value.ToString()
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
