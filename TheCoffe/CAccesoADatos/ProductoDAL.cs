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
    class ProductoDAL
    {
        DBTheCoffeeEntities db;

        public void Create(Producto producto)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    db.Producto.Add(producto);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public List<Producto> Read(bool estado)
        {
            using (db = new DBTheCoffeeEntities())
            {
                return db.Producto.Include(p => p.Categoria1)
                    .Where(p => p.estado == estado)
                    .ToList();
            }
        }

       /* public List<Producto> Read(bool estado)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    return db.Producto.Where(c => c.estado == estado).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        } */

        public Producto SearchObject(int id)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    return db.Producto.Find(id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void Update(Producto producto)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    db.Entry(producto).State = EntityState.Modified;
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
                    var producto = db.Producto.Find(id);
                    if (producto != null)
                    {
                        if (producto.estado == false)
                        {
                            producto.estado = true;
                        }
                        else
                        {
                            producto.estado = false;
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

        public List<Producto> Search(String name)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    return db.Producto.Where(p =>
                    p.nombre.Contains(name) && p.estado == false).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Categoria1> listCategories()
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    return (from lst in db.Categoria1
                            where lst.estado == false
                            select lst).ToList();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
