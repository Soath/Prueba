using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NbdiPRVpProveedor
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
            string sLIFNR, 
            string sName1, 
            string sStras, 
            string sSTCD1)
        {
            DbdiPRVpProveedor Obj = new DbdiPRVpProveedor();
            Obj.LIFNR = sLIFNR;
            Obj.Name1 = sName1;
            Obj.Stras = sStras;
            Obj.STCD1 = sSTCD1;
            return Obj.Insertar(Obj);
        }


        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
            string sLIFNR, 
            string sName1, 
            string sStras, 
            string sSTCD1)
        {
            DbdiPRVpProveedor Obj = new DbdiPRVpProveedor();
            Obj.LIFNR = sLIFNR;
            Obj.Name1 = sName1;
            Obj.Stras = sStras;
            Obj.STCD1 = sSTCD1;
            return Obj.Editar(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string sLIFNR)
        {
            DbdiPRVpProveedor Obj = new DbdiPRVpProveedor();
            Obj.LIFNR = sLIFNR;
            return Obj.Eliminar(Obj);
        }



        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DbdiPRVpProveedor().Mostrar();
        }


        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string iName1)
        {
            DbdiPRVpProveedor Obj = new DbdiPRVpProveedor();
            Obj.Name1 = iName1;
            return Obj.Buscar(Obj);
        }
    }
}
