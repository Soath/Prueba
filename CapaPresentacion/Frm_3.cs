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
    public partial class Frm_3 : Form
    {
        public Frm_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

                    new Importar().importarExcel(dataGridView1, hoja);
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void Frm_3_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //falta mostrar el ACFid
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                   string Rta = string.Empty;
                   Rta = NacfACFp_Activo_Fijo.Insertar2(
       Convert.ToString(row.Cells[1].Value), //ACFid
       Convert.ToString(row.Cells[2].Value) //ACFdescripcion
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
    }
}
