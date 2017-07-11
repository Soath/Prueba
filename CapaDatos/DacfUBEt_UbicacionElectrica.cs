using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DacfUBEt_UbicacionElectrica{

        private string iUBEcodigogis;
        private string sUBEobra;
        private string sKOSTL;
        private string sVNRid;
        private string sSELid;
        private string iUBEset;
        private string sUBEsetetq;
        private string iUBEalimentador;
        private string sUBEalimentadoretq;
        private string iUBEsed;
        private string sUBEsedetq;
        private string iUBEcircuito;
        private string sUBEcircuitoetq;
        private string iUBEpuntoi;
        private string sUBEpuntoietq;
        private string iUBEpuntof;
        private string sUBEpuntofetq;
        private string iUBEid;
        private string iACFid; 
        private string cUBIGEO;
        private string cUBEpostei;
        private string cUBEpostef;

        public string UBEcodigogis
        {
            get { return iUBEcodigogis; }
            set { iUBEcodigogis = value; }
        }
        public string UBEobra
        {
            get { return sUBEobra; }
            set { sUBEobra = value; }
        }
        public string KOSTL
        {
            get { return sKOSTL; }
            set { sKOSTL = value; }
        }
        public string VNRid
        {
            get { return sVNRid; }
            set { sVNRid = value; }
        }
        public string SELid
        {
            get { return sSELid; }
            set { sSELid = value; }
        }
        public string UBEset
        {
            get { return iUBEset; }
            set { iUBEset = value; }
        }
        public string UBEsetetq
        {
            get { return sUBEsetetq; }
            set { sUBEsetetq = value; }
        }
        public string UBEalimentador
        {
            get { return iUBEalimentador; }
            set { iUBEalimentador = value; }
        }
        public string UBEalimentadoretq
        {
            get { return sUBEalimentadoretq; }
            set { sUBEalimentadoretq = value; }
        }
        public string UBEsed
        {
            get { return iUBEsed; }
            set { iUBEsed = value; }
        }
        public string UBEsedetq
        {
            get { return sUBEsedetq; }
            set { sUBEsedetq = value; }
        }
        public string UBEcircuito
        {
            get { return iUBEcircuito; }
            set { iUBEcircuito = value; }
        }
        public string UBEcircuitoetq
        {
            get { return sUBEcircuitoetq; }
            set { sUBEcircuitoetq = value; }
        }
        public string UBEpuntoi
        {
            get { return iUBEpuntoi; }
            set { iUBEpuntoi = value; }
        }
        public string UBEpuntoietq
        {
            get { return sUBEpuntoietq; }
            set { sUBEpuntoietq = value; }
        }
        public string UBEpuntof
        {
            get { return iUBEpuntof; }
            set { iUBEpuntof = value; }
        }
        public string UBEpuntofetq
        {
            get { return sUBEpuntofetq; }
            set { sUBEpuntofetq = value; }
        }
        public string UBEid
        {
            get { return iUBEid; }
            set { iUBEid = value; }
        }
        public string ACFid
        {
            get { return iACFid; }
            set { iACFid = value; }
        }

        public string UBIGEO
        {
            get { return cUBIGEO; }
            set { cUBIGEO = value; }
        }
        public string UBEpostei
        {
            get { return cUBEpostei; }
            set { cUBEpostei = value; }
        }
        public string UBEpostef
        {
            get { return cUBEpostef; }
            set { cUBEpostef = value; }
        }
       
        //Constructor vacío
	public DacfUBEt_UbicacionElectrica(){
	}
        //Constructor con parámetros
    public DacfUBEt_UbicacionElectrica(
         string UBEcodigogis,
         string UBEobra,               
         string KOSTL,                 
         string VNRid,                   
         string SELid,                   
         string UBEset,
         string UBEsetetq,            
         string UBEalimentador,         
         string UBEalimentadoretq,                   
         string UBEsed,          
         string UBEsedetq,      
         string UBEcircuito,     
         string UBEcircuitoetq,        
         string UBEpuntoi,         
         string UBEpuntoietq,               
         string UBEpuntof,             
         string UBEpuntofetq,           
         string UBEid,         
         string ACFid)         
    {

        this.UBEcodigogis = iUBEcodigogis;
        this.UBEobra = sUBEobra;
        this.KOSTL = sKOSTL;
        this.VNRid = sVNRid;
        this.SELid = sSELid;
        this.UBEset = iUBEset;
        this.UBEsetetq = sUBEsetetq;
        this.UBEalimentador = iUBEalimentador;
        this.UBEalimentadoretq = sUBEalimentadoretq;
        this.UBEsed = iUBEsed;
        this.UBEsedetq = sUBEsedetq;
        this.UBEcircuito = iUBEcircuito;
        this.UBEcircuitoetq = sUBEcircuitoetq;
        this.UBEpuntoi = iUBEpuntoi;
        this.UBEpuntoietq = sUBEpuntoietq;
        this.UBEpuntof = iUBEpuntof;
        this.UBEpuntofetq = sUBEpuntofetq;
        this.UBEid = iUBEid;
        this.ACFid = iACFid;      
	}

/*	public object Clone() {
//		return base.MemberwiseClone();
//	}
*/

    //METODO MOSTRAR
        public DataTable Mostrar() {
           DataTable DtResultado = new DataTable("acfUBEt_UbicacionElectrica");
            SqlConnection SqlCon = new SqlConnection();

		try {
            //Codigo
             SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfUBEt_UbicacionElectrica";
                SqlCmd.CommandType = CommandType.StoredProcedure;



                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
        }
				
	        catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
	}

        //METODO INSERTAR 
	public string Insertar(DacfUBEt_UbicacionElectrica acfUBEt_UbicacionElectrica)
    {
        string rpta = "";
        SqlConnection SqlCon = new SqlConnection();
		try {
             //Código
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_I_acfUBEt_UbicacionElectrica";
                SqlCmd.CommandType = CommandType.StoredProcedure;                            
                //
                SqlParameter ParUBEcodigogis = new SqlParameter();
                ParUBEcodigogis.ParameterName = "@iUBEcodigogis";
                ParUBEcodigogis.SqlDbType = SqlDbType.BigInt;
                ParUBEcodigogis.Value = Convert.ToInt64(acfUBEt_UbicacionElectrica.UBEcodigogis);
                SqlCmd.Parameters.Add(ParUBEcodigogis);
                //
                SqlParameter ParUBEobra = new SqlParameter();
                ParUBEobra.ParameterName = "@sUBEobra";
                ParUBEobra.SqlDbType = SqlDbType.Char;
                ParUBEobra.Value = acfUBEt_UbicacionElectrica.UBEobra;
                SqlCmd.Parameters.Add(ParUBEobra);
                //
                SqlParameter ParKOSTL = new SqlParameter();
                ParKOSTL.ParameterName = "@sKOSTL";
                ParKOSTL.SqlDbType = SqlDbType.Char;
                ParKOSTL.Value = acfUBEt_UbicacionElectrica.KOSTL;
                SqlCmd.Parameters.Add(ParKOSTL);
                //
                SqlParameter ParVNRid = new SqlParameter();
                ParVNRid.ParameterName = "@sVNRid";
                ParVNRid.SqlDbType = SqlDbType.Char;
                ParVNRid.Value = acfUBEt_UbicacionElectrica.VNRid;
                SqlCmd.Parameters.Add(ParVNRid);
                //
                SqlParameter ParSELid = new SqlParameter();
                ParSELid.ParameterName = "@sSELid";
                ParSELid.SqlDbType = SqlDbType.Char;
                ParSELid.Value = acfUBEt_UbicacionElectrica.SELid;
                SqlCmd.Parameters.Add(ParSELid);
                //
                SqlParameter ParUBEset = new SqlParameter();
                ParUBEset.ParameterName = "@iUBEset";
                ParUBEset.SqlDbType = SqlDbType.BigInt;
                ParUBEset.Value = acfUBEt_UbicacionElectrica.UBEset;
                SqlCmd.Parameters.Add(ParUBEset);
                //
                SqlParameter UBEsetetq = new SqlParameter();
                UBEsetetq.ParameterName = "@desUBEsetetq";
                UBEsetetq.SqlDbType = SqlDbType.VarChar;
                UBEsetetq.Value = acfUBEt_UbicacionElectrica.UBEsetetq;
                SqlCmd.Parameters.Add(UBEsetetq);
                //
                SqlParameter ParUBEalimentador = new SqlParameter();
                ParUBEalimentador.ParameterName = "@iUBEalimentador";
                ParUBEalimentador.SqlDbType = SqlDbType.BigInt;
                ParUBEalimentador.Value = acfUBEt_UbicacionElectrica.UBEalimentador;
                SqlCmd.Parameters.Add(ParUBEalimentador);
                //
                SqlParameter ParUBEalimentadoretq = new SqlParameter();
                ParUBEalimentadoretq.ParameterName = "@sUBEalimentadoretq";
                ParUBEalimentadoretq.SqlDbType = SqlDbType.VarChar;
                ParUBEalimentadoretq.Value = acfUBEt_UbicacionElectrica.UBEalimentadoretq;
                SqlCmd.Parameters.Add(ParUBEalimentadoretq);
                //
                SqlParameter ParUBEsed = new SqlParameter();
                ParUBEsed.ParameterName = "@iUBEsed";
                ParUBEsed.SqlDbType = SqlDbType.BigInt;
                ParUBEsed.Value = acfUBEt_UbicacionElectrica.UBEsed;
                SqlCmd.Parameters.Add(ParUBEsed);
                //
                SqlParameter ParUBEsedetq = new SqlParameter();
                ParUBEsedetq.ParameterName = "@sUBEsedetq";
                ParUBEsedetq.SqlDbType = SqlDbType.VarChar;
                ParUBEsedetq.Value = acfUBEt_UbicacionElectrica.UBEsedetq;
                SqlCmd.Parameters.Add(ParUBEsedetq);
                //
                SqlParameter ParUBEcircuito = new SqlParameter();
                ParUBEcircuito.ParameterName = "@iUBEcircuito";
                ParUBEcircuito.SqlDbType = SqlDbType.BigInt;
                ParUBEcircuito.Value = acfUBEt_UbicacionElectrica.UBEcircuito;
                SqlCmd.Parameters.Add(ParUBEcircuito);
                //
                SqlParameter ParUBEcircuitoetq = new SqlParameter();
                ParUBEcircuitoetq.ParameterName = "@sUBEcircuitoetq";
                ParUBEcircuitoetq.SqlDbType = SqlDbType.VarChar;
                ParUBEcircuitoetq.Value = acfUBEt_UbicacionElectrica.UBEcircuitoetq;
                SqlCmd.Parameters.Add(ParUBEcircuitoetq);
                //
                SqlParameter ParUBEpuntoi = new SqlParameter();
                ParUBEpuntoi.ParameterName = "@iUBEpuntoi";
                ParUBEpuntoi.SqlDbType = SqlDbType.BigInt;
                ParUBEpuntoi.Value = acfUBEt_UbicacionElectrica.UBEpuntoi;
                SqlCmd.Parameters.Add(ParUBEpuntoi);
                //
                SqlParameter ParUBEpuntoietq = new SqlParameter();
                ParUBEpuntoietq.ParameterName = "@sUBEpuntoietq";
                ParUBEpuntoietq.SqlDbType = SqlDbType.VarChar;
                ParUBEpuntoietq.Value = acfUBEt_UbicacionElectrica.UBEpuntoietq;
                SqlCmd.Parameters.Add(ParUBEpuntoietq);
                //
                SqlParameter ParUBEpuntof = new SqlParameter();
                ParUBEpuntof.ParameterName = "@iUBEpuntof";
                ParUBEpuntof.SqlDbType = SqlDbType.BigInt;
                ParUBEpuntof.Value = acfUBEt_UbicacionElectrica.UBEpuntof;
                SqlCmd.Parameters.Add(ParUBEpuntof);
                //
                SqlParameter ParUBEpuntofetq = new SqlParameter();
                ParUBEpuntofetq.ParameterName = "@sUBEpuntofetq";
                ParUBEpuntofetq.SqlDbType = SqlDbType.VarChar;
                ParUBEpuntofetq.Value = acfUBEt_UbicacionElectrica.UBEpuntofetq;
                SqlCmd.Parameters.Add(ParUBEpuntofetq);
                //
                SqlParameter ParUBEid = new SqlParameter();
                ParUBEid.ParameterName = "@iUBEid";
                ParUBEid.SqlDbType = SqlDbType.Int;
                ParUBEid.Value = acfUBEt_UbicacionElectrica.UBEid;
                SqlCmd.Parameters.Add(ParUBEid);
                //
                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@iACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Value = acfUBEt_UbicacionElectrica.ACFid;
                SqlCmd.Parameters.Add(ParACFid);
                //

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Elimino el Registro";

			
			
		}
	catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
	}

        //Metodo importar Excel a DB Ubicacion Electrica
    public string SAPIMPORT(DacfUBEt_UbicacionElectrica acfUBEt_UbicacionElectrica)
    {
        string rpta = "";
        SqlConnection SqlCon = new SqlConnection();
        try
        {
            //Código
            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCon.Open();
            //Establecer el Comando
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_I_SAPIMPORT_UBICELEC";
            SqlCmd.CommandType = CommandType.StoredProcedure;
            //
            SqlParameter ParUBEcodigogis = new SqlParameter();
            ParUBEcodigogis.ParameterName = "@iUBEcodigogis";
            ParUBEcodigogis.SqlDbType = SqlDbType.BigInt;
            ParUBEcodigogis.Value = Convert.ToInt64(acfUBEt_UbicacionElectrica.UBEcodigogis);
            SqlCmd.Parameters.Add(ParUBEcodigogis);
            //
            SqlParameter ParUBEobra = new SqlParameter();
            ParUBEobra.ParameterName = "@sUBEobra";
            ParUBEobra.SqlDbType = SqlDbType.Char;
            ParUBEobra.Value = acfUBEt_UbicacionElectrica.UBEobra;
            SqlCmd.Parameters.Add(ParUBEobra);
            //
            SqlParameter ParKOSTL = new SqlParameter();
            ParKOSTL.ParameterName = "@sKOSTL";
            ParKOSTL.SqlDbType = SqlDbType.Char;
            ParKOSTL.Value = acfUBEt_UbicacionElectrica.KOSTL;
            SqlCmd.Parameters.Add(ParKOSTL);
            //
            SqlParameter ParVNRid = new SqlParameter();
            ParVNRid.ParameterName = "@sVNRid";
            ParVNRid.SqlDbType = SqlDbType.Char;
            ParVNRid.Value = acfUBEt_UbicacionElectrica.VNRid;
            SqlCmd.Parameters.Add(ParVNRid);
            //
            SqlParameter ParSELid = new SqlParameter();
            ParSELid.ParameterName = "@sSELid";
            ParSELid.SqlDbType = SqlDbType.Char;
            ParSELid.Value = acfUBEt_UbicacionElectrica.SELid;
            SqlCmd.Parameters.Add(ParSELid);
            //
            SqlParameter ParUBEset = new SqlParameter();
            ParUBEset.ParameterName = "@iUBEset";
            ParUBEset.SqlDbType = SqlDbType.BigInt;
            ParUBEset.Value = acfUBEt_UbicacionElectrica.UBEset;
            SqlCmd.Parameters.Add(ParUBEset);
            //
            SqlParameter UBEsetetq = new SqlParameter();
            UBEsetetq.ParameterName = "@sUBEsetetq";
            UBEsetetq.SqlDbType = SqlDbType.VarChar;
            UBEsetetq.Value = acfUBEt_UbicacionElectrica.UBEsetetq;
            SqlCmd.Parameters.Add(UBEsetetq);
            //
            SqlParameter ParUBEalimentador = new SqlParameter();
            ParUBEalimentador.ParameterName = "@iUBEalimentador";
            ParUBEalimentador.SqlDbType = SqlDbType.BigInt;
            ParUBEalimentador.Value = acfUBEt_UbicacionElectrica.UBEalimentador;
            SqlCmd.Parameters.Add(ParUBEalimentador);
            //
            SqlParameter ParUBEalimentadoretq = new SqlParameter();
            ParUBEalimentadoretq.ParameterName = "@sUBEalimentadoretq";
            ParUBEalimentadoretq.SqlDbType = SqlDbType.VarChar;
            ParUBEalimentadoretq.Value = acfUBEt_UbicacionElectrica.UBEalimentadoretq;
            SqlCmd.Parameters.Add(ParUBEalimentadoretq);
            //
            SqlParameter ParUBEsed = new SqlParameter();
            ParUBEsed.ParameterName = "@iUBEsed";
            ParUBEsed.SqlDbType = SqlDbType.BigInt;
            ParUBEsed.Value = acfUBEt_UbicacionElectrica.UBEsed;
            SqlCmd.Parameters.Add(ParUBEsed);
            //
            SqlParameter ParUBEsedetq = new SqlParameter();
            ParUBEsedetq.ParameterName = "@sUBEsedetq";
            ParUBEsedetq.SqlDbType = SqlDbType.VarChar;
            ParUBEsedetq.Value = acfUBEt_UbicacionElectrica.UBEsedetq;
            SqlCmd.Parameters.Add(ParUBEsedetq);
            //
            SqlParameter ParUBEcircuito = new SqlParameter();
            ParUBEcircuito.ParameterName = "@iUBEcircuito";
            ParUBEcircuito.SqlDbType = SqlDbType.BigInt;
            ParUBEcircuito.Value = acfUBEt_UbicacionElectrica.UBEcircuito;
            SqlCmd.Parameters.Add(ParUBEcircuito);
            //
            SqlParameter ParUBEcircuitoetq = new SqlParameter();
            ParUBEcircuitoetq.ParameterName = "@sUBEcircuitoetq";
            ParUBEcircuitoetq.SqlDbType = SqlDbType.VarChar;
            ParUBEcircuitoetq.Value = acfUBEt_UbicacionElectrica.UBEcircuitoetq;
            SqlCmd.Parameters.Add(ParUBEcircuitoetq);
            //
            SqlParameter ParUBEpuntoi = new SqlParameter();
            ParUBEpuntoi.ParameterName = "@iUBEpuntoi";
            ParUBEpuntoi.SqlDbType = SqlDbType.BigInt;
            ParUBEpuntoi.Value = acfUBEt_UbicacionElectrica.UBEpuntoi;
            SqlCmd.Parameters.Add(ParUBEpuntoi);
            //
            SqlParameter ParUBEpuntoietq = new SqlParameter();
            ParUBEpuntoietq.ParameterName = "@sUBEpuntoietq";
            ParUBEpuntoietq.SqlDbType = SqlDbType.VarChar;
            ParUBEpuntoietq.Value = acfUBEt_UbicacionElectrica.UBEpuntoietq;
            SqlCmd.Parameters.Add(ParUBEpuntoietq);
            //
            SqlParameter ParUBEpuntof = new SqlParameter();
            ParUBEpuntof.ParameterName = "@iUBEpuntof";
            ParUBEpuntof.SqlDbType = SqlDbType.BigInt;
            ParUBEpuntof.Value = acfUBEt_UbicacionElectrica.UBEpuntof;
            SqlCmd.Parameters.Add(ParUBEpuntof);
            //
            SqlParameter ParUBEpuntofetq = new SqlParameter();
            ParUBEpuntofetq.ParameterName = "@sUBEpuntofetq";
            ParUBEpuntofetq.SqlDbType = SqlDbType.VarChar;
            ParUBEpuntofetq.Value = acfUBEt_UbicacionElectrica.UBEpuntofetq;
            SqlCmd.Parameters.Add(ParUBEpuntofetq);
            //
            // SqlParameter ParUBEid = new SqlParameter();
            // ParUBEid.ParameterName = "@iUBEid";
            // ParUBEid.SqlDbType = SqlDbType.Int;
            // ParUBEid.Value = acfUBEt_UbicacionElectrica.UBEid;
            // SqlCmd.Parameters.Add(ParUBEid);
            //
            SqlParameter ParACFid = new SqlParameter();
            ParACFid.ParameterName = "@iACFid";
            ParACFid.SqlDbType = SqlDbType.Int;
            //ParACFid.Value = acfUBEt_UbicacionElectrica.ACFid;
                if (string.IsNullOrWhiteSpace(acfUBEt_UbicacionElectrica.ACFid))
                {
                    ParACFid.Value = 0;
                }
                else
                {
                    ParACFid.Value = Convert.ToInt32(acfUBEt_UbicacionElectrica.ACFid);
                }
                SqlCmd.Parameters.Add(ParACFid);
            //
            SqlParameter ParUBIGEO = new SqlParameter();
            ParUBIGEO.ParameterName = "@cUBIGEO";
            ParUBIGEO.SqlDbType = SqlDbType.VarChar;
            ParUBIGEO.Value = acfUBEt_UbicacionElectrica.UBIGEO;
            SqlCmd.Parameters.Add(ParUBIGEO);
            //
            SqlParameter ParUBEpostei = new SqlParameter();
            ParUBEpostei.ParameterName = "@cUBEpostei";
            ParUBEpostei.SqlDbType = SqlDbType.VarChar;
            ParUBEpostei.Value = acfUBEt_UbicacionElectrica.UBEpostei;
            SqlCmd.Parameters.Add(ParUBEpostei);
            //
            SqlParameter ParUBEpostef = new SqlParameter();
            ParUBEpostef.ParameterName = "@cUBEpostef";
            ParUBEpostef.SqlDbType = SqlDbType.VarChar;
            ParUBEpostef.Value = acfUBEt_UbicacionElectrica.UBEpostef;
            SqlCmd.Parameters.Add(ParUBEpostef);
            //

            //Ejecutamos nuestro comando

            rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Elimino el Registro";



        }
        catch (Exception ex)
        {
            rpta = ex.Message;
        }
        finally
        {
            if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
        }
        return rpta;
    }


        //METODO EDITAR
	public string Editar(DacfUBEt_UbicacionElectrica acfUBEt_UbicacionElectrica) {
		string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_U_acfUBEt_UbicacionElectrica";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter ParUBEcodigogis = new SqlParameter();
                ParUBEcodigogis.ParameterName = "@iUBEcodigogis";
                ParUBEcodigogis.SqlDbType = SqlDbType.BigInt;
                ParUBEcodigogis.Value = Convert.ToInt64(acfUBEt_UbicacionElectrica.UBEcodigogis);
                SqlCmd.Parameters.Add(ParUBEcodigogis);
                //
                SqlParameter ParUBEobra = new SqlParameter();
                ParUBEobra.ParameterName = "@sUBEobra";
                ParUBEobra.SqlDbType = SqlDbType.Char;
                ParUBEobra.Value = acfUBEt_UbicacionElectrica.UBEobra;
                SqlCmd.Parameters.Add(ParUBEobra);
                //
                SqlParameter ParKOSTL = new SqlParameter();
                ParKOSTL.ParameterName = "@sKOSTL";
                ParKOSTL.SqlDbType = SqlDbType.Char;
                ParKOSTL.Value = acfUBEt_UbicacionElectrica.KOSTL;
                SqlCmd.Parameters.Add(ParKOSTL);
                //
                SqlParameter ParVNRid = new SqlParameter();
                ParVNRid.ParameterName = "@sVNRid";
                ParVNRid.SqlDbType = SqlDbType.Char;
                ParVNRid.Value = acfUBEt_UbicacionElectrica.VNRid;
                SqlCmd.Parameters.Add(ParVNRid);
                //
                SqlParameter ParSELid = new SqlParameter();
                ParSELid.ParameterName = "@sSELid";
                ParSELid.SqlDbType = SqlDbType.Char;
                ParSELid.Value = acfUBEt_UbicacionElectrica.SELid;
                SqlCmd.Parameters.Add(ParSELid);
                //
                SqlParameter ParUBEset = new SqlParameter();
                ParUBEset.ParameterName = "@iUBEset";
                ParUBEset.SqlDbType = SqlDbType.BigInt;
                ParUBEset.Value = acfUBEt_UbicacionElectrica.UBEset;
                SqlCmd.Parameters.Add(ParUBEset);
                //
                SqlParameter UBEsetetq = new SqlParameter();
                UBEsetetq.ParameterName = "@desUBEsetetq";
                UBEsetetq.SqlDbType = SqlDbType.VarChar;
                UBEsetetq.Value = acfUBEt_UbicacionElectrica.UBEsetetq;
                SqlCmd.Parameters.Add(UBEsetetq);
                //
                SqlParameter ParUBEalimentador = new SqlParameter();
                ParUBEalimentador.ParameterName = "@iUBEalimentador";
                ParUBEalimentador.SqlDbType = SqlDbType.BigInt;
                ParUBEalimentador.Value = acfUBEt_UbicacionElectrica.UBEalimentador;
                SqlCmd.Parameters.Add(ParUBEalimentador);
                //
                SqlParameter ParUBEalimentadoretq = new SqlParameter();
                ParUBEalimentadoretq.ParameterName = "@sUBEalimentadoretq";
                ParUBEalimentadoretq.SqlDbType = SqlDbType.VarChar;
                ParUBEalimentadoretq.Value = acfUBEt_UbicacionElectrica.UBEalimentadoretq;
                SqlCmd.Parameters.Add(ParUBEalimentadoretq);
                //
                SqlParameter ParUBEsed = new SqlParameter();
                ParUBEsed.ParameterName = "@iUBEsed";
                ParUBEsed.SqlDbType = SqlDbType.BigInt;
                ParUBEsed.Value = acfUBEt_UbicacionElectrica.UBEsed;
                SqlCmd.Parameters.Add(ParUBEsed);
                //
                SqlParameter ParUBEsedetq = new SqlParameter();
                ParUBEsedetq.ParameterName = "@sUBEsedetq";
                ParUBEsedetq.SqlDbType = SqlDbType.VarChar;
                ParUBEsedetq.Value = acfUBEt_UbicacionElectrica.UBEsedetq;
                SqlCmd.Parameters.Add(ParUBEsedetq);
                //
                SqlParameter ParUBEcircuito = new SqlParameter();
                ParUBEcircuito.ParameterName = "@iUBEcircuito";
                ParUBEcircuito.SqlDbType = SqlDbType.BigInt;
                ParUBEcircuito.Value = acfUBEt_UbicacionElectrica.UBEcircuito;
                SqlCmd.Parameters.Add(ParUBEcircuito);
                //
                SqlParameter ParUBEcircuitoetq = new SqlParameter();
                ParUBEcircuitoetq.ParameterName = "@sUBEcircuitoetq";
                ParUBEcircuitoetq.SqlDbType = SqlDbType.VarChar;
                ParUBEcircuitoetq.Value = acfUBEt_UbicacionElectrica.UBEcircuitoetq;
                SqlCmd.Parameters.Add(ParUBEcircuitoetq);
                //
                SqlParameter ParUBEpuntoi = new SqlParameter();
                ParUBEpuntoi.ParameterName = "@iUBEpuntoi";
                ParUBEpuntoi.SqlDbType = SqlDbType.BigInt;
                ParUBEpuntoi.Value = acfUBEt_UbicacionElectrica.UBEpuntoi;
                SqlCmd.Parameters.Add(ParUBEpuntoi);
                //
                SqlParameter ParUBEpuntoietq = new SqlParameter();
                ParUBEpuntoietq.ParameterName = "@sUBEpuntoietq";
                ParUBEpuntoietq.SqlDbType = SqlDbType.VarChar;
                ParUBEpuntoietq.Value = acfUBEt_UbicacionElectrica.UBEpuntoietq;
                SqlCmd.Parameters.Add(ParUBEpuntoietq);
                //
                SqlParameter ParUBEpuntof = new SqlParameter();
                ParUBEpuntof.ParameterName = "@iUBEpuntof";
                ParUBEpuntof.SqlDbType = SqlDbType.BigInt;
                ParUBEpuntof.Value = acfUBEt_UbicacionElectrica.UBEpuntof;
                SqlCmd.Parameters.Add(ParUBEpuntof);
                //
                SqlParameter ParUBEpuntofetq = new SqlParameter();
                ParUBEpuntofetq.ParameterName = "@sUBEpuntofetq";
                ParUBEpuntofetq.SqlDbType = SqlDbType.VarChar;
                ParUBEpuntofetq.Value = acfUBEt_UbicacionElectrica.UBEpuntofetq;
                SqlCmd.Parameters.Add(ParUBEpuntofetq);
                //
                SqlParameter ParUBEid = new SqlParameter();
                ParUBEid.ParameterName = "@iUBEid";
                ParUBEid.SqlDbType = SqlDbType.Int;
                ParUBEid.Value = acfUBEt_UbicacionElectrica.UBEid;
                SqlCmd.Parameters.Add(ParUBEid);
                //
                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@iACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Value = acfUBEt_UbicacionElectrica.ACFid;
                SqlCmd.Parameters.Add(ParACFid);
                //
                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Actualizo el Registro";


                }
		catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta; 
	}


        //METODO ELIMINAR
	public string Eliminar(DacfUBEt_UbicacionElectrica acfUBEt_UbicacionElectrica) {
		
			string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_D_acfUBEt_UbicacionElectrica";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter ParUBEcodigogis = new SqlParameter();
                ParUBEcodigogis.ParameterName = "@iUBEcodigogis";
                ParUBEcodigogis.SqlDbType = SqlDbType.BigInt;
                ParUBEcodigogis.Value = Convert.ToInt64(acfUBEt_UbicacionElectrica.UBEcodigogis);
                SqlCmd.Parameters.Add(ParUBEcodigogis);
                //

                 //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Elimino el Registro";


		}
		catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
	}


    //METODO BUSCAR

	public DataTable Buscar(string iACFid) {

        DataTable DtResultado = new DataTable("acfUBEt_UbicacionElectrica");
            SqlConnection SqlCon = new SqlConnection();


		try {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_acfUBEt_UbicacionElectrica";
            SqlCmd.CommandType = CommandType.StoredProcedure;



            SqlParameter ParUBEobra = new SqlParameter();
            ParUBEobra.ParameterName = "@iACFid";
            ParUBEobra.SqlDbType = SqlDbType.Int;
            ParUBEobra.Size = 50;
            ParUBEobra.Value = Convert.ToInt32(iACFid);
            SqlCmd.Parameters.Add(ParUBEobra);

            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

		}
        catch (Exception ex)
        {
            DtResultado = null;
        }
        return DtResultado;

	}

}
}