using BE;
using System.Data.SqlClient;
using System.Data;

public class clsLnAcfMEQt_maquinariaequipo {

	private ConnectionManager oConexion = null;

	 public clsLnAcfMEQt_maquinariaequipo(ConnectionManager oConexion) {
		try {
			this.oConexion = oConexion;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public void Cargar(ref clsBeTbUsuarios oBeAcfMEQt_maquinariaequipo, ref DataRow dr) {
		try {
				oBeAcfMEQt_maquinariaequipo.MEQvnrtot = ( IsDBNull(dr.Item['MEQvnrtot']) ? 0.0 : dr.Item['MEQvnrtot'] )
				oBeAcfMEQt_maquinariaequipo.MEQcantidad = ( IsDBNull(dr.Item['MEQcantidad']) ? 0.0 : dr.Item['MEQcantidad'] )
				oBeAcfMEQt_maquinariaequipo.MEQaccffecinc = ( IsDBNull(dr.Item['MEQaccffecinc']) ? 0.0 : dr.Item['MEQaccffecinc'] )
				oBeAcfMEQt_maquinariaequipo.MEQabreviatura = ( IsDBNull(dr.Item['MEQabreviatura']) ? '' : dr.Item['MEQabreviatura'] )
				oBeAcfMEQt_maquinariaequipo.MEQopiniontecnica = ( IsDBNull(dr.Item['MEQopiniontecnica']) ? '' : dr.Item['MEQopiniontecnica'] )
				oBeAcfMEQt_maquinariaequipo.MEQctacontable = ( IsDBNull(dr.Item['MEQctacontable']) ? 0.0 : dr.Item['MEQctacontable'] )
				oBeAcfMEQt_maquinariaequipo.MEQniif = ( IsDBNull(dr.Item['MEQniif']) ? 0.0 : dr.Item['MEQniif'] )
				oBeAcfMEQt_maquinariaequipo.MEQvrident = ( IsDBNull(dr.Item['MEQvrident']) ? 0.0 : dr.Item['MEQvrident'] )
				oBeAcfMEQt_maquinariaequipo.MEQprovdes = ( IsDBNull(dr.Item['MEQprovdes']) ? 0.0 : dr.Item['MEQprovdes'] )
				oBeAcfMEQt_maquinariaequipo.MEQcostorepcor = ( IsDBNull(dr.Item['MEQcostorepcor']) ? 0.0 : dr.Item['MEQcostorepcor'] )
				oBeAcfMEQt_maquinariaequipo.MEQfactorinst = ( IsDBNull(dr.Item['MEQfactorinst']) ? 0.0 : dr.Item['MEQfactorinst'] )
				oBeAcfMEQt_maquinariaequipo.MEQvalorresi = ( IsDBNull(dr.Item['MEQvalorresi']) ? 0.0 : dr.Item['MEQvalorresi'] )
				oBeAcfMEQt_maquinariaequipo.MEQedadact = ( IsDBNull(dr.Item['MEQedadact']) ? 0.0 : dr.Item['MEQedadact'] )
				oBeAcfMEQt_maquinariaequipo.MEQdeptas = ( IsDBNull(dr.Item['MEQdeptas']) ? 0.0 : dr.Item['MEQdeptas'] )
				oBeAcfMEQt_maquinariaequipo.MEQvalorref = ( IsDBNull(dr.Item['MEQvalorref']) ? 0.0 : dr.Item['MEQvalorref'] )
				oBeAcfMEQt_maquinariaequipo.MEQvalref2 = ( IsDBNull(dr.Item['MEQvalref2']) ? 0.0 : dr.Item['MEQvalref2'] )
				oBeAcfMEQt_maquinariaequipo.MEQvsm = ( IsDBNull(dr.Item['MEQvsm']) ? 0.0 : dr.Item['MEQvsm'] )
				oBeAcfMEQt_maquinariaequipo.MEQestado = ( IsDBNull(dr.Item['MEQestado']) ? 0.0 : dr.Item['MEQestado'] )
				oBeAcfMEQt_maquinariaequipo.MEQvidautil = ( IsDBNull(dr.Item['MEQvidautil']) ? 0.0 : dr.Item['MEQvidautil'] )
				oBeAcfMEQt_maquinariaequipo.MEQvidautmax = ( IsDBNull(dr.Item['MEQvidautmax']) ? 0.0 : dr.Item['MEQvidautmax'] )
				oBeAcfMEQt_maquinariaequipo.MEQedadtec = ( IsDBNull(dr.Item['MEQedadtec']) ? 0.0 : dr.Item['MEQedadtec'] )
				oBeAcfMEQt_maquinariaequipo.MEQdepreciacion = ( IsDBNull(dr.Item['MEQdepreciacion']) ? 0.0 : dr.Item['MEQdepreciacion'] )
				oBeAcfMEQt_maquinariaequipo.MEQdep2012 = ( IsDBNull(dr.Item['MEQdep2012']) ? 0.0 : dr.Item['MEQdep2012'] )
				oBeAcfMEQt_maquinariaequipo.MEQcostocorr = ( IsDBNull(dr.Item['MEQcostocorr']) ? 0.0 : dr.Item['MEQcostocorr'] )
				oBeAcfMEQt_maquinariaequipo.MEQvaloractivo = ( IsDBNull(dr.Item['MEQvaloractivo']) ? 0.0 : dr.Item['MEQvaloractivo'] )
				oBeAcfMEQt_maquinariaequipo.MEQdepre = ( IsDBNull(dr.Item['MEQdepre']) ? 0.0 : dr.Item['MEQdepre'] )
				oBeAcfMEQt_maquinariaequipo.MEQtasair = ( IsDBNull(dr.Item['MEQtasair']) ? 0.0 : dr.Item['MEQtasair'] )
				oBeAcfMEQt_maquinariaequipo.MEQimpdife = ( IsDBNull(dr.Item['MEQimpdife']) ? 0.0 : dr.Item['MEQimpdife'] )
				oBeAcfMEQt_maquinariaequipo.MEQdifneta = ( IsDBNull(dr.Item['MEQdifneta']) ? 0.0 : dr.Item['MEQdifneta'] )
				oBeAcfMEQt_maquinariaequipo.MEQvalorneto = ( IsDBNull(dr.Item['MEQvalorneto']) ? 0.0 : dr.Item['MEQvalorneto'] )
				oBeAcfMEQt_maquinariaequipo.MEQvalact = ( IsDBNull(dr.Item['MEQvalact']) ? 0.0 : dr.Item['MEQvalact'] )
				oBeAcfMEQt_maquinariaequipo.MEQcostotcorr = ( IsDBNull(dr.Item['MEQcostotcorr']) ? 0.0 : dr.Item['MEQcostotcorr'] )
				oBeAcfMEQt_maquinariaequipo.MEQdepacuniif = ( IsDBNull(dr.Item['MEQdepacuniif']) ? 0.0 : dr.Item['MEQdepacuniif'] )
				oBeAcfMEQt_maquinariaequipo.MEQcrcnet = ( IsDBNull(dr.Item['MEQcrcnet']) ? 0.0 : dr.Item['MEQcrcnet'] )
				oBeAcfMEQt_maquinariaequipo.MEQvalnet = ( IsDBNull(dr.Item['MEQvalnet']) ? 0.0 : dr.Item['MEQvalnet'] )
				oBeAcfMEQt_maquinariaequipo.MEQdiferenneta = ( IsDBNull(dr.Item['MEQdiferenneta']) ? 0.0 : dr.Item['MEQdiferenneta'] )
				oBeAcfMEQt_maquinariaequipo.MEQvalornetolib = ( IsDBNull(dr.Item['MEQvalornetolib']) ? 0.0 : dr.Item['MEQvalornetolib'] )
				oBeAcfMEQt_maquinariaequipo.MEQdepacumtrib = ( IsDBNull(dr.Item['MEQdepacumtrib']) ? 0.0 : dr.Item['MEQdepacumtrib'] )
				oBeAcfMEQt_maquinariaequipo.MEQcostohistorico = ( IsDBNull(dr.Item['MEQcostohistorico']) ? 0.0 : dr.Item['MEQcostohistorico'] )
				oBeAcfMEQt_maquinariaequipo.RVAcodigo = ( IsDBNull(dr.Item['RVAcodigo']) ? '' : dr.Item['RVAcodigo'] )
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Insertar(ref clsBeAcfMEQt_maquinariaequipo oBeAcfMEQt_maquinariaequipo) {
		try {
			string sp = 'SpAcfMEQt_maquinariaequipoInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVNRTOT", oBeAcfMEQt_maquinariaequipo.MEQvnrtot));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQCANTIDAD", oBeAcfMEQt_maquinariaequipo.MEQcantidad));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQACCFFECINC", oBeAcfMEQt_maquinariaequipo.MEQaccffecinc));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQABREVIATURA", oBeAcfMEQt_maquinariaequipo.MEQabreviatura));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQOPINIONTECNICA", oBeAcfMEQt_maquinariaequipo.MEQopiniontecnica));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQCTACONTABLE", oBeAcfMEQt_maquinariaequipo.MEQctacontable));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQNIIF", oBeAcfMEQt_maquinariaequipo.MEQniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVRIDENT", oBeAcfMEQt_maquinariaequipo.MEQvrident));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQPROVDES", oBeAcfMEQt_maquinariaequipo.MEQprovdes));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQCOSTOREPCOR", oBeAcfMEQt_maquinariaequipo.MEQcostorepcor));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQFACTORINST", oBeAcfMEQt_maquinariaequipo.MEQfactorinst));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVALORRESI", oBeAcfMEQt_maquinariaequipo.MEQvalorresi));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQEDADACT", oBeAcfMEQt_maquinariaequipo.MEQedadact));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQDEPTAS", oBeAcfMEQt_maquinariaequipo.MEQdeptas));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVALORREF", oBeAcfMEQt_maquinariaequipo.MEQvalorref));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVALREF2", oBeAcfMEQt_maquinariaequipo.MEQvalref2));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVSM", oBeAcfMEQt_maquinariaequipo.MEQvsm));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQESTADO", oBeAcfMEQt_maquinariaequipo.MEQestado));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVIDAUTIL", oBeAcfMEQt_maquinariaequipo.MEQvidautil));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVIDAUTMAX", oBeAcfMEQt_maquinariaequipo.MEQvidautmax));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQEDADTEC", oBeAcfMEQt_maquinariaequipo.MEQedadtec));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQDEPRECIACION", oBeAcfMEQt_maquinariaequipo.MEQdepreciacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQDEP2012", oBeAcfMEQt_maquinariaequipo.MEQdep2012));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQCOSTOCORR", oBeAcfMEQt_maquinariaequipo.MEQcostocorr));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVALORACTIVO", oBeAcfMEQt_maquinariaequipo.MEQvaloractivo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQDEPRE", oBeAcfMEQt_maquinariaequipo.MEQdepre));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQTASAIR", oBeAcfMEQt_maquinariaequipo.MEQtasair));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQIMPDIFE", oBeAcfMEQt_maquinariaequipo.MEQimpdife));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQDIFNETA", oBeAcfMEQt_maquinariaequipo.MEQdifneta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVALORNETO", oBeAcfMEQt_maquinariaequipo.MEQvalorneto));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVALACT", oBeAcfMEQt_maquinariaequipo.MEQvalact));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQCOSTOTCORR", oBeAcfMEQt_maquinariaequipo.MEQcostotcorr));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQDEPACUNIIF", oBeAcfMEQt_maquinariaequipo.MEQdepacuniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQCRCNET", oBeAcfMEQt_maquinariaequipo.MEQcrcnet));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVALNET", oBeAcfMEQt_maquinariaequipo.MEQvalnet));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQDIFERENNETA", oBeAcfMEQt_maquinariaequipo.MEQdiferenneta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVALORNETOLIB", oBeAcfMEQt_maquinariaequipo.MEQvalornetolib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQDEPACUMTRIB", oBeAcfMEQt_maquinariaequipo.MEQdepacumtrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQCOSTOHISTORICO", oBeAcfMEQt_maquinariaequipo.MEQcostohistorico));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfMEQt_maquinariaequipo.RVAcodigo));
			cmd.Parameters("@RVACODIGO").Direction = ParameterDirection.Output;
			
			rowsAffected = cmd.ExecuteNonQuery();
			oBeAcfMEQt_maquinariaequipo.RVAcodigo = Convert.ToString(cmd.Parameters['@RVACODIGO'].Value);
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Actualizar(ref clsBeAcfMEQt_maquinariaequipo oBeAcfMEQt_maquinariaequipo) {
		try {
			string sp = 'SpAcfMEQt_maquinariaequipoActualizar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVNRTOT", oBeAcfMEQt_maquinariaequipo.MEQvnrtot));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQCANTIDAD", oBeAcfMEQt_maquinariaequipo.MEQcantidad));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQACCFFECINC", oBeAcfMEQt_maquinariaequipo.MEQaccffecinc));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQABREVIATURA", oBeAcfMEQt_maquinariaequipo.MEQabreviatura));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQOPINIONTECNICA", oBeAcfMEQt_maquinariaequipo.MEQopiniontecnica));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQCTACONTABLE", oBeAcfMEQt_maquinariaequipo.MEQctacontable));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQNIIF", oBeAcfMEQt_maquinariaequipo.MEQniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVRIDENT", oBeAcfMEQt_maquinariaequipo.MEQvrident));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQPROVDES", oBeAcfMEQt_maquinariaequipo.MEQprovdes));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQCOSTOREPCOR", oBeAcfMEQt_maquinariaequipo.MEQcostorepcor));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQFACTORINST", oBeAcfMEQt_maquinariaequipo.MEQfactorinst));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVALORRESI", oBeAcfMEQt_maquinariaequipo.MEQvalorresi));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQEDADACT", oBeAcfMEQt_maquinariaequipo.MEQedadact));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQDEPTAS", oBeAcfMEQt_maquinariaequipo.MEQdeptas));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVALORREF", oBeAcfMEQt_maquinariaequipo.MEQvalorref));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVALREF2", oBeAcfMEQt_maquinariaequipo.MEQvalref2));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVSM", oBeAcfMEQt_maquinariaequipo.MEQvsm));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQESTADO", oBeAcfMEQt_maquinariaequipo.MEQestado));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVIDAUTIL", oBeAcfMEQt_maquinariaequipo.MEQvidautil));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVIDAUTMAX", oBeAcfMEQt_maquinariaequipo.MEQvidautmax));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQEDADTEC", oBeAcfMEQt_maquinariaequipo.MEQedadtec));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQDEPRECIACION", oBeAcfMEQt_maquinariaequipo.MEQdepreciacion));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQDEP2012", oBeAcfMEQt_maquinariaequipo.MEQdep2012));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQCOSTOCORR", oBeAcfMEQt_maquinariaequipo.MEQcostocorr));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVALORACTIVO", oBeAcfMEQt_maquinariaequipo.MEQvaloractivo));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQDEPRE", oBeAcfMEQt_maquinariaequipo.MEQdepre));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQTASAIR", oBeAcfMEQt_maquinariaequipo.MEQtasair));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQIMPDIFE", oBeAcfMEQt_maquinariaequipo.MEQimpdife));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQDIFNETA", oBeAcfMEQt_maquinariaequipo.MEQdifneta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVALORNETO", oBeAcfMEQt_maquinariaequipo.MEQvalorneto));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVALACT", oBeAcfMEQt_maquinariaequipo.MEQvalact));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQCOSTOTCORR", oBeAcfMEQt_maquinariaequipo.MEQcostotcorr));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQDEPACUNIIF", oBeAcfMEQt_maquinariaequipo.MEQdepacuniif));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQCRCNET", oBeAcfMEQt_maquinariaequipo.MEQcrcnet));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVALNET", oBeAcfMEQt_maquinariaequipo.MEQvalnet));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQDIFERENNETA", oBeAcfMEQt_maquinariaequipo.MEQdiferenneta));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQVALORNETOLIB", oBeAcfMEQt_maquinariaequipo.MEQvalornetolib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQDEPACUMTRIB", oBeAcfMEQt_maquinariaequipo.MEQdepacumtrib));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@MEQCOSTOHISTORICO", oBeAcfMEQt_maquinariaequipo.MEQcostohistorico));
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfMEQt_maquinariaequipo.RVAcodigo));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public int Eliminar(ref clsBeAcfMEQt_maquinariaequipo oBeAcfMEQt_maquinariaequipo) {
		try {
			string sp = 'SpAcfMEQt_maquinariaequipoEliminar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
			int rowsAffected = 0;
			cmd.Open();
			
			cmd.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfMEQt_maquinariaequipo.RVAcodigo));
			
			rowsAffected = cmd.ExecuteNonQuery();
			
			return rowsAffected;
			
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public DataTable Listar() {
		try {
			string sp = 'SpAcfMEQt_maquinariaequipoListar';
			
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

	public bool Obtener(ref clsBeAcfMEQt_maquinariaequipo oBeAcfMEQt_maquinariaequipo) {
		try {
			string sp = 'SpAcfMEQt_maquinariaequipoObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfMEQt_maquinariaequipo.RVAcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfMEQt_maquinariaequipo, dt.Rows(0))
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

	public bool Primero(ref clsBeAcfMEQt_maquinariaequipo oBeAcfMEQt_maquinariaequipo) {
		Try
			string sp = 'SpAcfMEQt_maquinariaequipoPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfMEQt_maquinariaequipo, dt.Rows[0]);
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

	public bool Primero(ref clsBeAcfMEQt_maquinariaequipo oBeAcfMEQt_maquinariaequipo) {
		try {
			string sp = 'SpAcfMEQt_maquinariaequipoUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfMEQt_maquinariaequipo, dt.Rows[0]);
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

	public bool Anterior(ref clsBeAcfMEQt_maquinariaequipo oBeAcfMEQt_maquinariaequipo) {
		Try
			string sp = 'SpAcfMEQt_maquinariaequipoAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfMEQt_maquinariaequipo.RVAcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfMEQt_maquinariaequipo, dt.Rows[0]);
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

	public bool Siguiente(ref clsBeAcfMEQt_maquinariaequipo oBeAcfMEQt_maquinariaequipo) {
		Try
			string sp = 'SpAcfMEQt_maquinariaequipoSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@RVACODIGO", oBeAcfMEQt_maquinariaequipo.RVAcodigo));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeAcfMEQt_maquinariaequipo, dt.Rows[0]);
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
