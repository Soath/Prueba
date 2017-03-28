using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfDDFt_detalledediferido {

	private ConnectionManager oConexion = null;

	 public clsLnAcfDDFt_detalledediferido(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfDDFt_detalledediferido, ref DataRow dr) {
		try {
				oBeAcfDDFt_detalledediferido.ACFcuenta = ( IsDBNull(dr.Item['ACFcuenta']) ? '' : dr.Item['ACFcuenta'] )
				oBeAcfDDFt_detalledediferido.INVZU = ( IsDBNull(dr.Item['INVZU']) ? '' : dr.Item['INVZU'] )
				oBeAcfDDFt_detalledediferido.TXT50 = ( IsDBNull(dr.Item['TXT50']) ? '' : dr.Item['TXT50'] )
				oBeAcfDDFt_detalledediferido.ACFvalorniif = ( IsDBNull(dr.Item['ACFvalorniif']) ? 0.0 : dr.Item['ACFvalorniif'] )
				oBeAcfDDFt_detalledediferido.ACFdepniif = ( IsDBNull(dr.Item['ACFdepniif']) ? 0.0 : dr.Item['ACFdepniif'] )
				oBeAcfDDFt_detalledediferido.ACFPPENiif = ( IsDBNull(dr.Item['ACFPPENiif']) ? 0.0 : dr.Item['ACFPPENiif'] )
				oBeAcfDDFt_detalledediferido.ACFvalortrib = ( IsDBNull(dr.Item['ACFvalortrib']) ? 0.0 : dr.Item['ACFvalortrib'] )
				oBeAcfDDFt_detalledediferido.ACFDepTrib = ( IsDBNull(dr.Item['ACFDepTrib']) ? 0.0 : dr.Item['ACFDepTrib'] )
				oBeAcfDDFt_detalledediferido.ACFpplir = ( IsDBNull(dr.Item['ACFpplir']) ? 0.0 : dr.Item['ACFpplir'] )
				oBeAcfDDFt_detalledediferido.ACFdeducible = ( IsDBNull(dr.Item['ACFdeducible']) ? 0.0 : dr.Item['ACFdeducible'] )
				oBeAcfDDFt_detalledediferido.ACFimponible = ( IsDBNull(dr.Item['ACFimponible']) ? 0.0 : dr.Item['ACFimponible'] )
				oBeAcfDDFt_detalledediferido.ACFirda = ( IsDBNull(dr.Item['ACFirda']) ? 0.0 : dr.Item['ACFirda'] )
				oBeAcfDDFt_detalledediferido.ACFirdp = ( IsDBNull(dr.Item['ACFirdp']) ? 0.0 : dr.Item['ACFirdp'] )
				oBeAcfDDFt_detalledediferido.ACFculdep = ( IsDBNull(dr.Item['ACFculdep']) ? 0.0 : dr.Item['ACFculdep'] )
				oBeAcfDDFt_detalledediferido.ACFrecper1 = ( IsDBNull(dr.Item['ACFrecper1']) ? 0.0 : dr.Item['ACFrecper1'] )
				oBeAcfDDFt_detalledediferido.ACFrecper2 = ( IsDBNull(dr.Item['ACFrecper2']) ? 0.0 : dr.Item['ACFrecper2'] )
				oBeAcfDDFt_detalledediferido.ACFrecper3 = ( IsDBNull(dr.Item['ACFrecper3']) ? 0.0 : dr.Item['ACFrecper3'] )
				oBeAcfDDFt_detalledediferido.ACFrecper4 = ( IsDBNull(dr.Item['ACFrecper4']) ? 0.0 : dr.Item['ACFrecper4'] )
				oBeAcfDDFt_detalledediferido.ACFtotales = ( IsDBNull(dr.Item['ACFtotales']) ? 0.0 : dr.Item['ACFtotales'] )
				oBeAcfDDFt_detalledediferido.ACFirdaA = ( IsDBNull(dr.Item['ACFirdaA']) ? 0.0 : dr.Item['ACFirdaA'] )
				oBeAcfDDFt_detalledediferido.ACFirdpA = ( IsDBNull(dr.Item['ACFirdpA']) ? 0.0 : dr.Item['ACFirdpA'] )
				oBeAcfDDFt_detalledediferido.ACFirdaF = ( IsDBNull(dr.Item['ACFirdaF']) ? 0.0 : dr.Item['ACFirdaF'] )
				oBeAcfDDFt_detalledediferido.ACFirdpF = ( IsDBNull(dr.Item['ACFirdpF']) ? 0.0 : dr.Item['ACFirdpF'] )
				oBeAcfDDFt_detalledediferido.PDFcodigo = ( IsDBNull(dr.Item['PDFcodigo']) ? 0 : dr.Item['PDFcodigo'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfDDFt_detalledediferido oBeAcfDDFt_detalledediferido) {
		try {
			string sp = 'SpAcfDDFt_detalledediferidoInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCUENTA", oBeAcfDDFt_detalledediferido.ACFcuenta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVZU", oBeAcfDDFt_detalledediferido.INVZU));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@TXT50", oBeAcfDDFt_detalledediferido.TXT50));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORNIIF", oBeAcfDDFt_detalledediferido.ACFvalorniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPNIIF", oBeAcfDDFt_detalledediferido.ACFdepniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFPPENIIF", oBeAcfDDFt_detalledediferido.ACFPPENiif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORTRIB", oBeAcfDDFt_detalledediferido.ACFvalortrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPTRIB", oBeAcfDDFt_detalledediferido.ACFDepTrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFPPLIR", oBeAcfDDFt_detalledediferido.ACFpplir));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEDUCIBLE", oBeAcfDDFt_detalledediferido.ACFdeducible));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFIMPONIBLE", oBeAcfDDFt_detalledediferido.ACFimponible));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFIRDA", oBeAcfDDFt_detalledediferido.ACFirda));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFIRDP", oBeAcfDDFt_detalledediferido.ACFirdp));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCULDEP", oBeAcfDDFt_detalledediferido.ACFculdep));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFRECPER1", oBeAcfDDFt_detalledediferido.ACFrecper1));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFRECPER2", oBeAcfDDFt_detalledediferido.ACFrecper2));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFRECPER3", oBeAcfDDFt_detalledediferido.ACFrecper3));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFRECPER4", oBeAcfDDFt_detalledediferido.ACFrecper4));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFTOTALES", oBeAcfDDFt_detalledediferido.ACFtotales));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFIRDAA", oBeAcfDDFt_detalledediferido.ACFirdaA));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFIRDPA", oBeAcfDDFt_detalledediferido.ACFirdpA));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFIRDAF", oBeAcfDDFt_detalledediferido.ACFirdaF));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFIRDPF", oBeAcfDDFt_detalledediferido.ACFirdpF));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PDFCODIGO", oBeAcfDDFt_detalledediferido.PDFcodigo));
			cmd.Parameters("@PDFCODIGO").Direction = ParameterDirection.Output;
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfDDFt_detalledediferido.PDFcodigo = int.Parse(cmd.Parameters['@PDFCODIGO'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfDDFt_detalledediferido oBeAcfDDFt_detalledediferido) {
		try {
			string sp = 'SpAcfDDFt_detalledediferidoActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCUENTA", oBeAcfDDFt_detalledediferido.ACFcuenta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVZU", oBeAcfDDFt_detalledediferido.INVZU));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@TXT50", oBeAcfDDFt_detalledediferido.TXT50));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORNIIF", oBeAcfDDFt_detalledediferido.ACFvalorniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPNIIF", oBeAcfDDFt_detalledediferido.ACFdepniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFPPENIIF", oBeAcfDDFt_detalledediferido.ACFPPENiif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORTRIB", oBeAcfDDFt_detalledediferido.ACFvalortrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPTRIB", oBeAcfDDFt_detalledediferido.ACFDepTrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFPPLIR", oBeAcfDDFt_detalledediferido.ACFpplir));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEDUCIBLE", oBeAcfDDFt_detalledediferido.ACFdeducible));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFIMPONIBLE", oBeAcfDDFt_detalledediferido.ACFimponible));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFIRDA", oBeAcfDDFt_detalledediferido.ACFirda));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFIRDP", oBeAcfDDFt_detalledediferido.ACFirdp));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCULDEP", oBeAcfDDFt_detalledediferido.ACFculdep));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFRECPER1", oBeAcfDDFt_detalledediferido.ACFrecper1));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFRECPER2", oBeAcfDDFt_detalledediferido.ACFrecper2));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFRECPER3", oBeAcfDDFt_detalledediferido.ACFrecper3));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFRECPER4", oBeAcfDDFt_detalledediferido.ACFrecper4));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFTOTALES", oBeAcfDDFt_detalledediferido.ACFtotales));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFIRDAA", oBeAcfDDFt_detalledediferido.ACFirdaA));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFIRDPA", oBeAcfDDFt_detalledediferido.ACFirdpA));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFIRDAF", oBeAcfDDFt_detalledediferido.ACFirdaF));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFIRDPF", oBeAcfDDFt_detalledediferido.ACFirdpF));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PDFCODIGO", oBeAcfDDFt_detalledediferido.PDFcodigo));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfDDFt_detalledediferido oBeAcfDDFt_detalledediferido) {
		try {
			string sp = 'SpAcfDDFt_detalledediferidoEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PDFCODIGO", oBeAcfDDFt_detalledediferido.PDFcodigo));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfDDFt_detalledediferidoListar';
			
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

	public bool Obtener(ref clsBeAcfDDFt_detalledediferido oBeAcfDDFt_detalledediferido) {
		try {
			string sp = 'SpAcfDDFt_detalledediferidoObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@PDFCODIGO", oBeAcfDDFt_detalledediferido.PDFcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfDDFt_detalledediferido, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfDDFt_detalledediferido oBeAcfDDFt_detalledediferido) {
		Try
			string sp = 'SpAcfDDFt_detalledediferidoPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfDDFt_detalledediferido, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfDDFt_detalledediferido oBeAcfDDFt_detalledediferido) {
		try {
			string sp = 'SpAcfDDFt_detalledediferidoUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfDDFt_detalledediferido, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfDDFt_detalledediferido oBeAcfDDFt_detalledediferido) {
		Try
			string sp = 'SpAcfDDFt_detalledediferidoAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@PDFCODIGO", oBeAcfDDFt_detalledediferido.PDFcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfDDFt_detalledediferido, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfDDFt_detalledediferido oBeAcfDDFt_detalledediferido) {
		Try
			string sp = 'SpAcfDDFt_detalledediferidoSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@PDFCODIGO", oBeAcfDDFt_detalledediferido.PDFcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfDDFt_detalledediferido, dt.Rows[0]);
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
