using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfUBEt_UbicacionElectrica {

	private ConnectionManager oConexion = null;

	 public clsLnAcfUBEt_UbicacionElectrica(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfUBEt_UbicacionElectrica, ref DataRow dr) {
		try {
				oBeAcfUBEt_UbicacionElectrica.UBEcodigogis = ( IsDBNull(dr.Item['UBEcodigogis']) ? 0 : dr.Item['UBEcodigogis'] )
				oBeAcfUBEt_UbicacionElectrica.UBEobra = ( IsDBNull(dr.Item['UBEobra']) ? '' : dr.Item['UBEobra'] )
				oBeAcfUBEt_UbicacionElectrica.KOSTL = ( IsDBNull(dr.Item['KOSTL']) ? '' : dr.Item['KOSTL'] )
				oBeAcfUBEt_UbicacionElectrica.VNRid = ( IsDBNull(dr.Item['VNRid']) ? '' : dr.Item['VNRid'] )
				oBeAcfUBEt_UbicacionElectrica.SELid = ( IsDBNull(dr.Item['SELid']) ? '' : dr.Item['SELid'] )
				oBeAcfUBEt_UbicacionElectrica.UBEset = ( IsDBNull(dr.Item['UBEset']) ? 0 : dr.Item['UBEset'] )
				oBeAcfUBEt_UbicacionElectrica.UBEsetetq = ( IsDBNull(dr.Item['UBEsetetq']) ? '' : dr.Item['UBEsetetq'] )
				oBeAcfUBEt_UbicacionElectrica.UBEalimentador = ( IsDBNull(dr.Item['UBEalimentador']) ? 0 : dr.Item['UBEalimentador'] )
				oBeAcfUBEt_UbicacionElectrica.UBEalimentadoretq = ( IsDBNull(dr.Item['UBEalimentadoretq']) ? '' : dr.Item['UBEalimentadoretq'] )
				oBeAcfUBEt_UbicacionElectrica.UBEsed = ( IsDBNull(dr.Item['UBEsed']) ? 0 : dr.Item['UBEsed'] )
				oBeAcfUBEt_UbicacionElectrica.UBEsedetq = ( IsDBNull(dr.Item['UBEsedetq']) ? '' : dr.Item['UBEsedetq'] )
				oBeAcfUBEt_UbicacionElectrica.UBEcircuito = ( IsDBNull(dr.Item['UBEcircuito']) ? 0 : dr.Item['UBEcircuito'] )
				oBeAcfUBEt_UbicacionElectrica.UBEcircuitoetq = ( IsDBNull(dr.Item['UBEcircuitoetq']) ? '' : dr.Item['UBEcircuitoetq'] )
				oBeAcfUBEt_UbicacionElectrica.UBEpuntoi = ( IsDBNull(dr.Item['UBEpuntoi']) ? 0 : dr.Item['UBEpuntoi'] )
				oBeAcfUBEt_UbicacionElectrica.UBEpuntoietq = ( IsDBNull(dr.Item['UBEpuntoietq']) ? '' : dr.Item['UBEpuntoietq'] )
				oBeAcfUBEt_UbicacionElectrica.UBEpuntof = ( IsDBNull(dr.Item['UBEpuntof']) ? 0 : dr.Item['UBEpuntof'] )
				oBeAcfUBEt_UbicacionElectrica.UBEpuntofetq = ( IsDBNull(dr.Item['UBEpuntofetq']) ? '' : dr.Item['UBEpuntofetq'] )
				oBeAcfUBEt_UbicacionElectrica.UBEid = ( IsDBNull(dr.Item['UBEid']) ? 0 : dr.Item['UBEid'] )
				oBeAcfUBEt_UbicacionElectrica.ACFid = ( IsDBNull(dr.Item['ACFid']) ? 0 : dr.Item['ACFid'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfUBEt_UbicacionElectrica oBeAcfUBEt_UbicacionElectrica) {
		try {
			string sp = 'SpAcfUBEt_UbicacionElectricaInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBECODIGOGIS", oBeAcfUBEt_UbicacionElectrica.UBEcodigogis));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEOBRA", oBeAcfUBEt_UbicacionElectrica.UBEobra));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@KOSTL", oBeAcfUBEt_UbicacionElectrica.KOSTL));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@VNRID", oBeAcfUBEt_UbicacionElectrica.VNRid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@SELID", oBeAcfUBEt_UbicacionElectrica.SELid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBESET", oBeAcfUBEt_UbicacionElectrica.UBEset));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBESETETQ", oBeAcfUBEt_UbicacionElectrica.UBEsetetq));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEALIMENTADOR", oBeAcfUBEt_UbicacionElectrica.UBEalimentador));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEALIMENTADORETQ", oBeAcfUBEt_UbicacionElectrica.UBEalimentadoretq));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBESED", oBeAcfUBEt_UbicacionElectrica.UBEsed));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBESEDETQ", oBeAcfUBEt_UbicacionElectrica.UBEsedetq));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBECIRCUITO", oBeAcfUBEt_UbicacionElectrica.UBEcircuito));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBECIRCUITOETQ", oBeAcfUBEt_UbicacionElectrica.UBEcircuitoetq));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEPUNTOI", oBeAcfUBEt_UbicacionElectrica.UBEpuntoi));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEPUNTOIETQ", oBeAcfUBEt_UbicacionElectrica.UBEpuntoietq));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEPUNTOF", oBeAcfUBEt_UbicacionElectrica.UBEpuntof));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEPUNTOFETQ", oBeAcfUBEt_UbicacionElectrica.UBEpuntofetq));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEID", oBeAcfUBEt_UbicacionElectrica.UBEid));
			cmd.Parameters("@UBEID").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfUBEt_UbicacionElectrica.ACFid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfUBEt_UbicacionElectrica.UBEid = int.Parse(cmd.Parameters['@UBEID'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfUBEt_UbicacionElectrica oBeAcfUBEt_UbicacionElectrica) {
		try {
			string sp = 'SpAcfUBEt_UbicacionElectricaActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBECODIGOGIS", oBeAcfUBEt_UbicacionElectrica.UBEcodigogis));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEOBRA", oBeAcfUBEt_UbicacionElectrica.UBEobra));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@KOSTL", oBeAcfUBEt_UbicacionElectrica.KOSTL));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@VNRID", oBeAcfUBEt_UbicacionElectrica.VNRid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@SELID", oBeAcfUBEt_UbicacionElectrica.SELid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBESET", oBeAcfUBEt_UbicacionElectrica.UBEset));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBESETETQ", oBeAcfUBEt_UbicacionElectrica.UBEsetetq));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEALIMENTADOR", oBeAcfUBEt_UbicacionElectrica.UBEalimentador));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEALIMENTADORETQ", oBeAcfUBEt_UbicacionElectrica.UBEalimentadoretq));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBESED", oBeAcfUBEt_UbicacionElectrica.UBEsed));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBESEDETQ", oBeAcfUBEt_UbicacionElectrica.UBEsedetq));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBECIRCUITO", oBeAcfUBEt_UbicacionElectrica.UBEcircuito));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBECIRCUITOETQ", oBeAcfUBEt_UbicacionElectrica.UBEcircuitoetq));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEPUNTOI", oBeAcfUBEt_UbicacionElectrica.UBEpuntoi));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEPUNTOIETQ", oBeAcfUBEt_UbicacionElectrica.UBEpuntoietq));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEPUNTOF", oBeAcfUBEt_UbicacionElectrica.UBEpuntof));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEPUNTOFETQ", oBeAcfUBEt_UbicacionElectrica.UBEpuntofetq));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEID", oBeAcfUBEt_UbicacionElectrica.UBEid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfUBEt_UbicacionElectrica.ACFid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfUBEt_UbicacionElectrica oBeAcfUBEt_UbicacionElectrica) {
		try {
			string sp = 'SpAcfUBEt_UbicacionElectricaEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEID", oBeAcfUBEt_UbicacionElectrica.UBEid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfUBEt_UbicacionElectricaListar';
			
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

	public bool Obtener(ref clsBeAcfUBEt_UbicacionElectrica oBeAcfUBEt_UbicacionElectrica) {
		try {
			string sp = 'SpAcfUBEt_UbicacionElectricaObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@UBEID", oBeAcfUBEt_UbicacionElectrica.UBEid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfUBEt_UbicacionElectrica, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfUBEt_UbicacionElectrica oBeAcfUBEt_UbicacionElectrica) {
		Try
			string sp = 'SpAcfUBEt_UbicacionElectricaPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfUBEt_UbicacionElectrica, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfUBEt_UbicacionElectrica oBeAcfUBEt_UbicacionElectrica) {
		try {
			string sp = 'SpAcfUBEt_UbicacionElectricaUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfUBEt_UbicacionElectrica, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfUBEt_UbicacionElectrica oBeAcfUBEt_UbicacionElectrica) {
		Try
			string sp = 'SpAcfUBEt_UbicacionElectricaAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@UBEID", oBeAcfUBEt_UbicacionElectrica.UBEid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfUBEt_UbicacionElectrica, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfUBEt_UbicacionElectrica oBeAcfUBEt_UbicacionElectrica) {
		Try
			string sp = 'SpAcfUBEt_UbicacionElectricaSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@UBEID", oBeAcfUBEt_UbicacionElectrica.UBEid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfUBEt_UbicacionElectrica, dt.Rows[0]);
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
