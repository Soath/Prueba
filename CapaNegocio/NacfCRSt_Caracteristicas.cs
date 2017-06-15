﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfCRSt_Caracteristicas
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
         string iACFid,
         string iMARid,
         string iESTid,
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
            DacfCRSt_Caracteristicas Obj = new DacfCRSt_Caracteristicas();
            Obj.ACFid = iACFid;
            Obj.MARid = iMARid;
            Obj.ESTid = iESTid;
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

        // Metodo Insertar Excel a DB_Caracteristicas
        public static string SAPIMPORT(
         string iACFid,
         string iMARid,
         string iESTid,
         string sCRSserie,
         string sCRSmodelo,
         string sCRScolor,
         string iMATid,
         string sCRStipo,
         string iUNMid,
         string decCRScantidad,
         string sCRSvehplaca,
         string sCRSvehexpediente,
         //string dtCRSvehinscripcion,
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
         //string dtCRSfinscpredio,
         string sCRSficharegistral,
         string decCRSareaconstruida,
         string decCRSperimetro,
         string sCRSusopredio,
         string decCRSvalorautovaluo,
         string sCRScodigoluz,
         string sCRScodigoagua,
         //string dtCRSfadqpredio,
         string sCRSobservacion)
        {
            DacfCRSt_Caracteristicas Obj = new DacfCRSt_Caracteristicas();
            Obj.ACFid = iACFid;
            Obj.MARid = iMARid;
            Obj.ESTid = iESTid;
            Obj.CRSserie = sCRSserie;
            Obj.CRSmodelo = sCRSmodelo;
            Obj.CRScolor = sCRScolor;
            Obj.MATid = iMATid;
            Obj.CRStipo = sCRStipo;
            Obj.UNMid = iUNMid;
            Obj.CRScantidad = decCRScantidad;
            Obj.CRSvehplaca = sCRSvehplaca;
            Obj.CRSvehexpediente = sCRSvehexpediente;
            //Obj.CRSvehinscripcion = dtCRSvehinscripcion;
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
            //Obj.CRSfinscpredio = dtCRSfinscpredio;
            Obj.CRSficharegistral = sCRSficharegistral;
            Obj.CRSareaconstruida = decCRSareaconstruida;
            Obj.CRSperimetro = decCRSperimetro;
            Obj.CRSusopredio = sCRSusopredio;
            Obj.CRSvalorautovaluo = decCRSvalorautovaluo;
            Obj.CRScodigoluz = sCRScodigoluz;
            Obj.CRScodigoagua = sCRScodigoagua;
            //Obj.CRSfadqpredio = dtCRSfadqpredio;
            Obj.CRSobservacion = sCRSobservacion;
            return Obj.SAPIMPORT(Obj);
        }
        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
         string iACFid,
         string iMARid,
         string iESTid,
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
         string sCRSobservacion
            )
        {
            DacfCRSt_Caracteristicas Obj = new DacfCRSt_Caracteristicas();
            Obj.ACFid = iACFid;
            Obj.MARid = iMARid;
            Obj.ESTid = iESTid;
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
        //Metodo EditarSustitucionMejora que llama al metodo Editar
        //de la CapaDatos
        public static string EditarSustitucionMejora(
         string iACFid,
         string iMARid,
         string sCRSserie,
         string sCRSmodelo,
         string sCRScolor,
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
         string sCRSobservacion)
        {
            DacfCRSt_Caracteristicas Obj = new DacfCRSt_Caracteristicas();
            Obj.ACFid = iACFid;
            Obj.MARid = iMARid;
            Obj.CRSserie = sCRSserie;
            Obj.CRSmodelo = sCRSmodelo;
            Obj.CRScolor = sCRScolor;
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
            Obj.CRSobservacion = sCRSobservacion;
            return Obj.EditarSustitucionMejora(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string iACFid)
        {
            DacfCRSt_Caracteristicas Obj = new DacfCRSt_Caracteristicas();
            Obj.ACFid = iACFid;
            return Obj.Eliminar(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DacfCRSt_Caracteristicas().Mostrar();
        }
        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase 
        //de la CapaDatos
        public static DataTable MostrarSustitucionMejora(string iACFid)
        {
            return new DacfCRSt_Caracteristicas().MostrarSustitucionMejora(iACFid);
        }


        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string sCRSserie)
        {
            return new DacfCRSt_Caracteristicas().Buscar(sCRSserie);
        }

    }
}
