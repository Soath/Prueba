using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfLOCt_Local {

	private ConnectionManager oConexion = null;

	 public clsLnAcfLOCt_Local(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfLOCt_Local, ref DataRow dr) {
		try {
				oBeAcfLOCt_Local.LOCid = ( IsDBNull(dr.Item['LOCid']) ? 0 : dr.Item['LOCid'] )
				oBeAcfLOCt_Local.LOClocal = ( IsDBNull(dr.Item['LOClocal']) ? '' : dr.Item['LOClocal'] )
				oBeAcfLOCt_Local.LOCdireccion = ( IsDBNull(dr.Item['LOCdireccion']) ? '' : dr.Item['LOCdireccion'] )
				oBeAcfLOCt_Local.SEGMENT = ( IsDBNull(dr.Item['SEGMENT']) ? '' : dr.Item['SEGMENT'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfLOCt_Local oBeAcfLOCt_Local) {
		try {
			string sp = 'SpAcfLOCt_LocalInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LOCID", oBeAcfLOCt_Local.LOCid));
			cmd.Parameters("@LOCID").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LOCLOCAL", oBeAcfLOCt_Local.LOClocal));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LOCDIRECCION", oBeAcfLOCt_Local.LOCdireccion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@SEGMENT", oBeAcfLOCt_Local.SEGMENT));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfLOCt_Local.LOCid = int.Parse(cmd.Parameters['@LOCID'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfLOCt_Local oBeAcfLOCt_Local) {
		try {
			string sp = 'SpAcfLOCt_LocalActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LOCID", oBeAcfLOCt_Local.LOCid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LOCLOCAL", oBeAcfLOCt_Local.LOClocal));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LOCDIRECCION", oBeAcfLOCt_Local.LOCdireccion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@SEGMENT", oBeAcfLOCt_Local.SEGMENT));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfLOCt_Local oBeAcfLOCt_Local) {
		try {
			string sp = 'SpAcfLOCt_LocalEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LOCID", oBeAcfLOCt_Local.LOCid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfLOCt_LocalListar';
			
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

	public bool Obtener(ref clsBeAcfLOCt_Local oBeAcfLOCt_Local) {
		try {
			string sp = 'SpAcfLOCt_LocalObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@LOCID", oBeAcfLOCt_Local.LOCid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfLOCt_Local, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfLOCt_Local oBeAcfLOCt_Local) {
		Try
			string sp = 'SpAcfLOCt_LocalPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfLOCt_Local, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfLOCt_Local oBeAcfLOCt_Local) {
		try {
			string sp = 'SpAcfLOCt_LocalUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfLOCt_Local, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfLOCt_Local oBeAcfLOCt_Local) {
		Try
			string sp = 'SpAcfLOCt_LocalAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@LOCID", oBeAcfLOCt_Local.LOCid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfLOCt_Local, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfLOCt_Local oBeAcfLOCt_Local) {
		Try
			string sp = 'SpAcfLOCt_LocalSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@LOCID", oBeAcfLOCt_Local.LOCid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfLOCt_Local, dt.Rows[0]);
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
