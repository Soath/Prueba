using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnBdiXCCpExtraccionSAP_CentroCosto {

	private ConnectionManager oConexion = null;

	 public clsLnBdiXCCpExtraccionSAP_CentroCosto(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeBdiXCCpExtraccionSAP_CentroCosto, ref DataRow dr) {
		try {
				oBeBdiXCCpExtraccionSAP_CentroCosto.KOSTL = ( IsDBNull(dr.Item['KOSTL']) ? '' : dr.Item['KOSTL'] )
				oBeBdiXCCpExtraccionSAP_CentroCosto.KTEXT = ( IsDBNull(dr.Item['KTEXT']) ? '' : dr.Item['KTEXT'] )
				oBeBdiXCCpExtraccionSAP_CentroCosto.KLTXT = ( IsDBNull(dr.Item['KLTXT']) ? '' : dr.Item['KLTXT'] )
				oBeBdiXCCpExtraccionSAP_CentroCosto.MCDS3 = ( IsDBNull(dr.Item['MCDS3']) ? '' : dr.Item['MCDS3'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeBdiXCCpExtraccionSAP_CentroCosto oBeBdiXCCpExtraccionSAP_CentroCosto) {
		try {
			string sp = 'SpBdiXCCpExtraccionSAP_CentroCostoInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@KOSTL", oBeBdiXCCpExtraccionSAP_CentroCosto.KOSTL));
			cmd.Parameters("@KOSTL").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@KTEXT", oBeBdiXCCpExtraccionSAP_CentroCosto.KTEXT));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@KLTXT", oBeBdiXCCpExtraccionSAP_CentroCosto.KLTXT));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MCDS3", oBeBdiXCCpExtraccionSAP_CentroCosto.MCDS3));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeBdiXCCpExtraccionSAP_CentroCosto.KOSTL = Convert.ToString(cmd.Parameters['@KOSTL'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeBdiXCCpExtraccionSAP_CentroCosto oBeBdiXCCpExtraccionSAP_CentroCosto) {
		try {
			string sp = 'SpBdiXCCpExtraccionSAP_CentroCostoActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@KOSTL", oBeBdiXCCpExtraccionSAP_CentroCosto.KOSTL));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@KTEXT", oBeBdiXCCpExtraccionSAP_CentroCosto.KTEXT));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@KLTXT", oBeBdiXCCpExtraccionSAP_CentroCosto.KLTXT));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MCDS3", oBeBdiXCCpExtraccionSAP_CentroCosto.MCDS3));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeBdiXCCpExtraccionSAP_CentroCosto oBeBdiXCCpExtraccionSAP_CentroCosto) {
		try {
			string sp = 'SpBdiXCCpExtraccionSAP_CentroCostoEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@KOSTL", oBeBdiXCCpExtraccionSAP_CentroCosto.KOSTL));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpBdiXCCpExtraccionSAP_CentroCostoListar';
			
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

	public bool Obtener(ref clsBeBdiXCCpExtraccionSAP_CentroCosto oBeBdiXCCpExtraccionSAP_CentroCosto) {
		try {
			string sp = 'SpBdiXCCpExtraccionSAP_CentroCostoObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@KOSTL", oBeBdiXCCpExtraccionSAP_CentroCosto.KOSTL));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiXCCpExtraccionSAP_CentroCosto, dt.Rows(0))
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

	public bool Primero(ref clsBeBdiXCCpExtraccionSAP_CentroCosto oBeBdiXCCpExtraccionSAP_CentroCosto) {
		Try
			string sp = 'SpBdiXCCpExtraccionSAP_CentroCostoPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiXCCpExtraccionSAP_CentroCosto, dt.Rows[0]);
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

	public bool Primero(ref clsBeBdiXCCpExtraccionSAP_CentroCosto oBeBdiXCCpExtraccionSAP_CentroCosto) {
		try {
			string sp = 'SpBdiXCCpExtraccionSAP_CentroCostoUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiXCCpExtraccionSAP_CentroCosto, dt.Rows[0]);
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

	public bool Anterior(ref clsBeBdiXCCpExtraccionSAP_CentroCosto oBeBdiXCCpExtraccionSAP_CentroCosto) {
		Try
			string sp = 'SpBdiXCCpExtraccionSAP_CentroCostoAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@KOSTL", oBeBdiXCCpExtraccionSAP_CentroCosto.KOSTL));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiXCCpExtraccionSAP_CentroCosto, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeBdiXCCpExtraccionSAP_CentroCosto oBeBdiXCCpExtraccionSAP_CentroCosto) {
		Try
			string sp = 'SpBdiXCCpExtraccionSAP_CentroCostoSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@KOSTL", oBeBdiXCCpExtraccionSAP_CentroCosto.KOSTL));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiXCCpExtraccionSAP_CentroCosto, dt.Rows[0]);
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
