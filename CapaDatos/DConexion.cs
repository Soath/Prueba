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
        public static String CnBDActivo = "Data Source=192.168.0.23; Initial Catalog=ActivosFijos; User ID = sa;  Password = eg909090;";
        //public static String CnBDActivo = "Data Source=.; Initial Catalog=ActivosFijos; User ID = sa;  Password = eg909090;";
        //public static String CnBDActivo = "Data Source=localhost ; Initial Catalog=ActivosFijos; Integrated Security=SSPI;";
        //public static String CnBDActivo = "Data Source=190.117.111.145; Initial Catalog=ActivosFijos; User ID = sa;  Password = eg909090;";
        public static String CnBDI = "Data Source=200.4.227.24,1434; Initial Catalog=dbMEGA_BDI; User ID =clarico;  Password = c4+21L8@3;";

        // conexión para la tabla 
        public static String CnGIS = "Data Source=192.168.0.18; Initial Catalog=TablaIntermedia; User ID = sa;  Password = eg909090;";

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
        public String ChequearConexion1()
        {
            String mensaje = "";
            SqlConnection SqlConexion1 = new SqlConnection();

            try
            {

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
                SqlConexion1.Open();
            }

            return mensaje;
        }

        public String ChequearConexion2()
        {
            String mensaje = "";
            SqlConnection SqlConexion2 = new SqlConnection();

            try
            {

                SqlConexion2.ConnectionString = DConexion.CnGIS;
                SqlConexion2.Open();

                mensaje = "Y";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                SqlConexion2.Open();
            }

            return mensaje;
        }
    }

}