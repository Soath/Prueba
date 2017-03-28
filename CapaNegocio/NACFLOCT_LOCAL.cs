using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NACFLOCT_LOCAL
    {
        public static DataTable ListaACFLOCT_LOCAL()
        {
            return new DACFLOCT_LOCAL().SpListar();
        }

        public static DataTable Mostrar(int parNumeroPagina, int parRegistrosPorPagina)
        {
            return new DACFLOCT_LOCAL().Mostrar(parNumeroPagina, parRegistrosPorPagina);
        }

        public static int Tamaño(int parRegistrosPorPagina)
        {
            return new DACFLOCT_LOCAL().Tamaño(parRegistrosPorPagina);
        }


        public static DataTable Buscar(String parNombre_Buscado)
        {
            DACFLOCT_LOCAL local = new DACFLOCT_LOCAL();
            local.Nombre_Buscado = parNombre_Buscado;

            return local.Buscar(local);
        }

        public static String Eliminar(int parLOCID)
        {
            DACFLOCT_LOCAL local = new DACFLOCT_LOCAL();
            local.LOCID = parLOCID;

            return local.Eliminar(local);
        }

        public static String Insertar(String parLOCLOCAL, String parLOCDIRECCION)
        {
            DACFLOCT_LOCAL local = new DACFLOCT_LOCAL();
            local.LOCLOCAL = parLOCLOCAL;
            local.LOCDIRECCION = parLOCDIRECCION;

            return local.Insertar(local);
        }

        public static String Editar(int parLOCID, String parLOCLOCAL, String parLOCDIRECCION, String ParSEGMENT)
        {
            DACFLOCT_LOCAL local = new DACFLOCT_LOCAL();
            local.LOCID = parLOCID;
            local.LOCLOCAL = parLOCLOCAL;
            local.LOCDIRECCION = parLOCDIRECCION;
            local.SEGMENT = ParSEGMENT;
            return local.Editar(local);
        }
    }
}
