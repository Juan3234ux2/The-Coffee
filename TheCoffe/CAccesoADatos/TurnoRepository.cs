using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.CDatos;

namespace TheCoffe.CAccesoADatos
{
    class TurnoRepository
    {
        DBTheCoffeeEntities db;

        public void Create(Turno_Caja turno)
        {
            using (db = new DBTheCoffeeEntities())
            {
                try
                {
                    db.Turno_Caja.Add(turno);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear el turno.", ex);
                }
            }
        }


        public async Task<List<Turno_Caja>> Read(bool estado)
        {
            using (db = new DBTheCoffeeEntities())
            {
                return await db.Turno_Caja.Include(p => p.Usuario).ToListAsync();
            }
        }

        public Turno_Caja SearchObject(int id)
        {
            using (db = new DBTheCoffeeEntities())
            {
                return db.Turno_Caja.Find(id);
            }
        }       
        public void Update(Turno_Caja turno)
        {
            using (db = new DBTheCoffeeEntities())
            {
                try
                {
                    db.Entry(turno).State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el turno.", ex);
                }
            }
        }

        public List<Turno_Caja> Search(String name)
        {
            using (db = new DBTheCoffeeEntities())
            {
                return db.Turno_Caja.Where(p =>
                p.Usuario.nombreCompleto.Contains(name)).ToList();
            }
        }

        public async Task<List<Turno_Caja>> FiltrarPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            using (db = new DBTheCoffeeEntities())
            {
                return await db.Turno_Caja
                    .Include(t => t.Usuario)
                    .Where(t =>  t.fecha_cierre >= fechaDesde && t.fecha_cierre <= fechaHasta)
                    .OrderByDescending(t => t.fecha_cierre)
                    .ToListAsync();
            }
        }
    }
}
