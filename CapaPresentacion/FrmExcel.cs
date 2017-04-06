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
    
    public partial class FrmExcel : Form
    {
        public FrmExcel()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtHoja.Text == string.Empty)
            {
                MessageBox.Show("Inserte el nombre de la HOJA");
            }
            else { 
 


            try
            {
                string hoja;
                hoja = txtHoja.Text;
            
                new Importar().importarExcel(dataGridView1, hoja);
            }
            catch (Exception ex)
            {
                
            }
            
                

        }
        }
        private void FrmExcel_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string Rta = string.Empty;
                    Rta = NacfACFp_Activo_Fijo.Insertar(
         Convert.ToString(row.Cells[0].Value),
         Convert.ToString(row.Cells[1].Value), 
         Convert.ToString(row.Cells[2].Value),  
         Convert.ToString(row.Cells[3].Value),  
         Convert.ToString(row.Cells[4].Value) , 
         Convert.ToString(row.Cells[5].Value)  ,
         Convert.ToString(row.Cells[6].Value)  ,
         Convert.ToString(row.Cells[7].Value)  ,
         Convert.ToString(row.Cells[8].Value)  ,
         Convert.ToString(row.Cells[9].Value)  ,
         Convert.ToString(row.Cells[10].Value)  ,
         Convert.ToString(row.Cells[11].Value)  ,
         Convert.ToString(row.Cells[12].Value)  ,
         Convert.ToString(row.Cells[13].Value)  ,
         Convert.ToString(row.Cells[14].Value)  ,
         Convert.ToString(row.Cells[15].Value)  ,
         Convert.ToString(row.Cells[16].Value)  ,
         Convert.ToString(row.Cells[17].Value)  ,
         Convert.ToString(row.Cells[18].Value)  ,
         Convert.ToString(row.Cells[19].Value)  ,
         Convert.ToString(row.Cells[20].Value)  ,
         Convert.ToString(row.Cells[21].Value)  ,
         Convert.ToString(row.Cells[22].Value)  ,
         Convert.ToString(row.Cells[23].Value)  ,
         Convert.ToString(row.Cells[24].Value)  ,
         Convert.ToString(row.Cells[25].Value)  ,
         Convert.ToString(row.Cells[26].Value)  ,
         Convert.ToString(row.Cells[27].Value)  ,
         Convert.ToString(row.Cells[28].Value)  ,
         Convert.ToString(row.Cells[29].Value)  ,
         Convert.ToString(row.Cells[30].Value)  ,
         Convert.ToString(row.Cells[31].Value)  ,
         Convert.ToString(row.Cells[32].Value)  ,
         Convert.ToString(row.Cells[33].Value)  ,
         Convert.ToString(row.Cells[34].Value)  ,
         Convert.ToString(row.Cells[35].Value)  ,
         Convert.ToString(row.Cells[36].Value)  ,
         Convert.ToString(row.Cells[37].Value)  ,
         Convert.ToString(row.Cells[38].Value)  ,
         Convert.ToString(row.Cells[39].Value)  ,
         Convert.ToString(row.Cells[40].Value)  ,
         Convert.ToString(row.Cells[41].Value)  ,
         Convert.ToString(row.Cells[42].Value)  ,
         Convert.ToString(row.Cells[43  ].Value));
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
    }
}

