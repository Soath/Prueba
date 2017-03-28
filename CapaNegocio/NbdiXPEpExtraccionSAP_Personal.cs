using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NbdiXPEpExtraccionSAP_Personal
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
            string sPERNR, 
            string sNachn, 
            string sName2, 
            string sVorna, 
            string sDNI, 
            string sWERKS,
            string sPersg,
            string sKOSTL)              
        {
            DbdiXPEpExtraccionSAP_Personal Obj = new DbdiXPEpExtraccionSAP_Personal();
            Obj.PERNR = sPERNR;
            Obj.Nachn = sNachn;
            Obj.Name2 = sName2;
            Obj.Vorna = sVorna;
            Obj.DNI = sDNI;
            Obj.WERKS = sWERKS;
            Obj.Persg = sPersg;
            Obj.KOSTL = sKOSTL;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
            string sPERNR,
            string sNachn,
            string sName2,
            string sVorna,
            string sDNI,
            string sWERKS,
            string sPersg,
            string sKOSTL)
        {
            DbdiXPEpExtraccionSAP_Personal Obj = new DbdiXPEpExtraccionSAP_Personal();
            Obj.PERNR = sPERNR;
            Obj.Nachn = sNachn;
            Obj.Name2 = sName2;
            Obj.Vorna = sVorna;
            Obj.DNI = sDNI;
            Obj.WERKS = sWERKS;
            Obj.Persg = sPersg;
            Obj.KOSTL = sKOSTL;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string sPERNR)
        {
            DbdiXPEpExtraccionSAP_Personal Obj = new DbdiXPEpExtraccionSAP_Personal();
            Obj.PERNR = sPERNR;
            return Obj.Eliminar(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DbdiXPEpExtraccionSAP_Personal().Mostrar();
        }


        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string sNachn)
        {
            DbdiXPEpExtraccionSAP_Personal Obj = new DbdiXPEpExtraccionSAP_Personal();
            Obj.Nachn = sNachn;
            return Obj.Buscar(Obj);
        }

    }
}
