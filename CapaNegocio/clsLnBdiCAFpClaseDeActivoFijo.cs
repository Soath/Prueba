using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnBdiCAFpClaseDeActivoFijo {

	private ConnectionManager oConexion = null;

	 public clsLnBdiCAFpClaseDeActivoFijo(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeBdiCAFpClaseDeActivoFijo, ref DataRow dr) {
		try {
				oBeBdiCAFpClaseDeActivoFijo.ANLKL = ( IsDBNull(dr.Item['ANLKL']) ? '' : dr.Item['ANLKL'] )
				oBeBdiCAFpClaseDeActivoFijo.TXK50 = ( IsDBNull(dr.Item['TXK50']) ? '' : dr.Item['TXK50'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeBdiCAFpClaseDeActivoFijo oBeBdiCAFpClaseDeActivoFijo) {
		try {
			string sp = 'SpBdiCAFpClaseDeActivoFijoInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ANLKL", oBeBdiCAFpClaseDeActivoFijo.ANLKL));
			cmd.Parameters("@ANLKL").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@TXK50", oBeBdiCAFpClaseDeActivoFijo.TXK50));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeBdiCAFpClaseDeActivoFijo.ANLKL = Convert.ToString(cmd.Parameters['@ANLKL'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeBdiCAFpClaseDeActivoFijo oBeBdiCAFpClaseDeActivoFijo) {
		try {
			string sp = 'SpBdiCAFpClaseDeActivoFijoActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ANLKL", oBeBdiCAFpClaseDeActivoFijo.ANLKL));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@TXK50", oBeBdiCAFpClaseDeActivoFijo.TXK50));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeBdiCAFpClaseDeActivoFijo oBeBdiCAFpClaseDeActivoFijo) {
		try {
			string sp = 'SpBdiCAFpClaseDeActivoFijoEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ANLKL", oBeBdiCAFpClaseDeActivoFijo.ANLKL));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpBdiCAFpClaseDeActivoFijoListar';
			
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

	public bool Obtener(ref clsBeBdiCAFpClaseDeActivoFijo oBeBdiCAFpClaseDeActivoFijo) {
		try {
			string sp = 'SpBdiCAFpClaseDeActivoFijoObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@ANLKL", oBeBdiCAFpClaseDeActivoFijo.ANLKL));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiCAFpClaseDeActivoFijo, dt.Rows(0))
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

	public bool Primero(ref clsBeBdiCAFpClaseDeActivoFijo oBeBdiCAFpClaseDeActivoFijo) {
		Try
			string sp = 'SpBdiCAFpClaseDeActivoFijoPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiCAFpClaseDeActivoFijo, dt.Rows[0]);
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

	public bool Primero(ref clsBeBdiCAFpClaseDeActivoFijo oBeBdiCAFpClaseDeActivoFijo) {
		try {
			string sp = 'SpBdiCAFpClaseDeActivoFijoUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiCAFpClaseDeActivoFijo, dt.Rows[0]);
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

	public bool Anterior(ref clsBeBdiCAFpClaseDeActivoFijo oBeBdiCAFpClaseDeActivoFijo) {
		Try
			string sp = 'SpBdiCAFpClaseDeActivoFijoAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@ANLKL", oBeBdiCAFpClaseDeActivoFijo.ANLKL));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiCAFpClaseDeActivoFijo, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeBdiCAFpClaseDeActivoFijo oBeBdiCAFpClaseDeActivoFijo) {
		Try
			string sp = 'SpBdiCAFpClaseDeActivoFijoSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@ANLKL", oBeBdiCAFpClaseDeActivoFijo.ANLKL));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiCAFpClaseDeActivoFijo, dt.Rows[0]);
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
