using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfESTt_Estado
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
            string iESTid,
            string sESTestado)
        {
            DacfESTt_Estado Obj = new DacfESTt_Estado();
            Obj.ESTid = iESTid;
            Obj.ESTestado = sESTestado;            
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
            string iESTid,
            string sESTestado)
        {
            DacfESTt_Estado Obj = new DacfESTt_Estado();
            Obj.ESTid = iESTid;
            Obj.ESTestado = sESTestado; 
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string iESTid)
        {
            DacfESTt_Estado Obj = new DacfESTt_Estado();
            Obj.ESTid = iESTid;
            return Obj.Eliminar(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DacfESTt_Estado().Mostrar();
        }


        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string sESTestado)
        {
            DacfESTt_Estado Obj = new DacfESTt_Estado();
            Obj.ESTestado = sESTestado;
            return Obj.Buscar(Obj);
        }

    }
}
