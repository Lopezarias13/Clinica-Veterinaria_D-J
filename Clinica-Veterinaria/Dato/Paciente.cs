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
    
    public partial class Paciente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paciente()
        {
            this.HistorialMedico = new HashSet<HistorialMedico>();
        }
    
        public int Id { get; set; }
        public string Property1 { get; set; }
        public string Codigo { get; set; }
        public string Alias { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public string ColorDePelo { get; set; }
        public string FechaNacimiento { get; set; }
        public string PesoMedio { get; set; }
        public string PesoActual { get; set; }
        public int ClienteId { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistorialMedico> HistorialMedico { get; set; }
    }
}
