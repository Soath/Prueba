using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfTMVt_TipoMovimiento {

	private ConnectionManager oConexion = null;

	 public clsLnAcfTMVt_TipoMovimiento(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfTMVt_TipoMovimiento, ref DataRow dr) {
		try {
				oBeAcfTMVt_TipoMovimiento.TMVid = ( IsDBNull(dr.Item['TMVid']) ? '' : dr.Item['TMVid'] )
				oBeAcfTMVt_TipoMovimiento.TMVtipomovimiento = ( IsDBNull(dr.Item['TMVtipomovimiento']) ? '' : dr.Item['TMVtipomovimiento'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfTMVt_TipoMovimiento oBeAcfTMVt_TipoMovimiento) {
		try {
			string sp = 'SpAcfTMVt_TipoMovimientoInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@TMVID", oBeAcfTMVt_TipoMovimiento.TMVid));
			cmd.Parameters("@TMVID").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@TMVTIPOMOVIMIENTO", oBeAcfTMVt_TipoMovimiento.TMVtipomovimiento));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfTMVt_TipoMovimiento.TMVid = Convert.ToString(cmd.Parameters['@TMVID'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfTMVt_TipoMovimiento oBeAcfTMVt_TipoMovimiento) {
		try {
			string sp = 'SpAcfTMVt_TipoMovimientoActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@TMVID", oBeAcfTMVt_TipoMovimiento.TMVid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@TMVTIPOMOVIMIENTO", oBeAcfTMVt_TipoMovimiento.TMVtipomovimiento));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfTMVt_TipoMovimiento oBeAcfTMVt_TipoMovimiento) {
		try {
			string sp = 'SpAcfTMVt_TipoMovimientoEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@TMVID", oBeAcfTMVt_TipoMovimiento.TMVid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfTMVt_TipoMovimientoListar';
			
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

	public bool Obtener(ref clsBeAcfTMVt_TipoMovimiento oBeAcfTMVt_TipoMovimiento) {
		try {
			string sp = 'SpAcfTMVt_TipoMovimientoObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@TMVID", oBeAcfTMVt_TipoMovimiento.TMVid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfTMVt_TipoMovimiento, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfTMVt_TipoMovimiento oBeAcfTMVt_TipoMovimiento) {
		Try
			string sp = 'SpAcfTMVt_TipoMovimientoPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfTMVt_TipoMovimiento, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfTMVt_TipoMovimiento oBeAcfTMVt_TipoMovimiento) {
		try {
			string sp = 'SpAcfTMVt_TipoMovimientoUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfTMVt_TipoMovimiento, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfTMVt_TipoMovimiento oBeAcfTMVt_TipoMovimiento) {
		Try
			string sp = 'SpAcfTMVt_TipoMovimientoAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@TMVID", oBeAcfTMVt_TipoMovimiento.TMVid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfTMVt_TipoMovimiento, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfTMVt_TipoMovimiento oBeAcfTMVt_TipoMovimiento) {
		Try
			string sp = 'SpAcfTMVt_TipoMovimientoSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@TMVID", oBeAcfTMVt_TipoMovimiento.TMVid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfTMVt_TipoMovimiento, dt.Rows[0]);
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
