using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DbdiXPEpExtraccionSAP_Personal{


        private string sPERNR;
        private string sNachn;
        private string sName2;
        private string sVorna;
        private string sDNI;
        private string sWERKS;
        private string sPersg;
        private string sKOSTL;

	    public string PERNR {
		get { return sPERNR;	}
		set { sPERNR = value;	}
	    }

	    public string Nachn {
		get { return sNachn;	}
		set { sNachn = value;	}
	    }

        public String Name2    {
        get { return sName2;  }
        set { sName2 = value; }
        }

        public String Vorna    {
        get { return sVorna;  }
        set { sVorna = value; }
        }

        public String DNI    {
        get { return sDNI;  }
        set { sDNI = value; }
        }

        public String WERKS    {
        get { return sWERKS; }
        set { sWERKS = value;}
        }
        public String Persg
        {
            get { return sPersg; }
            set { sPersg = value; }
        }
        public String KOSTL
        {
            get { return sKOSTL; }
            set { sKOSTL = value; }
        }
        //Constructor vacío
	public DbdiXPEpExtraccionSAP_Personal(){
	}
        //Constructor con parámetros
    public DbdiXPEpExtraccionSAP_Personal(
        string PERNR, 
        string Nachn, 
        string Name2, 
        string Vorna, 
        string DNI, 
        string WERKS,
        string Persg,
        string KOSTL)
    {

        this.PERNR = sPERNR;
        this.Nachn = sNachn;
        this.Name2 = sName2;
        this.Vorna = sVorna;
        this.DNI = sDNI;
        this.WERKS = sWERKS;
        this.Persg = sPersg;
        this.KOSTL = sKOSTL;
	}

/*	public object Clone() {
//		return base.MemberwiseClone();
//	}
*/

    //METODO MOSTRAR
        public DataTable Mostrar() {
           DataTable DtResultado = new DataTable("bdiXPEpExtraccionSAP_Personal");
            SqlConnection SqlCon = new SqlConnection();

		try {
            //Codigo
             SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_bdiXPEpExtraccionSAP_Personal";
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
	public string Insertar(DbdiXPEpExtraccionSAP_Personal bdiXPEpExtraccionSAP_Personal)
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
                SqlCmd.CommandText = "usp_I_bdiXPEpExtraccionSAP_Personal";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPERNR = new SqlParameter();
                ParPERNR.ParameterName = "@sPERNR";
                ParPERNR.SqlDbType = SqlDbType.Char;
                ParPERNR.Value = bdiXPEpExtraccionSAP_Personal.PERNR;
                SqlCmd.Parameters.Add(ParPERNR);
//
                SqlParameter ParNachn = new SqlParameter();
                ParNachn.ParameterName = "@sNachn";
                ParNachn.SqlDbType = SqlDbType.VarChar;
                ParNachn.Value = bdiXPEpExtraccionSAP_Personal.Nachn;
                SqlCmd.Parameters.Add(ParNachn);
//
                SqlParameter ParName2 = new SqlParameter();
                ParName2.ParameterName = "@sName2";
                ParName2.SqlDbType = SqlDbType.VarChar;
                ParName2.Value = bdiXPEpExtraccionSAP_Personal.Vorna;
                SqlCmd.Parameters.Add(ParName2);
//
                //
                SqlParameter ParVorna = new SqlParameter();
                ParVorna.ParameterName = "@sVorna";
                ParVorna.SqlDbType = SqlDbType.VarChar;
                ParVorna.Value = bdiXPEpExtraccionSAP_Personal.Vorna;
                SqlCmd.Parameters.Add(ParVorna);
                //
                //
                SqlParameter ParDNI = new SqlParameter();
                ParDNI.ParameterName = "@sDNI";
                ParDNI.SqlDbType = SqlDbType.VarChar;
                ParDNI.Value = bdiXPEpExtraccionSAP_Personal.DNI;
                SqlCmd.Parameters.Add(ParDNI);
                //
                //
                SqlParameter ParWERKS = new SqlParameter();
                ParWERKS.ParameterName = "@sWERKS";
                ParWERKS.SqlDbType = SqlDbType.VarChar;
                ParWERKS.Value = bdiXPEpExtraccionSAP_Personal.WERKS;
                SqlCmd.Parameters.Add(ParWERKS);
                //
                SqlParameter ParPersg = new SqlParameter();
                ParPersg.ParameterName = "@sPersg";
                ParPersg.SqlDbType = SqlDbType.VarChar;
                ParPersg.Value = bdiXPEpExtraccionSAP_Personal.Persg;
                SqlCmd.Parameters.Add(ParPersg);
                //
                SqlParameter ParKOSTL = new SqlParameter();
                ParKOSTL.ParameterName = "@sKOSTL";
                ParKOSTL.SqlDbType = SqlDbType.VarChar;
                ParKOSTL.Value = bdiXPEpExtraccionSAP_Personal.KOSTL;
                SqlCmd.Parameters.Add(ParKOSTL);
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
	public string Editar(DbdiXPEpExtraccionSAP_Personal bdiXPEpExtraccionSAP_Personal) {
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
                SqlCmd.CommandText = "usp_U_bdiXPEpExtraccionSAP_Personal";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPERNR = new SqlParameter();
                ParPERNR.ParameterName = "@sPERNR";
                ParPERNR.SqlDbType = SqlDbType.Char;
                ParPERNR.Value = bdiXPEpExtraccionSAP_Personal.PERNR;
                SqlCmd.Parameters.Add(ParPERNR);
                //
                SqlParameter ParNachn = new SqlParameter();
                ParNachn.ParameterName = "@sNachn";
                ParNachn.SqlDbType = SqlDbType.VarChar;
                ParNachn.Value = bdiXPEpExtraccionSAP_Personal.Nachn;
                SqlCmd.Parameters.Add(ParNachn);
                //
                SqlParameter ParName2 = new SqlParameter();
                ParName2.ParameterName = "@sName2";
                ParName2.SqlDbType = SqlDbType.VarChar;
                ParName2.Value = bdiXPEpExtraccionSAP_Personal.Vorna;
                SqlCmd.Parameters.Add(ParName2);
                //
                //
                SqlParameter ParVorna = new SqlParameter();
                ParVorna.ParameterName = "@sVorna";
                ParVorna.SqlDbType = SqlDbType.VarChar;
                ParVorna.Value = bdiXPEpExtraccionSAP_Personal.Vorna;
                SqlCmd.Parameters.Add(ParVorna);
                //
                //
                SqlParameter ParDNI = new SqlParameter();
                ParDNI.ParameterName = "@sDNI";
                ParDNI.SqlDbType = SqlDbType.Char;
                ParDNI.Value = bdiXPEpExtraccionSAP_Personal.DNI;
                SqlCmd.Parameters.Add(ParDNI);
                //
                //
                SqlParameter ParWERKS = new SqlParameter();
                ParWERKS.ParameterName = "@sWERKS";
                ParWERKS.SqlDbType = SqlDbType.VarChar;
                ParWERKS.Value = bdiXPEpExtraccionSAP_Personal.WERKS;
                SqlCmd.Parameters.Add(ParWERKS);
                //
                SqlParameter ParPersg = new SqlParameter();
                ParPersg.ParameterName = "@sPersg";
                ParPersg.SqlDbType = SqlDbType.VarChar;
                ParPersg.Value = bdiXPEpExtraccionSAP_Personal.Persg;
                SqlCmd.Parameters.Add(ParPersg);
                //
                SqlParameter ParKOSTL = new SqlParameter();
                ParKOSTL.ParameterName = "@sKOSTL";
                ParKOSTL.SqlDbType = SqlDbType.VarChar;
                ParKOSTL.Value = bdiXPEpExtraccionSAP_Personal.KOSTL;
                SqlCmd.Parameters.Add(ParKOSTL);
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
	public string Eliminar(DbdiXPEpExtraccionSAP_Personal bdiXPEpExtraccionSAP_Personal) {
		
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
                SqlCmd.CommandText = "usp_D_bdiXPEpExtraccionSAP_Personal";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPERNR = new SqlParameter();
                ParPERNR.ParameterName = "@sPERNR";
                ParPERNR.SqlDbType = SqlDbType.Char;
                ParPERNR.Value = bdiXPEpExtraccionSAP_Personal.PERNR;
                SqlCmd.Parameters.Add(ParPERNR);
			
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

	public DataTable Buscar(DbdiXPEpExtraccionSAP_Personal bdiXPEpExtraccionSAP_Personal) {

        DataTable DtResultado = new DataTable("bdiXPEpExtraccionSAP_Personal");
            SqlConnection SqlCon = new SqlConnection();


		try {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_bdiXPEpExtraccionSAP_Personal";
            SqlCmd.CommandType = CommandType.StoredProcedure;



            SqlParameter ParAMBambiente = new SqlParameter();
            ParAMBambiente.ParameterName = "@sPERNR";
            ParAMBambiente.SqlDbType = SqlDbType.Char;
            ParAMBambiente.Size = 50;
            ParAMBambiente.Value = bdiXPEpExtraccionSAP_Personal.PERNR;
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
