using SistemaPlanificacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SegNetAdapter;
using ServicioUtilitarios;
using Encriptador;
namespace SistemaPlanificacion.Controllers
{
    public class AccountController : Controller
    {
        private SistemaPlanificacionDataContext per = new SistemaPlanificacionDataContext();

        // GET: /Account/LogOn
        [AllowAnonymous]
        public ActionResult LogOn()
        {
            LogOnViewModel model = new Models.LogOnViewModel();
            return View(model);
        }
        
        [AllowAnonymous]
        [HttpPost]
        public ActionResult LogOn(LogOnViewModel model, string returnUrl)
        {
            /*
            if (returnUrl == "/Account/LogOff")
            {
                returnUrl = "/";
            }
            if (string.IsNullOrEmpty(model.UserName))
            {
                this.ModelState.AddModelError("", "Ingrese su usuario.");
                return View(model);
            }
            if (string.IsNullOrEmpty(model.Password))
            {
                this.ModelState.AddModelError("", "Ingrese su contraseña.");
                return View(model);
            }
            Seguridad.gstrSistema = "SGPLN";
            int intContadorPWD = 0;
            string strUsuarioAnterior = "";
            int intResultado;
            clsSeguridadNet objSeguridadWeb = new SegNetAdapter.clsSeguridadNet();
            string clave = SegNetAdapter.Crypto.Encrypt(model.Password, "ELS");
            Seguridad.gstrSesion = objSeguridadWeb.fncInicioSesion(model.UserName, clave, Seguridad.gstrSistema);
            if (Seguridad.gstrSesion.Length > 1)
            {
                FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                if (this.Url.IsLocalUrl(returnUrl))
                {
                    Seguridad.gstrUsuario = model.UserName;
                    if ((Session["gstrUsuarioSp"] == null) || (Session["DatosUsuarioSp"] == null))
                    {
                        var Cnt = per.spePELpPersonalElectrosur.Where(ttp => ttp.Dni == model.UserName).Count();
                        if (Cnt == 1)
                        {
                            Session["gstrUsuarioSp"] = model.UserName;
                            var DatosUsuario = per.spePERiPersonal(model.UserName).FirstOrDefault();
                            Session["DatosUsuarioSp"] = DatosUsuario.Trabajador;
                        }
                        if (Cnt == 0)
                        {
                            var Aux = per.spePELpPersonalElectrosur.Where(ttp => ttp.CodigoSAP == model.UserName).FirstOrDefault();
                            Session["gstrUsuarioSp"] = Aux.Dni;
                            Session["DatosUsuarioSp"] = Aux.Trabajador;
                        }
                    }
                    Session["gstrSesionSp"] = Seguridad.gstrSesion;
                    Seguridad.fncDividirpermisos(Seguridad.gobjSeguridad.fncObtenerPermisos(Seguridad.gstrUsuario, Seguridad.gstrSistema, Seguridad.gstrSesion));
                    Seguridad.fncObtenerValoresPermisosTotal();
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {

                switch (Seguridad.gstrSesion)
                {
                    case "1":
                        this.ModelState.AddModelError("", "El usuario ingresado no existe. Por favor contactar con el Administrador.");
                        // fncLimpiartextos();
                        intContadorPWD = 0;
                        break;
                    //Exit Sub
                    case "2":
                        this.ModelState.AddModelError("", "El usuario ingresado no se encuentra asociado al sistema actual. Por favor contactar con el Administrador.");
                        intContadorPWD = 0;
                        break;
                    case "3":
                        this.ModelState.AddModelError("", "El usuario ingresado se encuentra bloqueado. Por favor contactar con el Administrador.");
                        intContadorPWD = 0;
                        break;
                    case "4":
                        this.ModelState.AddModelError("", "El usuario ingresado se encuentra deshabilitado. Por favor contactar con el Administrador.");
                        intContadorPWD = 0;
                        break;
                    case "5":
                        if (intContadorPWD == 0)
                        {
                            intContadorPWD += 1;
                            strUsuarioAnterior = model.UserName;
                        }
                        else if (strUsuarioAnterior == model.UserName)
                            intContadorPWD += 1;
                        else
                        {
                            strUsuarioAnterior = model.UserName;
                            intContadorPWD = 1;
                        }
                        break;
                    case "6":
                        //'Llamar el formulario de cambio de clave
                        //Me.Visible = False
                        //Seguridad.gstrSesion = Seguridad.gobjSeguridad.fncCambioClave(model.UserName);
                        return RedirectToAction("CambioClave", "Account", new { id = model.UserName });
                        //break;
                }
            }
            if (intContadorPWD >= Convert.ToInt16(Seguridad.gobjSeguridad.fncCantidadIntentosPassword()))
            {
                //'Llamar a sp para blokear usuario
                intResultado = Convert.ToInt16(Seguridad.gobjSeguridad.fncBloquearUsuario());
                this.ModelState.AddModelError("", "Sistema de Seguridad: Se ha equivocado más de las veces permitidas en el ingreso de su password. El usuario ha sido bloqueado. Por favor contactar con el Administrador.");

            }
            else if (intContadorPWD < Convert.ToInt16(Seguridad.gobjSeguridad.fncCantidadIntentosPassword()) & intContadorPWD != 0)
            {
                this.ModelState.AddModelError("", "Sistema de Seguridad: Se ha equivocado en el ingreso de su password. Por favor inténtelo nuevamente.");

            }
            return View(model);
            */

            Session["gstrUsuarioSp"] = model.UserName;
            Session["gstrSesionSp"] = "fhjfdjfdjfjjjfd124352";
            return View(model);
            
        }
        
        [CustomAuthorize]
        public ActionResult ChangePassword()
        {
            ViewBag.ClassActiveUsuario = "active";
            ViewBag.Username = Session["gstrUsuarioSp"].ToString();
            return View();
        }

        [CustomAuthorize]
        [HttpPost]
        public ActionResult ChangePassword(LogOnViewModel model)
        {
            ViewBag.ClassActiveUsuario = "active";
            model.UserName = Session["gstrUsuarioSp"].ToString();
            ViewBag.Username = Session["gstrUsuarioSp"].ToString();
            
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(model.NewPassword))
                {
                    this.ModelState.AddModelError("", "Repita su nueva contraseña.");
                    return View(model);
                }
                if (model.Password != model.NewPassword)
                {
                    this.ModelState.AddModelError("", "Las contraseñas ingresadas no son iguales.");
                    return View(model);
                }

                Seguridad.gstrSistema = "SGPLN";
                clsSeguridadNet objSeguridadWeb = new SegNetAdapter.clsSeguridadNet();
                if (!objSeguridadWeb.ValidatePassword(model.Password, 6, 12, 1, 1, 1, 0))
                {
                    this.ModelState.AddModelError("", "La contraseña tiene que contener números y letras (mayúsculas y minúsculas), entre 6 a 12 caracteres.");
                    return View(model);
                }
                string clave = SegNetAdapter.Crypto.Encrypt(model.Password, "ELS");
                string repiteClave = SegNetAdapter.Crypto.Encrypt(model.NewPassword, "ELS");
                if (clave.Trim() != "")
                {
                    if (clave.Trim() == repiteClave.Trim())
                    {

                        Seguridad.gstrSesion = objSeguridadWeb.fncCambioClave(model.UserName, clave, Seguridad.gstrSistema);
                        //this.ModelState.AddModelError("", model.UserName);
                        if (Seguridad.gstrSesion.Length > 1)
                        {
                            //return RedirectToAction("Index", "Home");
                            Session["gstrUsuarioSp"] = model.UserName;
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            switch (Seguridad.gstrSesion)
                            {
                                case "2":
                                    this.ModelState.AddModelError("", "La contraseña ingresada es igual a la actual. Ingrese una nueva contraseña.");
                                    //ViewBag.msgError = "La contraseña ingresada es igual a la actual. Ingrese una nueva contraseña.";
                                    break;
                                // fncLimpiartextos();
                                case "3":
                                    this.ModelState.AddModelError("", "La contraseña es igual al nombre del usuario.Ingrese una nueva contraseña.");
                                    //ViewBag.msgError = "La contraseña es igual al nombre del usuario.Ingrese una nueva contraseña.";
                                    break;
                            }
                        }
                    }
                }
                Seguridad.gstrSesion = objSeguridadWeb.fncCambioClave(model.UserName, clave, Seguridad.gstrSistema);
                if (Seguridad.gstrSesion.Length > 1)
                {
                    Session["gstrUsuarioSp"] = model.UserName;
                    //return RedirectToAction("Index", "indicador");
                }
                else
                {
                    Seguridad.gstrSesion = objSeguridadWeb.fncInicioSesion(model.UserName, clave, Seguridad.gstrSistema);
                }
                ViewBag.msgSeCambioPass = "Su contraseña ha sido actualizada";
            }
            return View(model);
        }

        //GET: /Account/CambioClave
        [AllowAnonymous]
        public ActionResult CambioClave(string id)
        {
            LogOnViewModel model = new Models.LogOnViewModel();
            model.UserName = id;
            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult CambioClave(LogOnViewModel model, string returnUrl)
        {
            if (string.IsNullOrEmpty(model.NewPassword))
            {
                this.ModelState.AddModelError("", "Repita su nueva contraseña.");
                return View(model);
            }
            if (model.Password != model.NewPassword)
            {
                this.ModelState.AddModelError("", "Las contraseñas ingresadas no son iguales.");
                return View(model);
            }

            Seguridad.gstrSistema = "SGPLN";
            clsSeguridadNet objSeguridadWeb = new SegNetAdapter.clsSeguridadNet();
            if (!objSeguridadWeb.ValidatePassword(model.Password, 6, 12, 1, 1, 1, 0))
            {
                this.ModelState.AddModelError("", "La contraseña tiene que contener números y letras (mayúsculas y minúsculas), entre 6 a 12 caracteres.");
                return View(model);
            }
            string clave = SegNetAdapter.Crypto.Encrypt(model.Password, "ELS");
            string repiteClave = SegNetAdapter.Crypto.Encrypt(model.NewPassword, "ELS");
            if (clave.Trim() != "")
            {
                if (clave.Trim() == repiteClave.Trim())
                {

                    Seguridad.gstrSesion = objSeguridadWeb.fncCambioClave(model.UserName, clave, Seguridad.gstrSistema);
                    //this.ModelState.AddModelError("", model.UserName);
                    if (Seguridad.gstrSesion.Length > 1)
                    {
                        //return RedirectToAction("Index", "Home");
                        Session["gstrUsuarioSp"] = model.UserName;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        switch (Seguridad.gstrSesion)
                        {
                            case "2":
                                this.ModelState.AddModelError("", "La contraseña ingresada es igual a la actual. Ingrese una nueva contraseña.");
                                //ViewBag.msgError = "La contraseña ingresada es igual a la actual. Ingrese una nueva contraseña.";
                                break;
                            // fncLimpiartextos();
                            case "3":
                                this.ModelState.AddModelError("", "La contraseña es igual al nombre del usuario.Ingrese una nueva contraseña.");
                                //ViewBag.msgError = "La contraseña es igual al nombre del usuario.Ingrese una nueva contraseña.";
                                break;
                        }
                    }
                }
            }
            return View(model);
        }
        
        // POST: /Account/LogOff
        [HttpPost]
        public ActionResult LogOff()
        {
            Session["gstrUsuarioSp"] = null;
            Session.Remove("divisionPermiso");
            FormsAuthentication.SignOut();
            Session.Remove("gstrUsuarioSp");
            Session.Abandon();
            Session.Clear();
            return RedirectToAction("LogOn", "Account", new { ReturnUrl = "/" });
        }

    }
}