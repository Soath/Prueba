using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DacfRVAt_registrovaluacion{


        private string sRVAcodigo;
        private string sRVAperiodo;
        private string sRVAfecha;
        private string sRVAresponsable;
        private string sRVRestado;

        public string RVAcodigo
        {
        get { return sRVAcodigo; }
        set { sRVAcodigo = value; }
	    }

        public string RVAperiodo
        {
        get { return sRVAperiodo; }
        set { sRVAperiodo = value; }
	    }

        public String RVAfecha
        {
        get { return sRVAfecha; }
        set { sRVAfecha = value; }
        }

        public String RVAresponsable
        {
        get { return sRVAresponsable; }
        set { sRVAresponsable = value; }
        }

        public String RVRestado
        {
        get { return sRVRestado; }
        set { sRVRestado = value; }
        }

        //Constructor vacío
	public DacfRVAt_registrovaluacion(){
	}
        //Constructor con parámetros
    public DacfRVAt_registrovaluacion(
        string RVAcodigo,
        string RVAperiodo,
        string RVAfecha,
        string RVAresponsable,
        string RVRestado)
        
    {

        this.RVAcodigo = sRVAcodigo;
        this.RVAperiodo = sRVAperiodo;
        this.RVAfecha = sRVAfecha;
        this.RVAresponsable = sRVAresponsable;
        this.RVRestado = sRVRestado;
	}

/*	public object Clone() {
//		return base.MemberwiseClone();
//	}
*/


        public DataTable Mostrar() {
           DataTable DtResultado = new DataTable("acfRVAt_registrovaluacion");
            SqlConnection SqlCon = new SqlConnection();

		try {
            //Codigo
             SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfRVAt_registrovaluacion";
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
	public string Insertar(DacfRVAt_registrovaluacion acfRVAt_registrovaluacion)
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
                SqlCmd.CommandText = "usp_I_acfRVAt_registrovaluacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRVAcodigo = new SqlParameter();
                ParRVAcodigo.ParameterName = "@sRVAcodigo";
                ParRVAcodigo.SqlDbType = SqlDbType.Char;
                ParRVAcodigo.Value = acfRVAt_registrovaluacion.RVAcodigo;
                SqlCmd.Parameters.Add(ParRVAcodigo);
//
                SqlParameter ParRVAperiodo = new SqlParameter();
                ParRVAperiodo.ParameterName = "@sRVAperiodo";
                ParRVAperiodo.SqlDbType = SqlDbType.Char;
                ParRVAperiodo.Value = acfRVAt_registrovaluacion.RVAperiodo;
                SqlCmd.Parameters.Add(ParRVAperiodo);
//
                SqlParameter ParRVAfecha = new SqlParameter();
                ParRVAfecha.ParameterName = "@sRVAfecha";
                ParRVAfecha.SqlDbType = SqlDbType.Char;
                ParRVAfecha.Value = acfRVAt_registrovaluacion.RVAfecha;
                SqlCmd.Parameters.Add(ParRVAfecha);
//
                //
                SqlParameter ParRVAresponsable = new SqlParameter();
                ParRVAresponsable.ParameterName = "@sRVAresponsable";
                ParRVAresponsable.SqlDbType = SqlDbType.Char;
                ParRVAresponsable.Value = acfRVAt_registrovaluacion.RVAresponsable;
                SqlCmd.Parameters.Add(ParRVAresponsable);
                //
                //
                SqlParameter ParRVRestado = new SqlParameter();
                ParRVRestado.ParameterName = "@sRVRestado";
                ParRVRestado.SqlDbType = SqlDbType.Char;
                ParRVRestado.Value = acfRVAt_registrovaluacion.RVRestado;
                SqlCmd.Parameters.Add(ParRVRestado);
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
	public string Editar(DacfRVAt_registrovaluacion acfRVAt_registrovaluacion) {
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
                SqlCmd.CommandText = "usp_U_acfRVAt_registrovaluacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRVAcodigo = new SqlParameter();
                ParRVAcodigo.ParameterName = "@sRVAcodigo";
                ParRVAcodigo.SqlDbType = SqlDbType.Char;
                ParRVAcodigo.Value = acfRVAt_registrovaluacion.RVAcodigo;
                SqlCmd.Parameters.Add(ParRVAcodigo);
                //
                SqlParameter ParRVAperiodo = new SqlParameter();
                ParRVAperiodo.ParameterName = "@sRVAperiodo";
                ParRVAperiodo.SqlDbType = SqlDbType.Char;
                ParRVAperiodo.Value = acfRVAt_registrovaluacion.RVAperiodo;
                SqlCmd.Parameters.Add(ParRVAperiodo);
                //
                SqlParameter ParRVAfecha = new SqlParameter();
                ParRVAfecha.ParameterName = "@sRVAfecha";
                ParRVAfecha.SqlDbType = SqlDbType.Char;
                ParRVAfecha.Value = acfRVAt_registrovaluacion.RVAfecha;
                SqlCmd.Parameters.Add(ParRVAfecha);
                //
                //
                SqlParameter PartRVAresponsable = new SqlParameter();
                PartRVAresponsable.ParameterName = "@sRVAresponsable";
                PartRVAresponsable.SqlDbType = SqlDbType.Char;
                PartRVAresponsable.Value = acfRVAt_registrovaluacion.RVAresponsable;
                SqlCmd.Parameters.Add(PartRVAresponsable);
                //
                //
                SqlParameter ParRVRestado = new SqlParameter();
                ParRVRestado.ParameterName = "@sRVRestado";
                ParRVRestado.SqlDbType = SqlDbType.Char;
                ParRVRestado.Value = acfRVAt_registrovaluacion.RVRestado;
                SqlCmd.Parameters.Add(ParRVRestado);
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
	public string Eliminar(DacfRVAt_registrovaluacion acfRVAt_registrovaluacion) {
		
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
                SqlCmd.CommandText = "usp_D_acfRVAt_registrovaluacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRVAcodigo = new SqlParameter();
                ParRVAcodigo.ParameterName = "@sRVAcodigo";
                ParRVAcodigo.SqlDbType = SqlDbType.Char;
                ParRVAcodigo.Value = acfRVAt_registrovaluacion.RVAcodigo;
                SqlCmd.Parameters.Add(ParRVAcodigo);
			
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

	public DataTable Buscar(DacfRVAt_registrovaluacion acfRVAt_registrovaluacion) {

        DataTable DtResultado = new DataTable("acfRVAt_registrovaluacion");
            SqlConnection SqlCon = new SqlConnection();


		try {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_acfRVAt_registrovaluacion";
            SqlCmd.CommandType = CommandType.StoredProcedure;



            SqlParameter ParRVAresponsable = new SqlParameter();
            ParRVAresponsable.ParameterName = "@sRVAresponsable";
            ParRVAresponsable.SqlDbType = SqlDbType.Char;
            ParRVAresponsable.Size = 50;
            ParRVAresponsable.Value = acfRVAt_registrovaluacion.RVAresponsable;
            SqlCmd.Parameters.Add(ParRVAresponsable);

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
