using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfMATt_Material
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
            string iMATid,
            string sMATmaterial,
            string sMATabreviado)
            
        {
            DacfMATt_Material Obj = new DacfMATt_Material();
            Obj.MATid = iMATid;
            Obj.MATmaterial = sMATmaterial;
            Obj.MATabreviado = sMATabreviado;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
            string iMATid,
            string sMATmaterial,
            string sMATabreviado)
        {
            DacfMATt_Material Obj = new DacfMATt_Material();
            Obj.MATid = iMATid;
            Obj.MATmaterial = sMATmaterial;
            Obj.MATabreviado = sMATabreviado;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string iMATid)
        {
            DacfMATt_Material Obj = new DacfMATt_Material();
            Obj.MATid = iMATid;
            return Obj.Eliminar(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DacfMATt_Material().Mostrar();
        }


        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string sMATmaterial)
        {
            DacfMATt_Material Obj = new DacfMATt_Material();
            Obj.MATmaterial = sMATmaterial;
            return Obj.Buscar(Obj);
        }

    }
}
