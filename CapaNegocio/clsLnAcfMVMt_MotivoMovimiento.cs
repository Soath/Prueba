using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfMVMt_MotivoMovimiento {

	private ConnectionManager oConexion = null;

	 public clsLnAcfMVMt_MotivoMovimiento(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfMVMt_MotivoMovimiento, ref DataRow dr) {
		try {
				oBeAcfMVMt_MotivoMovimiento.TMVid = ( IsDBNull(dr.Item['TMVid']) ? '' : dr.Item['TMVid'] )
				oBeAcfMVMt_MotivoMovimiento.MVMid = ( IsDBNull(dr.Item['MVMid']) ? '' : dr.Item['MVMid'] )
				oBeAcfMVMt_MotivoMovimiento.MVMmotivomovimiento = ( IsDBNull(dr.Item['MVMmotivomovimiento']) ? '' : dr.Item['MVMmotivomovimiento'] )
				oBeAcfMVMt_MotivoMovimiento.MVMjustificacion = ( IsDBNull(dr.Item['MVMjustificacion']) ? 0 : dr.Item['MVMjustificacion'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfMVMt_MotivoMovimiento oBeAcfMVMt_MotivoMovimiento) {
		try {
			string sp = 'SpAcfMVMt_MotivoMovimientoInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@TMVID", oBeAcfMVMt_MotivoMovimiento.TMVid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MVMID", oBeAcfMVMt_MotivoMovimiento.MVMid));
			cmd.Parameters("@MVMID").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MVMMOTIVOMOVIMIENTO", oBeAcfMVMt_MotivoMovimiento.MVMmotivomovimiento));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MVMJUSTIFICACION", oBeAcfMVMt_MotivoMovimiento.MVMjustificacion));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfMVMt_MotivoMovimiento.MVMid = Convert.ToString(cmd.Parameters['@MVMID'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfMVMt_MotivoMovimiento oBeAcfMVMt_MotivoMovimiento) {
		try {
			string sp = 'SpAcfMVMt_MotivoMovimientoActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@TMVID", oBeAcfMVMt_MotivoMovimiento.TMVid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MVMID", oBeAcfMVMt_MotivoMovimiento.MVMid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MVMMOTIVOMOVIMIENTO", oBeAcfMVMt_MotivoMovimiento.MVMmotivomovimiento));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MVMJUSTIFICACION", oBeAcfMVMt_MotivoMovimiento.MVMjustificacion));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfMVMt_MotivoMovimiento oBeAcfMVMt_MotivoMovimiento) {
		try {
			string sp = 'SpAcfMVMt_MotivoMovimientoEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MVMID", oBeAcfMVMt_MotivoMovimiento.MVMid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfMVMt_MotivoMovimientoListar';
			
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

	public bool Obtener(ref clsBeAcfMVMt_MotivoMovimiento oBeAcfMVMt_MotivoMovimiento) {
		try {
			string sp = 'SpAcfMVMt_MotivoMovimientoObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@MVMID", oBeAcfMVMt_MotivoMovimiento.MVMid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfMVMt_MotivoMovimiento, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfMVMt_MotivoMovimiento oBeAcfMVMt_MotivoMovimiento) {
		Try
			string sp = 'SpAcfMVMt_MotivoMovimientoPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfMVMt_MotivoMovimiento, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfMVMt_MotivoMovimiento oBeAcfMVMt_MotivoMovimiento) {
		try {
			string sp = 'SpAcfMVMt_MotivoMovimientoUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfMVMt_MotivoMovimiento, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfMVMt_MotivoMovimiento oBeAcfMVMt_MotivoMovimiento) {
		Try
			string sp = 'SpAcfMVMt_MotivoMovimientoAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@MVMID", oBeAcfMVMt_MotivoMovimiento.MVMid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfMVMt_MotivoMovimiento, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfMVMt_MotivoMovimiento oBeAcfMVMt_MotivoMovimiento) {
		Try
			string sp = 'SpAcfMVMt_MotivoMovimientoSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@MVMID", oBeAcfMVMt_MotivoMovimiento.MVMid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfMVMt_MotivoMovimiento, dt.Rows[0]);
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
