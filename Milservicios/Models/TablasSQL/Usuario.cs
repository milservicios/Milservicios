//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Milservicios.Models.TablasSQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class USUARIO
    {
        public int Id_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Telefono { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
    
        public virtual FAMILIA FAMILIA { get; set; }
        public virtual PROFESIONAL PROFESIONAL { get; set; }
    }
}
