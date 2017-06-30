using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DAcfINBt_Inventariobienes
    {

        private string mINVid;
        private string mACFid;
        private string mACFactivo;
        private string mBUKRS;
        private string mSEGMENT;
        private string mKOSTL;
        private string mANLKL;
        private string mPERNR;
        private string mACTid;
        private string mCSTid;
        private string mVNRid;
        private string mACFfincorporacion;
        private string mACFfcapitalizacion;
        private string mACFvutiltribanio;
        private string mACFvutiltribdia;
        private string mACFvalortrib;
        private string mACFfactortrib;
        private string mACFdepacutrib;
        private string mACFvutilniifanio;
        private string mACFvutilniifdia;
        private string mACFvalorniif;
        private string mACFfactorniif;
        private string mACFdepacuniif;
        private string mACFobra;
        private string mACFord41;
        private string mACFord42;
        private string mACFord43;
        private string mACFord44;
        private string mACFanlue;
        private string mACFcuenta;
        private string mACFcuentadep;
        private string mLIFNR;
        private string mBLART;
        private string mACFcomprobante;
        private string mACFnotaingreso;
        private string mACFfechanotaingreso;
        private string mACFordencompra;
        private string mACFobservacion;
        private string mAMBid;
        private string mUBEid;
        private string mACFfechacomprobante;
        private string mACFfechaordencompra;

        public string INVid
        {
            get { return mINVid; }
            set { mINVid = value; }
        }
        public string ACFid
        {
            get { return mACFid; }
            set { mACFid = value; }
        }
        public string ACFactivo
        {
            get { return mACFactivo; }
            set { mACFactivo = value; }
        }
        public string BUKRS
        {
            get { return mBUKRS; }
            set { mBUKRS = value; }
        }
        public string SEGMENT
        {
            get { return mSEGMENT; }
            set { mSEGMENT = value; }
        }
        public string KOSTL
        {
            get { return mKOSTL; }
            set { mKOSTL = value; }
        }
        public string ANLKL
        {
            get { return mANLKL; }
            set { mANLKL = value; }
        }
        public string PERNR
        {
            get { return mPERNR; }
            set { mPERNR = value; }
        }
        public string ACTid
        {
            get { return mACTid; }
            set { mACTid = value; }
        }
        public string CSTid
        {
            get { return mCSTid; }
            set { mCSTid = value; }
        }
        public string VNRid
        {
            get { return mVNRid; }
            set { mVNRid = value; }
        }
        public string ACFfincorporacion
        {
            get { return mACFfincorporacion; }
            set { mACFfincorporacion = value; }
        }
        public string ACFfcapitalizacion
        {
            get { return mACFfcapitalizacion; }
            set { mACFfcapitalizacion = value; }
        }
        public string ACFvutiltribanio
        {
            get { return mACFvutiltribanio; }
            set { mACFvutiltribanio = value; }
        }
        public string ACFvutiltribdia
        {
            get { return mACFvutiltribdia; }
            set { mACFvutiltribdia = value; }
        }
        public string ACFvalortrib
        {
            get { return mACFvalortrib; }
            set { mACFvalortrib = value; }
        }
        public string ACFfactortrib
        {
            get { return mACFfactortrib; }
            set { mACFfactortrib = value; }
        }
        public string ACFdepacutrib
        {
            get { return mACFdepacutrib; }
            set { mACFdepacutrib = value; }
        }
        public string ACFvutilniifanio
        {
            get { return mACFvutilniifanio; }
            set { mACFvutilniifanio = value; }
        }
        public string ACFvutilniifdia
        {
            get { return mACFvutilniifdia; }
            set { mACFvutilniifdia = value; }
        }
        public string ACFvalorniif
        {
            get { return mACFvalorniif; }
            set { mACFvalorniif = value; }
        }
        public string ACFfactorniif
        {
            get { return mACFfactorniif; }
            set { mACFfactorniif = value; }
        }
        public string ACFdepacuniif
        {
            get { return mACFdepacuniif; }
            set { mACFdepacuniif = value; }
        }

        public string ACFobra
        {
            get { return mACFobra; }
            set { mACFobra = value; }
        }
        public string ACFord41
        {
            get { return mACFord41; }
            set { mACFord42 = value; }
        }
        public string ACFord42
        {
            get { return mACFord42; }
            set { mACFord42 = value; }
        }
        public string ACFord43
        {
            get { return mACFord43; }
            set { mACFord43 = value; }
        }
        public string ACFord44
        {
            get { return mACFord44; }
            set { mACFord44 = value; }
        }
        public string ACFanlue
        {
            get { return mACFanlue; }
            set { mACFanlue = value; }
        }
        public string ACFcuenta
        {
            get { return mACFcuenta; }
            set { mACFcuenta = value; }
        }
        public string ACFcuentadep
        {
            get { return mACFcuentadep; }
            set { mACFcuentadep = value; }
        }
        public string LIFNR
        {
            get { return mLIFNR; }
            set { mLIFNR = value; }
        }
        public string BLART
        {
            get { return mBLART; }
            set { mBLART = value; }
        }
        public string ACFcomprobante
        {
            get { return mACFcomprobante; }
            set { mACFcomprobante = value; }
        }
        public string ACFnotaingreso
        {
            get { return mACFnotaingreso; }
            set { mACFnotaingreso = value; }
        }
        public string ACFfechanotaingreso
        {
            get { return mACFfechanotaingreso; }
            set { mACFfechanotaingreso = value; }
        }
        public string ACFordencompra
        {
            get { return mACFordencompra; }
            set { mACFordencompra = value; }
        }
        public string ACFobservacion
        {
            get { return mACFobservacion; }
            set { mACFobservacion = value; }
        }
        public string AMBid
        {
            get { return mAMBid; }
            set { mAMBid = value; }
        }
        public string UBEid
        {
            get { return mUBEid; }
            set { mUBEid = value; }
        }
        public string ACFfechacomprobante
        {
            get { return mACFfechacomprobante; }
            set { mACFfechacomprobante = value; }
        }
        public string ACFfechaordencompra
        {
            get { return mACFfechaordencompra; }
            set { mACFfechaordencompra = value; }
        }


         //Constructor vacío
        public DAcfINBt_Inventariobienes()
        {
	}


        public DAcfINBt_Inventariobienes(
         string  INVid,
         string  ACFid,
         string  ACFactivo,
         string  BUKRS,
         string  SEGMENT,
         string  KOSTL,
         string  ANLKL,
         string  PERNR,
         string  ACTid,
         string  CSTid,
         string  VNRid,
         string  ACFfincorporacion,
         string  ACFfcapitalizacion,
         string  ACFvutiltribanio,
         string  ACFvutiltribdia,
         string  ACFvalortrib,
         string  ACFfactortrib,
         string  ACFdepacutrib,
         string  ACFvutilniifanio,
         string  ACFvutilniifdia,
         string  ACFvalorniif,
         string  ACFfactorniif,
         string  ACFdepacuniif,
         string  ACFobra,
         string  ACFord41,
         string  ACFord42,
         string  ACFord43,
         string  ACFord44,
         string  ACFanlue,
         string  ACFcuenta,
         string  ACFcuentadep,
         string  LIFNR,
         string  BLART,
         string  ACFcomprobante,
         string  ACFnotaingreso,
         string  ACFfechanotaingreso,
         string  ACFordencompra,
         string  ACFobservacion,
         string  AMBid,
         string  UBEid,
         string  ACFfechacomprobante,
         string  ACFfechaordencompra
        
        )         
         {

        this.INVid=                 mINVid;
        this.ACFid=                 mACFid;
        this.ACFactivo=             mACFactivo;
        this.BUKRS=                 mBUKRS;
        this.SEGMENT=               mSEGMENT;
        this.KOSTL=                 mKOSTL;
        this.ANLKL=                 mANLKL;
        this.PERNR=                 mPERNR;
        this.ACTid=                 mACTid;
        this.CSTid=                 mCSTid;
        this.VNRid=                 mVNRid;
        this.ACFfincorporacion=     mACFfincorporacion;
        this.ACFfcapitalizacion=    mACFfcapitalizacion;
        this.ACFvutiltribanio=      mACFvutiltribanio;
        this.ACFvutiltribdia=       mACFvutiltribdia;
        this.ACFvalortrib=          mACFvalortrib;
        this.ACFfactortrib=         mACFfactortrib;
        this.ACFdepacutrib=         mACFdepacutrib;
        this.ACFvutilniifanio=      mACFvutilniifanio;
        this.ACFvutilniifdia=       mACFvutilniifdia;
        this.ACFvalorniif=          mACFvalorniif;
        this.ACFfactorniif=         mACFfactorniif;
        this.ACFdepacuniif=         mACFdepacuniif;
        this.ACFobra=               mACFobra;
        this.ACFord41=              mACFord41;
        this.ACFord42=              mACFord42;
        this.ACFord43=              mACFord43;
        this.ACFord44=              mACFord44;
        this.ACFanlue=              mACFanlue;
        this.ACFcuenta=             mACFcuenta;
        this.ACFcuentadep=          mACFcuentadep;
        this.LIFNR=                 mLIFNR;
        this.BLART=                 mBLART;
        this.ACFcomprobante=        mACFcomprobante;
        this.ACFnotaingreso=        mACFnotaingreso;
        this.ACFfechanotaingreso=   mACFfechanotaingreso;
        this.ACFordencompra=        mACFordencompra;
        this.ACFobservacion=        mACFobservacion;
        this.AMBid=                 mAMBid;
        this.UBEid=                 mUBEid;
        this.ACFfechacomprobante=   mACFfechacomprobante;
        this.ACFfechaordencompra=   mACFfechaordencompra;
       

	}


       //METODO MOSTRAR
        public DataTable    Mostrar(string iINVid)
        {
            DataTable DtResultado = new DataTable("acfINBt_Inventariobienes");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfINBt_Inventariobienes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParINVid = new SqlParameter();
                ParINVid.ParameterName = "@INVid";
                ParINVid.SqlDbType = SqlDbType.Int;
                ParINVid.Size = 50;
                ParINVid.Value = iINVid;
                SqlCmd.Parameters.Add(ParINVid);

               //SqlParameter PariMVAid = new SqlParameter();
               //PariMVAid.ParameterName = "@iMVAid";
               //PariMVAid.SqlDbType = SqlDbType.Int;
               //PariMVAid.Value = MVAid;
               //SqlCmd.Parameters.Add(PariMVAid);


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
    public DataTable Depreciacion(String iINVid, String sKOSTL)
        {
            DataTable DtResultado = new DataTable("acfINBt_Inventariobienes");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "acfrpt_nventarioReporte";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParINVid = new SqlParameter();
                ParINVid.ParameterName = "@iINVid";
                ParINVid.SqlDbType = SqlDbType.Int;
                ParINVid.Value = iINVid;
                SqlCmd.Parameters.Add(ParINVid);

                SqlParameter ParsKOSTL = new SqlParameter();
                ParsKOSTL.ParameterName = "@sKOSTL";
                ParsKOSTL.SqlDbType = SqlDbType.Char;
                ParsKOSTL.Value = sKOSTL;
                SqlCmd.Parameters.Add(ParsKOSTL);

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
	public string Insertar(DAcfINBt_Inventariobienes acfINBt_Inventariobienes)
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
                SqlCmd.CommandText = "usp_I_acfINBt_Inventariobienes";
                SqlCmd.CommandType = CommandType.StoredProcedure;                            
                //
                SqlParameter PariINVid = new SqlParameter();
                PariINVid.ParameterName = "@iINVid";
                PariINVid.SqlDbType = SqlDbType.Int;
                PariINVid.Value = acfINBt_Inventariobienes.INVid;
                SqlCmd.Parameters.Add(PariINVid);
                //
                SqlParameter PariACFid = new SqlParameter();
                PariACFid.ParameterName = "@iACFid";
                PariACFid.SqlDbType = SqlDbType.Int;
                PariACFid.Value = acfINBt_Inventariobienes.ACFid;
                SqlCmd.Parameters.Add(PariACFid);
                //
                SqlParameter ParsACFactivo = new SqlParameter();
                ParsACFactivo.ParameterName = "@sACFactivo";
                ParsACFactivo.SqlDbType = SqlDbType.VarChar;
                ParsACFactivo.Value = acfINBt_Inventariobienes.ACFactivo;
                SqlCmd.Parameters.Add(ParsACFactivo);
                //
                SqlParameter ParsBUKRS = new SqlParameter();
                ParsBUKRS.ParameterName = "@sBUKRS";
                ParsBUKRS.SqlDbType = SqlDbType.Char;
                ParsBUKRS.Value = acfINBt_Inventariobienes.BUKRS;
                SqlCmd.Parameters.Add(ParsBUKRS);
                //
                SqlParameter ParsSEGMENT = new SqlParameter();
                ParsSEGMENT.ParameterName = "@sSEGMENT";
                ParsSEGMENT.SqlDbType = SqlDbType.Char;
                ParsSEGMENT.Value = acfINBt_Inventariobienes.SEGMENT;
                SqlCmd.Parameters.Add(ParsSEGMENT);
                //
                SqlParameter ParsKOSTL = new SqlParameter();
                ParsKOSTL.ParameterName = "@sKOSTL";
                ParsKOSTL.SqlDbType = SqlDbType.Char;
                ParsKOSTL.Value = acfINBt_Inventariobienes.KOSTL;
                SqlCmd.Parameters.Add(ParsKOSTL);
                //
                SqlParameter ParsANLKL = new SqlParameter();
                ParsANLKL.ParameterName = "@sANLKL";
                ParsANLKL.SqlDbType = SqlDbType.Char;
                ParsANLKL.Value = acfINBt_Inventariobienes.KOSTL;
                SqlCmd.Parameters.Add(ParsANLKL);
                //
                SqlParameter ParsPERNR = new SqlParameter();
                ParsPERNR.ParameterName = "@sPERNR";
                ParsPERNR.SqlDbType = SqlDbType.Char;
                ParsPERNR.Value = acfINBt_Inventariobienes.PERNR;
                SqlCmd.Parameters.Add(ParsPERNR);
                //
                SqlParameter ParsACTid = new SqlParameter();
                ParsACTid.ParameterName = "@sACTid";
                ParsACTid.SqlDbType = SqlDbType.Char;
                ParsACTid.Value = acfINBt_Inventariobienes.ACTid;
                SqlCmd.Parameters.Add(ParsACTid);
                //
                SqlParameter ParsCSTid = new SqlParameter();
                ParsCSTid.ParameterName = "@sCSTid";
                ParsCSTid.SqlDbType = SqlDbType.Char;
                ParsCSTid.Value = acfINBt_Inventariobienes.CSTid;
                SqlCmd.Parameters.Add(ParsCSTid);
                //
                SqlParameter ParsVNRid = new SqlParameter();
                ParsVNRid.ParameterName = "@sVNRid";
                ParsVNRid.SqlDbType = SqlDbType.Char;
                ParsVNRid.Value =acfINBt_Inventariobienes.VNRid;
                SqlCmd.Parameters.Add(ParsVNRid);
                //
                SqlParameter PardtACFfincorporacion= new SqlParameter();
                PardtACFfincorporacion.ParameterName = "@dtACFfincorporacion";
                PardtACFfincorporacion.SqlDbType = SqlDbType.DateTime;
                PardtACFfincorporacion.Value = acfINBt_Inventariobienes.ACFfincorporacion;
                SqlCmd.Parameters.Add(PardtACFfincorporacion);
                //
                SqlParameter PardtACFfcapitalizacion = new SqlParameter();
                PardtACFfcapitalizacion.ParameterName = "@dtACFfcapitalizacion";
                PardtACFfcapitalizacion.SqlDbType = SqlDbType.DateTime;
                PardtACFfcapitalizacion.Value = acfINBt_Inventariobienes.ACFfcapitalizacion;
                SqlCmd.Parameters.Add(PardtACFfcapitalizacion);
                //
                SqlParameter PariACFvutiltribanio = new SqlParameter();
                PariACFvutiltribanio.ParameterName = "@iACFvutiltribanio";
                PariACFvutiltribanio.SqlDbType = SqlDbType.Int;
                PariACFvutiltribanio.Value = acfINBt_Inventariobienes.ACFvutiltribanio;
                SqlCmd.Parameters.Add(PariACFvutiltribanio);
                //
                SqlParameter PariACFvutiltribdia = new SqlParameter();
                PariACFvutiltribdia.ParameterName = "@iACFvutiltribdia";
                PariACFvutiltribdia.SqlDbType = SqlDbType.Int;
                PariACFvutiltribdia.Value = acfINBt_Inventariobienes.ACFvutiltribdia;
                SqlCmd.Parameters.Add(PariACFvutiltribdia);
                //
                SqlParameter PardecACFvalortrib = new SqlParameter();
                PardecACFvalortrib.ParameterName = "@decACFvalortrib";
                PardecACFvalortrib.SqlDbType = SqlDbType.Decimal;
                PardecACFvalortrib.Value = acfINBt_Inventariobienes.ACFvalortrib;
                SqlCmd.Parameters.Add(PardecACFvalortrib);
                //
                SqlParameter PardecACFfactortrib = new SqlParameter();
                PardecACFfactortrib.ParameterName = "@decACFfactortrib";
                PardecACFfactortrib.SqlDbType = SqlDbType.Decimal;
                PardecACFfactortrib.Value = acfINBt_Inventariobienes.ACFfactortrib;
                SqlCmd.Parameters.Add(PardecACFfactortrib);
                //
                SqlParameter PardecACFdepacutrib = new SqlParameter();
                PardecACFdepacutrib.ParameterName = "@decACFdepacutrib";
                PardecACFdepacutrib.SqlDbType = SqlDbType.Decimal;
                PardecACFdepacutrib.Value = acfINBt_Inventariobienes.ACFdepacutrib;
                SqlCmd.Parameters.Add(PardecACFdepacutrib);
                //
                SqlParameter PariACfvutilniifanio = new SqlParameter();
                PariACfvutilniifanio.ParameterName = "@iACfvutilniifanio";
                PariACfvutilniifanio.SqlDbType = SqlDbType.Int;
                PariACfvutilniifanio.Value = acfINBt_Inventariobienes.ACFvutilniifanio;
                SqlCmd.Parameters.Add(PariACfvutilniifanio);
                //
                SqlParameter PariACFvutilniifdia = new SqlParameter();
                PariACFvutilniifdia.ParameterName = "@iACFvutilniifdia";
                PariACFvutilniifdia.SqlDbType = SqlDbType.Int;
                PariACFvutilniifdia.Value = acfINBt_Inventariobienes.ACFvutilniifdia;
                SqlCmd.Parameters.Add(PariACFvutilniifdia);
                //
                SqlParameter PardecACFvalorniif = new SqlParameter();
                PardecACFvalorniif.ParameterName = "@decACFvalorniif";
                PardecACFvalorniif.SqlDbType = SqlDbType.Decimal;
                PardecACFvalorniif.Value = acfINBt_Inventariobienes.ACFvalorniif;
                SqlCmd.Parameters.Add(PardecACFvalorniif);
                //
                SqlParameter PardecACFfactorniif= new SqlParameter();
                PardecACFfactorniif.ParameterName = "@decACFfactorniif";
                PardecACFfactorniif.SqlDbType = SqlDbType.Decimal;
                PardecACFfactorniif.Value = acfINBt_Inventariobienes.ACFfactorniif;
                SqlCmd.Parameters.Add(PardecACFfactorniif);
                //
                SqlParameter PardecACFdepacuniif = new SqlParameter();
                PardecACFdepacuniif.ParameterName = "@decACFdepacuniif";
                PardecACFdepacuniif.SqlDbType = SqlDbType.Decimal;
                PardecACFdepacuniif.Value = acfINBt_Inventariobienes.ACFdepacuniif;
                SqlCmd.Parameters.Add(PardecACFdepacuniif);
                //
                SqlParameter ParsACFobra = new SqlParameter();
                ParsACFobra.ParameterName = "@sACFobra";
                ParsACFobra.SqlDbType = SqlDbType.Char;
                ParsACFobra.Value = acfINBt_Inventariobienes.ACFobra;
                SqlCmd.Parameters.Add(ParsACFobra);
                //
                SqlParameter ParsACFord41 = new SqlParameter();
                ParsACFord41.ParameterName = "@sACFord41";
                ParsACFord41.SqlDbType = SqlDbType.Char;
                ParsACFord41.Value = acfINBt_Inventariobienes.ACFord41;
                SqlCmd.Parameters.Add(ParsACFord41);
                //
                SqlParameter ParsACFord42 = new SqlParameter();
                ParsACFord42.ParameterName = "@sACFord42";
                ParsACFord42.SqlDbType = SqlDbType.Char;
                ParsACFord42.Value = acfINBt_Inventariobienes.ACFord42;
                SqlCmd.Parameters.Add(ParsACFord42);
                //
                SqlParameter ParsACFord43 = new SqlParameter();
                ParsACFord43.ParameterName = "@sACFord43";
                ParsACFord43.SqlDbType = SqlDbType.Char;
                ParsACFord43.Value = acfINBt_Inventariobienes.ACFord43;
                SqlCmd.Parameters.Add(ParsACFord43);
                //
                SqlParameter ParsACFord44 = new SqlParameter();
                ParsACFord44.ParameterName = "@sACFord44";
                ParsACFord44.SqlDbType = SqlDbType.Char;
                ParsACFord44.Value = acfINBt_Inventariobienes.ACFord44;
                SqlCmd.Parameters.Add(ParsACFord44);
                //
               SqlParameter ParsACFanlue = new SqlParameter();
                ParsACFanlue.ParameterName = "@sACFanlue";
                ParsACFanlue.SqlDbType = SqlDbType.Char;
                ParsACFanlue.Value = acfINBt_Inventariobienes.ACFanlue;
                SqlCmd.Parameters.Add(ParsACFanlue);
                //
                SqlParameter ParsACFcuenta = new SqlParameter();
                ParsACFcuenta.ParameterName = "@sACFcuenta";
                ParsACFcuenta.SqlDbType = SqlDbType.Char;
                ParsACFcuenta.Value = acfINBt_Inventariobienes.ACFcuenta;
                SqlCmd.Parameters.Add(ParsACFcuenta);
                //
                SqlParameter ParsACFcuentadep = new SqlParameter();
                ParsACFcuentadep.ParameterName = "@sACFcuentadep";
                ParsACFcuentadep.SqlDbType = SqlDbType.Char;
                ParsACFcuentadep.Value = acfINBt_Inventariobienes.ACFcuentadep;
                SqlCmd.Parameters.Add(ParsACFcuenta);
                //
                 SqlParameter ParsLIFNR = new SqlParameter();
                ParsLIFNR.ParameterName = "@sLIFNR";
                ParsLIFNR.SqlDbType = SqlDbType.Char;
                ParsLIFNR.Value = acfINBt_Inventariobienes.LIFNR;
                SqlCmd.Parameters.Add(ParsLIFNR);
                //
                 SqlParameter ParsBLART = new SqlParameter();
                ParsBLART.ParameterName = "@sBLART";
                ParsBLART.SqlDbType = SqlDbType.Char;
                ParsBLART.Value = acfINBt_Inventariobienes.BLART;
                SqlCmd.Parameters.Add(ParsBLART);
                //
                 SqlParameter ParsACFcomprobante = new SqlParameter();
                ParsACFcomprobante.ParameterName = "@sACFcomprobante";
                ParsACFcomprobante.SqlDbType = SqlDbType.Char;
                ParsACFcomprobante.Value = acfINBt_Inventariobienes.ACFcomprobante;
                SqlCmd.Parameters.Add(ParsACFcuenta);
                //
                 SqlParameter ParsACFnotaingreso = new SqlParameter();
                ParsACFnotaingreso.ParameterName = "@sACFnotaingreso";
                ParsACFnotaingreso.SqlDbType = SqlDbType.Char;
                ParsACFnotaingreso.Value = acfINBt_Inventariobienes.ACFnotaingreso;
                SqlCmd.Parameters.Add(ParsACFnotaingreso);
                //
                SqlParameter PardtACFfechanotaingreso = new SqlParameter();
                PardtACFfechanotaingreso.ParameterName = "@dtACFfechanotaingreso";
                PardtACFfechanotaingreso.SqlDbType = SqlDbType.DateTime;
                PardtACFfechanotaingreso.Value = acfINBt_Inventariobienes.ACFfechanotaingreso;
                SqlCmd.Parameters.Add(PardtACFfechanotaingreso);
                //
                SqlParameter ParsACFordencompra = new SqlParameter();
                ParsACFordencompra.ParameterName = "@sACFordencompra";
                ParsACFordencompra.SqlDbType = SqlDbType.Char;
                ParsACFordencompra.Value = acfINBt_Inventariobienes.ACFordencompra;
                SqlCmd.Parameters.Add(ParsACFordencompra);
                //
                SqlParameter ParsACFobservacion = new SqlParameter();
                ParsACFobservacion.ParameterName = "@sACFobservacion";
                ParsACFobservacion.SqlDbType = SqlDbType.VarChar;
                ParsACFobservacion.Value = acfINBt_Inventariobienes.ACFobservacion;
                SqlCmd.Parameters.Add(ParsACFobservacion);
                //
                SqlParameter PariAMBid = new SqlParameter();
                PariAMBid.ParameterName = "@iAMBid";
                PariAMBid.SqlDbType = SqlDbType.Int;
                PariAMBid.Value = acfINBt_Inventariobienes.AMBid;
                SqlCmd.Parameters.Add(PariAMBid);
                //
                SqlParameter PariUBEid = new SqlParameter();
                PariUBEid.ParameterName = "@iUBEid";
                PariUBEid.SqlDbType = SqlDbType.Int;
                PariUBEid.Value = acfINBt_Inventariobienes.UBEid;
                SqlCmd.Parameters.Add(PariUBEid);
                //
               SqlParameter PardtACFfechacomprobante = new SqlParameter();
                PardtACFfechacomprobante.ParameterName = "@dtACFfechacomprobante";
                PardtACFfechacomprobante.SqlDbType = SqlDbType.DateTime;
                PardtACFfechacomprobante.Value = acfINBt_Inventariobienes.ACFfechacomprobante;
                SqlCmd.Parameters.Add(PardtACFfechacomprobante);
                //
                SqlParameter PardtACFfechaordencompra = new SqlParameter();
                PardtACFfechaordencompra.ParameterName = "@dtACFfechaordencompra";
                PardtACFfechaordencompra.SqlDbType = SqlDbType.DateTime;
                PardtACFfechaordencompra.Value = acfINBt_Inventariobienes.ACFfechaordencompra;
                SqlCmd.Parameters.Add(PardtACFfechaordencompra);
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
	public string Editar(DAcfINBt_Inventariobienes acfINBt_Inventariobienes) {
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
                SqlCmd.CommandText = "usp_U_acfINBt_Inventariobienes";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter PariINVid = new SqlParameter();
                PariINVid.ParameterName = "@iINVid";
                PariINVid.SqlDbType = SqlDbType.Int;
                PariINVid.Value = acfINBt_Inventariobienes.INVid;
                SqlCmd.Parameters.Add(PariINVid);
                //
                SqlParameter PariACFid = new SqlParameter();
                PariACFid.ParameterName = "@iACFid";
                PariACFid.SqlDbType = SqlDbType.Int;
                PariACFid.Value = acfINBt_Inventariobienes.ACFid;
                SqlCmd.Parameters.Add(PariACFid);
                //
                SqlParameter ParsACFactivo = new SqlParameter();
                ParsACFactivo.ParameterName = "@sACFactivo";
                ParsACFactivo.SqlDbType = SqlDbType.VarChar;
                ParsACFactivo.Value = acfINBt_Inventariobienes.ACFactivo;
                SqlCmd.Parameters.Add(ParsACFactivo);
                //
                SqlParameter ParsBUKRS = new SqlParameter();
                ParsBUKRS.ParameterName = "@sBUKRS";
                ParsBUKRS.SqlDbType = SqlDbType.Char;
                ParsBUKRS.Value = acfINBt_Inventariobienes.BUKRS;
                SqlCmd.Parameters.Add(ParsBUKRS);
                //
                SqlParameter ParsSEGMENT = new SqlParameter();
                ParsSEGMENT.ParameterName = "@sSEGMENT";
                ParsSEGMENT.SqlDbType = SqlDbType.Char;
                ParsSEGMENT.Value = acfINBt_Inventariobienes.SEGMENT;
                SqlCmd.Parameters.Add(ParsSEGMENT);
                //
                SqlParameter ParsKOSTL = new SqlParameter();
                ParsKOSTL.ParameterName = "@sKOSTL";
                ParsKOSTL.SqlDbType = SqlDbType.Char;
                ParsKOSTL.Value = acfINBt_Inventariobienes.KOSTL;
                SqlCmd.Parameters.Add(ParsKOSTL);
                //
                SqlParameter ParsANLKL = new SqlParameter();
                ParsANLKL.ParameterName = "@sANLKL";
                ParsANLKL.SqlDbType = SqlDbType.Char;
                ParsANLKL.Value = acfINBt_Inventariobienes.KOSTL;
                SqlCmd.Parameters.Add(ParsANLKL);
                //
                SqlParameter ParsPERNR = new SqlParameter();
                ParsPERNR.ParameterName = "@sPERNR";
                ParsPERNR.SqlDbType = SqlDbType.Char;
                ParsPERNR.Value = acfINBt_Inventariobienes.PERNR;
                SqlCmd.Parameters.Add(ParsPERNR);
                //
                SqlParameter ParsACTid = new SqlParameter();
                ParsACTid.ParameterName = "@sACTid";
                ParsACTid.SqlDbType = SqlDbType.Char;
                ParsACTid.Value = acfINBt_Inventariobienes.ACTid;
                SqlCmd.Parameters.Add(ParsACTid);
                //
                SqlParameter ParsCSTid = new SqlParameter();
                ParsCSTid.ParameterName = "@sCSTid";
                ParsCSTid.SqlDbType = SqlDbType.Char;
                ParsCSTid.Value = acfINBt_Inventariobienes.CSTid;
                SqlCmd.Parameters.Add(ParsCSTid);
                //
                SqlParameter ParsVNRid = new SqlParameter();
                ParsVNRid.ParameterName = "@sVNRid";
                ParsVNRid.SqlDbType = SqlDbType.Char;
                ParsVNRid.Value =acfINBt_Inventariobienes.VNRid;
                SqlCmd.Parameters.Add(ParsVNRid);
                //
                SqlParameter PardtACFfincorporacion= new SqlParameter();
                PardtACFfincorporacion.ParameterName = "@dtACFfincorporacion";
                PardtACFfincorporacion.SqlDbType = SqlDbType.DateTime;
                PardtACFfincorporacion.Value = acfINBt_Inventariobienes.ACFfincorporacion;
                SqlCmd.Parameters.Add(PardtACFfincorporacion);
                //
                SqlParameter PardtACFfcapitalizacion = new SqlParameter();
                PardtACFfcapitalizacion.ParameterName = "@dtACFfcapitalizacion";
                PardtACFfcapitalizacion.SqlDbType = SqlDbType.DateTime;
                PardtACFfcapitalizacion.Value = acfINBt_Inventariobienes.ACFfcapitalizacion;
                SqlCmd.Parameters.Add(PardtACFfcapitalizacion);
                //
                SqlParameter PariACFvutiltribanio = new SqlParameter();
                PariACFvutiltribanio.ParameterName = "@iACFvutiltribanio";
                PariACFvutiltribanio.SqlDbType = SqlDbType.Int;
                PariACFvutiltribanio.Value = acfINBt_Inventariobienes.ACFvutiltribanio;
                SqlCmd.Parameters.Add(PariACFvutiltribanio);
                //
                SqlParameter PariACFvutiltribdia = new SqlParameter();
                PariACFvutiltribdia.ParameterName = "@iACFvutiltribdia";
                PariACFvutiltribdia.SqlDbType = SqlDbType.Int;
                PariACFvutiltribdia.Value = acfINBt_Inventariobienes.ACFvutiltribdia;
                SqlCmd.Parameters.Add(PariACFvutiltribdia);
                //
                SqlParameter PardecACFvalortrib = new SqlParameter();
                PardecACFvalortrib.ParameterName = "@decACFvalortrib";
                PardecACFvalortrib.SqlDbType = SqlDbType.Decimal;
                PardecACFvalortrib.Value = acfINBt_Inventariobienes.ACFvalortrib;
                SqlCmd.Parameters.Add(PardecACFvalortrib);
                //
                SqlParameter PardecACFfactortrib = new SqlParameter();
                PardecACFfactortrib.ParameterName = "@decACFfactortrib";
                PardecACFfactortrib.SqlDbType = SqlDbType.Decimal;
                PardecACFfactortrib.Value = acfINBt_Inventariobienes.ACFfactortrib;
                SqlCmd.Parameters.Add(PardecACFfactortrib);
                //
                SqlParameter PardecACFdepacutrib = new SqlParameter();
                PardecACFdepacutrib.ParameterName = "@decACFdepacutrib";
                PardecACFdepacutrib.SqlDbType = SqlDbType.Decimal;
                PardecACFdepacutrib.Value = acfINBt_Inventariobienes.ACFdepacutrib;
                SqlCmd.Parameters.Add(PardecACFdepacutrib);
                //
                SqlParameter PariACfvutilniifanio = new SqlParameter();
                PariACfvutilniifanio.ParameterName = "@iACfvutilniifanio";
                PariACfvutilniifanio.SqlDbType = SqlDbType.Int;
                PariACfvutilniifanio.Value = acfINBt_Inventariobienes.ACFvutilniifanio;
                SqlCmd.Parameters.Add(PariACfvutilniifanio);
                //
                SqlParameter PariACFvutilniifdia = new SqlParameter();
                PariACFvutilniifdia.ParameterName = "@iACFvutilniifdia";
                PariACFvutilniifdia.SqlDbType = SqlDbType.Int;
                PariACFvutilniifdia.Value = acfINBt_Inventariobienes.ACFvutilniifdia;
                SqlCmd.Parameters.Add(PariACFvutilniifdia);
                //
                SqlParameter PardecACFvalorniif = new SqlParameter();
                PardecACFvalorniif.ParameterName = "@decACFvalorniif";
                PardecACFvalorniif.SqlDbType = SqlDbType.Decimal;
                PardecACFvalorniif.Value = acfINBt_Inventariobienes.ACFvalorniif;
                SqlCmd.Parameters.Add(PardecACFvalorniif);
                //
                SqlParameter PardecACFfactorniif= new SqlParameter();
                PardecACFfactorniif.ParameterName = "@decACFfactorniif";
                PardecACFfactorniif.SqlDbType = SqlDbType.Decimal;
                PardecACFfactorniif.Value = acfINBt_Inventariobienes.ACFfactorniif;
                SqlCmd.Parameters.Add(PardecACFfactorniif);
                //
                SqlParameter PardecACFdepacuniif = new SqlParameter();
                PardecACFdepacuniif.ParameterName = "@decACFdepacuniif";
                PardecACFdepacuniif.SqlDbType = SqlDbType.Decimal;
                PardecACFdepacuniif.Value = acfINBt_Inventariobienes.ACFdepacuniif;
                SqlCmd.Parameters.Add(PardecACFdepacuniif);
                //
                SqlParameter ParsACFobra = new SqlParameter();
                ParsACFobra.ParameterName = "@sACFobra";
                ParsACFobra.SqlDbType = SqlDbType.Char;
                ParsACFobra.Value = acfINBt_Inventariobienes.ACFobra;
                SqlCmd.Parameters.Add(ParsACFobra);
                //
                SqlParameter ParsACFord41 = new SqlParameter();
                ParsACFord41.ParameterName = "@sACFord41";
                ParsACFord41.SqlDbType = SqlDbType.Char;
                ParsACFord41.Value = acfINBt_Inventariobienes.ACFord41;
                SqlCmd.Parameters.Add(ParsACFord41);
                //
                SqlParameter ParsACFord42 = new SqlParameter();
                ParsACFord42.ParameterName = "@sACFord42";
                ParsACFord42.SqlDbType = SqlDbType.Char;
                ParsACFord42.Value = acfINBt_Inventariobienes.ACFord42;
                SqlCmd.Parameters.Add(ParsACFord42);
                //
                SqlParameter ParsACFord43 = new SqlParameter();
                ParsACFord43.ParameterName = "@sACFord43";
                ParsACFord43.SqlDbType = SqlDbType.Char;
                ParsACFord43.Value = acfINBt_Inventariobienes.ACFord43;
                SqlCmd.Parameters.Add(ParsACFord43);
                //
                SqlParameter ParsACFord44 = new SqlParameter();
                ParsACFord44.ParameterName = "@sACFord44";
                ParsACFord44.SqlDbType = SqlDbType.Char;
                ParsACFord44.Value = acfINBt_Inventariobienes.ACFord44;
                SqlCmd.Parameters.Add(ParsACFord44);
                //
               SqlParameter ParsACFanlue = new SqlParameter();
                ParsACFanlue.ParameterName = "@sACFanlue";
                ParsACFanlue.SqlDbType = SqlDbType.Char;
                ParsACFanlue.Value = acfINBt_Inventariobienes.ACFanlue;
                SqlCmd.Parameters.Add(ParsACFanlue);
                //
                SqlParameter ParsACFcuenta = new SqlParameter();
                ParsACFcuenta.ParameterName = "@sACFcuenta";
                ParsACFcuenta.SqlDbType = SqlDbType.Char;
                ParsACFcuenta.Value = acfINBt_Inventariobienes.ACFcuenta;
                SqlCmd.Parameters.Add(ParsACFcuenta);
                //
                SqlParameter ParsACFcuentadep = new SqlParameter();
                ParsACFcuentadep.ParameterName = "@sACFcuentadep";
                ParsACFcuentadep.SqlDbType = SqlDbType.Char;
                ParsACFcuentadep.Value = acfINBt_Inventariobienes.ACFcuentadep;
                SqlCmd.Parameters.Add(ParsACFcuenta);
                //
                 SqlParameter ParsLIFNR = new SqlParameter();
                ParsLIFNR.ParameterName = "@sLIFNR";
                ParsLIFNR.SqlDbType = SqlDbType.Char;
                ParsLIFNR.Value = acfINBt_Inventariobienes.LIFNR;
                SqlCmd.Parameters.Add(ParsLIFNR);
                //
                 SqlParameter ParsBLART = new SqlParameter();
                ParsBLART.ParameterName = "@sBLART";
                ParsBLART.SqlDbType = SqlDbType.Char;
                ParsBLART.Value = acfINBt_Inventariobienes.BLART;
                SqlCmd.Parameters.Add(ParsBLART);
                //
                 SqlParameter ParsACFcomprobante = new SqlParameter();
                ParsACFcomprobante.ParameterName = "@sACFcomprobante";
                ParsACFcomprobante.SqlDbType = SqlDbType.Char;
                ParsACFcomprobante.Value = acfINBt_Inventariobienes.ACFcomprobante;
                SqlCmd.Parameters.Add(ParsACFcuenta);
                //
                 SqlParameter ParsACFnotaingreso = new SqlParameter();
                ParsACFnotaingreso.ParameterName = "@sACFnotaingreso";
                ParsACFnotaingreso.SqlDbType = SqlDbType.Char;
                ParsACFnotaingreso.Value = acfINBt_Inventariobienes.ACFnotaingreso;
                SqlCmd.Parameters.Add(ParsACFnotaingreso);
                //
                SqlParameter PardtACFfechanotaingreso = new SqlParameter();
                PardtACFfechanotaingreso.ParameterName = "@dtACFfechanotaingreso";
                PardtACFfechanotaingreso.SqlDbType = SqlDbType.DateTime;
                PardtACFfechanotaingreso.Value = acfINBt_Inventariobienes.ACFfechanotaingreso;
                SqlCmd.Parameters.Add(PardtACFfechanotaingreso);
                //
                SqlParameter ParsACFordencompra = new SqlParameter();
                ParsACFordencompra.ParameterName = "@sACFordencompra";
                ParsACFordencompra.SqlDbType = SqlDbType.Char;
                ParsACFordencompra.Value = acfINBt_Inventariobienes.ACFordencompra;
                SqlCmd.Parameters.Add(ParsACFordencompra);
                //
                SqlParameter ParsACFobservacion = new SqlParameter();
                ParsACFobservacion.ParameterName = "@sACFobservacion";
                ParsACFobservacion.SqlDbType = SqlDbType.VarChar;
                ParsACFobservacion.Value = acfINBt_Inventariobienes.ACFobservacion;
                SqlCmd.Parameters.Add(ParsACFobservacion);
                //
                SqlParameter PariAMBid = new SqlParameter();
                PariAMBid.ParameterName = "@iAMBid";
                PariAMBid.SqlDbType = SqlDbType.Int;
                PariAMBid.Value = acfINBt_Inventariobienes.AMBid;
                SqlCmd.Parameters.Add(PariAMBid);
                //
                SqlParameter PariUBEid = new SqlParameter();
                PariUBEid.ParameterName = "@iUBEid";
                PariUBEid.SqlDbType = SqlDbType.Int;
                PariUBEid.Value = acfINBt_Inventariobienes.UBEid;
                SqlCmd.Parameters.Add(PariUBEid);
                //
               SqlParameter PardtACFfechacomprobante = new SqlParameter();
                PardtACFfechacomprobante.ParameterName = "@dtACFfechacomprobante";
                PardtACFfechacomprobante.SqlDbType = SqlDbType.DateTime;
                PardtACFfechacomprobante.Value = acfINBt_Inventariobienes.ACFfechacomprobante;
                SqlCmd.Parameters.Add(PardtACFfechacomprobante);
                //
                SqlParameter PardtACFfechaordencompra = new SqlParameter();
                PardtACFfechaordencompra.ParameterName = "@dtACFfechaordencompra";
                PardtACFfechaordencompra.SqlDbType = SqlDbType.DateTime;
                PardtACFfechaordencompra.Value = acfINBt_Inventariobienes.ACFfechaordencompra;
                SqlCmd.Parameters.Add(PardtACFfechaordencompra);
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
	public string Eliminar(DAcfINBt_Inventariobienes acfINBt_Inventariobienes) {
		
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
                SqlCmd.CommandText = "usp_D_acfINBt_Inventariobienes";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                 SqlParameter PariINVid = new SqlParameter();
                PariINVid.ParameterName = "@iINVid";
                PariINVid.SqlDbType = SqlDbType.Int;
                PariINVid.Value = acfINBt_Inventariobienes.INVid;
                SqlCmd.Parameters.Add(PariINVid);
                //
                 SqlParameter PariACFid = new SqlParameter();
                PariACFid.ParameterName = "@iACFid";
                PariACFid.SqlDbType = SqlDbType.Int;
                PariACFid.Value = acfINBt_Inventariobienes.ACFid;
                SqlCmd.Parameters.Add(PariACFid);

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

    public DataTable Buscar(string iACFid)
    {
        DataTable DtResultado = new DataTable("acfINBt_Inventariobienes");
        SqlConnection SqlCon = new SqlConnection();

        try
        {
            //Codigo
            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_acfINBt_Inventariobienes";
            SqlCmd.CommandType = CommandType.StoredProcedure;

            SqlParameter ParACFid = new SqlParameter();
            ParACFid.ParameterName = "@ACFid";
            ParACFid.SqlDbType = SqlDbType.Int;
            ParACFid.Size = 50;
            ParACFid.Value = iACFid;
            SqlCmd.Parameters.Add(ParACFid);

            //SqlParameter PariMVAid = new SqlParameter();
            //PariMVAid.ParameterName = "@iMVAid";
            //PariMVAid.SqlDbType = SqlDbType.Int;
            //PariMVAid.Value = MVAid;
            //SqlCmd.Parameters.Add(PariMVAid);


            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);
        }
        catch (Exception ex)
        {
            DtResultado = null;
        }
        return DtResultado;
    }
    //METODO ELIMINAR
    public string Copiar()
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
            SqlCmd.CommandText = "usp_C_acfINVp_Inventariobienes";
            SqlCmd.CommandType = CommandType.StoredProcedure;
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
    public string Copiar2(DAcfINBt_Inventariobienes acfINBt_Inventariobienes)
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
            SqlCmd.CommandText = "usp_C2_acfINVp_Inventariobienes";
            SqlCmd.CommandType = CommandType.StoredProcedure;
            //

            SqlParameter ParKOSTL = new SqlParameter();
            ParKOSTL.ParameterName = "@sKOSTL";
            ParKOSTL.SqlDbType = SqlDbType.Char;
                ParKOSTL.Value = KOSTL;
            SqlCmd.Parameters.Add(ParKOSTL);
            //
            //Ejecutamos nuestro comando

            rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "No hay Registro que coincidan con el Filtro";


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
    public DataTable Mostrar2()
    {
        DataTable DtResultado = new DataTable("acfINBt_Inventariobienes");
        SqlConnection SqlCon = new SqlConnection();

        try
        {
            //Codigo
            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_S2_acfINBt_Inventariobienes";
            SqlCmd.CommandType = CommandType.StoredProcedure;


            //SqlParameter PariMVAid = new SqlParameter();
            //PariMVAid.ParameterName = "@iMVAid";
            //PariMVAid.SqlDbType = SqlDbType.Int;
            //PariMVAid.Value = MVAid;
            //SqlCmd.Parameters.Add(PariMVAid);


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
