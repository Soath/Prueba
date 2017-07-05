using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NbdiCAFpClaseDeActivoFijo
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
            string sANLKL,
            string sTXK50)
        {
            DbdiCAFpClaseDeActivoFijo Obj = new DbdiCAFpClaseDeActivoFijo();
            Obj.ANLKL = sANLKL;
            Obj.TXK50 = sTXK50;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
            string sANLKL,
            string sTXK50)
        {
            DbdiCAFpClaseDeActivoFijo Obj = new DbdiCAFpClaseDeActivoFijo();
            Obj.ANLKL = sANLKL;
            Obj.TXK50 = sTXK50;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string sANLKL)
        {
            DbdiCAFpClaseDeActivoFijo Obj = new DbdiCAFpClaseDeActivoFijo();
            Obj.ANLKL = sANLKL;
            return Obj.Eliminar(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DbdiCAFpClaseDeActivoFijo().Mostrar();
        }


        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string sANLKL)
        {
            DbdiCAFpClaseDeActivoFijo Obj = new DbdiCAFpClaseDeActivoFijo();
            Obj.ANLKL = sANLKL;
            return Obj.Buscar(Obj);
        }

    }
}
