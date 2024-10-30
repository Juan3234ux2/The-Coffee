using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CDatos;
using System.Data.Entity;
using System.Data.SqlClient;

namespace TheCoffe.CAccesoADatos
{
    class CategoriaRepository
    {
        private DBTheCoffeeEntities _db;
        public void Create(Categoria1 categoria)
        {
            using (_db = new DBTheCoffeeEntities())
            {
                try
                {
                    _db.Categoria1.Add(categoria);
                    _db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear la categoria.", ex);
                }
            }
        }

        public async Task<List<Categoria1>> Read(bool estado)
        {
            using (_db = new DBTheCoffeeEntities())
            {
                 return await _db.Categoria1.Where(c => c.estado == estado)
                    .OrderBy(c => c.descripcion)
                    .ToListAsync();                           
            }
        }

        public Categoria1 SearchObject(int id)
        {
            using (_db = new DBTheCoffeeEntities())
            {
                try
                {
                    return _db.Categoria1.Find(id);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener la categoria.", ex);
                }
            }
        }

        public void Update(Categoria1 categoria)
        {
            using (_db = new DBTheCoffeeEntities())
            {
                try
                {
                    _db.Entry(categoria).State = EntityState.Modified;
                    _db.SaveChanges();               
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar la categoria.", ex);
                }
            }
        }

        public void Delete(int id)
        {
            using (_db = new DBTheCoffeeEntities())
            {
                try
                {
                     var categoria = _db.Categoria1.Find(id);
                     if (categoria != null)
                     {
                        categoria.estado = !categoria.estado;
                        _db.SaveChanges();
                     }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar la categoria.", ex);
                }
            }

        }

        public List<Categoria1> Search(String name)
        {
            using (_db = new DBTheCoffeeEntities())
            {
                return _db.Categoria1.Where(p =>
                p.descripcion.Contains(name) && p.estado == true).ToList();
            }
        }
        public bool existCategory(Categoria1 categoria)
        {
            using (_db = new DBTheCoffeeEntities())
            {
                return _db.Categoria1.Any(c => c.descripcion == categoria.descripcion && c.id_categoria != categoria.id_categoria); 
            }
        }
    }
}
