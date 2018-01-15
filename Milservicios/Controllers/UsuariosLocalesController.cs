using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Milservicios.Models.DatosLocales;

namespace Milservicios.Controllers
{
    public class UsuariosLocalesController : Controller
    {
        ArrayUsuarios inicializar = new ArrayUsuarios();
        // GET: UsuariosLocales
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult perfilUsuario()
        {
            inicializar.regUsuarios();
            inicializar.selializarDatosFamilia();
            inicializar.selializarDatosProfesional();
            //inicializar.leerUsuariosFamilia();
            //inicializar.leerUsuariosProfesional();
            //Datos familia
            ViewData["Nombre"] = inicializar.usuariosFamilia[0].Nombre;
            ViewData["Apellido"] = inicializar.usuariosFamilia[0].Apellido;
            ViewData["Telefono"] = inicializar.usuariosFamilia[0].Telefono;
            ViewData["Email"] = inicializar.usuariosFamilia[0].Email;
            ViewData["Ciudad"] = inicializar.usuariosFamilia[0].Ciudad;
            ViewData["Edad"] = inicializar.usuariosFamilia[0].Edad;
            ViewData["Descripcion"] = inicializar.usuariosFamilia[0].Descripcion;
            //Datos profesional
            ViewData["Nombre1"] = inicializar.usuariosProfesional[0].Nombre;
            ViewData["Apellido1"] = inicializar.usuariosProfesional[0].Apellido;
            ViewData["Telefono1"] = inicializar.usuariosProfesional[0].Telefono;
            ViewData["Email1"] = inicializar.usuariosProfesional[0].Email;
            ViewData["Ciudad1"] = inicializar.usuariosProfesional[0].Ciudad;
            ViewData["Edad1"] = inicializar.usuariosProfesional[0].Edad;
            ViewData["Curriculum1"] = inicializar.usuariosProfesional[0].Curriculum;
            ViewData["Descripcion1"] = inicializar.usuariosProfesional[0].Descripcion;
            return View();
        }
        [HttpPost]
        public ActionResult RegistroAnunciosClasPar(int duracion,
            string horario,
            string nacionalidad,
            bool carnet,
            double sueldo,
            string zona,
            bool fumador,
            string asignatura,
            string curso,
            string tipo,
            string lugar)
        {
            if (carnet != true)
            {
                carnet = false;
            }
            if (fumador != true)
            {
                fumador = false;
            }
            //db.RegistroAnunciosClasePart(duracion, horario, nacionalidad, carnet, sueldo, zona, fumador, asignatura, curso, tipo, lugar);
            return Redirect("/Home/Index");
        }
    }
}