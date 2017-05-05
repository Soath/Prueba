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
            DataGRid();
            this.dataListado2.DataSource = NMovimiento_Transferencia_Activo.Mostrar2();
        }


        private void DataGRid()
        {
            this.dataListado1.DataSource = NMovimiento_Transferencia_Activo.Mostrar2();
        }
    }
}
