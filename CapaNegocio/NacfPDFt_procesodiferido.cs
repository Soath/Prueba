using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfPDFt_procesodiferido
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
            string iPDFcodigo,
            string sPDFperiodo,
            string dtPDFfecha,
            string sPDFreponsable,
            string bPDFestado)
        
        {
            DacfPDFt_procesodiferido Obj = new DacfPDFt_procesodiferido();
            Obj.PDFcodigo = iPDFcodigo;
            Obj.PDFperiodo = sPDFperiodo;
            Obj.tPDFfecha = dtPDFfecha;
            Obj.PDFreponsable = sPDFreponsable;
            Obj.PDFestado = bPDFestado;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
            string iPDFcodigo,
            string sPDFperiodo,
            string dtPDFfecha,
            string sPDFreponsable,
            string bPDFestado)
        {
            DacfPDFt_procesodiferido Obj = new DacfPDFt_procesodiferido();
            Obj.PDFcodigo = iPDFcodigo;
            Obj.PDFperiodo = sPDFperiodo;
            Obj.tPDFfecha = dtPDFfecha;
            Obj.PDFreponsable = sPDFreponsable;
            Obj.PDFestado = bPDFestado;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string iPDFcodigo)
        {
            DacfPDFt_procesodiferido Obj = new DacfPDFt_procesodiferido();
            Obj.PDFcodigo = iPDFcodigo;
            return Obj.Eliminar(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DacfPDFt_procesodiferido().Mostrar();
        }


        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string sPDFreponsable)
        {
            DacfPDFt_procesodiferido Obj = new DacfPDFt_procesodiferido();
            Obj.PDFreponsable = sPDFreponsable;
            return Obj.Buscar(Obj);
        }

    }
}
