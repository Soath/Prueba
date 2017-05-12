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
    
    public partial class FrmExcel : Form
    {
        public FrmExcel()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtHoja.Text == string.Empty)
            {
                MessageBox.Show("Inserte el nombre de la HOJA");
            }
            else { 
 


            try
            {
                string hoja;
                hoja = txtHoja.Text;
            
                new Importar().importarExcel(dataGridView1, hoja);
            }
            catch (Exception ex)
            {
                
            }
            
                

        }
        }
        private void FrmExcel_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                   string Rta = string.Empty;
                   Rta = NacfACFp_Activo_Fijo.Insertar(
       Convert.ToString(row.Cells[2].Value), //ACFid
       Convert.ToString(row.Cells[5].Value),  // BUKRS
       Convert.ToString(row.Cells[122].Value),  //Se trajo del excel de SAP SEGMENT
       Convert.ToString(row.Cells[106].Value), //Se trajo del excel de SAP ANLKL ( Id clase activos) 
       Convert.ToString(row.Cells[8].Value) ,  //PERNR
       Convert.ToString(row.Cells[12].Value)  , //CSTid
       Convert.ToString(row.Cells[13].Value)  , //MVMid
       ""  , // ACFfmovimiento en la tabla en blanco
       Convert.ToString(row.Cells[15].Value)  ,//VNRid
       Convert.ToString(row.Cells[3].Value)  , //ACFdescripcion
       Convert.ToString(row.Cells[14].Value)  ,//ACFfincorporacion
       Convert.ToString(row.Cells[120].Value)  ,//Se trajo del excel de SAP ACFfcapitalizacion
       Convert.ToString(row.Cells[42].Value)  , //ACFvutiltribanio
       Convert.ToString(row.Cells[0].Value)  , //FORMULA ACFvutiltribdia
       Convert.ToString(row.Cells[43].Value)  , // ACFvalortrib
       Convert.ToString(row.Cells[41].Value)  , //ACFvutilniifanio
       Convert.ToString(row.Cells[0].Value)  , // FORMULA vutilniifdia
       Convert.ToString(row.Cells[0].Value)  , // No se encontro ACFvalorniif
       "" , // NO SE ENCONTRO ACFdepacutrib CERO
      "" , // NO SE ENCONTRO  ACFfdepacuniif
       Convert.ToString(row.Cells[29].Value)  , // ACFobra
     //Convert.ToString(row.Cells[130].Value)  , //Se trajo del excel de SAP ACFord41
     //Convert.ToString(row.Cells[131].Value)  ,//Se trajo del excel de SAP ACFord42
     //Convert.ToString(row.Cells[132].Value)  ,//Se trajo del excel de SAP ACFord43
     //Convert.ToString(row.Cells[133].Value)  ,//Se trajo del excel de SAP ACFord44
       Convert.ToString(row.Cells[136].Value)  ,//encontro ACFanlue
       "" , //No se encontro ACFfactortrib
       ""  , //No se encontro ACFfactorniif
       Convert.ToString(row.Cells[10].Value)  , //ACFcuenta
       ""  ,//No se encontro ACFcuentadep
       Convert.ToString(row.Cells[0].Value)  ,//No se encontro CMPid
       ""  ,//No se encontro ACFobservacion
       Convert.ToString(row.Cells[29].Value)  , //LIFNR
       Convert.ToString(row.Cells[35].Value)  ,//ACFnotaingreso
       Convert.ToString(row.Cells[36].Value)  ,//ACFfechanotaingreso
       Convert.ToString(row.Cells[37].Value)  ,//ACFordencompra
       Convert.ToString(row.Cells[34].Value)  ,//ACFfechaordencompra
       "" ,//No se encontro BLART
       Convert.ToString(row.Cells[33].Value)  ,//ACFcomprobante
       Convert.ToString(row.Cells[121].Value)  ,//Se trajo del excel de la tabla de SAPKOSTL
       Convert.ToString(row.Cells[127].Value)  ,//AMBid
       Convert.ToString(row.Cells[6].Value)  ,//UBEID
       Convert.ToString(row.Cells[34].Value)  ,//ACFfechacomprobante
       Convert.ToString(row.Cells[135].Value) ,  //Se trajo del excel de la tabla de SAP V_T087U_ANLUE
       Convert.ToString(row.Cells[2].Value),  //Tipo Activo  
       Convert.ToString(row.Cells[1].Value)  

         );
                    if (Rta.Equals("OK"))
                    {
                    }
                    else
                    {
                        break;
         
                    }
         
                }
                MessageBox.Show("Datos agregados");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}

