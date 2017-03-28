using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnBdiPRVpProveedor {

	private ConnectionManager oConexion = null;

	 public clsLnBdiPRVpProveedor(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeBdiPRVpProveedor, ref DataRow dr) {
		try {
				oBeBdiPRVpProveedor.LIFNR = ( IsDBNull(dr.Item['LIFNR']) ? '' : dr.Item['LIFNR'] )
				oBeBdiPRVpProveedor.Name1 = ( IsDBNull(dr.Item['Name1']) ? '' : dr.Item['Name1'] )
				oBeBdiPRVpProveedor.Stras = ( IsDBNull(dr.Item['Stras']) ? '' : dr.Item['Stras'] )
				oBeBdiPRVpProveedor.STCD1 = ( IsDBNull(dr.Item['STCD1']) ? '' : dr.Item['STCD1'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeBdiPRVpProveedor oBeBdiPRVpProveedor) {
		try {
			string sp = 'SpBdiPRVpProveedorInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LIFNR", oBeBdiPRVpProveedor.LIFNR));
			cmd.Parameters("@LIFNR").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@NAME1", oBeBdiPRVpProveedor.Name1));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@STRAS", oBeBdiPRVpProveedor.Stras));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@STCD1", oBeBdiPRVpProveedor.STCD1));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeBdiPRVpProveedor.LIFNR = Convert.ToString(cmd.Parameters['@LIFNR'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeBdiPRVpProveedor oBeBdiPRVpProveedor) {
		try {
			string sp = 'SpBdiPRVpProveedorActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LIFNR", oBeBdiPRVpProveedor.LIFNR));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@NAME1", oBeBdiPRVpProveedor.Name1));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@STRAS", oBeBdiPRVpProveedor.Stras));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@STCD1", oBeBdiPRVpProveedor.STCD1));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeBdiPRVpProveedor oBeBdiPRVpProveedor) {
		try {
			string sp = 'SpBdiPRVpProveedorEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LIFNR", oBeBdiPRVpProveedor.LIFNR));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpBdiPRVpProveedorListar';
			
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

	public bool Obtener(ref clsBeBdiPRVpProveedor oBeBdiPRVpProveedor) {
		try {
			string sp = 'SpBdiPRVpProveedorObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@LIFNR", oBeBdiPRVpProveedor.LIFNR));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiPRVpProveedor, dt.Rows(0))
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

	public bool Primero(ref clsBeBdiPRVpProveedor oBeBdiPRVpProveedor) {
		Try
			string sp = 'SpBdiPRVpProveedorPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiPRVpProveedor, dt.Rows[0]);
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

	public bool Primero(ref clsBeBdiPRVpProveedor oBeBdiPRVpProveedor) {
		try {
			string sp = 'SpBdiPRVpProveedorUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiPRVpProveedor, dt.Rows[0]);
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

	public bool Anterior(ref clsBeBdiPRVpProveedor oBeBdiPRVpProveedor) {
		Try
			string sp = 'SpBdiPRVpProveedorAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@LIFNR", oBeBdiPRVpProveedor.LIFNR));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiPRVpProveedor, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeBdiPRVpProveedor oBeBdiPRVpProveedor) {
		Try
			string sp = 'SpBdiPRVpProveedorSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@LIFNR", oBeBdiPRVpProveedor.LIFNR));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiPRVpProveedor, dt.Rows[0]);
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
