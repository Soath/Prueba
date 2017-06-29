using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class NbdiXCCpExtraccionSAP_CentroCosto
    {

        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(string mKOSTL, string mKTEXT, string mKLTXT, string mMCDS3)
        {
            DBdiXCCpExtraccionSAP_CentroCosto Obj = new DBdiXCCpExtraccionSAP_CentroCosto();
            Obj.KOSTL = mKOSTL;
            Obj.KTEXT = mKTEXT;
            Obj.KLTXT = mKLTXT;
            Obj.MCDS3 = mMCDS3;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(string mKOSTL, string mKTEXT, string mKLTXT, string mMCDS3)
        {
            DBdiXCCpExtraccionSAP_CentroCosto Obj = new DBdiXCCpExtraccionSAP_CentroCosto();
            Obj.KOSTL = mKOSTL;
            Obj.KTEXT = mKTEXT;
            Obj.KLTXT = mKLTXT;
            Obj.MCDS3 = mMCDS3;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string mKOSTL)
        {
            DBdiXCCpExtraccionSAP_CentroCosto Obj = new DBdiXCCpExtraccionSAP_CentroCosto();
            Obj.KOSTL = mKOSTL;
            return Obj.Eliminar(Obj);
        }

        //MEtodo importar Excel del SAP
        public static string SAPIMPORT(string mKOSTL)
        {
            DBdiXCCpExtraccionSAP_CentroCosto Obj = new DBdiXCCpExtraccionSAP_CentroCosto();
            Obj.KOSTL = mKOSTL;
            return Obj.SAPIMPORT(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DBdiXCCpExtraccionSAP_CentroCosto().Mostrar();
        }

        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string iKOSTL)
        {
            DBdiXCCpExtraccionSAP_CentroCosto Obj = new DBdiXCCpExtraccionSAP_CentroCosto();
            Obj.KOSTL = iKOSTL;
            return Obj.Buscar(Obj);
        }
    }
}
