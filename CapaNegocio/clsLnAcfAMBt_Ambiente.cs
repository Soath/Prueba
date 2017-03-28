using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfAMBt_Ambiente {

	private ConnectionManager oConexion = null;

	 public clsLnAcfAMBt_Ambiente(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfAMBt_Ambiente, ref DataRow dr) {
		try {
				oBeAcfAMBt_Ambiente.LOCid = ( IsDBNull(dr.Item['LOCid']) ? 0 : dr.Item['LOCid'] )
				oBeAcfAMBt_Ambiente.AMBid = ( IsDBNull(dr.Item['AMBid']) ? 0 : dr.Item['AMBid'] )
				oBeAcfAMBt_Ambiente.AMBambiente = ( IsDBNull(dr.Item['AMBambiente']) ? '' : dr.Item['AMBambiente'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfAMBt_Ambiente oBeAcfAMBt_Ambiente) {
		try {
			string sp = 'SpAcfAMBt_AmbienteInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LOCID", oBeAcfAMBt_Ambiente.LOCid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@AMBID", oBeAcfAMBt_Ambiente.AMBid));
			cmd.Parameters("@AMBID").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@AMBAMBIENTE", oBeAcfAMBt_Ambiente.AMBambiente));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfAMBt_Ambiente.AMBid = int.Parse(cmd.Parameters['@AMBID'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfAMBt_Ambiente oBeAcfAMBt_Ambiente) {
		try {
			string sp = 'SpAcfAMBt_AmbienteActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LOCID", oBeAcfAMBt_Ambiente.LOCid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@AMBID", oBeAcfAMBt_Ambiente.AMBid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@AMBAMBIENTE", oBeAcfAMBt_Ambiente.AMBambiente));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfAMBt_Ambiente oBeAcfAMBt_Ambiente) {
		try {
			string sp = 'SpAcfAMBt_AmbienteEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@AMBID", oBeAcfAMBt_Ambiente.AMBid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfAMBt_AmbienteListar';
			
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

	public bool Obtener(ref clsBeAcfAMBt_Ambiente oBeAcfAMBt_Ambiente) {
		try {
			string sp = 'SpAcfAMBt_AmbienteObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@AMBID", oBeAcfAMBt_Ambiente.AMBid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfAMBt_Ambiente, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfAMBt_Ambiente oBeAcfAMBt_Ambiente) {
		Try
			string sp = 'SpAcfAMBt_AmbientePrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfAMBt_Ambiente, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfAMBt_Ambiente oBeAcfAMBt_Ambiente) {
		try {
			string sp = 'SpAcfAMBt_AmbienteUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfAMBt_Ambiente, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfAMBt_Ambiente oBeAcfAMBt_Ambiente) {
		Try
			string sp = 'SpAcfAMBt_AmbienteAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@AMBID", oBeAcfAMBt_Ambiente.AMBid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfAMBt_Ambiente, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfAMBt_Ambiente oBeAcfAMBt_Ambiente) {
		Try
			string sp = 'SpAcfAMBt_AmbienteSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@AMBID", oBeAcfAMBt_Ambiente.AMBid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfAMBt_Ambiente, dt.Rows[0]);
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
