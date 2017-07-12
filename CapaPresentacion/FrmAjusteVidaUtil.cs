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
    public partial class FrmAjusteVidaUtil : KryptonForm
    {
        public FrmAjusteVidaUtil()
        {
            InitializeComponent();
            mostrar();
            this.chkEliminar.Click += new System.EventHandler(this.Control_Click_ChkEliminar);
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(Control_Click_dataListado);
        }

        private void mostrar()
        {
            this.BotonesIE(true);

            //this.dataListado.DataSource = NacfACFp_Activo_Fijo.Mostrar2("0"); 
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

            this.dataListado.Columns[1].HeaderText = "Id";
            this.dataListado.Columns[2].HeaderText = "Descripcion";
            this.dataListado.Columns[3].HeaderText = "V.Util Año";
            this.dataListado.Columns[4].HeaderText = "V.Util Dia";
            this.dataListado.Columns[5].HeaderText = "V.Util Año Mod";
            this.dataListado.Columns[6].HeaderText = "V.Util Dia Mod";
            this.dataListado.Columns[7].HeaderText = "vutiltribanio";
            this.dataListado.Columns[8].HeaderText = "ACFvutiltribdia";
            this.dataListado.Columns[9].HeaderText = "VUtilTribAnioMOD";
            this.dataListado.Columns[10].HeaderText = "VUtilTribDiaMOD";
            this.dataListado.Columns[11].HeaderText = "ACFdepacutrib";
            this.dataListado.Columns[12].HeaderText = "ACFdepacuniif";
            this.dataListado.Columns[13].HeaderText = "CMPid";

        }

        private void BotonesIE(bool edo)
        {
            this.toolStripRefrescar.Visible = !edo;            
            this.toolStripAnterior.Visible = !edo;
            this.toolStripGuardar.Visible = edo;
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

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void FrmAjusteValorBien_Load(object sender, EventArgs e)    
        {
            //mostrar();
            dataListado.AllowUserToAddRows = false;

        }

        private void dataListado_ColumnAdded(object sender, DataGridViewColumnEventArgs e) {}

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Control:", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Control_", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripAgregar_Click(object sender, EventArgs e)
        {
            
            string iACFid = Microsoft.VisualBasic.Interaction.InputBox(
                            "Ingrese el Id del Activo Fijo",
                            "Ajuste del Valor del Bien");
            if (iACFid != null)
            {

                //dataListado.DataSource = NacfACFp_Activo_Fijo.Mostrar2(iACFid);
                dataListado.DataSource = null;
                DataTable tabla = NacfACFp_Activo_Fijo.Mostrar2(iACFid);
                if (tabla.Rows.Count > 0)
                {
                    foreach (DataRow Drow in tabla.Rows)
                    {
                        int num = dataListado.Rows.Add();
                        dataListado.Rows[num].Cells[1].Value = Drow["ACFid"].ToString();
                        dataListado.Rows[num].Cells[2].Value = Drow["ACFdescripcion"].ToString();
                        dataListado.Rows[num].Cells[3].Value = Drow["ACFvutilniifanio"].ToString();
                        dataListado.Rows[num].Cells[4].Value = Drow["ACFvutilniifdia"].ToString();
                        dataListado.Rows[num].Cells[5].Value = Drow["VidaUtilNiffanioMOD"].ToString();
                        dataListado.Rows[num].Cells[6].Value = Drow["VidaUtilNiffdiaMOD"].ToString();
                        dataListado.Rows[num].Cells[7].Value = Drow["ACFvutiltribanio"].ToString();
                        dataListado.Rows[num].Cells[8].Value = Drow["ACFvutiltribdia"].ToString();
                        dataListado.Rows[num].Cells[9].Value = Drow["VUtilTribAnioMOD"].ToString();
                        dataListado.Rows[num].Cells[10].Value = Drow["VUtilTribDiaMOD"].ToString();
                        dataListado.Rows[num].Cells[11].Value = Drow["ACFdepacutrib"].ToString();
                        dataListado.Rows[num].Cells[12].Value = Drow["ACFdepacuniif"].ToString();
                        dataListado.Rows[num].Cells[13].Value = Drow["CMPid"].ToString();
                    }
                }
                else
                    MessageBox.Show("No Existe", "Registro");

            }
        }

        private void toolStripRefrescar_Click(object sender, EventArgs e)
        {
            BotonesIE(true);
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            string Rta = string.Empty;
            MessageBox.Show("Editando Vida Util");
            try
            {
                foreach (DataGridViewRow row in dataListado.Rows)
                {
                    Rta = NacfACFp_Activo_Fijo.Editar2(
                     this.dataListado.CurrentRow.Cells[1].Value.ToString()
                    , this.dataListado.CurrentRow.Cells[5].Value.ToString()
                    , this.dataListado.CurrentRow.Cells[6].Value.ToString()
                    , this.dataListado.CurrentRow.Cells[9].Value.ToString()
                    , this.dataListado.CurrentRow.Cells[10].Value.ToString()

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

        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            int fil = dataListado.CurrentRow.Index;
            dataListado.Rows.RemoveAt(fil);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
