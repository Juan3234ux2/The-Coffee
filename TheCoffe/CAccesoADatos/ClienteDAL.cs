using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CDatos;

namespace TheCoffe.CAccesoADatos
{
    class ClienteDAL
    {
        DBTheCoffeeEntities db;

        public void Create(Cliente cliente)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    db.Cliente.Add(cliente);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Cliente> Read()
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    return db.Cliente.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    db.Categoria1.Remove(db.Categoria1.Single
                        (p => p.id_categoria == id));
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Cliente> Search(String name)
        {
            try
            {
                using (db = new DBTheCoffeeEntities())
                {
                    return db.Cliente.Where(p =>
                    p.nombre.Contains(name)).ToList();
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
