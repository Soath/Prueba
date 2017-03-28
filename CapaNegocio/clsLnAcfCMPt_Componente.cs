using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfCMPt_Componente {

	private ConnectionManager oConexion = null;

	 public clsLnAcfCMPt_Componente(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfCMPt_Componente, ref DataRow dr) {
		try {
				oBeAcfCMPt_Componente.CMPid = ( IsDBNull(dr.Item['CMPid']) ? '' : dr.Item['CMPid'] )
				oBeAcfCMPt_Componente.CMPcomponente = ( IsDBNull(dr.Item['CMPcomponente']) ? '' : dr.Item['CMPcomponente'] )
				oBeAcfCMPt_Componente.CMPusoestimado = ( IsDBNull(dr.Item['CMPusoestimado']) ? 0.0 : dr.Item['CMPusoestimado'] )
				oBeAcfCMPt_Componente.CMPconservacion = ( IsDBNull(dr.Item['CMPconservacion']) ? 0.0 : dr.Item['CMPconservacion'] )
				oBeAcfCMPt_Componente.CMPobsolecencia = ( IsDBNull(dr.Item['CMPobsolecencia']) ? 0.0 : dr.Item['CMPobsolecencia'] )
				oBeAcfCMPt_Componente.CMPlimitelegal = ( IsDBNull(dr.Item['CMPlimitelegal']) ? 0.0 : dr.Item['CMPlimitelegal'] )
				oBeAcfCMPt_Componente.CMPtotalfactores = ( IsDBNull(dr.Item['CMPtotalfactores']) ? 0.0 : dr.Item['CMPtotalfactores'] )
				oBeAcfCMPt_Componente.CMPfactorusoestimado = ( IsDBNull(dr.Item['CMPfactorusoestimado']) ? 0.0 : dr.Item['CMPfactorusoestimado'] )
				oBeAcfCMPt_Componente.CMPvutilanio = ( IsDBNull(dr.Item['CMPvutilanio']) ? 0 : dr.Item['CMPvutilanio'] )
				oBeAcfCMPt_Componente.CMPvutildia = ( IsDBNull(dr.Item['CMPvutildia']) ? 0 : dr.Item['CMPvutildia'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfCMPt_Componente oBeAcfCMPt_Componente) {
		try {
			string sp = 'SpAcfCMPt_ComponenteInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPID", oBeAcfCMPt_Componente.CMPid));
			cmd.Parameters("@CMPID").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPCOMPONENTE", oBeAcfCMPt_Componente.CMPcomponente));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPUSOESTIMADO", oBeAcfCMPt_Componente.CMPusoestimado));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPCONSERVACION", oBeAcfCMPt_Componente.CMPconservacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPOBSOLECENCIA", oBeAcfCMPt_Componente.CMPobsolecencia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPLIMITELEGAL", oBeAcfCMPt_Componente.CMPlimitelegal));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPTOTALFACTORES", oBeAcfCMPt_Componente.CMPtotalfactores));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPFACTORUSOESTIMADO", oBeAcfCMPt_Componente.CMPfactorusoestimado));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPVUTILANIO", oBeAcfCMPt_Componente.CMPvutilanio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPVUTILDIA", oBeAcfCMPt_Componente.CMPvutildia));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfCMPt_Componente.CMPid = Convert.ToString(cmd.Parameters['@CMPID'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfCMPt_Componente oBeAcfCMPt_Componente) {
		try {
			string sp = 'SpAcfCMPt_ComponenteActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPID", oBeAcfCMPt_Componente.CMPid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPCOMPONENTE", oBeAcfCMPt_Componente.CMPcomponente));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPUSOESTIMADO", oBeAcfCMPt_Componente.CMPusoestimado));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPCONSERVACION", oBeAcfCMPt_Componente.CMPconservacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPOBSOLECENCIA", oBeAcfCMPt_Componente.CMPobsolecencia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPLIMITELEGAL", oBeAcfCMPt_Componente.CMPlimitelegal));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPTOTALFACTORES", oBeAcfCMPt_Componente.CMPtotalfactores));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPFACTORUSOESTIMADO", oBeAcfCMPt_Componente.CMPfactorusoestimado));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPVUTILANIO", oBeAcfCMPt_Componente.CMPvutilanio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPVUTILDIA", oBeAcfCMPt_Componente.CMPvutildia));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfCMPt_Componente oBeAcfCMPt_Componente) {
		try {
			string sp = 'SpAcfCMPt_ComponenteEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPID", oBeAcfCMPt_Componente.CMPid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfCMPt_ComponenteListar';
			
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

	public bool Obtener(ref clsBeAcfCMPt_Componente oBeAcfCMPt_Componente) {
		try {
			string sp = 'SpAcfCMPt_ComponenteObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@CMPID", oBeAcfCMPt_Componente.CMPid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfCMPt_Componente, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfCMPt_Componente oBeAcfCMPt_Componente) {
		Try
			string sp = 'SpAcfCMPt_ComponentePrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfCMPt_Componente, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfCMPt_Componente oBeAcfCMPt_Componente) {
		try {
			string sp = 'SpAcfCMPt_ComponenteUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfCMPt_Componente, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfCMPt_Componente oBeAcfCMPt_Componente) {
		Try
			string sp = 'SpAcfCMPt_ComponenteAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@CMPID", oBeAcfCMPt_Componente.CMPid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfCMPt_Componente, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfCMPt_Componente oBeAcfCMPt_Componente) {
		Try
			string sp = 'SpAcfCMPt_ComponenteSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@CMPID", oBeAcfCMPt_Componente.CMPid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfCMPt_Componente, dt.Rows[0]);
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
