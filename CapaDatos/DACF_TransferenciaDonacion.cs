using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DACF_TransferenciaDonacion
    {


        public DataTable Mostrar()
        {
            string rpta = "";
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();



            try
            {
                //Codigo
                SqlCon.ConnectionString = DConexion.CnBDI;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCon.Open();
                SqlCmd.CommandText = "SELECT TOP 20 [INVZU],[ANLN1],[TXT50],[KOSTL],[PERNR],[INVNR],[ESTADO],[ANLUE],[ANLKL],[HERST],[TYPBZ],[MEINS],[MENGE],[ZZPRPU],[ZZARPU],[LAND1],[URJHR],[KFZKZ],[AKTIV],[LIFNR],[NDJARF],[NDJARC],[AFASLF],[AFASLC] FROM [dbMEGA_BDI].[dbo].[bdiMAFpActivoFijo]";
                

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "NO se Actualizo el Registro";
            }

            catch (Exception ex)
            {
                rpta = ex.Message;
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;
        }


    }


}
