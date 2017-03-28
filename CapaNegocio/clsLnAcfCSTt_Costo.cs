using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfCSTt_Costo {

	private ConnectionManager oConexion = null;

	 public clsLnAcfCSTt_Costo(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfCSTt_Costo, ref DataRow dr) {
		try {
				oBeAcfCSTt_Costo.CSTid = ( IsDBNull(dr.Item['CSTid']) ? '' : dr.Item['CSTid'] )
				oBeAcfCSTt_Costo.CSTdescripcion = ( IsDBNull(dr.Item['CSTdescripcion']) ? '' : dr.Item['CSTdescripcion'] )
				oBeAcfCSTt_Costo.CSTdetalle = ( IsDBNull(dr.Item['CSTdetalle']) ? '' : dr.Item['CSTdetalle'] )
				oBeAcfCSTt_Costo.CSTabreviado = ( IsDBNull(dr.Item['CSTabreviado']) ? '' : dr.Item['CSTabreviado'] )
				oBeAcfCSTt_Costo.ACTid = ( IsDBNull(dr.Item['ACTid']) ? '' : dr.Item['ACTid'] )
				oBeAcfCSTt_Costo.CSTid_costo = ( IsDBNull(dr.Item['CSTid_costo']) ? '' : dr.Item['CSTid_costo'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfCSTt_Costo oBeAcfCSTt_Costo) {
		try {
			string sp = 'SpAcfCSTt_CostoInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CSTID", oBeAcfCSTt_Costo.CSTid));
			cmd.Parameters("@CSTID").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CSTDESCRIPCION", oBeAcfCSTt_Costo.CSTdescripcion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CSTDETALLE", oBeAcfCSTt_Costo.CSTdetalle));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CSTABREVIADO", oBeAcfCSTt_Costo.CSTabreviado));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACTID", oBeAcfCSTt_Costo.ACTid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CSTID_COSTO", oBeAcfCSTt_Costo.CSTid_costo));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfCSTt_Costo.CSTid = Convert.ToString(cmd.Parameters['@CSTID'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfCSTt_Costo oBeAcfCSTt_Costo) {
		try {
			string sp = 'SpAcfCSTt_CostoActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CSTID", oBeAcfCSTt_Costo.CSTid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CSTDESCRIPCION", oBeAcfCSTt_Costo.CSTdescripcion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CSTDETALLE", oBeAcfCSTt_Costo.CSTdetalle));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CSTABREVIADO", oBeAcfCSTt_Costo.CSTabreviado));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACTID", oBeAcfCSTt_Costo.ACTid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CSTID_COSTO", oBeAcfCSTt_Costo.CSTid_costo));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfCSTt_Costo oBeAcfCSTt_Costo) {
		try {
			string sp = 'SpAcfCSTt_CostoEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CSTID", oBeAcfCSTt_Costo.CSTid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfCSTt_CostoListar';
			
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

	public bool Obtener(ref clsBeAcfCSTt_Costo oBeAcfCSTt_Costo) {
		try {
			string sp = 'SpAcfCSTt_CostoObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@CSTID", oBeAcfCSTt_Costo.CSTid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfCSTt_Costo, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfCSTt_Costo oBeAcfCSTt_Costo) {
		Try
			string sp = 'SpAcfCSTt_CostoPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfCSTt_Costo, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfCSTt_Costo oBeAcfCSTt_Costo) {
		try {
			string sp = 'SpAcfCSTt_CostoUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfCSTt_Costo, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfCSTt_Costo oBeAcfCSTt_Costo) {
		Try
			string sp = 'SpAcfCSTt_CostoAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@CSTID", oBeAcfCSTt_Costo.CSTid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfCSTt_Costo, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfCSTt_Costo oBeAcfCSTt_Costo) {
		Try
			string sp = 'SpAcfCSTt_CostoSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@CSTID", oBeAcfCSTt_Costo.CSTid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfCSTt_Costo, dt.Rows[0]);
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
