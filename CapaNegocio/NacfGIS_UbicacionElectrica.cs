using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfGIS_UbicacionElectrica
    {

    //   //M�todo Insertar que llama al m�todo Insertar de la clase 
    //   //de la CapaDatos
    //   public static string Insertar(string mACTid, string mACTactividad)
    //   {
    //       //DacfGIS_UbicacionElectrica Obj = new DacfGIS_UbicacionElectrica();
    //       //Obj.ACTid = mACTid;
    //       //Obj.ACTactividad = mACTactividad;
    //       //return Obj.Insertar(Obj);
    //   }
    //   //------------------------------------------------------------------
    //   //Metodo Editar que llama al metodo Editar de la clase 
    //   //de la CapaDatos
    //   public static string Editar(string mACTid, string mACTactividad)
    //   {
    //       DacfGIS_UbicacionElectrica Obj = new DacfGIS_UbicacionElectrica();
    //       Obj.ACTid = mACTid;
    //       Obj.ACTactividad = mACTactividad;
    //       return Obj.Editar(Obj);
    //   }
    //   //------------------------------------------------------------------
    //   //M�todo Eliminar que llama al m�todo Eliminar de la clase 
    //   //de la CapaDatos
    //   public static string Eliminar(string mACTid)
    //   {
    //       DacfGIS_UbicacionElectrica Obj = new DacfGIS_UbicacionElectrica();
    //       Obj.ACTid = mACTid;
    //       return Obj.Eliminar(Obj);
    //   }
       //------------------------------------------------------------------
       //M�todo Mostrar que llama al m�todo Mostrar de la clase 
       //de la CapaDatos
       public static DataTable Mostrar(string UBEestado)
       {
           return new DacfGIS_UbicacionElectrica().Mostrar(UBEestado);
       }
       //------------------------------------------------------------------
    //   //M�todo Buscar que llama al m�todo BuscarNombre
    //   //de la clase a de la CapaDatos
    //
    //   public static DataTable Buscar(string iACTid)
    //   {
    //       DacfGIS_UbicacionElectrica Obj = new DacfGIS_UbicacionElectrica();
    //       Obj.ACTid = iACTid;
    //       return Obj.Buscar(Obj);
    //   }

    }
}

