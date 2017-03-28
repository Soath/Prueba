using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfMVAt_MovimientoActivo {

	private ConnectionManager oConexion = null;

	 public clsLnAcfMVAt_MovimientoActivo(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfMVAt_MovimientoActivo, ref DataRow dr) {
		try {
				oBeAcfMVAt_MovimientoActivo.MVAid = ( IsDBNull(dr.Item['MVAid']) ? 0 : dr.Item['MVAid'] )
				oBeAcfMVAt_MovimientoActivo.ACFid = ( IsDBNull(dr.Item['ACFid']) ? 0 : dr.Item['ACFid'] )
				oBeAcfMVAt_MovimientoActivo.ACFactivo = ( IsDBNull(dr.Item['ACFactivo']) ? '' : dr.Item['ACFactivo'] )
				oBeAcfMVAt_MovimientoActivo.BUKRS = ( IsDBNull(dr.Item['BUKRS']) ? '' : dr.Item['BUKRS'] )
				oBeAcfMVAt_MovimientoActivo.SEGMENT = ( IsDBNull(dr.Item['SEGMENT']) ? '' : dr.Item['SEGMENT'] )
				oBeAcfMVAt_MovimientoActivo.KOSTL = ( IsDBNull(dr.Item['KOSTL']) ? '' : dr.Item['KOSTL'] )
				oBeAcfMVAt_MovimientoActivo.ANLKL = ( IsDBNull(dr.Item['ANLKL']) ? '' : dr.Item['ANLKL'] )
				oBeAcfMVAt_MovimientoActivo.PERNR = ( IsDBNull(dr.Item['PERNR']) ? '' : dr.Item['PERNR'] )
				oBeAcfMVAt_MovimientoActivo.CSTid = ( IsDBNull(dr.Item['CSTid']) ? '' : dr.Item['CSTid'] )
				oBeAcfMVAt_MovimientoActivo.TMVid = ( IsDBNull(dr.Item['TMVid']) ? '' : dr.Item['TMVid'] )
				oBeAcfMVAt_MovimientoActivo.MVMid = ( IsDBNull(dr.Item['MVMid']) ? '' : dr.Item['MVMid'] )
				oBeAcfMVAt_MovimientoActivo.ACFfmovimiento = ( IsDBNull(dr.Item['ACFfmovimiento']) ? Date.Now() : dr.Item['ACFfmovimiento'] )
				oBeAcfMVAt_MovimientoActivo.VNRid = ( IsDBNull(dr.Item['VNRid']) ? '' : dr.Item['VNRid'] )
				oBeAcfMVAt_MovimientoActivo.ACFfincorporacion = ( IsDBNull(dr.Item['ACFfincorporacion']) ? Date.Now() : dr.Item['ACFfincorporacion'] )
				oBeAcfMVAt_MovimientoActivo.ACFfcapitalizacion = ( IsDBNull(dr.Item['ACFfcapitalizacion']) ? Date.Now() : dr.Item['ACFfcapitalizacion'] )
				oBeAcfMVAt_MovimientoActivo.ACFvutiltribanio = ( IsDBNull(dr.Item['ACFvutiltribanio']) ? 0 : dr.Item['ACFvutiltribanio'] )
				oBeAcfMVAt_MovimientoActivo.ACFvutiltribdia = ( IsDBNull(dr.Item['ACFvutiltribdia']) ? 0 : dr.Item['ACFvutiltribdia'] )
				oBeAcfMVAt_MovimientoActivo.ACFvalortrib = ( IsDBNull(dr.Item['ACFvalortrib']) ? 0.0 : dr.Item['ACFvalortrib'] )
				oBeAcfMVAt_MovimientoActivo.ACFfactortrib = ( IsDBNull(dr.Item['ACFfactortrib']) ? 0.0 : dr.Item['ACFfactortrib'] )
				oBeAcfMVAt_MovimientoActivo.ACFdepacutrib = ( IsDBNull(dr.Item['ACFdepacutrib']) ? 0.0 : dr.Item['ACFdepacutrib'] )
				oBeAcfMVAt_MovimientoActivo.ACFvutilniifanio = ( IsDBNull(dr.Item['ACFvutilniifanio']) ? 0 : dr.Item['ACFvutilniifanio'] )
				oBeAcfMVAt_MovimientoActivo.ACFvutilniifdia = ( IsDBNull(dr.Item['ACFvutilniifdia']) ? 0 : dr.Item['ACFvutilniifdia'] )
				oBeAcfMVAt_MovimientoActivo.ACFvalorniif = ( IsDBNull(dr.Item['ACFvalorniif']) ? 0.0 : dr.Item['ACFvalorniif'] )
				oBeAcfMVAt_MovimientoActivo.ACFfactorniif = ( IsDBNull(dr.Item['ACFfactorniif']) ? 0.0 : dr.Item['ACFfactorniif'] )
				oBeAcfMVAt_MovimientoActivo.ACFdepacuniif = ( IsDBNull(dr.Item['ACFdepacuniif']) ? 0.0 : dr.Item['ACFdepacuniif'] )
				oBeAcfMVAt_MovimientoActivo.ACFobra = ( IsDBNull(dr.Item['ACFobra']) ? '' : dr.Item['ACFobra'] )
				oBeAcfMVAt_MovimientoActivo.ACFord41 = ( IsDBNull(dr.Item['ACFord41']) ? '' : dr.Item['ACFord41'] )
				oBeAcfMVAt_MovimientoActivo.ACFord42 = ( IsDBNull(dr.Item['ACFord42']) ? '' : dr.Item['ACFord42'] )
				oBeAcfMVAt_MovimientoActivo.ACFord43 = ( IsDBNull(dr.Item['ACFord43']) ? '' : dr.Item['ACFord43'] )
				oBeAcfMVAt_MovimientoActivo.ACFord44 = ( IsDBNull(dr.Item['ACFord44']) ? '' : dr.Item['ACFord44'] )
				oBeAcfMVAt_MovimientoActivo.ACFanlue = ( IsDBNull(dr.Item['ACFanlue']) ? '' : dr.Item['ACFanlue'] )
				oBeAcfMVAt_MovimientoActivo.ACFcuenta = ( IsDBNull(dr.Item['ACFcuenta']) ? '' : dr.Item['ACFcuenta'] )
				oBeAcfMVAt_MovimientoActivo.ACFcuentadep = ( IsDBNull(dr.Item['ACFcuentadep']) ? '' : dr.Item['ACFcuentadep'] )
				oBeAcfMVAt_MovimientoActivo.ACFcomprobante = ( IsDBNull(dr.Item['ACFcomprobante']) ? '' : dr.Item['ACFcomprobante'] )
				oBeAcfMVAt_MovimientoActivo.ACFnotaingreso = ( IsDBNull(dr.Item['ACFnotaingreso']) ? '' : dr.Item['ACFnotaingreso'] )
				oBeAcfMVAt_MovimientoActivo.ACFfechanotaingreso = ( IsDBNull(dr.Item['ACFfechanotaingreso']) ? Date.Now() : dr.Item['ACFfechanotaingreso'] )
				oBeAcfMVAt_MovimientoActivo.ACFordencompra = ( IsDBNull(dr.Item['ACFordencompra']) ? '' : dr.Item['ACFordencompra'] )
				oBeAcfMVAt_MovimientoActivo.ACFfechaordencompra = ( IsDBNull(dr.Item['ACFfechaordencompra']) ? Date.Now() : dr.Item['ACFfechaordencompra'] )
				oBeAcfMVAt_MovimientoActivo.ACFobservacion = ( IsDBNull(dr.Item['ACFobservacion']) ? '' : dr.Item['ACFobservacion'] )
				oBeAcfMVAt_MovimientoActivo.LIFNR = ( IsDBNull(dr.Item['LIFNR']) ? '' : dr.Item['LIFNR'] )
				oBeAcfMVAt_MovimientoActivo.BLART = ( IsDBNull(dr.Item['BLART']) ? '' : dr.Item['BLART'] )
				oBeAcfMVAt_MovimientoActivo.AMBid = ( IsDBNull(dr.Item['AMBid']) ? 0 : dr.Item['AMBid'] )
				oBeAcfMVAt_MovimientoActivo.CMPid = ( IsDBNull(dr.Item['CMPid']) ? '' : dr.Item['CMPid'] )
				oBeAcfMVAt_MovimientoActivo.UBEid = ( IsDBNull(dr.Item['UBEid']) ? 0 : dr.Item['UBEid'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfMVAt_MovimientoActivo oBeAcfMVAt_MovimientoActivo) {
		try {
			string sp = 'SpAcfMVAt_MovimientoActivoInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MVAID", oBeAcfMVAt_MovimientoActivo.MVAid));
			cmd.Parameters("@MVAID").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfMVAt_MovimientoActivo.ACFid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFACTIVO", oBeAcfMVAt_MovimientoActivo.ACFactivo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@BUKRS", oBeAcfMVAt_MovimientoActivo.BUKRS));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@SEGMENT", oBeAcfMVAt_MovimientoActivo.SEGMENT));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@KOSTL", oBeAcfMVAt_MovimientoActivo.KOSTL));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ANLKL", oBeAcfMVAt_MovimientoActivo.ANLKL));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PERNR", oBeAcfMVAt_MovimientoActivo.PERNR));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CSTID", oBeAcfMVAt_MovimientoActivo.CSTid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@TMVID", oBeAcfMVAt_MovimientoActivo.TMVid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MVMID", oBeAcfMVAt_MovimientoActivo.MVMid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFMOVIMIENTO", oBeAcfMVAt_MovimientoActivo.ACFfmovimiento));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@VNRID", oBeAcfMVAt_MovimientoActivo.VNRid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFINCORPORACION", oBeAcfMVAt_MovimientoActivo.ACFfincorporacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFCAPITALIZACION", oBeAcfMVAt_MovimientoActivo.ACFfcapitalizacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILTRIBANIO", oBeAcfMVAt_MovimientoActivo.ACFvutiltribanio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILTRIBDIA", oBeAcfMVAt_MovimientoActivo.ACFvutiltribdia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORTRIB", oBeAcfMVAt_MovimientoActivo.ACFvalortrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFACTORTRIB", oBeAcfMVAt_MovimientoActivo.ACFfactortrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPACUTRIB", oBeAcfMVAt_MovimientoActivo.ACFdepacutrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILNIIFANIO", oBeAcfMVAt_MovimientoActivo.ACFvutilniifanio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILNIIFDIA", oBeAcfMVAt_MovimientoActivo.ACFvutilniifdia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORNIIF", oBeAcfMVAt_MovimientoActivo.ACFvalorniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFACTORNIIF", oBeAcfMVAt_MovimientoActivo.ACFfactorniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPACUNIIF", oBeAcfMVAt_MovimientoActivo.ACFdepacuniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFOBRA", oBeAcfMVAt_MovimientoActivo.ACFobra));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD41", oBeAcfMVAt_MovimientoActivo.ACFord41));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD42", oBeAcfMVAt_MovimientoActivo.ACFord42));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD43", oBeAcfMVAt_MovimientoActivo.ACFord43));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD44", oBeAcfMVAt_MovimientoActivo.ACFord44));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFANLUE", oBeAcfMVAt_MovimientoActivo.ACFanlue));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCUENTA", oBeAcfMVAt_MovimientoActivo.ACFcuenta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCUENTADEP", oBeAcfMVAt_MovimientoActivo.ACFcuentadep));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCOMPROBANTE", oBeAcfMVAt_MovimientoActivo.ACFcomprobante));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFNOTAINGRESO", oBeAcfMVAt_MovimientoActivo.ACFnotaingreso));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFECHANOTAINGRESO", oBeAcfMVAt_MovimientoActivo.ACFfechanotaingreso));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORDENCOMPRA", oBeAcfMVAt_MovimientoActivo.ACFordencompra));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFECHAORDENCOMPRA", oBeAcfMVAt_MovimientoActivo.ACFfechaordencompra));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFOBSERVACION", oBeAcfMVAt_MovimientoActivo.ACFobservacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LIFNR", oBeAcfMVAt_MovimientoActivo.LIFNR));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@BLART", oBeAcfMVAt_MovimientoActivo.BLART));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@AMBID", oBeAcfMVAt_MovimientoActivo.AMBid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPID", oBeAcfMVAt_MovimientoActivo.CMPid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEID", oBeAcfMVAt_MovimientoActivo.UBEid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfMVAt_MovimientoActivo.MVAid = int.Parse(cmd.Parameters['@MVAID'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfMVAt_MovimientoActivo oBeAcfMVAt_MovimientoActivo) {
		try {
			string sp = 'SpAcfMVAt_MovimientoActivoActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MVAID", oBeAcfMVAt_MovimientoActivo.MVAid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfMVAt_MovimientoActivo.ACFid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFACTIVO", oBeAcfMVAt_MovimientoActivo.ACFactivo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@BUKRS", oBeAcfMVAt_MovimientoActivo.BUKRS));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@SEGMENT", oBeAcfMVAt_MovimientoActivo.SEGMENT));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@KOSTL", oBeAcfMVAt_MovimientoActivo.KOSTL));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ANLKL", oBeAcfMVAt_MovimientoActivo.ANLKL));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PERNR", oBeAcfMVAt_MovimientoActivo.PERNR));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CSTID", oBeAcfMVAt_MovimientoActivo.CSTid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@TMVID", oBeAcfMVAt_MovimientoActivo.TMVid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MVMID", oBeAcfMVAt_MovimientoActivo.MVMid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFMOVIMIENTO", oBeAcfMVAt_MovimientoActivo.ACFfmovimiento));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@VNRID", oBeAcfMVAt_MovimientoActivo.VNRid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFINCORPORACION", oBeAcfMVAt_MovimientoActivo.ACFfincorporacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFCAPITALIZACION", oBeAcfMVAt_MovimientoActivo.ACFfcapitalizacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILTRIBANIO", oBeAcfMVAt_MovimientoActivo.ACFvutiltribanio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILTRIBDIA", oBeAcfMVAt_MovimientoActivo.ACFvutiltribdia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORTRIB", oBeAcfMVAt_MovimientoActivo.ACFvalortrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFACTORTRIB", oBeAcfMVAt_MovimientoActivo.ACFfactortrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPACUTRIB", oBeAcfMVAt_MovimientoActivo.ACFdepacutrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILNIIFANIO", oBeAcfMVAt_MovimientoActivo.ACFvutilniifanio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILNIIFDIA", oBeAcfMVAt_MovimientoActivo.ACFvutilniifdia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORNIIF", oBeAcfMVAt_MovimientoActivo.ACFvalorniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFACTORNIIF", oBeAcfMVAt_MovimientoActivo.ACFfactorniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPACUNIIF", oBeAcfMVAt_MovimientoActivo.ACFdepacuniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFOBRA", oBeAcfMVAt_MovimientoActivo.ACFobra));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD41", oBeAcfMVAt_MovimientoActivo.ACFord41));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD42", oBeAcfMVAt_MovimientoActivo.ACFord42));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD43", oBeAcfMVAt_MovimientoActivo.ACFord43));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD44", oBeAcfMVAt_MovimientoActivo.ACFord44));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFANLUE", oBeAcfMVAt_MovimientoActivo.ACFanlue));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCUENTA", oBeAcfMVAt_MovimientoActivo.ACFcuenta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCUENTADEP", oBeAcfMVAt_MovimientoActivo.ACFcuentadep));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCOMPROBANTE", oBeAcfMVAt_MovimientoActivo.ACFcomprobante));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFNOTAINGRESO", oBeAcfMVAt_MovimientoActivo.ACFnotaingreso));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFECHANOTAINGRESO", oBeAcfMVAt_MovimientoActivo.ACFfechanotaingreso));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORDENCOMPRA", oBeAcfMVAt_MovimientoActivo.ACFordencompra));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFECHAORDENCOMPRA", oBeAcfMVAt_MovimientoActivo.ACFfechaordencompra));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFOBSERVACION", oBeAcfMVAt_MovimientoActivo.ACFobservacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LIFNR", oBeAcfMVAt_MovimientoActivo.LIFNR));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@BLART", oBeAcfMVAt_MovimientoActivo.BLART));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@AMBID", oBeAcfMVAt_MovimientoActivo.AMBid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CMPID", oBeAcfMVAt_MovimientoActivo.CMPid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEID", oBeAcfMVAt_MovimientoActivo.UBEid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfMVAt_MovimientoActivo oBeAcfMVAt_MovimientoActivo) {
		try {
			string sp = 'SpAcfMVAt_MovimientoActivoEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MVAID", oBeAcfMVAt_MovimientoActivo.MVAid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfMVAt_MovimientoActivoListar';
			
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

	public bool Obtener(ref clsBeAcfMVAt_MovimientoActivo oBeAcfMVAt_MovimientoActivo) {
		try {
			string sp = 'SpAcfMVAt_MovimientoActivoObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@MVAID", oBeAcfMVAt_MovimientoActivo.MVAid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfMVAt_MovimientoActivo, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfMVAt_MovimientoActivo oBeAcfMVAt_MovimientoActivo) {
		Try
			string sp = 'SpAcfMVAt_MovimientoActivoPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfMVAt_MovimientoActivo, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfMVAt_MovimientoActivo oBeAcfMVAt_MovimientoActivo) {
		try {
			string sp = 'SpAcfMVAt_MovimientoActivoUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfMVAt_MovimientoActivo, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfMVAt_MovimientoActivo oBeAcfMVAt_MovimientoActivo) {
		Try
			string sp = 'SpAcfMVAt_MovimientoActivoAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@MVAID", oBeAcfMVAt_MovimientoActivo.MVAid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfMVAt_MovimientoActivo, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfMVAt_MovimientoActivo oBeAcfMVAt_MovimientoActivo) {
		Try
			string sp = 'SpAcfMVAt_MovimientoActivoSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@MVAID", oBeAcfMVAt_MovimientoActivo.MVAid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfMVAt_MovimientoActivo, dt.Rows[0]);
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
