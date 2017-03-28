using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfSPNt_Supranumero
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
            string sV_T087U_ANLUE,
            string sV_T087U_ANLUE_TXT)
        {
            DacfSPNt_Supranumero Obj = new DacfSPNt_Supranumero();
            Obj.V_T087U_ANLUE = sV_T087U_ANLUE;
            Obj.V_T087U_ANLUE_TXT = sV_T087U_ANLUE_TXT;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
            string sV_T087U_ANLUE,
            string sV_T087U_ANLUE_TXT)
        {
            DacfSPNt_Supranumero Obj = new DacfSPNt_Supranumero();
            Obj.V_T087U_ANLUE = sV_T087U_ANLUE;
            Obj.V_T087U_ANLUE_TXT = sV_T087U_ANLUE_TXT;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string sV_T087U_ANLUE)
        {
            DacfSPNt_Supranumero Obj = new DacfSPNt_Supranumero();
            Obj.V_T087U_ANLUE = sV_T087U_ANLUE;
            return Obj.Eliminar(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DacfSPNt_Supranumero().Mostrar();
        }


        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string sV_T087U_ANLUE_TXT)
        {
            DacfSPNt_Supranumero Obj = new DacfSPNt_Supranumero();
            Obj.V_T087U_ANLUE_TXT = sV_T087U_ANLUE_TXT;
            return Obj.Buscar(Obj);
        }

    }
}
