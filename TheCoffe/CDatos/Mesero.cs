//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheCoffe.CDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mesero
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mesero()
        {
            this.DiaDeTrabajo = new HashSet<DiaDeTrabajo>();
        }
    
        public int id_mesero { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int hora_entrada { get; set; }
        public int hora_salida { get; set; }
        public int dni { get; set; }
        public string telefono { get; set; }
        public bool estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiaDeTrabajo> DiaDeTrabajo { get; set; }
    }
}