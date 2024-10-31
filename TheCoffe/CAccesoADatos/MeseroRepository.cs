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
    class MeseroRepository
    {
        private DBTheCoffeeEntities db;
        public MeseroRepository()
        {
            db = new DBTheCoffeeEntities();
        }
        public void Create(Mesero mesero, List<int> diasDeTrabajo)
        {
                try
                {
                    var dias = db.DiaDeTrabajo
                        .Where(d => diasDeTrabajo.Contains(d.id_dia))
                        .ToList();
                    mesero.DiaDeTrabajo = dias;
                    db.Mesero.Add(mesero);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear el mesero.", ex);
                }
        }

        public async Task<List<Mesero>> Read(bool estado)
        {
                return await db.Mesero.Where(c => c.estado == estado).OrderBy(m => m.nombre).ToListAsync();
        }
        public async Task<List<Mesero>> FindAll()
        {
            return await db.Mesero.OrderBy(m => m.nombre).ToListAsync();
        }
        public async Task<List<Mesero>> ObtenerMeserosTrabajando()
        {
            var horaActual = DateTime.Now.Hour;
            int dia = ((int)DateTime.Now.DayOfWeek == 0) ? 7 : (int)DateTime.Now.DayOfWeek;
            return await db.Mesero.Where(mesero =>
            mesero.DiaDeTrabajo.Any(d => d.id_dia == dia) &&
            mesero.hora_entrada <= horaActual &&
            mesero.hora_salida >= horaActual && mesero.estado
            ).ToListAsync();
        }
        public Mesero SearchObject(int id)
        {
            return db.Mesero.Find(id);
        }
        public void Update(Mesero mesero, List<int> diasDeTrabajo)
        {
               try {
                    var dias = db.DiaDeTrabajo
                        .Where(d => diasDeTrabajo.Contains(d.id_dia))
                        .ToList();
                    mesero.DiaDeTrabajo = dias;
                    db.Entry(mesero).State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el mesero.", ex);
                }
        }
        public void ChangeState(int id)
        {
                try
                {
                    var mesero = db.Mesero.Find(id);
                    if (mesero != null)
                    {
                        mesero.estado = !mesero.estado;
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el estado del mesero.", ex);
                }
        }

        public List<Mesero> Search(String name)
        {
                return db.Mesero.Where(p =>
                p.nombre.Contains(name) && p.estado == true).ToList();
        }

        public bool ExistDNI(Mesero mesero)
        {
                return db.Mesero.ToList().Any(m => m.dni == mesero.dni && m.id_mesero != mesero.id_mesero);
        }
        public bool ExistPhone(Mesero mesero)
        {
                return db.Mesero.ToList().Any(m => m.telefono == mesero.telefono && m.id_mesero != mesero.id_mesero);
        }
    }
}
