using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnBdiSEGpSegmento {

	private ConnectionManager oConexion = null;

	 public clsLnBdiSEGpSegmento(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeBdiSEGpSegmento, ref DataRow dr) {
		try {
				oBeBdiSEGpSegmento.SEGMENT = ( IsDBNull(dr.Item['SEGMENT']) ? '' : dr.Item['SEGMENT'] )
				oBeBdiSEGpSegmento.NAME = ( IsDBNull(dr.Item['NAME']) ? '' : dr.Item['NAME'] )
				oBeBdiSEGpSegmento.Id_zona = ( IsDBNull(dr.Item['id_zona']) ? '' : dr.Item['id_zona'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeBdiSEGpSegmento oBeBdiSEGpSegmento) {
		try {
			string sp = 'SpBdiSEGpSegmentoInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@SEGMENT", oBeBdiSEGpSegmento.SEGMENT));
			cmd.Parameters("@SEGMENT").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@NAME", oBeBdiSEGpSegmento.NAME));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ID_ZONA", oBeBdiSEGpSegmento.Id_zona));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeBdiSEGpSegmento.SEGMENT = Convert.ToString(cmd.Parameters['@SEGMENT'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeBdiSEGpSegmento oBeBdiSEGpSegmento) {
		try {
			string sp = 'SpBdiSEGpSegmentoActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@SEGMENT", oBeBdiSEGpSegmento.SEGMENT));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@NAME", oBeBdiSEGpSegmento.NAME));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ID_ZONA", oBeBdiSEGpSegmento.Id_zona));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeBdiSEGpSegmento oBeBdiSEGpSegmento) {
		try {
			string sp = 'SpBdiSEGpSegmentoEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@SEGMENT", oBeBdiSEGpSegmento.SEGMENT));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpBdiSEGpSegmentoListar';
			
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

	public bool Obtener(ref clsBeBdiSEGpSegmento oBeBdiSEGpSegmento) {
		try {
			string sp = 'SpBdiSEGpSegmentoObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@SEGMENT", oBeBdiSEGpSegmento.SEGMENT));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiSEGpSegmento, dt.Rows(0))
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

	public bool Primero(ref clsBeBdiSEGpSegmento oBeBdiSEGpSegmento) {
		Try
			string sp = 'SpBdiSEGpSegmentoPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiSEGpSegmento, dt.Rows[0]);
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

	public bool Primero(ref clsBeBdiSEGpSegmento oBeBdiSEGpSegmento) {
		try {
			string sp = 'SpBdiSEGpSegmentoUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiSEGpSegmento, dt.Rows[0]);
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

	public bool Anterior(ref clsBeBdiSEGpSegmento oBeBdiSEGpSegmento) {
		Try
			string sp = 'SpBdiSEGpSegmentoAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@SEGMENT", oBeBdiSEGpSegmento.SEGMENT));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiSEGpSegmento, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeBdiSEGpSegmento oBeBdiSEGpSegmento) {
		Try
			string sp = 'SpBdiSEGpSegmentoSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@SEGMENT", oBeBdiSEGpSegmento.SEGMENT));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeBdiSEGpSegmento, dt.Rows[0]);
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
