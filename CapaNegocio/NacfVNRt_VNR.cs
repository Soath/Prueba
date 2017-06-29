using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;



namespace CapaNegocio
{
    public class NacfVNRt_VNR
    {

        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(string mVNRid, string mVNRvnr, string mVNRcuenta, string mVNRcuentadep)
        {
            DAcfVNRt_VNR Obj = new DAcfVNRt_VNR();
            Obj.VNRid = mVNRid;
            Obj.VNRvnr = mVNRvnr;
            Obj.VNRcuenta = mVNRcuenta;
            Obj.VNRcuentadep = mVNRcuentadep;

            return Obj.Insertar(Obj);
        }
        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(string mVNRid, string mVNRvnr, string mVNRcuenta, string mVNRcuentadep)
        {
            DAcfVNRt_VNR Obj = new DAcfVNRt_VNR();
            Obj.VNRid = mVNRid;
            Obj.VNRvnr = mVNRvnr;
            Obj.VNRcuenta = mVNRcuenta;
            Obj.VNRcuentadep = mVNRcuentadep;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string mVNRid)
        {
            DAcfVNRt_VNR Obj = new DAcfVNRt_VNR();
            Obj.VNRid = mVNRid;
            return Obj.Eliminar(Obj);
        }

        // SAPIMPORT para el VRN
        public static string SAPIMPORT(string mVNRid)
        {
            DAcfVNRt_VNR Obj = new DAcfVNRt_VNR();
            Obj.VNRid = mVNRid;
            return Obj.SAPIMPORT(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DAcfVNRt_VNR().Mostrar();
        }
        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string iVNRid)
        {
            DAcfVNRt_VNR Obj = new DAcfVNRt_VNR();
            Obj.VNRid = iVNRid;
            return Obj.Buscar(Obj);
        }
    }
}
