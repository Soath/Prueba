﻿using System;
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
    public partial class Frm_ConciliarInventario : KryptonForm
    {
        public Frm_ConciliarInventario()
        {
            InitializeComponent();
            CargarCombos();
        }

        private void CargarCombos()
        {
            this.cboACF1.DataSource = NacfACFp_Activo_Fijo.Mostrar(); //ACFid
            this.cboACF1.ValueMember = "ACFid";
            this.cboACF1.DisplayMember = "ACFid";
            this.cboACF1.SelectedIndex = -1;

            this.cboACF2.DataSource = NacfACFp_Activo_Fijo.MostrarINV(cboINV.Text); //ACFid
            this.cboACF2.ValueMember = "ACFid";
            this.cboACF2.DisplayMember = "ACFid";
            this.cboACF2.SelectedIndex = -1;

            this.cboINV.DataSource = NacfINVp_Inventario.Mostrar(); //INVid
            this.cboINV.ValueMember = "INVid";
            this.cboINV.DisplayMember = "INVid";
            this.cboINV.SelectedIndex = -1;

        }

        private void mostrar(string iINVid, string iACFid)
        {
            this.datalistado1.DataSource = NacfINBt_Inventariobienes.conciliarinvent(iINVid, iACFid);
            /* if (datalistado.Rows.Count == 0)
             {
                 BotonesSinReg(false);
             }
             else
             {
                 BotonesSinReg(true);
                 this.toolStripAgregar.Enabled = true;

             }
             this.datalistado.Select();
             this.datalistado.Focus();*/


        }

        private void Frm_ConciliarInventario_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrar(cboINV.Text, cboACF2.Text);
        }
    }
}
