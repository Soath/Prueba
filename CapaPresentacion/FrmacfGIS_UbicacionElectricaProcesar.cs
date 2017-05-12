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
                { var2 = "0"; }
            else { var2 = textBox2.Text; }

            if (textBox3.Text == "")
                { var3 = "0"; }
            else { var3 = textBox3.Text; }

            if (textBox4.Text == "") 
                { var4 = "0"; }
            else { var4 = textBox4.Text; }
           // 
            if (textBox5.Text == "")
                { var5 = "0"; }
            else { var5 = textBox5.Text; }

            if (textBox6.Text == "")
                { var6 = "NULL"; }
            else { var6 = textBox6.Text; }

            if (textBox7.Text == "")
                { var7 = "0"; }
            else { var7 = textBox7.Text; }

            if (textBox8.Text == "")
                { var8 = "NULL"; }
            else { var8 = textBox8.Text; }
             
            if (textBox9.Text == "")
               { var9 = "0"; }
            else { var9 = textBox9.Text; }

            if (textBox10.Text == "")
                { var10 = "NULL"; }
            else { var10 = textBox10.Text; }
            
            if (textBox11.Text == "")
                { var11 = "0"; }
            else { var11 = textBox11.Text; }

            if (textBox12.Text == "")
                { var12 = "NULL"; }
            else { var12 = textBox12.Text; }

            if (textBox13.Text == "")
                { var13 = "0"; }
            else { var13 = textBox13.Text; }
            
            if (textBox14.Text == "")
                { var14 = "0"; }
            else { var14 = textBox14.Text; }

            if (textBox15.Text == "")
                { var15 = "NULL"; }
            else { var15 = textBox15.Text; }

            if (textBox16.Text == "")
                { var16 = "0"; }
            else { var16 = textBox16.Text; }
            
            if (textBox17.Text == "")
                { var17 = "0"; }
            else { var17 = textBox17.Text; }

            if (textBox18.Text == "")
                { var18 = "NULL"; }
            else { var18 = textBox18.Text; }

            if (textBox19.Text == "")
                { var19 = "NULL"; }
            else { var19 = textBox19.Text; }

            if (textBox20.Text == "")
                { var20 = "0"; }
            else { var20 = textBox20.Text; }

            if (textBox21.Text == "")
                { var21 = "NULL"; }
            else { var21 = textBox21.Text; }

            if (textBox22.Text == "")
                { var22 = "0"; }
            else { var22 = textBox22.Text; }

            if (textBox23.Text == "")
                { var23 = "NULL"; }
            else { var23 = textBox23.Text; }

            if (textBox24.Text == "")
                { var24 = "0"; }
            else { var24 = textBox24.Text; }

            if (textBox25.Text == "")
                { var25 = "NULL"; }
            else { var25 = textBox25.Text; }

            if (textBox26.Text == "")
                { var26 = "0"; }
            else { var26 = textBox26.Text; }
            
            if (textBox27.Text == "")
                { var27 = "0"; }
            else { var27 = textBox27.Text; }
            
            if (textBox28.Text == "")
                { var28 = "0"; }
            else { var28 = "1"; }
            
            this.Dispose();
        }
    }
}
