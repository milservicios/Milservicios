using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
        [HttpPost]
        public ActionResult Registro(string nombre, string apellido, int telefono, string email, string contraseña)
        {
            db.RegistroUsuario(nombre,apellido,telefono,email,contraseña);
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