using System;
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
            mostrar();
        }
        private void mostrar()
        {
            this.datalistado1.DataSource = NacfINBt_Inventariobienes.Mostrar2();
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
    }
}
