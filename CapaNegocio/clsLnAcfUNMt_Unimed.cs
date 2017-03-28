using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfUNMt_Unimed {

	private ConnectionManager oConexion = null;

	 public clsLnAcfUNMt_Unimed(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfUNMt_Unimed, ref DataRow dr) {
		try {
				oBeAcfUNMt_Unimed.UNMid = ( IsDBNull(dr.Item['UNMid']) ? 0 : dr.Item['UNMid'] )
				oBeAcfUNMt_Unimed.UNMunidad = ( IsDBNull(dr.Item['UNMunidad']) ? '' : dr.Item['UNMunidad'] )
				oBeAcfUNMt_Unimed.UNMdetalle = ( IsDBNull(dr.Item['UNMdetalle']) ? '' : dr.Item['UNMdetalle'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfUNMt_Unimed oBeAcfUNMt_Unimed) {
		try {
			string sp = 'SpAcfUNMt_UnimedInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UNMID", oBeAcfUNMt_Unimed.UNMid));
			cmd.Parameters("@UNMID").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UNMUNIDAD", oBeAcfUNMt_Unimed.UNMunidad));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UNMDETALLE", oBeAcfUNMt_Unimed.UNMdetalle));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfUNMt_Unimed.UNMid = int.Parse(cmd.Parameters['@UNMID'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfUNMt_Unimed oBeAcfUNMt_Unimed) {
		try {
			string sp = 'SpAcfUNMt_UnimedActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UNMID", oBeAcfUNMt_Unimed.UNMid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UNMUNIDAD", oBeAcfUNMt_Unimed.UNMunidad));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UNMDETALLE", oBeAcfUNMt_Unimed.UNMdetalle));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfUNMt_Unimed oBeAcfUNMt_Unimed) {
		try {
			string sp = 'SpAcfUNMt_UnimedEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UNMID", oBeAcfUNMt_Unimed.UNMid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfUNMt_UnimedListar';
			
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

	public bool Obtener(ref clsBeAcfUNMt_Unimed oBeAcfUNMt_Unimed) {
		try {
			string sp = 'SpAcfUNMt_UnimedObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@UNMID", oBeAcfUNMt_Unimed.UNMid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfUNMt_Unimed, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfUNMt_Unimed oBeAcfUNMt_Unimed) {
		Try
			string sp = 'SpAcfUNMt_UnimedPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfUNMt_Unimed, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfUNMt_Unimed oBeAcfUNMt_Unimed) {
		try {
			string sp = 'SpAcfUNMt_UnimedUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfUNMt_Unimed, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfUNMt_Unimed oBeAcfUNMt_Unimed) {
		Try
			string sp = 'SpAcfUNMt_UnimedAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@UNMID", oBeAcfUNMt_Unimed.UNMid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfUNMt_Unimed, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfUNMt_Unimed oBeAcfUNMt_Unimed) {
		Try
			string sp = 'SpAcfUNMt_UnimedSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@UNMID", oBeAcfUNMt_Unimed.UNMid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfUNMt_Unimed, dt.Rows[0]);
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
