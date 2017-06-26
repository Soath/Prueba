using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class D_PRMVAR
    {
        private string mGRPid;
        private string mGRPid_variable;
        private string mPRM_descripcion;
        private string mPRM_valor;
        private string mPRM_estado;
        private string mPRM_frmnombre;
                       

        public string GRPid
        {
            get
            {
                return mGRPid;
            }
            set
            {
                mGRPid = value;
            }
        }

        public string GRPid_variable
        {
            get
            {
                return mGRPid_variable;
            }
            set
            {
                mGRPid_variable = value;
            }
        }
       public string PRM_descripcion
        {
            get
            {
                return mPRM_descripcion;
            }
            set
            {
                mPRM_descripcion = value;
            }
        }
            public string PRM_valor
        {
            get
            {
                return mPRM_valor;
            }
            set
            {
                mPRM_valor = value;
            }
        }
        public string PRM_estado
        {
            get
            {
                return mPRM_estado;
            }
            set
            {
                mPRM_estado = value;
            }
        }
        public string PRM_frmnombre
        {
            get
            {
                return mPRM_frmnombre;
            }
            set
            {
                mPRM_frmnombre = value;
            }
        }


        //Constructor vacío
        public D_PRMVAR()
        {
        }

        //Constructor con parámetros

        public D_PRMVAR(

            string GRPid,
            string GRPid_variable,
            string PRM_descripcion,
            string PRM_valor,
            string PRM_estado,
            string PRM_frmnombre
            )
        {

            this.mGRPid                = GRPid              ;
            this.mGRPid_variable       = GRPid_variable     ;
            this.mPRM_descripcion      = PRM_descripcion    ;
            this.mPRM_valor            = PRM_valor          ;
            this.mPRM_estado           = PRM_estado         ;
            this.mPRM_frmnombre = PRM_frmnombre;


        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("PRMVAR");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_PRMVAR";
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
        public string Insertar(D_PRMVAR PRMVAR)
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
                SqlCmd.CommandText = "usp_I_PRMVAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                
                SqlParameter ParGRPid_variable = new SqlParameter();
                ParGRPid_variable.ParameterName = "@GRPid_variable";
                ParGRPid_variable.SqlDbType = SqlDbType.VarChar;
                ParGRPid_variable.Value = PRMVAR.GRPid_variable;
                SqlCmd.Parameters.Add(ParGRPid_variable);
                //
                SqlParameter ParPRM_descripcion = new SqlParameter();
                ParPRM_descripcion.ParameterName = "@PRM_descripcion";
                ParPRM_descripcion.SqlDbType = SqlDbType.VarChar;
                ParPRM_descripcion.Value = PRMVAR.PRM_descripcion;
                SqlCmd.Parameters.Add(ParPRM_descripcion);
                //
                SqlParameter ParPRM_valor = new SqlParameter();
                ParPRM_valor.ParameterName = "@PRM_valor";
                ParPRM_valor.SqlDbType = SqlDbType.VarChar;
                ParPRM_valor.Value = PRMVAR.PRM_valor;
                SqlCmd.Parameters.Add(ParPRM_valor);
                //
                SqlParameter ParPRM_estado = new SqlParameter();
                ParPRM_estado.ParameterName = "@PRM_estado";
                ParPRM_estado.SqlDbType = SqlDbType.Char;
                ParPRM_estado.Value = PRMVAR.PRM_estado;
                SqlCmd.Parameters.Add(ParPRM_estado);
                //
                SqlParameter ParPRM_frmnombre = new SqlParameter();
                ParPRM_frmnombre.ParameterName = "@PRM_frmnombre";
                ParPRM_frmnombre.SqlDbType = SqlDbType.VarChar;
                ParPRM_frmnombre.Value = PRMVAR.PRM_frmnombre;
                SqlCmd.Parameters.Add(ParPRM_frmnombre);

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
        public string Editar(D_PRMVAR PRMVAR)
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
                SqlCmd.CommandText = "usp_U_PRMVAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPRMVAR = new SqlParameter();
                ParPRMVAR.ParameterName = "@GRPid";
                ParPRMVAR.SqlDbType = SqlDbType.Int;
                ParPRMVAR.Value = PRMVAR.GRPid;
                SqlCmd.Parameters.Add(ParPRMVAR);
                //
                SqlParameter ParGRPid_variable = new SqlParameter();
                ParGRPid_variable.ParameterName = "@GRPid_variable";
                ParGRPid_variable.SqlDbType = SqlDbType.VarChar;
                ParGRPid_variable.Value = PRMVAR.GRPid_variable;
                SqlCmd.Parameters.Add(ParGRPid_variable);
                //
                SqlParameter ParPRM_descripcion = new SqlParameter();
                ParPRM_descripcion.ParameterName = "@PRM_descripcion";
                ParPRM_descripcion.SqlDbType = SqlDbType.VarChar;
                ParPRM_descripcion.Value = PRMVAR.PRM_descripcion;
                SqlCmd.Parameters.Add(ParPRM_descripcion);
                //
                SqlParameter ParPRM_valor = new SqlParameter();
                ParPRM_valor.ParameterName = "@PRM_valor";
                ParPRM_valor.SqlDbType = SqlDbType.VarChar;
                ParPRM_valor.Value = PRMVAR.PRM_valor;
                SqlCmd.Parameters.Add(ParPRM_valor);
                //
                SqlParameter ParPRM_estado = new SqlParameter();
                ParPRM_estado.ParameterName = "@PRM_estado";
                ParPRM_estado.SqlDbType = SqlDbType.Char;
                ParPRM_estado.Value = PRMVAR.PRM_estado;
                SqlCmd.Parameters.Add(ParPRM_estado);
                //
                SqlParameter ParPRM_frmnombre = new SqlParameter();
                ParPRM_frmnombre.ParameterName = "@PRM_frmnombre";
                ParPRM_frmnombre.SqlDbType = SqlDbType.VarChar;
                ParPRM_frmnombre.Value = PRMVAR.PRM_frmnombre;
                SqlCmd.Parameters.Add(ParPRM_frmnombre);

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
        public string Eliminar(D_PRMVAR PRMVAR )
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
                SqlCmd.CommandText = "usp_D_PRMVAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //
                SqlParameter ParPRMVAR = new SqlParameter();
                ParPRMVAR.ParameterName = "@GRPid";
                ParPRMVAR.SqlDbType = SqlDbType.Int;
                ParPRMVAR.Value = PRMVAR.GRPid;
                SqlCmd.Parameters.Add(ParPRMVAR);

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

        public DataTable Buscar(D_PRMVAR PRMVAR)
        {

            DataTable DtResultado = new DataTable("PRMVAR");
            SqlConnection SqlCon = new SqlConnection();


            try
            {

                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_B_PRMVAR";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParPRMVAR = new SqlParameter();
                ParPRMVAR.ParameterName = "@GRPid";
                ParPRMVAR.SqlDbType = SqlDbType.Int;
                ParPRMVAR.Value = PRMVAR.GRPid;
                SqlCmd.Parameters.Add(ParPRMVAR);

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
