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
    class MesaDAL
    {
        DBTheCoffeeEntities db;

        public void Create(Mesa mesa)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    db.Mesa.Add(mesa);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Mesa> Read(bool estado)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    return db.Mesa.Where(c => c.estado == estado).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public Mesa SearchObject(int id)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    return db.Mesa.Find(id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void Update(Mesa mesa)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    db.Entry(mesa).State = EntityState.Modified;
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
                    var mesa = db.Mesa.Find(id);
                    if (mesa != null)
                    {
                        if (mesa.estado == false)
                        {
                            mesa.estado = true;
                        }
                        else
                        {
                            mesa.estado = false;
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

        public List<Mesa> Search(int nroMesa)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    return db.Mesa.Where(p =>
                     p.nro_mesa == nroMesa && p.estado == false).ToList();
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
