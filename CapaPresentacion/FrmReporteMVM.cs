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
    public partial class FrmReporteMVM : Form
    {
        public FrmReporteMVM()
        {
            InitializeComponent();
        }

        private void FrmReporteMVM_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ActivosFijosDataSet.acfMVMt_MotivoMovimiento' Puede moverla o quitarla según sea necesario.
            this.acfMVMt_MotivoMovimientoTableAdapter.Fill(this.ActivosFijosDataSet.acfMVMt_MotivoMovimiento);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
