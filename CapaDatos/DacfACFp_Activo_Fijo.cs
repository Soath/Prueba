using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DacfACFp_Activo_Fijo{

        private string iACFid;        
        private string sBUKRS;
        private string sSEGMENT;
        private string sANLKL;
        private string sPERNR;
        private string sCSTid;
        private string sMVMid;
        private string dtACFfmovimiento;
        private string sVNRid;
        private string sACFdescripcion;
        private string dtACFfincorporacion;
        private string decACFfcapitalizacion;
        private string iACFvutiltribanio;
        private string iACFvutiltribdia;
        private string decACFvalortrib;
        private string iACFvutilniifanio;
        private string iACFvutilniifdia;
        private string decACFvalorniif;
        private string sACFdepacutrib;
        private string decACFdepacuniif;
        private string sACFobra;
        //private string sACFord41;
        //private string sACFord42;
        //private string sACFord43;
        //private string sACFord44;
        private string sACFanlue;
        private string decACFfactortrib;
        private string decACFfactorniif;
        private string sACFcuenta;
        private string sACFcuentadep;
        private string sCMPid;
        private string sACFobservacion;
        private string sLIFNR;
        private string sACFnotaingreso;
        private string sACFfechanotaingreso;
        private string sACFordencompra;
        private string dtACFfechaordencompra;
        private string sBLART;
        private string sACFcomprobante;
        private string sKOSTL;
        private string iAMBid;
        private string iUBEid;
        private string dtACFfechacomprobante;
        private string sV_T087U_ANLUE;
        private string sACFtipo_activo;
        private string cACFAnulado;
        private string cACFid_Padre;
        private string cACFtipo_orden;
        private string cOBJid_objeto;
        private string cCRPid_crp;

        public string ACFid
        {
            get { return iACFid; }
            set { iACFid = value; }
        }
        public string ACFtipo_activo
        {
            get { return sACFtipo_activo; }
            set { sACFtipo_activo = value; }
        }
        public string BUKRS
        {
            get { return sBUKRS; }
            set { sBUKRS = value; }
        }
        public string SEGMENT
        {
            get { return sSEGMENT; }
            set { sSEGMENT = value; }
        }
        public string ANLKL
        {
            get { return sANLKL; }
            set { sANLKL = value; }
        }
        public string PERNR
        {
            get { return sPERNR; }
            set { sPERNR = value; }
        }
        public string CSTid
        {
            get { return sCSTid; }
            set { sCSTid = value; }
        }
        public string MVMid
        {
            get { return sMVMid; }
            set { sMVMid = value; }
        }
        public string ACFfmovimiento
        {
            get { return dtACFfmovimiento; }
            set { dtACFfmovimiento = value; }
        }
        public string VNRid
        {
            get { return sVNRid; }
            set { sVNRid = value; }
        }
        public string ACFdescripcion
        {
            get { return sACFdescripcion; }
            set { sACFdescripcion = value; }
        }
        public string ACFfincorporacion
        {
            get { return dtACFfincorporacion; }
            set { dtACFfincorporacion = value; }
        }
        public string ACFfcapitalizacion
        {
            get { return decACFfcapitalizacion; }
            set { decACFfcapitalizacion = value; }
        }
        public string ACFvutiltribanio
        {
            get { return iACFvutiltribanio; }
            set { iACFvutiltribanio = value; }
        }
        public string ACFvutiltribdia
        {
            get { return iACFvutiltribdia; }
            set { iACFvutiltribdia = value; }
        }
        public string ACFvalortrib
        {
            get { return decACFvalortrib; }
            set { decACFvalortrib = value; }
        }
        public string ACFvutilniifanio
        {
            get { return iACFvutilniifanio; }
            set { iACFvutilniifanio = value; }
        }
        public string ACFvutilniifdia
        {
            get { return iACFvutilniifdia; }
            set { iACFvutilniifdia = value; }
        }
        public string ACFvalorniif
        {
            get { return decACFvalorniif; }
            set { decACFvalorniif = value; }
        }
        public string ACFdepacutrib
        {
            get { return sACFdepacutrib; }
            set { sACFdepacutrib = value; }
        }
        public string ACFdepacuniif
        {
            get { return decACFdepacuniif; }
            set { decACFdepacuniif = value; }
        }
        public string ACFobra
        {
            get { return sACFobra; }
            set { sACFobra = value; }
        }
        //public string ACFord41
        //{
        //    get { return sACFord41; }
        //    set { sACFord41 = value; }
        //}
        //public string ACFord42
        //{
        //    get { return sACFord42; }
        //    set { sACFord42 = value; }
        //}
        //public string ACFord43
        //{
        //    get { return sACFord43; }
        //    set { sACFord43 = value; }
        //}
        //public string ACFord44
        //{
        //    get { return sACFord44; }
        //    set { sACFord44 = value; }
        //}
        public string ACFanlue
        {
            get { return sACFanlue; }
            set { sACFanlue = value; }
        }
        public string ACFfactortrib
        {
            get { return decACFfactortrib; }
            set { decACFfactortrib = value; }
        }
        public string ACFfactorniif
        {
            get { return decACFfactorniif; }
            set { decACFfactorniif = value; }
        }
        public string ACFcuenta
        {
            get { return sACFcuenta; }
            set { sACFcuenta = value; }
        }
        public string ACFcuentadep
        {
            get { return sACFcuentadep; }
            set { sACFcuentadep = value; }
        }
        public string CMPid
        {
            get { return sCMPid; }
            set { sCMPid = value; }
        }
        public string ACFobservacion
        {
            get { return sACFobservacion; }
            set { sACFobservacion = value; }
        }
        public string LIFNR
        {
            get { return sLIFNR; }
            set { sLIFNR = value; }
        }
        public string ACFnotaingreso
        {
            get { return sACFnotaingreso; }
            set { sACFnotaingreso = value; }
        }
        public string ACFfechanotaingreso
        {
            get { return sACFfechanotaingreso; }
            set { sACFfechanotaingreso = value; }
        }
        public string ACFordencompra
        {
            get { return sACFordencompra; }
            set { sACFordencompra = value; }
        }
        public string ACFfechaordencompra
        {
            get { return dtACFfechaordencompra; }
            set { dtACFfechaordencompra = value; }
        }
        public string BLART
        {
            get { return sBLART; }
            set { sBLART = value; }
        }
        public string ACFcomprobante
        {
            get { return sACFcomprobante; }
            set { sACFcomprobante = value; }
        }
        public string KOSTL
        {
            get { return sKOSTL; }
            set { sKOSTL = value; }
        }
        public string AMBid
        {
            get { return iAMBid; }
            set { iAMBid = value; }
        }
        public string UBEid
        {
            get { return iUBEid; }
            set { iUBEid = value; }
        }
        public string ACFfechacomprobante
        {
            get { return dtACFfechacomprobante; }
            set { dtACFfechacomprobante = value; }
        }
        public string V_T087U_ANLUE
        {
            get { return sV_T087U_ANLUE; }
            set { sV_T087U_ANLUE = value; }
        }
        public string ACFAnulado
        {
            get { return cACFAnulado; }
            set { cACFAnulado = value; }
        }

        public string ACFid_Padre
        {
            get { return cACFid_Padre; }
            set { cACFid_Padre = value; }
        }

        public string ACFtipo_orden
        {
            get { return cACFtipo_orden; }
            set { cACFtipo_orden = value; }
        }

        public string OBJid_objeto
        {
            get { return cOBJid_objeto; }
            set { cOBJid_objeto = value; }
        }

        public string CRPid_crp
        {
            get { return cCRPid_crp; }
            set { cCRPid_crp = value; }
        }

        //Constructor vacío
        public DacfACFp_Activo_Fijo(){
	}
        //Constructor con parámetros
    public DacfACFp_Activo_Fijo(
         string ACFid,         
         string BUKRS,               
         string SEGMENT,                 
         string ANLKL,                   
         string PERNR,                   
         string CSTid,                   
         string MVMid,                   
         string ACFfmovimiento,         
         string VNRid,                   
         string ACFdescripcion,          
         string ACFfincorporacion,      
         string ACFfcapitalizacion,     
         string ACFvutiltribanio,        
         string ACFvutiltribdia,         
         string ACFvalortrib,          
         string ACFvutilniifanio,        
         string ACFvutilniifdia,         
         string ACFvalorniif,          
         string ACFdepacutrib,           
         string ACFdepacuniif,         
         string ACFobra,                 
         //string ACFord41,                
         //string ACFord42,                
         //string ACFord43,                
         //string ACFord44,                
         string ACFanlue,                
         string ACFfactortrib,         
         string ACFfactorniif,         
         string ACFcuenta,               
         string ACFcuentadep,            
         string CMPid,                   
         string ACFobservacion,          
         string LIFNR,                   
         string ACFnotaingreso,          
         string ACFfechanotaingreso,     
         string ACFordencompra,          
         string ACFfechaordencompra,    
         string BLART,                   
         string ACFcomprobante,          
         string KOSTL,                   
         string AMBid,                   
         string UBEid,                   
         string ACFfechacomprobante,    
         string V_T087U_ANLUE,
         string ACFtipo_activo,
         string ACFAnulado,
         string ACFid_Padre,
         string ACFtipo_orden,
         string OBJid_objeto,
         string CRPid_crp
         )         
    {

        this.ACFid = iACFid;        
        this.BUKRS = sBUKRS;
        this.SEGMENT = sSEGMENT;
        this.ANLKL = sANLKL;
        this.PERNR = sPERNR;
        this.CSTid = sCSTid;
        this.MVMid = sMVMid;
        this.ACFfmovimiento = dtACFfmovimiento;
        this.VNRid = sVNRid;
        this.ACFdescripcion = sACFdescripcion;
        this.ACFfincorporacion = dtACFfincorporacion;
        this.ACFfcapitalizacion = decACFfcapitalizacion;
        this.ACFvutiltribanio = iACFvutiltribanio;
        this.ACFvutiltribdia = iACFvutiltribdia;
        this.ACFvalortrib = decACFvalortrib;
        this.ACFvutilniifanio = iACFvutilniifanio;
        this.ACFvutilniifdia = iACFvutilniifdia;
        this.ACFvalorniif = decACFvalorniif;
        this.ACFdepacutrib = sACFdepacutrib;
        this.ACFdepacuniif = decACFdepacuniif;
        this.ACFobra = sACFobra;
        //this.ACFord41 = sACFord41;
        //this.ACFord42 = sACFord42;
        //this.ACFord43 = sACFord43;
        //this.ACFord44 = sACFord44;
        this.ACFanlue = sACFanlue;
        this.ACFfactortrib = decACFfactortrib;
        this.ACFfactorniif = decACFfactorniif;
        this.ACFcuenta = sACFcuenta;
        this.ACFcuentadep = sACFcuentadep;
        this.CMPid = sCMPid;
        this.ACFobservacion = sACFobservacion;
        this.LIFNR = sLIFNR;
        this.ACFnotaingreso = sACFnotaingreso;
        this.ACFfechanotaingreso = sACFfechanotaingreso;
        this.ACFordencompra = sACFordencompra;
        this.ACFfechaordencompra = dtACFfechaordencompra;
        this.BLART = sBLART;
        this.ACFcomprobante = sACFcomprobante;
        this.KOSTL = sKOSTL;
        this.AMBid = iAMBid;
        this.UBEid = iUBEid;
        this.ACFfechacomprobante = dtACFfechacomprobante;
        this.V_T087U_ANLUE = sV_T087U_ANLUE;
        this.ACFtipo_activo = sACFtipo_activo;
        this.ACFAnulado = cACFAnulado;
        this.ACFid_Padre = cACFid_Padre;
        this.ACFtipo_orden = cACFtipo_orden;
        this.OBJid_objeto = cOBJid_objeto;
        this.CRPid_crp = cCRPid_crp;

    }
	public object Clone() {
		return base.MemberwiseClone();
	}

        public DataTable Top() {
                        
            DataTable DtResultado = new DataTable("acfACFp_Activo_Fijo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_T_acfACFp_Activo_Fijo";
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
            DataTable DtResultado = new DataTable("acfACFp_Activo_Fijo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_P_acfACFp_Activo_Fijo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@ACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Size = 50;
                ParACFid.Value = ACFid;
                SqlCmd.Parameters.Add(ParACFid);

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
            DataTable DtResultado = new DataTable("acfACFp_Activo_Fijo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_N_acfACFp_Activo_Fijo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@ACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Size = 50;
                ParACFid.Value = ACFid;
                SqlCmd.Parameters.Add(ParACFid);


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
            DataTable DtResultado = new DataTable("acfACFp_Activo_Fijo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_L_acfACFp_Activo_Fijo";
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

    //METODO MOSTRAR
        public DataTable Mostrar() {
           DataTable DtResultado = new DataTable("acfACFp_Activo_Fijo");
            SqlConnection SqlCon = new SqlConnection();

		try {
            //Codigo
             SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfACFp_Activo_Fijo";
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

        //METODO MOSTRAR2
        public DataTable Mostrar2(string iACFid)
        {
            DataTable DtResultado = new DataTable("acfACFp_Activo_Fijo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_AjusteValorBien";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@iACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Value = iACFid;
                SqlCmd.Parameters.Add(ParACFid);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //METODO MOSTRAR2
        public DataTable Mostrar5(string AMBid)
        {
            DataTable DtResultado = new DataTable("acfACFp_Activo_Fijo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S5_acfACFp_Activo_Fijo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParAMBid = new SqlParameter();
                ParAMBid.ParameterName = "@AMBid";
                ParAMBid.SqlDbType = SqlDbType.Int;
                ParAMBid.Value = AMBid;
                SqlCmd.Parameters.Add(ParAMBid);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        //METODO MOSTRAR6
        //METODO MOSTRAR2
        public DataTable Mostrar6(string ACFidn, string ACFidm)
        {
            DataTable DtResultado = new DataTable("acfACFp_Activo_Fijo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S6_acfACFp_Activo_Fijo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParACFidn = new SqlParameter();
                ParACFidn.ParameterName = "@ACFidn";
                ParACFidn.SqlDbType = SqlDbType.Int;
                ParACFidn.Value = ACFidn;
                SqlCmd.Parameters.Add(ParACFidn);

                SqlParameter ParACFidm = new SqlParameter();
                ParACFidm.ParameterName = "@ACFidm";
                ParACFidm.SqlDbType = SqlDbType.Int;
                ParACFidm.Value = ACFidm;
                SqlCmd.Parameters.Add(ParACFidm);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        //METODO MOSTRAR 3
        public DataTable Mostrar3()
        {
            DataTable DtResultado = new DataTable("acfACFp_Activo_Fijo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S2_acfACFp_Activo_Fijo";
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
        
        //Ingresar Activo Fijo en Frm Transferencia Activo
        public DataTable IngresarACF(string iACFid)
        {
            DataTable DtResultado = new DataTable("acfACFp_Activo_Fijo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S4_acfACFp_Activo_Fijo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCMPid = new SqlParameter();
                ParCMPid.ParameterName = "@iACFid";
                ParCMPid.SqlDbType = SqlDbType.Int;
                ParCMPid.Value = iACFid;
                SqlCmd.Parameters.Add(ParCMPid);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //METODO MOSTRAR 4
        public DataTable Mostrar4(string CMPid)
        {
            DataTable DtResultado = new DataTable("acfACFp_Activo_Fijo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S3_acfACFp_Activo_Fijo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCMPid = new SqlParameter();
                ParCMPid.ParameterName = "@CMPid";
                ParCMPid.SqlDbType = SqlDbType.Int;
                ParCMPid.Value = CMPid;
                SqlCmd.Parameters.Add(ParCMPid);

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
    public string Insertar(DacfACFp_Activo_Fijo acfACFp_Activo_Fijo)
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
            SqlCmd.CommandText = "usp_I_acfACFp_Activo_Fijo";
            SqlCmd.CommandType = CommandType.StoredProcedure;
            //

            SqlParameter ParACFid = new SqlParameter();
            ParACFid.ParameterName = "@iACFid";
            ParACFid.SqlDbType = SqlDbType.Int;
            ParACFid.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFid);
            SqlCmd.Parameters.Add(ParACFid);
            //
            SqlParameter ParBUKRS = new SqlParameter();
            ParBUKRS.ParameterName = "@sBUKRS";
            ParBUKRS.SqlDbType = SqlDbType.Char;
            ParBUKRS.Value = acfACFp_Activo_Fijo.BUKRS;
            SqlCmd.Parameters.Add(ParBUKRS);
            //
            SqlParameter ParSEGMENT = new SqlParameter();
            ParSEGMENT.ParameterName = "@sSEGMENT";
            ParSEGMENT.SqlDbType = SqlDbType.Char;
            ParSEGMENT.Value = acfACFp_Activo_Fijo.SEGMENT;
            SqlCmd.Parameters.Add(ParSEGMENT);
            //
            SqlParameter ParANLKL = new SqlParameter();
            ParANLKL.ParameterName = "@sANLKL";
            ParANLKL.SqlDbType = SqlDbType.Char;
            ParANLKL.Value = acfACFp_Activo_Fijo.ANLKL;
            SqlCmd.Parameters.Add(ParANLKL);
            //
            SqlParameter ParPERNR = new SqlParameter();
            ParPERNR.ParameterName = "@sPERNR";
            ParPERNR.SqlDbType = SqlDbType.Char;
            ParPERNR.Value = acfACFp_Activo_Fijo.PERNR;
            SqlCmd.Parameters.Add(ParPERNR);
            //
            SqlParameter ParCSTid = new SqlParameter();
            ParCSTid.ParameterName = "@sCSTid";
            ParCSTid.SqlDbType = SqlDbType.Char;
            ParCSTid.Value = acfACFp_Activo_Fijo.CSTid;
            SqlCmd.Parameters.Add(ParCSTid);
            //
            SqlParameter ParMVMid = new SqlParameter();
            ParMVMid.ParameterName = "@sMVMid";
            ParMVMid.SqlDbType = SqlDbType.Char;
            ParMVMid.Value = acfACFp_Activo_Fijo.MVMid;
            SqlCmd.Parameters.Add(ParMVMid);
            //
            SqlParameter ParACFfmovimiento = new SqlParameter();
            ParACFfmovimiento.ParameterName = "@dtACFfmovimiento";
            ParACFfmovimiento.SqlDbType = SqlDbType.DateTime;
            ParACFfmovimiento.Value = Convert.ToDateTime(acfACFp_Activo_Fijo.ACFfmovimiento);
            SqlCmd.Parameters.Add(ParACFfmovimiento);

            //
            SqlParameter ParVNRid = new SqlParameter();
            ParVNRid.ParameterName = "@sVNRid";
            ParVNRid.SqlDbType = SqlDbType.Char;
            ParVNRid.Value = acfACFp_Activo_Fijo.VNRid;
            SqlCmd.Parameters.Add(ParVNRid);
            //
            SqlParameter ParACFdescripcion = new SqlParameter();
            ParACFdescripcion.ParameterName = "@sACFdescripcion";
            ParACFdescripcion.SqlDbType = SqlDbType.Char;
            ParACFdescripcion.Value = acfACFp_Activo_Fijo.ACFdescripcion;
            SqlCmd.Parameters.Add(ParACFdescripcion);
            //
            SqlParameter ParACFfincorporacion = new SqlParameter();
            ParACFfincorporacion.ParameterName = "@dtACFfincorporacion";
            ParACFfincorporacion.SqlDbType = SqlDbType.DateTime;
            ParACFfincorporacion.Value = Convert.ToDateTime(acfACFp_Activo_Fijo.ACFfincorporacion);
            SqlCmd.Parameters.Add(ParACFfincorporacion);
            //
            SqlParameter ParACFfcapitalizacion = new SqlParameter();
            ParACFfcapitalizacion.ParameterName = "@decACFfcapitalizacion";
            ParACFfcapitalizacion.SqlDbType = SqlDbType.Decimal;
            ParACFfcapitalizacion.Value = Convert.ToDecimal(acfACFp_Activo_Fijo.ACFfcapitalizacion);
            SqlCmd.Parameters.Add(ParACFfcapitalizacion);
            //
            SqlParameter ParACFvutiltribanio = new SqlParameter();
            ParACFvutiltribanio.ParameterName = "@iACFvutiltribanio";
            ParACFvutiltribanio.SqlDbType = SqlDbType.Int;
            ParACFvutiltribanio.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutiltribanio);
            SqlCmd.Parameters.Add(ParACFvutiltribanio);
            //
            SqlParameter ParACFvutiltribdia = new SqlParameter();
            ParACFvutiltribdia.ParameterName = "@iACFvutiltribdia";
            ParACFvutiltribdia.SqlDbType = SqlDbType.Int;
            ParACFvutiltribdia.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutiltribdia);
            SqlCmd.Parameters.Add(ParACFvutiltribdia);
            //
            SqlParameter ParACFvalortrib = new SqlParameter();
            ParACFvalortrib.ParameterName = "@decACFvalortrib";
            ParACFvalortrib.SqlDbType = SqlDbType.Decimal;
            ParACFvalortrib.Value = Convert.ToDecimal(acfACFp_Activo_Fijo.ACFvalortrib);
            SqlCmd.Parameters.Add(ParACFvalortrib);
            //
            SqlParameter ParACFvutilniifanio = new SqlParameter();
            ParACFvutilniifanio.ParameterName = "@iACFvutilniifanio";
            ParACFvutilniifanio.SqlDbType = SqlDbType.Int;
            ParACFvutilniifanio.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutilniifanio);
            SqlCmd.Parameters.Add(ParACFvutilniifanio);
            //
            SqlParameter ParACFvutilniifdia = new SqlParameter();
            ParACFvutilniifdia.ParameterName = "@iACFvutilniifdia";
            ParACFvutilniifdia.SqlDbType = SqlDbType.Int;
            ParACFvutilniifdia.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutilniifdia);
            SqlCmd.Parameters.Add(ParACFvutilniifdia);
            //
            SqlParameter ParACFvalorniif = new SqlParameter();
            ParACFvalorniif.ParameterName = "@decACFvalorniif";
            ParACFvalorniif.SqlDbType = SqlDbType.Decimal;
            ParACFvalorniif.Value = Convert.ToDecimal(acfACFp_Activo_Fijo.ACFvalorniif);
            SqlCmd.Parameters.Add(ParACFvalorniif);
            //
            SqlParameter ParACFdepacutrib = new SqlParameter();
            ParACFdepacutrib.ParameterName = "@sACFdepacutrib";
            ParACFdepacutrib.SqlDbType = SqlDbType.Char;
            ParACFdepacutrib.Value = acfACFp_Activo_Fijo.ACFdepacutrib;
            SqlCmd.Parameters.Add(ParACFdepacutrib);
            //
            SqlParameter ParACFdepacuniif = new SqlParameter();
            ParACFdepacuniif.ParameterName = "@decACFdepacuniif";
            ParACFdepacuniif.SqlDbType = SqlDbType.Decimal;
            ParACFdepacuniif.Value = Convert.ToDecimal(acfACFp_Activo_Fijo.ACFdepacuniif);
            SqlCmd.Parameters.Add(ParACFdepacuniif);
            //
            SqlParameter ParACFobra = new SqlParameter();
            ParACFobra.ParameterName = "@sACFobra";
            ParACFobra.SqlDbType = SqlDbType.Char;
            ParACFobra.Value = acfACFp_Activo_Fijo.ACFobra;
            SqlCmd.Parameters.Add(ParACFobra);
            //
            //SqlParameter ParACFord41 = new SqlParameter();
            //ParACFord41.ParameterName = "@sACFord41";
            //ParACFord41.SqlDbType = SqlDbType.Char;
            //ParACFord41.Value = acfACFp_Activo_Fijo.ACFord41;
            //SqlCmd.Parameters.Add(ParACFord41);
            ////
            //SqlParameter ParACFord42 = new SqlParameter();
            //ParACFord42.ParameterName = "@sACFord42";
            //ParACFord42.SqlDbType = SqlDbType.Char;
            //ParACFord42.Value = acfACFp_Activo_Fijo.ACFord42;
            //SqlCmd.Parameters.Add(ParACFord42);
            ////
            //SqlParameter ParACFord43 = new SqlParameter();
            //ParACFord43.ParameterName = "@sACFord43";
            //ParACFord43.SqlDbType = SqlDbType.Char;
            //ParACFord43.Value = acfACFp_Activo_Fijo.ACFord43;
            //SqlCmd.Parameters.Add(ParACFord43);
            ////
            //SqlParameter ParACFord44 = new SqlParameter();
            //ParACFord44.ParameterName = "@sACFord44";
            //ParACFord44.SqlDbType = SqlDbType.Char;
            //ParACFord44.Value = acfACFp_Activo_Fijo.ACFord44;
            //SqlCmd.Parameters.Add(ParACFord44);
            //
            SqlParameter ParACFanlue = new SqlParameter();
            ParACFanlue.ParameterName = "@sACFanlue";
            ParACFanlue.SqlDbType = SqlDbType.Char;
            ParACFanlue.Value = acfACFp_Activo_Fijo.ACFanlue;
            SqlCmd.Parameters.Add(ParACFanlue);
            //
            SqlParameter ParACFfactortrib = new SqlParameter();
            ParACFfactortrib.ParameterName = "@decACFfactortrib";
            ParACFfactortrib.SqlDbType = SqlDbType.Decimal;
            ParACFfactortrib.Value = Convert.ToDecimal(acfACFp_Activo_Fijo.ACFfactortrib);
            SqlCmd.Parameters.Add(ParACFfactortrib);
            //
            SqlParameter ParACFfactorniif = new SqlParameter();
            ParACFfactorniif.ParameterName = "@decACFfactorniif";
            ParACFfactorniif.SqlDbType = SqlDbType.Decimal;
            ParACFfactorniif.Value = Convert.ToDecimal(acfACFp_Activo_Fijo.ACFfactorniif);
            SqlCmd.Parameters.Add(ParACFfactorniif);
            //
            SqlParameter ParACFcuenta = new SqlParameter();
            ParACFcuenta.ParameterName = "@sACFcuenta";
            ParACFcuenta.SqlDbType = SqlDbType.Char;
            ParACFcuenta.Value = acfACFp_Activo_Fijo.ACFcuenta;
            SqlCmd.Parameters.Add(ParACFcuenta);
            //
            SqlParameter ParACFcuentadep = new SqlParameter();
            ParACFcuentadep.ParameterName = "@sACFcuentadep";
            ParACFcuentadep.SqlDbType = SqlDbType.Char;
            ParACFcuentadep.Value = acfACFp_Activo_Fijo.ACFcuentadep;
            SqlCmd.Parameters.Add(ParACFcuentadep);
            //
            SqlParameter ParCMPid = new SqlParameter();
            ParCMPid.ParameterName = "@sCMPid";
            ParCMPid.SqlDbType = SqlDbType.Char;
            ParCMPid.Value = acfACFp_Activo_Fijo.CMPid;
            SqlCmd.Parameters.Add(ParCMPid);
            //
            SqlParameter ParACFobservacion = new SqlParameter();
            ParACFobservacion.ParameterName = "@sACFobservacion";
            ParACFobservacion.SqlDbType = SqlDbType.VarChar;
            ParACFobservacion.Value = acfACFp_Activo_Fijo.ACFobservacion;
            SqlCmd.Parameters.Add(ParACFobservacion);
            //
            SqlParameter ParLIFNR = new SqlParameter();
            ParLIFNR.ParameterName = "@sLIFNR";
            ParLIFNR.SqlDbType = SqlDbType.Char;
            ParLIFNR.Value = acfACFp_Activo_Fijo.LIFNR;
            SqlCmd.Parameters.Add(ParLIFNR);
            //
            SqlParameter ParACFnotaingreso = new SqlParameter();
            ParACFnotaingreso.ParameterName = "@sACFnotaingreso";
            ParACFnotaingreso.SqlDbType = SqlDbType.Char;
            ParACFnotaingreso.Value = acfACFp_Activo_Fijo.ACFnotaingreso;
            SqlCmd.Parameters.Add(ParACFnotaingreso);
            //
            SqlParameter ParACFfechanotaingreso = new SqlParameter();
            ParACFfechanotaingreso.ParameterName = "@sACFfechanotaingreso";
            ParACFfechanotaingreso.SqlDbType = SqlDbType.DateTime;
            ParACFfechanotaingreso.Value = Convert.ToDateTime(acfACFp_Activo_Fijo.ACFfechanotaingreso);
            SqlCmd.Parameters.Add(ParACFfechanotaingreso);
            //
            SqlParameter ParACFordencompra = new SqlParameter();
            ParACFordencompra.ParameterName = "@sACFordencompra";
            ParACFordencompra.SqlDbType = SqlDbType.Char;
            ParACFordencompra.Value = acfACFp_Activo_Fijo.ACFordencompra;
            SqlCmd.Parameters.Add(ParACFordencompra);
            //
            SqlParameter ParACFfechaordencompra = new SqlParameter();
            ParACFfechaordencompra.ParameterName = "@dtACFfechaordencompra";
            ParACFfechaordencompra.SqlDbType = SqlDbType.DateTime;
            ParACFfechaordencompra.Value = Convert.ToDateTime(acfACFp_Activo_Fijo.ACFfechaordencompra);
            SqlCmd.Parameters.Add(ParACFfechaordencompra);
            //
            SqlParameter ParBLART = new SqlParameter();
            ParBLART.ParameterName = "@sBLART";
            ParBLART.SqlDbType = SqlDbType.Char;
            ParBLART.Value = acfACFp_Activo_Fijo.BLART;
            SqlCmd.Parameters.Add(ParBLART);
            //
            SqlParameter ParACFcomprobante = new SqlParameter();
            ParACFcomprobante.ParameterName = "@sACFcomprobante";
            ParACFcomprobante.SqlDbType = SqlDbType.Char;
            ParACFcomprobante.Value = acfACFp_Activo_Fijo.ACFcomprobante;
            SqlCmd.Parameters.Add(ParACFcomprobante);
            //
            SqlParameter ParKOSTL = new SqlParameter();
            ParKOSTL.ParameterName = "@sKOSTL";
            ParKOSTL.SqlDbType = SqlDbType.Char;
            ParKOSTL.Value = acfACFp_Activo_Fijo.KOSTL;
            SqlCmd.Parameters.Add(ParKOSTL);
            //
            SqlParameter ParAMBid = new SqlParameter();
            ParAMBid.ParameterName = "@iAMBid";
            ParAMBid.SqlDbType = SqlDbType.Int;
            ParAMBid.Value = Convert.ToInt32(acfACFp_Activo_Fijo.AMBid);
            SqlCmd.Parameters.Add(ParAMBid);
            //
            SqlParameter ParUBEid = new SqlParameter();
            ParUBEid.ParameterName = "@iUBEid";
            ParUBEid.SqlDbType = SqlDbType.Int;
            ParUBEid.Value = Convert.ToInt32(acfACFp_Activo_Fijo.UBEid);
            SqlCmd.Parameters.Add(ParUBEid);
            //
            SqlParameter ParACFfechacomprobante = new SqlParameter();
            ParACFfechacomprobante.ParameterName = "@dtACFfechacomprobante";
            ParACFfechacomprobante.SqlDbType = SqlDbType.DateTime;
            ParACFfechacomprobante.Value = Convert.ToDateTime(acfACFp_Activo_Fijo.ACFfechacomprobante);
            SqlCmd.Parameters.Add(ParACFfechacomprobante);
            //
            SqlParameter ParV_T087U_ANLUE = new SqlParameter();
            ParV_T087U_ANLUE.ParameterName = "@sV_T087U_ANLUE";
            ParV_T087U_ANLUE.SqlDbType = SqlDbType.Char;
            ParV_T087U_ANLUE.Value = acfACFp_Activo_Fijo.V_T087U_ANLUE;
            SqlCmd.Parameters.Add(ParV_T087U_ANLUE);
            //
            SqlParameter ParACFtipo_activo = new SqlParameter();
            ParACFtipo_activo.ParameterName = "@sACFtipo_activo";
            ParACFtipo_activo.SqlDbType = SqlDbType.Char;
            ParACFtipo_activo.Value = acfACFp_Activo_Fijo.ACFtipo_activo;
            SqlCmd.Parameters.Add(ParACFtipo_activo);

            SqlParameter ParACFAnulado = new SqlParameter();
            ParACFAnulado.ParameterName = "@cACFAnulado";
            ParACFAnulado.SqlDbType = SqlDbType.Char;
            ParACFAnulado.Value = cACFAnulado;
            SqlCmd.Parameters.Add(ParACFAnulado);

            SqlParameter ParACFid_Padre = new SqlParameter();
            ParACFid_Padre.ParameterName = "@cACFid_Padre";
            ParACFid_Padre.SqlDbType = SqlDbType.Int;
            ParACFid_Padre.Value = Convert.ToInt32(cACFid_Padre);
            SqlCmd.Parameters.Add(ParACFid_Padre);

                SqlParameter ParACFtipo_orden = new SqlParameter();
                ParACFtipo_orden.ParameterName = "@cACFtipo_orden";
                ParACFtipo_orden.SqlDbType = SqlDbType.VarChar;
                ParACFtipo_orden.Value = acfACFp_Activo_Fijo.cACFtipo_orden;
                SqlCmd.Parameters.Add(ParACFtipo_orden);

                SqlParameter ParOBJid_objeto = new SqlParameter();
                ParOBJid_objeto.ParameterName = "@cOBJid_objeto";
                ParOBJid_objeto.SqlDbType = SqlDbType.Char;
                ParOBJid_objeto.Value = acfACFp_Activo_Fijo.cOBJid_objeto;
                SqlCmd.Parameters.Add(ParOBJid_objeto);

                SqlParameter ParCRPid_crp = new SqlParameter();
                ParCRPid_crp.ParameterName = "@cCRPid_crp";
                ParCRPid_crp.SqlDbType = SqlDbType.Char;
                ParCRPid_crp.Value = acfACFp_Activo_Fijo.cCRPid_crp;
                SqlCmd.Parameters.Add(ParCRPid_crp);


                //
                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Inserto el Registro";		
			
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


        //Metodo Insertar de un Excel(SAP) a la DB Activo Fijo
        public string SAPIMPORT(DacfACFp_Activo_Fijo acfACFp_Activo_Fijo)
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
                SqlCmd.CommandText = "usp_I_SAPIMPORT_ACF";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //

                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@iACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFid);
                SqlCmd.Parameters.Add(ParACFid);
                //
                SqlParameter ParBUKRS = new SqlParameter();
                ParBUKRS.ParameterName = "@sBUKRS";
                ParBUKRS.SqlDbType = SqlDbType.Char;
                ParBUKRS.Value = acfACFp_Activo_Fijo.BUKRS;
                SqlCmd.Parameters.Add(ParBUKRS);
                //
                SqlParameter ParSEGMENT = new SqlParameter();
                ParSEGMENT.ParameterName = "@sSEGMENT";
                ParSEGMENT.SqlDbType = SqlDbType.Char;
                ParSEGMENT.Value = acfACFp_Activo_Fijo.SEGMENT;
                SqlCmd.Parameters.Add(ParSEGMENT);
                //
                SqlParameter ParANLKL = new SqlParameter();
                ParANLKL.ParameterName = "@sANLKL";
                ParANLKL.SqlDbType = SqlDbType.Char;
                ParANLKL.Value = acfACFp_Activo_Fijo.ANLKL;
                SqlCmd.Parameters.Add(ParANLKL);
                //
                SqlParameter ParPERNR = new SqlParameter();
                ParPERNR.ParameterName = "@sPERNR";
                ParPERNR.SqlDbType = SqlDbType.Char;
                ParPERNR.Value = acfACFp_Activo_Fijo.PERNR;
                SqlCmd.Parameters.Add(ParPERNR);
                //
                SqlParameter ParCSTid = new SqlParameter();
                ParCSTid.ParameterName = "@sCSTid";
                ParCSTid.SqlDbType = SqlDbType.Char;
                ParCSTid.Value = acfACFp_Activo_Fijo.CSTid;
                SqlCmd.Parameters.Add(ParCSTid);
                //
                SqlParameter ParMVMid = new SqlParameter();
                ParMVMid.ParameterName = "@sMVMid";
                ParMVMid.SqlDbType = SqlDbType.Char;
                ParMVMid.Value = acfACFp_Activo_Fijo.MVMid;
                SqlCmd.Parameters.Add(ParMVMid);
                //
                //SqlParameter ParACFfmovimiento = new SqlParameter();
                //ParACFfmovimiento.ParameterName = "@dtACFfmovimiento";
                //ParACFfmovimiento.SqlDbType = SqlDbType.DateTime;
                //ParACFfmovimiento.Value = Convert.ToDateTime(acfACFp_Activo_Fijo.ACFfmovimiento);
                //SqlCmd.Parameters.Add(ParACFfmovimiento);

                //
                SqlParameter ParVNRid = new SqlParameter();
                ParVNRid.ParameterName = "@sVNRid";
                ParVNRid.SqlDbType = SqlDbType.Char;
                ParVNRid.Value = acfACFp_Activo_Fijo.VNRid;
                SqlCmd.Parameters.Add(ParVNRid);
                //
                SqlParameter ParACFdescripcion = new SqlParameter();
                ParACFdescripcion.ParameterName = "@sACFdescripcion";
                ParACFdescripcion.SqlDbType = SqlDbType.Char;
                ParACFdescripcion.Value = acfACFp_Activo_Fijo.ACFdescripcion;
                SqlCmd.Parameters.Add(ParACFdescripcion);
                //
                SqlParameter ParACFfincorporacion = new SqlParameter();
                ParACFfincorporacion.ParameterName = "@dtACFfincorporacion";
                ParACFfincorporacion.SqlDbType = SqlDbType.DateTime;
                ParACFfincorporacion.Value = Convert.ToDateTime(acfACFp_Activo_Fijo.ACFfincorporacion);
                SqlCmd.Parameters.Add(ParACFfincorporacion);
                //
                // SqlParameter ParACFfcapitalizacion = new SqlParameter();
                // ParACFfcapitalizacion.ParameterName = "@decACFfcapitalizacion";
                // ParACFfcapitalizacion.SqlDbType = SqlDbType.Decimal;
                // ParACFfcapitalizacion.Value = Convert.ToDecimal(acfACFp_Activo_Fijo.ACFfcapitalizacion);
                // SqlCmd.Parameters.Add(ParACFfcapitalizacion);
                //
                SqlParameter ParACFvutiltribanio = new SqlParameter();
                ParACFvutiltribanio.ParameterName = "@iACFvutiltribanio";
                ParACFvutiltribanio.SqlDbType = SqlDbType.Int;
                ParACFvutiltribanio.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutiltribanio);
                SqlCmd.Parameters.Add(ParACFvutiltribanio);
                //
                SqlParameter ParACFvutiltribdia = new SqlParameter();
                ParACFvutiltribdia.ParameterName = "@iACFvutiltribdia";
                ParACFvutiltribdia.SqlDbType = SqlDbType.Int;
                ParACFvutiltribdia.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutiltribdia);
                SqlCmd.Parameters.Add(ParACFvutiltribdia);
                //
                SqlParameter ParACFvalortrib = new SqlParameter();
                ParACFvalortrib.ParameterName = "@decACFvalortrib";
                ParACFvalortrib.SqlDbType = SqlDbType.Decimal;
                ParACFvalortrib.Value = Convert.ToDecimal(acfACFp_Activo_Fijo.ACFvalortrib);
                SqlCmd.Parameters.Add(ParACFvalortrib);
                //
                SqlParameter ParACFvutilniifanio = new SqlParameter();
                ParACFvutilniifanio.ParameterName = "@iACFvutilniifanio";
                ParACFvutilniifanio.SqlDbType = SqlDbType.Int;
                ParACFvutilniifanio.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutilniifanio);
                SqlCmd.Parameters.Add(ParACFvutilniifanio);
                //
                SqlParameter ParACFvutilniifdia = new SqlParameter();
                ParACFvutilniifdia.ParameterName = "@iACFvutilniifdia";
                ParACFvutilniifdia.SqlDbType = SqlDbType.Int;
                ParACFvutilniifdia.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutilniifdia);
                SqlCmd.Parameters.Add(ParACFvutilniifdia);
                //
                SqlParameter ParACFvalorniif = new SqlParameter();
                ParACFvalorniif.ParameterName = "@decACFvalorniif";
                ParACFvalorniif.SqlDbType = SqlDbType.Decimal;
                ParACFvalorniif.Value = Convert.ToDecimal(acfACFp_Activo_Fijo.ACFvalorniif);
                SqlCmd.Parameters.Add(ParACFvalorniif);
                //
                SqlParameter ParACFdepacutrib = new SqlParameter();
                ParACFdepacutrib.ParameterName = "@sACFdepacutrib";
                ParACFdepacutrib.SqlDbType = SqlDbType.Char;
                ParACFdepacutrib.Value = acfACFp_Activo_Fijo.ACFdepacutrib;
                SqlCmd.Parameters.Add(ParACFdepacutrib);
                //
                SqlParameter ParACFdepacuniif = new SqlParameter();
                ParACFdepacuniif.ParameterName = "@decACFdepacuniif";
                ParACFdepacuniif.SqlDbType = SqlDbType.Decimal;
                ParACFdepacuniif.Value = Convert.ToDecimal(acfACFp_Activo_Fijo.ACFdepacuniif);
                SqlCmd.Parameters.Add(ParACFdepacuniif);
                //
                SqlParameter ParACFobra = new SqlParameter();
                ParACFobra.ParameterName = "@sACFobra";
                ParACFobra.SqlDbType = SqlDbType.Char;
                ParACFobra.Value = acfACFp_Activo_Fijo.ACFobra;
                SqlCmd.Parameters.Add(ParACFobra);
                //
                //SqlParameter ParACFord41 = new SqlParameter();
                //ParACFord41.ParameterName = "@sACFord41";
                //ParACFord41.SqlDbType = SqlDbType.Char;
                //ParACFord41.Value = acfACFp_Activo_Fijo.ACFord41;
                //SqlCmd.Parameters.Add(ParACFord41);
                ////
                //SqlParameter ParACFord42 = new SqlParameter();
                //ParACFord42.ParameterName = "@sACFord42";
                //ParACFord42.SqlDbType = SqlDbType.Char;
                //ParACFord42.Value = acfACFp_Activo_Fijo.ACFord42;
                //SqlCmd.Parameters.Add(ParACFord42);
                ////
                //SqlParameter ParACFord43 = new SqlParameter();
                //ParACFord43.ParameterName = "@sACFord43";
                //ParACFord43.SqlDbType = SqlDbType.Char;
                //ParACFord43.Value = acfACFp_Activo_Fijo.ACFord43;
                //SqlCmd.Parameters.Add(ParACFord43);
                ////
                //SqlParameter ParACFord44 = new SqlParameter();
                //ParACFord44.ParameterName = "@sACFord44";
                //ParACFord44.SqlDbType = SqlDbType.Char;
                //ParACFord44.Value = acfACFp_Activo_Fijo.ACFord44;
                //SqlCmd.Parameters.Add(ParACFord44);
                //
                SqlParameter ParACFanlue = new SqlParameter();
                ParACFanlue.ParameterName = "@sACFanlue";
                ParACFanlue.SqlDbType = SqlDbType.Char;
                ParACFanlue.Value = acfACFp_Activo_Fijo.ACFanlue;
                SqlCmd.Parameters.Add(ParACFanlue);
                //
                // SqlParameter ParACFfactortrib = new SqlParameter();
                // ParACFfactortrib.ParameterName = "@decACFfactortrib";
                // ParACFfactortrib.SqlDbType = SqlDbType.Decimal;
                // ParACFfactortrib.Value = Convert.ToDecimal(acfACFp_Activo_Fijo.ACFfactortrib);
                // SqlCmd.Parameters.Add(ParACFfactortrib);
                // //
                // SqlParameter ParACFfactorniif = new SqlParameter();
                // ParACFfactorniif.ParameterName = "@decACFfactorniif";
                // ParACFfactorniif.SqlDbType = SqlDbType.Decimal;
                // ParACFfactorniif.Value = Convert.ToDecimal(acfACFp_Activo_Fijo.ACFfactorniif);
                // SqlCmd.Parameters.Add(ParACFfactorniif);
                //
                SqlParameter ParACFcuenta = new SqlParameter();
                ParACFcuenta.ParameterName = "@sACFcuenta";
                ParACFcuenta.SqlDbType = SqlDbType.Char;
                ParACFcuenta.Value = acfACFp_Activo_Fijo.ACFcuenta;
                SqlCmd.Parameters.Add(ParACFcuenta);
                //
                SqlParameter ParACFcuentadep = new SqlParameter();
                ParACFcuentadep.ParameterName = "@sACFcuentadep";
                ParACFcuentadep.SqlDbType = SqlDbType.Char;
                ParACFcuentadep.Value = acfACFp_Activo_Fijo.ACFcuentadep;
                SqlCmd.Parameters.Add(ParACFcuentadep);
                //
                SqlParameter ParCMPid = new SqlParameter();
                ParCMPid.ParameterName = "@sCMPid";
                ParCMPid.SqlDbType = SqlDbType.Char;
                ParCMPid.Value = acfACFp_Activo_Fijo.CMPid;
                SqlCmd.Parameters.Add(ParCMPid);
                //
                SqlParameter ParACFobservacion = new SqlParameter();
                ParACFobservacion.ParameterName = "@sACFobservacion";
                ParACFobservacion.SqlDbType = SqlDbType.VarChar;
                ParACFobservacion.Value = acfACFp_Activo_Fijo.ACFobservacion;
                SqlCmd.Parameters.Add(ParACFobservacion);
                //
                SqlParameter ParLIFNR = new SqlParameter();
                ParLIFNR.ParameterName = "@sLIFNR";
                ParLIFNR.SqlDbType = SqlDbType.Char;
                ParLIFNR.Value = acfACFp_Activo_Fijo.LIFNR;
                SqlCmd.Parameters.Add(ParLIFNR);
                //
                SqlParameter ParACFnotaingreso = new SqlParameter();
                ParACFnotaingreso.ParameterName = "@sACFnotaingreso";
                ParACFnotaingreso.SqlDbType = SqlDbType.Char;
                ParACFnotaingreso.Value = acfACFp_Activo_Fijo.ACFnotaingreso;
                SqlCmd.Parameters.Add(ParACFnotaingreso);
                //
                //SqlParameter ParACFfechanotaingreso = new SqlParameter();
                //ParACFfechanotaingreso.ParameterName = "@sACFfechanotaingreso";
                //ParACFfechanotaingreso.SqlDbType = SqlDbType.DateTime;
                //ParACFfechanotaingreso.Value = Convert.ToDateTime(acfACFp_Activo_Fijo.ACFfechanotaingreso);
                //SqlCmd.Parameters.Add(ParACFfechanotaingreso);
                //
                SqlParameter ParACFordencompra = new SqlParameter();
                ParACFordencompra.ParameterName = "@sACFordencompra";
                ParACFordencompra.SqlDbType = SqlDbType.Char;
                ParACFordencompra.Value = acfACFp_Activo_Fijo.ACFordencompra;
                SqlCmd.Parameters.Add(ParACFordencompra);
                //
                SqlParameter ParACFfechaordencompra = new SqlParameter();
                ParACFfechaordencompra.ParameterName = "@dtACFfechaordencompra";
                ParACFfechaordencompra.SqlDbType = SqlDbType.DateTime;
                ParACFfechaordencompra.Value = Convert.ToDateTime(acfACFp_Activo_Fijo.ACFfechaordencompra);
                SqlCmd.Parameters.Add(ParACFfechaordencompra);
                //
                SqlParameter ParBLART = new SqlParameter();
                ParBLART.ParameterName = "@sBLART";
                ParBLART.SqlDbType = SqlDbType.Char;
                ParBLART.Value = acfACFp_Activo_Fijo.BLART;
                SqlCmd.Parameters.Add(ParBLART);
                //
                SqlParameter ParACFcomprobante = new SqlParameter();
                ParACFcomprobante.ParameterName = "@sACFcomprobante";
                ParACFcomprobante.SqlDbType = SqlDbType.Char;
                ParACFcomprobante.Value = acfACFp_Activo_Fijo.ACFcomprobante;
                SqlCmd.Parameters.Add(ParACFcomprobante);
                //
                SqlParameter ParKOSTL = new SqlParameter();
                ParKOSTL.ParameterName = "@sKOSTL";
                ParKOSTL.SqlDbType = SqlDbType.Char;
                ParKOSTL.Value = acfACFp_Activo_Fijo.KOSTL;
                SqlCmd.Parameters.Add(ParKOSTL);
                //
                SqlParameter ParAMBid = new SqlParameter();
                ParAMBid.ParameterName = "@iAMBid";
                ParAMBid.SqlDbType = SqlDbType.Int;
                ParAMBid.Value = Convert.ToInt32(acfACFp_Activo_Fijo.AMBid);
                SqlCmd.Parameters.Add(ParAMBid);
                //
                SqlParameter ParUBEid = new SqlParameter();
                ParUBEid.ParameterName = "@iUBEid";
                ParUBEid.SqlDbType = SqlDbType.Int;
                ParUBEid.Value = Convert.ToInt32(acfACFp_Activo_Fijo.UBEid);
                SqlCmd.Parameters.Add(ParUBEid);
                //
                // SqlParameter ParACFfechacomprobante = new SqlParameter();
                // ParACFfechacomprobante.ParameterName = "@dtACFfechacomprobante";
                // ParACFfechacomprobante.SqlDbType = SqlDbType.DateTime;
                // ParACFfechacomprobante.Value = Convert.ToDateTime(acfACFp_Activo_Fijo.ACFfechacomprobante);
                // SqlCmd.Parameters.Add(ParACFfechacomprobante);
                //
                SqlParameter ParV_T087U_ANLUE = new SqlParameter();
                ParV_T087U_ANLUE.ParameterName = "@sV_T087U_ANLUE";
                ParV_T087U_ANLUE.SqlDbType = SqlDbType.Char;
                ParV_T087U_ANLUE.Value = acfACFp_Activo_Fijo.V_T087U_ANLUE;
                SqlCmd.Parameters.Add(ParV_T087U_ANLUE);
                //
                SqlParameter ParACFtipo_activo = new SqlParameter();
                ParACFtipo_activo.ParameterName = "@sACFtipo_activo";
                ParACFtipo_activo.SqlDbType = SqlDbType.Char;
                ParACFtipo_activo.Value = acfACFp_Activo_Fijo.ACFtipo_activo;
                SqlCmd.Parameters.Add(ParACFtipo_activo);

                SqlParameter ParACFAnulado = new SqlParameter();
                ParACFAnulado.ParameterName = "@cACFAnulado";
                ParACFAnulado.SqlDbType = SqlDbType.Char;
                ParACFAnulado.Value = cACFAnulado;
                SqlCmd.Parameters.Add(ParACFAnulado);

                SqlParameter ParACFid_Padre = new SqlParameter();
                ParACFid_Padre.ParameterName = "@cACFid_Padre";
                ParACFid_Padre.SqlDbType = SqlDbType.Int;
                ParACFid_Padre.Value = Convert.ToInt32(cACFid_Padre);
                SqlCmd.Parameters.Add(ParACFid_Padre);

                SqlParameter ParACFtipo_orden = new SqlParameter();
                ParACFtipo_orden.ParameterName = "@cACFtipo_orden";
                ParACFtipo_orden.SqlDbType = SqlDbType.VarChar;
                ParACFtipo_orden.Value = acfACFp_Activo_Fijo.cACFtipo_orden;
                SqlCmd.Parameters.Add(ParACFtipo_orden);

                SqlParameter ParOBJid_objeto = new SqlParameter();
                ParOBJid_objeto.ParameterName = "@cOBJid_objeto";
                ParOBJid_objeto.SqlDbType = SqlDbType.Char;
                ParOBJid_objeto.Value = acfACFp_Activo_Fijo.cOBJid_objeto;
                SqlCmd.Parameters.Add(ParOBJid_objeto);

                SqlParameter ParCRPid_crp = new SqlParameter();
                ParCRPid_crp.ParameterName = "@cCRPid_crp";
                ParCRPid_crp.SqlDbType = SqlDbType.Char;
                ParCRPid_crp.Value = acfACFp_Activo_Fijo.cCRPid_crp;
                SqlCmd.Parameters.Add(ParCRPid_crp);


                //
                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Inserto el Registro";

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
        //METODO INSERTAR 
        public string Insertar2(DacfACFp_Activo_Fijo acfACFp_Activo_Fijo)
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
                SqlCmd.CommandText = "usp_I2_acfACFp_Activo_Fijo";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //

                SqlParameter ParACFdescripcion = new SqlParameter();
                ParACFdescripcion.ParameterName = "@sACFdescripcion";
                ParACFdescripcion.SqlDbType = SqlDbType.Char;
                ParACFdescripcion.Value = acfACFp_Activo_Fijo.ACFdescripcion;
                SqlCmd.Parameters.Add(ParACFdescripcion);
                //
                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Inserto el Registro";
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


        //METODO INSERTAR para el formulario de BajaEvaluacionTecnica
        public string Editar5(DacfACFp_Activo_Fijo acfACFp_Activo_Fijo)
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
                SqlCmd.CommandText = "usp_U5_acfACFp_Activo_Fijo";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@iACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFid);
                SqlCmd.Parameters.Add(ParACFid);
                //
                //SqlParameter ParACFAnulado = new SqlParameter();
                //ParACFAnulado.ParameterName = "@cACFAnulado";
                //ParACFAnulado.SqlDbType = SqlDbType.Char;
                //ParACFAnulado.Value = cACFAnulado;
                //SqlCmd.Parameters.Add(ParACFAnulado);
                //
                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Modifico el Registro";
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
        public string Editar(DacfACFp_Activo_Fijo acfACFp_Activo_Fijo) {
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
                SqlCmd.CommandText = "usp_U_acfACFp_Activo_Fijo";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //

                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@iACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFid);
                SqlCmd.Parameters.Add(ParACFid);
                //
                SqlParameter ParBUKRS = new SqlParameter();
                ParBUKRS.ParameterName = "@sBUKRS";
                ParBUKRS.SqlDbType = SqlDbType.Char;
                ParBUKRS.Value = acfACFp_Activo_Fijo.BUKRS;
                SqlCmd.Parameters.Add(ParBUKRS);
                //
                SqlParameter ParSEGMENT = new SqlParameter();
                ParSEGMENT.ParameterName = "@sSEGMENT";
                ParSEGMENT.SqlDbType = SqlDbType.Char;
                ParSEGMENT.Value = acfACFp_Activo_Fijo.SEGMENT;
                SqlCmd.Parameters.Add(ParSEGMENT);
                //
                SqlParameter ParANLKL = new SqlParameter();
                ParANLKL.ParameterName = "@sANLKL";
                ParANLKL.SqlDbType = SqlDbType.Char;
                ParANLKL.Value = acfACFp_Activo_Fijo.ANLKL;
                SqlCmd.Parameters.Add(ParANLKL);
                //
                SqlParameter ParPERNR = new SqlParameter();
                ParPERNR.ParameterName = "@sPERNR";
                ParPERNR.SqlDbType = SqlDbType.Char;
                ParPERNR.Value = acfACFp_Activo_Fijo.PERNR;
                SqlCmd.Parameters.Add(ParPERNR);
                //
                SqlParameter ParCSTid = new SqlParameter();
                ParCSTid.ParameterName = "@sCSTid";
                ParCSTid.SqlDbType = SqlDbType.Char;
                ParCSTid.Value = acfACFp_Activo_Fijo.CSTid;
                SqlCmd.Parameters.Add(ParCSTid);
                //
                SqlParameter ParMVMid = new SqlParameter();
                ParMVMid.ParameterName = "@sMVMid";
                ParMVMid.SqlDbType = SqlDbType.Char;
                ParMVMid.Value = acfACFp_Activo_Fijo.MVMid;
                SqlCmd.Parameters.Add(ParMVMid);
                //
                SqlParameter ParACFfmovimiento = new SqlParameter();
                ParACFfmovimiento.ParameterName = "@dtACFfmovimiento";
                ParACFfmovimiento.SqlDbType = SqlDbType.DateTime;
                ParACFfmovimiento.Value = Convert.ToDateTime(acfACFp_Activo_Fijo.ACFfmovimiento);
                SqlCmd.Parameters.Add(ParACFfmovimiento);

                //
                SqlParameter ParVNRid = new SqlParameter();
                ParVNRid.ParameterName = "@sVNRid";
                ParVNRid.SqlDbType = SqlDbType.Char;
                ParVNRid.Value = acfACFp_Activo_Fijo.VNRid;
                SqlCmd.Parameters.Add(ParVNRid);
                //
                SqlParameter ParACFdescripcion = new SqlParameter();
                ParACFdescripcion.ParameterName = "@sACFdescripcion";
                ParACFdescripcion.SqlDbType = SqlDbType.Char;
                ParACFdescripcion.Value = acfACFp_Activo_Fijo.ACFdescripcion;
                SqlCmd.Parameters.Add(ParACFdescripcion);
                //
                SqlParameter ParACFfincorporacion = new SqlParameter();
                ParACFfincorporacion.ParameterName = "@dtACFfincorporacion";
                ParACFfincorporacion.SqlDbType = SqlDbType.DateTime;
                ParACFfincorporacion.Value = Convert.ToDateTime(acfACFp_Activo_Fijo.ACFfincorporacion);
                SqlCmd.Parameters.Add(ParACFfincorporacion);
                //
                SqlParameter ParACFfcapitalizacion = new SqlParameter();
                ParACFfcapitalizacion.ParameterName = "@decACFfcapitalizacion";
                ParACFfcapitalizacion.SqlDbType = SqlDbType.Decimal;
                ParACFfcapitalizacion.Value = Convert.ToDecimal(acfACFp_Activo_Fijo.ACFfcapitalizacion);
                SqlCmd.Parameters.Add(ParACFfcapitalizacion);
                //
                SqlParameter ParACFvutiltribanio = new SqlParameter();
                ParACFvutiltribanio.ParameterName = "@iACFvutiltribanio";
                ParACFvutiltribanio.SqlDbType = SqlDbType.Int;
                ParACFvutiltribanio.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutiltribanio);
                SqlCmd.Parameters.Add(ParACFvutiltribanio);
                //
                SqlParameter ParACFvutiltribdia = new SqlParameter();
                ParACFvutiltribdia.ParameterName = "@iACFvutiltribdia";
                ParACFvutiltribdia.SqlDbType = SqlDbType.Int;
                ParACFvutiltribdia.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutiltribdia);
                SqlCmd.Parameters.Add(ParACFvutiltribdia);
                //
                SqlParameter ParACFvalortrib = new SqlParameter();
                ParACFvalortrib.ParameterName = "@decACFvalortrib";
                ParACFvalortrib.SqlDbType = SqlDbType.Decimal;
                ParACFvalortrib.Value = Convert.ToDecimal(acfACFp_Activo_Fijo.ACFvalortrib);
                SqlCmd.Parameters.Add(ParACFvalortrib);
                //
                SqlParameter ParACFvutilniifanio = new SqlParameter();
                ParACFvutilniifanio.ParameterName = "@iACFvutilniifanio";
                ParACFvutilniifanio.SqlDbType = SqlDbType.Int;
                ParACFvutilniifanio.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutilniifanio);
                SqlCmd.Parameters.Add(ParACFvutilniifanio);
                //
                SqlParameter ParACFvutilniifdia = new SqlParameter();
                ParACFvutilniifdia.ParameterName = "@iACFvutilniifdia";
                ParACFvutilniifdia.SqlDbType = SqlDbType.Int;
                ParACFvutilniifdia.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutilniifdia);
                SqlCmd.Parameters.Add(ParACFvutilniifdia);
                //
                SqlParameter ParACFvalorniif = new SqlParameter();
                ParACFvalorniif.ParameterName = "@decACFvalorniif";
                ParACFvalorniif.SqlDbType = SqlDbType.Decimal;
                ParACFvalorniif.Value = Convert.ToDecimal(acfACFp_Activo_Fijo.ACFvalorniif);
                SqlCmd.Parameters.Add(ParACFvalorniif);
                //
                SqlParameter ParACFdepacutrib = new SqlParameter();
                ParACFdepacutrib.ParameterName = "@sACFdepacutrib";
                ParACFdepacutrib.SqlDbType = SqlDbType.Char;
                ParACFdepacutrib.Value = acfACFp_Activo_Fijo.ACFdepacutrib;
                SqlCmd.Parameters.Add(ParACFdepacutrib);
                //
                SqlParameter ParACFdepacuniif = new SqlParameter();
                ParACFdepacuniif.ParameterName = "@decACFdepacuniif";
                ParACFdepacuniif.SqlDbType = SqlDbType.Decimal;
                ParACFdepacuniif.Value = Convert.ToDecimal(acfACFp_Activo_Fijo.ACFdepacuniif);
                SqlCmd.Parameters.Add(ParACFdepacuniif);
                //
                SqlParameter ParACFobra = new SqlParameter();
                ParACFobra.ParameterName = "@sACFobra";
                ParACFobra.SqlDbType = SqlDbType.Char;
                ParACFobra.Value = acfACFp_Activo_Fijo.ACFobra;
                SqlCmd.Parameters.Add(ParACFobra);
                //
                //SqlParameter ParACFord41 = new SqlParameter();
                //ParACFord41.ParameterName = "@sACFord41";
                //ParACFord41.SqlDbType = SqlDbType.Char;
                //ParACFord41.Value = acfACFp_Activo_Fijo.ACFord41;
                //SqlCmd.Parameters.Add(ParACFord41);
                ////
                //SqlParameter ParACFord42 = new SqlParameter();
                //ParACFord42.ParameterName = "@sACFord42";
                //ParACFord42.SqlDbType = SqlDbType.Char;
                //ParACFord42.Value = acfACFp_Activo_Fijo.ACFord42;
                //SqlCmd.Parameters.Add(ParACFord42);
                ////
                //SqlParameter ParACFord43 = new SqlParameter();
                //ParACFord43.ParameterName = "@sACFord43";
                //ParACFord43.SqlDbType = SqlDbType.Char;
                //ParACFord43.Value = acfACFp_Activo_Fijo.ACFord43;
                //SqlCmd.Parameters.Add(ParACFord43);
                ////
                //SqlParameter ParACFord44 = new SqlParameter();
                //ParACFord44.ParameterName = "@sACFord44";
                //ParACFord44.SqlDbType = SqlDbType.Char;
                //ParACFord44.Value = acfACFp_Activo_Fijo.ACFord44;
                //SqlCmd.Parameters.Add(ParACFord44);
                //
                SqlParameter ParACFanlue = new SqlParameter();
                ParACFanlue.ParameterName = "@sACFanlue";
                ParACFanlue.SqlDbType = SqlDbType.Char;
                ParACFanlue.Value = acfACFp_Activo_Fijo.ACFanlue;
                SqlCmd.Parameters.Add(ParACFanlue);
                //
                SqlParameter ParACFfactortrib = new SqlParameter();
                ParACFfactortrib.ParameterName = "@decACFfactortrib";
                ParACFfactortrib.SqlDbType = SqlDbType.Decimal;
                ParACFfactortrib.Value = Convert.ToDecimal(acfACFp_Activo_Fijo.ACFfactortrib);
                SqlCmd.Parameters.Add(ParACFfactortrib);
                //
                SqlParameter ParACFfactorniif = new SqlParameter();
                ParACFfactorniif.ParameterName = "@decACFfactorniif";
                ParACFfactorniif.SqlDbType = SqlDbType.Decimal;
                ParACFfactorniif.Value = Convert.ToDecimal(acfACFp_Activo_Fijo.ACFfactorniif);
                SqlCmd.Parameters.Add(ParACFfactorniif);
                //
                SqlParameter ParACFcuenta = new SqlParameter();
                ParACFcuenta.ParameterName = "@sACFcuenta";
                ParACFcuenta.SqlDbType = SqlDbType.Char;
                ParACFcuenta.Value = acfACFp_Activo_Fijo.ACFcuenta;
                SqlCmd.Parameters.Add(ParACFcuenta);
                //
                SqlParameter ParACFcuentadep = new SqlParameter();
                ParACFcuentadep.ParameterName = "@sACFcuentadep";
                ParACFcuentadep.SqlDbType = SqlDbType.Char;
                ParACFcuentadep.Value = acfACFp_Activo_Fijo.ACFcuentadep;
                SqlCmd.Parameters.Add(ParACFcuentadep);
                //
                SqlParameter ParCMPid = new SqlParameter();
                ParCMPid.ParameterName = "@sCMPid";
                ParCMPid.SqlDbType = SqlDbType.Char;
                ParCMPid.Value = acfACFp_Activo_Fijo.CMPid;
                SqlCmd.Parameters.Add(ParCMPid);
                //
                SqlParameter ParACFobservacion = new SqlParameter();
                ParACFobservacion.ParameterName = "@sACFobservacion";
                ParACFobservacion.SqlDbType = SqlDbType.VarChar;
                ParACFobservacion.Value = acfACFp_Activo_Fijo.ACFobservacion;
                SqlCmd.Parameters.Add(ParACFobservacion);
                //
                SqlParameter ParLIFNR = new SqlParameter();
                ParLIFNR.ParameterName = "@sLIFNR";
                ParLIFNR.SqlDbType = SqlDbType.Char;
                ParLIFNR.Value = acfACFp_Activo_Fijo.LIFNR;
                SqlCmd.Parameters.Add(ParLIFNR);
                //
                SqlParameter ParACFnotaingreso = new SqlParameter();
                ParACFnotaingreso.ParameterName = "@sACFnotaingreso";
                ParACFnotaingreso.SqlDbType = SqlDbType.Char;
                ParACFnotaingreso.Value = acfACFp_Activo_Fijo.ACFnotaingreso;
                SqlCmd.Parameters.Add(ParACFnotaingreso);
                //
                SqlParameter ParACFfechanotaingreso = new SqlParameter();
                ParACFfechanotaingreso.ParameterName = "@sACFfechanotaingreso";
                ParACFfechanotaingreso.SqlDbType = SqlDbType.DateTime;
                ParACFfechanotaingreso.Value = Convert.ToDateTime(acfACFp_Activo_Fijo.ACFfechanotaingreso);
                SqlCmd.Parameters.Add(ParACFfechanotaingreso);
                //
                SqlParameter ParACFordencompra = new SqlParameter();
                ParACFordencompra.ParameterName = "@sACFordencompra";
                ParACFordencompra.SqlDbType = SqlDbType.Char;
                ParACFordencompra.Value = acfACFp_Activo_Fijo.ACFordencompra;
                SqlCmd.Parameters.Add(ParACFordencompra);
                //
                SqlParameter ParACFfechaordencompra = new SqlParameter();
                ParACFfechaordencompra.ParameterName = "@dtACFfechaordencompra";
                ParACFfechaordencompra.SqlDbType = SqlDbType.DateTime;
                ParACFfechaordencompra.Value = Convert.ToDateTime(acfACFp_Activo_Fijo.ACFfechaordencompra);
                SqlCmd.Parameters.Add(ParACFfechaordencompra);
                //
                SqlParameter ParBLART = new SqlParameter();
                ParBLART.ParameterName = "@sBLART";
                ParBLART.SqlDbType = SqlDbType.Char;
                ParBLART.Value = acfACFp_Activo_Fijo.BLART;
                SqlCmd.Parameters.Add(ParBLART);
                //
                SqlParameter ParACFcomprobante = new SqlParameter();
                ParACFcomprobante.ParameterName = "@sACFcomprobante";
                ParACFcomprobante.SqlDbType = SqlDbType.Char;
                ParACFcomprobante.Value = acfACFp_Activo_Fijo.ACFcomprobante;
                SqlCmd.Parameters.Add(ParACFcomprobante);
                //
                SqlParameter ParKOSTL = new SqlParameter();
                ParKOSTL.ParameterName = "@sKOSTL";
                ParKOSTL.SqlDbType = SqlDbType.Char;
                ParKOSTL.Value = acfACFp_Activo_Fijo.KOSTL;
                SqlCmd.Parameters.Add(ParKOSTL);
                //
                SqlParameter ParAMBid = new SqlParameter();
                ParAMBid.ParameterName = "@iAMBid";
                ParAMBid.SqlDbType = SqlDbType.Int;
                ParAMBid.Value = Convert.ToInt32(acfACFp_Activo_Fijo.AMBid);
                SqlCmd.Parameters.Add(ParAMBid);
                //
                SqlParameter ParUBEid = new SqlParameter();
                ParUBEid.ParameterName = "@iUBEid";
                ParUBEid.SqlDbType = SqlDbType.Int;
                ParUBEid.Value = Convert.ToInt32(acfACFp_Activo_Fijo.UBEid);
                SqlCmd.Parameters.Add(ParUBEid);
                //
                SqlParameter ParACFfechacomprobante = new SqlParameter();
                ParACFfechacomprobante.ParameterName = "@dtACFfechacomprobante";
                ParACFfechacomprobante.SqlDbType = SqlDbType.DateTime;
                ParACFfechacomprobante.Value = Convert.ToDateTime(acfACFp_Activo_Fijo.ACFfechacomprobante);
                SqlCmd.Parameters.Add(ParACFfechacomprobante);
                //
                SqlParameter ParV_T087U_ANLUE = new SqlParameter();
                ParV_T087U_ANLUE.ParameterName = "@sV_T087U_ANLUE";
                ParV_T087U_ANLUE.SqlDbType = SqlDbType.Char;
                ParV_T087U_ANLUE.Value = acfACFp_Activo_Fijo.V_T087U_ANLUE;
                SqlCmd.Parameters.Add(ParV_T087U_ANLUE);
                //
                SqlParameter ParACFtipo_activo = new SqlParameter();
                ParACFtipo_activo.ParameterName = "@sACFtipo_activo";
                ParACFtipo_activo.SqlDbType = SqlDbType.Char;
                ParACFtipo_activo.Value = acfACFp_Activo_Fijo.ACFtipo_activo;
                SqlCmd.Parameters.Add(ParACFtipo_activo);
                //
                SqlParameter ParACFAnulado = new SqlParameter();
                ParACFAnulado.ParameterName = "@cACFAnulado";
                ParACFAnulado.SqlDbType = SqlDbType.Char;
                ParACFAnulado.Value = cACFAnulado;
                SqlCmd.Parameters.Add(ParACFAnulado);

                SqlParameter ParACFid_Padre = new SqlParameter();
                ParACFid_Padre.ParameterName = "@cACFid_Padre";
                ParACFid_Padre.SqlDbType = SqlDbType.Int;
                ParACFid_Padre.Value = Convert.ToInt32(cACFid_Padre);
                SqlCmd.Parameters.Add(ParACFid_Padre);
                SqlParameter ParACFtipo_orden = new SqlParameter();
                ParACFtipo_orden.ParameterName = "@cACFtipo_orden";
                ParACFtipo_orden.SqlDbType = SqlDbType.VarChar;
                ParACFtipo_orden.Value = acfACFp_Activo_Fijo.cACFtipo_orden;
                SqlCmd.Parameters.Add(ParACFtipo_orden);

                SqlParameter ParOBJid_objeto = new SqlParameter();
                ParOBJid_objeto.ParameterName = "@cOBJid_objeto";
                ParOBJid_objeto.SqlDbType = SqlDbType.Char;
                ParOBJid_objeto.Value = acfACFp_Activo_Fijo.cOBJid_objeto;
                SqlCmd.Parameters.Add(ParOBJid_objeto);

                SqlParameter ParCRPid_crp = new SqlParameter();
                ParCRPid_crp.ParameterName = "@cCRPid_crp";
                ParCRPid_crp.SqlDbType = SqlDbType.Char;
                ParCRPid_crp.Value = acfACFp_Activo_Fijo.cCRPid_crp;
                SqlCmd.Parameters.Add(ParCRPid_crp);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Modifico el Registro";
                
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

        //METODO EDITAR2
        public string Editar2(DacfACFp_Activo_Fijo acfACFp_Activo_Fijo)
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
                SqlCmd.CommandText = "usp_U_AjusteVidaUtil";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //

                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@iACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFid);
                SqlCmd.Parameters.Add(ParACFid);
                //
                SqlParameter ParACFvutilniifanio = new SqlParameter();
                ParACFvutilniifanio.ParameterName = "@iACFvutilniifanio";
                ParACFvutilniifanio.SqlDbType = SqlDbType.Int;
                ParACFvutilniifanio.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutilniifanio);
                SqlCmd.Parameters.Add(ParACFvutilniifanio);
                //
                SqlParameter ParACFvutilniifdia = new SqlParameter();
                ParACFvutilniifdia.ParameterName = "@iACFvutilniifdia";
                ParACFvutilniifdia.SqlDbType = SqlDbType.Int;
                ParACFvutilniifdia.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutilniifdia);
                SqlCmd.Parameters.Add(ParACFvutilniifdia);
                //
                SqlParameter ParACFvutiltribanio = new SqlParameter();
                ParACFvutiltribanio.ParameterName = "@iACFvutiltribanio";
                ParACFvutiltribanio.SqlDbType = SqlDbType.Int;
                ParACFvutiltribanio.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutiltribanio);
                SqlCmd.Parameters.Add(ParACFvutiltribanio);
                //
                SqlParameter ParACFvutiltribdia = new SqlParameter();
                ParACFvutiltribdia.ParameterName = "@iACFvutiltribdia";
                ParACFvutiltribdia.SqlDbType = SqlDbType.Int;
                ParACFvutiltribdia.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutiltribdia);
                SqlCmd.Parameters.Add(ParACFvutiltribdia);
                
                
                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Modifico el Registro";

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

        //METODO EDITAR3
        public string Editar3(DacfACFp_Activo_Fijo acfACFp_Activo_Fijo)
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
                SqlCmd.CommandText = "usp_I_acfGIS_UbicacionElectrica";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@iACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFid);
                SqlCmd.Parameters.Add(ParACFid);
                //
                SqlParameter ParACFobra = new SqlParameter();
                ParACFobra.ParameterName = "@sACFobra";
                ParACFobra.SqlDbType = SqlDbType.Char;
                ParACFobra.Value = acfACFp_Activo_Fijo.ACFobra;
                SqlCmd.Parameters.Add(ParACFobra);
                //
                SqlParameter ParKOSTL = new SqlParameter();
                ParKOSTL.ParameterName = "@sKOSTL";
                ParKOSTL.SqlDbType = SqlDbType.Char;
                ParKOSTL.Value = acfACFp_Activo_Fijo.KOSTL;
                SqlCmd.Parameters.Add(ParKOSTL);
                //
                SqlParameter ParVNRid = new SqlParameter();
                ParVNRid.ParameterName = "@sVNRid";
                ParVNRid.SqlDbType = SqlDbType.Char;
                ParVNRid.Value = acfACFp_Activo_Fijo.VNRid;
                SqlCmd.Parameters.Add(ParVNRid);
                //
                SqlParameter ParACFvalorniif = new SqlParameter();
                ParACFvalorniif.ParameterName = "@decACFvalorniif";
                ParACFvalorniif.SqlDbType = SqlDbType.Decimal;
                ParACFvalorniif.Value = Convert.ToDecimal(acfACFp_Activo_Fijo.ACFvalorniif);
                SqlCmd.Parameters.Add(ParACFvalorniif);
                //
                SqlParameter ParACFvalortrib = new SqlParameter();
                ParACFvalortrib.ParameterName = "@decACFvalortrib";
                ParACFvalortrib.SqlDbType = SqlDbType.Decimal;
                ParACFvalortrib.Value = Convert.ToDecimal(acfACFp_Activo_Fijo.ACFvalortrib);
                SqlCmd.Parameters.Add(ParACFvalortrib);
                //
                SqlParameter ParUBEid = new SqlParameter();
                ParUBEid.ParameterName = "@iUBEid";
                ParUBEid.SqlDbType = SqlDbType.Int;
                ParUBEid.Value = Convert.ToInt32(acfACFp_Activo_Fijo.UBEid);
                SqlCmd.Parameters.Add(ParUBEid);
                //
                SqlParameter ParV_T087U_ANLUE = new SqlParameter();
                ParV_T087U_ANLUE.ParameterName = "@sV_T087U_ANLUE";
                ParV_T087U_ANLUE.SqlDbType = SqlDbType.Char;
                ParV_T087U_ANLUE.Value = acfACFp_Activo_Fijo.V_T087U_ANLUE;
                SqlCmd.Parameters.Add(ParV_T087U_ANLUE);
                //
                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Modifico el Registro";
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
        public string Editar4(DacfACFp_Activo_Fijo acfACFp_Activo_Fijo)
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
                SqlCmd.CommandText = "usp_U2_acfACFp_Activo_Fijo";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //

                SqlParameter ParACFvutiltribanio = new SqlParameter();
                ParACFvutiltribanio.ParameterName = "@ACFvutiltribanio";
                ParACFvutiltribanio.SqlDbType = SqlDbType.Int;
                ParACFvutiltribanio.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutiltribanio);
                SqlCmd.Parameters.Add(ParACFvutiltribanio);
                //
                SqlParameter ParACFvutiltribdia = new SqlParameter();
                ParACFvutiltribdia.ParameterName = "@ACFvutiltribdia";
                ParACFvutiltribdia.SqlDbType = SqlDbType.Int;
                ParACFvutiltribdia.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutiltribdia);
                SqlCmd.Parameters.Add(ParACFvutiltribdia);
               
                SqlParameter ParACFvutilniifanio = new SqlParameter();
                ParACFvutilniifanio.ParameterName = "@ACFvutilniifanio";
                ParACFvutilniifanio.SqlDbType = SqlDbType.Int;
                ParACFvutilniifanio.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutilniifanio);
                SqlCmd.Parameters.Add(ParACFvutilniifanio);
                //
                SqlParameter ParACFvutilniifdia = new SqlParameter();
                ParACFvutilniifdia.ParameterName = "@ACFvutilniifdia";
                ParACFvutilniifdia.SqlDbType = SqlDbType.Int;
                ParACFvutilniifdia.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutilniifdia);
                SqlCmd.Parameters.Add(ParACFvutilniifdia);
            
                SqlParameter ParCMPid = new SqlParameter();
                ParCMPid.ParameterName = "@CMPid";
                ParCMPid.SqlDbType = SqlDbType.Char;
                ParCMPid.Value = acfACFp_Activo_Fijo.CMPid;
                SqlCmd.Parameters.Add(ParCMPid);
              

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Modifico el Registro";

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
        //METODO EDITAR - DEPRECIACION
        public string depreciacion(DacfACFp_Activo_Fijo acfACFp_Activo_Fijo)
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
                SqlCmd.CommandText = "usp_U_acfACFp_Activo_Fijo_Depreciacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                // iACFid - se solo para procesar un dato de mes
                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@iACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                //ParACFid.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFid);
                ParACFid.Value = acfACFp_Activo_Fijo.ACFid;
                SqlCmd.Parameters.Add(ParACFid);
                //
                // iACFvutiltribanio - se solo para procesar un dato de año
                SqlParameter ParACFvutiltribanio = new SqlParameter();
                ParACFvutiltribanio.ParameterName = "@iACFvutiltribanio";
                ParACFvutiltribanio.SqlDbType = SqlDbType.Int;
                //ParACFvutiltribanio.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFvutiltribanio);
                ParACFvutiltribanio.Value = acfACFp_Activo_Fijo.ACFvutiltribanio;
                SqlCmd.Parameters.Add(ParACFvutiltribanio);
                //
                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO existen Registros";
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
        public string Eliminar(string iACFid, string cACFAnulado) {
		
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
                SqlCmd.CommandText = "usp_D_acfACFp_Activo_Fijo";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@iACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Value = Convert.ToInt32(iACFid);
                SqlCmd.Parameters.Add(ParACFid);

                SqlParameter ParACFAnulado = new SqlParameter();
                ParACFAnulado.ParameterName = "@cACFAnulado";
                ParACFAnulado.SqlDbType = SqlDbType.Char;
                ParACFAnulado.Value = cACFAnulado;
                SqlCmd.Parameters.Add(ParACFAnulado);
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

	public DataTable Actual(DacfACFp_Activo_Fijo acfACFp_Activo_Fijo) {

        DataTable DtResultado = new DataTable("acfACFp_Activo_Fijo");
        SqlConnection SqlCon = new SqlConnection();


		try {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_S_acfACFp_Activo_Fijo";
            SqlCmd.CommandType = CommandType.StoredProcedure;



            SqlParameter ParBUKRS = new SqlParameter();
            ParBUKRS.ParameterName = "@ACFid";
            ParBUKRS.SqlDbType = SqlDbType.Int;
            ParBUKRS.Size = 10;
            ParBUKRS.Value = Convert.ToInt32(acfACFp_Activo_Fijo.ACFid);
            SqlCmd.Parameters.Add(ParBUKRS);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

		}
        catch (Exception ex)
        {
            DtResultado = null;
        }
        return DtResultado;

	}

    public DataTable MostrarPadre(string CMPid)
    {
        DataTable DtResultado = new DataTable("acfACFp_Activo_Fijo");
        SqlConnection SqlCon = new SqlConnection();

        try
        {
            //Codigo
            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_S_acfACFp_Activo_FijoPadre";
            SqlCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter ParCMPid = new SqlParameter();
            ParCMPid.ParameterName = "@ACFid_Padre";
            ParCMPid.SqlDbType = SqlDbType.Int;
            ParCMPid.Value = CMPid;
            SqlCmd.Parameters.Add(ParCMPid);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);
        }

        catch (Exception ex)
        {
            DtResultado = null;
        }
        return DtResultado;
    }




    public DataTable MostrarRegistro(String ACFdescripcion)
    {

        DataTable DtResultado = new DataTable("acfACFp_Activo_Fijo");
        SqlConnection SqlCon = new SqlConnection();


        try
        {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_acfACFp_Activo_Fijo";
            SqlCmd.CommandType = CommandType.StoredProcedure;



            SqlParameter ParACFdescripcion = new SqlParameter();
            ParACFdescripcion.ParameterName = "@ACFdescripcion";
            ParACFdescripcion.SqlDbType = SqlDbType.Char;
            ParACFdescripcion.Size = 100;
            ParACFdescripcion.Value = ACFdescripcion;
            SqlCmd.Parameters.Add(ParACFdescripcion);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

        }
        catch (Exception ex)
        {
            DtResultado = null;
        }
        return DtResultado;

    }

   //Reporte de Depreciacion
   public DataTable Depreciacion()
        {
            DataTable DtResultado = new DataTable("acfACFp_Activo_Fijo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Depreciación_Anual";
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

    }
}
