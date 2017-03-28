using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DAcfVNRt_VNR
    {

        private string mVNRid;
        private string mVNRvnr;
        private string mVNRcuenta;
        private string mVNRcuentadep;

        public string VNRid
        {
            get
            {
                return mVNRid;
            }
            set
            {
                mVNRid = value;
            }
        }
        public string VNRvnr
        {
            get
            {
                return mVNRvnr;
            }
            set
            {
                mVNRvnr = value;
            }
        }
        public string VNRcuenta
        {
            get
            {
                return mVNRcuenta;
            }
            set
            {
                mVNRcuenta = value;
            }
        }
        public string VNRcuentadep
        {
            get
            {
                return mVNRcuentadep;
            }
            set
            {
                mVNRcuentadep = value;
            }
        }




         //Constructor vacío
        public DAcfVNRt_VNR()
        {


	}

        //Constructor con parámetros

        public DAcfVNRt_VNR(string VNRid, string VNRvnr, string VNRcuenta, string VNRcuentadep)
        {
        
		this.mVNRid = VNRid;
		this.mVNRvnr = VNRvnr;
        this.mVNRcuenta = VNRcuenta;
        this.mVNRcuentadep = VNRcuentadep;
	
	}

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("acfVNRt_VNR");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfVNRt_VNR";
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
        public string Insertar(DAcfVNRt_VNR acfVNRt_VNR)
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
                SqlCmd.CommandText = "usp_I_acfVNRt_VNR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParsVNRid = new SqlParameter();
                ParsVNRid.ParameterName = "@sVNRid";
                ParsVNRid.SqlDbType = SqlDbType.Char;
                ParsVNRid.Value = acfVNRt_VNR.VNRid;
                SqlCmd.Parameters.Add(ParsVNRid);
                //
                SqlParameter ParsVNRvnr = new SqlParameter();
                ParsVNRvnr.ParameterName = "@sVNRvnr";
                ParsVNRvnr.SqlDbType = SqlDbType.Char;
                ParsVNRvnr.Value = acfVNRt_VNR.VNRvnr;
                SqlCmd.Parameters.Add(ParsVNRvnr);
                //
                SqlParameter ParsVNRcuenta = new SqlParameter();
                ParsVNRcuenta.ParameterName = "@sVNRcuenta";
                ParsVNRcuenta.SqlDbType = SqlDbType.Char;
                ParsVNRcuenta.Value = acfVNRt_VNR.VNRcuenta;
                SqlCmd.Parameters.Add(ParsVNRcuenta);
                //
                SqlParameter ParsVNRcuentadep = new SqlParameter();
                ParsVNRcuentadep.ParameterName = "@sVNRcuentadep";
                ParsVNRcuentadep.SqlDbType = SqlDbType.Char;
                ParsVNRcuentadep.Value = acfVNRt_VNR.VNRcuentadep;
                SqlCmd.Parameters.Add(ParsVNRcuentadep);
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
        public string Editar(DAcfVNRt_VNR acfVNRt_VNR)
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
                SqlCmd.CommandText = "usp_U_acfVNRt_VNR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParsVNRid = new SqlParameter();
                ParsVNRid.ParameterName = "@sVNRid";
                ParsVNRid.SqlDbType = SqlDbType.Char;
                ParsVNRid.Value = acfVNRt_VNR.VNRid;
                SqlCmd.Parameters.Add(ParsVNRid);
                //
                SqlParameter ParsVNRvnr = new SqlParameter();
                ParsVNRvnr.ParameterName = "@sVNRvnr";
                ParsVNRvnr.SqlDbType = SqlDbType.Char;
                ParsVNRvnr.Value = acfVNRt_VNR.VNRvnr;
                SqlCmd.Parameters.Add(ParsVNRvnr);
                //
                SqlParameter ParsVNRcuenta = new SqlParameter();
                ParsVNRcuenta.ParameterName = "@sVNRcuenta";
                ParsVNRcuenta.SqlDbType = SqlDbType.Char;
                ParsVNRcuenta.Value = acfVNRt_VNR.VNRcuenta;
                SqlCmd.Parameters.Add(ParsVNRcuenta);
                //
                SqlParameter ParsVNRcuentadep = new SqlParameter();
                ParsVNRcuentadep.ParameterName = "@sVNRcuentadep";
                ParsVNRcuentadep.SqlDbType = SqlDbType.Char;
                ParsVNRcuentadep.Value = acfVNRt_VNR.VNRcuentadep;
                SqlCmd.Parameters.Add(ParsVNRcuentadep);
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
        public string Eliminar(DAcfVNRt_VNR acfVNRt_VNR)
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
                SqlCmd.CommandText = "usp_D_acfVNRt_VNR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //
                SqlParameter ParsVNRid = new SqlParameter();
                ParsVNRid.ParameterName = "@sVNRid";
                ParsVNRid.SqlDbType = SqlDbType.Char;
                ParsVNRid.Value = acfVNRt_VNR.VNRid;
                SqlCmd.Parameters.Add(ParsVNRid);


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

        public DataTable Buscar(DAcfVNRt_VNR acfVNRt_VNR)
        {

            DataTable DtResultado = new DataTable("acfVNRt_VNR");
            SqlConnection SqlCon = new SqlConnection();


            try
            {

                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_B_acfVNRt_VNR";
                SqlCmd.CommandType = CommandType.StoredProcedure;



                SqlParameter ParVNRvnr = new SqlParameter();
                ParVNRvnr.ParameterName = "@sVNRid";
                ParVNRvnr.SqlDbType = SqlDbType.Char;
                ParVNRvnr.Size = 50;
                ParVNRvnr.Value = acfVNRt_VNR.VNRid;
                SqlCmd.Parameters.Add(ParVNRvnr);

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
