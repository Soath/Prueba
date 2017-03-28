using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfDRTt_detallereparotributario {

	private ConnectionManager oConexion = null;

	 public clsLnAcfDRTt_detallereparotributario(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfDRTt_detallereparotributario, ref DataRow dr) {
		try {
				oBeAcfDRTt_detallereparotributario.RTRcodigo = ( IsDBNull(dr.Item['RTRcodigo']) ? 0 : dr.Item['RTRcodigo'] )
				oBeAcfDRTt_detallereparotributario.ACFcuenta = ( IsDBNull(dr.Item['ACFcuenta']) ? '' : dr.Item['ACFcuenta'] )
				oBeAcfDRTt_detallereparotributario.INVZU = ( IsDBNull(dr.Item['INVZU']) ? '' : dr.Item['INVZU'] )
				oBeAcfDRTt_detallereparotributario.TXT50 = ( IsDBNull(dr.Item['TXT50']) ? '' : dr.Item['TXT50'] )
				oBeAcfDRTt_detallereparotributario.ACFfactorniif = ( IsDBNull(dr.Item['ACFfactorniif']) ? 0.0 : dr.Item['ACFfactorniif'] )
				oBeAcfDRTt_detallereparotributario.ACFvutilniif = ( IsDBNull(dr.Item['ACFvutilniif']) ? 0.0 : dr.Item['ACFvutilniif'] )
				oBeAcfDRTt_detallereparotributario.ACFfactorTrib = ( IsDBNull(dr.Item['ACFfactorTrib']) ? 0.0 : dr.Item['ACFfactorTrib'] )
				oBeAcfDRTt_detallereparotributario.ACFvutiltrib = ( IsDBNull(dr.Item['ACFvutiltrib']) ? 0.0 : dr.Item['ACFvutiltrib'] )
				oBeAcfDRTt_detallereparotributario.ACFvalorniif = ( IsDBNull(dr.Item['ACFvalorniif']) ? 0.0 : dr.Item['ACFvalorniif'] )
				oBeAcfDRTt_detallereparotributario.ACFdepAcuniif = ( IsDBNull(dr.Item['ACFdepAcuniif']) ? 0.0 : dr.Item['ACFdepAcuniif'] )
				oBeAcfDRTt_detallereparotributario.ACFNiifNeto = ( IsDBNull(dr.Item['ACFNiifNeto']) ? 0.0 : dr.Item['ACFNiifNeto'] )
				oBeAcfDRTt_detallereparotributario.ACFDepNiifPer = ( IsDBNull(dr.Item['ACFDepNiifPer']) ? 0.0 : dr.Item['ACFDepNiifPer'] )
				oBeAcfDRTt_detallereparotributario.ACFvalortrib = ( IsDBNull(dr.Item['ACFvalortrib']) ? 0.0 : dr.Item['ACFvalortrib'] )
				oBeAcfDRTt_detallereparotributario.ACFdepacutrib = ( IsDBNull(dr.Item['ACFdepacutrib']) ? 0.0 : dr.Item['ACFdepacutrib'] )
				oBeAcfDRTt_detallereparotributario.ACFlirneto = ( IsDBNull(dr.Item['ACFlirneto']) ? 0.0 : dr.Item['ACFlirneto'] )
				oBeAcfDRTt_detallereparotributario.ACFdeptlirper = ( IsDBNull(dr.Item['ACFdeptlirper']) ? 0.0 : dr.Item['ACFdeptlirper'] )
				oBeAcfDRTt_detallereparotributario.ACFadiciones = ( IsDBNull(dr.Item['ACFadiciones']) ? 0.0 : dr.Item['ACFadiciones'] )
				oBeAcfDRTt_detallereparotributario.ACFdeducciones = ( IsDBNull(dr.Item['ACFdeducciones']) ? 0.0 : dr.Item['ACFdeducciones'] )
				oBeAcfDRTt_detallereparotributario.ACFneto = ( IsDBNull(dr.Item['ACFneto']) ? 0.0 : dr.Item['ACFneto'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfDRTt_detallereparotributario oBeAcfDRTt_detallereparotributario) {
		try {
			string sp = 'SpAcfDRTt_detallereparotributarioInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RTRCODIGO", oBeAcfDRTt_detallereparotributario.RTRcodigo));
			cmd.Parameters("@RTRCODIGO").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCUENTA", oBeAcfDRTt_detallereparotributario.ACFcuenta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVZU", oBeAcfDRTt_detallereparotributario.INVZU));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@TXT50", oBeAcfDRTt_detallereparotributario.TXT50));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFACTORNIIF", oBeAcfDRTt_detallereparotributario.ACFfactorniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILNIIF", oBeAcfDRTt_detallereparotributario.ACFvutilniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFACTORTRIB", oBeAcfDRTt_detallereparotributario.ACFfactorTrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILTRIB", oBeAcfDRTt_detallereparotributario.ACFvutiltrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORNIIF", oBeAcfDRTt_detallereparotributario.ACFvalorniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPACUNIIF", oBeAcfDRTt_detallereparotributario.ACFdepAcuniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFNIIFNETO", oBeAcfDRTt_detallereparotributario.ACFNiifNeto));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPNIIFPER", oBeAcfDRTt_detallereparotributario.ACFDepNiifPer));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORTRIB", oBeAcfDRTt_detallereparotributario.ACFvalortrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPACUTRIB", oBeAcfDRTt_detallereparotributario.ACFdepacutrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFLIRNETO", oBeAcfDRTt_detallereparotributario.ACFlirneto));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPTLIRPER", oBeAcfDRTt_detallereparotributario.ACFdeptlirper));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFADICIONES", oBeAcfDRTt_detallereparotributario.ACFadiciones));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEDUCCIONES", oBeAcfDRTt_detallereparotributario.ACFdeducciones));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFNETO", oBeAcfDRTt_detallereparotributario.ACFneto));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfDRTt_detallereparotributario.RTRcodigo = int.Parse(cmd.Parameters['@RTRCODIGO'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfDRTt_detallereparotributario oBeAcfDRTt_detallereparotributario) {
		try {
			string sp = 'SpAcfDRTt_detallereparotributarioActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RTRCODIGO", oBeAcfDRTt_detallereparotributario.RTRcodigo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCUENTA", oBeAcfDRTt_detallereparotributario.ACFcuenta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVZU", oBeAcfDRTt_detallereparotributario.INVZU));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@TXT50", oBeAcfDRTt_detallereparotributario.TXT50));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFACTORNIIF", oBeAcfDRTt_detallereparotributario.ACFfactorniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILNIIF", oBeAcfDRTt_detallereparotributario.ACFvutilniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFACTORTRIB", oBeAcfDRTt_detallereparotributario.ACFfactorTrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILTRIB", oBeAcfDRTt_detallereparotributario.ACFvutiltrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORNIIF", oBeAcfDRTt_detallereparotributario.ACFvalorniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPACUNIIF", oBeAcfDRTt_detallereparotributario.ACFdepAcuniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFNIIFNETO", oBeAcfDRTt_detallereparotributario.ACFNiifNeto));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPNIIFPER", oBeAcfDRTt_detallereparotributario.ACFDepNiifPer));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORTRIB", oBeAcfDRTt_detallereparotributario.ACFvalortrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPACUTRIB", oBeAcfDRTt_detallereparotributario.ACFdepacutrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFLIRNETO", oBeAcfDRTt_detallereparotributario.ACFlirneto));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPTLIRPER", oBeAcfDRTt_detallereparotributario.ACFdeptlirper));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFADICIONES", oBeAcfDRTt_detallereparotributario.ACFadiciones));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEDUCCIONES", oBeAcfDRTt_detallereparotributario.ACFdeducciones));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFNETO", oBeAcfDRTt_detallereparotributario.ACFneto));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfDRTt_detallereparotributario oBeAcfDRTt_detallereparotributario) {
		try {
			string sp = 'SpAcfDRTt_detallereparotributarioEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RTRCODIGO", oBeAcfDRTt_detallereparotributario.RTRcodigo));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfDRTt_detallereparotributarioListar';
			
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

	public bool Obtener(ref clsBeAcfDRTt_detallereparotributario oBeAcfDRTt_detallereparotributario) {
		try {
			string sp = 'SpAcfDRTt_detallereparotributarioObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@RTRCODIGO", oBeAcfDRTt_detallereparotributario.RTRcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfDRTt_detallereparotributario, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfDRTt_detallereparotributario oBeAcfDRTt_detallereparotributario) {
		Try
			string sp = 'SpAcfDRTt_detallereparotributarioPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfDRTt_detallereparotributario, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfDRTt_detallereparotributario oBeAcfDRTt_detallereparotributario) {
		try {
			string sp = 'SpAcfDRTt_detallereparotributarioUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfDRTt_detallereparotributario, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfDRTt_detallereparotributario oBeAcfDRTt_detallereparotributario) {
		Try
			string sp = 'SpAcfDRTt_detallereparotributarioAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@RTRCODIGO", oBeAcfDRTt_detallereparotributario.RTRcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfDRTt_detallereparotributario, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfDRTt_detallereparotributario oBeAcfDRTt_detallereparotributario) {
		Try
			string sp = 'SpAcfDRTt_detallereparotributarioSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@RTRCODIGO", oBeAcfDRTt_detallereparotributario.RTRcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfDRTt_detallereparotributario, dt.Rows[0]);
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
