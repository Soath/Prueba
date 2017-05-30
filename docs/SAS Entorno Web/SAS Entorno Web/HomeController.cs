using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaPlanificacion.Models;
namespace SistemaPlanificacion.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Normatividad()
        {
            if (Seguridad.pfncObtenerPermisos("SGPLN_PLN_PMV") != true)
                return RedirectToAction("Index", "Home");
            return View();
        }

        [AllowAnonymous]
        public ActionResult Enlaces()
        {
            if (Seguridad.pfncObtenerPermisos("SGPLN_PLN_PPA") != true)
                return RedirectToAction("Index", "Home");
            return View();
        }

        [AllowAnonymous]
        public ActionResult Foda()
        {
            if (Seguridad.pfncObtenerPermisos("SGPLN_PLN_FDA") != true)
                return RedirectToAction("Index", "Home");
            return View();
        }

        [AllowAnonymous]
        public ActionResult Matriz()
        {
            if (Seguridad.pfncObtenerPermisos("SGPLN_PLN_MTZ") != true)
                return RedirectToAction("Index", "Home");
            return View();
        }

        [AllowAnonymous]
        public ActionResult FactoresCriticos()
        {
            if (Seguridad.pfncObtenerPermisos("SGPLN_PLN_FCE") != true)
                return RedirectToAction("Index", "Home");
            return View();
        }
    }
}
