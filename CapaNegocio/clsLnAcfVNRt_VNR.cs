using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfVNRt_VNR {

	private ConnectionManager oConexion = null;

	 public clsLnAcfVNRt_VNR(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfVNRt_VNR, ref DataRow dr) {
		try {
				oBeAcfVNRt_VNR.VNRid = ( IsDBNull(dr.Item['VNRid']) ? '' : dr.Item['VNRid'] )
				oBeAcfVNRt_VNR.VNRvnr = ( IsDBNull(dr.Item['VNRvnr']) ? '' : dr.Item['VNRvnr'] )
				oBeAcfVNRt_VNR.VNRcuenta = ( IsDBNull(dr.Item['VNRcuenta']) ? '' : dr.Item['VNRcuenta'] )
				oBeAcfVNRt_VNR.VNRcuentadep = ( IsDBNull(dr.Item['VNRcuentadep']) ? '' : dr.Item['VNRcuentadep'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfVNRt_VNR oBeAcfVNRt_VNR) {
		try {
			string sp = 'SpAcfVNRt_VNRInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@VNRID", oBeAcfVNRt_VNR.VNRid));
			cmd.Parameters("@VNRID").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@VNRVNR", oBeAcfVNRt_VNR.VNRvnr));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@VNRCUENTA", oBeAcfVNRt_VNR.VNRcuenta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@VNRCUENTADEP", oBeAcfVNRt_VNR.VNRcuentadep));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfVNRt_VNR.VNRid = Convert.ToString(cmd.Parameters['@VNRID'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfVNRt_VNR oBeAcfVNRt_VNR) {
		try {
			string sp = 'SpAcfVNRt_VNRActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@VNRID", oBeAcfVNRt_VNR.VNRid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@VNRVNR", oBeAcfVNRt_VNR.VNRvnr));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@VNRCUENTA", oBeAcfVNRt_VNR.VNRcuenta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@VNRCUENTADEP", oBeAcfVNRt_VNR.VNRcuentadep));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfVNRt_VNR oBeAcfVNRt_VNR) {
		try {
			string sp = 'SpAcfVNRt_VNREliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@VNRID", oBeAcfVNRt_VNR.VNRid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfVNRt_VNRListar';
			
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

	public bool Obtener(ref clsBeAcfVNRt_VNR oBeAcfVNRt_VNR) {
		try {
			string sp = 'SpAcfVNRt_VNRObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@VNRID", oBeAcfVNRt_VNR.VNRid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfVNRt_VNR, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfVNRt_VNR oBeAcfVNRt_VNR) {
		Try
			string sp = 'SpAcfVNRt_VNRPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfVNRt_VNR, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfVNRt_VNR oBeAcfVNRt_VNR) {
		try {
			string sp = 'SpAcfVNRt_VNRUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfVNRt_VNR, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfVNRt_VNR oBeAcfVNRt_VNR) {
		Try
			string sp = 'SpAcfVNRt_VNRAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@VNRID", oBeAcfVNRt_VNR.VNRid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfVNRt_VNR, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfVNRt_VNR oBeAcfVNRt_VNR) {
		Try
			string sp = 'SpAcfVNRt_VNRSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@VNRID", oBeAcfVNRt_VNR.VNRid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfVNRt_VNR, dt.Rows[0]);
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
