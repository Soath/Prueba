using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DAcfRTRt_Reparotributario
    {
        private string mRTRperiodo;
        private string mRTRfecha;
        private string mRTRresponsable;
        private bool mRTRestado;
        private string mRTRcodigo;


        public string RTRperiodo
        {
            get
            {
                return mRTRperiodo;
            }
            set
            {
                mRTRperiodo = value;
            }
        }
        public string RTRfecha
        {
            get
            {
                return mRTRfecha;
            }
            set
            {
                mRTRfecha = value;
            }
        }
        public string RTRresponsable
        {
            get
            {
                return mRTRresponsable;
            }
            set
            {
                mRTRresponsable = value;
            }
        }

        public bool RTRestado
        {
            get
            {
                return mRTRestado;
            }
            set
            {
                mRTRestado = value;
            }
        }

        public string RTRcodigo
        {
            get
            {
                return mRTRcodigo;
            }
            set
            {
                mRTRcodigo = value;
            }
        }


         //Constructor vacío
        public DAcfRTRt_Reparotributario()
        {
	}



        //Constructor con parámetros

        public DAcfRTRt_Reparotributario(string RTRperiodo, string RTRfecha, string RTRresponsable, bool RTRestado, string RTRcodigo)
        {

        this.mRTRperiodo = RTRperiodo;
		this.mRTRfecha = RTRfecha;
        this.mRTRresponsable = RTRresponsable;
        this.mRTRestado = RTRestado;
        this.mRTRcodigo = RTRcodigo;
	
	}

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("acfRTRt_Reparotributario");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfRTRt_Reparotributario";
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
        public DataTable Top()
        {

            DataTable DtResultado = new DataTable("acfRTRt_Reparotributario");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_T_acfRTRt_Reparotributario";
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
        public DataTable Last()
        {
            DataTable DtResultado = new DataTable("acfRTRt_Reparotributario");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_L_acfRTRt_Reparotributario";
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
        public DataTable Next(String RTRcodigo)
        {
            DataTable DtResultado = new DataTable("acfRTRt_Reparotributario");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_N_acfRTRt_Reparotributario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRTRcodigo = new SqlParameter();
                ParRTRcodigo.ParameterName = "@RTRcodigo";
                ParRTRcodigo.SqlDbType = SqlDbType.Int;
                ParRTRcodigo.Value = Convert.ToInt32(RTRcodigo);
                ParRTRcodigo.Size = 50;
                SqlCmd.Parameters.Add(ParRTRcodigo);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        public DataTable Prev(String RTRcodigo)
        {
            DataTable DtResultado = new DataTable("acfRTRt_Reparotributario");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_P_acfRTRt_Reparotributario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRTRcodigo = new SqlParameter();
                ParRTRcodigo.ParameterName = "@RTRcodigo";
                ParRTRcodigo.SqlDbType = SqlDbType.Int;
                ParRTRcodigo.Size = 50;
                ParRTRcodigo.Value = RTRcodigo;
                SqlCmd.Parameters.Add(ParRTRcodigo);

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
        public string Insertar(DAcfRTRt_Reparotributario acfRTRt_Reparotributario)
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
                SqlCmd.CommandText = "usp_I_acfRTRt_Reparotributario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRTRperiodo = new SqlParameter();
                ParRTRperiodo.ParameterName = "@sRTRperiodo";
                ParRTRperiodo.SqlDbType = SqlDbType.Char;
                ParRTRperiodo.Value = acfRTRt_Reparotributario.RTRperiodo;
                SqlCmd.Parameters.Add(ParRTRperiodo);
                //
                SqlParameter ParsdtRTRfecha = new SqlParameter();
                ParsdtRTRfecha.ParameterName = "@dtRTRfecha";
                ParsdtRTRfecha.SqlDbType = SqlDbType.DateTime;
                ParsdtRTRfecha.Value = acfRTRt_Reparotributario.RTRfecha;
                SqlCmd.Parameters.Add(ParsdtRTRfecha);
                //
                SqlParameter PartsRTRresponsable = new SqlParameter();
                PartsRTRresponsable.ParameterName = "@sRTRresponsable";
                PartsRTRresponsable.SqlDbType = SqlDbType.Char;
                PartsRTRresponsable.Value = acfRTRt_Reparotributario.RTRresponsable;
                SqlCmd.Parameters.Add(PartsRTRresponsable);
                //
                SqlParameter PartbRTRestado = new SqlParameter();
                PartbRTRestado.ParameterName = "@bRTRestado";
                PartbRTRestado.SqlDbType = SqlDbType.Bit;
                PartbRTRestado.Value = acfRTRt_Reparotributario.RTRestado;
                SqlCmd.Parameters.Add(PartbRTRestado);
                //
                SqlParameter PartiRTRcodigo = new SqlParameter();
                PartiRTRcodigo.ParameterName = "@iRTRcodigo";
                PartiRTRcodigo.SqlDbType = SqlDbType.Int;
                PartiRTRcodigo.Value = acfRTRt_Reparotributario.RTRcodigo;
                SqlCmd.Parameters.Add(PartiRTRcodigo);
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
        public string Editar(DAcfRTRt_Reparotributario acfRTRt_Reparotributario)
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
                SqlCmd.CommandText = "usp_U_acfRTRt_Reparotributario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRTRperiodo = new SqlParameter();
                ParRTRperiodo.ParameterName = "@sRTRperiodo";
                ParRTRperiodo.SqlDbType = SqlDbType.Char;
                ParRTRperiodo.Value = acfRTRt_Reparotributario.RTRperiodo;
                SqlCmd.Parameters.Add(ParRTRperiodo);
                //
                SqlParameter ParsdtRTRfecha = new SqlParameter();
                ParsdtRTRfecha.ParameterName = "@dtRTRfecha";
                ParsdtRTRfecha.SqlDbType = SqlDbType.DateTime;
                ParsdtRTRfecha.Value = acfRTRt_Reparotributario.RTRfecha;
                SqlCmd.Parameters.Add(ParsdtRTRfecha);
                //
                SqlParameter PartsRTRresponsable = new SqlParameter();
                PartsRTRresponsable.ParameterName = "@sRTRresponsable";
                PartsRTRresponsable.SqlDbType = SqlDbType.Char;
                PartsRTRresponsable.Value = acfRTRt_Reparotributario.RTRresponsable;
                SqlCmd.Parameters.Add(PartsRTRresponsable);
                //
                SqlParameter PartbRTRestado = new SqlParameter();
                PartbRTRestado.ParameterName = "@bRTRestado";
                PartbRTRestado.SqlDbType = SqlDbType.Bit;
                PartbRTRestado.Value = acfRTRt_Reparotributario.RTRestado;
                SqlCmd.Parameters.Add(PartbRTRestado);
                //
                SqlParameter PartiRTRcodigo = new SqlParameter();
                PartiRTRcodigo.ParameterName = "@iRTRcodigo";
                PartiRTRcodigo.SqlDbType = SqlDbType.Int;
                PartiRTRcodigo.Value = acfRTRt_Reparotributario.RTRcodigo;
                SqlCmd.Parameters.Add(PartiRTRcodigo);
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
        public string Eliminar(DAcfRTRt_Reparotributario acfRTRt_Reparotributario)
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
                SqlCmd.CommandText = "usp_D_acfRTRt_Reparotributario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //
                SqlParameter PartiRTRcodigo = new SqlParameter();
                PartiRTRcodigo.ParameterName = "@iRTRcodigo";
                PartiRTRcodigo.SqlDbType = SqlDbType.Int;
                PartiRTRcodigo.Value = acfRTRt_Reparotributario.RTRcodigo;
                SqlCmd.Parameters.Add(PartiRTRcodigo);


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
        public DataTable Buscar(DAcfRTRt_Reparotributario acfRTRt_Reparotributario)
        {

            DataTable DtResultado = new DataTable("acfRTRt_Reparotributario");
            SqlConnection SqlCon = new SqlConnection();


            try
            {

                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_B_acfRTRt_Reparotributario";
                SqlCmd.CommandType = CommandType.StoredProcedure;



                SqlParameter ParRTRreparo = new SqlParameter();
                ParRTRreparo.ParameterName = "@iRTRcodigo";
                ParRTRreparo.SqlDbType = SqlDbType.Int;
                ParRTRreparo.Size = 50;
                ParRTRreparo.Value = acfRTRt_Reparotributario.RTRcodigo;
                SqlCmd.Parameters.Add(ParRTRreparo);

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
