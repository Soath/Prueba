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
using Excel = Microsoft.Office.Interop.Excel;


namespace CapaPresentacion
{
    public partial class FrmACF_BajaEvaluacionTecnica : KryptonForm
    {
        public FrmACF_BajaEvaluacionTecnica()
        {
            InitializeComponent();
        }



        private void mostrar()
        {
            this.BotonesIE(true);

            this.dataListado.DataSource = NACF_BajaEvaluacionTecnica.Mostrar();
            Columnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
            if (dataListado.Rows.Count == 0)
            {
                BotonesIE(false);
            }
            else
            {
                BotonesIE(true);

            }
            this.dataListado.Select();
            this.dataListado.Focus();
        }

        private void Columnas()
        {

            this.dataListado.Columns[0].Width = 70;
            this.dataListado.Columns[1].Width = 100;
            this.dataListado.Columns[2].Width = 220;
            this.dataListado.Columns[3].Width = 120;

            this.dataListado.Columns[0].HeaderText = "Seleccionar";
            this.dataListado.Columns[1].HeaderText = "Activo Fijo";
            this.dataListado.Columns[2].HeaderText = "Descripcion";
            this.dataListado.Columns[3].HeaderText = "ESTADO";
        }

        private void BotonesIE(bool edo)
        {
            this.toolStripRefrescar.Visible = !edo;
            this.toolStripAnterior.Visible = !edo;
            this.toolStripAgregar.Visible = edo;
            this.toolStripEditar.Visible = edo;
            this.toolStripCancelar.Visible = edo;
            this.toolStripSiguiente.Visible = edo;
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripPrimero_Click(object sender, EventArgs e)
        {

        }

        private void toolStripBuscar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripRefrescar_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripAnterior_Click(object sender, EventArgs e)
        {
            BotonesIE(true);
            new Importar().importarExcelca(" ",dataListado, "Hoja1", true);
            Columnas();
        }

        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            BotonesIE(false);
            this.dataListado.DataSource = null;
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            BotonesIE(false);
        }

        private void FrmACF_BajaEvaluacionTecnica_Load(object sender, EventArgs e)
        {

        }


        private void toolStripSiguiente_Click(object sender, EventArgs e)
        {

            new Importar().ExportarDataGridViewExcel(dataListado);
        }

        private void toolStripRefrescar_Click_1(object sender, EventArgs e)
        {
            BotonesIE(true);
            mostrar();
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
            }
        }

        private void toolStripAgregar_Click(object sender, EventArgs e)
        {
            if (this.chkEliminar.Checked)
                this.grabarlote();
            else
                this.grabarsele();
        }

        private void grabarlote()
        {
            try
            {
                //falta mostrar el ACFid
                Int32 total = 0;
                foreach (DataGridViewRow row in dataListado.Rows)
                {
                    string Rta = string.Empty;


                    Rta = NacfACFp_Activo_Fijo.Editar5(
                    Convert.ToString(row.Cells[1].Value) //ACFdescripcion
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


        private void grabarsele()
        {
            try
            {
                //falta mostrar el ACFid
                Int32 total = 0;
                foreach (DataGridViewRow row in dataListado.Rows)
                {
                    string Rta = string.Empty;

                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        Rta = NacfACFp_Activo_Fijo.Editar5(
                        Convert.ToString(row.Cells[1].Value) //ACFdescripcion
                        );
                        if (Rta.Equals("OK"))
                        {
                        }
                        else
                        {
                            break;

                        }
                    }
                }
                MessageBox.Show("Datos agregados");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
