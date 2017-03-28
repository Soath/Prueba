using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DbdiSOCpSociedades{

        private string sBUKRS;
        private string sBUTXT;


        public string BUKRS        {
		get { return sBUKRS;	}
		set { sBUKRS = value;	}
	}

        public string BUTXT        {
		get { return sBUTXT;	}
		set { sBUTXT = value;	}
	}

        //Constructor vacío
	public DbdiSOCpSociedades(){
	}
        //Constructor con parámetros
    public DbdiSOCpSociedades(
        string BUKRS,
        string BUTXT)
    {

        this.BUKRS = sBUKRS;
        this.BUTXT = sBUTXT;        
	}

/*	public object Clone() {
//		return base.MemberwiseClone();
//	}
*/

    //METODO MOSTRAR 
        public DataTable Mostrar() {
           DataTable DtResultado = new DataTable("bdiSOCpSociedades");
            SqlConnection SqlCon = new SqlConnection();

		try {
            //Codigo
             SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_bdiSOCpSociedades";
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
	public string Insertar(DbdiSOCpSociedades bdiSOCpSociedades)
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
                SqlCmd.CommandText = "usp_I_bdiSOCpSociedades";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBUKRS = new SqlParameter();
                ParBUKRS.ParameterName = "@sBUKRS";
                ParBUKRS.SqlDbType = SqlDbType.Char;
                ParBUKRS.Value = bdiSOCpSociedades.BUKRS;
                SqlCmd.Parameters.Add(ParBUKRS);
//
                SqlParameter ParBUTXT = new SqlParameter();
                ParBUTXT.ParameterName = "@sBUTXT";
                ParBUTXT.SqlDbType = SqlDbType.Char;
                ParBUTXT.Value = bdiSOCpSociedades.BUTXT;
                SqlCmd.Parameters.Add(ParBUTXT);
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
	public string Editar(DbdiSOCpSociedades bdiSOCpSociedades) {
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
                SqlCmd.CommandText = "usp_U_bdiSOCpSociedades";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBUKRS = new SqlParameter();
                ParBUKRS.ParameterName = "@sBUKRS";
                ParBUKRS.SqlDbType = SqlDbType.Char;
                ParBUKRS.Value = bdiSOCpSociedades.BUKRS;
                SqlCmd.Parameters.Add(ParBUKRS);
                //
                SqlParameter ParsBUTXT = new SqlParameter();
                ParsBUTXT.ParameterName = "@sBUTXT";
                ParsBUTXT.SqlDbType = SqlDbType.Char;
                ParsBUTXT.Value = bdiSOCpSociedades.BUTXT;
                SqlCmd.Parameters.Add(ParsBUTXT);                
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
	public string Eliminar(DbdiSOCpSociedades bdiSOCpSociedades) {
		
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
                SqlCmd.CommandText = "usp_D_bdiSOCpSociedades";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBUKRS = new SqlParameter();
                ParBUKRS.ParameterName = "@sBUKRS";
                ParBUKRS.SqlDbType = SqlDbType.Char;
                ParBUKRS.Value = bdiSOCpSociedades.BUKRS;
                SqlCmd.Parameters.Add(ParBUKRS);
			
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

	public DataTable Buscar(DbdiSOCpSociedades bdiSOCpSociedades) {

        DataTable DtResultado = new DataTable("bdiSOCpSociedades");
            SqlConnection SqlCon = new SqlConnection();


		try {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_bdiSOCpSociedades";
            SqlCmd.CommandType = CommandType.StoredProcedure;



            SqlParameter ParBUTXT = new SqlParameter();
            ParBUTXT.ParameterName = "@sBUTXT";
            ParBUTXT.SqlDbType = SqlDbType.Char;
            ParBUTXT.Size = 50;
            ParBUTXT.Value = bdiSOCpSociedades.BUTXT;
            SqlCmd.Parameters.Add(ParBUTXT);

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
