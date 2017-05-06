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
         string sACFtipo_activo
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
            return Obj.Insertar(Obj);
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
         string sACFtipo_activo
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
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string iACFid)
        {
            DacfACFp_Activo_Fijo Obj = new DacfACFp_Activo_Fijo();
            Obj.ACFid = iACFid;
            return Obj.Eliminar(Obj);
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

        public static DataTable Prev(String iACFid)
        {
            return new DacfACFp_Activo_Fijo().Prev(iACFid);
        }


        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DacfACFp_Activo_Fijo().Mostrar();
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


       
        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string sBUKRS)
        {
            DacfACFp_Activo_Fijo Obj = new DacfACFp_Activo_Fijo();
            Obj.BUKRS = sBUKRS;
            return Obj.Buscar(Obj);
        }

    }
}
