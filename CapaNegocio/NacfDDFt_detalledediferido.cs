using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfDDFt_detalledediferido
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
            string sACFcuenta,
            string sINVZU,
            string sTXT50,
            string decACFvalorniif,
            string decACFdepniif,
            string decACFPPENiif,
            string decACFvalortrib,
            string decACFDepTrib,
            string decACFpplir,
            string decACFdeducible,
            string decACFimponible,
            string decACFirda,
            string decACFirdp,
            string decACFculdep,
            string decACFrecper1,
            string decACFrecper2,
            string decACFrecper3,
            string decACFrecper4,
            string decACFtotales,
            string decACFirdaA,
            string decACFirdpA,
            string decACFirdaF,
            string decACFirdpF,
            string iPDFcodigo)
        {
            DacfDDFt_detalledediferido Obj = new DacfDDFt_detalledediferido();
            Obj.ACFcuenta = sACFcuenta;
            Obj.INVZU = sINVZU;
            Obj.TXT50 = sTXT50;
            Obj.ACFvalorniif = decACFvalorniif;
            Obj.ACFdepniif = decACFdepniif;
            Obj.ACFPPENiif = decACFPPENiif;
            Obj.ACFvalortrib = decACFvalortrib;
            Obj.ACFDepTrib = decACFDepTrib;
            Obj.ACFpplir = decACFpplir;
            Obj.ACFdeducible = decACFdeducible;
            Obj.ACFimponible = decACFimponible;
            Obj.ACFirda = decACFirda;
            Obj.ACFirdp = decACFirdp;
            Obj.ACFculdep = decACFculdep;
            Obj.ACFrecper1 = decACFrecper1;
            Obj.ACFrecper2 = decACFrecper2;
            Obj.ACFrecper3 = decACFrecper3;
            Obj.ACFrecper4 = decACFrecper4;
            Obj.ACFtotales = decACFtotales;
            Obj.ACFirdaA = decACFirdaA;
            Obj.ACFirdpA = decACFirdpA;
            Obj.ACFirdaF = decACFirdaF;
            Obj.ACFirdpF = decACFirdpF;
            Obj.PDFcodigo = iPDFcodigo;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
            string sACFcuenta,
            string sINVZU,
            string sTXT50,
            string decACFvalorniif,
            string decACFdepniif,
            string decACFPPENiif,
            string decACFvalortrib,
            string decACFDepTrib,
            string decACFpplir,
            string decACFdeducible,
            string decACFimponible,
            string decACFirda,
            string decACFirdp,
            string decACFculdep,
            string decACFrecper1,
            string decACFrecper2,
            string decACFrecper3,
            string decACFrecper4,
            string decACFtotales,
            string decACFirdaA,
            string decACFirdpA,
            string decACFirdaF,
            string decACFirdpF,
            string iPDFcodigo)
        {
            DacfDDFt_detalledediferido Obj = new DacfDDFt_detalledediferido();
            Obj.ACFcuenta = sACFcuenta;
            Obj.INVZU = sINVZU;
            Obj.TXT50 = sTXT50;
            Obj.ACFvalorniif = decACFvalorniif;
            Obj.ACFdepniif = decACFdepniif;
            Obj.ACFPPENiif = decACFPPENiif;
            Obj.ACFvalortrib = decACFvalortrib;
            Obj.ACFDepTrib = decACFDepTrib;
            Obj.ACFpplir = decACFpplir;
            Obj.ACFdeducible = decACFdeducible;
            Obj.ACFimponible = decACFimponible;
            Obj.ACFirda = decACFirda;
            Obj.ACFirdp = decACFirdp;
            Obj.ACFculdep = decACFculdep;
            Obj.ACFrecper1 = decACFrecper1;
            Obj.ACFrecper2 = decACFrecper2;
            Obj.ACFrecper3 = decACFrecper3;
            Obj.ACFrecper4 = decACFrecper4;
            Obj.ACFtotales = decACFtotales;
            Obj.ACFirdaA = decACFirdaA;
            Obj.ACFirdpA = decACFirdpA;
            Obj.ACFirdaF = decACFirdaF;
            Obj.ACFirdpF = decACFirdpF;
            Obj.PDFcodigo = iPDFcodigo;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string sACFcuenta)
        {
            DacfDDFt_detalledediferido Obj = new DacfDDFt_detalledediferido();
            Obj.ACFcuenta = sACFcuenta;
            return Obj.Eliminar(Obj);
        }
        public static string Copiar(string PDFcodigo)
        {
            DacfDDFt_detalledediferido Obj = new DacfDDFt_detalledediferido();
            Obj.PDFcodigo = PDFcodigo;
            return Obj.Copiar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar(string PDFcodigo)
        {
            return new DacfDDFt_detalledediferido().Mostrar(PDFcodigo);
        }


        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string sINVZU)
        {
            DacfDDFt_detalledediferido Obj = new DacfDDFt_detalledediferido();
            Obj.INVZU = sINVZU;
            return Obj.Buscar(Obj);
        }

    }
}

