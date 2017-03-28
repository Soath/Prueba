using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class NacfMARt_Marca
    {

        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(string mMARid, string mMARmarca)
        {
            DAcfMARt_Marca Obj = new DAcfMARt_Marca();
            Obj.MARid = mMARid;
            Obj.MARmarca = mMARmarca;
            return Obj.Insertar(Obj);
        }
        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(string mMARid, string mMARmarca)
        {
            DAcfMARt_Marca Obj = new DAcfMARt_Marca();
            Obj.MARid = mMARid;
            Obj.MARmarca = mMARmarca;
            return Obj.Editar(Obj);
        }


        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string mMARid)
        {
            DAcfMARt_Marca Obj = new DAcfMARt_Marca();
            Obj.MARid = mMARid;
            return Obj.Eliminar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DAcfMARt_Marca().Mostrar();
        }
        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string iMARid)
        {
            DAcfMARt_Marca Obj = new DAcfMARt_Marca();
            Obj.MARid = iMARid;
            return Obj.Buscar(Obj);
        }
    }
}
