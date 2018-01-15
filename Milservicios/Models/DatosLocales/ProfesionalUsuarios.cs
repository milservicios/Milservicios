using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Milservicios.Models.DatosLocales
{
    public class ProfesionalUsuarios
    {
        public int Id_Profesional { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Telefono { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string Sexo { get; set; }
        public string Ciudad { get; set; }
        public short Edad { get; set; }
        public string Descripcion { get; set; }
        public string Curriculum { get; set; }

    }
}