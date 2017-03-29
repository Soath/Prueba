using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class NacfDRTt_detallereparotributario
    {
         //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
         //de la CapaDatos
         public static string Insertar(
          string mRTRcodigo,
          string mACFcuenta,
          string mINVZU,
          string mTXT50,
          string mACFfactorniif,
          string mACFvutilniif,
          string mACFfactorTrib,
          string mACFvutiltrib,
          string mACFvalorniif,
          string mACFdepAcuniif,
          string mACFNiifNeto,
          string mACFDepNiifPer,
          string mACFvalortrib,
          string mACFdepacutrib,
          string mACFlirneto,
          string mACFdeptlirper,
          string mACFadiciones,
          string mACFdeducciones,
          string mACFneto)
        {

            DAcfDRTt_detallereparotributario Obj = new DAcfDRTt_detallereparotributario();
            Obj.RTRcodigo = mRTRcodigo;
            Obj.ACFcuenta = mACFcuenta;
            Obj.INVZU = mINVZU;
            Obj.TXT50 = mTXT50;
            Obj.ACFfactorniif = mACFfactorniif;
            Obj.ACFvutilniif = mACFvutilniif;
            Obj.ACFfactorTrib = mACFfactorTrib;
            Obj.ACFvutiltrib = mACFvutiltrib;
            Obj.ACFvalorniif = mACFvalorniif;
            Obj.ACFdepAcuniif = mACFdepAcuniif;
            Obj.ACFNiifNeto = mACFNiifNeto;
            Obj.ACFDepNiifPer = mACFDepNiifPer;
            Obj.ACFvalortrib = mACFvalortrib;
            Obj.ACFdepacutrib = mACFdepacutrib;
            Obj.ACFlirneto = mACFlirneto;
            Obj.ACFdeptlirper = mACFdeptlirper;
            Obj.ACFadiciones = mACFadiciones;
            Obj.ACFdeducciones = mACFdeducciones;
            Obj.ACFneto = mACFneto;
            return Obj.Insertar(Obj);
        
        }

         //------------------------------------------------------------------
         //Metodo Editar que llama al metodo Editar de la clase DPostres
         //de la CapaDatos
         public static string Editar(
         string mRTRcodigo,
          string mACFcuenta,
          string mINVZU,
          string mTXT50,
          string mACFfactorniif,
          string mACFvutilniif,
          string mACFfactorTrib,
          string mACFvutiltrib,
          string mACFvalorniif,
          string mACFdepAcuniif,
          string mACFNiifNeto,
          string mACFDepNiifPer,
          string mACFvalortrib,
          string mACFdepacutrib,
          string mACFlirneto,
          string mACFdeptlirper,
          string mACFadiciones,
          string mACFdeducciones,
          string mACFneto)
         {
             DAcfDRTt_detallereparotributario Obj = new DAcfDRTt_detallereparotributario();
             Obj.RTRcodigo = mRTRcodigo;
             Obj.ACFcuenta = mACFcuenta;
             Obj.INVZU = mINVZU;
             Obj.TXT50 = mTXT50;
             Obj.ACFfactorniif = mACFfactorniif;
             Obj.ACFvutilniif = mACFvutilniif;
             Obj.ACFfactorTrib = mACFfactorTrib;
             Obj.ACFvutiltrib = mACFvutiltrib;
             Obj.ACFvalorniif = mACFvalorniif;
             Obj.ACFdepAcuniif = mACFdepAcuniif;
             Obj.ACFNiifNeto = mACFNiifNeto;
             Obj.ACFDepNiifPer = mACFDepNiifPer;
             Obj.ACFvalortrib = mACFvalortrib;
             Obj.ACFdepacutrib = mACFdepacutrib;
             Obj.ACFlirneto = mACFlirneto;
             Obj.ACFdeptlirper = mACFdeptlirper;
             Obj.ACFadiciones = mACFadiciones;
             Obj.ACFdeducciones = mACFdeducciones;
             Obj.ACFneto = mACFneto;
             return Obj.Editar(Obj);
         }

         //------------------------------------------------------------------
         //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
         //de la CapaDatos
         public static string Eliminar(string mRTRcodigo)
         {
             DAcfDRTt_detallereparotributario Obj = new DAcfDRTt_detallereparotributario();
             Obj.RTRcodigo = mRTRcodigo;
             return Obj.Eliminar(Obj);
         }
         //------------------------------------------------------------------
         //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
         //de la CapaDatos
         public static DataTable Mostrar()
         {
             return new DAcfDRTt_detallereparotributario().Mostrar();
         }

         //------------------------------------------------------------------
         //M�todo Buscar que llama al m�todo BuscarNombre
         //de la clase DPostresa de la CapaDatos

         public static DataTable Buscar(string mRTRcodigo)
         {
             DAcfDRTt_detallereparotributario Obj = new DAcfDRTt_detallereparotributario();
             Obj.RTRcodigo = mRTRcodigo;
             return Obj.Buscar(Obj);
         }
    }
}
