using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
   public class NMovimiento_Transferencia_Activo
    {
        //M�todo Insertar que llama al m�todo Insertar de la clase DPostres
        //de la CapaDatos
        public static string Insertar(
             string iMVPid_proceso,
             string mMVPtipo,
            // string mMVPid_movimiento,
             string mMVPds_movimiento,
            // string mMVPid_motivo,
            // string mMVPds_motivo,
             string mMVPfecha_movimiento,
            // string mORGid_empresa,
            // string mORGds_empresa,
             string mORGid_zona,
             string mORGds_zona,
            // string mORGid_crp,
             string mORGcrp,
             string mORGds_crp,
             string mORGid_ambiente,
             string mORGds_ambiente,
             string mORGid_persona,
             string mORGds_persona,
             string mORGid_usuario,
             string mORGds_usuario,
            // string mORGid_sistelec,
            // string mORGds_sistelec,
            // string mORGid_set,
            // string mORGds_set,
            // string mORGid_alimentador,
            // string mORGds_alimentador,
            // string mORGid_sed,
            // string mORGds_sed,
            // string mORGid_circuito,
            // string mORGds_circuito,
            // string mORGposte_inicio,
            // string mORGds_poste_inicio,
            // string mORGposte_fin,
            // string mORGds_poste_fin,
            // string mORGlinea_at,
            // string mORGpunto_inicio,
            // string mORGpunto_fin,
            // string mORGid_activopadre,
            // string mORGds_activopadre,
            // string mDSTid_empresa,
            // string mDSTds_empresa,
             string mDSTid_zona,
             string mDSTds_zona,
            // string mDSTid_crp,
             string mDSTcrp,
             string mDSTds_crp,
             string mDSTid_ambiente,
             string mDSTds_ambiente,
             string mDSTid_persona,
             string mDSTds_persona,
             string mDSTid_usuario,
             string mDSTds_usuario
            // string mDSTid_sistelec,
            // string mDSTds_sistelec,
            // string mDSTid_set,
            // string mDSTds_set,
            // string mDSTid_alimentador,
            // string mDSTds_alimentador,
            // string mDSTid_sed,
            // string mDSTds_sed,
            // string mDSTid_circuito,
            // string mDSTds_circuito,
            // string mDSTposte_inicio,
            // string mDSTds_poste_inicio,
            // string mDSTposte_fin,
            // string mDSTds_poste_fin,
            // string mDSTlinea_at,
            // string mDSTpunto_inicio,
            // string mDSTpunto_fin,
            // string mDSTid_activopadre,
            // string mDSTds_activopadre,
            // string mMVPobservaciones,
            // string mMVPdefinitivo,
            // string mMVPfecha_fin,
            // string mMVPusuario_sistemas,
            // string mMVPaprueba_sistemas,
            // string mMVPfecha_sistemas,
            // string mMVPusuario_patrimonio,
            // string mMVPaprueba_patrimonio,
            // string mMVPfecha_patrimonio,
            // string mMVPretorno,
            // string mMVPusuario_retorno,
            // string mMVPfecha_retorno,
            // string mMVPusuario_registro,
            // string mMVPfecha_registro
            )
        {
            DMovimiento_Transferencia_Activo Obj = new DMovimiento_Transferencia_Activo();
            Obj.MVPid_proceso = iMVPid_proceso;
            Obj.MVPtipo = mMVPtipo;
            // Obj.MVPid_movimiento = mMVPid_movimiento;
            Obj.MVPds_movimiento = mMVPds_movimiento;
            // Obj.MVPid_motivo = mMVPid_motivo;
            // Obj.MVPds_motivo = mMVPds_motivo;
            Obj.MVPfecha_movimiento = mMVPfecha_movimiento;
            // Obj.ORGid_empresa = mORGid_empresa;
            // Obj.ORGds_empresa = mORGds_empresa;
            Obj.ORGid_zona = mORGid_zona;
            Obj.ORGds_zona = mORGds_zona;
            // Obj.ORGid_crp = mORGid_crp;
            Obj.ORGcrp = mORGcrp;
            Obj.ORGds_crp = mORGds_crp;
            Obj.ORGid_ambiente = mORGid_ambiente;
            Obj.ORGds_ambiente = mORGds_ambiente;
            Obj.ORGid_persona = mORGid_persona;
            Obj.ORGds_persona = mORGds_persona;
            Obj.ORGid_usuario = mORGid_usuario;
            Obj.ORGds_usuario = mORGds_usuario;
            // Obj.ORGid_sistelec = mORGid_sistelec;
            // Obj.ORGds_sistelec = mORGds_sistelec;
            // Obj.ORGid_set = mORGid_set;
            // Obj.ORGds_set = mORGds_set;
            // Obj.ORGid_alimentador = mORGid_alimentador;
            // Obj.ORGds_alimentador = mORGds_alimentador;
            // Obj.ORGid_sed = mORGid_sed;
            // Obj.ORGds_sed = mORGds_sed;
            // Obj.ORGid_circuito = mORGid_circuito;
            // Obj.ORGds_circuito = mORGds_circuito;
            // Obj.ORGposte_inicio = mORGposte_inicio;
            // Obj.ORGds_poste_inicio = mORGds_poste_inicio;
            // Obj.ORGposte_fin = mORGposte_fin;
            // Obj.ORGds_poste_fin = mORGds_poste_fin;
            // Obj.ORGlinea_at = mORGlinea_at;
            // Obj.ORGpunto_inicio = mORGpunto_inicio;
            // Obj.ORGpunto_fin = mORGpunto_fin;
            // Obj.ORGid_activopadre = mORGid_activopadre;
            // Obj.ORGds_activopadre = mORGds_activopadre;
            // Obj.DSTid_empresa = mDSTid_empresa;
            // Obj.DSTds_empresa = mDSTds_empresa;
            Obj.DSTid_zona = mDSTid_zona;
            Obj.DSTds_zona = mDSTds_zona;
            // Obj.DSTid_crp = mDSTid_crp;
            Obj.DSTcrp = mDSTcrp;
            Obj.DSTds_crp = mDSTds_crp;
            Obj.DSTid_ambiente = mDSTid_ambiente;
            Obj.DSTds_ambiente = mDSTds_ambiente;
            Obj.DSTid_persona = mDSTid_persona;
            Obj.DSTds_persona = mDSTds_persona;
            Obj.DSTid_usuario = mDSTid_usuario;
            Obj.DSTds_usuario = mDSTds_usuario;
            // Obj.DSTid_sistelec = mDSTid_sistelec;
            // Obj.DSTds_sistelec = mDSTds_sistelec;
            // Obj.DSTid_set = mDSTid_set;
            // Obj.DSTds_set = mDSTds_set;
            // Obj.DSTid_alimentador = mDSTid_alimentador;
            // Obj.DSTds_alimentador = mDSTds_alimentador;
            // Obj.DSTid_sed = mDSTid_sed;
            // Obj.DSTds_sed = mDSTds_sed;
            // Obj.DSTid_circuito = mDSTid_circuito;
            // Obj.DSTds_circuito = mDSTds_circuito;
            // Obj.DSTposte_inicio = mDSTposte_inicio;
            // Obj.DSTds_poste_inicio = mDSTds_poste_inicio;
            // Obj.DSTposte_fin = mDSTposte_fin;
            // Obj.DSTds_poste_fin = mDSTds_poste_fin;
            // Obj.DSTlinea_at = mDSTlinea_at;
            // Obj.DSTpunto_inicio = mDSTpunto_inicio;
            // Obj.DSTpunto_fin = mDSTpunto_fin;
            // Obj.DSTid_activopadre = mDSTid_activopadre;
            // Obj.DSTds_activopadre = mDSTds_activopadre;
            // Obj.MVPobservaciones = mMVPobservaciones;
            // Obj.MVPdefinitivo = mMVPdefinitivo;
            // Obj.MVPfecha_fin = mMVPfecha_fin;
            // Obj.MVPusuario_sistemas = mMVPusuario_sistemas;
            // Obj.MVPaprueba_sistemas = mMVPaprueba_sistemas;
            // Obj.MVPfecha_sistemas = mMVPfecha_sistemas;
            // Obj.MVPusuario_patrimonio = mMVPusuario_patrimonio;
            // Obj.MVPaprueba_patrimonio = mMVPaprueba_patrimonio;
            // Obj.MVPfecha_patrimonio = mMVPfecha_patrimonio;
            // Obj.MVPretorno = mMVPretorno;
            // Obj.MVPusuario_retorno = mMVPusuario_retorno;
            // Obj.MVPfecha_retorno = mMVPfecha_retorno;
            // Obj.MVPusuario_registro = mMVPusuario_registro;
            // Obj.MVPfecha_registro = mMVPfecha_registro;
            return Obj.Insertar(Obj);
        }

        //------------------------------------------------------------------
        //Metodo Editar que llama al metodo Editar de la clase DPostres
        //de la CapaDatos
        public static string Editar(
            string iMVPid_proceso,
             string mMVPtipo,
             // string mMVPid_movimiento,
             string mMVPds_movimiento,
             // string mMVPid_motivo,
             // string mMVPds_motivo,
             string mMVPfecha_movimiento,
             // string mORGid_empresa,
             // string mORGds_empresa,
             string mORGid_zona,
             string mORGds_zona,
             // string mORGid_crp,
             string mORGcrp,
             string mORGds_crp,
             string mORGid_ambiente,
             string mORGds_ambiente,
             string mORGid_persona,
             string mORGds_persona,
             string mORGid_usuario,
             string mORGds_usuario,
             // string mORGid_sistelec,
             // string mORGds_sistelec,
             // string mORGid_set,
             // string mORGds_set,
             // string mORGid_alimentador,
             // string mORGds_alimentador,
             // string mORGid_sed,
             // string mORGds_sed,
             // string mORGid_circuito,
             // string mORGds_circuito,
             // string mORGposte_inicio,
             // string mORGds_poste_inicio,
             // string mORGposte_fin,
             // string mORGds_poste_fin,
             // string mORGlinea_at,
             // string mORGpunto_inicio,
             // string mORGpunto_fin,
             // string mORGid_activopadre,
             // string mORGds_activopadre,
             // string mDSTid_empresa,
             // string mDSTds_empresa,
             string mDSTid_zona,
             string mDSTds_zona,
             // string mDSTid_crp,
             string mDSTcrp,
             string mDSTds_crp,
             string mDSTid_ambiente,
             string mDSTds_ambiente,
             string mDSTid_persona,
             string mDSTds_persona,
             string mDSTid_usuario,
             string mDSTds_usuario
            // string mDSTid_sistelec,
            // string mDSTds_sistelec,
            // string mDSTid_set,
            // string mDSTds_set,
            // string mDSTid_alimentador,
            // string mDSTds_alimentador,
            // string mDSTid_sed,
            // string mDSTds_sed,
            // string mDSTid_circuito,
            // string mDSTds_circuito,
            // string mDSTposte_inicio,
            // string mDSTds_poste_inicio,
            // string mDSTposte_fin,
            // string mDSTds_poste_fin,
            // string mDSTlinea_at,
            // string mDSTpunto_inicio,
            // string mDSTpunto_fin,
            // string mDSTid_activopadre,
            // string mDSTds_activopadre,
            // string mMVPobservaciones,
            // string mMVPdefinitivo,
            // string mMVPfecha_fin,
            // string mMVPusuario_sistemas,
            // string mMVPaprueba_sistemas,
            // string mMVPfecha_sistemas,
            // string mMVPusuario_patrimonio,
            // string mMVPaprueba_patrimonio,
            // string mMVPfecha_patrimonio,
            // string mMVPretorno,
            // string mMVPusuario_retorno,
            // string mMVPfecha_retorno,
            // string mMVPusuario_registro,
            // string mMVPfecha_registro
            )
        {
            DMovimiento_Transferencia_Activo Obj = new DMovimiento_Transferencia_Activo();
            Obj.MVPid_proceso = iMVPid_proceso;
            Obj.MVPtipo = mMVPtipo;
            // Obj.MVPid_movimiento = mMVPid_movimiento;
            Obj.MVPds_movimiento = mMVPds_movimiento;
            // Obj.MVPid_motivo = mMVPid_motivo;
            // Obj.MVPds_motivo = mMVPds_motivo;
            Obj.MVPfecha_movimiento = mMVPfecha_movimiento;
            // Obj.ORGid_empresa = mORGid_empresa;
            // Obj.ORGds_empresa = mORGds_empresa;
            Obj.ORGid_zona = mORGid_zona;
            Obj.ORGds_zona = mORGds_zona;
            // Obj.ORGid_crp = mORGid_crp;
            Obj.ORGcrp = mORGcrp;
            Obj.ORGds_crp = mORGds_crp;
            Obj.ORGid_ambiente = mORGid_ambiente;
            Obj.ORGds_ambiente = mORGds_ambiente;
            Obj.ORGid_persona = mORGid_persona;
            Obj.ORGds_persona = mORGds_persona;
            Obj.ORGid_usuario = mORGid_usuario;
            Obj.ORGds_usuario = mORGds_usuario;
            // Obj.ORGid_sistelec = mORGid_sistelec;
            // Obj.ORGds_sistelec = mORGds_sistelec;
            // Obj.ORGid_set = mORGid_set;
            // Obj.ORGds_set = mORGds_set;
            // Obj.ORGid_alimentador = mORGid_alimentador;
            // Obj.ORGds_alimentador = mORGds_alimentador;
            // Obj.ORGid_sed = mORGid_sed;
            // Obj.ORGds_sed = mORGds_sed;
            // Obj.ORGid_circuito = mORGid_circuito;
            // Obj.ORGds_circuito = mORGds_circuito;
            // Obj.ORGposte_inicio = mORGposte_inicio;
            // Obj.ORGds_poste_inicio = mORGds_poste_inicio;
            // Obj.ORGposte_fin = mORGposte_fin;
            // Obj.ORGds_poste_fin = mORGds_poste_fin;
            // Obj.ORGlinea_at = mORGlinea_at;
            // Obj.ORGpunto_inicio = mORGpunto_inicio;
            // Obj.ORGpunto_fin = mORGpunto_fin;
            // Obj.ORGid_activopadre = mORGid_activopadre;
            // Obj.ORGds_activopadre = mORGds_activopadre;
            // Obj.DSTid_empresa = mDSTid_empresa;
            // Obj.DSTds_empresa = mDSTds_empresa;
            Obj.DSTid_zona = mDSTid_zona;
            Obj.DSTds_zona = mDSTds_zona;
            // Obj.DSTid_crp = mDSTid_crp;
            Obj.DSTcrp = mDSTcrp;
            Obj.DSTds_crp = mDSTds_crp;
            Obj.DSTid_ambiente = mDSTid_ambiente;
            Obj.DSTds_ambiente = mDSTds_ambiente;
            Obj.DSTid_persona = mDSTid_persona;
            Obj.DSTds_persona = mDSTds_persona;
            Obj.DSTid_usuario = mDSTid_usuario;
            Obj.DSTds_usuario = mDSTds_usuario;
            // Obj.DSTid_sistelec = mDSTid_sistelec;
            // Obj.DSTds_sistelec = mDSTds_sistelec;
            // Obj.DSTid_set = mDSTid_set;
            // Obj.DSTds_set = mDSTds_set;
            // Obj.DSTid_alimentador = mDSTid_alimentador;
            // Obj.DSTds_alimentador = mDSTds_alimentador;
            // Obj.DSTid_sed = mDSTid_sed;
            // Obj.DSTds_sed = mDSTds_sed;
            // Obj.DSTid_circuito = mDSTid_circuito;
            // Obj.DSTds_circuito = mDSTds_circuito;
            // Obj.DSTposte_inicio = mDSTposte_inicio;
            // Obj.DSTds_poste_inicio = mDSTds_poste_inicio;
            // Obj.DSTposte_fin = mDSTposte_fin;
            // Obj.DSTds_poste_fin = mDSTds_poste_fin;
            // Obj.DSTlinea_at = mDSTlinea_at;
            // Obj.DSTpunto_inicio = mDSTpunto_inicio;
            // Obj.DSTpunto_fin = mDSTpunto_fin;
            // Obj.DSTid_activopadre = mDSTid_activopadre;
            // Obj.DSTds_activopadre = mDSTds_activopadre;
            // Obj.MVPobservaciones = mMVPobservaciones;
            // Obj.MVPdefinitivo = mMVPdefinitivo;
            // Obj.MVPfecha_fin = mMVPfecha_fin;
            // Obj.MVPusuario_sistemas = mMVPusuario_sistemas;
            // Obj.MVPaprueba_sistemas = mMVPaprueba_sistemas;
            // Obj.MVPfecha_sistemas = mMVPfecha_sistemas;
            // Obj.MVPusuario_patrimonio = mMVPusuario_patrimonio;
            // Obj.MVPaprueba_patrimonio = mMVPaprueba_patrimonio;
            // Obj.MVPfecha_patrimonio = mMVPfecha_patrimonio;
            // Obj.MVPretorno = mMVPretorno;
            // Obj.MVPusuario_retorno = mMVPusuario_retorno;
            // Obj.MVPfecha_retorno = mMVPfecha_retorno;
            // Obj.MVPusuario_registro = mMVPusuario_registro;
            // Obj.MVPfecha_registro = mMVPfecha_registro;
            return Obj.Editar(Obj);
        }
        //------------------------------------------------------------------
        //M�todo Eliminar que llama al m�todo Eliminar de la clase DPostres
        //de la CapaDatos
        public static string Eliminar(string iMVPid_proceso)
        {
            DMovimiento_Transferencia_Activo Obj = new DMovimiento_Transferencia_Activo();
            Obj.MVPid_proceso = iMVPid_proceso;
            return Obj.Eliminar(Obj);
        }


        // barra de navegacion
        public static DataTable Top()
        {
            return new DMovimiento_Transferencia_Activo().Top();
        }
        public static DataTable Last()
        {
            return new DMovimiento_Transferencia_Activo().Last();
        }
        public static DataTable Next(String iMVPid_proceso)
        {
            return new DMovimiento_Transferencia_Activo().Next(iMVPid_proceso);
        }

        public static DataTable Prev(String iMVPid_proceso)
        {
            return new DMovimiento_Transferencia_Activo().Prev(iMVPid_proceso);
        }

        //------------------------------------------------------------------
        //M�todo Mostrar que llama al m�todo Mostrar de la clase DPostres
        //de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DMovimiento_Transferencia_Activo().Mostrar();
        }
        //M�todo Mostrar que llama al m�todo Mostrar2
        public static DataTable Mostrar2()
        {
            return new DMovimiento_Transferencia_Activo().Mostrar2();
        }
        // Recargar el Act. Fijo 
        public static string RecargarACF(String iMVPid_proceso)
        {
            DMovimiento_Transferencia_Activo Obj = new DMovimiento_Transferencia_Activo();
            Obj.MVPid_proceso = iMVPid_proceso;
            return Obj.RecargarACF(Obj);
        }
        public static string FichaMovimiento(String iMVPid_proceso)
        {
            DMovimiento_Transferencia_Activo Obj = new DMovimiento_Transferencia_Activo();
            Obj.MVPid_proceso = iMVPid_proceso;
            return Obj.FichaMovimiento(Obj);
        }
        public static DataTable FichaMovimiento1(string iMVPid_proceso)
        {
            return new DMovimiento_Transferencia_Activo().FichaMovimiento1(iMVPid_proceso);
        }


        //------------------------------------------------------------------
        //M�todo Buscar que llama al m�todo BuscarNombre
        //de la clase DPostresa de la CapaDatos

        public static DataTable Buscar(string iMVPid_proceso)
        {
            DMovimiento_Transferencia_Activo Obj = new DMovimiento_Transferencia_Activo();
            Obj.MVPid_proceso = iMVPid_proceso;
            return Obj.Buscar(Obj);
        }

    }
}
