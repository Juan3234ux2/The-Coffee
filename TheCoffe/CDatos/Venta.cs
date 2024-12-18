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
    
    public partial class Venta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venta()
        {
            this.Venta_Detalle = new HashSet<Venta_Detalle>();
        }
    
        public int id_ventas { get; set; }
        public Nullable<System.DateTime> fecha_venta { get; set; }
        public int id_mesero { get; set; }
        public int id_mesa { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public string estado { get; set; }
        public Nullable<double> monto_total { get; set; }
        public Nullable<int> id_turno { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Mesa Mesa { get; set; }
        public virtual Mesero Mesero { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Detalle> Venta_Detalle { get; set; }
        public virtual Turno_Caja Turno_Caja { get; set; }
    }
}
