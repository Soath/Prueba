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
        public string ACFidNum;
        public FrmacfGIS_UbicacionElectrica()
        {
            InitializeComponent();
        }

        private void FrmacfGIS_UbicacionElectrica_Load(object sender, EventArgs e)
        {
             DataTable dat = NacfGIS_UbicacionElectrica.Last();
             if (dat.Rows.Count > 0)
             {
                 DataRow row = dat.Rows[0];
                 //guardo datos en variables
                 lbltultimoid.Text = Convert.ToString(row["ACFid"]);
                ACFidNum = lbltultimoid.Text;
             }
             else
             { lbltultimoid.Text = "No Existe Registro"; }
             



            dataListado.DataSource = NacfGIS_UbicacionElectrica.Mostrar("1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form FrmacfGIS_UbicacionElectricaImportar = new FrmacfGIS_UbicacionElectricaImportar();
            FrmacfGIS_UbicacionElectricaImportar.ShowDialog();
        }
    }
}
