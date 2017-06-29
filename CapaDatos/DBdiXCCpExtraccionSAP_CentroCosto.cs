using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DBdiXCCpExtraccionSAP_CentroCosto
    {
        private string mKOSTL;
        private string mKTEXT;
        private string mKLTXT;
        private string mMCDS3;

        public string KOSTL
        {
            get
            {
                return mKOSTL;
            }
            set
            {
                mKOSTL = value;
            }
        }
        public string KTEXT
        {
            get
            {
                return mKTEXT;
            }
            set
            {
                mKTEXT = value;
            }
        }
        public string KLTXT
        {
            get
            {
                return mKLTXT;
            }
            set
            {
                mKLTXT = value;
            }
        }
        public string MCDS3
        {
            get
            {
                return mMCDS3;
            }
            set
            {
                mMCDS3 = value;
            }
        }

        //Constructor vacío
        public DBdiXCCpExtraccionSAP_CentroCosto()
        {
	}

        //Constructor con parámetros

        public DBdiXCCpExtraccionSAP_CentroCosto(string KOSTL, string KTEXT, string KLTXT, string MCDS3)
        {

        this.mKOSTL = KOSTL;
        this.mKTEXT = KTEXT;
		this.mKLTXT = KLTXT;
        this.mMCDS3=MCDS3;
	}


        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("bdiXCCpExtraccionSAP_CentroCosto");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_bdiXCCpExtraccionSAP_CentroCosto";
                SqlCmd.CommandType = CommandType.StoredProcedure;



                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //METODO INSERTAR 


        public string Insertar(DBdiXCCpExtraccionSAP_CentroCosto bdiXCCpExtraccionSAP_CentroCosto)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_I_bdiXCCpExtraccionSAP_CentroCosto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParsKOSTL = new SqlParameter();
                ParsKOSTL.ParameterName = "@sKOSTL";
                ParsKOSTL.SqlDbType = SqlDbType.Char;
                ParsKOSTL.Value = bdiXCCpExtraccionSAP_CentroCosto.KOSTL;
                SqlCmd.Parameters.Add(ParsKOSTL);
                //
                SqlParameter ParsKTEXT = new SqlParameter();
                ParsKTEXT.ParameterName = "@sKTEXT";
                ParsKTEXT.SqlDbType = SqlDbType.Char;
                ParsKTEXT.Value = bdiXCCpExtraccionSAP_CentroCosto.KTEXT;
                SqlCmd.Parameters.Add(ParsKTEXT);
                //
                SqlParameter ParsKLTXT = new SqlParameter();
                ParsKLTXT.ParameterName = "@sKLTXT";
                ParsKLTXT.SqlDbType = SqlDbType.Char;
                ParsKLTXT.Value = bdiXCCpExtraccionSAP_CentroCosto.KLTXT;
                SqlCmd.Parameters.Add(ParsKLTXT);
                //
                SqlParameter ParsMCDS3 = new SqlParameter();
                ParsMCDS3.ParameterName = "@sMCDS3";
                ParsMCDS3.SqlDbType = SqlDbType.Char;
                ParsMCDS3.Value = bdiXCCpExtraccionSAP_CentroCosto.MCDS3;
                SqlCmd.Parameters.Add(ParsMCDS3);
                //

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Elimino el Registro";



            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //METODO EDITAR
        public string Editar(DBdiXCCpExtraccionSAP_CentroCosto bdiXCCpExtraccionSAP_CentroCosto)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_U_bdiXCCpExtraccionSAP_CentroCosto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParsKOSTL = new SqlParameter();
                ParsKOSTL.ParameterName = "@sKOSTL";
                ParsKOSTL.SqlDbType = SqlDbType.Char;
                ParsKOSTL.Value = bdiXCCpExtraccionSAP_CentroCosto.KOSTL;
                SqlCmd.Parameters.Add(ParsKOSTL);
                //
                SqlParameter ParsKTEXT = new SqlParameter();
                ParsKTEXT.ParameterName = "@sKTEXT";
                ParsKTEXT.SqlDbType = SqlDbType.Char;
                ParsKTEXT.Value = bdiXCCpExtraccionSAP_CentroCosto.KTEXT;
                SqlCmd.Parameters.Add(ParsKTEXT);
                //
                SqlParameter ParsKLTXT = new SqlParameter();
                ParsKLTXT.ParameterName = "@sKLTXT";
                ParsKLTXT.SqlDbType = SqlDbType.Char;
                ParsKLTXT.Value = bdiXCCpExtraccionSAP_CentroCosto.KLTXT;
                SqlCmd.Parameters.Add(ParsKLTXT);
                //
                SqlParameter ParsMCDS3 = new SqlParameter();
                ParsMCDS3.ParameterName = "@sMCDS3";
                ParsMCDS3.SqlDbType = SqlDbType.Char;
                ParsMCDS3.Value = bdiXCCpExtraccionSAP_CentroCosto.MCDS3;
                SqlCmd.Parameters.Add(ParsMCDS3);
                //

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Elimino el Registro";



            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //METODO ELIMINAR
        public string Eliminar(DBdiXCCpExtraccionSAP_CentroCosto bdiXCCpExtraccionSAP_CentroCosto)
        {

            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_D_bdiXCCpExtraccionSAP_CentroCosto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //
                SqlParameter ParsKOSTL = new SqlParameter();
                ParsKOSTL.ParameterName = "@sKOSTL";
                ParsKOSTL.SqlDbType = SqlDbType.Char;
                ParsKOSTL.Value = bdiXCCpExtraccionSAP_CentroCosto.KOSTL;
                SqlCmd.Parameters.Add(ParsKOSTL);


                //

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Elimino el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        // Metodo importar Excel del SAP

        public string SAPIMPORT(DBdiXCCpExtraccionSAP_CentroCosto bdiXCCpExtraccionSAP_CentroCosto)
        {

            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_i_SAPIMPORT_SAP_CentroCosto";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter ParsKOSTL = new SqlParameter();
                ParsKOSTL.ParameterName = "@sKOSTL";
                ParsKOSTL.SqlDbType = SqlDbType.Char;
                ParsKOSTL.Value = bdiXCCpExtraccionSAP_CentroCosto.KOSTL;
                SqlCmd.Parameters.Add(ParsKOSTL);
                //
                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "Conflictos en el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
        //METODO BUSCAR
        public DataTable Buscar(DBdiXCCpExtraccionSAP_CentroCosto bdiXCCpExtraccionSAP_CentroCosto)
        {

            DataTable DtResultado = new DataTable("bdiXCCpExtraccionSAP_CentroCosto");
            SqlConnection SqlCon = new SqlConnection();


            try
            {

                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_B_bdiXCCpExtraccionSAP_CentroCosto";
                SqlCmd.CommandType = CommandType.StoredProcedure;



                SqlParameter ParXCCExtraccion = new SqlParameter();
                ParXCCExtraccion.ParameterName = "@KOSTL";
                ParXCCExtraccion.SqlDbType = SqlDbType.Char;
                ParXCCExtraccion.Size = 50;
                ParXCCExtraccion.Value = bdiXCCpExtraccionSAP_CentroCosto.KOSTL;
                SqlCmd.Parameters.Add(ParXCCExtraccion);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

    }
}
