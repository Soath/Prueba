using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfINBt_Inventariobienes
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
         string mINVid,
         string mACFid,
         string mACFactivo,
         string mBUKRS,
         string mSEGMENT,
         string mKOSTL,
         string mANLKL,
         string mPERNR,
         string mACTid,
         string mCSTid,
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
         string mLIFNR,
         string mBLART,
         string mACFcomprobante,
         string mACFnotaingreso,
         string mACFfechanotaingreso,
         string mACFordencompra,
         string mACFobservacion,
         string mAMBid,
         string mUBEid,
         string mACFfechacomprobante,
         string mACFfechaordencompra)
        {

            DAcfINBt_Inventariobienes Obj = new DAcfINBt_Inventariobienes();

            Obj.INVid=                            mINVid;
            Obj.ACFid=               mACFid;
            Obj.ACFactivo=           mACFactivo;
            Obj.BUKRS=               mBUKRS;
            Obj.SEGMENT=             mSEGMENT;
            Obj.KOSTL=               mKOSTL;
            Obj.ANLKL=               mANLKL;
            Obj.PERNR=               mPERNR;
            Obj.ACTid=               mACTid;
            Obj.CSTid=               mCSTid;
            Obj.VNRid=               mVNRid;
            Obj.ACFfincorporacion=   mACFfincorporacion;
            Obj.ACFfcapitalizacion=  mACFfcapitalizacion;
            Obj.ACFvutiltribanio=    mACFvutiltribanio;
            Obj.ACFvutiltribdia=     mACFvutiltribdia;
            Obj.ACFvalortrib=        mACFvalortrib;
            Obj.ACFfactortrib=       mACFfactortrib;
            Obj.ACFdepacutrib=       mACFdepacutrib;
            Obj.ACFvutilniifanio=    mACFvutilniifanio;
            Obj.ACFvutilniifdia=     mACFvutilniifdia;
            Obj.ACFvalorniif=        mACFvalorniif;
            Obj.ACFfactorniif=       mACFfactorniif;
            Obj.ACFdepacuniif=       mACFdepacuniif;
            Obj.ACFobra=             mACFobra;
            Obj.ACFord41=            mACFord41;
            Obj.ACFord42=            mACFord42;
            Obj.ACFord43=            mACFord43;
            Obj.ACFord44=            mACFord44;
            Obj.ACFanlue=            mACFanlue;
            Obj.ACFcuenta=           mACFcuenta;
            Obj.ACFcuentadep=        mACFcuentadep;
            Obj.LIFNR=               mLIFNR;
            Obj.BLART=               mBLART;
            Obj.ACFcomprobante=      mACFcomprobante;
            Obj.ACFnotaingreso=      mACFnotaingreso;
            Obj.ACFfechanotaingreso= mACFfechanotaingreso;
            Obj.ACFordencompra=      mACFordencompra;
            Obj.ACFobservacion=      mACFobservacion;
            Obj.AMBid=               mAMBid;
            Obj.UBEid=               mUBEid;
            Obj.ACFfechacomprobante= mACFfechacomprobante;
            Obj.ACFfechaordencompra = mACFfechaordencompra;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
          string mINVid,
         string mACFid,
         string mACFactivo,
         string mBUKRS,
         string mSEGMENT,
         string mKOSTL,
         string mANLKL,
         string mPERNR,
         string mACTid,
         string mCSTid,
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
         string mLIFNR,
         string mBLART,
         string mACFcomprobante,
         string mACFnotaingreso,
         string mACFfechanotaingreso,
         string mACFordencompra,
         string mACFobservacion,
         string mAMBid,
         string mUBEid,
         string mACFfechacomprobante,
         string mACFfechaordencompra)
        {
            DAcfINBt_Inventariobienes Obj = new DAcfINBt_Inventariobienes();
            Obj.INVid = mINVid;
            Obj.ACFid = mACFid;
            Obj.ACFactivo = mACFactivo;
            Obj.BUKRS = mBUKRS;
            Obj.SEGMENT = mSEGMENT;
            Obj.KOSTL = mKOSTL;
            Obj.ANLKL = mANLKL;
            Obj.PERNR = mPERNR;
            Obj.ACTid = mACTid;
            Obj.CSTid = mCSTid;
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
            Obj.LIFNR = mLIFNR;
            Obj.BLART = mBLART;
            Obj.ACFcomprobante = mACFcomprobante;
            Obj.ACFnotaingreso = mACFnotaingreso;
            Obj.ACFfechanotaingreso = mACFfechanotaingreso;
            Obj.ACFordencompra = mACFordencompra;
            Obj.ACFobservacion = mACFobservacion;
            Obj.AMBid = mAMBid;
            Obj.UBEid = mUBEid;
            Obj.ACFfechacomprobante = mACFfechacomprobante;
            Obj.ACFfechaordencompra = mACFfechaordencompra;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string mINVid, string mACFid)
        {
            DAcfINBt_Inventariobienes Obj = new DAcfINBt_Inventariobienes();
            Obj.INVid = mINVid;
            Obj.ACFid = mACFid;
            return Obj.Eliminar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar(String iINVid)
        {
            return new DAcfINBt_Inventariobienes().Mostrar(iINVid);
        }
        public static string Copiar  ()
        {
            DAcfINBt_Inventariobienes Obj = new DAcfINBt_Inventariobienes();
            return Obj.Copiar();
        }
        public static string Copiar2(string KOSTL)
        {
            DAcfINBt_Inventariobienes Obj = new DAcfINBt_Inventariobienes();
            Obj.KOSTL = KOSTL;
            return Obj.Copiar2(Obj);
        }
        //reporte de depreciación
        public static DataTable Depreciacion(String iINVid, String sKOSTL)
        {
            return new DAcfINBt_Inventariobienes().Depreciacion(iINVid,sKOSTL);
        }
        public static DataTable Mostrar2()
        {
            return new DAcfINBt_Inventariobienes().Mostrar2();
        }
        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos
        public static DataTable Buscar(String iACFid)
        {
            return new DAcfINBt_Inventariobienes().Buscar(iACFid);
        }

    }
}

