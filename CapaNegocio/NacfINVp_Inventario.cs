using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class NacfINVp_Inventario
    {

        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(string mINVid, string mINVdetalle, string mINVinicio, string mINVcierre, string mINVactivo, string mINVrespon, string mINVperiodo)
        {
            DAcfINVp_Inventario Obj = new DAcfINVp_Inventario();
            Obj.INVid = mINVid;
            Obj.INVdetalle = mINVdetalle;
            Obj.INVinicio = mINVinicio;
            Obj.INVcierre = mINVcierre;
            Obj.INVactivo = mINVactivo;
            Obj.INVrespon = mINVrespon;
            Obj.INVperiodo = mINVperiodo;
            return Obj.Insertar(Obj);
        }
        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(string mINVid, string mINVdetalle, string mINVinicio, string mINVcierre, string mINVactivo, string mINVrespon, string mINVperiodo)
        {
            DAcfINVp_Inventario Obj = new DAcfINVp_Inventario();
            Obj.INVid = mINVid;
            Obj.INVdetalle = mINVdetalle;
            Obj.INVinicio = mINVinicio;
            Obj.INVcierre = mINVcierre;
            Obj.INVactivo = mINVactivo;
            Obj.INVrespon = mINVrespon;
            Obj.INVperiodo = mINVperiodo;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string mINVid)
        {
            DAcfINVp_Inventario Obj = new DAcfINVp_Inventario();
            Obj.INVid = mINVid;
            return Obj.Eliminar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DAcfINVp_Inventario().Mostrar();
        }
        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string iINVid)
        {
            DAcfINVp_Inventario Obj = new DAcfINVp_Inventario();
            Obj.INVid = iINVid;
            return Obj.Buscar(Obj);
        }
    }
}
