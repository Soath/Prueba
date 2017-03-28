using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfRTRt_Reparotributario {

	private ConnectionManager oConexion = null;

	 public clsLnAcfRTRt_Reparotributario(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfRTRt_Reparotributario, ref DataRow dr) {
		try {
				oBeAcfRTRt_Reparotributario.RTRperiodo = ( IsDBNull(dr.Item['RTRperiodo']) ? '' : dr.Item['RTRperiodo'] )
				oBeAcfRTRt_Reparotributario.RTRfecha = ( IsDBNull(dr.Item['RTRfecha']) ? Date.Now() : dr.Item['RTRfecha'] )
				oBeAcfRTRt_Reparotributario.RTRresponsable = ( IsDBNull(dr.Item['RTRresponsable']) ? '' : dr.Item['RTRresponsable'] )
				oBeAcfRTRt_Reparotributario.RTRestado = ( IsDBNull(dr.Item['RTRestado']) ? False : dr.Item['RTRestado'] )
				oBeAcfRTRt_Reparotributario.RTRcodigo = ( IsDBNull(dr.Item['RTRcodigo']) ? 0 : dr.Item['RTRcodigo'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfRTRt_Reparotributario oBeAcfRTRt_Reparotributario) {
		try {
			string sp = 'SpAcfRTRt_ReparotributarioInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RTRPERIODO", oBeAcfRTRt_Reparotributario.RTRperiodo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RTRFECHA", oBeAcfRTRt_Reparotributario.RTRfecha));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RTRRESPONSABLE", oBeAcfRTRt_Reparotributario.RTRresponsable));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RTRESTADO", oBeAcfRTRt_Reparotributario.RTRestado));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RTRCODIGO", oBeAcfRTRt_Reparotributario.RTRcodigo));
			cmd.Parameters("@RTRCODIGO").Direction = ParameterDirection.Output;
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfRTRt_Reparotributario.RTRcodigo = int.Parse(cmd.Parameters['@RTRCODIGO'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfRTRt_Reparotributario oBeAcfRTRt_Reparotributario) {
		try {
			string sp = 'SpAcfRTRt_ReparotributarioActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RTRPERIODO", oBeAcfRTRt_Reparotributario.RTRperiodo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RTRFECHA", oBeAcfRTRt_Reparotributario.RTRfecha));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RTRRESPONSABLE", oBeAcfRTRt_Reparotributario.RTRresponsable));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RTRESTADO", oBeAcfRTRt_Reparotributario.RTRestado));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RTRCODIGO", oBeAcfRTRt_Reparotributario.RTRcodigo));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfRTRt_Reparotributario oBeAcfRTRt_Reparotributario) {
		try {
			string sp = 'SpAcfRTRt_ReparotributarioEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RTRCODIGO", oBeAcfRTRt_Reparotributario.RTRcodigo));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfRTRt_ReparotributarioListar';
			
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

	public bool Obtener(ref clsBeAcfRTRt_Reparotributario oBeAcfRTRt_Reparotributario) {
		try {
			string sp = 'SpAcfRTRt_ReparotributarioObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@RTRCODIGO", oBeAcfRTRt_Reparotributario.RTRcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfRTRt_Reparotributario, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfRTRt_Reparotributario oBeAcfRTRt_Reparotributario) {
		Try
			string sp = 'SpAcfRTRt_ReparotributarioPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfRTRt_Reparotributario, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfRTRt_Reparotributario oBeAcfRTRt_Reparotributario) {
		try {
			string sp = 'SpAcfRTRt_ReparotributarioUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfRTRt_Reparotributario, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfRTRt_Reparotributario oBeAcfRTRt_Reparotributario) {
		Try
			string sp = 'SpAcfRTRt_ReparotributarioAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@RTRCODIGO", oBeAcfRTRt_Reparotributario.RTRcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfRTRt_Reparotributario, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfRTRt_Reparotributario oBeAcfRTRt_Reparotributario) {
		Try
			string sp = 'SpAcfRTRt_ReparotributarioSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@RTRCODIGO", oBeAcfRTRt_Reparotributario.RTRcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfRTRt_Reparotributario, dt.Rows[0]);
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
