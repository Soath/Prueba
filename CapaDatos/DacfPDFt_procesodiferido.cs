using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DacfPDFt_procesodiferido{


        private string iPDFcodigo;
        private string sPDFperiodo;
        private string dtPDFfecha;
        private string sPDFreponsable;
        private string bPDFestado;

        public string PDFcodigo
        {
        get { return iPDFcodigo; }
        set { iPDFcodigo = value; }
	    }

        public string PDFperiodo
        {
        get { return sPDFperiodo; }
        set { sPDFperiodo = value; }
	    }

        public String tPDFfecha
        {
        get { return dtPDFfecha; }
        set { dtPDFfecha = value; }
        }

        public String PDFreponsable
        {
        get { return sPDFreponsable; }
        set { sPDFreponsable = value; }
        }

        public String PDFestado
        {
        get { return bPDFestado; }
        set { bPDFestado = value; }
        }

        //Constructor vacío
	public DacfPDFt_procesodiferido(){
	}
        //Constructor con parámetros
    public DacfPDFt_procesodiferido(
        string PDFcodigo,
        string PDFperiodo,
        string tPDFfecha,
        string PDFreponsable,
        string PDFestado)
        
    {

        this.PDFcodigo = iPDFcodigo;
        this.PDFperiodo = sPDFperiodo;
        this.tPDFfecha = dtPDFfecha;
        this.PDFreponsable = sPDFreponsable;
        this.PDFestado = bPDFestado;
	}

/*	public object Clone() {
//		return base.MemberwiseClone();
//	}
*/

    //METODO MOSTRAR 
        public DataTable Mostrar() {
           DataTable DtResultado = new DataTable("acfPDFt_procesodiferido");
            SqlConnection SqlCon = new SqlConnection();

		try {
            //Codigo
             SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfPDFt_procesodiferido";
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
	public string Insertar(DacfPDFt_procesodiferido acfPDFt_procesodiferido)
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
                SqlCmd.CommandText = "usp_I_acfPDFt_procesodiferido";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPDFcodigo = new SqlParameter();
                ParPDFcodigo.ParameterName = "@iPDFcodigo";
                ParPDFcodigo.SqlDbType = SqlDbType.Int;
                ParPDFcodigo.Value = acfPDFt_procesodiferido.PDFcodigo;
                SqlCmd.Parameters.Add(ParPDFcodigo);
//
                SqlParameter ParPDFperiodo = new SqlParameter();
                ParPDFperiodo.ParameterName = "@sPDFperiodo";
                ParPDFperiodo.SqlDbType = SqlDbType.Char;
                ParPDFperiodo.Value = acfPDFt_procesodiferido.PDFperiodo;
                SqlCmd.Parameters.Add(ParPDFperiodo);
//
                SqlParameter PartPDFfecha = new SqlParameter();
                PartPDFfecha.ParameterName = "@dtPDFfecha";
                PartPDFfecha.SqlDbType = SqlDbType.DateTime;
                PartPDFfecha.Value = acfPDFt_procesodiferido.tPDFfecha;
                SqlCmd.Parameters.Add(PartPDFfecha);
//
                //
                SqlParameter ParPDFreponsable = new SqlParameter();
                ParPDFreponsable.ParameterName = "@sPDFreponsable";
                ParPDFreponsable.SqlDbType = SqlDbType.VarChar;
                ParPDFreponsable.Value = acfPDFt_procesodiferido.PDFreponsable;
                SqlCmd.Parameters.Add(ParPDFreponsable);
                //
                //
                SqlParameter ParPDFestado = new SqlParameter();
                ParPDFestado.ParameterName = "@bPDFestado";
                ParPDFestado.SqlDbType = SqlDbType.Bit;
                ParPDFestado.Value = acfPDFt_procesodiferido.PDFestado;
                SqlCmd.Parameters.Add(ParPDFestado);
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
	public string Editar(DacfPDFt_procesodiferido acfPDFt_procesodiferido) {
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
                SqlCmd.CommandText = "usp_U_acfPDFt_procesodiferido";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPDFcodigo = new SqlParameter();
                ParPDFcodigo.ParameterName = "@iPDFcodigo";
                ParPDFcodigo.SqlDbType = SqlDbType.Int;
                ParPDFcodigo.Value = acfPDFt_procesodiferido.PDFcodigo;
                SqlCmd.Parameters.Add(ParPDFcodigo);
                //
                SqlParameter ParPDFperiodo = new SqlParameter();
                ParPDFperiodo.ParameterName = "@sPDFperiodo";
                ParPDFperiodo.SqlDbType = SqlDbType.Char;
                ParPDFperiodo.Value = acfPDFt_procesodiferido.PDFperiodo;
                SqlCmd.Parameters.Add(ParPDFperiodo);
                //
                SqlParameter PartPDFfecha = new SqlParameter();
                PartPDFfecha.ParameterName = "@dtPDFfecha";
                PartPDFfecha.SqlDbType = SqlDbType.DateTime;
                PartPDFfecha.Value = acfPDFt_procesodiferido.tPDFfecha;
                SqlCmd.Parameters.Add(PartPDFfecha);
                //
                //
                SqlParameter PartPDFreponsable = new SqlParameter();
                PartPDFreponsable.ParameterName = "@sPDFreponsable";
                PartPDFreponsable.SqlDbType = SqlDbType.VarChar;
                PartPDFreponsable.Value = acfPDFt_procesodiferido.PDFreponsable;
                SqlCmd.Parameters.Add(PartPDFreponsable);
                //
                //
                SqlParameter ParPDFestado = new SqlParameter();
                ParPDFestado.ParameterName = "@bPDFestado";
                ParPDFestado.SqlDbType = SqlDbType.Bit;
                ParPDFestado.Value = acfPDFt_procesodiferido.PDFestado;
                SqlCmd.Parameters.Add(ParPDFestado);
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
	public string Eliminar(DacfPDFt_procesodiferido acfPDFt_procesodiferido) {
		
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
                SqlCmd.CommandText = "usp_D_acfPDFt_procesodiferido";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPDFcodigo = new SqlParameter();
                ParPDFcodigo.ParameterName = "@iPDFcodigo";
                ParPDFcodigo.SqlDbType = SqlDbType.Int;
                ParPDFcodigo.Value = acfPDFt_procesodiferido.PDFcodigo;
                SqlCmd.Parameters.Add(ParPDFcodigo);
			
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

	public DataTable Buscar(DacfPDFt_procesodiferido acfPDFt_procesodiferido) {

        DataTable DtResultado = new DataTable("acfPDFt_procesodiferido");
            SqlConnection SqlCon = new SqlConnection();


		try {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_acfPDFt_procesodiferido";
            SqlCmd.CommandType = CommandType.StoredProcedure;



            SqlParameter ParPDFreponsable = new SqlParameter();
            ParPDFreponsable.ParameterName = "@sPDFreponsable";
            ParPDFreponsable.SqlDbType = SqlDbType.VarChar;
            ParPDFreponsable.Size = 50;
            ParPDFreponsable.Value = acfPDFt_procesodiferido.PDFreponsable;
            SqlCmd.Parameters.Add(ParPDFreponsable);

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
