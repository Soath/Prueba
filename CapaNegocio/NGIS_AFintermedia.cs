using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NGIS_AFintermedia
    {
        //Método insertar tabla intermedia
        public static string Insertar(
            string mid_elem_gis,
            string mdescrip_elem_gis,
            string mcodigo_af,
            string mid_sistema_electrico,
            string mnombre_sistema_electrico,
            string mid_set,
            string mnombre_set,
            string mid_alimentador,
            string mnombre_alimentador,
            string mid_sed,
            string mnombre_sed,
            string mid_circuito,
            string mnombre_circuito,
            string mid_punto_inicio,
            string mpunto_inicio_x,
            string mpunto_inicio_y,
            string mid_punto_fin,
            string mpunto_fin_x,
            string mpunto_fin_y,
            string mlinea_at,
            string melem_punto_inicio_at,
            string mid_punto_inicio_at,
            string mpunto_inicio_at_x,
            string mpunto_inicio_at_y,
            string melem_punto_fin_at,
            string mid_punto_fin_at,
            string mpunto_fin_at_x,
            string mpunto_fin_at_y
            )
        {
            DGIS_AFintermedia Obj = new DGIS_AFintermedia();
            Obj.id_elem_gis = mid_elem_gis;
            Obj.descrip_elem_gis = mdescrip_elem_gis;
            Obj.codigo_af = mcodigo_af;
            Obj.id_sistema_electrico = mid_sistema_electrico;
            Obj.nombre_sistema_electrico = mnombre_sistema_electrico;
            Obj.id_set = mid_set;
            Obj.nombre_set = mnombre_set;
            Obj.id_alimentador = mid_alimentador;
            Obj.nombre_alimentador = mnombre_alimentador;
            Obj.id_sed = mid_sed;
            Obj.nombre_sed = mnombre_sed;
            Obj.id_circuito = mid_circuito;
            Obj.nombre_circuito = mnombre_circuito;
            Obj.id_punto_inicio = mid_punto_inicio;
            Obj.punto_inicio_x = mpunto_inicio_x;
            Obj.punto_inicio_y = mpunto_inicio_y;
            Obj.id_punto_fin = mid_punto_fin;
            Obj.punto_fin_x = mpunto_fin_x;
            Obj.punto_fin_y = mpunto_fin_y;
            Obj.linea_at = mlinea_at;
            Obj.elem_punto_inicio_at = melem_punto_inicio_at;
            Obj.id_punto_inicio_at = mid_punto_inicio_at;
            Obj.punto_inicio_at_x = mpunto_inicio_at_x;
            Obj.punto_inicio_at_y = mpunto_inicio_at_y;
            Obj.elem_punto_fin_at = melem_punto_fin_at;
            Obj.id_punto_fin_at = mid_punto_fin_at;
            Obj.punto_fin_at_x = mpunto_fin_at_x;
            Obj.punto_fin_at_y = mpunto_fin_at_y;
            return Obj.Insertar(Obj);
        }
        // Metodo EDitar de Tabla Intermedia
        public static string Editar(
            string mid_elem_gis,
            string mdescrip_elem_gis,
            string mcodigo_af,
            string mid_sistema_electrico,
            string mnombre_sistema_electrico,
            string mid_set,
            string mnombre_set,
            string mid_alimentador,
            string mnombre_alimentador,
            string mid_sed,
            string mnombre_sed,
            string mid_circuito,
            string mnombre_circuito,
            string mid_punto_inicio,
            string mpunto_inicio_x,
            string mpunto_inicio_y,
            string mid_punto_fin,
            string mpunto_fin_x,
            string mpunto_fin_y,
            string mlinea_at,
            string melem_punto_inicio_at,
            string mid_punto_inicio_at,
            string mpunto_inicio_at_x,
            string mpunto_inicio_at_y,
            string melem_punto_fin_at,
            string mid_punto_fin_at,
            string mpunto_fin_at_x,
            string mpunto_fin_at_y
            )
        {
            DGIS_AFintermedia Obj = new DGIS_AFintermedia();
            Obj.id_elem_gis = mid_elem_gis;
            Obj.descrip_elem_gis = mdescrip_elem_gis;
            Obj.codigo_af = mcodigo_af;
            Obj.id_sistema_electrico = mid_sistema_electrico;
            Obj.nombre_sistema_electrico = mnombre_sistema_electrico;
            Obj.id_set = mid_set;
            Obj.nombre_set = mnombre_set;
            Obj.id_alimentador = mid_alimentador;
            Obj.nombre_alimentador = mnombre_alimentador;
            Obj.id_sed = mid_sed;
            Obj.nombre_sed = mnombre_sed;
            Obj.id_circuito = mid_circuito;
            Obj.nombre_circuito = mnombre_circuito;
            Obj.id_punto_inicio = mid_punto_inicio;
            Obj.punto_inicio_x = mpunto_inicio_x;
            Obj.punto_inicio_y = mpunto_inicio_y;
            Obj.id_punto_fin = mid_punto_fin;
            Obj.punto_fin_x = mpunto_fin_x;
            Obj.punto_fin_y = mpunto_fin_y;
            Obj.linea_at = mlinea_at;
            Obj.elem_punto_inicio_at = melem_punto_inicio_at;
            Obj.id_punto_inicio_at = mid_punto_inicio_at;
            Obj.punto_inicio_at_x = mpunto_inicio_at_x;
            Obj.punto_inicio_at_y = mpunto_inicio_at_y;
            Obj.elem_punto_fin_at = melem_punto_fin_at;
            Obj.id_punto_fin_at = mid_punto_fin_at;
            Obj.punto_fin_at_x = mpunto_fin_at_x;
            Obj.punto_fin_at_y = mpunto_fin_at_y;
            return Obj.Editar(Obj);
        }
        //Metodo Mostras de Tabla Intermedia
        public static DataTable Mostrar()
        {
            return new DGIS_AFintermedia().Mostrar();
        }
        //Metodo Buscar de Tabla Intermedia
        public static DataTable Buscar(
            string mid_elem_gis
            )
        {
            DGIS_AFintermedia Obj = new DGIS_AFintermedia();
            Obj.id_elem_gis = mid_elem_gis;
            return Obj.Buscar(Obj);
        }

    }
}
