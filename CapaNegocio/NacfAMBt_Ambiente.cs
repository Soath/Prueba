using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfAMBt_Ambiente
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
            string mLOCid, 
            string mAMBid, 
            string mAMBambiente)
        {
            DAcfAMBt_Ambiente Obj = new DAcfAMBt_Ambiente();
            Obj.LOCid = mLOCid;
            Obj.AMBid = mAMBid;
            Obj.AMBambiente = mAMBambiente;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
            string mLOCid, 
            string mAMBid, 
            string mAMBambiente)
        {
            DAcfAMBt_Ambiente Obj = new DAcfAMBt_Ambiente();
            Obj.LOCid = mLOCid;
            Obj.AMBid = mAMBid;
            Obj.AMBambiente = mAMBambiente;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string mAMBid)
        {
            DAcfAMBt_Ambiente Obj = new DAcfAMBt_Ambiente();
            Obj.AMBid = mAMBid;
            return Obj.Eliminar(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DAcfAMBt_Ambiente().Mostrar();
        }


        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string iAMBid)
        {
            DAcfAMBt_Ambiente Obj = new DAcfAMBt_Ambiente();
            Obj.AMBid = iAMBid;
            return Obj.Buscar(Obj);
        }

    }
}
