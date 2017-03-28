using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DacfSPNt_Supranumero{

        private string sV_T087U_ANLUE;
        private string sV_T087U_ANLUE_TXT;


        public string V_T087U_ANLUE        {
		get {
            return sV_T087U_ANLUE;
		}
		set {
            sV_T087U_ANLUE = value;
		}
	}

        public string V_T087U_ANLUE_TXT        {
		get {
            return sV_T087U_ANLUE_TXT;
		}
		set {
            sV_T087U_ANLUE_TXT = value;
		}
	}

        //Constructor vacío
	public DacfSPNt_Supranumero(){
	}
        //Constructor con parámetros
    public DacfSPNt_Supranumero(
        string V_T087U_ANLUE,
        string V_T087U_ANLUE_TXT)
    {

        this.V_T087U_ANLUE = sV_T087U_ANLUE;
        this.V_T087U_ANLUE_TXT = sV_T087U_ANLUE_TXT;        
	}

/*	public object Clone() {
//		return base.MemberwiseClone();
//	}
*/

    //METODO MOSTRAR 
        public DataTable Mostrar() {
           DataTable DtResultado = new DataTable("acfSPNt_Supranumero");
            SqlConnection SqlCon = new SqlConnection();

		try {
            //Codigo
             SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfSPNt_Supranumero";
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
	public string Insertar(DacfSPNt_Supranumero acfSPNt_Supranumero)
    {
        string rpta = "";
        SqlConnection SqlCon = new SqlConnection();
		try {
             //Código
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_I_acfSPNt_Supranumero";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParV_T087U_ANLUE = new SqlParameter();
                ParV_T087U_ANLUE.ParameterName = "@sV_T087U_ANLUE";
                ParV_T087U_ANLUE.SqlDbType = SqlDbType.Char;
                ParV_T087U_ANLUE.Value = acfSPNt_Supranumero.V_T087U_ANLUE;
                SqlCmd.Parameters.Add(ParV_T087U_ANLUE);
//
                SqlParameter ParV_T087U_ANLUE_TXT = new SqlParameter();
                ParV_T087U_ANLUE_TXT.ParameterName = "@sV_T087U_ANLUE_TXT";
                ParV_T087U_ANLUE_TXT.SqlDbType = SqlDbType.VarChar;
                ParV_T087U_ANLUE_TXT.Value = acfSPNt_Supranumero.V_T087U_ANLUE_TXT;
                SqlCmd.Parameters.Add(ParV_T087U_ANLUE_TXT);
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
	public string Editar(DacfSPNt_Supranumero acfSPNt_Supranumero) {
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
                SqlCmd.CommandText = "usp_U_acfSPNt_Supranumero";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParV_T087U_ANLUE = new SqlParameter();
                ParV_T087U_ANLUE.ParameterName = "@sV_T087U_ANLUE";
                ParV_T087U_ANLUE.SqlDbType = SqlDbType.Char;
                ParV_T087U_ANLUE.Value = acfSPNt_Supranumero.V_T087U_ANLUE;
                SqlCmd.Parameters.Add(ParV_T087U_ANLUE);
                //
                SqlParameter ParsV_T087U_ANLUE_TXT = new SqlParameter();
                ParsV_T087U_ANLUE_TXT.ParameterName = "@sV_T087U_ANLUE_TXT";
                ParsV_T087U_ANLUE_TXT.SqlDbType = SqlDbType.VarChar;
                ParsV_T087U_ANLUE_TXT.Value = acfSPNt_Supranumero.V_T087U_ANLUE_TXT;
                SqlCmd.Parameters.Add(ParsV_T087U_ANLUE_TXT);                
                //

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Actualizo el Registro";


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
	public string Eliminar(DacfSPNt_Supranumero acfSPNt_Supranumero) {
		
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
                SqlCmd.CommandText = "usp_D_acfSPNt_Supranumero";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParV_T087U_ANLUE = new SqlParameter();
                ParV_T087U_ANLUE.ParameterName = "@sV_T087U_ANLUE";
                ParV_T087U_ANLUE.SqlDbType = SqlDbType.Char;
                ParV_T087U_ANLUE.Value = acfSPNt_Supranumero.V_T087U_ANLUE;
                SqlCmd.Parameters.Add(ParV_T087U_ANLUE);
			
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


    //METODO BUSCAR

	public DataTable Buscar(DacfSPNt_Supranumero acfSPNt_Supranumero) {

        DataTable DtResultado = new DataTable("acfSPNt_Supranumero");
            SqlConnection SqlCon = new SqlConnection();


		try {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_acfSPNt_Supranumero";
            SqlCmd.CommandType = CommandType.StoredProcedure;



            SqlParameter ParV_T087U_ANLUE_TXT = new SqlParameter();
            ParV_T087U_ANLUE_TXT.ParameterName = "@sV_T087U_ANLUE_TXT";
            ParV_T087U_ANLUE_TXT.SqlDbType = SqlDbType.VarChar;
            ParV_T087U_ANLUE_TXT.Size = 50;
            ParV_T087U_ANLUE_TXT.Value = acfSPNt_Supranumero.V_T087U_ANLUE_TXT;
            SqlCmd.Parameters.Add(ParV_T087U_ANLUE_TXT);

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
