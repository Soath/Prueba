//*************************************************************************************
//-- Autor:  Generador  Tony Valdez
//-- Capa Negocio
//-- Fecha Creación:17/02/2017 07:24:12 p.m.
//******************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NPostres
    {
    //------------------------------------------------------------------
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(string idpostre,string nombre,string precio,string stock)
        {
            DPostres Obj = new DPostres();
                 Obj.Idpostre = idpostre;
                 Obj.Nombre = nombre;
                 Obj.Precio = precio;
                 Obj.Stock = stock;
            return Obj.Insertar(Obj);
        }

    //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(string idpostre,string nombre,string precio,string stock)
        {
            DPostres Obj = new DPostres();
                 Obj.Idpostre = idpostre;
                 Obj.Nombre = nombre;
                 Obj.Precio = precio;
                 Obj.Stock = stock;
            return Obj.Editar(Obj);
        }

    //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string idpostre)
        {
            DPostres Obj = new DPostres();
            Obj.Idpostre  = idpostre;
            return Obj.Eliminar(Obj);
        }

    //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DPostres().Mostrar();
        }

    //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo MostrarId de la clase DPostres
        //de la CapaDatos
        public static DataTable MostrarId(string parId)
        {
            DPostres Obj = new DPostres();
            Obj.Idpostre  = parId;
            return new DPostres().MostrarId(Obj);
        }

    //------------------------------------------------------------------
        //Metodo ExisteId que llama al m�todo MostrarId de la clase DPostres
        //de la CapaDatos
        public static bool ExisteId(string parid)
        {
            DPostres Obj = new DPostres();
            Obj.Idpostre  =  parid;
                            DataTable datos = new DPostres().MostrarId(Obj);
                            if(datos.Rows.Count == 0)
                                return false;
                            else
                                return true;
        }

    //------------------------------------------------------------------
        //M�todo BuscarNombre que llama al m�todo ConsultaDinamica
        //de la clase DPostresa de la CapaDatos

        public static DataTable ConsultaDinamica(string consulta)
        {
            DPostres Obj = new DPostres();
            Obj.Consulta = consulta;
            return Obj.ConsultaDinamica(Obj);
       }

        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Accion dinamica de la clase DPostres
        //de la CapaDatos
        public static string AccionDinamica(string accion)
        {
            DPostres Obj = new DPostres();
            Obj.Consulta = accion;
            return Obj.AccionDinamica(Obj);
        }
    //------------------------------------------------------------------
        //M�todo BuscarNombre que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable BuscarNombre(string textobuscar)
        {
            DPostres Obj = new DPostres();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
       }
   }
  }
