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
    public partial class FrmacfGIS_UbicacionElectrica : Form
    {
        public FrmacfGIS_UbicacionElectrica()
        {
            InitializeComponent();
        }

        private void FrmacfGIS_UbicacionElectrica_Load(object sender, EventArgs e)
        {
            dataListado.DataSource = NacfGIS_UbicacionElectrica.Mostrar("1");
        }
    }
}
