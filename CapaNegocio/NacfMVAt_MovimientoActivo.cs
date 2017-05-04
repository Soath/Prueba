using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfMVAt_MovimientoActivo
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
         string mMVAid,
         string mACFid,
         string mACFactivo,
         string mBUKRS,
         string mSEGMENT,
         string mKOSTL,
         string mANLKL,
         string mPERNR,
         string mCSTid,
         string mTMVid,
         string mMVMid,
         string mACFfmovimiento,
         string mVNRid,
         string mACFfincorporacion,
         string mACFfcapitalizacion,
         string mACFvutiltribanio,
         string mACFvutiltribdia,
         string mACFvalortrib,
         string mACFfactortrib,
         string mACFdepacutrib,
         string mACFvutilniifanio,
         string mACFvutilniifdia,
         string mACFvalorniif,
         string mACFfactorniif,
         string mACFdepacuniif,
         string mACFobra,
         string mACFord41,
         string mACFord42,
         string mACFord43,
         string mACFord44,
         string mACFanlue,
         string mACFcuenta,
         string mACFcuentadep,
         string mACFcomprobante,
         string mACFnotaingreso,
         string mACFfechanotaingreso,
         string mACFordencompra,
         string mACFfechaordencompra,
         string mACFobservacion,
         string mLIFNR,
         string mBLART,
         string mAMBid,
         string mCMPid,
         string mUBEid)
        {
            DAcfMVAt_MovimientoActivo Obj = new DAcfMVAt_MovimientoActivo();
            Obj.MVAid = mMVAid;
            Obj.ACFid = mACFid;
            Obj.ACFactivo = mACFactivo;
            Obj.BUKRS = mBUKRS;
            Obj.SEGMENT = mSEGMENT;
            Obj.KOSTL = mKOSTL;
            Obj.ANLKL = mANLKL;
            Obj.PERNR = mPERNR;
            Obj.CSTid = mCSTid;
            Obj.TMVid = mTMVid;
            Obj.MVMid = mMVMid;
            Obj.ACFfmovimiento = mACFfmovimiento;
            Obj.VNRid = mVNRid;
            Obj.ACFfincorporacion = mACFfincorporacion;
            Obj.ACFfcapitalizacion = mACFfcapitalizacion;
            Obj.ACFvutiltribanio = mACFvutiltribanio;
            Obj.ACFvutiltribdia = mACFvutiltribdia;
            Obj.ACFvalortrib = mACFvalortrib;
            Obj.ACFfactortrib = mACFfactortrib;
            Obj.ACFdepacutrib = mACFdepacutrib;
            Obj.ACFvutilniifanio = mACFvutilniifanio;
            Obj.ACFvutilniifdia = mACFvutilniifdia;
            Obj.ACFvalorniif = mACFvalorniif;
            Obj.ACFfactorniif = mACFfactorniif;
            Obj.ACFdepacuniif = mACFdepacuniif;
            Obj.ACFobra = mACFobra;
            Obj.ACFord41 = mACFord41;
            Obj.ACFord42 = mACFord42;
            Obj.ACFord43 = mACFord43;
            Obj.ACFord44 = mACFord44;
            Obj.ACFanlue = mACFanlue;
            Obj.ACFcuenta = mACFcuenta;
            Obj.ACFcuentadep = mACFcuentadep;
            Obj.ACFcomprobante = mACFcomprobante;
            Obj.ACFnotaingreso = mACFnotaingreso;
            Obj.ACFfechanotaingreso = mACFfechanotaingreso;
            Obj.ACFordencompra = mACFordencompra;
            Obj.ACFfechaordencompra = mACFfechaordencompra;
            Obj.ACFobservacion = mACFobservacion;
            Obj.LIFNR = mLIFNR;
            Obj.BLART = mBLART;
            Obj.AMBid = mAMBid;
            Obj.CMPid = mCMPid;
            Obj.UBEid = mUBEid;
            return Obj.Insertar(Obj);
        }
        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
        string mMVAid,
         string mACFid,
         string mACFactivo,
         string mBUKRS,
         string mSEGMENT,
         string mKOSTL,
         string mANLKL,
         string mPERNR,
         string mCSTid,
         string mTMVid,
         string mMVMid,
         string mACFfmovimiento,
         string mVNRid,
         string mACFfincorporacion,
         string mACFfcapitalizacion,
         string mACFvutiltribanio,
         string mACFvutiltribdia,
         string mACFvalortrib,
         string mACFfactortrib,
         string mACFdepacutrib,
         string mACFvutilniifanio,
         string mACFvutilniifdia,
         string mACFvalorniif,
         string mACFfactorniif,
         string mACFdepacuniif,
         string mACFobra,
         string mACFord41,
         string mACFord42,
         string mACFord43,
         string mACFord44,
         string mACFanlue,
         string mACFcuenta,
         string mACFcuentadep,
         string mACFcomprobante,
         string mACFnotaingreso,
         string mACFfechanotaingreso,
         string mACFordencompra,
         string mACFfechaordencompra,
         string mACFobservacion,
         string mLIFNR,
         string mBLART,
         string mAMBid,
         string mCMPid,
         string mUBEid)
        {
            DAcfMVAt_MovimientoActivo Obj = new DAcfMVAt_MovimientoActivo();
            Obj.MVAid = mMVAid;
            Obj.ACFid = mACFid;
            Obj.ACFactivo = mACFactivo;
            Obj.BUKRS = mBUKRS;
            Obj.SEGMENT = mSEGMENT;
            Obj.KOSTL = mKOSTL;
            Obj.ANLKL = mANLKL;
            Obj.PERNR = mPERNR;
            Obj.CSTid = mCSTid;
            Obj.TMVid = mTMVid;
            Obj.MVMid = mMVMid;
            Obj.ACFfmovimiento = mACFfmovimiento;
            Obj.VNRid = mVNRid;
            Obj.ACFfincorporacion = mACFfincorporacion;
            Obj.ACFfcapitalizacion = mACFfcapitalizacion;
            Obj.ACFvutiltribanio = mACFvutiltribanio;
            Obj.ACFvutiltribdia = mACFvutiltribdia;
            Obj.ACFvalortrib = mACFvalortrib;
            Obj.ACFfactortrib = mACFfactortrib;
            Obj.ACFdepacutrib = mACFdepacutrib;
            Obj.ACFvutilniifanio = mACFvutilniifanio;
            Obj.ACFvutilniifdia = mACFvutilniifdia;
            Obj.ACFvalorniif = mACFvalorniif;
            Obj.ACFfactorniif = mACFfactorniif;
            Obj.ACFdepacuniif = mACFdepacuniif;
            Obj.ACFobra = mACFobra;
            Obj.ACFord41 = mACFord41;
            Obj.ACFord42 = mACFord42;
            Obj.ACFord43 = mACFord43;
            Obj.ACFord44 = mACFord44;
            Obj.ACFanlue = mACFanlue;
            Obj.ACFcuenta = mACFcuenta;
            Obj.ACFcuentadep = mACFcuentadep;
            Obj.ACFcomprobante = mACFcomprobante;
            Obj.ACFnotaingreso = mACFnotaingreso;
            Obj.ACFfechanotaingreso = mACFfechanotaingreso;
            Obj.ACFordencompra = mACFordencompra;
            Obj.ACFfechaordencompra = mACFfechaordencompra;
            Obj.ACFobservacion = mACFobservacion;
            Obj.LIFNR = mLIFNR;
            Obj.BLART = mBLART;
            Obj.AMBid = mAMBid;
            Obj.CMPid = mCMPid;
            Obj.UBEid = mUBEid;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string iMVAid, string iACFid)
        {
            DAcfMVAt_MovimientoActivo Obj = new DAcfMVAt_MovimientoActivo();
            Obj.MVAid = iMVAid;
            Obj.ACFid = iACFid;
            return Obj.Eliminar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar(String iMVAid)
        {
            return new DAcfMVAt_MovimientoActivo().Mostrar(iMVAid);
        }
        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string iMVAid, string iACFid)
        {
            DAcfMVAt_MovimientoActivo Obj = new DAcfMVAt_MovimientoActivo();
            Obj.MVAid = iMVAid;
            Obj.ACFid = iACFid;
            return Obj.Buscar(Obj);
        }
    }
}
