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
    public partial class FrmMovimientoTransferecnaiActivo : Form
    {
        public FrmMovimientoTransferecnaiActivo()
        {
            InitializeComponent();
        }

        private void FrmMovimientoTransferecnaiActivo_Load(object sender, EventArgs e)
        {
            this.DataGRid1();
            this.DataGRid2();
            this.dataListado1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(Control_Click_dataListado);

        }
        private void Control_Click_dataListado(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado1.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell Seleccionar = (DataGridViewCheckBoxCell)dataListado1.Rows[e.RowIndex].Cells["Seleccionar"];
                Seleccionar.Value = !Convert.ToBoolean(Seleccionar.Value);
            }
        }

        private void DataGRid1()
        {
            // MVAid = MVPid_proceso -- se esta relacionando por lo mismo
            this.dataListado1.DataSource = NMovimiento_Transferencia_Activo.Mostrar2();
        }
        private void DataGRid2()
        {
            // MVAid = MVPid_proceso -- se esta relacionando por lo mismo
            this.dataListado2.DataSource = NacfMVAt_MovimientoActivo.Mostrar2();            
        }

        private void dataListado1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dataListado1.Rows[e.RowIndex];
                        
            string iMVAid = row.Cells[1].Value.ToString();

            //MessageBox.Show(iMVAid);
            this.dataListado2.DataSource = NacfMVAt_MovimientoActivo.Mostrar3(iMVAid);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string Codigo;
            string Rta = string.Empty;

            foreach (DataGridViewRow row in dataListado1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    Codigo = Convert.ToString(row.Cells[1].Value);
                    Rta = NMovimiento_Transferencia_Activo.RecargarACF(Codigo);

                    if (Rta.Equals("OK"))
                    {
                        this.MensajeOk("Se Actuliza Correctamente el Estado");
                    }
                    else
                    {
                        this.MensajeError("Error al Actuliza el Estado ...");
                    }

                }
            }
            this.DataGRid1();
            this.DataGRid2();
        }
    }
}
