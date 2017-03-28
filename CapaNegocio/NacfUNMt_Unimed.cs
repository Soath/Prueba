using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfUNMt_Unimed
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
            string iUNMid,
            string sUNMunidad,
            string sUNMdetalle)
        {
            DacfUNMt_Unimed Obj = new DacfUNMt_Unimed();
            Obj.UNMid = iUNMid;
            Obj.UNMunidad = sUNMunidad;
            Obj.UNMdetalle = sUNMdetalle;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
            string iUNMid,
            string sUNMunidad,
            string sUNMdetalle)
        {
            DacfUNMt_Unimed Obj = new DacfUNMt_Unimed();
            Obj.UNMid = iUNMid;
            Obj.UNMunidad = sUNMunidad;
            Obj.UNMdetalle = sUNMdetalle;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string sUNMunidad)
        {
            DacfUNMt_Unimed Obj = new DacfUNMt_Unimed();
            Obj.UNMunidad = sUNMunidad;
            return Obj.Eliminar(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DacfUNMt_Unimed().Mostrar();
        }


        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string sUNMunidad)
        {
            DacfUNMt_Unimed Obj = new DacfUNMt_Unimed();
            Obj.UNMunidad = sUNMunidad;
            return Obj.Buscar(Obj);
        }

    }
}

