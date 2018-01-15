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
    public class AnunciosLocales
    {
        public int Id_Anuncio { get; set; }
        public int Duracion { get; set; }
        public string Horario { get; set; }
        public string Nacionalidad { get; set; }
        public string Carnet { get; set; }
        public double Sueldo { get; set; }
        public string Ciudad { get; set; }
        public string Zona { get; set; }
        public string Fumador { get; set; }
        public string Descripcion { get; set; }
        //Tipo de anuncio
        public string TipoAnuncio { get; set; }
        //Datos Labores Domesticas
        public string Tarea { get; set; }
        //Datos Cuidado de personas
        public short EdadPersona { get; set; }
        public short NumeroPersonas { get; set; }
        public string TipoDeCuidado { get; set; }
        //Datos cuidado de mascotas
        public string Animal { get; set; }
        public short NumeroAnimales { get; set; }
        //Datos Clases particulares
        public string Asignatura { get; set; }
        public string Curso { get; set; }
        //Id del usuario que pone el 
        public int IdProfesional { get; set; }
        public int IdFamilia { get; set; }
    }
}