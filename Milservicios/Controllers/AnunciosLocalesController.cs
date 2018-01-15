using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Milservicios.Models.DatosLocales;

namespace Milservicios.Controllers
{
    public class AnunciosLocalesController : Controller
    {
        ArrayAnuncios inicializar = new ArrayAnuncios();
        ArrayUsuarios usuarios = new ArrayUsuarios();
        // GET: AnunciosLocales
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult VistaAnuncios()
        {

            inicializar.leerAnunciosFamilia();
            inicializar.leerAnunciosProfesional();
            //inicializar.regAnuncios();
            //inicializar.selializarDatosFamilia();
            //inicializar.selializarDatosProfesional();

            //Datos familia

            ViewData["TipoAnuncio"] = inicializar.anunciosFamilia[0].TipoAnuncio;
            ViewData["Duracion"] = inicializar.anunciosFamilia[0].Duracion;
            ViewData["Ciudad"] = inicializar.anunciosFamilia[0].Ciudad;
            ViewData["AnuncioTipo"] = "Usuario Familia";
            //-----
            ViewData["TipoAnuncio1"] = inicializar.anunciosProfesional[0].TipoAnuncio;
            ViewData["Duracion1"] = inicializar.anunciosProfesional[0].Duracion;
            ViewData["Ciudad1"] = inicializar.anunciosProfesional[0].Ciudad;
            ViewData["AnuncioTipo1"] = "Usuario Profesional";
            //-----
            ViewData["TipoAnuncio2"] = inicializar.anunciosProfesional[1].TipoAnuncio;
            ViewData["Duracion2"] = inicializar.anunciosProfesional[1].Duracion;
            ViewData["Ciudad2"] = inicializar.anunciosProfesional[1].Ciudad;
            ViewData["AnuncioTipo2"] = "Usuario Profesional";
            //-----
            ViewData["TipoAnuncio3"] = inicializar.anunciosFamilia[1].TipoAnuncio;
            ViewData["Duracion3"] = inicializar.anunciosFamilia[1].Duracion;
            ViewData["Ciudad3"] = inicializar.anunciosFamilia[1].Ciudad;
            ViewData["AnuncioTipo3"] = "Usuario Familia";
            //-----
            ViewData["TipoAnuncio4"] = inicializar.anunciosFamilia[2].TipoAnuncio;
            ViewData["Duracion4"] = inicializar.anunciosFamilia[2].Duracion;
            ViewData["Ciudad4"] = inicializar.anunciosFamilia[2].Ciudad;
            ViewData["AnuncioTipo4"] = "Usuario Familia";
            //-----
            ViewData["TipoAnuncio5"] = inicializar.anunciosProfesional[2].TipoAnuncio;
            ViewData["Duracion5"] = inicializar.anunciosProfesional[2].Duracion;
            ViewData["Ciudad5"] = inicializar.anunciosProfesional[2].Ciudad;
            ViewData["AnuncioTipo5"] = "Usuario Profesional";
            //-----
            ViewData["TipoAnuncio6"] = inicializar.anunciosProfesional[3].TipoAnuncio;
            ViewData["Duracion6"] = inicializar.anunciosProfesional[3].Duracion;
            ViewData["Ciudad6"] = inicializar.anunciosProfesional[3].Ciudad;
            ViewData["AnuncioTipo6"] = "Usuario Profesional";



            /*ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            /*var anuncios = from s in inicializar.anunciosFamilia
                           select s;*/
            /*switch (sortOrder)
            {
                case "name_desc":
                    anuncios = anuncios.OrderByDescending(s => s.TipoAnuncio);
                    break;
                case "Date":
                    anuncios = anuncios.OrderBy(s => s.Sueldo);
                    break;
                case "date_desc":
                    anuncios = anuncios.OrderByDescending(s => s.Ciudad);
                    break;
                default:
                    anuncios = anuncios.OrderBy(s => s.TipoAnuncio);
                    break;
            }*/
            return View();



        }
        [HttpGet]
        public ActionResult Detalles1()
        {
            usuarios.regUsuarios();
            inicializar.leerAnunciosFamilia();
            inicializar.leerAnunciosProfesional();
            ViewData["TipoAnuncio1"] = inicializar.anunciosProfesional[0].TipoAnuncio;
            ViewData["Duracion1"] = inicializar.anunciosProfesional[0].Duracion;
            ViewData["Ciudad1"] = inicializar.anunciosProfesional[0].Ciudad;
            ViewData["AnuncioTipo1"] = "Usuario Profesional";
            ViewData["Horario1"] = inicializar.anunciosProfesional[0].Horario;
            ViewData["Carnet1"] = inicializar.anunciosProfesional[0].Carnet;
            ViewData["Zona1"] = inicializar.anunciosProfesional[0].Zona;
            ViewData["Fumador1"] = inicializar.anunciosProfesional[0].Fumador;
            ViewData["Descripcion1"] = inicializar.anunciosProfesional[0].Descripcion;
            ViewData["Curso1"] = inicializar.anunciosProfesional[0].Curso;
            ViewData["Asignatura1"] = inicializar.anunciosProfesional[0].Asignatura;

            //Datos Usuario
            ViewData["Nombre1"] = usuarios.usuariosProfesional[0].Nombre;
            ViewData["Apellido1"] = usuarios.usuariosProfesional[0].Apellido;
            ViewData["Telefono1"] = usuarios.usuariosProfesional[0].Telefono;
            ViewData["Email1"] = usuarios.usuariosProfesional[0].Email;
            ViewData["Sexo1"] = usuarios.usuariosProfesional[0].Sexo;
            ViewData["Edad1"] = usuarios.usuariosProfesional[0].Edad;
            ViewData["Curriculum1"] = usuarios.usuariosProfesional[0].Curriculum;


            return View();
        }
        [HttpGet]
        public ActionResult misAnuncios()
        {
            inicializar.leerAnunciosFamilia();
            inicializar.leerAnunciosProfesional();


            ViewData["TipoAnuncio"] = inicializar.anunciosFamilia[0].TipoAnuncio;
            ViewData["Duracion"] = inicializar.anunciosFamilia[0].Duracion;
            ViewData["Ciudad"] = inicializar.anunciosFamilia[0].Ciudad;
            ViewData["AnuncioTipo"] = "Usuario Familia";
            //-----
            ViewData["TipoAnuncio2"] = inicializar.anunciosProfesional[1].TipoAnuncio;
            ViewData["Duracion2"] = inicializar.anunciosProfesional[1].Duracion;
            ViewData["Ciudad2"] = inicializar.anunciosProfesional[1].Ciudad;
            ViewData["AnuncioTipo2"] = "Usuario Profesional";
            return View();
        }
        [HttpGet]
        public ActionResult misAnunciosDetalles1()
        {
            usuarios.regUsuarios();
            inicializar.leerAnunciosFamilia();
            inicializar.leerAnunciosProfesional();
            ViewData["TipoAnuncio1"] = inicializar.anunciosProfesional[1].TipoAnuncio;
            ViewData["Duracion1"] = inicializar.anunciosProfesional[1].Duracion;
            ViewData["Ciudad1"] = inicializar.anunciosProfesional[1].Ciudad;
            ViewData["AnuncioTipo1"] = "Usuario Profesional";
            ViewData["Horario1"] = inicializar.anunciosProfesional[1].Horario;
            ViewData["Carnet1"] = inicializar.anunciosProfesional[1].Carnet;
            ViewData["Zona1"] = inicializar.anunciosProfesional[1].Zona;
            ViewData["Fumador1"] = inicializar.anunciosProfesional[1].Fumador;
            ViewData["Descripcion1"] = inicializar.anunciosProfesional[1].Descripcion;
            ViewData["Curso1"] = inicializar.anunciosProfesional[1].Animal;
            ViewData["Asignatura1"] = inicializar.anunciosProfesional[1].NumeroAnimales;




            return View();
        }
        [HttpGet]
        public ActionResult misAnunciosDetalles2()
        {
            usuarios.regUsuarios();
            inicializar.leerAnunciosFamilia();
            inicializar.leerAnunciosProfesional();
            ViewData["TipoAnuncio1"] = inicializar.anunciosProfesional[0].TipoAnuncio;
            ViewData["Duracion1"] = inicializar.anunciosProfesional[0].Duracion;
            ViewData["Ciudad1"] = inicializar.anunciosProfesional[0].Ciudad;
            ViewData["AnuncioTipo1"] = "Usuario Profesional";
            ViewData["Horario1"] = inicializar.anunciosProfesional[0].Horario;
            ViewData["Carnet1"] = inicializar.anunciosProfesional[0].Carnet;
            ViewData["Zona1"] = inicializar.anunciosProfesional[0].Zona;
            ViewData["Fumador1"] = inicializar.anunciosProfesional[0].Fumador;
            ViewData["Descripcion1"] = inicializar.anunciosProfesional[0].Descripcion;
            ViewData["Curso1"] = inicializar.anunciosProfesional[0].Curso;
            ViewData["Asignatura1"] = inicializar.anunciosProfesional[0].Asignatura;




            return View();
        }
        [HttpGet]
        public ActionResult misReservas()
        {
            usuarios.regUsuarios();
            inicializar.leerAnunciosFamilia();
            inicializar.leerAnunciosProfesional();
            ViewData["TipoAnuncio1"] = inicializar.anunciosProfesional[0].TipoAnuncio;
            ViewData["Duracion1"] = inicializar.anunciosProfesional[0].Duracion;
            ViewData["Ciudad1"] = inicializar.anunciosProfesional[0].Ciudad;
            ViewData["AnuncioTipo1"] = "Usuario Profesional";
            ViewData["Horario1"] = inicializar.anunciosProfesional[0].Horario;
            ViewData["Carnet1"] = inicializar.anunciosProfesional[0].Carnet;
            ViewData["Zona1"] = inicializar.anunciosProfesional[0].Zona;
            ViewData["Fumador1"] = inicializar.anunciosProfesional[0].Fumador;
            ViewData["Descripcion1"] = inicializar.anunciosProfesional[0].Descripcion;
            ViewData["Curso1"] = inicializar.anunciosProfesional[0].Curso;
            ViewData["Asignatura1"] = inicializar.anunciosProfesional[0].Asignatura;




            return View();
        }
        [HttpGet]
        public ActionResult misReservasDetalles1()
        {
            usuarios.regUsuarios();
            inicializar.leerAnunciosFamilia();
            inicializar.leerAnunciosProfesional();
            ViewData["TipoAnuncio1"] = inicializar.anunciosProfesional[0].TipoAnuncio;
            ViewData["Duracion1"] = inicializar.anunciosProfesional[0].Duracion;
            ViewData["Ciudad1"] = inicializar.anunciosProfesional[0].Ciudad;
            ViewData["AnuncioTipo1"] = "Usuario Profesional";
            ViewData["Horario1"] = inicializar.anunciosProfesional[0].Horario;
            ViewData["Carnet1"] = inicializar.anunciosProfesional[0].Carnet;
            ViewData["Zona1"] = inicializar.anunciosProfesional[0].Zona;
            ViewData["Fumador1"] = inicializar.anunciosProfesional[0].Fumador;
            ViewData["Descripcion1"] = inicializar.anunciosProfesional[0].Descripcion;
            ViewData["Curso1"] = inicializar.anunciosProfesional[0].Curso;
            ViewData["Asignatura1"] = inicializar.anunciosProfesional[0].Asignatura;

            //Datos Usuario
            ViewData["Nombre1"] = usuarios.usuariosProfesional[0].Nombre;
            ViewData["Apellido1"] = usuarios.usuariosProfesional[0].Apellido;
            ViewData["Telefono1"] = usuarios.usuariosProfesional[0].Telefono;
            ViewData["Email1"] = usuarios.usuariosProfesional[0].Email;
            ViewData["Sexo1"] = usuarios.usuariosProfesional[0].Sexo;
            ViewData["Edad1"] = usuarios.usuariosProfesional[0].Edad;
            ViewData["Curriculum1"] = usuarios.usuariosProfesional[0].Curriculum;


            return View();
        }
    }
}