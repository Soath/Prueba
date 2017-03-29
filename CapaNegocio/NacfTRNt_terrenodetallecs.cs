using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class NacfTRNt_terrenodetallecs
    {

         public static string Insertar(
          string mCRSnombrepredio,
          string mCRScentropoblado,
          string mCRSdepartamento,
          string mCRSinterior,
          string mCRScarretera,
          string mCRSkilometro,
          string mACFArea,
          string mACFvalor,
          string mACFtc,
          string mACFvalorSoles            ,
          string mACFValorDolar            ,
          string mACFValorAnt0             ,
          string mACFVutilniff             ,
          string mACFNetopcga              ,
          string mACFvalorATri             ,
          string mACFid                    ,
          string mACFdiferencia            ,
          string mACFDifTemDedu            ,
          string mACFDifTemGrav            ,
          string mACFTasaIR                ,
          string mACFSaldoDeducible        ,
          string mACFSaldoGravable         ,
          string mRVAcodigo)
        {
            DAcfTRNt_terrenodetalle Obj = new DAcfTRNt_terrenodetalle();
            Obj.CRSnombrepredio = mCRSnombrepredio;
            Obj.CRScentropoblado = mCRScentropoblado;
            Obj.CRSdepartamento = mCRSdepartamento;
            Obj.CRSinterior = mCRSinterior;
            Obj.CRScarretera = mCRScarretera;
            Obj.CRSkilometro = mCRSkilometro;
            Obj.ACFArea = mACFArea;
            Obj.ACFvalor = mACFvalor;
            Obj.ACFtc = mACFtc;
            Obj.ACFvalorSoles = mACFvalorSoles;
            Obj.ACFValorDolar = mACFValorDolar;
            Obj.ACFValorAnt0 = mACFValorAnt0;
            Obj.ACFVutilniff = mACFVutilniff;
            Obj.ACFNetopcga = mACFNetopcga;
            Obj.ACFvalorATri = mACFvalorATri;
            Obj.ACFid = mACFid;
            Obj.ACFdiferencia = mACFdiferencia;
            Obj.ACFDifTemDedu = mACFDifTemDedu;
            Obj.ACFDifTemGrav = mACFDifTemGrav;
            Obj.ACFTasaIR = mACFTasaIR;
            Obj.ACFSaldoDeducible = mACFSaldoDeducible;
            Obj.ACFSaldoGravable = mACFSaldoGravable;
            Obj.RVAcodigo = mRVAcodigo;
            return Obj.Insertar(Obj);
        }

         //------------------------------------------------------------------
         //Metodo Editar que llama al metodo Editar de la clase DPostres
         //de la CapaDatos
         public static string Editar(
           string mCRSnombrepredio,
          string mCRScentropoblado,
          string mCRSdepartamento,
          string mCRSinterior,
          string mCRScarretera,
          string mCRSkilometro,
          string mACFArea,
          string mACFvalor,
          string mACFtc,
          string mACFvalorSoles,
          string mACFValorDolar,
          string mACFValorAnt0,
          string mACFVutilniff,
          string mACFNetopcga,
          string mACFvalorATri,
          string mACFid,
          string mACFdiferencia,
          string mACFDifTemDedu,
          string mACFDifTemGrav,
          string mACFTasaIR,
          string mACFSaldoDeducible,
          string mACFSaldoGravable,
          string mRVAcodigo)
         {
             DAcfTRNt_terrenodetalle Obj = new DAcfTRNt_terrenodetalle();
             Obj.CRSnombrepredio = mCRSnombrepredio;
             Obj.CRScentropoblado = mCRScentropoblado;
             Obj.CRSdepartamento = mCRSdepartamento;
             Obj.CRSinterior = mCRSinterior;
             Obj.CRScarretera = mCRScarretera;
             Obj.CRSkilometro = mCRSkilometro;
             Obj.ACFArea = mACFArea;
             Obj.ACFvalor = mACFvalor;
             Obj.ACFtc = mACFtc;
             Obj.ACFvalorSoles = mACFvalorSoles;
             Obj.ACFValorDolar = mACFValorDolar;
             Obj.ACFValorAnt0 = mACFValorAnt0;
             Obj.ACFVutilniff = mACFVutilniff;
             Obj.ACFNetopcga = mACFNetopcga;
             Obj.ACFvalorATri = mACFvalorATri;
             Obj.ACFid = mACFid;
             Obj.ACFdiferencia = mACFdiferencia;
             Obj.ACFDifTemDedu = mACFDifTemDedu;
             Obj.ACFDifTemGrav = mACFDifTemGrav;
             Obj.ACFTasaIR = mACFTasaIR;
             Obj.ACFSaldoDeducible = mACFSaldoDeducible;
             Obj.ACFSaldoGravable = mACFSaldoGravable;
             Obj.RVAcodigo = mRVAcodigo;
             return Obj.Editar(Obj);
         }
         //------------------------------------------------------------------
         //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
         //de la CapaDatos
         public static string Eliminar(string sRVAcodigo)
         {
             DAcfTRNt_terrenodetalle Obj = new DAcfTRNt_terrenodetalle();
             Obj.RVAcodigo = sRVAcodigo;
             return Obj.Eliminar(Obj);
         }
         //------------------------------------------------------------------
         //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
         //de la CapaDatos
         public static DataTable Mostrar()
         {
             return new DAcfTRNt_terrenodetalle().Mostrar();
         }
         //------------------------------------------------------------------
         //M�todo Buscar que llama al m�todo BuscarNombre
         //de la clase DPostresa de la CapaDatos

         public static DataTable Buscar(string sRVAcodigo)
         {
             DAcfTRNt_terrenodetalle Obj = new DAcfTRNt_terrenodetalle();
             Obj.RVAcodigo = sRVAcodigo;
             return Obj.Buscar(Obj);
         }

    }
}
