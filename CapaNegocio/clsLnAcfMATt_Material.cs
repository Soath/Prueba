using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfMATt_Material {

	private ConnectionManager oConexion = null;

	 public clsLnAcfMATt_Material(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfMATt_Material, ref DataRow dr) {
		try {
				oBeAcfMATt_Material.MATid = ( IsDBNull(dr.Item['MATid']) ? 0 : dr.Item['MATid'] )
				oBeAcfMATt_Material.MATmaterial = ( IsDBNull(dr.Item['MATmaterial']) ? '' : dr.Item['MATmaterial'] )
				oBeAcfMATt_Material.MATabreviado = ( IsDBNull(dr.Item['MATabreviado']) ? '' : dr.Item['MATabreviado'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfMATt_Material oBeAcfMATt_Material) {
		try {
			string sp = 'SpAcfMATt_MaterialInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MATID", oBeAcfMATt_Material.MATid));
			cmd.Parameters("@MATID").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MATMATERIAL", oBeAcfMATt_Material.MATmaterial));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MATABREVIADO", oBeAcfMATt_Material.MATabreviado));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfMATt_Material.MATid = int.Parse(cmd.Parameters['@MATID'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfMATt_Material oBeAcfMATt_Material) {
		try {
			string sp = 'SpAcfMATt_MaterialActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MATID", oBeAcfMATt_Material.MATid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MATMATERIAL", oBeAcfMATt_Material.MATmaterial));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MATABREVIADO", oBeAcfMATt_Material.MATabreviado));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfMATt_Material oBeAcfMATt_Material) {
		try {
			string sp = 'SpAcfMATt_MaterialEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MATID", oBeAcfMATt_Material.MATid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfMATt_MaterialListar';
			
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

	public bool Obtener(ref clsBeAcfMATt_Material oBeAcfMATt_Material) {
		try {
			string sp = 'SpAcfMATt_MaterialObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@MATID", oBeAcfMATt_Material.MATid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfMATt_Material, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfMATt_Material oBeAcfMATt_Material) {
		Try
			string sp = 'SpAcfMATt_MaterialPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfMATt_Material, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfMATt_Material oBeAcfMATt_Material) {
		try {
			string sp = 'SpAcfMATt_MaterialUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfMATt_Material, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfMATt_Material oBeAcfMATt_Material) {
		Try
			string sp = 'SpAcfMATt_MaterialAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@MATID", oBeAcfMATt_Material.MATid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfMATt_Material, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfMATt_Material oBeAcfMATt_Material) {
		Try
			string sp = 'SpAcfMATt_MaterialSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@MATID", oBeAcfMATt_Material.MATid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfMATt_Material, dt.Rows[0]);
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
