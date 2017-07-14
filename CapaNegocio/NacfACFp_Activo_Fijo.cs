using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NacfACFp_Activo_Fijo
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
         string iACFid,         
         string sBUKRS,                  
         string sSEGMENT,                 
         string sANLKL,                   
         string sPERNR,                   
         string sCSTid,                   
         string sMVMid,                   
         string dtACFfmovimiento,         
         string sVNRid,                   
         string sACFdescripcion,          
         string dtACFfincorporacion,      
         string decACFfcapitalizacion,     
         string iACFvutiltribanio,        
         string iACFvutiltribdia,         
         string decACFvalortrib,          
         string iACFvutilniifanio,        
         string iACFvutilniifdia,         
         string decACFvalorniif,          
         string sACFdepacutrib,           
         string decACFdepacuniif,         
         string sACFobra,                 
         //string sACFord41,                
         //string sACFord42,                
         //string sACFord43,                
         //string sACFord44,                
         string sACFanlue,                
         string decACFfactortrib,         
         string decACFfactorniif,         
         string sACFcuenta,               
         string sACFcuentadep,            
         string sCMPid,                   
         string sACFobservacion,          
         string sLIFNR,                   
         string sACFnotaingreso,          
         string sACFfechanotaingreso,     
         string sACFordencompra,          
         string dtACFfechaordencompra,    
         string sBLART,                   
         string sACFcomprobante,          
         string sKOSTL,                   
         string iAMBid,                   
         string iUBEid,                   
         string dtACFfechacomprobante,    
         string sV_T087U_ANLUE,
         string sACFtipo_activo,
         string cACFAnulado,
         string cACFid_Padre,
         string cACFtipo_orden,
         string cOBJid_objeto,
         string cCRPid_crp
         )         
        {
            DacfACFp_Activo_Fijo Obj = new DacfACFp_Activo_Fijo();
            Obj.ACFid = iACFid;
            Obj.BUKRS = sBUKRS;
            Obj.SEGMENT = sSEGMENT;
            Obj.ANLKL = sANLKL;
            Obj.PERNR = sPERNR;
            Obj.CSTid = sCSTid;
            Obj.MVMid = sMVMid;
            Obj.ACFfmovimiento = dtACFfmovimiento;
            Obj.VNRid = sVNRid;
            Obj.ACFdescripcion = sACFdescripcion;
            Obj.ACFfincorporacion = dtACFfincorporacion;
            Obj.ACFfcapitalizacion = decACFfcapitalizacion;
            Obj.ACFvutiltribanio = iACFvutiltribanio;
            Obj.ACFvutiltribdia = iACFvutiltribdia;
            Obj.ACFvalortrib = decACFvalortrib;
            Obj.ACFvutilniifanio = iACFvutilniifanio;
            Obj.ACFvutilniifdia = iACFvutilniifdia;
            Obj.ACFvalorniif = decACFvalorniif;
            Obj.ACFdepacutrib = sACFdepacutrib;
            Obj.ACFdepacuniif = decACFdepacuniif;
            Obj.ACFobra = sACFobra;
            //Obj.ACFord41 = sACFord41;
            //Obj.ACFord42 = sACFord42;
            //Obj.ACFord43 = sACFord43;
            //Obj.ACFord44 = sACFord44;
            Obj.ACFanlue = sACFanlue;
            Obj.ACFfactortrib = decACFfactortrib;
            Obj.ACFfactorniif = decACFfactorniif;
            Obj.ACFcuenta = sACFcuenta;
            Obj.ACFcuentadep = sACFcuentadep;
            Obj.CMPid = sCMPid;
            Obj.ACFobservacion = sACFobservacion;
            Obj.LIFNR = sLIFNR;
            Obj.ACFnotaingreso = sACFnotaingreso;
            Obj.ACFfechanotaingreso = sACFfechanotaingreso;
            Obj.ACFordencompra = sACFordencompra;
            Obj.ACFfechaordencompra = dtACFfechaordencompra;
            Obj.BLART = sBLART;
            Obj.ACFcomprobante = sACFcomprobante;
            Obj.KOSTL = sKOSTL;
            Obj.AMBid = iAMBid;
            Obj.UBEid = iUBEid;
            Obj.ACFfechacomprobante = dtACFfechacomprobante;
            Obj.V_T087U_ANLUE = sV_T087U_ANLUE;
            Obj.ACFtipo_activo = sACFtipo_activo;
            Obj.ACFAnulado = cACFAnulado;
            Obj.ACFid_Padre = cACFid_Padre;
            Obj.ACFtipo_orden = cACFtipo_orden;
            Obj.OBJid_objeto= cOBJid_objeto;
            Obj.CRPid_crp= cCRPid_crp;
            return Obj.Insertar(Obj);

        }
        public static string SAPIMPORT(
         string iACFid,
         string sBUKRS,
         string sSEGMENT,
         string sANLKL,
         string sPERNR,
         string sCSTid,
         string sMVMid,
         //string dtACFfmovimiento,
         string sVNRid,
         string sACFdescripcion,
         string dtACFfincorporacion,
         //string decACFfcapitalizacion,
         string iACFvutiltribanio,
         string iACFvutiltribdia,
         string decACFvalortrib,
         string iACFvutilniifanio,
         string iACFvutilniifdia,
         string decACFvalorniif,
         string sACFdepacutrib,
         string decACFdepacuniif,
         string sACFobra,
         //string sACFord41,                
         //string sACFord42,                
         //string sACFord43,                
         //string sACFord44,                
         string sACFanlue,
         //  string decACFfactortrib,
         //  string decACFfactorniif,
         string sACFcuenta,
         string sACFcuentadep,
         string sCMPid,
         string sACFobservacion,
         string sLIFNR,
         string sACFnotaingreso,
         //string sACFfechanotaingreso,
         string sACFordencompra,
         string dtACFfechaordencompra,
         string sBLART,
         string sACFcomprobante,
         string sKOSTL,
         string iAMBid,
         string iUBEid,
         //string dtACFfechacomprobante,
         string sV_T087U_ANLUE,
         string sACFtipo_activo,
         string cACFAnulado,
         string cACFid_Padre,
         string cACFtipo_orden,
         string cOBJid_objeto,
         string cCRPid_crp,
         string iACTid
         )
        {
            DacfACFp_Activo_Fijo Obj = new DacfACFp_Activo_Fijo();
            Obj.ACFid = iACFid;
            Obj.BUKRS = sBUKRS;
            Obj.SEGMENT = sSEGMENT;
            Obj.ANLKL = sANLKL;
            Obj.PERNR = sPERNR;
            Obj.CSTid = sCSTid;
            Obj.MVMid = sMVMid;
           // Obj.ACFfmovimiento = dtACFfmovimiento;
            Obj.VNRid = sVNRid;
            Obj.ACFdescripcion = sACFdescripcion;
            Obj.ACFfincorporacion = dtACFfincorporacion;
            //Obj.ACFfcapitalizacion = decACFfcapitalizacion;
            Obj.ACFvutiltribanio = iACFvutiltribanio;
            Obj.ACFvutiltribdia = iACFvutiltribdia;
            Obj.ACFvalortrib = decACFvalortrib;
            Obj.ACFvutilniifanio = iACFvutilniifanio;
            Obj.ACFvutilniifdia = iACFvutilniifdia;
            Obj.ACFvalorniif = decACFvalorniif;
            Obj.ACFdepacutrib = sACFdepacutrib;
            Obj.ACFdepacuniif = decACFdepacuniif;
            Obj.ACFobra = sACFobra;
            //Obj.ACFord41 = sACFord41;
            //Obj.ACFord42 = sACFord42;
            //Obj.ACFord43 = sACFord43;
            //Obj.ACFord44 = sACFord44;
            Obj.ACFanlue = sACFanlue;
            // Obj.ACFfactortrib = decACFfactortrib;
            // Obj.ACFfactorniif = decACFfactorniif;
            Obj.ACFcuenta = sACFcuenta;
            Obj.ACFcuentadep = sACFcuentadep;
            Obj.CMPid = sCMPid;
            Obj.ACFobservacion = sACFobservacion;
            Obj.LIFNR = sLIFNR;
            Obj.ACFnotaingreso = sACFnotaingreso;
            //Obj.ACFfechanotaingreso = sACFfechanotaingreso;
            Obj.ACFordencompra = sACFordencompra;
            Obj.ACFfechaordencompra = dtACFfechaordencompra;
            Obj.BLART = sBLART;
            Obj.ACFcomprobante = sACFcomprobante;
            Obj.KOSTL = sKOSTL;
            Obj.AMBid = iAMBid;
            Obj.UBEid = iUBEid;
            //Obj.ACFfechacomprobante = dtACFfechacomprobante;
            Obj.V_T087U_ANLUE = sV_T087U_ANLUE;
            Obj.ACFtipo_activo = sACFtipo_activo;
            Obj.ACFAnulado = cACFAnulado;
            Obj.ACFid_Padre = cACFid_Padre;
            Obj.ACFtipo_orden = cACFtipo_orden;
            Obj.OBJid_objeto = cOBJid_objeto;
            Obj.CRPid_crp = cCRPid_crp;
            Obj.ACTid = iACTid;
            return Obj.SAPIMPORT(Obj);

        }
        public static string Insertar2(string sACFdescripcion)
        {
            DacfACFp_Activo_Fijo Obj = new DacfACFp_Activo_Fijo();
            Obj.ACFdescripcion = sACFdescripcion;
            return Obj.Insertar2(Obj);
        }
        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
         string iACFid,         
         string sBUKRS,
         string sSEGMENT,
         string sANLKL,
         string sPERNR,
         string sCSTid,
         string sMVMid,
         string dtACFfmovimiento,
         string sVNRid,
         string sACFdescripcion,
         string dtACFfincorporacion,
         string decACFfcapitalizacion,
         string iACFvutiltribanio,
         string iACFvutiltribdia,
         string decACFvalortrib,
         string iACFvutilniifanio,
         string iACFvutilniifdia,
         string decACFvalorniif,
         string sACFdepacutrib,
         string decACFdepacuniif,
         string sACFobra,
         //string sACFord41,
         //string sACFord42,
         //string sACFord43,
         //string sACFord44,
         string sACFanlue,
         string decACFfactortrib,
         string decACFfactorniif,
         string sACFcuenta,
         string sACFcuentadep,
         string sCMPid,
         string sACFobservacion,
         string sLIFNR,
         string sACFnotaingreso,
         string sACFfechanotaingreso,
         string sACFordencompra,
         string dtACFfechaordencompra,
         string sBLART,
         string sACFcomprobante,
         string sKOSTL,
         string iAMBid,
         string iUBEid,
         string dtACFfechacomprobante,
         string sV_T087U_ANLUE,
         string sACFtipo_activo,
         string cACFAnulado,
         string cACFid_Padre,
         string cACFtipo_orden,
         string cOBJid_objeto,
         string cCRPid_crp

         )  
        {
            DacfACFp_Activo_Fijo Obj = new DacfACFp_Activo_Fijo();
            Obj.ACFid = iACFid;            
            Obj.BUKRS = sBUKRS;
            Obj.SEGMENT = sSEGMENT;
            Obj.ANLKL = sANLKL;
            Obj.PERNR = sPERNR;
            Obj.CSTid = sCSTid;
            Obj.MVMid = sMVMid;
            Obj.ACFfmovimiento = dtACFfmovimiento;
            Obj.VNRid = sVNRid;
            Obj.ACFdescripcion = sACFdescripcion;
            Obj.ACFfincorporacion = dtACFfincorporacion;
            Obj.ACFfcapitalizacion = decACFfcapitalizacion;
            Obj.ACFvutiltribanio = iACFvutiltribanio;
            Obj.ACFvutiltribdia = iACFvutiltribdia;
            Obj.ACFvalortrib = decACFvalortrib;
            Obj.ACFvutilniifanio = iACFvutilniifanio;
            Obj.ACFvutilniifdia = iACFvutilniifdia;
            Obj.ACFvalorniif = decACFvalorniif;
            Obj.ACFdepacutrib = sACFdepacutrib;
            Obj.ACFdepacuniif = decACFdepacuniif;
            Obj.ACFobra = sACFobra;
            //Obj.ACFord41 = sACFord41;
            //Obj.ACFord42 = sACFord42;
            //Obj.ACFord43 = sACFord43;
            //Obj.ACFord44 = sACFord44;
            Obj.ACFanlue = sACFanlue;
            Obj.ACFfactortrib = decACFfactortrib;
            Obj.ACFfactorniif = decACFfactorniif;
            Obj.ACFcuenta = sACFcuenta;
            Obj.ACFcuentadep = sACFcuentadep;
            Obj.CMPid = sCMPid;
            Obj.ACFobservacion = sACFobservacion;
            Obj.LIFNR = sLIFNR;
            Obj.ACFnotaingreso = sACFnotaingreso;
            Obj.ACFfechanotaingreso = sACFfechanotaingreso;
            Obj.ACFordencompra = sACFordencompra;
            Obj.ACFfechaordencompra = dtACFfechaordencompra;
            Obj.BLART = sBLART;
            Obj.ACFcomprobante = sACFcomprobante;
            Obj.KOSTL = sKOSTL;
            Obj.AMBid = iAMBid;
            Obj.UBEid = iUBEid;
            Obj.ACFfechacomprobante = dtACFfechacomprobante;
            Obj.V_T087U_ANLUE = sV_T087U_ANLUE;
            Obj.ACFtipo_activo = sACFtipo_activo;
            Obj.ACFAnulado = cACFAnulado;
            Obj.ACFid_Padre = cACFid_Padre;
            Obj.ACFtipo_orden= cACFtipo_orden;
            Obj.OBJid_objeto= cOBJid_objeto;
            Obj.CRPid_crp = cCRPid_crp;


            return Obj.Editar(Obj);
        }

        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar3(
         string iACFid,
         string sACFobra,
         string sKOSTL,
         string sVNRid,
         string decACFvalorniif,
         string decACFvalortrib,
         string iUBEid,
         string sV_T087U_ANLUE
         )
        {
            DacfACFp_Activo_Fijo Obj = new DacfACFp_Activo_Fijo();
            Obj.ACFid = iACFid;
            Obj.ACFobra = sACFobra;
            Obj.KOSTL = sKOSTL;
            Obj.VNRid = sVNRid;
            Obj.ACFvalorniif = decACFvalorniif;
            Obj.ACFvalortrib = decACFvalortrib;
            Obj.UBEid = iUBEid;
            Obj.V_T087U_ANLUE = sV_T087U_ANLUE;
            return Obj.Editar3(Obj);
        }

        //Metodo Editar que llama al metodo Editar de la clase 
        //de la CapaDatos
        public static string Editar2(
         string iACFid,
         string iACFvutilniifanio,
         string iACFvutilniifdia,
         string iACFvutiltribanio,
         string iACFvutiltribdia
         )
        {
            DacfACFp_Activo_Fijo Obj = new DacfACFp_Activo_Fijo();
            Obj.ACFid = iACFid;
            Obj.ACFvutilniifanio = iACFvutilniifanio;
            Obj.ACFvutilniifdia = iACFvutilniifdia;
            Obj.ACFvutiltribanio = iACFvutiltribanio;
            Obj.ACFvutiltribdia = iACFvutiltribdia;
            return Obj.Editar2(Obj);
        }
        public static string Editar4(
         string ACFvutiltribanio,
         string ACFvutiltribdia,
         string ACFvutilniifanio,
         string ACFvutilniifdia,
         string CMPid
         )
        {
            DacfACFp_Activo_Fijo Obj = new DacfACFp_Activo_Fijo();
            Obj.ACFvutiltribanio = ACFvutiltribanio;
            Obj.ACFvutiltribdia = ACFvutiltribdia;
            Obj.ACFvutilniifanio = ACFvutilniifanio;
            Obj.ACFvutilniifdia = ACFvutilniifdia;
            Obj.CMPid = CMPid;

            return Obj.Editar4(Obj);
        }

        // Editar para el formulario de BajaEvaluacionTecnica
        public static string Editar5(string ACFid)
        {
            DacfACFp_Activo_Fijo Obj = new DacfACFp_Activo_Fijo();
            Obj.ACFid = ACFid;
            //Obj.ACFAnulado = ACFAnulado;

            return Obj.Editar5(Obj);
        }

        //Metodo Editar que llama al metodo Editar del formulario de depreciacion 
        //de la CapaDatos
        public static string depreciacion(
         string ACFid, // iACFid - se solo para procesar un dato de mes
         string ACFvutiltribanio, // iACFvutiltribanio - se solo para procesar un dato de año
         string sACFanlue // variable de fecha para la tabla PRMVAR
         )
        {
            DacfACFp_Activo_Fijo Obj = new DacfACFp_Activo_Fijo();
            Obj.ACFid = ACFid;
            Obj.ACFvutiltribanio = ACFvutiltribanio;
            Obj.ACFanlue = sACFanlue;
            return Obj.depreciacion(Obj);
        }

        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string iACFid,string cACFAnulado)
        {
            return new DacfACFp_Activo_Fijo().Eliminar(iACFid,cACFAnulado);
        }
        public static DataTable Top()
        {
            return new DacfACFp_Activo_Fijo().Top();
        }
        public static DataTable Last()
        {
            return new DacfACFp_Activo_Fijo().Last();
        }
        public static DataTable Next(String iACFid)
        {
            return new DacfACFp_Activo_Fijo().Next(iACFid);
        }
        public static DataTable Mostrar3()
        {
            return new DacfACFp_Activo_Fijo().Mostrar3();
        }
   
        public static DataTable Prev(String iACFid)
        {
            return new DacfACFp_Activo_Fijo().Prev(iACFid);
        }


        //------------------------------------------------------------------
        //M�todo Mostrar en coinciliar inventario
        public static DataTable Mostrar()
        {
            return new DacfACFp_Activo_Fijo().Mostrar();
        }
        //M�todo Mostrar en coinciliar inventario de inventario
        public static DataTable MostrarINV(string INV)
        {
            return new DacfACFp_Activo_Fijo().MostrarINV(INV);
        }


        //reporte de depreciación
        public static DataTable Depreciacion(String iACFvutiltribanio)
        {
            return new DacfACFp_Activo_Fijo().Depreciacion(iACFvutiltribanio);
        }


        public static DataTable MostrarRegistro(string ACFdescripcion)
        {
            return new DacfACFp_Activo_Fijo().MostrarRegistro(ACFdescripcion);
        }        
        //M�todo Mostrar2 que llama al m�todo Mostrar2 de la clase 
        //de la CapaDatos
        public static DataTable Mostrar2(string iACFid)
        {
            return new DacfACFp_Activo_Fijo().Mostrar2(iACFid);
        }
        public static DataTable Mostrar5(string AMBid)
        {
            return new DacfACFp_Activo_Fijo().Mostrar5(AMBid);
        }
        public static DataTable Mostrar6(string ACFidn, string ACFidm)
        {
            return new DacfACFp_Activo_Fijo().Mostrar6(ACFidn,ACFidm);
        }

        public static DataTable Mostrar4(string CMPid)
        {
            return new DacfACFp_Activo_Fijo().Mostrar4(CMPid);
        }

        // agregar activo fijo en Frm Trasnferencia Activo
        public static DataTable IngresarACF(string iACFid)
        {
            return new DacfACFp_Activo_Fijo().IngresarACF(iACFid);
        }
        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable MostrarPadre(string CMPid)
        {
            return new DacfACFp_Activo_Fijo().MostrarPadre(CMPid);
        }


        public static DataTable Actual(string ACFid)
        {
            DacfACFp_Activo_Fijo Obj = new DacfACFp_Activo_Fijo();
            Obj.ACFid = ACFid;
            return Obj.Actual(Obj);
        }

    }
}
