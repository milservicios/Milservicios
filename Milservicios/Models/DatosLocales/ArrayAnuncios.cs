using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Milservicios.Models.DatosLocales;
using Milservicios.Models.TablasSQL;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Milservicios.Models.DatosLocales
{
    public class ArrayAnuncios
    {
        public List<AnunciosLocales> anunciosFamilia = new List<AnunciosLocales>();
        public List<AnunciosLocales> anunciosProfesional = new List<AnunciosLocales>();

        public void regAnuncios()
        {

            AnunciosLocales familia1 = new AnunciosLocales();
            familia1.Id_Anuncio = 1;
            familia1.Duracion = 2;
            familia1.Horario = "16.00-18.00";
            familia1.Sueldo = 12;
            familia1.Carnet = "SI";
            familia1.Ciudad = "San Sebastian";
            familia1.Zona = "Calle Andina";
            familia1.Fumador = "NO";
            familia1.Descripcion = "Estoy estudiando economia y necesito clases de macroeconomia internacional.";
            familia1.TipoAnuncio = "Clases Particulares";
            familia1.Asignatura = "Macroeconomia";
            familia1.Curso = "Tercero de carrera";
            familia1.IdFamilia = 1;

            // Añadimos el usuario a la lista
            anunciosFamilia.Add(familia1);


            AnunciosLocales familia2 = new AnunciosLocales();
            familia2.Id_Anuncio = 2;
            familia2.Duracion = 4;
            familia2.Horario = "14.00-18.00";
            familia2.Sueldo = 12;
            familia2.Carnet = "SI";
            familia2.Ciudad = "Madrid";
            familia2.Zona = "Puerta del Sol";
            familia2.Fumador = "NO";
            familia2.Descripcion = "Busco una persona para realizar las labores de mi casa. Pago 12€ la hora.";
            familia2.TipoAnuncio = "Labores Domesticas";
            familia2.Tarea = "Limpiar y planchar";
            
            familia2.IdFamilia = 2;

            // Añadimos el usuario a la lista
            anunciosFamilia.Add(familia2);

            AnunciosLocales familia3 = new AnunciosLocales();
            familia3.Id_Anuncio = 3;
            familia3.Duracion = 48;
            familia3.Horario = "Dos dias";
            familia3.Sueldo = 12;
            familia3.Carnet = "SI";
            familia3.Ciudad = "Barcelona";
            familia3.Zona = "Calle Diagonal";
            familia3.Fumador = "NO";
            familia3.Descripcion = "Tengo 2 perros y necesito que alguien los cuide mientras me voy de viaje los dias 2 y 3 de febrero.";
            familia3.TipoAnuncio = "Cuidado de mascotas";
            familia3.Animal = "Perro";
            familia3.NumeroAnimales = 2;
            familia3.IdFamilia = 3;

            // Añadimos el usuario a la lista
            anunciosFamilia.Add(familia3);


            //--------------------------------------Lista de usuarios Profesional-----------------------------------------------------//


            AnunciosLocales profesional1 = new AnunciosLocales();
            profesional1.Id_Anuncio = 4;
            profesional1.Duracion = 3;
            profesional1.Horario = "16.00-19.00";
            profesional1.Sueldo = 45;
            profesional1.Carnet = "SI";
            profesional1.Ciudad = "San Sebastian";
            profesional1.Zona = "Cualquiera";
            profesional1.Fumador = "NO";
            profesional1.Descripcion = "Doy clases de economia a cualquier nivel.";
            profesional1.TipoAnuncio = "Clases Particilares";
            profesional1.Asignatura = "Economia";
            profesional1.Curso = "Todos";
            profesional1.IdProfesional = 2;

            // Añadimos el usuario a la lista
            anunciosProfesional.Add(profesional1);

            AnunciosLocales profesional2 = new AnunciosLocales();
            profesional2.Id_Anuncio = 5;
            profesional2.Duracion = 3;
            profesional2.Horario = "16.00-19.00";
            profesional2.Sueldo = 12;
            profesional2.Carnet = "SI";
            profesional2.Ciudad = "San Sebastian";
            profesional2.Zona = "Cualquiera";
            profesional2.Fumador = "NO";
            profesional2.Descripcion = "Cuido todo tipo de animales";
            profesional2.TipoAnuncio = "Cuidado de mascotas";
            profesional2.Animal = "Perros y gatos";
            profesional2.NumeroAnimales = 6;
            profesional2.IdFamilia = 1;

            // Añadimos el usuario a la lista
            anunciosProfesional.Add(profesional2);

            AnunciosLocales profesional3 = new AnunciosLocales();
            profesional3.Id_Anuncio = 6;
            profesional3.Duracion = 4;
            profesional3.Horario = "16.00-20.00";
            profesional3.Sueldo = 15;
            profesional3.Carnet = "SI";
            profesional3.Ciudad = "Sevilla";
            profesional3.Zona = "Cualquiera";
            profesional3.Fumador = "NO";
            profesional3.Descripcion = "Doy clases de ingles a cualquier nivel. Tengo nivel C2 de ingles.";
            profesional3.TipoAnuncio = "Clases Particilares";
            profesional3.Asignatura = "Ingles";
            profesional3.Curso = "Todos";
            profesional3.IdProfesional = 3;

            // Añadimos el usuario a la lista
            anunciosProfesional.Add(profesional3);

            AnunciosLocales profesional4 = new AnunciosLocales();
            profesional4.Id_Anuncio = 7;
            profesional4.Duracion = 8;
            profesional4.Horario = "12.00-20.00";
            profesional4.Sueldo = 15;
            profesional4.Carnet = "SI";
            profesional4.Ciudad = "Granada";
            profesional4.Zona = "Cualquiera";
            profesional4.Fumador = "NO";
            profesional4.Descripcion = "Puedo trabajar de canguro y cuidando a personas mayores. Tengo mucha experiencia cuidando niños.";
            profesional4.TipoAnuncio = "Cuidado de personas";
            profesional4.EdadPersona = 8;
            profesional4.NumeroPersonas = 3;
            profesional4.TipoDeCuidado = "Cualquier tipo de cuidado";
            profesional4.IdProfesional = 4;

            // Añadimos el usuario a la lista
            anunciosProfesional.Add(profesional4);
        }
        public void selializarDatosFamilia()
        {
            XmlSerializer s = new XmlSerializer(typeof(List<AnunciosLocales>));
            TextWriter w = new StreamWriter(@"C:\Users\Alberto\source\repos\Milservicios\AnunciosFamilia.xml");
            s.Serialize(w, anunciosFamilia);
            w.Close();
        }
        public void leerAnunciosFamilia()
        {
            XmlSerializer s = new XmlSerializer(typeof(List<AnunciosLocales>));
            TextReader r = new StreamReader(@"C:\Users\Alberto\source\repos\Milservicios\AnunciosFamilia.xml");
            anunciosFamilia = (List<AnunciosLocales>)s.Deserialize(r);
            r.Close();
        }
        public void selializarDatosProfesional()
        {
            XmlSerializer s = new XmlSerializer(typeof(List<AnunciosLocales>));
            TextWriter w = new StreamWriter(@"C:\Users\Alberto\source\repos\Milservicios\AnunciosProfesionales.xml");
            s.Serialize(w, anunciosProfesional);
            w.Close();
        }
        public void leerAnunciosProfesional()
        {
            XmlSerializer s = new XmlSerializer(typeof(List<AnunciosLocales>));
            TextReader r = new StreamReader(@"C:\Users\Alberto\source\repos\Milservicios\AnunciosProfesionales.xml");
            anunciosProfesional = (List<AnunciosLocales>)s.Deserialize(r);
            r.Close();
        }
    }
}