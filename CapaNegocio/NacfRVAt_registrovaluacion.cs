using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfRVAt_registrovaluacion
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
            string sRVAcodigo,
            string sRVAperiodo,
            string sRVAfecha,
            string sRVAresponsable,
            string sRVRestado)
        {
            DacfRVAt_registrovaluacion Obj = new DacfRVAt_registrovaluacion();
            Obj.RVAcodigo = sRVAcodigo;
            Obj.RVAperiodo = sRVAperiodo;
            Obj.RVAfecha = sRVAfecha;
            Obj.RVAresponsable = sRVAresponsable;
            Obj.RVRestado = sRVRestado;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
            string sRVAcodigo,
            string sRVAperiodo,
            string sRVAfecha,
            string sRVAresponsable,
            string sRVRestado)
        {
            DacfRVAt_registrovaluacion Obj = new DacfRVAt_registrovaluacion();
            Obj.RVAcodigo = sRVAcodigo;
            Obj.RVAperiodo = sRVAperiodo;
            Obj.RVAfecha = sRVAfecha;
            Obj.RVAresponsable = sRVAresponsable;
            Obj.RVRestado = sRVRestado;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string iRVAcodigo)
        {
            DacfRVAt_registrovaluacion Obj = new DacfRVAt_registrovaluacion();
            Obj.RVAcodigo = iRVAcodigo;
            return Obj.Eliminar(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()//(string sRVAcodigo)
        {
            return new DacfRVAt_registrovaluacion().Mostrar();
        }


        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string sRVAresponsable)
        {
            DacfRVAt_registrovaluacion Obj = new DacfRVAt_registrovaluacion();
            Obj.RVAresponsable = sRVAresponsable;
            return Obj.Buscar(Obj);
        }
        // barra de navegacion
        public static DataTable Top()
        {
            return new DacfRVAt_registrovaluacion().Top();
        }
        public static DataTable Last()
        {
            return new DacfRVAt_registrovaluacion().Last();
        }
        public static DataTable Next(String RVAcodigo)
        {
            return new DacfRVAt_registrovaluacion().Next(RVAcodigo);
        }

        public static DataTable Prev(String RVAcodigo)
        {
            return new DacfRVAt_registrovaluacion().Prev(RVAcodigo);
        }
    }
}
