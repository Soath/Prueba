using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    class NacfEDIt_edificaciondetalle
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
            string iACFid,
            string sEDIzona,
            string sEDIdescripicion,
            string decEDIfactorasignado,
            string decACFValorIR,
            string decACFTC,
            string decACFCRC,
            string decACFDEPCRC,
            string decACFNETOCRC,
            string decACFvalorniif,
            string decACFdepacuniif,
            string decACFNETOPCGA,
            string decACFDIFCosto,
            string decACFINCCosto,
            string decACFDISCosto,
            string decACFDIFDEP,
            string decACFINCDep,
            string decACFDISDep,
            string decACFDIFNeta,
            string decACFSumDifDed,
            string decACFSumDifGra,
            string decACFSumACTDif,
            string decACFSumPasDif,
            string sACFid,            
            string sLOClocal,
            string sRVAcodigo)
        {
            DacfEDIt_edificaciondetalle Obj = new DacfEDIt_edificaciondetalle();
            Obj.ACFid = iACFid;
            Obj.EDIzona = sEDIzona;
            Obj.EDIdescripicion = sEDIdescripicion;
            Obj.EDIfactorasignado = decEDIfactorasignado;
            Obj.ACFValorIR = decACFValorIR;
            Obj.ACFTC = decACFTC;
            Obj.ACFCRC = decACFCRC;
            Obj.ACFDEPCRC = decACFDEPCRC;
            Obj.ACFNETOCRC = decACFNETOCRC;
            Obj.ACFvalorniif = decACFvalorniif;
            Obj.ACFdepacuniif = decACFdepacuniif;
            Obj.ACFNETOPCGA = decACFNETOPCGA;
            Obj.ACFDIFCosto = decACFDIFCosto;
            Obj.ACFINCCosto = decACFINCCosto;
            Obj.ACFDISCosto = decACFDISCosto;
            Obj.ACFDIFDEP = decACFDIFDEP;
            Obj.ACFINCDep = decACFINCDep;
            Obj.ACFDISDep = decACFDISDep;
            Obj.ACFDIFNeta = decACFDIFNeta;
            Obj.ACFSumDifDed = decACFSumDifDed;
            Obj.ACFSumDifGra = decACFSumDifGra;
            Obj.ACFSumACTDif = decACFSumACTDif;
            Obj.ACFSumPasDif = decACFSumPasDif;
            Obj.ACFid = sACFid;
            Obj.LOClocal = sLOClocal;
            Obj.RVAcodigo = sRVAcodigo;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
            string iACFid,
            string sEDIzona,
            string sEDIdescripicion,
            string decEDIfactorasignado,
            string decACFValorIR,
            string decACFTC,
            string decACFCRC,
            string decACFDEPCRC,
            string decACFNETOCRC,
            string decACFvalorniif,
            string decACFdepacuniif,
            string decACFNETOPCGA,
            string decACFDIFCosto,
            string decACFINCCosto,
            string decACFDISCosto,
            string decACFDIFDEP,
            string decACFINCDep,
            string decACFDISDep,
            string decACFDIFNeta,
            string decACFSumDifDed,
            string decACFSumDifGra,
            string decACFSumACTDif,
            string decACFSumPasDif,
            string sACFid,
            string sLOClocal,
            string sRVAcodigo)
        {
            DacfEDIt_edificaciondetalle Obj = new DacfEDIt_edificaciondetalle();
            Obj.ACFid = iACFid;
            Obj.EDIzona = sEDIzona;
            Obj.EDIdescripicion = sEDIdescripicion;
            Obj.EDIfactorasignado = decEDIfactorasignado;
            Obj.ACFValorIR = decACFValorIR;
            Obj.ACFTC = decACFTC;
            Obj.ACFCRC = decACFCRC;
            Obj.ACFDEPCRC = decACFDEPCRC;
            Obj.ACFNETOCRC = decACFNETOCRC;
            Obj.ACFvalorniif = decACFvalorniif;
            Obj.ACFdepacuniif = decACFdepacuniif;
            Obj.ACFNETOPCGA = decACFNETOPCGA;
            Obj.ACFDIFCosto = decACFDIFCosto;
            Obj.ACFINCCosto = decACFINCCosto;
            Obj.ACFDISCosto = decACFDISCosto;
            Obj.ACFDIFDEP = decACFDIFDEP;
            Obj.ACFINCDep = decACFINCDep;
            Obj.ACFDISDep = decACFDISDep;
            Obj.ACFDIFNeta = decACFDIFNeta;
            Obj.ACFSumDifDed = decACFSumDifDed;
            Obj.ACFSumDifGra = decACFSumDifGra;
            Obj.ACFSumACTDif = decACFSumACTDif;
            Obj.ACFSumPasDif = decACFSumPasDif;
            Obj.ACFid = sACFid;
            Obj.LOClocal = sLOClocal;
            Obj.RVAcodigo = sRVAcodigo;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string iACFid)
        {
            DacfEDIt_edificaciondetalle Obj = new DacfEDIt_edificaciondetalle();
            Obj.ACFid = iACFid;
            return Obj.Eliminar(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DacfEDIt_edificaciondetalle().Mostrar();
        }


        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string sEDIzona)
        {
            DacfEDIt_edificaciondetalle Obj = new DacfEDIt_edificaciondetalle();
            Obj.EDIzona = sEDIzona;
            return Obj.Buscar(Obj);
        }

    }
}
