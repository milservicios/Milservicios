using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Milservicios.Models.BaseDatos;

namespace Milservicios.Controllers
{
    public class GestionAnunciosController : Controller
    {
        //Llamamos a la base de datos
        BaseDatos db = new BaseDatos();

        /* GET: GestionAnuncios
        public ActionResult Index()
        {
            return View();
        }*/
        // Registro de anuncios
        [HttpGet]
        public ActionResult TipoAnuncios()
        {
            return View();
        }
        // Registro de anuncios de CLASES PARTICULARES
        [HttpGet]
        public ActionResult RegistroAnunciosClasPart()
        {
            return View();
        }
        //post
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
            db.RegistroAnunciosClasePart(duracion, horario, nacionalidad, carnet, sueldo, zona, fumador, asignatura, curso, tipo, lugar);
            return Redirect("/Home/Index");
        }
        // Resgistro de anuncios de CUIDADO DE MASCOTAS
        [HttpGet]
        public ActionResult RegistroAnunciosCuidadoMasc()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistroAnunciosCuidadoMasc(int duracion,
            string horario,
            string nacionalidad,
            bool carnet,
            double sueldo,
            string zona,
            bool fumador,
            string animal,
            short numero)
        {
            if (carnet != true)
            {
                carnet = false;
            }
            if (fumador != true)
            {
                fumador = false;
            }
            db.RegistroAnunciosCudadoMasc(duracion, horario, nacionalidad, carnet, sueldo, zona, fumador, animal, numero);
            return Redirect("/Home/Index");
        }

        // Resgistro de anuncios de CUIDADO DE PERSONAS
        [HttpGet]
        public ActionResult RegistroAnunciosCuidadoPers()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistroAnunciosCuidadoPers(int duracion,
            string horario,
            string nacionalidad,
            bool carnet,
            double sueldo,
            string zona,
            bool fumador,
            short edad,
            short numero,
            string tipo)
        {
            if (carnet != true)
            {
                carnet = false;
            }
            if (fumador != true)
            {
                fumador = false;
            }
            db.RegistroAnunciosCudadoPers(duracion, horario, nacionalidad, carnet, sueldo, zona, fumador, edad, numero, tipo);
            return Redirect("/Home/Index");
        }

        // Resgistro de anuncios de LABORES DOMESTICAS  
        [HttpGet]
        public ActionResult RegistroAnunciosLaboresDom()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistroAnunciosLaboresDom(int duracion,
            string horario,
            string nacionalidad,
            bool carnet,
            double sueldo,
            string zona,
            bool fumador,
            string tarea)
        {
            if (carnet != true)
            {
                carnet = false;
            }
            if (fumador != true)
            {
                fumador = false;
            }
            db.RegistroAnunciosLaborDom(duracion, horario, nacionalidad, carnet, sueldo, zona, fumador, tarea);
            return Redirect("/Home/Index");
        }
        //Retorno de las vistas de anuncios
        [HttpGet]
        public ActionResult VistaAnuncios() { return View(); }
        [HttpPost]
        public ActionResult VistaAnuncios(string abc) { return View(); }
    }

//Fin2
}