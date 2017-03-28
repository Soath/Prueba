using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DBdiCDDpClasesDeDocumento
    {
        private string mBLART;
        private string mLTEXT;
        private string mDETdoctipo;

        public string BLART
        {
            get
            {
                return mBLART;
            }
            set
            {
                mBLART = value;
            }
        }

        public string LTEXT
        {
            get
            {
                return mLTEXT;
            }
            set
            {
                mLTEXT = value;
            }
        }
        public string DETdoctipo
        {
            get
            {
                return mDETdoctipo;
            }
            set
            {
                mDETdoctipo = value;
            }
        }

        //Constructor vacío
        public DBdiCDDpClasesDeDocumento()
        {
	    }

         //Constructor con parámetros

        public DBdiCDDpClasesDeDocumento(string BLART, string LTEXT, string DETdoctipo)
        {
        
		this.mBLART = BLART;
		this.mLTEXT = LTEXT;
        this.mDETdoctipo = DETdoctipo;
	
	    }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("bdiCDDpClasesDeDocumento");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_bdiCDDpClasesDeDocumento";
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
        public string Insertar(DBdiCDDpClasesDeDocumento bdiCDDpClasesDeDocumento)
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
                SqlCmd.CommandText = "usp_I_bdiCDDpClasesDeDocumento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParsBLART = new SqlParameter();
                ParsBLART.ParameterName = "@sBLART";
                ParsBLART.SqlDbType = SqlDbType.Char;
                ParsBLART.Value = bdiCDDpClasesDeDocumento.BLART;
                SqlCmd.Parameters.Add(ParsBLART);
                //
                SqlParameter ParsLTEXT = new SqlParameter();
                ParsLTEXT.ParameterName = "@sLTEXT";
                ParsLTEXT.SqlDbType = SqlDbType.Char;
                ParsLTEXT.Value = bdiCDDpClasesDeDocumento.LTEXT;
                SqlCmd.Parameters.Add(ParsLTEXT);
                //
                SqlParameter sDETdoctipo = new SqlParameter();
                sDETdoctipo.ParameterName = "@sDETdoctipo";
                sDETdoctipo.SqlDbType = SqlDbType.Char;
                sDETdoctipo.Value = bdiCDDpClasesDeDocumento.DETdoctipo;
                SqlCmd.Parameters.Add(sDETdoctipo);
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
        public string Editar(DBdiCDDpClasesDeDocumento bdiCDDpClasesDeDocumento)
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
                SqlCmd.CommandText = "usp_U_bdiCDDpClasesDeDocumento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParsBLART = new SqlParameter();
                ParsBLART.ParameterName = "@sBLART";
                ParsBLART.SqlDbType = SqlDbType.Char;
                ParsBLART.Value = bdiCDDpClasesDeDocumento.BLART;
                SqlCmd.Parameters.Add(ParsBLART);
                //
                SqlParameter ParsLTEXT = new SqlParameter();
                ParsLTEXT.ParameterName = "@sLTEXT";
                ParsLTEXT.SqlDbType = SqlDbType.Char;
                ParsLTEXT.Value = bdiCDDpClasesDeDocumento.LTEXT;
                SqlCmd.Parameters.Add(ParsLTEXT);
                //
                SqlParameter sDETdoctipo = new SqlParameter();
                sDETdoctipo.ParameterName = "@sDETdoctipo";
                sDETdoctipo.SqlDbType = SqlDbType.Char;
                sDETdoctipo.Value = bdiCDDpClasesDeDocumento.DETdoctipo;
                SqlCmd.Parameters.Add(sDETdoctipo);
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
        public string Eliminar(DBdiCDDpClasesDeDocumento bdiCDDpClasesDeDocumento)
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
                SqlCmd.CommandText = "usp_D_bdiCDDpClasesDeDocumento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //
                SqlParameter ParsBLART = new SqlParameter();
                ParsBLART.ParameterName = "@sBLART";
                ParsBLART.SqlDbType = SqlDbType.Char;
                ParsBLART.Value = bdiCDDpClasesDeDocumento.BLART;
                SqlCmd.Parameters.Add(ParsBLART);
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

        public DataTable Buscar(DBdiCDDpClasesDeDocumento bdiCDDpClasesDeDocumento)
        {

            DataTable DtResultado = new DataTable("bdiCDDpClasesDeDocumento");
            SqlConnection SqlCon = new SqlConnection();


            try
            {

                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_B_bdiCDDpClasesDeDocumento";
                SqlCmd.CommandType = CommandType.StoredProcedure;



                SqlParameter ParCDDClases= new SqlParameter();
                ParCDDClases.ParameterName = "@sBLART";
                ParCDDClases.SqlDbType = SqlDbType.Char;
                ParCDDClases.Size = 50;
                ParCDDClases.Value = bdiCDDpClasesDeDocumento.BLART;
                SqlCmd.Parameters.Add(ParCDDClases);

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
