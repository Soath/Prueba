using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using CapaDatos;
using System.Data;



namespace CapaNegocio
{
    public class NbdiCDDpClasesDeDocumento
    {

        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(string mBLART, string mLTEXT, string mDETdoctipo)
        {
            DBdiCDDpClasesDeDocumento Obj = new DBdiCDDpClasesDeDocumento();
            Obj.BLART = mBLART;
            Obj.LTEXT = mLTEXT;
            Obj.DETdoctipo = mDETdoctipo;
            return Obj.Insertar(Obj);
        }
        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(string mBLART, string mLTEXT, string mDETdoctipo)
        {
            DBdiCDDpClasesDeDocumento Obj = new DBdiCDDpClasesDeDocumento();
            Obj.BLART = mBLART;
            Obj.LTEXT = mLTEXT;
            Obj.DETdoctipo = mDETdoctipo;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string mBLART)
        {
            DBdiCDDpClasesDeDocumento Obj = new DBdiCDDpClasesDeDocumento();
            Obj.BLART = mBLART;
            return Obj.Eliminar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DBdiCDDpClasesDeDocumento().Mostrar();
        }
        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string iBLART)
        {
            DBdiCDDpClasesDeDocumento Obj = new DBdiCDDpClasesDeDocumento();
            Obj.BLART = iBLART;
            return Obj.Buscar(Obj);
        }
    }
}
