using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DAcfMVMt_MotivoMovimiento
    {

        private string mTMVid;
        private string mMVMid;
        private string mMVMmotivomovimiento;
        private string mMVMjustificacion;

        public string TMVid
        {
            get {   return mTMVid;  }
            set {   mTMVid = value; }
        }

        public string MVMid
        {
            get {   return mMVMid;  }
            set {   mMVMid = value; }
        }

        public string MVMmotivomovimiento
        {
            get {   return mMVMmotivomovimiento ;  }
            set {   mMVMmotivomovimiento = value;  }
        }

        public string MVMjustificacion
        {
            get {   return mMVMjustificacion;  }
            set {   mMVMjustificacion = value; }
        }

         //Constructor vacío
        public DAcfMVMt_MotivoMovimiento()
        {
	    }
        //Constructor con parámetros

        public DAcfMVMt_MotivoMovimiento(
            string TMVid, 
            string MVMid, 
            string MVMmotivomovimiento, 
            string MVMjustificacion)
        {
        
		this.mTMVid = TMVid;
		this.mMVMid = MVMid;
		this.mMVMmotivomovimiento = MVMmotivomovimiento;
        this.mMVMjustificacion = MVMjustificacion;
	}

/*	public object Clone() {
//		return base.MemberwiseClone();
//	}
*/


        //METODO MOSTRAR 
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("acfMVMt_MotivoMovimiento");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfMVMt_MotivoMovimiento";
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
        public string Insertar(DAcfMVMt_MotivoMovimiento acfMVMt_MotivoMovimiento)
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
                SqlCmd.CommandText = "usp_I_acfMVMt_MotivoMovimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTMVid = new SqlParameter();
                ParTMVid.ParameterName = "@sTMVid";
                ParTMVid.SqlDbType = SqlDbType.Char;
                ParTMVid.Value = acfMVMt_MotivoMovimiento.TMVid;
                SqlCmd.Parameters.Add(ParTMVid);
                //
                SqlParameter PariMVMid = new SqlParameter();
                PariMVMid.ParameterName = "@sMVMid";
                PariMVMid.SqlDbType = SqlDbType.Char;
                PariMVMid.Value = acfMVMt_MotivoMovimiento.MVMid;
                SqlCmd.Parameters.Add(PariMVMid);
                //
                SqlParameter ParsMVMmotivomovimiento = new SqlParameter();
                ParsMVMmotivomovimiento.ParameterName = "@sMVMmotivomovimiento";
                ParsMVMmotivomovimiento.SqlDbType = SqlDbType.Char;
                ParsMVMmotivomovimiento.Value = acfMVMt_MotivoMovimiento.MVMmotivomovimiento;
                SqlCmd.Parameters.Add(ParsMVMmotivomovimiento);
                //
                SqlParameter ParsMVMjustificacion = new SqlParameter();
                ParsMVMjustificacion.ParameterName = "@iMVMjustificacion";
                ParsMVMjustificacion.SqlDbType = SqlDbType.SmallInt;
                ParsMVMjustificacion.Value = acfMVMt_MotivoMovimiento.MVMjustificacion;
                SqlCmd.Parameters.Add(ParsMVMjustificacion);
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
        public string Editar(DAcfMVMt_MotivoMovimiento acfMVMt_MotivoMovimiento)
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
                SqlCmd.CommandText = "usp_U_acfMVMt_MotivoMovimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTMVid = new SqlParameter();
                ParTMVid.ParameterName = "@sTMVid";
                ParTMVid.SqlDbType = SqlDbType.Char;
                ParTMVid.Value = acfMVMt_MotivoMovimiento.TMVid;
                SqlCmd.Parameters.Add(ParTMVid);
                //
                SqlParameter PariMVMid = new SqlParameter();
                PariMVMid.ParameterName = "@sMVMid";
                PariMVMid.SqlDbType = SqlDbType.Char;
                PariMVMid.Value = acfMVMt_MotivoMovimiento.MVMid;
                SqlCmd.Parameters.Add(PariMVMid);
                //
                SqlParameter ParsMVMmotivomovimiento = new SqlParameter();
                ParsMVMmotivomovimiento.ParameterName = "@sMVMmotivomovimiento";
                ParsMVMmotivomovimiento.SqlDbType = SqlDbType.Char;
                ParsMVMmotivomovimiento.Value = acfMVMt_MotivoMovimiento.MVMmotivomovimiento;
                SqlCmd.Parameters.Add(ParsMVMmotivomovimiento);
                //
                SqlParameter ParsMVMjustificacion = new SqlParameter();
                ParsMVMjustificacion.ParameterName = "@iMVMjustificacion";
                ParsMVMjustificacion.SqlDbType = SqlDbType.SmallInt;
                ParsMVMjustificacion.Value = acfMVMt_MotivoMovimiento.MVMjustificacion;
                SqlCmd.Parameters.Add(ParsMVMjustificacion);
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
        public string Eliminar(DAcfMVMt_MotivoMovimiento acfMVMt_MotivoMovimiento)
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
                SqlCmd.CommandText = "usp_D_acfMVMt_MotivoMovimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //
                SqlParameter PariMVMid = new SqlParameter();
                PariMVMid.ParameterName = "@sMVMid";
                PariMVMid.SqlDbType = SqlDbType.Char;
                PariMVMid.Value = acfMVMt_MotivoMovimiento.MVMid;
                SqlCmd.Parameters.Add(PariMVMid);               

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
        public DataTable Buscar(DAcfMVMt_MotivoMovimiento acfMVMt_MotivoMovimiento)
        {

            DataTable DtResultado = new DataTable("acfMVMt_MotivoMovimiento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_B_acfMVMt_MotivoMovimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                
                SqlParameter ParMVMmovimiento = new SqlParameter();
                ParMVMmovimiento.ParameterName = "@sMVMid";
                ParMVMmovimiento.SqlDbType = SqlDbType.Char;
                ParMVMmovimiento.Size = 50;
                ParMVMmovimiento.Value = acfMVMt_MotivoMovimiento.MVMid;
                SqlCmd.Parameters.Add(ParMVMmovimiento);

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
