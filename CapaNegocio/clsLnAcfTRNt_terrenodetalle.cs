using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfTRNt_terrenodetalle {

	private ConnectionManager oConexion = null;

	 public clsLnAcfTRNt_terrenodetalle(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfTRNt_terrenodetalle, ref DataRow dr) {
		try {
				oBeAcfTRNt_terrenodetalle.CRSnombrepredio = ( IsDBNull(dr.Item['CRSnombrepredio']) ? '' : dr.Item['CRSnombrepredio'] )
				oBeAcfTRNt_terrenodetalle.CRScentropoblado = ( IsDBNull(dr.Item['CRScentropoblado']) ? '' : dr.Item['CRScentropoblado'] )
				oBeAcfTRNt_terrenodetalle.CRSdepartamento = ( IsDBNull(dr.Item['CRSdepartamento']) ? '' : dr.Item['CRSdepartamento'] )
				oBeAcfTRNt_terrenodetalle.CRSinterior = ( IsDBNull(dr.Item['CRSinterior']) ? '' : dr.Item['CRSinterior'] )
				oBeAcfTRNt_terrenodetalle.CRScarretera = ( IsDBNull(dr.Item['CRScarretera']) ? '' : dr.Item['CRScarretera'] )
				oBeAcfTRNt_terrenodetalle.CRSkilometro = ( IsDBNull(dr.Item['CRSkilometro']) ? '' : dr.Item['CRSkilometro'] )
				oBeAcfTRNt_terrenodetalle.ACFArea = ( IsDBNull(dr.Item['ACFArea']) ? '' : dr.Item['ACFArea'] )
				oBeAcfTRNt_terrenodetalle.ACFvalor = ( IsDBNull(dr.Item['ACFvalor']) ? '' : dr.Item['ACFvalor'] )
				oBeAcfTRNt_terrenodetalle.ACFtc = ( IsDBNull(dr.Item['ACFtc']) ? '' : dr.Item['ACFtc'] )
				oBeAcfTRNt_terrenodetalle.ACFvalorSoles = ( IsDBNull(dr.Item['ACFvalorSoles']) ? '' : dr.Item['ACFvalorSoles'] )
				oBeAcfTRNt_terrenodetalle.ACFValorDolar = ( IsDBNull(dr.Item['ACFValorDolar']) ? '' : dr.Item['ACFValorDolar'] )
				oBeAcfTRNt_terrenodetalle.ACFValorAnt0 = ( IsDBNull(dr.Item['ACFValorAnt0']) ? '' : dr.Item['ACFValorAnt0'] )
				oBeAcfTRNt_terrenodetalle.ACFVutilniff = ( IsDBNull(dr.Item['ACFVutilniff']) ? '' : dr.Item['ACFVutilniff'] )
				oBeAcfTRNt_terrenodetalle.ACFNetopcga = ( IsDBNull(dr.Item['ACFNetopcga']) ? '' : dr.Item['ACFNetopcga'] )
				oBeAcfTRNt_terrenodetalle.ACFvalorATri = ( IsDBNull(dr.Item['ACFvalorATri']) ? '' : dr.Item['ACFvalorATri'] )
				oBeAcfTRNt_terrenodetalle.ACFid = ( IsDBNull(dr.Item['ACFid']) ? '' : dr.Item['ACFid'] )
				oBeAcfTRNt_terrenodetalle.ACFdiferencia = ( IsDBNull(dr.Item['ACFdiferencia']) ? '' : dr.Item['ACFdiferencia'] )
				oBeAcfTRNt_terrenodetalle.ACFDifTemDedu = ( IsDBNull(dr.Item['ACFDifTemDedu']) ? '' : dr.Item['ACFDifTemDedu'] )
				oBeAcfTRNt_terrenodetalle.ACFDifTemGrav = ( IsDBNull(dr.Item['ACFDifTemGrav']) ? '' : dr.Item['ACFDifTemGrav'] )
				oBeAcfTRNt_terrenodetalle.ACFTasaIR = ( IsDBNull(dr.Item['ACFTasaIR']) ? '' : dr.Item['ACFTasaIR'] )
				oBeAcfTRNt_terrenodetalle.ACFSaldoDeducible = ( IsDBNull(dr.Item['ACFSaldoDeducible']) ? '' : dr.Item['ACFSaldoDeducible'] )
				oBeAcfTRNt_terrenodetalle.ACFSaldoGravable = ( IsDBNull(dr.Item['ACFSaldoGravable']) ? '' : dr.Item['ACFSaldoGravable'] )
				oBeAcfTRNt_terrenodetalle.RVAcodigo = ( IsDBNull(dr.Item['RVAcodigo']) ? '' : dr.Item['RVAcodigo'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfTRNt_terrenodetalle oBeAcfTRNt_terrenodetalle) {
		try {
			string sp = 'SpAcfTRNt_terrenodetalleInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSNOMBREPREDIO", oBeAcfTRNt_terrenodetalle.CRSnombrepredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCENTROPOBLADO", oBeAcfTRNt_terrenodetalle.CRScentropoblado));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSDEPARTAMENTO", oBeAcfTRNt_terrenodetalle.CRSdepartamento));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSINTERIOR", oBeAcfTRNt_terrenodetalle.CRSinterior));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCARRETERA", oBeAcfTRNt_terrenodetalle.CRScarretera));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSKILOMETRO", oBeAcfTRNt_terrenodetalle.CRSkilometro));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFAREA", oBeAcfTRNt_terrenodetalle.ACFArea));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALOR", oBeAcfTRNt_terrenodetalle.ACFvalor));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFTC", oBeAcfTRNt_terrenodetalle.ACFtc));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORSOLES", oBeAcfTRNt_terrenodetalle.ACFvalorSoles));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORDOLAR", oBeAcfTRNt_terrenodetalle.ACFValorDolar));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORANT0", oBeAcfTRNt_terrenodetalle.ACFValorAnt0));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILNIFF", oBeAcfTRNt_terrenodetalle.ACFVutilniff));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFNETOPCGA", oBeAcfTRNt_terrenodetalle.ACFNetopcga));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORATRI", oBeAcfTRNt_terrenodetalle.ACFvalorATri));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfTRNt_terrenodetalle.ACFid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDIFERENCIA", oBeAcfTRNt_terrenodetalle.ACFdiferencia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDIFTEMDEDU", oBeAcfTRNt_terrenodetalle.ACFDifTemDedu));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDIFTEMGRAV", oBeAcfTRNt_terrenodetalle.ACFDifTemGrav));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFTASAIR", oBeAcfTRNt_terrenodetalle.ACFTasaIR));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFSALDODEDUCIBLE", oBeAcfTRNt_terrenodetalle.ACFSaldoDeducible));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFSALDOGRAVABLE", oBeAcfTRNt_terrenodetalle.ACFSaldoGravable));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfTRNt_terrenodetalle.RVAcodigo));
			cmd.Parameters("@RVACODIGO").Direction = ParameterDirection.Output;
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfTRNt_terrenodetalle.RVAcodigo = Convert.ToString(cmd.Parameters['@RVACODIGO'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfTRNt_terrenodetalle oBeAcfTRNt_terrenodetalle) {
		try {
			string sp = 'SpAcfTRNt_terrenodetalleActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSNOMBREPREDIO", oBeAcfTRNt_terrenodetalle.CRSnombrepredio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCENTROPOBLADO", oBeAcfTRNt_terrenodetalle.CRScentropoblado));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSDEPARTAMENTO", oBeAcfTRNt_terrenodetalle.CRSdepartamento));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSINTERIOR", oBeAcfTRNt_terrenodetalle.CRSinterior));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSCARRETERA", oBeAcfTRNt_terrenodetalle.CRScarretera));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CRSKILOMETRO", oBeAcfTRNt_terrenodetalle.CRSkilometro));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFAREA", oBeAcfTRNt_terrenodetalle.ACFArea));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALOR", oBeAcfTRNt_terrenodetalle.ACFvalor));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFTC", oBeAcfTRNt_terrenodetalle.ACFtc));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORSOLES", oBeAcfTRNt_terrenodetalle.ACFvalorSoles));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORDOLAR", oBeAcfTRNt_terrenodetalle.ACFValorDolar));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORANT0", oBeAcfTRNt_terrenodetalle.ACFValorAnt0));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILNIFF", oBeAcfTRNt_terrenodetalle.ACFVutilniff));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFNETOPCGA", oBeAcfTRNt_terrenodetalle.ACFNetopcga));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORATRI", oBeAcfTRNt_terrenodetalle.ACFvalorATri));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfTRNt_terrenodetalle.ACFid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDIFERENCIA", oBeAcfTRNt_terrenodetalle.ACFdiferencia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDIFTEMDEDU", oBeAcfTRNt_terrenodetalle.ACFDifTemDedu));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDIFTEMGRAV", oBeAcfTRNt_terrenodetalle.ACFDifTemGrav));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFTASAIR", oBeAcfTRNt_terrenodetalle.ACFTasaIR));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFSALDODEDUCIBLE", oBeAcfTRNt_terrenodetalle.ACFSaldoDeducible));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFSALDOGRAVABLE", oBeAcfTRNt_terrenodetalle.ACFSaldoGravable));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfTRNt_terrenodetalle.RVAcodigo));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfTRNt_terrenodetalle oBeAcfTRNt_terrenodetalle) {
		try {
			string sp = 'SpAcfTRNt_terrenodetalleEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfTRNt_terrenodetalle.RVAcodigo));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfTRNt_terrenodetalleListar';
			
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

	public bool Obtener(ref clsBeAcfTRNt_terrenodetalle oBeAcfTRNt_terrenodetalle) {
		try {
			string sp = 'SpAcfTRNt_terrenodetalleObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfTRNt_terrenodetalle.RVAcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfTRNt_terrenodetalle, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfTRNt_terrenodetalle oBeAcfTRNt_terrenodetalle) {
		Try
			string sp = 'SpAcfTRNt_terrenodetallePrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfTRNt_terrenodetalle, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfTRNt_terrenodetalle oBeAcfTRNt_terrenodetalle) {
		try {
			string sp = 'SpAcfTRNt_terrenodetalleUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfTRNt_terrenodetalle, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfTRNt_terrenodetalle oBeAcfTRNt_terrenodetalle) {
		Try
			string sp = 'SpAcfTRNt_terrenodetalleAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfTRNt_terrenodetalle.RVAcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfTRNt_terrenodetalle, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfTRNt_terrenodetalle oBeAcfTRNt_terrenodetalle) {
		Try
			string sp = 'SpAcfTRNt_terrenodetalleSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfTRNt_terrenodetalle.RVAcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfTRNt_terrenodetalle, dt.Rows[0]);
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
