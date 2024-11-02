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
    class UsuarioRepository
    {
        DBTheCoffeeEntities db;

        public void Create(Usuario usuario)
        {
            using (db = new DBTheCoffeeEntities())
            {
                try
                {          
                    db.Usuario.Add(usuario);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear el usuario.", ex);
                }
            }
        }


        public async Task<List<Usuario>> Read(bool estado)
        {
            using (db = new DBTheCoffeeEntities())
            {
                return await db.Usuario.Include(p => p.rol_usuario)
                    .Where(p => p.estado == estado)
                    .OrderBy(u => u.nombre)
                    .ToListAsync();
            }
        }

        public Usuario SearchObject(int id)
        {
                using (db = new DBTheCoffeeEntities())
                {
                    return db.Usuario.Find(id);
                }
        }
        public Usuario SearchByUsername(string nombreUsuario)
        {
            using (db = new DBTheCoffeeEntities())
            {
                try
                {
                    return db.Usuario.Include(u => u.rol_usuario).SingleOrDefault(u => u.usuario1 == nombreUsuario && u.estado);
                }catch(Exception ex)
                {
                    throw ex.InnerException;
                }
            }
        }
        public void Update(Usuario usuario)
        {
                using (db = new DBTheCoffeeEntities())
                {
                    try
                    {
                        db.Entry(usuario).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                    throw new Exception("Error al actualizar el usuario.", ex);
                    }
                }
        }

        public void ChangeState(int id)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    var usuario = db.Usuario.Find(id);
                    if (usuario != null)
                    {
                        usuario.estado = !usuario.estado;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el estado del usuario.", ex);
            }
        }

        public List<Usuario> Search(String name)
        {
                using (db = new DBTheCoffeeEntities())
                {
                    return db.Usuario.Where(p =>
                    p.nombre.Contains(name) && p.estado == true).ToList();
                }
        }

        public async Task<List<rol_usuario>> listRoles()
        {
                using (db = new DBTheCoffeeEntities())
                {
                    return await db.rol_usuario.ToListAsync();
                }
        }
        public bool ExistUser(Usuario usuario)
        {
            using (db = new DBTheCoffeeEntities())
            {
                return db.Usuario.ToList().Any(u => u.usuario1 == usuario.usuario1 && u.id_usuario != usuario.id_usuario);
            }
        }
        public bool ExistPhone(Usuario usuario)
        {
            using (db = new DBTheCoffeeEntities())
            {
                return db.Usuario.ToList().Any(u => u.telefono == usuario.telefono && u.id_usuario != usuario.id_usuario);
            }
        }
    }
}
