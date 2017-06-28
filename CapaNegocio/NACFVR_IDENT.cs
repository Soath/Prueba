using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NACFVR_IDENT
    {


        public static DataTable Mostrar()
        {
            return new DACFVR_IDENT().Mostrar();
        }
    }
}
