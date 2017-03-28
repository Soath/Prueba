using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;




namespace CapaDatos
{
    public class DAcfSELt_SistemaElectrico
    {

        private string mSELid;
        private string mSELsistemaelectrico;
        private string mSEGMENT;

        public string SELid
        {
            get
            {
                return mSELid;
            }
            set
            {
                mSELid = value;
            }
        }
        public string SELsistemaelectrico
        {
            get
            {
                return mSELsistemaelectrico;
            }
            set
            {
                mSELsistemaelectrico = value;
            }
        }
        public string SEGMENT
        {
            get
            {
                return mSEGMENT;
            }
            set
            {
                mSEGMENT = value;
            }
        }


             //Constructor vacío
        public DAcfSELt_SistemaElectrico()
        {


	}


         //Constructor con parámetros

        public DAcfSELt_SistemaElectrico(string SELid, string SELsistemaelectrico, string SEGMENT)
        {
        
		this.mSELid = SELid;
		this.mSELsistemaelectrico = SELsistemaelectrico;
        this.mSEGMENT = SEGMENT;
	}

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("acfSELt_SistemaElectrico");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfSELt_SistemaElectrico";
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
        public string Insertar(DAcfSELt_SistemaElectrico acfSELt_SistemaElectrico)
        {
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
                SqlCmd.CommandText = "usp_I_acfSELt_SistemaElectrico";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParsSELid = new SqlParameter();
                ParsSELid.ParameterName = "@sSELid";
                ParsSELid.SqlDbType = SqlDbType.Char;
                ParsSELid.Value = acfSELt_SistemaElectrico.SELid;
                SqlCmd.Parameters.Add(ParsSELid);
                //
                SqlParameter ParsSELsistemaelectrico = new SqlParameter();
                ParsSELsistemaelectrico.ParameterName = "@sSELsistemaelectrico";
                ParsSELsistemaelectrico.SqlDbType = SqlDbType.VarChar;
                ParsSELsistemaelectrico.Value = acfSELt_SistemaElectrico.SELsistemaelectrico;
                SqlCmd.Parameters.Add(ParsSELsistemaelectrico);
                //
                SqlParameter ParsSEGMENT = new SqlParameter();
                ParsSEGMENT.ParameterName = "@sSEGMENT";
                ParsSEGMENT.SqlDbType = SqlDbType.Char;
                ParsSEGMENT.Value = acfSELt_SistemaElectrico.SEGMENT;
                SqlCmd.Parameters.Add(ParsSEGMENT);
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
        public string Editar(DAcfSELt_SistemaElectrico acfSELt_SistemaElectrico)
        {
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
                SqlCmd.CommandText = "usp_U_acfSELt_SistemaElectrico";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParsSELid = new SqlParameter();
                ParsSELid.ParameterName = "@sSELid";
                ParsSELid.SqlDbType = SqlDbType.Char;
                ParsSELid.Value = acfSELt_SistemaElectrico.SELid;
                SqlCmd.Parameters.Add(ParsSELid);
                //
                SqlParameter ParsSELsistemaelectrico = new SqlParameter();
                ParsSELsistemaelectrico.ParameterName = "@sSELsistemaelectrico";
                ParsSELsistemaelectrico.SqlDbType = SqlDbType.VarChar;
                ParsSELsistemaelectrico.Value = acfSELt_SistemaElectrico.SELsistemaelectrico;
                SqlCmd.Parameters.Add(ParsSELsistemaelectrico);
                //
                SqlParameter ParsSEGMENT = new SqlParameter();
                ParsSEGMENT.ParameterName = "@sSEGMENT";
                ParsSEGMENT.SqlDbType = SqlDbType.Char;
                ParsSEGMENT.Value = acfSELt_SistemaElectrico.SEGMENT;
                SqlCmd.Parameters.Add(ParsSEGMENT);
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

        //METODO ELIMINAR
        public string Eliminar(DAcfSELt_SistemaElectrico acfSELt_SistemaElectrico)
        {

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
                SqlCmd.CommandText = "usp_D_acfSELt_SistemaElectrico";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //
                SqlParameter ParsSELid = new SqlParameter();
                ParsSELid.ParameterName = "@sSELid";
                ParsSELid.SqlDbType = SqlDbType.Char;
                ParsSELid.Value = acfSELt_SistemaElectrico.SELid;
                SqlCmd.Parameters.Add(ParsSELid);

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

        public DataTable Buscar(DAcfSELt_SistemaElectrico acfSELt_SistemaElectrico)
        {

            DataTable DtResultado = new DataTable("acfSELt_SistemaElectrico");
            SqlConnection SqlCon = new SqlConnection();


            try
            {

                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_B_acfSELt_SistemaElectrico";
                SqlCmd.CommandType = CommandType.StoredProcedure;



                SqlParameter ParSELsistema = new SqlParameter();
                ParSELsistema.ParameterName = "@sSELid";
                ParSELsistema.SqlDbType = SqlDbType.Char;
                ParSELsistema.Size = 50;
                ParSELsistema.Value = acfSELt_SistemaElectrico.SELid;
                SqlCmd.Parameters.Add(ParSELsistema);

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
