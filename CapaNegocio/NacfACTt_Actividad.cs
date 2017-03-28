using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfACTt_Actividad
    {

        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(string mACTid, string mACTactividad)
        {
            DAcfACTt_Actividad Obj = new DAcfACTt_Actividad();
            Obj.ACTid = mACTid;
            Obj.ACTactividad = mACTactividad;
            return Obj.Insertar(Obj);
        }
        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(string mACTid, string mACTactividad)
        {
            DAcfACTt_Actividad Obj = new DAcfACTt_Actividad();
            Obj.ACTid = mACTid;
            Obj.ACTactividad = mACTactividad;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string mACTid)
        {
            DAcfACTt_Actividad Obj = new DAcfACTt_Actividad();
            Obj.ACTid = mACTid;
            return Obj.Eliminar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DAcfACTt_Actividad().Mostrar();
        }
        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string iACTid)
        {
            DAcfACTt_Actividad Obj = new DAcfACTt_Actividad();
            Obj.ACTid = iACTid;
            return Obj.Buscar(Obj);
        }

    }
}
