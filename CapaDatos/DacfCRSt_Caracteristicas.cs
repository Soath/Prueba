using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DacfCRSt_Caracteristicas{

        private string iACFid;
        private string iMARid;
        private string iESTid;
        private string sCRSserie;
        private string sCRSmodelo;
        private string sCRScolor;
        private string iMATid;
        private string sCRStipo;
        private string iUNMid ;
        private string decCRScantidad;
        private string sCRSvehplaca;
        private string sCRSvehexpediente;
        private string dtCRSvehinscripcion;
        private string sCRSvehclase;
        private string sCRSvehcombustible;
        private string iCRSvehejes;
        private string iCRSvehpasajeros;
        private string iCRSvehasientos;
        private string decCRSvehpesoseco;
        private string decCRSvehcargautil;
        private string decCRSaltura;
        private string decCRSancho;
        private string sCRSvelocidad;
        private string sCRSresolucion;
        private string sCRScapacidad;
        private string sCRSpotencia;
        private string sCRSvnominal;
        private string sCRSventrada;
        private string sCRSvsalida;
        private string sCRSfrecuencia;
        private string sCRStemperatura;
        private string sCRSprocesador;
        private string sCRSpuertos;
        private string decCRSutmx;
        private string decCRSutmy;
        private string sCRSesfuerzopunta;
        private string sCRScajaderivadora;
        private string sCRSalquilacable;
        private string sCRScentropoblado;
        private string sCRSurbanizacion;
        private string sCRScalle;
        private string sCRSlote;
        private string sCRSnumeropredio;
        private string sCRSdepartamento;
        private string sCRSinterior;
        private string sCRScarretera;
        private string decCRSkilometro;
        private string sCRSnombrepredio;
        private string iCRSpisospredio;
        private string sCRSpartidapredio;
        private string sCRStomopredio;
        private string sCRSfolioinipredio;
        private string sCRSfoliofinpredio;
        private string sCRSasientopredio;
        private string dtCRSfinscpredio;
        private string sCRSficharegistral;
        private string decCRSareaconstruida;
        private string decCRSperimetro;
        private string sCRSusopredio;
        private string decCRSvalorautovaluo;
        private string sCRScodigoluz;
        private string sCRScodigoagua;
        private string dtCRSfadqpredio;
        private string sCRSobservacion;

        public string ACFid
        {
            get { return iACFid; }
            set { iACFid = value; }
        }
        public string MARid
        {
            get { return iMARid; }
            set { iMARid = value; }
        }
        public string ESTid
        {
            get { return iESTid; }
            set { iESTid = value; }
        }
        public string CRSserie
        {
            get { return sCRSserie; }
            set { sCRSserie = value; }
        }
        public string CRSmodelo
        {
            get { return sCRSmodelo; }
            set { sCRSmodelo = value; }
        }
        public string CRScolor
        {
            get { return sCRScolor; }
            set { sCRScolor = value; }
        }
        public string MATid
        {
            get { return iMATid; }
            set { iMATid = value; }
        }
        public string CRStipo
        {
            get { return sCRStipo; }
            set { sCRStipo = value; }
        }
        public string UNMid
        {
            get { return iUNMid; }
            set { iUNMid = value; }
        }
        public string CRScantidad
        {
            get { return decCRScantidad; }
            set { decCRScantidad = value; }
        }
        public string CRSvehplaca
        {
            get { return sCRSvehplaca; }
            set { sCRSvehplaca = value; }
        }
        public string CRSvehexpediente
        {
            get { return sCRSvehexpediente; }
            set { sCRSvehexpediente = value; }
        }
        public string CRSvehinscripcion
        {
            get { return dtCRSvehinscripcion; }
            set { dtCRSvehinscripcion = value; }
        }
        public string CRSvehclase
        {
            get { return sCRSvehclase; }
            set { sCRSvehclase = value; }
        }
        public string CRSvehcombustible
        {
            get { return sCRSvehcombustible; }
            set { sCRSvehcombustible = value; }
        }
        public string CRSvehejes
        {
            get { return iCRSvehejes; }
            set { iCRSvehejes = value; }
        }
        public string CRSvehpasajeros
        {
            get { return iCRSvehpasajeros; }
            set { iCRSvehpasajeros = value; }
        }
        public string CRSvehasientos
        {
            get { return iCRSvehasientos; }
            set { iCRSvehasientos = value; }
        }
        public string CRSvehpesoseco
        {
            get { return decCRSvehpesoseco; }
            set { decCRSvehpesoseco = value; }
        }
        public string CRSvehcargautil
        {
            get { return decCRSvehcargautil; }
            set { decCRSvehcargautil = value; }
        }
        public string CRSaltura
        {
            get { return decCRSaltura; }
            set { decCRSaltura = value; }
        }
        public string CRSancho
        {
            get { return decCRSancho; }
            set { decCRSancho = value; }
        }
        public string CRSvelocidad
        {
            get { return sCRSvelocidad; }
            set { sCRSvelocidad = value; }
        }
        public string CRSresolucion
        {
            get { return sCRSresolucion; }
            set { sCRSresolucion = value; }
        }
        public string CRScapacidad
        {
            get { return sCRScapacidad; }
            set { sCRScapacidad = value; }
        }
        public string CRSpotencia
        {
            get { return sCRSpotencia; }
            set { sCRSpotencia = value; }
        }
        public string CRSvnominal
        {
            get { return sCRSvnominal; }
            set { sCRSvnominal = value; }
        }
        public string CRSventrada
        {
            get { return sCRSventrada; }
            set { sCRSventrada = value; }
        }
        public string CRSvsalida
        {
            get { return sCRSvsalida; }
            set { sCRSvsalida = value; }
        }
        public string CRSfrecuencia
        {
            get { return sCRSfrecuencia; }
            set { sCRSfrecuencia = value; }
        }
        public string CRStemperatura
        {
            get { return sCRStemperatura; }
            set { sCRStemperatura = value; }
        }
        public string CRSprocesador
        {
            get { return sCRSprocesador; }
            set { sCRSprocesador = value; }
        }
        public string CRSpuertos
        {
            get { return sCRSpuertos; }
            set { sCRSpuertos = value; }
        }
        public string CRSutmx
        {
            get { return decCRSutmx; }
            set { decCRSutmx = value; }
        }
        public string CRSutmy
        {
            get { return decCRSutmy; }
            set { decCRSutmy = value; }
        }
        public string CRSesfuerzopunta
        {
            get { return sCRSesfuerzopunta; }
            set { sCRSesfuerzopunta = value; }
        }
        public string CRScajaderivadora
        {
            get { return sCRScajaderivadora; }
            set { sCRScajaderivadora = value; }
        }
        public string CRSalquilacable
        {
            get { return sCRSalquilacable; }
            set { sCRSalquilacable = value; }
        }
        public string CRScentropoblado
        {
            get { return sCRScentropoblado; }
            set { sCRScentropoblado = value; }
        }
        public string CRSurbanizacion
        {
            get { return sCRSurbanizacion; }
            set { sCRSurbanizacion = value; }
        }
        public string CRScalle
        {
            get { return sCRScalle; }
            set { sCRScalle = value; }
        }
        public string CRSlote
        {
            get { return sCRSlote; }
            set { sCRSlote = value; }
        }
        public string CRSnumeropredio
        {
            get { return sCRSnumeropredio; }
            set { sCRSnumeropredio = value; }
        }
        public string CRSdepartamento
        {
            get { return sCRSdepartamento; }
            set { sCRSdepartamento = value; }
        }
        public string CRSinterior
        {
            get { return sCRSinterior; }
            set { sCRSinterior = value; }
        }
        public string CRScarretera
        {
            get { return sCRScarretera; }
            set { sCRScarretera = value; }
        }
        public string CRSkilometro
        {
            get { return decCRSkilometro; }
            set { decCRSkilometro = value; }
        }
        public string CRSnombrepredio
        {
            get { return sCRSnombrepredio; }
            set { sCRSnombrepredio = value; }
        }
        public string CRSpisospredio
        {
            get { return iCRSpisospredio; }
            set { iCRSpisospredio = value; }
        }
        public string CRSpartidapredio
        {
            get { return sCRSpartidapredio; }
            set { sCRSpartidapredio = value; }
        }
        public string CRStomopredio
        {
            get { return sCRStomopredio; }
            set { sCRStomopredio = value; }
        }
        public string CRSfolioinipredio
        {
            get { return sCRSfolioinipredio; }
            set { sCRSfolioinipredio = value; }
        }
        public string CRSfoliofinpredio
        {
            get { return sCRSfoliofinpredio; }
            set { sCRSfoliofinpredio = value; }
        }
        public string CRSasientopredio
        {
            get { return sCRSasientopredio; }
            set { sCRSasientopredio = value; }
        }
        public string CRSfinscpredio
        {
            get { return dtCRSfinscpredio; }
            set { dtCRSfinscpredio = value; }
        }
        public string CRSficharegistral
        {
            get { return sCRSficharegistral; }
            set { sCRSficharegistral = value; }
        }
        public string CRSareaconstruida
        {
            get { return decCRSareaconstruida; }
            set { decCRSareaconstruida = value; }
        }
        public string CRSperimetro
        {
            get { return decCRSperimetro; }
            set { decCRSperimetro = value; }
        }
        public string CRSusopredio
        {
            get { return sCRSusopredio; }
            set { sCRSusopredio = value; }
        }
        public string CRSvalorautovaluo
        {
            get { return decCRSvalorautovaluo; }
            set { decCRSvalorautovaluo = value; }
        }
        public string CRScodigoluz
        {
            get { return sCRScodigoluz; }
            set { sCRScodigoluz = value; }
        }
        public string CRScodigoagua
        {
            get { return sCRScodigoagua; }
            set { sCRScodigoagua = value; }
        }
        public string CRSfadqpredio
        {
            get { return dtCRSfadqpredio; }
            set { dtCRSfadqpredio = value; }
        }
        public string CRSobservacion
        {
            get { return sCRSobservacion; }
            set { sCRSobservacion = value; }
        }


        //Constructor vacío
	public DacfCRSt_Caracteristicas(){
	}
        //Constructor con parámetros
    public DacfCRSt_Caracteristicas(
                          string ACFid
                        , string MARid
                        , string ESTid
                        , string CRSserie
                        , string CRSmodelo
                        , string CRScolor
                        , string MATid
                        , string CRStipo
                        , string UNMid
                        , string CRScantidad
                        , string CRSvehplaca
                        , string CRSvehexpediente
                        , string CRSvehinscripcion
                        , string CRSvehclase
                        , string CRSvehcombustible
                        , string CRSvehejes
                        , string CRSvehpasajeros
                        , string CRSvehasientos
                        , string CRSvehpesoseco
                        , string CRSvehcargautil
                        , string CRSaltura
                        , string CRSancho
                        , string CRSvelocidad
                        , string CRSresolucion
                        , string CRScapacidad
                        , string CRSpotencia
                        , string CRSvnominal
                        , string CRSventrada
                        , string CRSvsalida
                        , string CRSfrecuencia
                        , string CRStemperatura
                        , string CRSprocesador
                        , string CRSpuertos
                        , string CRSutmx
                        , string CRSutmy
                        , string CRSesfuerzopunta
                        , string CRScajaderivadora
                        , string CRSalquilacable
                        , string CRScentropoblado
                        , string CRSurbanizacion
                        , string CRScalle
                        , string CRSlote
                        , string CRSnumeropredio
                        , string CRSdepartamento
                        , string CRSinterior
                        , string CRScarretera
                        , string CRSkilometro
                        , string CRSnombrepredio
                        , string CRSpisospredio
                        , string CRSpartidapredio
                        , string CRStomopredio
                        , string CRSfolioinipredio
                        , string CRSfoliofinpredio
                        , string CRSasientopredio
                        , string CRSfinscpredio
                        , string CRSficharegistral
                        , string CRSareaconstruida
                        , string CRSperimetro
                        , string CRSusopredio
                        , string CRSvalorautovaluo
                        , string CRScodigoluz
                        , string CRScodigoagua
                        , string CRSfadqpredio
                        , string CRSobservacion
        )         
    {

            this.ACFid = iACFid;
            this.MARid = iMARid;
            this.ESTid = iESTid;
            this.CRSserie = sCRSserie;
            this.CRSmodelo = sCRSmodelo;
            this.CRScolor = sCRScolor;
            this.MATid = iMATid;
            this.CRStipo = sCRStipo;
            this.UNMid = iUNMid;
            this.CRScantidad = decCRScantidad;
            this.CRSvehplaca = sCRSvehplaca;
            this.CRSvehexpediente = sCRSvehexpediente;
            this.CRSvehinscripcion = dtCRSvehinscripcion;
            this.CRSvehclase = sCRSvehclase;
            this.CRSvehcombustible = sCRSvehcombustible;
            this.CRSvehejes = iCRSvehejes;
            this.CRSvehpasajeros = iCRSvehpasajeros;
            this.CRSvehasientos = iCRSvehasientos;
            this.CRSvehpesoseco = decCRSvehpesoseco;
            this.CRSvehcargautil = decCRSvehcargautil;
            this.CRSaltura = decCRSaltura;
            this.CRSancho = decCRSancho;
            this.CRSvelocidad = sCRSvelocidad;
            this.CRSresolucion = sCRSresolucion;
            this.CRScapacidad = sCRScapacidad;
            this.CRSpotencia = sCRSpotencia;
            this.CRSvnominal = sCRSvnominal;
            this.CRSventrada = sCRSventrada;
            this.CRSvsalida = sCRSvsalida;
            this.CRSfrecuencia = sCRSfrecuencia;
            this.CRStemperatura = sCRStemperatura;
            this.CRSprocesador = sCRSprocesador;
            this.CRSpuertos = sCRSpuertos;
            this.CRSutmx = decCRSutmx;
            this.CRSutmy = decCRSutmy;
            this.CRSesfuerzopunta = sCRSesfuerzopunta;
            this.CRScajaderivadora = sCRScajaderivadora;
            this.CRSalquilacable = sCRSalquilacable;
            this.CRScentropoblado = sCRScentropoblado;
            this.CRSurbanizacion = sCRSurbanizacion;
            this.CRScalle = sCRScalle;
            this.CRSlote = sCRSlote;
            this.CRSnumeropredio = sCRSnumeropredio;
            this.CRSdepartamento = sCRSdepartamento;
            this.CRSinterior = sCRSinterior;
            this.CRScarretera = sCRScarretera;
            this.CRSkilometro = decCRSkilometro;
            this.CRSnombrepredio = sCRSnombrepredio;
            this.CRSpisospredio = iCRSpisospredio;
            this.CRSpartidapredio = sCRSpartidapredio;
            this.CRStomopredio = sCRStomopredio;
            this.CRSfolioinipredio = sCRSfolioinipredio;
            this.CRSfoliofinpredio = sCRSfoliofinpredio;
            this.CRSasientopredio = sCRSasientopredio;
            this.CRSfinscpredio = dtCRSfinscpredio;
            this.CRSficharegistral = sCRSficharegistral;
            this.CRSareaconstruida = decCRSareaconstruida;
            this.CRSperimetro = decCRSperimetro;
            this.CRSusopredio = sCRSusopredio;
            this.CRSvalorautovaluo = decCRSvalorautovaluo;
            this.CRScodigoluz = sCRScodigoluz;
            this.CRScodigoagua = sCRScodigoagua;
            this.CRSfadqpredio = dtCRSfadqpredio;
            this.CRSobservacion = sCRSobservacion;

        }

        /*	public object Clone() {
        //		return base.MemberwiseClone();
        //	}
        */

        //METODO MOSTRAR
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("acfCRSt_Caracteristicas");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfCRSt_Caracteristicas";
                SqlCmd.CommandType = CommandType.StoredProcedure;



                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //METODO MostrarSustitucionMejora
        public DataTable MostrarSustitucionMejora(string iACFid)
        {
            DataTable DtResultado = new DataTable("acfCRSt_Caracteristicas");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfCRSt_Caracteristicas_SustitucionMejora";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@iACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Value = iACFid;
                SqlCmd.Parameters.Add(ParACFid);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //METODO INSERTAR 
        public string Insertar(DacfCRSt_Caracteristicas acfCRSt_Caracteristicas)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_I_acfCRSt_Caracteristicas";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@iACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Value = Convert.ToInt32(acfCRSt_Caracteristicas.ACFid);
                SqlCmd.Parameters.Add(ParACFid);
                //
                SqlParameter ParMARid = new SqlParameter();
                ParMARid.ParameterName = "@iMARid";
                ParMARid.SqlDbType = SqlDbType.Int;
                ParMARid.Value = Convert.ToInt32(acfCRSt_Caracteristicas.MARid);
                SqlCmd.Parameters.Add(ParMARid);
                //
                SqlParameter ParESTid = new SqlParameter();
                ParESTid.ParameterName = "@iESTid";
                ParESTid.SqlDbType = SqlDbType.Int;
                ParESTid.Value = Convert.ToInt32(acfCRSt_Caracteristicas.ESTid);
                SqlCmd.Parameters.Add(ParESTid);
                //
                SqlParameter ParCRSserie = new SqlParameter();
                ParCRSserie.ParameterName = "@sCRSserie";
                ParCRSserie.SqlDbType = SqlDbType.VarChar;
                ParCRSserie.Value = acfCRSt_Caracteristicas.CRSserie;
                SqlCmd.Parameters.Add(ParCRSserie);
                //
                SqlParameter ParCRSmodelo = new SqlParameter();
                ParCRSmodelo.ParameterName = "@sCRSmodelo";
                ParCRSmodelo.SqlDbType = SqlDbType.VarChar;
                ParCRSmodelo.Value = acfCRSt_Caracteristicas.CRSmodelo;
                SqlCmd.Parameters.Add(ParCRSmodelo);
                //
                SqlParameter ParCRScolor = new SqlParameter();
                ParCRScolor.ParameterName = "@sCRScolor";
                ParCRScolor.SqlDbType = SqlDbType.VarChar;
                ParCRScolor.Value = acfCRSt_Caracteristicas.CRScolor;
                SqlCmd.Parameters.Add(ParCRScolor);
                //
                SqlParameter ParMATid = new SqlParameter();
                ParMATid.ParameterName = "@iMATid";
                ParMATid.SqlDbType = SqlDbType.Char;
                ParMATid.Value = acfCRSt_Caracteristicas.MATid;
                SqlCmd.Parameters.Add(ParMATid);
                //
                SqlParameter ParCRStipo = new SqlParameter();
                ParCRStipo.ParameterName = "@sCRStipo";
                ParCRStipo.SqlDbType = SqlDbType.Char;
                ParCRStipo.Value = acfCRSt_Caracteristicas.CRStipo;
                SqlCmd.Parameters.Add(ParCRStipo);
                //
                SqlParameter ParUNMid = new SqlParameter();
                ParUNMid.ParameterName = "@iUNMid";
                ParUNMid.SqlDbType = SqlDbType.Int;
                ParUNMid.Value = Convert.ToInt32(acfCRSt_Caracteristicas.UNMid);
                SqlCmd.Parameters.Add(ParUNMid);
                //
                SqlParameter ParCRScantidad = new SqlParameter();
                ParCRScantidad.ParameterName = "@decCRScantidad";
                ParCRScantidad.SqlDbType = SqlDbType.Decimal;
                ParCRScantidad.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRScantidad);
                SqlCmd.Parameters.Add(ParCRScantidad);
                //
                SqlParameter ParCRSvehplaca = new SqlParameter();
                ParCRSvehplaca.ParameterName = "@sCRSvehplaca";
                ParCRSvehplaca.SqlDbType = SqlDbType.VarChar;
                ParCRSvehplaca.Value = acfCRSt_Caracteristicas.CRSvehplaca;
                SqlCmd.Parameters.Add(ParCRSvehplaca);
                //
                SqlParameter ParCRSvehexpediente = new SqlParameter();
                ParCRSvehexpediente.ParameterName = "@sCRSvehexpediente";
                ParCRSvehexpediente.SqlDbType = SqlDbType.VarChar;
                ParCRSvehexpediente.Value = acfCRSt_Caracteristicas.CRSvehexpediente;
                SqlCmd.Parameters.Add(ParCRSvehexpediente);
                //


                SqlParameter ParCRSvehinscripcion = new SqlParameter();
                ParCRSvehinscripcion.ParameterName = "@dtCRSvehinscripcion";
                ParCRSvehinscripcion.SqlDbType = SqlDbType.DateTime;
                if (string.IsNullOrWhiteSpace(acfCRSt_Caracteristicas.CRSvehinscripcion))
                {
                    ParCRSvehinscripcion.Value = DBNull.Value;
                }
                else
                {
                    ParCRSvehinscripcion.Value = Convert.ToDateTime(acfCRSt_Caracteristicas.CRSvehinscripcion);
                }
                SqlCmd.Parameters.Add(ParCRSvehinscripcion);
                //
                SqlParameter ParCRSvehclase = new SqlParameter();
                ParCRSvehclase.ParameterName = "@sCRSvehclase";
                ParCRSvehclase.SqlDbType = SqlDbType.VarChar;
                ParCRSvehclase.Value = acfCRSt_Caracteristicas.CRSvehclase;
                SqlCmd.Parameters.Add(ParCRSvehclase);
                //
                SqlParameter ParCRSvehcombustible = new SqlParameter();
                ParCRSvehcombustible.ParameterName = "@sCRSvehcombustible";
                ParCRSvehcombustible.SqlDbType = SqlDbType.VarChar;
                ParCRSvehcombustible.Value = acfCRSt_Caracteristicas.CRSvehcombustible;
                SqlCmd.Parameters.Add(ParCRSvehcombustible);
                //
                SqlParameter ParCRSvehejes = new SqlParameter();
                ParCRSvehejes.ParameterName = "@iCRSvehejes";
                ParCRSvehejes.SqlDbType = SqlDbType.Int;
                ParCRSvehejes.Value = Convert.ToInt32(acfCRSt_Caracteristicas.CRSvehejes);
                SqlCmd.Parameters.Add(ParCRSvehejes);
                //
                SqlParameter ParCRSvehpasajeros = new SqlParameter();
                ParCRSvehpasajeros.ParameterName = "@iCRSvehpasajeros";
                ParCRSvehpasajeros.SqlDbType = SqlDbType.Int;
                ParCRSvehpasajeros.Value = Convert.ToInt32(acfCRSt_Caracteristicas.CRSvehpasajeros);
                SqlCmd.Parameters.Add(ParCRSvehpasajeros);
                //
                SqlParameter ParCRSvehasientos = new SqlParameter();
                ParCRSvehasientos.ParameterName = "@iCRSvehasientos";
                ParCRSvehasientos.SqlDbType = SqlDbType.Int;
                ParCRSvehasientos.Value = Convert.ToInt32(acfCRSt_Caracteristicas.CRSvehasientos);
                SqlCmd.Parameters.Add(ParCRSvehasientos);
                //
                SqlParameter ParCRSvehpesoseco = new SqlParameter();
                ParCRSvehpesoseco.ParameterName = "@decCRSvehpesoseco";
                ParCRSvehpesoseco.SqlDbType = SqlDbType.Decimal;
                ParCRSvehpesoseco.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSvehpesoseco);
                SqlCmd.Parameters.Add(ParCRSvehpesoseco);
                //
                SqlParameter ParCRSvehcargautil = new SqlParameter();
                ParCRSvehcargautil.ParameterName = "@decCRSvehcargautil";
                ParCRSvehcargautil.SqlDbType = SqlDbType.Decimal;
                ParCRSvehcargautil.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSvehcargautil);
                SqlCmd.Parameters.Add(ParCRSvehcargautil);
                //
                SqlParameter ParCRSaltura = new SqlParameter();
                ParCRSaltura.ParameterName = "@decCRSaltura";
                ParCRSaltura.SqlDbType = SqlDbType.Decimal;
                ParCRSaltura.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSaltura);
                SqlCmd.Parameters.Add(ParCRSaltura);
                //
                SqlParameter ParCRSancho = new SqlParameter();
                ParCRSancho.ParameterName = "@decCRSancho";
                ParCRSancho.SqlDbType = SqlDbType.Decimal;
                ParCRSancho.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSancho);
                SqlCmd.Parameters.Add(ParCRSancho);
                //
                SqlParameter ParCRSvelocidad = new SqlParameter();
                ParCRSvelocidad.ParameterName = "@sCRSvelocidad";
                ParCRSvelocidad.SqlDbType = SqlDbType.VarChar;
                ParCRSvelocidad.Value = acfCRSt_Caracteristicas.CRSvelocidad;
                SqlCmd.Parameters.Add(ParCRSvelocidad);
                //
                SqlParameter ParCRSresolucion = new SqlParameter();
                ParCRSresolucion.ParameterName = "@sCRSresolucion";
                ParCRSresolucion.SqlDbType = SqlDbType.VarChar;
                ParCRSresolucion.Value = acfCRSt_Caracteristicas.CRSresolucion;
                SqlCmd.Parameters.Add(ParCRSresolucion);
                //
                SqlParameter ParCRScapacidad = new SqlParameter();
                ParCRScapacidad.ParameterName = "@sCRScapacidad";
                ParCRScapacidad.SqlDbType = SqlDbType.VarChar;
                ParCRScapacidad.Value = acfCRSt_Caracteristicas.CRScapacidad;
                SqlCmd.Parameters.Add(ParCRScapacidad);
                //
                SqlParameter ParCRSpotencia = new SqlParameter();
                ParCRSpotencia.ParameterName = "@sCRSpotencia";
                ParCRSpotencia.SqlDbType = SqlDbType.VarChar;
                ParCRSpotencia.Value = acfCRSt_Caracteristicas.CRSpotencia;
                SqlCmd.Parameters.Add(ParCRSpotencia);
                //
                SqlParameter ParCRSvnominal = new SqlParameter();
                ParCRSvnominal.ParameterName = "@sCRSvnominal";
                ParCRSvnominal.SqlDbType = SqlDbType.VarChar;
                ParCRSvnominal.Value = acfCRSt_Caracteristicas.CRSvnominal;
                SqlCmd.Parameters.Add(ParCRSvnominal);
                //
                SqlParameter ParCRSventrada = new SqlParameter();
                ParCRSventrada.ParameterName = "@sCRSventrada";
                ParCRSventrada.SqlDbType = SqlDbType.VarChar;
                ParCRSventrada.Value = acfCRSt_Caracteristicas.CRSventrada;
                SqlCmd.Parameters.Add(ParCRSventrada);
                //
                SqlParameter ParCRSvsalida = new SqlParameter();
                ParCRSvsalida.ParameterName = "@sCRSvsalida";
                ParCRSvsalida.SqlDbType = SqlDbType.VarChar;
                ParCRSvsalida.Value = acfCRSt_Caracteristicas.CRSvsalida;
                SqlCmd.Parameters.Add(ParCRSvsalida);
                //
                SqlParameter ParCRSfrecuencia = new SqlParameter();
                ParCRSfrecuencia.ParameterName = "@sCRSfrecuencia";
                ParCRSfrecuencia.SqlDbType = SqlDbType.VarChar;
                ParCRSfrecuencia.Value = acfCRSt_Caracteristicas.CRSfrecuencia;
                SqlCmd.Parameters.Add(ParCRSfrecuencia);
                //
                SqlParameter ParCRStemperatura = new SqlParameter();
                ParCRStemperatura.ParameterName = "@sCRStemperatura";
                ParCRStemperatura.SqlDbType = SqlDbType.VarChar;
                ParCRStemperatura.Value = acfCRSt_Caracteristicas.CRStemperatura;
                SqlCmd.Parameters.Add(ParCRStemperatura);
                //
                SqlParameter ParCRSprocesador = new SqlParameter();
                ParCRSprocesador.ParameterName = "@sCRSprocesador";
                ParCRSprocesador.SqlDbType = SqlDbType.VarChar;
                ParCRSprocesador.Value = acfCRSt_Caracteristicas.CRSprocesador;
                SqlCmd.Parameters.Add(ParCRSprocesador);
                //
                SqlParameter ParCRSpuertos = new SqlParameter();
                ParCRSpuertos.ParameterName = "@sCRSpuertos";
                ParCRSpuertos.SqlDbType = SqlDbType.VarChar;
                ParCRSpuertos.Value = acfCRSt_Caracteristicas.CRSpuertos;
                SqlCmd.Parameters.Add(ParCRSpuertos);
                //
                SqlParameter ParCRSutmx = new SqlParameter();
                ParCRSutmx.ParameterName = "@decCRSutmx";
                ParCRSutmx.SqlDbType = SqlDbType.Decimal;
                ParCRSutmx.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSutmx);
                SqlCmd.Parameters.Add(ParCRSutmx);
                //
                SqlParameter ParCRSutmy = new SqlParameter();
                ParCRSutmy.ParameterName = "@decCRSutmy";
                ParCRSutmy.SqlDbType = SqlDbType.Decimal;
                ParCRSutmy.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSutmy);
                SqlCmd.Parameters.Add(ParCRSutmy);
                //
                SqlParameter ParCRSesfuerzopunta = new SqlParameter();
                ParCRSesfuerzopunta.ParameterName = "@sCRSesfuerzopunta";
                ParCRSesfuerzopunta.SqlDbType = SqlDbType.VarChar;
                ParCRSesfuerzopunta.Value = acfCRSt_Caracteristicas.CRSesfuerzopunta;
                SqlCmd.Parameters.Add(ParCRSesfuerzopunta);
                //
                SqlParameter ParCRScajaderivadora = new SqlParameter();
                ParCRScajaderivadora.ParameterName = "@sCRScajaderivadora";
                ParCRScajaderivadora.SqlDbType = SqlDbType.VarChar;
                ParCRScajaderivadora.Value = acfCRSt_Caracteristicas.CRScajaderivadora;
                SqlCmd.Parameters.Add(ParCRScajaderivadora);
                //
                SqlParameter ParCRSalquilacable = new SqlParameter();
                ParCRSalquilacable.ParameterName = "@sCRSalquilacable";
                ParCRSalquilacable.SqlDbType = SqlDbType.Char;
                ParCRSalquilacable.Value = acfCRSt_Caracteristicas.CRSalquilacable;
                SqlCmd.Parameters.Add(ParCRSalquilacable);
                //
                SqlParameter ParCRScentropoblado = new SqlParameter();
                ParCRScentropoblado.ParameterName = "@sCRScentropoblado";
                ParCRScentropoblado.SqlDbType = SqlDbType.VarChar;
                ParCRScentropoblado.Value = acfCRSt_Caracteristicas.CRScentropoblado;
                SqlCmd.Parameters.Add(ParCRScentropoblado);
                //
                SqlParameter ParCRSurbanizacion = new SqlParameter();
                ParCRSurbanizacion.ParameterName = "@sCRSurbanizacion";
                ParCRSurbanizacion.SqlDbType = SqlDbType.VarChar;
                ParCRSurbanizacion.Value = acfCRSt_Caracteristicas.CRSurbanizacion;
                SqlCmd.Parameters.Add(ParCRSurbanizacion);
                //
                SqlParameter ParCRScalle = new SqlParameter();
                ParCRScalle.ParameterName = "@sCRScalle";
                ParCRScalle.SqlDbType = SqlDbType.VarChar;
                ParCRScalle.Value = acfCRSt_Caracteristicas.CRScalle;
                SqlCmd.Parameters.Add(ParCRScalle);
                //
                SqlParameter ParCRSlote = new SqlParameter();
                ParCRSlote.ParameterName = "@sCRSlote";
                ParCRSlote.SqlDbType = SqlDbType.VarChar;
                ParCRSlote.Value = acfCRSt_Caracteristicas.CRSlote;
                SqlCmd.Parameters.Add(ParCRSlote);
                //
                SqlParameter ParCRSnumeropredio = new SqlParameter();
                ParCRSnumeropredio.ParameterName = "@sCRSnumeropredio";
                ParCRSnumeropredio.SqlDbType = SqlDbType.VarChar;
                ParCRSnumeropredio.Value = acfCRSt_Caracteristicas.CRSnumeropredio;
                SqlCmd.Parameters.Add(ParCRSnumeropredio);
                //
                SqlParameter ParCRSdepartamento = new SqlParameter();
                ParCRSdepartamento.ParameterName = "@sCRSdepartamento";
                ParCRSdepartamento.SqlDbType = SqlDbType.VarChar;
                ParCRSdepartamento.Value = acfCRSt_Caracteristicas.CRSdepartamento;
                SqlCmd.Parameters.Add(ParCRSdepartamento);
                //
                SqlParameter ParCRSinterior = new SqlParameter();
                ParCRSinterior.ParameterName = "@sCRSinterior";
                ParCRSinterior.SqlDbType = SqlDbType.VarChar;
                ParCRSinterior.Value = acfCRSt_Caracteristicas.CRSinterior;
                SqlCmd.Parameters.Add(ParCRSinterior);
                //
                SqlParameter ParCRScarretera = new SqlParameter();
                ParCRScarretera.ParameterName = "@sCRScarretera";
                ParCRScarretera.SqlDbType = SqlDbType.VarChar;
                ParCRScarretera.Value = acfCRSt_Caracteristicas.CRScarretera;
                SqlCmd.Parameters.Add(ParCRScarretera);
                //
                SqlParameter ParCRSkilometro = new SqlParameter();
                ParCRSkilometro.ParameterName = "@decCRSkilometro";
                ParCRSkilometro.SqlDbType = SqlDbType.Decimal;
                ParCRSkilometro.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSkilometro);
                SqlCmd.Parameters.Add(ParCRSkilometro);
                //
                SqlParameter ParCRSnombrepredio = new SqlParameter();
                ParCRSnombrepredio.ParameterName = "@sCRSnombrepredio";
                ParCRSnombrepredio.SqlDbType = SqlDbType.VarChar;
                ParCRSnombrepredio.Value = acfCRSt_Caracteristicas.CRSnombrepredio;
                SqlCmd.Parameters.Add(ParCRSnombrepredio);
                //
                SqlParameter ParCRSpisospredio = new SqlParameter();
                ParCRSpisospredio.ParameterName = "@iCRSpisospredio";
                ParCRSpisospredio.SqlDbType = SqlDbType.Int;
                ParCRSpisospredio.Value = Convert.ToInt32(acfCRSt_Caracteristicas.CRSpisospredio);
                SqlCmd.Parameters.Add(ParCRSpisospredio);
                //
                SqlParameter ParCRSpartidapredio = new SqlParameter();
                ParCRSpartidapredio.ParameterName = "@sCRSpartidapredio";
                ParCRSpartidapredio.SqlDbType = SqlDbType.VarChar;
                ParCRSpartidapredio.Value = acfCRSt_Caracteristicas.CRSpartidapredio;
                SqlCmd.Parameters.Add(ParCRSpartidapredio);
                //
                SqlParameter ParCRStomopredio = new SqlParameter();
                ParCRStomopredio.ParameterName = "@sCRStomopredio";
                ParCRStomopredio.SqlDbType = SqlDbType.VarChar;
                ParCRStomopredio.Value = acfCRSt_Caracteristicas.CRStomopredio;
                SqlCmd.Parameters.Add(ParCRStomopredio);
                //
                SqlParameter ParCRSfolioinipredio = new SqlParameter();
                ParCRSfolioinipredio.ParameterName = "@sCRSfolioinipredio";
                ParCRSfolioinipredio.SqlDbType = SqlDbType.VarChar;
                ParCRSfolioinipredio.Value = acfCRSt_Caracteristicas.CRSfolioinipredio;
                SqlCmd.Parameters.Add(ParCRSfolioinipredio);
                //
                SqlParameter ParCRSfoliofinpredio = new SqlParameter();
                ParCRSfoliofinpredio.ParameterName = "@sCRSfoliofinpredio";
                ParCRSfoliofinpredio.SqlDbType = SqlDbType.VarChar;
                ParCRSfoliofinpredio.Value = acfCRSt_Caracteristicas.CRSfoliofinpredio;
                SqlCmd.Parameters.Add(ParCRSfoliofinpredio);
                //
                SqlParameter ParCRSasientopredio = new SqlParameter();
                ParCRSasientopredio.ParameterName = "@sCRSasientopredio";
                ParCRSasientopredio.SqlDbType = SqlDbType.VarChar;
                ParCRSasientopredio.Value = acfCRSt_Caracteristicas.CRSasientopredio;
                SqlCmd.Parameters.Add(ParCRSasientopredio);
                //
                SqlParameter ParCRSfinscpredio = new SqlParameter();
                ParCRSfinscpredio.ParameterName = "@dtCRSfinscpredio";
                ParCRSfinscpredio.SqlDbType = SqlDbType.DateTime;
                if (string.IsNullOrWhiteSpace(acfCRSt_Caracteristicas.CRSfinscpredio))
                {
                    ParCRSfinscpredio.Value = DBNull.Value;
                }
                else
                {
                    ParCRSfinscpredio.Value = Convert.ToDateTime(acfCRSt_Caracteristicas.CRSfinscpredio);
                }
                SqlCmd.Parameters.Add(ParCRSfinscpredio);
                //
                SqlParameter ParCRSficharegistral = new SqlParameter();
                ParCRSficharegistral.ParameterName = "@sCRSficharegistral";
                ParCRSficharegistral.SqlDbType = SqlDbType.VarChar;
                ParCRSficharegistral.Value = acfCRSt_Caracteristicas.CRSficharegistral;
                SqlCmd.Parameters.Add(ParCRSficharegistral);
                //
                SqlParameter ParCRSareaconstruida = new SqlParameter();
                ParCRSareaconstruida.ParameterName = "@decCRSareaconstruida";
                ParCRSareaconstruida.SqlDbType = SqlDbType.Decimal;
                ParCRSareaconstruida.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSareaconstruida);
                SqlCmd.Parameters.Add(ParCRSareaconstruida);
                //
                SqlParameter ParCRSperimetro = new SqlParameter();
                ParCRSperimetro.ParameterName = "@decCRSperimetro";
                ParCRSperimetro.SqlDbType = SqlDbType.Decimal;
                ParCRSperimetro.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSperimetro);
                SqlCmd.Parameters.Add(ParCRSperimetro);
                //
                SqlParameter ParCRSusopredio = new SqlParameter();
                ParCRSusopredio.ParameterName = "@sCRSusopredio";
                ParCRSusopredio.SqlDbType = SqlDbType.VarChar;
                ParCRSusopredio.Value = acfCRSt_Caracteristicas.CRSusopredio;
                SqlCmd.Parameters.Add(ParCRSusopredio);
                //
                SqlParameter ParCRSvalorautovaluo = new SqlParameter();
                ParCRSvalorautovaluo.ParameterName = "@decCRSvalorautovaluo";
                ParCRSvalorautovaluo.SqlDbType = SqlDbType.Decimal;
                ParCRSvalorautovaluo.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSvalorautovaluo);
                SqlCmd.Parameters.Add(ParCRSvalorautovaluo);
                //
                SqlParameter ParCRScodigoluz = new SqlParameter();
                ParCRScodigoluz.ParameterName = "@sCRScodigoluz";
                ParCRScodigoluz.SqlDbType = SqlDbType.VarChar;
                ParCRScodigoluz.Value = acfCRSt_Caracteristicas.CRScodigoluz;
                SqlCmd.Parameters.Add(ParCRScodigoluz);
                //
                SqlParameter ParCRScodigoagua = new SqlParameter();
                ParCRScodigoagua.ParameterName = "@sCRScodigoagua";
                ParCRScodigoagua.SqlDbType = SqlDbType.VarChar;
                ParCRScodigoagua.Value = acfCRSt_Caracteristicas.CRScodigoagua;
                SqlCmd.Parameters.Add(ParCRScodigoagua);
                //
                SqlParameter ParCRSfadqpredio = new SqlParameter();
                ParCRSfadqpredio.ParameterName = "@dtCRSfadqpredio";
                ParCRSfadqpredio.SqlDbType = SqlDbType.DateTime;
                if (string.IsNullOrWhiteSpace(acfCRSt_Caracteristicas.CRSfadqpredio))
                {
                    ParCRSfadqpredio.Value = DBNull.Value;
                }
                else
                {
                    ParCRSfadqpredio.Value = Convert.ToDateTime(acfCRSt_Caracteristicas.CRSfadqpredio);
                }
                SqlCmd.Parameters.Add(ParCRSfadqpredio);
                //
                SqlParameter ParCRSobservacion = new SqlParameter();
                ParCRSobservacion.ParameterName = "@sCRSobservacion";
                ParCRSobservacion.SqlDbType = SqlDbType.VarChar;
                ParCRSobservacion.Value = acfCRSt_Caracteristicas.CRSobservacion;
                SqlCmd.Parameters.Add(ParCRSobservacion);
                //
                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Elimino el Registro";



            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }


        //Metodo Insertar Excel a DB_Caracter{isticas
        public string SAPIMPORT(DacfCRSt_Caracteristicas acfCRSt_Caracteristicas)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_I_SAPIMPORT_CARACTERISTICAS";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@iACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                //ParACFid.Value = Convert.ToInt32(acfCRSt_Caracteristicas.ACFid);
                if (string.IsNullOrWhiteSpace(acfCRSt_Caracteristicas.ACFid))
                {
                    ParACFid.Value = 0;
                }
                else
                {
                    ParACFid.Value = Convert.ToInt32(acfCRSt_Caracteristicas.ACFid);
                }
                SqlCmd.Parameters.Add(ParACFid);
                //
                SqlParameter ParMARid = new SqlParameter();
                ParMARid.ParameterName = "@iMARid";
                ParMARid.SqlDbType = SqlDbType.Int;
                ParMARid.Value = Convert.ToInt32(acfCRSt_Caracteristicas.MARid);
                SqlCmd.Parameters.Add(ParMARid);
                //
                SqlParameter ParESTid = new SqlParameter();
                ParESTid.ParameterName = "@iESTid";
                ParESTid.SqlDbType = SqlDbType.Int;
                ParESTid.Value = Convert.ToInt32(acfCRSt_Caracteristicas.ESTid);
                SqlCmd.Parameters.Add(ParESTid);
                //
                SqlParameter ParCRSserie = new SqlParameter();
                ParCRSserie.ParameterName = "@sCRSserie";
                ParCRSserie.SqlDbType = SqlDbType.VarChar;
                ParCRSserie.Value = acfCRSt_Caracteristicas.CRSserie;
                SqlCmd.Parameters.Add(ParCRSserie);
                //
                SqlParameter ParCRSmodelo = new SqlParameter();
                ParCRSmodelo.ParameterName = "@sCRSmodelo";
                ParCRSmodelo.SqlDbType = SqlDbType.VarChar;
                ParCRSmodelo.Value = acfCRSt_Caracteristicas.CRSmodelo;
                SqlCmd.Parameters.Add(ParCRSmodelo);
                //
                SqlParameter ParCRScolor = new SqlParameter();
                ParCRScolor.ParameterName = "@sCRScolor";
                ParCRScolor.SqlDbType = SqlDbType.VarChar;
                ParCRScolor.Value = acfCRSt_Caracteristicas.CRScolor;
                SqlCmd.Parameters.Add(ParCRScolor);
                //
                SqlParameter ParMATid = new SqlParameter();
                ParMATid.ParameterName = "@iMATid";
                ParMATid.SqlDbType = SqlDbType.Char;
                ParMATid.Value = acfCRSt_Caracteristicas.MATid;
                SqlCmd.Parameters.Add(ParMATid);
                //
                SqlParameter ParCRStipo = new SqlParameter();
                ParCRStipo.ParameterName = "@sCRStipo";
                ParCRStipo.SqlDbType = SqlDbType.Char;
                ParCRStipo.Value = acfCRSt_Caracteristicas.CRStipo;
                SqlCmd.Parameters.Add(ParCRStipo);
                //
                SqlParameter ParUNMid = new SqlParameter();
                ParUNMid.ParameterName = "@iUNMid";
                ParUNMid.SqlDbType = SqlDbType.Int;
                ParUNMid.Value = Convert.ToInt32(acfCRSt_Caracteristicas.UNMid);
                SqlCmd.Parameters.Add(ParUNMid);
                //
                SqlParameter ParCRScantidad = new SqlParameter();
                ParCRScantidad.ParameterName = "@decCRScantidad";
                ParCRScantidad.SqlDbType = SqlDbType.Decimal;
                ParCRScantidad.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRScantidad);
                SqlCmd.Parameters.Add(ParCRScantidad);
                //
                SqlParameter ParCRSvehplaca = new SqlParameter();
                ParCRSvehplaca.ParameterName = "@sCRSvehplaca";
                ParCRSvehplaca.SqlDbType = SqlDbType.VarChar;
                ParCRSvehplaca.Value = acfCRSt_Caracteristicas.CRSvehplaca;
                SqlCmd.Parameters.Add(ParCRSvehplaca);
                //
                SqlParameter ParCRSvehexpediente = new SqlParameter();
                ParCRSvehexpediente.ParameterName = "@sCRSvehexpediente";
                ParCRSvehexpediente.SqlDbType = SqlDbType.VarChar;
                ParCRSvehexpediente.Value = acfCRSt_Caracteristicas.CRSvehexpediente;
                SqlCmd.Parameters.Add(ParCRSvehexpediente);
                //
                SqlParameter ParCRSvehinscripcion = new SqlParameter();
                ParCRSvehinscripcion.ParameterName = "@dtCRSvehinscripcion";
                ParCRSvehinscripcion.SqlDbType = SqlDbType.DateTime;
                ParCRSvehinscripcion.Value = Convert.ToDateTime(acfCRSt_Caracteristicas.CRSvehinscripcion);
                SqlCmd.Parameters.Add(ParCRSvehinscripcion);
                //
                SqlParameter ParCRSvehclase = new SqlParameter();
                ParCRSvehclase.ParameterName = "@sCRSvehclase";
                ParCRSvehclase.SqlDbType = SqlDbType.VarChar;
                ParCRSvehclase.Value = acfCRSt_Caracteristicas.CRSvehclase;
                SqlCmd.Parameters.Add(ParCRSvehclase);
                //
                SqlParameter ParCRSvehcombustible = new SqlParameter();
                ParCRSvehcombustible.ParameterName = "@sCRSvehcombustible";
                ParCRSvehcombustible.SqlDbType = SqlDbType.VarChar;
                ParCRSvehcombustible.Value = acfCRSt_Caracteristicas.CRSvehcombustible;
                SqlCmd.Parameters.Add(ParCRSvehcombustible);
                //
                SqlParameter ParCRSvehejes = new SqlParameter();
                ParCRSvehejes.ParameterName = "@iCRSvehejes";
                ParCRSvehejes.SqlDbType = SqlDbType.Int;
                ParCRSvehejes.Value = Convert.ToInt32(acfCRSt_Caracteristicas.CRSvehejes);
                SqlCmd.Parameters.Add(ParCRSvehejes);
                //
                SqlParameter ParCRSvehpasajeros = new SqlParameter();
                ParCRSvehpasajeros.ParameterName = "@iCRSvehpasajeros";
                ParCRSvehpasajeros.SqlDbType = SqlDbType.Int;
                ParCRSvehpasajeros.Value = Convert.ToInt32(acfCRSt_Caracteristicas.CRSvehpasajeros);
                SqlCmd.Parameters.Add(ParCRSvehpasajeros);
                //
                SqlParameter ParCRSvehasientos = new SqlParameter();
                ParCRSvehasientos.ParameterName = "@iCRSvehasientos";
                ParCRSvehasientos.SqlDbType = SqlDbType.Int;
                ParCRSvehasientos.Value = Convert.ToInt32(acfCRSt_Caracteristicas.CRSvehasientos);
                SqlCmd.Parameters.Add(ParCRSvehasientos);
                //
                SqlParameter ParCRSvehpesoseco = new SqlParameter();
                ParCRSvehpesoseco.ParameterName = "@decCRSvehpesoseco";
                ParCRSvehpesoseco.SqlDbType = SqlDbType.Decimal;
                ParCRSvehpesoseco.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSvehpesoseco);
                SqlCmd.Parameters.Add(ParCRSvehpesoseco);
                //
                SqlParameter ParCRSvehcargautil = new SqlParameter();
                ParCRSvehcargautil.ParameterName = "@decCRSvehcargautil";
                ParCRSvehcargautil.SqlDbType = SqlDbType.Decimal;
                ParCRSvehcargautil.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSvehcargautil);
                SqlCmd.Parameters.Add(ParCRSvehcargautil);
                //
                SqlParameter ParCRSaltura = new SqlParameter();
                ParCRSaltura.ParameterName = "@decCRSaltura";
                ParCRSaltura.SqlDbType = SqlDbType.Decimal;
                ParCRSaltura.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSaltura);
                SqlCmd.Parameters.Add(ParCRSaltura);
                //
                SqlParameter ParCRSancho = new SqlParameter();
                ParCRSancho.ParameterName = "@decCRSancho";
                ParCRSancho.SqlDbType = SqlDbType.Decimal;
                ParCRSancho.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSancho);
                SqlCmd.Parameters.Add(ParCRSancho);
                //
                SqlParameter ParCRSvelocidad = new SqlParameter();
                ParCRSvelocidad.ParameterName = "@sCRSvelocidad";
                ParCRSvelocidad.SqlDbType = SqlDbType.VarChar;
                ParCRSvelocidad.Value = acfCRSt_Caracteristicas.CRSvelocidad;
                SqlCmd.Parameters.Add(ParCRSvelocidad);
                //
                SqlParameter ParCRSresolucion = new SqlParameter();
                ParCRSresolucion.ParameterName = "@sCRSresolucion";
                ParCRSresolucion.SqlDbType = SqlDbType.VarChar;
                ParCRSresolucion.Value = acfCRSt_Caracteristicas.CRSresolucion;
                SqlCmd.Parameters.Add(ParCRSresolucion);
                //
                SqlParameter ParCRScapacidad = new SqlParameter();
                ParCRScapacidad.ParameterName = "@sCRScapacidad";
                ParCRScapacidad.SqlDbType = SqlDbType.VarChar;
                ParCRScapacidad.Value = acfCRSt_Caracteristicas.CRScapacidad;
                SqlCmd.Parameters.Add(ParCRScapacidad);
                //
                SqlParameter ParCRSpotencia = new SqlParameter();
                ParCRSpotencia.ParameterName = "@sCRSpotencia";
                ParCRSpotencia.SqlDbType = SqlDbType.VarChar;
                ParCRSpotencia.Value = acfCRSt_Caracteristicas.CRSpotencia;
                SqlCmd.Parameters.Add(ParCRSpotencia);
                //
                SqlParameter ParCRSvnominal = new SqlParameter();
                ParCRSvnominal.ParameterName = "@sCRSvnominal";
                ParCRSvnominal.SqlDbType = SqlDbType.VarChar;
                ParCRSvnominal.Value = acfCRSt_Caracteristicas.CRSvnominal;
                SqlCmd.Parameters.Add(ParCRSvnominal);
                //
                SqlParameter ParCRSventrada = new SqlParameter();
                ParCRSventrada.ParameterName = "@sCRSventrada";
                ParCRSventrada.SqlDbType = SqlDbType.VarChar;
                ParCRSventrada.Value = acfCRSt_Caracteristicas.CRSventrada;
                SqlCmd.Parameters.Add(ParCRSventrada);
                //
                SqlParameter ParCRSvsalida = new SqlParameter();
                ParCRSvsalida.ParameterName = "@sCRSvsalida";
                ParCRSvsalida.SqlDbType = SqlDbType.VarChar;
                ParCRSvsalida.Value = acfCRSt_Caracteristicas.CRSvsalida;
                SqlCmd.Parameters.Add(ParCRSvsalida);
                //
                SqlParameter ParCRSfrecuencia = new SqlParameter();
                ParCRSfrecuencia.ParameterName = "@sCRSfrecuencia";
                ParCRSfrecuencia.SqlDbType = SqlDbType.VarChar;
                ParCRSfrecuencia.Value = acfCRSt_Caracteristicas.CRSfrecuencia;
                SqlCmd.Parameters.Add(ParCRSfrecuencia);
                //
                SqlParameter ParCRStemperatura = new SqlParameter();
                ParCRStemperatura.ParameterName = "@sCRStemperatura";
                ParCRStemperatura.SqlDbType = SqlDbType.VarChar;
                ParCRStemperatura.Value = acfCRSt_Caracteristicas.CRStemperatura;
                SqlCmd.Parameters.Add(ParCRStemperatura);
                //
                SqlParameter ParCRSprocesador = new SqlParameter();
                ParCRSprocesador.ParameterName = "@sCRSprocesador";
                ParCRSprocesador.SqlDbType = SqlDbType.VarChar;
                ParCRSprocesador.Value = acfCRSt_Caracteristicas.CRSprocesador;
                SqlCmd.Parameters.Add(ParCRSprocesador);
                //
                SqlParameter ParCRSpuertos = new SqlParameter();
                ParCRSpuertos.ParameterName = "@sCRSpuertos";
                ParCRSpuertos.SqlDbType = SqlDbType.VarChar;
                ParCRSpuertos.Value = acfCRSt_Caracteristicas.CRSpuertos;
                SqlCmd.Parameters.Add(ParCRSpuertos);
                //
                SqlParameter ParCRSutmx = new SqlParameter();
                ParCRSutmx.ParameterName = "@decCRSutmx";
                ParCRSutmx.SqlDbType = SqlDbType.Decimal;
                ParCRSutmx.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSutmx);
                SqlCmd.Parameters.Add(ParCRSutmx);
                //
                SqlParameter ParCRSutmy = new SqlParameter();
                ParCRSutmy.ParameterName = "@decCRSutmy";
                ParCRSutmy.SqlDbType = SqlDbType.Decimal;
                ParCRSutmy.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSutmy);
                SqlCmd.Parameters.Add(ParCRSutmy);
                //
                SqlParameter ParCRSesfuerzopunta = new SqlParameter();
                ParCRSesfuerzopunta.ParameterName = "@sCRSesfuerzopunta";
                ParCRSesfuerzopunta.SqlDbType = SqlDbType.VarChar;
                ParCRSesfuerzopunta.Value = acfCRSt_Caracteristicas.CRSesfuerzopunta;
                SqlCmd.Parameters.Add(ParCRSesfuerzopunta);
                //
                SqlParameter ParCRScajaderivadora = new SqlParameter();
                ParCRScajaderivadora.ParameterName = "@sCRScajaderivadora";
                ParCRScajaderivadora.SqlDbType = SqlDbType.VarChar;
                ParCRScajaderivadora.Value = acfCRSt_Caracteristicas.CRScajaderivadora;
                SqlCmd.Parameters.Add(ParCRScajaderivadora);
                //
                SqlParameter ParCRSalquilacable = new SqlParameter();
                ParCRSalquilacable.ParameterName = "@sCRSalquilacable";
                ParCRSalquilacable.SqlDbType = SqlDbType.Char;
                ParCRSalquilacable.Value = acfCRSt_Caracteristicas.CRSalquilacable;
                SqlCmd.Parameters.Add(ParCRSalquilacable);
                //
                SqlParameter ParCRScentropoblado = new SqlParameter();
                ParCRScentropoblado.ParameterName = "@sCRScentropoblado";
                ParCRScentropoblado.SqlDbType = SqlDbType.VarChar;
                ParCRScentropoblado.Value = acfCRSt_Caracteristicas.CRScentropoblado;
                SqlCmd.Parameters.Add(ParCRScentropoblado);
                //
                SqlParameter ParCRSurbanizacion = new SqlParameter();
                ParCRSurbanizacion.ParameterName = "@sCRSurbanizacion";
                ParCRSurbanizacion.SqlDbType = SqlDbType.VarChar;
                ParCRSurbanizacion.Value = acfCRSt_Caracteristicas.CRSurbanizacion;
                SqlCmd.Parameters.Add(ParCRSurbanizacion);
                //
                SqlParameter ParCRScalle = new SqlParameter();
                ParCRScalle.ParameterName = "@sCRScalle";
                ParCRScalle.SqlDbType = SqlDbType.VarChar;
                ParCRScalle.Value = acfCRSt_Caracteristicas.CRScalle;
                SqlCmd.Parameters.Add(ParCRScalle);
                //
                SqlParameter ParCRSlote = new SqlParameter();
                ParCRSlote.ParameterName = "@sCRSlote";
                ParCRSlote.SqlDbType = SqlDbType.VarChar;
                ParCRSlote.Value = acfCRSt_Caracteristicas.CRSlote;
                SqlCmd.Parameters.Add(ParCRSlote);
                //
                SqlParameter ParCRSnumeropredio = new SqlParameter();
                ParCRSnumeropredio.ParameterName = "@sCRSnumeropredio";
                ParCRSnumeropredio.SqlDbType = SqlDbType.VarChar;
                ParCRSnumeropredio.Value = acfCRSt_Caracteristicas.CRSnumeropredio;
                SqlCmd.Parameters.Add(ParCRSnumeropredio);
                //
                SqlParameter ParCRSdepartamento = new SqlParameter();
                ParCRSdepartamento.ParameterName = "@sCRSdepartamento";
                ParCRSdepartamento.SqlDbType = SqlDbType.VarChar;
                ParCRSdepartamento.Value = acfCRSt_Caracteristicas.CRSdepartamento;
                SqlCmd.Parameters.Add(ParCRSdepartamento);
                //
                SqlParameter ParCRSinterior = new SqlParameter();
                ParCRSinterior.ParameterName = "@sCRSinterior";
                ParCRSinterior.SqlDbType = SqlDbType.VarChar;
                ParCRSinterior.Value = acfCRSt_Caracteristicas.CRSinterior;
                SqlCmd.Parameters.Add(ParCRSinterior);
                //
                SqlParameter ParCRScarretera = new SqlParameter();
                ParCRScarretera.ParameterName = "@sCRScarretera";
                ParCRScarretera.SqlDbType = SqlDbType.VarChar;
                ParCRScarretera.Value = acfCRSt_Caracteristicas.CRScarretera;
                SqlCmd.Parameters.Add(ParCRScarretera);
                //
                SqlParameter ParCRSkilometro = new SqlParameter();
                ParCRSkilometro.ParameterName = "@decCRSkilometro";
                ParCRSkilometro.SqlDbType = SqlDbType.Decimal;
                ParCRSkilometro.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSkilometro);
                SqlCmd.Parameters.Add(ParCRSkilometro);
                //
                SqlParameter ParCRSnombrepredio = new SqlParameter();
                ParCRSnombrepredio.ParameterName = "@sCRSnombrepredio";
                ParCRSnombrepredio.SqlDbType = SqlDbType.VarChar;
                ParCRSnombrepredio.Value = acfCRSt_Caracteristicas.CRSnombrepredio;
                SqlCmd.Parameters.Add(ParCRSnombrepredio);
                //
                SqlParameter ParCRSpisospredio = new SqlParameter();
                ParCRSpisospredio.ParameterName = "@iCRSpisospredio";
                ParCRSpisospredio.SqlDbType = SqlDbType.Int;
                ParCRSpisospredio.Value = Convert.ToInt32(acfCRSt_Caracteristicas.CRSpisospredio);
                SqlCmd.Parameters.Add(ParCRSpisospredio);
                //
                SqlParameter ParCRSpartidapredio = new SqlParameter();
                ParCRSpartidapredio.ParameterName = "@sCRSpartidapredio";
                ParCRSpartidapredio.SqlDbType = SqlDbType.VarChar;
                ParCRSpartidapredio.Value = acfCRSt_Caracteristicas.CRSpartidapredio;
                SqlCmd.Parameters.Add(ParCRSpartidapredio);
                //
                SqlParameter ParCRStomopredio = new SqlParameter();
                ParCRStomopredio.ParameterName = "@sCRStomopredio";
                ParCRStomopredio.SqlDbType = SqlDbType.VarChar;
                ParCRStomopredio.Value = acfCRSt_Caracteristicas.CRStomopredio;
                SqlCmd.Parameters.Add(ParCRStomopredio);
                //
                SqlParameter ParCRSfolioinipredio = new SqlParameter();
                ParCRSfolioinipredio.ParameterName = "@sCRSfolioinipredio";
                ParCRSfolioinipredio.SqlDbType = SqlDbType.VarChar;
                ParCRSfolioinipredio.Value = acfCRSt_Caracteristicas.CRSfolioinipredio;
                SqlCmd.Parameters.Add(ParCRSfolioinipredio);
                //
                SqlParameter ParCRSfoliofinpredio = new SqlParameter();
                ParCRSfoliofinpredio.ParameterName = "@sCRSfoliofinpredio";
                ParCRSfoliofinpredio.SqlDbType = SqlDbType.VarChar;
                ParCRSfoliofinpredio.Value = acfCRSt_Caracteristicas.CRSfoliofinpredio;
                SqlCmd.Parameters.Add(ParCRSfoliofinpredio);
                //
                SqlParameter ParCRSasientopredio = new SqlParameter();
                ParCRSasientopredio.ParameterName = "@sCRSasientopredio";
                ParCRSasientopredio.SqlDbType = SqlDbType.VarChar;
                ParCRSasientopredio.Value = acfCRSt_Caracteristicas.CRSasientopredio;
                SqlCmd.Parameters.Add(ParCRSasientopredio);
                //
                SqlParameter ParCRSfinscpredio = new SqlParameter();
                ParCRSfinscpredio.ParameterName = "@dtCRSfinscpredio";
                ParCRSfinscpredio.SqlDbType = SqlDbType.DateTime;
                ParCRSfinscpredio.Value = Convert.ToDateTime(acfCRSt_Caracteristicas.CRSfinscpredio);
                SqlCmd.Parameters.Add(ParCRSfinscpredio);
                //
                SqlParameter ParCRSficharegistral = new SqlParameter();
                ParCRSficharegistral.ParameterName = "@sCRSficharegistral";
                ParCRSficharegistral.SqlDbType = SqlDbType.VarChar;
                ParCRSficharegistral.Value = acfCRSt_Caracteristicas.CRSficharegistral;
                SqlCmd.Parameters.Add(ParCRSficharegistral);
                //
                SqlParameter ParCRSareaconstruida = new SqlParameter();
                ParCRSareaconstruida.ParameterName = "@decCRSareaconstruida";
                ParCRSareaconstruida.SqlDbType = SqlDbType.Decimal;
                ParCRSareaconstruida.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSareaconstruida);
                SqlCmd.Parameters.Add(ParCRSareaconstruida);
                //
                SqlParameter ParCRSperimetro = new SqlParameter();
                ParCRSperimetro.ParameterName = "@decCRSperimetro";
                ParCRSperimetro.SqlDbType = SqlDbType.Decimal;
                ParCRSperimetro.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSperimetro);
                SqlCmd.Parameters.Add(ParCRSperimetro);
                //
                SqlParameter ParCRSusopredio = new SqlParameter();
                ParCRSusopredio.ParameterName = "@sCRSusopredio";
                ParCRSusopredio.SqlDbType = SqlDbType.VarChar;
                ParCRSusopredio.Value = acfCRSt_Caracteristicas.CRSusopredio;
                SqlCmd.Parameters.Add(ParCRSusopredio);
                //
                SqlParameter ParCRSvalorautovaluo = new SqlParameter();
                ParCRSvalorautovaluo.ParameterName = "@decCRSvalorautovaluo";
                ParCRSvalorautovaluo.SqlDbType = SqlDbType.Decimal;
                ParCRSvalorautovaluo.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSvalorautovaluo);
                SqlCmd.Parameters.Add(ParCRSvalorautovaluo);
                //
                SqlParameter ParCRScodigoluz = new SqlParameter();
                ParCRScodigoluz.ParameterName = "@sCRScodigoluz";
                ParCRScodigoluz.SqlDbType = SqlDbType.VarChar;
                ParCRScodigoluz.Value = acfCRSt_Caracteristicas.CRScodigoluz;
                SqlCmd.Parameters.Add(ParCRScodigoluz);
                //
                SqlParameter ParCRScodigoagua = new SqlParameter();
                ParCRScodigoagua.ParameterName = "@sCRScodigoagua";
                ParCRScodigoagua.SqlDbType = SqlDbType.VarChar;
                ParCRScodigoagua.Value = acfCRSt_Caracteristicas.CRScodigoagua;
                SqlCmd.Parameters.Add(ParCRScodigoagua);
                //
                SqlParameter ParCRSfadqpredio = new SqlParameter();
                ParCRSfadqpredio.ParameterName = "@dtCRSfadqpredio";
                ParCRSfadqpredio.SqlDbType = SqlDbType.DateTime;
                ParCRSfadqpredio.Value = Convert.ToDateTime(acfCRSt_Caracteristicas.CRSfadqpredio);
                SqlCmd.Parameters.Add(ParCRSfadqpredio);
                //
                SqlParameter ParCRSobservacion = new SqlParameter();
                ParCRSobservacion.ParameterName = "@sCRSobservacion";
                ParCRSobservacion.SqlDbType = SqlDbType.VarChar;
                ParCRSobservacion.Value = acfCRSt_Caracteristicas.CRSobservacion;
                SqlCmd.Parameters.Add(ParCRSobservacion);
                //
                //Ejecutamos nuestro comando            
                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Elimino el Registro";        
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }


        //METODO EDITAR
        public string Editar(DacfCRSt_Caracteristicas acfCRSt_Caracteristicas)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_U_acfCRSt_Caracteristicas";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@iACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Value = Convert.ToInt32(acfCRSt_Caracteristicas.ACFid);
                SqlCmd.Parameters.Add(ParACFid);
                //
                SqlParameter ParMARid = new SqlParameter();
                ParMARid.ParameterName = "@iMARid";
                ParMARid.SqlDbType = SqlDbType.Int;
                ParMARid.Value = Convert.ToInt32(acfCRSt_Caracteristicas.MARid);
                SqlCmd.Parameters.Add(ParMARid);
                //
                SqlParameter ParESTid = new SqlParameter();
                ParESTid.ParameterName = "@iESTid";
                ParESTid.SqlDbType = SqlDbType.Int;
                ParESTid.Value = Convert.ToInt32(acfCRSt_Caracteristicas.ESTid);
                SqlCmd.Parameters.Add(ParESTid);
                //
                SqlParameter ParCRSserie = new SqlParameter();
                ParCRSserie.ParameterName = "@sCRSserie";
                ParCRSserie.SqlDbType = SqlDbType.VarChar;
                ParCRSserie.Value = acfCRSt_Caracteristicas.CRSserie;
                SqlCmd.Parameters.Add(ParCRSserie);
                //
                SqlParameter ParCRSmodelo = new SqlParameter();
                ParCRSmodelo.ParameterName = "@sCRSmodelo";
                ParCRSmodelo.SqlDbType = SqlDbType.VarChar;
                ParCRSmodelo.Value = acfCRSt_Caracteristicas.CRSmodelo;
                SqlCmd.Parameters.Add(ParCRSmodelo);
                //
                SqlParameter ParCRScolor = new SqlParameter();
                ParCRScolor.ParameterName = "@sCRScolor";
                ParCRScolor.SqlDbType = SqlDbType.VarChar;
                ParCRScolor.Value = acfCRSt_Caracteristicas.CRScolor;
                SqlCmd.Parameters.Add(ParCRScolor);
                //
                SqlParameter ParMATid = new SqlParameter();
                ParMATid.ParameterName = "@iMATid";
                ParMATid.SqlDbType = SqlDbType.Char;
                ParMATid.Value = acfCRSt_Caracteristicas.MATid;
                SqlCmd.Parameters.Add(ParMATid);
                //
                SqlParameter ParCRStipo = new SqlParameter();
                ParCRStipo.ParameterName = "@sCRStipo";
                ParCRStipo.SqlDbType = SqlDbType.Char;
                ParCRStipo.Value = acfCRSt_Caracteristicas.CRStipo;
                SqlCmd.Parameters.Add(ParCRStipo);
                //
                SqlParameter ParUNMid = new SqlParameter();
                ParUNMid.ParameterName = "@iUNMid";
                ParUNMid.SqlDbType = SqlDbType.Int;
                ParUNMid.Value = Convert.ToInt32(acfCRSt_Caracteristicas.UNMid);
                SqlCmd.Parameters.Add(ParUNMid);
                //
                SqlParameter ParCRScantidad = new SqlParameter();
                ParCRScantidad.ParameterName = "@decCRScantidad";
                ParCRScantidad.SqlDbType = SqlDbType.Decimal;
                ParCRScantidad.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRScantidad);
                SqlCmd.Parameters.Add(ParCRScantidad);
                //
                SqlParameter ParCRSvehplaca = new SqlParameter();
                ParCRSvehplaca.ParameterName = "@sCRSvehplaca";
                ParCRSvehplaca.SqlDbType = SqlDbType.VarChar;
                ParCRSvehplaca.Value = acfCRSt_Caracteristicas.CRSvehplaca;
                SqlCmd.Parameters.Add(ParCRSvehplaca);
                //
                SqlParameter ParCRSvehexpediente = new SqlParameter();
                ParCRSvehexpediente.ParameterName = "@sCRSvehexpediente";
                ParCRSvehexpediente.SqlDbType = SqlDbType.VarChar;
                ParCRSvehexpediente.Value = acfCRSt_Caracteristicas.CRSvehexpediente;
                SqlCmd.Parameters.Add(ParCRSvehexpediente);
                //


                SqlParameter ParCRSvehinscripcion = new SqlParameter();
                ParCRSvehinscripcion.ParameterName = "@dtCRSvehinscripcion";
                ParCRSvehinscripcion.SqlDbType = SqlDbType.DateTime;
                if (string.IsNullOrWhiteSpace(acfCRSt_Caracteristicas.CRSvehinscripcion))
                {
                    ParCRSvehinscripcion.Value = DBNull.Value;
                }
                else
                {
                    ParCRSvehinscripcion.Value = Convert.ToDateTime(acfCRSt_Caracteristicas.CRSvehinscripcion);
                }
                SqlCmd.Parameters.Add(ParCRSvehinscripcion);
                //
                SqlParameter ParCRSvehclase = new SqlParameter();
                ParCRSvehclase.ParameterName = "@sCRSvehclase";
                ParCRSvehclase.SqlDbType = SqlDbType.VarChar;
                ParCRSvehclase.Value = acfCRSt_Caracteristicas.CRSvehclase;
                SqlCmd.Parameters.Add(ParCRSvehclase);
                //
                SqlParameter ParCRSvehcombustible = new SqlParameter();
                ParCRSvehcombustible.ParameterName = "@sCRSvehcombustible";
                ParCRSvehcombustible.SqlDbType = SqlDbType.VarChar;
                ParCRSvehcombustible.Value = acfCRSt_Caracteristicas.CRSvehcombustible;
                SqlCmd.Parameters.Add(ParCRSvehcombustible);
                //
                SqlParameter ParCRSvehejes = new SqlParameter();
                ParCRSvehejes.ParameterName = "@iCRSvehejes";
                ParCRSvehejes.SqlDbType = SqlDbType.Int;
                ParCRSvehejes.Value = Convert.ToInt32(acfCRSt_Caracteristicas.CRSvehejes);
                SqlCmd.Parameters.Add(ParCRSvehejes);
                //
                SqlParameter ParCRSvehpasajeros = new SqlParameter();
                ParCRSvehpasajeros.ParameterName = "@iCRSvehpasajeros";
                ParCRSvehpasajeros.SqlDbType = SqlDbType.Int;
                ParCRSvehpasajeros.Value = Convert.ToInt32(acfCRSt_Caracteristicas.CRSvehpasajeros);
                SqlCmd.Parameters.Add(ParCRSvehpasajeros);
                //
                SqlParameter ParCRSvehasientos = new SqlParameter();
                ParCRSvehasientos.ParameterName = "@iCRSvehasientos";
                ParCRSvehasientos.SqlDbType = SqlDbType.Int;
                ParCRSvehasientos.Value = Convert.ToInt32(acfCRSt_Caracteristicas.CRSvehasientos);
                SqlCmd.Parameters.Add(ParCRSvehasientos);
                //
                SqlParameter ParCRSvehpesoseco = new SqlParameter();
                ParCRSvehpesoseco.ParameterName = "@decCRSvehpesoseco";
                ParCRSvehpesoseco.SqlDbType = SqlDbType.Decimal;
                ParCRSvehpesoseco.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSvehpesoseco);
                SqlCmd.Parameters.Add(ParCRSvehpesoseco);
                //
                SqlParameter ParCRSvehcargautil = new SqlParameter();
                ParCRSvehcargautil.ParameterName = "@decCRSvehcargautil";
                ParCRSvehcargautil.SqlDbType = SqlDbType.Decimal;
                ParCRSvehcargautil.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSvehcargautil);
                SqlCmd.Parameters.Add(ParCRSvehcargautil);
                //
                SqlParameter ParCRSaltura = new SqlParameter();
                ParCRSaltura.ParameterName = "@decCRSaltura";
                ParCRSaltura.SqlDbType = SqlDbType.Decimal;
                ParCRSaltura.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSaltura);
                SqlCmd.Parameters.Add(ParCRSaltura);
                //
                SqlParameter ParCRSancho = new SqlParameter();
                ParCRSancho.ParameterName = "@decCRSancho";
                ParCRSancho.SqlDbType = SqlDbType.Decimal;
                ParCRSancho.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSancho);
                SqlCmd.Parameters.Add(ParCRSancho);
                //
                SqlParameter ParCRSvelocidad = new SqlParameter();
                ParCRSvelocidad.ParameterName = "@sCRSvelocidad";
                ParCRSvelocidad.SqlDbType = SqlDbType.VarChar;
                ParCRSvelocidad.Value = acfCRSt_Caracteristicas.CRSvelocidad;
                SqlCmd.Parameters.Add(ParCRSvelocidad);
                //
                SqlParameter ParCRSresolucion = new SqlParameter();
                ParCRSresolucion.ParameterName = "@sCRSresolucion";
                ParCRSresolucion.SqlDbType = SqlDbType.VarChar;
                ParCRSresolucion.Value = acfCRSt_Caracteristicas.CRSresolucion;
                SqlCmd.Parameters.Add(ParCRSresolucion);
                //
                SqlParameter ParCRScapacidad = new SqlParameter();
                ParCRScapacidad.ParameterName = "@sCRScapacidad";
                ParCRScapacidad.SqlDbType = SqlDbType.VarChar;
                ParCRScapacidad.Value = acfCRSt_Caracteristicas.CRScapacidad;
                SqlCmd.Parameters.Add(ParCRScapacidad);
                //
                SqlParameter ParCRSpotencia = new SqlParameter();
                ParCRSpotencia.ParameterName = "@sCRSpotencia";
                ParCRSpotencia.SqlDbType = SqlDbType.VarChar;
                ParCRSpotencia.Value = acfCRSt_Caracteristicas.CRSpotencia;
                SqlCmd.Parameters.Add(ParCRSpotencia);
                //
                SqlParameter ParCRSvnominal = new SqlParameter();
                ParCRSvnominal.ParameterName = "@sCRSvnominal";
                ParCRSvnominal.SqlDbType = SqlDbType.VarChar;
                ParCRSvnominal.Value = acfCRSt_Caracteristicas.CRSvnominal;
                SqlCmd.Parameters.Add(ParCRSvnominal);
                //
                SqlParameter ParCRSventrada = new SqlParameter();
                ParCRSventrada.ParameterName = "@sCRSventrada";
                ParCRSventrada.SqlDbType = SqlDbType.VarChar;
                ParCRSventrada.Value = acfCRSt_Caracteristicas.CRSventrada;
                SqlCmd.Parameters.Add(ParCRSventrada);
                //
                SqlParameter ParCRSvsalida = new SqlParameter();
                ParCRSvsalida.ParameterName = "@sCRSvsalida";
                ParCRSvsalida.SqlDbType = SqlDbType.VarChar;
                ParCRSvsalida.Value = acfCRSt_Caracteristicas.CRSvsalida;
                SqlCmd.Parameters.Add(ParCRSvsalida);
                //
                SqlParameter ParCRSfrecuencia = new SqlParameter();
                ParCRSfrecuencia.ParameterName = "@sCRSfrecuencia";
                ParCRSfrecuencia.SqlDbType = SqlDbType.VarChar;
                ParCRSfrecuencia.Value = acfCRSt_Caracteristicas.CRSfrecuencia;
                SqlCmd.Parameters.Add(ParCRSfrecuencia);
                //
                SqlParameter ParCRStemperatura = new SqlParameter();
                ParCRStemperatura.ParameterName = "@sCRStemperatura";
                ParCRStemperatura.SqlDbType = SqlDbType.VarChar;
                ParCRStemperatura.Value = acfCRSt_Caracteristicas.CRStemperatura;
                SqlCmd.Parameters.Add(ParCRStemperatura);
                //
                SqlParameter ParCRSprocesador = new SqlParameter();
                ParCRSprocesador.ParameterName = "@sCRSprocesador";
                ParCRSprocesador.SqlDbType = SqlDbType.VarChar;
                ParCRSprocesador.Value = acfCRSt_Caracteristicas.CRSprocesador;
                SqlCmd.Parameters.Add(ParCRSprocesador);
                //
                SqlParameter ParCRSpuertos = new SqlParameter();
                ParCRSpuertos.ParameterName = "@sCRSpuertos";
                ParCRSpuertos.SqlDbType = SqlDbType.VarChar;
                ParCRSpuertos.Value = acfCRSt_Caracteristicas.CRSpuertos;
                SqlCmd.Parameters.Add(ParCRSpuertos);
                //
                SqlParameter ParCRSutmx = new SqlParameter();
                ParCRSutmx.ParameterName = "@decCRSutmx";
                ParCRSutmx.SqlDbType = SqlDbType.Decimal;
                ParCRSutmx.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSutmx);
                SqlCmd.Parameters.Add(ParCRSutmx);
                //
                SqlParameter ParCRSutmy = new SqlParameter();
                ParCRSutmy.ParameterName = "@decCRSutmy";
                ParCRSutmy.SqlDbType = SqlDbType.Decimal;
                ParCRSutmy.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSutmy);
                SqlCmd.Parameters.Add(ParCRSutmy);
                //
                SqlParameter ParCRSesfuerzopunta = new SqlParameter();
                ParCRSesfuerzopunta.ParameterName = "@sCRSesfuerzopunta";
                ParCRSesfuerzopunta.SqlDbType = SqlDbType.VarChar;
                ParCRSesfuerzopunta.Value = acfCRSt_Caracteristicas.CRSesfuerzopunta;
                SqlCmd.Parameters.Add(ParCRSesfuerzopunta);
                //
                SqlParameter ParCRScajaderivadora = new SqlParameter();
                ParCRScajaderivadora.ParameterName = "@sCRScajaderivadora";
                ParCRScajaderivadora.SqlDbType = SqlDbType.VarChar;
                ParCRScajaderivadora.Value = acfCRSt_Caracteristicas.CRScajaderivadora;
                SqlCmd.Parameters.Add(ParCRScajaderivadora);
                //
                SqlParameter ParCRSalquilacable = new SqlParameter();
                ParCRSalquilacable.ParameterName = "@sCRSalquilacable";
                ParCRSalquilacable.SqlDbType = SqlDbType.Char;
                ParCRSalquilacable.Value = acfCRSt_Caracteristicas.CRSalquilacable;
                SqlCmd.Parameters.Add(ParCRSalquilacable);
                //
                SqlParameter ParCRScentropoblado = new SqlParameter();
                ParCRScentropoblado.ParameterName = "@sCRScentropoblado";
                ParCRScentropoblado.SqlDbType = SqlDbType.VarChar;
                ParCRScentropoblado.Value = acfCRSt_Caracteristicas.CRScentropoblado;
                SqlCmd.Parameters.Add(ParCRScentropoblado);
                //
                SqlParameter ParCRSurbanizacion = new SqlParameter();
                ParCRSurbanizacion.ParameterName = "@sCRSurbanizacion";
                ParCRSurbanizacion.SqlDbType = SqlDbType.VarChar;
                ParCRSurbanizacion.Value = acfCRSt_Caracteristicas.CRSurbanizacion;
                SqlCmd.Parameters.Add(ParCRSurbanizacion);
                //
                SqlParameter ParCRScalle = new SqlParameter();
                ParCRScalle.ParameterName = "@sCRScalle";
                ParCRScalle.SqlDbType = SqlDbType.VarChar;
                ParCRScalle.Value = acfCRSt_Caracteristicas.CRScalle;
                SqlCmd.Parameters.Add(ParCRScalle);
                //
                SqlParameter ParCRSlote = new SqlParameter();
                ParCRSlote.ParameterName = "@sCRSlote";
                ParCRSlote.SqlDbType = SqlDbType.VarChar;
                ParCRSlote.Value = acfCRSt_Caracteristicas.CRSlote;
                SqlCmd.Parameters.Add(ParCRSlote);
                //
                SqlParameter ParCRSnumeropredio = new SqlParameter();
                ParCRSnumeropredio.ParameterName = "@sCRSnumeropredio";
                ParCRSnumeropredio.SqlDbType = SqlDbType.VarChar;
                ParCRSnumeropredio.Value = acfCRSt_Caracteristicas.CRSnumeropredio;
                SqlCmd.Parameters.Add(ParCRSnumeropredio);
                //
                SqlParameter ParCRSdepartamento = new SqlParameter();
                ParCRSdepartamento.ParameterName = "@sCRSdepartamento";
                ParCRSdepartamento.SqlDbType = SqlDbType.VarChar;
                ParCRSdepartamento.Value = acfCRSt_Caracteristicas.CRSdepartamento;
                SqlCmd.Parameters.Add(ParCRSdepartamento);
                //
                SqlParameter ParCRSinterior = new SqlParameter();
                ParCRSinterior.ParameterName = "@sCRSinterior";
                ParCRSinterior.SqlDbType = SqlDbType.VarChar;
                ParCRSinterior.Value = acfCRSt_Caracteristicas.CRSinterior;
                SqlCmd.Parameters.Add(ParCRSinterior);
                //
                SqlParameter ParCRScarretera = new SqlParameter();
                ParCRScarretera.ParameterName = "@sCRScarretera";
                ParCRScarretera.SqlDbType = SqlDbType.VarChar;
                ParCRScarretera.Value = acfCRSt_Caracteristicas.CRScarretera;
                SqlCmd.Parameters.Add(ParCRScarretera);
                //
                SqlParameter ParCRSkilometro = new SqlParameter();
                ParCRSkilometro.ParameterName = "@decCRSkilometro";
                ParCRSkilometro.SqlDbType = SqlDbType.Decimal;
                ParCRSkilometro.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSkilometro);
                SqlCmd.Parameters.Add(ParCRSkilometro);
                //
                SqlParameter ParCRSnombrepredio = new SqlParameter();
                ParCRSnombrepredio.ParameterName = "@sCRSnombrepredio";
                ParCRSnombrepredio.SqlDbType = SqlDbType.VarChar;
                ParCRSnombrepredio.Value = acfCRSt_Caracteristicas.CRSnombrepredio;
                SqlCmd.Parameters.Add(ParCRSnombrepredio);
                //
                SqlParameter ParCRSpisospredio = new SqlParameter();
                ParCRSpisospredio.ParameterName = "@iCRSpisospredio";
                ParCRSpisospredio.SqlDbType = SqlDbType.Int;
                ParCRSpisospredio.Value = Convert.ToInt32(acfCRSt_Caracteristicas.CRSpisospredio);
                SqlCmd.Parameters.Add(ParCRSpisospredio);
                //
                SqlParameter ParCRSpartidapredio = new SqlParameter();
                ParCRSpartidapredio.ParameterName = "@sCRSpartidapredio";
                ParCRSpartidapredio.SqlDbType = SqlDbType.VarChar;
                ParCRSpartidapredio.Value = acfCRSt_Caracteristicas.CRSpartidapredio;
                SqlCmd.Parameters.Add(ParCRSpartidapredio);
                //
                SqlParameter ParCRStomopredio = new SqlParameter();
                ParCRStomopredio.ParameterName = "@sCRStomopredio";
                ParCRStomopredio.SqlDbType = SqlDbType.VarChar;
                ParCRStomopredio.Value = acfCRSt_Caracteristicas.CRStomopredio;
                SqlCmd.Parameters.Add(ParCRStomopredio);
                //
                SqlParameter ParCRSfolioinipredio = new SqlParameter();
                ParCRSfolioinipredio.ParameterName = "@sCRSfolioinipredio";
                ParCRSfolioinipredio.SqlDbType = SqlDbType.VarChar;
                ParCRSfolioinipredio.Value = acfCRSt_Caracteristicas.CRSfolioinipredio;
                SqlCmd.Parameters.Add(ParCRSfolioinipredio);
                //
                SqlParameter ParCRSfoliofinpredio = new SqlParameter();
                ParCRSfoliofinpredio.ParameterName = "@sCRSfoliofinpredio";
                ParCRSfoliofinpredio.SqlDbType = SqlDbType.VarChar;
                ParCRSfoliofinpredio.Value = acfCRSt_Caracteristicas.CRSfoliofinpredio;
                SqlCmd.Parameters.Add(ParCRSfoliofinpredio);
                //
                SqlParameter ParCRSasientopredio = new SqlParameter();
                ParCRSasientopredio.ParameterName = "@sCRSasientopredio";
                ParCRSasientopredio.SqlDbType = SqlDbType.VarChar;
                ParCRSasientopredio.Value = acfCRSt_Caracteristicas.CRSasientopredio;
                SqlCmd.Parameters.Add(ParCRSasientopredio);
                //
                SqlParameter ParCRSfinscpredio = new SqlParameter();
                ParCRSfinscpredio.ParameterName = "@dtCRSfinscpredio";
                ParCRSfinscpredio.SqlDbType = SqlDbType.DateTime;
                if (string.IsNullOrWhiteSpace(acfCRSt_Caracteristicas.CRSfinscpredio))
                {
                    ParCRSfinscpredio.Value = DBNull.Value;
                }
                else
                {
                    ParCRSfinscpredio.Value = Convert.ToDateTime(acfCRSt_Caracteristicas.CRSfinscpredio);
                }
                SqlCmd.Parameters.Add(ParCRSfinscpredio);
                //
                SqlParameter ParCRSficharegistral = new SqlParameter();
                ParCRSficharegistral.ParameterName = "@sCRSficharegistral";
                ParCRSficharegistral.SqlDbType = SqlDbType.VarChar;
                ParCRSficharegistral.Value = acfCRSt_Caracteristicas.CRSficharegistral;
                SqlCmd.Parameters.Add(ParCRSficharegistral);
                //
                SqlParameter ParCRSareaconstruida = new SqlParameter();
                ParCRSareaconstruida.ParameterName = "@decCRSareaconstruida";
                ParCRSareaconstruida.SqlDbType = SqlDbType.Decimal;
                ParCRSareaconstruida.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSareaconstruida);
                SqlCmd.Parameters.Add(ParCRSareaconstruida);
                //
                SqlParameter ParCRSperimetro = new SqlParameter();
                ParCRSperimetro.ParameterName = "@decCRSperimetro";
                ParCRSperimetro.SqlDbType = SqlDbType.Decimal;
                ParCRSperimetro.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSperimetro);
                SqlCmd.Parameters.Add(ParCRSperimetro);
                //
                SqlParameter ParCRSusopredio = new SqlParameter();
                ParCRSusopredio.ParameterName = "@sCRSusopredio";
                ParCRSusopredio.SqlDbType = SqlDbType.VarChar;
                ParCRSusopredio.Value = acfCRSt_Caracteristicas.CRSusopredio;
                SqlCmd.Parameters.Add(ParCRSusopredio);
                //
                SqlParameter ParCRSvalorautovaluo = new SqlParameter();
                ParCRSvalorautovaluo.ParameterName = "@decCRSvalorautovaluo";
                ParCRSvalorautovaluo.SqlDbType = SqlDbType.Decimal;
                ParCRSvalorautovaluo.Value = Convert.ToDecimal(acfCRSt_Caracteristicas.CRSvalorautovaluo);
                SqlCmd.Parameters.Add(ParCRSvalorautovaluo);
                //
                SqlParameter ParCRScodigoluz = new SqlParameter();
                ParCRScodigoluz.ParameterName = "@sCRScodigoluz";
                ParCRScodigoluz.SqlDbType = SqlDbType.VarChar;
                ParCRScodigoluz.Value = acfCRSt_Caracteristicas.CRScodigoluz;
                SqlCmd.Parameters.Add(ParCRScodigoluz);
                //
                SqlParameter ParCRScodigoagua = new SqlParameter();
                ParCRScodigoagua.ParameterName = "@sCRScodigoagua";
                ParCRScodigoagua.SqlDbType = SqlDbType.VarChar;
                ParCRScodigoagua.Value = acfCRSt_Caracteristicas.CRScodigoagua;
                SqlCmd.Parameters.Add(ParCRScodigoagua);
                //
                SqlParameter ParCRSfadqpredio = new SqlParameter();
                ParCRSfadqpredio.ParameterName = "@dtCRSfadqpredio";
                ParCRSfadqpredio.SqlDbType = SqlDbType.DateTime;
                if (string.IsNullOrWhiteSpace(acfCRSt_Caracteristicas.CRSfadqpredio))
                {
                    ParCRSfadqpredio.Value = DBNull.Value;
                }
                else
                {
                    ParCRSfadqpredio.Value = Convert.ToDateTime(acfCRSt_Caracteristicas.CRSfadqpredio);
                }
                SqlCmd.Parameters.Add(ParCRSfadqpredio);
                //
                SqlParameter ParCRSobservacion = new SqlParameter();
                ParCRSobservacion.ParameterName = "@sCRSobservacion";
                ParCRSobservacion.SqlDbType = SqlDbType.VarChar;
                ParCRSobservacion.Value = acfCRSt_Caracteristicas.CRSobservacion;
                SqlCmd.Parameters.Add(ParCRSobservacion);
                //
                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Elimino el Registro";



            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        //METODO Editar Sustitucion Mejora
        public string EditarSustitucionMejora(DacfCRSt_Caracteristicas acfCRSt_Caracteristicas)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_U_acfCRSt_Caracteristicas_SustitucionMejora";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@iACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Value = acfCRSt_Caracteristicas.ACFid;
                SqlCmd.Parameters.Add(ParACFid);
                //
                SqlParameter ParMARid = new SqlParameter();
                ParMARid.ParameterName = "@iMARid";
                ParMARid.SqlDbType = SqlDbType.Int;
                ParMARid.Value = acfCRSt_Caracteristicas.MARid;
                SqlCmd.Parameters.Add(ParMARid);
                //
                SqlParameter ParCRSserie = new SqlParameter();
                ParCRSserie.ParameterName = "@sCRSserie";
                ParCRSserie.SqlDbType = SqlDbType.VarChar;
                ParCRSserie.Value = acfCRSt_Caracteristicas.CRSserie;
                SqlCmd.Parameters.Add(ParCRSserie);
                //
                SqlParameter ParCRSmodelo = new SqlParameter();
                ParCRSmodelo.ParameterName = "@sCRSmodelo";
                ParCRSmodelo.SqlDbType = SqlDbType.VarChar;
                ParCRSmodelo.Value = acfCRSt_Caracteristicas.CRSmodelo;
                SqlCmd.Parameters.Add(ParCRSmodelo);
                //
                SqlParameter ParCRScolor = new SqlParameter();
                ParCRScolor.ParameterName = "@sCRScolor";
                ParCRScolor.SqlDbType = SqlDbType.VarChar;
                ParCRScolor.Value = acfCRSt_Caracteristicas.CRScolor;
                SqlCmd.Parameters.Add(ParCRScolor);
                //
                SqlParameter ParCRSresolucion = new SqlParameter();
                ParCRSresolucion.ParameterName = "@sCRSresolucion";
                ParCRSresolucion.SqlDbType = SqlDbType.VarChar;
                ParCRSresolucion.Value = acfCRSt_Caracteristicas.CRSresolucion;
                SqlCmd.Parameters.Add(ParCRSresolucion);
                //
                SqlParameter ParCRScapacidad = new SqlParameter();
                ParCRScapacidad.ParameterName = "@sCRScapacidad";
                ParCRScapacidad.SqlDbType = SqlDbType.VarChar;
                ParCRScapacidad.Value = acfCRSt_Caracteristicas.CRScapacidad;
                SqlCmd.Parameters.Add(ParCRScapacidad);
                //
                SqlParameter ParCRSpotencia = new SqlParameter();
                ParCRSpotencia.ParameterName = "@sCRSpotencia";
                ParCRSpotencia.SqlDbType = SqlDbType.VarChar;
                ParCRSpotencia.Value = acfCRSt_Caracteristicas.CRSpotencia;
                SqlCmd.Parameters.Add(ParCRSpotencia);
                //
                SqlParameter ParCRSvnominal = new SqlParameter();
                ParCRSvnominal.ParameterName = "@sCRSvnominal";
                ParCRSvnominal.SqlDbType = SqlDbType.VarChar;
                ParCRSvnominal.Value = acfCRSt_Caracteristicas.CRSvnominal;
                SqlCmd.Parameters.Add(ParCRSvnominal);
                //
                SqlParameter ParCRSventrada = new SqlParameter();
                ParCRSventrada.ParameterName = "@sCRSventrada";
                ParCRSventrada.SqlDbType = SqlDbType.VarChar;
                ParCRSventrada.Value = acfCRSt_Caracteristicas.CRSventrada;
                SqlCmd.Parameters.Add(ParCRSventrada);
                //
                SqlParameter ParCRSvsalida = new SqlParameter();
                ParCRSvsalida.ParameterName = "@sCRSvsalida";
                ParCRSvsalida.SqlDbType = SqlDbType.VarChar;
                ParCRSvsalida.Value = acfCRSt_Caracteristicas.CRSvsalida;
                SqlCmd.Parameters.Add(ParCRSvsalida);
                //
                SqlParameter ParCRSfrecuencia = new SqlParameter();
                ParCRSfrecuencia.ParameterName = "@sCRSfrecuencia";
                ParCRSfrecuencia.SqlDbType = SqlDbType.VarChar;
                ParCRSfrecuencia.Value = acfCRSt_Caracteristicas.CRSfrecuencia;
                SqlCmd.Parameters.Add(ParCRSfrecuencia);
                //
                SqlParameter ParCRStemperatura = new SqlParameter();
                ParCRStemperatura.ParameterName = "@sCRStemperatura";
                ParCRStemperatura.SqlDbType = SqlDbType.VarChar;
                ParCRStemperatura.Value = acfCRSt_Caracteristicas.CRStemperatura;
                SqlCmd.Parameters.Add(ParCRStemperatura);
                //
                SqlParameter ParCRSprocesador = new SqlParameter();
                ParCRSprocesador.ParameterName = "@sCRSprocesador";
                ParCRSprocesador.SqlDbType = SqlDbType.VarChar;
                ParCRSprocesador.Value = acfCRSt_Caracteristicas.CRSprocesador;
                SqlCmd.Parameters.Add(ParCRSprocesador);
                //
                SqlParameter ParCRSpuertos = new SqlParameter();
                ParCRSpuertos.ParameterName = "@sCRSpuertos";
                ParCRSpuertos.SqlDbType = SqlDbType.VarChar;
                ParCRSpuertos.Value = acfCRSt_Caracteristicas.CRSpuertos;
                SqlCmd.Parameters.Add(ParCRSpuertos);
                //
                SqlParameter ParCRSobservacion = new SqlParameter();
                ParCRSobservacion.ParameterName = "@sCRSobservacion";
                ParCRSobservacion.SqlDbType = SqlDbType.VarChar;
                ParCRSobservacion.Value = acfCRSt_Caracteristicas.CRSobservacion;
                SqlCmd.Parameters.Add(ParCRSobservacion);
                //
                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Actualizo el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }


        //METODO ELIMINAR
        public string Eliminar(DacfCRSt_Caracteristicas acfCRSt_Caracteristicas) {
		
			string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_D_acfCRSt_Caracteristicas";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@iACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Value = acfCRSt_Caracteristicas.ACFid;
                SqlCmd.Parameters.Add(ParACFid);
                //

                 //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Elimino el Registro";


		}
		catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
	}


    //METODO BUSCAR

	public DataTable Buscar(string ACFid) {

        DataTable DtResultado = new DataTable("acfCRSt_Caracteristicas");
            SqlConnection SqlCon = new SqlConnection();


		try {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_acfCRSt_Caracteristicas";
            SqlCmd.CommandType = CommandType.StoredProcedure;



            SqlParameter ParCRSserie = new SqlParameter();
            ParCRSserie.ParameterName = "@iACFid";
            ParCRSserie.SqlDbType = SqlDbType.Char;
            ParCRSserie.Size = 10;
            ParCRSserie.Value = Convert.ToInt32(ACFid);
            SqlCmd.Parameters.Add(ParCRSserie);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

		}
        catch (Exception ex)
        {
            DtResultado = null;
        }
        return DtResultado;

	}

}
}
