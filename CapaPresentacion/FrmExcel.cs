﻿using System;
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

    public partial class FrmExcel : Form
    {
        public FrmExcel()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string hoja;
            hoja = txtHoja.Text;
            new Importar().importarExcel(dataGridView1, hoja);


        }

        private void FrmExcel_Load(object sender, EventArgs e)
        {

        }
    }
}
