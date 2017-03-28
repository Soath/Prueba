using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfCRSt_Caracteristicas {

	private ConnectionManager oConexion = null;

	 public clsLnAcfCRSt_Caracteristicas(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfCRSt_Caracteristicas, ref DataRow dr) {
		try {
				oBeAcfCRSt_Caracteristicas.ACFid = ( IsDBNull(dr.Item['ACFid']) ? 0 : dr.Item['ACFid'] )
				oBeAcfCRSt_Caracteristicas.MARid = ( IsDBNull(dr.Item['MARid']) ? 0 : dr.Item['MARid'] )
				oBeAcfCRSt_Caracteristicas.ESTid = ( IsDBNull(dr.Item['ESTid']) ? 0 : dr.Item['ESTid'] )
				oBeAcfCRSt_Caracteristicas.CRSserie = ( IsDBNull(dr.Item['CRSserie']) ? '' : dr.Item['CRSserie'] )
				oBeAcfCRSt_Caracteristicas.CRSmodelo = ( IsDBNull(dr.Item['CRSmodelo']) ? '' : dr.Item['CRSmodelo'] )
				oBeAcfCRSt_Caracteristicas.CRScolor = ( IsDBNull(dr.Item['CRScolor']) ? '' : dr.Item['CRScolor'] )
				oBeAcfCRSt_Caracteristicas.MATid = ( IsDBNull(dr.Item['MATid']) ? 0 : dr.Item['MATid'] )
				oBeAcfCRSt_Caracteristicas.CRStipo = ( IsDBNull(dr.Item['CRStipo']) ? '' : dr.Item['CRStipo'] )
				oBeAcfCRSt_Caracteristicas.UNMid = ( IsDBNull(dr.Item['UNMid']) ? 0 : dr.Item['UNMid'] )
				oBeAcfCRSt_Caracteristicas.CRScantidad = ( IsDBNull(dr.Item['CRScantidad']) ? 0.0 : dr.Item['CRScantidad'] )
				oBeAcfCRSt_Caracteristicas.CRSvehplaca = ( IsDBNull(dr.Item['CRSvehplaca']) ? '' : dr.Item['CRSvehplaca'] )
				oBeAcfCRSt_Caracteristicas.CRSvehexpediente = ( IsDBNull(dr.Item['CRSvehexpediente']) ? '' : dr.Item['CRSvehexpediente'] )
				oBeAcfCRSt_Caracteristicas.CRSvehinscripcion = ( IsDBNull(dr.Item['CRSvehinscripcion']) ? Date.Now() : dr.Item['CRSvehinscripcion'] )
				oBeAcfCRSt_Caracteristicas.CRSvehclase = ( IsDBNull(dr.Item['CRSvehclase']) ? '' : dr.Item['CRSvehclase'] )
				oBeAcfCRSt_Caracteristicas.CRSvehcombustible = ( IsDBNull(dr.Item['CRSvehcombustible']) ? '' : dr.Item['CRSvehcombustible'] )
				oBeAcfCRSt_Caracteristicas.CRSvehejes = ( IsDBNull(dr.Item['CRSvehejes']) ? 0 : dr.Item['CRSvehejes'] )
				oBeAcfCRSt_Caracteristicas.CRSvehpasajeros = ( IsDBNull(dr.Item['CRSvehpasajeros']) ? 0 : dr.Item['CRSvehpasajeros'] )
				oBeAcfCRSt_Caracteristicas.CRSvehasientos = ( IsDBNull(dr.Item['CRSvehasientos']) ? 0 : dr.Item['CRSvehasientos'] )
				oBeAcfCRSt_Caracteristicas.CRSvehpesoseco = ( IsDBNull(dr.Item['CRSvehpesoseco']) ? 0.0 : dr.Item['CRSvehpesoseco'] )
				oBeAcfCRSt_Caracteristicas.CRSvehcargautil = ( IsDBNull(dr.Item['CRSvehcargautil']) ? 0.0 : dr.Item['CRSvehcargautil'] )
				oBeAcfCRSt_Caracteristicas.CRSaltura = ( IsDBNull(dr.Item['CRSaltura']) ? 0.0 : dr.Item['CRSaltura'] )
				oBeAcfCRSt_Caracteristicas.CRSancho = ( IsDBNull(dr.Item['CRSancho']) ? 0.0 : dr.Item['CRSancho'] )
				oBeAcfCRSt_Caracteristicas.CRSvelocidad = ( IsDBNull(dr.Item['CRSvelocidad']) ? '' : dr.Item['CRSvelocidad'] )
				oBeAcfCRSt_Caracteristicas.CRSresolucion = ( IsDBNull(dr.Item['CRSresolucion']) ? '' : dr.Item['CRSresolucion'] )
				oBeAcfCRSt_Caracteristicas.CRScapacidad = ( IsDBNull(dr.Item['CRScapacidad']) ? '' : dr.Item['CRScapacidad'] )
				oBeAcfCRSt_Caracteristicas.CRSpotencia = ( IsDBNull(dr.Item['CRSpotencia']) ? '' : dr.Item['CRSpotencia'] )
				oBeAcfCRSt_Caracteristicas.CRSvnominal = ( IsDBNull(dr.Item['CRSvnominal']) ? '' : dr.Item['CRSvnominal'] )
				oBeAcfCRSt_Caracteristicas.CRSventrada = ( IsDBNull(dr.Item['CRSventrada']) ? '' : dr.Item['CRSventrada'] )
				oBeAcfCRSt_Caracteristicas.CRSvsalida = ( IsDBNull(dr.Item['CRSvsalida']) ? '' : dr.Item['CRSvsalida'] )
				oBeAcfCRSt_Caracteristicas.CRSfrecuencia = ( IsDBNull(dr.Item['CRSfrecuencia']) ? '' : dr.Item['CRSfrecuencia'] )
				oBeAcfCRSt_Caracteristicas.CRStemperatura = ( IsDBNull(dr.Item['CRStemperatura']) ? '' : dr.Item['CRStemperatura'] )
				oBeAcfCRSt_Caracteristicas.CRSprocesador = ( IsDBNull(dr.Item['CRSprocesador']) ? '' : dr.Item['CRSprocesador'] )
				oBeAcfCRSt_Caracteristicas.CRSpuertos = ( IsDBNull(dr.Item['CRSpuertos']) ? '' : dr.Item['CRSpuertos'] )
				oBeAcfCRSt_Caracteristicas.CRSutmx = ( IsDBNull(dr.Item['CRSutmx']) ? 0.0 : dr.Item['CRSutmx'] )
				oBeAcfCRSt_Caracteristicas.CRSutmy = ( IsDBNull(dr.Item['CRSutmy']) ? 0.0 : dr.Item['CRSutmy'] )
				oBeAcfCRSt_Caracteristicas.CRSesfuerzopunta = ( IsDBNull(dr.Item['CRSesfuerzopunta']) ? '' : dr.Item['CRSesfuerzopunta'] )
				oBeAcfCRSt_Caracteristicas.CRScajaderivadora = ( IsDBNull(dr.Item['CRScajaderivadora']) ? '' : dr.Item['CRScajaderivadora'] )
				oBeAcfCRSt_Caracteristicas.CRSalquilacable = ( IsDBNull(dr.Item['CRSalquilacable']) ? '' : dr.Item['CRSalquilacable'] )
				oBeAcfCRSt_Caracteristicas.CRScentropoblado = ( IsDBNull(dr.Item['CRScentropoblado']) ? '' : dr.Item['CRScentropoblado'] )
				oBeAcfCRSt_Caracteristicas.CRSurbanizacion = ( IsDBNull(dr.Item['CRSurbanizacion']) ? '' : dr.Item['CRSurbanizacion'] )
				oBeAcfCRSt_Caracteristicas.CRScalle = ( IsDBNull(dr.Item['CRScalle']) ? '' : dr.Item['CRScalle'] )
				oBeAcfCRSt_Caracteristicas.CRSlote = ( IsDBNull(dr.Item['CRSlote']) ? '' : dr.Item['CRSlote'] )
				oBeAcfCRSt_Caracteristicas.CRSnumeropredio = ( IsDBNull(dr.Item['CRSnumeropredio']) ? '' : dr.Item['CRSnumeropredio'] )
				oBeAcfCRSt_Caracteristicas.CRSdepartamento = ( IsDBNull(dr.Item['CRSdepartamento']) ? '' : dr.Item['CRSdepartamento'] )
				oBeAcfCRSt_Caracteristicas.CRSinterior = ( IsDBNull(dr.Item['CRSinterior']) ? '' : dr.Item['CRSinterior'] )
				oBeAcfCRSt_Caracteristicas.CRScarretera = ( IsDBNull(dr.Item['CRScarretera']) ? '' : dr.Item['CRScarretera'] )
				oBeAcfCRSt_Caracteristicas.CRSkilometro = ( IsDBNull(dr.Item['CRSkilometro']) ? 0.0 : dr.Item['CRSkilometro'] )
				oBeAcfCRSt_Caracteristicas.CRSnombrepredio = ( IsDBNull(dr.Item['CRSnombrepredio']) ? '' : dr.Item['CRSnombrepredio'] )
				oBeAcfCRSt_Caracteristicas.CRSpisospredio = ( IsDBNull(dr.Item['CRSpisospredio']) ? 0 : dr.Item['CRSpisospredio'] )
				oBeAcfCRSt_Caracteristicas.CRSpartidapredio = ( IsDBNull(dr.Item['CRSpartidapredio']) ? '' : dr.Item['CRSpartidapredio'] )
				oBeAcfCRSt_Caracteristicas.CRStomopredio = ( IsDBNull(dr.Item['CRStomopredio']) ? '' : dr.Item['CRStomopredio'] )
				oBeAcfCRSt_Caracteristicas.CRSfolioinipredio = ( IsDBNull(dr.Item['CRSfolioinipredio']) ? '' : dr.Item['CRSfolioinipredio'] )
				oBeAcfCRSt_Caracteristicas.CRSfoliofinpredio = ( IsDBNull(dr.Item['CRSfoliofinpredio']) ? '' : dr.Item['CRSfoliofinpredio'] )
				oBeAcfCRSt_Caracteristicas.CRSasientopredio = ( IsDBNull(dr.Item['CRSasientopredio']) ? '' : dr.Item['CRSasientopredio'] )
				oBeAcfCRSt_Caracteristicas.CRSfinscpredio = ( IsDBNull(dr.Item['CRSfinscpredio']) ? Date.Now() : dr.Item['CRSfinscpredio'] )
				oBeAcfCRSt_Caracteristicas.CRSficharegistral = ( IsDBNull(dr.Item['CRSficharegistral']) ? '' : dr.Item['CRSficharegistral'] )
				oBeAcfCRSt_Caracteristicas.CRSareaconstruida = ( IsDBNull(dr.Item['CRSareaconstruida']) ? 0.0 : dr.Item['CRSareaconstruida'] )
				oBeAcfCRSt_Caracteristicas.CRSperimetro = ( IsDBNull(dr.Item['CRSperimetro']) ? 0.0 : dr.Item['CRSperimetro'] )
				oBeAcfCRSt_Caracteristicas.CRSusopredio = ( IsDBNull(dr.Item['CRSusopredio']) ? '' : dr.Item['CRSusopredio'] )
				oBeAcfCRSt_Caracteristicas.CRSvalorautovaluo = ( IsDBNull(dr.Item['CRSvalorautovaluo']) ? 0.0 : dr.Item['CRSvalorautovaluo'] )
				oBeAcfCRSt_Caracteristicas.CRScodigoluz = ( IsDBNull(dr.Item['CRScodigoluz']) ? '' : dr.Item['CRScodigoluz'] )
				oBeAcfCRSt_Caracteristicas.CRScodigoagua = ( IsDBNull(dr.Item['CRScodigoagua']) ? '' : dr.Item['CRScodigoagua'] )
				oBeAcfCRSt_Caracteristicas.CRSfadqpredio = ( IsDBNull(dr.Item['CRSfadqpredio']) ? Date.Now() : dr.Item['CRSfadqpredio'] )
				oBeAcfCRSt_Caracteristicas.CRSobservacion = ( IsDBNull(dr.Item['CRSobservacion']) ? '' : dr.Item['CRSobservacion'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfCRSt_Caracteristicas oBeAcfCRSt_Caracteristicas) {
		try {
			string sp = 'SpAcfCRSt_CaracteristicasInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfCRSt_Caracteristicas.ACFid));
			cmd.Parameters("@ACFID").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MARID", oBeAcfCRSt_Caracteristicas.MARid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ESTID", oBeAcfCRSt_Caracteristicas.ESTid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSSERIE", oBeAcfCRSt_Caracteristicas.CRSserie));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSMODELO", oBeAcfCRSt_Caracteristicas.CRSmodelo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCOLOR", oBeAcfCRSt_Caracteristicas.CRScolor));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MATID", oBeAcfCRSt_Caracteristicas.MATid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSTIPO", oBeAcfCRSt_Caracteristicas.CRStipo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UNMID", oBeAcfCRSt_Caracteristicas.UNMid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCANTIDAD", oBeAcfCRSt_Caracteristicas.CRScantidad));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHPLACA", oBeAcfCRSt_Caracteristicas.CRSvehplaca));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHEXPEDIENTE", oBeAcfCRSt_Caracteristicas.CRSvehexpediente));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHINSCRIPCION", oBeAcfCRSt_Caracteristicas.CRSvehinscripcion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHCLASE", oBeAcfCRSt_Caracteristicas.CRSvehclase));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHCOMBUSTIBLE", oBeAcfCRSt_Caracteristicas.CRSvehcombustible));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHEJES", oBeAcfCRSt_Caracteristicas.CRSvehejes));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHPASAJEROS", oBeAcfCRSt_Caracteristicas.CRSvehpasajeros));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHASIENTOS", oBeAcfCRSt_Caracteristicas.CRSvehasientos));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHPESOSECO", oBeAcfCRSt_Caracteristicas.CRSvehpesoseco));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHCARGAUTIL", oBeAcfCRSt_Caracteristicas.CRSvehcargautil));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSALTURA", oBeAcfCRSt_Caracteristicas.CRSaltura));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSANCHO", oBeAcfCRSt_Caracteristicas.CRSancho));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVELOCIDAD", oBeAcfCRSt_Caracteristicas.CRSvelocidad));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSRESOLUCION", oBeAcfCRSt_Caracteristicas.CRSresolucion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCAPACIDAD", oBeAcfCRSt_Caracteristicas.CRScapacidad));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPOTENCIA", oBeAcfCRSt_Caracteristicas.CRSpotencia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVNOMINAL", oBeAcfCRSt_Caracteristicas.CRSvnominal));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVENTRADA", oBeAcfCRSt_Caracteristicas.CRSventrada));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVSALIDA", oBeAcfCRSt_Caracteristicas.CRSvsalida));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFRECUENCIA", oBeAcfCRSt_Caracteristicas.CRSfrecuencia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSTEMPERATURA", oBeAcfCRSt_Caracteristicas.CRStemperatura));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPROCESADOR", oBeAcfCRSt_Caracteristicas.CRSprocesador));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPUERTOS", oBeAcfCRSt_Caracteristicas.CRSpuertos));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSUTMX", oBeAcfCRSt_Caracteristicas.CRSutmx));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSUTMY", oBeAcfCRSt_Caracteristicas.CRSutmy));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSESFUERZOPUNTA", oBeAcfCRSt_Caracteristicas.CRSesfuerzopunta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCAJADERIVADORA", oBeAcfCRSt_Caracteristicas.CRScajaderivadora));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSALQUILACABLE", oBeAcfCRSt_Caracteristicas.CRSalquilacable));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCENTROPOBLADO", oBeAcfCRSt_Caracteristicas.CRScentropoblado));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSURBANIZACION", oBeAcfCRSt_Caracteristicas.CRSurbanizacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCALLE", oBeAcfCRSt_Caracteristicas.CRScalle));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSLOTE", oBeAcfCRSt_Caracteristicas.CRSlote));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSNUMEROPREDIO", oBeAcfCRSt_Caracteristicas.CRSnumeropredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSDEPARTAMENTO", oBeAcfCRSt_Caracteristicas.CRSdepartamento));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSINTERIOR", oBeAcfCRSt_Caracteristicas.CRSinterior));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCARRETERA", oBeAcfCRSt_Caracteristicas.CRScarretera));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSKILOMETRO", oBeAcfCRSt_Caracteristicas.CRSkilometro));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSNOMBREPREDIO", oBeAcfCRSt_Caracteristicas.CRSnombrepredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPISOSPREDIO", oBeAcfCRSt_Caracteristicas.CRSpisospredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPARTIDAPREDIO", oBeAcfCRSt_Caracteristicas.CRSpartidapredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSTOMOPREDIO", oBeAcfCRSt_Caracteristicas.CRStomopredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFOLIOINIPREDIO", oBeAcfCRSt_Caracteristicas.CRSfolioinipredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFOLIOFINPREDIO", oBeAcfCRSt_Caracteristicas.CRSfoliofinpredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSASIENTOPREDIO", oBeAcfCRSt_Caracteristicas.CRSasientopredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFINSCPREDIO", oBeAcfCRSt_Caracteristicas.CRSfinscpredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFICHAREGISTRAL", oBeAcfCRSt_Caracteristicas.CRSficharegistral));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSAREACONSTRUIDA", oBeAcfCRSt_Caracteristicas.CRSareaconstruida));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPERIMETRO", oBeAcfCRSt_Caracteristicas.CRSperimetro));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSUSOPREDIO", oBeAcfCRSt_Caracteristicas.CRSusopredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVALORAUTOVALUO", oBeAcfCRSt_Caracteristicas.CRSvalorautovaluo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCODIGOLUZ", oBeAcfCRSt_Caracteristicas.CRScodigoluz));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCODIGOAGUA", oBeAcfCRSt_Caracteristicas.CRScodigoagua));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFADQPREDIO", oBeAcfCRSt_Caracteristicas.CRSfadqpredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSOBSERVACION", oBeAcfCRSt_Caracteristicas.CRSobservacion));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfCRSt_Caracteristicas.ACFid = int.Parse(cmd.Parameters['@ACFID'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfCRSt_Caracteristicas oBeAcfCRSt_Caracteristicas) {
		try {
			string sp = 'SpAcfCRSt_CaracteristicasActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfCRSt_Caracteristicas.ACFid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MARID", oBeAcfCRSt_Caracteristicas.MARid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ESTID", oBeAcfCRSt_Caracteristicas.ESTid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSSERIE", oBeAcfCRSt_Caracteristicas.CRSserie));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSMODELO", oBeAcfCRSt_Caracteristicas.CRSmodelo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCOLOR", oBeAcfCRSt_Caracteristicas.CRScolor));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MATID", oBeAcfCRSt_Caracteristicas.MATid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSTIPO", oBeAcfCRSt_Caracteristicas.CRStipo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UNMID", oBeAcfCRSt_Caracteristicas.UNMid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCANTIDAD", oBeAcfCRSt_Caracteristicas.CRScantidad));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHPLACA", oBeAcfCRSt_Caracteristicas.CRSvehplaca));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHEXPEDIENTE", oBeAcfCRSt_Caracteristicas.CRSvehexpediente));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHINSCRIPCION", oBeAcfCRSt_Caracteristicas.CRSvehinscripcion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHCLASE", oBeAcfCRSt_Caracteristicas.CRSvehclase));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHCOMBUSTIBLE", oBeAcfCRSt_Caracteristicas.CRSvehcombustible));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHEJES", oBeAcfCRSt_Caracteristicas.CRSvehejes));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHPASAJEROS", oBeAcfCRSt_Caracteristicas.CRSvehpasajeros));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHASIENTOS", oBeAcfCRSt_Caracteristicas.CRSvehasientos));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHPESOSECO", oBeAcfCRSt_Caracteristicas.CRSvehpesoseco));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVEHCARGAUTIL", oBeAcfCRSt_Caracteristicas.CRSvehcargautil));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSALTURA", oBeAcfCRSt_Caracteristicas.CRSaltura));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSANCHO", oBeAcfCRSt_Caracteristicas.CRSancho));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVELOCIDAD", oBeAcfCRSt_Caracteristicas.CRSvelocidad));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSRESOLUCION", oBeAcfCRSt_Caracteristicas.CRSresolucion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCAPACIDAD", oBeAcfCRSt_Caracteristicas.CRScapacidad));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPOTENCIA", oBeAcfCRSt_Caracteristicas.CRSpotencia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVNOMINAL", oBeAcfCRSt_Caracteristicas.CRSvnominal));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVENTRADA", oBeAcfCRSt_Caracteristicas.CRSventrada));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVSALIDA", oBeAcfCRSt_Caracteristicas.CRSvsalida));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFRECUENCIA", oBeAcfCRSt_Caracteristicas.CRSfrecuencia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSTEMPERATURA", oBeAcfCRSt_Caracteristicas.CRStemperatura));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPROCESADOR", oBeAcfCRSt_Caracteristicas.CRSprocesador));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPUERTOS", oBeAcfCRSt_Caracteristicas.CRSpuertos));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSUTMX", oBeAcfCRSt_Caracteristicas.CRSutmx));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSUTMY", oBeAcfCRSt_Caracteristicas.CRSutmy));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSESFUERZOPUNTA", oBeAcfCRSt_Caracteristicas.CRSesfuerzopunta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCAJADERIVADORA", oBeAcfCRSt_Caracteristicas.CRScajaderivadora));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSALQUILACABLE", oBeAcfCRSt_Caracteristicas.CRSalquilacable));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCENTROPOBLADO", oBeAcfCRSt_Caracteristicas.CRScentropoblado));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSURBANIZACION", oBeAcfCRSt_Caracteristicas.CRSurbanizacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCALLE", oBeAcfCRSt_Caracteristicas.CRScalle));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSLOTE", oBeAcfCRSt_Caracteristicas.CRSlote));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSNUMEROPREDIO", oBeAcfCRSt_Caracteristicas.CRSnumeropredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSDEPARTAMENTO", oBeAcfCRSt_Caracteristicas.CRSdepartamento));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSINTERIOR", oBeAcfCRSt_Caracteristicas.CRSinterior));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCARRETERA", oBeAcfCRSt_Caracteristicas.CRScarretera));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSKILOMETRO", oBeAcfCRSt_Caracteristicas.CRSkilometro));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSNOMBREPREDIO", oBeAcfCRSt_Caracteristicas.CRSnombrepredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPISOSPREDIO", oBeAcfCRSt_Caracteristicas.CRSpisospredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPARTIDAPREDIO", oBeAcfCRSt_Caracteristicas.CRSpartidapredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSTOMOPREDIO", oBeAcfCRSt_Caracteristicas.CRStomopredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFOLIOINIPREDIO", oBeAcfCRSt_Caracteristicas.CRSfolioinipredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFOLIOFINPREDIO", oBeAcfCRSt_Caracteristicas.CRSfoliofinpredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSASIENTOPREDIO", oBeAcfCRSt_Caracteristicas.CRSasientopredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFINSCPREDIO", oBeAcfCRSt_Caracteristicas.CRSfinscpredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFICHAREGISTRAL", oBeAcfCRSt_Caracteristicas.CRSficharegistral));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSAREACONSTRUIDA", oBeAcfCRSt_Caracteristicas.CRSareaconstruida));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSPERIMETRO", oBeAcfCRSt_Caracteristicas.CRSperimetro));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSUSOPREDIO", oBeAcfCRSt_Caracteristicas.CRSusopredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSVALORAUTOVALUO", oBeAcfCRSt_Caracteristicas.CRSvalorautovaluo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCODIGOLUZ", oBeAcfCRSt_Caracteristicas.CRScodigoluz));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCODIGOAGUA", oBeAcfCRSt_Caracteristicas.CRScodigoagua));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSFADQPREDIO", oBeAcfCRSt_Caracteristicas.CRSfadqpredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSOBSERVACION", oBeAcfCRSt_Caracteristicas.CRSobservacion));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfCRSt_Caracteristicas oBeAcfCRSt_Caracteristicas) {
		try {
			string sp = 'SpAcfCRSt_CaracteristicasEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfCRSt_Caracteristicas.ACFid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfCRSt_CaracteristicasListar';
			
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

	public bool Obtener(ref clsBeAcfCRSt_Caracteristicas oBeAcfCRSt_Caracteristicas) {
		try {
			string sp = 'SpAcfCRSt_CaracteristicasObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfCRSt_Caracteristicas.ACFid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfCRSt_Caracteristicas, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfCRSt_Caracteristicas oBeAcfCRSt_Caracteristicas) {
		Try
			string sp = 'SpAcfCRSt_CaracteristicasPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfCRSt_Caracteristicas, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfCRSt_Caracteristicas oBeAcfCRSt_Caracteristicas) {
		try {
			string sp = 'SpAcfCRSt_CaracteristicasUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfCRSt_Caracteristicas, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfCRSt_Caracteristicas oBeAcfCRSt_Caracteristicas) {
		Try
			string sp = 'SpAcfCRSt_CaracteristicasAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfCRSt_Caracteristicas.ACFid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfCRSt_Caracteristicas, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfCRSt_Caracteristicas oBeAcfCRSt_Caracteristicas) {
		Try
			string sp = 'SpAcfCRSt_CaracteristicasSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfCRSt_Caracteristicas.ACFid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfCRSt_Caracteristicas, dt.Rows[0]);
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
