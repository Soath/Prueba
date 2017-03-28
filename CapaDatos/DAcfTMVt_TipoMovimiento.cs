using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System.Data;
using System.Data.SqlClient;



namespace CapaDatos
{
    public class DAcfTMVt_TipoMovimiento
    {

        private string mTVMid;
        private string mTVMtipomovimiento;

        public string TVMid
        {
            get
            {
                return mTVMid;
            }
            set
            {
                mTVMid = value;
            }
        }

        public string TVMtipomovimiento
        {
            get
            {
                return mTVMtipomovimiento;
            }
            set
            {
                mTVMtipomovimiento = value;
            }
        }


         //Constructor vacío
        public DAcfTMVt_TipoMovimiento()
        {


	}


        //Constructor con parámetros

        public DAcfTMVt_TipoMovimiento(string TVMid, string TVMtipomovimiento)
        {
        
		this.mTVMid = TVMid;
		this.mTVMtipomovimiento = TVMtipomovimiento;
	
	}

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("acfTMVt_TipoMovimiento");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfTMVt_TipoMovimiento";
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
        public string Insertar(DAcfTMVt_TipoMovimiento acfTMVt_TipoMovimiento)
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
                SqlCmd.CommandText = "usp_I_acfTMVt_TipoMovimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParsTVMid = new SqlParameter();
                ParsTVMid.ParameterName = "@sTMVid";
                ParsTVMid.SqlDbType = SqlDbType.Char;
                ParsTVMid.Value = acfTMVt_TipoMovimiento.TVMid;
                SqlCmd.Parameters.Add(ParsTVMid);
                //
                SqlParameter ParsTVMmotivomovimiento = new SqlParameter();
                ParsTVMmotivomovimiento.ParameterName = "@sTMVtipomovimiento";
                ParsTVMmotivomovimiento.SqlDbType = SqlDbType.Char;
                ParsTVMmotivomovimiento.Value = acfTMVt_TipoMovimiento.TVMtipomovimiento;
                SqlCmd.Parameters.Add(ParsTVMmotivomovimiento);
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
        public string Editar(DAcfTMVt_TipoMovimiento acfTMVt_TipoMovimiento)
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
                SqlCmd.CommandText = "usp_U_acfTMVt_TipoMovimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParsTVMid = new SqlParameter();
                ParsTVMid.ParameterName = "@sTMVid";
                ParsTVMid.SqlDbType = SqlDbType.Char;
                ParsTVMid.Value = acfTMVt_TipoMovimiento.TVMid;
                SqlCmd.Parameters.Add(ParsTVMid);
                //
                SqlParameter ParsTVMmotivomovimiento = new SqlParameter();
                ParsTVMmotivomovimiento.ParameterName = "@sTMVtipomovimiento";
                ParsTVMmotivomovimiento.SqlDbType = SqlDbType.Char;
                ParsTVMmotivomovimiento.Value = acfTMVt_TipoMovimiento.TVMtipomovimiento;
                SqlCmd.Parameters.Add(ParsTVMmotivomovimiento);
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
        public string Eliminar(DAcfTMVt_TipoMovimiento acfTMVt_TipoMovimiento)
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
                SqlCmd.CommandText = "usp_D_acfTMVt_TipoMovimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //
                SqlParameter ParsTVMid = new SqlParameter();
                ParsTVMid.ParameterName = "@sTMVid";
                ParsTVMid.SqlDbType = SqlDbType.Char;
                ParsTVMid.Value = acfTMVt_TipoMovimiento.TVMid;
                SqlCmd.Parameters.Add(ParsTVMid);


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

        public DataTable Buscar(DAcfTMVt_TipoMovimiento acfTMVt_TipoMovimiento)
        {

            DataTable DtResultado = new DataTable("acfTMVt_TipoMovimiento");
            SqlConnection SqlCon = new SqlConnection();


            try
            {

                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_B_acfTMVt_TipoMovimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;



                SqlParameter ParTVMtipomovimiento = new SqlParameter();
                ParTVMtipomovimiento.ParameterName = "@sTMVid";
                ParTVMtipomovimiento.SqlDbType = SqlDbType.Char;
                ParTVMtipomovimiento.Size = 50;
                ParTVMtipomovimiento.Value = acfTMVt_TipoMovimiento.TVMid;
                SqlCmd.Parameters.Add(ParTVMtipomovimiento);

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
