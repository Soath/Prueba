using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfINBt_Inventariobienes {

	private ConnectionManager oConexion = null;

	 public clsLnAcfINBt_Inventariobienes(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfINBt_Inventariobienes, ref DataRow dr) {
		try {
				oBeAcfINBt_Inventariobienes.INVid = ( IsDBNull(dr.Item['INVid']) ? 0 : dr.Item['INVid'] )
				oBeAcfINBt_Inventariobienes.ACFid = ( IsDBNull(dr.Item['ACFid']) ? 0 : dr.Item['ACFid'] )
				oBeAcfINBt_Inventariobienes.ACFactivo = ( IsDBNull(dr.Item['ACFactivo']) ? '' : dr.Item['ACFactivo'] )
				oBeAcfINBt_Inventariobienes.BUKRS = ( IsDBNull(dr.Item['BUKRS']) ? '' : dr.Item['BUKRS'] )
				oBeAcfINBt_Inventariobienes.SEGMENT = ( IsDBNull(dr.Item['SEGMENT']) ? '' : dr.Item['SEGMENT'] )
				oBeAcfINBt_Inventariobienes.KOSTL = ( IsDBNull(dr.Item['KOSTL']) ? '' : dr.Item['KOSTL'] )
				oBeAcfINBt_Inventariobienes.ANLKL = ( IsDBNull(dr.Item['ANLKL']) ? '' : dr.Item['ANLKL'] )
				oBeAcfINBt_Inventariobienes.PERNR = ( IsDBNull(dr.Item['PERNR']) ? '' : dr.Item['PERNR'] )
				oBeAcfINBt_Inventariobienes.ACTid = ( IsDBNull(dr.Item['ACTid']) ? '' : dr.Item['ACTid'] )
				oBeAcfINBt_Inventariobienes.CSTid = ( IsDBNull(dr.Item['CSTid']) ? '' : dr.Item['CSTid'] )
				oBeAcfINBt_Inventariobienes.VNRid = ( IsDBNull(dr.Item['VNRid']) ? '' : dr.Item['VNRid'] )
				oBeAcfINBt_Inventariobienes.ACFfincorporacion = ( IsDBNull(dr.Item['ACFfincorporacion']) ? Date.Now() : dr.Item['ACFfincorporacion'] )
				oBeAcfINBt_Inventariobienes.ACFfcapitalizacion = ( IsDBNull(dr.Item['ACFfcapitalizacion']) ? Date.Now() : dr.Item['ACFfcapitalizacion'] )
				oBeAcfINBt_Inventariobienes.ACFvutiltribanio = ( IsDBNull(dr.Item['ACFvutiltribanio']) ? 0 : dr.Item['ACFvutiltribanio'] )
				oBeAcfINBt_Inventariobienes.ACFvutiltribdia = ( IsDBNull(dr.Item['ACFvutiltribdia']) ? 0 : dr.Item['ACFvutiltribdia'] )
				oBeAcfINBt_Inventariobienes.ACFvalortrib = ( IsDBNull(dr.Item['ACFvalortrib']) ? 0.0 : dr.Item['ACFvalortrib'] )
				oBeAcfINBt_Inventariobienes.ACFfactortrib = ( IsDBNull(dr.Item['ACFfactortrib']) ? 0.0 : dr.Item['ACFfactortrib'] )
				oBeAcfINBt_Inventariobienes.ACFdepacutrib = ( IsDBNull(dr.Item['ACFdepacutrib']) ? 0.0 : dr.Item['ACFdepacutrib'] )
				oBeAcfINBt_Inventariobienes.ACfvutilniifanio = ( IsDBNull(dr.Item['ACfvutilniifanio']) ? 0 : dr.Item['ACfvutilniifanio'] )
				oBeAcfINBt_Inventariobienes.ACFvutilniifdia = ( IsDBNull(dr.Item['ACFvutilniifdia']) ? 0 : dr.Item['ACFvutilniifdia'] )
				oBeAcfINBt_Inventariobienes.ACFvalorniif = ( IsDBNull(dr.Item['ACFvalorniif']) ? 0.0 : dr.Item['ACFvalorniif'] )
				oBeAcfINBt_Inventariobienes.ACFfactorniif = ( IsDBNull(dr.Item['ACFfactorniif']) ? 0.0 : dr.Item['ACFfactorniif'] )
				oBeAcfINBt_Inventariobienes.ACFdepacuniif = ( IsDBNull(dr.Item['ACFdepacuniif']) ? 0.0 : dr.Item['ACFdepacuniif'] )
				oBeAcfINBt_Inventariobienes.ACFobra = ( IsDBNull(dr.Item['ACFobra']) ? '' : dr.Item['ACFobra'] )
				oBeAcfINBt_Inventariobienes.ACFord41 = ( IsDBNull(dr.Item['ACFord41']) ? '' : dr.Item['ACFord41'] )
				oBeAcfINBt_Inventariobienes.ACFord42 = ( IsDBNull(dr.Item['ACFord42']) ? '' : dr.Item['ACFord42'] )
				oBeAcfINBt_Inventariobienes.ACFord43 = ( IsDBNull(dr.Item['ACFord43']) ? '' : dr.Item['ACFord43'] )
				oBeAcfINBt_Inventariobienes.ACFord44 = ( IsDBNull(dr.Item['ACFord44']) ? '' : dr.Item['ACFord44'] )
				oBeAcfINBt_Inventariobienes.ACFanlue = ( IsDBNull(dr.Item['ACFanlue']) ? '' : dr.Item['ACFanlue'] )
				oBeAcfINBt_Inventariobienes.ACFcuenta = ( IsDBNull(dr.Item['ACFcuenta']) ? '' : dr.Item['ACFcuenta'] )
				oBeAcfINBt_Inventariobienes.ACFcuentadep = ( IsDBNull(dr.Item['ACFcuentadep']) ? '' : dr.Item['ACFcuentadep'] )
				oBeAcfINBt_Inventariobienes.LIFNR = ( IsDBNull(dr.Item['LIFNR']) ? '' : dr.Item['LIFNR'] )
				oBeAcfINBt_Inventariobienes.BLART = ( IsDBNull(dr.Item['BLART']) ? '' : dr.Item['BLART'] )
				oBeAcfINBt_Inventariobienes.ACFcomprobante = ( IsDBNull(dr.Item['ACFcomprobante']) ? '' : dr.Item['ACFcomprobante'] )
				oBeAcfINBt_Inventariobienes.ACFnotaingreso = ( IsDBNull(dr.Item['ACFnotaingreso']) ? '' : dr.Item['ACFnotaingreso'] )
				oBeAcfINBt_Inventariobienes.ACFfechanotaingreso = ( IsDBNull(dr.Item['ACFfechanotaingreso']) ? Date.Now() : dr.Item['ACFfechanotaingreso'] )
				oBeAcfINBt_Inventariobienes.ACFordencompra = ( IsDBNull(dr.Item['ACFordencompra']) ? '' : dr.Item['ACFordencompra'] )
				oBeAcfINBt_Inventariobienes.ACFobservacion = ( IsDBNull(dr.Item['ACFobservacion']) ? '' : dr.Item['ACFobservacion'] )
				oBeAcfINBt_Inventariobienes.AMBid = ( IsDBNull(dr.Item['AMBid']) ? 0 : dr.Item['AMBid'] )
				oBeAcfINBt_Inventariobienes.UBEid = ( IsDBNull(dr.Item['UBEid']) ? 0 : dr.Item['UBEid'] )
				oBeAcfINBt_Inventariobienes.ACFfechacomprobante = ( IsDBNull(dr.Item['ACFfechacomprobante']) ? Date.Now() : dr.Item['ACFfechacomprobante'] )
				oBeAcfINBt_Inventariobienes.ACFfechaordencompra = ( IsDBNull(dr.Item['ACFfechaordencompra']) ? Date.Now() : dr.Item['ACFfechaordencompra'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfINBt_Inventariobienes oBeAcfINBt_Inventariobienes) {
		try {
			string sp = 'SpAcfINBt_InventariobienesInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVID", oBeAcfINBt_Inventariobienes.INVid));
			cmd.Parameters("@INVID").Direction = ParameterDirection.Output;
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfINBt_Inventariobienes.ACFid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFACTIVO", oBeAcfINBt_Inventariobienes.ACFactivo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@BUKRS", oBeAcfINBt_Inventariobienes.BUKRS));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@SEGMENT", oBeAcfINBt_Inventariobienes.SEGMENT));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@KOSTL", oBeAcfINBt_Inventariobienes.KOSTL));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ANLKL", oBeAcfINBt_Inventariobienes.ANLKL));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PERNR", oBeAcfINBt_Inventariobienes.PERNR));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACTID", oBeAcfINBt_Inventariobienes.ACTid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CSTID", oBeAcfINBt_Inventariobienes.CSTid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@VNRID", oBeAcfINBt_Inventariobienes.VNRid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFINCORPORACION", oBeAcfINBt_Inventariobienes.ACFfincorporacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFCAPITALIZACION", oBeAcfINBt_Inventariobienes.ACFfcapitalizacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILTRIBANIO", oBeAcfINBt_Inventariobienes.ACFvutiltribanio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILTRIBDIA", oBeAcfINBt_Inventariobienes.ACFvutiltribdia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORTRIB", oBeAcfINBt_Inventariobienes.ACFvalortrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFACTORTRIB", oBeAcfINBt_Inventariobienes.ACFfactortrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPACUTRIB", oBeAcfINBt_Inventariobienes.ACFdepacutrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILNIIFANIO", oBeAcfINBt_Inventariobienes.ACfvutilniifanio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILNIIFDIA", oBeAcfINBt_Inventariobienes.ACFvutilniifdia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORNIIF", oBeAcfINBt_Inventariobienes.ACFvalorniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFACTORNIIF", oBeAcfINBt_Inventariobienes.ACFfactorniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPACUNIIF", oBeAcfINBt_Inventariobienes.ACFdepacuniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFOBRA", oBeAcfINBt_Inventariobienes.ACFobra));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD41", oBeAcfINBt_Inventariobienes.ACFord41));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD42", oBeAcfINBt_Inventariobienes.ACFord42));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD43", oBeAcfINBt_Inventariobienes.ACFord43));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD44", oBeAcfINBt_Inventariobienes.ACFord44));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFANLUE", oBeAcfINBt_Inventariobienes.ACFanlue));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCUENTA", oBeAcfINBt_Inventariobienes.ACFcuenta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCUENTADEP", oBeAcfINBt_Inventariobienes.ACFcuentadep));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LIFNR", oBeAcfINBt_Inventariobienes.LIFNR));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@BLART", oBeAcfINBt_Inventariobienes.BLART));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCOMPROBANTE", oBeAcfINBt_Inventariobienes.ACFcomprobante));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFNOTAINGRESO", oBeAcfINBt_Inventariobienes.ACFnotaingreso));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFECHANOTAINGRESO", oBeAcfINBt_Inventariobienes.ACFfechanotaingreso));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORDENCOMPRA", oBeAcfINBt_Inventariobienes.ACFordencompra));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFOBSERVACION", oBeAcfINBt_Inventariobienes.ACFobservacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@AMBID", oBeAcfINBt_Inventariobienes.AMBid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEID", oBeAcfINBt_Inventariobienes.UBEid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFECHACOMPROBANTE", oBeAcfINBt_Inventariobienes.ACFfechacomprobante));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFECHAORDENCOMPRA", oBeAcfINBt_Inventariobienes.ACFfechaordencompra));
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfINBt_Inventariobienes.INVid = int.Parse(cmd.Parameters['@INVID'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfINBt_Inventariobienes oBeAcfINBt_Inventariobienes) {
		try {
			string sp = 'SpAcfINBt_InventariobienesActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVID", oBeAcfINBt_Inventariobienes.INVid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFID", oBeAcfINBt_Inventariobienes.ACFid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFACTIVO", oBeAcfINBt_Inventariobienes.ACFactivo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@BUKRS", oBeAcfINBt_Inventariobienes.BUKRS));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@SEGMENT", oBeAcfINBt_Inventariobienes.SEGMENT));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@KOSTL", oBeAcfINBt_Inventariobienes.KOSTL));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ANLKL", oBeAcfINBt_Inventariobienes.ANLKL));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@PERNR", oBeAcfINBt_Inventariobienes.PERNR));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACTID", oBeAcfINBt_Inventariobienes.ACTid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@CSTID", oBeAcfINBt_Inventariobienes.CSTid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@VNRID", oBeAcfINBt_Inventariobienes.VNRid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFINCORPORACION", oBeAcfINBt_Inventariobienes.ACFfincorporacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFCAPITALIZACION", oBeAcfINBt_Inventariobienes.ACFfcapitalizacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILTRIBANIO", oBeAcfINBt_Inventariobienes.ACFvutiltribanio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILTRIBDIA", oBeAcfINBt_Inventariobienes.ACFvutiltribdia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORTRIB", oBeAcfINBt_Inventariobienes.ACFvalortrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFACTORTRIB", oBeAcfINBt_Inventariobienes.ACFfactortrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPACUTRIB", oBeAcfINBt_Inventariobienes.ACFdepacutrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILNIIFANIO", oBeAcfINBt_Inventariobienes.ACfvutilniifanio));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVUTILNIIFDIA", oBeAcfINBt_Inventariobienes.ACFvutilniifdia));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFVALORNIIF", oBeAcfINBt_Inventariobienes.ACFvalorniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFACTORNIIF", oBeAcfINBt_Inventariobienes.ACFfactorniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFDEPACUNIIF", oBeAcfINBt_Inventariobienes.ACFdepacuniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFOBRA", oBeAcfINBt_Inventariobienes.ACFobra));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD41", oBeAcfINBt_Inventariobienes.ACFord41));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD42", oBeAcfINBt_Inventariobienes.ACFord42));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD43", oBeAcfINBt_Inventariobienes.ACFord43));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORD44", oBeAcfINBt_Inventariobienes.ACFord44));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFANLUE", oBeAcfINBt_Inventariobienes.ACFanlue));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCUENTA", oBeAcfINBt_Inventariobienes.ACFcuenta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCUENTADEP", oBeAcfINBt_Inventariobienes.ACFcuentadep));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@LIFNR", oBeAcfINBt_Inventariobienes.LIFNR));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@BLART", oBeAcfINBt_Inventariobienes.BLART));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFCOMPROBANTE", oBeAcfINBt_Inventariobienes.ACFcomprobante));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFNOTAINGRESO", oBeAcfINBt_Inventariobienes.ACFnotaingreso));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFECHANOTAINGRESO", oBeAcfINBt_Inventariobienes.ACFfechanotaingreso));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFORDENCOMPRA", oBeAcfINBt_Inventariobienes.ACFordencompra));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFOBSERVACION", oBeAcfINBt_Inventariobienes.ACFobservacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@AMBID", oBeAcfINBt_Inventariobienes.AMBid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@UBEID", oBeAcfINBt_Inventariobienes.UBEid));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFECHACOMPROBANTE", oBeAcfINBt_Inventariobienes.ACFfechacomprobante));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@ACFFECHAORDENCOMPRA", oBeAcfINBt_Inventariobienes.ACFfechaordencompra));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfINBt_Inventariobienes oBeAcfINBt_Inventariobienes) {
		try {
			string sp = 'SpAcfINBt_InventariobienesEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@INVID", oBeAcfINBt_Inventariobienes.INVid));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfINBt_InventariobienesListar';
			
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

	public bool Obtener(ref clsBeAcfINBt_Inventariobienes oBeAcfINBt_Inventariobienes) {
		try {
			string sp = 'SpAcfINBt_InventariobienesObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@INVID", oBeAcfINBt_Inventariobienes.INVid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfINBt_Inventariobienes, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfINBt_Inventariobienes oBeAcfINBt_Inventariobienes) {
		Try
			string sp = 'SpAcfINBt_InventariobienesPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfINBt_Inventariobienes, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfINBt_Inventariobienes oBeAcfINBt_Inventariobienes) {
		try {
			string sp = 'SpAcfINBt_InventariobienesUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfINBt_Inventariobienes, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfINBt_Inventariobienes oBeAcfINBt_Inventariobienes) {
		Try
			string sp = 'SpAcfINBt_InventariobienesAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@INVID", oBeAcfINBt_Inventariobienes.INVid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfINBt_Inventariobienes, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfINBt_Inventariobienes oBeAcfINBt_Inventariobienes) {
		Try
			string sp = 'SpAcfINBt_InventariobienesSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@INVID", oBeAcfINBt_Inventariobienes.INVid));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfINBt_Inventariobienes, dt.Rows[0]);
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
