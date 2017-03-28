using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DbdiCAFpClaseDeActivoFijo{

        private string sANLKL;
        private string sTXK50;


        public string ANLKL        {
		get {
            return sANLKL;
		}
		set {
            sANLKL = value;
		}
	}

        public string TXK50        {
		get {
            return sTXK50;
		}
		set {
            sTXK50 = value;
		}
	}

        //Constructor vacío
	public DbdiCAFpClaseDeActivoFijo(){
	}
        //Constructor con parámetros
    public DbdiCAFpClaseDeActivoFijo(
        string ANLKL,
        string TXK50)
    {

        this.ANLKL = sANLKL;
        this.TXK50 = sTXK50;        
	}

/*	public object Clone() {
//		return base.MemberwiseClone();
//	}
*/

    //METODO MOSTRAR 
        public DataTable Mostrar() {
           DataTable DtResultado = new DataTable("bdiCAFpClaseDeActivoFijo");
            SqlConnection SqlCon = new SqlConnection();

		try {
            //Codigo
             SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_bdiCAFpClaseDeActivoFijo";
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
	public string Insertar(DbdiCAFpClaseDeActivoFijo bdiCAFpClaseDeActivoFijo)
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
                SqlCmd.CommandText = "usp_I_bdiCAFpClaseDeActivoFijo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParANLKL = new SqlParameter();
                ParANLKL.ParameterName = "@sANLKL";
                ParANLKL.SqlDbType = SqlDbType.Char;
                ParANLKL.Value = bdiCAFpClaseDeActivoFijo.ANLKL;
                SqlCmd.Parameters.Add(ParANLKL);
//
                SqlParameter ParTXK50 = new SqlParameter();
                ParTXK50.ParameterName = "@sTXK50";
                ParTXK50.SqlDbType = SqlDbType.Char;
                ParTXK50.Value = bdiCAFpClaseDeActivoFijo.TXK50;
                SqlCmd.Parameters.Add(ParTXK50);
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
	public string Editar(DbdiCAFpClaseDeActivoFijo bdiCAFpClaseDeActivoFijo) {
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
                SqlCmd.CommandText = "usp_U_bdiCAFpClaseDeActivoFijo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParANLKL = new SqlParameter();
                ParANLKL.ParameterName = "@sANLKL";
                ParANLKL.SqlDbType = SqlDbType.Char;
                ParANLKL.Value = bdiCAFpClaseDeActivoFijo.ANLKL;
                SqlCmd.Parameters.Add(ParANLKL);
                //
                SqlParameter ParsTXK50 = new SqlParameter();
                ParsTXK50.ParameterName = "@sTXK50";
                ParsTXK50.SqlDbType = SqlDbType.Char;
                ParsTXK50.Value = bdiCAFpClaseDeActivoFijo.TXK50;
                SqlCmd.Parameters.Add(ParsTXK50);                
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
	public string Eliminar(DbdiCAFpClaseDeActivoFijo bdiCAFpClaseDeActivoFijo) {
		
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
                SqlCmd.CommandText = "usp_D_bdiCAFpClaseDeActivoFijo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParANLKL = new SqlParameter();
                ParANLKL.ParameterName = "@sANLKL";
                ParANLKL.SqlDbType = SqlDbType.Char;
                ParANLKL.Value = bdiCAFpClaseDeActivoFijo.ANLKL;
                SqlCmd.Parameters.Add(ParANLKL);
			
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

	public DataTable Buscar(DbdiCAFpClaseDeActivoFijo bdiCAFpClaseDeActivoFijo) {

        DataTable DtResultado = new DataTable("bdiCAFpClaseDeActivoFijo");
            SqlConnection SqlCon = new SqlConnection();


		try {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_bdiCAFpClaseDeActivoFijo";
            SqlCmd.CommandType = CommandType.StoredProcedure;



            SqlParameter ParTXK50 = new SqlParameter();
            ParTXK50.ParameterName = "@sTXK50";
            ParTXK50.SqlDbType = SqlDbType.Char;
            ParTXK50.Size = 50;
            ParTXK50.Value = bdiCAFpClaseDeActivoFijo.TXK50;
            SqlCmd.Parameters.Add(ParTXK50);

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

