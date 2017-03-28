using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DAcfMARt_Marca
    {

        private string mMARid;
        private string mMARmarca;


        public string MARid
        {
            get
            {
                return mMARid;
            }
            set
            {
                mMARid = value;
            }
        }
        public string MARmarca
        {
            get
            {
                return mMARmarca;
            }
            set
            {
                mMARmarca = value;
            }
        }


         //Constructor vacío
        public DAcfMARt_Marca()
        {
	}
         //Constructor con parámetros

        public DAcfMARt_Marca(string MARid, string MARmarca)
        {
        
		this.mMARid = MARid;
		this.mMARmarca = MARmarca;
        
	}

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("acfMARt_Marca");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfMARt_Marca";
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
        public string Insertar(DAcfMARt_Marca acfMARt_Marca)
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
                SqlCmd.CommandText = "usp_I_acfMARt_Marca";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParMARid = new SqlParameter();
                ParMARid.ParameterName = "@iMARid";
                ParMARid.SqlDbType = SqlDbType.Int;
                ParMARid.Value = acfMARt_Marca.MARid;
                SqlCmd.Parameters.Add(ParMARid);
                //
                SqlParameter ParsMARmarca = new SqlParameter();
                ParsMARmarca.ParameterName = "@sMARmarca";
                ParsMARmarca.SqlDbType = SqlDbType.VarChar;
                ParsMARmarca.Value = acfMARt_Marca.MARmarca;
                SqlCmd.Parameters.Add(ParsMARmarca);
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
        public string Editar(DAcfMARt_Marca acfMARt_Marca)
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
                SqlCmd.CommandText = "usp_U_acfMARt_Marca";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParMARid = new SqlParameter();
                ParMARid.ParameterName = "@iMARid";
                ParMARid.SqlDbType = SqlDbType.Int;
                ParMARid.Value = acfMARt_Marca.MARid;
                SqlCmd.Parameters.Add(ParMARid);
                //
                SqlParameter ParsMARmarca = new SqlParameter();
                ParsMARmarca.ParameterName = "@sMARmarca";
                ParsMARmarca.SqlDbType = SqlDbType.VarChar;
                ParsMARmarca.Value = acfMARt_Marca.MARmarca;
                SqlCmd.Parameters.Add(ParsMARmarca);
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

        public string Eliminar(DAcfMARt_Marca acfMARt_Marca)
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
                SqlCmd.CommandText = "usp_D_acfMARt_Marca";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                //
                SqlParameter ParMARid = new SqlParameter();
                ParMARid.ParameterName = "@iMARid";
                ParMARid.SqlDbType = SqlDbType.Int;
                ParMARid.Value = acfMARt_Marca.MARid;
                SqlCmd.Parameters.Add(ParMARid);
               


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

        public DataTable Buscar(DAcfMARt_Marca acfMARt_Marca)
        {

            DataTable DtResultado = new DataTable("acfMARt_Marca");
            SqlConnection SqlCon = new SqlConnection();


            try
            {

                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_B_acfMARt_Marca";
                SqlCmd.CommandType = CommandType.StoredProcedure;



                SqlParameter ParMARmarcas = new SqlParameter();
                ParMARmarcas.ParameterName = "@iMARid";
                ParMARmarcas.SqlDbType = SqlDbType.Char;
                ParMARmarcas.Size = 50;
                ParMARmarcas.Value = acfMARt_Marca.MARid;
                SqlCmd.Parameters.Add(ParMARmarcas);

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
