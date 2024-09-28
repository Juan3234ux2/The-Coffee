using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoffe.CDatos
{
    public class Categoria
    {
        public int id_categoria { get; set; }
        public string descripcion { get; set; } 

        public Categoria()
        {

        }

        public Categoria(int id_categoria, string descripcion)
        {
            this.id_categoria = id_categoria;
            this.descripcion = descripcion;
        }
    }
}
