﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.CDatos;

namespace TheCoffe.CAccesoADatos
{
    class PedidoRepository
    {
        DBTheCoffeeEntities db;

        public void Create(Venta venta)
        {
            using (db = new DBTheCoffeeEntities())
            {
                try
                {
                    db.Venta.Add(venta);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear la venta.", ex);
                }
            }
        }

        public async Task<List<Venta>> ObtenerVentasDeTurno(int id_turno)
        {
            using (var db = new DBTheCoffeeEntities())
            {
                return await db.Venta
                              .Where(v => v.id_turno == id_turno && v.estado == "Completado")
                              .ToListAsync();
            }
        }
        public async Task<Venta> ObtenerVentaPorMesa(int idMesa)
        {
            using (var db = new DBTheCoffeeEntities())
            {
                return await db.Venta
                    .Include(v => v.Venta_Detalle)
                    .Include(v => v.Mesero)
                    .Where(v => v.id_mesa == idMesa && v.estado == "En Preparacion")
                    .FirstOrDefaultAsync();
            }
        }
        public async Task<List<Venta>> Read(string estado)
        {
            using (db = new DBTheCoffeeEntities())
            {
                return await db.Venta.Include(v => v.Venta_Detalle)
                    .Where(v => v.estado == estado)
                    .OrderBy(v => v.fecha_venta)
                    .ToListAsync();
            }
        }
        public async Task<List<Venta>> FindAll()
        {
            using (db = new DBTheCoffeeEntities())
            {
                return await db.Venta.Include(v => v.Venta_Detalle)               
                    .OrderBy(v => v.fecha_venta)
                    .ToListAsync();
            }
        }
        public Venta SearchObject(int id)
        {
            using (db = new DBTheCoffeeEntities())
            {
                return db.Venta.Find(id);
            }
        }
        public void Update(Venta venta)
        {
            using (db = new DBTheCoffeeEntities())
            {
                try
                {
                    db.Entry(venta).State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar la venta.", ex);
                }
            }
        }
        public void ChangeState(int id, string estado)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    var venta = db.Venta.Find(id);
                    if (venta != null)
                    {
                        venta.estado = estado;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el estado del venta.", ex);
            }
        }
    }
}
