using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CDatos;
using System.Data.Entity;
using System.Data.SqlClient;
using TheCoffe.CNegocio.Services;

namespace TheCoffe.CAccesoADatos
{
    class CategoriaRepository
    {
        private DBTheCoffeeEntities _db;
        private OrderService orderService = new OrderService();
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
        public async Task<List<CategoriaEstadistica>> ObtenerVentasPorCategoria(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Venta> ventas = await orderService.FiltrarPorFecha(fechaDesde, fechaHasta);
            var idVentas = ventas.Select(v => v.id_ventas).ToList();
            using (_db = new DBTheCoffeeEntities())
            {
                var categoriasPopulares = await _db.Venta_Detalle
                    .Where(vd => idVentas.Contains(vd.id_ventas) && vd.Producto.Categoria1 != null)
                    .GroupBy(vd => vd.Producto.Categoria1.descripcion)
                    .Select(g => new CategoriaEstadistica
                    {
                        TotalPedidos = g.Count(),
                        Categoria = g.Key
                    })
                    .OrderByDescending(t => t.TotalPedidos)
                    .Take(3)
                    .ToListAsync();
                return categoriasPopulares;
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
        public async Task<List<Categoria1>> ObtenerCategoriasPopulares()
        {
            using (_db = new DBTheCoffeeEntities())
            {
                if(_db.Venta_Detalle.Count() > 3)
                {
                    return await _db.Venta_Detalle
                                .GroupBy(d => d.id_producto)
                                .Select(g => new
                                {
                                    ProductoId = g.Key,
                                    TotalVentas = g.Sum(d => d.cantidad)
                                })
                                .Join(_db.Producto,
                                      resultado => resultado.ProductoId,
                                      producto => producto.id_producto,
                                      (resultado, producto) => new
                                      {
                                          prod = producto,
                                          resultado.TotalVentas
                                      })
                                .Join(_db.Categoria1,
                                      p => p.prod.id_categoria,
                                      categoria => categoria.id_categoria,
                                      (productoConVentas, categoria) => new
                                      {
                                          ca = categoria,
                                          productoConVentas.TotalVentas
                                      })
                                      .GroupBy(c => c.ca.id_categoria)
                                        .Select(g => new
                                        {
                                            categoria = g.FirstOrDefault().ca,
                                            TotalVentasPorCategoria = g.Sum(x => x.TotalVentas)
                                        })
                                    .OrderByDescending(c => c.TotalVentasPorCategoria)
                                    .Select(c => c.categoria)
                                    .Where(c => c.estado)
                                    .Take(3)
                                    .OrderBy(c => c.descripcion)
                                    .ToListAsync();

                }
                else
                {
                    return await _db.Categoria1.Where(c => c.estado)
                   .OrderBy(c => c.descripcion)
                   .ToListAsync();
                }
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
