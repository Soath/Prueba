using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfACFp_Activo_Fijo {

	private ConnectionManager oConexion = null;

	 public clsLnAcfACFp_Activo_Fijo(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfACFp_Activo_Fijo, ref DataRow dr) {
		try {
				oBeAcfACFp_Activo_Fijo.ACFid = ( IsDBNull(dr.Item['ACFid']) ? 0 : dr.Item['ACFid'] )
				oBeAcfACFp_Activo_Fijo.BUKRS = ( IsDBNull(dr.Item['BUKRS']) ? '' : dr.Item['BUKRS'] )
				oBeAcfACFp_Activo_Fijo.SEGMENT = ( IsDBNull(dr.Item['SEGMENT']) ? '' : dr.Item['SEGMENT'] )
				oBeAcfACFp_Activo_Fijo.ANLKL = ( IsDBNull(dr.Item['ANLKL']) ? '' : dr.Item['ANLKL'] )
				oBeAcfACFp_Activo_Fijo.PERNR = ( IsDBNull(dr.Item['PERNR']) ? '' : dr.Item['PERNR'] )
				oBeAcfACFp_Activo_Fijo.CSTid = ( IsDBNull(dr.Item['CSTid']) ? '' : dr.Item['CSTid'] )
				oBeAcfACFp_Activo_Fijo.MVMid = ( IsDBNull(dr.Item['MVMid']) ? '' : dr.Item['MVMid'] )
				oBeAcfACFp_Activo_Fijo.ACFfmovimiento = ( IsDBNull(dr.Item['ACFfmovimiento']) ? Date.Now() : dr.Item['ACFfmovimiento'] )
				oBeAcfACFp_Activo_Fijo.VNRid = ( IsDBNull(dr.Item['VNRid']) ? '' : dr.Item['VNRid'] )
				oBeAcfACFp_Activo_Fijo.ACFdescripcion = ( IsDBNull(dr.Item['ACFdescripcion']) ? '' : dr.Item['ACFdescripcion'] )
				oBeAcfACFp_Activo_Fijo.ACFfincorporacion = ( IsDBNull(dr.Item['ACFfincorporacion']) ? Date.Now() : dr.Item['ACFfincorporacion'] )
				oBeAcfACFp_Activo_Fijo.ACFfcapitalizacion = ( IsDBNull(dr.Item['ACFfcapitalizacion']) ? Date.Now() : dr.Item['ACFfcapitalizacion'] )
				oBeAcfACFp_Activo_Fijo.ACFvutiltribanio = ( IsDBNull(dr.Item['ACFvutiltribanio']) ? 0 : dr.Item['ACFvutiltribanio'] )
				oBeAcfACFp_Activo_Fijo.ACFvutiltribdia = ( IsDBNull(dr.Item['ACFvutiltribdia']) ? 0 : dr.Item['ACFvutiltribdia'] )
				oBeAcfACFp_Activo_Fijo.ACFvalortrib = ( IsDBNull(dr.Item['ACFvalortrib']) ? 0.0 : dr.Item['ACFvalortrib'] )
				oBeAcfACFp_Activo_Fijo.ACFvutilniifanio = ( IsDBNull(dr.Item['ACFvutilniifanio']) ? 0 : dr.Item['ACFvutilniifanio'] )
				oBeAcfACFp_Activo_Fijo.ACFvutilniifdia = ( IsDBNull(dr.Item['ACFvutilniifdia']) ? 0 : dr.Item['ACFvutilniifdia'] )
				oBeAcfACFp_Activo_Fijo.ACFvalorniif = ( IsDBNull(dr.Item['ACFvalorniif']) ? 0.0 : dr.Item['ACFvalorniif'] )
				oBeAcfACFp_Activo_Fijo.ACFdepacutrib = ( IsDBNull(dr.Item['ACFdepacutrib']) ? '' : dr.Item['ACFdepacutrib'] )
				oBeAcfACFp_Activo_Fijo.ACFdepacuniif = ( IsDBNull(dr.Item['ACFdepacuniif']) ? 0.0 : dr.Item['ACFdepacuniif'] )
				oBeAcfACFp_Activo_Fijo.ACFobra = ( IsDBNull(dr.Item['ACFobra']) ? '' : dr.Item['ACFobra'] )
				oBeAcfACFp_Activo_Fijo.ACFord41 = ( IsDBNull(dr.Item['ACFord41']) ? '' : dr.Item['ACFord41'] )
				oBeAcfACFp_Activo_Fijo.ACFord42 = ( IsDBNull(dr.Item['ACFord42']) ? '' : dr.Item['ACFord42'] )
				oBeAcfACFp_Activo_Fijo.ACFord43 = ( IsDBNull(dr.Item['ACFord43']) ? '' : dr.Item['ACFord43'] )
				oBeAcfACFp_Activo_Fijo.ACFord44 = ( IsDBNull(dr.Item['ACFord44']) ? '' : dr.Item['ACFord44'] )
				oBeAcfACFp_Activo_Fijo.ACFanlue = ( IsDBNull(dr.Item['ACFanlue']) ? '' : dr.Item['ACFanlue'] )
				oBeAcfACFp_Activo_Fijo.ACFfactortrib = ( IsDBNull(dr.Item['ACFfactortrib']) ? 0.0 : dr.Item['ACFfactortrib'] )
				oBeAcfACFp_Activo_Fijo.ACFfactorniif = ( IsDBNull(dr.Item['ACFfactorniif']) ? 0.0 : dr.Item['ACFfactorniif'] )
				oBeAcfACFp_Activo_Fijo.ACFcuenta = ( IsDBNull(dr.Item['ACFcuenta']) ? '' : dr.Item['ACFcuenta'] )
				oBeAcfACFp_Activo_Fijo.ACFcuentadep = ( IsDBNull(dr.Item['ACFcuentadep']) ? '' : dr.Item['ACFcuentadep'] )
				oBeAcfACFp_Activo_Fijo.CMPid = ( IsDBNull(dr.Item['CMPid']) ? '' : dr.Item['CMPid'] )
				oBeAcfACFp_Activo_Fijo.ACFobservacion = ( IsDBNull(dr.Item['ACFobservacion']) ? '' : dr.Item['ACFobservacion'] )
				oBeAcfACFp_Activo_Fijo.LIFNR = ( IsDBNull(dr.Item['LIFNR']) ? '' : dr.Item['LIFNR'] )
				oBeAcfACFp_Activo_Fijo.ACFnotaingreso = ( IsDBNull(dr.Item['ACFnotaingreso']) ? '' : dr.Item['ACFnotaingreso'] )
				oBeAcfACFp_Activo_Fijo.ACFfechanotaingreso = ( IsDBNull(dr.Item['ACFfechanotaingreso']) ? '' : dr.Item['ACFfechanotaingreso'] )
				oBeAcfACFp_Activo_Fijo.ACFordencompra = ( IsDBNull(dr.Item['ACFordencompra']) ? '' : dr.Item['ACFordencompra'] )
				oBeAcfACFp_Activo_Fijo.ACFfechaordencompra = ( IsDBNull(dr.Item['ACFfechaordencompra']) ? Date.Now() : dr.Item['ACFfechaordencompra'] )
				oBeAcfACFp_Activo_Fijo.BLART = ( IsDBNull(dr.Item['BLART']) ? '' : dr.Item['BLART'] )
				oBeAcfACFp_Activo_Fijo.ACFcomprobante = ( IsDBNull(dr.Item['ACFcomprobante']) ? '' : dr.Item['ACFcomprobante'] )
				oBeAcfACFp_Activo_Fijo.KOSTL = ( IsDBNull(dr.Item['KOSTL']) ? '' : dr.Item['KOSTL'] )
				oBeAcfACFp_Activo_Fijo.AMBid = ( IsDBNull(dr.Item['AMBid']) ? 0 : dr.Item['AMBid'] )
				oBeAcfACFp_Activo_Fijo.UBEid = ( IsDBNull(dr.Item['UBEid']) ? 0 : dr.Item['UBEid'] )
				oBeAcfACFp_Activo_Fijo.ACFfechacomprobante = ( IsDBNull(dr.Item['ACFfechacomprobante']) ? Date.Now() : dr.Item['ACFfechacomprobante'] )
				oBeAcfACFp_Activo_Fijo.V_T087U_ANLUE = ( IsDBNull(dr.Item['V_T087U_ANLUE']) ? '' : dr.Item['V_T087U_ANLUE'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfACFp_Activo_Fijo oBeAcfACFp_Activo_Fijo) {
		try {
			string sp = 'SpAcfACFp_Activo_FijoInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfACFp_Activo_Fijo.ACFid));
			cmd.Parameters("@ACFID").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@BUKRS", oBeAcfACFp_Activo_Fijo.BUKRS));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@SEGMENT", oBeAcfACFp_Activo_Fijo.SEGMENT));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ANLKL", oBeAcfACFp_Activo_Fijo.ANLKL));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PERNR", oBeAcfACFp_Activo_Fijo.PERNR));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CSTID", oBeAcfACFp_Activo_Fijo.CSTid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MVMID", oBeAcfACFp_Activo_Fijo.MVMid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFMOVIMIENTO", oBeAcfACFp_Activo_Fijo.ACFfmovimiento));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@VNRID", oBeAcfACFp_Activo_Fijo.VNRid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDESCRIPCION", oBeAcfACFp_Activo_Fijo.ACFdescripcion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFINCORPORACION", oBeAcfACFp_Activo_Fijo.ACFfincorporacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFCAPITALIZACION", oBeAcfACFp_Activo_Fijo.ACFfcapitalizacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILTRIBANIO", oBeAcfACFp_Activo_Fijo.ACFvutiltribanio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILTRIBDIA", oBeAcfACFp_Activo_Fijo.ACFvutiltribdia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORTRIB", oBeAcfACFp_Activo_Fijo.ACFvalortrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILNIIFANIO", oBeAcfACFp_Activo_Fijo.ACFvutilniifanio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILNIIFDIA", oBeAcfACFp_Activo_Fijo.ACFvutilniifdia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORNIIF", oBeAcfACFp_Activo_Fijo.ACFvalorniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPACUTRIB", oBeAcfACFp_Activo_Fijo.ACFdepacutrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPACUNIIF", oBeAcfACFp_Activo_Fijo.ACFdepacuniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFOBRA", oBeAcfACFp_Activo_Fijo.ACFobra));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD41", oBeAcfACFp_Activo_Fijo.ACFord41));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD42", oBeAcfACFp_Activo_Fijo.ACFord42));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD43", oBeAcfACFp_Activo_Fijo.ACFord43));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD44", oBeAcfACFp_Activo_Fijo.ACFord44));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFANLUE", oBeAcfACFp_Activo_Fijo.ACFanlue));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFACTORTRIB", oBeAcfACFp_Activo_Fijo.ACFfactortrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFACTORNIIF", oBeAcfACFp_Activo_Fijo.ACFfactorniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCUENTA", oBeAcfACFp_Activo_Fijo.ACFcuenta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCUENTADEP", oBeAcfACFp_Activo_Fijo.ACFcuentadep));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPID", oBeAcfACFp_Activo_Fijo.CMPid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFOBSERVACION", oBeAcfACFp_Activo_Fijo.ACFobservacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LIFNR", oBeAcfACFp_Activo_Fijo.LIFNR));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFNOTAINGRESO", oBeAcfACFp_Activo_Fijo.ACFnotaingreso));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFECHANOTAINGRESO", oBeAcfACFp_Activo_Fijo.ACFfechanotaingreso));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORDENCOMPRA", oBeAcfACFp_Activo_Fijo.ACFordencompra));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFECHAORDENCOMPRA", oBeAcfACFp_Activo_Fijo.ACFfechaordencompra));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@BLART", oBeAcfACFp_Activo_Fijo.BLART));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCOMPROBANTE", oBeAcfACFp_Activo_Fijo.ACFcomprobante));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@KOSTL", oBeAcfACFp_Activo_Fijo.KOSTL));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@AMBID", oBeAcfACFp_Activo_Fijo.AMBid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEID", oBeAcfACFp_Activo_Fijo.UBEid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFECHACOMPROBANTE", oBeAcfACFp_Activo_Fijo.ACFfechacomprobante));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@V_T087U_ANLUE", oBeAcfACFp_Activo_Fijo.V_T087U_ANLUE));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfACFp_Activo_Fijo.ACFid = int.Parse(cmd.Parameters['@ACFID'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfACFp_Activo_Fijo oBeAcfACFp_Activo_Fijo) {
		try {
			string sp = 'SpAcfACFp_Activo_FijoActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfACFp_Activo_Fijo.ACFid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@BUKRS", oBeAcfACFp_Activo_Fijo.BUKRS));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@SEGMENT", oBeAcfACFp_Activo_Fijo.SEGMENT));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ANLKL", oBeAcfACFp_Activo_Fijo.ANLKL));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PERNR", oBeAcfACFp_Activo_Fijo.PERNR));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CSTID", oBeAcfACFp_Activo_Fijo.CSTid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MVMID", oBeAcfACFp_Activo_Fijo.MVMid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFMOVIMIENTO", oBeAcfACFp_Activo_Fijo.ACFfmovimiento));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@VNRID", oBeAcfACFp_Activo_Fijo.VNRid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDESCRIPCION", oBeAcfACFp_Activo_Fijo.ACFdescripcion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFINCORPORACION", oBeAcfACFp_Activo_Fijo.ACFfincorporacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFCAPITALIZACION", oBeAcfACFp_Activo_Fijo.ACFfcapitalizacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILTRIBANIO", oBeAcfACFp_Activo_Fijo.ACFvutiltribanio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILTRIBDIA", oBeAcfACFp_Activo_Fijo.ACFvutiltribdia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORTRIB", oBeAcfACFp_Activo_Fijo.ACFvalortrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILNIIFANIO", oBeAcfACFp_Activo_Fijo.ACFvutilniifanio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILNIIFDIA", oBeAcfACFp_Activo_Fijo.ACFvutilniifdia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORNIIF", oBeAcfACFp_Activo_Fijo.ACFvalorniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPACUTRIB", oBeAcfACFp_Activo_Fijo.ACFdepacutrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPACUNIIF", oBeAcfACFp_Activo_Fijo.ACFdepacuniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFOBRA", oBeAcfACFp_Activo_Fijo.ACFobra));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD41", oBeAcfACFp_Activo_Fijo.ACFord41));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD42", oBeAcfACFp_Activo_Fijo.ACFord42));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD43", oBeAcfACFp_Activo_Fijo.ACFord43));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD44", oBeAcfACFp_Activo_Fijo.ACFord44));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFANLUE", oBeAcfACFp_Activo_Fijo.ACFanlue));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFACTORTRIB", oBeAcfACFp_Activo_Fijo.ACFfactortrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFACTORNIIF", oBeAcfACFp_Activo_Fijo.ACFfactorniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCUENTA", oBeAcfACFp_Activo_Fijo.ACFcuenta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCUENTADEP", oBeAcfACFp_Activo_Fijo.ACFcuentadep));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPID", oBeAcfACFp_Activo_Fijo.CMPid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFOBSERVACION", oBeAcfACFp_Activo_Fijo.ACFobservacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LIFNR", oBeAcfACFp_Activo_Fijo.LIFNR));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFNOTAINGRESO", oBeAcfACFp_Activo_Fijo.ACFnotaingreso));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFECHANOTAINGRESO", oBeAcfACFp_Activo_Fijo.ACFfechanotaingreso));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORDENCOMPRA", oBeAcfACFp_Activo_Fijo.ACFordencompra));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFECHAORDENCOMPRA", oBeAcfACFp_Activo_Fijo.ACFfechaordencompra));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@BLART", oBeAcfACFp_Activo_Fijo.BLART));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCOMPROBANTE", oBeAcfACFp_Activo_Fijo.ACFcomprobante));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@KOSTL", oBeAcfACFp_Activo_Fijo.KOSTL));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@AMBID", oBeAcfACFp_Activo_Fijo.AMBid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEID", oBeAcfACFp_Activo_Fijo.UBEid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFECHACOMPROBANTE", oBeAcfACFp_Activo_Fijo.ACFfechacomprobante));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@V_T087U_ANLUE", oBeAcfACFp_Activo_Fijo.V_T087U_ANLUE));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfACFp_Activo_Fijo oBeAcfACFp_Activo_Fijo) {
		try {
			string sp = 'SpAcfACFp_Activo_FijoEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfACFp_Activo_Fijo.ACFid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfACFp_Activo_FijoListar';
			
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

	public bool Obtener(ref clsBeAcfACFp_Activo_Fijo oBeAcfACFp_Activo_Fijo) {
		try {
			string sp = 'SpAcfACFp_Activo_FijoObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfACFp_Activo_Fijo.ACFid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfACFp_Activo_Fijo, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfACFp_Activo_Fijo oBeAcfACFp_Activo_Fijo) {
		Try
			string sp = 'SpAcfACFp_Activo_FijoPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfACFp_Activo_Fijo, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfACFp_Activo_Fijo oBeAcfACFp_Activo_Fijo) {
		try {
			string sp = 'SpAcfACFp_Activo_FijoUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfACFp_Activo_Fijo, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfACFp_Activo_Fijo oBeAcfACFp_Activo_Fijo) {
		Try
			string sp = 'SpAcfACFp_Activo_FijoAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfACFp_Activo_Fijo.ACFid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfACFp_Activo_Fijo, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfACFp_Activo_Fijo oBeAcfACFp_Activo_Fijo) {
		Try
			string sp = 'SpAcfACFp_Activo_FijoSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfACFp_Activo_Fijo.ACFid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfACFp_Activo_Fijo, dt.Rows[0]);
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
