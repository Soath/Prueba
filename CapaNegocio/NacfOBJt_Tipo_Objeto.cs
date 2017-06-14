using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfOBJt_Tipo_Objeto
    {


        public static DataTable Mostrar()
        {
            return new DacfOBJt_Tipo_Objeto().Mostrar();
        }
    }
}
