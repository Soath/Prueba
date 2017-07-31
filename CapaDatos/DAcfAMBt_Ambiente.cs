using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DAcfAMBt_Ambiente{
    

	private string mLOCid;
	private string mAMBid;
	private string mAMBambiente;

	public string LOCid {
		get {			return mLOCid;		}
		set {			mLOCid = value;		}
	}

	public string AMBid {
		get {			return mAMBid;		}
		set {			mAMBid = value;		}
	}

	public String AMBambiente {
		get {			return mAMBambiente;		}
		set {			mAMBambiente = value;		}
	}
        //Constructor vacío
	public DAcfAMBt_Ambiente(){
	}
        //Constructor con parámetros
	public DAcfAMBt_Ambiente(
        string LOCid, 
        string AMBid, 
        string AMBambiente)
    {
        
		this.mLOCid = LOCid;
		this.mAMBid = AMBid;
		this.mAMBambiente = AMBambiente;
	}

/*	public object Clone() {
//		return base.MemberwiseClone();
//	}
*/

    //METODO MOSTRAR 
        public DataTable Mostrar() {
           DataTable DtResultado = new DataTable("acfAMBt_Ambiente");
            SqlConnection SqlCon = new SqlConnection();

		try {
            //Codigo
             SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfAMBt_Ambiente";
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
	    public string Insertar(DAcfAMBt_Ambiente acfAMBt_Ambiente)
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
                SqlCmd.CommandText = "usp_I_acfAMBt_Ambiente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParLOCid = new SqlParameter();
                ParLOCid.ParameterName = "@iLOCid";
                ParLOCid.SqlDbType = SqlDbType.Int;
                ParLOCid.Value = acfAMBt_Ambiente.LOCid;
                SqlCmd.Parameters.Add(ParLOCid);
//
                SqlParameter PariAMBid = new SqlParameter();
                PariAMBid.ParameterName = "@iAMBid";
                PariAMBid.SqlDbType = SqlDbType.Int;
                PariAMBid.Value = acfAMBt_Ambiente.AMBid;
                SqlCmd.Parameters.Add(PariAMBid);
//
                SqlParameter ParsAMBambiente = new SqlParameter();
                ParsAMBambiente.ParameterName = "@sAMBambiente";
                ParsAMBambiente.SqlDbType = SqlDbType.VarChar;
                ParsAMBambiente.Value = acfAMBt_Ambiente.AMBambiente;
                SqlCmd.Parameters.Add(ParsAMBambiente);
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
	public string Editar(DAcfAMBt_Ambiente acfAMBt_Ambiente) {
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
                SqlCmd.CommandText = "usp_U_acfAMBt_Ambiente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParLOCid = new SqlParameter();
                ParLOCid.ParameterName = "@iLOCid";
                ParLOCid.SqlDbType = SqlDbType.Int;
                ParLOCid.Value = acfAMBt_Ambiente.LOCid;
                SqlCmd.Parameters.Add(ParLOCid);
//
                SqlParameter PariAMBid = new SqlParameter();
                PariAMBid.ParameterName = "@iAMBid";
                PariAMBid.SqlDbType = SqlDbType.Int;
                PariAMBid.Value = acfAMBt_Ambiente.AMBid;
                SqlCmd.Parameters.Add(PariAMBid);
//
                SqlParameter ParsAMBambiente = new SqlParameter();
                ParsAMBambiente.ParameterName = "@sAMBambiente";
                ParsAMBambiente.SqlDbType = SqlDbType.VarChar;
                ParsAMBambiente.Value = acfAMBt_Ambiente.AMBambiente;
                SqlCmd.Parameters.Add(ParsAMBambiente);
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
	public string Eliminar(DAcfAMBt_Ambiente acfAMBt_Ambiente) {
		
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
                SqlCmd.CommandText = "usp_D_acfAMBt_Ambiente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                  SqlParameter PariAMBid = new SqlParameter();
                PariAMBid.ParameterName = "@iAMBid";
                PariAMBid.SqlDbType = SqlDbType.Int;
                PariAMBid.Value = acfAMBt_Ambiente.AMBid;
                SqlCmd.Parameters.Add(PariAMBid);
			
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
	public DataTable Buscar(DAcfAMBt_Ambiente acfAMBt_Ambiente) {

        DataTable DtResultado = new DataTable("acfAMBTt_Ambiente");
            SqlConnection SqlCon = new SqlConnection();


		try {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_acfAMBt_Ambiente";
            SqlCmd.CommandType = CommandType.StoredProcedure;



            SqlParameter ParAMBambiente = new SqlParameter();
            ParAMBambiente.ParameterName = "@iAMBid";
            ParAMBambiente.SqlDbType = SqlDbType.Char;
            ParAMBambiente.Size = 50;
            ParAMBambiente.Value = acfAMBt_Ambiente.AMBid;
            SqlCmd.Parameters.Add(ParAMBambiente);

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
