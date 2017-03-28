using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnBdiSOCpSociedades {

	private ConnectionManager oConexion = null;

	 public clsLnBdiSOCpSociedades(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeBdiSOCpSociedades, ref DataRow dr) {
		try {
				oBeBdiSOCpSociedades.BUKRS = ( IsDBNull(dr.Item['BUKRS']) ? '' : dr.Item['BUKRS'] )
				oBeBdiSOCpSociedades.BUTXT = ( IsDBNull(dr.Item['BUTXT']) ? '' : dr.Item['BUTXT'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeBdiSOCpSociedades oBeBdiSOCpSociedades) {
		try {
			string sp = 'SpBdiSOCpSociedadesInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@BUKRS", oBeBdiSOCpSociedades.BUKRS));
			cmd.Parameters("@BUKRS").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@BUTXT", oBeBdiSOCpSociedades.BUTXT));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeBdiSOCpSociedades.BUKRS = Convert.ToString(cmd.Parameters['@BUKRS'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeBdiSOCpSociedades oBeBdiSOCpSociedades) {
		try {
			string sp = 'SpBdiSOCpSociedadesActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@BUKRS", oBeBdiSOCpSociedades.BUKRS));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@BUTXT", oBeBdiSOCpSociedades.BUTXT));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeBdiSOCpSociedades oBeBdiSOCpSociedades) {
		try {
			string sp = 'SpBdiSOCpSociedadesEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@BUKRS", oBeBdiSOCpSociedades.BUKRS));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpBdiSOCpSociedadesListar';
			
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

	public bool Obtener(ref clsBeBdiSOCpSociedades oBeBdiSOCpSociedades) {
		try {
			string sp = 'SpBdiSOCpSociedadesObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@BUKRS", oBeBdiSOCpSociedades.BUKRS));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiSOCpSociedades, dt.Rows(0))
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

	public bool Primero(ref clsBeBdiSOCpSociedades oBeBdiSOCpSociedades) {
		Try
			string sp = 'SpBdiSOCpSociedadesPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiSOCpSociedades, dt.Rows[0]);
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

	public bool Primero(ref clsBeBdiSOCpSociedades oBeBdiSOCpSociedades) {
		try {
			string sp = 'SpBdiSOCpSociedadesUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiSOCpSociedades, dt.Rows[0]);
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

	public bool Anterior(ref clsBeBdiSOCpSociedades oBeBdiSOCpSociedades) {
		Try
			string sp = 'SpBdiSOCpSociedadesAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@BUKRS", oBeBdiSOCpSociedades.BUKRS));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiSOCpSociedades, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeBdiSOCpSociedades oBeBdiSOCpSociedades) {
		Try
			string sp = 'SpBdiSOCpSociedadesSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@BUKRS", oBeBdiSOCpSociedades.BUKRS));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiSOCpSociedades, dt.Rows[0]);
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
