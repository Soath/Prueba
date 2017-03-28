using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DacfDDFt_detalledediferido{

        private string sACFcuenta;
        private string sINVZU;
        private string sTXT50;
        private string decACFvalorniif;
        private string decACFdepniif;
        private string decACFPPENiif;
        private string decACFvalortrib;
        private string decACFDepTrib;
        private string decACFpplir;
        private string decACFdeducible;
        private string decACFimponible;
        private string decACFirda;
        private string decACFirdp;
        private string decACFculdep;
        private string decACFrecper1;
        private string decACFrecper2;
        private string decACFrecper3;
        private string decACFrecper4;
        private string decACFtotales;
        private string decACFirdaA;
        private string decACFirdpA;
        private string decACFirdaF;
        private string decACFirdpF;
        private string iPDFcodigo;

        public string ACFcuenta
        {
            get { return sACFcuenta; }
            set { sACFcuenta = value; }
        }
        public string INVZU
        {
            get { return sINVZU; }
            set { sINVZU = value; }
        }
        public string TXT50
        {
            get { return sTXT50; }
            set { sTXT50 = value; }
        }
        public string ACFvalorniif
        {
            get { return decACFvalorniif; }
            set { decACFvalorniif = value; }
        }
        public string ACFdepniif
        {
            get { return decACFdepniif; }
            set { decACFdepniif = value; }
        }
        public string ACFPPENiif
        {
            get { return decACFPPENiif; }
            set { decACFPPENiif = value; }
        }
        public string ACFvalortrib
        {
            get { return decACFvalortrib; }
            set { decACFvalortrib = value; }
        }
        public string ACFDepTrib
        {
            get { return decACFDepTrib; }
            set { decACFDepTrib = value; }
        }
        public string ACFpplir
        {
            get { return decACFpplir; }
            set { decACFpplir = value; }
        }
        public string ACFdeducible
        {
            get { return decACFdeducible; }
            set { decACFdeducible = value; }
        }
        public string ACFimponible
        {
            get { return decACFimponible; }
            set { decACFimponible = value; }
        }
        public string ACFirda
        {
            get { return decACFirda; }
            set { decACFirda = value; }
        }
        public string ACFirdp
        {
            get { return decACFirdp; }
            set { decACFirdp = value; }
        }
        public string ACFculdep
        {
            get { return decACFculdep; }
            set { decACFculdep = value; }
        }
        public string ACFrecper1
        {
            get { return decACFrecper1; }
            set { decACFrecper1 = value; }
        }
        public string ACFrecper2
        {
            get { return decACFrecper2; }
            set { decACFrecper2 = value; }
        }
        public string ACFrecper3
        {
            get { return decACFrecper3; }
            set { decACFrecper3 = value; }
        }
        public string ACFrecper4
        {
            get { return decACFrecper4; }
            set { decACFrecper4 = value; }
        }
        public string ACFtotales
        {
            get { return decACFtotales; }
            set { decACFtotales = value; }
        }
        public string ACFirdaA
        {
            get { return decACFirdaA; }
            set { decACFirdaA = value; }
        }
        public string ACFirdpA
        {
            get { return decACFirdpA; }
            set { decACFirdpA = value; }
        }
        public string ACFirdaF
        {
            get { return decACFirdaF; }
            set { decACFirdaF = value; }
        }
        public string ACFirdpF
        {
            get { return decACFirdpF; }
            set { decACFirdpF = value; }
        }
        public string PDFcodigo
        {
            get { return iPDFcodigo; }
            set { iPDFcodigo = value; }
        }      
       
        //Constructor vacío
	public DacfDDFt_detalledediferido(){
	}
        //Constructor con parámetros
    public DacfDDFt_detalledediferido(
         string ACFcuenta,
         string INVZU,               
         string TXT50,                 
         string ACFvalorniif,                   
         string ACFdepniif,                   
         string ACFPPENiif,
         string ACFvalortrib,            
         string ACFDepTrib,         
         string ACFpplir,                   
         string ACFdeducible,          
         string ACFimponible,      
         string ACFirda,     
         string ACFirdp,        
         string ACFculdep,         
         string ACFrecper1,               
         string ACFrecper2,             
         string ACFrecper3,           
         string ACFrecper4,         
         string ACFtotales,                 
         string ACFirdaA,                
         string ACFirdpA,                
         string ACFirdaF,                
         string ACFirdpF,                
         string PDFcodigo)         
    {

        this.ACFcuenta = sACFcuenta;
        this.INVZU = sINVZU;
        this.TXT50 = sTXT50;
        this.ACFvalorniif = decACFvalorniif;
        this.ACFdepniif = decACFdepniif;
        this.ACFPPENiif = decACFPPENiif;
        this.ACFvalortrib = decACFvalortrib;
        this.ACFDepTrib = decACFDepTrib;
        this.ACFpplir = decACFpplir;
        this.ACFdeducible = decACFdeducible;
        this.ACFimponible = decACFimponible;
        this.ACFirda = decACFirda;
        this.ACFirdp = decACFirdp;
        this.ACFculdep = decACFculdep;
        this.ACFrecper1 = decACFrecper1;
        this.ACFrecper2 = decACFrecper2;
        this.ACFrecper3 = decACFrecper3;
        this.ACFrecper4 = decACFrecper4;
        this.ACFtotales = decACFtotales;
        this.ACFirdaA = decACFirdaA;
        this.ACFirdpA = decACFirdpA;
        this.ACFirdaF = decACFirdaF;
        this.ACFirdpF = decACFirdpF;
        this.PDFcodigo = iPDFcodigo;       
	}

/*	public object Clone() {
//		return base.MemberwiseClone();
//	}
*/

    //METODO MOSTRAR
        public DataTable Mostrar() {
           DataTable DtResultado = new DataTable("acfDDFt_detalledediferido");
            SqlConnection SqlCon = new SqlConnection();

		try {
            //Codigo
             SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfDDFt_detalledediferido";
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
	public string Insertar(DacfDDFt_detalledediferido acfDDFt_detalledediferido)
    {
        string rpta = "";
        SqlConnection SqlCon = new SqlConnection();
		try {
             //Código
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_I_acfDDFt_detalledediferido";
                SqlCmd.CommandType = CommandType.StoredProcedure;                            
                //
                SqlParameter ParACFcuenta = new SqlParameter();
                ParACFcuenta.ParameterName = "@sACFcuenta";
                ParACFcuenta.SqlDbType = SqlDbType.Char;
                ParACFcuenta.Value = acfDDFt_detalledediferido.ACFcuenta;
                SqlCmd.Parameters.Add(ParACFcuenta);
                //
                SqlParameter ParINVZU = new SqlParameter();
                ParINVZU.ParameterName = "@sINVZU";
                ParINVZU.SqlDbType = SqlDbType.Char;
                ParINVZU.Value = acfDDFt_detalledediferido.INVZU;
                SqlCmd.Parameters.Add(ParINVZU);
                //
                SqlParameter ParTXT50 = new SqlParameter();
                ParTXT50.ParameterName = "@sTXT50";
                ParTXT50.SqlDbType = SqlDbType.Char;
                ParTXT50.Value = acfDDFt_detalledediferido.TXT50;
                SqlCmd.Parameters.Add(ParTXT50);
                //
                SqlParameter ParACFvalorniif = new SqlParameter();
                ParACFvalorniif.ParameterName = "@decACFvalorniif";
                ParACFvalorniif.SqlDbType = SqlDbType.Decimal;
                ParACFvalorniif.Value = acfDDFt_detalledediferido.ACFvalorniif;
                SqlCmd.Parameters.Add(ParACFvalorniif);
                //
                SqlParameter ParACFdepniif = new SqlParameter();
                ParACFdepniif.ParameterName = "@decACFdepniif";
                ParACFdepniif.SqlDbType = SqlDbType.Decimal;
                ParACFdepniif.Value = acfDDFt_detalledediferido.ACFdepniif;
                SqlCmd.Parameters.Add(ParACFdepniif);
                //
                SqlParameter ParACFPPENiif = new SqlParameter();
                ParACFPPENiif.ParameterName = "@decACFPPENiif";
                ParACFPPENiif.SqlDbType = SqlDbType.Decimal;
                ParACFPPENiif.Value = acfDDFt_detalledediferido.ACFPPENiif;
                SqlCmd.Parameters.Add(ParACFPPENiif);
                //
                SqlParameter ACFvalortrib = new SqlParameter();
                ACFvalortrib.ParameterName = "@desACFvalortrib";
                ACFvalortrib.SqlDbType = SqlDbType.Decimal;
                ACFvalortrib.Value = acfDDFt_detalledediferido.ACFvalortrib;
                SqlCmd.Parameters.Add(ACFvalortrib);
                //
                SqlParameter ParACFDepTrib = new SqlParameter();
                ParACFDepTrib.ParameterName = "@decACFDepTrib";
                ParACFDepTrib.SqlDbType = SqlDbType.Decimal;
                ParACFDepTrib.Value = acfDDFt_detalledediferido.ACFDepTrib;
                SqlCmd.Parameters.Add(ParACFDepTrib);
                //
                SqlParameter ParACFpplir = new SqlParameter();
                ParACFpplir.ParameterName = "@decACFpplir";
                ParACFpplir.SqlDbType = SqlDbType.Decimal;
                ParACFpplir.Value = acfDDFt_detalledediferido.ACFpplir;
                SqlCmd.Parameters.Add(ParACFpplir);
                //
                SqlParameter ParACFdeducible = new SqlParameter();
                ParACFdeducible.ParameterName = "@decACFdeducible";
                ParACFdeducible.SqlDbType = SqlDbType.Decimal;
                ParACFdeducible.Value = acfDDFt_detalledediferido.ACFdeducible;
                SqlCmd.Parameters.Add(ParACFdeducible);
                //
                SqlParameter ParACFimponible = new SqlParameter();
                ParACFimponible.ParameterName = "@decACFimponible";
                ParACFimponible.SqlDbType = SqlDbType.Decimal;
                ParACFimponible.Value = acfDDFt_detalledediferido.ACFimponible;
                SqlCmd.Parameters.Add(ParACFimponible);
                //
                SqlParameter ParACFirda = new SqlParameter();
                ParACFirda.ParameterName = "@decACFirda";
                ParACFirda.SqlDbType = SqlDbType.Decimal;
                ParACFirda.Value = acfDDFt_detalledediferido.ACFirda;
                SqlCmd.Parameters.Add(ParACFirda);
                //
                SqlParameter ParACFirdp = new SqlParameter();
                ParACFirdp.ParameterName = "@decACFirdp";
                ParACFirdp.SqlDbType = SqlDbType.Decimal;
                ParACFirdp.Value = acfDDFt_detalledediferido.ACFirdp;
                SqlCmd.Parameters.Add(ParACFirdp);
                //
                SqlParameter ParACFculdep = new SqlParameter();
                ParACFculdep.ParameterName = "@decACFculdep";
                ParACFculdep.SqlDbType = SqlDbType.Decimal;
                ParACFculdep.Value = acfDDFt_detalledediferido.ACFculdep;
                SqlCmd.Parameters.Add(ParACFculdep);
                //
                SqlParameter ParACFrecper1 = new SqlParameter();
                ParACFrecper1.ParameterName = "@decACFrecper1";
                ParACFrecper1.SqlDbType = SqlDbType.Decimal;
                ParACFrecper1.Value = acfDDFt_detalledediferido.ACFrecper1;
                SqlCmd.Parameters.Add(ParACFrecper1);
                //
                SqlParameter ParACFrecper2 = new SqlParameter();
                ParACFrecper2.ParameterName = "@decACFrecper2";
                ParACFrecper2.SqlDbType = SqlDbType.Decimal;
                ParACFrecper2.Value = acfDDFt_detalledediferido.ACFrecper2;
                SqlCmd.Parameters.Add(ParACFrecper2);
                //
                SqlParameter ParACFrecper3 = new SqlParameter();
                ParACFrecper3.ParameterName = "@decACFrecper3";
                ParACFrecper3.SqlDbType = SqlDbType.Decimal;
                ParACFrecper3.Value = acfDDFt_detalledediferido.ACFrecper3;
                SqlCmd.Parameters.Add(ParACFrecper3);
                //
                SqlParameter ParACFrecper4 = new SqlParameter();
                ParACFrecper4.ParameterName = "@decACFrecper4";
                ParACFrecper4.SqlDbType = SqlDbType.Decimal;
                ParACFrecper4.Value = acfDDFt_detalledediferido.ACFrecper4;
                SqlCmd.Parameters.Add(ParACFrecper4);
                //
                SqlParameter ParACFtotales = new SqlParameter();
                ParACFtotales.ParameterName = "@decACFtotales";
                ParACFtotales.SqlDbType = SqlDbType.Decimal;
                ParACFtotales.Value = acfDDFt_detalledediferido.ACFtotales;
                SqlCmd.Parameters.Add(ParACFtotales);
                //
                SqlParameter ParACFirdaA = new SqlParameter();
                ParACFirdaA.ParameterName = "@decACFirdaA";
                ParACFirdaA.SqlDbType = SqlDbType.Decimal;
                ParACFirdaA.Value = acfDDFt_detalledediferido.ACFirdaA;
                SqlCmd.Parameters.Add(ParACFirdaA);
                //
                SqlParameter ParACFirdpA = new SqlParameter();
                ParACFirdpA.ParameterName = "@decACFirdpA";
                ParACFirdpA.SqlDbType = SqlDbType.Decimal;
                ParACFirdpA.Value = acfDDFt_detalledediferido.ACFirdpA;
                SqlCmd.Parameters.Add(ParACFirdpA);
                //
                SqlParameter ParACFirdaF = new SqlParameter();
                ParACFirdaF.ParameterName = "@decACFirdaF";
                ParACFirdaF.SqlDbType = SqlDbType.Decimal;
                ParACFirdaF.Value = acfDDFt_detalledediferido.ACFirdaF;
                SqlCmd.Parameters.Add(ParACFirdaF);
                //
                SqlParameter ParACFirdpF = new SqlParameter();
                ParACFirdpF.ParameterName = "@decACFirdpF";
                ParACFirdpF.SqlDbType = SqlDbType.Decimal;
                ParACFirdpF.Value = acfDDFt_detalledediferido.ACFirdpF;
                SqlCmd.Parameters.Add(ParACFirdpF);
                //
                SqlParameter ParPDFcodigo = new SqlParameter();
                ParPDFcodigo.ParameterName = "@iPDFcodigo";
                ParPDFcodigo.SqlDbType = SqlDbType.Int;
                ParPDFcodigo.Value = acfDDFt_detalledediferido.PDFcodigo;
                SqlCmd.Parameters.Add(ParPDFcodigo);
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
	public string Editar(DacfDDFt_detalledediferido acfDDFt_detalledediferido) {
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
                SqlCmd.CommandText = "usp_U_acfDDFt_detalledediferido";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter ParACFcuenta = new SqlParameter();
                ParACFcuenta.ParameterName = "@sACFcuenta";
                ParACFcuenta.SqlDbType = SqlDbType.Char;
                ParACFcuenta.Value = acfDDFt_detalledediferido.ACFcuenta;
                SqlCmd.Parameters.Add(ParACFcuenta);
                //
                SqlParameter ParINVZU = new SqlParameter();
                ParINVZU.ParameterName = "@sINVZU";
                ParINVZU.SqlDbType = SqlDbType.Char;
                ParINVZU.Value = acfDDFt_detalledediferido.INVZU;
                SqlCmd.Parameters.Add(ParINVZU);
                //
                SqlParameter ParTXT50 = new SqlParameter();
                ParTXT50.ParameterName = "@sTXT50";
                ParTXT50.SqlDbType = SqlDbType.Char;
                ParTXT50.Value = acfDDFt_detalledediferido.TXT50;
                SqlCmd.Parameters.Add(ParTXT50);
                //
                SqlParameter ParACFvalorniif = new SqlParameter();
                ParACFvalorniif.ParameterName = "@decACFvalorniif";
                ParACFvalorniif.SqlDbType = SqlDbType.Decimal;
                ParACFvalorniif.Value = acfDDFt_detalledediferido.ACFvalorniif;
                SqlCmd.Parameters.Add(ParACFvalorniif);
                //
                SqlParameter ParACFdepniif = new SqlParameter();
                ParACFdepniif.ParameterName = "@decACFdepniif";
                ParACFdepniif.SqlDbType = SqlDbType.Decimal;
                ParACFdepniif.Value = acfDDFt_detalledediferido.ACFdepniif;
                SqlCmd.Parameters.Add(ParACFdepniif);
                //
                SqlParameter ParACFPPENiif = new SqlParameter();
                ParACFPPENiif.ParameterName = "@decACFPPENiif";
                ParACFPPENiif.SqlDbType = SqlDbType.Decimal;
                ParACFPPENiif.Value = acfDDFt_detalledediferido.ACFPPENiif;
                SqlCmd.Parameters.Add(ParACFPPENiif);
                //
                SqlParameter ACFvalortrib = new SqlParameter();
                ACFvalortrib.ParameterName = "@desACFvalortrib";
                ACFvalortrib.SqlDbType = SqlDbType.Decimal;
                ACFvalortrib.Value = acfDDFt_detalledediferido.ACFvalortrib;
                SqlCmd.Parameters.Add(ACFvalortrib);
                //
                SqlParameter ParACFDepTrib = new SqlParameter();
                ParACFDepTrib.ParameterName = "@decACFDepTrib";
                ParACFDepTrib.SqlDbType = SqlDbType.Decimal;
                ParACFDepTrib.Value = acfDDFt_detalledediferido.ACFDepTrib;
                SqlCmd.Parameters.Add(ParACFDepTrib);
                //
                SqlParameter ParACFpplir = new SqlParameter();
                ParACFpplir.ParameterName = "@decACFpplir";
                ParACFpplir.SqlDbType = SqlDbType.Decimal;
                ParACFpplir.Value = acfDDFt_detalledediferido.ACFpplir;
                SqlCmd.Parameters.Add(ParACFpplir);
                //
                SqlParameter ParACFdeducible = new SqlParameter();
                ParACFdeducible.ParameterName = "@decACFdeducible";
                ParACFdeducible.SqlDbType = SqlDbType.Decimal;
                ParACFdeducible.Value = acfDDFt_detalledediferido.ACFdeducible;
                SqlCmd.Parameters.Add(ParACFdeducible);
                //
                SqlParameter ParACFimponible = new SqlParameter();
                ParACFimponible.ParameterName = "@decACFimponible";
                ParACFimponible.SqlDbType = SqlDbType.Decimal;
                ParACFimponible.Value = acfDDFt_detalledediferido.ACFimponible;
                SqlCmd.Parameters.Add(ParACFimponible);
                //
                SqlParameter ParACFirda = new SqlParameter();
                ParACFirda.ParameterName = "@decACFirda";
                ParACFirda.SqlDbType = SqlDbType.Decimal;
                ParACFirda.Value = acfDDFt_detalledediferido.ACFirda;
                SqlCmd.Parameters.Add(ParACFirda);
                //
                SqlParameter ParACFirdp = new SqlParameter();
                ParACFirdp.ParameterName = "@decACFirdp";
                ParACFirdp.SqlDbType = SqlDbType.Decimal;
                ParACFirdp.Value = acfDDFt_detalledediferido.ACFirdp;
                SqlCmd.Parameters.Add(ParACFirdp);
                //
                SqlParameter ParACFculdep = new SqlParameter();
                ParACFculdep.ParameterName = "@decACFculdep";
                ParACFculdep.SqlDbType = SqlDbType.Decimal;
                ParACFculdep.Value = acfDDFt_detalledediferido.ACFculdep;
                SqlCmd.Parameters.Add(ParACFculdep);
                //
                SqlParameter ParACFrecper1 = new SqlParameter();
                ParACFrecper1.ParameterName = "@decACFrecper1";
                ParACFrecper1.SqlDbType = SqlDbType.Decimal;
                ParACFrecper1.Value = acfDDFt_detalledediferido.ACFrecper1;
                SqlCmd.Parameters.Add(ParACFrecper1);
                //
                SqlParameter ParACFrecper2 = new SqlParameter();
                ParACFrecper2.ParameterName = "@decACFrecper2";
                ParACFrecper2.SqlDbType = SqlDbType.Decimal;
                ParACFrecper2.Value = acfDDFt_detalledediferido.ACFrecper2;
                SqlCmd.Parameters.Add(ParACFrecper2);
                //
                SqlParameter ParACFrecper3 = new SqlParameter();
                ParACFrecper3.ParameterName = "@decACFrecper3";
                ParACFrecper3.SqlDbType = SqlDbType.Decimal;
                ParACFrecper3.Value = acfDDFt_detalledediferido.ACFrecper3;
                SqlCmd.Parameters.Add(ParACFrecper3);
                //
                SqlParameter ParACFrecper4 = new SqlParameter();
                ParACFrecper4.ParameterName = "@decACFrecper4";
                ParACFrecper4.SqlDbType = SqlDbType.Decimal;
                ParACFrecper4.Value = acfDDFt_detalledediferido.ACFrecper4;
                SqlCmd.Parameters.Add(ParACFrecper4);
                //
                SqlParameter ParACFtotales = new SqlParameter();
                ParACFtotales.ParameterName = "@decACFtotales";
                ParACFtotales.SqlDbType = SqlDbType.Decimal;
                ParACFtotales.Value = acfDDFt_detalledediferido.ACFtotales;
                SqlCmd.Parameters.Add(ParACFtotales);
                //
                SqlParameter ParACFirdaA = new SqlParameter();
                ParACFirdaA.ParameterName = "@decACFirdaA";
                ParACFirdaA.SqlDbType = SqlDbType.Decimal;
                ParACFirdaA.Value = acfDDFt_detalledediferido.ACFirdaA;
                SqlCmd.Parameters.Add(ParACFirdaA);
                //
                SqlParameter ParACFirdpA = new SqlParameter();
                ParACFirdpA.ParameterName = "@decACFirdpA";
                ParACFirdpA.SqlDbType = SqlDbType.Decimal;
                ParACFirdpA.Value = acfDDFt_detalledediferido.ACFirdpA;
                SqlCmd.Parameters.Add(ParACFirdpA);
                //
                SqlParameter ParACFirdaF = new SqlParameter();
                ParACFirdaF.ParameterName = "@decACFirdaF";
                ParACFirdaF.SqlDbType = SqlDbType.Decimal;
                ParACFirdaF.Value = acfDDFt_detalledediferido.ACFirdaF;
                SqlCmd.Parameters.Add(ParACFirdaF);
                //
                SqlParameter ParACFirdpF = new SqlParameter();
                ParACFirdpF.ParameterName = "@decACFirdpF";
                ParACFirdpF.SqlDbType = SqlDbType.Decimal;
                ParACFirdpF.Value = acfDDFt_detalledediferido.ACFirdpF;
                SqlCmd.Parameters.Add(ParACFirdpF);
                //
                SqlParameter ParPDFcodigo = new SqlParameter();
                ParPDFcodigo.ParameterName = "@iPDFcodigo";
                ParPDFcodigo.SqlDbType = SqlDbType.Int;
                ParPDFcodigo.Value = acfDDFt_detalledediferido.PDFcodigo;
                SqlCmd.Parameters.Add(ParPDFcodigo);
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
	public string Eliminar(DacfDDFt_detalledediferido acfDDFt_detalledediferido) {
		
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
                SqlCmd.CommandText = "usp_D_acfDDFt_detalledediferido";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter ParACFcuenta = new SqlParameter();
                ParACFcuenta.ParameterName = "@sACFcuenta";
                ParACFcuenta.SqlDbType = SqlDbType.Char;
                ParACFcuenta.Value = acfDDFt_detalledediferido.ACFcuenta;
                SqlCmd.Parameters.Add(ParACFcuenta);
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

	public DataTable Buscar(DacfDDFt_detalledediferido acfDDFt_detalledediferido) {

        DataTable DtResultado = new DataTable("acfDDFt_detalledediferido");
            SqlConnection SqlCon = new SqlConnection();


		try {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_acfDDFt_detalledediferido";
            SqlCmd.CommandType = CommandType.StoredProcedure;



            SqlParameter ParINVZU = new SqlParameter();
            ParINVZU.ParameterName = "@sINVZU";
            ParINVZU.SqlDbType = SqlDbType.Char;
            ParINVZU.Size = 50;
            ParINVZU.Value = acfDDFt_detalledediferido.INVZU;
            SqlCmd.Parameters.Add(ParINVZU);

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
