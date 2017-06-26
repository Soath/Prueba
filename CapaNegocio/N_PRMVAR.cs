using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class N_PRMVAR
    {

        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(string mGRPid_variable,
            string mPRM_descripcion,
            string mPRM_valor,
            string mPRM_estado,
            string mPRM_frmnombre)
        {
            D_PRMVAR Obj = new D_PRMVAR();
            Obj.GRPid_variable= mGRPid_variable;
            Obj.PRM_descripcion = mPRM_descripcion;
            Obj.PRM_valor = mPRM_valor;
            Obj.PRM_estado = mPRM_estado;
            Obj.PRM_frmnombre = mPRM_frmnombre;
            return Obj.Insertar(Obj);
        }
        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(string mGRPid,
            string mGRPid_variable,
            string mPRM_descripcion,
            string mPRM_valor,
            string mPRM_estado,
            string mPRM_frmnombre)
        {
            D_PRMVAR Obj = new D_PRMVAR();
            Obj.GRPid = mGRPid;
            Obj.GRPid_variable = mGRPid_variable;
            Obj.PRM_descripcion = mPRM_descripcion;
            Obj.PRM_valor = mPRM_valor;
            Obj.PRM_estado = mPRM_estado;
            Obj.PRM_frmnombre = mPRM_frmnombre;

            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string mGRPid)
        {
            D_PRMVAR Obj = new D_PRMVAR();
            Obj.GRPid = mGRPid;
            return Obj.Eliminar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new D_PRMVAR().Mostrar();
        }
        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string mGRPid)
        {
            D_PRMVAR Obj = new D_PRMVAR();
            Obj.GRPid = mGRPid; 
            return Obj.Buscar(Obj);
        }

    }
}
