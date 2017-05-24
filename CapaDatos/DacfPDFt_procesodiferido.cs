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
        private string dPDFfecha;
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

        public String PDFfecha
        {
        get { return dPDFfecha; }
        set { dPDFfecha = value; }
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
        string PDFfecha,
        string PDFreponsable,
        string PDFestado)
        
    {

        this.PDFcodigo = iPDFcodigo;
        this.PDFperiodo = sPDFperiodo;
        this.PDFfecha = dPDFfecha;
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


        // barra de navegacion
        public DataTable Top()
        {

            DataTable DtResultado = new DataTable("acfPDFt_procesodiferido");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_T_acfPDFt_procesodiferido";
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

        public DataTable Prev(String CMPid)
        {
            DataTable DtResultado = new DataTable("acfPDFt_procesodiferido");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_P_acfPDFt_procesodiferido";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPDFcodigo = new SqlParameter();
                ParPDFcodigo.ParameterName = "@iPDFcodigo";
                ParPDFcodigo.SqlDbType = SqlDbType.Int;
                ParPDFcodigo.Size = 50;
                ParPDFcodigo.Value = PDFcodigo;
                SqlCmd.Parameters.Add(ParPDFcodigo);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        public DataTable Last()
        {
            DataTable DtResultado = new DataTable("acfPDFt_procesodiferido");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_L_acfPDFt_procesodiferido";
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
        public DataTable Next(String CMPid)
        {
            DataTable DtResultado = new DataTable("acfPDFt_procesodiferido");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_N_acfPDFt_procesodiferido";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPDFcodigo = new SqlParameter();
                ParPDFcodigo.ParameterName = "@iPDFcodigo";
                ParPDFcodigo.SqlDbType = SqlDbType.Int;
                ParPDFcodigo.Size = 50;
                ParPDFcodigo.Value = PDFcodigo;
                SqlCmd.Parameters.Add(ParPDFcodigo);


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
                SqlParameter ParPDFfecha = new SqlParameter();
                ParPDFfecha.ParameterName = "@dPDFfecha";
                ParPDFfecha.SqlDbType = SqlDbType.DateTime;
                ParPDFfecha.Value = acfPDFt_procesodiferido.PDFfecha;
                SqlCmd.Parameters.Add(ParPDFfecha);
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
                SqlParameter ParPDFfecha = new SqlParameter();
                ParPDFfecha.ParameterName = "@dPDFfecha";
                ParPDFfecha.SqlDbType = SqlDbType.DateTime;
                ParPDFfecha.Value = acfPDFt_procesodiferido.PDFfecha;
                SqlCmd.Parameters.Add(ParPDFfecha);
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
