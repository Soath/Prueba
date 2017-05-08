using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmacfGIS_UbicacionElectricaProcesar : Form
    {
        public int NumFila;
        public string var1, var2, var3, var4, var5, var6, var7, var8, var9, var10, var11, 
                      var12, var13, var14, var15, var16, var17, var18, var19, var20, var21, 
                      var22, var23, var24, var25, var26, var27, var28;
        public FrmacfGIS_UbicacionElectricaProcesar()
        {
            InitializeComponent();
        }
        
        private void FrmacfGIS_UbicacionElectricaProcesar_Load(object sender, EventArgs e)
        {
            // para que los textboc resiban datos es necesario cambiar la propiedad MODIFIERS = PUBLIC
        }

        
        private void FrmacfGIS_UbicacionElectricaProcesar_Load_1(object sender, EventArgs e)
        {
            // la variable NumFila resive el numero de la fila del datagrid en el formulario procesar
            textBox29.Text = NumFila.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////
            //// ----------------------------------------
            ////            
            //     if(textBox1.Text != null)

            var1 = textBox1.Text;
            if (textBox2.Text == "")
            {
                var2 = "0";
            }
            else
            { var2 = textBox2.Text; }
          //    var3  = textBox3.Text;
          //    var4  = textBox4.Text;
          //    var5  = textBox5.Text;
          //    var6  = textBox6.Text;
          //    var7  = textBox7.Text;
          //    var8  = textBox8.Text;
          //    var9  = textBox9.Text;
          //    var10  = textBox10.Text;
          //    var11  = textBox11.Text;
          //    var12  = textBox12.Text;
          //    var13  = textBox13.Text;
          //    var14  = textBox14.Text;
          //    var15  = textBox15.Text;
          //    var16  = textBox16.Text;
          //    var17  = textBox17.Text;
          //    var18  = textBox18.Text;
          //    var19  = textBox19.Text;
          //    var20  = textBox20.Text;
          //    var21  = textBox21.Text;
          //    var22  = textBox22.Text;
          //    var23  = textBox23.Text;
          //    var24  = textBox24.Text;
          //    var25  = textBox25.Text;
          //    var26  = textBox26.Text;
          //    var27  = textBox27.Text;
          //    var28  = textBox28.Text;



            //var1= textBox4.Text;
            this.Dispose();
        }
    }
}
