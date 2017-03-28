using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NNacfLOCt_Local
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
            string iLOCid,
            string sLOClocal,
            string sLOCdireccion,
            string sSEGMENT)          
        {
            DDacfLOCt_Local Obj = new DDacfLOCt_Local();
            Obj.LOCid = iLOCid;
            Obj.LOClocal = sLOClocal;
            Obj.LOCdireccion = sLOCdireccion;
            Obj.SEGMENT = sSEGMENT;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
            string iLOCid,
            string sLOClocal,
            string sLOCdireccion,
            string sSEGMENT)
        {
            DDacfLOCt_Local Obj = new DDacfLOCt_Local();
            Obj.LOCid = iLOCid;
            Obj.LOClocal = sLOClocal;
            Obj.LOCdireccion = sLOCdireccion;
            Obj.SEGMENT = sSEGMENT;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string iLOCid)
        {
            DDacfLOCt_Local Obj = new DDacfLOCt_Local();
            Obj.LOCid = iLOCid;
            return Obj.Eliminar(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DDacfLOCt_Local().Mostrar();
        }


        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string sLOClocal)
        {
            DDacfLOCt_Local Obj = new DDacfLOCt_Local();
            Obj.LOClocal = sLOClocal;
            return Obj.Buscar(Obj);
        }

    }
}
