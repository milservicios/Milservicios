using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Milservicios.Controllers
{
    public class PerfilController : Controller
    {
        /*Perfil de Usuario*/
        //GET
        //Retorno de perfil familia
        [HttpGet]
        public ActionResult PerfilFamilia() { return View(); }
        //Retorno de perfil profesional
        [HttpGet]
        public ActionResult PerfilProfesional() { return View(); }
        //Retorno de perfil ambos
        [HttpGet]
        public ActionResult PerfilAmbos() { return View(); }
        //POST        
        //Retorno de perfil familia
        [HttpPost]
        public ActionResult PerfilFamilia(string abc ){ return View(); }
        //Retorno de perfil profesional
        [HttpPost]
        public ActionResult PerfilProfesional(string abc) { return View(); }
        //Retorno de perfil ambos
        [HttpPost]
        public ActionResult PerfilAmbos(string abc) { return View(); }
        
        /*Modificar Perfil de Usuario*/
        //GET
        //Retorno modificar perfil familia
        [HttpGet]        
        public ActionResult ModificarPerfilFamilia() { return View(); }
        //Retorno modificar perfil profesional
        [HttpGet]        
        public ActionResult ModificarPerfilProfesional() { return View(); }
        //Retorno modificar perfil ambos
        [HttpGet]
        public ActionResult ModificarPerfilAmbos() { return View(); }
        //POST
        //Retorno modificar perfil familia
        [HttpPost]
        public ActionResult ModificarPerfilFamilia(string abc) { return View(); }
        //Retorno modificar perfil profesional
        [HttpPost]        
        public ActionResult ModificarPerfilProfesional(string abc) { return View(); }
        //Retorno modificar perfil ambos
        [HttpPost]
        public ActionResult ModificarPerfilAmbos(string abc) { return View(); }

    }
}