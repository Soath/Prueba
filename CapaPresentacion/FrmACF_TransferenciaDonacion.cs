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
using Excel=Microsoft.Office.Interop.Excel;


namespace CapaPresentacion
{
    public partial class FrmACF_TransferenciaDonacion : KryptonForm
    {
        public FrmACF_TransferenciaDonacion()
        {
            InitializeComponent();
            this.chkEliminar.Click += new System.EventHandler(this.Control_Click_ChkEliminar);
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(Control_Click_dataListado);

        }



        private void mostrar()
        {
            this.BotonesIE(true);

            this.dataListado.DataSource = NACF_TransferenciaDonacion.Mostrar();
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
            this.dataListado.Columns[1].Width = 70;
            this.dataListado.Columns[2].Width = 150;
            this.dataListado.Columns[3].Width = 50;
            this.dataListado.Columns[4].Width = 50;
            this.dataListado.Columns[5].Width = 50;
            this.dataListado.Columns[6].Width = 50;

            this.dataListado.Columns[1].HeaderText = "Cod.Ext";
            this.dataListado.Columns[2].HeaderText = "Nro.ACF";
            this.dataListado.Columns[3].HeaderText = "Descripcion";
            this.dataListado.Columns[4].HeaderText = "C.Costo";
            this.dataListado.Columns[5].HeaderText = "Personal";
            this.dataListado.Columns[6].HeaderText = "Serie";
            this.dataListado.Columns[7].HeaderText = "INV.";
            this.dataListado.Columns[8].HeaderText = "ESTADO";
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

        private void Control_Click_dataListado(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }
        private void Control_Click_ChkEliminar(object sender, EventArgs e)
        {
            this.BotonChkEliminar();
        }

        private void BotonChkEliminar()
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
             BotonesIE(true);
             mostrar();
        }

        private void toolStripAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                string Hoja1 = Microsoft.VisualBasic.Interaction.InputBox(
                                 "Ingrese el nombre de la Hoja:",
                                 "Se requiere nombre de la Hoja");
                if (Hoja1!="")
                {
                    BotonesIE(true);
                new Importar().importarExcelca("",dataListado, Hoja1, true);
                Columnas();
                }
            }
            catch (Exception ex)
            {
            }
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

        


        private void toolStripSiguiente_Click(object sender, EventArgs e)
        {
            
            new Importar().ExportarDataGridViewExcel(dataListado);
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


                    Rta = NacfACFp_Activo_Fijo.Insertar2(
                    Convert.ToString(row.Cells[3].Value) //ACFdescripcion
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
                        Rta = NacfACFp_Activo_Fijo.Insertar2(
                        Convert.ToString(row.Cells[3].Value) //ACFdescripcion
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

        private void FrmACF_TransferenciaDonacion_Load(object sender, EventArgs e)
        {

        }
    }
}
