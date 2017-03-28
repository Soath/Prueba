using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DbdiPRVpProveedor
    {

        private string sLIFNR;
        private string sName1;
        private string sStras;
        private string sSTCD1;

        public string LIFNR
        {
            get {   return sLIFNR;  }
            set {   sLIFNR = value; }
        }

        public string Name1
        {
            get {   return sName1;  }
            set {   sName1 = value; }
        }

        public string Stras
        {
            get {   return sStras ;  }
            set {   sStras = value;  }
        }

        public string STCD1
        {
            get {   return sSTCD1;  }
            set {   sSTCD1 = value; }
        }

         //Constructor vacío
        public DbdiPRVpProveedor()
        {
	    }
        //Constructor con parámetros

        public DbdiPRVpProveedor(
            string LIFNR, 
            string Name1, 
            string Stras, 
            string STCD1)
        {
        
		this.LIFNR = sLIFNR;
		this.Name1 = sName1;
		this.Stras = sStras;
        this.STCD1 = sSTCD1;
	}

/*	public object Clone() {
//		return base.MemberwiseClone();
//	}
*/
        //METODO MOSTRAR 
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("bdiPRVpProveedor");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_bdiPRVpProveedor";
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
        public string Insertar(DbdiPRVpProveedor bdiPRVpProveedor)
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
                SqlCmd.CommandText = "usp_I_bdiPRVpProveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParLIFNR = new SqlParameter();
                ParLIFNR.ParameterName = "@sLIFNR";
                ParLIFNR.SqlDbType = SqlDbType.Char;
                ParLIFNR.Value = bdiPRVpProveedor.LIFNR;
                SqlCmd.Parameters.Add(ParLIFNR);
                //
                SqlParameter PariName1 = new SqlParameter();
                PariName1.ParameterName = "@sName1";
                PariName1.SqlDbType = SqlDbType.Char;
                PariName1.Value = bdiPRVpProveedor.Name1;
                SqlCmd.Parameters.Add(PariName1);
                //
                SqlParameter ParsStras = new SqlParameter();
                ParsStras.ParameterName = "@sStras";
                ParsStras.SqlDbType = SqlDbType.Char;
                ParsStras.Value = bdiPRVpProveedor.Stras;
                SqlCmd.Parameters.Add(ParsStras);
                //
                SqlParameter ParsSTCD1 = new SqlParameter();
                ParsSTCD1.ParameterName = "@sSTCD1";
                ParsSTCD1.SqlDbType = SqlDbType.Char;
                ParsSTCD1.Value = bdiPRVpProveedor.STCD1;
                SqlCmd.Parameters.Add(ParsSTCD1);
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
        public string Editar(DbdiPRVpProveedor bdiPRVpProveedor)
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
                SqlCmd.CommandText = "usp_U_bdiPRVpProveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParLIFNR = new SqlParameter();
                ParLIFNR.ParameterName = "@sLIFNR";
                ParLIFNR.SqlDbType = SqlDbType.Char;
                ParLIFNR.Value = bdiPRVpProveedor.LIFNR;
                SqlCmd.Parameters.Add(ParLIFNR);
                //
                SqlParameter PariName1 = new SqlParameter();
                PariName1.ParameterName = "@sName1";
                PariName1.SqlDbType = SqlDbType.Char;
                PariName1.Value = bdiPRVpProveedor.Name1;
                SqlCmd.Parameters.Add(PariName1);
                //
                SqlParameter ParsStras = new SqlParameter();
                ParsStras.ParameterName = "@sStras";
                ParsStras.SqlDbType = SqlDbType.Char;
                ParsStras.Value = bdiPRVpProveedor.Stras;
                SqlCmd.Parameters.Add(ParsStras);
                //
                SqlParameter ParsSTCD1 = new SqlParameter();
                ParsSTCD1.ParameterName = "@sSTCD1";
                ParsSTCD1.SqlDbType = SqlDbType.Char;
                ParsSTCD1.Value = bdiPRVpProveedor.STCD1;
                SqlCmd.Parameters.Add(ParsSTCD1);
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
        public string Eliminar(DbdiPRVpProveedor bdiPRVpProveedor)
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
                SqlCmd.CommandText = "usp_D_bdiPRVpProveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //
                SqlParameter ParLIFNR = new SqlParameter();
                ParLIFNR.ParameterName = "@sLIFNR";
                ParLIFNR.SqlDbType = SqlDbType.Char;
                ParLIFNR.Value = bdiPRVpProveedor.LIFNR;
                SqlCmd.Parameters.Add(ParLIFNR);              
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
        public DataTable Buscar(DbdiPRVpProveedor bdiPRVpProveedor)
        {
            DataTable DtResultado = new DataTable("bdiPRVpProveedor");
            SqlConnection SqlCon = new SqlConnection();            
            try
            {

                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_B_bdiPRVpProveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;



                SqlParameter ParName1 = new SqlParameter();
                ParName1.ParameterName = "@sName1";
                ParName1.SqlDbType = SqlDbType.Char;
                ParName1.Size = 50;
                ParName1.Value = bdiPRVpProveedor.Name1;
                SqlCmd.Parameters.Add(ParName1);

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
