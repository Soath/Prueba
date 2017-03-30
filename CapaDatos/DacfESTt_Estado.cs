using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DacfESTt_Estado{

        private string iESTid;
        private string sESTestado;


        public string ESTid        {
		get { return iESTid;	}
		set { iESTid = value;	}
	}

        public string ESTestado        {
		get { return sESTestado;	}
		set { sESTestado = value;	}
	}

        //Constructor vacío
	public DacfESTt_Estado(){
	}
        //Constructor con parámetros
    public DacfESTt_Estado(
        string ESTid,
        string ESTestado)
    {

        this.ESTid = iESTid;
        this.ESTestado = sESTestado;        
	}

/*	public object Clone() {
//		return base.MemberwiseClone();
//	}
*/

   

    //METODO MOSTRAR 
        public DataTable Mostrar() {
           DataTable DtResultado = new DataTable("acfESTt_Estado");
            SqlConnection SqlCon = new SqlConnection();

		try {
            //Codigo
             SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfESTt_Estado";
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
	public string Insertar(DacfESTt_Estado acfESTt_Estado)
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
                SqlCmd.CommandText = "usp_I_acfESTt_Estado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParESTid = new SqlParameter();
                ParESTid.ParameterName = "@iESTid";
                ParESTid.SqlDbType = SqlDbType.Int;
                ParESTid.Value = acfESTt_Estado.ESTid;
                SqlCmd.Parameters.Add(ParESTid);
//
                SqlParameter ParESTestado = new SqlParameter();
                ParESTestado.ParameterName = "@sESTestado";
                ParESTestado.SqlDbType = SqlDbType.VarChar;
                ParESTestado.Value = acfESTt_Estado.ESTestado;
                SqlCmd.Parameters.Add(ParESTestado);
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
	public string Editar(DacfESTt_Estado acfESTt_Estado) {
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
                SqlCmd.CommandText = "usp_U_acfESTt_Estado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParESTid = new SqlParameter();
                ParESTid.ParameterName = "@iESTid";
                ParESTid.SqlDbType = SqlDbType.Int;
                ParESTid.Value = acfESTt_Estado.ESTid;
                SqlCmd.Parameters.Add(ParESTid);
                //
                SqlParameter ParsESTestado = new SqlParameter();
                ParsESTestado.ParameterName = "@sESTestado";
                ParsESTestado.SqlDbType = SqlDbType.VarChar;
                ParsESTestado.Value = acfESTt_Estado.ESTestado;
                SqlCmd.Parameters.Add(ParsESTestado);                
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
	public string Eliminar(DacfESTt_Estado acfESTt_Estado) {
		
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
                SqlCmd.CommandText = "usp_D_acfESTt_Estado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParESTid = new SqlParameter();
                ParESTid.ParameterName = "@iESTid";
                ParESTid.SqlDbType = SqlDbType.Int;
                ParESTid.Value = acfESTt_Estado.ESTid;
                SqlCmd.Parameters.Add(ParESTid);
			
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

	public DataTable Buscar(DacfESTt_Estado acfESTt_Estado) {

        DataTable DtResultado = new DataTable("acfESTt_Estado");
            SqlConnection SqlCon = new SqlConnection();


		try {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_acfESTt_Estado";
            SqlCmd.CommandType = CommandType.StoredProcedure;



            SqlParameter ParESTestado = new SqlParameter();
            ParESTestado.ParameterName = "@sESTestado";
            ParESTestado.SqlDbType = SqlDbType.VarChar;
            ParESTestado.Size = 50;
            ParESTestado.Value = acfESTt_Estado.ESTestado;
            SqlCmd.Parameters.Add(ParESTestado);

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
