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
    class UsuarioDAL
    {
        DBTheCoffeeEntities db;

        public void Create(Usuario usuario)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    db.Usuario.Add(usuario);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public List<Usuario> Read(bool estado)
        {
            using (db = new DBTheCoffeeEntities())
            {
                return db.Usuario.Include(p => p.rol_usuario)
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

        public Usuario SearchObject(int id)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    return db.Usuario.Find(id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void Update(Usuario usuario)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    db.Entry(usuario).State = EntityState.Modified;
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
                    var usuario = db.Usuario.Find(id);
                    if (usuario != null)
                    {
                        if (usuario.estado == false)
                        {
                            usuario.estado = true;
                        }
                        else
                        {
                            usuario.estado = false;
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

        public List<Usuario> Search(String name)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    return db.Usuario.Where(p =>
                    p.nombre.Contains(name) && p.estado == false).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<rol_usuario> listRoles()
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    return (from lst in db.rol_usuario
                            where lst.estado == true
                            select lst).ToList();
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
