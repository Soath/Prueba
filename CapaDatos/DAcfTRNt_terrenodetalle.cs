using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DAcfTRNt_terrenodetalle
    {
        private string mCRSnombrepredio;
        private string mCRScentropoblado;
        private string mCRSdepartamento;
        private string mCRSinterior;
        private string mCRScarretera;
        private string mCRSkilometro;
        private string mACFArea;
        private string mACFvalor;
        private string mACFtc;
        private string mACFvalorSoles            ;
        private string mACFValorDolar            ;
        private string mACFValorAnt0             ;
        private string mACFVutilniff             ;
        private string mACFNetopcga              ;
        private string mACFvalorATri             ;
        private string mACFid                    ;
        private string mACFdiferencia            ;
        private string mACFDifTemDedu            ;
        private string mACFDifTemGrav            ;
        private string mACFTasaIR                ;
        private string mACFSaldoDeducible        ;
        private string mACFSaldoGravable         ;
        private string mRVAcodigo;
       
    

    public string CRSnombrepredio
        {
            get { return mCRSnombrepredio; }
            set { mCRSnombrepredio = value; }
        }
    public string CRScentropoblado
        {
            get { return mCRScentropoblado; }
            set { mCRScentropoblado = value; }
        }
    public string CRSdepartamento
        {
            get { return mCRSdepartamento; }
            set { mCRSdepartamento = value; }
        }
    public string CRSinterior
        {
            get { return mCRSinterior; }
            set { mCRSinterior = value; }
        }
    public string CRScarretera
        {
            get { return mCRScarretera; }
            set { mCRScarretera = value; }
        }
    public string CRSkilometro
        {
            get { return mCRSkilometro; }
            set { mCRSkilometro = value; }
        }
    public string ACFArea
        {
            get { return mACFArea; }
            set { mACFArea = value; }
        }
    public string ACFvalor
        {
            get { return mACFvalor; }
            set { mACFvalor = value; }
        }
    public string ACFtc
        {
            get { return mACFtc; }
            set { mACFtc = value; }
        }
    public string ACFvalorSoles
        {
            get { return mACFvalorSoles; }
            set { mACFvalorSoles = value; }
        }
    public string ACFValorDolar
        {
            get { return mACFValorDolar; }
            set { mACFValorDolar = value; }
        }
    public string ACFValorAnt0
        {
            get { return mACFValorAnt0; }
            set { mACFValorAnt0 = value; }
        }
    public string ACFVutilniff
        {
            get { return mACFVutilniff; }
            set { mACFVutilniff = value; }
        }
    public string ACFNetopcga
        {
            get { return mACFNetopcga; }
            set { mACFNetopcga = value; }
        }
    public string ACFvalorATri
        {
            get { return mACFvalorATri; }
            set { mACFvalorATri = value; }
        }
    public string ACFid
        {
            get { return mACFid; }
            set { mACFid = value; }
        }
    public string ACFdiferencia
        {
            get { return mACFdiferencia; }
            set { mACFdiferencia = value; }
        }
    public string ACFDifTemDedu
        {
            get { return mACFDifTemDedu; }
            set { mACFDifTemDedu = value; }
        }
    public string ACFDifTemGrav
        {
            get { return mACFDifTemGrav; }
            set { mACFDifTemGrav = value; }
        }
    public string ACFTasaIR
        {
            get { return mACFTasaIR; }
            set { mACFTasaIR = value; }
        }
    public string ACFSaldoDeducible
        {
            get { return mACFSaldoDeducible; }
            set { mACFSaldoDeducible = value; }
        }
    public string ACFSaldoGravable
        {
            get { return mACFSaldoGravable; }
            set { mACFSaldoGravable = value; }
        }
    public string RVAcodigo
        {
            get { return mRVAcodigo; }
            set { mRVAcodigo = value; }
        }

          //Constructor vacío
	public DAcfTRNt_terrenodetalle(){
	}
        //Constructor con parámetros
    public DAcfTRNt_terrenodetalle(
         string CRSnombrepredio,
         string CRScentropoblado,
         string CRSdepartamento,
         string CRSinterior,
         string CRScarretera,
         string CRSkilometro,
         string ACFArea,
         string ACFvalor,
         string ACFtc,
         string ACFvalorSoles            ,
         string ACFValorDolar            ,
         string ACFValorAnt0             ,
         string ACFVutilniff             ,
         string ACFNetopcga              ,
         string ACFvalorATri             ,
         string ACFid                    ,
         string ACFdiferencia            ,
         string ACFDifTemDedu            ,
         string ACFDifTemGrav            ,
         string ACFTasaIR                ,
         string ACFSaldoDeducible        ,
         string ACFSaldoGravable         ,
         string RVAcodigo
        )
    {
        this.CRSnombrepredio = mCRSnombrepredio;
        this.CRScentropoblado = mCRScentropoblado;
        this.CRSdepartamento = mCRSdepartamento;
        this.CRSinterior = mCRSinterior;
        this.CRScarretera = mCRScarretera;
        this.CRSkilometro = mCRSkilometro;
        this.ACFArea = mACFArea;
        this.ACFvalor = mACFvalor;
        this.ACFtc = mACFtc;
        this.ACFvalorSoles = mACFvalorSoles;
        this.ACFValorDolar = mACFValorDolar;
        this.ACFValorAnt0 = mACFValorAnt0;
        this.ACFVutilniff = mACFVutilniff;
        this.ACFNetopcga = mACFNetopcga;
        this.ACFvalorATri = mACFvalorATri;
        this.ACFid = mACFid;
        this.ACFdiferencia = mACFdiferencia;
        this.ACFDifTemDedu = mACFDifTemDedu;
        this.ACFDifTemGrav = mACFDifTemGrav;
        this.ACFTasaIR = mACFTasaIR;
        this.ACFSaldoDeducible = mACFSaldoDeducible;
        this.ACFSaldoGravable = mACFSaldoGravable;
        this.RVAcodigo = mRVAcodigo;
        
    }

    //METODO MOSTRAR
    public DataTable Mostrar()
    {
        DataTable DtResultado = new DataTable("acfTRNt_terrenodetalle");
        SqlConnection SqlCon = new SqlConnection();

        try
        {
            //Codigo
            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_S_acfTRNt_terrenodetalle";
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
    public string Insertar(DAcfTRNt_terrenodetalle acfTRNt_terrenodetalle)
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
            SqlCmd.CommandText = "usp_I_acfTRNt_terrenodetalle";
            SqlCmd.CommandType = CommandType.StoredProcedure;
            //
            SqlParameter ParCRSnombrepredio = new SqlParameter();
            ParCRSnombrepredio.ParameterName = "@sCRSnombrepredio";
            ParCRSnombrepredio.SqlDbType = SqlDbType.Char;
            ParCRSnombrepredio.Value = acfTRNt_terrenodetalle.CRSnombrepredio;
            SqlCmd.Parameters.Add(ParCRSnombrepredio);
            //
            SqlParameter ParCRScentropoblado = new SqlParameter();
            ParCRScentropoblado.ParameterName = "@sCRScentropoblado";
            ParCRScentropoblado.SqlDbType = SqlDbType.Char;
            ParCRScentropoblado.Value = acfTRNt_terrenodetalle.CRScentropoblado;
            SqlCmd.Parameters.Add(ParCRScentropoblado);
            //
            SqlParameter ParCRSdepartamento = new SqlParameter();
            ParCRSdepartamento.ParameterName = "@sCRSdepartamento";
            ParCRSdepartamento.SqlDbType = SqlDbType.Char;
            ParCRSdepartamento.Value = acfTRNt_terrenodetalle.CRSdepartamento;
            SqlCmd.Parameters.Add(ParCRSdepartamento);
            //
            SqlParameter ParCRSinterior = new SqlParameter();
            ParCRSinterior.ParameterName = "@sCRSinterior";
            ParCRSinterior.SqlDbType = SqlDbType.Char;
            ParCRSinterior.Value = acfTRNt_terrenodetalle.CRSinterior;
            SqlCmd.Parameters.Add(ParCRSinterior);
            //
            SqlParameter ParCRScarretera = new SqlParameter();
            ParCRScarretera.ParameterName = "@sCRScarretera";
            ParCRScarretera.SqlDbType = SqlDbType.Char;
            ParCRScarretera.Value = acfTRNt_terrenodetalle.CRScarretera;
            SqlCmd.Parameters.Add(ParCRScarretera);
            //
            SqlParameter ParCRSkilometro = new SqlParameter();
            ParCRSkilometro.ParameterName = "@sCRSkilometro";
            ParCRSkilometro.SqlDbType = SqlDbType.Char;
            ParCRSkilometro.Value = acfTRNt_terrenodetalle.CRSkilometro;
            SqlCmd.Parameters.Add(ParCRSkilometro);
            //
            SqlParameter ParACFArea = new SqlParameter();
            ParACFArea.ParameterName = "@sACFArea";
            ParACFArea.SqlDbType = SqlDbType.Char;
            ParACFArea.Value = acfTRNt_terrenodetalle.ACFArea;
            SqlCmd.Parameters.Add(ParACFArea);
            //
            SqlParameter ParACFvalor = new SqlParameter();
            ParACFvalor.ParameterName = "@sACFvalor";
            ParACFvalor.SqlDbType = SqlDbType.Char;
            ParACFvalor.Value = acfTRNt_terrenodetalle.ACFvalor;
            SqlCmd.Parameters.Add(ParACFvalor);
            //
            SqlParameter ParACFtc = new SqlParameter();
            ParACFtc.ParameterName = "@sACFtc";
            ParACFtc.SqlDbType = SqlDbType.Char;
            ParACFtc.Value = acfTRNt_terrenodetalle.ACFtc;
            SqlCmd.Parameters.Add(ParACFtc);
            //
            SqlParameter ParACFvalorSoles = new SqlParameter();
            ParACFvalorSoles.ParameterName = "@sACFvalorSoles";
            ParACFvalorSoles.SqlDbType = SqlDbType.Char;
            ParACFvalorSoles.Value = acfTRNt_terrenodetalle.ACFvalorSoles;
            SqlCmd.Parameters.Add(ParACFvalorSoles);
            //
            SqlParameter ParACFValorDolar = new SqlParameter();
            ParACFValorDolar.ParameterName = "@sACFValorDolar";
            ParACFValorDolar.SqlDbType = SqlDbType.Char;
            ParACFValorDolar.Value = acfTRNt_terrenodetalle.ACFValorDolar;
            SqlCmd.Parameters.Add(ParACFValorDolar);
            //
            SqlParameter ParACFValorAnt0 = new SqlParameter();
            ParACFValorAnt0.ParameterName = "@sACFValorAnt0";
            ParACFValorAnt0.SqlDbType = SqlDbType.Char;
            ParACFValorAnt0.Value = acfTRNt_terrenodetalle.ACFValorAnt0;
            SqlCmd.Parameters.Add(ParACFValorAnt0);
            //
            SqlParameter ParACFVutilniff = new SqlParameter();
            ParACFVutilniff.ParameterName = "@sACFVutilniff";
            ParACFVutilniff.SqlDbType = SqlDbType.Char;
            ParACFVutilniff.Value = acfTRNt_terrenodetalle.ACFVutilniff;
            SqlCmd.Parameters.Add(ParACFVutilniff);
            //
            SqlParameter ParACFNetopcga = new SqlParameter();
            ParACFNetopcga.ParameterName = "@sACFNetopcga";
            ParACFNetopcga.SqlDbType = SqlDbType.Char;
            ParACFNetopcga.Value = acfTRNt_terrenodetalle.ACFNetopcga;
            SqlCmd.Parameters.Add(ParACFNetopcga);
            //
            SqlParameter ParACFvalorATri = new SqlParameter();
            ParACFvalorATri.ParameterName = "@sACFvalorATri";
            ParACFvalorATri.SqlDbType = SqlDbType.Char;
            ParACFvalorATri.Value = acfTRNt_terrenodetalle.ACFvalorATri;
            SqlCmd.Parameters.Add(ParACFvalorATri);
            //
            SqlParameter ParACFid = new SqlParameter();
            ParACFid.ParameterName = "@sACFid";
            ParACFid.SqlDbType = SqlDbType.Char;
            ParACFid.Value = acfTRNt_terrenodetalle.ACFid;
            SqlCmd.Parameters.Add(ParACFid);
            //
            SqlParameter ParACFdiferencia = new SqlParameter();
            ParACFdiferencia.ParameterName = "@sACFdiferencia";
            ParACFdiferencia.SqlDbType = SqlDbType.Char;
            ParACFdiferencia.Value = acfTRNt_terrenodetalle.ACFdiferencia;
            SqlCmd.Parameters.Add(ParACFdiferencia);
            //
            SqlParameter ParACFDifTemDedu = new SqlParameter();
            ParACFDifTemDedu.ParameterName = "@sACFDifTemDedu";
            ParACFDifTemDedu.SqlDbType = SqlDbType.Char;
            ParACFDifTemDedu.Value = acfTRNt_terrenodetalle.ACFDifTemDedu;
            SqlCmd.Parameters.Add(ParACFDifTemDedu);
            //
            SqlParameter ParACFDifTemGrav = new SqlParameter();
            ParACFDifTemGrav.ParameterName = "@sACFDifTemGrav";
            ParACFDifTemGrav.SqlDbType = SqlDbType.Char;
            ParACFDifTemGrav.Value = acfTRNt_terrenodetalle.ACFDifTemGrav;
            SqlCmd.Parameters.Add(ParACFDifTemGrav);
            //
            SqlParameter ParACFTasaIR = new SqlParameter();
            ParACFTasaIR.ParameterName = "@sACFTasaIR";
            ParACFTasaIR.SqlDbType = SqlDbType.Char;
            ParACFTasaIR.Value = acfTRNt_terrenodetalle.ACFTasaIR;
            SqlCmd.Parameters.Add(ParACFTasaIR);
            //
            SqlParameter ParACFSaldoDeducible = new SqlParameter();
            ParACFSaldoDeducible.ParameterName = "@sACFSaldoDeducible";
            ParACFSaldoDeducible.SqlDbType = SqlDbType.Char;
            ParACFSaldoDeducible.Value = acfTRNt_terrenodetalle.ACFSaldoDeducible;
            SqlCmd.Parameters.Add(ParACFSaldoDeducible);
            //
            SqlParameter ParACFSaldoGravable = new SqlParameter();
            ParACFSaldoGravable.ParameterName = "@sACFSaldoGravable";
            ParACFSaldoGravable.SqlDbType = SqlDbType.Char;
            ParACFSaldoGravable.Value = acfTRNt_terrenodetalle.ACFSaldoGravable;
            SqlCmd.Parameters.Add(ParACFSaldoGravable);
            //
            SqlParameter ParRVAcodigo = new SqlParameter();
            ParRVAcodigo.ParameterName = "@sRVAcodigo";
            ParRVAcodigo.SqlDbType = SqlDbType.Char;
            ParRVAcodigo.Value = acfTRNt_terrenodetalle.RVAcodigo;
            SqlCmd.Parameters.Add(ParRVAcodigo);
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
    public string Editar(DAcfTRNt_terrenodetalle acfTRNt_terrenodetalle)
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
            SqlCmd.CommandText = "usp_U_acfTRNt_terrenodetalle";
            SqlCmd.CommandType = CommandType.StoredProcedure;
            //
            //
            SqlParameter ParCRSnombrepredio = new SqlParameter();
            ParCRSnombrepredio.ParameterName = "@sCRSnombrepredio";
            ParCRSnombrepredio.SqlDbType = SqlDbType.Char;
            ParCRSnombrepredio.Value = acfTRNt_terrenodetalle.CRSnombrepredio;
            SqlCmd.Parameters.Add(ParCRSnombrepredio);
            //
            SqlParameter ParCRScentropoblado = new SqlParameter();
            ParCRScentropoblado.ParameterName = "@sCRScentropoblado";
            ParCRScentropoblado.SqlDbType = SqlDbType.Char;
            ParCRScentropoblado.Value = acfTRNt_terrenodetalle.CRScentropoblado;
            SqlCmd.Parameters.Add(ParCRScentropoblado);
            //
            SqlParameter ParCRSdepartamento = new SqlParameter();
            ParCRSdepartamento.ParameterName = "@sCRSdepartamento";
            ParCRSdepartamento.SqlDbType = SqlDbType.Char;
            ParCRSdepartamento.Value = acfTRNt_terrenodetalle.CRSdepartamento;
            SqlCmd.Parameters.Add(ParCRSdepartamento);
            //
            SqlParameter ParCRSinterior = new SqlParameter();
            ParCRSinterior.ParameterName = "@sCRSinterior";
            ParCRSinterior.SqlDbType = SqlDbType.Char;
            ParCRSinterior.Value = acfTRNt_terrenodetalle.CRSinterior;
            SqlCmd.Parameters.Add(ParCRSinterior);
            //
            SqlParameter ParCRScarretera = new SqlParameter();
            ParCRScarretera.ParameterName = "@sCRScarretera";
            ParCRScarretera.SqlDbType = SqlDbType.Char;
            ParCRScarretera.Value = acfTRNt_terrenodetalle.CRScarretera;
            SqlCmd.Parameters.Add(ParCRScarretera);
            //
            SqlParameter ParCRSkilometro = new SqlParameter();
            ParCRSkilometro.ParameterName = "@sCRSkilometro";
            ParCRSkilometro.SqlDbType = SqlDbType.Char;
            ParCRSkilometro.Value = acfTRNt_terrenodetalle.CRSkilometro;
            SqlCmd.Parameters.Add(ParCRSkilometro);
            //
            SqlParameter ParACFArea = new SqlParameter();
            ParACFArea.ParameterName = "@sACFArea";
            ParACFArea.SqlDbType = SqlDbType.Char;
            ParACFArea.Value = acfTRNt_terrenodetalle.ACFArea;
            SqlCmd.Parameters.Add(ParACFArea);
            //
            SqlParameter ParACFvalor = new SqlParameter();
            ParACFvalor.ParameterName = "@sACFvalor";
            ParACFvalor.SqlDbType = SqlDbType.Char;
            ParACFvalor.Value = acfTRNt_terrenodetalle.ACFvalor;
            SqlCmd.Parameters.Add(ParACFvalor);
            //
            SqlParameter ParACFtc = new SqlParameter();
            ParACFtc.ParameterName = "@sACFtc";
            ParACFtc.SqlDbType = SqlDbType.Char;
            ParACFtc.Value = acfTRNt_terrenodetalle.ACFtc;
            SqlCmd.Parameters.Add(ParACFtc);
            //
            SqlParameter ParACFvalorSoles = new SqlParameter();
            ParACFvalorSoles.ParameterName = "@sACFvalorSoles";
            ParACFvalorSoles.SqlDbType = SqlDbType.Char;
            ParACFvalorSoles.Value = acfTRNt_terrenodetalle.ACFvalorSoles;
            SqlCmd.Parameters.Add(ParACFvalorSoles);
            //
            SqlParameter ParACFValorDolar = new SqlParameter();
            ParACFValorDolar.ParameterName = "@sACFValorDolar";
            ParACFValorDolar.SqlDbType = SqlDbType.Char;
            ParACFValorDolar.Value = acfTRNt_terrenodetalle.ACFValorDolar;
            SqlCmd.Parameters.Add(ParACFValorDolar);
            //
            SqlParameter ParACFValorAnt0 = new SqlParameter();
            ParACFValorAnt0.ParameterName = "@sACFValorAnt0";
            ParACFValorAnt0.SqlDbType = SqlDbType.Char;
            ParACFValorAnt0.Value = acfTRNt_terrenodetalle.ACFValorAnt0;
            SqlCmd.Parameters.Add(ParACFValorAnt0);
            //
            SqlParameter ParACFVutilniff = new SqlParameter();
            ParACFVutilniff.ParameterName = "@sACFVutilniff";
            ParACFVutilniff.SqlDbType = SqlDbType.Char;
            ParACFVutilniff.Value = acfTRNt_terrenodetalle.ACFVutilniff;
            SqlCmd.Parameters.Add(ParACFVutilniff);
            //
            SqlParameter ParACFNetopcga = new SqlParameter();
            ParACFNetopcga.ParameterName = "@sACFNetopcga";
            ParACFNetopcga.SqlDbType = SqlDbType.Char;
            ParACFNetopcga.Value = acfTRNt_terrenodetalle.ACFNetopcga;
            SqlCmd.Parameters.Add(ParACFNetopcga);
            //
            SqlParameter ParACFvalorATri = new SqlParameter();
            ParACFvalorATri.ParameterName = "@sACFvalorATri";
            ParACFvalorATri.SqlDbType = SqlDbType.Char;
            ParACFvalorATri.Value = acfTRNt_terrenodetalle.ACFvalorATri;
            SqlCmd.Parameters.Add(ParACFvalorATri);
            //
            SqlParameter ParACFid = new SqlParameter();
            ParACFid.ParameterName = "@sACFid";
            ParACFid.SqlDbType = SqlDbType.Char;
            ParACFid.Value = acfTRNt_terrenodetalle.ACFid;
            SqlCmd.Parameters.Add(ParACFid);
            //
            SqlParameter ParACFdiferencia = new SqlParameter();
            ParACFdiferencia.ParameterName = "@sACFdiferencia";
            ParACFdiferencia.SqlDbType = SqlDbType.Char;
            ParACFdiferencia.Value = acfTRNt_terrenodetalle.ACFdiferencia;
            SqlCmd.Parameters.Add(ParACFdiferencia);
            //
            SqlParameter ParACFDifTemDedu = new SqlParameter();
            ParACFDifTemDedu.ParameterName = "@sACFDifTemDedu";
            ParACFDifTemDedu.SqlDbType = SqlDbType.Char;
            ParACFDifTemDedu.Value = acfTRNt_terrenodetalle.ACFDifTemDedu;
            SqlCmd.Parameters.Add(ParACFDifTemDedu);
            //
            SqlParameter ParACFDifTemGrav = new SqlParameter();
            ParACFDifTemGrav.ParameterName = "@sACFDifTemGrav";
            ParACFDifTemGrav.SqlDbType = SqlDbType.Char;
            ParACFDifTemGrav.Value = acfTRNt_terrenodetalle.ACFDifTemGrav;
            SqlCmd.Parameters.Add(ParACFDifTemGrav);
            //
            SqlParameter ParACFTasaIR = new SqlParameter();
            ParACFTasaIR.ParameterName = "@sACFTasaIR";
            ParACFTasaIR.SqlDbType = SqlDbType.Char;
            ParACFTasaIR.Value = acfTRNt_terrenodetalle.ACFTasaIR;
            SqlCmd.Parameters.Add(ParACFTasaIR);
            //
            SqlParameter ParACFSaldoDeducible = new SqlParameter();
            ParACFSaldoDeducible.ParameterName = "@sACFSaldoDeducible";
            ParACFSaldoDeducible.SqlDbType = SqlDbType.Char;
            ParACFSaldoDeducible.Value = acfTRNt_terrenodetalle.ACFSaldoDeducible;
            SqlCmd.Parameters.Add(ParACFSaldoDeducible);
            //
            SqlParameter ParACFSaldoGravable = new SqlParameter();
            ParACFSaldoGravable.ParameterName = "@sACFSaldoGravable";
            ParACFSaldoGravable.SqlDbType = SqlDbType.Char;
            ParACFSaldoGravable.Value = acfTRNt_terrenodetalle.ACFSaldoGravable;
            SqlCmd.Parameters.Add(ParACFSaldoGravable);
            //
            SqlParameter ParRVAcodigo = new SqlParameter();
            ParRVAcodigo.ParameterName = "@sRVAcodigo";
            ParRVAcodigo.SqlDbType = SqlDbType.Char;
            ParRVAcodigo.Value = acfTRNt_terrenodetalle.RVAcodigo;
            SqlCmd.Parameters.Add(ParRVAcodigo);
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
    public string Eliminar(DAcfTRNt_terrenodetalle acfTRNt_terrenodetalle)
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
            SqlCmd.CommandText = "usp_D_acfTRNt_terrenodetalle";
            SqlCmd.CommandType = CommandType.StoredProcedure;
            //
            SqlParameter ParRVAcodigo = new SqlParameter();
            ParRVAcodigo.ParameterName = "@sRVAcodigo";
            ParRVAcodigo.SqlDbType = SqlDbType.Char;
            ParRVAcodigo.Value = acfTRNt_terrenodetalle.RVAcodigo;
            SqlCmd.Parameters.Add(ParRVAcodigo);
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

    public DataTable Buscar(string ACFid)
    {

        DataTable DtResultado = new DataTable("acfTRNt_terrenodetalle");
        SqlConnection SqlCon = new SqlConnection();


        try
        {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_acfTRNt_terrenodetalle";
            SqlCmd.CommandType = CommandType.StoredProcedure;



            SqlParameter ParRVAcodigo = new SqlParameter();
            ParRVAcodigo.ParameterName = "@sACFid";
            ParRVAcodigo.SqlDbType = SqlDbType.Char;
            ParRVAcodigo.Value = ACFid;
            SqlCmd.Parameters.Add(ParRVAcodigo);

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
