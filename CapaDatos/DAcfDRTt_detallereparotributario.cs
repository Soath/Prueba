using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DAcfDRTt_detallereparotributario
    {

        private string mRTRcodigo;
        private string mACFcuenta;
        private string mINVZU;
        private string mTXT50;
        private string mACFfactorniif;
        private string mACFvutilniif;
        private string mACFfactorTrib;
        private string mACFvutiltrib;
        private string mACFvalorniif;
        private string mACFdepAcuniif;
        private string mACFNiifNeto;
        private string mACFDepNiifPer;
        private string mACFvalortrib;
        private string mACFdepacutrib;
        private string mACFlirneto;
        private string mACFdeptlirper;
        private string mACFadiciones;
        private string mACFdeducciones;
        private string mACFneto;

        public string RTRcodigo
        {
            get { return mRTRcodigo; }
            set { mRTRcodigo = value; }
        }
        public string ACFcuenta
        {
            get { return mACFcuenta; }
            set { mACFcuenta = value; }
        }
        public string INVZU
        {
            get { return mINVZU; }
            set { mINVZU = value; }
        }
        public string TXT50
        {
            get { return mTXT50; }
            set { mTXT50 = value; }
        }
        public string ACFfactorniif
        {
            get { return mACFfactorniif; }
            set { mACFfactorniif = value; }
        }
        public string ACFvutilniif
        {
            get { return mACFvutilniif; }
            set { mACFvutilniif = value; }
        }
        public string ACFfactorTrib
        {
            get { return mACFfactorTrib; }
            set { mACFfactorTrib = value; }
        }
        public string ACFvutiltrib
        {
            get { return mACFvutiltrib; }
            set { mACFvutiltrib = value; }
        }
        public string ACFvalorniif
        {
            get { return mACFvalorniif; }
            set { mACFvalorniif = value; }
        }
        public string ACFdepAcuniif
        {
            get { return mACFdepAcuniif; }
            set { mACFdepAcuniif = value; }
        }
        public string ACFNiifNeto
        {
            get { return mACFNiifNeto; }
            set { mACFNiifNeto = value; }
        }
        public string ACFDepNiifPer
        {
            get { return mACFDepNiifPer; }
            set { mACFDepNiifPer = value; }
        }
        public string ACFvalortrib
        {
            get { return mACFvalortrib; }
            set { mACFvalortrib = value; }
        }
        public string ACFdepacutrib
        {
            get { return mACFdepacutrib; }
            set { mACFdepacutrib = value; }
        }
        public string ACFlirneto
        {
            get { return mACFlirneto; }
            set { mACFlirneto = value; }
        }
        public string ACFdeptlirper
        {
            get { return mACFdeptlirper; }
            set { mACFdeptlirper = value; }
        }
        public string ACFadiciones
        {
            get { return mACFadiciones; }
            set { mACFadiciones = value; }
        }
        public string ACFdeducciones
        {
            get { return mACFdeducciones; }
            set { mACFdeducciones = value; }
        }
         public string ACFneto
        {
            get { return mACFneto; }
            set { mACFneto = value; }
        }

           //Constructor vacío
         public DAcfDRTt_detallereparotributario()
         {
	    }

         public DAcfDRTt_detallereparotributario(
         string RTRcodigo,
         string ACFcuenta,
         string INVZU,
         string TXT50,
         string ACFfactorniif,
         string ACFvutilniif,
         string ACFfactorTrib,
         string ACFvutiltrib,
         string ACFvalorniif,
         string ACFdepAcuniif,
         string ACFNiifNeto,
         string ACFDepNiifPer,
         string ACFvalortrib,
         string ACFdepacutrib,
         string ACFlirneto,
         string ACFdeptlirper,
         string ACFadiciones,
         string ACFdeducciones,
         string ACFneto
        )
         {

             this.RTRcodigo = mRTRcodigo;
             this.ACFcuenta = mACFcuenta;
             this.INVZU = mINVZU;
             this.TXT50 = mTXT50;
             this.ACFfactorniif = mACFfactorniif;
             this.ACFvutilniif = mACFvutilniif;
             this.ACFfactorTrib = mACFfactorTrib;
             this.ACFvutiltrib = mACFvutiltrib;
             this.ACFvalorniif = mACFvalorniif;
             this.ACFdepAcuniif = mACFdepAcuniif;
             this.ACFNiifNeto = mACFNiifNeto;
             this.ACFDepNiifPer = mACFDepNiifPer;
             this.ACFvalortrib = mACFvalortrib;
             this.ACFdepacutrib = mACFdepacutrib;
             this.ACFlirneto = mACFlirneto;
             this.ACFdeptlirper = mACFdeptlirper;
             this.ACFadiciones = mACFadiciones;
             this.ACFdeducciones = mACFdeducciones;
             this.ACFneto = mACFneto;
            

         }
         //METODO MOSTRAR
         public DataTable Mostrar()
         {
             DataTable DtResultado = new DataTable("acfDRTt_detallereparotributario");
             SqlConnection SqlCon = new SqlConnection();

             try
             {
                 //Codigo
                 SqlCon.ConnectionString = DConexion.CnBDActivo;
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "usp_S_acfDRTt_detallereparotributario";
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
         public string Insertar(DAcfDRTt_detallereparotributario acfDRTt_detallereparotributario)
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
                 SqlCmd.CommandText = "usp_I_acfDRTt_detallereparotributario";
                 SqlCmd.CommandType = CommandType.StoredProcedure;
                 //
                 SqlParameter ParRTRcodigo = new SqlParameter();
                 ParRTRcodigo.ParameterName = "@iRTRcodigo";
                 ParRTRcodigo.SqlDbType = SqlDbType.Int;
                 ParRTRcodigo.Value = acfDRTt_detallereparotributario.RTRcodigo;
                 SqlCmd.Parameters.Add(ParRTRcodigo);
                 //
                 SqlParameter ParACFcuenta = new SqlParameter();
                 ParACFcuenta.ParameterName = "@sACFcuenta";
                 ParACFcuenta.SqlDbType = SqlDbType.Char;
                 ParACFcuenta.Value = acfDRTt_detallereparotributario.ACFcuenta;
                 SqlCmd.Parameters.Add(ParACFcuenta);
                 //
                 SqlParameter ParINVZU = new SqlParameter();
                 ParINVZU.ParameterName = "@sINVZU";
                 ParINVZU.SqlDbType = SqlDbType.Char;
                 ParINVZU.Value = acfDRTt_detallereparotributario.INVZU;
                 SqlCmd.Parameters.Add(ParINVZU);
                 //
                 SqlParameter ParTXT50 = new SqlParameter();
                 ParTXT50.ParameterName = "@sTXT50";
                 ParTXT50.SqlDbType = SqlDbType.Char;
                 ParTXT50.Value = acfDRTt_detallereparotributario.TXT50;
                 SqlCmd.Parameters.Add(ParTXT50);
                 //
                 SqlParameter ParACFfactorniif = new SqlParameter();
                 ParACFfactorniif.ParameterName = "@decACFfactorniif";
                 ParACFfactorniif.SqlDbType = SqlDbType.Decimal;
                 ParACFfactorniif.Value = acfDRTt_detallereparotributario.ACFfactorniif;
                 SqlCmd.Parameters.Add(ParACFfactorniif);
                 //
                 SqlParameter ParACFvutilniif = new SqlParameter();
                 ParACFvutilniif.ParameterName = "@decACFvutilniif";
                 ParACFvutilniif.SqlDbType = SqlDbType.Decimal;
                 ParACFvutilniif.Value = acfDRTt_detallereparotributario.ACFvutilniif;
                 SqlCmd.Parameters.Add(ParACFvutilniif);
                 //
                 SqlParameter ParACFfactorTrib = new SqlParameter();
                 ParACFfactorTrib.ParameterName = "@decACFfactorTrib";
                 ParACFfactorTrib.SqlDbType = SqlDbType.Decimal;
                 ParACFfactorTrib.Value = acfDRTt_detallereparotributario.ACFfactorTrib;
                 SqlCmd.Parameters.Add(ParACFfactorTrib);
                 //
                 SqlParameter ParACFvutiltrib = new SqlParameter();
                 ParACFvutiltrib.ParameterName = "@decACFvutiltrib";
                 ParACFvutiltrib.SqlDbType = SqlDbType.Decimal;
                 ParACFvutiltrib.Value = acfDRTt_detallereparotributario.ACFvutiltrib;
                 SqlCmd.Parameters.Add(ParACFvutiltrib);
                 //
                 SqlParameter ParACFvalorniif = new SqlParameter();
                 ParACFvalorniif.ParameterName = "@decACFvalorniif";
                 ParACFvalorniif.SqlDbType = SqlDbType.Decimal;
                 ParACFvalorniif.Value = acfDRTt_detallereparotributario.ACFvalorniif;
                 SqlCmd.Parameters.Add(ParACFvalorniif);
                 //
                 SqlParameter ParACFdepAcuniif = new SqlParameter();
                 ParACFdepAcuniif.ParameterName = "@decACFdepAcuniif";
                 ParACFdepAcuniif.SqlDbType = SqlDbType.Decimal;
                 ParACFdepAcuniif.Value = acfDRTt_detallereparotributario.ACFdepAcuniif;
                 SqlCmd.Parameters.Add(ParACFdepAcuniif);
                 //
                 SqlParameter ParACFNiifNeto = new SqlParameter();
                 ParACFNiifNeto.ParameterName = "@decACFNiifNeto";
                 ParACFNiifNeto.SqlDbType = SqlDbType.Decimal;
                 ParACFNiifNeto.Value = acfDRTt_detallereparotributario.ACFNiifNeto;
                 SqlCmd.Parameters.Add(ParACFNiifNeto);
                 //
                 SqlParameter ParACFDepNiifPer = new SqlParameter();
                 ParACFDepNiifPer.ParameterName = "@decACFDepNiifPer";
                 ParACFDepNiifPer.SqlDbType = SqlDbType.Decimal;
                 ParACFDepNiifPer.Value = acfDRTt_detallereparotributario.ACFDepNiifPer;
                 SqlCmd.Parameters.Add(ParACFDepNiifPer);
                 //
                 SqlParameter ParACFvalortrib = new SqlParameter();
                 ParACFvalortrib.ParameterName = "@decACFvalortrib";
                 ParACFvalortrib.SqlDbType = SqlDbType.Decimal;
                 ParACFvalortrib.Value = acfDRTt_detallereparotributario.ACFvalortrib;
                 SqlCmd.Parameters.Add(ParACFvalortrib);
                 //
                 SqlParameter ParACFdepacutrib = new SqlParameter();
                 ParACFdepacutrib.ParameterName = "@decACFdepacutrib";
                 ParACFdepacutrib.SqlDbType = SqlDbType.Decimal;
                 ParACFdepacutrib.Value = acfDRTt_detallereparotributario.ACFdepacutrib;
                 SqlCmd.Parameters.Add(ParACFdepacutrib);
                 //
                 SqlParameter ParACFlirneto = new SqlParameter();
                 ParACFlirneto.ParameterName = "@decACFlirneto";
                 ParACFlirneto.SqlDbType = SqlDbType.Decimal;
                 ParACFlirneto.Value = acfDRTt_detallereparotributario.ACFlirneto;
                 SqlCmd.Parameters.Add(ParACFlirneto);
                 //
                 SqlParameter ParACFdeptlirper = new SqlParameter();
                 ParACFdeptlirper.ParameterName = "@decACFdeptlirper";
                 ParACFdeptlirper.SqlDbType = SqlDbType.Decimal;
                 ParACFdeptlirper.Value = acfDRTt_detallereparotributario.ACFdeptlirper;
                 SqlCmd.Parameters.Add(ParACFdeptlirper);
                 //
                 SqlParameter ParACFadiciones = new SqlParameter();
                 ParACFadiciones.ParameterName = "@decACFadiciones";
                 ParACFadiciones.SqlDbType = SqlDbType.Decimal;
                 ParACFadiciones.Value = acfDRTt_detallereparotributario.ACFadiciones;
                 SqlCmd.Parameters.Add(ParACFadiciones);
                 //
                 SqlParameter ParACFdeducciones = new SqlParameter();
                 ParACFdeducciones.ParameterName = "@decACFdeducciones";
                 ParACFdeducciones.SqlDbType = SqlDbType.Decimal;
                 ParACFdeducciones.Value = acfDRTt_detallereparotributario.ACFdeducciones;
                 SqlCmd.Parameters.Add(ParACFdeducciones);
                 //
                 SqlParameter ParACFneto = new SqlParameter();
                 ParACFneto.ParameterName = "@decACFneto";
                 ParACFneto.SqlDbType = SqlDbType.Decimal;
                 ParACFneto.Value = acfDRTt_detallereparotributario.ACFneto;
                 SqlCmd.Parameters.Add(ParACFneto);
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
         public string Editar(DAcfDRTt_detallereparotributario acfDRTt_detallereparotributario)
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
                 SqlCmd.CommandText = "usp_U_acfDRTt_detallereparotributario";
                 SqlCmd.CommandType = CommandType.StoredProcedure;
                 //
                 //
                 SqlParameter ParRTRcodigo = new SqlParameter();
                 ParRTRcodigo.ParameterName = "@iRTRcodigo";
                 ParRTRcodigo.SqlDbType = SqlDbType.Int;
                 ParRTRcodigo.Value = acfDRTt_detallereparotributario.RTRcodigo;
                 SqlCmd.Parameters.Add(ParRTRcodigo);
                 //
                 SqlParameter ParACFcuenta = new SqlParameter();
                 ParACFcuenta.ParameterName = "@sACFcuenta";
                 ParACFcuenta.SqlDbType = SqlDbType.Char;
                 ParACFcuenta.Value = acfDRTt_detallereparotributario.ACFcuenta;
                 SqlCmd.Parameters.Add(ParACFcuenta);
                 //
                 SqlParameter ParINVZU = new SqlParameter();
                 ParINVZU.ParameterName = "@sINVZU";
                 ParINVZU.SqlDbType = SqlDbType.Char;
                 ParINVZU.Value = acfDRTt_detallereparotributario.INVZU;
                 SqlCmd.Parameters.Add(ParINVZU);
                 //
                 SqlParameter ParTXT50 = new SqlParameter();
                 ParTXT50.ParameterName = "@sTXT50";
                 ParTXT50.SqlDbType = SqlDbType.Char;
                 ParTXT50.Value = acfDRTt_detallereparotributario.TXT50;
                 SqlCmd.Parameters.Add(ParTXT50);
                 //
                 SqlParameter ParACFfactorniif = new SqlParameter();
                 ParACFfactorniif.ParameterName = "@decACFfactorniif";
                 ParACFfactorniif.SqlDbType = SqlDbType.Decimal;
                 ParACFfactorniif.Value = acfDRTt_detallereparotributario.ACFfactorniif;
                 SqlCmd.Parameters.Add(ParACFfactorniif);
                 //
                 SqlParameter ParACFvutilniif = new SqlParameter();
                 ParACFvutilniif.ParameterName = "@decACFvutilniif";
                 ParACFvutilniif.SqlDbType = SqlDbType.Decimal;
                 ParACFvutilniif.Value = acfDRTt_detallereparotributario.ACFvutilniif;
                 SqlCmd.Parameters.Add(ParACFvutilniif);
                 //
                 SqlParameter ParACFfactorTrib = new SqlParameter();
                 ParACFfactorTrib.ParameterName = "@decACFfactorTrib";
                 ParACFfactorTrib.SqlDbType = SqlDbType.Decimal;
                 ParACFfactorTrib.Value = acfDRTt_detallereparotributario.ACFfactorTrib;
                 SqlCmd.Parameters.Add(ParACFfactorTrib);
                 //
                 SqlParameter ParACFvutiltrib = new SqlParameter();
                 ParACFvutiltrib.ParameterName = "@decACFvutiltrib";
                 ParACFvutiltrib.SqlDbType = SqlDbType.Decimal;
                 ParACFvutiltrib.Value = acfDRTt_detallereparotributario.ACFvutiltrib;
                 SqlCmd.Parameters.Add(ParACFvutiltrib);
                 //
                 SqlParameter ParACFvalorniif = new SqlParameter();
                 ParACFvalorniif.ParameterName = "@decACFvalorniif";
                 ParACFvalorniif.SqlDbType = SqlDbType.Decimal;
                 ParACFvalorniif.Value = acfDRTt_detallereparotributario.ACFvalorniif;
                 SqlCmd.Parameters.Add(ParACFvalorniif);
                 //
                 SqlParameter ParACFdepAcuniif = new SqlParameter();
                 ParACFdepAcuniif.ParameterName = "@decACFdepAcuniif";
                 ParACFdepAcuniif.SqlDbType = SqlDbType.Decimal;
                 ParACFdepAcuniif.Value = acfDRTt_detallereparotributario.ACFdepAcuniif;
                 SqlCmd.Parameters.Add(ParACFdepAcuniif);
                 //
                 SqlParameter ParACFNiifNeto = new SqlParameter();
                 ParACFNiifNeto.ParameterName = "@decACFNiifNeto";
                 ParACFNiifNeto.SqlDbType = SqlDbType.Decimal;
                 ParACFNiifNeto.Value = acfDRTt_detallereparotributario.ACFNiifNeto;
                 SqlCmd.Parameters.Add(ParACFNiifNeto);
                 //
                 SqlParameter ParACFDepNiifPer = new SqlParameter();
                 ParACFDepNiifPer.ParameterName = "@decACFDepNiifPer";
                 ParACFDepNiifPer.SqlDbType = SqlDbType.Decimal;
                 ParACFDepNiifPer.Value = acfDRTt_detallereparotributario.ACFDepNiifPer;
                 SqlCmd.Parameters.Add(ParACFDepNiifPer);
                 //
                 SqlParameter ParACFvalortrib = new SqlParameter();
                 ParACFvalortrib.ParameterName = "@decACFvalortrib";
                 ParACFvalortrib.SqlDbType = SqlDbType.Decimal;
                 ParACFvalortrib.Value = acfDRTt_detallereparotributario.ACFvalortrib;
                 SqlCmd.Parameters.Add(ParACFvalortrib);
                 //
                 SqlParameter ParACFdepacutrib = new SqlParameter();
                 ParACFdepacutrib.ParameterName = "@decACFdepacutrib";
                 ParACFdepacutrib.SqlDbType = SqlDbType.Decimal;
                 ParACFdepacutrib.Value = acfDRTt_detallereparotributario.ACFdepacutrib;
                 SqlCmd.Parameters.Add(ParACFdepacutrib);
                 //
                 SqlParameter ParACFlirneto = new SqlParameter();
                 ParACFlirneto.ParameterName = "@decACFlirneto";
                 ParACFlirneto.SqlDbType = SqlDbType.Decimal;
                 ParACFlirneto.Value = acfDRTt_detallereparotributario.ACFlirneto;
                 SqlCmd.Parameters.Add(ParACFlirneto);
                 //
                 SqlParameter ParACFdeptlirper = new SqlParameter();
                 ParACFdeptlirper.ParameterName = "@decACFdeptlirper";
                 ParACFdeptlirper.SqlDbType = SqlDbType.Decimal;
                 ParACFdeptlirper.Value = acfDRTt_detallereparotributario.ACFdeptlirper;
                 SqlCmd.Parameters.Add(ParACFdeptlirper);
                 //
                 SqlParameter ParACFadiciones = new SqlParameter();
                 ParACFadiciones.ParameterName = "@decACFadiciones";
                 ParACFadiciones.SqlDbType = SqlDbType.Decimal;
                 ParACFadiciones.Value = acfDRTt_detallereparotributario.ACFadiciones;
                 SqlCmd.Parameters.Add(ParACFadiciones);
                 //
                 SqlParameter ParACFdeducciones = new SqlParameter();
                 ParACFdeducciones.ParameterName = "@decACFdeducciones";
                 ParACFdeducciones.SqlDbType = SqlDbType.Decimal;
                 ParACFdeducciones.Value = acfDRTt_detallereparotributario.ACFdeducciones;
                 SqlCmd.Parameters.Add(ParACFdeducciones);
                 //
                 SqlParameter ParACFneto = new SqlParameter();
                 ParACFneto.ParameterName = "@decACFneto";
                 ParACFneto.SqlDbType = SqlDbType.Decimal;
                 ParACFneto.Value = acfDRTt_detallereparotributario.ACFneto;
                 SqlCmd.Parameters.Add(ParACFneto);
                 //
                

                 //Ejecutamos nuestro comando

                 rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Actualizo el Registro";


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
         public string Eliminar(DAcfDRTt_detallereparotributario acfDRTt_detallereparotributario)
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
                 SqlCmd.CommandText = "usp_D_acfDRTt_detallereparotributario";
                 SqlCmd.CommandType = CommandType.StoredProcedure;
                 //
                 SqlParameter ParRTRcodigo = new SqlParameter();
                 ParRTRcodigo.ParameterName = "@iRTRcodigo";
                 ParRTRcodigo.SqlDbType = SqlDbType.Int;
                 ParRTRcodigo.Value = acfDRTt_detallereparotributario.RTRcodigo;
                 SqlCmd.Parameters.Add(ParRTRcodigo);
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

         public DataTable Buscar(DAcfDRTt_detallereparotributario acfDRTt_detallereparotributario)
         {

             DataTable DtResultado = new DataTable("acfDRTt_detallereparotributario");
             SqlConnection SqlCon = new SqlConnection();


             try
             {

                 SqlCon.ConnectionString = DConexion.CnBDActivo;
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "usp_B_acfDRTt_detallereparotributario";
                 SqlCmd.CommandType = CommandType.StoredProcedure;



                 SqlParameter ParRTRcodigo = new SqlParameter();
                 ParRTRcodigo.ParameterName = "@iRTRcodigo";
                 ParRTRcodigo.SqlDbType = SqlDbType.Int;
                 ParRTRcodigo.Value = acfDRTt_detallereparotributario.RTRcodigo;
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
    }
}
