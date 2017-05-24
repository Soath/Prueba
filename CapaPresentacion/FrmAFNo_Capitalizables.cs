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
using Excel=Microsoft.Office.Interop.Excel;


namespace CapaPresentacion
{
    public partial class FrmAFNo_Capitalizables : KryptonForm
    {
        public FrmAFNo_Capitalizables()
        {
            InitializeComponent();
            this.chkEliminar.Click += new System.EventHandler(this.Control_Click_ChkEliminar);
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(Control_Click_dataListado);
            this.Load += new System.EventHandler(this.FrmAFNo_Capitalizables_miLoad);
        }



        private void mostrar()
        {
            this.BotonesIE(true);

            this.dataListado.DataSource = NAFNo_Capitalizables.Mostrar();
            Columnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
            if (dataListado.Rows.Count == 0)
            {
                BotonesIE(false);
            }
            else
            {
                BotonesIE(true);

            }
            this.dataListado.Select();
            this.dataListado.Focus();
        }

        private void Columnas()
        {

            this.dataListado.Columns[0].Width = 70;
            this.dataListado.Columns[1].Width = 70;
            this.dataListado.Columns[2].Width = 200;
            this.dataListado.Columns[3].Width = 50;
            this.dataListado.Columns[4].Width = 50;
            this.dataListado.Columns[5].Width = 100;
            this.dataListado.Columns[6].Width = 100;
            this.dataListado.Columns[7].Width = 80;
            this.dataListado.Columns[8].Width = 200;

            this.dataListado.Columns[1].HeaderText = "Clase";
            
            this.dataListado.Columns[2].HeaderText = "Descripcion";
            this.dataListado.Columns[3].HeaderText = "Cantidad";
            this.dataListado.Columns[4].HeaderText = "Unidad";
            this.dataListado.Columns[5].HeaderText = "Precio";
            this.dataListado.Columns[6].HeaderText = "Total";
            this.dataListado.Columns[7].HeaderText = "RUC";
            this.dataListado.Columns[8].HeaderText = "Proveedor";
        }

        private void BotonesIE(bool edo)
        {
            this.toolStripRefrescar.Visible = !edo;
            this.toolStripAnterior.Visible = !edo;
            this.toolStripAgregar.Visible = edo;
            this.toolStripEditar.Visible = edo;
            this.toolStripCancelar.Visible = edo;
            this.toolStripSiguiente.Visible = edo;
        }

        private void Control_Click_dataListado(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }
        private void Control_Click_ChkEliminar(object sender, EventArgs e)
        {
            this.BotonChkEliminar();
        }

        private void BotonChkEliminar()
        {
            if (chkEliminar.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripPrimero_Click(object sender, EventArgs e)
        {

        }

        private void toolStripBuscar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripRefrescar_Click(object sender, EventArgs e)
        {
             BotonesIE(true);
             mostrar();
        }

        private void toolStripAnterior_Click(object sender, EventArgs e)
        {
                BotonesIE(true);
                new Importar().importarExcelca(dataListado, "Hoja1", true);
                Columnas();
        }

        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            BotonesIE(false);
            this.dataListado.DataSource = null;
        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            BotonesIE(false);
        }

        private void FrmAFNo_Capitalizables_Load(object sender, EventArgs e)
        {

        }


        private void toolStripSiguiente_Click(object sender, EventArgs e)
        {
            
            new Importar().ExportarDataGridViewExcel(dataListado);
        }

        private void FrmAFNo_Capitalizables_miLoad(object sender, EventArgs e)
        {
            //this.mostrar();
        }

    }
}
