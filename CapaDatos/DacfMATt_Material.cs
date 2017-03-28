using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DacfMATt_Material{


        private string iMATid;
        private string sMATmaterial;
        private string sMATabreviado;

        public string MATid
        {
            get { return iMATid; }
            set { iMATid = value; }
	    }

        public string MATmaterial
        {
            get { return sMATmaterial; }
            set { sMATmaterial = value; }
	    }

        public String MATabreviado
        {
            get { return sMATabreviado; }
            set { sMATabreviado = value; }
        }
    
        //Constructor vacío
	public DacfMATt_Material(){	}

        //Constructor con parámetros
    public DacfMATt_Material(
        string iMATid,
        string sMATmaterial,
        string sMATabreviado)
        
    {

        this.MATid = iMATid;
        this.MATmaterial = sMATmaterial;
        this.MATabreviado = sMATabreviado;
	}

/*	public object Clone() {
//		return base.MemberwiseClone();
//	}
*/

    //METODO MOSTRAR 
        public DataTable Mostrar() {
           DataTable DtResultado = new DataTable("acfMATt_Material");
            SqlConnection SqlCon = new SqlConnection();

		try {
            //Codigo
             SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfMATt_Material";
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
	public string Insertar(DacfMATt_Material acfMATt_Material)
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
                SqlCmd.CommandText = "usp_I_acfMATt_Material";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParMATid = new SqlParameter();
                ParMATid.ParameterName = "@iMATid";
                ParMATid.SqlDbType = SqlDbType.Int;
                ParMATid.Value = acfMATt_Material.MATid;
                SqlCmd.Parameters.Add(ParMATid);
//
                SqlParameter ParMATmaterial = new SqlParameter();
                ParMATmaterial.ParameterName = "@sMATmaterial";
                ParMATmaterial.SqlDbType = SqlDbType.VarChar;
                ParMATmaterial.Value = acfMATt_Material.MATmaterial;
                SqlCmd.Parameters.Add(ParMATmaterial);
//
                SqlParameter ParMATabreviado = new SqlParameter();
                ParMATabreviado.ParameterName = "@sMATabreviado";
                ParMATabreviado.SqlDbType = SqlDbType.Char;
                ParMATabreviado.Value = acfMATt_Material.MATabreviado;
                SqlCmd.Parameters.Add(ParMATabreviado);
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
	public string Editar(DacfMATt_Material acfMATt_Material) {
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
                SqlCmd.CommandText = "usp_U_acfMATt_Material";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParMATid = new SqlParameter();
                ParMATid.ParameterName = "@iMATid";
                ParMATid.SqlDbType = SqlDbType.Int;
                ParMATid.Value = acfMATt_Material.MATid;
                SqlCmd.Parameters.Add(ParMATid);
                //
                SqlParameter ParMATmaterial = new SqlParameter();
                ParMATmaterial.ParameterName = "@sMATmaterial";
                ParMATmaterial.SqlDbType = SqlDbType.VarChar;
                ParMATmaterial.Value = acfMATt_Material.MATmaterial;
                SqlCmd.Parameters.Add(ParMATmaterial);
                //
                SqlParameter ParMATabreviado = new SqlParameter();
                ParMATabreviado.ParameterName = "@sMATabreviado";
                ParMATabreviado.SqlDbType = SqlDbType.Char;
                ParMATabreviado.Value = acfMATt_Material.MATabreviado;
                SqlCmd.Parameters.Add(ParMATabreviado);
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
	public string Eliminar(DacfMATt_Material acfMATt_Material) {
		
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
                SqlCmd.CommandText = "usp_D_acfMATt_Material";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParMATid = new SqlParameter();
                ParMATid.ParameterName = "@iMATid";
                ParMATid.SqlDbType = SqlDbType.Int;
                ParMATid.Value = acfMATt_Material.MATid;
                SqlCmd.Parameters.Add(ParMATid);
			
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

	public DataTable Buscar(DacfMATt_Material acfMATt_Material) {

        DataTable DtResultado = new DataTable("acfMATt_Material");
            SqlConnection SqlCon = new SqlConnection();


		try {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_acfMATt_Material";
            SqlCmd.CommandType = CommandType.StoredProcedure;



            SqlParameter ParMATmaterial = new SqlParameter();
            ParMATmaterial.ParameterName = "@sMATmaterial";
            ParMATmaterial.SqlDbType = SqlDbType.VarChar;
            ParMATmaterial.Size = 50;
            ParMATmaterial.Value = acfMATt_Material.MATmaterial;
            SqlCmd.Parameters.Add(ParMATmaterial);

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

