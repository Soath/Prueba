using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
   public  class DBdiSEGpSegmento
    {

        private string mSEGMENT;
        private string mNAME;
        private string mid_zona;

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
        public string NAME
        {
            get
            {
                return mNAME;
            }
            set
            {
                mNAME = value;
            }
        }
        public string id_zona
        {
            get
            {
                return mid_zona;
            }
            set
            {
                mid_zona = value;
            }
        }

        //Constructor vacío
        public DBdiSEGpSegmento()
        {
	    }


        //Constructor con parámetros

        public DBdiSEGpSegmento(string SEGMENT, string NAME, string id_zona)
        {
        
		this.mSEGMENT = SEGMENT;
		this.mNAME = NAME;
        this.mid_zona = id_zona;
	
	    }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("bdiSEGpSegmento");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_bdiSEGpSegmento";
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
        public string Insertar(DBdiSEGpSegmento bdiSEGpSegmento)
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
                SqlCmd.CommandText = "usp_I_bdiSEGpSegmento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParsSEGMENT = new SqlParameter();
                ParsSEGMENT.ParameterName = "@sSEGMENT";
                ParsSEGMENT.SqlDbType = SqlDbType.Char;
                ParsSEGMENT.Value = bdiSEGpSegmento.SEGMENT;
                SqlCmd.Parameters.Add(ParsSEGMENT);
                //
                SqlParameter ParsNAME = new SqlParameter();
                ParsNAME.ParameterName = "@sNAME";
                ParsNAME.SqlDbType = SqlDbType.Char;
                ParsNAME.Value = bdiSEGpSegmento.NAME;
                SqlCmd.Parameters.Add(ParsNAME);
                //
                SqlParameter Parsid_zona = new SqlParameter();
                Parsid_zona.ParameterName = "@sid_zona";
                Parsid_zona.SqlDbType = SqlDbType.Char;
                Parsid_zona.Value = bdiSEGpSegmento.id_zona;
                SqlCmd.Parameters.Add(Parsid_zona);
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
        public string Editar (DBdiSEGpSegmento bdiSEGpSegmento)
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
                SqlCmd.CommandText = "usp_U_bdiSEGpSegmento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParsSEGMENT = new SqlParameter();
                ParsSEGMENT.ParameterName = "@sSEGMENT";
                ParsSEGMENT.SqlDbType = SqlDbType.Char;
                ParsSEGMENT.Value = bdiSEGpSegmento.SEGMENT;
                SqlCmd.Parameters.Add(ParsSEGMENT);
                //
                SqlParameter ParsNAME = new SqlParameter();
                ParsNAME.ParameterName = "@sNAME";
                ParsNAME.SqlDbType = SqlDbType.Char;
                ParsNAME.Value = bdiSEGpSegmento.NAME;
                SqlCmd.Parameters.Add(ParsNAME);
                //
                SqlParameter Parsid_zona = new SqlParameter();
                Parsid_zona.ParameterName = "@sid_zona";
                Parsid_zona.SqlDbType = SqlDbType.Char;
                Parsid_zona.Value = bdiSEGpSegmento.id_zona;
                SqlCmd.Parameters.Add(Parsid_zona);
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
        public string Eliminar(DBdiSEGpSegmento bdiSEGpSegmento)
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
                SqlCmd.CommandText = "usp_D_bdiSEGpSegmento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //
                SqlParameter ParsSEGMENT = new SqlParameter();
                ParsSEGMENT.ParameterName = "@sSEGMENT";
                ParsSEGMENT.SqlDbType = SqlDbType.Char;
                ParsSEGMENT.Value = bdiSEGpSegmento.SEGMENT;
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

        //METODO BUSCAR

        public DataTable Buscar(DBdiSEGpSegmento bdiSEGpSegmento)
        {

            DataTable DtResultado = new DataTable("bdiSEGpSegmento");
            SqlConnection SqlCon = new SqlConnection();


            try
            {

                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_B_bdiSEGpSegmento";
                SqlCmd.CommandType = CommandType.StoredProcedure;



                SqlParameter ParSEGsegmento = new SqlParameter();
                ParSEGsegmento.ParameterName = "@sSEGMENT";
                ParSEGsegmento.SqlDbType = SqlDbType.Char;
                ParSEGsegmento.Size = 50;
                ParSEGsegmento.Value = bdiSEGpSegmento.SEGMENT;
                SqlCmd.Parameters.Add(ParSEGsegmento);

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
