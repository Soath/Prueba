using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DConexion
    {
        // public static String CnBDActivo = "Data Source=localhost; Initial Catalog=ActivosFijos; Integrated Security=SSPI;";
        public static String CnBDActivo = "Data Source=192.168.0.18; Initial Catalog=ActivosFijos; User ID = sa;  Password = eg909090;";
        //public static String CnBDActivo = "Data Source=.; Initial Catalog=ActivosFijos; User ID = sa;  Password = eg909090;";
        //public static String CnBDActivo = "Data Source=localhost ; Initial Catalog=ActivosFijos; Integrated Security=SSPI;";
        //public static String CnBDActivo = "Data Source=190.117.111.145; Initial Catalog=ActivosFijos; User ID = sa;  Password = eg909090;";
        public static String CnBDI = "Data Source=www.electrosur.com.pe,1434; Initial Catalog=dbMEGA_BDI; User ID =clarico;  Password = c4+21L8@3;";


        public String ChequearConexion()
        {
            String mensaje = "";
            SqlConnection SqlConexion = new SqlConnection();
            SqlConnection SqlConexion1 = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDActivo;
                SqlConexion.Open();

                SqlConexion1.ConnectionString = DConexion.CnBDI;
                SqlConexion1.Open();

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