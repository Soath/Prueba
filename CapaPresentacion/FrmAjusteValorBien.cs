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
    public partial class FrmAjusteValorBien : Form
    {
        public FrmAjusteValorBien()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string iACFid = Microsoft.VisualBasic.Interaction.InputBox(
                            "Ingrese el Id del Activo Fijo",
                            "Ajuste del Valor del Bien");
            if (iACFid != null)
            {
                
                //dataListado.DataSource = NacfACFp_Activo_Fijo.Mostrar2(iACFid);
                                
                DataTable tabla = NacfACFp_Activo_Fijo.Mostrar2(iACFid);
                
                 foreach (DataRow Drow in tabla.Rows)
                 {
                     int num = dataListado.Rows.Add();
                     dataListado.Rows[num].Cells[0].Value = Drow["ACFid"].ToString();
                     dataListado.Rows[num].Cells[1].Value = Drow["ACFdescripcion"].ToString();
                     dataListado.Rows[num].Cells[2].Value = Drow["ACFvutilniifanio"].ToString();
                     dataListado.Rows[num].Cells[3].Value = Drow["ACFvutilniifdia"].ToString();
                     dataListado.Rows[num].Cells[4].Value = Drow["VidaUtilNiffanioMOD"].ToString();
                     dataListado.Rows[num].Cells[5].Value = Drow["VidaUtilNiffdiaMOD"].ToString();
                     dataListado.Rows[num].Cells[6].Value = Drow["ACFvutiltribanio"].ToString();
                     dataListado.Rows[num].Cells[7].Value = Drow["ACFvutiltribdia"].ToString();
                     dataListado.Rows[num].Cells[8].Value = Drow["VUtilTribAnioMOD"].ToString();
                     dataListado.Rows[num].Cells[9].Value = Drow["VUtilTribDiaMOD"].ToString();
                     dataListado.Rows[num].Cells[10].Value = Drow["ACFdepacutrib"].ToString();
                     dataListado.Rows[num].Cells[11].Value = Drow["ACFdepacuniif"].ToString();
                     dataListado.Rows[num].Cells[12].Value = Drow["CMPid"].ToString();
                 }

            }

        }

        private void FrmAjusteValorBien_Load(object sender, EventArgs e)
        {
            
        }

        private void dataListado_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int fil = dataListado.CurrentRow.Index;
            dataListado.Rows.RemoveAt(fil);
        }
    }
}
