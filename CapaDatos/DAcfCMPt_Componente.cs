using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DAcfCMPt_Componente
    {
        private string mCMPid;
        private string mCMPcomponente;
        private string mCMPusoestimado;
        private string mCMPconservacion;
        private string mCMPobsolecencia;
        private string mCMPlimitelegal;
        private string mCMPtotalfactores;
        private string mCMPfactorusoestimado;
        private string mCMPvutilanio;
        private string mCMPvutildia;

        public string CMPid
        {
            get
            {
                return mCMPid;
            }
            set
            {
                mCMPid = value;
            }
        }

        public string CMPcomponente
        {
            get
            {
                return mCMPcomponente;
            }
            set
            {
                mCMPcomponente = value;
            }
        }

        public string CMPusoestimado
        {
            get
            {
                return mCMPusoestimado;
            }
            set
            {
                mCMPusoestimado = value;
            }
        }

        public string CMPconservacion
        {
            get
            {
                return mCMPconservacion;
            }
            set
            {
                mCMPconservacion = value;
            }
        }
        public string CMPobsolecencia
        {
            get
            {
                return mCMPobsolecencia;
            }
            set
            {
                mCMPobsolecencia = value;
            }
        }

        public string CMPlimitelegal
        {
            get
            {
                return mCMPlimitelegal;
            }
            set
            {
                mCMPlimitelegal = value;
            }
        }
        public string CMPtotalfactores
        {
            get
            {
                return mCMPtotalfactores;
            }
            set
            {
                mCMPtotalfactores = value;
            }
        }

        public string CMPfactorusoestimado
        {
            get
            {
                return mCMPfactorusoestimado;
            }
            set
            {
                mCMPfactorusoestimado = value;
            }
        }

        public string CMPvutilanio
        {
            get
            {
                return mCMPvutilanio;
            }
            set
            {
                mCMPvutilanio = value;
            }
        }

        public string CMPvutildia
        {
            get
            {
                return mCMPvutildia;
            }
            set
            {
                mCMPvutildia = value;
            }
        }


         //Constructor vacío
        public DAcfCMPt_Componente()
        {
	}

         //Constructor con parámetros

        public DAcfCMPt_Componente(string CMPid, string CMPcomponente,string CMPusoestimado, string CMPconservacion, string CMPobsolecencia, string CMPlimitelegal, string CMPtotalfactores, string CMPfactorusoestimado, string CMPvutilanio, string CMPvutildia)
        {
        
		this.mCMPid = CMPid;
		this.mCMPcomponente = CMPcomponente;
        this.mCMPusoestimado = CMPusoestimado;
        this.mCMPconservacion = CMPconservacion;
        this.mCMPobsolecencia = CMPobsolecencia;
        this.mCMPlimitelegal = CMPlimitelegal;
        this.mCMPtotalfactores = CMPtotalfactores;
        this.mCMPfactorusoestimado = CMPfactorusoestimado;
        this.mCMPvutilanio = CMPvutilanio;
        this.mCMPvutildia = CMPvutildia;
	
	}

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("acfCMPt_Componente");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfCMPt_Componente";
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


        // barra de navegacion
        public DataTable Top()
        {

            DataTable DtResultado = new DataTable("acfCMPt_Componente");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_T_acfCMPt_Componente";
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

        public DataTable Prev(String ACFid)
        {
            DataTable DtResultado = new DataTable("acfCMPt_Componente");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_P_acfCMPt_Componente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCMPcomponente = new SqlParameter();
                ParCMPcomponente.ParameterName = "@sCMPid";
                ParCMPcomponente.SqlDbType = SqlDbType.Char;
                ParCMPcomponente.Size = 50;
                ParCMPcomponente.Value = CMPid;
                SqlCmd.Parameters.Add(ParCMPcomponente);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable Next(String ACFid)
        {
            DataTable DtResultado = new DataTable("acfCMPt_Componente");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_N_acfCMPt_Componente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCMPcomponente = new SqlParameter();
                ParCMPcomponente.ParameterName = "@sCMPid";
                ParCMPcomponente.SqlDbType = SqlDbType.Char;
                ParCMPcomponente.Size = 50;
                ParCMPcomponente.Value = CMPid;
                SqlCmd.Parameters.Add(ParCMPcomponente);


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
            DataTable DtResultado = new DataTable("acfCMPt_Componente");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_L_acfCMPt_Componente";
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
        public string Insertar(DAcfCMPt_Componente acfCMPt_Componente)
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
                SqlCmd.CommandText = "usp_I_acfCMPt_Componente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCMPid = new SqlParameter();
                ParCMPid.ParameterName = "@sCMPid";
                ParCMPid.SqlDbType = SqlDbType.Char;
                ParCMPid.Value = acfCMPt_Componente.CMPid;
                SqlCmd.Parameters.Add(ParCMPid);
                //
                SqlParameter PariCMPcomponente = new SqlParameter();
                PariCMPcomponente.ParameterName = "@sCMPcomponente";
                PariCMPcomponente.SqlDbType = SqlDbType.VarChar;
                PariCMPcomponente.Value = acfCMPt_Componente.CMPcomponente;
                SqlCmd.Parameters.Add(PariCMPcomponente);
                //
                SqlParameter PardCMPusoestimado = new SqlParameter();
                PardCMPusoestimado.ParameterName = "@decCMPusoestimado";
                PardCMPusoestimado.SqlDbType = SqlDbType.Decimal;
                PardCMPusoestimado.Value = acfCMPt_Componente.CMPusoestimado;
                SqlCmd.Parameters.Add(PardCMPusoestimado);
                //
                SqlParameter PardCMPconservacion = new SqlParameter();
                PardCMPconservacion.ParameterName = "@decCMPconservacion";
                PardCMPconservacion.SqlDbType = SqlDbType.Decimal;
                PardCMPconservacion.Value = acfCMPt_Componente.CMPconservacion;
                SqlCmd.Parameters.Add(PardCMPconservacion);
                //
                SqlParameter PardCMPobsolecencia = new SqlParameter();
                PardCMPobsolecencia.ParameterName = "@decCMPobsolecencia";
                PardCMPobsolecencia.SqlDbType = SqlDbType.Decimal;
                PardCMPobsolecencia.Value = acfCMPt_Componente.CMPobsolecencia;
                SqlCmd.Parameters.Add(PardCMPobsolecencia);
                //
                SqlParameter PardCMPlimitelegal = new SqlParameter();
                PardCMPlimitelegal.ParameterName = "@decCMPlimitelegal";
                PardCMPlimitelegal.SqlDbType = SqlDbType.Decimal;
                PardCMPlimitelegal.Value = acfCMPt_Componente.CMPlimitelegal;
                SqlCmd.Parameters.Add(PardCMPlimitelegal);
                //
                SqlParameter PardCMPtotalfactores = new SqlParameter();
                PardCMPtotalfactores.ParameterName = "@decCMPtotalfactores";
                PardCMPtotalfactores.SqlDbType = SqlDbType.Decimal;
                PardCMPtotalfactores.Value = acfCMPt_Componente.CMPtotalfactores;
                SqlCmd.Parameters.Add(PardCMPtotalfactores);
                //
                SqlParameter PardCMPfactorusoestimado = new SqlParameter();
                PardCMPfactorusoestimado.ParameterName = "@decCMPfactorusoestimado";
                PardCMPfactorusoestimado.SqlDbType = SqlDbType.Decimal;
                PardCMPfactorusoestimado.Value = acfCMPt_Componente.CMPfactorusoestimado;
                SqlCmd.Parameters.Add(PardCMPfactorusoestimado);
                //
                SqlParameter PariCMPvutilanio = new SqlParameter();
                PariCMPvutilanio.ParameterName = "@iCMPvutilanio";
                PariCMPvutilanio.SqlDbType = SqlDbType.Int;
                PariCMPvutilanio.Value = acfCMPt_Componente.CMPvutilanio;
                SqlCmd.Parameters.Add(PariCMPvutilanio);
                //
                SqlParameter PariCMPvutildia = new SqlParameter();
                PariCMPvutildia.ParameterName = "@iCMPvutildia";
                PariCMPvutildia.SqlDbType = SqlDbType.Int;
                PariCMPvutildia.Value = acfCMPt_Componente.CMPvutildia;
                SqlCmd.Parameters.Add(PariCMPvutildia);
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
        public string Editar(DAcfCMPt_Componente acfCMPt_Componente)
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
                SqlCmd.CommandText = "usp_U_acfCMPt_Componente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCMPid = new SqlParameter();
                ParCMPid.ParameterName = "@sCMPid";
                ParCMPid.SqlDbType = SqlDbType.Char;
                ParCMPid.Value = acfCMPt_Componente.CMPid;
                SqlCmd.Parameters.Add(ParCMPid);
                //
                SqlParameter PariCMPcomponente = new SqlParameter();
                PariCMPcomponente.ParameterName = "@sCMPcomponente";
                PariCMPcomponente.SqlDbType = SqlDbType.VarChar;
                PariCMPcomponente.Value = acfCMPt_Componente.CMPcomponente;
                SqlCmd.Parameters.Add(PariCMPcomponente);
                //
                SqlParameter PardCMPusoestimado = new SqlParameter();
                PardCMPusoestimado.ParameterName = "@decCMPusoestimado";
                PardCMPusoestimado.SqlDbType = SqlDbType.Decimal;
                PardCMPusoestimado.Value = acfCMPt_Componente.CMPusoestimado;
                SqlCmd.Parameters.Add(PardCMPusoestimado);
                //
                SqlParameter PardCMPconservacion = new SqlParameter();
                PardCMPconservacion.ParameterName = "@decCMPconservacion";
                PardCMPconservacion.SqlDbType = SqlDbType.Decimal;
                PardCMPconservacion.Value = acfCMPt_Componente.CMPconservacion;
                SqlCmd.Parameters.Add(PardCMPconservacion);
                //
                SqlParameter PardCMPobsolecencia = new SqlParameter();
                PardCMPobsolecencia.ParameterName = "@decCMPobsolecencia";
                PardCMPobsolecencia.SqlDbType = SqlDbType.Decimal;
                PardCMPobsolecencia.Value = acfCMPt_Componente.CMPobsolecencia;
                SqlCmd.Parameters.Add(PardCMPobsolecencia);
                //
                SqlParameter PardCMPlimitelegal = new SqlParameter();
                PardCMPlimitelegal.ParameterName = "@decCMPlimitelegal";
                PardCMPlimitelegal.SqlDbType = SqlDbType.Decimal;
                PardCMPlimitelegal.Value = acfCMPt_Componente.CMPlimitelegal;
                SqlCmd.Parameters.Add(PardCMPlimitelegal);
                //
                SqlParameter PardCMPtotalfactores = new SqlParameter();
                PardCMPtotalfactores.ParameterName = "@decCMPtotalfactores";
                PardCMPtotalfactores.SqlDbType = SqlDbType.Decimal;
                PardCMPtotalfactores.Value = acfCMPt_Componente.CMPtotalfactores;
                SqlCmd.Parameters.Add(PardCMPtotalfactores);
                //
                SqlParameter PardCMPfactorusoestimado = new SqlParameter();
                PardCMPfactorusoestimado.ParameterName = "@decCMPfactorusoestimado";
                PardCMPfactorusoestimado.SqlDbType = SqlDbType.Decimal;
                PardCMPfactorusoestimado.Value = acfCMPt_Componente.CMPfactorusoestimado;
                SqlCmd.Parameters.Add(PardCMPfactorusoestimado);
                //
                SqlParameter PariCMPvutilanio = new SqlParameter();
                PariCMPvutilanio.ParameterName = "@iCMPvutilanio";
                PariCMPvutilanio.SqlDbType = SqlDbType.Int;
                PariCMPvutilanio.Value = acfCMPt_Componente.CMPvutilanio;
                SqlCmd.Parameters.Add(PariCMPvutilanio);
                //
                SqlParameter PariCMPvutildia = new SqlParameter();
                PariCMPvutildia.ParameterName = "@iCMPvutildia";
                PariCMPvutildia.SqlDbType = SqlDbType.Int;
                PariCMPvutildia.Value = acfCMPt_Componente.CMPvutildia;
                SqlCmd.Parameters.Add(PariCMPvutildia);
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
        public string Eliminar(DAcfCMPt_Componente acfCMPt_Componente)
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
                SqlCmd.CommandText = "usp_D_acfCMPt_Componente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //
                SqlParameter ParCMPid = new SqlParameter();
                ParCMPid.ParameterName = "@sCMPid";
                ParCMPid.SqlDbType = SqlDbType.Char;
                ParCMPid.Value = acfCMPt_Componente.CMPid;
                SqlCmd.Parameters.Add(ParCMPid);


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

        public DataTable Buscar(DAcfCMPt_Componente acfCMPt_Componente)
        {

            DataTable DtResultado = new DataTable("acfCMPt_Componente");
            SqlConnection SqlCon = new SqlConnection();


            try
            {

                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_B_acfCMPt_Componente";
                SqlCmd.CommandType = CommandType.StoredProcedure;



                SqlParameter ParCMPcomponente = new SqlParameter();
                ParCMPcomponente.ParameterName = "@sCMPid";
                ParCMPcomponente.SqlDbType = SqlDbType.Char;
                ParCMPcomponente.Size = 50;
                ParCMPcomponente.Value = acfCMPt_Componente.CMPid;
                SqlCmd.Parameters.Add(ParCMPcomponente);

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
