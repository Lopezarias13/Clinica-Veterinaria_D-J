//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clinica_Veterinaria.Dato
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bitacora
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Accion { get; set; }
        public int UsuarioId { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
