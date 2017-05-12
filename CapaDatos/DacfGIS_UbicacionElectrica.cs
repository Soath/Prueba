using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DacfGIS_UbicacionElectrica
    {
        private string iUBEid;
        private string mUBEcodigogis;
        private string mACFid;
        private string mSELid;
        private string mUBEset;
        private string mUBEsetetq;
        private string mUBEalimentador;
        private string mUBEalimetiquetadoretq;
        private string mUBEsed;
        private string mUBEsedetq;
        private string mUBcircuito;
        private string mUBEcircuitoetq;
        private string mUBEtipoPuntoi;
        private string mUBEpuntoi;
        private string mUBEpuntoietq;
        private string mUBEtipoPuntof;
        private string mUBEpuntof;
        private string mUBEpuntofetq;
        private string mUBEobra;
        private string mKOSTL;
        private string mZona;
        private string mVNRid;
        private string mCodNiff;
        private string mValAct;
        private string mFactor;
        private string mVidUtilTrib;
        private string mVidUtilFinan;
        private string mUBEestado;

        public string UBEid
        {
            get { return iUBEid; }
            set { iUBEid = value; }
        }
        public string UBEcodigogis
        {
            get { return mUBEcodigogis; }
            set { mUBEcodigogis = value; }
        }
        public string ACFid
        {
            get { return mACFid; }
            set { mACFid = value; }
        }
        public string SELid
        {
            get { return mSELid; }
            set { mSELid = value; }
        }
        public string UBEset
        {
            get { return mUBEset; }
            set { mUBEset = value; }
        }
        public string UBEsetetq
        {
            get { return mUBEsetetq; }
            set { mUBEsetetq = value; }
        }
        public string UBEalimentador
        {
            get { return mUBEalimentador; }
            set { mUBEalimentador = value; }
        }
        public string UBEalimetiquetadoretq
        {
            get { return mUBEalimetiquetadoretq; }
            set { mUBEalimetiquetadoretq = value; }
        }
        public string UBEsed
        {
            get { return mUBEsed; }
            set { mUBEsed = value; }
        }
        public string UBEsedetq
        {
            get { return mUBEsedetq; }
            set { mUBEsedetq = value; }
        }
        public string UBcircuito
        {
            get { return mUBcircuito; }
            set { mUBcircuito = value; }
        }
        public string UBEcircuitoetq
        {
            get { return mUBEcircuitoetq; }
            set { mUBEcircuitoetq = value; }
        }
        public string UBEtipoPuntoi
        {
            get { return mUBEtipoPuntoi; }
            set { mUBEtipoPuntoi = value; }
        }
        public string UBEpuntoi
        {
            get { return mUBEpuntoi; }
            set { mUBEpuntoi = value; }
        }
        public string UBEpuntoietq
        {
            get { return mUBEpuntoietq; }
            set { mUBEpuntoietq = value; }
        }
        public string UBEtipoPuntof
        {
            get { return mUBEtipoPuntof; }
            set { mUBEtipoPuntof = value; }
        }
        public string UBEpuntof
        {
            get { return mUBEpuntof; }
            set { mUBEpuntof = value; }
        }
        public string UBEpuntofetq
        {
            get { return mUBEpuntofetq; }
            set { mUBEpuntofetq = value; }
        }
        public string UBEobra
        {
            get { return mUBEobra; }
            set { mUBEobra = value; }
        }
        public string KOSTL
        {
            get { return mKOSTL; }
            set { mKOSTL = value; }
        }
        public string Zona
        {
            get { return mZona; }
            set { mZona = value; }
        }
        public string VNRid
        {
            get { return mVNRid; }
            set { mVNRid = value; }
        }
        public string CodNiff
        {
            get { return mCodNiff; }
            set { mCodNiff = value; }
        }
        public string ValAct
        {
            get { return mValAct; }
            set { mValAct = value; }
        }
        public string Factor
        {
            get { return mFactor; }
            set { mFactor = value; }
        }
        public string VidUtilTrib
        {
            get { return mVidUtilTrib; }
            set { mVidUtilTrib = value; }
        }
        public string VidUtilFinan
        {
            get { return mVidUtilFinan; }
            set { mVidUtilFinan = value; }
        }
        public string UBEestado
        {
            get { return mUBEestado; }
            set { mUBEestado = value; }
        }

        //Constructor con parámetros
        public DacfGIS_UbicacionElectrica(
            string UBEid,
            string UBEcodigogis,
            string ACFid,
            string SELid,
            string UBEset,
            string UBEsetetq,
            string UBEalimentador,
            string UBEalimetiquetadoretq,
            string UBEsed,
            string UBEsedetq,
            string UBcircuito,
            string UBEcircuitoetq,
            string UBEtipoPuntoi,
            string UBEpuntoi,
            string UBEpuntoietq,
            string UBEtipoPuntof,
            string UBEpuntof,
            string UBEpuntofetq,
            string UBEobra,
            string KOSTL,
            string Zona,
            string VNRid,
            string CodNiff,
            string ValAct,
            string Factor,
            string VidUtilTrib,
            string VidUtilFinan,
            string UBEestado
            )
        {

            this.UBEid = iUBEid;
            this.UBEcodigogis = mUBEcodigogis;
            this.ACFid = mACFid;
            this.SELid = mSELid;
            this.UBEset = mUBEset;
            this.UBEsetetq = mUBEsetetq;
            this.UBEalimentador = mUBEalimentador;
            this.UBEalimetiquetadoretq = mUBEalimetiquetadoretq;
            this.UBEsed = mUBEsed;
            this.UBEsedetq = mUBEsedetq;
            this.UBcircuito = mUBcircuito;
            this.UBEcircuitoetq = mUBEcircuitoetq;
            this.UBEtipoPuntoi = mUBEtipoPuntoi;
            this.UBEpuntoi = mUBEpuntoi;
            this.UBEpuntoietq = mUBEpuntoietq;
            this.UBEtipoPuntof = mUBEtipoPuntof;
            this.UBEpuntof = mUBEpuntof;
            this.UBEpuntofetq = mUBEpuntofetq;
            this.UBEobra = mUBEobra;
            this.KOSTL = mKOSTL;
            this.Zona = mZona;
            this.VNRid = mVNRid;
            this.CodNiff = mCodNiff;
            this.ValAct = mValAct;
            this.Factor = mFactor;
            this.VidUtilTrib = mVidUtilTrib;
            this.VidUtilFinan = mVidUtilFinan;
            this.UBEestado = mUBEestado;
        }

        /*	public object Clone() {
        //		return base.MemberwiseClone();
        //	}
        */
        //Constructor vacío
        public DacfGIS_UbicacionElectrica()
        {
        }
        //METODO MOSTRAR
        public DataTable Mostrar(string UBEestado)
        {
            DataTable DtResultado = new DataTable("acfGIS_UbicacionElectrica");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfGIS_UbicacionElectrica";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUBEestado = new SqlParameter();
                ParUBEestado.ParameterName = "@mUBEestado";
                ParUBEestado.SqlDbType = SqlDbType.Char;
                ParUBEestado.Value = UBEestado;
                SqlCmd.Parameters.Add(ParUBEestado);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //METODO LAST
        public DataTable Last()
        {
            DataTable DtResultado = new DataTable("acfGIS_UbicacionElectrica");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_L_acfGIS_UbicacionElectrica";
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
        public string Insertar(DacfGIS_UbicacionElectrica acfGIS_UbicacionElectrica)
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
                SqlCmd.CommandText = "usp_I_acfGIS_UbicacionElectrica";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUBEid = new SqlParameter();
                ParUBEid.ParameterName = "@iUBEid";
                ParUBEid.SqlDbType = SqlDbType.Int;
                ParUBEid.Value = acfGIS_UbicacionElectrica.UBEid;
                SqlCmd.Parameters.Add(ParUBEid);
                //   
                SqlParameter ParUBEcodigogis = new SqlParameter();
                ParUBEcodigogis.ParameterName = "@mUBEcodigogis";
                ParUBEcodigogis.SqlDbType = SqlDbType.BigInt;
                ParUBEcodigogis.Value = acfGIS_UbicacionElectrica.UBEcodigogis;
                SqlCmd.Parameters.Add(ParUBEcodigogis);
                //     
                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@mACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Value = acfGIS_UbicacionElectrica.ACFid;
                SqlCmd.Parameters.Add(ParACFid);
                //
                SqlParameter ParSELid = new SqlParameter();
                ParSELid.ParameterName = "@mSELid";
                ParSELid.SqlDbType = SqlDbType.BigInt;
                ParSELid.Value = acfGIS_UbicacionElectrica.SELid;
                SqlCmd.Parameters.Add(ParSELid);
                //     
                SqlParameter ParUBEset = new SqlParameter();
                ParUBEset.ParameterName = "@mUBEset";
                ParUBEset.SqlDbType = SqlDbType.BigInt;
                ParUBEset.Value = acfGIS_UbicacionElectrica.UBEset;
                SqlCmd.Parameters.Add(ParUBEset);
                //   
                SqlParameter ParUBEsetetq = new SqlParameter();
                ParUBEsetetq.ParameterName = "@mUBEsetetq";
                ParUBEsetetq.SqlDbType = SqlDbType.VarChar;
                ParUBEsetetq.Value = acfGIS_UbicacionElectrica.UBEsetetq;
                SqlCmd.Parameters.Add(ParUBEsetetq);
                //    
                SqlParameter ParUBEalimentador = new SqlParameter();
                ParUBEalimentador.ParameterName = "@mUBEalimentador";
                ParUBEalimentador.SqlDbType = SqlDbType.BigInt;
                ParUBEalimentador.Value = acfGIS_UbicacionElectrica.UBEalimentador;
                SqlCmd.Parameters.Add(ParUBEalimentador);
                //    
                SqlParameter ParUBEalimetiquetadoretq = new SqlParameter();
                ParUBEalimetiquetadoretq.ParameterName = "@mUBEalimetiquetadoretq";
                ParUBEalimetiquetadoretq.SqlDbType = SqlDbType.VarChar;
                ParUBEalimetiquetadoretq.Value = acfGIS_UbicacionElectrica.UBEalimetiquetadoretq;
                SqlCmd.Parameters.Add(ParUBEalimetiquetadoretq);
                //     
                SqlParameter ParUBEsed = new SqlParameter();
                ParUBEsed.ParameterName = "@mUBEsed";
                ParUBEsed.SqlDbType = SqlDbType.BigInt;
                ParUBEsed.Value = acfGIS_UbicacionElectrica.UBEsed;
                SqlCmd.Parameters.Add(ParUBEsed);
                //     
                SqlParameter ParUBEsedetq = new SqlParameter();
                ParUBEsedetq.ParameterName = "@mUBEsedetq";
                ParUBEsedetq.SqlDbType = SqlDbType.VarChar;
                ParUBEsedetq.Value = acfGIS_UbicacionElectrica.UBEsedetq;
                SqlCmd.Parameters.Add(ParUBEsedetq);
                //     
                SqlParameter ParUBcircuito = new SqlParameter();
                ParUBcircuito.ParameterName = "@mUBcircuito";
                ParUBcircuito.SqlDbType = SqlDbType.BigInt;
                ParUBcircuito.Value = acfGIS_UbicacionElectrica.UBcircuito;
                SqlCmd.Parameters.Add(ParUBcircuito);
                //  
                SqlParameter ParUBEcircuitoetq = new SqlParameter();
                ParUBEcircuitoetq.ParameterName = "@mUBEcircuitoetq";
                ParUBEcircuitoetq.SqlDbType = SqlDbType.VarChar;
                ParUBEcircuitoetq.Value = acfGIS_UbicacionElectrica.UBEcircuitoetq;
                SqlCmd.Parameters.Add(ParUBEcircuitoetq);
                //   
                SqlParameter ParUBEtipoPuntoi = new SqlParameter();
                ParUBEtipoPuntoi.ParameterName = "@mUBEtipoPuntoi";
                ParUBEtipoPuntoi.SqlDbType = SqlDbType.BigInt;
                ParUBEtipoPuntoi.Value = acfGIS_UbicacionElectrica.UBEtipoPuntoi;
                SqlCmd.Parameters.Add(ParUBEtipoPuntoi);
                //     
                SqlParameter ParUBEpuntoi = new SqlParameter();
                ParUBEpuntoi.ParameterName = "@mUBEpuntoi";
                ParUBEpuntoi.SqlDbType = SqlDbType.BigInt;
                ParUBEpuntoi.Value = acfGIS_UbicacionElectrica.UBEpuntoi;
                SqlCmd.Parameters.Add(ParUBEpuntoi);
                //     
                SqlParameter ParUBEpuntoietq = new SqlParameter();
                ParUBEpuntoietq.ParameterName = "@mUBEpuntoietq";
                ParUBEpuntoietq.SqlDbType = SqlDbType.VarChar;
                ParUBEpuntoietq.Value = acfGIS_UbicacionElectrica.UBEpuntoietq;
                SqlCmd.Parameters.Add(ParUBEpuntoietq);
                // 
                SqlParameter ParUBEtipoPuntof = new SqlParameter();
                ParUBEtipoPuntof.ParameterName = "@mUBEtipoPuntof";
                ParUBEtipoPuntof.SqlDbType = SqlDbType.BigInt;
                ParUBEtipoPuntof.Value = acfGIS_UbicacionElectrica.UBEtipoPuntof;
                SqlCmd.Parameters.Add(ParUBEtipoPuntof);
                //  
                SqlParameter ParUBEpuntof = new SqlParameter();
                ParUBEpuntof.ParameterName = "@BigInt";
                ParUBEpuntof.SqlDbType = SqlDbType.VarChar;
                ParUBEpuntof.Value = acfGIS_UbicacionElectrica.UBEpuntof;
                SqlCmd.Parameters.Add(ParUBEpuntof);
                //     
                SqlParameter ParUBEpuntofetq = new SqlParameter();
                ParUBEpuntofetq.ParameterName = "@mUBEpuntofetq";
                ParUBEpuntofetq.SqlDbType = SqlDbType.VarChar;
                ParUBEpuntofetq.Value = acfGIS_UbicacionElectrica.UBEpuntofetq;
                SqlCmd.Parameters.Add(ParUBEpuntofetq);
                //   
                SqlParameter ParUBEobra = new SqlParameter();
                ParUBEobra.ParameterName = "@mUBEobra";
                ParUBEobra.SqlDbType = SqlDbType.Char;
                ParUBEobra.Value = acfGIS_UbicacionElectrica.UBEobra;
                SqlCmd.Parameters.Add(ParUBEobra);
                //     
                SqlParameter ParKOSTL = new SqlParameter();
                ParKOSTL.ParameterName = "@mKOSTL";
                ParKOSTL.SqlDbType = SqlDbType.Char;
                ParKOSTL.Value = acfGIS_UbicacionElectrica.KOSTL;
                SqlCmd.Parameters.Add(ParKOSTL);
                //     
                SqlParameter ParZona = new SqlParameter();
                ParZona.ParameterName = "@mZona";
                ParZona.SqlDbType = SqlDbType.Char;
                ParZona.Value = acfGIS_UbicacionElectrica.Zona;
                SqlCmd.Parameters.Add(ParZona);
                //     
                SqlParameter ParVNRid = new SqlParameter();
                ParVNRid.ParameterName = "@mVNRid";
                ParVNRid.SqlDbType = SqlDbType.Char;
                ParVNRid.Value = acfGIS_UbicacionElectrica.VNRid;
                SqlCmd.Parameters.Add(ParVNRid);
                //     
                SqlParameter ParCodNiff = new SqlParameter();
                ParCodNiff.ParameterName = "@mCodNiff";
                ParCodNiff.SqlDbType = SqlDbType.Char;
                ParCodNiff.Value = acfGIS_UbicacionElectrica.CodNiff;
                SqlCmd.Parameters.Add(ParCodNiff);
                //     
                SqlParameter ParValAct = new SqlParameter();
                ParValAct.ParameterName = "@mValAct";
                ParValAct.SqlDbType = SqlDbType.Int;
                ParValAct.Value = acfGIS_UbicacionElectrica.ValAct;
                SqlCmd.Parameters.Add(ParValAct);
                //
                SqlParameter ParFactor = new SqlParameter();
                ParFactor.ParameterName = "@mFactor";
                ParFactor.SqlDbType = SqlDbType.Int;
                ParFactor.Value = acfGIS_UbicacionElectrica.Factor;
                SqlCmd.Parameters.Add(ParFactor);
                //     
                SqlParameter ParVidUtilTrib = new SqlParameter();
                ParVidUtilTrib.ParameterName = "@mVidUtilTrib";
                ParVidUtilTrib.SqlDbType = SqlDbType.Int;
                ParVidUtilTrib.Value = acfGIS_UbicacionElectrica.VidUtilTrib;
                SqlCmd.Parameters.Add(ParVidUtilTrib);
                // 
                SqlParameter ParVidUtilFinan = new SqlParameter();
                ParVidUtilFinan.ParameterName = "@mVidUtilFinan";
                ParVidUtilFinan.SqlDbType = SqlDbType.Int;
                ParVidUtilFinan.Value = acfGIS_UbicacionElectrica.VidUtilFinan;
                SqlCmd.Parameters.Add(ParVidUtilFinan);
                //    
                SqlParameter ParUBEestado = new SqlParameter();
                ParUBEestado.ParameterName = "@mUBEestado";
                ParUBEestado.SqlDbType = SqlDbType.Char;
                ParUBEestado.Value = acfGIS_UbicacionElectrica.UBEestado;
                SqlCmd.Parameters.Add(ParUBEestado);
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
        public string Editar(DacfGIS_UbicacionElectrica acfGIS_UbicacionElectrica)
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
              SqlCmd.CommandText = "usp_U_acfGIS_UbicacionElectrica";
              SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUBEid = new SqlParameter();
                ParUBEid.ParameterName = "@iUBEid";
                ParUBEid.SqlDbType = SqlDbType.Int;
                ParUBEid.Value = acfGIS_UbicacionElectrica.UBEid;
                SqlCmd.Parameters.Add(ParUBEid);
                //   
                SqlParameter ParUBEcodigogis = new SqlParameter();
                ParUBEcodigogis.ParameterName = "@mUBEcodigogis";
                ParUBEcodigogis.SqlDbType = SqlDbType.BigInt;
                ParUBEcodigogis.Value = acfGIS_UbicacionElectrica.UBEcodigogis;
                SqlCmd.Parameters.Add(ParUBEcodigogis);
                //     
                SqlParameter ParACFid = new SqlParameter();
                ParACFid.ParameterName = "@mACFid";
                ParACFid.SqlDbType = SqlDbType.Int;
                ParACFid.Value = acfGIS_UbicacionElectrica.ACFid;
                SqlCmd.Parameters.Add(ParACFid);
                //
                SqlParameter ParSELid = new SqlParameter();
                ParSELid.ParameterName = "@mSELid";
                ParSELid.SqlDbType = SqlDbType.BigInt;
                ParSELid.Value = acfGIS_UbicacionElectrica.SELid;
                SqlCmd.Parameters.Add(ParSELid);
                //     
                SqlParameter ParUBEset = new SqlParameter();
                ParUBEset.ParameterName = "@mUBEset";
                ParUBEset.SqlDbType = SqlDbType.BigInt;
                ParUBEset.Value = acfGIS_UbicacionElectrica.UBEset;
                SqlCmd.Parameters.Add(ParUBEset);
                //   
                SqlParameter ParUBEsetetq = new SqlParameter();
                ParUBEsetetq.ParameterName = "@mUBEsetetq";
                ParUBEsetetq.SqlDbType = SqlDbType.VarChar;
                ParUBEsetetq.Value = acfGIS_UbicacionElectrica.UBEsetetq;
                SqlCmd.Parameters.Add(ParUBEsetetq);
                //    
                SqlParameter ParUBEalimentador = new SqlParameter();
                ParUBEalimentador.ParameterName = "@mUBEalimentador";
                ParUBEalimentador.SqlDbType = SqlDbType.BigInt;
                ParUBEalimentador.Value = acfGIS_UbicacionElectrica.UBEalimentador;
                SqlCmd.Parameters.Add(ParUBEalimentador);
                //    
                SqlParameter ParUBEalimetiquetadoretq = new SqlParameter();
                ParUBEalimetiquetadoretq.ParameterName = "@mUBEalimetiquetadoretq";
                ParUBEalimetiquetadoretq.SqlDbType = SqlDbType.VarChar;
                ParUBEalimetiquetadoretq.Value = acfGIS_UbicacionElectrica.UBEalimetiquetadoretq;
                SqlCmd.Parameters.Add(ParUBEalimetiquetadoretq);
                //     
                SqlParameter ParUBEsed = new SqlParameter();
                ParUBEsed.ParameterName = "@mUBEsed";
                ParUBEsed.SqlDbType = SqlDbType.BigInt;
                ParUBEsed.Value = acfGIS_UbicacionElectrica.UBEsed;
                SqlCmd.Parameters.Add(ParUBEsed);
                //     
                SqlParameter ParUBEsedetq = new SqlParameter();
                ParUBEsedetq.ParameterName = "@mUBEsedetq";
                ParUBEsedetq.SqlDbType = SqlDbType.VarChar;
                ParUBEsedetq.Value = acfGIS_UbicacionElectrica.UBEsedetq;
                SqlCmd.Parameters.Add(ParUBEsedetq);
                //     
                SqlParameter ParUBcircuito = new SqlParameter();
                ParUBcircuito.ParameterName = "@mUBcircuito";
                ParUBcircuito.SqlDbType = SqlDbType.BigInt;
                ParUBcircuito.Value = acfGIS_UbicacionElectrica.UBcircuito;
                SqlCmd.Parameters.Add(ParUBcircuito);
                //  
                SqlParameter ParUBEcircuitoetq = new SqlParameter();
                ParUBEcircuitoetq.ParameterName = "@mUBEcircuitoetq";
                ParUBEcircuitoetq.SqlDbType = SqlDbType.VarChar;
                ParUBEcircuitoetq.Value = acfGIS_UbicacionElectrica.UBEcircuitoetq;
                SqlCmd.Parameters.Add(ParUBEcircuitoetq);
                //   
                SqlParameter ParUBEtipoPuntoi = new SqlParameter();
                ParUBEtipoPuntoi.ParameterName = "@mUBEtipoPuntoi";
                ParUBEtipoPuntoi.SqlDbType = SqlDbType.BigInt;
                ParUBEtipoPuntoi.Value = acfGIS_UbicacionElectrica.UBEtipoPuntoi;
                SqlCmd.Parameters.Add(ParUBEtipoPuntoi);
                //     
                SqlParameter ParUBEpuntoi = new SqlParameter();
                ParUBEpuntoi.ParameterName = "@mUBEpuntoi";
                ParUBEpuntoi.SqlDbType = SqlDbType.BigInt;
                ParUBEpuntoi.Value = acfGIS_UbicacionElectrica.UBEpuntoi;
                SqlCmd.Parameters.Add(ParUBEpuntoi);
                //     
                SqlParameter ParUBEpuntoietq = new SqlParameter();
                ParUBEpuntoietq.ParameterName = "@mUBEpuntoietq";
                ParUBEpuntoietq.SqlDbType = SqlDbType.VarChar;
                ParUBEpuntoietq.Value = acfGIS_UbicacionElectrica.UBEpuntoietq;
                SqlCmd.Parameters.Add(ParUBEpuntoietq);
                // 
                SqlParameter ParUBEtipoPuntof = new SqlParameter();
                ParUBEtipoPuntof.ParameterName = "@mUBEtipoPuntof";
                ParUBEtipoPuntof.SqlDbType = SqlDbType.BigInt;
                ParUBEtipoPuntof.Value = acfGIS_UbicacionElectrica.UBEtipoPuntof;
                SqlCmd.Parameters.Add(ParUBEtipoPuntof);
                //  
                SqlParameter ParUBEpuntof = new SqlParameter();
                ParUBEpuntof.ParameterName = "@mUBEpuntof";
                ParUBEpuntof.SqlDbType = SqlDbType.BigInt;
                ParUBEpuntof.Value = acfGIS_UbicacionElectrica.UBEpuntof;
                SqlCmd.Parameters.Add(ParUBEpuntof);
                //     
                SqlParameter ParUBEpuntofetq = new SqlParameter();
                ParUBEpuntofetq.ParameterName = "@mUBEpuntofetq";
                ParUBEpuntofetq.SqlDbType = SqlDbType.VarChar;
                ParUBEpuntofetq.Value = acfGIS_UbicacionElectrica.UBEpuntofetq;
                SqlCmd.Parameters.Add(ParUBEpuntofetq);
                //   
                SqlParameter ParUBEobra = new SqlParameter();
                ParUBEobra.ParameterName = "@mUBEobra";
                ParUBEobra.SqlDbType = SqlDbType.Char;
                ParUBEobra.Value = acfGIS_UbicacionElectrica.UBEobra;
                SqlCmd.Parameters.Add(ParUBEobra);
                //     
                SqlParameter ParKOSTL = new SqlParameter();
                ParKOSTL.ParameterName = "@mKOSTL";
                ParKOSTL.SqlDbType = SqlDbType.Char;
                ParKOSTL.Value = acfGIS_UbicacionElectrica.KOSTL;
                SqlCmd.Parameters.Add(ParKOSTL);
                //     
                SqlParameter ParZona = new SqlParameter();
                ParZona.ParameterName = "@mZona";
                ParZona.SqlDbType = SqlDbType.Char;
                ParZona.Value = acfGIS_UbicacionElectrica.Zona;
                SqlCmd.Parameters.Add(ParZona);
                //     
                SqlParameter ParVNRid = new SqlParameter();
                ParVNRid.ParameterName = "@mVNRid";
                ParVNRid.SqlDbType = SqlDbType.Char;
                ParVNRid.Value = acfGIS_UbicacionElectrica.VNRid;
                SqlCmd.Parameters.Add(ParVNRid);
                //     
                SqlParameter ParCodNiff = new SqlParameter();
                ParCodNiff.ParameterName = "@mCodNiff";
                ParCodNiff.SqlDbType = SqlDbType.Char;
                ParCodNiff.Value = acfGIS_UbicacionElectrica.CodNiff;
                SqlCmd.Parameters.Add(ParCodNiff);
                //     
                SqlParameter ParValAct = new SqlParameter();
                ParValAct.ParameterName = "@mValAct";
                ParValAct.SqlDbType = SqlDbType.Int;
                ParValAct.Value = acfGIS_UbicacionElectrica.ValAct;
                SqlCmd.Parameters.Add(ParValAct);
                //
                SqlParameter ParFactor = new SqlParameter();
                ParFactor.ParameterName = "@mFactor";
                ParFactor.SqlDbType = SqlDbType.VarChar;
                ParFactor.Value = acfGIS_UbicacionElectrica.Factor;
                SqlCmd.Parameters.Add(ParFactor);
                //     
                SqlParameter ParVidUtilTrib = new SqlParameter();
                ParVidUtilTrib.ParameterName = "@mVidUtilTrib";
                ParVidUtilTrib.SqlDbType = SqlDbType.Int;
                ParVidUtilTrib.Value = acfGIS_UbicacionElectrica.VidUtilTrib;
                SqlCmd.Parameters.Add(ParVidUtilTrib);
                // 
                SqlParameter ParVidUtilFinan = new SqlParameter();
                ParVidUtilFinan.ParameterName = "@mVidUtilFinan";
                ParVidUtilFinan.SqlDbType = SqlDbType.Int;
                ParVidUtilFinan.Value = acfGIS_UbicacionElectrica.VidUtilFinan;
                SqlCmd.Parameters.Add(ParVidUtilFinan);
                //    
                SqlParameter ParUBEestado = new SqlParameter();
                ParUBEestado.ParameterName = "@mUBEestado";
                ParUBEestado.SqlDbType = SqlDbType.Char;
                ParUBEestado.Value = acfGIS_UbicacionElectrica.UBEestado;
                SqlCmd.Parameters.Add(ParUBEestado);
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
        public string Eliminar(DacfGIS_UbicacionElectrica acfGIS_UbicacionElectrica)
        {

            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
            //   //Código
            //   SqlCon.ConnectionString = DConexion.CnBDActivo;
            //   SqlCon.Open();
            //   //Establecer el Comando
            //   SqlCommand SqlCmd = new SqlCommand();
            //   SqlCmd.Connection = SqlCon;
            //   SqlCmd.CommandText = "usp_D_acfGIS_UbicacionElectrica";
            //   SqlCmd.CommandType = CommandType.StoredProcedure;
            //
            //   SqlParameter ParCSTid = new SqlParameter();
            //   ParCSTid.ParameterName = "@sCSTid";
            //   ParCSTid.SqlDbType = SqlDbType.Int;
            //   ParCSTid.Value = acfGIS_UbicacionElectrica.CSTid;
            //   SqlCmd.Parameters.Add(ParCSTid);
            //
            //   //
            //
            //   //Ejecutamos nuestro comando
            //
            //   rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Elimino el Registro";
            //

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

        public DataTable Buscar(DacfGIS_UbicacionElectrica acfGIS_UbicacionElectrica)
        {

            DataTable DtResultado = new DataTable("acfGIS_UbicacionElectrica");
            SqlConnection SqlCon = new SqlConnection();


            try
            {

           //   SqlCon.ConnectionString = DConexion.CnBDActivo;
           //   SqlCommand SqlCmd = new SqlCommand();
           //   SqlCmd.Connection = SqlCon;
           //   SqlCmd.CommandText = "usp_B_acfGIS_UbicacionElectrica";
           //   SqlCmd.CommandType = CommandType.StoredProcedure;
           //
           //
           //
           //   SqlParameter ParAMBambiente = new SqlParameter();
           //   ParAMBambiente.ParameterName = "@sCSTdescripcion";
           //   ParAMBambiente.SqlDbType = SqlDbType.Int;
           //   ParAMBambiente.Size = 50;
           //   ParAMBambiente.Value = acfGIS_UbicacionElectrica.CSTdescripcion;
           //   SqlCmd.Parameters.Add(ParAMBambiente);
           //
           //   SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
           //   SqlDat.Fill(DtResultado);
           //
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

    }
}
