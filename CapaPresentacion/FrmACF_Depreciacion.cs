using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmACF_Depreciacion : Form
    {
        
        public FrmACF_Depreciacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int proceso = 0;
            if (checkBox1.Checked == true)   { proceso = 1; };
            if (checkBox2.Checked == true)   { proceso = 2; };
            if ((checkBox1.Checked == true) && (checkBox2.Checked == true) )
                                             { proceso = 3; };
            switch (proceso)
            {                
                case 1:
                    MessageBox.Show("Proceso de Depreciaciación - Contable NIIF");
                    break;
                case 2:
                    MessageBox.Show("Proceso de Depreciaciación - Tributaria LIR");
                    break;
                case 3:
                    MessageBox.Show("Proceso de Depreciaciación - Contable y Tributaria");
                    break;
                default:
                    MessageBox.Show("Debe Elegir el Tipo Proceso de Depreciaciación");
                    break;
            };        
                                             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
