using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reCAPTCHA.MVC;
using Milservicios.Models.BaseDatos;
using Milservicios.Models.TablasSQL;

namespace Milservicios.Controllers
{
    public class ControlWebController : Controller
    {

        //Llamamos a la base de datos
        BaseDatos db = new BaseDatos();

        //Otros
        public List<SelectListItem> ObtenerLista()
        {
            return new List<SelectListItem>()
                 {
                      new SelectListItem()
                         {
                             Text = "FAMILIA",
                             Value = "1",
                             Selected = true

                           },
                      new SelectListItem()
                          {
                             Text = "PROFESIONAL",
                              Value = "2",
                             Selected = true
                           },
                      new SelectListItem()
                          {
                             Text = "AMBOS",
                              Value = "3",
                             Selected = true
                          },
                      };
        }

        // GET: ControlWeb
        public ActionResult Index()
        {
            return View();
        }
        // Retorno de la vista registro  
        [HttpGet]
        public ActionResult Registro()
        {
            ViewBag.Milista = ObtenerLista();
            return View();
        }
        // Retornno de la vista registro con un modelo
        /*
        [HttpPost]
        public ActionResult Registro(string nombre, string apellido, int telefono, string email, string contraseña)
        {
            db.RegistroFamilia(nombre,apellido,telefono,email,contraseña);
            return View();
        }
        */
        /*  ---------------- IMPORTANTE ----------------
         * MODIFICACIÓN DE LAS VISTAS DE REGISTRO
         * HABRÁ CUATRO VISTAS, PRINCIPAL Y SECUNDARIAS
         * LA PRINCIPAL SOLO VALDRÁ PARA SER ENLACE DE
         * LAS SECUNDARIAS... CUIDADO CON LOS QUE 
         * IMPLEMENTAIS...
         */
         /*Registro HTTPGET*/
        //RegistroUsuario
        [HttpGet]
        public ActionResult RegistroUsuario()
        {
            return View();
        }
        //Registro de Familias
        [HttpGet]
        public ActionResult RegistroFamilia()
        {
            return View();
        }
        //Registro de Profesionales
        [HttpGet]
        public ActionResult RegistroProfesional()
        {
            return View();
        }
        //Registro de Ambos
        [HttpGet]
        public ActionResult RegistroAmbos()
        {
            return View();
        }
        /*Registro HTTPPOST*/       
        //Registro de Familias
        [HttpPost]
        [CaptchaValidator]
        public ActionResult RegistroFamilia(string nombre,
            string apellido, 
            int telefono,
            string email,
            string contraseña,
            string ciudad)
        {
            db.RegistroFamilia(nombre, apellido, telefono, email, contraseña, ciudad);
            return View();
        }
        //Registro de Profesionales
        [HttpPost]
        public ActionResult RegistroProfesional(string nombre,
            string apellido,
            int telefono,
            string email, 
            string contraseña,
            string sexo,
            short edad,
            string descripcion,
            string zona
            )
        {
            db.RegistroProfesional(nombre, apellido, telefono, email, contraseña, sexo,edad, descripcion, zona);
            return View();
        }
        //Registro de Ambos
        [HttpPost]
        public ActionResult RegistroAmbos(string nombre, 
            string apellido, 
            int telefono, 
            string email, 
            string contraseña,
            string ciudad,
            string sexo,
            short edad,
            string descripcion,
            string zona)
        {
            db.RegistroAmbos(nombre, apellido, telefono, email, contraseña, ciudad, sexo, edad, descripcion, zona);
            return View();
        }
        // Retorno de la vista acceso
        [HttpGet]
        public ActionResult Acceso()
        {
            ViewBag.Message = "En esta pagina podras realizar el acceso a la pagina.";
            return View();
        }
        // Retornno a la vista acceso con el email y contraseña
        [HttpPost]
        public ActionResult Acceso(string email, string contraseña)
        {
            return View();
        }

    }
}