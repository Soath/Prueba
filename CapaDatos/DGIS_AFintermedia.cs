using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DGIS_AFintermedia
    {
        private string mid_elem_gis;
        private string mdescrip_elem_gis;
        private string mcodigo_af;
        private string mid_sistema_electrico;
        private string mnombre_sistema_electrico;
        private string mid_set;
        private string mnombre_set;
        private string mid_alimentador;
        private string mnombre_alimentador;
        private string mid_sed;
        private string mnombre_sed;
        private string mid_circuito;
        private string mnombre_circuito;
        private string mid_punto_inicio;
        private string mpunto_inicio_x;
        private string mpunto_inicio_y;
        private string mid_punto_fin;
        private string mpunto_fin_x;
        private string mpunto_fin_y;
        private string mlinea_at;
        private string melem_punto_inicio_at;
        private string mid_punto_inicio_at;
        private string mpunto_inicio_at_x;
        private string mpunto_inicio_at_y;
        private string melem_punto_fin_at;
        private string mid_punto_fin_at;
        private string mpunto_fin_at_x;
        private string mpunto_fin_at_y;

        public string id_elem_gis
        {
            get { return mid_elem_gis; }
            set { mid_elem_gis = value; }
        }
        public string descrip_elem_gis
        {
            get { return mdescrip_elem_gis; }
            set { mdescrip_elem_gis = value; }
        }
        public string codigo_af
        {
            get { return mcodigo_af; }
            set { mcodigo_af = value; }
        }
        public string id_sistema_electrico
        {
            get { return mid_sistema_electrico; }
            set { mid_sistema_electrico = value; }
        }
        public string nombre_sistema_electrico
        {
            get { return mnombre_sistema_electrico; }
            set { mnombre_sistema_electrico = value; }
        }
        public string id_set
        {
            get { return mid_set; }
            set { mid_set = value; }
        }
        public string nombre_set
        {
            get { return mnombre_set; }
            set { mnombre_set = value; }
        }
        public string id_alimentador
        {
            get { return mid_alimentador; }
            set { mid_alimentador = value; }
        }
        public string nombre_alimentador
        {
            get { return mnombre_alimentador; }
            set { mnombre_alimentador = value; }
        }
        public string id_sed
        {
            get { return mid_sed; }
            set { mid_sed = value; }
        }
        public string nombre_sed
        {
            get { return mnombre_sed; }
            set { mnombre_sed = value; }
        }
        public string id_circuito
        {
            get { return mid_circuito; }
            set { mid_circuito = value; }
        }
        public string nombre_circuito
        {
            get { return mnombre_circuito; }
            set { mnombre_circuito = value; }
        }
        public string id_punto_inicio
        {
            get { return mid_punto_inicio; }
            set { mid_punto_inicio = value; }
        }
        public string punto_inicio_x
        {
            get { return mpunto_inicio_x; }
            set { mpunto_inicio_x = value; }
        }
        public string punto_inicio_y
        {
            get { return mpunto_inicio_y; }
            set { mpunto_inicio_y = value; }
        }
        public string id_punto_fin
        {
            get { return mid_punto_fin; }
            set { mid_punto_fin = value; }
        }
        public string punto_fin_x
        {
            get { return mpunto_fin_x; }
            set { mpunto_fin_x = value; }
        }
        public string punto_fin_y
        {
            get { return mpunto_fin_y; }
            set { mpunto_fin_y = value; }
        }
        public string linea_at
        {
            get { return mlinea_at; }
            set { mlinea_at = value; }
        }
        public string elem_punto_inicio_at
        {
            get { return melem_punto_inicio_at; }
            set { melem_punto_inicio_at = value; }
        }
        public string id_punto_inicio_at
        {
            get { return mid_punto_inicio_at; }
            set { mid_punto_inicio_at = value; }
        }
        public string punto_inicio_at_x
        {
            get { return mpunto_inicio_at_x; }
            set { mpunto_inicio_at_x = value; }
        }

        public string punto_inicio_at_y
        {
            get { return mpunto_inicio_at_y; }
            set { mpunto_inicio_at_y = value; }
        }

        public string elem_punto_fin_at
        {
            get { return melem_punto_fin_at; }
            set { melem_punto_fin_at = value; }
        }

        public string id_punto_fin_at
        {
            get { return mid_punto_fin_at; }
            set { mid_punto_fin_at = value; }
        }

        public string punto_fin_at_x
        {
            get { return mpunto_fin_at_x; }
            set { mpunto_fin_at_x = value; }
        }

        public string punto_fin_at_y
        {
            get { return mpunto_fin_at_y; }
            set { mpunto_fin_at_y = value; }
        }
        //Constructor vacío
        public DGIS_AFintermedia()
        {
        }
        //Constructor con parámetros
        public DGIS_AFintermedia(
            string id_elem_gis,
            string descrip_elem_gis,
            string codigo_af,
            string id_sistema_electrico,
            string nombre_sistema_electrico,
            string id_set,
            string nombre_set,
            string id_alimentador,
            string nombre_alimentador,
            string id_sed,
            string nombre_sed,
            string id_circuito,
            string nombre_circuito,
            string id_punto_inicio,
            string punto_inicio_x,
            string punto_inicio_y,
            string id_punto_fin,
            string punto_fin_x,
            string punto_fin_y,
            string linea_at,
            string elem_punto_inicio_at,
            string id_punto_inicio_at,
            string punto_inicio_at_x,
            string punto_inicio_at_y,
            string elem_punto_fin_at,
            string id_punto_fin_at,
            string punto_fin_at_x,
            string punto_fin_at_y
            )
        {
            this.mid_elem_gis = id_elem_gis;
            this.mdescrip_elem_gis = descrip_elem_gis;
            this.mcodigo_af = codigo_af;
            this.mid_sistema_electrico = id_sistema_electrico;
            this.mnombre_sistema_electrico = nombre_sistema_electrico;
            this.mid_set = id_set;
            this.mnombre_set = nombre_set;
            this.mid_alimentador = id_alimentador;
            this.mnombre_alimentador = nombre_alimentador;
            this.mid_sed = id_sed;
            this.mnombre_sed = nombre_sed;
            this.mid_circuito = id_circuito;
            this.mnombre_circuito = nombre_circuito;
            this.mid_punto_inicio = id_punto_inicio;
            this.mpunto_inicio_x = punto_inicio_x;
            this.mpunto_inicio_y = punto_inicio_y;
            this.mid_punto_fin = id_punto_fin;
            this.mpunto_fin_x = punto_fin_x;
            this.mpunto_fin_y = punto_fin_y;
            this.mlinea_at = linea_at;
            this.melem_punto_inicio_at = elem_punto_inicio_at;
            this.mid_punto_inicio_at = id_punto_inicio_at;
            this.mpunto_inicio_at_x = punto_inicio_at_x;
            this.mpunto_inicio_at_y = punto_inicio_at_y;
            this.melem_punto_fin_at = elem_punto_fin_at;
            this.mid_punto_fin_at = id_punto_fin_at;
            this.mpunto_fin_at_x = punto_fin_at_x;
            this.mpunto_fin_at_y = punto_fin_at_y;
        }

        //METODO MOSTRAR 
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("AF_intermedia");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnGIS;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_AF_intermedia";
                SqlCmd.CommandType = CommandType.StoredProcedure;
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

        //METODO INSERTAR 
        public string Insertar(DGIS_AFintermedia AF_intermedia)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = DConexion.CnGIS;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_I_AF_intermedia";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter Parid_elem_gis = new SqlParameter();
                Parid_elem_gis.ParameterName = "@mid_elem_gis";
                Parid_elem_gis.SqlDbType = SqlDbType.Int;
                Parid_elem_gis.Value = AF_intermedia.id_elem_gis;
                SqlCmd.Parameters.Add(Parid_elem_gis);
                //
                SqlParameter Pardescrip_elem_gis = new SqlParameter();
                Pardescrip_elem_gis.ParameterName = "@mdescrip_elem_gis";
                Pardescrip_elem_gis.SqlDbType = SqlDbType.Char;
                Pardescrip_elem_gis.Value = AF_intermedia.descrip_elem_gis;
                SqlCmd.Parameters.Add(Pardescrip_elem_gis);
                //
                SqlParameter Parcodigo_af = new SqlParameter();
                Parcodigo_af.ParameterName = "@mcodigo_af";
                Parcodigo_af.SqlDbType = SqlDbType.Int;
                Parcodigo_af.Value = AF_intermedia.codigo_af;
                SqlCmd.Parameters.Add(Parcodigo_af);
                //
                SqlParameter Parid_sistema_electrico = new SqlParameter();
                Parid_sistema_electrico.ParameterName = "@mid_sistema_electrico";
                Parid_sistema_electrico.SqlDbType = SqlDbType.Char;
                Parid_sistema_electrico.Value = AF_intermedia.id_sistema_electrico;
                SqlCmd.Parameters.Add(Parid_sistema_electrico);
                //
                SqlParameter Parnombre_sistema_electrico = new SqlParameter();
                Parnombre_sistema_electrico.ParameterName = "@mnombre_sistema_electrico";
                Parnombre_sistema_electrico.SqlDbType = SqlDbType.Char;
                Parnombre_sistema_electrico.Value = AF_intermedia.nombre_sistema_electrico;
                SqlCmd.Parameters.Add(Parnombre_sistema_electrico);
                //
                SqlParameter Parid_set = new SqlParameter();
                Parid_set.ParameterName = "@mid_set";
                Parid_set.SqlDbType = SqlDbType.Int;
                Parid_set.Value = AF_intermedia.id_set;
                SqlCmd.Parameters.Add(Parid_set);
                //
                SqlParameter Parnombre_set = new SqlParameter();
                Parnombre_set.ParameterName = "@mnombre_set";
                Parnombre_set.SqlDbType = SqlDbType.Char;
                Parnombre_set.Value = AF_intermedia.nombre_set;
                SqlCmd.Parameters.Add(Parnombre_set);
                //
                SqlParameter Parid_alimentador = new SqlParameter();
                Parid_alimentador.ParameterName = "@mid_alimentador";
                Parid_alimentador.SqlDbType = SqlDbType.Int;
                Parid_alimentador.Value = AF_intermedia.id_alimentador;
                SqlCmd.Parameters.Add(Parid_alimentador);
                //
                SqlParameter Parnombre_alimentador = new SqlParameter();
                Parnombre_alimentador.ParameterName = "@mnombre_alimentador";
                Parnombre_alimentador.SqlDbType = SqlDbType.Char;
                Parnombre_alimentador.Value = AF_intermedia.nombre_alimentador;
                SqlCmd.Parameters.Add(Parnombre_alimentador);
                //
                SqlParameter Parid_sed = new SqlParameter();
                Parid_sed.ParameterName = "@mid_sed";
                Parid_sed.SqlDbType = SqlDbType.Int;
                Parid_sed.Value = AF_intermedia.id_sed;
                SqlCmd.Parameters.Add(Parid_sed);
                //
                SqlParameter Parnombre_sed = new SqlParameter();
                Parnombre_sed.ParameterName = "@mnombre_sed";
                Parnombre_sed.SqlDbType = SqlDbType.Char;
                Parnombre_sed.Value = AF_intermedia.nombre_sed;
                SqlCmd.Parameters.Add(Parnombre_sed);
                //
                SqlParameter Parid_circuito = new SqlParameter();
                Parid_circuito.ParameterName = "@mid_circuito";
                Parid_circuito.SqlDbType = SqlDbType.Int;
                Parid_circuito.Value = AF_intermedia.id_circuito;
                SqlCmd.Parameters.Add(Parid_circuito);
                //
                SqlParameter Parnombre_circuito = new SqlParameter();
                Parnombre_circuito.ParameterName = "@mnombre_circuito";
                Parnombre_circuito.SqlDbType = SqlDbType.Char;
                Parnombre_circuito.Value = AF_intermedia.nombre_circuito;
                SqlCmd.Parameters.Add(Parnombre_circuito);
                //
                SqlParameter Parid_punto_inicio = new SqlParameter();
                Parid_punto_inicio.ParameterName = "@mid_punto_inicio";
                Parid_punto_inicio.SqlDbType = SqlDbType.Int;
                Parid_punto_inicio.Value = AF_intermedia.id_punto_inicio;
                SqlCmd.Parameters.Add(Parid_punto_inicio);
                //
                SqlParameter Parpunto_inicio_x = new SqlParameter();
                Parpunto_inicio_x.ParameterName = "@mpunto_inicio_x";
                Parpunto_inicio_x.SqlDbType = SqlDbType.Decimal;
                Parpunto_inicio_x.Value = AF_intermedia.punto_inicio_x;
                SqlCmd.Parameters.Add(Parpunto_inicio_x);
                //
                SqlParameter Parpunto_inicio_y = new SqlParameter();
                Parpunto_inicio_y.ParameterName = "@mpunto_inicio_y";
                Parpunto_inicio_y.SqlDbType = SqlDbType.Decimal;
                Parpunto_inicio_y.Value = AF_intermedia.punto_inicio_y;
                SqlCmd.Parameters.Add(Parpunto_inicio_y);
                //
                SqlParameter Parid_punto_fin = new SqlParameter();
                Parid_punto_fin.ParameterName = "@mid_punto_fin";
                Parid_punto_fin.SqlDbType = SqlDbType.Int;
                Parid_punto_fin.Value = AF_intermedia.id_punto_fin;
                SqlCmd.Parameters.Add(Parid_punto_fin);
                //
                SqlParameter Parpunto_fin_x = new SqlParameter();
                Parpunto_fin_x.ParameterName = "@mpunto_fin_x";
                Parpunto_fin_x.SqlDbType = SqlDbType.Decimal;
                Parpunto_fin_x.Value = AF_intermedia.punto_fin_x;
                SqlCmd.Parameters.Add(Parpunto_fin_x);
                //
                SqlParameter Parpunto_fin_y = new SqlParameter();
                Parpunto_fin_y.ParameterName = "@mpunto_fin_y";
                Parpunto_fin_y.SqlDbType = SqlDbType.Decimal;
                Parpunto_fin_y.Value = AF_intermedia.punto_fin_y;
                SqlCmd.Parameters.Add(Parpunto_fin_y);
                //
                SqlParameter Parlinea_at = new SqlParameter();
                Parlinea_at.ParameterName = "@mlinea_at";
                Parlinea_at.SqlDbType = SqlDbType.Char;
                Parlinea_at.Value = AF_intermedia.linea_at;
                SqlCmd.Parameters.Add(Parlinea_at);
                //
                SqlParameter Parelem_punto_inicio_at = new SqlParameter();
                Parelem_punto_inicio_at.ParameterName = "@melem_punto_inicio_at";
                Parelem_punto_inicio_at.SqlDbType = SqlDbType.Char;
                Parelem_punto_inicio_at.Value = AF_intermedia.elem_punto_inicio_at;
                SqlCmd.Parameters.Add(Parelem_punto_inicio_at);
                //
                SqlParameter Parid_punto_inicio_at = new SqlParameter();
                Parid_punto_inicio_at.ParameterName = "@mid_punto_inicio_at";
                Parid_punto_inicio_at.SqlDbType = SqlDbType.Int;
                Parid_punto_inicio_at.Value = AF_intermedia.id_punto_inicio_at;
                SqlCmd.Parameters.Add(Parid_punto_inicio_at);
                //
                SqlParameter Parpunto_inicio_at_x = new SqlParameter();
                Parpunto_inicio_at_x.ParameterName = "@mpunto_inicio_at_x";
                Parpunto_inicio_at_x.SqlDbType = SqlDbType.Decimal;
                Parpunto_inicio_at_x.Value = AF_intermedia.punto_inicio_at_x;
                SqlCmd.Parameters.Add(Parpunto_inicio_at_x);
                //
                SqlParameter Parpunto_inicio_at_y = new SqlParameter();
                Parpunto_inicio_at_y.ParameterName = "@mpunto_inicio_at_y";
                Parpunto_inicio_at_y.SqlDbType = SqlDbType.Decimal;
                Parpunto_inicio_at_y.Value = AF_intermedia.punto_inicio_at_y;
                SqlCmd.Parameters.Add(Parpunto_inicio_at_y);
                //
                SqlParameter Parelem_punto_fin_at = new SqlParameter();
                Parelem_punto_fin_at.ParameterName = "@melem_punto_fin_at";
                Parelem_punto_fin_at.SqlDbType = SqlDbType.Char;
                Parelem_punto_fin_at.Value = AF_intermedia.elem_punto_fin_at;
                SqlCmd.Parameters.Add(Parelem_punto_fin_at);
                //
                SqlParameter Parid_punto_fin_at = new SqlParameter();
                Parid_punto_fin_at.ParameterName = "@mid_punto_fin_at";
                Parid_punto_fin_at.SqlDbType = SqlDbType.Int;
                Parid_punto_fin_at.Value = AF_intermedia.id_punto_fin_at;
                SqlCmd.Parameters.Add(Parid_punto_fin_at);
                //
                SqlParameter Parpunto_fin_at_x = new SqlParameter();
                Parpunto_fin_at_x.ParameterName = "@mpunto_fin_at_x";
                Parpunto_fin_at_x.SqlDbType = SqlDbType.Decimal;
                Parpunto_fin_at_x.Value = AF_intermedia.punto_fin_at_x;
                SqlCmd.Parameters.Add(Parpunto_fin_at_x);
                //
                SqlParameter Parpunto_fin_at_y = new SqlParameter();
                Parpunto_fin_at_y.ParameterName = "@mpunto_fin_at_y";
                Parpunto_fin_at_y.SqlDbType = SqlDbType.Decimal;
                Parpunto_fin_at_y.Value = AF_intermedia.punto_fin_at_y;
                SqlCmd.Parameters.Add(Parpunto_fin_at_y);
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
        public string Editar(DGIS_AFintermedia AF_intermedia)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = DConexion.CnGIS;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_U_AF_intermedia";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter Parid_elem_gis = new SqlParameter();
                Parid_elem_gis.ParameterName = "@mid_elem_gis";
                Parid_elem_gis.SqlDbType = SqlDbType.Int;
                Parid_elem_gis.Value = AF_intermedia.id_elem_gis;
                SqlCmd.Parameters.Add(Parid_elem_gis);
                //
                SqlParameter Pardescrip_elem_gis = new SqlParameter();
                Pardescrip_elem_gis.ParameterName = "@mdescrip_elem_gis";
                Pardescrip_elem_gis.SqlDbType = SqlDbType.Char;
                Pardescrip_elem_gis.Value = AF_intermedia.descrip_elem_gis;
                SqlCmd.Parameters.Add(Pardescrip_elem_gis);
                //
                SqlParameter Parcodigo_af = new SqlParameter();
                Parcodigo_af.ParameterName = "@mcodigo_af";
                Parcodigo_af.SqlDbType = SqlDbType.Int;
                Parcodigo_af.Value = AF_intermedia.codigo_af;
                SqlCmd.Parameters.Add(Parcodigo_af);
                //
                SqlParameter Parid_sistema_electrico = new SqlParameter();
                Parid_sistema_electrico.ParameterName = "@mid_sistema_electrico";
                Parid_sistema_electrico.SqlDbType = SqlDbType.Char;
                Parid_sistema_electrico.Value = AF_intermedia.id_sistema_electrico;
                SqlCmd.Parameters.Add(Parid_sistema_electrico);
                //
                SqlParameter Parnombre_sistema_electrico = new SqlParameter();
                Parnombre_sistema_electrico.ParameterName = "@mnombre_sistema_electrico";
                Parnombre_sistema_electrico.SqlDbType = SqlDbType.Char;
                Parnombre_sistema_electrico.Value = AF_intermedia.nombre_sistema_electrico;
                SqlCmd.Parameters.Add(Parnombre_sistema_electrico);
                //
                SqlParameter Parid_set = new SqlParameter();
                Parid_set.ParameterName = "@mid_set";
                Parid_set.SqlDbType = SqlDbType.Int;
                Parid_set.Value = AF_intermedia.id_set;
                SqlCmd.Parameters.Add(Parid_set);
                //
                SqlParameter Parnombre_set = new SqlParameter();
                Parnombre_set.ParameterName = "@mnombre_set";
                Parnombre_set.SqlDbType = SqlDbType.Char;
                Parnombre_set.Value = AF_intermedia.nombre_set;
                SqlCmd.Parameters.Add(Parnombre_set);
                //
                SqlParameter Parid_alimentador = new SqlParameter();
                Parid_alimentador.ParameterName = "@mid_alimentador";
                Parid_alimentador.SqlDbType = SqlDbType.Int;
                Parid_alimentador.Value = AF_intermedia.id_alimentador;
                SqlCmd.Parameters.Add(Parid_alimentador);
                //
                SqlParameter Parnombre_alimentador = new SqlParameter();
                Parnombre_alimentador.ParameterName = "@mnombre_alimentador";
                Parnombre_alimentador.SqlDbType = SqlDbType.Char;
                Parnombre_alimentador.Value = AF_intermedia.nombre_alimentador;
                SqlCmd.Parameters.Add(Parnombre_alimentador);
                //
                SqlParameter Parid_sed = new SqlParameter();
                Parid_sed.ParameterName = "@mid_sed";
                Parid_sed.SqlDbType = SqlDbType.Int;
                Parid_sed.Value = AF_intermedia.id_sed;
                SqlCmd.Parameters.Add(Parid_sed);
                //
                SqlParameter Parnombre_sed = new SqlParameter();
                Parnombre_sed.ParameterName = "@mnombre_sed";
                Parnombre_sed.SqlDbType = SqlDbType.Char;
                Parnombre_sed.Value = AF_intermedia.nombre_sed;
                SqlCmd.Parameters.Add(Parnombre_sed);
                //
                SqlParameter Parid_circuito = new SqlParameter();
                Parid_circuito.ParameterName = "@mid_circuito";
                Parid_circuito.SqlDbType = SqlDbType.Int;
                Parid_circuito.Value = AF_intermedia.id_circuito;
                SqlCmd.Parameters.Add(Parid_circuito);
                //
                SqlParameter Parnombre_circuito = new SqlParameter();
                Parnombre_circuito.ParameterName = "@mnombre_circuito";
                Parnombre_circuito.SqlDbType = SqlDbType.Char;
                Parnombre_circuito.Value = AF_intermedia.nombre_circuito;
                SqlCmd.Parameters.Add(Parnombre_circuito);
                //
                SqlParameter Parid_punto_inicio = new SqlParameter();
                Parid_punto_inicio.ParameterName = "@mid_punto_inicio";
                Parid_punto_inicio.SqlDbType = SqlDbType.Int;
                Parid_punto_inicio.Value = AF_intermedia.id_punto_inicio;
                SqlCmd.Parameters.Add(Parid_punto_inicio);
                //
                SqlParameter Parpunto_inicio_x = new SqlParameter();
                Parpunto_inicio_x.ParameterName = "@mpunto_inicio_x";
                Parpunto_inicio_x.SqlDbType = SqlDbType.Decimal;
                Parpunto_inicio_x.Value = AF_intermedia.punto_inicio_x;
                SqlCmd.Parameters.Add(Parpunto_inicio_x);
                //
                SqlParameter Parpunto_inicio_y = new SqlParameter();
                Parpunto_inicio_y.ParameterName = "@mpunto_inicio_y";
                Parpunto_inicio_y.SqlDbType = SqlDbType.Decimal;
                Parpunto_inicio_y.Value = AF_intermedia.punto_inicio_y;
                SqlCmd.Parameters.Add(Parpunto_inicio_y);
                //
                SqlParameter Parid_punto_fin = new SqlParameter();
                Parid_punto_fin.ParameterName = "@mid_punto_fin";
                Parid_punto_fin.SqlDbType = SqlDbType.Int;
                Parid_punto_fin.Value = AF_intermedia.id_punto_fin;
                SqlCmd.Parameters.Add(Parid_punto_fin);
                //
                SqlParameter Parpunto_fin_x = new SqlParameter();
                Parpunto_fin_x.ParameterName = "@mpunto_fin_x";
                Parpunto_fin_x.SqlDbType = SqlDbType.Decimal;
                Parpunto_fin_x.Value = AF_intermedia.punto_fin_x;
                SqlCmd.Parameters.Add(Parpunto_fin_x);
                //
                SqlParameter Parpunto_fin_y = new SqlParameter();
                Parpunto_fin_y.ParameterName = "@mpunto_fin_y";
                Parpunto_fin_y.SqlDbType = SqlDbType.Decimal;
                Parpunto_fin_y.Value = AF_intermedia.punto_fin_y;
                SqlCmd.Parameters.Add(Parpunto_fin_y);
                //
                SqlParameter Parlinea_at = new SqlParameter();
                Parlinea_at.ParameterName = "@mlinea_at";
                Parlinea_at.SqlDbType = SqlDbType.Char;
                Parlinea_at.Value = AF_intermedia.linea_at;
                SqlCmd.Parameters.Add(Parlinea_at);
                //
                SqlParameter Parelem_punto_inicio_at = new SqlParameter();
                Parelem_punto_inicio_at.ParameterName = "@melem_punto_inicio_at";
                Parelem_punto_inicio_at.SqlDbType = SqlDbType.Char;
                Parelem_punto_inicio_at.Value = AF_intermedia.elem_punto_inicio_at;
                SqlCmd.Parameters.Add(Parelem_punto_inicio_at);
                //
                SqlParameter Parid_punto_inicio_at = new SqlParameter();
                Parid_punto_inicio_at.ParameterName = "@mid_punto_inicio_at";
                Parid_punto_inicio_at.SqlDbType = SqlDbType.Int;
                Parid_punto_inicio_at.Value = AF_intermedia.id_punto_inicio_at;
                SqlCmd.Parameters.Add(Parid_punto_inicio_at);
                //
                SqlParameter Parpunto_inicio_at_x = new SqlParameter();
                Parpunto_inicio_at_x.ParameterName = "@mpunto_inicio_at_x";
                Parpunto_inicio_at_x.SqlDbType = SqlDbType.Decimal;
                Parpunto_inicio_at_x.Value = AF_intermedia.punto_inicio_at_x;
                SqlCmd.Parameters.Add(Parpunto_inicio_at_x);
                //
                SqlParameter Parpunto_inicio_at_y = new SqlParameter();
                Parpunto_inicio_at_y.ParameterName = "@mpunto_inicio_at_y";
                Parpunto_inicio_at_y.SqlDbType = SqlDbType.Decimal;
                Parpunto_inicio_at_y.Value = AF_intermedia.punto_inicio_at_y;
                SqlCmd.Parameters.Add(Parpunto_inicio_at_y);
                //
                SqlParameter Parelem_punto_fin_at = new SqlParameter();
                Parelem_punto_fin_at.ParameterName = "@melem_punto_fin_at";
                Parelem_punto_fin_at.SqlDbType = SqlDbType.Char;
                Parelem_punto_fin_at.Value = AF_intermedia.elem_punto_fin_at;
                SqlCmd.Parameters.Add(Parelem_punto_fin_at);
                //
                SqlParameter Parid_punto_fin_at = new SqlParameter();
                Parid_punto_fin_at.ParameterName = "@mid_punto_fin_at";
                Parid_punto_fin_at.SqlDbType = SqlDbType.Int;
                Parid_punto_fin_at.Value = AF_intermedia.id_punto_fin_at;
                SqlCmd.Parameters.Add(Parid_punto_fin_at);
                //
                SqlParameter Parpunto_fin_at_x = new SqlParameter();
                Parpunto_fin_at_x.ParameterName = "@mpunto_fin_at_x";
                Parpunto_fin_at_x.SqlDbType = SqlDbType.Decimal;
                Parpunto_fin_at_x.Value = AF_intermedia.punto_fin_at_x;
                SqlCmd.Parameters.Add(Parpunto_fin_at_x);
                //
                SqlParameter Parpunto_fin_at_y = new SqlParameter();
                Parpunto_fin_at_y.ParameterName = "@mpunto_fin_at_y";
                Parpunto_fin_at_y.SqlDbType = SqlDbType.Decimal;
                Parpunto_fin_at_y.Value = AF_intermedia.punto_fin_at_y;
                SqlCmd.Parameters.Add(Parpunto_fin_at_y);
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

        //METODO BUSCAR
        public DataTable Buscar(DGIS_AFintermedia AF_intermedia)
        {
            DataTable DtResultado = new DataTable("AF_intermedia");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = DConexion.CnGIS;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_B_AF_intermedia";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //
                SqlParameter Parid_elem_gis = new SqlParameter();
                Parid_elem_gis.ParameterName = "@mid_elem_gis";
                Parid_elem_gis.SqlDbType = SqlDbType.Int;
                Parid_elem_gis.Size = 50;
                Parid_elem_gis.Value = AF_intermedia.id_elem_gis;
                SqlCmd.Parameters.Add(Parid_elem_gis);
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
