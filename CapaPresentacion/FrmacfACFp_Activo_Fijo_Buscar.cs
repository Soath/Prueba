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
        public static string IdAct;
        private void mostrar()
        {

            bss.DataSource = NacfACFp_Activo_Fijo.Mostrar();
            dataListado.DataSource = NacfACFp_Activo_Fijo.Mostrar();
            OcultarColumnas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
         
            dataListado.DataSource = NacfACFp_Activo_Fijo.MostrarRegistro(this.TextBox1.Text);
            OcultarColumnas();
        }


        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = true;
            this.dataListado.Columns[1].Width = 100;
            this.dataListado.Columns[1].DefaultCellStyle.Format = "#,0";
            this.dataListado.Columns[1].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataListado.Columns[2].Width = 450;
            this.dataListado.Columns[1].HeaderText = "IdActivo";
            this.dataListado.Columns[2].HeaderText = "Descripcion";

        }

       

        private void dataListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataListado.Rows[e.RowIndex].Cells[1].Value.ToString() != "")
            {
                IdAct = dataListado.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.Dispose();

            }
        }
    }
}
