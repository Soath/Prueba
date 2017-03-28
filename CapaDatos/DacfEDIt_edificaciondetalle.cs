using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DacfEDIt_edificaciondetalle{

        private string iACFid;
        private string sEDIzona;
        private string sEDIdescripicion;
        private string decEDIfactorasignado;
        private string decACFValorIR;
        private string decACFTC;
        private string decACFCRC;
        private string decACFDEPCRC;
        private string decACFNETOCRC;
        private string decACFvalorniif;
        private string decACFdepacuniif;
        private string decACFNETOPCGA;
        private string decACFDIFCosto;
        private string decACFINCCosto;
        private string decACFDISCosto;
        private string decACFDIFDEP;
        private string decACFINCDep;
        private string decACFDISDep;
        private string decACFDIFNeta;
        private string decACFSumDifDed;
        private string decACFSumDifGra;
        private string decACFSumACTDif;
        private string decACFSumPasDif;
        private string sACFid;

        private string sLOClocal;
        private string sRVAcodigo;

        public string ACFid
        {
            get { return iACFid; }
            set { iACFid = value; }
        }
        public string EDIzona
        {
            get { return sEDIzona; }
            set { sEDIzona = value; }
        }
        public string EDIdescripicion
        {
            get { return sEDIdescripicion; }
            set { sEDIdescripicion = value; }
        }
        public string EDIfactorasignado
        {
            get { return decEDIfactorasignado; }
            set { decEDIfactorasignado = value; }
        }
        public string ACFValorIR
        {
            get { return decACFValorIR; }
            set { decACFValorIR = value; }
        }
        public string ACFTC
        {
            get { return decACFTC; }
            set { decACFTC = value; }
        }
        public string ACFCRC
        {
            get { return decACFCRC; }
            set { decACFCRC = value; }
        }
        public string ACFDEPCRC
        {
            get { return decACFDEPCRC; }
            set { decACFDEPCRC = value; }
        }
        public string ACFNETOCRC
        {
            get { return decACFNETOCRC; }
            set { decACFNETOCRC = value; }
        }
        public string ACFvalorniif
        {
            get { return decACFvalorniif; }
            set { decACFvalorniif = value; }
        }
        public string ACFdepacuniif
        {
            get { return decACFdepacuniif; }
            set { decACFdepacuniif = value; }
        }
        public string ACFNETOPCGA
        {
            get { return decACFNETOPCGA; }
            set { decACFNETOPCGA = value; }
        }
        public string ACFDIFCosto
        {
            get { return decACFDIFCosto; }
            set { decACFDIFCosto = value; }
        }
        public string ACFINCCosto
        {
            get { return decACFINCCosto; }
            set { decACFINCCosto = value; }
        }
        public string ACFDISCosto
        {
            get { return decACFDISCosto; }
            set { decACFDISCosto = value; }
        }
        public string ACFDIFDEP
        {
            get { return decACFDIFDEP; }
            set { decACFDIFDEP = value; }
        }
        public string ACFINCDep
        {
            get { return decACFINCDep; }
            set { decACFINCDep = value; }
        }
        public string ACFDISDep
        {
            get { return decACFDISDep; }
            set { decACFDISDep = value; }
        }
        public string ACFDIFNeta
        {
            get { return decACFDIFNeta; }
            set { decACFDIFNeta = value; }
        }
        public string ACFSumDifDed
        {
            get { return decACFSumDifDed; }
            set { decACFSumDifDed = value; }
        }
        public string ACFSumDifGra
        {
            get { return decACFSumDifGra; }
            set { decACFSumDifGra = value; }
        }
        public string ACFSumACTDif
        {
            get { return decACFSumACTDif; }
            set { decACFSumACTDif = value; }
        }
        public string ACFSumPasDif
        {
            get { return decACFSumPasDif; }
            set { decACFSumPasDif = value; }
        }
        public string ACFcuenta
        {
            get { return sACFid; }
            set { sACFid = value; }
        }
        public string LOClocal
        {
            get { return sLOClocal; }
            set { sLOClocal = value; }
        }
        public string RVAcodigo
        {
            get { return sRVAcodigo; }
            set { sRVAcodigo = value; }
        }  
       
        //Constructor vacío
	public DacfEDIt_edificaciondetalle(){
	}
        //Constructor con parámetros
    public DacfEDIt_edificaciondetalle(
         string ACFid,
         string EDIzona,               
         string EDIdescripicion,                 
         string EDIfactorasignado,                   
         string ACFValorIR,                   
         string ACFTC,
         string ACFCRC,            
         string ACFDEPCRC,         
         string ACFNETOCRC,                   
         string ACFvalorniif,          
         string ACFdepacuniif,      
         string ACFNETOPCGA,     
         string ACFDIFCosto,        
         string ACFINCCosto,         
         string ACFDISCosto,               
         string ACFDIFDEP,             
         string ACFINCDep,           
         string ACFDISDep,         
         string ACFDIFNeta,                 
         string ACFSumDifDed,                
         string ACFSumDifGra,                
         string ACFSumACTDif,                
         string ACFSumPasDif,                
         string ACFcuenta,
         string LOClocal,
         string RVAcodigo)         
    {

        this.ACFid = iACFid;
        this.EDIzona = sEDIzona;
        this.EDIdescripicion = sEDIdescripicion;
        this.EDIfactorasignado = decEDIfactorasignado;
        this.ACFValorIR = decACFValorIR;
        this.ACFTC = decACFTC;
        this.ACFCRC = decACFCRC;
        this.ACFDEPCRC = decACFDEPCRC;
        this.ACFNETOCRC = decACFNETOCRC;
        this.ACFvalorniif = decACFvalorniif;
        this.ACFdepacuniif = decACFdepacuniif;
        this.ACFNETOPCGA = decACFNETOPCGA;
        this.ACFDIFCosto = decACFDIFCosto;
        this.ACFINCCosto = decACFINCCosto;
        this.ACFDISCosto = decACFDISCosto;
        this.ACFDIFDEP = decACFDIFDEP;
        this.ACFINCDep = decACFINCDep;
        this.ACFDISDep = decACFDISDep;
        this.ACFDIFNeta = decACFDIFNeta;
        this.ACFSumDifDed = decACFSumDifDed;
        this.ACFSumDifGra = decACFSumDifGra;
        this.ACFSumACTDif = decACFSumACTDif;
        this.ACFSumPasDif = decACFSumPasDif;
        this.ACFcuenta = sACFid;
        this.LOClocal = sLOClocal;
        this.RVAcodigo = sRVAcodigo; 
	}

/*	public object Clone() {
//		return base.MemberwiseClone();
//	}
*/

    //METODO MOSTRAR
        public DataTable Mostrar() {
           DataTable DtResultado = new DataTable("acfEDIt_edificaciondetalle");
            SqlConnection SqlCon = new SqlConnection();

		try {
            //Codigo
             SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfEDIt_edificaciondetalle";
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
	public string Insertar(DacfEDIt_edificaciondetalle acfEDIt_edificaciondetalle)
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
                SqlCmd.CommandText = "usp_I_acfEDIt_edificaciondetalle";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@iACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Value = acfEDIt_edificaciondetalle.ACFid;
                SqlCmd.Parameters.Add(ParACFid);
                //
                SqlParameter ParEDIzona = new SqlParameter();
                ParEDIzona.ParameterName = "@sEDIzona";
                ParEDIzona.SqlDbType = SqlDbType.Char;
                ParEDIzona.Value = acfEDIt_edificaciondetalle.EDIzona;
                SqlCmd.Parameters.Add(ParEDIzona);
                //
                SqlParameter ParEDIdescripicion = new SqlParameter();
                ParEDIdescripicion.ParameterName = "@sEDIdescripicion";
                ParEDIdescripicion.SqlDbType = SqlDbType.Char;
                ParEDIdescripicion.Value = acfEDIt_edificaciondetalle.EDIdescripicion;
                SqlCmd.Parameters.Add(ParEDIdescripicion);
                //
                SqlParameter ParEDIfactorasignado = new SqlParameter();
                ParEDIfactorasignado.ParameterName = "@decEDIfactorasignado";
                ParEDIfactorasignado.SqlDbType = SqlDbType.Decimal;
                ParEDIfactorasignado.Value = acfEDIt_edificaciondetalle.EDIfactorasignado;
                SqlCmd.Parameters.Add(ParEDIfactorasignado);
                //
                SqlParameter ParACFValorIR = new SqlParameter();
                ParACFValorIR.ParameterName = "@decACFValorIR";
                ParACFValorIR.SqlDbType = SqlDbType.Decimal;
                ParACFValorIR.Value = acfEDIt_edificaciondetalle.ACFValorIR;
                SqlCmd.Parameters.Add(ParACFValorIR);
                //
                SqlParameter ParACFTC = new SqlParameter();
                ParACFTC.ParameterName = "@decACFTC";
                ParACFTC.SqlDbType = SqlDbType.Decimal;
                ParACFTC.Value = acfEDIt_edificaciondetalle.ACFTC;
                SqlCmd.Parameters.Add(ParACFTC);
                //
                SqlParameter ACFCRC = new SqlParameter();
                ACFCRC.ParameterName = "@desACFCRC";
                ACFCRC.SqlDbType = SqlDbType.Decimal;
                ACFCRC.Value = acfEDIt_edificaciondetalle.ACFCRC;
                SqlCmd.Parameters.Add(ACFCRC);
                //
                SqlParameter ParACFDEPCRC = new SqlParameter();
                ParACFDEPCRC.ParameterName = "@decACFDEPCRC";
                ParACFDEPCRC.SqlDbType = SqlDbType.Decimal;
                ParACFDEPCRC.Value = acfEDIt_edificaciondetalle.ACFDEPCRC;
                SqlCmd.Parameters.Add(ParACFDEPCRC);
                //
                SqlParameter ParACFNETOCRC = new SqlParameter();
                ParACFNETOCRC.ParameterName = "@decACFNETOCRC";
                ParACFNETOCRC.SqlDbType = SqlDbType.Decimal;
                ParACFNETOCRC.Value = acfEDIt_edificaciondetalle.ACFNETOCRC;
                SqlCmd.Parameters.Add(ParACFNETOCRC);
                //
                SqlParameter ParACFvalorniif = new SqlParameter();
                ParACFvalorniif.ParameterName = "@decACFvalorniif";
                ParACFvalorniif.SqlDbType = SqlDbType.Decimal;
                ParACFvalorniif.Value = acfEDIt_edificaciondetalle.ACFvalorniif;
                SqlCmd.Parameters.Add(ParACFvalorniif);
                //
                SqlParameter ParACFdepacuniif = new SqlParameter();
                ParACFdepacuniif.ParameterName = "@decACFdepacuniif";
                ParACFdepacuniif.SqlDbType = SqlDbType.Decimal;
                ParACFdepacuniif.Value = acfEDIt_edificaciondetalle.ACFdepacuniif;
                SqlCmd.Parameters.Add(ParACFdepacuniif);
                //
                SqlParameter ParACFNETOPCGA = new SqlParameter();
                ParACFNETOPCGA.ParameterName = "@decACFNETOPCGA";
                ParACFNETOPCGA.SqlDbType = SqlDbType.Decimal;
                ParACFNETOPCGA.Value = acfEDIt_edificaciondetalle.ACFNETOPCGA;
                SqlCmd.Parameters.Add(ParACFNETOPCGA);
                //
                SqlParameter ParACFDIFCosto = new SqlParameter();
                ParACFDIFCosto.ParameterName = "@decACFDIFCosto";
                ParACFDIFCosto.SqlDbType = SqlDbType.Decimal;
                ParACFDIFCosto.Value = acfEDIt_edificaciondetalle.ACFDIFCosto;
                SqlCmd.Parameters.Add(ParACFDIFCosto);
                //
                SqlParameter ParACFINCCosto = new SqlParameter();
                ParACFINCCosto.ParameterName = "@decACFINCCosto";
                ParACFINCCosto.SqlDbType = SqlDbType.Decimal;
                ParACFINCCosto.Value = acfEDIt_edificaciondetalle.ACFINCCosto;
                SqlCmd.Parameters.Add(ParACFINCCosto);
                //
                SqlParameter ParACFDISCosto = new SqlParameter();
                ParACFDISCosto.ParameterName = "@decACFDISCosto";
                ParACFDISCosto.SqlDbType = SqlDbType.Decimal;
                ParACFDISCosto.Value = acfEDIt_edificaciondetalle.ACFDISCosto;
                SqlCmd.Parameters.Add(ParACFDISCosto);
                //
                SqlParameter ParACFDIFDEP = new SqlParameter();
                ParACFDIFDEP.ParameterName = "@decACFDIFDEP";
                ParACFDIFDEP.SqlDbType = SqlDbType.Decimal;
                ParACFDIFDEP.Value = acfEDIt_edificaciondetalle.ACFDIFDEP;
                SqlCmd.Parameters.Add(ParACFDIFDEP);
                //
                SqlParameter ParACFINCDep = new SqlParameter();
                ParACFINCDep.ParameterName = "@decACFINCDep";
                ParACFINCDep.SqlDbType = SqlDbType.Decimal;
                ParACFINCDep.Value = acfEDIt_edificaciondetalle.ACFINCDep;
                SqlCmd.Parameters.Add(ParACFINCDep);
                //
                SqlParameter ParACFDISDep = new SqlParameter();
                ParACFDISDep.ParameterName = "@decACFDISDep";
                ParACFDISDep.SqlDbType = SqlDbType.Decimal;
                ParACFDISDep.Value = acfEDIt_edificaciondetalle.ACFDISDep;
                SqlCmd.Parameters.Add(ParACFDISDep);
                //
                SqlParameter ParACFDIFNeta = new SqlParameter();
                ParACFDIFNeta.ParameterName = "@decACFDIFNeta";
                ParACFDIFNeta.SqlDbType = SqlDbType.Decimal;
                ParACFDIFNeta.Value = acfEDIt_edificaciondetalle.ACFDIFNeta;
                SqlCmd.Parameters.Add(ParACFDIFNeta);
                //
                SqlParameter ParACFSumDifDed = new SqlParameter();
                ParACFSumDifDed.ParameterName = "@decACFSumDifDed";
                ParACFSumDifDed.SqlDbType = SqlDbType.Decimal;
                ParACFSumDifDed.Value = acfEDIt_edificaciondetalle.ACFSumDifDed;
                SqlCmd.Parameters.Add(ParACFSumDifDed);
                //
                SqlParameter ParACFSumDifGra = new SqlParameter();
                ParACFSumDifGra.ParameterName = "@decACFSumDifGra";
                ParACFSumDifGra.SqlDbType = SqlDbType.Decimal;
                ParACFSumDifGra.Value = acfEDIt_edificaciondetalle.ACFSumDifGra;
                SqlCmd.Parameters.Add(ParACFSumDifGra);
                //
                SqlParameter ParACFSumACTDif = new SqlParameter();
                ParACFSumACTDif.ParameterName = "@decACFSumACTDif";
                ParACFSumACTDif.SqlDbType = SqlDbType.Decimal;
                ParACFSumACTDif.Value = acfEDIt_edificaciondetalle.ACFSumACTDif;
                SqlCmd.Parameters.Add(ParACFSumACTDif);
                //
                SqlParameter ParACFSumPasDif = new SqlParameter();
                ParACFSumPasDif.ParameterName = "@decACFSumPasDif";
                ParACFSumPasDif.SqlDbType = SqlDbType.Decimal;
                ParACFSumPasDif.Value = acfEDIt_edificaciondetalle.ACFSumPasDif;
                SqlCmd.Parameters.Add(ParACFSumPasDif);
                //
                SqlParameter ParACFcuenta = new SqlParameter();
                ParACFcuenta.ParameterName = "@iACFcuenta";
                ParACFcuenta.SqlDbType = SqlDbType.Char;
                ParACFcuenta.Value = acfEDIt_edificaciondetalle.ACFcuenta;
                SqlCmd.Parameters.Add(ParACFcuenta);
                //
                SqlParameter ParLOClocal = new SqlParameter();
                ParLOClocal.ParameterName = "@sLOClocal";
                ParLOClocal.SqlDbType = SqlDbType.Char;
                ParLOClocal.Value = acfEDIt_edificaciondetalle.LOClocal;
                SqlCmd.Parameters.Add(ParLOClocal);
                //
                SqlParameter ParRVAcodigo = new SqlParameter();
                ParRVAcodigo.ParameterName = "@sRVAcodigo";
                ParRVAcodigo.SqlDbType = SqlDbType.Char;
                ParRVAcodigo.Value = acfEDIt_edificaciondetalle.RVAcodigo;
                SqlCmd.Parameters.Add(ParRVAcodigo);
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
	public string Editar(DacfEDIt_edificaciondetalle acfEDIt_edificaciondetalle) {
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
                SqlCmd.CommandText = "usp_U_acfEDIt_edificaciondetalle";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@iACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Value = acfEDIt_edificaciondetalle.ACFid;
                SqlCmd.Parameters.Add(ParACFid);
                //
                SqlParameter ParEDIzona = new SqlParameter();
                ParEDIzona.ParameterName = "@sEDIzona";
                ParEDIzona.SqlDbType = SqlDbType.Char;
                ParEDIzona.Value = acfEDIt_edificaciondetalle.EDIzona;
                SqlCmd.Parameters.Add(ParEDIzona);
                //
                SqlParameter ParEDIdescripicion = new SqlParameter();
                ParEDIdescripicion.ParameterName = "@sEDIdescripicion";
                ParEDIdescripicion.SqlDbType = SqlDbType.Char;
                ParEDIdescripicion.Value = acfEDIt_edificaciondetalle.EDIdescripicion;
                SqlCmd.Parameters.Add(ParEDIdescripicion);
                //
                SqlParameter ParEDIfactorasignado = new SqlParameter();
                ParEDIfactorasignado.ParameterName = "@decEDIfactorasignado";
                ParEDIfactorasignado.SqlDbType = SqlDbType.Decimal;
                ParEDIfactorasignado.Value = acfEDIt_edificaciondetalle.EDIfactorasignado;
                SqlCmd.Parameters.Add(ParEDIfactorasignado);
                //
                SqlParameter ParACFValorIR = new SqlParameter();
                ParACFValorIR.ParameterName = "@decACFValorIR";
                ParACFValorIR.SqlDbType = SqlDbType.Decimal;
                ParACFValorIR.Value = acfEDIt_edificaciondetalle.ACFValorIR;
                SqlCmd.Parameters.Add(ParACFValorIR);
                //
                SqlParameter ParACFTC = new SqlParameter();
                ParACFTC.ParameterName = "@decACFTC";
                ParACFTC.SqlDbType = SqlDbType.Decimal;
                ParACFTC.Value = acfEDIt_edificaciondetalle.ACFTC;
                SqlCmd.Parameters.Add(ParACFTC);
                //
                SqlParameter ACFCRC = new SqlParameter();
                ACFCRC.ParameterName = "@desACFCRC";
                ACFCRC.SqlDbType = SqlDbType.Decimal;
                ACFCRC.Value = acfEDIt_edificaciondetalle.ACFCRC;
                SqlCmd.Parameters.Add(ACFCRC);
                //
                SqlParameter ParACFDEPCRC = new SqlParameter();
                ParACFDEPCRC.ParameterName = "@decACFDEPCRC";
                ParACFDEPCRC.SqlDbType = SqlDbType.Decimal;
                ParACFDEPCRC.Value = acfEDIt_edificaciondetalle.ACFDEPCRC;
                SqlCmd.Parameters.Add(ParACFDEPCRC);
                //
                SqlParameter ParACFNETOCRC = new SqlParameter();
                ParACFNETOCRC.ParameterName = "@decACFNETOCRC";
                ParACFNETOCRC.SqlDbType = SqlDbType.Decimal;
                ParACFNETOCRC.Value = acfEDIt_edificaciondetalle.ACFNETOCRC;
                SqlCmd.Parameters.Add(ParACFNETOCRC);
                //
                SqlParameter ParACFvalorniif = new SqlParameter();
                ParACFvalorniif.ParameterName = "@decACFvalorniif";
                ParACFvalorniif.SqlDbType = SqlDbType.Decimal;
                ParACFvalorniif.Value = acfEDIt_edificaciondetalle.ACFvalorniif;
                SqlCmd.Parameters.Add(ParACFvalorniif);
                //
                SqlParameter ParACFdepacuniif = new SqlParameter();
                ParACFdepacuniif.ParameterName = "@decACFdepacuniif";
                ParACFdepacuniif.SqlDbType = SqlDbType.Decimal;
                ParACFdepacuniif.Value = acfEDIt_edificaciondetalle.ACFdepacuniif;
                SqlCmd.Parameters.Add(ParACFdepacuniif);
                //
                SqlParameter ParACFNETOPCGA = new SqlParameter();
                ParACFNETOPCGA.ParameterName = "@decACFNETOPCGA";
                ParACFNETOPCGA.SqlDbType = SqlDbType.Decimal;
                ParACFNETOPCGA.Value = acfEDIt_edificaciondetalle.ACFNETOPCGA;
                SqlCmd.Parameters.Add(ParACFNETOPCGA);
                //
                SqlParameter ParACFDIFCosto = new SqlParameter();
                ParACFDIFCosto.ParameterName = "@decACFDIFCosto";
                ParACFDIFCosto.SqlDbType = SqlDbType.Decimal;
                ParACFDIFCosto.Value = acfEDIt_edificaciondetalle.ACFDIFCosto;
                SqlCmd.Parameters.Add(ParACFDIFCosto);
                //
                SqlParameter ParACFINCCosto = new SqlParameter();
                ParACFINCCosto.ParameterName = "@decACFINCCosto";
                ParACFINCCosto.SqlDbType = SqlDbType.Decimal;
                ParACFINCCosto.Value = acfEDIt_edificaciondetalle.ACFINCCosto;
                SqlCmd.Parameters.Add(ParACFINCCosto);
                //
                SqlParameter ParACFDISCosto = new SqlParameter();
                ParACFDISCosto.ParameterName = "@decACFDISCosto";
                ParACFDISCosto.SqlDbType = SqlDbType.Decimal;
                ParACFDISCosto.Value = acfEDIt_edificaciondetalle.ACFDISCosto;
                SqlCmd.Parameters.Add(ParACFDISCosto);
                //
                SqlParameter ParACFDIFDEP = new SqlParameter();
                ParACFDIFDEP.ParameterName = "@decACFDIFDEP";
                ParACFDIFDEP.SqlDbType = SqlDbType.Decimal;
                ParACFDIFDEP.Value = acfEDIt_edificaciondetalle.ACFDIFDEP;
                SqlCmd.Parameters.Add(ParACFDIFDEP);
                //
                SqlParameter ParACFINCDep = new SqlParameter();
                ParACFINCDep.ParameterName = "@decACFINCDep";
                ParACFINCDep.SqlDbType = SqlDbType.Decimal;
                ParACFINCDep.Value = acfEDIt_edificaciondetalle.ACFINCDep;
                SqlCmd.Parameters.Add(ParACFINCDep);
                //
                SqlParameter ParACFDISDep = new SqlParameter();
                ParACFDISDep.ParameterName = "@decACFDISDep";
                ParACFDISDep.SqlDbType = SqlDbType.Decimal;
                ParACFDISDep.Value = acfEDIt_edificaciondetalle.ACFDISDep;
                SqlCmd.Parameters.Add(ParACFDISDep);
                //
                SqlParameter ParACFDIFNeta = new SqlParameter();
                ParACFDIFNeta.ParameterName = "@decACFDIFNeta";
                ParACFDIFNeta.SqlDbType = SqlDbType.Decimal;
                ParACFDIFNeta.Value = acfEDIt_edificaciondetalle.ACFDIFNeta;
                SqlCmd.Parameters.Add(ParACFDIFNeta);
                //
                SqlParameter ParACFSumDifDed = new SqlParameter();
                ParACFSumDifDed.ParameterName = "@decACFSumDifDed";
                ParACFSumDifDed.SqlDbType = SqlDbType.Decimal;
                ParACFSumDifDed.Value = acfEDIt_edificaciondetalle.ACFSumDifDed;
                SqlCmd.Parameters.Add(ParACFSumDifDed);
                //
                SqlParameter ParACFSumDifGra = new SqlParameter();
                ParACFSumDifGra.ParameterName = "@decACFSumDifGra";
                ParACFSumDifGra.SqlDbType = SqlDbType.Decimal;
                ParACFSumDifGra.Value = acfEDIt_edificaciondetalle.ACFSumDifGra;
                SqlCmd.Parameters.Add(ParACFSumDifGra);
                //
                SqlParameter ParACFSumACTDif = new SqlParameter();
                ParACFSumACTDif.ParameterName = "@decACFSumACTDif";
                ParACFSumACTDif.SqlDbType = SqlDbType.Decimal;
                ParACFSumACTDif.Value = acfEDIt_edificaciondetalle.ACFSumACTDif;
                SqlCmd.Parameters.Add(ParACFSumACTDif);
                //
                SqlParameter ParACFSumPasDif = new SqlParameter();
                ParACFSumPasDif.ParameterName = "@decACFSumPasDif";
                ParACFSumPasDif.SqlDbType = SqlDbType.Decimal;
                ParACFSumPasDif.Value = acfEDIt_edificaciondetalle.ACFSumPasDif;
                SqlCmd.Parameters.Add(ParACFSumPasDif);
                //
                SqlParameter ParACFcuenta = new SqlParameter();
                ParACFcuenta.ParameterName = "@iACFcuenta";
                ParACFcuenta.SqlDbType = SqlDbType.Char;
                ParACFcuenta.Value = acfEDIt_edificaciondetalle.ACFcuenta;
                SqlCmd.Parameters.Add(ParACFcuenta);
                //
                SqlParameter ParLOClocal = new SqlParameter();
                ParLOClocal.ParameterName = "@sLOClocal";
                ParLOClocal.SqlDbType = SqlDbType.Char;
                ParLOClocal.Value = acfEDIt_edificaciondetalle.LOClocal;
                SqlCmd.Parameters.Add(ParLOClocal);
                //
                SqlParameter ParRVAcodigo = new SqlParameter();
                ParRVAcodigo.ParameterName = "@sRVAcodigo";
                ParRVAcodigo.SqlDbType = SqlDbType.Char;
                ParRVAcodigo.Value = acfEDIt_edificaciondetalle.RVAcodigo;
                SqlCmd.Parameters.Add(ParRVAcodigo);
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
	public string Eliminar(DacfEDIt_edificaciondetalle acfEDIt_edificaciondetalle) {
		
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
                SqlCmd.CommandText = "usp_D_acfEDIt_edificaciondetalle";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@sACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Value = acfEDIt_edificaciondetalle.ACFid;
                SqlCmd.Parameters.Add(ParACFid);
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

	public DataTable Buscar(DacfEDIt_edificaciondetalle acfEDIt_edificaciondetalle) {

        DataTable DtResultado = new DataTable("acfEDIt_edificaciondetalle");
            SqlConnection SqlCon = new SqlConnection();


		try {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_acfEDIt_edificaciondetalle";
            SqlCmd.CommandType = CommandType.StoredProcedure;



            SqlParameter ParEDIzona = new SqlParameter();
            ParEDIzona.ParameterName = "@sEDIzona";
            ParEDIzona.SqlDbType = SqlDbType.Char;
            ParEDIzona.Size = 50;
            ParEDIzona.Value = acfEDIt_edificaciondetalle.EDIzona;
            SqlCmd.Parameters.Add(ParEDIzona);

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
