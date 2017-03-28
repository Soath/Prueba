using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfRVAt_registrovaluacion {

	private ConnectionManager oConexion = null;

	 public clsLnAcfRVAt_registrovaluacion(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfRVAt_registrovaluacion, ref DataRow dr) {
		try {
				oBeAcfRVAt_registrovaluacion.RVAcodigo = ( IsDBNull(dr.Item['RVAcodigo']) ? '' : dr.Item['RVAcodigo'] )
				oBeAcfRVAt_registrovaluacion.RVAperiodo = ( IsDBNull(dr.Item['RVAperiodo']) ? '' : dr.Item['RVAperiodo'] )
				oBeAcfRVAt_registrovaluacion.RVAfecha = ( IsDBNull(dr.Item['RVAfecha']) ? '' : dr.Item['RVAfecha'] )
				oBeAcfRVAt_registrovaluacion.RVAresponsable = ( IsDBNull(dr.Item['RVAresponsable']) ? '' : dr.Item['RVAresponsable'] )
				oBeAcfRVAt_registrovaluacion.RVRestado = ( IsDBNull(dr.Item['RVRestado']) ? '' : dr.Item['RVRestado'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfRVAt_registrovaluacion oBeAcfRVAt_registrovaluacion) {
		try {
			string sp = 'SpAcfRVAt_registrovaluacionInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfRVAt_registrovaluacion.RVAcodigo));
			cmd.Parameters("@RVACODIGO").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RVAPERIODO", oBeAcfRVAt_registrovaluacion.RVAperiodo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RVAFECHA", oBeAcfRVAt_registrovaluacion.RVAfecha));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RVARESPONSABLE", oBeAcfRVAt_registrovaluacion.RVAresponsable));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RVRESTADO", oBeAcfRVAt_registrovaluacion.RVRestado));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfRVAt_registrovaluacion.RVAcodigo = Convert.ToString(cmd.Parameters['@RVACODIGO'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfRVAt_registrovaluacion oBeAcfRVAt_registrovaluacion) {
		try {
			string sp = 'SpAcfRVAt_registrovaluacionActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfRVAt_registrovaluacion.RVAcodigo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RVAPERIODO", oBeAcfRVAt_registrovaluacion.RVAperiodo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RVAFECHA", oBeAcfRVAt_registrovaluacion.RVAfecha));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RVARESPONSABLE", oBeAcfRVAt_registrovaluacion.RVAresponsable));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RVRESTADO", oBeAcfRVAt_registrovaluacion.RVRestado));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfRVAt_registrovaluacion oBeAcfRVAt_registrovaluacion) {
		try {
			string sp = 'SpAcfRVAt_registrovaluacionEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfRVAt_registrovaluacion.RVAcodigo));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfRVAt_registrovaluacionListar';
			
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

	public bool Obtener(ref clsBeAcfRVAt_registrovaluacion oBeAcfRVAt_registrovaluacion) {
		try {
			string sp = 'SpAcfRVAt_registrovaluacionObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfRVAt_registrovaluacion.RVAcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfRVAt_registrovaluacion, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfRVAt_registrovaluacion oBeAcfRVAt_registrovaluacion) {
		Try
			string sp = 'SpAcfRVAt_registrovaluacionPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfRVAt_registrovaluacion, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfRVAt_registrovaluacion oBeAcfRVAt_registrovaluacion) {
		try {
			string sp = 'SpAcfRVAt_registrovaluacionUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfRVAt_registrovaluacion, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfRVAt_registrovaluacion oBeAcfRVAt_registrovaluacion) {
		Try
			string sp = 'SpAcfRVAt_registrovaluacionAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfRVAt_registrovaluacion.RVAcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfRVAt_registrovaluacion, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfRVAt_registrovaluacion oBeAcfRVAt_registrovaluacion) {
		Try
			string sp = 'SpAcfRVAt_registrovaluacionSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfRVAt_registrovaluacion.RVAcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfRVAt_registrovaluacion, dt.Rows[0]);
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
