using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfSELt_SistemaElectrico {

	private ConnectionManager oConexion = null;

	 public clsLnAcfSELt_SistemaElectrico(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfSELt_SistemaElectrico, ref DataRow dr) {
		try {
				oBeAcfSELt_SistemaElectrico.SELid = ( IsDBNull(dr.Item['SELid']) ? '' : dr.Item['SELid'] )
				oBeAcfSELt_SistemaElectrico.SELsistemaelectrico = ( IsDBNull(dr.Item['SELsistemaelectrico']) ? '' : dr.Item['SELsistemaelectrico'] )
				oBeAcfSELt_SistemaElectrico.SEGMENT = ( IsDBNull(dr.Item['SEGMENT']) ? '' : dr.Item['SEGMENT'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfSELt_SistemaElectrico oBeAcfSELt_SistemaElectrico) {
		try {
			string sp = 'SpAcfSELt_SistemaElectricoInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@SELID", oBeAcfSELt_SistemaElectrico.SELid));
			cmd.Parameters("@SELID").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@SELSISTEMAELECTRICO", oBeAcfSELt_SistemaElectrico.SELsistemaelectrico));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@SEGMENT", oBeAcfSELt_SistemaElectrico.SEGMENT));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfSELt_SistemaElectrico.SELid = Convert.ToString(cmd.Parameters['@SELID'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfSELt_SistemaElectrico oBeAcfSELt_SistemaElectrico) {
		try {
			string sp = 'SpAcfSELt_SistemaElectricoActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@SELID", oBeAcfSELt_SistemaElectrico.SELid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@SELSISTEMAELECTRICO", oBeAcfSELt_SistemaElectrico.SELsistemaelectrico));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@SEGMENT", oBeAcfSELt_SistemaElectrico.SEGMENT));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfSELt_SistemaElectrico oBeAcfSELt_SistemaElectrico) {
		try {
			string sp = 'SpAcfSELt_SistemaElectricoEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@SELID", oBeAcfSELt_SistemaElectrico.SELid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfSELt_SistemaElectricoListar';
			
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

	public bool Obtener(ref clsBeAcfSELt_SistemaElectrico oBeAcfSELt_SistemaElectrico) {
		try {
			string sp = 'SpAcfSELt_SistemaElectricoObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@SELID", oBeAcfSELt_SistemaElectrico.SELid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfSELt_SistemaElectrico, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfSELt_SistemaElectrico oBeAcfSELt_SistemaElectrico) {
		Try
			string sp = 'SpAcfSELt_SistemaElectricoPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfSELt_SistemaElectrico, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfSELt_SistemaElectrico oBeAcfSELt_SistemaElectrico) {
		try {
			string sp = 'SpAcfSELt_SistemaElectricoUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfSELt_SistemaElectrico, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfSELt_SistemaElectrico oBeAcfSELt_SistemaElectrico) {
		Try
			string sp = 'SpAcfSELt_SistemaElectricoAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@SELID", oBeAcfSELt_SistemaElectrico.SELid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfSELt_SistemaElectrico, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfSELt_SistemaElectrico oBeAcfSELt_SistemaElectrico) {
		Try
			string sp = 'SpAcfSELt_SistemaElectricoSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@SELID", oBeAcfSELt_SistemaElectrico.SELid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfSELt_SistemaElectrico, dt.Rows[0]);
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
