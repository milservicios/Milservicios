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

    public class ArrayUsuarios
    {
        // ---------------------------------------Lista de ususarios Familia------------------------------------------------------//
        public List<FamiliaUsuarios> usuariosFamilia = new List<FamiliaUsuarios>();
        public List<ProfesionalUsuarios> usuariosProfesional = new List<ProfesionalUsuarios>();

        public void regUsuarios()
        {

            FamiliaUsuarios familia1 = new FamiliaUsuarios();
            familia1.Id_Familia = 1;
            familia1.Nombre = "Ibon";
            familia1.Apellido = "Zugasti";
            familia1.Telefono = 600000000;
            familia1.Email = "elgallo@gmail.com";
            familia1.Sexo = "Masculino";
            familia1.Contraseña = "Victorito14";
            familia1.Ciudad = "San Sebastian";
            familia1.Edad = 42;
            familia1.Descripcion = "Soy un ciclista profesional. Estoy estudiando la carrera de economicas y necesito un profesor particular.";

            // Añadimos el usuario a la lista

            usuariosFamilia.Add(familia1);


            //--------------------------------------Lista de usuarios Profesional-----------------------------------------------------//


            ProfesionalUsuarios profesional1 = new ProfesionalUsuarios();
            // Datos del usuario
            profesional1.Id_Profesional = 2;
            profesional1.Nombre = "Tomas";
            profesional1.Apellido = "Misser";
            profesional1.Telefono = 600000001;
            profesional1.Email = "elcapo@gmail.com";
            profesional1.Contraseña = "Victorito14";
            // Datos de profesional del usuario
            profesional1.Ciudad = "San Sebastian";
            profesional1.Sexo = "Masculino";
            profesional1.Edad = 25;
            profesional1.Curriculum = "Licenciado en Economia";
            profesional1.Descripcion = "Soy un licenciado en economia por la UAH. Doy clases particulares a alumnos de economia en San Sebastian.";

            usuariosProfesional.Add(profesional1);
        }

        public void selializarDatosFamilia()
        {
            XmlSerializer s = new XmlSerializer(typeof(List<FamiliaUsuarios>));
            TextWriter w = new StreamWriter(@"C:\Users\Alberto\Source\Repos\Milservicios\UsuariosFamilia.xml");
            s.Serialize(w, usuariosFamilia);
            w.Close();
        }
        public void leerUsuariosFamilia()
        {
            XmlSerializer s = new XmlSerializer(typeof(List<FamiliaUsuarios>));
            TextReader r = new StreamReader(@"C:\Users\Alberto\source\repos\Milservicios\UsuariosFamilia.xml");
            usuariosFamilia = (List<FamiliaUsuarios>)s.Deserialize(r);
            r.Close();
        }
        public void selializarDatosProfesional()
        {
            XmlSerializer s = new XmlSerializer(typeof(List<ProfesionalUsuarios>));
            TextWriter w = new StreamWriter(@"C:\Users\Alberto\source\repos\Milservicios\UsuariosProfesionales.xml");
            s.Serialize(w, usuariosProfesional);
            w.Close();
        }
        public void leerUsuariosProfesional()
        {
            XmlSerializer s = new XmlSerializer(typeof(List<ProfesionalUsuarios>));
            TextReader r = new StreamReader(@"C:\Users\Alberto\source\repos\Milservicios\UsuariosProfesionales.xml");
            usuariosProfesional = (List<ProfesionalUsuarios>)s.Deserialize(r);
            r.Close();
        }

    }
}