using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfSPNt_Supranumero {

	private ConnectionManager oConexion = null;

	 public clsLnAcfSPNt_Supranumero(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfSPNt_Supranumero, ref DataRow dr) {
		try {
				oBeAcfSPNt_Supranumero.V_T087U_ANLUE = ( IsDBNull(dr.Item['V_T087U_ANLUE']) ? '' : dr.Item['V_T087U_ANLUE'] )
				oBeAcfSPNt_Supranumero.V_T087U_ANLUE_TXT = ( IsDBNull(dr.Item['V_T087U_ANLUE_TXT']) ? '' : dr.Item['V_T087U_ANLUE_TXT'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfSPNt_Supranumero oBeAcfSPNt_Supranumero) {
		try {
			string sp = 'SpAcfSPNt_SupranumeroInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@V_T087U_ANLUE", oBeAcfSPNt_Supranumero.V_T087U_ANLUE));
			cmd.Parameters("@V_T087U_ANLUE").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@V_T087U_ANLUE_TXT", oBeAcfSPNt_Supranumero.V_T087U_ANLUE_TXT));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfSPNt_Supranumero.V_T087U_ANLUE = Convert.ToString(cmd.Parameters['@V_T087U_ANLUE'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfSPNt_Supranumero oBeAcfSPNt_Supranumero) {
		try {
			string sp = 'SpAcfSPNt_SupranumeroActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@V_T087U_ANLUE", oBeAcfSPNt_Supranumero.V_T087U_ANLUE));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@V_T087U_ANLUE_TXT", oBeAcfSPNt_Supranumero.V_T087U_ANLUE_TXT));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfSPNt_Supranumero oBeAcfSPNt_Supranumero) {
		try {
			string sp = 'SpAcfSPNt_SupranumeroEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@V_T087U_ANLUE", oBeAcfSPNt_Supranumero.V_T087U_ANLUE));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfSPNt_SupranumeroListar';
			
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

	public bool Obtener(ref clsBeAcfSPNt_Supranumero oBeAcfSPNt_Supranumero) {
		try {
			string sp = 'SpAcfSPNt_SupranumeroObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@V_T087U_ANLUE", oBeAcfSPNt_Supranumero.V_T087U_ANLUE));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfSPNt_Supranumero, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfSPNt_Supranumero oBeAcfSPNt_Supranumero) {
		Try
			string sp = 'SpAcfSPNt_SupranumeroPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfSPNt_Supranumero, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfSPNt_Supranumero oBeAcfSPNt_Supranumero) {
		try {
			string sp = 'SpAcfSPNt_SupranumeroUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfSPNt_Supranumero, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfSPNt_Supranumero oBeAcfSPNt_Supranumero) {
		Try
			string sp = 'SpAcfSPNt_SupranumeroAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@V_T087U_ANLUE", oBeAcfSPNt_Supranumero.V_T087U_ANLUE));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfSPNt_Supranumero, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfSPNt_Supranumero oBeAcfSPNt_Supranumero) {
		Try
			string sp = 'SpAcfSPNt_SupranumeroSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@V_T087U_ANLUE", oBeAcfSPNt_Supranumero.V_T087U_ANLUE));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfSPNt_Supranumero, dt.Rows[0]);
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
