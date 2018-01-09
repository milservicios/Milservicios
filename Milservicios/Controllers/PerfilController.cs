using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Milservicios.Controllers
{
    public class PerfilController : Controller
    {
        /*Retorno de vistas*/
        //Retorno de perfil familia
        [HttpGet]
        public ActionResult PerfilFamilia() { return View(); }
        //Retorno de perfil profesional
        [HttpGet]
        public ActionResult PerfilProfesional() { return View(); }
        //Retorno de perfil ambos
        [HttpGet]
        public ActionResult PerfilAmbos() { return View(); }

        /*Retorno de modificaciones*/
        //Retorno de perfil familia
        [HttpPost]
        public ActionResult PerfilFamilia(string abc ){ return View(); }
        //Retorno de perfil profesional
        [HttpPost]
        public ActionResult PerfilProfesional(string abc) { return View(); }
        //Retorno de perfil ambos
        [HttpPost]
        public ActionResult PerfilAmbos(string abc) { return View(); }
    }
}