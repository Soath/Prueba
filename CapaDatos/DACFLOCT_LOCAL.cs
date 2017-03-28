using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DACFLOCT_LOCAL
    {
        public int LOCID { get; set; }
        public String LOCLOCAL { get; set; }
        public String LOCDIRECCION { get; set; }
        public String SEGMENT { get; set; }
        public String Nombre_Buscado { get; set; }

        public DACFLOCT_LOCAL()
        {

        }

        public DACFLOCT_LOCAL(int parLOCID, String parLOCLOCAL, String parLOCDIRECCION, String parSEGMENT, String parNombreBus)
        {
            this.LOCID = parLOCID;
            this.LOCLOCAL = parLOCLOCAL;
            this.LOCDIRECCION = parLOCDIRECCION;
            this.SEGMENT = parSEGMENT;
            this.Nombre_Buscado = parNombreBus;
        }

        public DataTable SpListar()
        {
            DataTable TablaDatos = new DataTable("dbo.DACFLOCT_LOCAL");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDActivo;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "dbo.SpACFLOCT_LOCALListar";
                SqlComando.CommandType = CommandType.StoredProcedure;
                
                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.ListaCategorias. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public DataTable Mostrar(int parNumeroPagina, int parRegistrosPorPagina)
        {
            DataTable TablaDatos = new DataTable("dbo.DACFLOCT_LOCAL");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDActivo;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "dbo.SpLOCALMostrar";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNumeroPagina = new SqlParameter();
                ParNumeroPagina.ParameterName = "@NumeroPagina";
                ParNumeroPagina.SqlDbType = SqlDbType.Int;
                ParNumeroPagina.Value = parNumeroPagina;
                SqlComando.Parameters.Add(ParNumeroPagina);

                SqlParameter ParRegistrosPorPagina = new SqlParameter();
                ParRegistrosPorPagina.ParameterName = "@RegistrosPorPagina";
                ParRegistrosPorPagina.SqlDbType = SqlDbType.Int;
                ParRegistrosPorPagina.Value = parRegistrosPorPagina;
                SqlComando.Parameters.Add(ParRegistrosPorPagina);

                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.MostrarCategorias. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public int Tamaño(int parRegistrosPorPagina)
        {
            SqlConnection SqlConexion = new SqlConnection();
            int totalPaginas = 1;

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDActivo;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "dbo.TamañoLocal";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRegistrosPorPagina = new SqlParameter();
                ParRegistrosPorPagina.ParameterName = "@RegistrosPorPagina";
                ParRegistrosPorPagina.SqlDbType = SqlDbType.Int;
                ParRegistrosPorPagina.Value = parRegistrosPorPagina;
                SqlComando.Parameters.Add(ParRegistrosPorPagina);

                SqlParameter ParTotalPaginas = new SqlParameter();
                ParTotalPaginas.ParameterName = "@TotalPaginas";
                ParTotalPaginas.SqlDbType = SqlDbType.Int;
                ParTotalPaginas.Direction = ParameterDirection.Output;
                SqlComando.Parameters.Add(ParTotalPaginas);

                SqlComando.ExecuteNonQuery();

                totalPaginas = (int)SqlComando.Parameters["@TotalPaginas"].Value;
            }

            catch (Exception ex)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.TamañoCategorias. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return totalPaginas;
        }

        public DataTable Buscar(DACFLOCT_LOCAL parLOC)
        {
            DataTable TablaDatos = new DataTable("dbo.DACFLOCT_LOCAL");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDActivo;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "dbo.SpBuscar";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre_Buscado = new SqlParameter();
                ParNombre_Buscado.ParameterName = "@NombreBuscado";
                ParNombre_Buscado.SqlDbType = SqlDbType.VarChar;
                ParNombre_Buscado.Size = parLOC.Nombre_Buscado.Length;
                ParNombre_Buscado.Value = parLOC.Nombre_Buscado;
                SqlComando.Parameters.Add(ParNombre_Buscado);

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.BuscarCategoria. " + ex.Message, ex);
            }

            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }

            return TablaDatos;
        }

        public string Insertar(DACFLOCT_LOCAL parCategorias)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDActivo;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.InsertarCategoria";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParLOCLOCAL = new SqlParameter();
                ParLOCLOCAL.ParameterName = "@LOCLOCAL";
                ParLOCLOCAL.SqlDbType = SqlDbType.VarChar;
                ParLOCLOCAL.Size = parCategorias.LOCLOCAL.Length;
                ParLOCLOCAL.Value = parCategorias.LOCLOCAL;
                SqlComando.Parameters.Add(ParLOCLOCAL);

                SqlParameter ParLOCDIRECCION = new SqlParameter();
                ParLOCDIRECCION.ParameterName = "@LOCDIRECCION";
                ParLOCDIRECCION.SqlDbType = SqlDbType.VarChar;
                ParLOCDIRECCION.Size = parCategorias.LOCDIRECCION.Length;
                ParLOCDIRECCION.Value = parCategorias.LOCDIRECCION;
                SqlComando.Parameters.Add(ParLOCDIRECCION);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos.";
                }
                else if (ex.Number == 2627)
                {
                    Respuesta = "Ya existe una categoría con ese Nombre.";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "No puedes dejar el campo Nombre vacío.";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Produccion.InsertarCategoria. " + ex.Message;
                }
            }

            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }

            return Respuesta;
        }

        public string Eliminar(DACFLOCT_LOCAL parCategorias)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDActivo;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Produccion.EliminarCategoria";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParLOCID = new SqlParameter();
                ParLOCID.ParameterName = "@LOCID";
                ParLOCID.SqlDbType = SqlDbType.Int;
                ParLOCID.Value = parCategorias.LOCID;
                SqlComando.Parameters.Add(ParLOCID);

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    Respuesta = "No puedes eliminar una categoría que cuenta con Productos. Debes eliminar o actualizar sus Productos antes de eliminar la categoría.";
                }

                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Produccion.EliminarCategoria. " + ex.Message;
                }
            }

            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }

            return Respuesta;
        }

        public string Editar(DACFLOCT_LOCAL parLocal)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDActivo;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "dbo.SpACFLOCT_LOCALActualizar";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParLOCID = new SqlParameter();
                ParLOCID.ParameterName = "@LOCID";
                ParLOCID.SqlDbType = SqlDbType.Int;
                ParLOCID.Value = parLocal.LOCID;
                SqlComando.Parameters.Add(ParLOCID);

                SqlParameter ParLOCLOCAL = new SqlParameter();
                ParLOCLOCAL.ParameterName = "@LOCLOCAL";
                ParLOCLOCAL.SqlDbType = SqlDbType.VarChar;
                ParLOCLOCAL.Size = parLocal.LOCLOCAL.Length;
                ParLOCLOCAL.Value = parLocal.LOCLOCAL;
                SqlComando.Parameters.Add(ParLOCLOCAL);

                SqlParameter ParLOCDIRECCION = new SqlParameter();
                ParLOCDIRECCION.ParameterName = "@LOCDIRECCION";
                ParLOCDIRECCION.SqlDbType = SqlDbType.VarChar;
                ParLOCDIRECCION.Size = parLocal.LOCDIRECCION.Length;
                ParLOCDIRECCION.Value = parLocal.LOCDIRECCION;
                SqlComando.Parameters.Add(ParLOCDIRECCION);

                SqlParameter ParSEGMENT = new SqlParameter();
                ParSEGMENT.ParameterName = "@SEGMENT";
                ParSEGMENT.SqlDbType = SqlDbType.VarChar;
                ParSEGMENT.Size = parLocal.SEGMENT.Length;
                ParSEGMENT.Value = parLocal.SEGMENT;
                SqlComando.Parameters.Add(ParSEGMENT);


                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos.";
                }
                else if (ex.Number == 2627)
                {
                    Respuesta = "Ya existe una categoría con ese Nombre.";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "No puedes dejar el campo Nombre vacío.";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Produccion.EditarCategoria. " + ex.Message;
                }
            }

            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }

            return Respuesta;
        }
    }
}