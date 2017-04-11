using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocio;


namespace CapaPresentacion
{

    public partial class FrmExcel2 : Form
    {
        public FrmExcel2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string hoja;
            hoja = txtHoja.Text;
            new Importar().importarExcel(dataGridView1, hoja);


        }

        private void FrmExcel2_Load(object sender, EventArgs e)
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
                    Rta = NacfMVMt_MotivoMovimiento.Insertar(Convert.ToString(row.Cells[0].Value), Convert.ToString(row.Cells[1].Value), Convert.ToString(row.Cells[2].Value), Convert.ToString(row.Cells[3].Value));

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
