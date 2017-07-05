using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DDacfLOCt_Local{


        private string iLOCid;
        private string sLOClocal;
        private string sLOCdireccion;
        private string sSEGMENT;

        public string LOCid        {
		get {  return iLOCid;		}
		set {  iLOCid = value;		}
	}

        public string LOClocal        {
		get {  return sLOClocal;		}
		set {  sLOClocal = value;		}
	}

        public String LOCdireccion        {
        get
        {    return sLOCdireccion;  }
        set
        {    sLOCdireccion = value;        }
    }

        public String SEGMENT        {
        get
        { return sSEGMENT; }
        set
        { sSEGMENT = value; }
    }

    
        //Constructor vacío
	public DDacfLOCt_Local(){
	}
        //Constructor con parámetros
    public DDacfLOCt_Local(
        string iLOCid,
        string sLOClocal,
        string sLOCdireccion, 
        string CSTabreviado)
    {

        this.LOCid = iLOCid;
        this.LOClocal = sLOClocal;
        this.LOCdireccion = sLOCdireccion;
        this.SEGMENT = sSEGMENT;
	}

/*	public object Clone() {
//		return base.MemberwiseClone();
//	}
*/

    //METODO MOSTRAR 
        public DataTable Mostrar() {
           DataTable DtResultado = new DataTable("acfLOCt_Local");
            SqlConnection SqlCon = new SqlConnection();

		try {
            //Codigo
             SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfLOCt_Local";
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
	public string Insertar(DDacfLOCt_Local acfLOCt_Local)
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
                SqlCmd.CommandText = "usp_I_acfLOCt_Local";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParLOCid = new SqlParameter();
                ParLOCid.ParameterName = "@iLOCid";
                ParLOCid.SqlDbType = SqlDbType.Int;
                ParLOCid.Value = acfLOCt_Local.LOCid;
                SqlCmd.Parameters.Add(ParLOCid);
//
                SqlParameter ParLOClocal = new SqlParameter();
                ParLOClocal.ParameterName = "@sLOClocal";
                ParLOClocal.SqlDbType = SqlDbType.VarChar;
                ParLOClocal.Value = acfLOCt_Local.LOClocal;
                SqlCmd.Parameters.Add(ParLOClocal);
//
                SqlParameter ParLOCdireccion = new SqlParameter();
                ParLOCdireccion.ParameterName = "@sLOCdireccion";
                ParLOCdireccion.SqlDbType = SqlDbType.VarChar;
                ParLOCdireccion.Value = acfLOCt_Local.LOCdireccion;
                SqlCmd.Parameters.Add(ParLOCdireccion);
//
                //
                SqlParameter ParSEGMENT = new SqlParameter();
                ParSEGMENT.ParameterName = "@sSEGMENT";
                ParSEGMENT.SqlDbType = SqlDbType.Char;
                ParSEGMENT.Value = acfLOCt_Local.SEGMENT;
                SqlCmd.Parameters.Add(ParSEGMENT);
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
	public string Editar(DDacfLOCt_Local acfLOCt_Local) {
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
                SqlCmd.CommandText = "usp_U_acfLOCt_Local";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParLOCid = new SqlParameter();
                ParLOCid.ParameterName = "@iLOCid";
                ParLOCid.SqlDbType = SqlDbType.Int;
                ParLOCid.Value = acfLOCt_Local.LOCid;
                SqlCmd.Parameters.Add(ParLOCid);
                //
                SqlParameter ParLOClocal = new SqlParameter();
                ParLOClocal.ParameterName = "@sLOClocal";
                ParLOClocal.SqlDbType = SqlDbType.VarChar;
                ParLOClocal.Value = acfLOCt_Local.LOClocal;
                SqlCmd.Parameters.Add(ParLOClocal);
                //
                SqlParameter ParLOCdireccion = new SqlParameter();
                ParLOCdireccion.ParameterName = "@sLOCdireccion";
                ParLOCdireccion.SqlDbType = SqlDbType.VarChar;
                ParLOCdireccion.Value = acfLOCt_Local.LOCdireccion;
                SqlCmd.Parameters.Add(ParLOCdireccion);
                //
                //
                SqlParameter ParSEGMENT = new SqlParameter();
                ParSEGMENT.ParameterName = "@sSEGMENT";
                ParSEGMENT.SqlDbType = SqlDbType.Char;
                ParSEGMENT.Value = acfLOCt_Local.SEGMENT;
                SqlCmd.Parameters.Add(ParSEGMENT);
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
	public string Eliminar(DDacfLOCt_Local acfLOCt_Local) {
		
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
                SqlCmd.CommandText = "usp_D_acfLOCt_Local";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParLOCid = new SqlParameter();
                ParLOCid.ParameterName = "@iLOCid";
                ParLOCid.SqlDbType = SqlDbType.Int;
                ParLOCid.Value = acfLOCt_Local.LOCid;
                SqlCmd.Parameters.Add(ParLOCid);
			
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

	public DataTable Buscar(DDacfLOCt_Local acfLOCt_Local) {

        DataTable DtResultado = new DataTable("acfLOCt_Local");
            SqlConnection SqlCon = new SqlConnection();


		try {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_acfLOCt_Local";
            SqlCmd.CommandType = CommandType.StoredProcedure;



            SqlParameter ParAMBambiente = new SqlParameter();
            ParAMBambiente.ParameterName = "@iLOCid";
            ParAMBambiente.SqlDbType = SqlDbType.Char;
            ParAMBambiente.Size = 50;
            ParAMBambiente.Value = acfLOCt_Local.LOCid;
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

