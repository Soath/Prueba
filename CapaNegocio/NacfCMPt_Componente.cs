using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfCMPt_Componente
    {

        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(string mCMPid, string mCMPcomponente, string mCMPusoestimado, string mCMPconservacion, string mCMPobsolecencia, string mCMPlimitelegal, string mCMPtotalfactores, string mCMPfactorusoestimado, string mCMPvutilanio, string mCMPvutildia)
        {
            DAcfCMPt_Componente Obj = new DAcfCMPt_Componente();
            Obj.CMPid = mCMPid;
            Obj.CMPcomponente = mCMPcomponente;
            Obj.CMPusoestimado = mCMPusoestimado;
            Obj.CMPconservacion = mCMPconservacion;
            Obj.CMPobsolecencia = mCMPobsolecencia;
            Obj.CMPlimitelegal = mCMPlimitelegal;
            Obj.CMPtotalfactores = mCMPtotalfactores;
            Obj.CMPfactorusoestimado = mCMPfactorusoestimado;
            Obj.CMPvutilanio = mCMPvutilanio;
            Obj.CMPvutildia = mCMPvutildia;
            return Obj.Insertar(Obj);
        }
        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(string mCMPid, string mCMPcomponente, string mCMPusoestimado, string mCMPconservacion, string mCMPobsolecencia, string mCMPlimitelegal, string mCMPtotalfactores, string mCMPfactorusoestimado, string mCMPvutilanio, string mCMPvutildia)
        {
            DAcfCMPt_Componente Obj = new DAcfCMPt_Componente();
            Obj.CMPid = mCMPid;
            Obj.CMPcomponente = mCMPcomponente;
            Obj.CMPusoestimado = mCMPusoestimado;
            Obj.CMPconservacion = mCMPconservacion;
            Obj.CMPobsolecencia = mCMPobsolecencia;
            Obj.CMPlimitelegal = mCMPlimitelegal;
            Obj.CMPtotalfactores = mCMPtotalfactores;
            Obj.CMPfactorusoestimado = mCMPfactorusoestimado;
            Obj.CMPvutilanio = mCMPvutilanio;
            Obj.CMPvutildia = mCMPvutildia;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string mCMPid)
        {
            DAcfCMPt_Componente Obj = new DAcfCMPt_Componente();
            Obj.CMPid = mCMPid;
            return Obj.Eliminar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DAcfCMPt_Componente().Mostrar();
        }
        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string iCMPid)
        {
            DAcfCMPt_Componente Obj = new DAcfCMPt_Componente();
            Obj.CMPid = iCMPid;
            return Obj.Buscar(Obj);
        }
    }
}
