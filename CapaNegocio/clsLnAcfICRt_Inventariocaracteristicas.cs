using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfICRt_Inventariocaracteristicas {

	private ConnectionManager oConexion = null;

	 public clsLnAcfICRt_Inventariocaracteristicas(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfICRt_Inventariocaracteristicas, ref DataRow dr) {
		try {
				oBeAcfICRt_Inventariocaracteristicas.MARid = ( IsDBNull(dr.Item['MARid']) ? 0 : dr.Item['MARid'] )
				oBeAcfICRt_Inventariocaracteristicas.ESTid = ( IsDBNull(dr.Item['ESTid']) ? 0 : dr.Item['ESTid'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSserie = ( IsDBNull(dr.Item['CRSserie']) ? '' : dr.Item['CRSserie'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSmodelo = ( IsDBNull(dr.Item['CRSmodelo']) ? '' : dr.Item['CRSmodelo'] )
				oBeAcfICRt_Inventariocaracteristicas.CRScolor = ( IsDBNull(dr.Item['CRScolor']) ? '' : dr.Item['CRScolor'] )
				oBeAcfICRt_Inventariocaracteristicas.MATid = ( IsDBNull(dr.Item['MATid']) ? 0 : dr.Item['MATid'] )
				oBeAcfICRt_Inventariocaracteristicas.CRStipo = ( IsDBNull(dr.Item['CRStipo']) ? '' : dr.Item['CRStipo'] )
				oBeAcfICRt_Inventariocaracteristicas.UNMid = ( IsDBNull(dr.Item['UNMid']) ? 0 : dr.Item['UNMid'] )
				oBeAcfICRt_Inventariocaracteristicas.CRScantidad = ( IsDBNull(dr.Item['CRScantidad']) ? 0.0 : dr.Item['CRScantidad'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSvehplaca = ( IsDBNull(dr.Item['CRSvehplaca']) ? '' : dr.Item['CRSvehplaca'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSvehexpediente = ( IsDBNull(dr.Item['CRSvehexpediente']) ? '' : dr.Item['CRSvehexpediente'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSvehinscripcion = ( IsDBNull(dr.Item['CRSvehinscripcion']) ? Date.Now() : dr.Item['CRSvehinscripcion'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSvehclase = ( IsDBNull(dr.Item['CRSvehclase']) ? '' : dr.Item['CRSvehclase'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSvehcombustible = ( IsDBNull(dr.Item['CRSvehcombustible']) ? '' : dr.Item['CRSvehcombustible'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSvehejes = ( IsDBNull(dr.Item['CRSvehejes']) ? 0 : dr.Item['CRSvehejes'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSvehpasajeros = ( IsDBNull(dr.Item['CRSvehpasajeros']) ? 0 : dr.Item['CRSvehpasajeros'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSvehasientos = ( IsDBNull(dr.Item['CRSvehasientos']) ? 0 : dr.Item['CRSvehasientos'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSvehpesoseco = ( IsDBNull(dr.Item['CRSvehpesoseco']) ? 0.0 : dr.Item['CRSvehpesoseco'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSvehcargautil = ( IsDBNull(dr.Item['CRSvehcargautil']) ? 0.0 : dr.Item['CRSvehcargautil'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSaltura = ( IsDBNull(dr.Item['CRSaltura']) ? 0.0 : dr.Item['CRSaltura'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSancho = ( IsDBNull(dr.Item['CRSancho']) ? 0.0 : dr.Item['CRSancho'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSvelocidad = ( IsDBNull(dr.Item['CRSvelocidad']) ? '' : dr.Item['CRSvelocidad'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSresolucion = ( IsDBNull(dr.Item['CRSresolucion']) ? '' : dr.Item['CRSresolucion'] )
				oBeAcfICRt_Inventariocaracteristicas.CRScapacidad = ( IsDBNull(dr.Item['CRScapacidad']) ? '' : dr.Item['CRScapacidad'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSpotencia = ( IsDBNull(dr.Item['CRSpotencia']) ? '' : dr.Item['CRSpotencia'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSvnominal = ( IsDBNull(dr.Item['CRSvnominal']) ? '' : dr.Item['CRSvnominal'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSventrada = ( IsDBNull(dr.Item['CRSventrada']) ? '' : dr.Item['CRSventrada'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSvsalida = ( IsDBNull(dr.Item['CRSvsalida']) ? '' : dr.Item['CRSvsalida'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSfrecuencia = ( IsDBNull(dr.Item['CRSfrecuencia']) ? '' : dr.Item['CRSfrecuencia'] )
				oBeAcfICRt_Inventariocaracteristicas.CRStemperatura = ( IsDBNull(dr.Item['CRStemperatura']) ? '' : dr.Item['CRStemperatura'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSprocesador = ( IsDBNull(dr.Item['CRSprocesador']) ? '' : dr.Item['CRSprocesador'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSpuertos = ( IsDBNull(dr.Item['CRSpuertos']) ? '' : dr.Item['CRSpuertos'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSutmx = ( IsDBNull(dr.Item['CRSutmx']) ? 0.0 : dr.Item['CRSutmx'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSutmy = ( IsDBNull(dr.Item['CRSutmy']) ? 0.0 : dr.Item['CRSutmy'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSesfuerzopunta = ( IsDBNull(dr.Item['CRSesfuerzopunta']) ? '' : dr.Item['CRSesfuerzopunta'] )
				oBeAcfICRt_Inventariocaracteristicas.CRScajaderivadora = ( IsDBNull(dr.Item['CRScajaderivadora']) ? '' : dr.Item['CRScajaderivadora'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSalquilacable = ( IsDBNull(dr.Item['CRSalquilacable']) ? '' : dr.Item['CRSalquilacable'] )
				oBeAcfICRt_Inventariocaracteristicas.CRScentropoblado = ( IsDBNull(dr.Item['CRScentropoblado']) ? '' : dr.Item['CRScentropoblado'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSurbanizacion = ( IsDBNull(dr.Item['CRSurbanizacion']) ? '' : dr.Item['CRSurbanizacion'] )
				oBeAcfICRt_Inventariocaracteristicas.CRScalle = ( IsDBNull(dr.Item['CRScalle']) ? '' : dr.Item['CRScalle'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSlote = ( IsDBNull(dr.Item['CRSlote']) ? '' : dr.Item['CRSlote'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSnumeropredio = ( IsDBNull(dr.Item['CRSnumeropredio']) ? '' : dr.Item['CRSnumeropredio'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSdepartamento = ( IsDBNull(dr.Item['CRSdepartamento']) ? '' : dr.Item['CRSdepartamento'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSinterior = ( IsDBNull(dr.Item['CRSinterior']) ? '' : dr.Item['CRSinterior'] )
				oBeAcfICRt_Inventariocaracteristicas.CRScarretera = ( IsDBNull(dr.Item['CRScarretera']) ? '' : dr.Item['CRScarretera'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSkilometro = ( IsDBNull(dr.Item['CRSkilometro']) ? 0.0 : dr.Item['CRSkilometro'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSnombrepredio = ( IsDBNull(dr.Item['CRSnombrepredio']) ? '' : dr.Item['CRSnombrepredio'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSpisospredio = ( IsDBNull(dr.Item['CRSpisospredio']) ? 0 : dr.Item['CRSpisospredio'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSpartidapredio = ( IsDBNull(dr.Item['CRSpartidapredio']) ? '' : dr.Item['CRSpartidapredio'] )
				oBeAcfICRt_Inventariocaracteristicas.CRStomopredio = ( IsDBNull(dr.Item['CRStomopredio']) ? '' : dr.Item['CRStomopredio'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSfolioinipredio = ( IsDBNull(dr.Item['CRSfolioinipredio']) ? '' : dr.Item['CRSfolioinipredio'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSfoliofinpredio = ( IsDBNull(dr.Item['CRSfoliofinpredio']) ? '' : dr.Item['CRSfoliofinpredio'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSasientopredio = ( IsDBNull(dr.Item['CRSasientopredio']) ? '' : dr.Item['CRSasientopredio'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSfinscpredio = ( IsDBNull(dr.Item['CRSfinscpredio']) ? Date.Now() : dr.Item['CRSfinscpredio'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSficharegistral = ( IsDBNull(dr.Item['CRSficharegistral']) ? '' : dr.Item['CRSficharegistral'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSareaconstruida = ( IsDBNull(dr.Item['CRSareaconstruida']) ? 0.0 : dr.Item['CRSareaconstruida'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSperimetro = ( IsDBNull(dr.Item['CRSperimetro']) ? 0.0 : dr.Item['CRSperimetro'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSusopredio = ( IsDBNull(dr.Item['CRSusopredio']) ? '' : dr.Item['CRSusopredio'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSvalorautovaluo = ( IsDBNull(dr.Item['CRSvalorautovaluo']) ? 0.0 : dr.Item['CRSvalorautovaluo'] )
				oBeAcfICRt_Inventariocaracteristicas.CRScodigoluz = ( IsDBNull(dr.Item['CRScodigoluz']) ? '' : dr.Item['CRScodigoluz'] )
				oBeAcfICRt_Inventariocaracteristicas.CRScodigoagua = ( IsDBNull(dr.Item['CRScodigoagua']) ? '' : dr.Item['CRScodigoagua'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSfadqpredio = ( IsDBNull(dr.Item['CRSfadqpredio']) ? Date.Now() : dr.Item['CRSfadqpredio'] )
				oBeAcfICRt_Inventariocaracteristicas.CRSobservacion = ( IsDBNull(dr.Item['CRSobservacion']) ? '' : dr.Item['CRSobservacion'] )
				oBeAcfICRt_Inventariocaracteristicas.INVid = ( IsDBNull(dr.Item['INVid']) ? 0 : dr.Item['INVid'] )
				oBeAcfICRt_Inventariocaracteristicas.ACFid = ( IsDBNull(dr.Item['ACFid']) ? 0 : dr.Item['ACFid'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfICRt_Inventariocaracteristicas oBeAcfICRt_Inventariocaracteristicas) {
		try {
			string sp = 'SpAcfICRt_InventariocaracteristicasInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MARID", oBeAcfICRt_Inventariocaracteristicas.MARid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ESTID", oBeAcfICRt_Inventariocaracteristicas.ESTid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSSERIE", oBeAcfICRt_Inventariocaracteristicas.CRSserie));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSMODELO", oBeAcfICRt_Inventariocaracteristicas.CRSmodelo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCOLOR", oBeAcfICRt_Inventariocaracteristicas.CRScolor));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MATID", oBeAcfICRt_Inventariocaracteristicas.MATid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSTIPO", oBeAcfICRt_Inventariocaracteristicas.CRStipo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UNMID", oBeAcfICRt_Inventariocaracteristicas.UNMid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCANTIDAD", oBeAcfICRt_Inventariocaracteristicas.CRScantidad));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHPLACA", oBeAcfICRt_Inventariocaracteristicas.CRSvehplaca));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHEXPEDIENTE", oBeAcfICRt_Inventariocaracteristicas.CRSvehexpediente));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHINSCRIPCION", oBeAcfICRt_Inventariocaracteristicas.CRSvehinscripcion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHCLASE", oBeAcfICRt_Inventariocaracteristicas.CRSvehclase));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHCOMBUSTIBLE", oBeAcfICRt_Inventariocaracteristicas.CRSvehcombustible));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHEJES", oBeAcfICRt_Inventariocaracteristicas.CRSvehejes));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHPASAJEROS", oBeAcfICRt_Inventariocaracteristicas.CRSvehpasajeros));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHASIENTOS", oBeAcfICRt_Inventariocaracteristicas.CRSvehasientos));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHPESOSECO", oBeAcfICRt_Inventariocaracteristicas.CRSvehpesoseco));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHCARGAUTIL", oBeAcfICRt_Inventariocaracteristicas.CRSvehcargautil));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSALTURA", oBeAcfICRt_Inventariocaracteristicas.CRSaltura));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSANCHO", oBeAcfICRt_Inventariocaracteristicas.CRSancho));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVELOCIDAD", oBeAcfICRt_Inventariocaracteristicas.CRSvelocidad));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSRESOLUCION", oBeAcfICRt_Inventariocaracteristicas.CRSresolucion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCAPACIDAD", oBeAcfICRt_Inventariocaracteristicas.CRScapacidad));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPOTENCIA", oBeAcfICRt_Inventariocaracteristicas.CRSpotencia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVNOMINAL", oBeAcfICRt_Inventariocaracteristicas.CRSvnominal));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVENTRADA", oBeAcfICRt_Inventariocaracteristicas.CRSventrada));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVSALIDA", oBeAcfICRt_Inventariocaracteristicas.CRSvsalida));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFRECUENCIA", oBeAcfICRt_Inventariocaracteristicas.CRSfrecuencia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSTEMPERATURA", oBeAcfICRt_Inventariocaracteristicas.CRStemperatura));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPROCESADOR", oBeAcfICRt_Inventariocaracteristicas.CRSprocesador));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPUERTOS", oBeAcfICRt_Inventariocaracteristicas.CRSpuertos));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSUTMX", oBeAcfICRt_Inventariocaracteristicas.CRSutmx));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSUTMY", oBeAcfICRt_Inventariocaracteristicas.CRSutmy));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSESFUERZOPUNTA", oBeAcfICRt_Inventariocaracteristicas.CRSesfuerzopunta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCAJADERIVADORA", oBeAcfICRt_Inventariocaracteristicas.CRScajaderivadora));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSALQUILACABLE", oBeAcfICRt_Inventariocaracteristicas.CRSalquilacable));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCENTROPOBLADO", oBeAcfICRt_Inventariocaracteristicas.CRScentropoblado));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSURBANIZACION", oBeAcfICRt_Inventariocaracteristicas.CRSurbanizacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCALLE", oBeAcfICRt_Inventariocaracteristicas.CRScalle));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSLOTE", oBeAcfICRt_Inventariocaracteristicas.CRSlote));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSNUMEROPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRSnumeropredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSDEPARTAMENTO", oBeAcfICRt_Inventariocaracteristicas.CRSdepartamento));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSINTERIOR", oBeAcfICRt_Inventariocaracteristicas.CRSinterior));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCARRETERA", oBeAcfICRt_Inventariocaracteristicas.CRScarretera));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSKILOMETRO", oBeAcfICRt_Inventariocaracteristicas.CRSkilometro));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSNOMBREPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRSnombrepredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPISOSPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRSpisospredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPARTIDAPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRSpartidapredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSTOMOPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRStomopredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFOLIOINIPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRSfolioinipredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFOLIOFINPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRSfoliofinpredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSASIENTOPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRSasientopredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFINSCPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRSfinscpredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFICHAREGISTRAL", oBeAcfICRt_Inventariocaracteristicas.CRSficharegistral));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSAREACONSTRUIDA", oBeAcfICRt_Inventariocaracteristicas.CRSareaconstruida));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPERIMETRO", oBeAcfICRt_Inventariocaracteristicas.CRSperimetro));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSUSOPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRSusopredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVALORAUTOVALUO", oBeAcfICRt_Inventariocaracteristicas.CRSvalorautovaluo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCODIGOLUZ", oBeAcfICRt_Inventariocaracteristicas.CRScodigoluz));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCODIGOAGUA", oBeAcfICRt_Inventariocaracteristicas.CRScodigoagua));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFADQPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRSfadqpredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSOBSERVACION", oBeAcfICRt_Inventariocaracteristicas.CRSobservacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVID", oBeAcfICRt_Inventariocaracteristicas.INVid));
			cmd.Parameters("@INVID").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfICRt_Inventariocaracteristicas.ACFid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfICRt_Inventariocaracteristicas.INVid = int.Parse(cmd.Parameters['@INVID'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfICRt_Inventariocaracteristicas oBeAcfICRt_Inventariocaracteristicas) {
		try {
			string sp = 'SpAcfICRt_InventariocaracteristicasActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MARID", oBeAcfICRt_Inventariocaracteristicas.MARid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ESTID", oBeAcfICRt_Inventariocaracteristicas.ESTid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSSERIE", oBeAcfICRt_Inventariocaracteristicas.CRSserie));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSMODELO", oBeAcfICRt_Inventariocaracteristicas.CRSmodelo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCOLOR", oBeAcfICRt_Inventariocaracteristicas.CRScolor));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MATID", oBeAcfICRt_Inventariocaracteristicas.MATid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSTIPO", oBeAcfICRt_Inventariocaracteristicas.CRStipo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UNMID", oBeAcfICRt_Inventariocaracteristicas.UNMid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCANTIDAD", oBeAcfICRt_Inventariocaracteristicas.CRScantidad));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHPLACA", oBeAcfICRt_Inventariocaracteristicas.CRSvehplaca));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHEXPEDIENTE", oBeAcfICRt_Inventariocaracteristicas.CRSvehexpediente));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHINSCRIPCION", oBeAcfICRt_Inventariocaracteristicas.CRSvehinscripcion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHCLASE", oBeAcfICRt_Inventariocaracteristicas.CRSvehclase));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHCOMBUSTIBLE", oBeAcfICRt_Inventariocaracteristicas.CRSvehcombustible));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHEJES", oBeAcfICRt_Inventariocaracteristicas.CRSvehejes));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHPASAJEROS", oBeAcfICRt_Inventariocaracteristicas.CRSvehpasajeros));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHASIENTOS", oBeAcfICRt_Inventariocaracteristicas.CRSvehasientos));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHPESOSECO", oBeAcfICRt_Inventariocaracteristicas.CRSvehpesoseco));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHCARGAUTIL", oBeAcfICRt_Inventariocaracteristicas.CRSvehcargautil));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSALTURA", oBeAcfICRt_Inventariocaracteristicas.CRSaltura));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSANCHO", oBeAcfICRt_Inventariocaracteristicas.CRSancho));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVELOCIDAD", oBeAcfICRt_Inventariocaracteristicas.CRSvelocidad));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSRESOLUCION", oBeAcfICRt_Inventariocaracteristicas.CRSresolucion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCAPACIDAD", oBeAcfICRt_Inventariocaracteristicas.CRScapacidad));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPOTENCIA", oBeAcfICRt_Inventariocaracteristicas.CRSpotencia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVNOMINAL", oBeAcfICRt_Inventariocaracteristicas.CRSvnominal));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVENTRADA", oBeAcfICRt_Inventariocaracteristicas.CRSventrada));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVSALIDA", oBeAcfICRt_Inventariocaracteristicas.CRSvsalida));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFRECUENCIA", oBeAcfICRt_Inventariocaracteristicas.CRSfrecuencia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSTEMPERATURA", oBeAcfICRt_Inventariocaracteristicas.CRStemperatura));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPROCESADOR", oBeAcfICRt_Inventariocaracteristicas.CRSprocesador));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPUERTOS", oBeAcfICRt_Inventariocaracteristicas.CRSpuertos));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSUTMX", oBeAcfICRt_Inventariocaracteristicas.CRSutmx));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSUTMY", oBeAcfICRt_Inventariocaracteristicas.CRSutmy));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSESFUERZOPUNTA", oBeAcfICRt_Inventariocaracteristicas.CRSesfuerzopunta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCAJADERIVADORA", oBeAcfICRt_Inventariocaracteristicas.CRScajaderivadora));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSALQUILACABLE", oBeAcfICRt_Inventariocaracteristicas.CRSalquilacable));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCENTROPOBLADO", oBeAcfICRt_Inventariocaracteristicas.CRScentropoblado));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSURBANIZACION", oBeAcfICRt_Inventariocaracteristicas.CRSurbanizacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCALLE", oBeAcfICRt_Inventariocaracteristicas.CRScalle));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSLOTE", oBeAcfICRt_Inventariocaracteristicas.CRSlote));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSNUMEROPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRSnumeropredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSDEPARTAMENTO", oBeAcfICRt_Inventariocaracteristicas.CRSdepartamento));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSINTERIOR", oBeAcfICRt_Inventariocaracteristicas.CRSinterior));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCARRETERA", oBeAcfICRt_Inventariocaracteristicas.CRScarretera));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSKILOMETRO", oBeAcfICRt_Inventariocaracteristicas.CRSkilometro));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSNOMBREPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRSnombrepredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPISOSPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRSpisospredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPARTIDAPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRSpartidapredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSTOMOPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRStomopredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFOLIOINIPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRSfolioinipredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFOLIOFINPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRSfoliofinpredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSASIENTOPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRSasientopredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFINSCPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRSfinscpredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFICHAREGISTRAL", oBeAcfICRt_Inventariocaracteristicas.CRSficharegistral));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSAREACONSTRUIDA", oBeAcfICRt_Inventariocaracteristicas.CRSareaconstruida));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPERIMETRO", oBeAcfICRt_Inventariocaracteristicas.CRSperimetro));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSUSOPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRSusopredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVALORAUTOVALUO", oBeAcfICRt_Inventariocaracteristicas.CRSvalorautovaluo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCODIGOLUZ", oBeAcfICRt_Inventariocaracteristicas.CRScodigoluz));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCODIGOAGUA", oBeAcfICRt_Inventariocaracteristicas.CRScodigoagua));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFADQPREDIO", oBeAcfICRt_Inventariocaracteristicas.CRSfadqpredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSOBSERVACION", oBeAcfICRt_Inventariocaracteristicas.CRSobservacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVID", oBeAcfICRt_Inventariocaracteristicas.INVid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfICRt_Inventariocaracteristicas.ACFid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfICRt_Inventariocaracteristicas oBeAcfICRt_Inventariocaracteristicas) {
		try {
			string sp = 'SpAcfICRt_InventariocaracteristicasEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVID", oBeAcfICRt_Inventariocaracteristicas.INVid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfICRt_InventariocaracteristicasListar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			return dt;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public bool Obtener(ref clsBeAcfICRt_Inventariocaracteristicas oBeAcfICRt_Inventariocaracteristicas) {
		try {
			string sp = 'SpAcfICRt_InventariocaracteristicasObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@INVID", oBeAcfICRt_Inventariocaracteristicas.INVid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfICRt_Inventariocaracteristicas, dt.Rows(0))
			}
			else {
				throw new Exception('No se pudo obtener el registro');
			}
			
			return true;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public bool Primero(ref clsBeAcfICRt_Inventariocaracteristicas oBeAcfICRt_Inventariocaracteristicas) {
		Try
			string sp = 'SpAcfICRt_InventariocaracteristicasPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfICRt_Inventariocaracteristicas, dt.Rows[0]);
			}
			else {
				throw new Exception('No se pudo obtener el primer registro');
			}
			
			return true;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public bool Primero(ref clsBeAcfICRt_Inventariocaracteristicas oBeAcfICRt_Inventariocaracteristicas) {
		try {
			string sp = 'SpAcfICRt_InventariocaracteristicasUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfICRt_Inventariocaracteristicas, dt.Rows[0]);
			}
			else {
				throw new Exception('No se pudo obtener el primer registro');
			}
			
			return true;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public bool Anterior(ref clsBeAcfICRt_Inventariocaracteristicas oBeAcfICRt_Inventariocaracteristicas) {
		Try
			string sp = 'SpAcfICRt_InventariocaracteristicasAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@INVID", oBeAcfICRt_Inventariocaracteristicas.INVid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfICRt_Inventariocaracteristicas, dt.Rows[0]);
			}
			else {
				throw new Exception('No se pudo obtener el anterior registro');
			End If
			}
			
			return true;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public bool Siguiente(ref clsBeAcfICRt_Inventariocaracteristicas oBeAcfICRt_Inventariocaracteristicas) {
		Try
			string sp = 'SpAcfICRt_InventariocaracteristicasSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@INVID", oBeAcfICRt_Inventariocaracteristicas.INVid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfICRt_Inventariocaracteristicas, dt.Rows[0]);
			}
			else {
				throw new Exception('No se pudo obtener el siguiente registro');
			End If
			}
			
			return true;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

}
