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
    class Categoria1DAL
    {
        DBTheCoffeeEntities db;

        public bool Create(Categoria1 categoria)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    db.Categoria1.Add(categoria);
                    db.SaveChanges();
                }
                return true;
            }
            catch(Exception ex)
            {
                
                return false;
            }
        }

        public List<Categoria1> Read(bool estado)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    return db.Categoria1.Where(c => c.estado == estado).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public Categoria1 SearchObject(int id)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    return db.Categoria1.Find(id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void Update(Categoria1 categoria)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    db.Entry(categoria).State = EntityState.Modified;
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
                    var categoria = db.Categoria1.Find(id);
                    if (categoria != null)
                    {
                        if (categoria.estado == false)
                        {
                            categoria.estado = true;
                        }
                        else
                        {
                            categoria.estado = false;
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

        public List<Categoria1> Search(String name)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    return db.Categoria1.Where(p =>
                    p.descripcion.Contains(name) && p.estado == false).ToList();
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
