using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CDatos;
using System.Data.Entity;

namespace TheCoffe.CAccesoADatos
{
    class MesaRepository
    {
        private DBTheCoffeeEntities _db;
        public void Create(Mesa mesa)
        {
            using (_db = new DBTheCoffeeEntities())
            {
                try
                {
                    _db.Mesa.Add(mesa);
                    _db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear la mesa.", ex);
                }
            }
        }

        public async Task<List<Mesa>> Read(bool estado)
        {
            using (_db = new DBTheCoffeeEntities())
            {
                return await _db.Mesa.Where(m => m.estado == estado).OrderBy(m => m.nro_mesa).ToListAsync(); 
            }
        }

        public Mesa SearchObject(int id)
        {
            using (_db = new DBTheCoffeeEntities())
            {
                return _db.Mesa.Find(id);
            }
        }

        public void Update(Mesa mesa)
        {
            using (_db = new DBTheCoffeeEntities())
            {
                try
                {
                    _db.Entry(mesa).State = EntityState.Modified;
                    _db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar la mesa.", ex);
                }
            }
        }

        public void ChangeState(int id)
        {
            using (_db = new DBTheCoffeeEntities())
            {
                try
                {
                    var mesa = _db.Mesa.Find(id);
                    if (mesa != null)
                    {
                        mesa.estado = !mesa.estado;
                        _db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el estado de la mesa.", ex);
                }
            }
        }
        public Mesa ObtenerIdPorNro(int nroMesa)
        {
            using(_db = new DBTheCoffeeEntities())
            {
                return _db.Mesa.First(m => m.nro_mesa == nroMesa);
            }
        }
        public void ChangeDisponibility(int id)
        {
            using (_db = new DBTheCoffeeEntities())
            {
                try
                {
                    var mesa = _db.Mesa.Find(id);
                    if (mesa != null)
                    {
                        mesa.disponible = !mesa.disponible;
                        _db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el estado de la mesa.", ex);
                }
            }
        }
        public List<Mesa> Search(int nroMesa)
        {
            using (_db = new DBTheCoffeeEntities())
            {
                return _db.Mesa.Where(p =>
                p.nro_mesa == nroMesa && p.estado == true).ToList();
            }
        }
        public bool existTable(Mesa mesa)
        {
            using (_db = new DBTheCoffeeEntities())
            {
                return _db.Mesa.ToList().Any(m => m.nro_mesa == mesa.nro_mesa && m.id_mesa != mesa.id_mesa);
            }
        }
    }
}
