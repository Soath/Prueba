﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DConexion
    {
        //public static String CnBDActivo = "Data Source=TOSHIBA-PC; Initial Catalog=BDActivos; Integrated Security=SSPI;";
        //public static String CnBDActivo = "Data Source=TOSHIBA-PC; Initial Catalog=ActivosFijos; Integrated Security=SSPI;";
        //public static String CnMaster = "Data Source=TOSHIBA-PC; Initial Catalog=master; Integrated Security=SSPI;";
        //public static String CnBDActivo = "Data Source=TOSHIBA-PC; Initial Catalog=ActivosFijos; Integrated Security=SSPI;";
<<<<<<< HEAD
        public static String CnBDActivo = "Data Source=SAMAEL-PC; Initial Catalog=ActivosFijos; Integrated Security=SSPI;";
        //public static String CnBDActivo = "Data Source=192.168.0.18; Initial Catalog=ActivosFijos; User ID = sa;  Password = eg909090;";
        //public static String CnBDActivo = "Data Source=localhost; Initial Catalog=ActivosFijos; Integrated Security=SSPI;";
=======
        //public static String CnBDActivo = "Data Source=SAMAEL-PC; Initial Catalog=BDActivos; Integrated Security=SSPI;";
        //public static String CnBDActivo = "Data Source=192.168.0.18; Initial Catalog=ActivosFijos; User ID = sa;  Password = eg909090;";
        public static String CnBDActivo = "Data Source=localhost; Initial Catalog=ActivosFijos; Integrated Security=SSPI;";
>>>>>>> b609767f57c03af5303a6105e5432aed640c34f7

        
        public String ChequearConexion()
        {
            String mensaje = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDActivo;
                SqlConexion.Open();
                mensaje = "Y";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                SqlConexion.Close();
            }

            return mensaje;
        }
    }

}