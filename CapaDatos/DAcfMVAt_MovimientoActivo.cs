using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DAcfMVAt_MovimientoActivo
    {
        private string mMVAid;
        private string mACFid;
        private string mACFactivo;
        private string mBUKRS;
        private string mSEGMENT;
        private string mKOSTL;
        private string mANLKL;
        private string mPERNR;
        private string mCSTid;
        private string mTMVid;
        private string mMVMid;
        private string mACFfmovimiento;
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
        private string mACFcomprobante;
        private string mACFnotaingreso;
        private string mACFfechanotaingreso;
        private string mACFordencompra;
        private string mACFfechaordencompra;
        private string mACFobservacion;
        private string mLIFNR;
        private string mBLART;
        private string mAMBid;
        private string mCMPid;
        private string mUBEid;


        public string MVAid
        {
            get { return mMVAid; }
            set { mMVAid = value; }
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
        public string CSTid
        {
            get { return mCSTid; }
            set { mCSTid = value; }
        }
        public string TMVid
        {
            get { return mTMVid; }
            set { mTMVid = value; }
        }
        public string MVMid
        {
            get { return mMVMid; }
            set { mMVMid = value; }
        }
        public string ACFfmovimiento
        {
            get { return mACFfmovimiento; }
            set { mACFfmovimiento = value; }
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
            set { mACFord41 = value; }
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
        public string ACFfechaordencompra
        {
            get { return mACFfechaordencompra; }
            set { mACFfechaordencompra = value; }
        }
        public string ACFobservacion
        {
            get { return mACFobservacion; }
            set { mACFobservacion = value; }
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
        public string AMBid
        {
            get { return mAMBid; }
            set { mAMBid = value; }
        }
        public string CMPid
        {
            get { return mCMPid; }
            set { mCMPid = value; }
        }
        public string UBEid
        {
            get { return mUBEid; }
            set { mUBEid = value; }
        }
 
 
 
 
        //Constructor vacío
        public DAcfMVAt_MovimientoActivo()
        {
	}
        public DAcfMVAt_MovimientoActivo(
         string MVAid,
         string ACFid,
         string ACFactivo,
         string BUKRS,
         string SEGMENT,
         string KOSTL,
         string ANLKL,
         string PERNR,
         string CSTid,
         string TMVid,
         string MVMid,
         string ACFfmovimiento,
         string VNRid,
         string ACFfincorporacion,
         string ACFfcapitalizacion,
         string ACFvutiltribanio,
         string ACFvutiltribdia,
         string ACFvalortrib,
         string ACFfactortrib,
         string ACFdepacutrib,
         string ACFvutilniifanio,
         string ACFvutilniifdia,
         string ACFvalorniif,
         string ACFfactorniif,
         string ACFdepacuniif,
         string ACFobra,
         string ACFord41,
         string ACFord42,
         string ACFord43,
         string ACFord44,
         string ACFanlue,
         string ACFcuenta,
         string ACFcuentadep,
         string ACFcomprobante,
         string ACFnotaingreso,
         string ACFfechanotaingreso,
         string ACFordencompra,
         string ACFfechaordencompra, 
         string ACFobservacion,
         string LIFNR, 
         string BLART,
         string AMBid,
         string CMPid,
         string UBEid
        )
        {
            this.MVAid = mMVAid;
            this.ACFid = mACFid;
            this.ACFactivo = mACFactivo;
            this.BUKRS = mBUKRS;
            this.SEGMENT = mSEGMENT;
            this.KOSTL = mKOSTL;
            this.ANLKL = mANLKL;
            this.PERNR = mPERNR;
            this.CSTid = mCSTid;
            this.TMVid = mTMVid;
            this.MVMid = mMVMid;
            this.ACFfmovimiento = mACFfmovimiento;
            this.VNRid = mVNRid;
            this.ACFfincorporacion = mACFfincorporacion;
            this.ACFfcapitalizacion = mACFfcapitalizacion;
            this.ACFvutiltribanio = mACFvutiltribanio;
            this.ACFvutiltribdia = mACFvutiltribdia;
            this.ACFvalortrib = mACFvalortrib;
            this.ACFfactortrib = mACFfactortrib;
            this.ACFdepacutrib = mACFdepacutrib;
            this.ACFvutilniifanio = mACFvutilniifanio;
            this.ACFvutilniifdia = mACFvutilniifdia;
            this.ACFvalorniif = mACFvalorniif;
            this.ACFfactorniif = mACFfactorniif;
            this.ACFdepacuniif = mACFdepacuniif;
            this.ACFobra = mACFobra;
            this.ACFord41 = mACFord41;
            this.ACFord42 = mACFord42;
            this.ACFord43 = mACFord43;
            this.ACFord44 = mACFord44;
            this.ACFanlue = mACFanlue;
            this.ACFcuenta = mACFcuenta;
            this.ACFcuentadep = mACFcuentadep;
            this.ACFcomprobante = mACFcomprobante;
            this.ACFnotaingreso = mACFnotaingreso;
            this.ACFfechanotaingreso = mACFfechanotaingreso;
            this.ACFordencompra = mACFordencompra;
            this.ACFfechaordencompra = mACFfechaordencompra;
            this.ACFobservacion = mACFobservacion;
            this.LIFNR = mLIFNR;
            this.BLART = mBLART;
            this.AMBid = mAMBid;
            this.CMPid = mCMPid;
            this.UBEid = mUBEid;
            

        }

        //METODO MOSTRAR
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("acfMVAt_MovimientoActivo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfMVAt_MovimientoActivo";
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
        public string Insertar(DAcfMVAt_MovimientoActivo acfMVAt_MovimientoActivo)
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
                SqlCmd.CommandText = "usp_I_acfMVAt_MovimientoActivo";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter PariMVAid = new SqlParameter();
                PariMVAid.ParameterName = "@iMVAid";
                PariMVAid.SqlDbType = SqlDbType.Int;
                PariMVAid.Value = acfMVAt_MovimientoActivo.MVAid;
                SqlCmd.Parameters.Add(PariMVAid);
                //
                SqlParameter PariACFid = new SqlParameter();
                PariACFid.ParameterName = "@iACFid";
                PariACFid.SqlDbType = SqlDbType.Int;
                PariACFid.Value = acfMVAt_MovimientoActivo.ACFid;
                SqlCmd.Parameters.Add(PariACFid);
                //
                SqlParameter ParsACFactivo = new SqlParameter();
                ParsACFactivo.ParameterName = "@sACFactivo";
                ParsACFactivo.SqlDbType = SqlDbType.VarChar;
                ParsACFactivo.Value = acfMVAt_MovimientoActivo.ACFactivo;
                SqlCmd.Parameters.Add(ParsACFactivo);
                //
                SqlParameter ParsBUKRS = new SqlParameter();
                ParsBUKRS.ParameterName = "@sBUKRS";
                ParsBUKRS.SqlDbType = SqlDbType.Char;
                ParsBUKRS.Value = acfMVAt_MovimientoActivo.BUKRS;
                SqlCmd.Parameters.Add(ParsBUKRS);
                //
                SqlParameter ParsSEGMENT = new SqlParameter();
                ParsSEGMENT.ParameterName = "@sSEGMENT";
                ParsSEGMENT.SqlDbType = SqlDbType.VarChar;
                ParsSEGMENT.Value = acfMVAt_MovimientoActivo.SEGMENT;
                SqlCmd.Parameters.Add(ParsSEGMENT);
                //
                SqlParameter ParsKOSTL = new SqlParameter();
                ParsKOSTL.ParameterName = "@sKOSTL";
                ParsKOSTL.SqlDbType = SqlDbType.Char;
                ParsKOSTL.Value = acfMVAt_MovimientoActivo.KOSTL;
                SqlCmd.Parameters.Add(ParsKOSTL);
                //
                SqlParameter ParsANLKL = new SqlParameter();
                ParsANLKL.ParameterName = "@sANLKL";
                ParsANLKL.SqlDbType = SqlDbType.Char;
                ParsANLKL.Value = acfMVAt_MovimientoActivo.ANLKL;
                SqlCmd.Parameters.Add(ParsANLKL);
                //
                SqlParameter ParsPERNR = new SqlParameter();
                ParsPERNR.ParameterName = "@sPERNR";
                ParsPERNR.SqlDbType = SqlDbType.Char;
                ParsPERNR.Value = acfMVAt_MovimientoActivo.PERNR;
                SqlCmd.Parameters.Add(ParsPERNR);
                //
                SqlParameter ParCSTid = new SqlParameter();
                ParCSTid.ParameterName = "@sCSTid";
                ParCSTid.SqlDbType = SqlDbType.Char;
                ParCSTid.Value = acfMVAt_MovimientoActivo.CSTid;
                SqlCmd.Parameters.Add(ParCSTid);
                //
                SqlParameter ParTMVid = new SqlParameter();
                ParTMVid.ParameterName = "@sTMVid";
                ParTMVid.SqlDbType = SqlDbType.Char;
                ParTMVid.Value = acfMVAt_MovimientoActivo.TMVid;
                SqlCmd.Parameters.Add(ParTMVid);
                //
                SqlParameter ParMVMid = new SqlParameter();
                ParMVMid.ParameterName = "@sMVMid";
                ParMVMid.SqlDbType = SqlDbType.Char;
                ParMVMid.Value = acfMVAt_MovimientoActivo.MVMid;
                SqlCmd.Parameters.Add(ParMVMid);
                //
                SqlParameter ParACFfmovimiento = new SqlParameter();
                ParACFfmovimiento.ParameterName = "@dtACFfmovimiento";
                ParACFfmovimiento.SqlDbType = SqlDbType.DateTime;
                ParACFfmovimiento.Value = acfMVAt_MovimientoActivo.ACFfmovimiento;
                SqlCmd.Parameters.Add(ParACFfmovimiento);
                //
               
                SqlParameter ParsVNRid = new SqlParameter();
                ParsVNRid.ParameterName = "sVNRid";
                ParsVNRid.SqlDbType = SqlDbType.Char;
                ParsVNRid.Value = acfMVAt_MovimientoActivo.VNRid;
                SqlCmd.Parameters.Add(ParsVNRid);
                //
                SqlParameter ParACFfincorporacion = new SqlParameter();
                ParACFfincorporacion.ParameterName = "@dtACFfincorporacion";
                ParACFfincorporacion.SqlDbType = SqlDbType.DateTime;
                ParACFfincorporacion.Value = acfMVAt_MovimientoActivo.ACFfincorporacion;
                SqlCmd.Parameters.Add(ParACFfincorporacion);
                //
                SqlParameter ParACFfcapitalizacion = new SqlParameter();
                ParACFfcapitalizacion.ParameterName = "@dtACFfcapitalizacion";
                ParACFfcapitalizacion.SqlDbType = SqlDbType.DateTime;
                ParACFfcapitalizacion.Value = acfMVAt_MovimientoActivo.ACFfcapitalizacion;
                SqlCmd.Parameters.Add(ParACFfcapitalizacion);
                //
                SqlParameter ParACFvutiltribanio = new SqlParameter();
                ParACFvutiltribanio.ParameterName = "@iACFvutiltribanio";
                ParACFvutiltribanio.SqlDbType = SqlDbType.Int;
                ParACFvutiltribanio.Value = acfMVAt_MovimientoActivo.ACFvutiltribanio;
                SqlCmd.Parameters.Add(ParACFvutiltribanio);
                //
                SqlParameter ParACFvutiltribdia = new SqlParameter();
                ParACFvutiltribdia.ParameterName = "@iACFvutiltribdia";
                ParACFvutiltribdia.SqlDbType = SqlDbType.Int;
                ParACFvutiltribdia.Value = acfMVAt_MovimientoActivo.ACFvutiltribdia;
                SqlCmd.Parameters.Add(ParACFvutiltribdia);
                //
                SqlParameter ParACFvalortrib = new SqlParameter();
                ParACFvalortrib.ParameterName = "@decACFvalortrib";
                ParACFvalortrib.SqlDbType = SqlDbType.Decimal;
                ParACFvalortrib.Value = acfMVAt_MovimientoActivo.ACFvalortrib;
                SqlCmd.Parameters.Add(ParACFvalortrib);
                //
                SqlParameter ParACFfactortrib = new SqlParameter();
                ParACFfactortrib.ParameterName = "@decACFfactortrib";
                ParACFfactortrib.SqlDbType = SqlDbType.Decimal;
                ParACFfactortrib.Value = acfMVAt_MovimientoActivo.ACFfactortrib;
                SqlCmd.Parameters.Add(ParACFfactortrib);
                //
                SqlParameter ParACFdepacutrib = new SqlParameter();
                ParACFdepacutrib.ParameterName = "@decACFdepacutrib";
                ParACFdepacutrib.SqlDbType = SqlDbType.Decimal;
                ParACFdepacutrib.Value = acfMVAt_MovimientoActivo.ACFdepacutrib;
                SqlCmd.Parameters.Add(ParACFdepacutrib);
                //
                SqlParameter ParACFvutilniifanio = new SqlParameter();
                ParACFvutilniifanio.ParameterName = "@iACFvutilniifanio";
                ParACFvutilniifanio.SqlDbType = SqlDbType.Int;
                ParACFvutilniifanio.Value = acfMVAt_MovimientoActivo.ACFvutilniifanio;
                SqlCmd.Parameters.Add(ParACFvutilniifanio);
                //
                SqlParameter ParACFvutilniifdia = new SqlParameter();
                ParACFvutilniifdia.ParameterName = "@iACFvutilniifdia";
                ParACFvutilniifdia.SqlDbType = SqlDbType.Int;
                ParACFvutilniifdia.Value = acfMVAt_MovimientoActivo.ACFvutilniifdia;
                SqlCmd.Parameters.Add(ParACFvutilniifdia);
                //
                SqlParameter ParACFvalorniif = new SqlParameter();
                ParACFvalorniif.ParameterName = "@decACFvalorniif";
                ParACFvalorniif.SqlDbType = SqlDbType.Decimal;
                ParACFvalorniif.Value = acfMVAt_MovimientoActivo.ACFvalorniif;
                SqlCmd.Parameters.Add(ParACFvalorniif);
                //
                SqlParameter ParACFfactorniif = new SqlParameter();
                ParACFfactorniif.ParameterName = "@dACFfactorniif";
                ParACFfactorniif.SqlDbType = SqlDbType.Decimal;
                ParACFfactorniif.Value = acfMVAt_MovimientoActivo.ACFfactorniif;
                SqlCmd.Parameters.Add(ParACFfactorniif);
                //
                SqlParameter ParACFdepacuniif = new SqlParameter();
                ParACFdepacuniif.ParameterName = "@dACFdepacuniif";
                ParACFdepacuniif.SqlDbType = SqlDbType.Decimal;
                ParACFdepacuniif.Value = acfMVAt_MovimientoActivo.ACFdepacuniif;
                SqlCmd.Parameters.Add(ParACFdepacuniif);
                //
                SqlParameter ParACFobra  = new SqlParameter();
                ParACFobra .ParameterName = "@sACFobra ";
                ParACFobra .SqlDbType = SqlDbType.Char;
                ParACFobra .Value = acfMVAt_MovimientoActivo.ACFobra;
                SqlCmd.Parameters.Add(ParACFobra );
                //
                SqlParameter ParsACFord41 = new SqlParameter();
                ParsACFord41.ParameterName = "@sACFord41";
                ParsACFord41.SqlDbType = SqlDbType.Char;
                ParsACFord41.Value = acfMVAt_MovimientoActivo.ACFord41;
                SqlCmd.Parameters.Add(ParsACFord41);
                //
                SqlParameter ParACFord42 = new SqlParameter();
                ParACFord42.ParameterName = "@sACFord42";
                ParACFord42.SqlDbType = SqlDbType.Char;
                ParACFord42.Value = acfMVAt_MovimientoActivo.ACFord42;
                SqlCmd.Parameters.Add(ParACFord42);
                //
                SqlParameter ParACFord43 = new SqlParameter();
                ParACFord43.ParameterName = "@sACFord43";
                ParACFord43.SqlDbType = SqlDbType.Char;
                ParACFord43.Value = acfMVAt_MovimientoActivo.ACFord43;
                SqlCmd.Parameters.Add(ParACFord43);
                //
                SqlParameter ParACFord44 = new SqlParameter();
                ParACFord44.ParameterName = "@sACFord44";
                ParACFord44.SqlDbType = SqlDbType.Char;
                ParACFord44.Value = acfMVAt_MovimientoActivo.ACFord44;
                SqlCmd.Parameters.Add(ParACFord44);
                //
                SqlParameter ParACFanlue = new SqlParameter();
                ParACFanlue.ParameterName = "@sACFanlue";
                ParACFanlue.SqlDbType = SqlDbType.Char;
                ParACFanlue.Value = acfMVAt_MovimientoActivo.ACFanlue;
                SqlCmd.Parameters.Add(ParACFanlue);
                //
                SqlParameter ParACFcuenta = new SqlParameter();
                ParACFcuenta.ParameterName = "@sACFcuenta";
                ParACFcuenta.SqlDbType = SqlDbType.Char;
                ParACFcuenta.Value = acfMVAt_MovimientoActivo.ACFcuenta;
                SqlCmd.Parameters.Add(ParACFcuenta);
                //
                SqlParameter ParACFcuentadep = new SqlParameter();
                ParACFcuentadep.ParameterName = "@sACFcuentadep";
                ParACFcuentadep.SqlDbType = SqlDbType.Char;
                ParACFcuentadep.Value = acfMVAt_MovimientoActivo.ACFcuentadep;
                SqlCmd.Parameters.Add(ParACFcuentadep);
                //
                SqlParameter ParACFcomprobante = new SqlParameter();
                ParACFcomprobante.ParameterName = "@sACFcomprobante";
                ParACFcomprobante.SqlDbType = SqlDbType.Char;
                ParACFcomprobante.Value = acfMVAt_MovimientoActivo.ACFcomprobante;
                SqlCmd.Parameters.Add(ParACFcomprobante);
                //
                SqlParameter ParACFnotaingreso = new SqlParameter();
                ParACFnotaingreso.ParameterName = "@sACFnotaingreso";
                ParACFnotaingreso.SqlDbType = SqlDbType.Char;
                ParACFnotaingreso.Value = acfMVAt_MovimientoActivo.ACFnotaingreso;
                SqlCmd.Parameters.Add(ParACFnotaingreso);
                //
                SqlParameter ParACFfechanotaingreso = new SqlParameter();
                ParACFfechanotaingreso.ParameterName = "@dtACFfechanotaingreso";
                ParACFfechanotaingreso.SqlDbType = SqlDbType.DateTime;
                ParACFfechanotaingreso.Value = acfMVAt_MovimientoActivo.ACFfechanotaingreso;
                SqlCmd.Parameters.Add(ParACFfechanotaingreso);
                //
                SqlParameter ParACFordencompra = new SqlParameter();
                ParACFordencompra.ParameterName = "@sACFordencompra";
                ParACFordencompra.SqlDbType = SqlDbType.Char;
                ParACFordencompra.Value = acfMVAt_MovimientoActivo.ACFordencompra;
                SqlCmd.Parameters.Add(ParACFordencompra);
                //
                SqlParameter ParACFfechaordencompra = new SqlParameter();
                ParACFfechaordencompra.ParameterName = "@dtACFfechaordencompra";
                ParACFfechaordencompra.SqlDbType = SqlDbType.DateTime;
                ParACFfechaordencompra.Value = acfMVAt_MovimientoActivo.ACFfechaordencompra;
                SqlCmd.Parameters.Add(ParACFfechaordencompra);
                //
                SqlParameter ParACFobservacion = new SqlParameter();
                ParACFobservacion.ParameterName = "@sACFobservacion";
                ParACFobservacion.SqlDbType = SqlDbType.Char;
                ParACFobservacion.Value = acfMVAt_MovimientoActivo.ACFobservacion;
                SqlCmd.Parameters.Add(ParACFobservacion);
                //
                SqlParameter ParLIFNR = new SqlParameter();
                ParLIFNR.ParameterName = "@sLIFNR";
                ParLIFNR.SqlDbType = SqlDbType.Char;
                ParLIFNR.Value = acfMVAt_MovimientoActivo.LIFNR;
                SqlCmd.Parameters.Add(ParLIFNR);
                //
                SqlParameter ParBLART = new SqlParameter();
                ParBLART.ParameterName = "@sBLART";
                ParBLART.SqlDbType = SqlDbType.Char;
                ParBLART.Value = acfMVAt_MovimientoActivo.BLART;
                SqlCmd.Parameters.Add(ParBLART);
                //
                SqlParameter ParAMBid = new SqlParameter();
                ParAMBid.ParameterName = "@iAMBid";
                ParAMBid.SqlDbType = SqlDbType.Int;
                ParAMBid.Value = acfMVAt_MovimientoActivo.AMBid;
                SqlCmd.Parameters.Add(ParAMBid);
                //
                SqlParameter ParCMPid = new SqlParameter();
                ParCMPid.ParameterName = "@sCMPid";
                ParCMPid.SqlDbType = SqlDbType.Char;
                ParCMPid.Value = acfMVAt_MovimientoActivo.CMPid;
                SqlCmd.Parameters.Add(ParCMPid);
                //
                SqlParameter ParUBEid = new SqlParameter();
                ParUBEid.ParameterName = "@iUBEid";
                ParUBEid.SqlDbType = SqlDbType.Int;
                ParUBEid.Value = acfMVAt_MovimientoActivo.UBEid;
                SqlCmd.Parameters.Add(ParUBEid);
                
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
        public string Editar(DAcfMVAt_MovimientoActivo acfMVAt_MovimientoActivo)
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
                SqlCmd.CommandText = "usp_U_acfMVAt_MovimientoActivo";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter PariMVAid = new SqlParameter();
                PariMVAid.ParameterName = "@iMVAid";
                PariMVAid.SqlDbType = SqlDbType.Int;
                PariMVAid.Value = acfMVAt_MovimientoActivo.MVAid;
                SqlCmd.Parameters.Add(PariMVAid);
                //
                SqlParameter PariACFid = new SqlParameter();
                PariACFid.ParameterName = "@iACFid";
                PariACFid.SqlDbType = SqlDbType.Int;
                PariACFid.Value = acfMVAt_MovimientoActivo.ACFid;
                SqlCmd.Parameters.Add(PariACFid);
                //
                SqlParameter ParsACFactivo = new SqlParameter();
                ParsACFactivo.ParameterName = "@sACFactivo";
                ParsACFactivo.SqlDbType = SqlDbType.VarChar;
                ParsACFactivo.Value = acfMVAt_MovimientoActivo.ACFactivo;
                SqlCmd.Parameters.Add(ParsACFactivo);
                //
                SqlParameter ParsBUKRS = new SqlParameter();
                ParsBUKRS.ParameterName = "@sBUKRS";
                ParsBUKRS.SqlDbType = SqlDbType.Char;
                ParsBUKRS.Value = acfMVAt_MovimientoActivo.BUKRS;
                SqlCmd.Parameters.Add(ParsBUKRS);
                //
                SqlParameter ParsSEGMENT = new SqlParameter();
                ParsSEGMENT.ParameterName = "@sSEGMENT";
                ParsSEGMENT.SqlDbType = SqlDbType.VarChar;
                ParsSEGMENT.Value = acfMVAt_MovimientoActivo.SEGMENT;
                SqlCmd.Parameters.Add(ParsSEGMENT);
                //
                SqlParameter ParsKOSTL = new SqlParameter();
                ParsKOSTL.ParameterName = "@sKOSTL";
                ParsKOSTL.SqlDbType = SqlDbType.Char;
                ParsKOSTL.Value = acfMVAt_MovimientoActivo.KOSTL;
                SqlCmd.Parameters.Add(ParsKOSTL);
                //
                SqlParameter ParsANLKL = new SqlParameter();
                ParsANLKL.ParameterName = "@sANLKL";
                ParsANLKL.SqlDbType = SqlDbType.Char;
                ParsANLKL.Value = acfMVAt_MovimientoActivo.ANLKL;
                SqlCmd.Parameters.Add(ParsANLKL);
                //
                SqlParameter ParsPERNR = new SqlParameter();
                ParsPERNR.ParameterName = "@sPERNR";
                ParsPERNR.SqlDbType = SqlDbType.Char;
                ParsPERNR.Value = acfMVAt_MovimientoActivo.PERNR;
                SqlCmd.Parameters.Add(ParsPERNR);
                //
                SqlParameter ParCSTid = new SqlParameter();
                ParCSTid.ParameterName = "@sCSTid";
                ParCSTid.SqlDbType = SqlDbType.Char;
                ParCSTid.Value = acfMVAt_MovimientoActivo.CSTid;
                SqlCmd.Parameters.Add(ParCSTid);
                //
                SqlParameter ParTMVid = new SqlParameter();
                ParTMVid.ParameterName = "@sTMVid";
                ParTMVid.SqlDbType = SqlDbType.Char;
                ParTMVid.Value = acfMVAt_MovimientoActivo.TMVid;
                SqlCmd.Parameters.Add(ParTMVid);
                //
                SqlParameter ParMVMid = new SqlParameter();
                ParMVMid.ParameterName = "@sMVMid";
                ParMVMid.SqlDbType = SqlDbType.Char;
                ParMVMid.Value = acfMVAt_MovimientoActivo.MVMid;
                SqlCmd.Parameters.Add(ParMVMid);
                //
                SqlParameter ParACFfmovimiento = new SqlParameter();
                ParACFfmovimiento.ParameterName = "@dtACFfmovimiento";
                ParACFfmovimiento.SqlDbType = SqlDbType.DateTime;
                ParACFfmovimiento.Value = acfMVAt_MovimientoActivo.ACFfmovimiento;
                SqlCmd.Parameters.Add(ParACFfmovimiento);
                //

                SqlParameter ParsVNRid = new SqlParameter();
                ParsVNRid.ParameterName = "sVNRid";
                ParsVNRid.SqlDbType = SqlDbType.Char;
                ParsVNRid.Value = acfMVAt_MovimientoActivo.VNRid;
                SqlCmd.Parameters.Add(ParsVNRid);
                //
                SqlParameter ParACFfincorporacion = new SqlParameter();
                ParACFfincorporacion.ParameterName = "@dtACFfincorporacion";
                ParACFfincorporacion.SqlDbType = SqlDbType.DateTime;
                ParACFfincorporacion.Value = acfMVAt_MovimientoActivo.ACFfincorporacion;
                SqlCmd.Parameters.Add(ParACFfincorporacion);
                //
                SqlParameter ParACFfcapitalizacion = new SqlParameter();
                ParACFfcapitalizacion.ParameterName = "@dtACFfcapitalizacion";
                ParACFfcapitalizacion.SqlDbType = SqlDbType.DateTime;
                ParACFfcapitalizacion.Value = acfMVAt_MovimientoActivo.ACFfcapitalizacion;
                SqlCmd.Parameters.Add(ParACFfcapitalizacion);
                //
                SqlParameter ParACFvutiltribanio = new SqlParameter();
                ParACFvutiltribanio.ParameterName = "@iACFvutiltribanio";
                ParACFvutiltribanio.SqlDbType = SqlDbType.Int;
                ParACFvutiltribanio.Value = acfMVAt_MovimientoActivo.ACFvutiltribanio;
                SqlCmd.Parameters.Add(ParACFvutiltribanio);
                //
                SqlParameter ParACFvutiltribdia = new SqlParameter();
                ParACFvutiltribdia.ParameterName = "@iACFvutiltribdia";
                ParACFvutiltribdia.SqlDbType = SqlDbType.Int;
                ParACFvutiltribdia.Value = acfMVAt_MovimientoActivo.ACFvutiltribdia;
                SqlCmd.Parameters.Add(ParACFvutiltribdia);
                //
                SqlParameter ParACFvalortrib = new SqlParameter();
                ParACFvalortrib.ParameterName = "@decACFvalortrib";
                ParACFvalortrib.SqlDbType = SqlDbType.Decimal;
                ParACFvalortrib.Value = acfMVAt_MovimientoActivo.ACFvalortrib;
                SqlCmd.Parameters.Add(ParACFvalortrib);
                //
                SqlParameter ParACFfactortrib = new SqlParameter();
                ParACFfactortrib.ParameterName = "@decACFfactortrib";
                ParACFfactortrib.SqlDbType = SqlDbType.Decimal;
                ParACFfactortrib.Value = acfMVAt_MovimientoActivo.ACFfactortrib;
                SqlCmd.Parameters.Add(ParACFfactortrib);
                //
                SqlParameter ParACFdepacutrib = new SqlParameter();
                ParACFdepacutrib.ParameterName = "@decACFdepacutrib";
                ParACFdepacutrib.SqlDbType = SqlDbType.Decimal;
                ParACFdepacutrib.Value = acfMVAt_MovimientoActivo.ACFdepacutrib;
                SqlCmd.Parameters.Add(ParACFdepacutrib);
                //
                SqlParameter ParACFvutilniifanio = new SqlParameter();
                ParACFvutilniifanio.ParameterName = "@iACFvutilniifanio";
                ParACFvutilniifanio.SqlDbType = SqlDbType.Int;
                ParACFvutilniifanio.Value = acfMVAt_MovimientoActivo.ACFvutilniifanio;
                SqlCmd.Parameters.Add(ParACFvutilniifanio);
                //
                SqlParameter ParACFvutilniifdia = new SqlParameter();
                ParACFvutilniifdia.ParameterName = "@iACFvutilniifdia";
                ParACFvutilniifdia.SqlDbType = SqlDbType.Int;
                ParACFvutilniifdia.Value = acfMVAt_MovimientoActivo.ACFvutilniifdia;
                SqlCmd.Parameters.Add(ParACFvutilniifdia);
                //
                SqlParameter ParACFvalorniif = new SqlParameter();
                ParACFvalorniif.ParameterName = "@decACFvalorniif";
                ParACFvalorniif.SqlDbType = SqlDbType.Decimal;
                ParACFvalorniif.Value = acfMVAt_MovimientoActivo.ACFvalorniif;
                SqlCmd.Parameters.Add(ParACFvalorniif);
                //
                SqlParameter ParACFfactorniif = new SqlParameter();
                ParACFfactorniif.ParameterName = "@dACFfactorniif";
                ParACFfactorniif.SqlDbType = SqlDbType.Decimal;
                ParACFfactorniif.Value = acfMVAt_MovimientoActivo.ACFfactorniif;
                SqlCmd.Parameters.Add(ParACFfactorniif);
                //
                SqlParameter ParACFdepacuniif = new SqlParameter();
                ParACFdepacuniif.ParameterName = "@dACFdepacuniif";
                ParACFdepacuniif.SqlDbType = SqlDbType.Decimal;
                ParACFdepacuniif.Value = acfMVAt_MovimientoActivo.ACFdepacuniif;
                SqlCmd.Parameters.Add(ParACFdepacuniif);
                //
                SqlParameter ParACFobra = new SqlParameter();
                ParACFobra.ParameterName = "@sACFobra ";
                ParACFobra.SqlDbType = SqlDbType.Char;
                ParACFobra.Value = acfMVAt_MovimientoActivo.ACFobra;
                SqlCmd.Parameters.Add(ParACFobra);
                //
                SqlParameter ParsACFord41 = new SqlParameter();
                ParsACFord41.ParameterName = "@sACFord41";
                ParsACFord41.SqlDbType = SqlDbType.Char;
                ParsACFord41.Value = acfMVAt_MovimientoActivo.ACFord41;
                SqlCmd.Parameters.Add(ParsACFord41);
                //
                SqlParameter ParACFord42 = new SqlParameter();
                ParACFord42.ParameterName = "@sACFord42";
                ParACFord42.SqlDbType = SqlDbType.Char;
                ParACFord42.Value = acfMVAt_MovimientoActivo.ACFord42;
                SqlCmd.Parameters.Add(ParACFord42);
                //
                SqlParameter ParACFord43 = new SqlParameter();
                ParACFord43.ParameterName = "@sACFord43";
                ParACFord43.SqlDbType = SqlDbType.Char;
                ParACFord43.Value = acfMVAt_MovimientoActivo.ACFord43;
                SqlCmd.Parameters.Add(ParACFord43);
                //
                SqlParameter ParACFord44 = new SqlParameter();
                ParACFord44.ParameterName = "@sACFord44";
                ParACFord44.SqlDbType = SqlDbType.Char;
                ParACFord44.Value = acfMVAt_MovimientoActivo.ACFord44;
                SqlCmd.Parameters.Add(ParACFord44);
                //
                SqlParameter ParACFanlue = new SqlParameter();
                ParACFanlue.ParameterName = "@sACFanlue";
                ParACFanlue.SqlDbType = SqlDbType.Char;
                ParACFanlue.Value = acfMVAt_MovimientoActivo.ACFanlue;
                SqlCmd.Parameters.Add(ParACFanlue);
                //
                SqlParameter ParACFcuenta = new SqlParameter();
                ParACFcuenta.ParameterName = "@sACFcuenta";
                ParACFcuenta.SqlDbType = SqlDbType.Char;
                ParACFcuenta.Value = acfMVAt_MovimientoActivo.ACFcuenta;
                SqlCmd.Parameters.Add(ParACFcuenta);
                //
                SqlParameter ParACFcuentadep = new SqlParameter();
                ParACFcuentadep.ParameterName = "@sACFcuentadep";
                ParACFcuentadep.SqlDbType = SqlDbType.Char;
                ParACFcuentadep.Value = acfMVAt_MovimientoActivo.ACFcuentadep;
                SqlCmd.Parameters.Add(ParACFcuentadep);
                //
                SqlParameter ParACFcomprobante = new SqlParameter();
                ParACFcomprobante.ParameterName = "@sACFcomprobante";
                ParACFcomprobante.SqlDbType = SqlDbType.Char;
                ParACFcomprobante.Value = acfMVAt_MovimientoActivo.ACFcomprobante;
                SqlCmd.Parameters.Add(ParACFcomprobante);
                //
                SqlParameter ParACFnotaingreso = new SqlParameter();
                ParACFnotaingreso.ParameterName = "@sACFnotaingreso";
                ParACFnotaingreso.SqlDbType = SqlDbType.Char;
                ParACFnotaingreso.Value = acfMVAt_MovimientoActivo.ACFnotaingreso;
                SqlCmd.Parameters.Add(ParACFnotaingreso);
                //
                SqlParameter ParACFfechanotaingreso = new SqlParameter();
                ParACFfechanotaingreso.ParameterName = "@dtACFfechanotaingreso";
                ParACFfechanotaingreso.SqlDbType = SqlDbType.DateTime;
                ParACFfechanotaingreso.Value = acfMVAt_MovimientoActivo.ACFfechanotaingreso;
                SqlCmd.Parameters.Add(ParACFfechanotaingreso);
                //
                SqlParameter ParACFordencompra = new SqlParameter();
                ParACFordencompra.ParameterName = "@sACFordencompra";
                ParACFordencompra.SqlDbType = SqlDbType.Char;
                ParACFordencompra.Value = acfMVAt_MovimientoActivo.ACFordencompra;
                SqlCmd.Parameters.Add(ParACFordencompra);
                //
                SqlParameter ParACFfechaordencompra = new SqlParameter();
                ParACFfechaordencompra.ParameterName = "@dtACFfechaordencompra";
                ParACFfechaordencompra.SqlDbType = SqlDbType.DateTime;
                ParACFfechaordencompra.Value = acfMVAt_MovimientoActivo.ACFfechaordencompra;
                SqlCmd.Parameters.Add(ParACFfechaordencompra);
                //
                SqlParameter ParACFobservacion = new SqlParameter();
                ParACFobservacion.ParameterName = "@sACFobservacion";
                ParACFobservacion.SqlDbType = SqlDbType.Char;
                ParACFobservacion.Value = acfMVAt_MovimientoActivo.ACFobservacion;
                SqlCmd.Parameters.Add(ParACFobservacion);
                //
                SqlParameter ParLIFNR = new SqlParameter();
                ParLIFNR.ParameterName = "@sLIFNR";
                ParLIFNR.SqlDbType = SqlDbType.Char;
                ParLIFNR.Value = acfMVAt_MovimientoActivo.LIFNR;
                SqlCmd.Parameters.Add(ParLIFNR);
                //
                SqlParameter ParBLART = new SqlParameter();
                ParBLART.ParameterName = "@sBLART";
                ParBLART.SqlDbType = SqlDbType.Char;
                ParBLART.Value = acfMVAt_MovimientoActivo.BLART;
                SqlCmd.Parameters.Add(ParBLART);
                //
                SqlParameter ParAMBid = new SqlParameter();
                ParAMBid.ParameterName = "@iAMBid";
                ParAMBid.SqlDbType = SqlDbType.Int;
                ParAMBid.Value = acfMVAt_MovimientoActivo.AMBid;
                SqlCmd.Parameters.Add(ParAMBid);
                //
                SqlParameter ParCMPid = new SqlParameter();
                ParCMPid.ParameterName = "@sCMPid";
                ParCMPid.SqlDbType = SqlDbType.Char;
                ParCMPid.Value = acfMVAt_MovimientoActivo.CMPid;
                SqlCmd.Parameters.Add(ParCMPid);
                //
                SqlParameter ParUBEid = new SqlParameter();
                ParUBEid.ParameterName = "@iUBEid";
                ParUBEid.SqlDbType = SqlDbType.Int;
                ParUBEid.Value = acfMVAt_MovimientoActivo.UBEid;
                SqlCmd.Parameters.Add(ParUBEid);
                

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
        public string Eliminar(DAcfMVAt_MovimientoActivo acfMVAt_MovimientoActivo)
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
                SqlCmd.CommandText = "usp_D_acfMVAt_MovimientoActivo";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter PariMVAid = new SqlParameter();
                PariMVAid.ParameterName = "@iMVAid";
                PariMVAid.SqlDbType = SqlDbType.Int;
                PariMVAid.Value = acfMVAt_MovimientoActivo.MVAid;
                SqlCmd.Parameters.Add(PariMVAid);
                //
                SqlParameter PariACFid = new SqlParameter();
                PariACFid.ParameterName = "@iACFid";
                PariACFid.SqlDbType = SqlDbType.Int;
                PariACFid.Value = acfMVAt_MovimientoActivo.ACFid;
                SqlCmd.Parameters.Add(PariACFid);
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

        public DataTable Buscar(DAcfMVAt_MovimientoActivo acfMVAt_MovimientoActivo)
        {

            DataTable DtResultado = new DataTable("acfMVAt_MovimientoActivo");
            SqlConnection SqlCon = new SqlConnection();


            try
            {

                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_B_acfMVAt_MovimientoActivo";
                SqlCmd.CommandType = CommandType.StoredProcedure;



                SqlParameter PariMVAid = new SqlParameter();
                PariMVAid.ParameterName = "@iMVAid";
                PariMVAid.SqlDbType = SqlDbType.Int;
                PariMVAid.Value = acfMVAt_MovimientoActivo.MVAid;
                SqlCmd.Parameters.Add(PariMVAid);
                //
                SqlParameter PariACFid = new SqlParameter();
                PariACFid.ParameterName = "@iACFid";
                PariACFid.SqlDbType = SqlDbType.Int;
                PariACFid.Value = acfMVAt_MovimientoActivo.ACFid;
                SqlCmd.Parameters.Add(PariACFid);
                //

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
