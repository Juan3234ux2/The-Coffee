using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CDatos;

namespace TheCoffe.CAccesoADatos
{
    class ClienteRepository
    {
        private DBTheCoffeeEntities _db;

        public void Create(Cliente cliente)
        {
            using (_db = new DBTheCoffeeEntities())
            {
                try
                {
                    _db.Cliente.Add(cliente);
                    _db.SaveChanges();    
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear el cliente.", ex);
                }
            }
        }

        public List<Cliente> Read()
        {
            using (_db = new DBTheCoffeeEntities())
            {
                 return _db.Cliente.ToList();    
            }
        }
        public bool ExistCUIT(Cliente cliente)
        {
            using (_db = new DBTheCoffeeEntities())
            {
                return _db.Cliente.ToList().Any(c => c.cuit == cliente.cuit && c.id_cliente != cliente.id_cliente); 
            }
        }
        public bool ExistEmail(Cliente cliente)
        {
            using (_db = new DBTheCoffeeEntities())
            {
                return _db.Cliente.ToList().Any(c => c.email == cliente.email && c.id_cliente != cliente.id_cliente);
            }
        }
    }
}
