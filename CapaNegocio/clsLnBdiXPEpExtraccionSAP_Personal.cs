using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnBdiXPEpExtraccionSAP_Personal {

	private ConnectionManager oConexion = null;

	 public clsLnBdiXPEpExtraccionSAP_Personal(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeBdiXPEpExtraccionSAP_Personal, ref DataRow dr) {
		try {
				oBeBdiXPEpExtraccionSAP_Personal.PERNR = ( IsDBNull(dr.Item['PERNR']) ? '' : dr.Item['PERNR'] )
				oBeBdiXPEpExtraccionSAP_Personal.Nachn = ( IsDBNull(dr.Item['Nachn']) ? '' : dr.Item['Nachn'] )
				oBeBdiXPEpExtraccionSAP_Personal.Name2 = ( IsDBNull(dr.Item['Name2']) ? '' : dr.Item['Name2'] )
				oBeBdiXPEpExtraccionSAP_Personal.Vorna = ( IsDBNull(dr.Item['Vorna']) ? '' : dr.Item['Vorna'] )
				oBeBdiXPEpExtraccionSAP_Personal.DNI = ( IsDBNull(dr.Item['DNI']) ? '' : dr.Item['DNI'] )
				oBeBdiXPEpExtraccionSAP_Personal.WERKS = ( IsDBNull(dr.Item['WERKS']) ? '' : dr.Item['WERKS'] )
				oBeBdiXPEpExtraccionSAP_Personal.Persg = ( IsDBNull(dr.Item['Persg']) ? '' : dr.Item['Persg'] )
				oBeBdiXPEpExtraccionSAP_Personal.KOSTL = ( IsDBNull(dr.Item['KOSTL']) ? '' : dr.Item['KOSTL'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeBdiXPEpExtraccionSAP_Personal oBeBdiXPEpExtraccionSAP_Personal) {
		try {
			string sp = 'SpBdiXPEpExtraccionSAP_PersonalInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PERNR", oBeBdiXPEpExtraccionSAP_Personal.PERNR));
			cmd.Parameters("@PERNR").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@NACHN", oBeBdiXPEpExtraccionSAP_Personal.Nachn));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@NAME2", oBeBdiXPEpExtraccionSAP_Personal.Name2));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@VORNA", oBeBdiXPEpExtraccionSAP_Personal.Vorna));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@DNI", oBeBdiXPEpExtraccionSAP_Personal.DNI));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@WERKS", oBeBdiXPEpExtraccionSAP_Personal.WERKS));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PERSG", oBeBdiXPEpExtraccionSAP_Personal.Persg));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@KOSTL", oBeBdiXPEpExtraccionSAP_Personal.KOSTL));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeBdiXPEpExtraccionSAP_Personal.PERNR = Convert.ToString(cmd.Parameters['@PERNR'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeBdiXPEpExtraccionSAP_Personal oBeBdiXPEpExtraccionSAP_Personal) {
		try {
			string sp = 'SpBdiXPEpExtraccionSAP_PersonalActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PERNR", oBeBdiXPEpExtraccionSAP_Personal.PERNR));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@NACHN", oBeBdiXPEpExtraccionSAP_Personal.Nachn));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@NAME2", oBeBdiXPEpExtraccionSAP_Personal.Name2));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@VORNA", oBeBdiXPEpExtraccionSAP_Personal.Vorna));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@DNI", oBeBdiXPEpExtraccionSAP_Personal.DNI));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@WERKS", oBeBdiXPEpExtraccionSAP_Personal.WERKS));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PERSG", oBeBdiXPEpExtraccionSAP_Personal.Persg));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@KOSTL", oBeBdiXPEpExtraccionSAP_Personal.KOSTL));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeBdiXPEpExtraccionSAP_Personal oBeBdiXPEpExtraccionSAP_Personal) {
		try {
			string sp = 'SpBdiXPEpExtraccionSAP_PersonalEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PERNR", oBeBdiXPEpExtraccionSAP_Personal.PERNR));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpBdiXPEpExtraccionSAP_PersonalListar';
			
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

	public bool Obtener(ref clsBeBdiXPEpExtraccionSAP_Personal oBeBdiXPEpExtraccionSAP_Personal) {
		try {
			string sp = 'SpBdiXPEpExtraccionSAP_PersonalObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@PERNR", oBeBdiXPEpExtraccionSAP_Personal.PERNR));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiXPEpExtraccionSAP_Personal, dt.Rows(0))
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

	public bool Primero(ref clsBeBdiXPEpExtraccionSAP_Personal oBeBdiXPEpExtraccionSAP_Personal) {
		Try
			string sp = 'SpBdiXPEpExtraccionSAP_PersonalPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiXPEpExtraccionSAP_Personal, dt.Rows[0]);
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

	public bool Primero(ref clsBeBdiXPEpExtraccionSAP_Personal oBeBdiXPEpExtraccionSAP_Personal) {
		try {
			string sp = 'SpBdiXPEpExtraccionSAP_PersonalUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiXPEpExtraccionSAP_Personal, dt.Rows[0]);
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

	public bool Anterior(ref clsBeBdiXPEpExtraccionSAP_Personal oBeBdiXPEpExtraccionSAP_Personal) {
		Try
			string sp = 'SpBdiXPEpExtraccionSAP_PersonalAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@PERNR", oBeBdiXPEpExtraccionSAP_Personal.PERNR));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiXPEpExtraccionSAP_Personal, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeBdiXPEpExtraccionSAP_Personal oBeBdiXPEpExtraccionSAP_Personal) {
		Try
			string sp = 'SpBdiXPEpExtraccionSAP_PersonalSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@PERNR", oBeBdiXPEpExtraccionSAP_Personal.PERNR));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiXPEpExtraccionSAP_Personal, dt.Rows[0]);
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
