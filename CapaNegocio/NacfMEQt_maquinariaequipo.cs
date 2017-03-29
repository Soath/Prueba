using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class NacfMEQt_maquinariaequipo
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
         string mMEQvnrtot,
         string mMEQcantidad,
         string mMEQaccffecinc,
         string mMEQabreviatura,
         string mMEQopiniontecnica,
         string mMEQctacontable,
         string mMEQniif,
         string mMEQvrident,
         string mMEQprovdes,
         string mMEQcostorepcor,
         string mMEQfactorinst,
         string mMEQvalorresi,
         string mMEQedadact,
         string mMEQdeptas,
         string mMEQvalorref,
         string mMEQvalref2,
         string mMEQvsm,
         string mMEQestado,
         string mMEQvidautil,
         string mMEQvidautmax,
         string mMEQedadtec,
         string mMEQdepreciacion,
         string mMEQdep2012,
         string mMEQcostocorr,
         string mMEQvaloractivo,
         string mMEQdepre,
         string mMEQtasair,
         string mMEQimpdife,
         string mMEQdifneta,
         string mMEQvalorneto,
         string mMEQvalact,
         string mMEQcostotcorr,
         string mMEQdepacuniif,
         string mMEQcrcnet,
         string mMEQvalnet,
         string mMEQdiferenneta,
         string mMEQvalornetolib,
         string mMEQdepacumtrib,
         string mMEQcostohistorico,
         string mRVAcodigo
          )
        {

            DAcfMEQt_maquinariaequipo Obj = new DAcfMEQt_maquinariaequipo();

            Obj.MEQvnrtot = mMEQvnrtot;
            Obj.MEQcantidad = mMEQcantidad;
            Obj.MEQaccffecinc = mMEQaccffecinc;
            Obj.MEQabreviatura = mMEQabreviatura;
            Obj.MEQopiniontecnica = mMEQopiniontecnica;
            Obj.MEQctacontable = mMEQctacontable;
            Obj.MEQniif = mMEQniif;
            Obj.MEQvrident = mMEQvrident;
            Obj.MEQprovdes = mMEQprovdes;
            Obj.MEQcostorepcor = mMEQcostorepcor;
            Obj.MEQfactorinst = mMEQfactorinst;
            Obj.MEQvalorresi = mMEQvalorresi;
            Obj.MEQedadact = mMEQedadact;
            Obj.MEQdeptas = mMEQdeptas;
            Obj.MEQvalorref = mMEQvalorref;
            Obj.MEQvalref2 = mMEQvalref2;
            Obj.MEQvsm = mMEQvsm;
            Obj.MEQestado = mMEQestado;
            Obj.MEQvidautil = mMEQvidautil;
            Obj.MEQvidautmax = mMEQvidautmax;
            Obj.MEQedadtec = mMEQedadtec;
            Obj.MEQdepreciacion = mMEQdepreciacion;
            Obj.MEQdep2012 = mMEQdep2012;
            Obj.MEQcostocorr = mMEQcostocorr;
            Obj.MEQvaloractivo = mMEQvaloractivo;
            Obj.MEQdepre = mMEQdepre;
            Obj.MEQtasair = mMEQtasair;
            Obj.MEQimpdife = mMEQimpdife;
            Obj.MEQdifneta = mMEQdifneta;
            Obj.MEQvalorneto = mMEQvalorneto;
            Obj.MEQvalact = mMEQvalact;
            Obj.MEQcostotcorr = mMEQcostotcorr;
            Obj.MEQdepacuniif = mMEQdepacuniif;
            Obj.MEQcrcnet = mMEQcrcnet;
            Obj.MEQvalnet = mMEQvalnet;
            Obj.MEQdiferenneta = mMEQdiferenneta;
            Obj.MEQvalornetolib = mMEQvalornetolib;
            Obj.MEQdepacumtrib = mMEQdepacumtrib;
            Obj.MEQcostohistorico = mMEQcostohistorico;
            Obj.RVAcodigo = mRVAcodigo;
            return Obj.Insertar(Obj);
        }
        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
           string mMEQvnrtot,
         string mMEQcantidad,
         string mMEQaccffecinc,
         string mMEQabreviatura,
         string mMEQopiniontecnica,
         string mMEQctacontable,
         string mMEQniif,
         string mMEQvrident,
         string mMEQprovdes,
         string mMEQcostorepcor,
         string mMEQfactorinst,
         string mMEQvalorresi,
         string mMEQedadact,
         string mMEQdeptas,
         string mMEQvalorref,
         string mMEQvalref2,
         string mMEQvsm,
         string mMEQestado,
         string mMEQvidautil,
         string mMEQvidautmax,
         string mMEQedadtec,
         string mMEQdepreciacion,
         string mMEQdep2012,
         string mMEQcostocorr,
         string mMEQvaloractivo,
         string mMEQdepre,
         string mMEQtasair,
         string mMEQimpdife,
         string mMEQdifneta,
         string mMEQvalorneto,
         string mMEQvalact,
         string mMEQcostotcorr,
         string mMEQdepacuniif,
         string mMEQcrcnet,
         string mMEQvalnet,
         string mMEQdiferenneta,
         string mMEQvalornetolib,
         string mMEQdepacumtrib,
         string mMEQcostohistorico,
         string mRVAcodigo)
        {
            DAcfMEQt_maquinariaequipo Obj = new DAcfMEQt_maquinariaequipo();

            Obj.MEQvnrtot = mMEQvnrtot;
            Obj.MEQcantidad = mMEQcantidad;
            Obj.MEQaccffecinc = mMEQaccffecinc;
            Obj.MEQabreviatura = mMEQabreviatura;
            Obj.MEQopiniontecnica = mMEQopiniontecnica;
            Obj.MEQctacontable = mMEQctacontable;
            Obj.MEQniif = mMEQniif;
            Obj.MEQvrident = mMEQvrident;
            Obj.MEQprovdes = mMEQprovdes;
            Obj.MEQcostorepcor = mMEQcostorepcor;
            Obj.MEQfactorinst = mMEQfactorinst;
            Obj.MEQvalorresi = mMEQvalorresi;
            Obj.MEQedadact = mMEQedadact;
            Obj.MEQdeptas = mMEQdeptas;
            Obj.MEQvalorref = mMEQvalorref;
            Obj.MEQvalref2 = mMEQvalref2;
            Obj.MEQvsm = mMEQvsm;
            Obj.MEQestado = mMEQestado;
            Obj.MEQvidautil = mMEQvidautil;
            Obj.MEQvidautmax = mMEQvidautmax;
            Obj.MEQedadtec = mMEQedadtec;
            Obj.MEQdepreciacion = mMEQdepreciacion;
            Obj.MEQdep2012 = mMEQdep2012;
            Obj.MEQcostocorr = mMEQcostocorr;
            Obj.MEQvaloractivo = mMEQvaloractivo;
            Obj.MEQdepre = mMEQdepre;
            Obj.MEQtasair = mMEQtasair;
            Obj.MEQimpdife = mMEQimpdife;
            Obj.MEQdifneta = mMEQdifneta;
            Obj.MEQvalorneto = mMEQvalorneto;
            Obj.MEQvalact = mMEQvalact;
            Obj.MEQcostotcorr = mMEQcostotcorr;
            Obj.MEQdepacuniif = mMEQdepacuniif;
            Obj.MEQcrcnet = mMEQcrcnet;
            Obj.MEQvalnet = mMEQvalnet;
            Obj.MEQdiferenneta = mMEQdiferenneta;
            Obj.MEQvalornetolib = mMEQvalornetolib;
            Obj.MEQdepacumtrib = mMEQdepacumtrib;
            Obj.MEQcostohistorico = mMEQcostohistorico;
            Obj.RVAcodigo = mRVAcodigo;
            return Obj.Editar(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string mRVAcodigo)
        {
            DAcfMEQt_maquinariaequipo Obj = new DAcfMEQt_maquinariaequipo();
            Obj.RVAcodigo = mRVAcodigo;
            return Obj.Eliminar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DAcfMEQt_maquinariaequipo().Mostrar();
        }

        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string mRVAcodigo)
        {
            DAcfMEQt_maquinariaequipo Obj = new DAcfMEQt_maquinariaequipo();
            Obj.RVAcodigo = mRVAcodigo;
            return Obj.Buscar(Obj);
        }
    }
}
