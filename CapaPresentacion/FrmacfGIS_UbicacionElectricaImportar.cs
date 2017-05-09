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
    public partial class FrmacfGIS_UbicacionElectricaImportar : Form
    {
        public int NumFila;
        public FrmacfGIS_UbicacionElectricaImportar()
        {
            InitializeComponent();
        }

        private void FrmacfGIS_UbicacionElectricaImportar_Load(object sender, EventArgs e)
        {
            dataListado.DataSource = NacfGIS_UbicacionElectrica.Mostrar("0");
        }

        private void dataListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dataListado.Rows[e.RowIndex];

            FrmacfGIS_UbicacionElectricaProcesar form = new FrmacfGIS_UbicacionElectricaProcesar();

            form.textBox1.Text = row.Cells[0].Value.ToString();
            form.textBox2.Text = row.Cells[1].Value.ToString();
            form.textBox3.Text = row.Cells[2].Value.ToString();
            form.textBox4.Text = row.Cells[3].Value.ToString();
            form.textBox5.Text = row.Cells[4].Value.ToString();
            form.textBox6.Text = row.Cells[5].Value.ToString();
            form.textBox7.Text = row.Cells[6].Value.ToString();
            form.textBox8.Text = row.Cells[7].Value.ToString();
            form.textBox9.Text = row.Cells[8].Value.ToString();
            form.textBox10.Text = row.Cells[9].Value.ToString();
            form.textBox11.Text = row.Cells[10].Value.ToString();
            form.textBox12.Text = row.Cells[11].Value.ToString();
            form.textBox13.Text = row.Cells[12].Value.ToString();
            form.textBox14.Text = row.Cells[13].Value.ToString();
            form.textBox15.Text = row.Cells[14].Value.ToString();
            form.textBox16.Text = row.Cells[15].Value.ToString();
            form.textBox17.Text = row.Cells[16].Value.ToString();
            form.textBox18.Text = row.Cells[17].Value.ToString();
            form.textBox19.Text = row.Cells[18].Value.ToString();
            form.textBox20.Text = row.Cells[19].Value.ToString();
            form.textBox21.Text = row.Cells[20].Value.ToString();
            form.textBox22.Text = row.Cells[21].Value.ToString();
            form.textBox23.Text = row.Cells[22].Value.ToString();
            form.textBox24.Text = row.Cells[23].Value.ToString();
            form.textBox25.Text = row.Cells[24].Value.ToString();
            form.textBox26.Text = row.Cells[25].Value.ToString();
            form.textBox27.Text = row.Cells[26].Value.ToString();
            form.textBox28.Text = row.Cells[27].Value.ToString();
            
            //form.NumFila = dataListado.CurrentRow.Index;

            NumFila = dataListado.CurrentRow.Index;
            form.ShowDialog();
            dataListado.Rows[NumFila].Cells[0].Value =  form.var1 ;
            dataListado.Rows[NumFila].Cells[1].Value =  form.var2 ;
            dataListado.Rows[NumFila].Cells[2].Value =  form.var3 ;
            dataListado.Rows[NumFila].Cells[3].Value =  form.var4 ;
            dataListado.Rows[NumFila].Cells[4].Value =  form.var5 ;
            dataListado.Rows[NumFila].Cells[5].Value =  form.var6 ;
            dataListado.Rows[NumFila].Cells[6].Value =  form.var7 ;
            dataListado.Rows[NumFila].Cells[7].Value =  form.var8 ;
            dataListado.Rows[NumFila].Cells[8].Value =  form.var9 ;
            dataListado.Rows[NumFila].Cells[9].Value =  form.var10;
            dataListado.Rows[NumFila].Cells[10].Value = form.var11;
            dataListado.Rows[NumFila].Cells[11].Value = form.var12;
            dataListado.Rows[NumFila].Cells[12].Value = form.var13;
            dataListado.Rows[NumFila].Cells[13].Value = form.var14;
            dataListado.Rows[NumFila].Cells[14].Value = form.var15;
            dataListado.Rows[NumFila].Cells[15].Value = form.var16;
            dataListado.Rows[NumFila].Cells[16].Value = form.var17;
            dataListado.Rows[NumFila].Cells[17].Value = form.var18;
            dataListado.Rows[NumFila].Cells[18].Value = form.var19;
            dataListado.Rows[NumFila].Cells[19].Value = form.var20;
            dataListado.Rows[NumFila].Cells[20].Value = form.var21;
            dataListado.Rows[NumFila].Cells[21].Value = form.var22;
            dataListado.Rows[NumFila].Cells[22].Value = form.var23;
            dataListado.Rows[NumFila].Cells[23].Value = form.var24;
            dataListado.Rows[NumFila].Cells[24].Value = form.var25;
            dataListado.Rows[NumFila].Cells[25].Value = form.var26;
            dataListado.Rows[NumFila].Cells[26].Value = form.var27;
            dataListado.Rows[NumFila].Cells[27].Value = form.var28;



        }

        private void button1_Click(object sender, EventArgs e)
        {
           string Rta = string.Empty;
           MessageBox.Show("Espere Por favor....");
           try
           {
               foreach (DataGridViewRow row in dataListado.Rows)
               {
                   Rta = NacfACFp_Activo_Fijo.Editar2(
                    this.dataListado.CurrentRow.Cells[0].Value.ToString()
                   , this.dataListado.CurrentRow.Cells[4].Value.ToString()
                   , this.dataListado.CurrentRow.Cells[5].Value.ToString()
                   , this.dataListado.CurrentRow.Cells[8].Value.ToString()
                   , this.dataListado.CurrentRow.Cells[9].Value.ToString()
        
                 );
               }
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message + ex.StackTrace);
           }
        }
    }
}
