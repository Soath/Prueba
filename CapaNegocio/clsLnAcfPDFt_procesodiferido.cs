using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfPDFt_procesodiferido {

	private ConnectionManager oConexion = null;

	 public clsLnAcfPDFt_procesodiferido(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfPDFt_procesodiferido, ref DataRow dr) {
		try {
				oBeAcfPDFt_procesodiferido.PDFcodigo = ( IsDBNull(dr.Item['PDFcodigo']) ? 0 : dr.Item['PDFcodigo'] )
				oBeAcfPDFt_procesodiferido.PDFperiodo = ( IsDBNull(dr.Item['PDFperiodo']) ? '' : dr.Item['PDFperiodo'] )
				oBeAcfPDFt_procesodiferido.PDFfecha = ( IsDBNull(dr.Item['PDFfecha']) ? Date.Now() : dr.Item['PDFfecha'] )
				oBeAcfPDFt_procesodiferido.PDFreponsable = ( IsDBNull(dr.Item['PDFreponsable']) ? '' : dr.Item['PDFreponsable'] )
				oBeAcfPDFt_procesodiferido.PDFestado = ( IsDBNull(dr.Item['PDFestado']) ? False : dr.Item['PDFestado'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfPDFt_procesodiferido oBeAcfPDFt_procesodiferido) {
		try {
			string sp = 'SpAcfPDFt_procesodiferidoInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PDFCODIGO", oBeAcfPDFt_procesodiferido.PDFcodigo));
			cmd.Parameters("@PDFCODIGO").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PDFPERIODO", oBeAcfPDFt_procesodiferido.PDFperiodo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PDFFECHA", oBeAcfPDFt_procesodiferido.PDFfecha));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PDFREPONSABLE", oBeAcfPDFt_procesodiferido.PDFreponsable));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PDFESTADO", oBeAcfPDFt_procesodiferido.PDFestado));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfPDFt_procesodiferido.PDFcodigo = int.Parse(cmd.Parameters['@PDFCODIGO'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfPDFt_procesodiferido oBeAcfPDFt_procesodiferido) {
		try {
			string sp = 'SpAcfPDFt_procesodiferidoActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PDFCODIGO", oBeAcfPDFt_procesodiferido.PDFcodigo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PDFPERIODO", oBeAcfPDFt_procesodiferido.PDFperiodo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PDFFECHA", oBeAcfPDFt_procesodiferido.PDFfecha));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PDFREPONSABLE", oBeAcfPDFt_procesodiferido.PDFreponsable));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PDFESTADO", oBeAcfPDFt_procesodiferido.PDFestado));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfPDFt_procesodiferido oBeAcfPDFt_procesodiferido) {
		try {
			string sp = 'SpAcfPDFt_procesodiferidoEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PDFCODIGO", oBeAcfPDFt_procesodiferido.PDFcodigo));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfPDFt_procesodiferidoListar';
			
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

	public bool Obtener(ref clsBeAcfPDFt_procesodiferido oBeAcfPDFt_procesodiferido) {
		try {
			string sp = 'SpAcfPDFt_procesodiferidoObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@PDFCODIGO", oBeAcfPDFt_procesodiferido.PDFcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfPDFt_procesodiferido, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfPDFt_procesodiferido oBeAcfPDFt_procesodiferido) {
		Try
			string sp = 'SpAcfPDFt_procesodiferidoPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfPDFt_procesodiferido, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfPDFt_procesodiferido oBeAcfPDFt_procesodiferido) {
		try {
			string sp = 'SpAcfPDFt_procesodiferidoUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfPDFt_procesodiferido, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfPDFt_procesodiferido oBeAcfPDFt_procesodiferido) {
		Try
			string sp = 'SpAcfPDFt_procesodiferidoAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@PDFCODIGO", oBeAcfPDFt_procesodiferido.PDFcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfPDFt_procesodiferido, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfPDFt_procesodiferido oBeAcfPDFt_procesodiferido) {
		Try
			string sp = 'SpAcfPDFt_procesodiferidoSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@PDFCODIGO", oBeAcfPDFt_procesodiferido.PDFcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfPDFt_procesodiferido, dt.Rows[0]);
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
