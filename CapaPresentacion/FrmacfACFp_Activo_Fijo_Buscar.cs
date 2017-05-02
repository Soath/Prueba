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
        public static int IdAct;
        private void mostrar()
        {

            bss.DataSource = NacfACFp_Activo_Fijo.Mostrar();
            this.DataGridView1.DataSource = bss;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bss.DataSource = NacfACFp_Activo_Fijo.MostrarRegistro(this.TextBox1.Text);
            this.DataGridView1.DataSource = bss;
        }

        private void kryptonDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() != "")
            {
                IdAct = int.Parse(DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                this.Dispose();

            }
        }
    }
}
