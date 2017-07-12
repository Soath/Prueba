using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfICRt_Inventariocaracteristicas
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
         string iACFid,
         string iMARid,
         string iESTid,
         string iINVid,
         string sCRSserie,
         string sCRSmodelo,
         string sCRScolor,
         string iMATid,
         string sCRStipo,
         string iUNMid,
         string decCRScantidad,
         string sCRSvehplaca,
         string sCRSvehexpediente,
         string dtCRSvehinscripcion,
         string sCRSvehclase,
         string sCRSvehcombustible,
         string iCRSvehejes,
         string iCRSvehpasajeros,
         string iCRSvehasientos,
         string decCRSvehpesoseco,
         string decCRSvehcargautil,
         string decCRSaltura,
         string decCRSancho,
         string sCRSvelocidad,
         string sCRSresolucion,
         string sCRScapacidad,
         string sCRSpotencia,
         string sCRSvnominal,
         string sCRSventrada,
         string sCRSvsalida,
         string sCRSfrecuencia,
         string sCRStemperatura,
         string sCRSprocesador,
         string sCRSpuertos,
         string decCRSutmx,
         string decCRSutmy,
         string sCRSesfuerzopunta,
         string sCRScajaderivadora,
         string sCRSalquilacable,
         string sCRScentropoblado,
         string sCRSurbanizacion,
         string sCRScalle,
         string sCRSlote,
         string sCRSnumeropredio,
         string sCRSdepartamento,
         string sCRSinterior,
         string sCRScarretera,
         string decCRSkilometro,
         string sCRSnombrepredio,
         string iCRSpisospredio,
         string sCRSpartidapredio,
         string sCRStomopredio,
         string sCRSfolioinipredio,
         string sCRSfoliofinpredio,
         string sCRSasientopredio,
         string dtCRSfinscpredio,
         string sCRSficharegistral,
         string decCRSareaconstruida,
         string decCRSperimetro,
         string sCRSusopredio,
         string decCRSvalorautovaluo,
         string sCRScodigoluz,
         string sCRScodigoagua,
         string dtCRSfadqpredio,
         string sCRSobservacion)
        {
            DacfICRt_Inventariocaracteristicas Obj = new DacfICRt_Inventariocaracteristicas();
            Obj.ACFid = iACFid;
            Obj.MARid = iMARid;
            Obj.ESTid = iESTid;
            Obj.INVid = iINVid;
            Obj.CRSserie = sCRSserie;
            Obj.CRSmodelo = sCRSmodelo;
            Obj.CRScolor = sCRScolor;
            Obj.MATid = iMATid;
            Obj.CRStipo = sCRStipo;
            Obj.UNMid = iUNMid;
            Obj.CRScantidad = decCRScantidad;
            Obj.CRSvehplaca = sCRSvehplaca;
            Obj.CRSvehexpediente = sCRSvehexpediente;
            Obj.CRSvehinscripcion = dtCRSvehinscripcion;
            Obj.CRSvehclase = sCRSvehclase;
            Obj.CRSvehcombustible = sCRSvehcombustible;
            Obj.CRSvehejes = iCRSvehejes;
            Obj.CRSvehpasajeros = iCRSvehpasajeros;
            Obj.CRSvehasientos = iCRSvehasientos;
            Obj.CRSvehpesoseco = decCRSvehpesoseco;
            Obj.CRSvehcargautil = decCRSvehcargautil;
            Obj.CRSaltura = decCRSaltura;
            Obj.CRSancho = decCRSancho;
            Obj.CRSvelocidad = sCRSvelocidad;
            Obj.CRSresolucion = sCRSresolucion;
            Obj.CRScapacidad = sCRScapacidad;
            Obj.CRSpotencia = sCRSpotencia;
            Obj.CRSvnominal = sCRSvnominal;
            Obj.CRSventrada = sCRSventrada;
            Obj.CRSvsalida = sCRSvsalida;
            Obj.CRSfrecuencia = sCRSfrecuencia;
            Obj.CRStemperatura = sCRStemperatura;
            Obj.CRSprocesador = sCRSprocesador;
            Obj.CRSpuertos = sCRSpuertos;
            Obj.CRSutmx = decCRSutmx;
            Obj.CRSutmy = decCRSutmy;
            Obj.CRSesfuerzopunta = sCRSesfuerzopunta;
            Obj.CRScajaderivadora = sCRScajaderivadora;
            Obj.CRSalquilacable = sCRSalquilacable;
            Obj.CRScentropoblado = sCRScentropoblado;
            Obj.CRSurbanizacion = sCRSurbanizacion;
            Obj.CRScalle = sCRScalle;
            Obj.CRSlote = sCRSlote;
            Obj.CRSnumeropredio = sCRSnumeropredio;
            Obj.CRSdepartamento = sCRSdepartamento;
            Obj.CRSinterior = sCRSinterior;
            Obj.CRScarretera = sCRScarretera;
            Obj.CRSkilometro = decCRSkilometro;
            Obj.CRSnombrepredio = sCRSnombrepredio;
            Obj.CRSpisospredio = iCRSpisospredio;
            Obj.CRSpartidapredio = sCRSpartidapredio;
            Obj.CRStomopredio = sCRStomopredio;
            Obj.CRSfolioinipredio = sCRSfolioinipredio;
            Obj.CRSfoliofinpredio = sCRSfoliofinpredio;
            Obj.CRSasientopredio = sCRSasientopredio;
            Obj.CRSfinscpredio = dtCRSfinscpredio;
            Obj.CRSficharegistral = sCRSficharegistral;
            Obj.CRSareaconstruida = decCRSareaconstruida;
            Obj.CRSperimetro = decCRSperimetro;
            Obj.CRSusopredio = sCRSusopredio;
            Obj.CRSvalorautovaluo = decCRSvalorautovaluo;
            Obj.CRScodigoluz = sCRScodigoluz;
            Obj.CRScodigoagua = sCRScodigoagua;
            Obj.CRSfadqpredio = dtCRSfadqpredio;
            Obj.CRSobservacion = sCRSobservacion;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
         string iACFid,
         string iMARid,
         string iESTid,
         string iINVid,
         string sCRSserie,
         string sCRSmodelo,
         string sCRScolor,
         string iMATid,
         string sCRStipo,
         string iUNMid,
         string decCRScantidad,
         string sCRSvehplaca,
         string sCRSvehexpediente,
         string dtCRSvehinscripcion,
         string sCRSvehclase,
         string sCRSvehcombustible,
         string iCRSvehejes,
         string iCRSvehpasajeros,
         string iCRSvehasientos,
         string decCRSvehpesoseco,
         string decCRSvehcargautil,
         string decCRSaltura,
         string decCRSancho,
         string sCRSvelocidad,
         string sCRSresolucion,
         string sCRScapacidad,
         string sCRSpotencia,
         string sCRSvnominal,
         string sCRSventrada,
         string sCRSvsalida,
         string sCRSfrecuencia,
         string sCRStemperatura,
         string sCRSprocesador,
         string sCRSpuertos,
         string decCRSutmx,
         string decCRSutmy,
         string sCRSesfuerzopunta,
         string sCRScajaderivadora,
         string sCRSalquilacable,
         string sCRScentropoblado,
         string sCRSurbanizacion,
         string sCRScalle,
         string sCRSlote,
         string sCRSnumeropredio,
         string sCRSdepartamento,
         string sCRSinterior,
         string sCRScarretera,
         string decCRSkilometro,
         string sCRSnombrepredio,
         string iCRSpisospredio,
         string sCRSpartidapredio,
         string sCRStomopredio,
         string sCRSfolioinipredio,
         string sCRSfoliofinpredio,
         string sCRSasientopredio,
         string dtCRSfinscpredio,
         string sCRSficharegistral,
         string decCRSareaconstruida,
         string decCRSperimetro,
         string sCRSusopredio,
         string decCRSvalorautovaluo,
         string sCRScodigoluz,
         string sCRScodigoagua,
         string dtCRSfadqpredio,
         string sCRSobservacion)
        {
            DacfICRt_Inventariocaracteristicas Obj = new DacfICRt_Inventariocaracteristicas();
            Obj.ACFid = iACFid;
            Obj.MARid = iMARid;
            Obj.ESTid = iESTid;
            Obj.INVid = iINVid;
            Obj.CRSserie = sCRSserie;
            Obj.CRSmodelo = sCRSmodelo;
            Obj.CRScolor = sCRScolor;
            Obj.MATid = iMATid;
            Obj.CRStipo = sCRStipo;
            Obj.UNMid = iUNMid;
            Obj.CRScantidad = decCRScantidad;
            Obj.CRSvehplaca = sCRSvehplaca;
            Obj.CRSvehexpediente = sCRSvehexpediente;
            Obj.CRSvehinscripcion = dtCRSvehinscripcion;
            Obj.CRSvehclase = sCRSvehclase;
            Obj.CRSvehcombustible = sCRSvehcombustible;
            Obj.CRSvehejes = iCRSvehejes;
            Obj.CRSvehpasajeros = iCRSvehpasajeros;
            Obj.CRSvehasientos = iCRSvehasientos;
            Obj.CRSvehpesoseco = decCRSvehpesoseco;
            Obj.CRSvehcargautil = decCRSvehcargautil;
            Obj.CRSaltura = decCRSaltura;
            Obj.CRSancho = decCRSancho;
            Obj.CRSvelocidad = sCRSvelocidad;
            Obj.CRSresolucion = sCRSresolucion;
            Obj.CRScapacidad = sCRScapacidad;
            Obj.CRSpotencia = sCRSpotencia;
            Obj.CRSvnominal = sCRSvnominal;
            Obj.CRSventrada = sCRSventrada;
            Obj.CRSvsalida = sCRSvsalida;
            Obj.CRSfrecuencia = sCRSfrecuencia;
            Obj.CRStemperatura = sCRStemperatura;
            Obj.CRSprocesador = sCRSprocesador;
            Obj.CRSpuertos = sCRSpuertos;
            Obj.CRSutmx = decCRSutmx;
            Obj.CRSutmy = decCRSutmy;
            Obj.CRSesfuerzopunta = sCRSesfuerzopunta;
            Obj.CRScajaderivadora = sCRScajaderivadora;
            Obj.CRSalquilacable = sCRSalquilacable;
            Obj.CRScentropoblado = sCRScentropoblado;
            Obj.CRSurbanizacion = sCRSurbanizacion;
            Obj.CRScalle = sCRScalle;
            Obj.CRSlote = sCRSlote;
            Obj.CRSnumeropredio = sCRSnumeropredio;
            Obj.CRSdepartamento = sCRSdepartamento;
            Obj.CRSinterior = sCRSinterior;
            Obj.CRScarretera = sCRScarretera;
            Obj.CRSkilometro = decCRSkilometro;
            Obj.CRSnombrepredio = sCRSnombrepredio;
            Obj.CRSpisospredio = iCRSpisospredio;
            Obj.CRSpartidapredio = sCRSpartidapredio;
            Obj.CRStomopredio = sCRStomopredio;
            Obj.CRSfolioinipredio = sCRSfolioinipredio;
            Obj.CRSfoliofinpredio = sCRSfoliofinpredio;
            Obj.CRSasientopredio = sCRSasientopredio;
            Obj.CRSfinscpredio = dtCRSfinscpredio;
            Obj.CRSficharegistral = sCRSficharegistral;
            Obj.CRSareaconstruida = decCRSareaconstruida;
            Obj.CRSperimetro = decCRSperimetro;
            Obj.CRSusopredio = sCRSusopredio;
            Obj.CRSvalorautovaluo = decCRSvalorautovaluo;
            Obj.CRScodigoluz = sCRScodigoluz;
            Obj.CRScodigoagua = sCRScodigoagua;
            Obj.CRSfadqpredio = dtCRSfadqpredio;
            Obj.CRSobservacion = sCRSobservacion;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string iACFid)
        {
            DacfICRt_Inventariocaracteristicas Obj = new DacfICRt_Inventariocaracteristicas();
            Obj.ACFid = iACFid;
            return Obj.Eliminar(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DacfICRt_Inventariocaracteristicas().Mostrar();
        }

        public static string Copiar()
        {
            DacfICRt_Inventariocaracteristicas Obj = new DacfICRt_Inventariocaracteristicas();
            return Obj.Copiar();
        }
        public static string Copiar4()
        {
            DacfICRt_Inventariocaracteristicas Obj = new DacfICRt_Inventariocaracteristicas();
            return Obj.Copiar4();
        }
        public static string Copiar2()
        {
            DacfICRt_Inventariocaracteristicas Obj = new DacfICRt_Inventariocaracteristicas();
            return Obj.Copiar2();
        }
        public static string Copiar3(string KOSTL)
        {
            return new DacfICRt_Inventariocaracteristicas().Copiar3(KOSTL);
        }
        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(String iACFid)
        {
            return new DacfICRt_Inventariocaracteristicas().Buscar(iACFid);
        }


        public static string Editar2(
        string iACFid,
        string iMARid,
        string sCRSserie)
        {
            DacfICRt_Inventariocaracteristicas Obj = new DacfICRt_Inventariocaracteristicas();
            Obj.ACFid = iACFid;
            Obj.MARid = iMARid;
            Obj.CRSserie = sCRSserie;

            return Obj.Editar2(Obj);
        }

        public static string CerrarInventario(
        //string iINVid,
        string iACFid,        
        string sCRSserie)
        {
            DacfICRt_Inventariocaracteristicas Obj = new DacfICRt_Inventariocaracteristicas();
            //Obj.ACFid = iINVid;
            Obj.ACFid = iACFid;
            Obj.CRSserie = sCRSserie;

            return Obj.CerrarInventario(Obj);
        }
    }
}
