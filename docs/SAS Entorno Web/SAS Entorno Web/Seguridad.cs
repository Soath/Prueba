using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Security;
using Microsoft.VisualBasic;
using System.Web.UI;

namespace SistemaPlanificacion.Models
{
    public static class Seguridad
    {

        public static SegNetAdapter.clsSeguridadNet gobjSeguridad = new SegNetAdapter.clsSeguridadNet();
        public static string gstrSesion;
        public static string gstrUsuario;
        public static Microsoft.VisualBasic.Collection gcolPermisos = new Microsoft.VisualBasic.Collection();
        public static string gstrUsuarioBD;
        public static string gstrServidorBD;
        public static string gstrNombreBD;
        public static string gstrPasswordBD;
        public static string gstrSistema;
        public static string[] strpartePerfil;

        public static string cpubCampoDatos;
        public static string cPubstrPermiso;

        public static void fncObtenerValoresPermisosTotal() //Obtenemos los valores principales de la aplicación
        {
            gstrUsuarioBD = gobjSeguridad.fncObtenerValoresPermisos(gstrUsuario, gstrSistema, gstrSesion, "SGPLN_USUARIOBD", "texto"); //Valor usuario Base de datos
            gstrServidorBD = gobjSeguridad.fncObtenerValoresPermisos(gstrUsuario, gstrSistema, gstrSesion, "SGPLN_SERVIDOR", "texto"); //Valor servidor Base de datos
            gstrNombreBD = gobjSeguridad.fncObtenerValoresPermisos(gstrUsuario, gstrSistema, gstrSesion, "SGPLN_BASEDATOS", "texto"); //Valor nombre Base de datos
            gstrPasswordBD = gobjSeguridad.fncObtenerValoresPermisos(gstrUsuario, gstrSistema, gstrSesion, "SGPLN_PASSWORD", "password"); //Valor password Base de datos
        }
        public static void fncDividirpermisos(string xstrPermisos)
        {
            gcolPermisos.Clear();
            string[] strParte1 = xstrPermisos.Split(';');
            //string[] strParte2=new string[];
            int intIndex;
            //strParte1 = xstrPermisos.Split(';');
            for (intIndex = 0; intIndex <= strParte1.GetUpperBound(0) - 1; intIndex++)
            {
                string[] strParte2 = strParte1[intIndex].Split(',');
                gcolPermisos.Add(strParte2[1], strParte2[0]);
            }


        }
        public static Boolean pfncObtenerPermisos(string strPalabraclave)
        {
            /*
            if (gcolPermisos[strPalabraclave].ToString() == "1")//' en caso tenga acceso a este permiso activara el menu
                return true;
            else //' caso sea igual a "0" contrario lo desactivara
                return false;
            */
            
            return true;
            
        }
        public static string pfncPuedeAccederA(string xstrPalabraclave)
        {
            /*
            string strPuedeAccederA = "";
            strPuedeAccederA = gobjSeguridad.fncPuedeAccederA(gstrUsuario, gstrSistema, gstrSesion, xstrPalabraclave);
            if (strPuedeAccederA.ToString() == "1") //en caso tenga acceso a este permiso activara el menu
                return strPuedeAccederA;
            else //' caso sea diferente de "1" evaluará las siguientes alternativas
            {
                switch (strPuedeAccederA)
                {
                    case "0": //'No tiene los permisos asociados a la función
                        return strPuedeAccederA;
                        // ClientScriptManager objClientScriptManager  = Page.ClientScript;
                        break;
                    case "2": //'El usuario ha sido desasociado al sistema
                        gfncFinSesion();
                        return strPuedeAccederA;
                        break;
                    case "3":// 'El usuario se encuentra bloqueado
                        gfncFinSesion();
                        return strPuedeAccederA;
                        break;
                    case "4":// 'El usuario ha sido deshabilitado del sistema
                        gfncFinSesion();
                        return strPuedeAccederA;
                        break;
                    case "5":// 'El usuario ha sido eliminado del sistema
                        gfncFinSesion();
                        return strPuedeAccederA;
                        break;
                    case "6":// 'La sesión actual se encuentra inactiva
                        gfncFinSesion();
                        return strPuedeAccederA;
                        break;
                    case "7":// 'Ha superado el tiempo máximo de la sesión
                        gfncFinSesion();
                        return strPuedeAccederA;
                        break;

                }
                return strPuedeAccederA;
            }
            */
            return "1";
            
        }
        public static void gfncFinSesion()
        {
            // if ((gobjSeguridad.fncFinSesion(gstrUsuario, gstrSistema, gstrSesion)) > 0) //Then 'Llamamos a cerrar sesión
            //formau.Exit(); //'Cerramos la aplicación
            //formau.SignOut();

        }
        //***Para Pistas de Auditoria la auditoria
        public static int pfncRegistrarAuditoria(string xAUDid_auditoria1, string xAUD_accion, string xAUD_tabla, int xAUD_count_registro, string xAUD_detalle, string xSESid_sesion)
        {
            //lobjSeguridad = CREATEOBJECT("DotNetCom.clsSeguridadNet");
            SegNetAdapter.clsSeguridadNet lobjSeguridad = new SegNetAdapter.clsSeguridadNet();
            int lsalida;
            lsalida = lobjSeguridad.fncRegistrarAuditoria(xAUDid_auditoria1, Convert.ToInt32(strpartePerfil[3].ToString()), Convert.ToInt32(strpartePerfil[1]), Convert.ToInt32(strpartePerfil[2]), Convert.ToInt32(strpartePerfil[0]), xAUD_accion, xAUD_tabla, DateTime.Now, xAUD_count_registro, xAUD_detalle, xSESid_sesion);
            return lsalida;
        }
        public static string pfncRegistrarAuditoriaDetalle(int xAUDid_auditoria, string xAUDid_auditoria1, string xAUD_tabla, string xAUD_detalle, string xSESid_sesion)
        {
            //lobjSeguridad = CREATEOBJECT("DotNetCom.clsSeguridadNet")
            SegNetAdapter.clsSeguridadNet lobjSeguridad = new SegNetAdapter.clsSeguridadNet();
            string lsalida;
            lsalida = lobjSeguridad.fncRegistrarAuditoriaDetalle(xAUDid_auditoria, xAUDid_auditoria1, xAUD_tabla, xAUD_detalle);
            return lsalida;

        }
        public static void pfncObtenerPerfilUsuarioPermiso(string xstrPalabraclave)
        {
            //lobjSeguridad = CREATEOBJECT("DotNetCom.clsSeguridadNet")
            SegNetAdapter.clsSeguridadNet lobjSeguridad = new SegNetAdapter.clsSeguridadNet();
            string lsalida;
            lsalida = lobjSeguridad.fncObtenerPerfilSistemaPermiso(gstrUsuario, gstrSistema, xstrPalabraclave);

            //**Separando en un arreglo
            string strPermisosT;
            strPermisosT = lsalida;
            int nLong;
            nLong = strPermisosT.Length;
            int intRepeticion = 0;
            string[] aCadena = new string[nLong];
            // aCadena = null;
            for (int nCont = 0; nCont < nLong; nCont++)
            {
                aCadena[nCont] = strPermisosT.Substring(nCont, 1);
                if (aCadena[nCont] == ";")
                    intRepeticion = intRepeticion + 1;
            }
            strpartePerfil = new string[intRepeticion];
            for (int intIndex = 0; intIndex < intRepeticion; intIndex++)
            {
                strpartePerfil[intIndex] = strPermisosT.Substring(0, strPermisosT.IndexOf(";")); //&&HASTA UN PUNTO Y COMA 
                strPermisosT = strPermisosT.Substring(strPermisosT.IndexOf(";") + 1); //HASTA EL FINAL 
            }

        }

        public static string GetUniqueID()
        {

            System.Guid _GUID = System.Guid.NewGuid();
            String _sGUID = _GUID.ToString();

            return _sGUID;
        }
        public static void LLernarCampoDatos(DataTable lc_table, int indicador)
        {
            //**Registrar Pistas de Auditoria SAS	:Ronald Mamani Ninaja
            //AFIELDS(La_Fields,(Lc_Table))
            //Ln_nFields = ALEN(La_Fields,1)
            //**registro de campos
            int _countColumna;
            _countColumna = lc_table.Columns.Count;
            int c = 1;
            if (indicador == 1)
            {
                //**registro de campos
                _countColumna = 0;
                _countColumna = lc_table.Columns.Count;
                c = 1;
                foreach (DataColumn columna in lc_table.Columns)
                {

                    cpubCampoDatos = cpubCampoDatos + columna.ColumnName;
                    if (c == _countColumna)
                        cpubCampoDatos = cpubCampoDatos + "::";
                    else
                        cpubCampoDatos = cpubCampoDatos + "||";
                    c = c + 1;
                }
            }

            foreach (DataRow fila in lc_table.Rows)
            {
                c = 1;
                foreach (DataColumn columna in lc_table.Columns)
                {
                    cpubCampoDatos = cpubCampoDatos + fila[columna].ToString();
                    if (c == _countColumna)
                        cpubCampoDatos = cpubCampoDatos + "::";
                    else
                        cpubCampoDatos = cpubCampoDatos + "||";
                    c = c + 1;
                }
            }
        }
        public static string[] RegistrarPistasAuditoriaIntegrado(DataTable lc_table, int indicador, string strpermiso, string strAccion, int indicadordetalle, int idauditoria, int idoperacion, ref string[] VLArrglo)
        {
            DataTable cloctabla;
            cloctabla = lc_table;
            if (indicador != 3) //para no registrar ningun campo ni registro 3 en caso sea insertar.
            {
                cpubCampoDatos = "";//&&variable publica
                LLernarCampoDatos(cloctabla, indicador);//&&uno solamante cabera(1 registro)y 2 puede ser detalle
            }
            Seguridad.pfncObtenerPerfilUsuarioPermiso(strpermiso);

            if (indicadordetalle == 0)
            {
                //string[] VLArrglo; 
                string xidoperacion;
                if (idoperacion <= 0)
                    xidoperacion = GetUniqueID();
                else
                    xidoperacion = idoperacion.ToString(); //&&Esto es la segunda tabla afectada cabecera
                int xidauditoria;
                xidauditoria = pfncRegistrarAuditoria(xidoperacion, strAccion, cloctabla.TableName.ToString(), 0, Seguridad.cpubCampoDatos, Seguridad.gstrSesion);
                VLArrglo[0] = xidoperacion;
                VLArrglo[1] = xidauditoria.ToString();
            }
            else
                pfncRegistrarAuditoriaDetalle(idauditoria, idoperacion.ToString(), cloctabla.ToString(), Seguridad.cpubCampoDatos, Seguridad.gstrSesion);

            return VLArrglo;
        }
    }

}