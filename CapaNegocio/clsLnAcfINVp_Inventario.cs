using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfINVp_Inventario {

	private ConnectionManager oConexion = null;

	 public clsLnAcfINVp_Inventario(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfINVp_Inventario, ref DataRow dr) {
		try {
				oBeAcfINVp_Inventario.INVid = ( IsDBNull(dr.Item['INVid']) ? 0 : dr.Item['INVid'] )
				oBeAcfINVp_Inventario.INVdetalle = ( IsDBNull(dr.Item['INVdetalle']) ? '' : dr.Item['INVdetalle'] )
				oBeAcfINVp_Inventario.INVinicio = ( IsDBNull(dr.Item['INVinicio']) ? Date.Now() : dr.Item['INVinicio'] )
				oBeAcfINVp_Inventario.INVcierre = ( IsDBNull(dr.Item['INVcierre']) ? Date.Now() : dr.Item['INVcierre'] )
				oBeAcfINVp_Inventario.INVactivo = ( IsDBNull(dr.Item['INVactivo']) ? False : dr.Item['INVactivo'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfINVp_Inventario oBeAcfINVp_Inventario) {
		try {
			string sp = 'SpAcfINVp_InventarioInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVID", oBeAcfINVp_Inventario.INVid));
			cmd.Parameters("@INVID").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVDETALLE", oBeAcfINVp_Inventario.INVdetalle));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVINICIO", oBeAcfINVp_Inventario.INVinicio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVCIERRE", oBeAcfINVp_Inventario.INVcierre));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVACTIVO", oBeAcfINVp_Inventario.INVactivo));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfINVp_Inventario.INVid = int.Parse(cmd.Parameters['@INVID'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfINVp_Inventario oBeAcfINVp_Inventario) {
		try {
			string sp = 'SpAcfINVp_InventarioActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVID", oBeAcfINVp_Inventario.INVid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVDETALLE", oBeAcfINVp_Inventario.INVdetalle));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVINICIO", oBeAcfINVp_Inventario.INVinicio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVCIERRE", oBeAcfINVp_Inventario.INVcierre));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVACTIVO", oBeAcfINVp_Inventario.INVactivo));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfINVp_Inventario oBeAcfINVp_Inventario) {
		try {
			string sp = 'SpAcfINVp_InventarioEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVID", oBeAcfINVp_Inventario.INVid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfINVp_InventarioListar';
			
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

	public bool Obtener(ref clsBeAcfINVp_Inventario oBeAcfINVp_Inventario) {
		try {
			string sp = 'SpAcfINVp_InventarioObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@INVID", oBeAcfINVp_Inventario.INVid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfINVp_Inventario, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfINVp_Inventario oBeAcfINVp_Inventario) {
		Try
			string sp = 'SpAcfINVp_InventarioPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfINVp_Inventario, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfINVp_Inventario oBeAcfINVp_Inventario) {
		try {
			string sp = 'SpAcfINVp_InventarioUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfINVp_Inventario, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfINVp_Inventario oBeAcfINVp_Inventario) {
		Try
			string sp = 'SpAcfINVp_InventarioAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@INVID", oBeAcfINVp_Inventario.INVid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfINVp_Inventario, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfINVp_Inventario oBeAcfINVp_Inventario) {
		Try
			string sp = 'SpAcfINVp_InventarioSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@INVID", oBeAcfINVp_Inventario.INVid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfINVp_Inventario, dt.Rows[0]);
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
