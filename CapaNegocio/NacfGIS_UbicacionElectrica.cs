using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfGIS_UbicacionElectrica
    {

    //   //M�todo Insertar que llama al m�todo Insertar de la clase 
    //   //de la CapaDatos
    //   public static string Insertar(string mACTid, string mACTactividad)
    //   {
    //       //DacfGIS_UbicacionElectrica Obj = new DacfGIS_UbicacionElectrica();
    //       //Obj.ACTid = mACTid;
    //       //Obj.ACTactividad = mACTactividad;
    //       //return Obj.Insertar(Obj);
    //   }
       //------------------------------------------------------------------
       //Metodo Editar que llama al metodo Editar de la clase 
       //de la CapaDatos
       public static string Editar(
              string iUBEid
            , string mUBEcodigogis
            , string mACFid
            , string mSELid
            , string mUBEset
            , string mUBEsetetq
            , string mUBEalimentador
            , string mUBEalimetiquetadoretq
            , string mUBEsed
            , string mUBEsedetq
            , string mUBcircuito
            , string mUBEcircuitoetq
            , string mUBEtipoPuntoi
            , string mUBEpuntoi
            , string mUBEpuntoietq
            , string mUBEtipoPuntof
            , string mUBEpuntof
            , string mUBEpuntofetq
            , string mUBEobra
            , string mKOSTL
            , string mZona
            , string mVNRid
            , string mCodNiff
            , string mValAct
            , string mFactor
            , string mVidUtilTrib
            , string mVidUtilFinan
            , string mUBEestado
           )
       {
           DacfGIS_UbicacionElectrica Obj = new DacfGIS_UbicacionElectrica();
            Obj.UBEid = iUBEid;
            Obj.UBEcodigogis = mUBEcodigogis;
            Obj.ACFid = mACFid;
            Obj.SELid = mSELid;
            Obj.UBEset = mUBEset;
            Obj.UBEsetetq = mUBEsetetq;
            Obj.UBEalimentador = mUBEalimentador;
            Obj.UBEalimetiquetadoretq = mUBEalimetiquetadoretq;
            Obj.UBEsed = mUBEsed;
            Obj.UBEsedetq = mUBEsedetq;
            Obj.UBcircuito = mUBcircuito;
            Obj.UBEcircuitoetq = mUBEcircuitoetq;
            Obj.UBEtipoPuntoi = mUBEtipoPuntoi;
            Obj.UBEpuntoi = mUBEpuntoi;
            Obj.UBEpuntoietq = mUBEpuntoietq;
            Obj.UBEtipoPuntof = mUBEtipoPuntof;
            Obj.UBEpuntof = mUBEpuntof;
            Obj.UBEpuntofetq = mUBEpuntofetq;
            Obj.UBEobra = mUBEobra;
            Obj.KOSTL = mKOSTL;
            Obj.Zona = mZona;
            Obj.VNRid = mVNRid;
            Obj.CodNiff = mCodNiff;
            Obj.ValAct = mValAct;
            Obj.Factor = mFactor;
            Obj.VidUtilTrib = mVidUtilTrib;
            Obj.VidUtilFinan = mVidUtilFinan;
            Obj.UBEestado = mUBEestado;
            return Obj.Editar(Obj);
       }
    //   //------------------------------------------------------------------
    //   //M�todo Eliminar que llama al m�todo Eliminar de la clase 
    //   //de la CapaDatos
    //   public static string Eliminar(string mACTid)
    //   {
    //       DacfGIS_UbicacionElectrica Obj = new DacfGIS_UbicacionElectrica();
    //       Obj.ACTid = mACTid;
    //       return Obj.Eliminar(Obj);
    //   }
       //------------------------------------------------------------------
       //M�todo Mostrar que llama al m�todo Mostrar de la clase 
       //de la CapaDatos
       public static DataTable Mostrar(string UBEestado)
       {
           return new DacfGIS_UbicacionElectrica().Mostrar(UBEestado);
       }

        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase 
        //de la CapaDatos
        public static DataTable Last()
        {
            return new DacfGIS_UbicacionElectrica().Last();
        }
        //------------------------------------------------------------------
        //   //M�todo Buscar que llama al m�todo BuscarNombre
        //   //de la clase a de la CapaDatos
        //
        //   public static DataTable Buscar(string iACTid)
        //   {
        //       DacfGIS_UbicacionElectrica Obj = new DacfGIS_UbicacionElectrica();
        //       Obj.ACTid = iACTid;
        //       return Obj.Buscar(Obj);
        //   }

    }
}

