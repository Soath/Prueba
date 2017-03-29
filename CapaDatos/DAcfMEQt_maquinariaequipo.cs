using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DAcfMEQt_maquinariaequipo
    {
        private string mMEQvnrtot;
        private string mMEQcantidad;
        private string mMEQaccffecinc;
        private string mMEQabreviatura;
        private string mMEQopiniontecnica;
        private string mMEQctacontable;
        private string mMEQniif;
        private string mMEQvrident;
        private string mMEQprovdes;
        private string mMEQcostorepcor;
        private string mMEQfactorinst;
        private string mMEQvalorresi;
        private string mMEQedadact;
        private string mMEQdeptas;
        private string mMEQvalorref;
        private string mMEQvalref2;
        private string mMEQvsm;
        private string mMEQestado;
        private string mMEQvidautil;
        private string mMEQvidautmax;
        private string mMEQedadtec;
        private string mMEQdepreciacion;
        private string mMEQdep2012;
        private string mMEQcostocorr;
        private string mMEQvaloractivo;
        private string mMEQdepre;
        private string mMEQtasair;
        private string mMEQimpdife;
        private string mMEQdifneta;
        private string mMEQvalorneto;
        private string mMEQvalact;
        private string mMEQcostotcorr;
        private string mMEQdepacuniif;
        private string mMEQcrcnet;
        private string mMEQvalnet;
        private string mMEQdiferenneta;
        private string mMEQvalornetolib;
        private string mMEQdepacumtrib;
        private string mMEQcostohistorico;
        private string mRVAcodigo;

        public string MEQvnrtot
        {
            get { return mMEQvnrtot; }
            set { mMEQvnrtot = value; }
        }
        public string MEQcantidad 
        {
            get { return mMEQcantidad; }
            set { mMEQcantidad = value; }
        }
        public string MEQaccffecinc
        {
            get { return mMEQaccffecinc; }
            set { mMEQaccffecinc = value; }
        }
        public string MEQabreviatura
        {
            get { return mMEQabreviatura; }
            set { mMEQabreviatura = value; }
        }
        public string MEQopiniontecnica
        {
            get { return mMEQopiniontecnica; }
            set { mMEQopiniontecnica = value; }
        }
        public string MEQctacontable
        {
            get { return mMEQctacontable; }
            set { mMEQctacontable = value; }
        }
        public string MEQniif
        {
            get { return mMEQniif; }
            set { mMEQniif = value; }
        }
        public string MEQvrident
        {
            get { return mMEQvrident; }
            set { mMEQvrident = value; }
        }
        public string MEQprovdes
        {
            get { return mMEQprovdes; }
            set { mMEQprovdes = value; }
        }
        public string MEQcostorepcor
        {
            get { return mMEQcostorepcor; }
            set { mMEQcostorepcor = value; }
        }
        public string MEQfactorinst
        {
            get { return mMEQfactorinst; }
            set { mMEQfactorinst = value; }
        }
        public string MEQvalorresi
        {
            get { return mMEQvalorresi; }
            set { mMEQvalorresi = value; }
        }
        public string MEQedadact
        {
            get { return mMEQedadact; }
            set { mMEQedadact = value; }
        }
        public string MEQdeptas
        {
            get { return mMEQdeptas; }
            set { mMEQdeptas = value; }
        }
        public string MEQvalorref
        {
            get { return mMEQvalorref; }
            set { mMEQvalorref = value; }
        }
        public string MEQvalref2
        {
            get { return mMEQvalref2; }
            set { mMEQvalref2 = value; }
        }
        public string MEQvsm
        {
            get { return mMEQvsm; }
            set { mMEQvsm = value; }
        }
        public string MEQestado
        {
            get { return mMEQestado; }
            set { mMEQestado = value; }
        }
        public string MEQvidautil
        {
            get { return mMEQvidautil; }
            set { mMEQvidautil = value; }
        }
        public string MEQvidautmax
        {
            get { return mMEQvidautmax; }
            set { mMEQvidautmax = value; }
        }
        public string MEQedadtec
        {
            get { return mMEQedadtec; }
            set { mMEQedadtec = value; }
        }
        public string MEQdepreciacion
        {
            get { return mMEQdepreciacion; }
            set { mMEQdepreciacion = value; }
        }
        public string MEQdep2012
        {
            get { return mMEQdep2012; }
            set { mMEQdep2012 = value; }
        }
        public string MEQcostocorr
        {
            get { return mMEQcostocorr; }
            set { mMEQcostocorr = value; }
        }
        public string MEQvaloractivo
        {
            get { return mMEQvaloractivo; }
            set { mMEQvaloractivo = value; }
        }
        public string MEQdepre
        {
            get { return mMEQdepre; }
            set { mMEQdepre = value; }
        }
        public string MEQtasair
        {
            get { return mMEQtasair; }
            set { mMEQtasair = value; }
        }

        public string MEQimpdife
        {
            get { return mMEQimpdife; }
            set { mMEQimpdife = value; }
        }
        public string MEQdifneta
        {
            get { return mMEQdifneta; }
            set { mMEQdifneta = value; }
        }
        public string MEQvalorneto
        {
            get { return mMEQvalorneto; }
            set { mMEQvalorneto = value; }
        }
        public string MEQvalact
        {
            get { return mMEQvalact; }
            set { mMEQvalact = value; }
        }
        public string MEQcostotcorr
        {
            get { return mMEQcostotcorr; }
            set { mMEQcostotcorr = value; }
        }
        public string MEQdepacuniif
        {
            get { return mMEQdepacuniif; }
            set { mMEQdepacuniif = value; }
        }
        public string MEQcrcnet
        {
            get { return mMEQcrcnet; }
            set { mMEQcrcnet = value; }
        }
        public string MEQvalnet
        {
            get { return mMEQvalnet; }
            set { mMEQvalnet = value; }
        }
        public string MEQdiferenneta
        {
            get { return mMEQdiferenneta; }
            set { mMEQdiferenneta = value; }
        }
        public string MEQvalornetolib
        {
            get { return mMEQvalornetolib; }
            set { mMEQvalornetolib = value; }
        }
        public string MEQdepacumtrib
        {
            get { return mMEQdepacumtrib; }
            set { mMEQdepacumtrib = value; }
        }
        public string MEQcostohistorico
        {
            get { return mMEQcostohistorico; }
            set { mMEQcostohistorico = value; }
        }
        public string RVAcodigo
        {
            get { return mRVAcodigo; }
            set { mRVAcodigo = value; }
        }



        //Constructor vacío
        public DAcfMEQt_maquinariaequipo()
        {
	}
        public DAcfMEQt_maquinariaequipo(
         string MEQvnrtot,
         string MEQcantidad,
         string MEQaccffecinc,
         string MEQabreviatura,
         string MEQopiniontecnica,
         string MEQctacontable,
         string MEQniif,
         string MEQvrident,
         string MEQprovdes,
         string MEQcostorepcor,
         string MEQfactorinst,
         string MEQvalorresi,
         string MEQedadact,
         string MEQdeptas,
         string MEQvalorref,
         string MEQvalref2,
         string MEQvsm,
         string MEQestado,
         string MEQvidautil,
         string MEQvidautmax,
         string MEQedadtec,
         string MEQdepreciacion,
         string MEQdep2012,
         string MEQcostocorr,
         string MEQvaloractivo,
         string MEQdepre,
         string MEQtasair,
         string MEQimpdife,
         string MEQdifneta,
         string MEQvalorneto,
         string MEQvalact,
         string MEQcostotcorr,
         string MEQdepacuniif,
         string MEQcrcnet,
         string MEQvalnet,
         string MEQdiferenneta,
         string MEQvalornetolib,
         string MEQdepacumtrib,
         string MEQcostohistorico,
         string RVAcodigo
        
        )
        {
            this.MEQvnrtot = mMEQvnrtot;
            this.MEQcantidad = mMEQcantidad;
            this.MEQaccffecinc = mMEQaccffecinc;
            this.MEQabreviatura = mMEQabreviatura;
            this.MEQopiniontecnica = mMEQopiniontecnica;
            this.MEQctacontable = mMEQctacontable;
            this.MEQniif = mMEQniif;
            this.MEQvrident = mMEQvrident;
            this.MEQprovdes = mMEQprovdes;
            this.MEQcostorepcor = mMEQcostorepcor;
            this.MEQfactorinst = mMEQfactorinst;
            this.MEQvalorresi = mMEQvalorresi;
            this.MEQedadact = mMEQedadact;
            this.MEQdeptas = mMEQdeptas;
            this.MEQvalorref = mMEQvalorref;
            this.MEQvalref2 = mMEQvalref2;
            this.MEQvsm = mMEQvsm;
            this.MEQestado = mMEQestado;
            this.MEQvidautil = mMEQvidautil;
            this.MEQvidautmax = mMEQvidautmax;
            this.MEQedadtec = mMEQedadtec;
            this.MEQdepreciacion = mMEQdepreciacion;
            this.MEQdep2012 = mMEQdep2012;
            this.MEQcostocorr = mMEQcostocorr;
            this.MEQvaloractivo = mMEQvaloractivo;
            this.MEQdepre = mMEQdepre;
            this.MEQtasair = mMEQtasair;
            this.MEQimpdife = mMEQimpdife;
            this.MEQdifneta = mMEQdifneta;
            this.MEQvalorneto = mMEQvalorneto;
            this.MEQvalact = mMEQvalact;
            this.MEQcostotcorr = mMEQcostotcorr;
            this.MEQdepacuniif = mMEQdepacuniif;
            this.MEQcrcnet = mMEQcrcnet;
            this.MEQvalnet = mMEQvalnet;
            this.MEQdiferenneta = mMEQdiferenneta;
            this.MEQvalornetolib = mMEQvalornetolib;
            this.MEQdepacumtrib = mMEQdepacumtrib;
            this.MEQcostohistorico = mMEQcostohistorico;
            this.RVAcodigo = mRVAcodigo;
           
        }
        //METODO MOSTRAR
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("acfMEQt_maquinariaequipo");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfMEQt_maquinariaequipo";
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
        public string Insertar(DAcfMEQt_maquinariaequipo acfMEQt_maquinariaequipo)
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
                SqlCmd.CommandText = "usp_I_acfMEQt_maquinariaequipo";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter PardecMEQvnrtot = new SqlParameter();
                PardecMEQvnrtot.ParameterName = "@decMEQvnrtot";
                PardecMEQvnrtot.SqlDbType = SqlDbType.Decimal;
                PardecMEQvnrtot.Value = acfMEQt_maquinariaequipo.MEQvnrtot;
                SqlCmd.Parameters.Add(PardecMEQvnrtot);
                //
                SqlParameter PardecMEQcantidad = new SqlParameter();
                PardecMEQcantidad.ParameterName = "@decMEQcantidad";
                PardecMEQcantidad.SqlDbType = SqlDbType.Decimal;
                PardecMEQcantidad.Value = acfMEQt_maquinariaequipo.MEQcantidad;
                SqlCmd.Parameters.Add(PardecMEQcantidad);
                //
                SqlParameter PardecMEQaccffecinc = new SqlParameter();
                PardecMEQaccffecinc.ParameterName = "@decMEQaccffecinc";
                PardecMEQaccffecinc.SqlDbType = SqlDbType.Decimal;
                PardecMEQaccffecinc.Value = acfMEQt_maquinariaequipo.MEQaccffecinc;
                SqlCmd.Parameters.Add(PardecMEQaccffecinc);
                //
                SqlParameter ParsMEQabreviatura = new SqlParameter();
                ParsMEQabreviatura.ParameterName = "@sMEQabreviatura";
                ParsMEQabreviatura.SqlDbType = SqlDbType.Char;
                ParsMEQabreviatura.Value = acfMEQt_maquinariaequipo.MEQabreviatura;
                SqlCmd.Parameters.Add(ParsMEQabreviatura);
                //
                //
                SqlParameter ParsMEQopiniontecnica = new SqlParameter();
                ParsMEQopiniontecnica.ParameterName = "@sMEQopiniontecnica";
                ParsMEQopiniontecnica.SqlDbType = SqlDbType.Char;
                ParsMEQopiniontecnica.Value = acfMEQt_maquinariaequipo.MEQopiniontecnica;
                SqlCmd.Parameters.Add(ParsMEQopiniontecnica);
                //
                SqlParameter PardecMEQctacontable = new SqlParameter();
                PardecMEQctacontable.ParameterName = "@decMEQctacontable";
                PardecMEQctacontable.SqlDbType = SqlDbType.Decimal;
                PardecMEQctacontable.Value = acfMEQt_maquinariaequipo.MEQctacontable;
                SqlCmd.Parameters.Add(PardecMEQctacontable);
                //
                SqlParameter PardecMEQniif = new SqlParameter();
                PardecMEQniif.ParameterName = "@decMEQniif";
                PardecMEQniif.SqlDbType = SqlDbType.Decimal;
                PardecMEQniif.Value = acfMEQt_maquinariaequipo.MEQniif;
                SqlCmd.Parameters.Add(PardecMEQniif);
                //
                SqlParameter PardecMEQvrident = new SqlParameter();
                PardecMEQvrident.ParameterName = "@decMEQvrident";
                PardecMEQvrident.SqlDbType = SqlDbType.Decimal;
                PardecMEQvrident.Value = acfMEQt_maquinariaequipo.MEQvrident;
                SqlCmd.Parameters.Add(PardecMEQvrident);
                //
                SqlParameter PardecMEQprovdes = new SqlParameter();
                PardecMEQprovdes.ParameterName = "@decMEQprovdes";
                PardecMEQprovdes.SqlDbType = SqlDbType.Decimal;
                PardecMEQprovdes.Value = acfMEQt_maquinariaequipo.MEQprovdes;
                SqlCmd.Parameters.Add(PardecMEQprovdes);
                //
                SqlParameter PardecMEQcostorepcor = new SqlParameter();
                PardecMEQcostorepcor.ParameterName = "@decMEQcostorepcor";
                PardecMEQcostorepcor.SqlDbType = SqlDbType.Decimal;
                PardecMEQcostorepcor.Value = acfMEQt_maquinariaequipo.MEQcostorepcor;
                SqlCmd.Parameters.Add(PardecMEQcostorepcor);
                //
                SqlParameter PardecMEQfactorinst = new SqlParameter();
                PardecMEQfactorinst.ParameterName = "@decMEQfactorinst";
                PardecMEQfactorinst.SqlDbType = SqlDbType.Decimal;
                PardecMEQfactorinst.Value = acfMEQt_maquinariaequipo.MEQfactorinst;
                SqlCmd.Parameters.Add(PardecMEQfactorinst);
                //
                SqlParameter PardecMEQvalorresi = new SqlParameter();
                PardecMEQvalorresi.ParameterName = "@decMEQvalorresi";
                PardecMEQvalorresi.SqlDbType = SqlDbType.Decimal;
                PardecMEQvalorresi.Value = acfMEQt_maquinariaequipo.MEQvalorresi;
                SqlCmd.Parameters.Add(PardecMEQvalorresi);
                //
                SqlParameter PardecMEQedadact = new SqlParameter();
                PardecMEQedadact.ParameterName = "@decMEQedadact";
                PardecMEQedadact.SqlDbType = SqlDbType.Decimal;
                PardecMEQedadact.Value = acfMEQt_maquinariaequipo.MEQedadact;
                SqlCmd.Parameters.Add(PardecMEQedadact);
                //
                SqlParameter PardecMEQdeptas = new SqlParameter();
                PardecMEQdeptas.ParameterName = "@decMEQdeptas";
                PardecMEQdeptas.SqlDbType = SqlDbType.Decimal;
                PardecMEQdeptas.Value = acfMEQt_maquinariaequipo.MEQdeptas;
                SqlCmd.Parameters.Add(PardecMEQdeptas);
                //
                SqlParameter PardecMEQvalorref = new SqlParameter();
                PardecMEQvalorref.ParameterName = "@decMEQvalorref";
                PardecMEQvalorref.SqlDbType = SqlDbType.Decimal;
                PardecMEQvalorref.Value = acfMEQt_maquinariaequipo.MEQvalorref;
                SqlCmd.Parameters.Add(PardecMEQvalorref);
                //
                SqlParameter PardecMEQvalref2 = new SqlParameter();
                PardecMEQvalref2.ParameterName = "@decMEQvalref2";
                PardecMEQvalref2.SqlDbType = SqlDbType.Decimal;
                PardecMEQvalref2.Value = acfMEQt_maquinariaequipo.MEQvalref2;
                SqlCmd.Parameters.Add(PardecMEQvalref2);
                //
                SqlParameter PardecMEQvsm = new SqlParameter();
                PardecMEQvsm.ParameterName = "@decMEQvsm";
                PardecMEQvsm.SqlDbType = SqlDbType.Decimal;
                PardecMEQvsm.Value = acfMEQt_maquinariaequipo.MEQvsm;
                SqlCmd.Parameters.Add(PardecMEQvsm);
                //
                SqlParameter PardecMEQestado = new SqlParameter();
                PardecMEQestado.ParameterName = "@decMEQestado";
                PardecMEQestado.SqlDbType = SqlDbType.Decimal;
                PardecMEQestado.Value = acfMEQt_maquinariaequipo.MEQestado;
                SqlCmd.Parameters.Add(PardecMEQestado);
                //
                SqlParameter PardecMEQvidautil = new SqlParameter();
                PardecMEQvidautil.ParameterName = "@decMEQvidautil";
                PardecMEQvidautil.SqlDbType = SqlDbType.Decimal;
                PardecMEQvidautil.Value = acfMEQt_maquinariaequipo.MEQvidautil;
                SqlCmd.Parameters.Add(PardecMEQvidautil);
                //
                SqlParameter PardecMEQvidautmax = new SqlParameter();
                PardecMEQvidautmax.ParameterName = "@decMEQvidautmax";
                PardecMEQvidautmax.SqlDbType = SqlDbType.Decimal;
                PardecMEQvidautmax.Value = acfMEQt_maquinariaequipo.MEQvidautmax;
                SqlCmd.Parameters.Add(PardecMEQvidautmax);
                //
                SqlParameter PardecMEQedadtec = new SqlParameter();
                PardecMEQedadtec.ParameterName = "@decMEQedadtec";
                PardecMEQedadtec.SqlDbType = SqlDbType.Decimal;
                PardecMEQedadtec.Value = acfMEQt_maquinariaequipo.MEQedadtec;
                SqlCmd.Parameters.Add(PardecMEQedadtec);
                //
                SqlParameter PardecMEQdepreciacion = new SqlParameter();
                PardecMEQdepreciacion.ParameterName = "@decMEQdepreciacion";
                PardecMEQdepreciacion.SqlDbType = SqlDbType.Decimal;
                PardecMEQdepreciacion.Value = acfMEQt_maquinariaequipo.MEQdepreciacion;
                SqlCmd.Parameters.Add(PardecMEQdepreciacion);
                //
                SqlParameter PardecMEQdep2012 = new SqlParameter();
                PardecMEQdep2012.ParameterName = "@decMEQdep2012";
                PardecMEQdep2012.SqlDbType = SqlDbType.Decimal;
                PardecMEQdep2012.Value = acfMEQt_maquinariaequipo.MEQdep2012;
                SqlCmd.Parameters.Add(PardecMEQdep2012);
                //
                SqlParameter PardecMEQcostocorr = new SqlParameter();
                PardecMEQcostocorr.ParameterName = "@decMEQcostocorr";
                PardecMEQcostocorr.SqlDbType = SqlDbType.Decimal;
                PardecMEQcostocorr.Value = acfMEQt_maquinariaequipo.MEQcostocorr;
                SqlCmd.Parameters.Add(PardecMEQcostocorr);
                //
                SqlParameter PardecMEQvaloractivo = new SqlParameter();
                PardecMEQvaloractivo.ParameterName = "@decMEQvaloractivo";
                PardecMEQvaloractivo.SqlDbType = SqlDbType.Decimal;
                PardecMEQvaloractivo.Value = acfMEQt_maquinariaequipo.MEQvaloractivo;
                SqlCmd.Parameters.Add(PardecMEQvaloractivo);
                //
                SqlParameter PardecMEQdepre = new SqlParameter();
                PardecMEQdepre.ParameterName = "@decMEQdepre";
                PardecMEQdepre.SqlDbType = SqlDbType.Decimal;
                PardecMEQdepre.Value = acfMEQt_maquinariaequipo.MEQdepre;
                SqlCmd.Parameters.Add(PardecMEQdepre);
                //
                SqlParameter PardecMEQtasair = new SqlParameter();
                PardecMEQtasair.ParameterName = "@decMEQtasair";
                PardecMEQtasair.SqlDbType = SqlDbType.Decimal;
                PardecMEQtasair.Value = acfMEQt_maquinariaequipo.MEQtasair;
                SqlCmd.Parameters.Add(PardecMEQtasair);
                //
                SqlParameter PardecMEQimpdife = new SqlParameter();
                PardecMEQimpdife.ParameterName = "@decMEQimpdife";
                PardecMEQimpdife.SqlDbType = SqlDbType.Decimal;
                PardecMEQimpdife.Value = acfMEQt_maquinariaequipo.MEQimpdife;
                SqlCmd.Parameters.Add(PardecMEQimpdife);
                //
                SqlParameter PardecMEQdifneta = new SqlParameter();
                PardecMEQdifneta.ParameterName = "@decMEQdifneta";
                PardecMEQdifneta.SqlDbType = SqlDbType.Decimal;
                PardecMEQdifneta.Value = acfMEQt_maquinariaequipo.MEQdifneta;
                SqlCmd.Parameters.Add(PardecMEQdifneta);
                //
                SqlParameter PardecMEQvalorneto = new SqlParameter();
                PardecMEQvalorneto.ParameterName = "@decMEQvalorneto";
                PardecMEQvalorneto.SqlDbType = SqlDbType.Decimal;
                PardecMEQvalorneto.Value = acfMEQt_maquinariaequipo.MEQvalorneto;
                SqlCmd.Parameters.Add(PardecMEQvalorneto);
                //
                SqlParameter PardecMEQvalact = new SqlParameter();
                PardecMEQvalact.ParameterName = "@decMEQvalact";
                PardecMEQvalact.SqlDbType = SqlDbType.Decimal;
                PardecMEQvalact.Value = acfMEQt_maquinariaequipo.MEQvalact;
                SqlCmd.Parameters.Add(PardecMEQvalact);
                //
                SqlParameter PardecMEQcostotcorr = new SqlParameter();
                PardecMEQcostotcorr.ParameterName = "@decMEQcostotcorr";
                PardecMEQcostotcorr.SqlDbType = SqlDbType.Decimal;
                PardecMEQcostotcorr.Value = acfMEQt_maquinariaequipo.MEQcostotcorr;
                SqlCmd.Parameters.Add(PardecMEQcostotcorr);
                //
                SqlParameter PardecMEQdepacuniif = new SqlParameter();
                PardecMEQdepacuniif.ParameterName = "@decMEQdepacuniif";
                PardecMEQdepacuniif.SqlDbType = SqlDbType.Decimal;
                PardecMEQdepacuniif.Value = acfMEQt_maquinariaequipo.MEQdepacuniif;
                SqlCmd.Parameters.Add(PardecMEQdepacuniif);
                //
                SqlParameter PardecMEQcrcnet = new SqlParameter();
                PardecMEQcrcnet.ParameterName = "@decMEQcrcnet";
                PardecMEQcrcnet.SqlDbType = SqlDbType.Decimal;
                PardecMEQcrcnet.Value = acfMEQt_maquinariaequipo.MEQcrcnet;
                SqlCmd.Parameters.Add(PardecMEQcrcnet);
                //
                SqlParameter PardecMEQvalnet = new SqlParameter();
                PardecMEQvalnet.ParameterName = "@decMEQvalnet";
                PardecMEQvalnet.SqlDbType = SqlDbType.Decimal;
                PardecMEQvalnet.Value = acfMEQt_maquinariaequipo.MEQvalnet;
                SqlCmd.Parameters.Add(PardecMEQvalnet);
                //
                SqlParameter PardecMEQdiferenneta = new SqlParameter();
                PardecMEQdiferenneta.ParameterName = "@decMEQdiferenneta";
                PardecMEQdiferenneta.SqlDbType = SqlDbType.Decimal;
                PardecMEQdiferenneta.Value = acfMEQt_maquinariaequipo.MEQdiferenneta;
                SqlCmd.Parameters.Add(PardecMEQdiferenneta);
                //
                SqlParameter PardecMEQvalornetolib = new SqlParameter();
                PardecMEQvalornetolib.ParameterName = "@decMEQvalornetolib";
                PardecMEQvalornetolib.SqlDbType = SqlDbType.Decimal;
                PardecMEQvalornetolib.Value = acfMEQt_maquinariaequipo.MEQvalornetolib;
                SqlCmd.Parameters.Add(PardecMEQvalornetolib);
                //
                SqlParameter PardecMEQdepacumtrib = new SqlParameter();
                PardecMEQdepacumtrib.ParameterName = "@decMEQdepacumtrib";
                PardecMEQdepacumtrib.SqlDbType = SqlDbType.Decimal;
                PardecMEQdepacumtrib.Value = acfMEQt_maquinariaequipo.MEQdepacumtrib;
                SqlCmd.Parameters.Add(PardecMEQdepacumtrib);
                //
                SqlParameter PardecMEQcostohistorico = new SqlParameter();
                PardecMEQcostohistorico.ParameterName = "@decMEQcostohistorico";
                PardecMEQcostohistorico.SqlDbType = SqlDbType.Decimal;
                PardecMEQcostohistorico.Value = acfMEQt_maquinariaequipo.MEQcostohistorico;
                SqlCmd.Parameters.Add(PardecMEQcostohistorico);
                //
                SqlParameter ParsRVAcodigo = new SqlParameter();
                ParsRVAcodigo.ParameterName = "@sRVAcodigo";
                ParsRVAcodigo.SqlDbType = SqlDbType.Char;
                ParsRVAcodigo.Value = acfMEQt_maquinariaequipo.RVAcodigo;
                SqlCmd.Parameters.Add(ParsRVAcodigo);
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
        public string Editar(DAcfMEQt_maquinariaequipo acfMEQt_maquinariaequipo)
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
                SqlCmd.CommandText = "usp_U_acfMEQt_maquinariaequipo";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter PardecMEQvnrtot = new SqlParameter();
                PardecMEQvnrtot.ParameterName = "@decMEQvnrtot";
                PardecMEQvnrtot.SqlDbType = SqlDbType.Decimal;
                PardecMEQvnrtot.Value = acfMEQt_maquinariaequipo.MEQvnrtot;
                SqlCmd.Parameters.Add(PardecMEQvnrtot);
                //
                SqlParameter PardecMEQcantidad = new SqlParameter();
                PardecMEQcantidad.ParameterName = "@decMEQcantidad";
                PardecMEQcantidad.SqlDbType = SqlDbType.Decimal;
                PardecMEQcantidad.Value = acfMEQt_maquinariaequipo.MEQcantidad;
                SqlCmd.Parameters.Add(PardecMEQcantidad);
                //
                SqlParameter PardecMEQaccffecinc = new SqlParameter();
                PardecMEQaccffecinc.ParameterName = "@decMEQaccffecinc";
                PardecMEQaccffecinc.SqlDbType = SqlDbType.Decimal;
                PardecMEQaccffecinc.Value = acfMEQt_maquinariaequipo.MEQaccffecinc;
                SqlCmd.Parameters.Add(PardecMEQaccffecinc);
                //
                SqlParameter ParsMEQabreviatura = new SqlParameter();
                ParsMEQabreviatura.ParameterName = "@sMEQabreviatura";
                ParsMEQabreviatura.SqlDbType = SqlDbType.Char;
                ParsMEQabreviatura.Value = acfMEQt_maquinariaequipo.MEQabreviatura;
                SqlCmd.Parameters.Add(ParsMEQabreviatura);
                //
                //
                SqlParameter ParsMEQopiniontecnica = new SqlParameter();
                ParsMEQopiniontecnica.ParameterName = "@sMEQopiniontecnica";
                ParsMEQopiniontecnica.SqlDbType = SqlDbType.Char;
                ParsMEQopiniontecnica.Value = acfMEQt_maquinariaequipo.MEQopiniontecnica;
                SqlCmd.Parameters.Add(ParsMEQopiniontecnica);
                //
                SqlParameter PardecMEQctacontable = new SqlParameter();
                PardecMEQctacontable.ParameterName = "@decMEQctacontable";
                PardecMEQctacontable.SqlDbType = SqlDbType.Decimal;
                PardecMEQctacontable.Value = acfMEQt_maquinariaequipo.MEQctacontable;
                SqlCmd.Parameters.Add(PardecMEQctacontable);
                //
                SqlParameter PardecMEQniif = new SqlParameter();
                PardecMEQniif.ParameterName = "@decMEQniif";
                PardecMEQniif.SqlDbType = SqlDbType.Decimal;
                PardecMEQniif.Value = acfMEQt_maquinariaequipo.MEQniif;
                SqlCmd.Parameters.Add(PardecMEQniif);
                //
                SqlParameter PardecMEQvrident = new SqlParameter();
                PardecMEQvrident.ParameterName = "@decMEQvrident";
                PardecMEQvrident.SqlDbType = SqlDbType.Decimal;
                PardecMEQvrident.Value = acfMEQt_maquinariaequipo.MEQvrident;
                SqlCmd.Parameters.Add(PardecMEQvrident);
                //
                SqlParameter PardecMEQprovdes = new SqlParameter();
                PardecMEQprovdes.ParameterName = "@decMEQprovdes";
                PardecMEQprovdes.SqlDbType = SqlDbType.Decimal;
                PardecMEQprovdes.Value = acfMEQt_maquinariaequipo.MEQprovdes;
                SqlCmd.Parameters.Add(PardecMEQprovdes);
                //
                SqlParameter PardecMEQcostorepcor = new SqlParameter();
                PardecMEQcostorepcor.ParameterName = "@decMEQcostorepcor";
                PardecMEQcostorepcor.SqlDbType = SqlDbType.Decimal;
                PardecMEQcostorepcor.Value = acfMEQt_maquinariaequipo.MEQcostorepcor;
                SqlCmd.Parameters.Add(PardecMEQcostorepcor);
                //
                SqlParameter PardecMEQfactorinst = new SqlParameter();
                PardecMEQfactorinst.ParameterName = "@decMEQfactorinst";
                PardecMEQfactorinst.SqlDbType = SqlDbType.Decimal;
                PardecMEQfactorinst.Value = acfMEQt_maquinariaequipo.MEQfactorinst;
                SqlCmd.Parameters.Add(PardecMEQfactorinst);
                //
                SqlParameter PardecMEQvalorresi = new SqlParameter();
                PardecMEQvalorresi.ParameterName = "@decMEQvalorresi";
                PardecMEQvalorresi.SqlDbType = SqlDbType.Decimal;
                PardecMEQvalorresi.Value = acfMEQt_maquinariaequipo.MEQvalorresi;
                SqlCmd.Parameters.Add(PardecMEQvalorresi);
                //
                SqlParameter PardecMEQedadact = new SqlParameter();
                PardecMEQedadact.ParameterName = "@decMEQedadact";
                PardecMEQedadact.SqlDbType = SqlDbType.Decimal;
                PardecMEQedadact.Value = acfMEQt_maquinariaequipo.MEQedadact;
                SqlCmd.Parameters.Add(PardecMEQedadact);
                //
                SqlParameter PardecMEQdeptas = new SqlParameter();
                PardecMEQdeptas.ParameterName = "@decMEQdeptas";
                PardecMEQdeptas.SqlDbType = SqlDbType.Decimal;
                PardecMEQdeptas.Value = acfMEQt_maquinariaequipo.MEQdeptas;
                SqlCmd.Parameters.Add(PardecMEQdeptas);
                //
                SqlParameter PardecMEQvalorref = new SqlParameter();
                PardecMEQvalorref.ParameterName = "@decMEQvalorref";
                PardecMEQvalorref.SqlDbType = SqlDbType.Decimal;
                PardecMEQvalorref.Value = acfMEQt_maquinariaequipo.MEQvalorref;
                SqlCmd.Parameters.Add(PardecMEQvalorref);
                //
                SqlParameter PardecMEQvalref2 = new SqlParameter();
                PardecMEQvalref2.ParameterName = "@decMEQvalref2";
                PardecMEQvalref2.SqlDbType = SqlDbType.Decimal;
                PardecMEQvalref2.Value = acfMEQt_maquinariaequipo.MEQvalref2;
                SqlCmd.Parameters.Add(PardecMEQvalref2);
                //
                SqlParameter PardecMEQvsm = new SqlParameter();
                PardecMEQvsm.ParameterName = "@decMEQvsm";
                PardecMEQvsm.SqlDbType = SqlDbType.Decimal;
                PardecMEQvsm.Value = acfMEQt_maquinariaequipo.MEQvsm;
                SqlCmd.Parameters.Add(PardecMEQvsm);
                //
                SqlParameter PardecMEQestado = new SqlParameter();
                PardecMEQestado.ParameterName = "@decMEQestado";
                PardecMEQestado.SqlDbType = SqlDbType.Decimal;
                PardecMEQestado.Value = acfMEQt_maquinariaequipo.MEQestado;
                SqlCmd.Parameters.Add(PardecMEQestado);
                //
                SqlParameter PardecMEQvidautil = new SqlParameter();
                PardecMEQvidautil.ParameterName = "@decMEQvidautil";
                PardecMEQvidautil.SqlDbType = SqlDbType.Decimal;
                PardecMEQvidautil.Value = acfMEQt_maquinariaequipo.MEQvidautil;
                SqlCmd.Parameters.Add(PardecMEQvidautil);
                //
                SqlParameter PardecMEQvidautmax = new SqlParameter();
                PardecMEQvidautmax.ParameterName = "@decMEQvidautmax";
                PardecMEQvidautmax.SqlDbType = SqlDbType.Decimal;
                PardecMEQvidautmax.Value = acfMEQt_maquinariaequipo.MEQvidautmax;
                SqlCmd.Parameters.Add(PardecMEQvidautmax);
                //
                SqlParameter PardecMEQedadtec = new SqlParameter();
                PardecMEQedadtec.ParameterName = "@decMEQedadtec";
                PardecMEQedadtec.SqlDbType = SqlDbType.Decimal;
                PardecMEQedadtec.Value = acfMEQt_maquinariaequipo.MEQedadtec;
                SqlCmd.Parameters.Add(PardecMEQedadtec);
                //
                SqlParameter PardecMEQdepreciacion = new SqlParameter();
                PardecMEQdepreciacion.ParameterName = "@decMEQdepreciacion";
                PardecMEQdepreciacion.SqlDbType = SqlDbType.Decimal;
                PardecMEQdepreciacion.Value = acfMEQt_maquinariaequipo.MEQdepreciacion;
                SqlCmd.Parameters.Add(PardecMEQdepreciacion);
                //
                SqlParameter PardecMEQdep2012 = new SqlParameter();
                PardecMEQdep2012.ParameterName = "@decMEQdep2012";
                PardecMEQdep2012.SqlDbType = SqlDbType.Decimal;
                PardecMEQdep2012.Value = acfMEQt_maquinariaequipo.MEQdep2012;
                SqlCmd.Parameters.Add(PardecMEQdep2012);
                //
                SqlParameter PardecMEQcostocorr = new SqlParameter();
                PardecMEQcostocorr.ParameterName = "@decMEQcostocorr";
                PardecMEQcostocorr.SqlDbType = SqlDbType.Decimal;
                PardecMEQcostocorr.Value = acfMEQt_maquinariaequipo.MEQcostocorr;
                SqlCmd.Parameters.Add(PardecMEQcostocorr);
                //
                SqlParameter PardecMEQvaloractivo = new SqlParameter();
                PardecMEQvaloractivo.ParameterName = "@decMEQvaloractivo";
                PardecMEQvaloractivo.SqlDbType = SqlDbType.Decimal;
                PardecMEQvaloractivo.Value = acfMEQt_maquinariaequipo.MEQvaloractivo;
                SqlCmd.Parameters.Add(PardecMEQvaloractivo);
                //
                SqlParameter PardecMEQdepre = new SqlParameter();
                PardecMEQdepre.ParameterName = "@decMEQdepre";
                PardecMEQdepre.SqlDbType = SqlDbType.Decimal;
                PardecMEQdepre.Value = acfMEQt_maquinariaequipo.MEQdepre;
                SqlCmd.Parameters.Add(PardecMEQdepre);
                //
                SqlParameter PardecMEQtasair = new SqlParameter();
                PardecMEQtasair.ParameterName = "@decMEQtasair";
                PardecMEQtasair.SqlDbType = SqlDbType.Decimal;
                PardecMEQtasair.Value = acfMEQt_maquinariaequipo.MEQtasair;
                SqlCmd.Parameters.Add(PardecMEQtasair);
                //
                SqlParameter PardecMEQimpdife = new SqlParameter();
                PardecMEQimpdife.ParameterName = "@decMEQimpdife";
                PardecMEQimpdife.SqlDbType = SqlDbType.Decimal;
                PardecMEQimpdife.Value = acfMEQt_maquinariaequipo.MEQimpdife;
                SqlCmd.Parameters.Add(PardecMEQimpdife);
                //
                SqlParameter PardecMEQdifneta = new SqlParameter();
                PardecMEQdifneta.ParameterName = "@decMEQdifneta";
                PardecMEQdifneta.SqlDbType = SqlDbType.Decimal;
                PardecMEQdifneta.Value = acfMEQt_maquinariaequipo.MEQdifneta;
                SqlCmd.Parameters.Add(PardecMEQdifneta);
                //
                SqlParameter PardecMEQvalorneto = new SqlParameter();
                PardecMEQvalorneto.ParameterName = "@decMEQvalorneto";
                PardecMEQvalorneto.SqlDbType = SqlDbType.Decimal;
                PardecMEQvalorneto.Value = acfMEQt_maquinariaequipo.MEQvalorneto;
                SqlCmd.Parameters.Add(PardecMEQvalorneto);
                //
                SqlParameter PardecMEQvalact = new SqlParameter();
                PardecMEQvalact.ParameterName = "@decMEQvalact";
                PardecMEQvalact.SqlDbType = SqlDbType.Decimal;
                PardecMEQvalact.Value = acfMEQt_maquinariaequipo.MEQvalact;
                SqlCmd.Parameters.Add(PardecMEQvalact);
                //
                SqlParameter PardecMEQcostotcorr = new SqlParameter();
                PardecMEQcostotcorr.ParameterName = "@decMEQcostotcorr";
                PardecMEQcostotcorr.SqlDbType = SqlDbType.Decimal;
                PardecMEQcostotcorr.Value = acfMEQt_maquinariaequipo.MEQcostotcorr;
                SqlCmd.Parameters.Add(PardecMEQcostotcorr);
                //
                SqlParameter PardecMEQdepacuniif = new SqlParameter();
                PardecMEQdepacuniif.ParameterName = "@decMEQdepacuniif";
                PardecMEQdepacuniif.SqlDbType = SqlDbType.Decimal;
                PardecMEQdepacuniif.Value = acfMEQt_maquinariaequipo.MEQdepacuniif;
                SqlCmd.Parameters.Add(PardecMEQdepacuniif);
                //
                SqlParameter PardecMEQcrcnet = new SqlParameter();
                PardecMEQcrcnet.ParameterName = "@decMEQcrcnet";
                PardecMEQcrcnet.SqlDbType = SqlDbType.Decimal;
                PardecMEQcrcnet.Value = acfMEQt_maquinariaequipo.MEQcrcnet;
                SqlCmd.Parameters.Add(PardecMEQcrcnet);
                //
                SqlParameter PardecMEQvalnet = new SqlParameter();
                PardecMEQvalnet.ParameterName = "@decMEQvalnet";
                PardecMEQvalnet.SqlDbType = SqlDbType.Decimal;
                PardecMEQvalnet.Value = acfMEQt_maquinariaequipo.MEQvalnet;
                SqlCmd.Parameters.Add(PardecMEQvalnet);
                //
                SqlParameter PardecMEQdiferenneta = new SqlParameter();
                PardecMEQdiferenneta.ParameterName = "@decMEQdiferenneta";
                PardecMEQdiferenneta.SqlDbType = SqlDbType.Decimal;
                PardecMEQdiferenneta.Value = acfMEQt_maquinariaequipo.MEQdiferenneta;
                SqlCmd.Parameters.Add(PardecMEQdiferenneta);
                //
                SqlParameter PardecMEQvalornetolib = new SqlParameter();
                PardecMEQvalornetolib.ParameterName = "@decMEQvalornetolib";
                PardecMEQvalornetolib.SqlDbType = SqlDbType.Decimal;
                PardecMEQvalornetolib.Value = acfMEQt_maquinariaequipo.MEQvalornetolib;
                SqlCmd.Parameters.Add(PardecMEQvalornetolib);
                //
                SqlParameter PardecMEQdepacumtrib = new SqlParameter();
                PardecMEQdepacumtrib.ParameterName = "@decMEQdepacumtrib";
                PardecMEQdepacumtrib.SqlDbType = SqlDbType.Decimal;
                PardecMEQdepacumtrib.Value = acfMEQt_maquinariaequipo.MEQdepacumtrib;
                SqlCmd.Parameters.Add(PardecMEQdepacumtrib);
                //
                SqlParameter PardecMEQcostohistorico = new SqlParameter();
                PardecMEQcostohistorico.ParameterName = "@decMEQcostohistorico";
                PardecMEQcostohistorico.SqlDbType = SqlDbType.Decimal;
                PardecMEQcostohistorico.Value = acfMEQt_maquinariaequipo.MEQcostohistorico;
                SqlCmd.Parameters.Add(PardecMEQcostohistorico);
                //
                SqlParameter ParsRVAcodigo = new SqlParameter();
                ParsRVAcodigo.ParameterName = "@sRVAcodigo";
                ParsRVAcodigo.SqlDbType = SqlDbType.Char;
                ParsRVAcodigo.Value = acfMEQt_maquinariaequipo.RVAcodigo;
                SqlCmd.Parameters.Add(ParsRVAcodigo);
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
	public string Eliminar(DAcfMEQt_maquinariaequipo acfMEQt_maquinariaequipo) {
		
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
                SqlCmd.CommandText = "usp_D_acfMEQt_maquinariaequipo";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter ParsRVAcodigo = new SqlParameter();
                ParsRVAcodigo.ParameterName = "@sRVAcodigo";
                ParsRVAcodigo.SqlDbType = SqlDbType.Char;
                ParsRVAcodigo.Value = acfMEQt_maquinariaequipo.RVAcodigo;
                SqlCmd.Parameters.Add(ParsRVAcodigo);
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

    public DataTable Buscar(DAcfMEQt_maquinariaequipo acfMEQt_maquinariaequipo)
    {

        DataTable DtResultado = new DataTable("acfMEQt_maquinariaequipo");
        SqlConnection SqlCon = new SqlConnection();


        try
        {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_acfMEQt_maquinariaequipo";
            SqlCmd.CommandType = CommandType.StoredProcedure;



            SqlParameter ParsRVAcodigo = new SqlParameter();
            ParsRVAcodigo.ParameterName = "@sRVAcodigo";
            ParsRVAcodigo.SqlDbType = SqlDbType.Char;
            ParsRVAcodigo.Value = acfMEQt_maquinariaequipo.RVAcodigo;
            SqlCmd.Parameters.Add(ParsRVAcodigo);
            //

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
