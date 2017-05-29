using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DMovimiento_Transferencia_Activo{

        private string iMVPid_proceso;
        private string mMVPtipo;
        private string mMVPid_movimiento;
        private string mMVPds_movimiento;
        private string mMVPid_motivo;
        private string mMVPds_motivo;
        private string mMVPfecha_movimiento;
        private string mORGid_empresa;
        private string mORGds_empresa;
        private string mORGid_zona;
        private string mORGds_zona;
        private string mORGid_crp;
        private string mORGcrp;
        private string mORGds_crp;
        private string mORGid_ambiente;
        private string mORGds_ambiente;
        private string mORGid_persona;
        private string mORGds_persona;
        private string mORGid_usuario;
        private string mORGds_usuario;
        private string mORGid_sistelec;
        private string mORGds_sistelec;
        private string mORGid_set;
        private string mORGds_set;
        private string mORGid_alimentador;
        private string mORGds_alimentador;
        private string mORGid_sed;
        private string mORGds_sed;
        private string mORGid_circuito;
        private string mORGds_circuito;
        private string mORGposte_inicio;
        private string mORGds_poste_inicio;
        private string mORGposte_fin;
        private string mORGds_poste_fin;
        private string mORGlinea_at;
        private string mORGpunto_inicio;
        private string mORGpunto_fin;
        private string mORGid_activopadre;
        private string mORGds_activopadre;
        private string mDSTid_empresa;
        private string mDSTds_empresa;
        private string mDSTid_zona;
        private string mDSTds_zona;
        private string mDSTid_crp;
        private string mDSTcrp;
        private string mDSTds_crp;
        private string mDSTid_ambiente;
        private string mDSTds_ambiente;
        private string mDSTid_persona;
        private string mDSTds_persona;
        private string mDSTid_usuario;
        private string mDSTds_usuario;
        private string mDSTid_sistelec;
        private string mDSTds_sistelec;
        private string mDSTid_set;
        private string mDSTds_set;
        private string mDSTid_alimentador;
        private string mDSTds_alimentador;
        private string mDSTid_sed;
        private string mDSTds_sed;
        private string mDSTid_circuito;
        private string mDSTds_circuito;
        private string mDSTposte_inicio;
        private string mDSTds_poste_inicio;
        private string mDSTposte_fin;
        private string mDSTds_poste_fin;
        private string mDSTlinea_at;
        private string mDSTpunto_inicio;
        private string mDSTpunto_fin;
        private string mDSTid_activopadre;
        private string mDSTds_activopadre;
        private string mMVPobservaciones;
        private string mMVPdefinitivo;
        private string mMVPfecha_fin;
        private string mMVPusuario_sistemas;
        private string mMVPaprueba_sistemas;
        private string mMVPfecha_sistemas;
        private string mMVPusuario_patrimonio;
        private string mMVPaprueba_patrimonio;
        private string mMVPfecha_patrimonio;
        private string mMVPretorno;
        private string mMVPusuario_retorno;
        private string mMVPfecha_retorno;
        private string mMVPusuario_registro;
        private string mMVPfecha_registro;

        public string MVPid_proceso
        {
            get { return iMVPid_proceso; }
            set { iMVPid_proceso = value; }
        }
        public string MVPtipo
        {
            get { return mMVPtipo; }
            set { mMVPtipo = value; }
        }
        public string MVPid_movimiento
        {
            get { return mMVPid_movimiento; }
            set { mMVPid_movimiento = value; }
        }
        public string MVPds_movimiento
        {
            get { return mMVPds_movimiento; }
            set { mMVPds_movimiento = value; }
        }
        public string MVPid_motivo
        {
            get { return mMVPid_motivo; }
            set { mMVPid_motivo = value; }
        }
        public string MVPds_motivo
        {
            get { return mMVPds_motivo; }
            set { mMVPds_motivo = value; }
        }
        public string MVPfecha_movimiento
        {
            get { return mMVPfecha_movimiento; }
            set { mMVPfecha_movimiento = value; }
        }
        public string ORGid_empresa
        {
            get { return mORGid_empresa; }
            set { mORGid_empresa = value; }
        }
        public string ORGds_empresa
        {
            get { return mORGds_empresa; }
            set { mORGds_empresa = value; }
        }
        public string ORGid_zona
        {
            get { return mORGid_zona; }
            set { mORGid_zona = value; }
        }
        public string ORGds_zona
        {
            get { return mORGds_zona; }
            set { mORGds_zona = value; }
        }
        public string ORGid_crp
        {
            get { return mORGid_crp; }
            set { mORGid_crp = value; }
        }
        public string ORGcrp
        {
            get { return mORGcrp; }
            set { mORGcrp = value; }
        }
        public string ORGds_crp
        {
            get { return mORGds_crp; }
            set { mORGds_crp = value; }
        }
        public string ORGid_ambiente
        {
            get { return mORGid_ambiente; }
            set { mORGid_ambiente = value; }
        }
        public string ORGds_ambiente
        {
            get { return mORGds_ambiente; }
            set { mORGds_ambiente = value; }
        }
        public string ORGid_persona
        {
            get { return mORGid_persona; }
            set { mORGid_persona = value; }
        }
        public string ORGds_persona
        {
            get { return mORGds_persona; }
            set { mORGds_persona = value; }
        }
        public string ORGid_usuario
        {
            get { return mORGid_usuario; }
            set { mORGid_usuario = value; }
        }
        public string ORGds_usuario
        {
            get { return mORGds_usuario; }
            set { mORGds_usuario = value; }
        }
        public string ORGid_sistelec
        {
            get { return mORGid_sistelec; }
            set { mORGid_sistelec = value; }
        }
        public string ORGds_sistelec
        {
            get { return mORGds_sistelec; }
            set { mORGds_sistelec = value; }
        }
        public string ORGid_set
        {
            get { return mORGid_set; }
            set { mORGid_set = value; }
        }
        public string ORGds_set
        {
            get { return mORGds_set; }
            set { mORGds_set = value; }
        }
        public string ORGid_alimentador
        {
            get { return mORGid_alimentador; }
            set { mORGid_alimentador = value; }
        }
        public string ORGds_alimentador
        {
            get { return mORGds_alimentador; }
            set { mORGds_alimentador = value; }
        }
        public string ORGid_sed
        {
            get { return mORGid_sed; }
            set { mORGid_sed = value; }
        }
        public string ORGds_sed
        {
            get { return mORGds_sed; }
            set { mORGds_sed = value; }
        }
        public string ORGid_circuito
        {
            get { return mORGid_circuito; }
            set { mORGid_circuito = value; }
        }
        public string ORGds_circuito
        {
            get { return mORGds_circuito; }
            set { mORGds_circuito = value; }
        }
        public string ORGposte_inicio
        {
            get { return mORGposte_inicio; }
            set { mORGposte_inicio = value; }
        }
        public string ORGds_poste_inicio
        {
            get { return mORGds_poste_inicio; }
            set { mORGds_poste_inicio = value; }
        }
        public string ORGposte_fin
        {
            get { return mORGposte_fin; }
            set { mORGposte_fin = value; }
        }
        public string ORGds_poste_fin
        {
            get { return mORGds_poste_fin; }
            set { mORGds_poste_fin = value; }
        }
        public string ORGlinea_at
        {
            get { return mORGlinea_at; }
            set { mORGlinea_at = value; }
        }
        public string ORGpunto_inicio
        {
            get { return mORGpunto_inicio; }
            set { mORGpunto_inicio = value; }
        }
        public string ORGpunto_fin
        {
            get { return mORGpunto_fin; }
            set { mORGpunto_fin = value; }
        }
        public string ORGid_activopadre
        {
            get { return mORGid_activopadre; }
            set { mORGid_activopadre = value; }
        }

        public string ORGds_activopadre
        {
            get { return mORGds_activopadre; }
            set { mORGds_activopadre = value; }
        }
        public string DSTid_empresa
        {
            get { return mDSTid_empresa; }
            set { mDSTid_empresa = value; }
        }
        public string DSTds_empresa
        {
            get { return mDSTds_empresa; }
            set { mDSTds_empresa = value; }
        }
        public string DSTid_zona
        {
            get { return mDSTid_zona; }
            set { mDSTid_zona = value; }
        }
        public string DSTds_zona
        {
            get { return mDSTds_zona; }
            set { mDSTds_zona = value; }
        }
        public string DSTid_crp
        {
            get { return mDSTid_crp; }
            set { mDSTid_crp = value; }
        }
        public string DSTcrp
        {
            get { return mDSTcrp; }
            set { mDSTcrp = value; }
        }
        public string DSTds_crp
        {
            get { return mDSTds_crp; }
            set { mDSTds_crp = value; }
        }
        public string DSTid_ambiente
        {
            get { return mDSTid_ambiente; }
            set { mDSTid_ambiente = value; }
        }
        public string DSTds_ambiente
        {
            get { return mDSTds_ambiente; }
            set { mDSTds_ambiente = value; }
        }
        public string DSTid_persona
        {
            get { return mDSTid_persona; }
            set { mDSTid_persona = value; }
        }
        public string DSTds_persona
        {
            get { return mDSTds_persona; }
            set { mDSTds_persona = value; }
        }
        public string DSTid_usuario
        {
            get { return mDSTid_usuario; }
            set { mDSTid_usuario = value; }
        }
        public string DSTds_usuario
        {
            get { return mDSTds_usuario; }
            set { mDSTds_usuario = value; }
        }
        public string DSTid_sistelec
        {
            get { return mDSTid_sistelec; }
            set { mDSTid_sistelec = value; }
        }
        public string DSTds_sistelec
        {
            get { return mDSTds_sistelec; }
            set { mDSTds_sistelec = value; }
        }
        public string DSTid_set
        {
            get { return mDSTid_set; }
            set { mDSTid_set = value; }
        }
        public string DSTds_set
        {
            get { return mDSTds_set; }
            set { mDSTds_set = value; }
        }
        public string DSTid_alimentador
        {
            get { return mDSTid_alimentador; }
            set { mDSTid_alimentador = value; }
        }
        public string DSTds_alimentador
        {
            get { return mDSTds_alimentador; }
            set { mDSTds_alimentador = value; }
        }
        public string DSTid_sed
        {
            get { return mDSTid_sed; }
            set { mDSTid_sed = value; }
        }
        public string DSTds_sed
        {
            get { return mDSTds_sed; }
            set { mDSTds_sed = value; }
        }
        public string DSTid_circuito
        {
            get { return mDSTid_circuito; }
            set { mDSTid_circuito = value; }
        }
        public string DSTds_circuito
        {
            get { return mDSTds_circuito; }
            set { mDSTds_circuito = value; }
        }
        public string DSTposte_inicio
        {
            get { return mDSTposte_inicio; }
            set { mDSTposte_inicio = value; }
        }
        public string DSTds_poste_inicio
        {
            get { return mDSTds_poste_inicio; }
            set { mDSTds_poste_inicio = value; }
        }
        public string DSTposte_fin
        {
            get { return mDSTposte_fin; }
            set { mDSTposte_fin = value; }
        }
        public string DSTds_poste_fin
        {
            get { return mDSTds_poste_fin; }
            set { mDSTds_poste_fin = value; }
        }
        public string DSTlinea_at
        {
            get { return mDSTlinea_at; }
            set { mDSTlinea_at = value; }
        }
        public string DSTpunto_inicio
        {
            get { return mDSTpunto_inicio; }
            set { mDSTpunto_inicio = value; }
        }
        public string DSTpunto_fin
        {
            get { return mDSTpunto_fin; }
            set { mDSTpunto_fin = value; }
        }
        public string DSTid_activopadre
        {
            get { return mDSTid_activopadre; }
            set { mDSTid_activopadre = value; }
        }
        public string DSTds_activopadre
        {
            get { return mDSTds_activopadre; }
            set { mDSTds_activopadre = value; }
        }
        public string MVPobservaciones
        {
            get { return mMVPobservaciones; }
            set { mMVPobservaciones = value; }
        }
        public string MVPdefinitivo
        {
            get { return mMVPdefinitivo; }
            set { mMVPdefinitivo = value; }
        }
        public string MVPfecha_fin
        {
            get { return mMVPfecha_fin; }
            set { mMVPfecha_fin = value; }
        }
        public string MVPusuario_sistemas
        {
            get { return mMVPusuario_sistemas; }
            set { mMVPusuario_sistemas = value; }
        }
        public string MVPaprueba_sistemas
        {
            get { return mMVPaprueba_sistemas; }
            set { mMVPaprueba_sistemas = value; }
        }
        public string MVPfecha_sistemas
        {
            get { return mMVPfecha_sistemas; }
            set { mMVPfecha_sistemas = value; }
        }
        public string MVPusuario_patrimonio
        {
            get { return mMVPusuario_patrimonio; }
            set { mMVPusuario_patrimonio = value; }
        }
        public string MVPaprueba_patrimonio
        {
            get { return mMVPaprueba_patrimonio; }
            set { mMVPaprueba_patrimonio = value; }
        }
        public string MVPfecha_patrimonio
        {
            get { return mMVPfecha_patrimonio; }
            set { mMVPfecha_patrimonio = value; }
        }
        public string MVPretorno
        {
            get { return mMVPretorno; }
            set { mMVPretorno = value; }
        }
        public string MVPusuario_retorno
        {
            get { return mMVPusuario_retorno; }
            set { mMVPusuario_retorno = value; }
        }
        public string MVPfecha_retorno
        {
            get { return mMVPfecha_retorno; }
            set { mMVPfecha_retorno = value; }
        }
        public string MVPusuario_registro
        {
            get { return mMVPusuario_registro; }
            set { mMVPusuario_registro = value; }
        }
        public string MVPfecha_registro
        {
            get { return mMVPfecha_registro; }
            set { mMVPfecha_registro = value; }
        }

        //Constructor vacío
	public DMovimiento_Transferencia_Activo(){
	}
        //Constructor con parámetros
	public DMovimiento_Transferencia_Activo(
        string MVPid_proceso,
        string MVPtipo,
        string MVPid_movimiento,
        string MVPds_movimiento,
        string MVPid_motivo,
        string MVPds_motivo,
        string MVPfecha_movimiento,
        string ORGid_empresa,
        string ORGds_empresa,
        string ORGid_zona,
        string ORGds_zona,
        string ORGid_crp,
        string ORGcrp,
        string ORGds_crp,
        string ORGid_ambiente,
        string ORGds_ambiente,
        string ORGid_persona,
        string ORGds_persona,
        string ORGid_usuario,
        string ORGds_usuario,
        string ORGid_sistelec,
        string ORGds_sistelec,
        string ORGid_set,
        string ORGds_set,
        string ORGid_alimentador,
        string ORGds_alimentador,
        string ORGid_sed,
        string ORGds_sed,
        string ORGid_circuito,
        string ORGds_circuito,
        string ORGposte_inicio,
        string ORGds_poste_inicio,
        string ORGposte_fin,
        string ORGds_poste_fin,
        string ORGlinea_at,
        string ORGpunto_inicio,
        string ORGpunto_fin,
        string ORGid_activopadre,
        string ORGds_activopadre,
        string DSTid_empresa,
        string DSTds_empresa,
        string DSTid_zona,
        string DSTds_zona,
        string DSTid_crp,
        string DSTcrp,
        string DSTds_crp,
        string DSTid_ambiente,
        string DSTds_ambiente,
        string DSTid_persona,
        string DSTds_persona,
        string DSTid_usuario,
        string DSTds_usuario,
        string DSTid_sistelec,
        string DSTds_sistelec,
        string DSTid_set,
        string DSTds_set,
        string DSTid_alimentador,
        string DSTds_alimentador,
        string DSTid_sed,
        string DSTds_sed,
        string DSTid_circuito,
        string DSTds_circuito,
        string DSTposte_inicio,
        string DSTds_poste_inicio,
        string DSTposte_fin,
        string DSTds_poste_fin,
        string DSTlinea_at,
        string DSTpunto_inicio,
        string DSTpunto_fin,
        string DSTid_activopadre,
        string DSTds_activopadre,
        string MVPobservaciones,
        string MVPdefinitivo,
        string MVPfecha_fin,
        string MVPusuario_sistemas,
        string MVPaprueba_sistemas,
        string MVPfecha_sistemas,
        string MVPusuario_patrimonio,
        string MVPaprueba_patrimonio,
        string MVPfecha_patrimonio,
        string MVPretorno,
        string MVPusuario_retorno,
        string MVPfecha_retorno,
        string MVPusuario_registro,
        string MVPfecha_registro
        )
    {

        this.iMVPid_proceso = MVPid_proceso;
        this.mMVPtipo = MVPtipo;
        this.mMVPid_movimiento = MVPid_movimiento;
        this.mMVPds_movimiento = MVPds_movimiento;
        this.mMVPid_motivo = MVPid_motivo;
        this.mMVPds_motivo = MVPds_motivo;
        this.mMVPfecha_movimiento = MVPfecha_movimiento;
        this.mORGid_empresa = ORGid_empresa;
        this.mORGds_empresa = ORGds_empresa;
        this.mORGid_zona = ORGid_zona;
        this.mORGds_zona = ORGds_zona;
        this.mORGid_crp = ORGid_crp;
        this.mORGcrp = ORGcrp;
        this.mORGds_crp = ORGds_crp;
        this.mORGid_ambiente = ORGid_ambiente;
        this.mORGds_ambiente = ORGds_ambiente;
        this.mORGid_persona = ORGid_persona;
        this.mORGds_persona = ORGds_persona;
        this.mORGid_usuario = ORGid_usuario;
        this.mORGds_usuario = ORGds_usuario;
        this.mORGid_sistelec = ORGid_sistelec;
        this.mORGds_sistelec = ORGds_sistelec;
        this.mORGid_set = ORGid_set;
        this.mORGds_set = ORGds_set;
        this.mORGid_alimentador = ORGid_alimentador;
        this.mORGds_alimentador = ORGds_alimentador;
        this.mORGid_sed = ORGid_sed;
        this.mORGds_sed = ORGds_sed;
        this.mORGid_circuito = ORGid_circuito;
        this.mORGds_circuito = ORGds_circuito;
        this.mORGposte_inicio = ORGposte_inicio;
        this.mORGds_poste_inicio = ORGds_poste_inicio;
        this.mORGposte_fin = ORGposte_fin;
        this.mORGds_poste_fin = ORGds_poste_fin;
        this.mORGlinea_at = ORGlinea_at;
        this.mORGpunto_inicio = ORGpunto_inicio;
        this.mORGpunto_fin = ORGpunto_fin;
        this.mORGid_activopadre = ORGid_activopadre;
        this.mORGds_activopadre = ORGds_activopadre;
        this.mDSTid_empresa = DSTid_empresa;
        this.mDSTds_empresa = DSTds_empresa;
        this.mDSTid_zona = DSTid_zona;
        this.mDSTds_zona = DSTds_zona;
        this.mDSTid_crp = DSTid_crp;
        this.mDSTcrp = DSTcrp;
        this.mDSTds_crp = DSTds_crp;
        this.mDSTid_ambiente = DSTid_ambiente;
        this.mDSTds_ambiente = DSTds_ambiente;
        this.mDSTid_persona = DSTid_persona;
        this.mDSTds_persona = DSTds_persona;
        this.mDSTid_usuario = DSTid_usuario;
        this.mDSTds_usuario = DSTds_usuario;
        this.mDSTid_sistelec = DSTid_sistelec;
        this.mDSTds_sistelec = DSTds_sistelec;
        this.mDSTid_set = DSTid_set;
        this.mDSTds_set = DSTds_set;
        this.mDSTid_alimentador = DSTid_alimentador;
        this.mDSTds_alimentador = DSTds_alimentador;
        this.mDSTid_sed = DSTid_sed;
        this.mDSTds_sed = DSTds_sed;
        this.mDSTid_circuito = DSTid_circuito;
        this.mDSTds_circuito = DSTds_circuito;
        this.mDSTposte_inicio = DSTposte_inicio;
        this.mDSTds_poste_inicio = DSTds_poste_inicio;
        this.mDSTposte_fin = DSTposte_fin;
        this.mDSTds_poste_fin = DSTds_poste_fin;
        this.mDSTlinea_at = DSTlinea_at;
        this.mDSTpunto_inicio = DSTpunto_inicio;
        this.mDSTpunto_fin = DSTpunto_fin;
        this.mDSTid_activopadre = DSTid_activopadre;
        this.mDSTds_activopadre = DSTds_activopadre;
        this.mMVPobservaciones = MVPobservaciones;
        this.mMVPdefinitivo = MVPdefinitivo;
        this.mMVPfecha_fin = MVPfecha_fin;
        this.mMVPusuario_sistemas = MVPusuario_sistemas;
        this.mMVPaprueba_sistemas = MVPaprueba_sistemas;
        this.mMVPfecha_sistemas = MVPfecha_sistemas;
        this.mMVPusuario_patrimonio = MVPusuario_patrimonio;
        this.mMVPaprueba_patrimonio = MVPaprueba_patrimonio;
        this.mMVPfecha_patrimonio = MVPfecha_patrimonio;
        this.mMVPretorno = MVPretorno;
        this.mMVPusuario_retorno = MVPusuario_retorno;
        this.mMVPfecha_retorno = MVPfecha_retorno;
        this.mMVPusuario_registro = MVPusuario_registro;
        this.mMVPfecha_registro = MVPfecha_registro;
	}

        /*	public object Clone() {
        //		return base.MemberwiseClone();
        //	}
        */

        //METODO MOSTRAR 
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("acfCMVp_Cabecera_Movimiento");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfCMVp_Cabecera_Movimiento";
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

        //METODO MOSTRAR 2
        public DataTable Mostrar2()
        {
            DataTable DtResultado = new DataTable("acfCMVp_Cabecera_Movimiento");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfCMVp_Cabecera_Movimiento2";
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
        public string Insertar(DMovimiento_Transferencia_Activo acfCMVp_Cabecera_Movimiento)
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
                SqlCmd.CommandText = "usp_I_acfCMVp_Cabecera_Movimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter PariMVPid_proceso = new SqlParameter();
                PariMVPid_proceso.ParameterName = "@iMVPid_proceso";
                PariMVPid_proceso.SqlDbType = SqlDbType.Int;
                PariMVPid_proceso.Value = acfCMVp_Cabecera_Movimiento.MVPid_proceso;
                SqlCmd.Parameters.Add(PariMVPid_proceso);

                SqlParameter ParmMVPtipo = new SqlParameter();
                ParmMVPtipo.ParameterName = "@mMVPtipo";
                ParmMVPtipo.SqlDbType = SqlDbType.Char;
                ParmMVPtipo.Value = acfCMVp_Cabecera_Movimiento.MVPtipo;
                SqlCmd.Parameters.Add(ParmMVPtipo);

                SqlParameter ParmMVPds_movimiento = new SqlParameter();
                ParmMVPds_movimiento.ParameterName = "@mMVPds_movimiento";
                ParmMVPds_movimiento.SqlDbType = SqlDbType.VarChar;
                ParmMVPds_movimiento.Value = acfCMVp_Cabecera_Movimiento.MVPds_movimiento;
                SqlCmd.Parameters.Add(ParmMVPds_movimiento);

                SqlParameter ParmMVPfecha_movimiento = new SqlParameter();
                ParmMVPfecha_movimiento.ParameterName = "@mMVPfecha_movimiento";
                ParmMVPfecha_movimiento.SqlDbType = SqlDbType.DateTime;
                ParmMVPfecha_movimiento.Value = acfCMVp_Cabecera_Movimiento.MVPfecha_movimiento;
                SqlCmd.Parameters.Add(ParmMVPfecha_movimiento);

                SqlParameter ParmORGid_persona = new SqlParameter();
                ParmORGid_persona.ParameterName = "@mORGid_persona";
                ParmORGid_persona.SqlDbType = SqlDbType.Char;
                ParmORGid_persona.Value = acfCMVp_Cabecera_Movimiento.ORGid_persona;
                SqlCmd.Parameters.Add(ParmORGid_persona);

                SqlParameter ParmORGds_persona = new SqlParameter();
                ParmORGds_persona.ParameterName = "@mORGds_persona";
                ParmORGds_persona.SqlDbType = SqlDbType.VarChar;
                ParmORGds_persona.Value = acfCMVp_Cabecera_Movimiento.ORGds_persona;
                SqlCmd.Parameters.Add(ParmORGds_persona);

                SqlParameter mORGid_zona = new SqlParameter();
                mORGid_zona.ParameterName = "@mORGid_zona";
                mORGid_zona.SqlDbType = SqlDbType.Char;
                mORGid_zona.Value = acfCMVp_Cabecera_Movimiento.ORGid_zona;
                SqlCmd.Parameters.Add(mORGid_zona);

                SqlParameter mORGds_zona = new SqlParameter();
                mORGds_zona.ParameterName = "@mORGds_zona";
                mORGds_zona.SqlDbType = SqlDbType.VarChar;
                mORGds_zona.Value = acfCMVp_Cabecera_Movimiento.ORGds_zona;
                SqlCmd.Parameters.Add(mORGds_zona);

                SqlParameter ParmORGcrp = new SqlParameter();
                ParmORGcrp.ParameterName = "@mORGcrp";
                ParmORGcrp.SqlDbType = SqlDbType.Char;
                ParmORGcrp.Value = acfCMVp_Cabecera_Movimiento.ORGcrp;
                SqlCmd.Parameters.Add(ParmORGcrp);

                SqlParameter ParmORGds_crp = new SqlParameter();
                ParmORGds_crp.ParameterName = "@mORGds_crp";
                ParmORGds_crp.SqlDbType = SqlDbType.VarChar;
                ParmORGds_crp.Value = acfCMVp_Cabecera_Movimiento.ORGds_crp;
                SqlCmd.Parameters.Add(ParmORGds_crp);

                SqlParameter ParmORGid_usuario = new SqlParameter();
                ParmORGid_usuario.ParameterName = "@mORGid_usuario";
                ParmORGid_usuario.SqlDbType = SqlDbType.VarChar;
                ParmORGid_usuario.Value = acfCMVp_Cabecera_Movimiento.ORGid_usuario;
                SqlCmd.Parameters.Add(ParmORGid_usuario);

                SqlParameter ParmORGds_usuario = new SqlParameter();
                ParmORGds_usuario.ParameterName = "@mORGds_usuario";
                ParmORGds_usuario.SqlDbType = SqlDbType.VarChar;
                ParmORGds_usuario.Value = acfCMVp_Cabecera_Movimiento.mORGds_usuario;
                SqlCmd.Parameters.Add(ParmORGds_usuario);

                SqlParameter ParmORGid_ambiente = new SqlParameter();
                ParmORGid_ambiente.ParameterName = "@mORGid_ambiente";
                ParmORGid_ambiente.SqlDbType = SqlDbType.Char;
                ParmORGid_ambiente.Value = acfCMVp_Cabecera_Movimiento.ORGid_ambiente;
                SqlCmd.Parameters.Add(ParmORGid_ambiente);

                SqlParameter ParmORGds_ambiente = new SqlParameter();
                ParmORGds_ambiente.ParameterName = "@mORGds_ambiente";
                ParmORGds_ambiente.SqlDbType = SqlDbType.VarChar;
                ParmORGds_ambiente.Value = acfCMVp_Cabecera_Movimiento.ORGds_ambiente;
                SqlCmd.Parameters.Add(ParmORGds_ambiente);

                SqlParameter ParmDSTid_persona = new SqlParameter();
                ParmDSTid_persona.ParameterName = "@mDSTid_persona";
                ParmDSTid_persona.SqlDbType = SqlDbType.VarChar;
                ParmDSTid_persona.Value = acfCMVp_Cabecera_Movimiento.DSTid_persona;
                SqlCmd.Parameters.Add(ParmDSTid_persona);

                SqlParameter ParmDSTds_persona = new SqlParameter();
                ParmDSTds_persona.ParameterName = "@mDSTds_persona";
                ParmDSTds_persona.SqlDbType = SqlDbType.VarChar;
                ParmDSTds_persona.Value = acfCMVp_Cabecera_Movimiento.DSTds_persona;
                SqlCmd.Parameters.Add(ParmDSTds_persona);

                SqlParameter ParmDSTid_zona = new SqlParameter();
                ParmDSTid_zona.ParameterName = "@mDSTid_zona";
                ParmDSTid_zona.SqlDbType = SqlDbType.Char;
                ParmDSTid_zona.Value = acfCMVp_Cabecera_Movimiento.DSTid_zona;
                SqlCmd.Parameters.Add(ParmDSTid_zona);

                SqlParameter ParmDSTds_zona = new SqlParameter();
                ParmDSTds_zona.ParameterName = "@mDSTds_zona";
                ParmDSTds_zona.SqlDbType = SqlDbType.VarChar;
                ParmDSTds_zona.Value = acfCMVp_Cabecera_Movimiento.DSTds_zona;
                SqlCmd.Parameters.Add(ParmDSTds_zona);

                SqlParameter ParmDSTcrp = new SqlParameter();
                ParmDSTcrp.ParameterName = "@mDSTcrp";
                ParmDSTcrp.SqlDbType = SqlDbType.VarChar;
                ParmDSTcrp.Value = acfCMVp_Cabecera_Movimiento.DSTcrp;
                SqlCmd.Parameters.Add(ParmDSTcrp);

                SqlParameter ParmDSTds_crp = new SqlParameter();
                ParmDSTds_crp.ParameterName = "@mDSTds_crp";
                ParmDSTds_crp.SqlDbType = SqlDbType.VarChar;
                ParmDSTds_crp.Value = acfCMVp_Cabecera_Movimiento.DSTds_crp;
                SqlCmd.Parameters.Add(ParmDSTds_crp);

                SqlParameter ParmDSTid_usuario = new SqlParameter();
                ParmDSTid_usuario.ParameterName = "@mDSTid_usuario";
                ParmDSTid_usuario.SqlDbType = SqlDbType.VarChar;
                ParmDSTid_usuario.Value = acfCMVp_Cabecera_Movimiento.DSTid_usuario;
                SqlCmd.Parameters.Add(ParmDSTid_usuario);

                SqlParameter ParmDSTds_usuario = new SqlParameter();
                ParmDSTds_usuario.ParameterName = "@mDSTds_usuario";
                ParmDSTds_usuario.SqlDbType = SqlDbType.VarChar;
                ParmDSTds_usuario.Value = acfCMVp_Cabecera_Movimiento.DSTds_usuario;
                SqlCmd.Parameters.Add(ParmDSTds_usuario);

                SqlParameter ParmDSTid_ambiente = new SqlParameter();
                ParmDSTid_ambiente.ParameterName = "@mDSTid_ambiente";
                ParmDSTid_ambiente.SqlDbType = SqlDbType.Char;
                ParmDSTid_ambiente.Value = acfCMVp_Cabecera_Movimiento.DSTid_ambiente;
                SqlCmd.Parameters.Add(ParmDSTid_ambiente);

                SqlParameter ParmDSTds_ambiente = new SqlParameter();
                ParmDSTds_ambiente.ParameterName = "@mDSTds_ambiente";
                ParmDSTds_ambiente.SqlDbType = SqlDbType.VarChar;
                ParmDSTds_ambiente.Value = acfCMVp_Cabecera_Movimiento.DSTds_ambiente;
                SqlCmd.Parameters.Add(ParmDSTds_ambiente);

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
	public string Editar(DMovimiento_Transferencia_Activo acfCMVp_Cabecera_Movimiento) {
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
                SqlCmd.CommandText = "usp_U_acfCMVp_Cabecera_Movimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter PariMVPid_proceso = new SqlParameter();
                PariMVPid_proceso.ParameterName = "@iMVPid_proceso";
                PariMVPid_proceso.SqlDbType = SqlDbType.Int;
                PariMVPid_proceso.Value = acfCMVp_Cabecera_Movimiento.MVPid_proceso;
                SqlCmd.Parameters.Add(PariMVPid_proceso);

                SqlParameter ParmMVPtipo = new SqlParameter();
                ParmMVPtipo.ParameterName = "@mMVPtipo";
                ParmMVPtipo.SqlDbType = SqlDbType.Char;
                ParmMVPtipo.Value = acfCMVp_Cabecera_Movimiento.MVPtipo;
                SqlCmd.Parameters.Add(ParmMVPtipo);

                SqlParameter ParmMVPds_movimiento = new SqlParameter();
                ParmMVPds_movimiento.ParameterName = "@mMVPds_movimiento";
                ParmMVPds_movimiento.SqlDbType = SqlDbType.VarChar;
                ParmMVPds_movimiento.Value = acfCMVp_Cabecera_Movimiento.MVPds_movimiento;
                SqlCmd.Parameters.Add(ParmMVPds_movimiento);

                SqlParameter ParmMVPfecha_movimiento = new SqlParameter();
                ParmMVPfecha_movimiento.ParameterName = "@mMVPfecha_movimiento";
                ParmMVPfecha_movimiento.SqlDbType = SqlDbType.DateTime;
                ParmMVPfecha_movimiento.Value = acfCMVp_Cabecera_Movimiento.MVPfecha_movimiento;
                SqlCmd.Parameters.Add(ParmMVPfecha_movimiento);

                SqlParameter ParmORGid_persona = new SqlParameter();
                ParmORGid_persona.ParameterName = "@mORGid_persona";
                ParmORGid_persona.SqlDbType = SqlDbType.Char;
                ParmORGid_persona.Value = acfCMVp_Cabecera_Movimiento.ORGid_persona;
                SqlCmd.Parameters.Add(ParmORGid_persona);

                SqlParameter ParmORGds_persona = new SqlParameter();
                ParmORGds_persona.ParameterName = "@mORGds_persona";
                ParmORGds_persona.SqlDbType = SqlDbType.VarChar;
                ParmORGds_persona.Value = acfCMVp_Cabecera_Movimiento.ORGds_persona;
                SqlCmd.Parameters.Add(ParmORGds_persona);

                SqlParameter mORGid_zona = new SqlParameter();
                mORGid_zona.ParameterName = "@mORGid_zona";
                mORGid_zona.SqlDbType = SqlDbType.Char;
                mORGid_zona.Value = acfCMVp_Cabecera_Movimiento.ORGid_zona;
                SqlCmd.Parameters.Add(mORGid_zona);

                SqlParameter mORGds_zona = new SqlParameter();
                mORGds_zona.ParameterName = "@mORGds_zona";
                mORGds_zona.SqlDbType = SqlDbType.VarChar;
                mORGds_zona.Value = acfCMVp_Cabecera_Movimiento.ORGds_zona;
                SqlCmd.Parameters.Add(mORGds_zona);

                SqlParameter ParmORGcrp = new SqlParameter();
                ParmORGcrp.ParameterName = "@mORGcrp";
                ParmORGcrp.SqlDbType = SqlDbType.Char;
                ParmORGcrp.Value = acfCMVp_Cabecera_Movimiento.ORGcrp;
                SqlCmd.Parameters.Add(ParmORGcrp);

                SqlParameter ParmORGds_crp = new SqlParameter();
                ParmORGds_crp.ParameterName = "@mORGds_crp";
                ParmORGds_crp.SqlDbType = SqlDbType.VarChar;
                ParmORGds_crp.Value = acfCMVp_Cabecera_Movimiento.ORGds_crp;
                SqlCmd.Parameters.Add(ParmORGds_crp);

                SqlParameter ParmORGid_usuario = new SqlParameter();
                ParmORGid_usuario.ParameterName = "@mORGid_usuario";
                ParmORGid_usuario.SqlDbType = SqlDbType.VarChar;
                ParmORGid_usuario.Value = acfCMVp_Cabecera_Movimiento.ORGid_usuario;
                SqlCmd.Parameters.Add(ParmORGid_usuario);

                SqlParameter ParmORGds_usuario = new SqlParameter();
                ParmORGds_usuario.ParameterName = "@mORGds_usuario";
                ParmORGds_usuario.SqlDbType = SqlDbType.VarChar;
                ParmORGds_usuario.Value = acfCMVp_Cabecera_Movimiento.mORGds_usuario;
                SqlCmd.Parameters.Add(ParmORGds_usuario);

                SqlParameter ParmORGid_ambiente = new SqlParameter();
                ParmORGid_ambiente.ParameterName = "@mORGid_ambiente";
                ParmORGid_ambiente.SqlDbType = SqlDbType.Char;
                ParmORGid_ambiente.Value = acfCMVp_Cabecera_Movimiento.ORGid_ambiente;
                SqlCmd.Parameters.Add(ParmORGid_ambiente);

                SqlParameter ParmORGds_ambiente = new SqlParameter();
                ParmORGds_ambiente.ParameterName = "@mORGds_ambiente";
                ParmORGds_ambiente.SqlDbType = SqlDbType.VarChar;
                ParmORGds_ambiente.Value = acfCMVp_Cabecera_Movimiento.ORGds_ambiente;
                SqlCmd.Parameters.Add(ParmORGds_ambiente);

                SqlParameter ParmDSTid_persona = new SqlParameter();
                ParmDSTid_persona.ParameterName = "@mDSTid_persona";
                ParmDSTid_persona.SqlDbType = SqlDbType.VarChar;
                ParmDSTid_persona.Value = acfCMVp_Cabecera_Movimiento.DSTid_persona;
                SqlCmd.Parameters.Add(ParmDSTid_persona);

                SqlParameter ParmDSTds_persona = new SqlParameter();
                ParmDSTds_persona.ParameterName = "@mDSTds_persona";
                ParmDSTds_persona.SqlDbType = SqlDbType.VarChar;
                ParmDSTds_persona.Value = acfCMVp_Cabecera_Movimiento.DSTds_persona;
                SqlCmd.Parameters.Add(ParmDSTds_persona);

                SqlParameter ParmDSTid_zona = new SqlParameter();
                ParmDSTid_zona.ParameterName = "@mDSTid_zona";
                ParmDSTid_zona.SqlDbType = SqlDbType.Char;
                ParmDSTid_zona.Value = acfCMVp_Cabecera_Movimiento.DSTid_zona;
                SqlCmd.Parameters.Add(ParmDSTid_zona);

                SqlParameter ParmDSTds_zona = new SqlParameter();
                ParmDSTds_zona.ParameterName = "@mDSTds_zona";
                ParmDSTds_zona.SqlDbType = SqlDbType.VarChar;
                ParmDSTds_zona.Value = acfCMVp_Cabecera_Movimiento.DSTds_zona;
                SqlCmd.Parameters.Add(ParmDSTds_zona);

                SqlParameter ParmDSTcrp = new SqlParameter();
                ParmDSTcrp.ParameterName = "@mDSTcrp";
                ParmDSTcrp.SqlDbType = SqlDbType.VarChar;
                ParmDSTcrp.Value = acfCMVp_Cabecera_Movimiento.DSTcrp;
                SqlCmd.Parameters.Add(ParmDSTcrp);

                SqlParameter ParmDSTds_crp = new SqlParameter();
                ParmDSTds_crp.ParameterName = "@mDSTds_crp";
                ParmDSTds_crp.SqlDbType = SqlDbType.VarChar;
                ParmDSTds_crp.Value = acfCMVp_Cabecera_Movimiento.DSTds_crp;
                SqlCmd.Parameters.Add(ParmDSTds_crp);

                SqlParameter ParmDSTid_usuario = new SqlParameter();
                ParmDSTid_usuario.ParameterName = "@mDSTid_usuario";
                ParmDSTid_usuario.SqlDbType = SqlDbType.VarChar;
                ParmDSTid_usuario.Value = acfCMVp_Cabecera_Movimiento.DSTid_usuario;
                SqlCmd.Parameters.Add(ParmDSTid_usuario);

                SqlParameter ParmDSTds_usuario = new SqlParameter();
                ParmDSTds_usuario.ParameterName = "@mDSTds_usuario";
                ParmDSTds_usuario.SqlDbType = SqlDbType.VarChar;
                ParmDSTds_usuario.Value = acfCMVp_Cabecera_Movimiento.DSTds_usuario;
                SqlCmd.Parameters.Add(ParmDSTds_usuario);

                SqlParameter ParmDSTid_ambiente = new SqlParameter();
                ParmDSTid_ambiente.ParameterName = "@mDSTid_ambiente";
                ParmDSTid_ambiente.SqlDbType = SqlDbType.Char;
                ParmDSTid_ambiente.Value = acfCMVp_Cabecera_Movimiento.DSTid_ambiente;
                SqlCmd.Parameters.Add(ParmDSTid_ambiente);

                SqlParameter ParmDSTds_ambiente = new SqlParameter();
                ParmDSTds_ambiente.ParameterName = "@mDSTds_ambiente";
                ParmDSTds_ambiente.SqlDbType = SqlDbType.VarChar;
                ParmDSTds_ambiente.Value = acfCMVp_Cabecera_Movimiento.DSTds_ambiente;
                SqlCmd.Parameters.Add(ParmDSTds_ambiente);

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
	public string Eliminar(DMovimiento_Transferencia_Activo acfCMVp_Cabecera_Movimiento) {
		
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
                SqlCmd.CommandText = "usp_D_acfCMVp_Cabecera_Movimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter PariMVPid_proceso = new SqlParameter();
                PariMVPid_proceso.ParameterName = "@iMVPid_proceso";
                PariMVPid_proceso.SqlDbType = SqlDbType.Int;
                PariMVPid_proceso.Value = acfCMVp_Cabecera_Movimiento.MVPid_proceso;
                SqlCmd.Parameters.Add(PariMVPid_proceso);


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

        // barra de navegacion
        public DataTable Top()
        {

            DataTable DtResultado = new DataTable("acfCMVp_Cabecera_Movimiento");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_T_acfCMVp_Cabecera_Movimiento";
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

        public DataTable Prev(String MVPid_proceso)
        {
            DataTable DtResultado = new DataTable("acfCMVp_Cabecera_Movimiento");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_P_acfCMVp_Cabecera_Movimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParMVPid_proceso = new SqlParameter();
                ParMVPid_proceso.ParameterName = "@iMVPid_proceso";
                ParMVPid_proceso.SqlDbType = SqlDbType.Int;
                ParMVPid_proceso.Size = 50;
                ParMVPid_proceso.Value = MVPid_proceso;
                SqlCmd.Parameters.Add(ParMVPid_proceso);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable Next(String MVPid_proceso)
        {
            DataTable DtResultado = new DataTable("acfCMVp_Cabecera_Movimiento");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_N_acfCMVp_Cabecera_Movimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParMVPid_proceso = new SqlParameter();
                ParMVPid_proceso.ParameterName = "@iMVPid_proceso";
                ParMVPid_proceso.SqlDbType = SqlDbType.Int;
                ParMVPid_proceso.Size = 50;
                ParMVPid_proceso.Value = MVPid_proceso;
                SqlCmd.Parameters.Add(ParMVPid_proceso);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        public DataTable Last()
        {
            DataTable DtResultado = new DataTable("acfCMVp_Cabecera_Movimiento");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_L_acfCMVp_Cabecera_Movimiento";
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

        //METODO BUSCAR

        public DataTable Buscar(DMovimiento_Transferencia_Activo acfCMVp_Cabecera_Movimiento) {

        DataTable DtResultado = new DataTable("acfAMBTt_Ambiente");
            SqlConnection SqlCon = new SqlConnection();


		try {

            SqlCon.ConnectionString = DConexion.CnBDActivo;
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandText = "usp_B_acfCMVp_Cabecera_Movimiento";
            SqlCmd.CommandType = CommandType.StoredProcedure;
                                
            SqlParameter PariMVPid_proceso = new SqlParameter();
                PariMVPid_proceso.ParameterName = "@iMVPid_proceso";
                PariMVPid_proceso.SqlDbType = SqlDbType.Int;
                PariMVPid_proceso.Size = 50;
                PariMVPid_proceso.Value = acfCMVp_Cabecera_Movimiento.MVPid_proceso;
            SqlCmd.Parameters.Add(PariMVPid_proceso);
            
            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtResultado);

		}
        catch (Exception ex)
        {
            DtResultado = null;
        }
        return DtResultado;

	}

        // Recargar el Activo Fijo
        public string RecargarACF(DMovimiento_Transferencia_Activo acfCMVp_Cabecera_Movimiento)
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
                SqlCmd.CommandText = "usp_U3_acfCMVp_Cabecera_Movimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter PariMVPid_proceso = new SqlParameter();
                PariMVPid_proceso.ParameterName = "@iMVPid_proceso";
                PariMVPid_proceso.SqlDbType = SqlDbType.Int;
                PariMVPid_proceso.Value = acfCMVp_Cabecera_Movimiento.MVPid_proceso;
                SqlCmd.Parameters.Add(PariMVPid_proceso);
                
                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Actualizao el Registro";

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

    }
}