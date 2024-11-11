using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TheCoffe.CDatos;
using TheCoffe.CDatos.Estadisticas;

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

        public async Task<List<Producto>> GetProductsByCategory(string categoryName)
        {
            using (db = new DBTheCoffeeEntities())
            {
                return await db.Producto.Include(p => p.Categoria1)
                    .Where(p => p.estado && p.Categoria1.descripcion == categoryName)
                    .ToListAsync();
            }
        }
        public async Task<List<Producto>> ObtenerProductosPopulares()
        {
            using (db = new DBTheCoffeeEntities())
            {
                if (db.Venta_Detalle.Count() > 8)
                {
                    return await db.Venta_Detalle
                            .GroupBy(d => d.id_producto)
                            .Select(g => new
                            {
                                ProductoId = g.Key,
                                TotalVentas = g.Sum(d => d.cantidad) 
                            })
                            .Join(db.Producto,
                                  resultado => resultado.ProductoId,
                                  producto => producto.id_producto,
                                  (resultado, producto) => new 
                                  {
                                      p = producto,
                                      resultado.TotalVentas
                                  })
                            .OrderByDescending(p => p.TotalVentas)
                            .Select(p => p.p)
                            .Where(p => p.estado)
                            .Take(9)
                            .OrderBy(p => p.nombre)
                            .ToListAsync();
                }
                else
                {
                    return await db.Producto
                    .Where(p => p.estado)
                    .Take(9)
                    .OrderBy(p => p.nombre)
                    .ToListAsync();
                }
            }
        }
        public async Task<List<ProductosEstadistica>> ObtenerEstadisticaProductos()
            {
            using (db = new DBTheCoffeeEntities())
            {
                    return await db.Venta_Detalle
                            .GroupBy(d => d.id_producto)
                            .Select(g => new
                            {
                                ProductoId = g.Key,
                                TotalVentas = g.Sum(d => d.cantidad) 
                            })
                            .Join(db.Producto,
                                  resultado => resultado.ProductoId,
                                  producto => producto.id_producto,
                                  (resultado, producto) => new ProductosEstadistica
                                  {
                                      Producto = producto.nombre,
                                      TotalPedidos = resultado.TotalVentas
                                  })
                            .OrderByDescending(p => p.TotalPedidos)
                            .Take(3)
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
                    return db.Producto.Include(p => p.Categoria1)
                    .Where(p =>
                    p.nombre.Contains(name) && p.estado == true).ToList();
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
