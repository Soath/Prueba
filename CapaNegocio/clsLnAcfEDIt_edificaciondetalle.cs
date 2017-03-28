using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfEDIt_edificaciondetalle {

	private ConnectionManager oConexion = null;

	 public clsLnAcfEDIt_edificaciondetalle(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfEDIt_edificaciondetalle, ref DataRow dr) {
		try {
				oBeAcfEDIt_edificaciondetalle.ACFid = ( IsDBNull(dr.Item['ACFid']) ? 0 : dr.Item['ACFid'] )
				oBeAcfEDIt_edificaciondetalle.EDIzona = ( IsDBNull(dr.Item['EDIzona']) ? '' : dr.Item['EDIzona'] )
				oBeAcfEDIt_edificaciondetalle.EDIdescripicion = ( IsDBNull(dr.Item['EDIdescripicion']) ? '' : dr.Item['EDIdescripicion'] )
				oBeAcfEDIt_edificaciondetalle.EDIfactorasignado = ( IsDBNull(dr.Item['EDIfactorasignado']) ? 0.0 : dr.Item['EDIfactorasignado'] )
				oBeAcfEDIt_edificaciondetalle.ACFValorIR = ( IsDBNull(dr.Item['ACFValorIR']) ? 0.0 : dr.Item['ACFValorIR'] )
				oBeAcfEDIt_edificaciondetalle.ACFTC = ( IsDBNull(dr.Item['ACFTC']) ? 0.0 : dr.Item['ACFTC'] )
				oBeAcfEDIt_edificaciondetalle.ACFCRC = ( IsDBNull(dr.Item['ACFCRC']) ? 0.0 : dr.Item['ACFCRC'] )
				oBeAcfEDIt_edificaciondetalle.ACFDEPCRC = ( IsDBNull(dr.Item['ACFDEPCRC']) ? 0.0 : dr.Item['ACFDEPCRC'] )
				oBeAcfEDIt_edificaciondetalle.ACFNETOCRC = ( IsDBNull(dr.Item['ACFNETOCRC']) ? 0.0 : dr.Item['ACFNETOCRC'] )
				oBeAcfEDIt_edificaciondetalle.ACFvalorniif = ( IsDBNull(dr.Item['ACFvalorniif']) ? 0.0 : dr.Item['ACFvalorniif'] )
				oBeAcfEDIt_edificaciondetalle.ACFdepacuniif = ( IsDBNull(dr.Item['ACFdepacuniif']) ? 0.0 : dr.Item['ACFdepacuniif'] )
				oBeAcfEDIt_edificaciondetalle.ACFNETOPCGA = ( IsDBNull(dr.Item['ACFNETOPCGA']) ? 0.0 : dr.Item['ACFNETOPCGA'] )
				oBeAcfEDIt_edificaciondetalle.ACFDIFCosto = ( IsDBNull(dr.Item['ACFDIFCosto']) ? 0.0 : dr.Item['ACFDIFCosto'] )
				oBeAcfEDIt_edificaciondetalle.ACFINCCosto = ( IsDBNull(dr.Item['ACFINCCosto']) ? 0.0 : dr.Item['ACFINCCosto'] )
				oBeAcfEDIt_edificaciondetalle.ACFDISCosto = ( IsDBNull(dr.Item['ACFDISCosto']) ? 0.0 : dr.Item['ACFDISCosto'] )
				oBeAcfEDIt_edificaciondetalle.ACFDIFDEP = ( IsDBNull(dr.Item['ACFDIFDEP']) ? 0.0 : dr.Item['ACFDIFDEP'] )
				oBeAcfEDIt_edificaciondetalle.ACFINCDep = ( IsDBNull(dr.Item['ACFINCDep']) ? 0.0 : dr.Item['ACFINCDep'] )
				oBeAcfEDIt_edificaciondetalle.ACFDISDep = ( IsDBNull(dr.Item['ACFDISDep']) ? 0.0 : dr.Item['ACFDISDep'] )
				oBeAcfEDIt_edificaciondetalle.ACFDIFNeta = ( IsDBNull(dr.Item['ACFDIFNeta']) ? 0.0 : dr.Item['ACFDIFNeta'] )
				oBeAcfEDIt_edificaciondetalle.ACFSumDifDed = ( IsDBNull(dr.Item['ACFSumDifDed']) ? 0.0 : dr.Item['ACFSumDifDed'] )
				oBeAcfEDIt_edificaciondetalle.ACFSumDifGra = ( IsDBNull(dr.Item['ACFSumDifGra']) ? 0.0 : dr.Item['ACFSumDifGra'] )
				oBeAcfEDIt_edificaciondetalle.ACFSumACTDif = ( IsDBNull(dr.Item['ACFSumACTDif']) ? 0.0 : dr.Item['ACFSumACTDif'] )
				oBeAcfEDIt_edificaciondetalle.ACFSumPasDif = ( IsDBNull(dr.Item['ACFSumPasDif']) ? 0.0 : dr.Item['ACFSumPasDif'] )
				oBeAcfEDIt_edificaciondetalle.ACFcuenta = ( IsDBNull(dr.Item['ACFcuenta']) ? '' : dr.Item['ACFcuenta'] )
				oBeAcfEDIt_edificaciondetalle.LOClocal = ( IsDBNull(dr.Item['LOClocal']) ? '' : dr.Item['LOClocal'] )
				oBeAcfEDIt_edificaciondetalle.RVAcodigo = ( IsDBNull(dr.Item['RVAcodigo']) ? '' : dr.Item['RVAcodigo'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfEDIt_edificaciondetalle oBeAcfEDIt_edificaciondetalle) {
		try {
			string sp = 'SpAcfEDIt_edificaciondetalleInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfEDIt_edificaciondetalle.ACFid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@EDIZONA", oBeAcfEDIt_edificaciondetalle.EDIzona));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@EDIDESCRIPICION", oBeAcfEDIt_edificaciondetalle.EDIdescripicion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@EDIFACTORASIGNADO", oBeAcfEDIt_edificaciondetalle.EDIfactorasignado));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORIR", oBeAcfEDIt_edificaciondetalle.ACFValorIR));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFTC", oBeAcfEDIt_edificaciondetalle.ACFTC));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCRC", oBeAcfEDIt_edificaciondetalle.ACFCRC));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPCRC", oBeAcfEDIt_edificaciondetalle.ACFDEPCRC));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFNETOCRC", oBeAcfEDIt_edificaciondetalle.ACFNETOCRC));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORNIIF", oBeAcfEDIt_edificaciondetalle.ACFvalorniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPACUNIIF", oBeAcfEDIt_edificaciondetalle.ACFdepacuniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFNETOPCGA", oBeAcfEDIt_edificaciondetalle.ACFNETOPCGA));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDIFCOSTO", oBeAcfEDIt_edificaciondetalle.ACFDIFCosto));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFINCCOSTO", oBeAcfEDIt_edificaciondetalle.ACFINCCosto));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDISCOSTO", oBeAcfEDIt_edificaciondetalle.ACFDISCosto));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDIFDEP", oBeAcfEDIt_edificaciondetalle.ACFDIFDEP));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFINCDEP", oBeAcfEDIt_edificaciondetalle.ACFINCDep));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDISDEP", oBeAcfEDIt_edificaciondetalle.ACFDISDep));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDIFNETA", oBeAcfEDIt_edificaciondetalle.ACFDIFNeta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFSUMDIFDED", oBeAcfEDIt_edificaciondetalle.ACFSumDifDed));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFSUMDIFGRA", oBeAcfEDIt_edificaciondetalle.ACFSumDifGra));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFSUMACTDIF", oBeAcfEDIt_edificaciondetalle.ACFSumACTDif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFSUMPASDIF", oBeAcfEDIt_edificaciondetalle.ACFSumPasDif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCUENTA", oBeAcfEDIt_edificaciondetalle.ACFcuenta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LOCLOCAL", oBeAcfEDIt_edificaciondetalle.LOClocal));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfEDIt_edificaciondetalle.RVAcodigo));
			cmd.Parameters("@RVACODIGO").Direction = ParameterDirection.Output;
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfEDIt_edificaciondetalle.RVAcodigo = Convert.ToString(cmd.Parameters['@RVACODIGO'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfEDIt_edificaciondetalle oBeAcfEDIt_edificaciondetalle) {
		try {
			string sp = 'SpAcfEDIt_edificaciondetalleActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfEDIt_edificaciondetalle.ACFid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@EDIZONA", oBeAcfEDIt_edificaciondetalle.EDIzona));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@EDIDESCRIPICION", oBeAcfEDIt_edificaciondetalle.EDIdescripicion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@EDIFACTORASIGNADO", oBeAcfEDIt_edificaciondetalle.EDIfactorasignado));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORIR", oBeAcfEDIt_edificaciondetalle.ACFValorIR));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFTC", oBeAcfEDIt_edificaciondetalle.ACFTC));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCRC", oBeAcfEDIt_edificaciondetalle.ACFCRC));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPCRC", oBeAcfEDIt_edificaciondetalle.ACFDEPCRC));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFNETOCRC", oBeAcfEDIt_edificaciondetalle.ACFNETOCRC));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORNIIF", oBeAcfEDIt_edificaciondetalle.ACFvalorniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPACUNIIF", oBeAcfEDIt_edificaciondetalle.ACFdepacuniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFNETOPCGA", oBeAcfEDIt_edificaciondetalle.ACFNETOPCGA));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDIFCOSTO", oBeAcfEDIt_edificaciondetalle.ACFDIFCosto));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFINCCOSTO", oBeAcfEDIt_edificaciondetalle.ACFINCCosto));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDISCOSTO", oBeAcfEDIt_edificaciondetalle.ACFDISCosto));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDIFDEP", oBeAcfEDIt_edificaciondetalle.ACFDIFDEP));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFINCDEP", oBeAcfEDIt_edificaciondetalle.ACFINCDep));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDISDEP", oBeAcfEDIt_edificaciondetalle.ACFDISDep));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDIFNETA", oBeAcfEDIt_edificaciondetalle.ACFDIFNeta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFSUMDIFDED", oBeAcfEDIt_edificaciondetalle.ACFSumDifDed));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFSUMDIFGRA", oBeAcfEDIt_edificaciondetalle.ACFSumDifGra));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFSUMACTDIF", oBeAcfEDIt_edificaciondetalle.ACFSumACTDif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFSUMPASDIF", oBeAcfEDIt_edificaciondetalle.ACFSumPasDif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCUENTA", oBeAcfEDIt_edificaciondetalle.ACFcuenta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LOCLOCAL", oBeAcfEDIt_edificaciondetalle.LOClocal));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfEDIt_edificaciondetalle.RVAcodigo));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfEDIt_edificaciondetalle oBeAcfEDIt_edificaciondetalle) {
		try {
			string sp = 'SpAcfEDIt_edificaciondetalleEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfEDIt_edificaciondetalle.RVAcodigo));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfEDIt_edificaciondetalleListar';
			
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

	public bool Obtener(ref clsBeAcfEDIt_edificaciondetalle oBeAcfEDIt_edificaciondetalle) {
		try {
			string sp = 'SpAcfEDIt_edificaciondetalleObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfEDIt_edificaciondetalle.RVAcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfEDIt_edificaciondetalle, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfEDIt_edificaciondetalle oBeAcfEDIt_edificaciondetalle) {
		Try
			string sp = 'SpAcfEDIt_edificaciondetallePrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfEDIt_edificaciondetalle, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfEDIt_edificaciondetalle oBeAcfEDIt_edificaciondetalle) {
		try {
			string sp = 'SpAcfEDIt_edificaciondetalleUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfEDIt_edificaciondetalle, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfEDIt_edificaciondetalle oBeAcfEDIt_edificaciondetalle) {
		Try
			string sp = 'SpAcfEDIt_edificaciondetalleAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfEDIt_edificaciondetalle.RVAcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfEDIt_edificaciondetalle, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfEDIt_edificaciondetalle oBeAcfEDIt_edificaciondetalle) {
		Try
			string sp = 'SpAcfEDIt_edificaciondetalleSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfEDIt_edificaciondetalle.RVAcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfEDIt_edificaciondetalle, dt.Rows[0]);
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
