using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfUBEt_UbicacionElectrica
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
            string iUBEcodigogis,
            string sUBEobra,
            string sKOSTL,
            string sVNRid,
            string sSELid,
            string iUBEset,
            string sUBEsetetq,
            string iUBEalimentador,
            string sUBEalimentadoretq,
            string iUBEsed,
            string sUBEsedetq,
            string iUBEcircuito,
            string sUBEcircuitoetq,
            string iUBEpuntoi,
            string sUBEpuntoietq,
            string iUBEpuntof,
            string sUBEpuntofetq,
            string iUBEid,
            string iACFid)
        {
            DacfUBEt_UbicacionElectrica Obj = new DacfUBEt_UbicacionElectrica();
            Obj.UBEcodigogis = iUBEcodigogis;
            Obj.UBEobra = sUBEobra;
            Obj.KOSTL = sKOSTL;
            Obj.VNRid = sVNRid;
            Obj.SELid = sSELid;
            Obj.UBEset = iUBEset;
            Obj.UBEsetetq = sUBEsetetq;
            Obj.UBEalimentador = iUBEalimentador;
            Obj.UBEalimentadoretq = sUBEalimentadoretq;
            Obj.UBEsed = iUBEsed;
            Obj.UBEsedetq = sUBEsedetq;
            Obj.UBEcircuito = iUBEcircuito;
            Obj.UBEcircuitoetq = sUBEcircuitoetq;
            Obj.UBEpuntoi = iUBEpuntoi;
            Obj.UBEpuntoietq = sUBEpuntoietq;
            Obj.UBEpuntof = iUBEpuntof;
            Obj.UBEpuntofetq = sUBEpuntofetq;
            Obj.UBEid = iUBEid;
            Obj.ACFid = iACFid;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
            string iUBEcodigogis,
            string sUBEobra,
            string sKOSTL,
            string sVNRid,
            string sSELid,
            string iUBEset,
            string sUBEsetetq,
            string iUBEalimentador,
            string sUBEalimentadoretq,
            string iUBEsed,
            string sUBEsedetq,
            string iUBEcircuito,
            string sUBEcircuitoetq,
            string iUBEpuntoi,
            string sUBEpuntoietq,
            string iUBEpuntof,
            string sUBEpuntofetq,
            string iUBEid,
            string iACFid)
        {
            DacfUBEt_UbicacionElectrica Obj = new DacfUBEt_UbicacionElectrica();
            Obj.UBEcodigogis = iUBEcodigogis;
            Obj.UBEobra = sUBEobra;
            Obj.KOSTL = sKOSTL;
            Obj.VNRid = sVNRid;
            Obj.SELid = sSELid;
            Obj.UBEset = iUBEset;
            Obj.UBEsetetq = sUBEsetetq;
            Obj.UBEalimentador = iUBEalimentador;
            Obj.UBEalimentadoretq = sUBEalimentadoretq;
            Obj.UBEsed = iUBEsed;
            Obj.UBEsedetq = sUBEsedetq;
            Obj.UBEcircuito = iUBEcircuito;
            Obj.UBEcircuitoetq = sUBEcircuitoetq;
            Obj.UBEpuntoi = iUBEpuntoi;
            Obj.UBEpuntoietq = sUBEpuntoietq;
            Obj.UBEpuntof = iUBEpuntof;
            Obj.UBEpuntofetq = sUBEpuntofetq;
            Obj.UBEid = iUBEid;
            Obj.ACFid = iACFid;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string iUBEcodigogis)
        {
            DacfUBEt_UbicacionElectrica Obj = new DacfUBEt_UbicacionElectrica();
            Obj.UBEcodigogis = iUBEcodigogis;
            return Obj.Eliminar(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DacfUBEt_UbicacionElectrica().Mostrar();
        }


        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string sACFid)
        {
            return new DacfUBEt_UbicacionElectrica().Buscar(sACFid);
        }

    }
}

