﻿using System;
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
    
    public partial class Frm_RegistroInventario : KryptonForm
    {
        private static Frm_InventarioG _Instancia;

        public static Frm_InventarioG GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new Frm_InventarioG();
            }
            return _Instancia;
        }


        public Frm_RegistroInventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarRegistro(this.txtACFid.Text);
            
        }
        private void MostrarRegistro(String ACFid)
        {

            try
            {
                DataTable dat = NacfINBt_Inventariobienes.Buscar(ACFid);
                   
                DataTable datt = NacfICRt_Inventariocaracteristicas.Buscar(ACFid);
                //ACFdescripcion.Text= dat.Rows[0]["ACFdescripcion"].ToString();

                if (dat.Rows.Count > 0)
                {
                    DataRow row = dat.Rows[0];
                    txtACTid.Text = Convert.ToString(row["ACTid"]);
                    txtACFobservacion.Text = Convert.ToString(row["ACFactivo"]);
                    txtACFdescripcion.Text = Convert.ToString(row["ACFobservacion"]);
                    txtVNRid.Text = Convert.ToString(row["VNRid"]);
                    txtUBEid1.Text = Convert.ToString(row["UBEid"]);

               
                }
                    if(datt.Rows.Count > 0)
                    {
                        DataRow row = datt.Rows[0];
                    }
                else
                    MessageBox.Show("No Existe", "Registro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }

}
