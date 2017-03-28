using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using CapaDatos;
using System.Data;


namespace CapaNegocio
{
   public  class NbdiSEGpSegmento
    {

        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(string mSEGMENT, string mNAME, string mid_zona)
        {
            DBdiSEGpSegmento Obj = new DBdiSEGpSegmento();
            Obj.SEGMENT = mSEGMENT;
            Obj.NAME = mNAME;
            Obj.id_zona = mid_zona;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(string mSEGMENT, string mNAME, string mid_zona)
        {
            DBdiSEGpSegmento Obj = new DBdiSEGpSegmento();
            Obj.SEGMENT = mSEGMENT;
            Obj.NAME = mNAME;
            Obj.id_zona = mid_zona;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string mSEGMENT)
        {
            DBdiSEGpSegmento Obj = new DBdiSEGpSegmento();
            Obj.SEGMENT = mSEGMENT;
            return Obj.Eliminar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DBdiSEGpSegmento().Mostrar();
        }
        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string iSEGMENT)
        {
            DBdiSEGpSegmento Obj = new DBdiSEGpSegmento();
            Obj.SEGMENT = iSEGMENT;
            return Obj.Buscar(Obj);
        }
    }
}
