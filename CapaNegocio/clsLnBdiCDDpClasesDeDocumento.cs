using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnBdiCDDpClasesDeDocumento {

	private ConnectionManager oConexion = null;

	 public clsLnBdiCDDpClasesDeDocumento(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeBdiCDDpClasesDeDocumento, ref DataRow dr) {
		try {
				oBeBdiCDDpClasesDeDocumento.BLART = ( IsDBNull(dr.Item['BLART']) ? '' : dr.Item['BLART'] )
				oBeBdiCDDpClasesDeDocumento.LTEXT = ( IsDBNull(dr.Item['LTEXT']) ? '' : dr.Item['LTEXT'] )
				oBeBdiCDDpClasesDeDocumento.DETdoctipo = ( IsDBNull(dr.Item['DETdoctipo']) ? '' : dr.Item['DETdoctipo'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeBdiCDDpClasesDeDocumento oBeBdiCDDpClasesDeDocumento) {
		try {
			string sp = 'SpBdiCDDpClasesDeDocumentoInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@BLART", oBeBdiCDDpClasesDeDocumento.BLART));
			cmd.Parameters("@BLART").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LTEXT", oBeBdiCDDpClasesDeDocumento.LTEXT));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@DETDOCTIPO", oBeBdiCDDpClasesDeDocumento.DETdoctipo));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeBdiCDDpClasesDeDocumento.BLART = Convert.ToString(cmd.Parameters['@BLART'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeBdiCDDpClasesDeDocumento oBeBdiCDDpClasesDeDocumento) {
		try {
			string sp = 'SpBdiCDDpClasesDeDocumentoActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@BLART", oBeBdiCDDpClasesDeDocumento.BLART));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LTEXT", oBeBdiCDDpClasesDeDocumento.LTEXT));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@DETDOCTIPO", oBeBdiCDDpClasesDeDocumento.DETdoctipo));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeBdiCDDpClasesDeDocumento oBeBdiCDDpClasesDeDocumento) {
		try {
			string sp = 'SpBdiCDDpClasesDeDocumentoEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@BLART", oBeBdiCDDpClasesDeDocumento.BLART));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpBdiCDDpClasesDeDocumentoListar';
			
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

	public bool Obtener(ref clsBeBdiCDDpClasesDeDocumento oBeBdiCDDpClasesDeDocumento) {
		try {
			string sp = 'SpBdiCDDpClasesDeDocumentoObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@BLART", oBeBdiCDDpClasesDeDocumento.BLART));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiCDDpClasesDeDocumento, dt.Rows(0))
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

	public bool Primero(ref clsBeBdiCDDpClasesDeDocumento oBeBdiCDDpClasesDeDocumento) {
		Try
			string sp = 'SpBdiCDDpClasesDeDocumentoPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiCDDpClasesDeDocumento, dt.Rows[0]);
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

	public bool Primero(ref clsBeBdiCDDpClasesDeDocumento oBeBdiCDDpClasesDeDocumento) {
		try {
			string sp = 'SpBdiCDDpClasesDeDocumentoUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiCDDpClasesDeDocumento, dt.Rows[0]);
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

	public bool Anterior(ref clsBeBdiCDDpClasesDeDocumento oBeBdiCDDpClasesDeDocumento) {
		Try
			string sp = 'SpBdiCDDpClasesDeDocumentoAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@BLART", oBeBdiCDDpClasesDeDocumento.BLART));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiCDDpClasesDeDocumento, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeBdiCDDpClasesDeDocumento oBeBdiCDDpClasesDeDocumento) {
		Try
			string sp = 'SpBdiCDDpClasesDeDocumentoSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@BLART", oBeBdiCDDpClasesDeDocumento.BLART));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiCDDpClasesDeDocumento, dt.Rows[0]);
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
