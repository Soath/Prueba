using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using ComponentFactory.Krypton.Toolkit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmacfACFp_Activo_Fijo_Buscar : KryptonForm
    {
        private static FrmacfACFp_Activo_Fijo_Buscar _Instancia;
        BindingSource bss = new BindingSource();

        public static FrmacfACFp_Activo_Fijo_Buscar GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FrmacfACFp_Activo_Fijo_Buscar();
            }
            return _Instancia;
        }
        public FrmacfACFp_Activo_Fijo_Buscar()
        {
            InitializeComponent();
            mostrar();
        }

        private void mostrar()
        {

            bss.DataSource = NacfINVp_Inventario.Mostrar();
            this.kryptonDataGridView1.DataSource = bss;
            
        }
    }
}
