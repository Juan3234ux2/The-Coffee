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
    
    public partial class Producto
    {
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public string imagen { get; set; }
        public bool estado { get; set; }
        public int id_categoria { get; set; }
    
        public virtual Categoria1 Categoria1 { get; set; }
    }
}
