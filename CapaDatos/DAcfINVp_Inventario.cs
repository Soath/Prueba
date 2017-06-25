using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DAcfINVp_Inventario
    {
        private string mINVid;
        private string mINVdetalle;
        private string mINVinicio;
        private string mINVcierre;
        private bool mINVactivo;
        private string mINVrespon;
        private string mINVperiodo;


        public string INVid
        {
            get
            {
                return mINVid;
            }
            set
            {
                mINVid = value;
            }
        }
        public string INVdetalle
        {
            get
            {
                return mINVdetalle;
            }
            set
            {
                mINVdetalle = value;
            }
        }
        public string INVinicio
        {
            get
            {
                return mINVinicio;
            }
            set
            {
                mINVinicio = value;
            }
        }
        public string INVcierre
        {
            get
            {
                return mINVcierre;
            }
            set
            {
                mINVcierre = value;
            }
        }
        public bool INVactivo
        {
            get
            {
                return mINVactivo;
            }
            set
            {
                mINVactivo = value;
            }
        }
        public string INVrespon
        {
            get
            {
                return mINVrespon;
            }
            set
            {
                mINVrespon = value;
            }
        }
        public string INVperiodo
        {
            get
            {
                return mINVperiodo;
            }
            set
            {
                mINVperiodo = value;
            }
        }
        //Constructor vacío
        public DAcfINVp_Inventario()
        {
	}

         //Constructor con parámetros

        public DAcfINVp_Inventario(string INVid, string INVdetalle, string INVinicio, string INVcierre, bool INVactivo, string INVrespon, string INVperiodo)
        {
        
		this.mINVid = INVid;
		this.mINVdetalle = INVdetalle;
        this.mINVinicio = INVinicio;
        this.mINVcierre = INVcierre;
        this.mINVactivo = INVactivo;
        this.mINVrespon = INVrespon;
        this.mINVperiodo = INVperiodo;
	
	}
        public DataTable Prev(String INVid)
        {
            DataTable DtResultado = new DataTable("acfINVp_Inventario");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_P_acfINVp_Inventario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParINVid = new SqlParameter();
                ParINVid.ParameterName = "@INVid";
                ParINVid.SqlDbType = SqlDbType.Int;
                ParINVid.Size = 50;
                ParINVid.Value = INVid;
                SqlCmd.Parameters.Add(ParINVid);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable Next(String INVid)
        {
            DataTable DtResultado = new DataTable("acfINVp_Inventario");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_N_acfINVp_Inventario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParINVid = new SqlParameter();
                ParINVid.ParameterName = "@INVid";
                ParINVid.SqlDbType = SqlDbType.Int;
                ParINVid.Size = 50;
                ParINVid.Value = INVid;
                SqlCmd.Parameters.Add(ParINVid);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }

            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("acfINVp_Inventario");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_S_acfINVp_Inventario";
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
        public string Insertar(DAcfINVp_Inventario acfINVp_Inventario)
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
                SqlCmd.CommandText = "usp_I_acfINVp_Inventario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParINVid = new SqlParameter();
                ParINVid.ParameterName = "@iINVid";
                ParINVid.SqlDbType = SqlDbType.Int;
                ParINVid.Value = acfINVp_Inventario.INVid;
                SqlCmd.Parameters.Add(ParINVid);
                //
                SqlParameter ParsINVdetalle = new SqlParameter();
                ParsINVdetalle.ParameterName = "@sINVdetalle";
                ParsINVdetalle.SqlDbType = SqlDbType.VarChar;
                ParsINVdetalle.Value = acfINVp_Inventario.INVdetalle;
                SqlCmd.Parameters.Add(ParsINVdetalle);
                //
                SqlParameter PartdINVinicio = new SqlParameter();
                PartdINVinicio.ParameterName = "@dtINVinicio";
                PartdINVinicio.SqlDbType = SqlDbType.DateTime;
                PartdINVinicio.Value = Convert.ToDateTime(acfINVp_Inventario.INVinicio);
                SqlCmd.Parameters.Add(PartdINVinicio);
                //
                SqlParameter PartdINVcierre = new SqlParameter();
                PartdINVcierre.ParameterName = "@dtINVcierre";
                PartdINVcierre.SqlDbType = SqlDbType.DateTime;
                PartdINVcierre.Value = Convert.ToDateTime(acfINVp_Inventario.INVcierre);
                SqlCmd.Parameters.Add(PartdINVcierre);
                //
                SqlParameter PartbINVactivo = new SqlParameter();
                PartbINVactivo.ParameterName = "@bINVactivo";
                PartbINVactivo.SqlDbType = SqlDbType.Bit;
                PartbINVactivo.Value = acfINVp_Inventario.INVactivo;
                SqlCmd.Parameters.Add(PartbINVactivo);
                //
                //
                SqlParameter ParsINVrespon = new SqlParameter();
                ParsINVrespon.ParameterName = "@sINVrespon";
                ParsINVrespon.SqlDbType = SqlDbType.Char;
                ParsINVrespon.Value = acfINVp_Inventario.INVrespon;
                SqlCmd.Parameters.Add(ParsINVrespon);
                //
                SqlParameter PardtINVperiodo = new SqlParameter();
                PardtINVperiodo.ParameterName = "@dtINVperiodo";
                PardtINVperiodo.SqlDbType = SqlDbType.Char;
                PardtINVperiodo.Value = acfINVp_Inventario.INVperiodo;
                SqlCmd.Parameters.Add(PardtINVperiodo);
                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Ingreso el Registro";



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
        public string Editar(DAcfINVp_Inventario acfINVp_Inventario)
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
                SqlCmd.CommandText = "usp_U_acfINVp_Inventario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParINVid = new SqlParameter();
                ParINVid.ParameterName = "@iINVid";
                ParINVid.SqlDbType = SqlDbType.Int;
                ParINVid.Value = acfINVp_Inventario.INVid;
                SqlCmd.Parameters.Add(ParINVid);
                //
                SqlParameter ParsINVdetalle = new SqlParameter();
                ParsINVdetalle.ParameterName = "@sINVdetalle";
                ParsINVdetalle.SqlDbType = SqlDbType.VarChar;
                ParsINVdetalle.Value = acfINVp_Inventario.INVdetalle;
                SqlCmd.Parameters.Add(ParsINVdetalle);
                //
                SqlParameter PartdINVinicio = new SqlParameter();
                PartdINVinicio.ParameterName = "@dtINVinicio";
                PartdINVinicio.SqlDbType = SqlDbType.DateTime;
                PartdINVinicio.Value = acfINVp_Inventario.INVinicio;
                SqlCmd.Parameters.Add(PartdINVinicio);
                //
                SqlParameter PartdINVcierre = new SqlParameter();
                PartdINVcierre.ParameterName = "@dtINVcierre";
                PartdINVcierre.SqlDbType = SqlDbType.DateTime;
                PartdINVcierre.Value = acfINVp_Inventario.INVcierre;
                SqlCmd.Parameters.Add(PartdINVcierre);
                //
                SqlParameter PartbINVactivo = new SqlParameter();
                PartbINVactivo.ParameterName = "@bINVactivo";
                PartbINVactivo.SqlDbType = SqlDbType.Bit;
                PartbINVactivo.Value = acfINVp_Inventario.INVactivo;
                SqlCmd.Parameters.Add(PartbINVactivo);
                //
                //
                SqlParameter ParsINVrespon = new SqlParameter();
                ParsINVrespon.ParameterName = "@sINVrespon";
                ParsINVrespon.SqlDbType = SqlDbType.Char;
                ParsINVrespon.Value = acfINVp_Inventario.INVrespon;
                SqlCmd.Parameters.Add(ParsINVrespon);
                //
                SqlParameter PardtINVperiodo = new SqlParameter();
                PardtINVperiodo.ParameterName = "@dtINVperiodo";
                PardtINVperiodo.SqlDbType = SqlDbType.Char;
                PardtINVperiodo.Value = acfINVp_Inventario.INVperiodo;
                SqlCmd.Parameters.Add(PardtINVperiodo);

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
        //METODO ELIMINAR
        public string Eliminar(DAcfINVp_Inventario acfINVp_Inventario)
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
                SqlCmd.CommandText = "usp_D_acfINVp_Inventario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //
                SqlParameter ParINVid = new SqlParameter();
                ParINVid.ParameterName = "@iINVid";
                ParINVid.SqlDbType = SqlDbType.Int;
                ParINVid.Value = acfINVp_Inventario.INVid;
                SqlCmd.Parameters.Add(ParINVid);


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


        public DataTable Top()
        {

            DataTable DtResultado = new DataTable("acfINVp_Inventario");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_T_acfINVp_Inventario";
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
        public DataTable Buscar(DAcfINVp_Inventario acfINVp_Inventario)
        {

            DataTable DtResultado = new DataTable("acfINVp_Inventario");
            SqlConnection SqlCon = new SqlConnection();


            try
            {

                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_B_acfINVp_Inventario";
                SqlCmd.CommandType = CommandType.StoredProcedure;



                SqlParameter ParINVinventario = new SqlParameter();
                ParINVinventario.ParameterName = "@iINVid";
                ParINVinventario.SqlDbType = SqlDbType.Char;
                ParINVinventario.Size = 50;
                ParINVinventario.Value = acfINVp_Inventario.INVid;
                SqlCmd.Parameters.Add(ParINVinventario);

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
            DataTable DtResultado = new DataTable("acfINVp_Inventario");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_L_acfINVp_Inventario";
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
        public string Cerrar()
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
                SqlCmd.CommandText = "usp_U2_acfINVp_Inventario";
                SqlCmd.CommandType = CommandType.StoredProcedure;
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
        public DataTable MostrarRegistro(String INVdetalle)
        {

            DataTable DtResultado = new DataTable("acfINVp_Inventario");
            SqlConnection SqlCon = new SqlConnection();


            try
            {

                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "usp_B_acfINVp_Inventario";
                SqlCmd.CommandType = CommandType.StoredProcedure;



                SqlParameter ParINVdetalle = new SqlParameter();
                ParINVdetalle.ParameterName = "@INVdetalle";
                ParINVdetalle.SqlDbType = SqlDbType.Char;
                ParINVdetalle.Size = 100;
                ParINVdetalle.Value = INVdetalle;
                SqlCmd.Parameters.Add(ParINVdetalle);

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
