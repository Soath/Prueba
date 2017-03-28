using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DacfCSTt_Costo{


        private string sCSTid;
        private string sCSTdescripcion;
        private string sCSTdetalle;
        private string sCSTabreviado;
        private string sACTid;
        private string sCSTid_costo;

	    public string CSTid {
		get { return sCSTid;	}
		set { sCSTid = value;	}
	    }

	    public string CSTdescripcion {
		get { return sCSTdescripcion;	}
		set { sCSTdescripcion = value;	}
	    }

        public String CSTdetalle    {
        get { return sCSTdetalle;  }
        set { sCSTdetalle = value; }
        }

        public String CSTabreviado    {
        get { return sCSTabreviado;  }
        set { sCSTabreviado = value; }
        }

        public String ACTid    {
        get { return sACTid;  }
        set { sACTid = value; }
        }

        public String CSTid_costo    {
        get { return sCSTid_costo; }
        set { sCSTid_costo = value;}
        }
        //Constructor vacío
	public DacfCSTt_Costo(){
	}
        //Constructor con parámetros
    public DacfCSTt_Costo(
        string CSTid, 
        string CSTdescripcion, 
        string CSTdetalle, 
        string CSTabreviado, 
        string ACTid, 
        string CSTid_costo)
    {

        this.CSTid = sCSTid;
        this.CSTdescripcion = sCSTdescripcion;
        this.CSTdetalle = sCSTdetalle;
        this.CSTabreviado = sCSTabreviado;
        this.ACTid = sACTid;
        this.CSTid_costo = sCSTid_costo;
	}

/*	public object Clone() {
//		return base.MemberwiseClone();
//	}
*/

    //METODO MOSTRAR
        public DataTable Mostrar() {
           DataTable DtResultado = new DataTable("acfCSTt_Costo");
            SqlConnection SqlCon = new SqlConnection();

		try {
            //Codigo
             SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfCSTt_Costo";
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
	public string Insertar(DacfCSTt_Costo acfCSTt_Costo)
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
                SqlCmd.CommandText = "usp_I_acfCSTt_Costo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCSTid = new SqlParameter();
                ParCSTid.ParameterName = "@sCSTid";
                ParCSTid.SqlDbType = SqlDbType.VarChar;
                ParCSTid.Value = acfCSTt_Costo.CSTid;
                SqlCmd.Parameters.Add(ParCSTid);
//
                SqlParameter ParCSTdescripcion = new SqlParameter();
                ParCSTdescripcion.ParameterName = "@sCSTdescripcion";
                ParCSTdescripcion.SqlDbType = SqlDbType.Int;
                ParCSTdescripcion.Value = acfCSTt_Costo.CSTdescripcion;
                SqlCmd.Parameters.Add(ParCSTdescripcion);
//
                SqlParameter ParCSTdetalle = new SqlParameter();
                ParCSTdetalle.ParameterName = "@sCSTdetalle";
                ParCSTdetalle.SqlDbType = SqlDbType.VarChar;
                ParCSTdetalle.Value = acfCSTt_Costo.CSTabreviado;
                SqlCmd.Parameters.Add(ParCSTdetalle);
//
                //
                SqlParameter ParCSTabreviado = new SqlParameter();
                ParCSTabreviado.ParameterName = "@sCSTabreviado";
                ParCSTabreviado.SqlDbType = SqlDbType.VarChar;
                ParCSTabreviado.Value = acfCSTt_Costo.CSTabreviado;
                SqlCmd.Parameters.Add(ParCSTabreviado);
                //
                //
                SqlParameter ParACTid = new SqlParameter();
                ParACTid.ParameterName = "@sACTid";
                ParACTid.SqlDbType = SqlDbType.Char;
                ParACTid.Value = acfCSTt_Costo.ACTid;
                SqlCmd.Parameters.Add(ParACTid);
                //
                //
                SqlParameter ParCSTid_costo = new SqlParameter();
                ParCSTid_costo.ParameterName = "@sCSTid_costo";
                ParCSTid_costo.SqlDbType = SqlDbType.Char;
                ParCSTid_costo.Value = acfCSTt_Costo.CSTid_costo;
                SqlCmd.Parameters.Add(ParCSTid_costo);
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
	public string Editar(DacfCSTt_Costo acfCSTt_Costo) {
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
                SqlCmd.CommandText = "usp_U_acfCSTt_Costo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCSTid = new SqlParameter();
                ParCSTid.ParameterName = "@sCSTid";
                ParCSTid.SqlDbType = SqlDbType.VarChar;
                ParCSTid.Value = acfCSTt_Costo.CSTid;
                SqlCmd.Parameters.Add(ParCSTid);
                //
                SqlParameter ParCSTdescripcion = new SqlParameter();
                ParCSTdescripcion.ParameterName = "@sCSTdescripcion";
                ParCSTdescripcion.SqlDbType = SqlDbType.Int;
                ParCSTdescripcion.Value = acfCSTt_Costo.CSTdescripcion;
                SqlCmd.Parameters.Add(ParCSTdescripcion);
                //
                SqlParameter ParCSTdetalle = new SqlParameter();
                ParCSTdetalle.ParameterName = "@sCSTdetalle";
                ParCSTdetalle.SqlDbType = SqlDbType.VarChar;
                ParCSTdetalle.Value = acfCSTt_Costo.CSTabreviado;
                SqlCmd.Parameters.Add(ParCSTdetalle);
                //
                //
                SqlParameter ParCSTabreviado = new SqlParameter();
                ParCSTabreviado.ParameterName = "@sCSTabreviado";
                ParCSTabreviado.SqlDbType = SqlDbType.VarChar;
                ParCSTabreviado.Value = acfCSTt_Costo.CSTabreviado;
                SqlCmd.Parameters.Add(ParCSTabreviado);
                //
                //
                SqlParameter ParACTid = new SqlParameter();
                ParACTid.ParameterName = "@sACTid";
                ParACTid.SqlDbType = SqlDbType.Char;
                ParACTid.Value = acfCSTt_Costo.ACTid;
                SqlCmd.Parameters.Add(ParACTid);
                //
                //
                SqlParameter ParCSTid_costo = new SqlParameter();
                ParCSTid_costo.ParameterName = "@sCSTid_costo";
                ParCSTid_costo.SqlDbType = SqlDbType.Char;
                ParCSTid_costo.Value = acfCSTt_Costo.CSTid_costo;
                SqlCmd.Parameters.Add(ParCSTid_costo);
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
	public string Eliminar(DacfCSTt_Costo acfCSTt_Costo) {
		
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
                SqlCmd.CommandText = "usp_D_acfCSTt_Costo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCSTid = new SqlParameter();
                ParCSTid.ParameterName = "@sCSTid";
                ParCSTid.SqlDbType = SqlDbType.Int;
                ParCSTid.Value = acfCSTt_Costo.CSTid;
                SqlCmd.Parameters.Add(ParCSTid);
			
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

	public DataTable Buscar(DacfCSTt_Costo acfCSTt_Costo) {

        DataTable DtResultado = new DataTable("acfCSTt_Costo");
            SqlConnection SqlCon = new SqlConnection();


		try {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_acfCSTt_Costo";
            SqlCmd.CommandType = CommandType.StoredProcedure;



            SqlParameter ParAMBambiente = new SqlParameter();
            ParAMBambiente.ParameterName = "@sCSTdescripcion";
            ParAMBambiente.SqlDbType = SqlDbType.Int;
            ParAMBambiente.Size = 50;
            ParAMBambiente.Value = acfCSTt_Costo.CSTdescripcion;
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
