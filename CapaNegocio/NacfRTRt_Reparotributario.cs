using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfRTRt_Reparotributario
    {

        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(string mRTRperiodo,string mRTRfecha, string mRTRresponsable, string mRTRestado, string mRTRcodigo)
        {
            DAcfRTRt_Reparotributario Obj = new DAcfRTRt_Reparotributario();
            Obj.RTRperiodo = mRTRperiodo;
            Obj.RTRfecha = mRTRfecha;
            Obj.RTRresponsable = mRTRresponsable;
            Obj.RTRestado = mRTRestado;
            Obj.RTRcodigo = mRTRcodigo;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(string mRTRperiodo, string mRTRfecha, string mRTRresponsable, string mRTRestado, string mRTRcodigo)
        {
            DAcfRTRt_Reparotributario Obj = new DAcfRTRt_Reparotributario();
            Obj.RTRperiodo = mRTRperiodo;
            Obj.RTRfecha = mRTRfecha;
            Obj.RTRresponsable = mRTRresponsable;
            Obj.RTRestado = mRTRestado;
            Obj.RTRcodigo = mRTRcodigo;
            return Obj.Editar(Obj);
        }


        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string mRTRcodigo)
        {
            DAcfRTRt_Reparotributario Obj = new DAcfRTRt_Reparotributario();
            Obj.RTRcodigo = mRTRcodigo;
            return Obj.Eliminar(Obj);
        }

        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DAcfRTRt_Reparotributario().Mostrar();
        }

        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string iRTRcodigo)
        {
            DAcfRTRt_Reparotributario Obj = new DAcfRTRt_Reparotributario();
            Obj.RTRcodigo = iRTRcodigo;
            return Obj.Buscar(Obj);
        }
    }
}
