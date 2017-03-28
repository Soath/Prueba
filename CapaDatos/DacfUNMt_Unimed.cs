using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DacfUNMt_Unimed{


        private string iUNMid;
        private string sUNMunidad;
        private string sUNMdetalle;

	public string UNMid {
		get {	return iUNMid;	}
		set {	iUNMid = value;	}
	}

	public string UNMunidad {
		get {	return sUNMunidad;	}
		set {	sUNMunidad = value;	}
	}

	public String UNMdetalle {
		get {	return sUNMdetalle;	 }
		set {	sUNMdetalle = value; }
	}
        //Constructor vacío
	public DacfUNMt_Unimed(){
	}
        //Constructor con parámetros
	public DacfUNMt_Unimed(
        string UNMid, 
        string UNMunidad, 
        string UNMdetalle)
    {
        
		this.iUNMid = UNMid;
		this.sUNMunidad = UNMunidad;
		this.sUNMdetalle = UNMdetalle;
	}

/*	public object Clone() {
//		return base.MemberwiseClone();
//	}
*/

    //METODO MOSTRAR 
        public DataTable Mostrar() {
           DataTable DtResultado = new DataTable("acfUNMt_Unimed");
            SqlConnection SqlCon = new SqlConnection();

		try {
            //Codigo
             SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfUNMt_Unimed";
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
	public string Insertar(DacfUNMt_Unimed acfUNMt_Unimed)
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
                SqlCmd.CommandText = "usp_I_acfUNMt_Unimed";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUNMid = new SqlParameter();
                ParUNMid.ParameterName = "@iUNMid";
                ParUNMid.SqlDbType = SqlDbType.Int;
                ParUNMid.Value = acfUNMt_Unimed.UNMid;
                SqlCmd.Parameters.Add(ParUNMid);
//
                SqlParameter PariUNMunidad = new SqlParameter();
                PariUNMunidad.ParameterName = "@sUNMunidad";
                PariUNMunidad.SqlDbType = SqlDbType.Char;
                PariUNMunidad.Value = acfUNMt_Unimed.UNMunidad;
                SqlCmd.Parameters.Add(PariUNMunidad);
//
                SqlParameter ParsUNMdetalle = new SqlParameter();
                ParsUNMdetalle.ParameterName = "@sUNMdetalle";
                ParsUNMdetalle.SqlDbType = SqlDbType.Char;
                ParsUNMdetalle.Value = acfUNMt_Unimed.UNMdetalle;
                SqlCmd.Parameters.Add(ParsUNMdetalle);
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
	public string Editar(DacfUNMt_Unimed acfUNMt_Unimed) {
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
                SqlCmd.CommandText = "usp_U_acfUNMt_Unimed";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUNMid = new SqlParameter();
                ParUNMid.ParameterName = "@iUNMid";
                ParUNMid.SqlDbType = SqlDbType.Int;
                ParUNMid.Value = acfUNMt_Unimed.UNMid;
                SqlCmd.Parameters.Add(ParUNMid);
//
                SqlParameter PariUNMunidad = new SqlParameter();
                PariUNMunidad.ParameterName = "@sUNMunidad";
                PariUNMunidad.SqlDbType = SqlDbType.Char;
                PariUNMunidad.Value = acfUNMt_Unimed.UNMunidad;
                SqlCmd.Parameters.Add(PariUNMunidad);
//
                SqlParameter ParsUNMdetalle = new SqlParameter();
                ParsUNMdetalle.ParameterName = "@sUNMdetalle";
                ParsUNMdetalle.SqlDbType = SqlDbType.Char;
                ParsUNMdetalle.Value = acfUNMt_Unimed.UNMdetalle;
                SqlCmd.Parameters.Add(ParsUNMdetalle);
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
	public string Eliminar(DacfUNMt_Unimed acfUNMt_Unimed) {
		
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
                SqlCmd.CommandText = "usp_D_acfUNMt_Unimed";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                  SqlParameter PariUNMunidad = new SqlParameter();
                PariUNMunidad.ParameterName = "@iUNMid";
                PariUNMunidad.SqlDbType = SqlDbType.Int;
                PariUNMunidad.Value = acfUNMt_Unimed.UNMunidad;
                SqlCmd.Parameters.Add(PariUNMunidad);
			
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

	public DataTable Buscar(DacfUNMt_Unimed acfUNMt_Unimed) {

        DataTable DtResultado = new DataTable("acfUNMt_Unimed");
            SqlConnection SqlCon = new SqlConnection();


		try {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_acfUNMt_Unimed";
            SqlCmd.CommandType = CommandType.StoredProcedure;



            SqlParameter ParUNMdetalle = new SqlParameter();
            ParUNMdetalle.ParameterName = "@iUNMunidad";
            ParUNMdetalle.SqlDbType = SqlDbType.Char;
            ParUNMdetalle.Size = 50;
            ParUNMdetalle.Value = acfUNMt_Unimed.UNMdetalle;
            SqlCmd.Parameters.Add(ParUNMdetalle);

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

