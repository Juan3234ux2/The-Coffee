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
    class MeseroDAL
    {
        DBTheCoffeeEntities db;

        public void Create(Mesero mesero)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    db.Mesero.Add(mesero);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Mesero> Read(bool estado)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    return db.Mesero.Where(c => c.estado == estado).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public Mesero SearchObject(int id)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    return db.Mesero.Find(id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void Update(Mesero mesero)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    db.Entry(mesero).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    var mesero = db.Mesero.Find(id);
                    if (mesero != null)
                    {
                        if (mesero.estado == false)
                        {
                            mesero.estado = true;
                        }
                        else
                        {
                            mesero.estado = false;
                        }
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Mesero> Search(String name)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    return db.Mesero.Where(p =>
                    p.nombre.Contains(name) && p.estado == false).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
