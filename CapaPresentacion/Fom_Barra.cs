﻿using System;
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
    public partial class Fom_Barra : Form
    {
        public Fom_Barra()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Reportes
            FrmReportes rptalu = new FrmReportes("Reportes\\Rpt_ACTactividad.rdlc", NacfACFp_Activo_Fijo.Mostrar(), "ip");
            rptalu.ShowDialog();
        }
    }
}