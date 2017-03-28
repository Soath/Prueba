using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DAcfACTt_Actividad
    {
        private string mACTid;
        private string mACTactividad;

        public string ACTid
        {
            get
            {
                return mACTid;
            }
            set
            {
                mACTid = value;
            }
        }

        public string ACTactividad
        {
            get
            {
                return mACTactividad;
            }
            set
            {
                mACTactividad = value;
            }
        }

        //Constructor vacío
        public DAcfACTt_Actividad()
        {
	}

        //Constructor con parámetros

        public DAcfACTt_Actividad(string ACTid, string ACTactividad)
        {
        
		this.mACTid = ACTid;
		this.mACTactividad = ACTactividad;
	
	}

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("acfACTt_Actividad");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfACTt_Actividad";
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
        public string Insertar(DAcfACTt_Actividad acfACTt_Actividad)
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
                SqlCmd.CommandText = "usp_I_acfACTt_Actividad";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParACTid = new SqlParameter();
                ParACTid.ParameterName = "@sACTid";
                ParACTid.SqlDbType = SqlDbType.Char;
                ParACTid.Value = acfACTt_Actividad.ACTid;
                SqlCmd.Parameters.Add(ParACTid);
                //
                SqlParameter PariACTactividad = new SqlParameter();
                PariACTactividad.ParameterName = "@sACTactividad";
                PariACTactividad.SqlDbType = SqlDbType.VarChar;
                PariACTactividad.Value = acfACTt_Actividad.ACTactividad;
                SqlCmd.Parameters.Add(PariACTactividad);
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
        public string Editar(DAcfACTt_Actividad acfACTt_Actividad)
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
                SqlCmd.CommandText = "usp_U_acfACTt_Actividad";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParACTid = new SqlParameter();
                ParACTid.ParameterName = "@sACTid";
                ParACTid.SqlDbType = SqlDbType.Char;
                ParACTid.Value = acfACTt_Actividad.ACTid;
                SqlCmd.Parameters.Add(ParACTid);
                //
                SqlParameter PariACTactividad = new SqlParameter();
                PariACTactividad.ParameterName = "@sACTactividad";
                PariACTactividad.SqlDbType = SqlDbType.VarChar;
                PariACTactividad.Value = acfACTt_Actividad.ACTactividad;
                SqlCmd.Parameters.Add(PariACTactividad);
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
        public string Eliminar(DAcfACTt_Actividad acfACTt_Actividad)
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
                SqlCmd.CommandText = "usp_D_acfACTt_Actividad";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //
                SqlParameter ParACTid = new SqlParameter();
                ParACTid.ParameterName = "@sACTid";
                ParACTid.SqlDbType = SqlDbType.Char;
                ParACTid.Value = acfACTt_Actividad.ACTid;
                SqlCmd.Parameters.Add(ParACTid);


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

        public DataTable Buscar(DAcfACTt_Actividad acfACTt_Actividad)
        {

            DataTable DtResultado = new DataTable("acfACTt_Actividad");
            SqlConnection SqlCon = new SqlConnection();


            try
            {

                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_B_acfACTt_Actividad";
                SqlCmd.CommandType = CommandType.StoredProcedure;



                SqlParameter ParACTactividad = new SqlParameter();
                ParACTactividad.ParameterName = "@sACTid";
                ParACTactividad.SqlDbType = SqlDbType.Char;
                ParACTactividad.Size = 50;
                ParACTactividad.Value = acfACTt_Actividad.ACTid;
                SqlCmd.Parameters.Add(ParACTactividad);

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
