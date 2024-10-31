using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.CDatos;

namespace TheCoffe.CAccesoADatos
{
    class PedidoDetalleRepository
    {
        DBTheCoffeeEntities db;

        public void Create(Venta_Detalle detalle)
        {
            using (db = new DBTheCoffeeEntities())
            {
                try
                {
                    db.Venta_Detalle.Add(detalle);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear la venta.", ex);
                }
            }
        }

        public async Task<List<Venta_Detalle>> Read()
        {
            using (db = new DBTheCoffeeEntities())
            {
                return await db.Venta_Detalle
                    .Include(v => v.Producto)
                    .OrderBy(v => v.Producto.nombre)
                    .ToListAsync();
            }
        }
        public void EliminarDetalle(Venta_Detalle detalle)
        {
            using (db = new DBTheCoffeeEntities())
            {
                Venta_Detalle d = db.Venta_Detalle.Find(detalle.id_detalle);
                try
                {
                    db.Venta_Detalle.Remove(d);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex.InnerException;
                }
            }
        }
        public Venta_Detalle SearchObject(int id)
        {
            using (db = new DBTheCoffeeEntities())
            {
                return db.Venta_Detalle.Find(id);
            }
        }
        public Venta_Detalle GetLastRecord()
        {
            using (db = new DBTheCoffeeEntities())
            {
                return db.Venta_Detalle.OrderByDescending(d => d.id_detalle).First();
            }
        }
        public void Update(Venta_Detalle detalle)
        {
            using (db = new DBTheCoffeeEntities())
            {
                try
                {
                    db.Entry(detalle).State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar la venta.", ex);
                }
            }
        }
        public Venta_Detalle ObtenerDetalle(int idVenta, int idProducto)
        {
            using (db = new DBTheCoffeeEntities())
            {
                return db.Venta_Detalle
                     .FirstOrDefault(d => d.id_ventas == idVenta && d.id_producto == idProducto);
            }
        }
    }
}
