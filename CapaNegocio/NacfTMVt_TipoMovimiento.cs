using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class NacfTMVt_TipoMovimiento
    {

        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(string mTVMid, string mTVMtipomovimiento)
        {
            DAcfTMVt_TipoMovimiento Obj = new DAcfTMVt_TipoMovimiento();
            Obj.TVMid = mTVMid;
            Obj.TVMtipomovimiento = mTVMtipomovimiento;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(string mTVMid, string mTVMtipomovimiento)
        {
            DAcfTMVt_TipoMovimiento Obj = new DAcfTMVt_TipoMovimiento();
            Obj.TVMid = mTVMid;
            Obj.TVMtipomovimiento = mTVMtipomovimiento;
            return Obj.Editar(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string mTVMid)
        {
            DAcfTMVt_TipoMovimiento Obj = new DAcfTMVt_TipoMovimiento();
            Obj.TVMid = mTVMid;
            return Obj.Eliminar(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DAcfTMVt_TipoMovimiento().Mostrar();
        }

        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string iTVMid)
        {
            DAcfTMVt_TipoMovimiento Obj = new DAcfTMVt_TipoMovimiento();
            Obj.TVMid = iTVMid;
            return Obj.Buscar(Obj);
        }
    }
}
