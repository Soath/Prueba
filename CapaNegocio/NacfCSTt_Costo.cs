using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfCSTt_Costo
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
            string sCSTid, 
            string sCSTdescripcion, 
            string sCSTdetalle,
            string sCSTabreviado, 
            string sACTid, 
            string sCSTid_costo)
        {
            DacfCSTt_Costo Obj = new DacfCSTt_Costo();
            Obj.CSTid = sCSTid;
            Obj.CSTdescripcion = sCSTdescripcion;
            Obj.CSTdetalle = sCSTdetalle;
            Obj.CSTabreviado = sCSTabreviado;
            Obj.ACTid = sACTid;
            Obj.CSTid_costo = sCSTid_costo;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
            string sCSTid, 
            string sCSTdescripcion, 
            string sCSTdetalle,
            string sCSTabreviado, 
            string sACTid, 
            string sCSTid_costo)
        {
            DacfCSTt_Costo Obj = new DacfCSTt_Costo();
            Obj.CSTid = sCSTid;
            Obj.CSTdescripcion = sCSTdescripcion;
            Obj.CSTdetalle = sCSTdetalle;
            Obj.CSTabreviado = sCSTabreviado;
            Obj.ACTid = sACTid;
            Obj.CSTid_costo = sCSTid_costo;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string sCSTid)
        {
            DacfCSTt_Costo Obj = new DacfCSTt_Costo();
            Obj.CSTid = sCSTid;
            return Obj.Eliminar(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DacfCSTt_Costo().Mostrar();
        }


        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string sCSTdescripcion)
        {
            DacfCSTt_Costo Obj = new DacfCSTt_Costo();
            Obj.CSTdescripcion = sCSTdescripcion;
            return Obj.Buscar(Obj);
        }

    }
}
