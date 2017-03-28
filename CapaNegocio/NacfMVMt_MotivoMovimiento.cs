using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfMVMt_MotivoMovimiento
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
            string mTMVid, 
            string mMVMid, 
            string mMVMmotivomovimiento, 
            string mMVMjustificacion)
        {
            DAcfMVMt_MotivoMovimiento Obj = new DAcfMVMt_MotivoMovimiento();
            Obj.TMVid = mTMVid;
            Obj.MVMid = mMVMid;
            Obj.MVMmotivomovimiento = mMVMmotivomovimiento;
            Obj.MVMjustificacion = mMVMjustificacion;
            return Obj.Insertar(Obj);
        }


        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
            string mTMVid, 
            string mMVMid, 
            string mMVMmotivomovimiento, 
            string mMVMjustificacion)
        {
            DAcfMVMt_MotivoMovimiento Obj = new DAcfMVMt_MotivoMovimiento();
            Obj.TMVid = mTMVid;
            Obj.MVMid = mMVMid;
            Obj.MVMmotivomovimiento = mMVMmotivomovimiento;
            Obj.MVMjustificacion = mMVMjustificacion;
            return Obj.Editar(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string mMVMid)
        {
            DAcfMVMt_MotivoMovimiento Obj = new DAcfMVMt_MotivoMovimiento();
            Obj.MVMid = mMVMid;
            return Obj.Eliminar(Obj);
        }



        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DAcfMVMt_MotivoMovimiento().Mostrar();
        }


        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string iMVMid)
        {
            DAcfMVMt_MotivoMovimiento Obj = new DAcfMVMt_MotivoMovimiento();
            Obj.MVMid = iMVMid;
            return Obj.Buscar(Obj);
        }
    }
}
