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
    
    public partial class Venta_Detalle
    {
        public int id_detalle { get; set; }
        public int cantidad { get; set; }
        public double subtotal { get; set; }
        public double precio_unitario { get; set; }
        public int id_producto { get; set; }
        public int id_ventas { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Venta Venta { get; set; }
    }
}