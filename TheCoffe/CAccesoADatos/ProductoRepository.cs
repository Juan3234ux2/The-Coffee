using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TheCoffe.CDatos;

namespace TheCoffe.CAccesoADatos
{
    class ProductoRepository
    {
        DBTheCoffeeEntities db;

        public void Create(Producto producto)
        {
            using (db = new DBTheCoffeeEntities())
            {
                try
                {
                        db.Producto.Add(producto);
                        db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear el producto.", ex);
                }
            }
        }       

        public async Task<List<Producto>> Read(bool estado)
        {
            using (db = new DBTheCoffeeEntities())
            {
                return await db.Producto.Include(p => p.Categoria1)
                    .Where(p => p.estado == estado)
                    .ToListAsync();
            }
        }


        public Producto SearchObject(int id)
        {
                using (db = new DBTheCoffeeEntities())
                {
                    return db.Producto.Find(id);
                }
        }

        public void Update(Producto producto)
        {
            using (db = new DBTheCoffeeEntities())
            {
                try
                {
                        db.Entry(producto).State = EntityState.Modified;
                        db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el producto.", ex);
                }
            }
        }

        public void ChangeState(int id)
        {
            using (db = new DBTheCoffeeEntities())
            {
                try
                {
                    var producto = db.Producto.Find(id);
                    producto.estado = !producto.estado;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el estado del producto.", ex);
                }
            }
        }

        public List<Producto> Search(String name)
        {
                using (db = new DBTheCoffeeEntities())
                {
                    return db.Producto.Where(p =>
                    p.nombre.Contains(name) && p.estado == false).ToList();
                }
        }
        public bool ExistProduct(Producto producto)
        {
            using (db = new DBTheCoffeeEntities())
            {
                return db.Producto.ToList().Any(p => p.nombre == producto.nombre && p.id_producto != producto.id_producto);
            }
        }
    }
}
