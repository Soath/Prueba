//-----------------------------------------------------
//-- Autor:  Generador  Tony Valdez
//-- Capa Datos
//-- Fecha Creación:17/02/2017 07:24:12 p.m.
//-----------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;



namespace CapaDatos
{
    public class DPostres
    {
        private string _idpostre;
        private string _nombre;
        private string _precio;
        private string _stock;
        private string _tabla;
        private string _consulta;
        private string _condicion;
        private string _TextoBuscar;
 
        public string Idpostre
        {
            get { return _idpostre; }
            set { _idpostre = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public string Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
        public string Tabla
        {
            get { return _tabla; }
            set { _tabla = value; }
        }
        
        public string Consulta
        {
            get { return _consulta; }
            set { _consulta = value; }
        }
        
        public string Condicion
        {
            get { return _condicion; }
            set { _condicion = value; }
        }
        
        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }
        

        //Constructor Vacío
        public DPostres()
        {

        }
        //Constructor con parámetros
        public DPostres(string idpostre,string nombre,string precio,string stock, string textobuscar,string tabla,string consulta , string condicion)
        {
        this.Idpostre = idpostre;
        this.Nombre = nombre;
        this.Precio = precio;
        this.Stock = stock;
            this.Tabla = tabla;
            this.Consulta = consulta;
            this.Condicion = condicion;
            this.TextoBuscar = textobuscar;

        }


        //Método Insertar

        public string Insertar(DPostres Postres)
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
                SqlCmd.CommandText = "sp_insertar_Postres";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdpostre = new SqlParameter();
                ParIdpostre.ParameterName = "@idpostre";
                ParIdpostre.SqlDbType = SqlDbType.Int;
                ParIdpostre.Value = Postres.Idpostre;
                SqlCmd.Parameters.Add(ParIdpostre);
//
                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Value = Postres.Nombre;
                SqlCmd.Parameters.Add(ParNombre);
//
                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@precio";
                ParPrecio.SqlDbType = SqlDbType.Decimal;
                ParPrecio.Value = Postres.Precio;
                SqlCmd.Parameters.Add(ParPrecio);
//
                SqlParameter ParStock = new SqlParameter();
                ParStock.ParameterName = "@stock";
                ParStock.SqlDbType = SqlDbType.Float;
                ParStock.Value = Postres.Stock;
                SqlCmd.Parameters.Add(ParStock);
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
//------------------------------------------------------------------------------
        //Método Editar
        public string Editar(DPostres Postres)
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
                SqlCmd.CommandText = "sp_editar_postres";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdpostre = new SqlParameter();
                ParIdpostre.ParameterName = "@idpostre";
                ParIdpostre.SqlDbType = SqlDbType.Int;
                ParIdpostre.Value = Postres.Idpostre;
                SqlCmd.Parameters.Add(ParIdpostre);
//
                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Value = Postres.Nombre;
                SqlCmd.Parameters.Add(ParNombre);
//
                SqlParameter ParPrecio = new SqlParameter();
                ParPrecio.ParameterName = "@precio";
                ParPrecio.SqlDbType = SqlDbType.Decimal;
                ParPrecio.Value = Postres.Precio;
                SqlCmd.Parameters.Add(ParPrecio);
//
                SqlParameter ParStock = new SqlParameter();
                ParStock.ParameterName = "@stock";
                ParStock.SqlDbType = SqlDbType.Float;
                ParStock.Value = Postres.Stock;
                SqlCmd.Parameters.Add(ParStock);
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
//-----------------------------------------------------------------------------------
        //Método Eliminar
        public string Eliminar(DPostres Postres)
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
                SqlCmd.CommandText = "sp_eliminar_postres";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdpostre = new SqlParameter();
                ParIdpostre.ParameterName = "@idpostre";
                ParIdpostre.SqlDbType = SqlDbType.Int;
                ParIdpostre.Value = Postres.Idpostre;
                SqlCmd.Parameters.Add(ParIdpostre);


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
//-------------------------------------------------------------------------
        //Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("postres");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_mostrar_postres";
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

//-------------------------------------------------------------------------
        //Método MostrarId busca por id y regresa el registro 
        public DataTable MostrarId(DPostres Postres)
        {
            DataTable DtResultado = new DataTable("postres");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_mostrarId_postres";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdpostre = new SqlParameter();
                ParIdpostre.ParameterName = "@Idpostre";
                ParIdpostre.SqlDbType = SqlDbType.Int;
                ParIdpostre.Value = Postres.Idpostre;
                SqlCmd.Parameters.Add(ParIdpostre);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


//------------------------------------------------------------------------------
        //Método  
        public DataTable ConsultaDinamica (DPostres Postres)
        {
            DataTable DtResultado = new DataTable("postres");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_postres_Dinamico";
                SqlCmd.CommandType = CommandType.StoredProcedure;
 

                SqlParameter ParConsulta = new SqlParameter();
                ParConsulta.ParameterName = "@consulta";
                ParConsulta.SqlDbType = SqlDbType.VarChar;
                ParConsulta.Size = 500;
                ParConsulta.Value = Postres.Consulta;
                SqlCmd.Parameters.Add(ParConsulta);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
        //-----------------------------------------------------------------------------------
        //Método Accion dinamica
        public string AccionDinamica(DPostres Postres)
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
                SqlCmd.CommandText = "sp_postres_Dinamico";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParConsulta = new SqlParameter();
                ParConsulta.ParameterName = @"consulta";
                ParConsulta.SqlDbType = SqlDbType.VarChar;
                ParConsulta.Value = Postres.Consulta;
                SqlCmd.Parameters.Add(ParConsulta);
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
//------------------------------------------------------------------------------
        //Método BuscarNombre 
        public DataTable BuscarNombre (DPostres Postres)
        {
            DataTable DtResultado = new DataTable("postres");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = DConexion.CnBDActivo;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_buscar_postres";
                SqlCmd.CommandType = CommandType.StoredProcedure;
 


                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Postres.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

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
