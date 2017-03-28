using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class NacfSELt_SistemaElectrico
    {

        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(string mSELid, string mSELsistemaelectrico, string mSEGMENT)
        {
            DAcfSELt_SistemaElectrico Obj = new DAcfSELt_SistemaElectrico();
            Obj.SELid = mSELid;
            Obj.SELsistemaelectrico = mSELsistemaelectrico;
            Obj.SEGMENT = mSEGMENT;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(string mSELid, string mSELsistemaelectrico, string mSEGMENT)
        {
            DAcfSELt_SistemaElectrico Obj = new DAcfSELt_SistemaElectrico();
            Obj.SELid = mSELid;
            Obj.SELsistemaelectrico = mSELsistemaelectrico;
            Obj.SEGMENT = mSEGMENT;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string mSELid)
        {
            DAcfSELt_SistemaElectrico Obj = new DAcfSELt_SistemaElectrico();
            Obj.SELid = mSELid;
            return Obj.Eliminar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DAcfSELt_SistemaElectrico().Mostrar();
        }

        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string iSELid)
        {
            DAcfSELt_SistemaElectrico Obj = new DAcfSELt_SistemaElectrico();
            Obj.SELid = iSELid;
            return Obj.Buscar(Obj);
        }

    }
}
